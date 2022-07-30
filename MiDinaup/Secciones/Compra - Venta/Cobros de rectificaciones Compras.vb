   Imports System.ComponentModel
   Imports DinaNETCore
   Imports DinaNETCore.APID
Partial Public Class SeccionesD
  Public Class CobrosDeRectificacionesComprasD
      Public Shared _SeccionID As String = "0522ab28-8c49-4776-a43d-5acaf4d1833f"
      Public Shared _SeccionIDGUID As New Guid("0522ab28-8c49-4776-a43d-5acaf4d1833f")
      Public Shared Async Function ConsultarDatos_Async(Parametros As SeccionConsultaParametrosC) As Task(Of List(Of CobrosDeRectificacionesComprasC )) 
          Dim R As New List(Of CobrosDeRectificacionesComprasC )  
          Dim d = Await Parametros.DinaupSesion.ConexionServidor.Funcion_Datos_Recibir_Async(CobrosDeRectificacionesComprasES._SeccionID, False, Parametros) 
          If d.Datos.TieneDatos Then 
              For Each Actual In d.Datos 
                  Dim Valores_Listador = Actual.Value.Item1
                  Dim Obj_Listador As New CobrosDeRectificacionesComprasC 
                  Obj_Listador.CargarDatos(Valores_Listador) 
                  Obj_Listador.CargaInterna(Actual.Value)
                  R.Add(Obj_Listador) 
              Next 
          End If 
          Return R 
      End Function 
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As CobrosDeRectificacionesComprasC, Optional CampoWhere$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Return Await DatosGuardar_Async(DinaupSesion, New List(Of CobrosDeRectificacionesComprasC)({DAtos}), CampoWhere )
      End Function
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As List(Of CobrosDeRectificacionesComprasC), Optional CampoWhere$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Dim Importar As New List(Of DinaupAPI_ImportacionProcesableC)
          For Each Actual In DAtos 
              Dim RegistroActual = New DinaupAPI_ImportacionProcesableC() 
               RegistroActual.dinaup_listador_datos = Actual.ToDic 
               Importar.Add(RegistroActual)  
          Next 
          Return Await DinaupSesion.ConexionServidor.Funcion_Importar_Ejecutar_Async(DinaupSesion, CobrosDeRectificacionesComprasES._SeccionID, Importar, CampoWhere, "") 
      End Function
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As CobrosDeRectificacionesCompras_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, CobrosDeRectificacionesComprasES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New CobrosDeRectificacionesCompras_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As CobrosDeRectificacionesCompras_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, CobrosDeRectificacionesComprasES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New CobrosDeRectificacionesCompras_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class CobrosDeRectificacionesComprasES
          Public shared _SeccionID as Guid = New Guid("0522ab28-8c49-4776-a43d-5acaf4d1833f")
          Public shared _Tabla$ = "tpr_20040105871"
      Public Shared ReferenciaPuestoDeTrabajo$ = "pr_300401060687"
      Public Shared ReferenciaAutorDelAlta$ = "pr_10040105877"
      Public Shared ReferenciaProveedor$ = "pr_300401060688"
      Public Shared ImporteImporteAfectadoADepositoTramitado$ = "pr_300401060697"
      Public Shared ReferenciaCompraRectificativaO1$ = "pr_100401058761"
      Public Shared ImporteImporteAfectadoADeposito$ = "pr_300401060698"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_100401058730"
      Public Shared FechaDeVencimiento$ = "pr_3004010606106"
      Public Shared Observaciones$ = "pr_3004010606108"
      Public Shared Estado$ = "pr_3004010606103"
      Public Shared FechaAlta_UTC$ = "pr_100401058711"
      Public Shared ReferenciaTransaccionMonetariaInterna$ = "pr_60040106111"
      Public Shared ImporteTotalPagadoTramitado$ = "pr_300401060699"
      Public Shared FechaDato_UTC$ = "pr_10040105878"
      Public Shared ReferenciaTransaccionSecundaria$ = "pr_20040114144"
      Public Shared ImporteTotalCobrado$ = "pr_3004010606100"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_10040105875"
      Public Shared DevolucionTramitadaYValidadaObsoleto$ = "pr_3004010606104"
      Public Shared ReferenciaMetodoDePagoDevolucionObsoleto$ = "pr_300401060689"
      Public Shared FechaDeTramitacionYValidacionDevolucionObsoleto_UTC$ = "pr_300401060695"
      Public Shared FechaDeVencimientoDevolucionObsoleto$ = "pr_3004010606107"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_100401058729"
      Public Shared ReferenciaMetodoDePago$ = "pr_300401060690"
      Public Shared ImporteImporte$ = "pr_3004010606101"
      Public Shared ProveedorTieneAccesoWeb$ = "pr_300401060694"
      Public Shared TodoTramitadoYValidado$ = "pr_3004010606105"
      Public Shared ReferenciaDepositoMonetario$ = "pr_300401060691"
      Public Shared HoraLocal$ = "pr_10040105879"
      Public Shared ReferenciaDestinador$ = "pr_100401058714"
      Public Shared ImporteImporteDevolucion$ = "pr_3004010606102"
      Public Shared ReferenciaEmisionDeChequeOPagare$ = "pr_300401060692"
      Public Shared FechaDeTramitacionYValidacion_UTC$ = "pr_300401060696"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_10040105876"
      Public Shared ReferenciaEmisionDeChequeOPagareDevolucion$ = "pr_300401060693"
      Public Shared FechaContable$ = "pr_60040135703"
      Public Shared ReferenciaAsientoContable$ = "pr_50040135301"
      Public Shared ReferenciaEmpleadoQueTramitaYValida$ = "pr_20040141241"
      Public Shared FechaLocalDeTramitacionYValidacion$ = "pr_20040141261"
      Public Shared EmpleadoQueTramitaYValidaTieneAccesoWeb$ = "pr_20040141242"
      Public Shared ReferenciaCompraOrigen$ = "pr_30040242023"
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
      Public Class CobrosDeRectificacionesComprasC
      Inherits Base_DatoC
          <DisplayName("Puesto de trabajo")>
          Public Property ReferenciaPuestoDeTrabajo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaPuestoDeTrabajo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaPuestoDeTrabajo"",""etiqueta"": ""Puesto de trabajo"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""f777486d-e709-41be-9211-d9c6b4bb05d6"",""titulo"": ""Base - Puestos de trabajo"",""iconoid"": ""5d7008ed-1e2f-4dbe-a376-6261de330414"",""etiquetasingular"": ""Puesto de trabajo"",""etiquetaplural"": ""Puestos de trabajo"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""f777486d-e709-41be-9211-d9c6b4bb05d6"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Puesto de trabajo"",""descripcion"": """",""keyword"": ""ReferenciaPuestoDeTrabajo"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaPuestoDeTrabajo As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaPuestoDeTrabajo
          <DisplayName("Autor del alta")>
          Public Property ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaAutorDelAlta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaAutorDelAlta"",""etiqueta"": ""Autor del alta"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta"",""descripcion"": """",""keyword"": ""ReferenciaAutorDelAlta"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaAutorDelAlta
          <DisplayName("Proveedor")>
          Public Property ReferenciaProveedor As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaProveedor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaProveedor"",""etiqueta"": ""Proveedor"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Proveedor"",""descripcion"": """",""keyword"": ""ReferenciaProveedor"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaProveedor As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaProveedor
          <DisplayName("Importe afectado a depósito (Tramitado)")>
          Public Property ImporteImporteAfectadoADepositoTramitado As Decimal
          Public Shared ___ImporteImporteAfectadoADepositoTramitado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteImporteAfectadoADepositoTramitado"",""etiqueta"": ""Importe afectado a depósito (Tramitado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Importe afectado a depósito (Tramitado)"",""descripcion"": """",""keyword"": ""ImporteImporteAfectadoADepositoTramitado"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteImporteAfectadoADepositoTramitado As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteImporteAfectadoADepositoTramitado
          <DisplayName("Compra rectificativa (o1)")>
          Public Property ReferenciaCompraRectificativaO1 As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaCompraRectificativaO1 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaCompraRectificativaO1"",""etiqueta"": ""Compra rectificativa (o1)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""fecd2787-c7cf-415d-8f69-32abd415f948"",""titulo"": ""Base - Compras rectificativas"",""iconoid"": ""28ad3bf4-ea68-470a-90d5-949d6f88da18"",""etiquetasingular"": ""Compra rectificativa"",""etiquetaplural"": ""Compras rectificativas"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""fecd2787-c7cf-415d-8f69-32abd415f948"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Compra rectificativa (o1)"",""descripcion"": """",""keyword"": ""ReferenciaCompraRectificativaO1"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaCompraRectificativaO1 As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaCompraRectificativaO1
          <DisplayName("Importe afectado a depósito")>
          Public Property ImporteImporteAfectadoADeposito As Decimal
          Public Shared ___ImporteImporteAfectadoADeposito As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteImporteAfectadoADeposito"",""etiqueta"": ""Importe afectado a depósito"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Importe afectado a depósito"",""descripcion"": """",""keyword"": ""ImporteImporteAfectadoADeposito"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteImporteAfectadoADeposito As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteImporteAfectadoADeposito
          <DisplayName("Empleado Tiene Acceso web")>
          Public Property EmpleadoTieneAccesoWeb As Boolean
          Public Shared ___EmpleadoTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EmpleadoTieneAccesoWeb"",""etiqueta"": ""Empleado Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empleado Tiene Acceso web"",""descripcion"": """",""keyword"": ""EmpleadoTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EmpleadoTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___EmpleadoTieneAccesoWeb
          <DisplayName("Fecha de vencimiento")>
          Public Property FechaDeVencimiento As Date?
          Public Shared ___FechaDeVencimiento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaDeVencimiento"",""etiqueta"": ""Fecha de vencimiento"",""oculta"": false,""formato"": 7,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha de vencimiento"",""descripcion"": """",""keyword"": ""FechaDeVencimiento"",""formato"": 7,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaDeVencimiento As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaDeVencimiento
          <Description("Puede usar este campo, para dejar registro de información que" & vbCrLf & "la persona encargada considere importante.")>
          <DisplayName("Observaciones")>
          Public Property Observaciones As String
          Public Shared ___Observaciones As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Observaciones"",""etiqueta"": ""Observaciones"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 9,""decimales"": ""0"",""multilinea"": true,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Observaciones"",""descripcion"": """",""keyword"": ""Observaciones"",""formato"": 5,""rol"": 9,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Observaciones As DinaNETCore.APID.DinaupAPI_CampoC = ___Observaciones
          <DisplayName("Estado")>
          Public Property Estado As EnumTramitacionE
          Public Shared ___Estado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Estado"",""etiqueta"": ""Estado"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 48,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [0,1,2,3],""predefinidos_textos"": [""Indefinido"",""Pendiente"",""Tramitado"",""Cancelado""],""predefinidos_iconos"": [""https://cdn.dinaup.com/ico/enums/48_0.png"",""https://cdn.dinaup.com/ico/enums/48_1.png"",""https://cdn.dinaup.com/ico/enums/48_2.png"",""https://cdn.dinaup.com/ico/enums/48_3.png""],""filtro"": {""titulo"": ""Estado"",""descripcion"": """",""keyword"": ""Estado"",""formato"": 2,""rol"": 48,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false,""enumeracion"": {""titulo"": ""Enum - Tramitación"", ""valores"": [{""valor"": 0, ""titulo"": ""Indefinido""},{""valor"": 1, ""titulo"": ""Pendiente""},{""valor"": 2, ""titulo"": ""Tramitado""},{""valor"": 3, ""titulo"": ""Cancelado""}]}},""solovalorespredefinidos"": true}")
          Public  __Estado As DinaNETCore.APID.DinaupAPI_CampoC = ___Estado
          <DisplayName("Fecha Alta del registro")>
          Public Property FechaAlta_UTC As Date?
          Public Shared ___FechaAlta_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaAlta_UTC"",""etiqueta"": ""Fecha Alta del registro"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Alta del registro"",""descripcion"": """",""keyword"": ""FechaAlta_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaAlta_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaAlta_UTC
          <DisplayName("Transacción monetaria interna")>
          Public Property ReferenciaTransaccionMonetariaInterna As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaTransaccionMonetariaInterna As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaTransaccionMonetariaInterna"",""etiqueta"": ""Transacción monetaria interna"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""2d23ee9b-d9d5-4546-9200-9937ce2c0638"",""titulo"": ""Transacciones monetarias internas"",""iconoid"": ""c17a70cf-f1f8-410e-ad7d-c07041338177"",""etiquetasingular"": ""Transacción monetaria interna"",""etiquetaplural"": ""Transacciones monetarias internas"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""2d23ee9b-d9d5-4546-9200-9937ce2c0638"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Transacción monetaria interna"",""descripcion"": """",""keyword"": ""ReferenciaTransaccionMonetariaInterna"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaTransaccionMonetariaInterna As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaTransaccionMonetariaInterna
          <DisplayName("Total pagado (Tramitado)")>
          Public Property ImporteTotalPagadoTramitado As Decimal
          Public Shared ___ImporteTotalPagadoTramitado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteTotalPagadoTramitado"",""etiqueta"": ""Total pagado (Tramitado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total pagado (Tramitado)"",""descripcion"": """",""keyword"": ""ImporteTotalPagadoTramitado"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteTotalPagadoTramitado As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteTotalPagadoTramitado
          <DisplayName("Fecha Dato")>
          Public Property FechaDato_UTC As Date?
          Public Shared ___FechaDato_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaDato_UTC"",""etiqueta"": ""Fecha Dato"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Dato"",""descripcion"": """",""keyword"": ""FechaDato_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaDato_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaDato_UTC
          <DisplayName("Transacción secundaria")>
          Public Property ReferenciaTransaccionSecundaria As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaTransaccionSecundaria As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaTransaccionSecundaria"",""etiqueta"": ""Transacción secundaria"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""666178a9-3df8-4fc2-a66a-3c3698898c24"",""titulo"": ""Transacciones monetarias secundarias internas"",""iconoid"": ""c17a70cf-f1f8-410e-ad7d-c07041338177"",""etiquetasingular"": ""Transacción secundaria interna"",""etiquetaplural"": ""Transacciones monetarias secundarias internas"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""666178a9-3df8-4fc2-a66a-3c3698898c24"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Transacción secundaria"",""descripcion"": """",""keyword"": ""ReferenciaTransaccionSecundaria"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaTransaccionSecundaria As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaTransaccionSecundaria
          <DisplayName("Total Cobrado")>
          Public Property ImporteTotalCobrado As Decimal
          Public Shared ___ImporteTotalCobrado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteTotalCobrado"",""etiqueta"": ""Total Cobrado"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total Cobrado"",""descripcion"": """",""keyword"": ""ImporteTotalCobrado"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteTotalCobrado As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteTotalCobrado
          <DisplayName("Empleado")>
          Public Property ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaEmpleadoPrincipal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaEmpleadoPrincipal"",""etiqueta"": ""Empleado"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c6e071c7-776f-4300-aa55-c711fd1da916"",""titulo"": ""Empleados"",""iconoid"": ""1c8abf82-640c-4d18-b62c-89de310923dd"",""etiquetasingular"": ""Empleado"",""etiquetaplural"": ""Empleados"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""c6e071c7-776f-4300-aa55-c711fd1da916"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empleado"",""descripcion"": """",""keyword"": ""ReferenciaEmpleadoPrincipal"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaEmpleadoPrincipal
          <DisplayName("Devolución tramitada y validada (Obsoleto)")>
          Public Property DevolucionTramitadaYValidadaObsoleto As EnumTramitacionE
          Public Shared ___DevolucionTramitadaYValidadaObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DevolucionTramitadaYValidadaObsoleto"",""etiqueta"": ""Devolución tramitada y validada (Obsoleto)"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 48,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [0,1,2,3],""predefinidos_textos"": [""Indefinido"",""Pendiente"",""Tramitado"",""Cancelado""],""predefinidos_iconos"": [""https://cdn.dinaup.com/ico/enums/48_0.png"",""https://cdn.dinaup.com/ico/enums/48_1.png"",""https://cdn.dinaup.com/ico/enums/48_2.png"",""https://cdn.dinaup.com/ico/enums/48_3.png""],""filtro"": {""titulo"": ""Devolución tramitada y validada (Obsoleto)"",""descripcion"": """",""keyword"": ""DevolucionTramitadaYValidadaObsoleto"",""formato"": 2,""rol"": 48,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false,""enumeracion"": {""titulo"": ""Enum - Tramitación"", ""valores"": [{""valor"": 0, ""titulo"": ""Indefinido""},{""valor"": 1, ""titulo"": ""Pendiente""},{""valor"": 2, ""titulo"": ""Tramitado""},{""valor"": 3, ""titulo"": ""Cancelado""}]}},""solovalorespredefinidos"": true}")
          Public  __DevolucionTramitadaYValidadaObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___DevolucionTramitadaYValidadaObsoleto
          <DisplayName("Método de pago (Devolución) (Obsoleto)")>
          Public Property ReferenciaMetodoDePagoDevolucionObsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaMetodoDePagoDevolucionObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaMetodoDePagoDevolucionObsoleto"",""etiqueta"": ""Método de pago (Devolución) (Obsoleto)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""b22b7c8f-35b9-494f-8c4c-dec035a7760d"",""titulo"": ""Base - Métodos de pago"",""iconoid"": ""f72dab6e-3c9f-47cf-a0dd-d27ce9cd64b8"",""etiquetasingular"": ""Método de pago"",""etiquetaplural"": ""Métodos de pago"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""b22b7c8f-35b9-494f-8c4c-dec035a7760d"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Método de pago (Devolución) (Obsoleto)"",""descripcion"": """",""keyword"": ""ReferenciaMetodoDePagoDevolucionObsoleto"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaMetodoDePagoDevolucionObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaMetodoDePagoDevolucionObsoleto
          <DisplayName("Fecha de tramitación y validación (Devolución) (Obsoleto)")>
          Public Property FechaDeTramitacionYValidacionDevolucionObsoleto_UTC As Date?
          Public Shared ___FechaDeTramitacionYValidacionDevolucionObsoleto_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaDeTramitacionYValidacionDevolucionObsoleto_UTC"",""etiqueta"": ""Fecha de tramitación y validación (Devolución) (Obsoleto)"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha de tramitación y validación (Devolución) (Obsoleto)"",""descripcion"": """",""keyword"": ""FechaDeTramitacionYValidacionDevolucionObsoleto_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaDeTramitacionYValidacionDevolucionObsoleto_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaDeTramitacionYValidacionDevolucionObsoleto_UTC
          <DisplayName("Fecha de vencimiento (Devolución) (Obsoleto)")>
          Public Property FechaDeVencimientoDevolucionObsoleto As Date?
          Public Shared ___FechaDeVencimientoDevolucionObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaDeVencimientoDevolucionObsoleto"",""etiqueta"": ""Fecha de vencimiento (Devolución) (Obsoleto)"",""oculta"": false,""formato"": 7,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha de vencimiento (Devolución) (Obsoleto)"",""descripcion"": """",""keyword"": ""FechaDeVencimientoDevolucionObsoleto"",""formato"": 7,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaDeVencimientoDevolucionObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaDeVencimientoDevolucionObsoleto
          <DisplayName("Autor del alta Tiene Acceso web")>
          Public Property AutorDelAltaTieneAccesoWeb As Boolean
          Public Shared ___AutorDelAltaTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AutorDelAltaTieneAccesoWeb"",""etiqueta"": ""Autor del alta Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta Tiene Acceso web"",""descripcion"": """",""keyword"": ""AutorDelAltaTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AutorDelAltaTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___AutorDelAltaTieneAccesoWeb
          <DisplayName("Método de pago")>
          Public Property ReferenciaMetodoDePago As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaMetodoDePago As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaMetodoDePago"",""etiqueta"": ""Método de pago"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""b22b7c8f-35b9-494f-8c4c-dec035a7760d"",""titulo"": ""Base - Métodos de pago"",""iconoid"": ""f72dab6e-3c9f-47cf-a0dd-d27ce9cd64b8"",""etiquetasingular"": ""Método de pago"",""etiquetaplural"": ""Métodos de pago"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""b22b7c8f-35b9-494f-8c4c-dec035a7760d"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Método de pago"",""descripcion"": """",""keyword"": ""ReferenciaMetodoDePago"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaMetodoDePago As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaMetodoDePago
          <DisplayName("Importe")>
          Public Property ImporteImporte As Decimal
          Public Shared ___ImporteImporte As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteImporte"",""etiqueta"": ""Importe"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Importe"",""descripcion"": """",""keyword"": ""ImporteImporte"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteImporte As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteImporte
          <DisplayName("Proveedor Tiene Acceso web")>
          Public Property ProveedorTieneAccesoWeb As Boolean
          Public Shared ___ProveedorTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ProveedorTieneAccesoWeb"",""etiqueta"": ""Proveedor Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Proveedor Tiene Acceso web"",""descripcion"": """",""keyword"": ""ProveedorTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ProveedorTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___ProveedorTieneAccesoWeb
          <DisplayName("Todo tramitado y validado (Obsoleto)")>
          Public Property TodoTramitadoYValidado As Boolean
          Public Shared ___TodoTramitadoYValidado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TodoTramitadoYValidado"",""etiqueta"": ""Todo tramitado y validado (Obsoleto)"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Todo tramitado y validado (Obsoleto)"",""descripcion"": """",""keyword"": ""TodoTramitadoYValidado"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __TodoTramitadoYValidado As DinaNETCore.APID.DinaupAPI_CampoC = ___TodoTramitadoYValidado
          <DisplayName("Depósito monetario")>
          Public Property ReferenciaDepositoMonetario As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaDepositoMonetario As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaDepositoMonetario"",""etiqueta"": ""Depósito monetario"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""cab2cf42-3cf6-4aa6-9930-c7ee704650bc"",""titulo"": ""Base - Depósitos monetarios"",""iconoid"": ""f037928c-b088-47e4-a79e-3d217109403b"",""etiquetasingular"": ""Depósito monetario"",""etiquetaplural"": ""Depósitos monetarios"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""cab2cf42-3cf6-4aa6-9930-c7ee704650bc"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Depósito monetario"",""descripcion"": """",""keyword"": ""ReferenciaDepositoMonetario"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaDepositoMonetario As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaDepositoMonetario
          <DisplayName("Hora local")>
          Public Property HoraLocal As DateTime?
          Public Shared ___HoraLocal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""HoraLocal"",""etiqueta"": ""Hora local"",""oculta"": false,""formato"": 8,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Hora local"",""descripcion"": """",""keyword"": ""HoraLocal"",""formato"": 8,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __HoraLocal As DinaNETCore.APID.DinaupAPI_CampoC = ___HoraLocal
          <DisplayName("Destinador")>
          Public Property ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaDestinador As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaDestinador"",""etiqueta"": ""Destinador"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""relacionesindirectas"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Destinador"",""descripcion"": """",""keyword"": ""ReferenciaDestinador"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaDestinador
          <DisplayName("Importe (Devolución)")>
          Public Property ImporteImporteDevolucion As Decimal
          Public Shared ___ImporteImporteDevolucion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteImporteDevolucion"",""etiqueta"": ""Importe (Devolución)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Importe (Devolución)"",""descripcion"": """",""keyword"": ""ImporteImporteDevolucion"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteImporteDevolucion As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteImporteDevolucion
          <DisplayName("Emisión de Cheque o Pagaré")>
          Public Property ReferenciaEmisionDeChequeOPagare As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaEmisionDeChequeOPagare As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaEmisionDeChequeOPagare"",""etiqueta"": ""Emisión de Cheque o Pagaré"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c898ba20-5858-41d1-a368-0fd478150623"",""titulo"": ""Base - Cheques y Pagares"",""iconoid"": ""6ca6f3c8-0971-4221-bebe-489130891aad"",""etiquetasingular"": ""Documento de pago"",""etiquetaplural"": ""Documentos de pago"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""c898ba20-5858-41d1-a368-0fd478150623"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Emisión de Cheque o Pagaré"",""descripcion"": """",""keyword"": ""ReferenciaEmisionDeChequeOPagare"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaEmisionDeChequeOPagare As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaEmisionDeChequeOPagare
          <DisplayName("Fecha de tramitación y validación")>
          Public Property FechaDeTramitacionYValidacion_UTC As Date?
          Public Shared ___FechaDeTramitacionYValidacion_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaDeTramitacionYValidacion_UTC"",""etiqueta"": ""Fecha de tramitación y validación"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha de tramitación y validación"",""descripcion"": """",""keyword"": ""FechaDeTramitacionYValidacion_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaDeTramitacionYValidacion_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaDeTramitacionYValidacion_UTC
          <DisplayName("Ubicación Principal")>
          Public Property ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaUbicacionPrincipal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaUbicacionPrincipal"",""etiqueta"": ""Ubicación Principal"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""b9adbfbf-a81a-45fb-861c-90502902c982"",""titulo"": ""Ubicaciones"",""iconoid"": ""b985b58f-7275-46b8-9b66-2c54346b0185"",""etiquetasingular"": ""Ubicación"",""etiquetaplural"": ""Ubicaciones"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""b9adbfbf-a81a-45fb-861c-90502902c982"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Ubicación Principal"",""descripcion"": """",""keyword"": ""ReferenciaUbicacionPrincipal"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaUbicacionPrincipal
          <DisplayName("Emisión de Cheque o pagaré (Devolución)")>
          Public Property ReferenciaEmisionDeChequeOPagareDevolucion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaEmisionDeChequeOPagareDevolucion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaEmisionDeChequeOPagareDevolucion"",""etiqueta"": ""Emisión de Cheque o pagaré (Devolución)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c898ba20-5858-41d1-a368-0fd478150623"",""titulo"": ""Base - Cheques y Pagares"",""iconoid"": ""6ca6f3c8-0971-4221-bebe-489130891aad"",""etiquetasingular"": ""Documento de pago"",""etiquetaplural"": ""Documentos de pago"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""c898ba20-5858-41d1-a368-0fd478150623"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Emisión de Cheque o pagaré (Devolución)"",""descripcion"": """",""keyword"": ""ReferenciaEmisionDeChequeOPagareDevolucion"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaEmisionDeChequeOPagareDevolucion As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaEmisionDeChequeOPagareDevolucion
          <DisplayName("Fecha contable")>
          Public Property FechaContable As Date?
          Public Shared ___FechaContable As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaContable"",""etiqueta"": ""Fecha contable"",""oculta"": false,""formato"": 7,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 69,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha contable"",""descripcion"": """",""keyword"": ""FechaContable"",""formato"": 7,""rol"": 69,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaContable As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaContable
          <DisplayName("Asiento contable")>
          Public Property ReferenciaAsientoContable As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaAsientoContable As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaAsientoContable"",""etiqueta"": ""Asiento contable"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c4608471-b749-46fd-a0eb-d82dda66dcc8"",""titulo"": ""Base - Asientos contables"",""iconoid"": ""226684b8-fe3c-46a7-8f24-7462e48c0027"",""etiquetasingular"": ""Asiento contable"",""etiquetaplural"": ""Asientos contables"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""c4608471-b749-46fd-a0eb-d82dda66dcc8"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Asiento contable"",""descripcion"": """",""keyword"": ""ReferenciaAsientoContable"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaAsientoContable As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaAsientoContable
          <DisplayName("Empleado que tramita y valida")>
          Public Property ReferenciaEmpleadoQueTramitaYValida As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaEmpleadoQueTramitaYValida As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaEmpleadoQueTramitaYValida"",""etiqueta"": ""Empleado que tramita y valida"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c6e071c7-776f-4300-aa55-c711fd1da916"",""titulo"": ""Empleados"",""iconoid"": ""1c8abf82-640c-4d18-b62c-89de310923dd"",""etiquetasingular"": ""Empleado"",""etiquetaplural"": ""Empleados"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""c6e071c7-776f-4300-aa55-c711fd1da916"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empleado que tramita y valida"",""descripcion"": """",""keyword"": ""ReferenciaEmpleadoQueTramitaYValida"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaEmpleadoQueTramitaYValida As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaEmpleadoQueTramitaYValida
          <DisplayName("Fecha local de tramitación y validación")>
          Public Property FechaLocalDeTramitacionYValidacion As Date?
          Public Shared ___FechaLocalDeTramitacionYValidacion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaLocalDeTramitacionYValidacion"",""etiqueta"": ""Fecha local de tramitación y validación"",""oculta"": false,""formato"": 7,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha local de tramitación y validación"",""descripcion"": """",""keyword"": ""FechaLocalDeTramitacionYValidacion"",""formato"": 7,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaLocalDeTramitacionYValidacion As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaLocalDeTramitacionYValidacion
          <DisplayName("Empleado que tramita y valida Tiene Acceso web")>
          Public Property EmpleadoQueTramitaYValidaTieneAccesoWeb As Boolean
          Public Shared ___EmpleadoQueTramitaYValidaTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EmpleadoQueTramitaYValidaTieneAccesoWeb"",""etiqueta"": ""Empleado que tramita y valida Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empleado que tramita y valida Tiene Acceso web"",""descripcion"": """",""keyword"": ""EmpleadoQueTramitaYValidaTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EmpleadoQueTramitaYValidaTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___EmpleadoQueTramitaYValidaTieneAccesoWeb
          <DisplayName("Compra (Origen)")>
          Public Property ReferenciaCompraOrigen As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaCompraOrigen As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaCompraOrigen"",""etiqueta"": ""Compra (Origen)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""340bde1f-cdc9-4471-b55e-44b9c96dd508"",""titulo"": ""Base - Compras y Gastos"",""iconoid"": ""5686dc42-beaf-4bc5-a068-97126541fa55"",""etiquetasingular"": ""Compra / Gasto"",""etiquetaplural"": ""Compras / Gastos"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""340bde1f-cdc9-4471-b55e-44b9c96dd508"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Compra (Origen)"",""descripcion"": """",""keyword"": ""ReferenciaCompraOrigen"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaCompraOrigen As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaCompraOrigen
          <ReadOnlyAttribute(True)>
          <DisplayName("ID")>
          Public Property ID As Guid
          Public Shared ___ID As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": true,""eseliminado"": false,""keyword"": ""ID"",""etiqueta"": ""ID"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""0522ab28-8c49-4776-a43d-5acaf4d1833f"",""titulo"": ""Cobros de rectificaciones Compras"",""iconoid"": ""846a49dd-bfd1-4f27-a4c0-667d5b041985"",""etiquetasingular"": ""Cobro de rectificación Compra"",""etiquetaplural"": ""Cobros de rectificaciones Compras"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""0522ab28-8c49-4776-a43d-5acaf4d1833f"",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""ID"",""descripcion"": """",""keyword"": ""ID"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
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
          me.ReferenciaPuestoDeTrabajo = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_300401060687"), _Datos.Leer_String("pr_300401060687.nombre"))
          me.ReferenciaAutorDelAlta = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_10040105877"), _Datos.Leer_String("pr_10040105877.nombre"))
          me.ReferenciaProveedor = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_300401060688"), _Datos.Leer_String("pr_300401060688.nombre"))
          me.ImporteImporteAfectadoADepositoTramitado = _Datos.Leer_Decimal("pr_300401060697")
          me.ReferenciaCompraRectificativaO1 = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_100401058761"), _Datos.Leer_String("pr_100401058761.nombre"))
          me.ImporteImporteAfectadoADeposito = _Datos.Leer_Decimal("pr_300401060698")
          me.EmpleadoTieneAccesoWeb = _Datos.Leer_Boolean("pr_100401058730")
          me.FechaDeVencimiento = _Datos.Leer_Date_Nulable("pr_3004010606106")
          me.Observaciones = _Datos.Leer_String("pr_3004010606108")
          me.Estado = _Datos.Leer_EnumTramitacionE("pr_3004010606103")
          me.FechaAlta_UTC = _Datos.Leer_DateTime_Nulable("pr_100401058711")
          me.ReferenciaTransaccionMonetariaInterna = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_60040106111"), _Datos.Leer_String("pr_60040106111.nombre"))
          me.ImporteTotalPagadoTramitado = _Datos.Leer_Decimal("pr_300401060699")
          me.FechaDato_UTC = _Datos.Leer_DateTime_Nulable("pr_10040105878")
          me.ReferenciaTransaccionSecundaria = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_20040114144"), _Datos.Leer_String("pr_20040114144.nombre"))
          me.ImporteTotalCobrado = _Datos.Leer_Decimal("pr_3004010606100")
          me.ReferenciaEmpleadoPrincipal = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_10040105875"), _Datos.Leer_String("pr_10040105875.nombre"))
          me.DevolucionTramitadaYValidadaObsoleto = _Datos.Leer_EnumTramitacionE("pr_3004010606104")
          me.ReferenciaMetodoDePagoDevolucionObsoleto = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_300401060689"), _Datos.Leer_String("pr_300401060689.nombre"))
          me.FechaDeTramitacionYValidacionDevolucionObsoleto_UTC = _Datos.Leer_DateTime_Nulable("pr_300401060695")
          me.FechaDeVencimientoDevolucionObsoleto = _Datos.Leer_Date_Nulable("pr_3004010606107")
          me.AutorDelAltaTieneAccesoWeb = _Datos.Leer_Boolean("pr_100401058729")
          me.ReferenciaMetodoDePago = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_300401060690"), _Datos.Leer_String("pr_300401060690.nombre"))
          me.ImporteImporte = _Datos.Leer_Decimal("pr_3004010606101")
          me.ProveedorTieneAccesoWeb = _Datos.Leer_Boolean("pr_300401060694")
          me.TodoTramitadoYValidado = _Datos.Leer_Boolean("pr_3004010606105")
          me.ReferenciaDepositoMonetario = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_300401060691"), _Datos.Leer_String("pr_300401060691.nombre"))
          me.HoraLocal = _Datos.Leer_Time_Nulable("pr_10040105879")
          me.ReferenciaDestinador = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_100401058714"), _Datos.Leer_String("pr_100401058714.nombre"))
          me.ImporteImporteDevolucion = _Datos.Leer_Decimal("pr_3004010606102")
          me.ReferenciaEmisionDeChequeOPagare = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_300401060692"), _Datos.Leer_String("pr_300401060692.nombre"))
          me.FechaDeTramitacionYValidacion_UTC = _Datos.Leer_DateTime_Nulable("pr_300401060696")
          me.ReferenciaUbicacionPrincipal = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_10040105876"), _Datos.Leer_String("pr_10040105876.nombre"))
          me.ReferenciaEmisionDeChequeOPagareDevolucion = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_300401060693"), _Datos.Leer_String("pr_300401060693.nombre"))
          me.FechaContable = _Datos.Leer_Date_Nulable("pr_60040135703")
          me.ReferenciaAsientoContable = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_50040135301"), _Datos.Leer_String("pr_50040135301.nombre"))
          me.ReferenciaEmpleadoQueTramitaYValida = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_20040141241"), _Datos.Leer_String("pr_20040141241.nombre"))
          me.FechaLocalDeTramitacionYValidacion = _Datos.Leer_Date_Nulable("pr_20040141261")
          me.EmpleadoQueTramitaYValidaTieneAccesoWeb = _Datos.Leer_Boolean("pr_20040141242")
          me.ReferenciaCompraOrigen = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_30040242023"), _Datos.Leer_String("pr_30040242023.nombre"))
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
         If Me.ReferenciaPuestoDeTrabajo IsNot nothing then
           R.add("pr_300401060687",me.ReferenciaPuestoDeTrabajo.ID.STR())
         Else
           R.add("pr_300401060687","")
         End if
         If Me.ReferenciaAutorDelAlta IsNot nothing then
           R.add("pr_10040105877",me.ReferenciaAutorDelAlta.ID.STR())
         Else
           R.add("pr_10040105877","")
         End if
         If Me.ReferenciaProveedor IsNot nothing then
           R.add("pr_300401060688",me.ReferenciaProveedor.ID.STR())
         Else
           R.add("pr_300401060688","")
         End if
         R.add("pr_300401060697", me.ImporteImporteAfectadoADepositoTramitado.AdaptarMySQL_Decimal())
         If Me.ReferenciaCompraRectificativaO1 IsNot nothing then
           R.add("pr_100401058761",me.ReferenciaCompraRectificativaO1.ID.STR())
         Else
           R.add("pr_100401058761","")
         End if
         R.add("pr_300401060698", me.ImporteImporteAfectadoADeposito.AdaptarMySQL_Decimal())
         R.add("pr_100401058730", me.EmpleadoTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_3004010606106", me.FechaDeVencimiento.AdaptarMySQL_Date_Nulable())
         R.add("pr_3004010606108", me.Observaciones.AdaptarMySQL_String())
         R.add("pr_3004010606103", me.Estado.AdaptarMySQL_EnumTramitacionE())
         R.add("pr_100401058711", me.FechaAlta_UTC.AdaptarMySQL_DateTime_Nulable())
         If Me.ReferenciaTransaccionMonetariaInterna IsNot nothing then
           R.add("pr_60040106111",me.ReferenciaTransaccionMonetariaInterna.ID.STR())
         Else
           R.add("pr_60040106111","")
         End if
         R.add("pr_300401060699", me.ImporteTotalPagadoTramitado.AdaptarMySQL_Decimal())
         R.add("pr_10040105878", me.FechaDato_UTC.AdaptarMySQL_DateTime_Nulable())
         If Me.ReferenciaTransaccionSecundaria IsNot nothing then
           R.add("pr_20040114144",me.ReferenciaTransaccionSecundaria.ID.STR())
         Else
           R.add("pr_20040114144","")
         End if
         R.add("pr_3004010606100", me.ImporteTotalCobrado.AdaptarMySQL_Decimal())
         If Me.ReferenciaEmpleadoPrincipal IsNot nothing then
           R.add("pr_10040105875",me.ReferenciaEmpleadoPrincipal.ID.STR())
         Else
           R.add("pr_10040105875","")
         End if
         R.add("pr_3004010606104", me.DevolucionTramitadaYValidadaObsoleto.AdaptarMySQL_EnumTramitacionE())
         If Me.ReferenciaMetodoDePagoDevolucionObsoleto IsNot nothing then
           R.add("pr_300401060689",me.ReferenciaMetodoDePagoDevolucionObsoleto.ID.STR())
         Else
           R.add("pr_300401060689","")
         End if
         R.add("pr_300401060695", me.FechaDeTramitacionYValidacionDevolucionObsoleto_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_3004010606107", me.FechaDeVencimientoDevolucionObsoleto.AdaptarMySQL_Date_Nulable())
         R.add("pr_100401058729", me.AutorDelAltaTieneAccesoWeb.AdaptarMySQL_Boolean())
         If Me.ReferenciaMetodoDePago IsNot nothing then
           R.add("pr_300401060690",me.ReferenciaMetodoDePago.ID.STR())
         Else
           R.add("pr_300401060690","")
         End if
         R.add("pr_3004010606101", me.ImporteImporte.AdaptarMySQL_Decimal())
         R.add("pr_300401060694", me.ProveedorTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_3004010606105", me.TodoTramitadoYValidado.AdaptarMySQL_Boolean())
         If Me.ReferenciaDepositoMonetario IsNot nothing then
           R.add("pr_300401060691",me.ReferenciaDepositoMonetario.ID.STR())
         Else
           R.add("pr_300401060691","")
         End if
         R.add("pr_10040105879", me.HoraLocal.AdaptarMySQL_Time_Nulable())
         If Me.ReferenciaDestinador IsNot nothing then
           R.add("pr_100401058714",me.ReferenciaDestinador.ID.STR())
         Else
           R.add("pr_100401058714","")
         End if
         R.add("pr_3004010606102", me.ImporteImporteDevolucion.AdaptarMySQL_Decimal())
         If Me.ReferenciaEmisionDeChequeOPagare IsNot nothing then
           R.add("pr_300401060692",me.ReferenciaEmisionDeChequeOPagare.ID.STR())
         Else
           R.add("pr_300401060692","")
         End if
         R.add("pr_300401060696", me.FechaDeTramitacionYValidacion_UTC.AdaptarMySQL_DateTime_Nulable())
         If Me.ReferenciaUbicacionPrincipal IsNot nothing then
           R.add("pr_10040105876",me.ReferenciaUbicacionPrincipal.ID.STR())
         Else
           R.add("pr_10040105876","")
         End if
         If Me.ReferenciaEmisionDeChequeOPagareDevolucion IsNot nothing then
           R.add("pr_300401060693",me.ReferenciaEmisionDeChequeOPagareDevolucion.ID.STR())
         Else
           R.add("pr_300401060693","")
         End if
         R.add("pr_60040135703", me.FechaContable.AdaptarMySQL_Date_Nulable())
         If Me.ReferenciaAsientoContable IsNot nothing then
           R.add("pr_50040135301",me.ReferenciaAsientoContable.ID.STR())
         Else
           R.add("pr_50040135301","")
         End if
         If Me.ReferenciaEmpleadoQueTramitaYValida IsNot nothing then
           R.add("pr_20040141241",me.ReferenciaEmpleadoQueTramitaYValida.ID.STR())
         Else
           R.add("pr_20040141241","")
         End if
         R.add("pr_20040141261", me.FechaLocalDeTramitacionYValidacion.AdaptarMySQL_Date_Nulable())
         R.add("pr_20040141242", me.EmpleadoQueTramitaYValidaTieneAccesoWeb.AdaptarMySQL_Boolean())
         If Me.ReferenciaCompraOrigen IsNot nothing then
           R.add("pr_30040242023",me.ReferenciaCompraOrigen.ID.STR())
         Else
           R.add("pr_30040242023","")
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
      Public Class CobrosDeRectificacionesCompras_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
          Public property ReferenciaPuestoDeTrabajo As Guid
            get
                return me.GetValue_Guid("pr_300401060687")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_300401060687", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_10040105877")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_10040105877", value)
            End Set
          End Property
          Public property ReferenciaProveedor As Guid
            get
                return me.GetValue_Guid("pr_300401060688")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_300401060688", value)
            End Set
          End Property
        Public ReadOnly property ImporteImporteAfectadoADepositoTramitado As Decimal
            get
                return me.GetValue_Decimal("pr_300401060697")
            End Get   
        End Property
        Public ReadOnly property ReferenciaCompraRectificativaO1 As Guid
            get
                return me.GetValue_Guid("pr_100401058761")
            End Get   
        End Property
        Public ReadOnly property ImporteImporteAfectadoADeposito As Decimal
            get
                return me.GetValue_Decimal("pr_300401060698")
            End Get   
        End Property
          Public property EmpleadoTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_100401058730")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_100401058730", value)
            End Set
          End Property
          Public property FechaDeVencimiento As Date
            get
                return me.GetValue_Date("pr_3004010606106")
            End Get
            Set(value As Date)
                me.SetValue_Date("pr_3004010606106", value)
            End Set
          End Property
          Public property Observaciones As String
            get
                return me.GetValue_String("pr_3004010606108")
            End Get
            Set(value As String)
                me.SetValue_String("pr_3004010606108", value)
            End Set
          End Property
          Public property Estado__Int as Integer
            get
                return me.GetValue_Int("pr_3004010606103")
            End Get
            Set(value as Integer)
                me.SetValue_Int("pr_3004010606103", value)
            End Set
          End Property
          Public property Estado As EnumTramitacionE
            get
                return me.GetValue_Int("pr_3004010606103")
            End Get
            Set(value As EnumTramitacionE)
                me.SetValue_Int("pr_3004010606103", value)
            End Set
          End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_100401058711")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_100401058711", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaTransaccionMonetariaInterna As Guid
            get
                return me.GetValue_Guid("pr_60040106111")
            End Get   
        End Property
        Public ReadOnly property ImporteTotalPagadoTramitado As Decimal
            get
                return me.GetValue_Decimal("pr_300401060699")
            End Get   
        End Property
          Public property FechaDato_UTC As Date
            get
                return me.GetValue_DateTime("pr_10040105878")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_10040105878", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaTransaccionSecundaria As Guid
            get
                return me.GetValue_Guid("pr_20040114144")
            End Get   
        End Property
        Public ReadOnly property ImporteTotalCobrado As Decimal
            get
                return me.GetValue_Decimal("pr_3004010606100")
            End Get   
        End Property
          Public property ReferenciaEmpleadoPrincipal As Guid
            get
                return me.GetValue_Guid("pr_10040105875")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_10040105875", value)
            End Set
          End Property
          Public property DevolucionTramitadaYValidadaObsoleto__Int as Integer
            get
                return me.GetValue_Int("pr_3004010606104")
            End Get
            Set(value as Integer)
                me.SetValue_Int("pr_3004010606104", value)
            End Set
          End Property
          Public property DevolucionTramitadaYValidadaObsoleto As EnumTramitacionE
            get
                return me.GetValue_Int("pr_3004010606104")
            End Get
            Set(value As EnumTramitacionE)
                me.SetValue_Int("pr_3004010606104", value)
            End Set
          End Property
          Public property ReferenciaMetodoDePagoDevolucionObsoleto As Guid
            get
                return me.GetValue_Guid("pr_300401060689")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_300401060689", value)
            End Set
          End Property
          Public property FechaDeTramitacionYValidacionDevolucionObsoleto_UTC As Date
            get
                return me.GetValue_DateTime("pr_300401060695")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_300401060695", value)
            End Set
          End Property
          Public property FechaDeVencimientoDevolucionObsoleto As Date
            get
                return me.GetValue_Date("pr_3004010606107")
            End Get
            Set(value As Date)
                me.SetValue_Date("pr_3004010606107", value)
            End Set
          End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_100401058729")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_100401058729", value)
            End Set
          End Property
          Public property ReferenciaMetodoDePago As Guid
            get
                return me.GetValue_Guid("pr_300401060690")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_300401060690", value)
            End Set
          End Property
          Public property ImporteImporte As Decimal
            get
                return me.GetValue_Decimal("pr_3004010606101")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_3004010606101", value)
            End Set
          End Property
          Public property ProveedorTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_300401060694")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_300401060694", value)
            End Set
          End Property
        Public ReadOnly property TodoTramitadoYValidado As Boolean
            get
                return me.GetValue_Boolean("pr_3004010606105")
            End Get   
        End Property
          Public property ReferenciaDepositoMonetario As Guid
            get
                return me.GetValue_Guid("pr_300401060691")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_300401060691", value)
            End Set
          End Property
        Public ReadOnly property HoraLocal As DateTime
            get
                return me.GetValue_DateTime("pr_10040105879")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_100401058714")
            End Get   
        End Property
          Public property ImporteImporteDevolucion As Decimal
            get
                return me.GetValue_Decimal("pr_3004010606102")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_3004010606102", value)
            End Set
          End Property
          Public property ReferenciaEmisionDeChequeOPagare As Guid
            get
                return me.GetValue_Guid("pr_300401060692")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_300401060692", value)
            End Set
          End Property
        Public ReadOnly property FechaDeTramitacionYValidacion_UTC As Date
            get
                return me.GetValue_DateTime("pr_300401060696")
            End Get   
        End Property
          Public property ReferenciaUbicacionPrincipal As Guid
            get
                return me.GetValue_Guid("pr_10040105876")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_10040105876", value)
            End Set
          End Property
          Public property ReferenciaEmisionDeChequeOPagareDevolucion As Guid
            get
                return me.GetValue_Guid("pr_300401060693")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_300401060693", value)
            End Set
          End Property
          Public property FechaContable As Date
            get
                return me.GetValue_Date("pr_60040135703")
            End Get
            Set(value As Date)
                me.SetValue_Date("pr_60040135703", value)
            End Set
          End Property
          Public property ReferenciaAsientoContable As Guid
            get
                return me.GetValue_Guid("pr_50040135301")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_50040135301", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaEmpleadoQueTramitaYValida As Guid
            get
                return me.GetValue_Guid("pr_20040141241")
            End Get   
        End Property
        Public ReadOnly property FechaLocalDeTramitacionYValidacion As Date
            get
                return me.GetValue_Date("pr_20040141261")
            End Get   
        End Property
          Public property EmpleadoQueTramitaYValidaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_20040141242")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_20040141242", value)
            End Set
          End Property
          Public property ReferenciaCompraOrigen As Guid
            get
                return me.GetValue_Guid("pr_30040242023")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_30040242023", value)
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
