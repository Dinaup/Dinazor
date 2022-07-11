   Imports System.ComponentModel
   Imports DinaNETCore
   Imports DinaNETCore.APID
Partial Public Class SeccionesD
  Public Class PuestosDeTrabajoBaseD
      Public Shared _SeccionID As String = "f777486d-e709-41be-9211-d9c6b4bb05d6"
      Public Shared _SeccionIDGUID As New Guid("f777486d-e709-41be-9211-d9c6b4bb05d6")
      Public Shared Async Function ConsultarDatos_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, ParamArray Valor As String()) As Task(Of List(Of PuestosDeTrabajoBaseC )) 
          Dim R As New List(Of PuestosDeTrabajoBaseC )  
          Dim d = Await DinaupSesion.ConexionServidor.Funcion_Datos_Recibir_Async(DinaupSesion, PuestosDeTrabajoBaseES._SeccionID, False, Campo, Valor) 
          If d.Datos.TieneDatos Then 
              For Each Actual In d.Datos 
                  Dim Valores_Listador = Actual.Value.Item1
                  Dim Obj_Listador As New PuestosDeTrabajoBaseC 
                  Obj_Listador.CargarDatos(Valores_Listador) 
                  R.Add(Obj_Listador) 
              Next 
          End If 
          Return R 
      End Function 
      Public Class PuestosDeTrabajoBaseES
          Public shared _SeccionID as Guid = New Guid("f777486d-e709-41be-9211-d9c6b4bb05d6")
          Public shared _Tabla$ = "tpr_441ce4bwc"
      Public Shared NombreDeEquipo$ = "pr_147276d4c5x4cwd"
      Public Shared EspacioTotalUnidadC$ = "pr_148783f9f9x22fwd"
      Public Shared VersionSistemaOperativo$ = "pr_147cb20cbbx1e8wd"
      Public Shared ResolucionAncho$ = "pr_14878e20cax323wd"
      Public Shared ResolucionAlto$ = "pr_14878ed063x1aawd"
      Public Shared MotivoDeBloqueo$ = "pr_147cb50188x1eawd"
      Public Shared HoraLocal$ = "pr_776ae0ewd"
      Public Shared UltimaConexion_UTC$ = "pr_1472741fe1x28wd"
      Public Shared EmpleadoQueProcesoLaVinculacionTieneAccesoWeb$ = "pr_1472617b07xb2wd"
      Public Shared ReferenciaDestinador$ = "pr_1463108555x208wd"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_1464b42b99h1dawd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_146314ad5ch142wd"
      Public Shared PuestoEnDesuso$ = "pr_147cb0c17cx39awd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_146310848ax262wd"
      Public Shared Plataforma$ = "pr_14878783aax1ebwd"
      Public Shared SistemaOperativo$ = "pr_14726eb53bx32wd"
      Public Shared MemoriaGigabyte$ = "pr_14726ce393x7ewd"
      Public Shared ReferenciaEmpleadoQueProcesoLaVinculacion$ = "pr_1472614c73x26dwd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_1464b59e3chcbwd"
      Public Shared Procesadores$ = "pr_1487870e11x261wd"
      Public Shared EspacioDisponibleUnidadC$ = "pr_1472729dd6x63wd"
      Public Shared FechaAlta_UTC$ = "pr_14c9f3f2b7x32bwd"
      Public Shared ExportarEnModulos$ = "pr_14631084b9g54wd"
      Public Shared FechaDeVinculacion_UTC$ = "pr_14725cda53x2acwd"
      Public Shared Idioma$ = "pr_1487b8bf67x12ewd"
      Public Shared Bloqueado$ = "pr_147cb5778bxe4wd"
      Public Shared Procesador$ = "pr_148785a0c9x18ewd"
      Public Shared VersionEnUltimaConexion$ = "pr_14727a6962x397wd"
      Public Shared TokenDeIdentificacion$ = "pr_1472584b9ax2a0wd"
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
      Public Class PuestosDeTrabajoBaseC
      Inherits Base_DatoC
          <DisplayName("Nombre de equipo")>
          Public Property NombreDeEquipo As String
          Public Shared ___NombreDeEquipo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""NombreDeEquipo"",""etiqueta"": ""Nombre de equipo"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Nombre de equipo"",""descripcion"": """",""keyword"": ""NombreDeEquipo"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __NombreDeEquipo As DinaNETCore.APID.DinaupAPI_CampoC = ___NombreDeEquipo
          <Description("Capacidad de disco en  Gigabyte.")>
          <DisplayName("Espacio total (Unidad C:)")>
          Public Property EspacioTotalUnidadC As Decimal
          Public Shared ___EspacioTotalUnidadC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EspacioTotalUnidadC"",""etiqueta"": ""Espacio total (Unidad C:)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""6"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Espacio total (Unidad C:)"",""descripcion"": """",""keyword"": ""EspacioTotalUnidadC"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EspacioTotalUnidadC As DinaNETCore.APID.DinaupAPI_CampoC = ___EspacioTotalUnidadC
          <DisplayName("Versión Sistema operativo")>
          Public Property VersionSistemaOperativo As String
          Public Shared ___VersionSistemaOperativo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""VersionSistemaOperativo"",""etiqueta"": ""Versión Sistema operativo"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Versión Sistema operativo"",""descripcion"": """",""keyword"": ""VersionSistemaOperativo"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __VersionSistemaOperativo As DinaNETCore.APID.DinaupAPI_CampoC = ___VersionSistemaOperativo
          <DisplayName("Resolución Ancho")>
          Public Property ResolucionAncho As Decimal
          Public Shared ___ResolucionAncho As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ResolucionAncho"",""etiqueta"": ""Resolución Ancho"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""8"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Resolución Ancho"",""descripcion"": """",""keyword"": ""ResolucionAncho"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ResolucionAncho As DinaNETCore.APID.DinaupAPI_CampoC = ___ResolucionAncho
          <DisplayName("Resolución Alto")>
          Public Property ResolucionAlto As Decimal
          Public Shared ___ResolucionAlto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ResolucionAlto"",""etiqueta"": ""Resolución Alto"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""8"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Resolución Alto"",""descripcion"": """",""keyword"": ""ResolucionAlto"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ResolucionAlto As DinaNETCore.APID.DinaupAPI_CampoC = ___ResolucionAlto
          <DisplayName("Motivo de bloqueo")>
          Public Property MotivoDeBloqueo As String
          Public Shared ___MotivoDeBloqueo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""MotivoDeBloqueo"",""etiqueta"": ""Motivo de bloqueo"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Motivo de bloqueo"",""descripcion"": """",""keyword"": ""MotivoDeBloqueo"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __MotivoDeBloqueo As DinaNETCore.APID.DinaupAPI_CampoC = ___MotivoDeBloqueo
          <DisplayName("Hora local")>
          Public Property HoraLocal As DateTime?
          Public Shared ___HoraLocal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""HoraLocal"",""etiqueta"": ""Hora local"",""oculta"": false,""formato"": 8,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Hora local"",""descripcion"": """",""keyword"": ""HoraLocal"",""formato"": 8,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __HoraLocal As DinaNETCore.APID.DinaupAPI_CampoC = ___HoraLocal
          <DisplayName("Última conexión")>
          Public Property UltimaConexion_UTC As Date?
          Public Shared ___UltimaConexion_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""UltimaConexion_UTC"",""etiqueta"": ""Última conexión"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 22,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Última conexión"",""descripcion"": """",""keyword"": ""UltimaConexion_UTC"",""formato"": 6,""rol"": 22,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __UltimaConexion_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___UltimaConexion_UTC
          <DisplayName("Empleado que procesó la vinculación Tiene Acceso web")>
          Public Property EmpleadoQueProcesoLaVinculacionTieneAccesoWeb As Boolean
          Public Shared ___EmpleadoQueProcesoLaVinculacionTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EmpleadoQueProcesoLaVinculacionTieneAccesoWeb"",""etiqueta"": ""Empleado que procesó la vinculación Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empleado que procesó la vinculación Tiene Acceso web"",""descripcion"": """",""keyword"": ""EmpleadoQueProcesoLaVinculacionTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EmpleadoQueProcesoLaVinculacionTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___EmpleadoQueProcesoLaVinculacionTieneAccesoWeb
          <DisplayName("Destinador")>
          Public Property ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaDestinador As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaDestinador"",""etiqueta"": ""Destinador"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""relacionesindirectas"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Destinador"",""descripcion"": """",""keyword"": ""ReferenciaDestinador"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaDestinador
          <DisplayName("Ubicación Principal")>
          Public Property ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaUbicacionPrincipal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaUbicacionPrincipal"",""etiqueta"": ""Ubicación Principal"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""bffd6c6e-a75b-455f-8367-067e7bb2fb47"",""titulo"": ""Base - Ubicaciones"",""iconoid"": ""b985b58f-7275-46b8-9b66-2c54346b0185"",""etiquetasingular"": ""Ubicación"",""etiquetaplural"": ""Ubicaciones"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""bffd6c6e-a75b-455f-8367-067e7bb2fb47"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Ubicación Principal"",""descripcion"": """",""keyword"": ""ReferenciaUbicacionPrincipal"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaUbicacionPrincipal
          <DisplayName("Autor del alta Tiene Acceso web")>
          Public Property AutorDelAltaTieneAccesoWeb As Boolean
          Public Shared ___AutorDelAltaTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AutorDelAltaTieneAccesoWeb"",""etiqueta"": ""Autor del alta Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta Tiene Acceso web"",""descripcion"": """",""keyword"": ""AutorDelAltaTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AutorDelAltaTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___AutorDelAltaTieneAccesoWeb
          <DisplayName("Puesto en desuso")>
          Public Property PuestoEnDesuso As Boolean
          Public Shared ___PuestoEnDesuso As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""PuestoEnDesuso"",""etiqueta"": ""Puesto en desuso"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Puesto en desuso"",""descripcion"": """",""keyword"": ""PuestoEnDesuso"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __PuestoEnDesuso As DinaNETCore.APID.DinaupAPI_CampoC = ___PuestoEnDesuso
          <DisplayName("Autor del alta")>
          Public Property ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaAutorDelAlta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaAutorDelAlta"",""etiqueta"": ""Autor del alta"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta"",""descripcion"": """",""keyword"": ""ReferenciaAutorDelAlta"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaAutorDelAlta
          <DisplayName("Plataforma")>
          Public Property Plataforma As String
          Public Shared ___Plataforma As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Plataforma"",""etiqueta"": ""Plataforma"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Plataforma"",""descripcion"": """",""keyword"": ""Plataforma"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Plataforma As DinaNETCore.APID.DinaupAPI_CampoC = ___Plataforma
          <DisplayName("Sistema operativo")>
          Public Property SistemaOperativo As String
          Public Shared ___SistemaOperativo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""SistemaOperativo"",""etiqueta"": ""Sistema operativo"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Sistema operativo"",""descripcion"": """",""keyword"": ""SistemaOperativo"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __SistemaOperativo As DinaNETCore.APID.DinaupAPI_CampoC = ___SistemaOperativo
          <DisplayName("Memoria (Gigabyte)")>
          Public Property MemoriaGigabyte As Decimal
          Public Shared ___MemoriaGigabyte As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""MemoriaGigabyte"",""etiqueta"": ""Memoria (Gigabyte)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""8"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Memoria (Gigabyte)"",""descripcion"": """",""keyword"": ""MemoriaGigabyte"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __MemoriaGigabyte As DinaNETCore.APID.DinaupAPI_CampoC = ___MemoriaGigabyte
          <DisplayName("Empleado que procesó la vinculación")>
          Public Property ReferenciaEmpleadoQueProcesoLaVinculacion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaEmpleadoQueProcesoLaVinculacion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaEmpleadoQueProcesoLaVinculacion"",""etiqueta"": ""Empleado que procesó la vinculación"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empleado que procesó la vinculación"",""descripcion"": """",""keyword"": ""ReferenciaEmpleadoQueProcesoLaVinculacion"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaEmpleadoQueProcesoLaVinculacion As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaEmpleadoQueProcesoLaVinculacion
          <DisplayName("Empleado Tiene Acceso web")>
          Public Property EmpleadoTieneAccesoWeb As Boolean
          Public Shared ___EmpleadoTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EmpleadoTieneAccesoWeb"",""etiqueta"": ""Empleado Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empleado Tiene Acceso web"",""descripcion"": """",""keyword"": ""EmpleadoTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EmpleadoTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___EmpleadoTieneAccesoWeb
          <DisplayName("Procesadores")>
          Public Property Procesadores As Decimal
          Public Shared ___Procesadores As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Procesadores"",""etiqueta"": ""Procesadores"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Procesadores"",""descripcion"": """",""keyword"": ""Procesadores"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Procesadores As DinaNETCore.APID.DinaupAPI_CampoC = ___Procesadores
          <Description("Espacio disponible en la unidad principal (Gigabyte).")>
          <DisplayName("Espacio disponible (Unidad C:)")>
          Public Property EspacioDisponibleUnidadC As Decimal
          Public Shared ___EspacioDisponibleUnidadC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EspacioDisponibleUnidadC"",""etiqueta"": ""Espacio disponible (Unidad C:)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""8"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Espacio disponible (Unidad C:)"",""descripcion"": """",""keyword"": ""EspacioDisponibleUnidadC"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EspacioDisponibleUnidadC As DinaNETCore.APID.DinaupAPI_CampoC = ___EspacioDisponibleUnidadC
          <DisplayName("Fecha Alta del registro")>
          Public Property FechaAlta_UTC As Date?
          Public Shared ___FechaAlta_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaAlta_UTC"",""etiqueta"": ""Fecha Alta del registro"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Alta del registro"",""descripcion"": """",""keyword"": ""FechaAlta_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaAlta_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaAlta_UTC
          <DisplayName("Fecha de vinculación")>
          Public Property FechaDeVinculacion_UTC As Date?
          Public Shared ___FechaDeVinculacion_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaDeVinculacion_UTC"",""etiqueta"": ""Fecha de vinculación"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 22,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha de vinculación"",""descripcion"": """",""keyword"": ""FechaDeVinculacion_UTC"",""formato"": 6,""rol"": 22,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaDeVinculacion_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaDeVinculacion_UTC
          <DisplayName("Idioma")>
          Public Property Idioma As String
          Public Shared ___Idioma As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Idioma"",""etiqueta"": ""Idioma"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Idioma"",""descripcion"": """",""keyword"": ""Idioma"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Idioma As DinaNETCore.APID.DinaupAPI_CampoC = ___Idioma
          <DisplayName("Bloqueado")>
          Public Property Bloqueado As Boolean
          Public Shared ___Bloqueado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Bloqueado"",""etiqueta"": ""Bloqueado"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Bloqueado"",""descripcion"": """",""keyword"": ""Bloqueado"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Bloqueado As DinaNETCore.APID.DinaupAPI_CampoC = ___Bloqueado
          <DisplayName("Procesador")>
          Public Property Procesador As String
          Public Shared ___Procesador As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Procesador"",""etiqueta"": ""Procesador"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Procesador"",""descripcion"": """",""keyword"": ""Procesador"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Procesador As DinaNETCore.APID.DinaupAPI_CampoC = ___Procesador
          <DisplayName("Versión en última conexión")>
          Public Property VersionEnUltimaConexion As String
          Public Shared ___VersionEnUltimaConexion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""VersionEnUltimaConexion"",""etiqueta"": ""Versión en última conexión"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Versión en última conexión"",""descripcion"": """",""keyword"": ""VersionEnUltimaConexion"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __VersionEnUltimaConexion As DinaNETCore.APID.DinaupAPI_CampoC = ___VersionEnUltimaConexion
          <DisplayName("Token de identificación")>
          Public Property TokenDeIdentificacion As String
          Public Shared ___TokenDeIdentificacion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TokenDeIdentificacion"",""etiqueta"": ""Token de identificación"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 10,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Token de identificación"",""descripcion"": """",""keyword"": ""TokenDeIdentificacion"",""formato"": 5,""rol"": 10,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __TokenDeIdentificacion As DinaNETCore.APID.DinaupAPI_CampoC = ___TokenDeIdentificacion
          <ReadOnlyAttribute(True)>
          <DisplayName("ID")>
          Public Property ID As Guid
          Public Shared ___ID As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": true,""eseliminado"": false,""keyword"": ""ID"",""etiqueta"": ""ID"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""f777486d-e709-41be-9211-d9c6b4bb05d6"",""titulo"": ""Base - Puestos de trabajo"",""iconoid"": ""5d7008ed-1e2f-4dbe-a376-6261de330414"",""etiquetasingular"": ""Puesto de trabajo"",""etiquetaplural"": ""Puestos de trabajo"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""f777486d-e709-41be-9211-d9c6b4bb05d6"",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""ID"",""descripcion"": """",""keyword"": ""ID"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ID As DinaNETCore.APID.DinaupAPI_CampoC = ___ID
          <DisplayName("Nombre")>
          Public Property TextoPrincipal As String
          Public Shared ___TextoPrincipal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TextoPrincipal"",""etiqueta"": ""Nombre"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Nombre"",""descripcion"": """",""keyword"": ""TextoPrincipal"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
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
          me.NombreDeEquipo = _Datos.Leer_String("pr_147276d4c5x4cwd")
          me.EspacioTotalUnidadC = _Datos.Leer_Decimal("pr_148783f9f9x22fwd")
          me.VersionSistemaOperativo = _Datos.Leer_String("pr_147cb20cbbx1e8wd")
          me.ResolucionAncho = _Datos.Leer_Decimal("pr_14878e20cax323wd")
          me.ResolucionAlto = _Datos.Leer_Decimal("pr_14878ed063x1aawd")
          me.MotivoDeBloqueo = _Datos.Leer_String("pr_147cb50188x1eawd")
          me.HoraLocal = _Datos.Leer_Time_Nulable("pr_776ae0ewd")
          me.UltimaConexion_UTC = _Datos.Leer_DateTime_Nulable("pr_1472741fe1x28wd")
          me.EmpleadoQueProcesoLaVinculacionTieneAccesoWeb = _Datos.Leer_Boolean("pr_1472617b07xb2wd")
          me.ReferenciaDestinador = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_1463108555x208wd"), _Datos.Leer_String("pr_1463108555x208wd.nombre"))
          me.ReferenciaUbicacionPrincipal = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_1464b42b99h1dawd"), _Datos.Leer_String("pr_1464b42b99h1dawd.nombre"))
          me.AutorDelAltaTieneAccesoWeb = _Datos.Leer_Boolean("pr_146314ad5ch142wd")
          me.PuestoEnDesuso = _Datos.Leer_Boolean("pr_147cb0c17cx39awd")
          me.ReferenciaAutorDelAlta = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_146310848ax262wd"), _Datos.Leer_String("pr_146310848ax262wd.nombre"))
          me.Plataforma = _Datos.Leer_String("pr_14878783aax1ebwd")
          me.SistemaOperativo = _Datos.Leer_String("pr_14726eb53bx32wd")
          me.MemoriaGigabyte = _Datos.Leer_Decimal("pr_14726ce393x7ewd")
          me.ReferenciaEmpleadoQueProcesoLaVinculacion = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_1472614c73x26dwd"), _Datos.Leer_String("pr_1472614c73x26dwd.nombre"))
          me.EmpleadoTieneAccesoWeb = _Datos.Leer_Boolean("pr_1464b59e3chcbwd")
          me.Procesadores = _Datos.Leer_Decimal("pr_1487870e11x261wd")
          me.EspacioDisponibleUnidadC = _Datos.Leer_Decimal("pr_1472729dd6x63wd")
          me.FechaAlta_UTC = _Datos.Leer_DateTime_Nulable("pr_14c9f3f2b7x32bwd")
          me.FechaDeVinculacion_UTC = _Datos.Leer_DateTime_Nulable("pr_14725cda53x2acwd")
          me.Idioma = _Datos.Leer_String("pr_1487b8bf67x12ewd")
          me.Bloqueado = _Datos.Leer_Boolean("pr_147cb5778bxe4wd")
          me.Procesador = _Datos.Leer_String("pr_148785a0c9x18ewd")
          me.VersionEnUltimaConexion = _Datos.Leer_String("pr_14727a6962x397wd")
          me.TokenDeIdentificacion = _Datos.Leer_String("pr_1472584b9ax2a0wd")
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
         R.add("pr_147276d4c5x4cwd", me.NombreDeEquipo.AdaptarMySQL_String())
         R.add("pr_148783f9f9x22fwd", me.EspacioTotalUnidadC.AdaptarMySQL_Decimal())
         R.add("pr_147cb20cbbx1e8wd", me.VersionSistemaOperativo.AdaptarMySQL_String())
         R.add("pr_14878e20cax323wd", me.ResolucionAncho.AdaptarMySQL_Decimal())
         R.add("pr_14878ed063x1aawd", me.ResolucionAlto.AdaptarMySQL_Decimal())
         R.add("pr_147cb50188x1eawd", me.MotivoDeBloqueo.AdaptarMySQL_String())
         R.add("pr_776ae0ewd", me.HoraLocal.AdaptarMySQL_Time_Nulable())
         R.add("pr_1472741fe1x28wd", me.UltimaConexion_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_1472617b07xb2wd", me.EmpleadoQueProcesoLaVinculacionTieneAccesoWeb.AdaptarMySQL_Boolean())
         If Me.ReferenciaDestinador IsNot nothing then
           R.add("pr_1463108555x208wd",me.ReferenciaDestinador.ID.STR())
         Else
           R.add("pr_1463108555x208wd","")
         End if
         If Me.ReferenciaUbicacionPrincipal IsNot nothing then
           R.add("pr_1464b42b99h1dawd",me.ReferenciaUbicacionPrincipal.ID.STR())
         Else
           R.add("pr_1464b42b99h1dawd","")
         End if
         R.add("pr_146314ad5ch142wd", me.AutorDelAltaTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_147cb0c17cx39awd", me.PuestoEnDesuso.AdaptarMySQL_Boolean())
         If Me.ReferenciaAutorDelAlta IsNot nothing then
           R.add("pr_146310848ax262wd",me.ReferenciaAutorDelAlta.ID.STR())
         Else
           R.add("pr_146310848ax262wd","")
         End if
         R.add("pr_14878783aax1ebwd", me.Plataforma.AdaptarMySQL_String())
         R.add("pr_14726eb53bx32wd", me.SistemaOperativo.AdaptarMySQL_String())
         R.add("pr_14726ce393x7ewd", me.MemoriaGigabyte.AdaptarMySQL_Decimal())
         If Me.ReferenciaEmpleadoQueProcesoLaVinculacion IsNot nothing then
           R.add("pr_1472614c73x26dwd",me.ReferenciaEmpleadoQueProcesoLaVinculacion.ID.STR())
         Else
           R.add("pr_1472614c73x26dwd","")
         End if
         R.add("pr_1464b59e3chcbwd", me.EmpleadoTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_1487870e11x261wd", me.Procesadores.AdaptarMySQL_Decimal())
         R.add("pr_1472729dd6x63wd", me.EspacioDisponibleUnidadC.AdaptarMySQL_Decimal())
         R.add("pr_14c9f3f2b7x32bwd", me.FechaAlta_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_14725cda53x2acwd", me.FechaDeVinculacion_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_1487b8bf67x12ewd", me.Idioma.AdaptarMySQL_String())
         R.add("pr_147cb5778bxe4wd", me.Bloqueado.AdaptarMySQL_Boolean())
         R.add("pr_148785a0c9x18ewd", me.Procesador.AdaptarMySQL_String())
         R.add("pr_14727a6962x397wd", me.VersionEnUltimaConexion.AdaptarMySQL_String())
         R.add("pr_1472584b9ax2a0wd", me.TokenDeIdentificacion.AdaptarMySQL_String())
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
  End Class
End Class
