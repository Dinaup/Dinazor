
using Microsoft.AspNetCore.Components;
using static DinaNETCore.APID;
using Microsoft.JSInterop;
using Radzen;
using static DinaNETCore.ExtensionesM;


namespace Dinazor.Services
{
    public class DatosCacheC
    {




        public DinaNETCore.CacheableC<MiDinaup.InformesD.FuncionalidadD.APIArchivosC.APIArchivos_FilaC> Cache_Archivos = new();



        public bool CacheCargado = false;




       







        public DatosCacheC(DinaupConfiguracionC _DinaupService)
        {
            this.Conexion = _DinaupService.Conexion;
            Timer_ActualizadorCache = new();
            Timer_ActualizadorCache.AutoReset = true;
            Timer_ActualizadorCache.Interval = 30000;
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

            try{
                var NuevaInformacionDeArchivos = new MiDinaup.InformesD.FuncionalidadD.APIArchivosC();
                NuevaInformacionDeArchivos.Agregar_Filtro("fechaia", ">=", Cache_Archivos.MaxFecha);
                await NuevaInformacionDeArchivos.Consultar_SinSesion_Async(Conexion, 1, 1000000);
                Cache_Archivos.Actualizar(NuevaInformacionDeArchivos.FilasPorID, NuevaInformacionDeArchivos.MaxFechaIA);
            }
            catch
            {

            }
            this.CacheCargado = true;

        }





    }
}
