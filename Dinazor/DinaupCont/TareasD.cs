

/// #######################################################
/// #       En la carpeta hay un archivo  llamado         #
/// #     Leeme.md, leelo para entender este archivo..    #
/// #######################################################




using APID = DinaNETCore.APID;

namespace Dinazor.DinaupCont
{
    public class TareasD
    {






        const string EstadoID_TareasCompletadas = "f81df6a3-cc03-413a-847b-d0a9c5101dd2";
        const string EstadoID_TareasPendientes = "9fbf6a39-ee4d-4b92-8e5a-e61bdcac475e";
        const string EstadoID_TareasCanceladas = "8a36fd03-0262-4233-b7c7-81d006814a3e";






        //@++   --------------   LEER   --------------   
        /// <summary>
        /// Recibe las tareas asociadas al usuario que tiene la sesión iniciada.
        /// </summary>
        public static async Task<MiDinaup.InformesD.FuncionalidadD.APIMisTareasC> Leer_RecibirMisTareas(DinaupPage Pagina)
        {
            var R = new MiDinaup.InformesD.FuncionalidadD.APIMisTareasC();
            await R.ConsultarAsync(Pagina.Dinaup_Sesion , 1, 600);
            return R;
        }






        //@++   --------------   AGREGAR   --------------   

        /// <summary>
        /// Agrega una tarea asociado al usuario que tiene la sesión iniciada.
        /// </summary>
        public static async Task<APID.HTTPRespuestaAPIC_Formualario_GuardarC> Agregar_TareaMia_Async(DinaupPage Pagina, string NuevaTarea_Descripcion)
        {

            var Nueva = new MiDinaup.SeccionesD.TareasD.TareasC();
            Nueva.ReferenciaEmpleadoPrincipal = new APID.DinaupAPI_IdentificacionRegistroC(Pagina.Dinaup_Sesion.DinaupUsuario.DatosSesion.Usuarios.Item1, Pagina.Dinaup_Sesion.DinaupUsuario.DatosSesion.Usuarios.Item2);
            Nueva.TextoPrincipal = NuevaTarea_Descripcion;
            Nueva.InformacionAdicional = NuevaTarea_Descripcion;
            Nueva.Posicion  = (int)(DateTime.UtcNow- new DateTime(2022,1,1)).TotalSeconds ;
            Nueva.EvaluarEnAgenda = false;
            return  await MiDinaup.SeccionesD.TareasD.DatosGuardar_Async(Pagina.Dinaup_Sesion.DinaupUsuario, Nueva);


        }






        //@++   --------------   EDITAR   --------------   
        /// <summary>
        /// Edita de manera sencilla el estado de una tarea. 
        /// </summary>
        public static async Task<APID.HTTPRespuestaAPIC_Formualario_GuardarC> Editar_EstadoDeTarea_Async(DinaupPage Pagina, string TareaID, bool PonerComoCompletada)
        {

            var Edicion_Tarea = new APID.DinaupAPI_ImportacionProcesableC(TareaID);
            if (PonerComoCompletada)
                Edicion_Tarea.dinaup_listador_datos.Add(MiDinaup.SeccionesD.TareasD.TareasES.ReferenciaEstado, EstadoID_TareasCompletadas);
            else
                Edicion_Tarea.dinaup_listador_datos.Add(MiDinaup.SeccionesD.TareasD.TareasES.ReferenciaEstado, EstadoID_TareasPendientes);

            return await Pagina.Dinaup_Servidor.Conexion.Funcion_Importar_Ejecutar_Async(Pagina.Dinaup_Sesion.DinaupUsuario, MiDinaup.SeccionesD.TareasD.TareasES._SeccionID, Edicion_Tarea);

        }






        //@++   --------------   HERRAMIENTAS / UTILIDADES   --------------   
        /// <summary>
        /// Como dependiendo de la base de datos, pueden haber estados distintos.
        /// Se han puesto en constante los estados ID, utilizados en este ejemplo.
        /// Se utiliza esta función para realizar la comparación. 
        /// </summary>
        public static bool H_TareaCompletada(Guid TareaEstadoID)
        {
            return H_TareaCompletada(TareaEstadoID.ToString());
        }
        /// <summary>
        /// Como dependiendo de la base de datos, pueden haber estados distintos.
        /// Se han puesto en constante los estados ID, utilizados en este ejemplo.
        /// Se utiliza esta función para realizar la comparación. 
        /// </summary>
        public static bool H_TareaCompletada(string TareaEstadoID)
        {
            return (TareaEstadoID == EstadoID_TareasCompletadas);
        }









    }
}
