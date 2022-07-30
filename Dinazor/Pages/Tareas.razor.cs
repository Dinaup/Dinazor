using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using DinaNetCore;
using static DinaNetCore.ExtensionesM;
using Radzen;

namespace Dinazor.Pages
{
    public partial class Tareas
    {


        [Parameter]
        public string ID { get; set; }



        //@@  Listado 
        /// <summary>Listado de mis tareas. Sin eliminadadas, Sin Canceladas, Sin revisadas.  </summary>
        public MiDinaup.InformesD.FuncionalidadD.APIMisTareasC Datos_Listado_DeMisTareas = null;
        public bool MostrarEliminados = false;




        //@@  Formulario 
        /// <summary>Cuando esta variable está instanciada, se muestra el formulario de editar en lugar de la lista. </summary>
        public MiDinaup.SeccionesD.TareasD.TareasC Datos_Formulario_TareaEditando = null;
        public Task<APID.HTTPRespuestaAPIC_Formualario_GuardarC> Datos_Formulario_Guardando = null;





        async Task Formulario_Cancelar(EventArgs e)
        {
            Datos_Formulario_TareaEditando = null;
            Datos_Formulario_Guardando = null;
            this.ID = "";
            NavigationManager.NavigateTo($"/Tareas", false, true);
            ActualizarUI();
        }




        async Task Formulario_Guardar(EventArgs e)
        {
            if (Datos_Formulario_TareaEditando != null)
            {
                Datos_Formulario_Guardando = MiDinaup.SeccionesD.TareasD.DatosGuardar_Async(Dinaup_Sesion.DinaupUsuario, Datos_Formulario_TareaEditando);

            }

        }










        async Task AbrirTarea(MiDinaup.InformesD.FuncionalidadD.APIMisTareasC.APIMisTareas_FilaC _Tarea)
        {
            this.ID = _Tarea.ID.ToString();
            NavigationManager.NavigateTo($"/Tareas/{this.ID}", false, true);
            ActualizarUI();
        }




        async void Change_EstadoTarea_Async(bool? valor, MiDinaup.InformesD.FuncionalidadD.APIMisTareasC.APIMisTareas_FilaC Item)
        {
            BusyDialog("Procesando...");
            await Task.Delay(300);
            await DinaupCont.TareasD.Editar_EstadoDeTarea_Async(this, Item.ID.STR(), !DinaupCont.TareasD.H_TareaCompletada(Item.EstadoID));
            ActualizarUI();
            DialogService.Close();
        }

        private async void OnKeyUp_AgregarTarea(KeyboardEventArgs args)
        {
            if (args.Key == "enter" || args.Key == "Enter")
            {
                if (NuevaTarea_Descripcion == "")
                {
                    NotificationService.Notify(NotificationSeverity.Error, "Debe indiciar una descripción de Tarea.");
                    return;
                }

                if (NuevaTarea_Descripcion.Length < 3)
                {
                    NotificationService.Notify(NotificationSeverity.Error, "La descripción de la tarea es demasiado corta.");
                    return;
                }

                await DinaupCont.TareasD.Agregar_TareaMia_Async(this, NuevaTarea_Descripcion);
                NotificationService.Notify(NotificationSeverity.Success, "La tarea se ha agregado correctamente.");
                NuevaTarea_Descripcion = "";
                ActualizarUI();
            }
        }

        async void ActualizarUI()
        {


            if (this.ID.EsGUID() == false)
            {


                Datos_Listado_DeMisTareas = new();
                if (MostrarEliminados)
                {
                    // Muestra eliminados
                    Datos_Listado_DeMisTareas.Agregar_Filtro("eliminado", "=", "1");
                    //// Muestra todos, eliminados y no 
                    //Datos_ListaDeMisTareas.Agregar_Filtro("eliminado","<>", "3");
                }

                Datos_Listado_DeMisTareas.Agregar_Filtro(MiDinaup.SeccionesD.TareasD.TareasES.ReferenciaEmpleadoPrincipal, "=", Dinaup_Sesion.DinaupUsuario.DatosSesion.Usuarios.Item1.STR());
                await Datos_Listado_DeMisTareas.ConsultarAsync(Dinaup_Sesion.DinaupUsuario, 1, 200);
                this.StateHasChanged();


            } else {


                BusyDialog("Procesando...");
                await Task.Delay(300);

                var param_Tareas = new SeccionConsultaParametrosC(Dinaup_Servidor.Conexion , new string[] { "id", "=", this.ID.ToString() } );
                param_Tareas.dinaup_incluir_archivosid_galeria = true;
                var Tareas = await MiDinaup.SeccionesD.TareasD.ConsultarDatos_Async(param_Tareas);
                Datos_Formulario_TareaEditando = Tareas.FirstOrDefault();
                this.StateHasChanged();
                DialogService.Close();

            }

        }

        protected override Task OnInitializedAsync()
        {
            ActualizarUI();
            return base.OnInitializedAsync();
        }
    }
}