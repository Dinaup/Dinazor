   Imports System.ComponentModel
   Imports DinaNETCore
   Imports DinaNETCore.APID
Partial Public Class SeccionesD
  Public Class BandejasDeCorreosD
      Public Shared _SeccionID As String = "70090a84-24a5-486d-b2d8-7aaff6ed2966"
      Public Shared _SeccionIDGUID As New Guid("70090a84-24a5-486d-b2d8-7aaff6ed2966")
      Public Shared Async Function ConsultarDatos_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, ParamArray Valor As String()) As Task(Of List(Of BandejasDeCorreosC )) 
          Dim R As New List(Of BandejasDeCorreosC )  
          Dim d = Await DinaupSesion.ConexionServidor.Funcion_Datos_Recibir_Async(DinaupSesion, BandejasDeCorreosES._SeccionID, False, Campo, Valor) 
          If d.Datos.TieneDatos Then 
              For Each Actual In d.Datos 
                  Dim Valores_Listador = Actual.Value.Item1
                  Dim Obj_Listador As New BandejasDeCorreosC 
                  Obj_Listador.CargarDatos(Valores_Listador) 
                  R.Add(Obj_Listador) 
              Next 
          End If 
          Return R 
      End Function 
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As BandejasDeCorreosC, Optional CampoWhere$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Return Await DatosGuardar_Async(DinaupSesion, New List(Of BandejasDeCorreosC)({DAtos}), CampoWhere )
      End Function
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As List(Of BandejasDeCorreosC), Optional CampoWhere$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Dim Importar As New List(Of DinaupAPI_ImportacionProcesableC)
          For Each Actual In DAtos 
              Dim RegistroActual = New DinaupAPI_ImportacionProcesableC() 
               RegistroActual.dinaup_listador_datos = Actual.ToDic 
               Importar.Add(RegistroActual)  
          Next 
          Return Await DinaupSesion.ConexionServidor.Funcion_Importar_Ejecutar_Async(DinaupSesion, BandejasDeCorreosES._SeccionID, Importar, CampoWhere, "") 
      End Function
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As BandejasDeCorreos_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, BandejasDeCorreosES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New BandejasDeCorreos_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As BandejasDeCorreos_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, BandejasDeCorreosES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New BandejasDeCorreos_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class BandejasDeCorreosES
          Public shared _SeccionID as Guid = New Guid("70090a84-24a5-486d-b2d8-7aaff6ed2966")
          Public shared _Tabla$ = "tpr_20040257111"
      Public Shared ReferenciaDestinador$ = "pr_200402571114"
      Public Shared FechaAlta_UTC$ = "pr_200402571113"
      Public Shared ReferenciaAutorDelAlta$ = "pr_20040257119"
      Public Shared HoraLocal$ = "pr_200402571111"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_200402571125"
      Public Shared FechaDato_UTC$ = "pr_200402571110"
      Public Shared Contenido$ = "pr_300402571127"
      Public Shared HaSidoMarcadoComoCorreoNoDeseado$ = "pr_300402571128"
      Public Shared Asunto$ = "pr_300402571131"
      Public Shared CorreoDestino$ = "pr_300402571130"
      Public Shared EntidadRelacionadaTieneAccesoWeb$ = "pr_40040257112"
      Public Shared ReferenciaEntidadRelacionada$ = "pr_40040257111"
      Public Shared ReferenciaEmpresaRelacionada$ = "pr_40040257113"
      Public Shared Cabecera$ = "pr_40040257114"
      Public Shared CorreoDeOrigen$ = "pr_300402571129"
      Public Shared ReferenciaEstado$ = "pr_500402571131"
      Public Shared IdentificadorUnico$ = "pr_10040257122"
      Public Shared ReferenciaConfiguracionDeCorreo$ = "pr_300402571134"
      Public Shared ReferenciaBuzon$ = "pr_50040257411"
      Public Shared CantidadDeArchivosAdjuntos$ = "pr_60040257111"
      Public Shared FechaDeCorreo_UTC$ = "pr_300402571136"
      Public Shared ReferenciaRegistroRelacionadoSeccion$ = "pr_20040257684"
      Public Shared ReferenciaRegistroRelacionado$ = "pr_20040257682"
      Public Shared Autor$ = "pr_10040408083"
      Public Shared DireccionDeEnvioAlias$ = "pr_10040408084"
      Public Shared DireccionDeRespuesta$ = "pr_10040408085"
      Public Shared MensajeIDEmail$ = "pr_20040452512"
      Public Shared Tipo$ = "pr_50040452752"
      Public Shared Carpeta$ = "pr_10040474828"
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
      Public Class BandejasDeCorreosC
      Inherits Base_DatoC
          <DisplayName("Destinador")>
          Public Property ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaDestinador As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaDestinador"",""etiqueta"": ""Destinador"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""relacionesindirectas"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Destinador"",""descripcion"": """",""keyword"": ""ReferenciaDestinador"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaDestinador
          <DisplayName("Fecha Alta del registro")>
          Public Property FechaAlta_UTC As Date?
          Public Shared ___FechaAlta_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaAlta_UTC"",""etiqueta"": ""Fecha Alta del registro"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Alta del registro"",""descripcion"": """",""keyword"": ""FechaAlta_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaAlta_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaAlta_UTC
          <DisplayName("Autor del alta")>
          Public Property ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaAutorDelAlta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaAutorDelAlta"",""etiqueta"": ""Autor del alta"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta"",""descripcion"": """",""keyword"": ""ReferenciaAutorDelAlta"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaAutorDelAlta
          <DisplayName("Hora local")>
          Public Property HoraLocal As DateTime?
          Public Shared ___HoraLocal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""HoraLocal"",""etiqueta"": ""Hora local"",""oculta"": false,""formato"": 8,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Hora local"",""descripcion"": """",""keyword"": ""HoraLocal"",""formato"": 8,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __HoraLocal As DinaNETCore.APID.DinaupAPI_CampoC = ___HoraLocal
          <DisplayName("Autor del alta Tiene Acceso web")>
          Public Property AutorDelAltaTieneAccesoWeb As Boolean
          Public Shared ___AutorDelAltaTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AutorDelAltaTieneAccesoWeb"",""etiqueta"": ""Autor del alta Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta Tiene Acceso web"",""descripcion"": """",""keyword"": ""AutorDelAltaTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AutorDelAltaTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___AutorDelAltaTieneAccesoWeb
          <DisplayName("Fecha Dato")>
          Public Property FechaDato_UTC As Date?
          Public Shared ___FechaDato_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaDato_UTC"",""etiqueta"": ""Fecha Dato"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Dato"",""descripcion"": """",""keyword"": ""FechaDato_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaDato_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaDato_UTC
          <DisplayName("Contenido")>
          Public Property Contenido As String
          Public Shared ___Contenido As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Contenido"",""etiqueta"": ""Contenido"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 65,""decimales"": ""0"",""multilinea"": true,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Contenido"",""descripcion"": """",""keyword"": ""Contenido"",""formato"": 5,""rol"": 65,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Contenido As DinaNETCore.APID.DinaupAPI_CampoC = ___Contenido
          <DisplayName("Ha sido marcado como Correo no deseado")>
          Public Property HaSidoMarcadoComoCorreoNoDeseado As Boolean
          Public Shared ___HaSidoMarcadoComoCorreoNoDeseado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""HaSidoMarcadoComoCorreoNoDeseado"",""etiqueta"": ""Ha sido marcado como Correo no deseado"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Ha sido marcado como Correo no deseado"",""descripcion"": """",""keyword"": ""HaSidoMarcadoComoCorreoNoDeseado"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __HaSidoMarcadoComoCorreoNoDeseado As DinaNETCore.APID.DinaupAPI_CampoC = ___HaSidoMarcadoComoCorreoNoDeseado
          <DisplayName("Asunto")>
          Public Property Asunto As String
          Public Shared ___Asunto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Asunto"",""etiqueta"": ""Asunto"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Asunto"",""descripcion"": """",""keyword"": ""Asunto"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Asunto As DinaNETCore.APID.DinaupAPI_CampoC = ___Asunto
          <DisplayName("Correo destino")>
          Public Property CorreoDestino As String
          Public Shared ___CorreoDestino As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CorreoDestino"",""etiqueta"": ""Correo destino"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 4,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Correo destino"",""descripcion"": """",""keyword"": ""CorreoDestino"",""formato"": 5,""rol"": 4,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CorreoDestino As DinaNETCore.APID.DinaupAPI_CampoC = ___CorreoDestino
          <DisplayName("Entidad relacionada Tiene Acceso web")>
          Public Property EntidadRelacionadaTieneAccesoWeb As Boolean
          Public Shared ___EntidadRelacionadaTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EntidadRelacionadaTieneAccesoWeb"",""etiqueta"": ""Entidad relacionada Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Entidad relacionada Tiene Acceso web"",""descripcion"": """",""keyword"": ""EntidadRelacionadaTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EntidadRelacionadaTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___EntidadRelacionadaTieneAccesoWeb
          <DisplayName("Entidad relacionada")>
          Public Property ReferenciaEntidadRelacionada As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaEntidadRelacionada As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaEntidadRelacionada"",""etiqueta"": ""Entidad relacionada"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Entidad relacionada"",""descripcion"": """",""keyword"": ""ReferenciaEntidadRelacionada"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaEntidadRelacionada As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaEntidadRelacionada
          <DisplayName("Empresa relacionada")>
          Public Property ReferenciaEmpresaRelacionada As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaEmpresaRelacionada As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaEmpresaRelacionada"",""etiqueta"": ""Empresa relacionada"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""9d1bb1b3-06e1-425b-bd5a-1d03bae37094"",""titulo"": ""Base - Empresas administradas"",""iconoid"": ""b788149e-1c15-4807-9a25-72adf3333e5b"",""etiquetasingular"": ""Empresa administrada"",""etiquetaplural"": ""Empresas administradas"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""9d1bb1b3-06e1-425b-bd5a-1d03bae37094"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empresa relacionada"",""descripcion"": """",""keyword"": ""ReferenciaEmpresaRelacionada"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaEmpresaRelacionada As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaEmpresaRelacionada
          <DisplayName("Cabecera")>
          Public Property Cabecera As String
          Public Shared ___Cabecera As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Cabecera"",""etiqueta"": ""Cabecera"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 9,""decimales"": ""0"",""multilinea"": true,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cabecera"",""descripcion"": """",""keyword"": ""Cabecera"",""formato"": 5,""rol"": 9,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Cabecera As DinaNETCore.APID.DinaupAPI_CampoC = ___Cabecera
          <DisplayName("Correo de origen")>
          Public Property CorreoDeOrigen As String
          Public Shared ___CorreoDeOrigen As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CorreoDeOrigen"",""etiqueta"": ""Correo de origen"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 4,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Correo de origen"",""descripcion"": """",""keyword"": ""CorreoDeOrigen"",""formato"": 5,""rol"": 4,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CorreoDeOrigen As DinaNETCore.APID.DinaupAPI_CampoC = ___CorreoDeOrigen
          <DisplayName("Estado")>
          Public Property ReferenciaEstado As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaEstado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaEstado"",""etiqueta"": ""Estado"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""f887a106-8678-4e36-bf85-c9ea84129632"",""titulo"": ""Base - Estados de correos recibidos"",""iconoid"": ""d29b6e1e-0922-4c61-926d-1182f1d705ab"",""etiquetasingular"": ""Estado de correos recibidos"",""etiquetaplural"": ""Estados de correos recibidos"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""f887a106-8678-4e36-bf85-c9ea84129632"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Estado"",""descripcion"": """",""keyword"": ""ReferenciaEstado"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaEstado As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaEstado
          <DisplayName("Identificador único")>
          Public Property IdentificadorUnico As String
          Public Shared ___IdentificadorUnico As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""IdentificadorUnico"",""etiqueta"": ""Identificador único"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Identificador único"",""descripcion"": """",""keyword"": ""IdentificadorUnico"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __IdentificadorUnico As DinaNETCore.APID.DinaupAPI_CampoC = ___IdentificadorUnico
          <DisplayName("Configuración de correo")>
          Public Property ReferenciaConfiguracionDeCorreo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaConfiguracionDeCorreo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaConfiguracionDeCorreo"",""etiqueta"": ""Configuración de correo"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""e80ad188-9d6d-4b05-a7fb-e498cef51598"",""titulo"": ""Base - Cuentas de Correo electrónico"",""iconoid"": ""5fd758a4-dbc3-4365-ad56-18af81075b78"",""etiquetasingular"": ""Cuenta de correo electrónico"",""etiquetaplural"": ""Cuentas de Correo electrónico"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""e80ad188-9d6d-4b05-a7fb-e498cef51598"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Configuración de correo"",""descripcion"": """",""keyword"": ""ReferenciaConfiguracionDeCorreo"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaConfiguracionDeCorreo As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaConfiguracionDeCorreo
          <DisplayName("Buzón")>
          Public Property ReferenciaBuzon As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaBuzon As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaBuzon"",""etiqueta"": ""Buzón"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""7e428fbb-1432-4807-b4d3-739346f15f37"",""titulo"": ""Base - Buzones de correo"",""iconoid"": ""a56f7a66-b0cd-4c38-ae69-d85b1c4ac09a"",""etiquetasingular"": ""Buzón de correos"",""etiquetaplural"": ""Buzones de correo"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""7e428fbb-1432-4807-b4d3-739346f15f37"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Buzón"",""descripcion"": """",""keyword"": ""ReferenciaBuzon"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaBuzon As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaBuzon
          <DisplayName("Cantidad de archivos adjuntos")>
          Public Property CantidadDeArchivosAdjuntos As Integer
          Public Shared ___CantidadDeArchivosAdjuntos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CantidadDeArchivosAdjuntos"",""etiqueta"": ""Cantidad de archivos adjuntos"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cantidad de archivos adjuntos"",""descripcion"": """",""keyword"": ""CantidadDeArchivosAdjuntos"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CantidadDeArchivosAdjuntos As DinaNETCore.APID.DinaupAPI_CampoC = ___CantidadDeArchivosAdjuntos
          <DisplayName("Fecha de correo")>
          Public Property FechaDeCorreo_UTC As Date?
          Public Shared ___FechaDeCorreo_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaDeCorreo_UTC"",""etiqueta"": ""Fecha de correo"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha de correo"",""descripcion"": """",""keyword"": ""FechaDeCorreo_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaDeCorreo_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaDeCorreo_UTC
          <DisplayName("Registro relacionado Sección")>
          Public Property ReferenciaRegistroRelacionadoSeccion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaRegistroRelacionadoSeccion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaRegistroRelacionadoSeccion"",""etiqueta"": ""Registro relacionado Sección"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""plantillasp"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Registro relacionado Sección"",""descripcion"": """",""keyword"": ""ReferenciaRegistroRelacionadoSeccion"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaRegistroRelacionadoSeccion As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaRegistroRelacionadoSeccion
          <DisplayName("Registro relacionado")>
          Public Property ReferenciaRegistroRelacionado As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaRegistroRelacionado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaRegistroRelacionado"",""etiqueta"": ""Registro relacionado"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Registro relacionado"",""descripcion"": """",""keyword"": ""ReferenciaRegistroRelacionado"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaRegistroRelacionado As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaRegistroRelacionado
          <DisplayName("Autor")>
          Public Property Autor As String
          Public Shared ___Autor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Autor"",""etiqueta"": ""Autor"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor"",""descripcion"": """",""keyword"": ""Autor"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Autor As DinaNETCore.APID.DinaupAPI_CampoC = ___Autor
          <DisplayName("Dirección de envío (Alias)")>
          Public Property DireccionDeEnvioAlias As String
          Public Shared ___DireccionDeEnvioAlias As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DireccionDeEnvioAlias"",""etiqueta"": ""Dirección de envío (Alias)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 4,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Dirección de envío (Alias)"",""descripcion"": """",""keyword"": ""DireccionDeEnvioAlias"",""formato"": 5,""rol"": 4,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DireccionDeEnvioAlias As DinaNETCore.APID.DinaupAPI_CampoC = ___DireccionDeEnvioAlias
          <DisplayName("Dirección de Respuesta")>
          Public Property DireccionDeRespuesta As String
          Public Shared ___DireccionDeRespuesta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DireccionDeRespuesta"",""etiqueta"": ""Dirección de Respuesta"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 4,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Dirección de Respuesta"",""descripcion"": """",""keyword"": ""DireccionDeRespuesta"",""formato"": 5,""rol"": 4,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DireccionDeRespuesta As DinaNETCore.APID.DinaupAPI_CampoC = ___DireccionDeRespuesta
          <DisplayName("Mensaje ID (Email)")>
          Public Property MensajeIDEmail As String
          Public Shared ___MensajeIDEmail As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""MensajeIDEmail"",""etiqueta"": ""Mensaje ID (Email)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Mensaje ID (Email)"",""descripcion"": """",""keyword"": ""MensajeIDEmail"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __MensajeIDEmail As DinaNETCore.APID.DinaupAPI_CampoC = ___MensajeIDEmail
          <DisplayName("Tipo")>
          Public Property Tipo As EnumCorreoEntranteSalienteE
          Public Shared ___Tipo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Tipo"",""etiqueta"": ""Tipo"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 62,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [0,1,2],""predefinidos_textos"": [""Indefinido"",""Entrante"",""Saliente""],""predefinidos_iconos"": [""https://cdn.dinaup.com/ico/enums/62_0.png"",""https://cdn.dinaup.com/ico/enums/62_1.png"",""https://cdn.dinaup.com/ico/enums/62_2.png""],""filtro"": {""titulo"": ""Tipo"",""descripcion"": """",""keyword"": ""Tipo"",""formato"": 2,""rol"": 62,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false,""enumeracion"": {""titulo"": ""Enum - Correo Entrante/Saliente"", ""valores"": [{""valor"": 0, ""titulo"": ""Indefinido""},{""valor"": 1, ""titulo"": ""Entrante""},{""valor"": 2, ""titulo"": ""Saliente""}]}},""solovalorespredefinidos"": true}")
          Public  __Tipo As DinaNETCore.APID.DinaupAPI_CampoC = ___Tipo
          <DisplayName("Carpeta")>
          Public Property Carpeta As String
          Public Shared ___Carpeta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Carpeta"",""etiqueta"": ""Carpeta"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Carpeta"",""descripcion"": """",""keyword"": ""Carpeta"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Carpeta As DinaNETCore.APID.DinaupAPI_CampoC = ___Carpeta
          <ReadOnlyAttribute(True)>
          <DisplayName("ID")>
          Public Property ID As Guid
          Public Shared ___ID As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": true,""eseliminado"": false,""keyword"": ""ID"",""etiqueta"": ""ID"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""70090a84-24a5-486d-b2d8-7aaff6ed2966"",""titulo"": ""Bandejas de correos"",""iconoid"": ""11aded57-319c-48cb-8a36-4709590203b2"",""etiquetasingular"": ""Bandeja de  correos"",""etiquetaplural"": ""Bandejas de  correos"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""70090a84-24a5-486d-b2d8-7aaff6ed2966"",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""ID"",""descripcion"": """",""keyword"": ""ID"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ID As DinaNETCore.APID.DinaupAPI_CampoC = ___ID
          <DisplayName("Título")>
          Public Property TextoPrincipal As String
          Public Shared ___TextoPrincipal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TextoPrincipal"",""etiqueta"": ""Título"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Título"",""descripcion"": """",""keyword"": ""TextoPrincipal"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
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
          me.ReferenciaDestinador = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_200402571114"), _Datos.Leer_String("pr_200402571114.nombre"))
          me.FechaAlta_UTC = _Datos.Leer_DateTime_Nulable("pr_200402571113")
          me.ReferenciaAutorDelAlta = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_20040257119"), _Datos.Leer_String("pr_20040257119.nombre"))
          me.HoraLocal = _Datos.Leer_Time_Nulable("pr_200402571111")
          me.AutorDelAltaTieneAccesoWeb = _Datos.Leer_Boolean("pr_200402571125")
          me.FechaDato_UTC = _Datos.Leer_DateTime_Nulable("pr_200402571110")
          me.Contenido = _Datos.Leer_String("pr_300402571127")
          me.HaSidoMarcadoComoCorreoNoDeseado = _Datos.Leer_Boolean("pr_300402571128")
          me.Asunto = _Datos.Leer_String("pr_300402571131")
          me.CorreoDestino = _Datos.Leer_String("pr_300402571130")
          me.EntidadRelacionadaTieneAccesoWeb = _Datos.Leer_Boolean("pr_40040257112")
          me.ReferenciaEntidadRelacionada = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_40040257111"), _Datos.Leer_String("pr_40040257111.nombre"))
          me.ReferenciaEmpresaRelacionada = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_40040257113"), _Datos.Leer_String("pr_40040257113.nombre"))
          me.Cabecera = _Datos.Leer_String("pr_40040257114")
          me.CorreoDeOrigen = _Datos.Leer_String("pr_300402571129")
          me.ReferenciaEstado = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_500402571131"), _Datos.Leer_String("pr_500402571131.nombre"))
          me.IdentificadorUnico = _Datos.Leer_String("pr_10040257122")
          me.ReferenciaConfiguracionDeCorreo = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_300402571134"), _Datos.Leer_String("pr_300402571134.nombre"))
          me.ReferenciaBuzon = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_50040257411"), _Datos.Leer_String("pr_50040257411.nombre"))
          me.CantidadDeArchivosAdjuntos = _Datos.Leer_Integer("pr_60040257111")
          me.FechaDeCorreo_UTC = _Datos.Leer_DateTime_Nulable("pr_300402571136")
          me.ReferenciaRegistroRelacionadoSeccion = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_20040257684"), _Datos.Leer_String("pr_20040257684.nombre"))
          me.ReferenciaRegistroRelacionado = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_20040257682"), _Datos.Leer_String("pr_20040257682.nombre"))
          me.Autor = _Datos.Leer_String("pr_10040408083")
          me.DireccionDeEnvioAlias = _Datos.Leer_String("pr_10040408084")
          me.DireccionDeRespuesta = _Datos.Leer_String("pr_10040408085")
          me.MensajeIDEmail = _Datos.Leer_String("pr_20040452512")
          me.Tipo = _Datos.Leer_EnumCorreoEntranteSalienteE("pr_50040452752")
          me.Carpeta = _Datos.Leer_String("pr_10040474828")
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
         If Me.ReferenciaDestinador IsNot nothing then
           R.add("pr_200402571114",me.ReferenciaDestinador.ID.STR())
         Else
           R.add("pr_200402571114","")
         End if
         R.add("pr_200402571113", me.FechaAlta_UTC.AdaptarMySQL_DateTime_Nulable())
         If Me.ReferenciaAutorDelAlta IsNot nothing then
           R.add("pr_20040257119",me.ReferenciaAutorDelAlta.ID.STR())
         Else
           R.add("pr_20040257119","")
         End if
         R.add("pr_200402571111", me.HoraLocal.AdaptarMySQL_Time_Nulable())
         R.add("pr_200402571125", me.AutorDelAltaTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_200402571110", me.FechaDato_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_300402571127", me.Contenido.AdaptarMySQL_String())
         R.add("pr_300402571128", me.HaSidoMarcadoComoCorreoNoDeseado.AdaptarMySQL_Boolean())
         R.add("pr_300402571131", me.Asunto.AdaptarMySQL_String())
         R.add("pr_300402571130", me.CorreoDestino.AdaptarMySQL_String())
         R.add("pr_40040257112", me.EntidadRelacionadaTieneAccesoWeb.AdaptarMySQL_Boolean())
         If Me.ReferenciaEntidadRelacionada IsNot nothing then
           R.add("pr_40040257111",me.ReferenciaEntidadRelacionada.ID.STR())
         Else
           R.add("pr_40040257111","")
         End if
         If Me.ReferenciaEmpresaRelacionada IsNot nothing then
           R.add("pr_40040257113",me.ReferenciaEmpresaRelacionada.ID.STR())
         Else
           R.add("pr_40040257113","")
         End if
         R.add("pr_40040257114", me.Cabecera.AdaptarMySQL_String())
         R.add("pr_300402571129", me.CorreoDeOrigen.AdaptarMySQL_String())
         If Me.ReferenciaEstado IsNot nothing then
           R.add("pr_500402571131",me.ReferenciaEstado.ID.STR())
         Else
           R.add("pr_500402571131","")
         End if
         R.add("pr_10040257122", me.IdentificadorUnico.AdaptarMySQL_String())
         If Me.ReferenciaConfiguracionDeCorreo IsNot nothing then
           R.add("pr_300402571134",me.ReferenciaConfiguracionDeCorreo.ID.STR())
         Else
           R.add("pr_300402571134","")
         End if
         If Me.ReferenciaBuzon IsNot nothing then
           R.add("pr_50040257411",me.ReferenciaBuzon.ID.STR())
         Else
           R.add("pr_50040257411","")
         End if
         R.add("pr_60040257111", me.CantidadDeArchivosAdjuntos.AdaptarMySQL_Integer())
         R.add("pr_300402571136", me.FechaDeCorreo_UTC.AdaptarMySQL_DateTime_Nulable())
         If Me.ReferenciaRegistroRelacionadoSeccion IsNot nothing then
           R.add("pr_20040257684",me.ReferenciaRegistroRelacionadoSeccion.ID.STR())
         Else
           R.add("pr_20040257684","")
         End if
         If Me.ReferenciaRegistroRelacionado IsNot nothing then
           R.add("pr_20040257682",me.ReferenciaRegistroRelacionado.ID.STR())
         Else
           R.add("pr_20040257682","")
         End if
         R.add("pr_10040408083", me.Autor.AdaptarMySQL_String())
         R.add("pr_10040408084", me.DireccionDeEnvioAlias.AdaptarMySQL_String())
         R.add("pr_10040408085", me.DireccionDeRespuesta.AdaptarMySQL_String())
         R.add("pr_20040452512", me.MensajeIDEmail.AdaptarMySQL_String())
         R.add("pr_50040452752", me.Tipo.AdaptarMySQL_EnumCorreoEntranteSalienteE())
         R.add("pr_10040474828", me.Carpeta.AdaptarMySQL_String())
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
      Public Class BandejasDeCorreos_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_200402571114")
            End Get   
        End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_200402571113")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_200402571113", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_20040257119")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_20040257119", value)
            End Set
          End Property
        Public ReadOnly property HoraLocal As DateTime
            get
                return me.GetValue_DateTime("pr_200402571111")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_200402571125")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_200402571125", value)
            End Set
          End Property
          Public property FechaDato_UTC As Date
            get
                return me.GetValue_DateTime("pr_200402571110")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_200402571110", value)
            End Set
          End Property
        Public ReadOnly property Contenido As String
            get
                return me.GetValue_String("pr_300402571127")
            End Get   
        End Property
          Public property HaSidoMarcadoComoCorreoNoDeseado As Boolean
            get
                return me.GetValue_Boolean("pr_300402571128")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_300402571128", value)
            End Set
          End Property
        Public ReadOnly property Asunto As String
            get
                return me.GetValue_String("pr_300402571131")
            End Get   
        End Property
        Public ReadOnly property CorreoDestino As String
            get
                return me.GetValue_String("pr_300402571130")
            End Get   
        End Property
          Public property EntidadRelacionadaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_40040257112")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_40040257112", value)
            End Set
          End Property
          Public property ReferenciaEntidadRelacionada As Guid
            get
                return me.GetValue_Guid("pr_40040257111")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_40040257111", value)
            End Set
          End Property
          Public property ReferenciaEmpresaRelacionada As Guid
            get
                return me.GetValue_Guid("pr_40040257113")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_40040257113", value)
            End Set
          End Property
        Public ReadOnly property Cabecera As String
            get
                return me.GetValue_String("pr_40040257114")
            End Get   
        End Property
        Public ReadOnly property CorreoDeOrigen As String
            get
                return me.GetValue_String("pr_300402571129")
            End Get   
        End Property
          Public property ReferenciaEstado As Guid
            get
                return me.GetValue_Guid("pr_500402571131")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_500402571131", value)
            End Set
          End Property
        Public ReadOnly property IdentificadorUnico As String
            get
                return me.GetValue_String("pr_10040257122")
            End Get   
        End Property
        Public ReadOnly property ReferenciaConfiguracionDeCorreo As Guid
            get
                return me.GetValue_Guid("pr_300402571134")
            End Get   
        End Property
          Public property ReferenciaBuzon As Guid
            get
                return me.GetValue_Guid("pr_50040257411")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_50040257411", value)
            End Set
          End Property
        Public ReadOnly property CantidadDeArchivosAdjuntos As Integer
            get
                return me.GetValue_Int("pr_60040257111")
            End Get   
        End Property
        Public ReadOnly property FechaDeCorreo_UTC As Date
            get
                return me.GetValue_DateTime("pr_300402571136")
            End Get   
        End Property
        Public ReadOnly property ReferenciaRegistroRelacionadoSeccion As Guid
            get
                return me.GetValue_Guid("pr_20040257684")
            End Get   
        End Property
        Public ReadOnly property ReferenciaRegistroRelacionado As Guid
            get
                return me.GetValue_Guid("pr_20040257682")
            End Get   
        End Property
        Public ReadOnly property Autor As String
            get
                return me.GetValue_String("pr_10040408083")
            End Get   
        End Property
        Public ReadOnly property DireccionDeEnvioAlias As String
            get
                return me.GetValue_String("pr_10040408084")
            End Get   
        End Property
        Public ReadOnly property DireccionDeRespuesta As String
            get
                return me.GetValue_String("pr_10040408085")
            End Get   
        End Property
          Public property MensajeIDEmail As String
            get
                return me.GetValue_String("pr_20040452512")
            End Get
            Set(value As String)
                me.SetValue_String("pr_20040452512", value)
            End Set
          End Property
        Public ReadOnly property Tipo As EnumCorreoEntranteSalienteE
            get
                return me.GetValue_Int("pr_50040452752")
            End Get   
        End Property
        Public ReadOnly property Carpeta As String
            get
                return me.GetValue_String("pr_10040474828")
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
