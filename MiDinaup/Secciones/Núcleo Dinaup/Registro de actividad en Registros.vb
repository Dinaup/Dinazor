   Imports System.ComponentModel
   Imports DinaNETCore
   Imports DinaNETCore.APID
Partial Public Class SeccionesD
  Public Class RegistroDeActividadEnRegistrosD
      Public Shared _SeccionID As String = "a4a4840b-d5c1-40d2-bf24-002d931982d8"
      Public Shared _SeccionIDGUID As New Guid("a4a4840b-d5c1-40d2-bf24-002d931982d8")
      Public Shared Async Function ConsultarDatos_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, ParamArray Valor As String()) As Task(Of List(Of RegistroDeActividadEnRegistrosC )) 
          Dim R As New List(Of RegistroDeActividadEnRegistrosC )  
          Dim d = Await DinaupSesion.ConexionServidor.Funcion_Datos_Recibir_Async(DinaupSesion, RegistroDeActividadEnRegistrosES._SeccionID, False, Campo, Valor) 
          If d.Datos.TieneDatos Then 
              For Each Actual In d.Datos 
                  Dim Valores_Listador = Actual.Value.Item1
                  Dim Obj_Listador As New RegistroDeActividadEnRegistrosC 
                  Obj_Listador.CargarDatos(Valores_Listador) 
                  R.Add(Obj_Listador) 
              Next 
          End If 
          Return R 
      End Function 
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As RegistroDeActividadEnRegistrosC, Optional CampoWhere$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Return Await DatosGuardar_Async(DinaupSesion, New List(Of RegistroDeActividadEnRegistrosC)({DAtos}), CampoWhere )
      End Function
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As List(Of RegistroDeActividadEnRegistrosC), Optional CampoWhere$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Dim Importar As New List(Of DinaupAPI_ImportacionProcesableC)
          For Each Actual In DAtos 
              Dim RegistroActual = New DinaupAPI_ImportacionProcesableC() 
               RegistroActual.dinaup_listador_datos = Actual.ToDic 
               Importar.Add(RegistroActual)  
          Next 
          Return Await DinaupSesion.ConexionServidor.Funcion_Importar_Ejecutar_Async(DinaupSesion, RegistroDeActividadEnRegistrosES._SeccionID, Importar, CampoWhere, "") 
      End Function
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As RegistroDeActividadEnRegistros_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, RegistroDeActividadEnRegistrosES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New RegistroDeActividadEnRegistros_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As RegistroDeActividadEnRegistros_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, RegistroDeActividadEnRegistrosES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New RegistroDeActividadEnRegistros_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class RegistroDeActividadEnRegistrosES
          Public shared _SeccionID as Guid = New Guid("a4a4840b-d5c1-40d2-bf24-002d931982d8")
          Public shared _Tabla$ = "tpr_407f801wc"
      Public Shared HaImprimido$ = "pr_40a64ccx59wc"
      Public Shared ReferenciaAutorDelAlta$ = "pr_146310243ex306wd"
      Public Shared ReferenciaPermisoPuntual$ = "pr_73b8379wd"
      Public Shared ReferenciaElemento$ = "pr_407fc81x1a3wc"
      Public Shared ReferenciaRegistroDeAccesoSesion$ = "pr_185b34608cx16bwd"
      Public Shared FechaDato_UTC$ = "pr_1463102482xbcwd"
      Public Shared ElementoNombre$ = "pr_47137adx73wc"
      Public Shared FechaAlta_UTC$ = "pr_14c9f3e26dg13bwd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_1464b59d72x51wd"
      Public Shared VecesFoco$ = "pr_407faadx2a4wc"
      Public Shared SegundosAbierto$ = "pr_407fa69x1e3wc"
      Public Shared SegundosActividad$ = "pr_407fa49x391wc"
      Public Shared ReferenciaSeccion$ = "pr_407fc0ex312wc"
      Public Shared FinalizacionInesperada$ = "pr_4d832fcx2fawc"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_1464b41092x328wd"
      Public Shared TipoDeAccion$ = "pr_7c20cf7wd"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_1464b410d0x38cwd"
      Public Shared TiempoEjecucion$ = "pr_4d83377x2a6wc"
      Public Shared ReferenciaDestinador$ = "pr_146310256ex24dwd"
      Public Shared HoraLocal$ = "pr_776aebawd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_146314ac52h261wd"
      Public Shared ReferenciaServidor$ = "pr_40040212261"
      Public Shared ID$ = "id"
      Public Shared TextoPrincipal$ = "nombre"
      Public Shared FechaAltaDato_UTC$ = "fecha"
      Public Shared FechaUltimaModificacion_UTC$ = "fecham"
      Public Shared Eliminado$ = "eliminado"
      Public Shared UsuarioCreadorDelDAto$ = "usuarioid"
      Public Shared Seccion$ = "plantillapid"
      Public Shared Posicion$ = "posicion"
      Public Shared Empresa$ = "ubicacion"
      Public Shared Modificado$ = "modificado"
      Public Shared FechaIndiceActividad_UTC$ = "fechaia"
      Public Shared Fechadesincronizacion_UTC$ = "fechasyn"
      End Class
      Public Class RegistroDeActividadEnRegistrosC
      Inherits Base_DatoC
          <DisplayName("Ha imprimido")>
          Public Property HaImprimido As Boolean
          Public Shared ___HaImprimido As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""HaImprimido"",""etiqueta"": ""Ha imprimido"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Ha imprimido"",""descripcion"": """",""keyword"": ""HaImprimido"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __HaImprimido As DinaNETCore.APID.DinaupAPI_CampoC = ___HaImprimido
          <DisplayName("Autor del alta")>
          Public Property ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaAutorDelAlta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaAutorDelAlta"",""etiqueta"": ""Autor del alta"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta"",""descripcion"": """",""keyword"": ""ReferenciaAutorDelAlta"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaAutorDelAlta
          <DisplayName("Permiso puntual")>
          Public Property ReferenciaPermisoPuntual As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaPermisoPuntual As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaPermisoPuntual"",""etiqueta"": ""Permiso puntual"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""d1737cfb-e597-46b1-b14f-d93493a1ad45"",""titulo"": ""Base - Permiso puntual a registros"",""iconoid"": ""ed925cd3-e57f-461a-9982-94b266bac032"",""etiquetasingular"": ""Permiso a registro"",""etiquetaplural"": ""Permisos a registro"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""d1737cfb-e597-46b1-b14f-d93493a1ad45"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Permiso puntual"",""descripcion"": """",""keyword"": ""ReferenciaPermisoPuntual"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaPermisoPuntual As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaPermisoPuntual
          <DisplayName("Elemento")>
          Public Property ReferenciaElemento As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaElemento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaElemento"",""etiqueta"": ""Elemento"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Elemento"",""descripcion"": """",""keyword"": ""ReferenciaElemento"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaElemento As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaElemento
          <DisplayName("Registro de Acceso (Sesión)")>
          Public Property ReferenciaRegistroDeAccesoSesion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaRegistroDeAccesoSesion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaRegistroDeAccesoSesion"",""etiqueta"": ""Registro de Acceso (Sesión)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c5250d97-16c1-420f-bd6b-94cf0216ea32"",""titulo"": ""Base - Registros de acceso a sistema"",""iconoid"": ""d601858e-c944-474a-9f6d-fa55326d6ef0"",""etiquetasingular"": ""Registro de acceso a sistema"",""etiquetaplural"": ""Registros de acceso a sistema"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""c5250d97-16c1-420f-bd6b-94cf0216ea32"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Registro de Acceso (Sesión)"",""descripcion"": """",""keyword"": ""ReferenciaRegistroDeAccesoSesion"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaRegistroDeAccesoSesion As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaRegistroDeAccesoSesion
          <DisplayName("Fecha Dato")>
          Public Property FechaDato_UTC As Date?
          Public Shared ___FechaDato_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaDato_UTC"",""etiqueta"": ""Fecha Dato"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Dato"",""descripcion"": """",""keyword"": ""FechaDato_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaDato_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaDato_UTC
          <DisplayName("Elemento nombre")>
          Public Property ElementoNombre As String
          Public Shared ___ElementoNombre As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ElementoNombre"",""etiqueta"": ""Elemento nombre"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Elemento nombre"",""descripcion"": """",""keyword"": ""ElementoNombre"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ElementoNombre As DinaNETCore.APID.DinaupAPI_CampoC = ___ElementoNombre
          <DisplayName("Fecha Alta del registro")>
          Public Property FechaAlta_UTC As Date?
          Public Shared ___FechaAlta_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaAlta_UTC"",""etiqueta"": ""Fecha Alta del registro"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Alta del registro"",""descripcion"": """",""keyword"": ""FechaAlta_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaAlta_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaAlta_UTC
          <DisplayName("Empleado Tiene Acceso web")>
          Public Property EmpleadoTieneAccesoWeb As Boolean
          Public Shared ___EmpleadoTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EmpleadoTieneAccesoWeb"",""etiqueta"": ""Empleado Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empleado Tiene Acceso web"",""descripcion"": """",""keyword"": ""EmpleadoTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EmpleadoTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___EmpleadoTieneAccesoWeb
          <DisplayName("Veces Foco")>
          Public Property VecesFoco As Integer
          Public Shared ___VecesFoco As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""VecesFoco"",""etiqueta"": ""Veces Foco"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Veces Foco"",""descripcion"": """",""keyword"": ""VecesFoco"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __VecesFoco As DinaNETCore.APID.DinaupAPI_CampoC = ___VecesFoco
          <DisplayName("Segundos Abierto")>
          Public Property SegundosAbierto As Integer
          Public Shared ___SegundosAbierto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""SegundosAbierto"",""etiqueta"": ""Segundos Abierto"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 33,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Segundos Abierto"",""descripcion"": """",""keyword"": ""SegundosAbierto"",""formato"": 2,""rol"": 33,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __SegundosAbierto As DinaNETCore.APID.DinaupAPI_CampoC = ___SegundosAbierto
          <DisplayName("Segundos actividad")>
          Public Property SegundosActividad As Integer
          Public Shared ___SegundosActividad As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""SegundosActividad"",""etiqueta"": ""Segundos actividad"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 33,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Segundos actividad"",""descripcion"": """",""keyword"": ""SegundosActividad"",""formato"": 2,""rol"": 33,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __SegundosActividad As DinaNETCore.APID.DinaupAPI_CampoC = ___SegundosActividad
          <DisplayName("Sección")>
          Public Property ReferenciaSeccion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaSeccion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaSeccion"",""etiqueta"": ""Sección"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""plantillasp"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Sección"",""descripcion"": """",""keyword"": ""ReferenciaSeccion"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaSeccion As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaSeccion
          <DisplayName("Finalización Inesperada")>
          Public Property FinalizacionInesperada As Boolean
          Public Shared ___FinalizacionInesperada As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FinalizacionInesperada"",""etiqueta"": ""Finalización Inesperada"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Finalización Inesperada"",""descripcion"": """",""keyword"": ""FinalizacionInesperada"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __FinalizacionInesperada As DinaNETCore.APID.DinaupAPI_CampoC = ___FinalizacionInesperada
          <DisplayName("Empleado")>
          Public Property ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaEmpleadoPrincipal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaEmpleadoPrincipal"",""etiqueta"": ""Empleado"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c6e071c7-776f-4300-aa55-c711fd1da916"",""titulo"": ""Empleados"",""iconoid"": ""1c8abf82-640c-4d18-b62c-89de310923dd"",""etiquetasingular"": ""Empleado"",""etiquetaplural"": ""Empleados"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""c6e071c7-776f-4300-aa55-c711fd1da916"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empleado"",""descripcion"": """",""keyword"": ""ReferenciaEmpleadoPrincipal"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaEmpleadoPrincipal
          <DisplayName("Tipo de acción")>
          Public Property TipoDeAccion As EnumRAPrincipalE
          Public Shared ___TipoDeAccion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TipoDeAccion"",""etiqueta"": ""Tipo de acción"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 42,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [0,1,2,3,4,5],""predefinidos_textos"": [""Indefinido"",""Agregar"",""Ver"",""Editar"",""No agregado"",""Contraseña Incorrecta""],""predefinidos_iconos"": [""https://cdn.dinaup.com/ico/enums/42_0.png"",""https://cdn.dinaup.com/ico/enums/42_1.png"",""https://cdn.dinaup.com/ico/enums/42_2.png"",""https://cdn.dinaup.com/ico/enums/42_3.png"",""https://cdn.dinaup.com/ico/enums/42_4.png"",""https://cdn.dinaup.com/ico/enums/42_5.png""],""filtro"": {""titulo"": ""Tipo de acción"",""descripcion"": """",""keyword"": ""TipoDeAccion"",""formato"": 2,""rol"": 42,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false,""enumeracion"": {""titulo"": ""Enum - R.A Principal"", ""valores"": [{""valor"": 0, ""titulo"": ""Indefinido""},{""valor"": 1, ""titulo"": ""Agregar""},{""valor"": 2, ""titulo"": ""Ver""},{""valor"": 3, ""titulo"": ""Editar""},{""valor"": 4, ""titulo"": ""No agregado""},{""valor"": 5, ""titulo"": ""Contraseña Incorrecta""}]}},""solovalorespredefinidos"": true}")
          Public  __TipoDeAccion As DinaNETCore.APID.DinaupAPI_CampoC = ___TipoDeAccion
          <DisplayName("Ubicación Principal")>
          Public Property ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaUbicacionPrincipal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaUbicacionPrincipal"",""etiqueta"": ""Ubicación Principal"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""b9adbfbf-a81a-45fb-861c-90502902c982"",""titulo"": ""Ubicaciones"",""iconoid"": ""b985b58f-7275-46b8-9b66-2c54346b0185"",""etiquetasingular"": ""Ubicación"",""etiquetaplural"": ""Ubicaciones"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""b9adbfbf-a81a-45fb-861c-90502902c982"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Ubicación Principal"",""descripcion"": """",""keyword"": ""ReferenciaUbicacionPrincipal"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaUbicacionPrincipal
          <Description("Cuando se agrega o modifica un registro, se muestra aquí el tiempo en segundos que ha tardado el servidor en completar la acción.")>
          <DisplayName("Tiempo Ejecución")>
          Public Property TiempoEjecucion As Decimal
          Public Shared ___TiempoEjecucion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TiempoEjecucion"",""etiqueta"": ""Tiempo Ejecución"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 33,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Tiempo Ejecución"",""descripcion"": """",""keyword"": ""TiempoEjecucion"",""formato"": 3,""rol"": 33,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __TiempoEjecucion As DinaNETCore.APID.DinaupAPI_CampoC = ___TiempoEjecucion
          <DisplayName("Destinador")>
          Public Property ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaDestinador As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaDestinador"",""etiqueta"": ""Destinador"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""relacionesindirectas"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Destinador"",""descripcion"": """",""keyword"": ""ReferenciaDestinador"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaDestinador
          <DisplayName("Hora local")>
          Public Property HoraLocal As DateTime?
          Public Shared ___HoraLocal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""HoraLocal"",""etiqueta"": ""Hora local"",""oculta"": false,""formato"": 8,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Hora local"",""descripcion"": """",""keyword"": ""HoraLocal"",""formato"": 8,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __HoraLocal As DinaNETCore.APID.DinaupAPI_CampoC = ___HoraLocal
          <DisplayName("Autor del alta Tiene Acceso web")>
          Public Property AutorDelAltaTieneAccesoWeb As Boolean
          Public Shared ___AutorDelAltaTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AutorDelAltaTieneAccesoWeb"",""etiqueta"": ""Autor del alta Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta Tiene Acceso web"",""descripcion"": """",""keyword"": ""AutorDelAltaTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AutorDelAltaTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___AutorDelAltaTieneAccesoWeb
          <DisplayName("Servidor")>
          Public Property ReferenciaServidor As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaServidor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaServidor"",""etiqueta"": ""Servidor"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""eadd8f25-d9e0-46ef-89a7-e95efe769df1"",""titulo"": ""Base - Servidores"",""iconoid"": ""35aab678-4c97-4349-9cad-b4e5b4d301a3"",""etiquetasingular"": ""Servidor"",""etiquetaplural"": ""Servidores"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""eadd8f25-d9e0-46ef-89a7-e95efe769df1"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Servidor"",""descripcion"": """",""keyword"": ""ReferenciaServidor"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaServidor As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaServidor
          <ReadOnlyAttribute(True)>
          <DisplayName("ID")>
          Public Property ID As Guid
          Public Shared ___ID As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": true,""eseliminado"": false,""keyword"": ""ID"",""etiqueta"": ""ID"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""a4a4840b-d5c1-40d2-bf24-002d931982d8"",""titulo"": ""Registro de actividad en Registros"",""iconoid"": ""9c537a5f-3346-419d-8d67-2f4bdd9f65d7"",""etiquetasingular"": ""Registro de actividad en registro"",""etiquetaplural"": ""Registros de actividad en registros"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""a4a4840b-d5c1-40d2-bf24-002d931982d8"",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""ID"",""descripcion"": """",""keyword"": ""ID"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ID As DinaNETCore.APID.DinaupAPI_CampoC = ___ID
          <DisplayName("Referencia")>
          Public Property TextoPrincipal As String
          Public Shared ___TextoPrincipal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TextoPrincipal"",""etiqueta"": ""Referencia"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Referencia"",""descripcion"": """",""keyword"": ""TextoPrincipal"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __TextoPrincipal As DinaNETCore.APID.DinaupAPI_CampoC = ___TextoPrincipal
          <ReadOnlyAttribute(True)>
          <DisplayName("Fecha Alta Dato")>
          Public Property FechaAltaDato_UTC As Date
          Public Shared ___FechaAltaDato_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaAltaDato_UTC"",""etiqueta"": ""Fecha Alta Dato"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Alta Dato"",""descripcion"": """",""keyword"": ""FechaAltaDato_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaAltaDato_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaAltaDato_UTC
          <ReadOnlyAttribute(True)>
          <DisplayName("Editado")>
          Public Property FechaUltimaModificacion_UTC As Date
          Public Shared ___FechaUltimaModificacion_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaUltimaModificacion_UTC"",""etiqueta"": ""Editado"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Editado"",""descripcion"": """",""keyword"": ""FechaUltimaModificacion_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaUltimaModificacion_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaUltimaModificacion_UTC
          <ReadOnlyAttribute(True)>
          <DisplayName("Eliminado")>
          Public Property Eliminado As Boolean
          Public Shared ___Eliminado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": true,""keyword"": ""Eliminado"",""etiqueta"": ""Eliminado"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Eliminado"",""descripcion"": """",""keyword"": ""Eliminado"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Eliminado As DinaNETCore.APID.DinaupAPI_CampoC = ___Eliminado
          <ReadOnlyAttribute(True)>
          <DisplayName("Usuario Creador del dato")>
          Public Property UsuarioCreadorDelDAto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___UsuarioCreadorDelDAto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""UsuarioCreadorDelDAto"",""etiqueta"": ""Usuario Creador del dato"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Usuario Creador del dato"",""descripcion"": """",""keyword"": ""UsuarioCreadorDelDAto"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __UsuarioCreadorDelDAto As DinaNETCore.APID.DinaupAPI_CampoC = ___UsuarioCreadorDelDAto
          <DisplayName("Sección (Relación Sistema)")>
          Public Property Seccion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___Seccion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Seccion"",""etiqueta"": ""Sección (Relación Sistema)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""plantillasp"",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Sección (Relación Sistema)"",""descripcion"": """",""keyword"": ""Seccion"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Seccion As DinaNETCore.APID.DinaupAPI_CampoC = ___Seccion
          <DisplayName("Posición (Orden)")>
          Public Property Posicion As Decimal
          Public Shared ___Posicion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Posicion"",""etiqueta"": ""Posición (Orden)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Posición (Orden)"",""descripcion"": """",""keyword"": ""Posicion"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Posicion As DinaNETCore.APID.DinaupAPI_CampoC = ___Posicion
          <ReadOnlyAttribute(True)>
          <DisplayName("Empresa")>
          Public Property Empresa As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___Empresa As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Empresa"",""etiqueta"": ""Empresa"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""8bcba7c2-11b2-4f81-a7a7-35f65de8aa51"",""titulo"": ""Empresas administradas"",""iconoid"": ""b788149e-1c15-4807-9a25-72adf3333e5b"",""etiquetasingular"": ""Empresa administrada"",""etiquetaplural"": ""Empresas administradas"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""8bcba7c2-11b2-4f81-a7a7-35f65de8aa51"",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empresa"",""descripcion"": """",""keyword"": ""Empresa"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Empresa As DinaNETCore.APID.DinaupAPI_CampoC = ___Empresa
          <ReadOnlyAttribute(True)>
          <DisplayName("Modificado")>
          Public Property Modificado As Boolean
          Public Shared ___Modificado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Modificado"",""etiqueta"": ""Modificado"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Modificado"",""descripcion"": """",""keyword"": ""Modificado"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Modificado As DinaNETCore.APID.DinaupAPI_CampoC = ___Modificado
          <ReadOnlyAttribute(True)>
          <DisplayName("Fecha Indice Actividad")>
          Public Property FechaIndiceActividad_UTC As Date
          Public Shared ___FechaIndiceActividad_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaIndiceActividad_UTC"",""etiqueta"": ""Fecha Indice Actividad"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Indice Actividad"",""descripcion"": """",""keyword"": ""FechaIndiceActividad_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaIndiceActividad_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaIndiceActividad_UTC
          <ReadOnlyAttribute(True)>
          <DisplayName("Fecha de Sincronización")>
          Public Property Fechadesincronizacion_UTC As Date
          Public Shared ___Fechadesincronizacion_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Fechadesincronizacion_UTC"",""etiqueta"": ""Fecha de Sincronización"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha de Sincronización"",""descripcion"": """",""keyword"": ""Fechadesincronizacion_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __Fechadesincronizacion_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___Fechadesincronizacion_UTC
          Overrides Sub CargarDatos(_Datos as Dic(of string,string))
          me.HaImprimido = _Datos.Leer_Boolean("pr_40a64ccx59wc")
          me.ReferenciaAutorDelAlta = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_146310243ex306wd"), _Datos.Leer_String("pr_146310243ex306wd.nombre"))
          me.ReferenciaPermisoPuntual = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_73b8379wd"), _Datos.Leer_String("pr_73b8379wd.nombre"))
          me.ReferenciaElemento = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_407fc81x1a3wc"), _Datos.Leer_String("pr_407fc81x1a3wc.nombre"))
          me.ReferenciaRegistroDeAccesoSesion = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_185b34608cx16bwd"), _Datos.Leer_String("pr_185b34608cx16bwd.nombre"))
          me.FechaDato_UTC = _Datos.Leer_DateTime_Nulable("pr_1463102482xbcwd")
          me.ElementoNombre = _Datos.Leer_String("pr_47137adx73wc")
          me.FechaAlta_UTC = _Datos.Leer_DateTime_Nulable("pr_14c9f3e26dg13bwd")
          me.EmpleadoTieneAccesoWeb = _Datos.Leer_Boolean("pr_1464b59d72x51wd")
          me.VecesFoco = _Datos.Leer_Integer("pr_407faadx2a4wc")
          me.SegundosAbierto = _Datos.Leer_Integer("pr_407fa69x1e3wc")
          me.SegundosActividad = _Datos.Leer_Integer("pr_407fa49x391wc")
          me.ReferenciaSeccion = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_407fc0ex312wc"), _Datos.Leer_String("pr_407fc0ex312wc.nombre"))
          me.FinalizacionInesperada = _Datos.Leer_Boolean("pr_4d832fcx2fawc")
          me.ReferenciaEmpleadoPrincipal = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_1464b41092x328wd"), _Datos.Leer_String("pr_1464b41092x328wd.nombre"))
          me.TipoDeAccion = _Datos.Leer_EnumRAPrincipalE("pr_7c20cf7wd")
          me.ReferenciaUbicacionPrincipal = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_1464b410d0x38cwd"), _Datos.Leer_String("pr_1464b410d0x38cwd.nombre"))
          me.TiempoEjecucion = _Datos.Leer_Decimal("pr_4d83377x2a6wc")
          me.ReferenciaDestinador = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_146310256ex24dwd"), _Datos.Leer_String("pr_146310256ex24dwd.nombre"))
          me.HoraLocal = _Datos.Leer_Time_Nulable("pr_776aebawd")
          me.AutorDelAltaTieneAccesoWeb = _Datos.Leer_Boolean("pr_146314ac52h261wd")
          me.ReferenciaServidor = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_40040212261"), _Datos.Leer_String("pr_40040212261.nombre"))
          me.ID = _Datos.Leer_Guid("id")
          me.TextoPrincipal = _Datos.Leer_String("nombre")
          me.FechaAltaDato_UTC = _Datos.Leer_DateTime("fecha")
          me.FechaUltimaModificacion_UTC = _Datos.Leer_DateTime("fecham")
          me.Eliminado = _Datos.Leer_Boolean("eliminado")
          me.UsuarioCreadorDelDAto = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("usuarioid"), _Datos.Leer_String("usuarioid.nombre"))
          me.Seccion = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("plantillapid"), _Datos.Leer_String("plantillapid.nombre"))
          me.Posicion = _Datos.Leer_Decimal("posicion")
          me.Empresa = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("ubicacion"), _Datos.Leer_String("ubicacion.nombre"))
          me.Modificado = _Datos.Leer_Boolean("modificado")
          me.FechaIndiceActividad_UTC = _Datos.Leer_DateTime("fechaia")
          me.Fechadesincronizacion_UTC = _Datos.Leer_DateTime("fechasyn")
          End Sub
          Overrides Function ToDic() as Dic(of String,String)
           dim R as new Dic(of String,String)
         R.add("pr_40a64ccx59wc", me.HaImprimido.AdaptarMySQL_Boolean())
         If Me.ReferenciaAutorDelAlta IsNot nothing then
           R.add("pr_146310243ex306wd",me.ReferenciaAutorDelAlta.ID.STR())
         Else
           R.add("pr_146310243ex306wd","")
         End if
         If Me.ReferenciaPermisoPuntual IsNot nothing then
           R.add("pr_73b8379wd",me.ReferenciaPermisoPuntual.ID.STR())
         Else
           R.add("pr_73b8379wd","")
         End if
         If Me.ReferenciaElemento IsNot nothing then
           R.add("pr_407fc81x1a3wc",me.ReferenciaElemento.ID.STR())
         Else
           R.add("pr_407fc81x1a3wc","")
         End if
         If Me.ReferenciaRegistroDeAccesoSesion IsNot nothing then
           R.add("pr_185b34608cx16bwd",me.ReferenciaRegistroDeAccesoSesion.ID.STR())
         Else
           R.add("pr_185b34608cx16bwd","")
         End if
         R.add("pr_1463102482xbcwd", me.FechaDato_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_47137adx73wc", me.ElementoNombre.AdaptarMySQL_String())
         R.add("pr_14c9f3e26dg13bwd", me.FechaAlta_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_1464b59d72x51wd", me.EmpleadoTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_407faadx2a4wc", me.VecesFoco.AdaptarMySQL_Integer())
         R.add("pr_407fa69x1e3wc", me.SegundosAbierto.AdaptarMySQL_Integer())
         R.add("pr_407fa49x391wc", me.SegundosActividad.AdaptarMySQL_Integer())
         If Me.ReferenciaSeccion IsNot nothing then
           R.add("pr_407fc0ex312wc",me.ReferenciaSeccion.ID.STR())
         Else
           R.add("pr_407fc0ex312wc","")
         End if
         R.add("pr_4d832fcx2fawc", me.FinalizacionInesperada.AdaptarMySQL_Boolean())
         If Me.ReferenciaEmpleadoPrincipal IsNot nothing then
           R.add("pr_1464b41092x328wd",me.ReferenciaEmpleadoPrincipal.ID.STR())
         Else
           R.add("pr_1464b41092x328wd","")
         End if
         R.add("pr_7c20cf7wd", me.TipoDeAccion.AdaptarMySQL_EnumRAPrincipalE())
         If Me.ReferenciaUbicacionPrincipal IsNot nothing then
           R.add("pr_1464b410d0x38cwd",me.ReferenciaUbicacionPrincipal.ID.STR())
         Else
           R.add("pr_1464b410d0x38cwd","")
         End if
         R.add("pr_4d83377x2a6wc", me.TiempoEjecucion.AdaptarMySQL_Decimal())
         If Me.ReferenciaDestinador IsNot nothing then
           R.add("pr_146310256ex24dwd",me.ReferenciaDestinador.ID.STR())
         Else
           R.add("pr_146310256ex24dwd","")
         End if
         R.add("pr_776aebawd", me.HoraLocal.AdaptarMySQL_Time_Nulable())
         R.add("pr_146314ac52h261wd", me.AutorDelAltaTieneAccesoWeb.AdaptarMySQL_Boolean())
         If Me.ReferenciaServidor IsNot nothing then
           R.add("pr_40040212261",me.ReferenciaServidor.ID.STR())
         Else
           R.add("pr_40040212261","")
         End if
         R.add("id", me.ID.AdaptarMySQL_Guid())
         R.add("nombre", me.TextoPrincipal.AdaptarMySQL_String())
         R.add("fecha", me.FechaAltaDato_UTC.AdaptarMySQL_DateTime())
         R.add("fecham", me.FechaUltimaModificacion_UTC.AdaptarMySQL_DateTime())
         R.add("eliminado", me.Eliminado.AdaptarMySQL_Boolean())
         If Me.UsuarioCreadorDelDAto IsNot nothing then
           R.add("usuarioid",me.UsuarioCreadorDelDAto.ID.STR())
         Else
           R.add("usuarioid","")
         End if
         If Me.Seccion IsNot nothing then
           R.add("plantillapid",me.Seccion.ID.STR())
         Else
           R.add("plantillapid","")
         End if
         R.add("posicion", me.Posicion.AdaptarMySQL_Decimal())
         If Me.Empresa IsNot nothing then
           R.add("ubicacion",me.Empresa.ID.STR())
         Else
           R.add("ubicacion","")
         End if
         R.add("modificado", me.Modificado.AdaptarMySQL_Boolean())
         R.add("fechaia", me.FechaIndiceActividad_UTC.AdaptarMySQL_DateTime())
         R.add("fechasyn", me.Fechadesincronizacion_UTC.AdaptarMySQL_DateTime())
            Return R
          End Function
          Sub new()
          End Sub
      End Class
      Public Class RegistroDeActividadEnRegistros_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
        Public ReadOnly property HaImprimido As Boolean
            get
                return me.GetValue_Boolean("pr_40a64ccx59wc")
            End Get   
        End Property
        Public ReadOnly property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_146310243ex306wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaPermisoPuntual As Guid
            get
                return me.GetValue_Guid("pr_73b8379wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaElemento As Guid
            get
                return me.GetValue_Guid("pr_407fc81x1a3wc")
            End Get   
        End Property
        Public ReadOnly property ReferenciaRegistroDeAccesoSesion As Guid
            get
                return me.GetValue_Guid("pr_185b34608cx16bwd")
            End Get   
        End Property
        Public ReadOnly property FechaDato_UTC As Date
            get
                return me.GetValue_DateTime("pr_1463102482xbcwd")
            End Get   
        End Property
        Public ReadOnly property ElementoNombre As String
            get
                return me.GetValue_String("pr_47137adx73wc")
            End Get   
        End Property
        Public ReadOnly property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_14c9f3e26dg13bwd")
            End Get   
        End Property
          Public property EmpleadoTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_1464b59d72x51wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_1464b59d72x51wd", value)
            End Set
          End Property
        Public ReadOnly property VecesFoco As Integer
            get
                return me.GetValue_Int("pr_407faadx2a4wc")
            End Get   
        End Property
        Public ReadOnly property SegundosAbierto As Integer
            get
                return me.GetValue_Int("pr_407fa69x1e3wc")
            End Get   
        End Property
        Public ReadOnly property SegundosActividad As Integer
            get
                return me.GetValue_Int("pr_407fa49x391wc")
            End Get   
        End Property
        Public ReadOnly property ReferenciaSeccion As Guid
            get
                return me.GetValue_Guid("pr_407fc0ex312wc")
            End Get   
        End Property
        Public ReadOnly property FinalizacionInesperada As Boolean
            get
                return me.GetValue_Boolean("pr_4d832fcx2fawc")
            End Get   
        End Property
        Public ReadOnly property ReferenciaEmpleadoPrincipal As Guid
            get
                return me.GetValue_Guid("pr_1464b41092x328wd")
            End Get   
        End Property
        Public ReadOnly property TipoDeAccion As EnumRAPrincipalE
            get
                return me.GetValue_Int("pr_7c20cf7wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaUbicacionPrincipal As Guid
            get
                return me.GetValue_Guid("pr_1464b410d0x38cwd")
            End Get   
        End Property
        Public ReadOnly property TiempoEjecucion As Decimal
            get
                return me.GetValue_Decimal("pr_4d83377x2a6wc")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_146310256ex24dwd")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As DateTime
            get
                return me.GetValue_DateTime("pr_776aebawd")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_146314ac52h261wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_146314ac52h261wd", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaServidor As Guid
            get
                return me.GetValue_Guid("pr_40040212261")
            End Get   
        End Property
        Public ReadOnly property ID As Guid
            get
                return me.GetValue_Guid("id")
            End Get   
        End Property
          Public property TextoPrincipal As String
            get
                return me.GetValue_String("nombre")
            End Get
            Set(value As String)
                me.SetValue_String("nombre", value)
            End Set
          End Property
        Public ReadOnly property FechaAltaDato_UTC As Date
            get
                return me.GetValue_DateTime("fecha")
            End Get   
        End Property
        Public ReadOnly property FechaUltimaModificacion_UTC As Date
            get
                return me.GetValue_DateTime("fecham")
            End Get   
        End Property
        Public ReadOnly property Eliminado As Boolean
            get
                return me.GetValue_Boolean("eliminado")
            End Get   
        End Property
        Public ReadOnly property UsuarioCreadorDelDAto As Guid
            get
                return me.GetValue_Guid("usuarioid")
            End Get   
        End Property
          Public property Seccion As Guid
            get
                return me.GetValue_Guid("plantillapid")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("plantillapid", value)
            End Set
          End Property
          Public property Posicion As Decimal
            get
                return me.GetValue_Decimal("posicion")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("posicion", value)
            End Set
          End Property
        Public ReadOnly property Empresa As Guid
            get
                return me.GetValue_Guid("ubicacion")
            End Get   
        End Property
        Public ReadOnly property Modificado As Boolean
            get
                return me.GetValue_Boolean("modificado")
            End Get   
        End Property
        Public ReadOnly property FechaIndiceActividad_UTC As Date
            get
                return me.GetValue_DateTime("fechaia")
            End Get   
        End Property
        Public ReadOnly property Fechadesincronizacion_UTC As Date
            get
                return me.GetValue_DateTime("fechasyn")
            End Get   
        End Property
          Sub New(___VV__ As DinaNETCore.API_VVC , _Token$)
              MyBase.New(___VV__, _Token) 
              Me.Evento_Actualizar()
          End Sub
      End Class
  End Class
End Class
