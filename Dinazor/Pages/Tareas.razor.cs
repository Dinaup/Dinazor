using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using DinaNETCore;
using static DinaNETCore.ExtensionesM;
using Radzen;

namespace Dinazor.Pages
{
    public partial class Tareas
    {


        [Parameter]
        public string ID { get; set; }


        /// <summary>Listado de mis tareas. Sin eliminadadas, Sin Canceladas, Sin revisadas.  </summary>
        public MiDinaup.InformesD.FuncionalidadD.APIMisTareasC Datos_ListaDeMisTareas = null;

        /// <summary>Cuando esta variable está instanciada, se muestra el formulario de editar en lugar de la lista. </summary>
        public MiDinaup.SeccionesD.TareasD.TareasC Datos_TareaEditando = null;





        public bool  MostrarEliminados = false;
        
        

        object RecibirArchivos()
        {
            return null;
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
            Datos_ListaDeMisTareas = new();
            if (MostrarEliminados)
            {
                // Muestra eliminados
                Datos_ListaDeMisTareas.Agregar_Filtro("eliminado", "=", "1");
               //// Muestra todos, eliminados y no 
               //Datos_ListaDeMisTareas.Agregar_Filtro("eliminado","<>", "3");
            }

            Datos_ListaDeMisTareas.Agregar_Filtro(MiDinaup.SeccionesD.TareasD.TareasES.ReferenciaEmpleadoPrincipal, "=", Dinaup_Sesion.DinaupUsuario.DatosSesion.Usuarios.Item1.STR());
            await Datos_ListaDeMisTareas.ConsultarAsync(Dinaup_Sesion.DinaupUsuario, 1, 200);
            this.StateHasChanged();
        }

        protected override Task OnInitializedAsync()
        {
            ActualizarUI();
            return base.OnInitializedAsync();
        }
    }
}