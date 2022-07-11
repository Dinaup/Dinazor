   Imports System.ComponentModel
   Imports DinaNETCore
   Imports DinaNETCore.APID
Partial Public Class SeccionesD
  Public Class DatosFiscalesD
      Public Shared _SeccionID As String = "f3b161a4-dbe4-44ea-9259-b41dc8f88fc1"
      Public Shared _SeccionIDGUID As New Guid("f3b161a4-dbe4-44ea-9259-b41dc8f88fc1")
      Public Shared Async Function ConsultarDatos_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, ParamArray Valor As String()) As Task(Of List(Of DatosFiscalesC )) 
          Dim R As New List(Of DatosFiscalesC )  
          Dim d = Await DinaupSesion.ConexionServidor.Funcion_Datos_Recibir_Async(DinaupSesion, DatosFiscalesES._SeccionID, False, Campo, Valor) 
          If d.Datos.TieneDatos Then 
              For Each Actual In d.Datos 
                  Dim Valores_Listador = Actual.Value.Item1
                  Dim Obj_Listador As New DatosFiscalesC 
                  Obj_Listador.CargarDatos(Valores_Listador) 
                  R.Add(Obj_Listador) 
              Next 
          End If 
          Return R 
      End Function 
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As DatosFiscalesC, Optional CampoWhere$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Return Await DatosGuardar_Async(DinaupSesion, New List(Of DatosFiscalesC)({DAtos}), CampoWhere )
      End Function
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As List(Of DatosFiscalesC), Optional CampoWhere$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Dim Importar As New List(Of DinaupAPI_ImportacionProcesableC)
          For Each Actual In DAtos 
              Dim RegistroActual = New DinaupAPI_ImportacionProcesableC() 
               RegistroActual.dinaup_listador_datos = Actual.ToDic 
               Importar.Add(RegistroActual)  
          Next 
          Return Await DinaupSesion.ConexionServidor.Funcion_Importar_Ejecutar_Async(DinaupSesion, DatosFiscalesES._SeccionID, Importar, CampoWhere, "") 
      End Function
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As DatosFiscales_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, DatosFiscalesES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New DatosFiscales_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As DatosFiscales_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, DatosFiscalesES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New DatosFiscales_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class DatosFiscalesES
          Public shared _SeccionID as Guid = New Guid("f3b161a4-dbe4-44ea-9259-b41dc8f88fc1")
          Public shared _Tabla$ = "tpr_20040138792"
      Public Shared Telefono$ = "pr_50040138793"
      Public Shared ReferenciaDestinador$ = "pr_200401387916"
      Public Shared ExportarEnModulos$ = "pr_200401387914"
      Public Shared FechaAlta_UTC$ = "pr_200401387915"
      Public Shared HoraLocal$ = "pr_200401387913"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_200401387927"
      Public Shared NIF$ = "pr_30040138792"
      Public Shared ApellidosYNombreORazonSocial$ = "pr_30040138791"
      Public Shared ReferenciaAutorDelAlta$ = "pr_200401387911"
      Public Shared Pais$ = "pr_30040138793"
      Public Shared Municipio$ = "pr_30040138794"
      Public Shared EntidadTieneAccesoWeb$ = "pr_30040138797"
      Public Shared DireccionCompleta$ = "pr_40040138792"
      Public Shared Provincia$ = "pr_40040138791"
      Public Shared CodigoPostal$ = "pr_30040138795"
      Public Shared ReferenciaEntidad$ = "pr_30040138796"
      Public Shared ReferenciaUbicacion$ = "pr_50040138795"
      Public Shared Numero$ = "pr_60040242243"
      Public Shared CodigoPais$ = "pr_60040241502"
      Public Shared CodigoProvincia$ = "pr_60040241501"
      Public Shared TipoNIF$ = "pr_50040241502"
      Public Shared Puerta$ = "pr_60040242241"
      Public Shared CPlazaAvda$ = "pr_60040242242"
      Public Shared Piso$ = "pr_60040242244"
      Public Shared Escalera$ = "pr_60040242245"
      Public Shared DomicilioDireccion$ = "pr_10040242251"
      Public Shared Movil$ = "pr_10040242252"
      Public Shared Fax$ = "pr_10040242253"
      Public Shared EditarDireccionCompleta$ = "pr_20040242251"
      Public Shared NIFIntracomunitario$ = "pr_40040251451"
      Public Shared EsUnaPersonaFisica$ = "pr_50040254941"
      Public Shared ApellidosPersonaFisica$ = "pr_40040254941"
      Public Shared NombrePersonaFisica$ = "pr_40040254942"
      Public Shared Tipo$ = "pr_40040254952"
      Public Shared CodigoMunicipio$ = "pr_20040275833"
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
      Public Class DatosFiscalesC
      Inherits Base_DatoC
          <DisplayName("Teléfono")>
          Public Property Telefono As String
          Public Shared ___Telefono As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Telefono"",""etiqueta"": ""Teléfono"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 2,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Teléfono"",""descripcion"": """",""keyword"": ""Telefono"",""formato"": 5,""rol"": 2,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Telefono As DinaNETCore.APID.DinaupAPI_CampoC = ___Telefono
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
          <DisplayName("NIF")>
          Public Property NIF As String
          Public Shared ___NIF As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""NIF"",""etiqueta"": ""NIF"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 79,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""NIF"",""descripcion"": """",""keyword"": ""NIF"",""formato"": 5,""rol"": 79,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __NIF As DinaNETCore.APID.DinaupAPI_CampoC = ___NIF
          <Description("Si es una persona física se consignará el primer apellido, un
espacio, el segundo apellido, un espacio y el nombre
completo, necesariamente en este orden.
Para personas jurídicas y entidades sin personalidad jurídica,
se consignará la razón social completa o denominación, sin
anagrama.")>
          <DisplayName("Apellidos y Nombre o Razón social")>
          Public Property ApellidosYNombreORazonSocial As String
          Public Shared ___ApellidosYNombreORazonSocial As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ApellidosYNombreORazonSocial"",""etiqueta"": ""Apellidos y Nombre o Razón social"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Apellidos y Nombre o Razón social"",""descripcion"": """",""keyword"": ""ApellidosYNombreORazonSocial"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ApellidosYNombreORazonSocial As DinaNETCore.APID.DinaupAPI_CampoC = ___ApellidosYNombreORazonSocial
          <DisplayName("Autor del alta")>
          Public Property ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaAutorDelAlta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaAutorDelAlta"",""etiqueta"": ""Autor del alta"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta"",""descripcion"": """",""keyword"": ""ReferenciaAutorDelAlta"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaAutorDelAlta
          <DisplayName("País")>
          Public Property Pais As String
          Public Shared ___Pais As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Pais"",""etiqueta"": ""País"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 83,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""País"",""descripcion"": """",""keyword"": ""Pais"",""formato"": 5,""rol"": 83,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Pais As DinaNETCore.APID.DinaupAPI_CampoC = ___Pais
          <DisplayName("Municipio")>
          Public Property Municipio As String
          Public Shared ___Municipio As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Municipio"",""etiqueta"": ""Municipio"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Municipio"",""descripcion"": """",""keyword"": ""Municipio"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Municipio As DinaNETCore.APID.DinaupAPI_CampoC = ___Municipio
          <DisplayName("Entidad Tiene Acceso web")>
          Public Property EntidadTieneAccesoWeb As Boolean
          Public Shared ___EntidadTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EntidadTieneAccesoWeb"",""etiqueta"": ""Entidad Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Entidad Tiene Acceso web"",""descripcion"": """",""keyword"": ""EntidadTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EntidadTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___EntidadTieneAccesoWeb
          <DisplayName("Dirección Completa")>
          Public Property DireccionCompleta As String
          Public Shared ___DireccionCompleta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DireccionCompleta"",""etiqueta"": ""Dirección Completa"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 16,""decimales"": ""0"",""multilinea"": true,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Dirección Completa"",""descripcion"": """",""keyword"": ""DireccionCompleta"",""formato"": 5,""rol"": 16,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DireccionCompleta As DinaNETCore.APID.DinaupAPI_CampoC = ___DireccionCompleta
          <DisplayName("Provincia")>
          Public Property Provincia As String
          Public Shared ___Provincia As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Provincia"",""etiqueta"": ""Provincia"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 84,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Provincia"",""descripcion"": """",""keyword"": ""Provincia"",""formato"": 5,""rol"": 84,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Provincia As DinaNETCore.APID.DinaupAPI_CampoC = ___Provincia
          <DisplayName("Código postal")>
          Public Property CodigoPostal As String
          Public Shared ___CodigoPostal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CodigoPostal"",""etiqueta"": ""Código postal"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Código postal"",""descripcion"": """",""keyword"": ""CodigoPostal"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CodigoPostal As DinaNETCore.APID.DinaupAPI_CampoC = ___CodigoPostal
          <DisplayName("Entidad")>
          Public Property ReferenciaEntidad As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaEntidad As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaEntidad"",""etiqueta"": ""Entidad"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Entidad"",""descripcion"": """",""keyword"": ""ReferenciaEntidad"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaEntidad As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaEntidad
          <DisplayName("Ubicación")>
          Public Property ReferenciaUbicacion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaUbicacion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaUbicacion"",""etiqueta"": ""Ubicación"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""bffd6c6e-a75b-455f-8367-067e7bb2fb47"",""titulo"": ""Base - Ubicaciones"",""iconoid"": ""b985b58f-7275-46b8-9b66-2c54346b0185"",""etiquetasingular"": ""Ubicación"",""etiquetaplural"": ""Ubicaciones"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""bffd6c6e-a75b-455f-8367-067e7bb2fb47"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Ubicación"",""descripcion"": """",""keyword"": ""ReferenciaUbicacion"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaUbicacion As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaUbicacion
          <DisplayName("Número")>
          Public Property Numero As String
          Public Shared ___Numero As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Numero"",""etiqueta"": ""Número"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Número"",""descripcion"": """",""keyword"": ""Numero"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Numero As DinaNETCore.APID.DinaupAPI_CampoC = ___Numero
          <DisplayName("Código País")>
          Public Property CodigoPais As String
          Public Shared ___CodigoPais As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CodigoPais"",""etiqueta"": ""Código País"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 85,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Código País"",""descripcion"": """",""keyword"": ""CodigoPais"",""formato"": 5,""rol"": 85,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CodigoPais As DinaNETCore.APID.DinaupAPI_CampoC = ___CodigoPais
          <DisplayName("Código Provincia")>
          Public Property CodigoProvincia As String
          Public Shared ___CodigoProvincia As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CodigoProvincia"",""etiqueta"": ""Código Provincia"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 86,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Código Provincia"",""descripcion"": """",""keyword"": ""CodigoProvincia"",""formato"": 5,""rol"": 86,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CodigoProvincia As DinaNETCore.APID.DinaupAPI_CampoC = ___CodigoProvincia
          <DisplayName("Tipo NIF")>
          Public Property TipoNIF As String
          Public Shared ___TipoNIF As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TipoNIF"",""etiqueta"": ""Tipo NIF"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 87,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Tipo NIF"",""descripcion"": """",""keyword"": ""TipoNIF"",""formato"": 5,""rol"": 87,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __TipoNIF As DinaNETCore.APID.DinaupAPI_CampoC = ___TipoNIF
          <DisplayName("Puerta")>
          Public Property Puerta As String
          Public Shared ___Puerta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Puerta"",""etiqueta"": ""Puerta"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Puerta"",""descripcion"": """",""keyword"": ""Puerta"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Puerta As DinaNETCore.APID.DinaupAPI_CampoC = ___Puerta
          <DisplayName("C / Plaza / Avda")>
          Public Property CPlazaAvda As String
          Public Shared ___CPlazaAvda As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CPlazaAvda"",""etiqueta"": ""C / Plaza / Avda"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""C / Plaza / Avda"",""descripcion"": """",""keyword"": ""CPlazaAvda"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CPlazaAvda As DinaNETCore.APID.DinaupAPI_CampoC = ___CPlazaAvda
          <DisplayName("Piso")>
          Public Property Piso As String
          Public Shared ___Piso As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Piso"",""etiqueta"": ""Piso"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Piso"",""descripcion"": """",""keyword"": ""Piso"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Piso As DinaNETCore.APID.DinaupAPI_CampoC = ___Piso
          <DisplayName("Escalera")>
          Public Property Escalera As String
          Public Shared ___Escalera As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Escalera"",""etiqueta"": ""Escalera"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Escalera"",""descripcion"": """",""keyword"": ""Escalera"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Escalera As DinaNETCore.APID.DinaupAPI_CampoC = ___Escalera
          <DisplayName("Domicilio / Dirección")>
          Public Property DomicilioDireccion As String
          Public Shared ___DomicilioDireccion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DomicilioDireccion"",""etiqueta"": ""Domicilio / Dirección"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Domicilio / Dirección"",""descripcion"": """",""keyword"": ""DomicilioDireccion"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DomicilioDireccion As DinaNETCore.APID.DinaupAPI_CampoC = ___DomicilioDireccion
          <DisplayName("Móvil")>
          Public Property Movil As String
          Public Shared ___Movil As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Movil"",""etiqueta"": ""Móvil"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Móvil"",""descripcion"": """",""keyword"": ""Movil"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Movil As DinaNETCore.APID.DinaupAPI_CampoC = ___Movil
          <DisplayName("Fax")>
          Public Property Fax As String
          Public Shared ___Fax As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Fax"",""etiqueta"": ""Fax"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fax"",""descripcion"": """",""keyword"": ""Fax"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Fax As DinaNETCore.APID.DinaupAPI_CampoC = ___Fax
          <DisplayName("Editar dirección completa")>
          Public Property EditarDireccionCompleta As Boolean
          Public Shared ___EditarDireccionCompleta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EditarDireccionCompleta"",""etiqueta"": ""Editar dirección completa"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Editar dirección completa"",""descripcion"": """",""keyword"": ""EditarDireccionCompleta"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EditarDireccionCompleta As DinaNETCore.APID.DinaupAPI_CampoC = ___EditarDireccionCompleta
          <DisplayName("NIF Intracomunitario")>
          Public Property NIFIntracomunitario As String
          Public Shared ___NIFIntracomunitario As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""NIFIntracomunitario"",""etiqueta"": ""NIF Intracomunitario"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""NIF Intracomunitario"",""descripcion"": """",""keyword"": ""NIFIntracomunitario"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __NIFIntracomunitario As DinaNETCore.APID.DinaupAPI_CampoC = ___NIFIntracomunitario
          <DisplayName("Es una persona física")>
          Public Property EsUnaPersonaFisica As Boolean
          Public Shared ___EsUnaPersonaFisica As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EsUnaPersonaFisica"",""etiqueta"": ""Es una persona física"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Es una persona física"",""descripcion"": """",""keyword"": ""EsUnaPersonaFisica"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EsUnaPersonaFisica As DinaNETCore.APID.DinaupAPI_CampoC = ___EsUnaPersonaFisica
          <DisplayName("Apellidos (Persona física)")>
          Public Property ApellidosPersonaFisica As String
          Public Shared ___ApellidosPersonaFisica As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ApellidosPersonaFisica"",""etiqueta"": ""Apellidos (Persona física)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Apellidos (Persona física)"",""descripcion"": """",""keyword"": ""ApellidosPersonaFisica"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ApellidosPersonaFisica As DinaNETCore.APID.DinaupAPI_CampoC = ___ApellidosPersonaFisica
          <DisplayName("Nombre (Persona física)")>
          Public Property NombrePersonaFisica As String
          Public Shared ___NombrePersonaFisica As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""NombrePersonaFisica"",""etiqueta"": ""Nombre (Persona física)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Nombre (Persona física)"",""descripcion"": """",""keyword"": ""NombrePersonaFisica"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __NombrePersonaFisica As DinaNETCore.APID.DinaupAPI_CampoC = ___NombrePersonaFisica
          <DisplayName("Tipo")>
          Public Property Tipo As EnumTipoIdentificacionFiscalE
          Public Shared ___Tipo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Tipo"",""etiqueta"": ""Tipo"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 92,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24],""predefinidos_textos"": ["""",""DNI"",""K. Españoles menores de 14 años que carezcan de DNI"",""L. Españoles mayores de 14 años residentes en el extranjero y que no tengan DNI que se trasladan a España por un tiempo inferior a seis meses"",""M. Extranjeros sin NIE, de forma transitoria por estar obligados a tenerlo o bien de forma definitiva al no estar obligados a ello"",""X. Extranjeros residentes en España e identificados por la Policía con un número de identidad de extranjero (NIE), asignado hasta el 15 de julio de 2008. "",""Y. Extranjeros residentes en España e identificados por la Policía con un NIE"",""Z. Letra reservada para Extranjeros identificados por la Policía, para cuando se agoten los \u0027NIE Y\u0027"",""A. Sociedades anónimas"",""B. Sociedades de responsabilidad limitada"",""C. Sociedades colectivas"",""D. Sociedades comanditarias"",""E. Comunidades de bienes"",""F. Sociedades cooperativas"",""G. Asociaciones y Fundaciones"",""H. Comunidades de propietarios en régimen de propiedad horizontal"",""J. Sociedades civiles, con o sin personalidad jurídica"",""N. Entidades extranjeras"",""P. Corporaciones Locales"",""Q. Organismos públicos"",""R. Congregaciones e instituciones religiosas"",""S. Órganos de la Administración General del Estado y de las Comunidades Autónomas"",""U. Uniones Temporales de Empresas"",""V. Otros tipos no definidos en el resto de claves"",""W. Establecimientos permanentes de entidades no residentes en España""],""predefinidos_iconos"": [""https://cdn.dinaup.com/ico/enums/92_0.png"",""https://cdn.dinaup.com/ico/enums/92_1.png"",""https://cdn.dinaup.com/ico/enums/92_2.png"",""https://cdn.dinaup.com/ico/enums/92_3.png"",""https://cdn.dinaup.com/ico/enums/92_4.png"",""https://cdn.dinaup.com/ico/enums/92_5.png"",""https://cdn.dinaup.com/ico/enums/92_6.png"",""https://cdn.dinaup.com/ico/enums/92_7.png"",""https://cdn.dinaup.com/ico/enums/92_8.png"",""https://cdn.dinaup.com/ico/enums/92_9.png"",""https://cdn.dinaup.com/ico/enums/92_10.png"",""https://cdn.dinaup.com/ico/enums/92_11.png"",""https://cdn.dinaup.com/ico/enums/92_12.png"",""https://cdn.dinaup.com/ico/enums/92_13.png"",""https://cdn.dinaup.com/ico/enums/92_14.png"",""https://cdn.dinaup.com/ico/enums/92_15.png"",""https://cdn.dinaup.com/ico/enums/92_16.png"",""https://cdn.dinaup.com/ico/enums/92_17.png"",""https://cdn.dinaup.com/ico/enums/92_18.png"",""https://cdn.dinaup.com/ico/enums/92_19.png"",""https://cdn.dinaup.com/ico/enums/92_20.png"",""https://cdn.dinaup.com/ico/enums/92_21.png"",""https://cdn.dinaup.com/ico/enums/92_22.png"",""https://cdn.dinaup.com/ico/enums/92_23.png"",""https://cdn.dinaup.com/ico/enums/92_24.png""],""filtro"": {""titulo"": ""Tipo"",""descripcion"": """",""keyword"": ""Tipo"",""formato"": 2,""rol"": 92,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false,""enumeracion"": {""titulo"": ""Enum - TipoIdentificacion Fiscal"", ""valores"": [{""valor"": 0, ""titulo"": """"},{""valor"": 1, ""titulo"": ""DNI""},{""valor"": 2, ""titulo"": ""K. Españoles menores de 14 años que carezcan de DNI""},{""valor"": 3, ""titulo"": ""L. Españoles mayores de 14 años residentes en el extranjero y que no tengan DNI que se trasladan a España por un tiempo inferior a seis meses""},{""valor"": 4, ""titulo"": ""M. Extranjeros sin NIE, de forma transitoria por estar obligados a tenerlo o bien de forma definitiva al no estar obligados a ello""},{""valor"": 5, ""titulo"": ""X. Extranjeros residentes en España e identificados por la Policía con un número de identidad de extranjero (NIE), asignado hasta el 15 de julio de 2008. ""},{""valor"": 6, ""titulo"": ""Y. Extranjeros residentes en España e identificados por la Policía con un NIE""},{""valor"": 7, ""titulo"": ""Z. Letra reservada para Extranjeros identificados por la Policía, para cuando se agoten los \u0027NIE Y\u0027""},{""valor"": 8, ""titulo"": ""A. Sociedades anónimas""},{""valor"": 9, ""titulo"": ""B. Sociedades de responsabilidad limitada""},{""valor"": 10, ""titulo"": ""C. Sociedades colectivas""},{""valor"": 11, ""titulo"": ""D. Sociedades comanditarias""},{""valor"": 12, ""titulo"": ""E. Comunidades de bienes""},{""valor"": 13, ""titulo"": ""F. Sociedades cooperativas""},{""valor"": 14, ""titulo"": ""G. Asociaciones y Fundaciones""},{""valor"": 15, ""titulo"": ""H. Comunidades de propietarios en régimen de propiedad horizontal""},{""valor"": 16, ""titulo"": ""J. Sociedades civiles, con o sin personalidad jurídica""},{""valor"": 17, ""titulo"": ""N. Entidades extranjeras""},{""valor"": 18, ""titulo"": ""P. Corporaciones Locales""},{""valor"": 19, ""titulo"": ""Q. Organismos públicos""},{""valor"": 20, ""titulo"": ""R. Congregaciones e instituciones religiosas""},{""valor"": 21, ""titulo"": ""S. Órganos de la Administración General del Estado y de las Comunidades Autónomas""},{""valor"": 22, ""titulo"": ""U. Uniones Temporales de Empresas""},{""valor"": 23, ""titulo"": ""V. Otros tipos no definidos en el resto de claves""},{""valor"": 24, ""titulo"": ""W. Establecimientos permanentes de entidades no residentes en España""}]}},""solovalorespredefinidos"": true}")
          Public  __Tipo As DinaNETCore.APID.DinaupAPI_CampoC = ___Tipo
          <DisplayName("Código Municipio")>
          Public Property CodigoMunicipio As String
          Public Shared ___CodigoMunicipio As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CodigoMunicipio"",""etiqueta"": ""Código Municipio"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Código Municipio"",""descripcion"": """",""keyword"": ""CodigoMunicipio"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CodigoMunicipio As DinaNETCore.APID.DinaupAPI_CampoC = ___CodigoMunicipio
          <ReadOnlyAttribute(True)>
          <DisplayName("ID")>
          Public Property ID As Guid
          Public Shared ___ID As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": true,""eseliminado"": false,""keyword"": ""ID"",""etiqueta"": ""ID"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""f3b161a4-dbe4-44ea-9259-b41dc8f88fc1"",""titulo"": ""Datos fiscales"",""iconoid"": ""773d55f9-1e21-41f1-b0b0-f6a1dd370ea3"",""etiquetasingular"": ""Datos fiscales"",""etiquetaplural"": ""Datos fiscales"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""f3b161a4-dbe4-44ea-9259-b41dc8f88fc1"",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""ID"",""descripcion"": """",""keyword"": ""ID"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
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
          me.Telefono = _Datos.Leer_String("pr_50040138793")
          me.ReferenciaDestinador = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_200401387916"), _Datos.Leer_String("pr_200401387916.nombre"))
          me.FechaAlta_UTC = _Datos.Leer_DateTime_Nulable("pr_200401387915")
          me.HoraLocal = _Datos.Leer_Time_Nulable("pr_200401387913")
          me.AutorDelAltaTieneAccesoWeb = _Datos.Leer_Boolean("pr_200401387927")
          me.NIF = _Datos.Leer_String("pr_30040138792")
          me.ApellidosYNombreORazonSocial = _Datos.Leer_String("pr_30040138791")
          me.ReferenciaAutorDelAlta = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_200401387911"), _Datos.Leer_String("pr_200401387911.nombre"))
          me.Pais = _Datos.Leer_String("pr_30040138793")
          me.Municipio = _Datos.Leer_String("pr_30040138794")
          me.EntidadTieneAccesoWeb = _Datos.Leer_Boolean("pr_30040138797")
          me.DireccionCompleta = _Datos.Leer_String("pr_40040138792")
          me.Provincia = _Datos.Leer_String("pr_40040138791")
          me.CodigoPostal = _Datos.Leer_String("pr_30040138795")
          me.ReferenciaEntidad = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_30040138796"), _Datos.Leer_String("pr_30040138796.nombre"))
          me.ReferenciaUbicacion = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_50040138795"), _Datos.Leer_String("pr_50040138795.nombre"))
          me.Numero = _Datos.Leer_String("pr_60040242243")
          me.CodigoPais = _Datos.Leer_String("pr_60040241502")
          me.CodigoProvincia = _Datos.Leer_String("pr_60040241501")
          me.TipoNIF = _Datos.Leer_String("pr_50040241502")
          me.Puerta = _Datos.Leer_String("pr_60040242241")
          me.CPlazaAvda = _Datos.Leer_String("pr_60040242242")
          me.Piso = _Datos.Leer_String("pr_60040242244")
          me.Escalera = _Datos.Leer_String("pr_60040242245")
          me.DomicilioDireccion = _Datos.Leer_String("pr_10040242251")
          me.Movil = _Datos.Leer_String("pr_10040242252")
          me.Fax = _Datos.Leer_String("pr_10040242253")
          me.EditarDireccionCompleta = _Datos.Leer_Boolean("pr_20040242251")
          me.NIFIntracomunitario = _Datos.Leer_String("pr_40040251451")
          me.EsUnaPersonaFisica = _Datos.Leer_Boolean("pr_50040254941")
          me.ApellidosPersonaFisica = _Datos.Leer_String("pr_40040254941")
          me.NombrePersonaFisica = _Datos.Leer_String("pr_40040254942")
          me.Tipo = _Datos.Leer_EnumTipoIdentificacionFiscalE("pr_40040254952")
          me.CodigoMunicipio = _Datos.Leer_String("pr_20040275833")
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
         R.add("pr_50040138793", me.Telefono.AdaptarMySQL_String())
         If Me.ReferenciaDestinador IsNot nothing then
           R.add("pr_200401387916",me.ReferenciaDestinador.ID.STR())
         Else
           R.add("pr_200401387916","")
         End if
         R.add("pr_200401387915", me.FechaAlta_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_200401387913", me.HoraLocal.AdaptarMySQL_Time_Nulable())
         R.add("pr_200401387927", me.AutorDelAltaTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_30040138792", me.NIF.AdaptarMySQL_String())
         R.add("pr_30040138791", me.ApellidosYNombreORazonSocial.AdaptarMySQL_String())
         If Me.ReferenciaAutorDelAlta IsNot nothing then
           R.add("pr_200401387911",me.ReferenciaAutorDelAlta.ID.STR())
         Else
           R.add("pr_200401387911","")
         End if
         R.add("pr_30040138793", me.Pais.AdaptarMySQL_String())
         R.add("pr_30040138794", me.Municipio.AdaptarMySQL_String())
         R.add("pr_30040138797", me.EntidadTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_40040138792", me.DireccionCompleta.AdaptarMySQL_String())
         R.add("pr_40040138791", me.Provincia.AdaptarMySQL_String())
         R.add("pr_30040138795", me.CodigoPostal.AdaptarMySQL_String())
         If Me.ReferenciaEntidad IsNot nothing then
           R.add("pr_30040138796",me.ReferenciaEntidad.ID.STR())
         Else
           R.add("pr_30040138796","")
         End if
         If Me.ReferenciaUbicacion IsNot nothing then
           R.add("pr_50040138795",me.ReferenciaUbicacion.ID.STR())
         Else
           R.add("pr_50040138795","")
         End if
         R.add("pr_60040242243", me.Numero.AdaptarMySQL_String())
         R.add("pr_60040241502", me.CodigoPais.AdaptarMySQL_String())
         R.add("pr_60040241501", me.CodigoProvincia.AdaptarMySQL_String())
         R.add("pr_50040241502", me.TipoNIF.AdaptarMySQL_String())
         R.add("pr_60040242241", me.Puerta.AdaptarMySQL_String())
         R.add("pr_60040242242", me.CPlazaAvda.AdaptarMySQL_String())
         R.add("pr_60040242244", me.Piso.AdaptarMySQL_String())
         R.add("pr_60040242245", me.Escalera.AdaptarMySQL_String())
         R.add("pr_10040242251", me.DomicilioDireccion.AdaptarMySQL_String())
         R.add("pr_10040242252", me.Movil.AdaptarMySQL_String())
         R.add("pr_10040242253", me.Fax.AdaptarMySQL_String())
         R.add("pr_20040242251", me.EditarDireccionCompleta.AdaptarMySQL_Boolean())
         R.add("pr_40040251451", me.NIFIntracomunitario.AdaptarMySQL_String())
         R.add("pr_50040254941", me.EsUnaPersonaFisica.AdaptarMySQL_Boolean())
         R.add("pr_40040254941", me.ApellidosPersonaFisica.AdaptarMySQL_String())
         R.add("pr_40040254942", me.NombrePersonaFisica.AdaptarMySQL_String())
         R.add("pr_40040254952", me.Tipo.AdaptarMySQL_EnumTipoIdentificacionFiscalE())
         R.add("pr_20040275833", me.CodigoMunicipio.AdaptarMySQL_String())
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
      Public Class DatosFiscales_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
          Public property Telefono As String
            get
                return me.GetValue_String("pr_50040138793")
            End Get
            Set(value As String)
                me.SetValue_String("pr_50040138793", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_200401387916")
            End Get   
        End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_200401387915")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_200401387915", value)
            End Set
          End Property
        Public ReadOnly property HoraLocal As DateTime
            get
                return me.GetValue_DateTime("pr_200401387913")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_200401387927")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_200401387927", value)
            End Set
          End Property
          Public property NIF As String
            get
                return me.GetValue_String("pr_30040138792")
            End Get
            Set(value As String)
                me.SetValue_String("pr_30040138792", value)
            End Set
          End Property
          Public property ApellidosYNombreORazonSocial As String
            get
                return me.GetValue_String("pr_30040138791")
            End Get
            Set(value As String)
                me.SetValue_String("pr_30040138791", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_200401387911")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_200401387911", value)
            End Set
          End Property
          Public property Pais As String
            get
                return me.GetValue_String("pr_30040138793")
            End Get
            Set(value As String)
                me.SetValue_String("pr_30040138793", value)
            End Set
          End Property
          Public property Municipio As String
            get
                return me.GetValue_String("pr_30040138794")
            End Get
            Set(value As String)
                me.SetValue_String("pr_30040138794", value)
            End Set
          End Property
          Public property EntidadTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_30040138797")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_30040138797", value)
            End Set
          End Property
          Public property DireccionCompleta As String
            get
                return me.GetValue_String("pr_40040138792")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040138792", value)
            End Set
          End Property
          Public property Provincia As String
            get
                return me.GetValue_String("pr_40040138791")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040138791", value)
            End Set
          End Property
          Public property CodigoPostal As String
            get
                return me.GetValue_String("pr_30040138795")
            End Get
            Set(value As String)
                me.SetValue_String("pr_30040138795", value)
            End Set
          End Property
          Public property ReferenciaEntidad As Guid
            get
                return me.GetValue_Guid("pr_30040138796")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_30040138796", value)
            End Set
          End Property
          Public property ReferenciaUbicacion As Guid
            get
                return me.GetValue_Guid("pr_50040138795")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_50040138795", value)
            End Set
          End Property
          Public property Numero As String
            get
                return me.GetValue_String("pr_60040242243")
            End Get
            Set(value As String)
                me.SetValue_String("pr_60040242243", value)
            End Set
          End Property
          Public property CodigoPais As String
            get
                return me.GetValue_String("pr_60040241502")
            End Get
            Set(value As String)
                me.SetValue_String("pr_60040241502", value)
            End Set
          End Property
          Public property CodigoProvincia As String
            get
                return me.GetValue_String("pr_60040241501")
            End Get
            Set(value As String)
                me.SetValue_String("pr_60040241501", value)
            End Set
          End Property
          Public property TipoNIF As String
            get
                return me.GetValue_String("pr_50040241502")
            End Get
            Set(value As String)
                me.SetValue_String("pr_50040241502", value)
            End Set
          End Property
          Public property Puerta As String
            get
                return me.GetValue_String("pr_60040242241")
            End Get
            Set(value As String)
                me.SetValue_String("pr_60040242241", value)
            End Set
          End Property
          Public property CPlazaAvda As String
            get
                return me.GetValue_String("pr_60040242242")
            End Get
            Set(value As String)
                me.SetValue_String("pr_60040242242", value)
            End Set
          End Property
          Public property Piso As String
            get
                return me.GetValue_String("pr_60040242244")
            End Get
            Set(value As String)
                me.SetValue_String("pr_60040242244", value)
            End Set
          End Property
          Public property Escalera As String
            get
                return me.GetValue_String("pr_60040242245")
            End Get
            Set(value As String)
                me.SetValue_String("pr_60040242245", value)
            End Set
          End Property
          Public property DomicilioDireccion As String
            get
                return me.GetValue_String("pr_10040242251")
            End Get
            Set(value As String)
                me.SetValue_String("pr_10040242251", value)
            End Set
          End Property
          Public property Movil As String
            get
                return me.GetValue_String("pr_10040242252")
            End Get
            Set(value As String)
                me.SetValue_String("pr_10040242252", value)
            End Set
          End Property
          Public property Fax As String
            get
                return me.GetValue_String("pr_10040242253")
            End Get
            Set(value As String)
                me.SetValue_String("pr_10040242253", value)
            End Set
          End Property
          Public property EditarDireccionCompleta As Boolean
            get
                return me.GetValue_Boolean("pr_20040242251")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_20040242251", value)
            End Set
          End Property
          Public property NIFIntracomunitario As String
            get
                return me.GetValue_String("pr_40040251451")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040251451", value)
            End Set
          End Property
          Public property EsUnaPersonaFisica As Boolean
            get
                return me.GetValue_Boolean("pr_50040254941")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_50040254941", value)
            End Set
          End Property
          Public property ApellidosPersonaFisica As String
            get
                return me.GetValue_String("pr_40040254941")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040254941", value)
            End Set
          End Property
          Public property NombrePersonaFisica As String
            get
                return me.GetValue_String("pr_40040254942")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040254942", value)
            End Set
          End Property
          Public property Tipo__Int as Integer
            get
                return me.GetValue_Int("pr_40040254952")
            End Get
            Set(value as Integer)
                me.SetValue_Int("pr_40040254952", value)
            End Set
          End Property
          Public property Tipo As EnumTipoIdentificacionFiscalE
            get
                return me.GetValue_Int("pr_40040254952")
            End Get
            Set(value As EnumTipoIdentificacionFiscalE)
                me.SetValue_Int("pr_40040254952", value)
            End Set
          End Property
          Public property CodigoMunicipio As String
            get
                return me.GetValue_String("pr_20040275833")
            End Get
            Set(value As String)
                me.SetValue_String("pr_20040275833", value)
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
