



Para visualizar correctamente este archivo. 
Instale en visual studio la extensión https://marketplace.visualstudio.com/items?itemName=MadsKristensen.MarkdownEditor2



# Pages 
En este directorio van las páginas.
`/Tareas` `/Tareas/ID` `/MiPerfil`... \
Para el correcto funcionamiento deben hereda **DinaupPage** `@inherits DinaupPage`

## SE DEBE TENER MUY EN CUENTA
1. Cuando creas una nueva página se debe controlar los rate-limits.
1. Cuando creas una página se debe controlar si tiene acceso o no el usuario para verla.



## Orden 
1. Las primeras lineas están reservadas para las directivas @page @inherits....
    ```csharp
        @page "/Tareas"
        @page "/Tareas/{id}"
        @inherits DinaupPage
 
1. Después se creará un bloque `@code`  única y exclusivamente para capturar los parámetros si los ubiese 
    ```csharp
    @code {
    	[Parameter]
    	public string ID { get; set; }
    }

1. Variables utilizados en la vista. \
    En un bloque de @code separado y Utilizando el prefijo `Datos_` se definen las variables que almacenarán los datos que se van
    a renderizar en la vista.
    ```csharp
    @code {


      /// <summary>Listado de mis tareas. Sin eliminadadas, Sin Canceladas, Sin revisadas.  </summary>
	  public MiDinaup.InformesD.FuncionalidadD.APIMisTareasC Datos_ListaDeMisTareas = null;

      /// <summary>Cuando esta variable está instanciada, se muestra el formulario de editar en lugar de la lista. </summary>
      public MiDinaup.SeccionesD.TareasD.TareasC Datos_TareaEditando = null;

    }
1.  Renderización HTML \
    Aquí ya se procede a mostrar los datos en HTML ==COMPROBANDO NULOS Y PERMISOS==. \
    Ejemplo: 
    ```csharp
        @if ( Datos_TareaEditando != null)
        {
	        <span>Editando</span>
        }
        else if (Datos_ListaDeMisTareas != null && Datos_ListaDeMisTareas.DatosDisponibles)
        {
	        @foreach (var item in Datos_ListaDeMisTareas.Filas)
	        {
	           <span>@item.TextoPrincipal</span>
	        }
        }else{
	        <span>Cargando...</span>
        }

1. Acciones. En última posición se crea un @code si ne necesitan crear funciones.
    ```csharp
	    async void ActualizarUI()
	    {
		    await Datos_ListaDeMisTareas.ConsultarAsync(Dinaup_Sesion.DinaupUsuario, 1, 200);
		    this.StateHasChanged();
	    }


	    protected override Task OnInitializedAsync()
	    {
		    ActualizarUI();
		    return base.OnInitializedAsync();
	    }
