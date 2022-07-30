
using Microsoft.AspNetCore.Components;
using static DinaNetCore.APID;
using static DinaNetCore.ExtensionesM;
using Microsoft.JSInterop;
using Radzen;





//@@  Información 
//@ En este documento se cachea y se actualiza cierta información. 
//@ Esto es importante para evitar está haciendo muchas consultas al API De Dinaup. 
//@ Este caché es muy óptimo porque está en memoria. No importa tanto cuanta RAM consuma la aplicación.
//@ Hay 2 tipos de caché.
//@ Informes:  Este caché es ideal para grande volúmenes de datos, pues hasta se cachean en disco.
//@ Secciones: Este es ideal cuando son pocos datos y es útil sobretodo porque es fácil de implementar (ya que no requiere un informe) 




namespace Dinazor.Services
{
    public class DatosCacheC
    {


        public bool CacheCargado = false;



        //@@ CACHE - Secciones 
        //@ Importante utilizar la clase DicCD que es un diccionario concurrente  compatible con multihilo 
        public DicCD<Guid, MiDinaup.SeccionesD.EstadosDeTareasD.EstadosDeTareasC> Cache_EstadosDeTareas = new();
        public DicCD<Guid, MiDinaup.SeccionesD.TiposDeTareasV1D.TiposDeTareasV1C> Cache_TiposDeTareas = new();


        //@@ CACHE - Informes 
        public DinaNetCore.CacheableC<MiDinaup.InformesD.FuncionalidadD.APIArchivosC.APIArchivos_FilaC> Cache_Archivos = new();





        const int MSActualizacionCache = 30000;


        public DatosCacheC(DinaupConfiguracionC _DinaupService)
        {
            this.Conexion = _DinaupService.Conexion;
            Timer_ActualizadorCache = new();
            Timer_ActualizadorCache.AutoReset = true;
            Timer_ActualizadorCache.Interval = MSActualizacionCache;
            Timer_ActualizadorCache.Elapsed += TimerElapsed;
            Timer_ActualizadorCache.Enabled = true;
            Cache_Archivos.Iniciar("c:\\Dinazor\\Cache\\Archivos.data");
            /// Cargar desde archivos
            ActualizarDatos();

        }






        private ServidorDinaup_ConectorC Conexion;
        private System.Timers.Timer Timer_ActualizadorCache;
        private void TimerElapsed(object? source, System.Timers.ElapsedEventArgs e)
        {




            Timer_ActualizadorCache.Enabled = false;
            try
            {
                ActualizarDatos().Wait();
            }
            catch { }
            Timer_ActualizadorCache.Enabled = true;

        }




        public async Task ActualizarDatos()
        {


            if (Conexion.ConexionDisponible == false)
            {
                Timer_ActualizadorCache.Interval = 200;
                return;
            }




            if (Timer_ActualizadorCache.Interval != MSActualizacionCache)
            {
                Timer_ActualizadorCache.Interval = MSActualizacionCache;
            }



            var x = ActualizarCache_Informes();
            var x2 = ActualizarCache_Datos();
            await x;
            await x2;
            this.CacheCargado = (ActualizarDatos_Informes_Ok && ActualizarDatos_Seccion_Ok);


        }






        private DateTime ActualizarDatos_Informes_PosicionFechaIA = new DateTime(2000, 1, 1);
        private Boolean ActualizarDatos_Informes_Ok = false;
        private async Task ActualizarCache_Informes()
        {



            // -2 es un valor arbitrario que se utiliza como margen de seguridad
            // Se hace antes de que se inicie el proceso de consulta para evitar que este tarde mucho y afecte a los marcadores de posición.
            var ProximaFecha = DateTime.UtcNow.AddMinutes(-2);


            try
            {

                var NuevaInformacionDeArchivos = new MiDinaup.InformesD.FuncionalidadD.APIArchivosC();
                NuevaInformacionDeArchivos.Agregar_Filtro("fechaia", ">=", Max(Cache_Archivos.MaxFecha, ActualizarDatos_Informes_PosicionFechaIA));



                await NuevaInformacionDeArchivos.Consultar_SinSesion_Async(Conexion, 1, 1000000);

                Cache_Archivos.Actualizar(NuevaInformacionDeArchivos.FilasPorID, NuevaInformacionDeArchivos.MaxFechaIA);




                // Únicamente se establece la próxima fecha si no ha habido ningún error.
                ActualizarDatos_Informes_PosicionFechaIA = ProximaFecha;
                ActualizarDatos_Informes_Ok = true;

            }
            catch { }


        }








        private DateTime ActualizarDatos_Seccion_PosicionFechaIA = new DateTime(2000, 1, 1);
        private Boolean ActualizarDatos_Seccion_Ok = false;
        private async Task ActualizarCache_Datos()
        {






            // Esta expresión es compatible con TODAS las secciones.
            var ExpresionBusqueda = new string[] { "fechaia", ">", "'" + ActualizarDatos_Seccion_PosicionFechaIA.AdaptarMySQL() + "'" };


            // -2 es un valor arbitrario que se utiliza como margen de seguridad
            // Se hace antes de que se inicie el proceso de consulta para evitar que este tarde mucho y afecte a los marcadores de posición.
            var ProximaFecha = DateTime.UtcNow.AddMinutes(-2);


            try
            {

                // Se consulta con task 
                var Consulta_EstadosDeTareas = MiDinaup.SeccionesD.EstadosDeTareasD.ConsultarDatos_Async(new DinaNetCore.SeccionConsultaParametrosC(Conexion, ExpresionBusqueda));
                var Consulta_TiposDeTareas = MiDinaup.SeccionesD.TiposDeTareasV1D.ConsultarDatos_Async(new DinaNetCore.SeccionConsultaParametrosC(Conexion, ExpresionBusqueda));



                // Se espera a que se terminen de completar las tares
                await Consulta_EstadosDeTareas;
                await Consulta_TiposDeTareas;


                // Se actualizan los diccionarios concurrentes 
                Consulta_EstadosDeTareas.Result.ForEach((actual) => Cache_EstadosDeTareas.set_TryHacerMagia(actual.ID, actual));
                Consulta_TiposDeTareas.Result.ForEach((actual) => Cache_TiposDeTareas.set_TryHacerMagia(actual.ID, actual));



                // Únicamente se establece la próxima fecha si no ha habido ningún error.
                ActualizarDatos_Seccion_PosicionFechaIA = ProximaFecha;
                ActualizarDatos_Seccion_Ok = true;


            }
            catch { }


        }





    }
}
