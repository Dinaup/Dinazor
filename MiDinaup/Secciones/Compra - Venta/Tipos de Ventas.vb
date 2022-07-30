   Imports System.ComponentModel
   Imports DinaNETCore
   Imports DinaNETCore.APID
Partial Public Class SeccionesD
  Public Class TiposDeVentasD
      Public Shared _SeccionID As String = "c7f23740-9d13-40c0-9261-a624e309e2e7"
      Public Shared _SeccionIDGUID As New Guid("c7f23740-9d13-40c0-9261-a624e309e2e7")
      Public Shared Async Function ConsultarDatos_Async(Parametros As SeccionConsultaParametrosC) As Task(Of List(Of TiposDeVentasC )) 
          Dim R As New List(Of TiposDeVentasC )  
          Dim d = Await Parametros.DinaupSesion.ConexionServidor.Funcion_Datos_Recibir_Async(TiposDeVentasES._SeccionID, False, Parametros) 
          If d.Datos.TieneDatos Then 
              For Each Actual In d.Datos 
                  Dim Valores_Listador = Actual.Value.Item1
                  Dim Obj_Listador As New TiposDeVentasC 
                  Obj_Listador.CargarDatos(Valores_Listador) 
                  Obj_Listador.CargaInterna(Actual.Value)
                  R.Add(Obj_Listador) 
              Next 
          End If 
          Return R 
      End Function 
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As TiposDeVentasC, Optional CampoWhere$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Return Await DatosGuardar_Async(DinaupSesion, New List(Of TiposDeVentasC)({DAtos}), CampoWhere )
      End Function
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As List(Of TiposDeVentasC), Optional CampoWhere$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Dim Importar As New List(Of DinaupAPI_ImportacionProcesableC)
          For Each Actual In DAtos 
              Dim RegistroActual = New DinaupAPI_ImportacionProcesableC() 
               RegistroActual.dinaup_listador_datos = Actual.ToDic 
               Importar.Add(RegistroActual)  
          Next 
          Return Await DinaupSesion.ConexionServidor.Funcion_Importar_Ejecutar_Async(DinaupSesion, TiposDeVentasES._SeccionID, Importar, CampoWhere, "") 
      End Function
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As TiposDeVentas_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, TiposDeVentasES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New TiposDeVentas_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As TiposDeVentas_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, TiposDeVentasES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New TiposDeVentas_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class TiposDeVentasES
          Public shared _SeccionID as Guid = New Guid("c7f23740-9d13-40c0-9261-a624e309e2e7")
          Public shared _Tabla$ = "tpr_476b991wc"
      Public Shared ExportarEnModulos$ = "pr_1463107a6ax1a5wd"
      Public Shared FechaAlta_UTC$ = "pr_14c9f3f0d3x350wd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_1463107a1dx3cdwd"
      Public Shared ReferenciaDestinador$ = "pr_1463107ae6x1adwd"
      Public Shared HoraLocal$ = "pr_776ae22wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_146314a801k23ewd"
      Public Shared NotaQueDebeIncluirLaFactura$ = "pr_60040239111"
      Public Shared RellenadoObligatorioDeCodigoPostalReceptor$ = "pr_40040239387"
      Public Shared RellenadoObligatorioDeDenominacionRazonSocialReceptor$ = "pr_40040239382"
      Public Shared RellenadoObligatorioDeCIFNIFEmisor$ = "pr_400402393811"
      Public Shared RellenadoObligatorioDePaisEmisor$ = "pr_50040239381"
      Public Shared ImporteImporteMaximoImpuestosIncluidos$ = "pr_30040239382"
      Public Shared RellenadoObligatorioDeMunicipioEmisor$ = "pr_50040239383"
      Public Shared RellenadoObligatorioDeDireccionEmisor$ = "pr_50040239386"
      Public Shared RellenadoObligatorioDeDenominacionRazonSocialEmisor$ = "pr_400402393810"
      Public Shared RellenadoObligatorioDeProvinciaEmisor$ = "pr_50040239382"
      Public Shared RellenadoObligatorioDeTelefonoEmisor$ = "pr_50040239385"
      Public Shared RellenadoObligatorioDeCodigoPostalEmisor$ = "pr_50040239384"
      Public Shared RellenadoObligatorioDeMunicipioReceptor$ = "pr_40040239386"
      Public Shared RellenadoObligatorioDePaisReceptor$ = "pr_40040239384"
      Public Shared RellenadoObligatorioDeTelefonoReceptor$ = "pr_40040239388"
      Public Shared RellenadoObligatorioDeCodigoDePaisReceptor$ = "pr_60040241542"
      Public Shared RellenadoObligatorioDeProvinciaReceptor$ = "pr_40040239385"
      Public Shared RellenadoObligatorioDeCIFNIFReceptor$ = "pr_40040239383"
      Public Shared RellenadoObligatorioDeCodigoDeProvinciaReceptor$ = "pr_60040241541"
      Public Shared RellenadoObligatorioDeDireccionReceptor$ = "pr_40040239389"
      Public Shared RellenadoObligatorioDeTipoDeNIFReceptor$ = "pr_30040241601"
      Public Shared RellenadoObligatorioDeClaveDeOperacionIntracomunitaria$ = "pr_40040242991"
      Public Shared RellenadoObligatorioDeNIFIntracomunitarioReceptor$ = "pr_40040255424"
      Public Shared RellenadoObligatorioDeNIFIntracomunitarioEmisor$ = "pr_40040255423"
      Public Shared ReferenciaActividadPredeterminada$ = "pr_20040256141"
      Public Shared ReferenciaClavePredeterminadaDeOperaciones$ = "pr_30040256991"
      Public Shared EsUnMovimientoSinFactura$ = "pr_60040266783"
      Public Shared PrefijoConceptoDeAsiento$ = "pr_60040271003"
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
      Public Class TiposDeVentasC
      Inherits Base_DatoC
          <DisplayName("Fecha Alta del registro")>
          Public Property FechaAlta_UTC As Date?
          Public Shared ___FechaAlta_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaAlta_UTC"",""etiqueta"": ""Fecha Alta del registro"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Alta del registro"",""descripcion"": """",""keyword"": ""FechaAlta_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaAlta_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaAlta_UTC
          <DisplayName("Autor del alta")>
          Public Property ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaAutorDelAlta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaAutorDelAlta"",""etiqueta"": ""Autor del alta"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta"",""descripcion"": """",""keyword"": ""ReferenciaAutorDelAlta"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaAutorDelAlta
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
          <DisplayName("Nota que debe incluir la factura")>
          Public Property NotaQueDebeIncluirLaFactura As String
          Public Shared ___NotaQueDebeIncluirLaFactura As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""NotaQueDebeIncluirLaFactura"",""etiqueta"": ""Nota que debe incluir la factura"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 9,""decimales"": ""0"",""multilinea"": true,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Nota que debe incluir la factura"",""descripcion"": """",""keyword"": ""NotaQueDebeIncluirLaFactura"",""formato"": 5,""rol"": 9,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __NotaQueDebeIncluirLaFactura As DinaNETCore.APID.DinaupAPI_CampoC = ___NotaQueDebeIncluirLaFactura
          <DisplayName("Rellenado obligatorio de Código postal (Receptor)")>
          Public Property RellenadoObligatorioDeCodigoPostalReceptor As Boolean
          Public Shared ___RellenadoObligatorioDeCodigoPostalReceptor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RellenadoObligatorioDeCodigoPostalReceptor"",""etiqueta"": ""Rellenado obligatorio de Código postal (Receptor)"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Rellenado obligatorio de Código postal (Receptor)"",""descripcion"": """",""keyword"": ""RellenadoObligatorioDeCodigoPostalReceptor"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RellenadoObligatorioDeCodigoPostalReceptor As DinaNETCore.APID.DinaupAPI_CampoC = ___RellenadoObligatorioDeCodigoPostalReceptor
          <DisplayName("Rellenado obligatorio de Denominación / Razón Social (Receptor)")>
          Public Property RellenadoObligatorioDeDenominacionRazonSocialReceptor As Boolean
          Public Shared ___RellenadoObligatorioDeDenominacionRazonSocialReceptor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RellenadoObligatorioDeDenominacionRazonSocialReceptor"",""etiqueta"": ""Rellenado obligatorio de Denominación / Razón Social (Receptor)"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Rellenado obligatorio de Denominación / Razón Social (Receptor)"",""descripcion"": """",""keyword"": ""RellenadoObligatorioDeDenominacionRazonSocialReceptor"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RellenadoObligatorioDeDenominacionRazonSocialReceptor As DinaNETCore.APID.DinaupAPI_CampoC = ___RellenadoObligatorioDeDenominacionRazonSocialReceptor
          <DisplayName("Rellenado obligatorio de CIF/NIF (Emisor)")>
          Public Property RellenadoObligatorioDeCIFNIFEmisor As Boolean
          Public Shared ___RellenadoObligatorioDeCIFNIFEmisor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RellenadoObligatorioDeCIFNIFEmisor"",""etiqueta"": ""Rellenado obligatorio de CIF/NIF (Emisor)"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Rellenado obligatorio de CIF/NIF (Emisor)"",""descripcion"": """",""keyword"": ""RellenadoObligatorioDeCIFNIFEmisor"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RellenadoObligatorioDeCIFNIFEmisor As DinaNETCore.APID.DinaupAPI_CampoC = ___RellenadoObligatorioDeCIFNIFEmisor
          <DisplayName("Rellenado obligatorio de País (Emisor)")>
          Public Property RellenadoObligatorioDePaisEmisor As Boolean
          Public Shared ___RellenadoObligatorioDePaisEmisor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RellenadoObligatorioDePaisEmisor"",""etiqueta"": ""Rellenado obligatorio de País (Emisor)"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Rellenado obligatorio de País (Emisor)"",""descripcion"": """",""keyword"": ""RellenadoObligatorioDePaisEmisor"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RellenadoObligatorioDePaisEmisor As DinaNETCore.APID.DinaupAPI_CampoC = ___RellenadoObligatorioDePaisEmisor
          <DisplayName("Importe máximo (Impuestos incluidos)")>
          Public Property ImporteImporteMaximoImpuestosIncluidos As Decimal
          Public Shared ___ImporteImporteMaximoImpuestosIncluidos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteImporteMaximoImpuestosIncluidos"",""etiqueta"": ""Importe máximo (Impuestos incluidos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Importe máximo (Impuestos incluidos)"",""descripcion"": """",""keyword"": ""ImporteImporteMaximoImpuestosIncluidos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteImporteMaximoImpuestosIncluidos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteImporteMaximoImpuestosIncluidos
          <DisplayName("Rellenado obligatorio de Municipio (Emisor)")>
          Public Property RellenadoObligatorioDeMunicipioEmisor As Boolean
          Public Shared ___RellenadoObligatorioDeMunicipioEmisor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RellenadoObligatorioDeMunicipioEmisor"",""etiqueta"": ""Rellenado obligatorio de Municipio (Emisor)"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Rellenado obligatorio de Municipio (Emisor)"",""descripcion"": """",""keyword"": ""RellenadoObligatorioDeMunicipioEmisor"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RellenadoObligatorioDeMunicipioEmisor As DinaNETCore.APID.DinaupAPI_CampoC = ___RellenadoObligatorioDeMunicipioEmisor
          <DisplayName("Rellenado obligatorio de Dirección (Emisor)")>
          Public Property RellenadoObligatorioDeDireccionEmisor As Boolean
          Public Shared ___RellenadoObligatorioDeDireccionEmisor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RellenadoObligatorioDeDireccionEmisor"",""etiqueta"": ""Rellenado obligatorio de Dirección (Emisor)"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Rellenado obligatorio de Dirección (Emisor)"",""descripcion"": """",""keyword"": ""RellenadoObligatorioDeDireccionEmisor"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RellenadoObligatorioDeDireccionEmisor As DinaNETCore.APID.DinaupAPI_CampoC = ___RellenadoObligatorioDeDireccionEmisor
          <DisplayName("Rellenado obligatorio de Denominación / Razón Social (Emisor)")>
          Public Property RellenadoObligatorioDeDenominacionRazonSocialEmisor As Boolean
          Public Shared ___RellenadoObligatorioDeDenominacionRazonSocialEmisor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RellenadoObligatorioDeDenominacionRazonSocialEmisor"",""etiqueta"": ""Rellenado obligatorio de Denominación / Razón Social (Emisor)"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Rellenado obligatorio de Denominación / Razón Social (Emisor)"",""descripcion"": """",""keyword"": ""RellenadoObligatorioDeDenominacionRazonSocialEmisor"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RellenadoObligatorioDeDenominacionRazonSocialEmisor As DinaNETCore.APID.DinaupAPI_CampoC = ___RellenadoObligatorioDeDenominacionRazonSocialEmisor
          <DisplayName("Rellenado obligatorio de Provincia (Emisor)")>
          Public Property RellenadoObligatorioDeProvinciaEmisor As Boolean
          Public Shared ___RellenadoObligatorioDeProvinciaEmisor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RellenadoObligatorioDeProvinciaEmisor"",""etiqueta"": ""Rellenado obligatorio de Provincia (Emisor)"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Rellenado obligatorio de Provincia (Emisor)"",""descripcion"": """",""keyword"": ""RellenadoObligatorioDeProvinciaEmisor"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RellenadoObligatorioDeProvinciaEmisor As DinaNETCore.APID.DinaupAPI_CampoC = ___RellenadoObligatorioDeProvinciaEmisor
          <DisplayName("Rellenado obligatorio de Teléfono (Emisor)")>
          Public Property RellenadoObligatorioDeTelefonoEmisor As Boolean
          Public Shared ___RellenadoObligatorioDeTelefonoEmisor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RellenadoObligatorioDeTelefonoEmisor"",""etiqueta"": ""Rellenado obligatorio de Teléfono (Emisor)"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Rellenado obligatorio de Teléfono (Emisor)"",""descripcion"": """",""keyword"": ""RellenadoObligatorioDeTelefonoEmisor"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RellenadoObligatorioDeTelefonoEmisor As DinaNETCore.APID.DinaupAPI_CampoC = ___RellenadoObligatorioDeTelefonoEmisor
          <DisplayName("Rellenado obligatorio de Código postal (Emisor)")>
          Public Property RellenadoObligatorioDeCodigoPostalEmisor As Boolean
          Public Shared ___RellenadoObligatorioDeCodigoPostalEmisor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RellenadoObligatorioDeCodigoPostalEmisor"",""etiqueta"": ""Rellenado obligatorio de Código postal (Emisor)"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Rellenado obligatorio de Código postal (Emisor)"",""descripcion"": """",""keyword"": ""RellenadoObligatorioDeCodigoPostalEmisor"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RellenadoObligatorioDeCodigoPostalEmisor As DinaNETCore.APID.DinaupAPI_CampoC = ___RellenadoObligatorioDeCodigoPostalEmisor
          <DisplayName("Rellenado obligatorio de Municipio (Receptor)")>
          Public Property RellenadoObligatorioDeMunicipioReceptor As Boolean
          Public Shared ___RellenadoObligatorioDeMunicipioReceptor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RellenadoObligatorioDeMunicipioReceptor"",""etiqueta"": ""Rellenado obligatorio de Municipio (Receptor)"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Rellenado obligatorio de Municipio (Receptor)"",""descripcion"": """",""keyword"": ""RellenadoObligatorioDeMunicipioReceptor"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RellenadoObligatorioDeMunicipioReceptor As DinaNETCore.APID.DinaupAPI_CampoC = ___RellenadoObligatorioDeMunicipioReceptor
          <DisplayName("Rellenado obligatorio de País (Receptor)")>
          Public Property RellenadoObligatorioDePaisReceptor As Boolean
          Public Shared ___RellenadoObligatorioDePaisReceptor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RellenadoObligatorioDePaisReceptor"",""etiqueta"": ""Rellenado obligatorio de País (Receptor)"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Rellenado obligatorio de País (Receptor)"",""descripcion"": """",""keyword"": ""RellenadoObligatorioDePaisReceptor"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RellenadoObligatorioDePaisReceptor As DinaNETCore.APID.DinaupAPI_CampoC = ___RellenadoObligatorioDePaisReceptor
          <DisplayName("Rellenado obligatorio de Teléfono (Receptor)")>
          Public Property RellenadoObligatorioDeTelefonoReceptor As Boolean
          Public Shared ___RellenadoObligatorioDeTelefonoReceptor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RellenadoObligatorioDeTelefonoReceptor"",""etiqueta"": ""Rellenado obligatorio de Teléfono (Receptor)"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Rellenado obligatorio de Teléfono (Receptor)"",""descripcion"": """",""keyword"": ""RellenadoObligatorioDeTelefonoReceptor"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RellenadoObligatorioDeTelefonoReceptor As DinaNETCore.APID.DinaupAPI_CampoC = ___RellenadoObligatorioDeTelefonoReceptor
          <DisplayName("Rellenado obligatorio de Código de País (Receptor)")>
          Public Property RellenadoObligatorioDeCodigoDePaisReceptor As Boolean
          Public Shared ___RellenadoObligatorioDeCodigoDePaisReceptor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RellenadoObligatorioDeCodigoDePaisReceptor"",""etiqueta"": ""Rellenado obligatorio de Código de País (Receptor)"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Rellenado obligatorio de Código de País (Receptor)"",""descripcion"": """",""keyword"": ""RellenadoObligatorioDeCodigoDePaisReceptor"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RellenadoObligatorioDeCodigoDePaisReceptor As DinaNETCore.APID.DinaupAPI_CampoC = ___RellenadoObligatorioDeCodigoDePaisReceptor
          <DisplayName("Rellenado obligatorio de Provincia (Receptor)")>
          Public Property RellenadoObligatorioDeProvinciaReceptor As Boolean
          Public Shared ___RellenadoObligatorioDeProvinciaReceptor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RellenadoObligatorioDeProvinciaReceptor"",""etiqueta"": ""Rellenado obligatorio de Provincia (Receptor)"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Rellenado obligatorio de Provincia (Receptor)"",""descripcion"": """",""keyword"": ""RellenadoObligatorioDeProvinciaReceptor"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RellenadoObligatorioDeProvinciaReceptor As DinaNETCore.APID.DinaupAPI_CampoC = ___RellenadoObligatorioDeProvinciaReceptor
          <DisplayName("Rellenado obligatorio de CIF/NIF (Receptor)")>
          Public Property RellenadoObligatorioDeCIFNIFReceptor As Boolean
          Public Shared ___RellenadoObligatorioDeCIFNIFReceptor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RellenadoObligatorioDeCIFNIFReceptor"",""etiqueta"": ""Rellenado obligatorio de CIF/NIF (Receptor)"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Rellenado obligatorio de CIF/NIF (Receptor)"",""descripcion"": """",""keyword"": ""RellenadoObligatorioDeCIFNIFReceptor"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RellenadoObligatorioDeCIFNIFReceptor As DinaNETCore.APID.DinaupAPI_CampoC = ___RellenadoObligatorioDeCIFNIFReceptor
          <DisplayName("Rellenado obligatorio de Código de Provincia (Receptor)")>
          Public Property RellenadoObligatorioDeCodigoDeProvinciaReceptor As Boolean
          Public Shared ___RellenadoObligatorioDeCodigoDeProvinciaReceptor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RellenadoObligatorioDeCodigoDeProvinciaReceptor"",""etiqueta"": ""Rellenado obligatorio de Código de Provincia (Receptor)"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Rellenado obligatorio de Código de Provincia (Receptor)"",""descripcion"": """",""keyword"": ""RellenadoObligatorioDeCodigoDeProvinciaReceptor"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RellenadoObligatorioDeCodigoDeProvinciaReceptor As DinaNETCore.APID.DinaupAPI_CampoC = ___RellenadoObligatorioDeCodigoDeProvinciaReceptor
          <DisplayName("Rellenado obligatorio de Dirección (Receptor)")>
          Public Property RellenadoObligatorioDeDireccionReceptor As Boolean
          Public Shared ___RellenadoObligatorioDeDireccionReceptor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RellenadoObligatorioDeDireccionReceptor"",""etiqueta"": ""Rellenado obligatorio de Dirección (Receptor)"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Rellenado obligatorio de Dirección (Receptor)"",""descripcion"": """",""keyword"": ""RellenadoObligatorioDeDireccionReceptor"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RellenadoObligatorioDeDireccionReceptor As DinaNETCore.APID.DinaupAPI_CampoC = ___RellenadoObligatorioDeDireccionReceptor
          <DisplayName("Rellenado obligatorio de Tipo de NIF (Receptor)")>
          Public Property RellenadoObligatorioDeTipoDeNIFReceptor As Boolean
          Public Shared ___RellenadoObligatorioDeTipoDeNIFReceptor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RellenadoObligatorioDeTipoDeNIFReceptor"",""etiqueta"": ""Rellenado obligatorio de Tipo de NIF (Receptor)"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Rellenado obligatorio de Tipo de NIF (Receptor)"",""descripcion"": """",""keyword"": ""RellenadoObligatorioDeTipoDeNIFReceptor"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RellenadoObligatorioDeTipoDeNIFReceptor As DinaNETCore.APID.DinaupAPI_CampoC = ___RellenadoObligatorioDeTipoDeNIFReceptor
          <DisplayName("Rellenado obligatorio de Clave de operación intracomunitaria")>
          Public Property RellenadoObligatorioDeClaveDeOperacionIntracomunitaria As Boolean
          Public Shared ___RellenadoObligatorioDeClaveDeOperacionIntracomunitaria As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RellenadoObligatorioDeClaveDeOperacionIntracomunitaria"",""etiqueta"": ""Rellenado obligatorio de Clave de operación intracomunitaria"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Rellenado obligatorio de Clave de operación intracomunitaria"",""descripcion"": """",""keyword"": ""RellenadoObligatorioDeClaveDeOperacionIntracomunitaria"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RellenadoObligatorioDeClaveDeOperacionIntracomunitaria As DinaNETCore.APID.DinaupAPI_CampoC = ___RellenadoObligatorioDeClaveDeOperacionIntracomunitaria
          <DisplayName("Rellenado obligatorio de NIF Intracomunitario (Receptor)")>
          Public Property RellenadoObligatorioDeNIFIntracomunitarioReceptor As Boolean
          Public Shared ___RellenadoObligatorioDeNIFIntracomunitarioReceptor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RellenadoObligatorioDeNIFIntracomunitarioReceptor"",""etiqueta"": ""Rellenado obligatorio de NIF Intracomunitario (Receptor)"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Rellenado obligatorio de NIF Intracomunitario (Receptor)"",""descripcion"": """",""keyword"": ""RellenadoObligatorioDeNIFIntracomunitarioReceptor"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RellenadoObligatorioDeNIFIntracomunitarioReceptor As DinaNETCore.APID.DinaupAPI_CampoC = ___RellenadoObligatorioDeNIFIntracomunitarioReceptor
          <DisplayName("Rellenado obligatorio de NIF Intracomunitario (Emisor)")>
          Public Property RellenadoObligatorioDeNIFIntracomunitarioEmisor As Boolean
          Public Shared ___RellenadoObligatorioDeNIFIntracomunitarioEmisor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RellenadoObligatorioDeNIFIntracomunitarioEmisor"",""etiqueta"": ""Rellenado obligatorio de NIF Intracomunitario (Emisor)"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Rellenado obligatorio de NIF Intracomunitario (Emisor)"",""descripcion"": """",""keyword"": ""RellenadoObligatorioDeNIFIntracomunitarioEmisor"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RellenadoObligatorioDeNIFIntracomunitarioEmisor As DinaNETCore.APID.DinaupAPI_CampoC = ___RellenadoObligatorioDeNIFIntracomunitarioEmisor
          <DisplayName("Actividad predeterminada")>
          Public Property ReferenciaActividadPredeterminada As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaActividadPredeterminada As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaActividadPredeterminada"",""etiqueta"": ""Actividad predeterminada"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""f6221df1-2f56-4f49-8e45-dd4914873fa8"",""titulo"": ""Base - Actividades de Empresas"",""iconoid"": ""c33cb208-e4a6-4189-af8f-00aa92e9599a"",""etiquetasingular"": ""Actividad de Empresa"",""etiquetaplural"": ""Actividades de Empresa"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""f6221df1-2f56-4f49-8e45-dd4914873fa8"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Actividad predeterminada"",""descripcion"": """",""keyword"": ""ReferenciaActividadPredeterminada"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaActividadPredeterminada As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaActividadPredeterminada
          <DisplayName("Clave predeterminada de operaciones")>
          Public Property ReferenciaClavePredeterminadaDeOperaciones As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaClavePredeterminadaDeOperaciones As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaClavePredeterminadaDeOperaciones"",""etiqueta"": ""Clave predeterminada de operaciones"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""953e3b4c-09d4-4c99-8890-0e9caf431c4b"",""titulo"": ""Base - Claves de operaciones"",""iconoid"": ""82fa82ed-055f-4f1b-8f3c-79d2b6777e7e"",""etiquetasingular"": ""Clave de operación"",""etiquetaplural"": ""Claves de operaciones"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""953e3b4c-09d4-4c99-8890-0e9caf431c4b"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Clave predeterminada de operaciones"",""descripcion"": """",""keyword"": ""ReferenciaClavePredeterminadaDeOperaciones"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaClavePredeterminadaDeOperaciones As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaClavePredeterminadaDeOperaciones
          <DisplayName("Es un ingreso sin factura")>
          Public Property EsUnMovimientoSinFactura As Boolean
          Public Shared ___EsUnMovimientoSinFactura As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EsUnMovimientoSinFactura"",""etiqueta"": ""Es un ingreso sin factura"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Es un ingreso sin factura"",""descripcion"": """",""keyword"": ""EsUnMovimientoSinFactura"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EsUnMovimientoSinFactura As DinaNETCore.APID.DinaupAPI_CampoC = ___EsUnMovimientoSinFactura
          <DisplayName("Prefijo concepto de asiento")>
          Public Property PrefijoConceptoDeAsiento As String
          Public Shared ___PrefijoConceptoDeAsiento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""PrefijoConceptoDeAsiento"",""etiqueta"": ""Prefijo concepto de asiento"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Prefijo concepto de asiento"",""descripcion"": """",""keyword"": ""PrefijoConceptoDeAsiento"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __PrefijoConceptoDeAsiento As DinaNETCore.APID.DinaupAPI_CampoC = ___PrefijoConceptoDeAsiento
          <ReadOnlyAttribute(True)>
          <DisplayName("ID")>
          Public Property ID As Guid
          Public Shared ___ID As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": true,""eseliminado"": false,""keyword"": ""ID"",""etiqueta"": ""ID"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c7f23740-9d13-40c0-9261-a624e309e2e7"",""titulo"": ""Tipos de Ventas"",""iconoid"": ""d720d25f-f5b8-4c83-a9f3-a8bf6cb31468"",""etiquetasingular"": ""Tipo de venta"",""etiquetaplural"": ""Tipos de Ventas"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""c7f23740-9d13-40c0-9261-a624e309e2e7"",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""ID"",""descripcion"": """",""keyword"": ""ID"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
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
          me.FechaAlta_UTC = _Datos.Leer_DateTime_Nulable("pr_14c9f3f0d3x350wd")
          me.ReferenciaAutorDelAlta = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_1463107a1dx3cdwd"), _Datos.Leer_String("pr_1463107a1dx3cdwd.nombre"))
          me.ReferenciaDestinador = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_1463107ae6x1adwd"), _Datos.Leer_String("pr_1463107ae6x1adwd.nombre"))
          me.HoraLocal = _Datos.Leer_Time_Nulable("pr_776ae22wd")
          me.AutorDelAltaTieneAccesoWeb = _Datos.Leer_Boolean("pr_146314a801k23ewd")
          me.NotaQueDebeIncluirLaFactura = _Datos.Leer_String("pr_60040239111")
          me.RellenadoObligatorioDeCodigoPostalReceptor = _Datos.Leer_Boolean("pr_40040239387")
          me.RellenadoObligatorioDeDenominacionRazonSocialReceptor = _Datos.Leer_Boolean("pr_40040239382")
          me.RellenadoObligatorioDeCIFNIFEmisor = _Datos.Leer_Boolean("pr_400402393811")
          me.RellenadoObligatorioDePaisEmisor = _Datos.Leer_Boolean("pr_50040239381")
          me.ImporteImporteMaximoImpuestosIncluidos = _Datos.Leer_Decimal("pr_30040239382")
          me.RellenadoObligatorioDeMunicipioEmisor = _Datos.Leer_Boolean("pr_50040239383")
          me.RellenadoObligatorioDeDireccionEmisor = _Datos.Leer_Boolean("pr_50040239386")
          me.RellenadoObligatorioDeDenominacionRazonSocialEmisor = _Datos.Leer_Boolean("pr_400402393810")
          me.RellenadoObligatorioDeProvinciaEmisor = _Datos.Leer_Boolean("pr_50040239382")
          me.RellenadoObligatorioDeTelefonoEmisor = _Datos.Leer_Boolean("pr_50040239385")
          me.RellenadoObligatorioDeCodigoPostalEmisor = _Datos.Leer_Boolean("pr_50040239384")
          me.RellenadoObligatorioDeMunicipioReceptor = _Datos.Leer_Boolean("pr_40040239386")
          me.RellenadoObligatorioDePaisReceptor = _Datos.Leer_Boolean("pr_40040239384")
          me.RellenadoObligatorioDeTelefonoReceptor = _Datos.Leer_Boolean("pr_40040239388")
          me.RellenadoObligatorioDeCodigoDePaisReceptor = _Datos.Leer_Boolean("pr_60040241542")
          me.RellenadoObligatorioDeProvinciaReceptor = _Datos.Leer_Boolean("pr_40040239385")
          me.RellenadoObligatorioDeCIFNIFReceptor = _Datos.Leer_Boolean("pr_40040239383")
          me.RellenadoObligatorioDeCodigoDeProvinciaReceptor = _Datos.Leer_Boolean("pr_60040241541")
          me.RellenadoObligatorioDeDireccionReceptor = _Datos.Leer_Boolean("pr_40040239389")
          me.RellenadoObligatorioDeTipoDeNIFReceptor = _Datos.Leer_Boolean("pr_30040241601")
          me.RellenadoObligatorioDeClaveDeOperacionIntracomunitaria = _Datos.Leer_Boolean("pr_40040242991")
          me.RellenadoObligatorioDeNIFIntracomunitarioReceptor = _Datos.Leer_Boolean("pr_40040255424")
          me.RellenadoObligatorioDeNIFIntracomunitarioEmisor = _Datos.Leer_Boolean("pr_40040255423")
          me.ReferenciaActividadPredeterminada = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_20040256141"), _Datos.Leer_String("pr_20040256141.nombre"))
          me.ReferenciaClavePredeterminadaDeOperaciones = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_30040256991"), _Datos.Leer_String("pr_30040256991.nombre"))
          me.EsUnMovimientoSinFactura = _Datos.Leer_Boolean("pr_60040266783")
          me.PrefijoConceptoDeAsiento = _Datos.Leer_String("pr_60040271003")
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
         R.add("pr_14c9f3f0d3x350wd", me.FechaAlta_UTC.AdaptarMySQL_DateTime_Nulable())
         If Me.ReferenciaAutorDelAlta IsNot nothing then
           R.add("pr_1463107a1dx3cdwd",me.ReferenciaAutorDelAlta.ID.STR())
         Else
           R.add("pr_1463107a1dx3cdwd","")
         End if
         If Me.ReferenciaDestinador IsNot nothing then
           R.add("pr_1463107ae6x1adwd",me.ReferenciaDestinador.ID.STR())
         Else
           R.add("pr_1463107ae6x1adwd","")
         End if
         R.add("pr_776ae22wd", me.HoraLocal.AdaptarMySQL_Time_Nulable())
         R.add("pr_146314a801k23ewd", me.AutorDelAltaTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_60040239111", me.NotaQueDebeIncluirLaFactura.AdaptarMySQL_String())
         R.add("pr_40040239387", me.RellenadoObligatorioDeCodigoPostalReceptor.AdaptarMySQL_Boolean())
         R.add("pr_40040239382", me.RellenadoObligatorioDeDenominacionRazonSocialReceptor.AdaptarMySQL_Boolean())
         R.add("pr_400402393811", me.RellenadoObligatorioDeCIFNIFEmisor.AdaptarMySQL_Boolean())
         R.add("pr_50040239381", me.RellenadoObligatorioDePaisEmisor.AdaptarMySQL_Boolean())
         R.add("pr_30040239382", me.ImporteImporteMaximoImpuestosIncluidos.AdaptarMySQL_Decimal())
         R.add("pr_50040239383", me.RellenadoObligatorioDeMunicipioEmisor.AdaptarMySQL_Boolean())
         R.add("pr_50040239386", me.RellenadoObligatorioDeDireccionEmisor.AdaptarMySQL_Boolean())
         R.add("pr_400402393810", me.RellenadoObligatorioDeDenominacionRazonSocialEmisor.AdaptarMySQL_Boolean())
         R.add("pr_50040239382", me.RellenadoObligatorioDeProvinciaEmisor.AdaptarMySQL_Boolean())
         R.add("pr_50040239385", me.RellenadoObligatorioDeTelefonoEmisor.AdaptarMySQL_Boolean())
         R.add("pr_50040239384", me.RellenadoObligatorioDeCodigoPostalEmisor.AdaptarMySQL_Boolean())
         R.add("pr_40040239386", me.RellenadoObligatorioDeMunicipioReceptor.AdaptarMySQL_Boolean())
         R.add("pr_40040239384", me.RellenadoObligatorioDePaisReceptor.AdaptarMySQL_Boolean())
         R.add("pr_40040239388", me.RellenadoObligatorioDeTelefonoReceptor.AdaptarMySQL_Boolean())
         R.add("pr_60040241542", me.RellenadoObligatorioDeCodigoDePaisReceptor.AdaptarMySQL_Boolean())
         R.add("pr_40040239385", me.RellenadoObligatorioDeProvinciaReceptor.AdaptarMySQL_Boolean())
         R.add("pr_40040239383", me.RellenadoObligatorioDeCIFNIFReceptor.AdaptarMySQL_Boolean())
         R.add("pr_60040241541", me.RellenadoObligatorioDeCodigoDeProvinciaReceptor.AdaptarMySQL_Boolean())
         R.add("pr_40040239389", me.RellenadoObligatorioDeDireccionReceptor.AdaptarMySQL_Boolean())
         R.add("pr_30040241601", me.RellenadoObligatorioDeTipoDeNIFReceptor.AdaptarMySQL_Boolean())
         R.add("pr_40040242991", me.RellenadoObligatorioDeClaveDeOperacionIntracomunitaria.AdaptarMySQL_Boolean())
         R.add("pr_40040255424", me.RellenadoObligatorioDeNIFIntracomunitarioReceptor.AdaptarMySQL_Boolean())
         R.add("pr_40040255423", me.RellenadoObligatorioDeNIFIntracomunitarioEmisor.AdaptarMySQL_Boolean())
         If Me.ReferenciaActividadPredeterminada IsNot nothing then
           R.add("pr_20040256141",me.ReferenciaActividadPredeterminada.ID.STR())
         Else
           R.add("pr_20040256141","")
         End if
         If Me.ReferenciaClavePredeterminadaDeOperaciones IsNot nothing then
           R.add("pr_30040256991",me.ReferenciaClavePredeterminadaDeOperaciones.ID.STR())
         Else
           R.add("pr_30040256991","")
         End if
         R.add("pr_60040266783", me.EsUnMovimientoSinFactura.AdaptarMySQL_Boolean())
         R.add("pr_60040271003", me.PrefijoConceptoDeAsiento.AdaptarMySQL_String())
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
      Public Class TiposDeVentas_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_14c9f3f0d3x350wd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_14c9f3f0d3x350wd", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_1463107a1dx3cdwd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_1463107a1dx3cdwd", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_1463107ae6x1adwd")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As DateTime
            get
                return me.GetValue_DateTime("pr_776ae22wd")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_146314a801k23ewd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_146314a801k23ewd", value)
            End Set
          End Property
          Public property NotaQueDebeIncluirLaFactura As String
            get
                return me.GetValue_String("pr_60040239111")
            End Get
            Set(value As String)
                me.SetValue_String("pr_60040239111", value)
            End Set
          End Property
          Public property RellenadoObligatorioDeCodigoPostalReceptor As Boolean
            get
                return me.GetValue_Boolean("pr_40040239387")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_40040239387", value)
            End Set
          End Property
          Public property RellenadoObligatorioDeDenominacionRazonSocialReceptor As Boolean
            get
                return me.GetValue_Boolean("pr_40040239382")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_40040239382", value)
            End Set
          End Property
          Public property RellenadoObligatorioDeCIFNIFEmisor As Boolean
            get
                return me.GetValue_Boolean("pr_400402393811")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_400402393811", value)
            End Set
          End Property
          Public property RellenadoObligatorioDePaisEmisor As Boolean
            get
                return me.GetValue_Boolean("pr_50040239381")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_50040239381", value)
            End Set
          End Property
          Public property ImporteImporteMaximoImpuestosIncluidos As Decimal
            get
                return me.GetValue_Decimal("pr_30040239382")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_30040239382", value)
            End Set
          End Property
          Public property RellenadoObligatorioDeMunicipioEmisor As Boolean
            get
                return me.GetValue_Boolean("pr_50040239383")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_50040239383", value)
            End Set
          End Property
          Public property RellenadoObligatorioDeDireccionEmisor As Boolean
            get
                return me.GetValue_Boolean("pr_50040239386")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_50040239386", value)
            End Set
          End Property
          Public property RellenadoObligatorioDeDenominacionRazonSocialEmisor As Boolean
            get
                return me.GetValue_Boolean("pr_400402393810")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_400402393810", value)
            End Set
          End Property
          Public property RellenadoObligatorioDeProvinciaEmisor As Boolean
            get
                return me.GetValue_Boolean("pr_50040239382")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_50040239382", value)
            End Set
          End Property
          Public property RellenadoObligatorioDeTelefonoEmisor As Boolean
            get
                return me.GetValue_Boolean("pr_50040239385")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_50040239385", value)
            End Set
          End Property
          Public property RellenadoObligatorioDeCodigoPostalEmisor As Boolean
            get
                return me.GetValue_Boolean("pr_50040239384")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_50040239384", value)
            End Set
          End Property
          Public property RellenadoObligatorioDeMunicipioReceptor As Boolean
            get
                return me.GetValue_Boolean("pr_40040239386")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_40040239386", value)
            End Set
          End Property
          Public property RellenadoObligatorioDePaisReceptor As Boolean
            get
                return me.GetValue_Boolean("pr_40040239384")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_40040239384", value)
            End Set
          End Property
          Public property RellenadoObligatorioDeTelefonoReceptor As Boolean
            get
                return me.GetValue_Boolean("pr_40040239388")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_40040239388", value)
            End Set
          End Property
          Public property RellenadoObligatorioDeCodigoDePaisReceptor As Boolean
            get
                return me.GetValue_Boolean("pr_60040241542")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_60040241542", value)
            End Set
          End Property
          Public property RellenadoObligatorioDeProvinciaReceptor As Boolean
            get
                return me.GetValue_Boolean("pr_40040239385")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_40040239385", value)
            End Set
          End Property
          Public property RellenadoObligatorioDeCIFNIFReceptor As Boolean
            get
                return me.GetValue_Boolean("pr_40040239383")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_40040239383", value)
            End Set
          End Property
          Public property RellenadoObligatorioDeCodigoDeProvinciaReceptor As Boolean
            get
                return me.GetValue_Boolean("pr_60040241541")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_60040241541", value)
            End Set
          End Property
          Public property RellenadoObligatorioDeDireccionReceptor As Boolean
            get
                return me.GetValue_Boolean("pr_40040239389")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_40040239389", value)
            End Set
          End Property
          Public property RellenadoObligatorioDeTipoDeNIFReceptor As Boolean
            get
                return me.GetValue_Boolean("pr_30040241601")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_30040241601", value)
            End Set
          End Property
          Public property RellenadoObligatorioDeClaveDeOperacionIntracomunitaria As Boolean
            get
                return me.GetValue_Boolean("pr_40040242991")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_40040242991", value)
            End Set
          End Property
          Public property RellenadoObligatorioDeNIFIntracomunitarioReceptor As Boolean
            get
                return me.GetValue_Boolean("pr_40040255424")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_40040255424", value)
            End Set
          End Property
          Public property RellenadoObligatorioDeNIFIntracomunitarioEmisor As Boolean
            get
                return me.GetValue_Boolean("pr_40040255423")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_40040255423", value)
            End Set
          End Property
          Public property ReferenciaActividadPredeterminada As Guid
            get
                return me.GetValue_Guid("pr_20040256141")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_20040256141", value)
            End Set
          End Property
          Public property ReferenciaClavePredeterminadaDeOperaciones As Guid
            get
                return me.GetValue_Guid("pr_30040256991")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_30040256991", value)
            End Set
          End Property
          Public property EsUnMovimientoSinFactura As Boolean
            get
                return me.GetValue_Boolean("pr_60040266783")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_60040266783", value)
            End Set
          End Property
          Public property PrefijoConceptoDeAsiento As String
            get
                return me.GetValue_String("pr_60040271003")
            End Get
            Set(value As String)
                me.SetValue_String("pr_60040271003", value)
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
