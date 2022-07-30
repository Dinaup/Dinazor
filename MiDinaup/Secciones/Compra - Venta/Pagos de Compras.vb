   Imports System.ComponentModel
   Imports DinaNETCore
   Imports DinaNETCore.APID
Partial Public Class SeccionesD
  Public Class PagosDeComprasD
      Public Shared _SeccionID As String = "b97a298f-0c73-4206-8567-2d3c7e2d7263"
      Public Shared _SeccionIDGUID As New Guid("b97a298f-0c73-4206-8567-2d3c7e2d7263")
      Public Shared Async Function ConsultarDatos_Async(Parametros As SeccionConsultaParametrosC) As Task(Of List(Of PagosDeComprasC )) 
          Dim R As New List(Of PagosDeComprasC )  
          Dim d = Await Parametros.DinaupSesion.ConexionServidor.Funcion_Datos_Recibir_Async(PagosDeComprasES._SeccionID, False, Parametros) 
          If d.Datos.TieneDatos Then 
              For Each Actual In d.Datos 
                  Dim Valores_Listador = Actual.Value.Item1
                  Dim Obj_Listador As New PagosDeComprasC 
                  Obj_Listador.CargarDatos(Valores_Listador) 
                  Obj_Listador.CargaInterna(Actual.Value)
                  R.Add(Obj_Listador) 
              Next 
          End If 
          Return R 
      End Function 
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As PagosDeComprasC, Optional CampoWhere$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Return Await DatosGuardar_Async(DinaupSesion, New List(Of PagosDeComprasC)({DAtos}), CampoWhere )
      End Function
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As List(Of PagosDeComprasC), Optional CampoWhere$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Dim Importar As New List(Of DinaupAPI_ImportacionProcesableC)
          For Each Actual In DAtos 
              Dim RegistroActual = New DinaupAPI_ImportacionProcesableC() 
               RegistroActual.dinaup_listador_datos = Actual.ToDic 
               Importar.Add(RegistroActual)  
          Next 
          Return Await DinaupSesion.ConexionServidor.Funcion_Importar_Ejecutar_Async(DinaupSesion, PagosDeComprasES._SeccionID, Importar, CampoWhere, "") 
      End Function
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As PagosDeCompras_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, PagosDeComprasES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New PagosDeCompras_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As PagosDeCompras_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, PagosDeComprasES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New PagosDeCompras_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class PagosDeComprasES
          Public shared _SeccionID as Guid = New Guid("b97a298f-0c73-4206-8567-2d3c7e2d7263")
          Public shared _Tabla$ = "tpr_20040105872"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_100401058757"
      Public Shared ReferenciaMovimientoDeCajaOrigen$ = "pr_300401060661"
      Public Shared FechaDato_UTC$ = "pr_100401058745"
      Public Shared ReferenciaMetodoDePagoDevolucionObsoleto$ = "pr_300401060662"
      Public Shared TodoTramitadoYValidadoObsoleto$ = "pr_300401060676"
      Public Shared ReferenciaEmisionDeChequeOPagare$ = "pr_300401060660"
      Public Shared FechaAlta_UTC$ = "pr_100401058748"
      Public Shared ImporteImporteDevolucion$ = "pr_300401060674"
      Public Shared ImporteImporteAfectadoADepositoTramitado$ = "pr_300401060673"
      Public Shared Observaciones$ = "pr_300401060680"
      Public Shared ReferenciaTransaccionSecundaria$ = "pr_20040114142"
      Public Shared DevolucionTramitadaYValidadaObsoleto$ = "pr_300401060677"
      Public Shared ReferenciaProveedor$ = "pr_300401060665"
      Public Shared FechaDeVencimiento$ = "pr_300401060679"
      Public Shared ReferenciaTransaccionMonetariaInterna$ = "pr_60040106112"
      Public Shared ImporteTotalPagado$ = "pr_300401060672"
      Public Shared ReferenciaPuestoDeTrabajo$ = "pr_300401060664"
      Public Shared ReferenciaMetodoDePago$ = "pr_300401060663"
      Public Shared ReferenciaAutorDelAlta$ = "pr_100401058744"
      Public Shared ImporteTotalPagadoTramitado$ = "pr_300401060670"
      Public Shared FechaDeTramitacionYValidacion_UTC$ = "pr_300401060667"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_100401058759"
      Public Shared ReferenciaEmisionDeChequeOPagareDevolucion$ = "pr_300401060658"
      Public Shared ProveedorTieneAccesoWeb$ = "pr_300401060666"
      Public Shared ImporteImporteAfectadoADeposito$ = "pr_300401060669"
      Public Shared Estado$ = "pr_300401060675"
      Public Shared ReferenciaDestinador$ = "pr_100401058751"
      Public Shared HoraLocal$ = "pr_100401058746"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_100401058743"
      Public Shared FechaDeTramitacionYValidacionDevolucionObsoleto_UTC$ = "pr_300401060668"
      Public Shared ImporteImporte$ = "pr_300401060671"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_100401058742"
      Public Shared ReferenciaDepositoMonetario$ = "pr_300401060659"
      Public Shared ReferenciaCompra$ = "pr_100401058762"
      Public Shared FechaDeVencimientoDevolucionObsoleto$ = "pr_300401060678"
      Public Shared FechaContable$ = "pr_60040135701"
      Public Shared ReferenciaAsientoContable$ = "pr_60040135301"
      Public Shared FechaLocalDeTramitacionYValidacion$ = "pr_20040141263"
      Public Shared ReferenciaEmpleadoQueTramitaYValida$ = "pr_50040141241"
      Public Shared EmpleadoQueTramitaYValidaTieneAccesoWeb$ = "pr_50040141242"
      Public Shared ReferenciaMovimientoBancario$ = "pr_10040264601"
      Public Shared AsignarManualmenteLaFechaContable$ = "pr_50040365592"
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
      Public Class PagosDeComprasC
      Inherits Base_DatoC
          <DisplayName("Empleado Tiene Acceso web")>
          Public Property EmpleadoTieneAccesoWeb As Boolean
          Public Shared ___EmpleadoTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EmpleadoTieneAccesoWeb"",""etiqueta"": ""Empleado Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empleado Tiene Acceso web"",""descripcion"": """",""keyword"": ""EmpleadoTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EmpleadoTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___EmpleadoTieneAccesoWeb
          <DisplayName("Movimiento de caja (Origen)")>
          Public Property ReferenciaMovimientoDeCajaOrigen As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaMovimientoDeCajaOrigen As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaMovimientoDeCajaOrigen"",""etiqueta"": ""Movimiento de caja (Origen)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""eab03f4c-bd9c-41aa-8b2b-bac5318d1682"",""titulo"": ""Lista - Ajustes de depósitos monetarios"",""iconoid"": """",""etiquetasingular"": ""Ajuste de depósito monetario"",""etiquetaplural"": ""Ajustes de depósito monetario"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": true,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""eab03f4c-bd9c-41aa-8b2b-bac5318d1682"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Movimiento de caja (Origen)"",""descripcion"": """",""keyword"": ""ReferenciaMovimientoDeCajaOrigen"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaMovimientoDeCajaOrigen As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaMovimientoDeCajaOrigen
          <DisplayName("Fecha Dato")>
          Public Property FechaDato_UTC As Date?
          Public Shared ___FechaDato_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaDato_UTC"",""etiqueta"": ""Fecha Dato"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Dato"",""descripcion"": """",""keyword"": ""FechaDato_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaDato_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaDato_UTC
          <DisplayName("Método de pago (Devolución) (Obsoleto)")>
          Public Property ReferenciaMetodoDePagoDevolucionObsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaMetodoDePagoDevolucionObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaMetodoDePagoDevolucionObsoleto"",""etiqueta"": ""Método de pago (Devolución) (Obsoleto)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""b22b7c8f-35b9-494f-8c4c-dec035a7760d"",""titulo"": ""Base - Métodos de pago"",""iconoid"": ""f72dab6e-3c9f-47cf-a0dd-d27ce9cd64b8"",""etiquetasingular"": ""Método de pago"",""etiquetaplural"": ""Métodos de pago"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""b22b7c8f-35b9-494f-8c4c-dec035a7760d"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Método de pago (Devolución) (Obsoleto)"",""descripcion"": """",""keyword"": ""ReferenciaMetodoDePagoDevolucionObsoleto"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaMetodoDePagoDevolucionObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaMetodoDePagoDevolucionObsoleto
          <DisplayName("Todo tramitado y validado (Obsoleto)")>
          Public Property TodoTramitadoYValidadoObsoleto As Boolean
          Public Shared ___TodoTramitadoYValidadoObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TodoTramitadoYValidadoObsoleto"",""etiqueta"": ""Todo tramitado y validado (Obsoleto)"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Todo tramitado y validado (Obsoleto)"",""descripcion"": """",""keyword"": ""TodoTramitadoYValidadoObsoleto"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __TodoTramitadoYValidadoObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___TodoTramitadoYValidadoObsoleto
          <DisplayName("Emisión de Cheque o Pagaré")>
          Public Property ReferenciaEmisionDeChequeOPagare As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaEmisionDeChequeOPagare As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaEmisionDeChequeOPagare"",""etiqueta"": ""Emisión de Cheque o Pagaré"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c898ba20-5858-41d1-a368-0fd478150623"",""titulo"": ""Base - Cheques y Pagares"",""iconoid"": ""6ca6f3c8-0971-4221-bebe-489130891aad"",""etiquetasingular"": ""Documento de pago"",""etiquetaplural"": ""Documentos de pago"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""c898ba20-5858-41d1-a368-0fd478150623"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Emisión de Cheque o Pagaré"",""descripcion"": """",""keyword"": ""ReferenciaEmisionDeChequeOPagare"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaEmisionDeChequeOPagare As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaEmisionDeChequeOPagare
          <DisplayName("Fecha Alta del registro")>
          Public Property FechaAlta_UTC As Date?
          Public Shared ___FechaAlta_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaAlta_UTC"",""etiqueta"": ""Fecha Alta del registro"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Alta del registro"",""descripcion"": """",""keyword"": ""FechaAlta_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaAlta_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaAlta_UTC
          <DisplayName("Importe (Devolución)")>
          Public Property ImporteImporteDevolucion As Decimal
          Public Shared ___ImporteImporteDevolucion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteImporteDevolucion"",""etiqueta"": ""Importe (Devolución)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Importe (Devolución)"",""descripcion"": """",""keyword"": ""ImporteImporteDevolucion"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteImporteDevolucion As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteImporteDevolucion
          <DisplayName("Importe afectado a depósito (Tramitado)")>
          Public Property ImporteImporteAfectadoADepositoTramitado As Decimal
          Public Shared ___ImporteImporteAfectadoADepositoTramitado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteImporteAfectadoADepositoTramitado"",""etiqueta"": ""Importe afectado a depósito (Tramitado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Importe afectado a depósito (Tramitado)"",""descripcion"": """",""keyword"": ""ImporteImporteAfectadoADepositoTramitado"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteImporteAfectadoADepositoTramitado As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteImporteAfectadoADepositoTramitado
          <Description("Puede usar este campo, para dejar registro de información que" & vbCrLf & "la persona encargada considere importante.")>
          <DisplayName("Observaciones")>
          Public Property Observaciones As String
          Public Shared ___Observaciones As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Observaciones"",""etiqueta"": ""Observaciones"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 9,""decimales"": ""0"",""multilinea"": true,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Observaciones"",""descripcion"": """",""keyword"": ""Observaciones"",""formato"": 5,""rol"": 9,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Observaciones As DinaNETCore.APID.DinaupAPI_CampoC = ___Observaciones
          <DisplayName("Transacción secundaria")>
          Public Property ReferenciaTransaccionSecundaria As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaTransaccionSecundaria As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaTransaccionSecundaria"",""etiqueta"": ""Transacción secundaria"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""666178a9-3df8-4fc2-a66a-3c3698898c24"",""titulo"": ""Transacciones monetarias secundarias internas"",""iconoid"": ""c17a70cf-f1f8-410e-ad7d-c07041338177"",""etiquetasingular"": ""Transacción secundaria interna"",""etiquetaplural"": ""Transacciones monetarias secundarias internas"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""666178a9-3df8-4fc2-a66a-3c3698898c24"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Transacción secundaria"",""descripcion"": """",""keyword"": ""ReferenciaTransaccionSecundaria"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaTransaccionSecundaria As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaTransaccionSecundaria
          <DisplayName("Devolución tramitada y validada (Obsoleto)")>
          Public Property DevolucionTramitadaYValidadaObsoleto As EnumTramitacionE
          Public Shared ___DevolucionTramitadaYValidadaObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DevolucionTramitadaYValidadaObsoleto"",""etiqueta"": ""Devolución tramitada y validada (Obsoleto)"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 48,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [0,1,2,3],""predefinidos_textos"": [""Indefinido"",""Pendiente"",""Tramitado"",""Cancelado""],""predefinidos_iconos"": [""https://cdn.dinaup.com/ico/enums/48_0.png"",""https://cdn.dinaup.com/ico/enums/48_1.png"",""https://cdn.dinaup.com/ico/enums/48_2.png"",""https://cdn.dinaup.com/ico/enums/48_3.png""],""filtro"": {""titulo"": ""Devolución tramitada y validada (Obsoleto)"",""descripcion"": """",""keyword"": ""DevolucionTramitadaYValidadaObsoleto"",""formato"": 2,""rol"": 48,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false,""enumeracion"": {""titulo"": ""Enum - Tramitación"", ""valores"": [{""valor"": 0, ""titulo"": ""Indefinido""},{""valor"": 1, ""titulo"": ""Pendiente""},{""valor"": 2, ""titulo"": ""Tramitado""},{""valor"": 3, ""titulo"": ""Cancelado""}]}},""solovalorespredefinidos"": true}")
          Public  __DevolucionTramitadaYValidadaObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___DevolucionTramitadaYValidadaObsoleto
          <DisplayName("Proveedor")>
          Public Property ReferenciaProveedor As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaProveedor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaProveedor"",""etiqueta"": ""Proveedor"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Proveedor"",""descripcion"": """",""keyword"": ""ReferenciaProveedor"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaProveedor As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaProveedor
          <DisplayName("Fecha de vencimiento")>
          Public Property FechaDeVencimiento As Date?
          Public Shared ___FechaDeVencimiento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaDeVencimiento"",""etiqueta"": ""Fecha de vencimiento"",""oculta"": false,""formato"": 7,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha de vencimiento"",""descripcion"": """",""keyword"": ""FechaDeVencimiento"",""formato"": 7,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaDeVencimiento As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaDeVencimiento
          <DisplayName("Transacción monetaria interna")>
          Public Property ReferenciaTransaccionMonetariaInterna As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaTransaccionMonetariaInterna As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaTransaccionMonetariaInterna"",""etiqueta"": ""Transacción monetaria interna"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""2d23ee9b-d9d5-4546-9200-9937ce2c0638"",""titulo"": ""Transacciones monetarias internas"",""iconoid"": ""c17a70cf-f1f8-410e-ad7d-c07041338177"",""etiquetasingular"": ""Transacción monetaria interna"",""etiquetaplural"": ""Transacciones monetarias internas"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""2d23ee9b-d9d5-4546-9200-9937ce2c0638"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Transacción monetaria interna"",""descripcion"": """",""keyword"": ""ReferenciaTransaccionMonetariaInterna"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaTransaccionMonetariaInterna As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaTransaccionMonetariaInterna
          <DisplayName("Total Pagado")>
          Public Property ImporteTotalPagado As Decimal
          Public Shared ___ImporteTotalPagado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteTotalPagado"",""etiqueta"": ""Total Pagado"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total Pagado"",""descripcion"": """",""keyword"": ""ImporteTotalPagado"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteTotalPagado As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteTotalPagado
          <DisplayName("Puesto de trabajo")>
          Public Property ReferenciaPuestoDeTrabajo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaPuestoDeTrabajo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaPuestoDeTrabajo"",""etiqueta"": ""Puesto de trabajo"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""f777486d-e709-41be-9211-d9c6b4bb05d6"",""titulo"": ""Base - Puestos de trabajo"",""iconoid"": ""5d7008ed-1e2f-4dbe-a376-6261de330414"",""etiquetasingular"": ""Puesto de trabajo"",""etiquetaplural"": ""Puestos de trabajo"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""f777486d-e709-41be-9211-d9c6b4bb05d6"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Puesto de trabajo"",""descripcion"": """",""keyword"": ""ReferenciaPuestoDeTrabajo"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaPuestoDeTrabajo As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaPuestoDeTrabajo
          <DisplayName("Método de pago")>
          Public Property ReferenciaMetodoDePago As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaMetodoDePago As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaMetodoDePago"",""etiqueta"": ""Método de pago"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""b22b7c8f-35b9-494f-8c4c-dec035a7760d"",""titulo"": ""Base - Métodos de pago"",""iconoid"": ""f72dab6e-3c9f-47cf-a0dd-d27ce9cd64b8"",""etiquetasingular"": ""Método de pago"",""etiquetaplural"": ""Métodos de pago"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""b22b7c8f-35b9-494f-8c4c-dec035a7760d"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Método de pago"",""descripcion"": """",""keyword"": ""ReferenciaMetodoDePago"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaMetodoDePago As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaMetodoDePago
          <DisplayName("Autor del alta")>
          Public Property ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaAutorDelAlta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaAutorDelAlta"",""etiqueta"": ""Autor del alta"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta"",""descripcion"": """",""keyword"": ""ReferenciaAutorDelAlta"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaAutorDelAlta
          <DisplayName("Total pagado (Tramitado)")>
          Public Property ImporteTotalPagadoTramitado As Decimal
          Public Shared ___ImporteTotalPagadoTramitado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteTotalPagadoTramitado"",""etiqueta"": ""Total pagado (Tramitado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total pagado (Tramitado)"",""descripcion"": """",""keyword"": ""ImporteTotalPagadoTramitado"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteTotalPagadoTramitado As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteTotalPagadoTramitado
          <DisplayName("Fecha de tramitación y validación")>
          Public Property FechaDeTramitacionYValidacion_UTC As Date?
          Public Shared ___FechaDeTramitacionYValidacion_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaDeTramitacionYValidacion_UTC"",""etiqueta"": ""Fecha de tramitación y validación"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha de tramitación y validación"",""descripcion"": """",""keyword"": ""FechaDeTramitacionYValidacion_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaDeTramitacionYValidacion_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaDeTramitacionYValidacion_UTC
          <DisplayName("Autor del alta Tiene Acceso web")>
          Public Property AutorDelAltaTieneAccesoWeb As Boolean
          Public Shared ___AutorDelAltaTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AutorDelAltaTieneAccesoWeb"",""etiqueta"": ""Autor del alta Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta Tiene Acceso web"",""descripcion"": """",""keyword"": ""AutorDelAltaTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AutorDelAltaTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___AutorDelAltaTieneAccesoWeb
          <DisplayName("Emisión de Cheque o pagaré (Devolución)")>
          Public Property ReferenciaEmisionDeChequeOPagareDevolucion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaEmisionDeChequeOPagareDevolucion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaEmisionDeChequeOPagareDevolucion"",""etiqueta"": ""Emisión de Cheque o pagaré (Devolución)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c898ba20-5858-41d1-a368-0fd478150623"",""titulo"": ""Base - Cheques y Pagares"",""iconoid"": ""6ca6f3c8-0971-4221-bebe-489130891aad"",""etiquetasingular"": ""Documento de pago"",""etiquetaplural"": ""Documentos de pago"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""c898ba20-5858-41d1-a368-0fd478150623"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Emisión de Cheque o pagaré (Devolución)"",""descripcion"": """",""keyword"": ""ReferenciaEmisionDeChequeOPagareDevolucion"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaEmisionDeChequeOPagareDevolucion As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaEmisionDeChequeOPagareDevolucion
          <DisplayName("Proveedor Tiene Acceso web")>
          Public Property ProveedorTieneAccesoWeb As Boolean
          Public Shared ___ProveedorTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ProveedorTieneAccesoWeb"",""etiqueta"": ""Proveedor Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Proveedor Tiene Acceso web"",""descripcion"": """",""keyword"": ""ProveedorTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ProveedorTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___ProveedorTieneAccesoWeb
          <DisplayName("Importe afectado a depósito")>
          Public Property ImporteImporteAfectadoADeposito As Decimal
          Public Shared ___ImporteImporteAfectadoADeposito As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteImporteAfectadoADeposito"",""etiqueta"": ""Importe afectado a depósito"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Importe afectado a depósito"",""descripcion"": """",""keyword"": ""ImporteImporteAfectadoADeposito"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteImporteAfectadoADeposito As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteImporteAfectadoADeposito
          <DisplayName("Estado")>
          Public Property Estado As EnumTramitacionE
          Public Shared ___Estado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Estado"",""etiqueta"": ""Estado"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 48,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [0,1,2,3],""predefinidos_textos"": [""Indefinido"",""Pendiente"",""Tramitado"",""Cancelado""],""predefinidos_iconos"": [""https://cdn.dinaup.com/ico/enums/48_0.png"",""https://cdn.dinaup.com/ico/enums/48_1.png"",""https://cdn.dinaup.com/ico/enums/48_2.png"",""https://cdn.dinaup.com/ico/enums/48_3.png""],""filtro"": {""titulo"": ""Estado"",""descripcion"": """",""keyword"": ""Estado"",""formato"": 2,""rol"": 48,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false,""enumeracion"": {""titulo"": ""Enum - Tramitación"", ""valores"": [{""valor"": 0, ""titulo"": ""Indefinido""},{""valor"": 1, ""titulo"": ""Pendiente""},{""valor"": 2, ""titulo"": ""Tramitado""},{""valor"": 3, ""titulo"": ""Cancelado""}]}},""solovalorespredefinidos"": true}")
          Public  __Estado As DinaNETCore.APID.DinaupAPI_CampoC = ___Estado
          <DisplayName("Destinador")>
          Public Property ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaDestinador As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaDestinador"",""etiqueta"": ""Destinador"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""relacionesindirectas"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Destinador"",""descripcion"": """",""keyword"": ""ReferenciaDestinador"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaDestinador
          <DisplayName("Hora local")>
          Public Property HoraLocal As DateTime?
          Public Shared ___HoraLocal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""HoraLocal"",""etiqueta"": ""Hora local"",""oculta"": false,""formato"": 8,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Hora local"",""descripcion"": """",""keyword"": ""HoraLocal"",""formato"": 8,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __HoraLocal As DinaNETCore.APID.DinaupAPI_CampoC = ___HoraLocal
          <DisplayName("Ubicación Principal")>
          Public Property ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaUbicacionPrincipal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaUbicacionPrincipal"",""etiqueta"": ""Ubicación Principal"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""b9adbfbf-a81a-45fb-861c-90502902c982"",""titulo"": ""Ubicaciones"",""iconoid"": ""b985b58f-7275-46b8-9b66-2c54346b0185"",""etiquetasingular"": ""Ubicación"",""etiquetaplural"": ""Ubicaciones"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""b9adbfbf-a81a-45fb-861c-90502902c982"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Ubicación Principal"",""descripcion"": """",""keyword"": ""ReferenciaUbicacionPrincipal"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaUbicacionPrincipal
          <DisplayName("Fecha de tramitación y validación (Devolución) (Obsoleto)")>
          Public Property FechaDeTramitacionYValidacionDevolucionObsoleto_UTC As Date?
          Public Shared ___FechaDeTramitacionYValidacionDevolucionObsoleto_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaDeTramitacionYValidacionDevolucionObsoleto_UTC"",""etiqueta"": ""Fecha de tramitación y validación (Devolución) (Obsoleto)"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha de tramitación y validación (Devolución) (Obsoleto)"",""descripcion"": """",""keyword"": ""FechaDeTramitacionYValidacionDevolucionObsoleto_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaDeTramitacionYValidacionDevolucionObsoleto_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaDeTramitacionYValidacionDevolucionObsoleto_UTC
          <DisplayName("Importe")>
          Public Property ImporteImporte As Decimal
          Public Shared ___ImporteImporte As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteImporte"",""etiqueta"": ""Importe"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Importe"",""descripcion"": """",""keyword"": ""ImporteImporte"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteImporte As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteImporte
          <DisplayName("Empleado")>
          Public Property ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaEmpleadoPrincipal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaEmpleadoPrincipal"",""etiqueta"": ""Empleado"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c6e071c7-776f-4300-aa55-c711fd1da916"",""titulo"": ""Empleados"",""iconoid"": ""1c8abf82-640c-4d18-b62c-89de310923dd"",""etiquetasingular"": ""Empleado"",""etiquetaplural"": ""Empleados"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""c6e071c7-776f-4300-aa55-c711fd1da916"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empleado"",""descripcion"": """",""keyword"": ""ReferenciaEmpleadoPrincipal"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaEmpleadoPrincipal
          <DisplayName("Depósito monetario")>
          Public Property ReferenciaDepositoMonetario As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaDepositoMonetario As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaDepositoMonetario"",""etiqueta"": ""Depósito monetario"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""cab2cf42-3cf6-4aa6-9930-c7ee704650bc"",""titulo"": ""Base - Depósitos monetarios"",""iconoid"": ""f037928c-b088-47e4-a79e-3d217109403b"",""etiquetasingular"": ""Depósito monetario"",""etiquetaplural"": ""Depósitos monetarios"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""cab2cf42-3cf6-4aa6-9930-c7ee704650bc"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Depósito monetario"",""descripcion"": """",""keyword"": ""ReferenciaDepositoMonetario"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaDepositoMonetario As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaDepositoMonetario
          <DisplayName("Compra")>
          Public Property ReferenciaCompra As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaCompra As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaCompra"",""etiqueta"": ""Compra"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""340bde1f-cdc9-4471-b55e-44b9c96dd508"",""titulo"": ""Base - Compras y Gastos"",""iconoid"": ""5686dc42-beaf-4bc5-a068-97126541fa55"",""etiquetasingular"": ""Compra / Gasto"",""etiquetaplural"": ""Compras / Gastos"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""340bde1f-cdc9-4471-b55e-44b9c96dd508"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Compra"",""descripcion"": """",""keyword"": ""ReferenciaCompra"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaCompra As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaCompra
          <DisplayName("Fecha de vencimiento (Devolución) (Obsoleto)")>
          Public Property FechaDeVencimientoDevolucionObsoleto As Date?
          Public Shared ___FechaDeVencimientoDevolucionObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaDeVencimientoDevolucionObsoleto"",""etiqueta"": ""Fecha de vencimiento (Devolución) (Obsoleto)"",""oculta"": false,""formato"": 7,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha de vencimiento (Devolución) (Obsoleto)"",""descripcion"": """",""keyword"": ""FechaDeVencimientoDevolucionObsoleto"",""formato"": 7,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaDeVencimientoDevolucionObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaDeVencimientoDevolucionObsoleto
          <DisplayName("Fecha contable")>
          Public Property FechaContable As Date?
          Public Shared ___FechaContable As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaContable"",""etiqueta"": ""Fecha contable"",""oculta"": false,""formato"": 7,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 69,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha contable"",""descripcion"": """",""keyword"": ""FechaContable"",""formato"": 7,""rol"": 69,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaContable As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaContable
          <DisplayName("Asiento contable")>
          Public Property ReferenciaAsientoContable As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaAsientoContable As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaAsientoContable"",""etiqueta"": ""Asiento contable"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c4608471-b749-46fd-a0eb-d82dda66dcc8"",""titulo"": ""Base - Asientos contables"",""iconoid"": ""226684b8-fe3c-46a7-8f24-7462e48c0027"",""etiquetasingular"": ""Asiento contable"",""etiquetaplural"": ""Asientos contables"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""c4608471-b749-46fd-a0eb-d82dda66dcc8"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Asiento contable"",""descripcion"": """",""keyword"": ""ReferenciaAsientoContable"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaAsientoContable As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaAsientoContable
          <DisplayName("Fecha local de tramitación y validación")>
          Public Property FechaLocalDeTramitacionYValidacion As Date?
          Public Shared ___FechaLocalDeTramitacionYValidacion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaLocalDeTramitacionYValidacion"",""etiqueta"": ""Fecha local de tramitación y validación"",""oculta"": false,""formato"": 7,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha local de tramitación y validación"",""descripcion"": """",""keyword"": ""FechaLocalDeTramitacionYValidacion"",""formato"": 7,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaLocalDeTramitacionYValidacion As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaLocalDeTramitacionYValidacion
          <DisplayName("Empleado que tramita y valida")>
          Public Property ReferenciaEmpleadoQueTramitaYValida As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaEmpleadoQueTramitaYValida As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaEmpleadoQueTramitaYValida"",""etiqueta"": ""Empleado que tramita y valida"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c6e071c7-776f-4300-aa55-c711fd1da916"",""titulo"": ""Empleados"",""iconoid"": ""1c8abf82-640c-4d18-b62c-89de310923dd"",""etiquetasingular"": ""Empleado"",""etiquetaplural"": ""Empleados"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""c6e071c7-776f-4300-aa55-c711fd1da916"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empleado que tramita y valida"",""descripcion"": """",""keyword"": ""ReferenciaEmpleadoQueTramitaYValida"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaEmpleadoQueTramitaYValida As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaEmpleadoQueTramitaYValida
          <DisplayName("Empleado que tramita y valida Tiene Acceso web")>
          Public Property EmpleadoQueTramitaYValidaTieneAccesoWeb As Boolean
          Public Shared ___EmpleadoQueTramitaYValidaTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EmpleadoQueTramitaYValidaTieneAccesoWeb"",""etiqueta"": ""Empleado que tramita y valida Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empleado que tramita y valida Tiene Acceso web"",""descripcion"": """",""keyword"": ""EmpleadoQueTramitaYValidaTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EmpleadoQueTramitaYValidaTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___EmpleadoQueTramitaYValidaTieneAccesoWeb
          <DisplayName("Movimiento bancario")>
          Public Property ReferenciaMovimientoBancario As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaMovimientoBancario As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaMovimientoBancario"",""etiqueta"": ""Movimiento bancario"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""974c8356-c1e9-4f0a-8c94-7d24ef2f19ce"",""titulo"": ""Base - Movimientos bancarios"",""iconoid"": ""73edff4d-02b1-4f53-b998-1e19b0865ae4"",""etiquetasingular"": ""Movimiento bancario"",""etiquetaplural"": ""Movimientos bancarios"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""974c8356-c1e9-4f0a-8c94-7d24ef2f19ce"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Movimiento bancario"",""descripcion"": """",""keyword"": ""ReferenciaMovimientoBancario"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaMovimientoBancario As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaMovimientoBancario
          <DisplayName("Asignar manualmente la fecha contable")>
          Public Property AsignarManualmenteLaFechaContable As Boolean
          Public Shared ___AsignarManualmenteLaFechaContable As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AsignarManualmenteLaFechaContable"",""etiqueta"": ""Asignar manualmente la fecha contable"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 103,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Asignar manualmente la fecha contable"",""descripcion"": """",""keyword"": ""AsignarManualmenteLaFechaContable"",""formato"": 1,""rol"": 103,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AsignarManualmenteLaFechaContable As DinaNETCore.APID.DinaupAPI_CampoC = ___AsignarManualmenteLaFechaContable
          <ReadOnlyAttribute(True)>
          <DisplayName("ID")>
          Public Property ID As Guid
          Public Shared ___ID As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": true,""eseliminado"": false,""keyword"": ""ID"",""etiqueta"": ""ID"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""b97a298f-0c73-4206-8567-2d3c7e2d7263"",""titulo"": ""Pagos de Compras"",""iconoid"": ""84e9d2cd-311c-41d7-9667-43cb2f74882e"",""etiquetasingular"": ""Pago de Compra/Gasto"",""etiquetaplural"": ""Pagos de Compra/Gasto"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""b97a298f-0c73-4206-8567-2d3c7e2d7263"",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""ID"",""descripcion"": """",""keyword"": ""ID"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
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
          me.EmpleadoTieneAccesoWeb = _Datos.Leer_Boolean("pr_100401058757")
          me.ReferenciaMovimientoDeCajaOrigen = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_300401060661"), _Datos.Leer_String("pr_300401060661.nombre"))
          me.FechaDato_UTC = _Datos.Leer_DateTime_Nulable("pr_100401058745")
          me.ReferenciaMetodoDePagoDevolucionObsoleto = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_300401060662"), _Datos.Leer_String("pr_300401060662.nombre"))
          me.TodoTramitadoYValidadoObsoleto = _Datos.Leer_Boolean("pr_300401060676")
          me.ReferenciaEmisionDeChequeOPagare = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_300401060660"), _Datos.Leer_String("pr_300401060660.nombre"))
          me.FechaAlta_UTC = _Datos.Leer_DateTime_Nulable("pr_100401058748")
          me.ImporteImporteDevolucion = _Datos.Leer_Decimal("pr_300401060674")
          me.ImporteImporteAfectadoADepositoTramitado = _Datos.Leer_Decimal("pr_300401060673")
          me.Observaciones = _Datos.Leer_String("pr_300401060680")
          me.ReferenciaTransaccionSecundaria = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_20040114142"), _Datos.Leer_String("pr_20040114142.nombre"))
          me.DevolucionTramitadaYValidadaObsoleto = _Datos.Leer_EnumTramitacionE("pr_300401060677")
          me.ReferenciaProveedor = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_300401060665"), _Datos.Leer_String("pr_300401060665.nombre"))
          me.FechaDeVencimiento = _Datos.Leer_Date_Nulable("pr_300401060679")
          me.ReferenciaTransaccionMonetariaInterna = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_60040106112"), _Datos.Leer_String("pr_60040106112.nombre"))
          me.ImporteTotalPagado = _Datos.Leer_Decimal("pr_300401060672")
          me.ReferenciaPuestoDeTrabajo = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_300401060664"), _Datos.Leer_String("pr_300401060664.nombre"))
          me.ReferenciaMetodoDePago = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_300401060663"), _Datos.Leer_String("pr_300401060663.nombre"))
          me.ReferenciaAutorDelAlta = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_100401058744"), _Datos.Leer_String("pr_100401058744.nombre"))
          me.ImporteTotalPagadoTramitado = _Datos.Leer_Decimal("pr_300401060670")
          me.FechaDeTramitacionYValidacion_UTC = _Datos.Leer_DateTime_Nulable("pr_300401060667")
          me.AutorDelAltaTieneAccesoWeb = _Datos.Leer_Boolean("pr_100401058759")
          me.ReferenciaEmisionDeChequeOPagareDevolucion = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_300401060658"), _Datos.Leer_String("pr_300401060658.nombre"))
          me.ProveedorTieneAccesoWeb = _Datos.Leer_Boolean("pr_300401060666")
          me.ImporteImporteAfectadoADeposito = _Datos.Leer_Decimal("pr_300401060669")
          me.Estado = _Datos.Leer_EnumTramitacionE("pr_300401060675")
          me.ReferenciaDestinador = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_100401058751"), _Datos.Leer_String("pr_100401058751.nombre"))
          me.HoraLocal = _Datos.Leer_Time_Nulable("pr_100401058746")
          me.ReferenciaUbicacionPrincipal = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_100401058743"), _Datos.Leer_String("pr_100401058743.nombre"))
          me.FechaDeTramitacionYValidacionDevolucionObsoleto_UTC = _Datos.Leer_DateTime_Nulable("pr_300401060668")
          me.ImporteImporte = _Datos.Leer_Decimal("pr_300401060671")
          me.ReferenciaEmpleadoPrincipal = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_100401058742"), _Datos.Leer_String("pr_100401058742.nombre"))
          me.ReferenciaDepositoMonetario = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_300401060659"), _Datos.Leer_String("pr_300401060659.nombre"))
          me.ReferenciaCompra = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_100401058762"), _Datos.Leer_String("pr_100401058762.nombre"))
          me.FechaDeVencimientoDevolucionObsoleto = _Datos.Leer_Date_Nulable("pr_300401060678")
          me.FechaContable = _Datos.Leer_Date_Nulable("pr_60040135701")
          me.ReferenciaAsientoContable = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_60040135301"), _Datos.Leer_String("pr_60040135301.nombre"))
          me.FechaLocalDeTramitacionYValidacion = _Datos.Leer_Date_Nulable("pr_20040141263")
          me.ReferenciaEmpleadoQueTramitaYValida = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_50040141241"), _Datos.Leer_String("pr_50040141241.nombre"))
          me.EmpleadoQueTramitaYValidaTieneAccesoWeb = _Datos.Leer_Boolean("pr_50040141242")
          me.ReferenciaMovimientoBancario = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_10040264601"), _Datos.Leer_String("pr_10040264601.nombre"))
          me.AsignarManualmenteLaFechaContable = _Datos.Leer_Boolean("pr_50040365592")
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
         R.add("pr_100401058757", me.EmpleadoTieneAccesoWeb.AdaptarMySQL_Boolean())
         If Me.ReferenciaMovimientoDeCajaOrigen IsNot nothing then
           R.add("pr_300401060661",me.ReferenciaMovimientoDeCajaOrigen.ID.STR())
         Else
           R.add("pr_300401060661","")
         End if
         R.add("pr_100401058745", me.FechaDato_UTC.AdaptarMySQL_DateTime_Nulable())
         If Me.ReferenciaMetodoDePagoDevolucionObsoleto IsNot nothing then
           R.add("pr_300401060662",me.ReferenciaMetodoDePagoDevolucionObsoleto.ID.STR())
         Else
           R.add("pr_300401060662","")
         End if
         R.add("pr_300401060676", me.TodoTramitadoYValidadoObsoleto.AdaptarMySQL_Boolean())
         If Me.ReferenciaEmisionDeChequeOPagare IsNot nothing then
           R.add("pr_300401060660",me.ReferenciaEmisionDeChequeOPagare.ID.STR())
         Else
           R.add("pr_300401060660","")
         End if
         R.add("pr_100401058748", me.FechaAlta_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_300401060674", me.ImporteImporteDevolucion.AdaptarMySQL_Decimal())
         R.add("pr_300401060673", me.ImporteImporteAfectadoADepositoTramitado.AdaptarMySQL_Decimal())
         R.add("pr_300401060680", me.Observaciones.AdaptarMySQL_String())
         If Me.ReferenciaTransaccionSecundaria IsNot nothing then
           R.add("pr_20040114142",me.ReferenciaTransaccionSecundaria.ID.STR())
         Else
           R.add("pr_20040114142","")
         End if
         R.add("pr_300401060677", me.DevolucionTramitadaYValidadaObsoleto.AdaptarMySQL_EnumTramitacionE())
         If Me.ReferenciaProveedor IsNot nothing then
           R.add("pr_300401060665",me.ReferenciaProveedor.ID.STR())
         Else
           R.add("pr_300401060665","")
         End if
         R.add("pr_300401060679", me.FechaDeVencimiento.AdaptarMySQL_Date_Nulable())
         If Me.ReferenciaTransaccionMonetariaInterna IsNot nothing then
           R.add("pr_60040106112",me.ReferenciaTransaccionMonetariaInterna.ID.STR())
         Else
           R.add("pr_60040106112","")
         End if
         R.add("pr_300401060672", me.ImporteTotalPagado.AdaptarMySQL_Decimal())
         If Me.ReferenciaPuestoDeTrabajo IsNot nothing then
           R.add("pr_300401060664",me.ReferenciaPuestoDeTrabajo.ID.STR())
         Else
           R.add("pr_300401060664","")
         End if
         If Me.ReferenciaMetodoDePago IsNot nothing then
           R.add("pr_300401060663",me.ReferenciaMetodoDePago.ID.STR())
         Else
           R.add("pr_300401060663","")
         End if
         If Me.ReferenciaAutorDelAlta IsNot nothing then
           R.add("pr_100401058744",me.ReferenciaAutorDelAlta.ID.STR())
         Else
           R.add("pr_100401058744","")
         End if
         R.add("pr_300401060670", me.ImporteTotalPagadoTramitado.AdaptarMySQL_Decimal())
         R.add("pr_300401060667", me.FechaDeTramitacionYValidacion_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_100401058759", me.AutorDelAltaTieneAccesoWeb.AdaptarMySQL_Boolean())
         If Me.ReferenciaEmisionDeChequeOPagareDevolucion IsNot nothing then
           R.add("pr_300401060658",me.ReferenciaEmisionDeChequeOPagareDevolucion.ID.STR())
         Else
           R.add("pr_300401060658","")
         End if
         R.add("pr_300401060666", me.ProveedorTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_300401060669", me.ImporteImporteAfectadoADeposito.AdaptarMySQL_Decimal())
         R.add("pr_300401060675", me.Estado.AdaptarMySQL_EnumTramitacionE())
         If Me.ReferenciaDestinador IsNot nothing then
           R.add("pr_100401058751",me.ReferenciaDestinador.ID.STR())
         Else
           R.add("pr_100401058751","")
         End if
         R.add("pr_100401058746", me.HoraLocal.AdaptarMySQL_Time_Nulable())
         If Me.ReferenciaUbicacionPrincipal IsNot nothing then
           R.add("pr_100401058743",me.ReferenciaUbicacionPrincipal.ID.STR())
         Else
           R.add("pr_100401058743","")
         End if
         R.add("pr_300401060668", me.FechaDeTramitacionYValidacionDevolucionObsoleto_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_300401060671", me.ImporteImporte.AdaptarMySQL_Decimal())
         If Me.ReferenciaEmpleadoPrincipal IsNot nothing then
           R.add("pr_100401058742",me.ReferenciaEmpleadoPrincipal.ID.STR())
         Else
           R.add("pr_100401058742","")
         End if
         If Me.ReferenciaDepositoMonetario IsNot nothing then
           R.add("pr_300401060659",me.ReferenciaDepositoMonetario.ID.STR())
         Else
           R.add("pr_300401060659","")
         End if
         If Me.ReferenciaCompra IsNot nothing then
           R.add("pr_100401058762",me.ReferenciaCompra.ID.STR())
         Else
           R.add("pr_100401058762","")
         End if
         R.add("pr_300401060678", me.FechaDeVencimientoDevolucionObsoleto.AdaptarMySQL_Date_Nulable())
         R.add("pr_60040135701", me.FechaContable.AdaptarMySQL_Date_Nulable())
         If Me.ReferenciaAsientoContable IsNot nothing then
           R.add("pr_60040135301",me.ReferenciaAsientoContable.ID.STR())
         Else
           R.add("pr_60040135301","")
         End if
         R.add("pr_20040141263", me.FechaLocalDeTramitacionYValidacion.AdaptarMySQL_Date_Nulable())
         If Me.ReferenciaEmpleadoQueTramitaYValida IsNot nothing then
           R.add("pr_50040141241",me.ReferenciaEmpleadoQueTramitaYValida.ID.STR())
         Else
           R.add("pr_50040141241","")
         End if
         R.add("pr_50040141242", me.EmpleadoQueTramitaYValidaTieneAccesoWeb.AdaptarMySQL_Boolean())
         If Me.ReferenciaMovimientoBancario IsNot nothing then
           R.add("pr_10040264601",me.ReferenciaMovimientoBancario.ID.STR())
         Else
           R.add("pr_10040264601","")
         End if
         R.add("pr_50040365592", me.AsignarManualmenteLaFechaContable.AdaptarMySQL_Boolean())
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
      Public Class PagosDeCompras_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
          Public property EmpleadoTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_100401058757")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_100401058757", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaMovimientoDeCajaOrigen As Guid
            get
                return me.GetValue_Guid("pr_300401060661")
            End Get   
        End Property
          Public property FechaDato_UTC As Date
            get
                return me.GetValue_DateTime("pr_100401058745")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_100401058745", value)
            End Set
          End Property
          Public property ReferenciaMetodoDePagoDevolucionObsoleto As Guid
            get
                return me.GetValue_Guid("pr_300401060662")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_300401060662", value)
            End Set
          End Property
        Public ReadOnly property TodoTramitadoYValidadoObsoleto As Boolean
            get
                return me.GetValue_Boolean("pr_300401060676")
            End Get   
        End Property
          Public property ReferenciaEmisionDeChequeOPagare As Guid
            get
                return me.GetValue_Guid("pr_300401060660")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_300401060660", value)
            End Set
          End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_100401058748")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_100401058748", value)
            End Set
          End Property
          Public property ImporteImporteDevolucion As Decimal
            get
                return me.GetValue_Decimal("pr_300401060674")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_300401060674", value)
            End Set
          End Property
        Public ReadOnly property ImporteImporteAfectadoADepositoTramitado As Decimal
            get
                return me.GetValue_Decimal("pr_300401060673")
            End Get   
        End Property
          Public property Observaciones As String
            get
                return me.GetValue_String("pr_300401060680")
            End Get
            Set(value As String)
                me.SetValue_String("pr_300401060680", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaTransaccionSecundaria As Guid
            get
                return me.GetValue_Guid("pr_20040114142")
            End Get   
        End Property
          Public property DevolucionTramitadaYValidadaObsoleto__Int as Integer
            get
                return me.GetValue_Int("pr_300401060677")
            End Get
            Set(value as Integer)
                me.SetValue_Int("pr_300401060677", value)
            End Set
          End Property
          Public property DevolucionTramitadaYValidadaObsoleto As EnumTramitacionE
            get
                return me.GetValue_Int("pr_300401060677")
            End Get
            Set(value As EnumTramitacionE)
                me.SetValue_Int("pr_300401060677", value)
            End Set
          End Property
          Public property ReferenciaProveedor As Guid
            get
                return me.GetValue_Guid("pr_300401060665")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_300401060665", value)
            End Set
          End Property
          Public property FechaDeVencimiento As Date
            get
                return me.GetValue_Date("pr_300401060679")
            End Get
            Set(value As Date)
                me.SetValue_Date("pr_300401060679", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaTransaccionMonetariaInterna As Guid
            get
                return me.GetValue_Guid("pr_60040106112")
            End Get   
        End Property
        Public ReadOnly property ImporteTotalPagado As Decimal
            get
                return me.GetValue_Decimal("pr_300401060672")
            End Get   
        End Property
          Public property ReferenciaPuestoDeTrabajo As Guid
            get
                return me.GetValue_Guid("pr_300401060664")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_300401060664", value)
            End Set
          End Property
          Public property ReferenciaMetodoDePago As Guid
            get
                return me.GetValue_Guid("pr_300401060663")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_300401060663", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_100401058744")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_100401058744", value)
            End Set
          End Property
        Public ReadOnly property ImporteTotalPagadoTramitado As Decimal
            get
                return me.GetValue_Decimal("pr_300401060670")
            End Get   
        End Property
        Public ReadOnly property FechaDeTramitacionYValidacion_UTC As Date
            get
                return me.GetValue_DateTime("pr_300401060667")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_100401058759")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_100401058759", value)
            End Set
          End Property
          Public property ReferenciaEmisionDeChequeOPagareDevolucion As Guid
            get
                return me.GetValue_Guid("pr_300401060658")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_300401060658", value)
            End Set
          End Property
          Public property ProveedorTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_300401060666")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_300401060666", value)
            End Set
          End Property
        Public ReadOnly property ImporteImporteAfectadoADeposito As Decimal
            get
                return me.GetValue_Decimal("pr_300401060669")
            End Get   
        End Property
          Public property Estado__Int as Integer
            get
                return me.GetValue_Int("pr_300401060675")
            End Get
            Set(value as Integer)
                me.SetValue_Int("pr_300401060675", value)
            End Set
          End Property
          Public property Estado As EnumTramitacionE
            get
                return me.GetValue_Int("pr_300401060675")
            End Get
            Set(value As EnumTramitacionE)
                me.SetValue_Int("pr_300401060675", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_100401058751")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As DateTime
            get
                return me.GetValue_DateTime("pr_100401058746")
            End Get   
        End Property
          Public property ReferenciaUbicacionPrincipal As Guid
            get
                return me.GetValue_Guid("pr_100401058743")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_100401058743", value)
            End Set
          End Property
          Public property FechaDeTramitacionYValidacionDevolucionObsoleto_UTC As Date
            get
                return me.GetValue_DateTime("pr_300401060668")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_300401060668", value)
            End Set
          End Property
          Public property ImporteImporte As Decimal
            get
                return me.GetValue_Decimal("pr_300401060671")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_300401060671", value)
            End Set
          End Property
          Public property ReferenciaEmpleadoPrincipal As Guid
            get
                return me.GetValue_Guid("pr_100401058742")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_100401058742", value)
            End Set
          End Property
          Public property ReferenciaDepositoMonetario As Guid
            get
                return me.GetValue_Guid("pr_300401060659")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_300401060659", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaCompra As Guid
            get
                return me.GetValue_Guid("pr_100401058762")
            End Get   
        End Property
          Public property FechaDeVencimientoDevolucionObsoleto As Date
            get
                return me.GetValue_Date("pr_300401060678")
            End Get
            Set(value As Date)
                me.SetValue_Date("pr_300401060678", value)
            End Set
          End Property
          Public property FechaContable As Date
            get
                return me.GetValue_Date("pr_60040135701")
            End Get
            Set(value As Date)
                me.SetValue_Date("pr_60040135701", value)
            End Set
          End Property
          Public property ReferenciaAsientoContable As Guid
            get
                return me.GetValue_Guid("pr_60040135301")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_60040135301", value)
            End Set
          End Property
        Public ReadOnly property FechaLocalDeTramitacionYValidacion As Date
            get
                return me.GetValue_Date("pr_20040141263")
            End Get   
        End Property
        Public ReadOnly property ReferenciaEmpleadoQueTramitaYValida As Guid
            get
                return me.GetValue_Guid("pr_50040141241")
            End Get   
        End Property
          Public property EmpleadoQueTramitaYValidaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_50040141242")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_50040141242", value)
            End Set
          End Property
          Public property ReferenciaMovimientoBancario As Guid
            get
                return me.GetValue_Guid("pr_10040264601")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_10040264601", value)
            End Set
          End Property
          Public property AsignarManualmenteLaFechaContable As Boolean
            get
                return me.GetValue_Boolean("pr_50040365592")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_50040365592", value)
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
