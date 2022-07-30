   Imports System.ComponentModel
   Imports DinaNETCore
   Imports DinaNETCore.APID
Partial Public Class SeccionesD
  Public Class CuentasDeCorreoElectronicoD
      Public Shared _SeccionID As String = "cb53c54c-e1f7-47de-8978-0e5228ed81c4"
      Public Shared _SeccionIDGUID As New Guid("cb53c54c-e1f7-47de-8978-0e5228ed81c4")
      Public Shared Async Function ConsultarDatos_Async(Parametros As SeccionConsultaParametrosC) As Task(Of List(Of CuentasDeCorreoElectronicoC )) 
          Dim R As New List(Of CuentasDeCorreoElectronicoC )  
          Dim d = Await Parametros.DinaupSesion.ConexionServidor.Funcion_Datos_Recibir_Async(CuentasDeCorreoElectronicoES._SeccionID, False, Parametros) 
          If d.Datos.TieneDatos Then 
              For Each Actual In d.Datos 
                  Dim Valores_Listador = Actual.Value.Item1
                  Dim Obj_Listador As New CuentasDeCorreoElectronicoC 
                  Obj_Listador.CargarDatos(Valores_Listador) 
                  Obj_Listador.CargaInterna(Actual.Value)
                  R.Add(Obj_Listador) 
              Next 
          End If 
          Return R 
      End Function 
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As CuentasDeCorreoElectronicoC, Optional CampoWhere$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Return Await DatosGuardar_Async(DinaupSesion, New List(Of CuentasDeCorreoElectronicoC)({DAtos}), CampoWhere )
      End Function
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As List(Of CuentasDeCorreoElectronicoC), Optional CampoWhere$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Dim Importar As New List(Of DinaupAPI_ImportacionProcesableC)
          For Each Actual In DAtos 
              Dim RegistroActual = New DinaupAPI_ImportacionProcesableC() 
               RegistroActual.dinaup_listador_datos = Actual.ToDic 
               Importar.Add(RegistroActual)  
          Next 
          Return Await DinaupSesion.ConexionServidor.Funcion_Importar_Ejecutar_Async(DinaupSesion, CuentasDeCorreoElectronicoES._SeccionID, Importar, CampoWhere, "") 
      End Function
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As CuentasDeCorreoElectronico_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, CuentasDeCorreoElectronicoES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New CuentasDeCorreoElectronico_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As CuentasDeCorreoElectronico_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, CuentasDeCorreoElectronicoES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New CuentasDeCorreoElectronico_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class CuentasDeCorreoElectronicoES
          Public shared _SeccionID as Guid = New Guid("cb53c54c-e1f7-47de-8978-0e5228ed81c4")
          Public shared _Tabla$ = "tpr_30040163371001"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_30040163371022"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_30040163371009"
      Public Shared ReferenciaDestinador$ = "pr_30040163371015"
      Public Shared FechaAlta_UTC$ = "pr_30040163371014"
      Public Shared HoraLocal$ = "pr_30040163371012"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_30040163371021"
      Public Shared ReferenciaAutorDelAlta$ = "pr_30040163371010"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_30040163371008"
      Public Shared Configuracion$ = "pr_30040164802"
      Public Shared NumeroMaximoDeEnviosDeEmailsPorHora$ = "pr_50040165183"
      Public Shared DireccionSMTP$ = "pr_10040164242"
      Public Shared Contraseña$ = "pr_10040164241"
      Public Shared ActivarSSLEnSMPT$ = "pr_10040164243"
      Public Shared ReferenciaImagenPrevia$ = "pr_500401652940"
      Public Shared Puerto$ = "pr_10040164244"
      Public Shared DireccionDeCorreo$ = "pr_60040164231004"
      Public Shared NumeroMaximoDeEnviosDeEmailsPorDia$ = "pr_50040165184"
      Public Shared Protocolo$ = "pr_60040255942"
      Public Shared ReferenciaServidorEncargado$ = "pr_20040257112"
      Public Shared ServidorIMAP$ = "pr_40040257404"
      Public Shared PuertoIMAP$ = "pr_40040257402"
      Public Shared ActivarSSLEnIMAP$ = "pr_40040257403"
      Public Shared DescargarCorreosRecibidos$ = "pr_10040257112"
      Public Shared ReferenciaBuzonPredeterminado$ = "pr_600402574032"
      Public Shared ReferenciaBuzonPrincipal$ = "pr_40040391503"
      Public Shared ResponderA$ = "pr_50040408061"
      Public Shared FiltrarEnviadosA$ = "pr_50040408062"
      Public Shared DireccionDeEnvioAlias$ = "pr_30040408073"
      Public Shared DescargarCorreosEnviados$ = "pr_60040452763"
      Public Shared ReferenciaEstadoInicialCorreosEnviados$ = "pr_60040452765"
      Public Shared ReferenciaEstadoInicialCorreosRecibidos$ = "pr_10040452771"
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
      Public Class CuentasDeCorreoElectronicoC
      Inherits Base_DatoC
          <DisplayName("Empleado Tiene Acceso web")>
          Public Property EmpleadoTieneAccesoWeb As Boolean
          Public Shared ___EmpleadoTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EmpleadoTieneAccesoWeb"",""etiqueta"": ""Empleado Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empleado Tiene Acceso web"",""descripcion"": """",""keyword"": ""EmpleadoTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EmpleadoTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___EmpleadoTieneAccesoWeb
          <DisplayName("Ubicación Principal")>
          Public Property ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaUbicacionPrincipal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaUbicacionPrincipal"",""etiqueta"": ""Ubicación Principal"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""b9adbfbf-a81a-45fb-861c-90502902c982"",""titulo"": ""Ubicaciones"",""iconoid"": ""b985b58f-7275-46b8-9b66-2c54346b0185"",""etiquetasingular"": ""Ubicación"",""etiquetaplural"": ""Ubicaciones"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""b9adbfbf-a81a-45fb-861c-90502902c982"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Ubicación Principal"",""descripcion"": """",""keyword"": ""ReferenciaUbicacionPrincipal"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaUbicacionPrincipal
          <DisplayName("Destinador")>
          Public Property ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaDestinador As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaDestinador"",""etiqueta"": ""Destinador"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""relacionesindirectas"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Destinador"",""descripcion"": """",""keyword"": ""ReferenciaDestinador"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaDestinador
          <DisplayName("Fecha Alta del registro")>
          Public Property FechaAlta_UTC As Date?
          Public Shared ___FechaAlta_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaAlta_UTC"",""etiqueta"": ""Fecha Alta del registro"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Alta del registro"",""descripcion"": """",""keyword"": ""FechaAlta_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaAlta_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaAlta_UTC
          <DisplayName("Hora local")>
          Public Property HoraLocal As DateTime?
          Public Shared ___HoraLocal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""HoraLocal"",""etiqueta"": ""Hora local"",""oculta"": false,""formato"": 8,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Hora local"",""descripcion"": """",""keyword"": ""HoraLocal"",""formato"": 8,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __HoraLocal As DinaNETCore.APID.DinaupAPI_CampoC = ___HoraLocal
          <DisplayName("Autor del alta Tiene Acceso web")>
          Public Property AutorDelAltaTieneAccesoWeb As Boolean
          Public Shared ___AutorDelAltaTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AutorDelAltaTieneAccesoWeb"",""etiqueta"": ""Autor del alta Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta Tiene Acceso web"",""descripcion"": """",""keyword"": ""AutorDelAltaTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AutorDelAltaTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___AutorDelAltaTieneAccesoWeb
          <DisplayName("Autor del alta")>
          Public Property ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaAutorDelAlta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaAutorDelAlta"",""etiqueta"": ""Autor del alta"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta"",""descripcion"": """",""keyword"": ""ReferenciaAutorDelAlta"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaAutorDelAlta
          <DisplayName("Empleado")>
          Public Property ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaEmpleadoPrincipal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaEmpleadoPrincipal"",""etiqueta"": ""Empleado"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c6e071c7-776f-4300-aa55-c711fd1da916"",""titulo"": ""Empleados"",""iconoid"": ""1c8abf82-640c-4d18-b62c-89de310923dd"",""etiquetasingular"": ""Empleado"",""etiquetaplural"": ""Empleados"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""c6e071c7-776f-4300-aa55-c711fd1da916"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empleado"",""descripcion"": """",""keyword"": ""ReferenciaEmpleadoPrincipal"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaEmpleadoPrincipal
          <DisplayName("Configuración")>
          Public Property Configuracion As String
          Public Shared ___Configuracion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Configuracion"",""etiqueta"": ""Configuración"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 50,""decimales"": ""0"",""multilinea"": true,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Configuración"",""descripcion"": """",""keyword"": ""Configuracion"",""formato"": 5,""rol"": 50,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Configuracion As DinaNETCore.APID.DinaupAPI_CampoC = ___Configuracion
          <DisplayName("Número máximo de envíos de emails por hora")>
          Public Property NumeroMaximoDeEnviosDeEmailsPorHora As Integer
          Public Shared ___NumeroMaximoDeEnviosDeEmailsPorHora As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""NumeroMaximoDeEnviosDeEmailsPorHora"",""etiqueta"": ""Número máximo de envíos de emails por hora"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Número máximo de envíos de emails por hora"",""descripcion"": """",""keyword"": ""NumeroMaximoDeEnviosDeEmailsPorHora"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __NumeroMaximoDeEnviosDeEmailsPorHora As DinaNETCore.APID.DinaupAPI_CampoC = ___NumeroMaximoDeEnviosDeEmailsPorHora
          <DisplayName("Dirección SMTP")>
          Public Property DireccionSMTP As String
          Public Shared ___DireccionSMTP As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DireccionSMTP"",""etiqueta"": ""Dirección SMTP"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Dirección SMTP"",""descripcion"": """",""keyword"": ""DireccionSMTP"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DireccionSMTP As DinaNETCore.APID.DinaupAPI_CampoC = ___DireccionSMTP
          <DisplayName("Contraseña")>
          Public Property Contraseña As String
          Public Shared ___Contraseña As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Contraseña"",""etiqueta"": ""Contraseña"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 10,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Contraseña"",""descripcion"": """",""keyword"": ""Contraseña"",""formato"": 5,""rol"": 10,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Contraseña As DinaNETCore.APID.DinaupAPI_CampoC = ___Contraseña
          <DisplayName("Activar SSL en SMPT")>
          Public Property ActivarSSLEnSMPT As Boolean
          Public Shared ___ActivarSSLEnSMPT As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ActivarSSLEnSMPT"",""etiqueta"": ""Activar SSL en SMPT"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Activar SSL en SMPT"",""descripcion"": """",""keyword"": ""ActivarSSLEnSMPT"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ActivarSSLEnSMPT As DinaNETCore.APID.DinaupAPI_CampoC = ___ActivarSSLEnSMPT
          <DisplayName("Imagen Previa")>
          Public Property ReferenciaImagenPrevia As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaImagenPrevia As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaImagenPrevia"",""etiqueta"": ""Imagen Previa"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""imagenes"",""rol"": 17,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Imagen Previa"",""descripcion"": """",""keyword"": ""ReferenciaImagenPrevia"",""formato"": 9,""rol"": 17,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaImagenPrevia As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaImagenPrevia
          <DisplayName("Puerto")>
          Public Property Puerto As Integer
          Public Shared ___Puerto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Puerto"",""etiqueta"": ""Puerto"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Puerto"",""descripcion"": """",""keyword"": ""Puerto"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Puerto As DinaNETCore.APID.DinaupAPI_CampoC = ___Puerto
          <DisplayName("Dirección de correo")>
          Public Property DireccionDeCorreo As String
          Public Shared ___DireccionDeCorreo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DireccionDeCorreo"",""etiqueta"": ""Dirección de correo"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 4,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Dirección de correo"",""descripcion"": """",""keyword"": ""DireccionDeCorreo"",""formato"": 5,""rol"": 4,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DireccionDeCorreo As DinaNETCore.APID.DinaupAPI_CampoC = ___DireccionDeCorreo
          <DisplayName("Número máximo de envíos de emails por día")>
          Public Property NumeroMaximoDeEnviosDeEmailsPorDia As Integer
          Public Shared ___NumeroMaximoDeEnviosDeEmailsPorDia As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""NumeroMaximoDeEnviosDeEmailsPorDia"",""etiqueta"": ""Número máximo de envíos de emails por día"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Número máximo de envíos de emails por día"",""descripcion"": """",""keyword"": ""NumeroMaximoDeEnviosDeEmailsPorDia"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __NumeroMaximoDeEnviosDeEmailsPorDia As DinaNETCore.APID.DinaupAPI_CampoC = ___NumeroMaximoDeEnviosDeEmailsPorDia
          <DisplayName("Protocolo")>
          Public Property Protocolo As EnumTipoServicioDeCorreoE
          Public Shared ___Protocolo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Protocolo"",""etiqueta"": ""Protocolo"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 93,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [0,1,2],""predefinidos_textos"": ["""",""SMTP"",""Gmail""],""predefinidos_iconos"": [""https://cdn.dinaup.com/ico/enums/93_0.png"",""https://cdn.dinaup.com/ico/enums/93_1.png"",""https://cdn.dinaup.com/ico/enums/93_2.png""],""filtro"": {""titulo"": ""Protocolo"",""descripcion"": """",""keyword"": ""Protocolo"",""formato"": 2,""rol"": 93,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false,""enumeracion"": {""titulo"": ""Enum - Tipo servicio de correo"", ""valores"": [{""valor"": 0, ""titulo"": """"},{""valor"": 1, ""titulo"": ""SMTP""},{""valor"": 2, ""titulo"": ""Gmail""}]}},""solovalorespredefinidos"": true}")
          Public  __Protocolo As DinaNETCore.APID.DinaupAPI_CampoC = ___Protocolo
          <DisplayName("Servidor encargado")>
          Public Property ReferenciaServidorEncargado As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaServidorEncargado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaServidorEncargado"",""etiqueta"": ""Servidor encargado"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""eadd8f25-d9e0-46ef-89a7-e95efe769df1"",""titulo"": ""Base - Servidores"",""iconoid"": ""35aab678-4c97-4349-9cad-b4e5b4d301a3"",""etiquetasingular"": ""Servidor"",""etiquetaplural"": ""Servidores"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""eadd8f25-d9e0-46ef-89a7-e95efe769df1"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Servidor encargado"",""descripcion"": """",""keyword"": ""ReferenciaServidorEncargado"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaServidorEncargado As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaServidorEncargado
          <DisplayName("Servidor IMAP")>
          Public Property ServidorIMAP As String
          Public Shared ___ServidorIMAP As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ServidorIMAP"",""etiqueta"": ""Servidor IMAP"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Servidor IMAP"",""descripcion"": """",""keyword"": ""ServidorIMAP"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ServidorIMAP As DinaNETCore.APID.DinaupAPI_CampoC = ___ServidorIMAP
          <DisplayName("Puerto IMAP")>
          Public Property PuertoIMAP As Integer
          Public Shared ___PuertoIMAP As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""PuertoIMAP"",""etiqueta"": ""Puerto IMAP"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Puerto IMAP"",""descripcion"": """",""keyword"": ""PuertoIMAP"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __PuertoIMAP As DinaNETCore.APID.DinaupAPI_CampoC = ___PuertoIMAP
          <DisplayName("Activar SSL en IMAP")>
          Public Property ActivarSSLEnIMAP As Boolean
          Public Shared ___ActivarSSLEnIMAP As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ActivarSSLEnIMAP"",""etiqueta"": ""Activar SSL en IMAP"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Activar SSL en IMAP"",""descripcion"": """",""keyword"": ""ActivarSSLEnIMAP"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ActivarSSLEnIMAP As DinaNETCore.APID.DinaupAPI_CampoC = ___ActivarSSLEnIMAP
          <DisplayName("Descargar correos recibidos")>
          Public Property DescargarCorreosRecibidos As Boolean
          Public Shared ___DescargarCorreosRecibidos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescargarCorreosRecibidos"",""etiqueta"": ""Descargar correos recibidos"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descargar correos recibidos"",""descripcion"": """",""keyword"": ""DescargarCorreosRecibidos"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescargarCorreosRecibidos As DinaNETCore.APID.DinaupAPI_CampoC = ___DescargarCorreosRecibidos
          <DisplayName("Buzón predeterminado")>
          Public Property ReferenciaBuzonPredeterminado As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaBuzonPredeterminado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaBuzonPredeterminado"",""etiqueta"": ""Buzón predeterminado"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""7e428fbb-1432-4807-b4d3-739346f15f37"",""titulo"": ""Base - Buzones de correo"",""iconoid"": ""a56f7a66-b0cd-4c38-ae69-d85b1c4ac09a"",""etiquetasingular"": ""Buzón de correos"",""etiquetaplural"": ""Buzones de correo"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""7e428fbb-1432-4807-b4d3-739346f15f37"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Buzón predeterminado"",""descripcion"": """",""keyword"": ""ReferenciaBuzonPredeterminado"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaBuzonPredeterminado As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaBuzonPredeterminado
          <DisplayName("Buzón Principal")>
          Public Property ReferenciaBuzonPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaBuzonPrincipal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaBuzonPrincipal"",""etiqueta"": ""Buzón Principal"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""93dc3756-c5c1-44d8-b11f-a23250336260"",""titulo"": ""Buzones de correo"",""iconoid"": ""a56f7a66-b0cd-4c38-ae69-d85b1c4ac09a"",""etiquetasingular"": ""Buzón de correos"",""etiquetaplural"": ""Buzones de correo"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""93dc3756-c5c1-44d8-b11f-a23250336260"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Buzón Principal"",""descripcion"": """",""keyword"": ""ReferenciaBuzonPrincipal"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaBuzonPrincipal As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaBuzonPrincipal
          <DisplayName("Responder A")>
          Public Property ResponderA As String
          Public Shared ___ResponderA As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ResponderA"",""etiqueta"": ""Responder A"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 4,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Responder A"",""descripcion"": """",""keyword"": ""ResponderA"",""formato"": 5,""rol"": 4,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ResponderA As DinaNETCore.APID.DinaupAPI_CampoC = ___ResponderA
          <DisplayName("Filtrar enviados a:")>
          Public Property FiltrarEnviadosA As String
          Public Shared ___FiltrarEnviadosA As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FiltrarEnviadosA"",""etiqueta"": ""Filtrar enviados a:"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 4,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Filtrar enviados a:"",""descripcion"": """",""keyword"": ""FiltrarEnviadosA"",""formato"": 5,""rol"": 4,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __FiltrarEnviadosA As DinaNETCore.APID.DinaupAPI_CampoC = ___FiltrarEnviadosA
          <DisplayName("Dirección de envío (Alias):")>
          Public Property DireccionDeEnvioAlias As String
          Public Shared ___DireccionDeEnvioAlias As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DireccionDeEnvioAlias"",""etiqueta"": ""Dirección de envío (Alias):"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 4,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Dirección de envío (Alias):"",""descripcion"": """",""keyword"": ""DireccionDeEnvioAlias"",""formato"": 5,""rol"": 4,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DireccionDeEnvioAlias As DinaNETCore.APID.DinaupAPI_CampoC = ___DireccionDeEnvioAlias
          <DisplayName("Descargar correos enviados")>
          Public Property DescargarCorreosEnviados As Boolean
          Public Shared ___DescargarCorreosEnviados As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescargarCorreosEnviados"",""etiqueta"": ""Descargar correos enviados"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descargar correos enviados"",""descripcion"": """",""keyword"": ""DescargarCorreosEnviados"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescargarCorreosEnviados As DinaNETCore.APID.DinaupAPI_CampoC = ___DescargarCorreosEnviados
          <DisplayName("Estado inicial (Correos enviados)")>
          Public Property ReferenciaEstadoInicialCorreosEnviados As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaEstadoInicialCorreosEnviados As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaEstadoInicialCorreosEnviados"",""etiqueta"": ""Estado inicial (Correos enviados)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""f887a106-8678-4e36-bf85-c9ea84129632"",""titulo"": ""Base - Estados de correos recibidos"",""iconoid"": ""d29b6e1e-0922-4c61-926d-1182f1d705ab"",""etiquetasingular"": ""Estado de correos recibidos"",""etiquetaplural"": ""Estados de correos recibidos"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""f887a106-8678-4e36-bf85-c9ea84129632"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Estado inicial (Correos enviados)"",""descripcion"": """",""keyword"": ""ReferenciaEstadoInicialCorreosEnviados"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaEstadoInicialCorreosEnviados As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaEstadoInicialCorreosEnviados
          <DisplayName("Estado inicial (Correos recibidos)")>
          Public Property ReferenciaEstadoInicialCorreosRecibidos As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaEstadoInicialCorreosRecibidos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaEstadoInicialCorreosRecibidos"",""etiqueta"": ""Estado inicial (Correos recibidos)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""f887a106-8678-4e36-bf85-c9ea84129632"",""titulo"": ""Base - Estados de correos recibidos"",""iconoid"": ""d29b6e1e-0922-4c61-926d-1182f1d705ab"",""etiquetasingular"": ""Estado de correos recibidos"",""etiquetaplural"": ""Estados de correos recibidos"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""f887a106-8678-4e36-bf85-c9ea84129632"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Estado inicial (Correos recibidos)"",""descripcion"": """",""keyword"": ""ReferenciaEstadoInicialCorreosRecibidos"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaEstadoInicialCorreosRecibidos As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaEstadoInicialCorreosRecibidos
          <ReadOnlyAttribute(True)>
          <DisplayName("ID")>
          Public Property ID As Guid
          Public Shared ___ID As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": true,""eseliminado"": false,""keyword"": ""ID"",""etiqueta"": ""ID"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""cb53c54c-e1f7-47de-8978-0e5228ed81c4"",""titulo"": ""Cuentas de Correo electrónico"",""iconoid"": ""5fd758a4-dbc3-4365-ad56-18af81075b78"",""etiquetasingular"": ""Cuenta de correo electrónico"",""etiquetaplural"": ""Cuentas de Correo electrónico"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""cb53c54c-e1f7-47de-8978-0e5228ed81c4"",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""ID"",""descripcion"": """",""keyword"": ""ID"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
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
          me.EmpleadoTieneAccesoWeb = _Datos.Leer_Boolean("pr_30040163371022")
          me.ReferenciaUbicacionPrincipal = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_30040163371009"), _Datos.Leer_String("pr_30040163371009.nombre"))
          me.ReferenciaDestinador = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_30040163371015"), _Datos.Leer_String("pr_30040163371015.nombre"))
          me.FechaAlta_UTC = _Datos.Leer_DateTime_Nulable("pr_30040163371014")
          me.HoraLocal = _Datos.Leer_Time_Nulable("pr_30040163371012")
          me.AutorDelAltaTieneAccesoWeb = _Datos.Leer_Boolean("pr_30040163371021")
          me.ReferenciaAutorDelAlta = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_30040163371010"), _Datos.Leer_String("pr_30040163371010.nombre"))
          me.ReferenciaEmpleadoPrincipal = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_30040163371008"), _Datos.Leer_String("pr_30040163371008.nombre"))
          me.Configuracion = _Datos.Leer_String("pr_30040164802")
          me.NumeroMaximoDeEnviosDeEmailsPorHora = _Datos.Leer_Integer("pr_50040165183")
          me.DireccionSMTP = _Datos.Leer_String("pr_10040164242")
          me.Contraseña = _Datos.Leer_String("pr_10040164241")
          me.ActivarSSLEnSMPT = _Datos.Leer_Boolean("pr_10040164243")
          me.ReferenciaImagenPrevia = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_500401652940"), _Datos.Leer_String("pr_500401652940.nombre"))
          me.Puerto = _Datos.Leer_Integer("pr_10040164244")
          me.DireccionDeCorreo = _Datos.Leer_String("pr_60040164231004")
          me.NumeroMaximoDeEnviosDeEmailsPorDia = _Datos.Leer_Integer("pr_50040165184")
          me.Protocolo = _Datos.Leer_EnumTipoServicioDeCorreoE("pr_60040255942")
          me.ReferenciaServidorEncargado = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_20040257112"), _Datos.Leer_String("pr_20040257112.nombre"))
          me.ServidorIMAP = _Datos.Leer_String("pr_40040257404")
          me.PuertoIMAP = _Datos.Leer_Integer("pr_40040257402")
          me.ActivarSSLEnIMAP = _Datos.Leer_Boolean("pr_40040257403")
          me.DescargarCorreosRecibidos = _Datos.Leer_Boolean("pr_10040257112")
          me.ReferenciaBuzonPredeterminado = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_600402574032"), _Datos.Leer_String("pr_600402574032.nombre"))
          me.ReferenciaBuzonPrincipal = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_40040391503"), _Datos.Leer_String("pr_40040391503.nombre"))
          me.ResponderA = _Datos.Leer_String("pr_50040408061")
          me.FiltrarEnviadosA = _Datos.Leer_String("pr_50040408062")
          me.DireccionDeEnvioAlias = _Datos.Leer_String("pr_30040408073")
          me.DescargarCorreosEnviados = _Datos.Leer_Boolean("pr_60040452763")
          me.ReferenciaEstadoInicialCorreosEnviados = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_60040452765"), _Datos.Leer_String("pr_60040452765.nombre"))
          me.ReferenciaEstadoInicialCorreosRecibidos = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_10040452771"), _Datos.Leer_String("pr_10040452771.nombre"))
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
         R.add("pr_30040163371022", me.EmpleadoTieneAccesoWeb.AdaptarMySQL_Boolean())
         If Me.ReferenciaUbicacionPrincipal IsNot nothing then
           R.add("pr_30040163371009",me.ReferenciaUbicacionPrincipal.ID.STR())
         Else
           R.add("pr_30040163371009","")
         End if
         If Me.ReferenciaDestinador IsNot nothing then
           R.add("pr_30040163371015",me.ReferenciaDestinador.ID.STR())
         Else
           R.add("pr_30040163371015","")
         End if
         R.add("pr_30040163371014", me.FechaAlta_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_30040163371012", me.HoraLocal.AdaptarMySQL_Time_Nulable())
         R.add("pr_30040163371021", me.AutorDelAltaTieneAccesoWeb.AdaptarMySQL_Boolean())
         If Me.ReferenciaAutorDelAlta IsNot nothing then
           R.add("pr_30040163371010",me.ReferenciaAutorDelAlta.ID.STR())
         Else
           R.add("pr_30040163371010","")
         End if
         If Me.ReferenciaEmpleadoPrincipal IsNot nothing then
           R.add("pr_30040163371008",me.ReferenciaEmpleadoPrincipal.ID.STR())
         Else
           R.add("pr_30040163371008","")
         End if
         R.add("pr_30040164802", me.Configuracion.AdaptarMySQL_String())
         R.add("pr_50040165183", me.NumeroMaximoDeEnviosDeEmailsPorHora.AdaptarMySQL_Integer())
         R.add("pr_10040164242", me.DireccionSMTP.AdaptarMySQL_String())
         R.add("pr_10040164241", me.Contraseña.AdaptarMySQL_String())
         R.add("pr_10040164243", me.ActivarSSLEnSMPT.AdaptarMySQL_Boolean())
         If Me.ReferenciaImagenPrevia IsNot nothing then
           R.add("pr_500401652940",me.ReferenciaImagenPrevia.ID.STR())
         Else
           R.add("pr_500401652940","")
         End if
         R.add("pr_10040164244", me.Puerto.AdaptarMySQL_Integer())
         R.add("pr_60040164231004", me.DireccionDeCorreo.AdaptarMySQL_String())
         R.add("pr_50040165184", me.NumeroMaximoDeEnviosDeEmailsPorDia.AdaptarMySQL_Integer())
         R.add("pr_60040255942", me.Protocolo.AdaptarMySQL_EnumTipoServicioDeCorreoE())
         If Me.ReferenciaServidorEncargado IsNot nothing then
           R.add("pr_20040257112",me.ReferenciaServidorEncargado.ID.STR())
         Else
           R.add("pr_20040257112","")
         End if
         R.add("pr_40040257404", me.ServidorIMAP.AdaptarMySQL_String())
         R.add("pr_40040257402", me.PuertoIMAP.AdaptarMySQL_Integer())
         R.add("pr_40040257403", me.ActivarSSLEnIMAP.AdaptarMySQL_Boolean())
         R.add("pr_10040257112", me.DescargarCorreosRecibidos.AdaptarMySQL_Boolean())
         If Me.ReferenciaBuzonPredeterminado IsNot nothing then
           R.add("pr_600402574032",me.ReferenciaBuzonPredeterminado.ID.STR())
         Else
           R.add("pr_600402574032","")
         End if
         If Me.ReferenciaBuzonPrincipal IsNot nothing then
           R.add("pr_40040391503",me.ReferenciaBuzonPrincipal.ID.STR())
         Else
           R.add("pr_40040391503","")
         End if
         R.add("pr_50040408061", me.ResponderA.AdaptarMySQL_String())
         R.add("pr_50040408062", me.FiltrarEnviadosA.AdaptarMySQL_String())
         R.add("pr_30040408073", me.DireccionDeEnvioAlias.AdaptarMySQL_String())
         R.add("pr_60040452763", me.DescargarCorreosEnviados.AdaptarMySQL_Boolean())
         If Me.ReferenciaEstadoInicialCorreosEnviados IsNot nothing then
           R.add("pr_60040452765",me.ReferenciaEstadoInicialCorreosEnviados.ID.STR())
         Else
           R.add("pr_60040452765","")
         End if
         If Me.ReferenciaEstadoInicialCorreosRecibidos IsNot nothing then
           R.add("pr_10040452771",me.ReferenciaEstadoInicialCorreosRecibidos.ID.STR())
         Else
           R.add("pr_10040452771","")
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
      Public Class CuentasDeCorreoElectronico_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
          Public property EmpleadoTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_30040163371022")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_30040163371022", value)
            End Set
          End Property
          Public property ReferenciaUbicacionPrincipal As Guid
            get
                return me.GetValue_Guid("pr_30040163371009")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_30040163371009", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_30040163371015")
            End Get   
        End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_30040163371014")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_30040163371014", value)
            End Set
          End Property
        Public ReadOnly property HoraLocal As DateTime
            get
                return me.GetValue_DateTime("pr_30040163371012")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_30040163371021")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_30040163371021", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_30040163371010")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_30040163371010", value)
            End Set
          End Property
          Public property ReferenciaEmpleadoPrincipal As Guid
            get
                return me.GetValue_Guid("pr_30040163371008")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_30040163371008", value)
            End Set
          End Property
        Public ReadOnly property Configuracion As String
            get
                return me.GetValue_String("pr_30040164802")
            End Get   
        End Property
          Public property NumeroMaximoDeEnviosDeEmailsPorHora As Integer
            get
                return me.GetValue_Int("pr_50040165183")
            End Get
            Set(value As Integer)
                me.SetValue_Int("pr_50040165183", value)
            End Set
          End Property
        Public ReadOnly property DireccionSMTP As String
            get
                return me.GetValue_String("pr_10040164242")
            End Get   
        End Property
        Public ReadOnly property Contraseña As String
            get
                return me.GetValue_String("pr_10040164241")
            End Get   
        End Property
        Public ReadOnly property ActivarSSLEnSMPT As Boolean
            get
                return me.GetValue_Boolean("pr_10040164243")
            End Get   
        End Property
          Public property ReferenciaImagenPrevia As Guid
            get
                return me.GetValue_Guid("pr_500401652940")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_500401652940", value)
            End Set
          End Property
        Public ReadOnly property Puerto As Integer
            get
                return me.GetValue_Int("pr_10040164244")
            End Get   
        End Property
        Public ReadOnly property DireccionDeCorreo As String
            get
                return me.GetValue_String("pr_60040164231004")
            End Get   
        End Property
          Public property NumeroMaximoDeEnviosDeEmailsPorDia As Integer
            get
                return me.GetValue_Int("pr_50040165184")
            End Get
            Set(value As Integer)
                me.SetValue_Int("pr_50040165184", value)
            End Set
          End Property
          Public property Protocolo__Int as Integer
            get
                return me.GetValue_Int("pr_60040255942")
            End Get
            Set(value as Integer)
                me.SetValue_Int("pr_60040255942", value)
            End Set
          End Property
          Public property Protocolo As EnumTipoServicioDeCorreoE
            get
                return me.GetValue_Int("pr_60040255942")
            End Get
            Set(value As EnumTipoServicioDeCorreoE)
                me.SetValue_Int("pr_60040255942", value)
            End Set
          End Property
          Public property ReferenciaServidorEncargado As Guid
            get
                return me.GetValue_Guid("pr_20040257112")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_20040257112", value)
            End Set
          End Property
        Public ReadOnly property ServidorIMAP As String
            get
                return me.GetValue_String("pr_40040257404")
            End Get   
        End Property
        Public ReadOnly property PuertoIMAP As Integer
            get
                return me.GetValue_Int("pr_40040257402")
            End Get   
        End Property
        Public ReadOnly property ActivarSSLEnIMAP As Boolean
            get
                return me.GetValue_Boolean("pr_40040257403")
            End Get   
        End Property
          Public property DescargarCorreosRecibidos As Boolean
            get
                return me.GetValue_Boolean("pr_10040257112")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_10040257112", value)
            End Set
          End Property
          Public property ReferenciaBuzonPredeterminado As Guid
            get
                return me.GetValue_Guid("pr_600402574032")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_600402574032", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaBuzonPrincipal As Guid
            get
                return me.GetValue_Guid("pr_40040391503")
            End Get   
        End Property
          Public property ResponderA As String
            get
                return me.GetValue_String("pr_50040408061")
            End Get
            Set(value As String)
                me.SetValue_String("pr_50040408061", value)
            End Set
          End Property
          Public property FiltrarEnviadosA As String
            get
                return me.GetValue_String("pr_50040408062")
            End Get
            Set(value As String)
                me.SetValue_String("pr_50040408062", value)
            End Set
          End Property
          Public property DireccionDeEnvioAlias As String
            get
                return me.GetValue_String("pr_30040408073")
            End Get
            Set(value As String)
                me.SetValue_String("pr_30040408073", value)
            End Set
          End Property
          Public property DescargarCorreosEnviados As Boolean
            get
                return me.GetValue_Boolean("pr_60040452763")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_60040452763", value)
            End Set
          End Property
          Public property ReferenciaEstadoInicialCorreosEnviados As Guid
            get
                return me.GetValue_Guid("pr_60040452765")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_60040452765", value)
            End Set
          End Property
          Public property ReferenciaEstadoInicialCorreosRecibidos As Guid
            get
                return me.GetValue_Guid("pr_10040452771")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_10040452771", value)
            End Set
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
