   Imports System.ComponentModel
   Imports DinaNETCore
   Imports DinaNETCore.APID
Partial Public Class SeccionesD
  Public Class FacturasProformaBaseD
      Public Class FacturasProformaBase_ConListaC
      Public Listador as FacturasProformaBaseC
      Public Lista As New List(of FacturasProformaBaseListaD.FacturasProformaBaseListaC)
        sub new(_listador  as FacturasProformaBaseC, _lista as List(of FacturasProformaBaseListaD.FacturasProformaBaseListaC))
           me.Listador =_listador 
           me.Lista =_lista 
        End sub
      End Class
      Public Shared _SeccionID As String = "4cd4f471-e8f3-42b2-b653-55a4cf0f4e19"
      Public Shared _SeccionIDGUID As New Guid("4cd4f471-e8f3-42b2-b653-55a4cf0f4e19")
      Public Shared Async Function ConsultarDatos_Async(Parametros As SeccionConsultaParametrosC) As Task(Of List(Of FacturasProformaBaseC )) 
          Dim R As New List(Of FacturasProformaBaseC )  
          Dim d = Await Parametros.DinaupSesion.ConexionServidor.Funcion_Datos_Recibir_Async(FacturasProformaBaseES._SeccionID, False, Parametros) 
          If d.Datos.TieneDatos Then 
              For Each Actual In d.Datos 
                  Dim Valores_Listador = Actual.Value.Item1
                  Dim Obj_Listador As New FacturasProformaBaseC 
                  Obj_Listador.CargarDatos(Valores_Listador) 
                  Obj_Listador.CargaInterna(Actual.Value)
                  R.Add(Obj_Listador) 
              Next 
          End If 
          Return R 
      End Function 
      Public Shared Async Function ConsultarDatos_ConLista_Async(  Parametros As SeccionConsultaParametrosC ) As Task(Of List(Of  FacturasProformaBase_ConListaC)) 
          Dim R As New List(Of FacturasProformaBase_ConListaC )  
          Dim d =  Await Parametros.DinaupSesion.ConexionServidor.Funcion_Datos_Recibir_Async(FacturasProformaBaseES._SeccionID, True, Parametros) 
          If d.Datos.TieneDatos Then 
              For Each Actual In d.Datos 
                  Dim Valores_Listador = Actual.Value.Item1
                  Dim Valores_Lista = Actual.Value.Item2
                  Dim Obj_Listador As New FacturasProformaBaseC 
                  Obj_Listador.CargarDatos(Valores_Listador) 
                  Obj_Listador.CargaInterna(Actual.Value)
                  Dim Objs_Listas As New List(Of FacturasProformaBaseListaD.FacturasProformaBaseListaC) 
                  If Valores_Lista.TieneDatos Then  
                      For Each ValoresLista In Valores_Lista 
                         Dim nItem As New FacturasProformaBaseListaD.FacturasProformaBaseListaC 
                         nItem.CargarDatos(ValoresLista)   
                         Objs_Listas.Add(nItem)         
                      Next   
                  End If   
                  R.Add(New FacturasProformaBase_ConListaC(Obj_Listador, Objs_Listas))
              Next 
          End If 
          Return R 
      End Function 
      Public Class FacturasProformaBaseES
          Public shared _SeccionID as Guid = New Guid("4cd4f471-e8f3-42b2-b653-55a4cf0f4e19")
          Public shared _Tabla$ = "tpr_300401055512"
      Public Shared ImporteImporteRetencion$ = "pr_100401058015"
      Public Shared IdentificacionCliente$ = "pr_10040107981"
      Public Shared PaisCliente$ = "pr_10040107985"
      Public Shared Terminos$ = "pr_100401079832"
      Public Shared DescripcionDescuentoAdicionalB$ = "pr_100401058070"
      Public Shared Observaciones$ = "pr_100401058071"
      Public Shared ImporteSaldoObtenidoEntidad$ = "pr_100401058016"
      Public Shared ReferenciaTipoDeCliente$ = "pr_10040105803"
      Public Shared ImporteTotal$ = "pr_100401058017"
      Public Shared AplicarRecargoDeEquivalencia$ = "pr_100401058075"
      Public Shared ValidoHasta$ = "pr_100401079831"
      Public Shared ImporteTotalDescuentosNoAplicados$ = "pr_100401058019"
      Public Shared ImporteDescuentosGeneralImpuesto1$ = "pr_100401058020"
      Public Shared ImporteSaldoQueTeniaElClienteAntesDeLaVenta$ = "pr_100401058021"
      Public Shared NFacturaNumerico$ = "pr_100401058074"
      Public Shared DireccionEmpresa$ = "pr_60040107984"
      Public Shared ReferenciaAutorDelAlta$ = "pr_3004010555320"
      Public Shared DescuentoTipoEntidadPorciento$ = "pr_100401058022"
      Public Shared DescuentoAdicionalAAplicadoPorciento$ = "pr_100401058023"
      Public Shared ImporteDescuentoSaldoImpuesto2$ = "pr_100401058024"
      Public Shared DescuentoAdicionalADeseadoPorciento$ = "pr_100401058025"
      Public Shared ImporteDescuentoSaldoImpuesto3$ = "pr_100401058026"
      Public Shared ImporteBaseImponibleImpuesto3$ = "pr_100401058027"
      Public Shared ImporteTotalImpuestos$ = "pr_100401058028"
      Public Shared TotalPorcentajeDescuentosGeneralesPorciento$ = "pr_100401058029"
      Public Shared FechaFactura$ = "pr_50040107971"
      Public Shared TelefonoEmpresa$ = "pr_50040108121"
      Public Shared DescuentoVIPDeseadoPorciento$ = "pr_100401058030"
      Public Shared ImportePresupuestoDeVentaRatioDeProrrateo$ = "pr_500401157210"
      Public Shared PaisEmpresa$ = "pr_60040107983"
      Public Shared DescripcionDescuentoAdicionalA$ = "pr_100401058072"
      Public Shared ImporteSumaImporteProductosConImpuestos$ = "pr_100401058031"
      Public Shared NFactura$ = "pr_100401058073"
      Public Shared CodigoPostalEmpresa$ = "pr_60040107981"
      Public Shared SaldoPromocionalGeneradoDeseadoPorciento$ = "pr_100401058032"
      Public Shared DescuentoEntidadDeseadoPorciento$ = "pr_100401058033"
      Public Shared ImporteCuotaImpuesto2$ = "pr_100401058034"
      Public Shared FechaDato_UTC$ = "pr_3004010555321"
      Public Shared ReferenciaRetencion$ = "pr_10040105804"
      Public Shared DescuentoTipoDeEntidadDeseadoPorciento$ = "pr_100401058035"
      Public Shared IdentificacionEmpresa$ = "pr_60040107985"
      Public Shared ImporteCuotaImpuesto3$ = "pr_100401058036"
      Public Shared ExportarEnModulos$ = "pr_3004010555323"
      Public Shared ImporteSumaDeConceptosImpuesto2$ = "pr_100401058037"
      Public Shared FechaAlta_UTC$ = "pr_3004010555324"
      Public Shared ReferenciaCliente$ = "pr_10040105805"
      Public Shared ReferenciaResumenImpuesto1$ = "pr_10040105806"
      Public Shared ImporteDescuentosProductoImpuesto1$ = "pr_100401058038"
      Public Shared DescuentoEntidadAplicadoPorciento$ = "pr_100401058039"
      Public Shared CIFNIFEmpresa$ = "pr_60040107986"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_3004010555335"
      Public Shared ImportePresupuestoDeVentaSaldoPromocionalUtilizado$ = "pr_50040115728"
      Public Shared DescuentoAdicionalBDeseadoPorciento$ = "pr_100401058040"
      Public Shared ReferenciaResumenImpuesto3$ = "pr_10040105807"
      Public Shared ImporteCuotaREImpuesto3$ = "pr_100401058041"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_3004010555318"
      Public Shared ImporteSumaDeConceptosImpuestoExentos$ = "pr_100401058042"
      Public Shared DescuentoGeneralDeseadoPorciento$ = "pr_100401058043"
      Public Shared ImporteDescuentoGeneralImpuestoExento$ = "pr_100401058044"
      Public Shared DescuentoVIPAplicadoPorciento$ = "pr_100401058045"
      Public Shared DescuentoAdicionalBAplicadoPorciento$ = "pr_100401058046"
      Public Shared ImporteTotalSinPagoConSaldo$ = "pr_20040115008"
      Public Shared ImporteDescuentosProductoImpuesto2$ = "pr_100401058047"
      Public Shared ReferenciaPresupuestoDeVenta$ = "pr_1004010580562"
      Public Shared ImporteTotalDescontadoSinImpuestos$ = "pr_100401058048"
      Public Shared ImporteCuotaImpuesto1$ = "pr_100401058049"
      Public Shared DescuentoGeneralAplicadoPorciento$ = "pr_100401058050"
      Public Shared ImporteBaseImponibleImpuesto1$ = "pr_100401058051"
      Public Shared ReferenciaConfiguracionDeVenta$ = "pr_10040105808"
      Public Shared ImpuestosIncluidos$ = "pr_100401058076"
      Public Shared ClienteTieneAccesoWeb$ = "pr_100401058014"
      Public Shared UsoDeSaldoPersonalizado$ = "pr_20040115732"
      Public Shared ImporteCuotaREImpuesto1$ = "pr_100401058052"
      Public Shared ReferenciaTipoDeMovimiento$ = "pr_10040105809"
      Public Shared SumaConceptosConImpuestos$ = "pr_60040115044"
      Public Shared ImporteDescuentosProductoImpuesto3$ = "pr_100401058053"
      Public Shared Notas$ = "pr_100401079833"
      Public Shared MunicipioEmpresa$ = "pr_10040108561"
      Public Shared ImporteDescuentosGeneralImpuesto2$ = "pr_100401058054"
      Public Shared ImporteBaseImponibleImpuesto2$ = "pr_100401058055"
      Public Shared ImporteSumaConceptosSinImpuestos$ = "pr_100401058056"
      Public Shared CantidadDeProductos$ = "pr_100401058057"
      Public Shared ImporteDescuentoSaldoExento$ = "pr_100401058058"
      Public Shared ImporteDescuentoSaldoImpuesto1$ = "pr_100401058059"
      Public Shared ImporteSaldoPromocionalUtilizado$ = "pr_100401058060"
      Public Shared ImporteDescuentosProductoExento$ = "pr_100401058061"
      Public Shared MunicipioCliente$ = "pr_50040108212"
      Public Shared ImportePresupuestoDeVentaImporteTotal$ = "pr_50040115727"
      Public Shared ImporteBaseImponibleExenta$ = "pr_100401058062"
      Public Shared ReferenciaEstado$ = "pr_100401058010"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_3004010555333"
      Public Shared SaldoPromocionalGeneradoAplicadoPorciento$ = "pr_100401058063"
      Public Shared ReferenciaResumenImpuesto2$ = "pr_100401058011"
      Public Shared CodigoPostalCliente$ = "pr_10040107984"
      Public Shared ReferenciaPuestoDeTrabajo$ = "pr_100401058012"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_3004010555319"
      Public Shared ImporteSumaImporteDeProductosSinImpuestos$ = "pr_100401058064"
      Public Shared ImporteDescuentosGeneralImpuesto3$ = "pr_100401058065"
      Public Shared CIFNIFCliente$ = "pr_10040107983"
      Public Shared ReferenciaNumeracionSerie$ = "pr_100401058013"
      Public Shared ProvinciaEmpresa$ = "pr_60040107982"
      Public Shared DireccionCliente$ = "pr_100401079920"
      Public Shared ImporteSubtotal$ = "pr_100401058066"
      Public Shared ReferenciaDestinador$ = "pr_3004010555327"
      Public Shared HoraLocal$ = "pr_3004010555322"
      Public Shared ImporteSumaDeConceptosImpuesto1$ = "pr_100401058067"
      Public Shared ImportePresupuestoDeVentaTotalSinPagoConSaldo$ = "pr_50040115729"
      Public Shared ImporteCuotaREImpuesto2$ = "pr_100401058068"
      Public Shared ProvinciaCliente$ = "pr_10040107986"
      Public Shared ImporteSumaDeConceptosImpuesto3$ = "pr_100401058069"
      Public Shared TelefonoCliente$ = "pr_10040138801"
      Public Shared ReferenciaDatosFiscalesEmpresa$ = "pr_10040138802"
      Public Shared ReferenciaDatosFiscalesCliente$ = "pr_10040138803"
      Public Shared ImporteImporteImpuestoGeneral$ = "pr_500401489611"
      Public Shared ReferenciaImpuestoGeneral$ = "pr_600401489612"
      Public Shared CondicionesDePago$ = "pr_50040172141"
      Public Shared CondicionDePagoDias$ = "pr_40040176512"
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
      Public Class FacturasProformaBaseC
      Inherits Base_DatoC
          <DisplayName("Importe retención")>
          Public Property ImporteImporteRetencion As Decimal
          Public Shared ___ImporteImporteRetencion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteImporteRetencion"",""etiqueta"": ""Importe retención"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Importe retención"",""descripcion"": """",""keyword"": ""ImporteImporteRetencion"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteImporteRetencion As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteImporteRetencion
          <Description("Nombre y apellidos, razón o denominación social completa.")>
          <DisplayName("Identificación (Cliente)")>
          Public Property IdentificacionCliente As String
          Public Shared ___IdentificacionCliente As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""IdentificacionCliente"",""etiqueta"": ""Identificación (Cliente)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Identificación (Cliente)"",""descripcion"": """",""keyword"": ""IdentificacionCliente"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __IdentificacionCliente As DinaNETCore.APID.DinaupAPI_CampoC = ___IdentificacionCliente
          <DisplayName("País (Cliente)")>
          Public Property PaisCliente As String
          Public Shared ___PaisCliente As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""PaisCliente"",""etiqueta"": ""País (Cliente)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""País (Cliente)"",""descripcion"": """",""keyword"": ""PaisCliente"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __PaisCliente As DinaNETCore.APID.DinaupAPI_CampoC = ___PaisCliente
          <DisplayName("Términos")>
          Public Property Terminos As String
          Public Shared ___Terminos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Terminos"",""etiqueta"": ""Términos"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 16,""decimales"": ""0"",""multilinea"": true,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Términos"",""descripcion"": """",""keyword"": ""Terminos"",""formato"": 5,""rol"": 16,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Terminos As DinaNETCore.APID.DinaupAPI_CampoC = ___Terminos
          <DisplayName("Descripción descuento adicional B")>
          Public Property DescripcionDescuentoAdicionalB As String
          Public Shared ___DescripcionDescuentoAdicionalB As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescripcionDescuentoAdicionalB"",""etiqueta"": ""Descripción descuento adicional B"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descripción descuento adicional B"",""descripcion"": """",""keyword"": ""DescripcionDescuentoAdicionalB"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescripcionDescuentoAdicionalB As DinaNETCore.APID.DinaupAPI_CampoC = ___DescripcionDescuentoAdicionalB
          <DisplayName("Observaciones")>
          Public Property Observaciones As String
          Public Shared ___Observaciones As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Observaciones"",""etiqueta"": ""Observaciones"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 9,""decimales"": ""0"",""multilinea"": true,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Observaciones"",""descripcion"": """",""keyword"": ""Observaciones"",""formato"": 5,""rol"": 9,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Observaciones As DinaNETCore.APID.DinaupAPI_CampoC = ___Observaciones
          <Description("Cantidad de saldo que obtiene la entidad en esta transacción." & vbCrLf & "Es un dato y no afecta directamente al saldo de la entidad, el saldo debe de ser entregado con un movimiento de saldo aparte.")>
          <DisplayName("Saldo obtenido entidad")>
          Public Property ImporteSaldoObtenidoEntidad As Decimal
          Public Shared ___ImporteSaldoObtenidoEntidad As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSaldoObtenidoEntidad"",""etiqueta"": ""Saldo obtenido entidad"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Saldo obtenido entidad"",""descripcion"": """",""keyword"": ""ImporteSaldoObtenidoEntidad"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSaldoObtenidoEntidad As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSaldoObtenidoEntidad
          <DisplayName("Tipo de Cliente")>
          Public Property ReferenciaTipoDeCliente As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaTipoDeCliente As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaTipoDeCliente"",""etiqueta"": ""Tipo de Cliente"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""8b1fa053-5abe-406e-9760-584ed34a3b97"",""titulo"": ""Base - Tipos de entidad"",""iconoid"": ""48978f8a-f2bd-4695-a897-3a0e7bfdc979"",""etiquetasingular"": ""Tipo de entidad"",""etiquetaplural"": ""Tipos de entidad"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""8b1fa053-5abe-406e-9760-584ed34a3b97"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Tipo de Cliente"",""descripcion"": """",""keyword"": ""ReferenciaTipoDeCliente"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaTipoDeCliente As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaTipoDeCliente
          <DisplayName("Total")>
          Public Property ImporteTotal As Decimal
          Public Shared ___ImporteTotal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteTotal"",""etiqueta"": ""Total"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total"",""descripcion"": """",""keyword"": ""ImporteTotal"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteTotal As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteTotal
          <DisplayName("Aplicar Recargo de equivalencia")>
          Public Property AplicarRecargoDeEquivalencia As Boolean
          Public Shared ___AplicarRecargoDeEquivalencia As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AplicarRecargoDeEquivalencia"",""etiqueta"": ""Aplicar Recargo de equivalencia"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Aplicar Recargo de equivalencia"",""descripcion"": """",""keyword"": ""AplicarRecargoDeEquivalencia"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AplicarRecargoDeEquivalencia As DinaNETCore.APID.DinaupAPI_CampoC = ___AplicarRecargoDeEquivalencia
          <DisplayName("Válido hasta")>
          Public Property ValidoHasta As Date?
          Public Shared ___ValidoHasta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ValidoHasta"",""etiqueta"": ""Válido hasta"",""oculta"": false,""formato"": 7,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Válido hasta"",""descripcion"": """",""keyword"": ""ValidoHasta"",""formato"": 7,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __ValidoHasta As DinaNETCore.APID.DinaupAPI_CampoC = ___ValidoHasta
          <Description("Refleja el importe Total de descuentos asociado a cada producto que no ha sido aplicado," & vbCrLf & "si ha tenido que realizar ajustes en el precio.")>
          <DisplayName("Total descuentos no aplicados")>
          Public Property ImporteTotalDescuentosNoAplicados As Decimal
          Public Shared ___ImporteTotalDescuentosNoAplicados As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteTotalDescuentosNoAplicados"",""etiqueta"": ""Total descuentos no aplicados"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total descuentos no aplicados"",""descripcion"": """",""keyword"": ""ImporteTotalDescuentosNoAplicados"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteTotalDescuentosNoAplicados As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteTotalDescuentosNoAplicados
          <DisplayName("Descuentos General Impuesto 1")>
          Public Property ImporteDescuentosGeneralImpuesto1 As Decimal
          Public Shared ___ImporteDescuentosGeneralImpuesto1 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentosGeneralImpuesto1"",""etiqueta"": ""Descuentos General Impuesto 1"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuentos General Impuesto 1"",""descripcion"": """",""keyword"": ""ImporteDescuentosGeneralImpuesto1"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentosGeneralImpuesto1 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentosGeneralImpuesto1
          <DisplayName("Saldo que tenía el cliente antes de la venta")>
          Public Property ImporteSaldoQueTeniaElClienteAntesDeLaVenta As Decimal
          Public Shared ___ImporteSaldoQueTeniaElClienteAntesDeLaVenta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSaldoQueTeniaElClienteAntesDeLaVenta"",""etiqueta"": ""Saldo que tenía el cliente antes de la venta"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Saldo que tenía el cliente antes de la venta"",""descripcion"": """",""keyword"": ""ImporteSaldoQueTeniaElClienteAntesDeLaVenta"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSaldoQueTeniaElClienteAntesDeLaVenta As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSaldoQueTeniaElClienteAntesDeLaVenta
          <Description("Es el número secuencial que el sistema emite cada vez que se realiza una transacción.")>
          <DisplayName("Nº Factura (Numérico)")>
          Public Property NFacturaNumerico As Integer
          Public Shared ___NFacturaNumerico As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""NFacturaNumerico"",""etiqueta"": ""Nº Factura (Numérico)"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Nº Factura (Numérico)"",""descripcion"": """",""keyword"": ""NFacturaNumerico"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __NFacturaNumerico As DinaNETCore.APID.DinaupAPI_CampoC = ___NFacturaNumerico
          <DisplayName("Dirección (Empresa)")>
          Public Property DireccionEmpresa As String
          Public Shared ___DireccionEmpresa As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DireccionEmpresa"",""etiqueta"": ""Dirección (Empresa)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 9,""decimales"": ""0"",""multilinea"": true,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Dirección (Empresa)"",""descripcion"": """",""keyword"": ""DireccionEmpresa"",""formato"": 5,""rol"": 9,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DireccionEmpresa As DinaNETCore.APID.DinaupAPI_CampoC = ___DireccionEmpresa
          <DisplayName("Autor del alta")>
          Public Property ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaAutorDelAlta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaAutorDelAlta"",""etiqueta"": ""Autor del alta"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta"",""descripcion"": """",""keyword"": ""ReferenciaAutorDelAlta"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaAutorDelAlta
          <Description("Porcentaje de descuento indicado en el tipo de entidad.")>
          <DisplayName("Descuento tipo entidad %")>
          Public Property DescuentoTipoEntidadPorciento As Decimal
          Public Shared ___DescuentoTipoEntidadPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoTipoEntidadPorciento"",""etiqueta"": ""Descuento tipo entidad %"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento tipo entidad %"",""descripcion"": """",""keyword"": ""DescuentoTipoEntidadPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoTipoEntidadPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoTipoEntidadPorciento
          <Description("Porcentaje de  descuento adicional A que se ha aplicado.")>
          <DisplayName("Descuento adicional A % (Aplicado)")>
          Public Property DescuentoAdicionalAAplicadoPorciento As Decimal
          Public Shared ___DescuentoAdicionalAAplicadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoAdicionalAAplicadoPorciento"",""etiqueta"": ""Descuento adicional A % (Aplicado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento adicional A % (Aplicado)"",""descripcion"": """",""keyword"": ""DescuentoAdicionalAAplicadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoAdicionalAAplicadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoAdicionalAAplicadoPorciento
          <DisplayName("Descuento saldo impuesto 2")>
          Public Property ImporteDescuentoSaldoImpuesto2 As Decimal
          Public Shared ___ImporteDescuentoSaldoImpuesto2 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentoSaldoImpuesto2"",""etiqueta"": ""Descuento saldo impuesto 2"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento saldo impuesto 2"",""descripcion"": """",""keyword"": ""ImporteDescuentoSaldoImpuesto2"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentoSaldoImpuesto2 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentoSaldoImpuesto2
          <Description("Descuento adicional configurable. " & vbCrLf & "(Este es el ""Deseado"", podría modificarse según la configuración de ajustes de descuentos indicada, este valor puede ser distinto al aplicado finalmente)")>
          <DisplayName("Descuento Adicional A % (Deseado)")>
          Public Property DescuentoAdicionalADeseadoPorciento As Decimal
          Public Shared ___DescuentoAdicionalADeseadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoAdicionalADeseadoPorciento"",""etiqueta"": ""Descuento Adicional A % (Deseado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento Adicional A % (Deseado)"",""descripcion"": """",""keyword"": ""DescuentoAdicionalADeseadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoAdicionalADeseadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoAdicionalADeseadoPorciento
          <DisplayName("Descuento saldo impuesto 3")>
          Public Property ImporteDescuentoSaldoImpuesto3 As Decimal
          Public Shared ___ImporteDescuentoSaldoImpuesto3 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentoSaldoImpuesto3"",""etiqueta"": ""Descuento saldo impuesto 3"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento saldo impuesto 3"",""descripcion"": """",""keyword"": ""ImporteDescuentoSaldoImpuesto3"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentoSaldoImpuesto3 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentoSaldoImpuesto3
          <DisplayName("Base imponible impuesto 3")>
          Public Property ImporteBaseImponibleImpuesto3 As Decimal
          Public Shared ___ImporteBaseImponibleImpuesto3 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteBaseImponibleImpuesto3"",""etiqueta"": ""Base imponible impuesto 3"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Base imponible impuesto 3"",""descripcion"": """",""keyword"": ""ImporteBaseImponibleImpuesto3"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteBaseImponibleImpuesto3 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteBaseImponibleImpuesto3
          <Description("Importe total de impuestos.")>
          <DisplayName("Total impuestos")>
          Public Property ImporteTotalImpuestos As Decimal
          Public Shared ___ImporteTotalImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteTotalImpuestos"",""etiqueta"": ""Total impuestos"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total impuestos"",""descripcion"": """",""keyword"": ""ImporteTotalImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteTotalImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteTotalImpuestos
          <DisplayName("Total porcentaje descuentos Generales")>
          Public Property TotalPorcentajeDescuentosGeneralesPorciento As Decimal
          Public Shared ___TotalPorcentajeDescuentosGeneralesPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TotalPorcentajeDescuentosGeneralesPorciento"",""etiqueta"": ""Total porcentaje descuentos Generales"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total porcentaje descuentos Generales"",""descripcion"": """",""keyword"": ""TotalPorcentajeDescuentosGeneralesPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __TotalPorcentajeDescuentosGeneralesPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___TotalPorcentajeDescuentosGeneralesPorciento
          <DisplayName("Fecha factura")>
          Public Property FechaFactura As Date?
          Public Shared ___FechaFactura As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaFactura"",""etiqueta"": ""Fecha factura"",""oculta"": false,""formato"": 7,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 69,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha factura"",""descripcion"": """",""keyword"": ""FechaFactura"",""formato"": 7,""rol"": 69,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaFactura As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaFactura
          <DisplayName("Teléfono (Empresa)")>
          Public Property TelefonoEmpresa As String
          Public Shared ___TelefonoEmpresa As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TelefonoEmpresa"",""etiqueta"": ""Teléfono (Empresa)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 2,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Teléfono (Empresa)"",""descripcion"": """",""keyword"": ""TelefonoEmpresa"",""formato"": 5,""rol"": 2,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __TelefonoEmpresa As DinaNETCore.APID.DinaupAPI_CampoC = ___TelefonoEmpresa
          <Description("Descuento especial que se indica en la ficha de la entidad. " & vbCrLf & "(Este es el ""Deseado"", podría modificarse según la configuración de ajustes de descuentos indicada, este valor puede ser distinto al aplicado finalmente)")>
          <DisplayName("Descuento V.I.P % (Deseado)")>
          Public Property DescuentoVIPDeseadoPorciento As Decimal
          Public Shared ___DescuentoVIPDeseadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoVIPDeseadoPorciento"",""etiqueta"": ""Descuento V.I.P % (Deseado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento V.I.P % (Deseado)"",""descripcion"": """",""keyword"": ""DescuentoVIPDeseadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoVIPDeseadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoVIPDeseadoPorciento
          <DisplayName("Presupuesto de Venta - Ratio de prorrateo")>
          Public Property ImportePresupuestoDeVentaRatioDeProrrateo As Decimal
          Public Shared ___ImportePresupuestoDeVentaRatioDeProrrateo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImportePresupuestoDeVentaRatioDeProrrateo"",""etiqueta"": ""Presupuesto de Venta - Ratio de prorrateo"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Presupuesto de Venta - Ratio de prorrateo"",""descripcion"": """",""keyword"": ""ImportePresupuestoDeVentaRatioDeProrrateo"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImportePresupuestoDeVentaRatioDeProrrateo As DinaNETCore.APID.DinaupAPI_CampoC = ___ImportePresupuestoDeVentaRatioDeProrrateo
          <DisplayName("País (Empresa)")>
          Public Property PaisEmpresa As String
          Public Shared ___PaisEmpresa As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""PaisEmpresa"",""etiqueta"": ""País (Empresa)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""País (Empresa)"",""descripcion"": """",""keyword"": ""PaisEmpresa"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __PaisEmpresa As DinaNETCore.APID.DinaupAPI_CampoC = ___PaisEmpresa
          <DisplayName("Descripción descuento adicional A")>
          Public Property DescripcionDescuentoAdicionalA As String
          Public Shared ___DescripcionDescuentoAdicionalA As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescripcionDescuentoAdicionalA"",""etiqueta"": ""Descripción descuento adicional A"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descripción descuento adicional A"",""descripcion"": """",""keyword"": ""DescripcionDescuentoAdicionalA"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescripcionDescuentoAdicionalA As DinaNETCore.APID.DinaupAPI_CampoC = ___DescripcionDescuentoAdicionalA
          <DisplayName("Suma Importe Productos (Con impuestos)")>
          Public Property ImporteSumaImporteProductosConImpuestos As Decimal
          Public Shared ___ImporteSumaImporteProductosConImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSumaImporteProductosConImpuestos"",""etiqueta"": ""Suma Importe Productos (Con impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Suma Importe Productos (Con impuestos)"",""descripcion"": """",""keyword"": ""ImporteSumaImporteProductosConImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSumaImporteProductosConImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSumaImporteProductosConImpuestos
          <DisplayName("Nº Factura")>
          Public Property NFactura As String
          Public Shared ___NFactura As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""NFactura"",""etiqueta"": ""Nº Factura"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Nº Factura"",""descripcion"": """",""keyword"": ""NFactura"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __NFactura As DinaNETCore.APID.DinaupAPI_CampoC = ___NFactura
          <DisplayName("Código postal (Empresa)")>
          Public Property CodigoPostalEmpresa As String
          Public Shared ___CodigoPostalEmpresa As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CodigoPostalEmpresa"",""etiqueta"": ""Código postal (Empresa)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Código postal (Empresa)"",""descripcion"": """",""keyword"": ""CodigoPostalEmpresa"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CodigoPostalEmpresa As DinaNETCore.APID.DinaupAPI_CampoC = ___CodigoPostalEmpresa
          <Description("El Saldo promocional que genera la transacción para añadirlo al saldo de la Entidad." & vbCrLf & "(Este es el ""Deseado"", podría modificarse según la configuración de ajustes de descuentos indicada)")>
          <DisplayName("Saldo promocional generado % (Deseado)")>
          Public Property SaldoPromocionalGeneradoDeseadoPorciento As Decimal
          Public Shared ___SaldoPromocionalGeneradoDeseadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""SaldoPromocionalGeneradoDeseadoPorciento"",""etiqueta"": ""Saldo promocional generado % (Deseado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Saldo promocional generado % (Deseado)"",""descripcion"": """",""keyword"": ""SaldoPromocionalGeneradoDeseadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __SaldoPromocionalGeneradoDeseadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___SaldoPromocionalGeneradoDeseadoPorciento
          <Description("Descuento perteneciente a la entidad seleccionada. " & vbCrLf & "(Este es el ""Deseado"", podría modificarse según la configuración de ajustes de descuentos indicada, este valor puede ser distinto al aplicado finalmente)")>
          <DisplayName("Descuento Entidad % (Deseado)")>
          Public Property DescuentoEntidadDeseadoPorciento As Decimal
          Public Shared ___DescuentoEntidadDeseadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoEntidadDeseadoPorciento"",""etiqueta"": ""Descuento Entidad % (Deseado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento Entidad % (Deseado)"",""descripcion"": """",""keyword"": ""DescuentoEntidadDeseadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoEntidadDeseadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoEntidadDeseadoPorciento
          <DisplayName("Cuota Impuesto 2")>
          Public Property ImporteCuotaImpuesto2 As Decimal
          Public Shared ___ImporteCuotaImpuesto2 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteCuotaImpuesto2"",""etiqueta"": ""Cuota Impuesto 2"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cuota Impuesto 2"",""descripcion"": """",""keyword"": ""ImporteCuotaImpuesto2"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteCuotaImpuesto2 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteCuotaImpuesto2
          <DisplayName("Fecha Dato")>
          Public Property FechaDato_UTC As Date?
          Public Shared ___FechaDato_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaDato_UTC"",""etiqueta"": ""Fecha Dato"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Dato"",""descripcion"": """",""keyword"": ""FechaDato_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaDato_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaDato_UTC
          <DisplayName("Retención")>
          Public Property ReferenciaRetencion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaRetencion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaRetencion"",""etiqueta"": ""Retención"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""1a89014d-3991-4d9d-8d0f-77fcf2ddff5e"",""titulo"": ""Base - Retenciones"",""iconoid"": ""13560fd4-34fc-42bc-b12d-007e26e5f428"",""etiquetasingular"": ""Retención"",""etiquetaplural"": ""Retenciones"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""1a89014d-3991-4d9d-8d0f-77fcf2ddff5e"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Retención"",""descripcion"": """",""keyword"": ""ReferenciaRetencion"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaRetencion As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaRetencion
          <Description("Porcentaje del descuento global  indicado en el tipo de entidad." & vbCrLf & "(Este es el ""Deseado"", podría modificarse según la configuración de ajustes de descuentos indicada)")>
          <DisplayName("Descuento tipo de entidad % (Deseado)")>
          Public Property DescuentoTipoDeEntidadDeseadoPorciento As Decimal
          Public Shared ___DescuentoTipoDeEntidadDeseadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoTipoDeEntidadDeseadoPorciento"",""etiqueta"": ""Descuento tipo de entidad % (Deseado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento tipo de entidad % (Deseado)"",""descripcion"": """",""keyword"": ""DescuentoTipoDeEntidadDeseadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoTipoDeEntidadDeseadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoTipoDeEntidadDeseadoPorciento
          <DisplayName("Identificación (Empresa)")>
          Public Property IdentificacionEmpresa As String
          Public Shared ___IdentificacionEmpresa As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""IdentificacionEmpresa"",""etiqueta"": ""Identificación (Empresa)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Identificación (Empresa)"",""descripcion"": """",""keyword"": ""IdentificacionEmpresa"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __IdentificacionEmpresa As DinaNETCore.APID.DinaupAPI_CampoC = ___IdentificacionEmpresa
          <DisplayName("Cuota Impuesto 3")>
          Public Property ImporteCuotaImpuesto3 As Decimal
          Public Shared ___ImporteCuotaImpuesto3 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteCuotaImpuesto3"",""etiqueta"": ""Cuota Impuesto 3"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cuota Impuesto 3"",""descripcion"": """",""keyword"": ""ImporteCuotaImpuesto3"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteCuotaImpuesto3 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteCuotaImpuesto3
          <DisplayName("Suma de conceptos Impuesto 2")>
          Public Property ImporteSumaDeConceptosImpuesto2 As Decimal
          Public Shared ___ImporteSumaDeConceptosImpuesto2 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSumaDeConceptosImpuesto2"",""etiqueta"": ""Suma de conceptos Impuesto 2"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Suma de conceptos Impuesto 2"",""descripcion"": """",""keyword"": ""ImporteSumaDeConceptosImpuesto2"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSumaDeConceptosImpuesto2 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSumaDeConceptosImpuesto2
          <DisplayName("Fecha Alta del registro")>
          Public Property FechaAlta_UTC As Date?
          Public Shared ___FechaAlta_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaAlta_UTC"",""etiqueta"": ""Fecha Alta del registro"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Alta del registro"",""descripcion"": """",""keyword"": ""FechaAlta_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaAlta_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaAlta_UTC
          <DisplayName("Cliente")>
          Public Property ReferenciaCliente As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaCliente As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaCliente"",""etiqueta"": ""Cliente"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cliente"",""descripcion"": """",""keyword"": ""ReferenciaCliente"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaCliente As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaCliente
          <DisplayName("Resumen Impuesto 1")>
          Public Property ReferenciaResumenImpuesto1 As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaResumenImpuesto1 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaResumenImpuesto1"",""etiqueta"": ""Resumen Impuesto 1"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""f3199ee0-dc83-4667-a9c1-f3b04e97a8a4"",""titulo"": ""Base - Impuestos"",""iconoid"": ""ff4a7189-6426-43b9-bdc4-070314999e81"",""etiquetasingular"": ""Impuesto"",""etiquetaplural"": ""Impuestos"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""f3199ee0-dc83-4667-a9c1-f3b04e97a8a4"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Resumen Impuesto 1"",""descripcion"": """",""keyword"": ""ReferenciaResumenImpuesto1"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaResumenImpuesto1 As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaResumenImpuesto1
          <DisplayName("Descuentos Producto Impuesto 1")>
          Public Property ImporteDescuentosProductoImpuesto1 As Decimal
          Public Shared ___ImporteDescuentosProductoImpuesto1 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentosProductoImpuesto1"",""etiqueta"": ""Descuentos Producto Impuesto 1"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuentos Producto Impuesto 1"",""descripcion"": """",""keyword"": ""ImporteDescuentosProductoImpuesto1"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentosProductoImpuesto1 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentosProductoImpuesto1
          <Description("Descuento perteneciente a la entidad que se ha aplicado.")>
          <DisplayName("Descuento Entidad % (Aplicado)")>
          Public Property DescuentoEntidadAplicadoPorciento As Decimal
          Public Shared ___DescuentoEntidadAplicadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoEntidadAplicadoPorciento"",""etiqueta"": ""Descuento Entidad % (Aplicado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento Entidad % (Aplicado)"",""descripcion"": """",""keyword"": ""DescuentoEntidadAplicadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoEntidadAplicadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoEntidadAplicadoPorciento
          <DisplayName("CIF/NIF (Empresa)")>
          Public Property CIFNIFEmpresa As String
          Public Shared ___CIFNIFEmpresa As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CIFNIFEmpresa"",""etiqueta"": ""CIF/NIF (Empresa)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 79,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""CIF/NIF (Empresa)"",""descripcion"": """",""keyword"": ""CIFNIFEmpresa"",""formato"": 5,""rol"": 79,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CIFNIFEmpresa As DinaNETCore.APID.DinaupAPI_CampoC = ___CIFNIFEmpresa
          <DisplayName("Empleado Tiene Acceso web")>
          Public Property EmpleadoTieneAccesoWeb As Boolean
          Public Shared ___EmpleadoTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EmpleadoTieneAccesoWeb"",""etiqueta"": ""Empleado Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empleado Tiene Acceso web"",""descripcion"": """",""keyword"": ""EmpleadoTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EmpleadoTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___EmpleadoTieneAccesoWeb
          <DisplayName("Presupuesto de Venta - Saldo promocional utilizado")>
          Public Property ImportePresupuestoDeVentaSaldoPromocionalUtilizado As Decimal
          Public Shared ___ImportePresupuestoDeVentaSaldoPromocionalUtilizado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImportePresupuestoDeVentaSaldoPromocionalUtilizado"",""etiqueta"": ""Presupuesto de Venta - Saldo promocional utilizado"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Presupuesto de Venta - Saldo promocional utilizado"",""descripcion"": """",""keyword"": ""ImportePresupuestoDeVentaSaldoPromocionalUtilizado"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImportePresupuestoDeVentaSaldoPromocionalUtilizado As DinaNETCore.APID.DinaupAPI_CampoC = ___ImportePresupuestoDeVentaSaldoPromocionalUtilizado
          <Description("Descuento adicional configurable." & vbCrLf & "(Este es el ""Deseado"", podría modificarse según la configuración de ajustes de descuentos indicada, este valor puede ser distinto al aplicado finalmente)")>
          <DisplayName("Descuento Adicional B % (Deseado)")>
          Public Property DescuentoAdicionalBDeseadoPorciento As Decimal
          Public Shared ___DescuentoAdicionalBDeseadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoAdicionalBDeseadoPorciento"",""etiqueta"": ""Descuento Adicional B % (Deseado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento Adicional B % (Deseado)"",""descripcion"": """",""keyword"": ""DescuentoAdicionalBDeseadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoAdicionalBDeseadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoAdicionalBDeseadoPorciento
          <DisplayName("Resumen impuesto 3")>
          Public Property ReferenciaResumenImpuesto3 As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaResumenImpuesto3 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaResumenImpuesto3"",""etiqueta"": ""Resumen impuesto 3"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""f3199ee0-dc83-4667-a9c1-f3b04e97a8a4"",""titulo"": ""Base - Impuestos"",""iconoid"": ""ff4a7189-6426-43b9-bdc4-070314999e81"",""etiquetasingular"": ""Impuesto"",""etiquetaplural"": ""Impuestos"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""f3199ee0-dc83-4667-a9c1-f3b04e97a8a4"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Resumen impuesto 3"",""descripcion"": """",""keyword"": ""ReferenciaResumenImpuesto3"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaResumenImpuesto3 As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaResumenImpuesto3
          <DisplayName("Cuota R.E Impuesto 3")>
          Public Property ImporteCuotaREImpuesto3 As Decimal
          Public Shared ___ImporteCuotaREImpuesto3 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteCuotaREImpuesto3"",""etiqueta"": ""Cuota R.E Impuesto 3"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cuota R.E Impuesto 3"",""descripcion"": """",""keyword"": ""ImporteCuotaREImpuesto3"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteCuotaREImpuesto3 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteCuotaREImpuesto3
          <DisplayName("Empleado")>
          Public Property ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaEmpleadoPrincipal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaEmpleadoPrincipal"",""etiqueta"": ""Empleado"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empleado"",""descripcion"": """",""keyword"": ""ReferenciaEmpleadoPrincipal"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaEmpleadoPrincipal
          <DisplayName("Suma de conceptos Impuesto Exentos")>
          Public Property ImporteSumaDeConceptosImpuestoExentos As Decimal
          Public Shared ___ImporteSumaDeConceptosImpuestoExentos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSumaDeConceptosImpuestoExentos"",""etiqueta"": ""Suma de conceptos Impuesto Exentos"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Suma de conceptos Impuesto Exentos"",""descripcion"": """",""keyword"": ""ImporteSumaDeConceptosImpuestoExentos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSumaDeConceptosImpuestoExentos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSumaDeConceptosImpuestoExentos
          <Description("Descuento general de la venta. " & vbCrLf & "(Este es el ""Deseado"", podría modificarse según la configuración de ajustes de descuentos indicada, este valor puede ser distinto al aplicado finalmente)")>
          <DisplayName("Descuento General % (Deseado)")>
          Public Property DescuentoGeneralDeseadoPorciento As Decimal
          Public Shared ___DescuentoGeneralDeseadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoGeneralDeseadoPorciento"",""etiqueta"": ""Descuento General % (Deseado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento General % (Deseado)"",""descripcion"": """",""keyword"": ""DescuentoGeneralDeseadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoGeneralDeseadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoGeneralDeseadoPorciento
          <DisplayName("Descuento General impuesto Exento")>
          Public Property ImporteDescuentoGeneralImpuestoExento As Decimal
          Public Shared ___ImporteDescuentoGeneralImpuestoExento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentoGeneralImpuestoExento"",""etiqueta"": ""Descuento General impuesto Exento"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento General impuesto Exento"",""descripcion"": """",""keyword"": ""ImporteDescuentoGeneralImpuestoExento"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentoGeneralImpuestoExento As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentoGeneralImpuestoExento
          <Description("Descuento especial que se indica en la ficha de la entidad.")>
          <DisplayName("Descuento V.I.P % (Aplicado)")>
          Public Property DescuentoVIPAplicadoPorciento As Decimal
          Public Shared ___DescuentoVIPAplicadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoVIPAplicadoPorciento"",""etiqueta"": ""Descuento V.I.P % (Aplicado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento V.I.P % (Aplicado)"",""descripcion"": """",""keyword"": ""DescuentoVIPAplicadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoVIPAplicadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoVIPAplicadoPorciento
          <Description("Porcentaje de  descuento adicional B que se ha aplicado.")>
          <DisplayName("Descuento adicional B % (Aplicado)")>
          Public Property DescuentoAdicionalBAplicadoPorciento As Decimal
          Public Shared ___DescuentoAdicionalBAplicadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoAdicionalBAplicadoPorciento"",""etiqueta"": ""Descuento adicional B % (Aplicado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento adicional B % (Aplicado)"",""descripcion"": """",""keyword"": ""DescuentoAdicionalBAplicadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoAdicionalBAplicadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoAdicionalBAplicadoPorciento
          <DisplayName("Total (Sin pago con saldo)")>
          Public Property ImporteTotalSinPagoConSaldo As Decimal
          Public Shared ___ImporteTotalSinPagoConSaldo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteTotalSinPagoConSaldo"",""etiqueta"": ""Total (Sin pago con saldo)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total (Sin pago con saldo)"",""descripcion"": """",""keyword"": ""ImporteTotalSinPagoConSaldo"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteTotalSinPagoConSaldo As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteTotalSinPagoConSaldo
          <DisplayName("Descuentos Producto Impuesto 2")>
          Public Property ImporteDescuentosProductoImpuesto2 As Decimal
          Public Shared ___ImporteDescuentosProductoImpuesto2 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentosProductoImpuesto2"",""etiqueta"": ""Descuentos Producto Impuesto 2"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuentos Producto Impuesto 2"",""descripcion"": """",""keyword"": ""ImporteDescuentosProductoImpuesto2"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentosProductoImpuesto2 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentosProductoImpuesto2
          <DisplayName("Presupuesto de venta")>
          Public Property ReferenciaPresupuestoDeVenta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaPresupuestoDeVenta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaPresupuestoDeVenta"",""etiqueta"": ""Presupuesto de venta"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""b0502d52-b315-487b-a911-0e60f022b6cc"",""titulo"": ""Base - Presupuestos de venta"",""iconoid"": ""9dbff307-faa5-4795-a496-c8334f0fa5f3"",""etiquetasingular"": ""Presupuesto de venta"",""etiquetaplural"": ""Presupuestos de venta"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""b0502d52-b315-487b-a911-0e60f022b6cc"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Presupuesto de venta"",""descripcion"": """",""keyword"": ""ReferenciaPresupuestoDeVenta"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaPresupuestoDeVenta As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaPresupuestoDeVenta
          <Description("Importe total de todo los impuestos (Tanto generales como de productos) que se han aplicado.")>
          <DisplayName("Total Descontado (Sin impuestos)")>
          Public Property ImporteTotalDescontadoSinImpuestos As Decimal
          Public Shared ___ImporteTotalDescontadoSinImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteTotalDescontadoSinImpuestos"",""etiqueta"": ""Total Descontado (Sin impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total Descontado (Sin impuestos)"",""descripcion"": """",""keyword"": ""ImporteTotalDescontadoSinImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteTotalDescontadoSinImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteTotalDescontadoSinImpuestos
          <DisplayName("Cuota Impuesto 1")>
          Public Property ImporteCuotaImpuesto1 As Decimal
          Public Shared ___ImporteCuotaImpuesto1 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteCuotaImpuesto1"",""etiqueta"": ""Cuota Impuesto 1"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cuota Impuesto 1"",""descripcion"": """",""keyword"": ""ImporteCuotaImpuesto1"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteCuotaImpuesto1 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteCuotaImpuesto1
          <Description("Descuento general de la venta que se ha aplicado.")>
          <DisplayName("Descuento General % (Aplicado)")>
          Public Property DescuentoGeneralAplicadoPorciento As Decimal
          Public Shared ___DescuentoGeneralAplicadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoGeneralAplicadoPorciento"",""etiqueta"": ""Descuento General % (Aplicado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento General % (Aplicado)"",""descripcion"": """",""keyword"": ""DescuentoGeneralAplicadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoGeneralAplicadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoGeneralAplicadoPorciento
          <DisplayName("Base imponible impuesto 1")>
          Public Property ImporteBaseImponibleImpuesto1 As Decimal
          Public Shared ___ImporteBaseImponibleImpuesto1 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteBaseImponibleImpuesto1"",""etiqueta"": ""Base imponible impuesto 1"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Base imponible impuesto 1"",""descripcion"": """",""keyword"": ""ImporteBaseImponibleImpuesto1"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteBaseImponibleImpuesto1 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteBaseImponibleImpuesto1
          <DisplayName("Configuración de venta")>
          Public Property ReferenciaConfiguracionDeVenta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaConfiguracionDeVenta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaConfiguracionDeVenta"",""etiqueta"": ""Configuración de venta"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""73992631-cf40-4582-9bb5-ceab51445675"",""titulo"": ""Base - Configuración Ventas"",""iconoid"": ""877786af-aff4-49b3-aede-a9b1d80f3395"",""etiquetasingular"": ""Configuración de venta"",""etiquetaplural"": ""Configuraciones de venta"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""73992631-cf40-4582-9bb5-ceab51445675"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Configuración de venta"",""descripcion"": """",""keyword"": ""ReferenciaConfiguracionDeVenta"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaConfiguracionDeVenta As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaConfiguracionDeVenta
          <DisplayName("Impuestos incluidos")>
          Public Property ImpuestosIncluidos As Boolean
          Public Shared ___ImpuestosIncluidos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImpuestosIncluidos"",""etiqueta"": ""Impuestos incluidos"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Impuestos incluidos"",""descripcion"": """",""keyword"": ""ImpuestosIncluidos"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImpuestosIncluidos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImpuestosIncluidos
          <DisplayName("Cliente Tiene Acceso web")>
          Public Property ClienteTieneAccesoWeb As Boolean
          Public Shared ___ClienteTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ClienteTieneAccesoWeb"",""etiqueta"": ""Cliente Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cliente Tiene Acceso web"",""descripcion"": """",""keyword"": ""ClienteTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ClienteTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___ClienteTieneAccesoWeb
          <DisplayName("Uso de saldo personalizado")>
          Public Property UsoDeSaldoPersonalizado As Boolean
          Public Shared ___UsoDeSaldoPersonalizado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""UsoDeSaldoPersonalizado"",""etiqueta"": ""Uso de saldo personalizado"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Uso de saldo personalizado"",""descripcion"": """",""keyword"": ""UsoDeSaldoPersonalizado"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __UsoDeSaldoPersonalizado As DinaNETCore.APID.DinaupAPI_CampoC = ___UsoDeSaldoPersonalizado
          <DisplayName("Cuota R.E Impuesto 1")>
          Public Property ImporteCuotaREImpuesto1 As Decimal
          Public Shared ___ImporteCuotaREImpuesto1 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteCuotaREImpuesto1"",""etiqueta"": ""Cuota R.E Impuesto 1"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cuota R.E Impuesto 1"",""descripcion"": """",""keyword"": ""ImporteCuotaREImpuesto1"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteCuotaREImpuesto1 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteCuotaREImpuesto1
          <DisplayName("Tipo de movimiento")>
          Public Property ReferenciaTipoDeMovimiento As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaTipoDeMovimiento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaTipoDeMovimiento"",""etiqueta"": ""Tipo de movimiento"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""ef5644b0-fb98-4191-908d-99594d9e1cc5"",""titulo"": ""Base - Tipos de movimiento"",""iconoid"": ""d720d25f-f5b8-4c83-a9f3-a8bf6cb31468"",""etiquetasingular"": ""Tipo de movimiento"",""etiquetaplural"": ""Tipos de movimiento"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""ef5644b0-fb98-4191-908d-99594d9e1cc5"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Tipo de movimiento"",""descripcion"": """",""keyword"": ""ReferenciaTipoDeMovimiento"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaTipoDeMovimiento As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaTipoDeMovimiento
          <DisplayName("Suma conceptos (Con impuestos)")>
          Public Property SumaConceptosConImpuestos As Decimal
          Public Shared ___SumaConceptosConImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""SumaConceptosConImpuestos"",""etiqueta"": ""Suma conceptos (Con impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Suma conceptos (Con impuestos)"",""descripcion"": """",""keyword"": ""SumaConceptosConImpuestos"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __SumaConceptosConImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___SumaConceptosConImpuestos
          <DisplayName("Descuentos Producto Impuesto 3")>
          Public Property ImporteDescuentosProductoImpuesto3 As Decimal
          Public Shared ___ImporteDescuentosProductoImpuesto3 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentosProductoImpuesto3"",""etiqueta"": ""Descuentos Producto Impuesto 3"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuentos Producto Impuesto 3"",""descripcion"": """",""keyword"": ""ImporteDescuentosProductoImpuesto3"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentosProductoImpuesto3 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentosProductoImpuesto3
          <DisplayName("Notas")>
          Public Property Notas As String
          Public Shared ___Notas As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Notas"",""etiqueta"": ""Notas"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 16,""decimales"": ""0"",""multilinea"": true,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Notas"",""descripcion"": """",""keyword"": ""Notas"",""formato"": 5,""rol"": 16,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Notas As DinaNETCore.APID.DinaupAPI_CampoC = ___Notas
          <DisplayName("Municipio (Empresa)")>
          Public Property MunicipioEmpresa As String
          Public Shared ___MunicipioEmpresa As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""MunicipioEmpresa"",""etiqueta"": ""Municipio (Empresa)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Municipio (Empresa)"",""descripcion"": """",""keyword"": ""MunicipioEmpresa"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __MunicipioEmpresa As DinaNETCore.APID.DinaupAPI_CampoC = ___MunicipioEmpresa
          <DisplayName("Descuentos General Impuesto 2")>
          Public Property ImporteDescuentosGeneralImpuesto2 As Decimal
          Public Shared ___ImporteDescuentosGeneralImpuesto2 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentosGeneralImpuesto2"",""etiqueta"": ""Descuentos General Impuesto 2"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuentos General Impuesto 2"",""descripcion"": """",""keyword"": ""ImporteDescuentosGeneralImpuesto2"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentosGeneralImpuesto2 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentosGeneralImpuesto2
          <DisplayName("Base imponible impuesto 2")>
          Public Property ImporteBaseImponibleImpuesto2 As Decimal
          Public Shared ___ImporteBaseImponibleImpuesto2 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteBaseImponibleImpuesto2"",""etiqueta"": ""Base imponible impuesto 2"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Base imponible impuesto 2"",""descripcion"": """",""keyword"": ""ImporteBaseImponibleImpuesto2"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteBaseImponibleImpuesto2 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteBaseImponibleImpuesto2
          <Description("Importe total de los productos del documento, sin ningún tipo de descuento y/o impuestos aplicado.")>
          <DisplayName("Suma conceptos (Sin impuestos)")>
          Public Property ImporteSumaConceptosSinImpuestos As Decimal
          Public Shared ___ImporteSumaConceptosSinImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSumaConceptosSinImpuestos"",""etiqueta"": ""Suma conceptos (Sin impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Suma conceptos (Sin impuestos)"",""descripcion"": """",""keyword"": ""ImporteSumaConceptosSinImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSumaConceptosSinImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSumaConceptosSinImpuestos
          <Description("Número total de productos.")>
          <DisplayName("Cantidad de Productos")>
          Public Property CantidadDeProductos As Decimal
          Public Shared ___CantidadDeProductos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CantidadDeProductos"",""etiqueta"": ""Cantidad de Productos"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""11"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cantidad de Productos"",""descripcion"": """",""keyword"": ""CantidadDeProductos"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CantidadDeProductos As DinaNETCore.APID.DinaupAPI_CampoC = ___CantidadDeProductos
          <DisplayName("Descuento saldo exento")>
          Public Property ImporteDescuentoSaldoExento As Decimal
          Public Shared ___ImporteDescuentoSaldoExento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentoSaldoExento"",""etiqueta"": ""Descuento saldo exento"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento saldo exento"",""descripcion"": """",""keyword"": ""ImporteDescuentoSaldoExento"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentoSaldoExento As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentoSaldoExento
          <DisplayName("Descuento saldo impuesto 1")>
          Public Property ImporteDescuentoSaldoImpuesto1 As Decimal
          Public Shared ___ImporteDescuentoSaldoImpuesto1 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentoSaldoImpuesto1"",""etiqueta"": ""Descuento saldo impuesto 1"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento saldo impuesto 1"",""descripcion"": """",""keyword"": ""ImporteDescuentoSaldoImpuesto1"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentoSaldoImpuesto1 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentoSaldoImpuesto1
          <DisplayName("Saldo promocional utilizado")>
          Public Property ImporteSaldoPromocionalUtilizado As Decimal
          Public Shared ___ImporteSaldoPromocionalUtilizado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSaldoPromocionalUtilizado"",""etiqueta"": ""Saldo promocional utilizado"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Saldo promocional utilizado"",""descripcion"": """",""keyword"": ""ImporteSaldoPromocionalUtilizado"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSaldoPromocionalUtilizado As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSaldoPromocionalUtilizado
          <DisplayName("Descuentos Producto Exento")>
          Public Property ImporteDescuentosProductoExento As Decimal
          Public Shared ___ImporteDescuentosProductoExento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentosProductoExento"",""etiqueta"": ""Descuentos Producto Exento"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuentos Producto Exento"",""descripcion"": """",""keyword"": ""ImporteDescuentosProductoExento"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentosProductoExento As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentosProductoExento
          <DisplayName("Municipio (Cliente)")>
          Public Property MunicipioCliente As String
          Public Shared ___MunicipioCliente As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""MunicipioCliente"",""etiqueta"": ""Municipio (Cliente)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Municipio (Cliente)"",""descripcion"": """",""keyword"": ""MunicipioCliente"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __MunicipioCliente As DinaNETCore.APID.DinaupAPI_CampoC = ___MunicipioCliente
          <DisplayName("Presupuesto de Venta - Importe total")>
          Public Property ImportePresupuestoDeVentaImporteTotal As Decimal
          Public Shared ___ImportePresupuestoDeVentaImporteTotal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImportePresupuestoDeVentaImporteTotal"",""etiqueta"": ""Presupuesto de Venta - Importe total"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Presupuesto de Venta - Importe total"",""descripcion"": """",""keyword"": ""ImportePresupuestoDeVentaImporteTotal"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImportePresupuestoDeVentaImporteTotal As DinaNETCore.APID.DinaupAPI_CampoC = ___ImportePresupuestoDeVentaImporteTotal
          <DisplayName("Base imponible Exenta")>
          Public Property ImporteBaseImponibleExenta As Decimal
          Public Shared ___ImporteBaseImponibleExenta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteBaseImponibleExenta"",""etiqueta"": ""Base imponible Exenta"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Base imponible Exenta"",""descripcion"": """",""keyword"": ""ImporteBaseImponibleExenta"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteBaseImponibleExenta As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteBaseImponibleExenta
          <DisplayName("Estado")>
          Public Property ReferenciaEstado As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaEstado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaEstado"",""etiqueta"": ""Estado"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""a595f5f3-3f90-416c-bdfc-f1c30faebd8e"",""titulo"": ""Base - Estados de Movimientos"",""iconoid"": ""1fbec552-994a-465e-a9ee-8502faa65d11"",""etiquetasingular"": ""Estado de Movimientos"",""etiquetaplural"": ""Estados de Movimientos"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""a595f5f3-3f90-416c-bdfc-f1c30faebd8e"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Estado"",""descripcion"": """",""keyword"": ""ReferenciaEstado"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaEstado As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaEstado
          <DisplayName("Autor del alta Tiene Acceso web")>
          Public Property AutorDelAltaTieneAccesoWeb As Boolean
          Public Shared ___AutorDelAltaTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AutorDelAltaTieneAccesoWeb"",""etiqueta"": ""Autor del alta Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta Tiene Acceso web"",""descripcion"": """",""keyword"": ""AutorDelAltaTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AutorDelAltaTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___AutorDelAltaTieneAccesoWeb
          <Description("El Saldo promocional que genera la transacción para añadirlo al saldo de la Entidad.")>
          <DisplayName("Saldo promocional generado % (Aplicado)")>
          Public Property SaldoPromocionalGeneradoAplicadoPorciento As Decimal
          Public Shared ___SaldoPromocionalGeneradoAplicadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""SaldoPromocionalGeneradoAplicadoPorciento"",""etiqueta"": ""Saldo promocional generado % (Aplicado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Saldo promocional generado % (Aplicado)"",""descripcion"": """",""keyword"": ""SaldoPromocionalGeneradoAplicadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __SaldoPromocionalGeneradoAplicadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___SaldoPromocionalGeneradoAplicadoPorciento
          <DisplayName("Resumen impuesto 2")>
          Public Property ReferenciaResumenImpuesto2 As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaResumenImpuesto2 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaResumenImpuesto2"",""etiqueta"": ""Resumen impuesto 2"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""f3199ee0-dc83-4667-a9c1-f3b04e97a8a4"",""titulo"": ""Base - Impuestos"",""iconoid"": ""ff4a7189-6426-43b9-bdc4-070314999e81"",""etiquetasingular"": ""Impuesto"",""etiquetaplural"": ""Impuestos"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""f3199ee0-dc83-4667-a9c1-f3b04e97a8a4"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Resumen impuesto 2"",""descripcion"": """",""keyword"": ""ReferenciaResumenImpuesto2"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaResumenImpuesto2 As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaResumenImpuesto2
          <DisplayName("Código postal (Cliente)")>
          Public Property CodigoPostalCliente As String
          Public Shared ___CodigoPostalCliente As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CodigoPostalCliente"",""etiqueta"": ""Código postal (Cliente)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Código postal (Cliente)"",""descripcion"": """",""keyword"": ""CodigoPostalCliente"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CodigoPostalCliente As DinaNETCore.APID.DinaupAPI_CampoC = ___CodigoPostalCliente
          <DisplayName("Puesto de trabajo")>
          Public Property ReferenciaPuestoDeTrabajo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaPuestoDeTrabajo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaPuestoDeTrabajo"",""etiqueta"": ""Puesto de trabajo"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""f777486d-e709-41be-9211-d9c6b4bb05d6"",""titulo"": ""Base - Puestos de trabajo"",""iconoid"": ""5d7008ed-1e2f-4dbe-a376-6261de330414"",""etiquetasingular"": ""Puesto de trabajo"",""etiquetaplural"": ""Puestos de trabajo"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""f777486d-e709-41be-9211-d9c6b4bb05d6"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Puesto de trabajo"",""descripcion"": """",""keyword"": ""ReferenciaPuestoDeTrabajo"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaPuestoDeTrabajo As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaPuestoDeTrabajo
          <DisplayName("Ubicación Principal")>
          Public Property ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaUbicacionPrincipal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaUbicacionPrincipal"",""etiqueta"": ""Ubicación Principal"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""bffd6c6e-a75b-455f-8367-067e7bb2fb47"",""titulo"": ""Base - Ubicaciones"",""iconoid"": ""b985b58f-7275-46b8-9b66-2c54346b0185"",""etiquetasingular"": ""Ubicación"",""etiquetaplural"": ""Ubicaciones"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""bffd6c6e-a75b-455f-8367-067e7bb2fb47"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Ubicación Principal"",""descripcion"": """",""keyword"": ""ReferenciaUbicacionPrincipal"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaUbicacionPrincipal
          <DisplayName("Suma importe de productos (Sin Impuestos)")>
          Public Property ImporteSumaImporteDeProductosSinImpuestos As Decimal
          Public Shared ___ImporteSumaImporteDeProductosSinImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSumaImporteDeProductosSinImpuestos"",""etiqueta"": ""Suma importe de productos (Sin Impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Suma importe de productos (Sin Impuestos)"",""descripcion"": """",""keyword"": ""ImporteSumaImporteDeProductosSinImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSumaImporteDeProductosSinImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSumaImporteDeProductosSinImpuestos
          <DisplayName("Descuentos General Impuesto 3")>
          Public Property ImporteDescuentosGeneralImpuesto3 As Decimal
          Public Shared ___ImporteDescuentosGeneralImpuesto3 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentosGeneralImpuesto3"",""etiqueta"": ""Descuentos General Impuesto 3"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuentos General Impuesto 3"",""descripcion"": """",""keyword"": ""ImporteDescuentosGeneralImpuesto3"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentosGeneralImpuesto3 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentosGeneralImpuesto3
          <DisplayName("CIF/NIF (Cliente)")>
          Public Property CIFNIFCliente As String
          Public Shared ___CIFNIFCliente As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CIFNIFCliente"",""etiqueta"": ""CIF/NIF (Cliente)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 79,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""CIF/NIF (Cliente)"",""descripcion"": """",""keyword"": ""CIFNIFCliente"",""formato"": 5,""rol"": 79,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CIFNIFCliente As DinaNETCore.APID.DinaupAPI_CampoC = ___CIFNIFCliente
          <DisplayName("Numeración / Serie")>
          Public Property ReferenciaNumeracionSerie As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaNumeracionSerie As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaNumeracionSerie"",""etiqueta"": ""Numeración / Serie"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""a93edb96-3ad2-4498-a1ca-696737b93cea"",""titulo"": ""Base - Numeraciones / Series"",""iconoid"": ""5ae6b089-a12a-417c-92c2-d64de875e355"",""etiquetasingular"": ""Numeración / Serie"",""etiquetaplural"": ""Numeraciones / Series"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""a93edb96-3ad2-4498-a1ca-696737b93cea"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Numeración / Serie"",""descripcion"": """",""keyword"": ""ReferenciaNumeracionSerie"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaNumeracionSerie As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaNumeracionSerie
          <DisplayName("Provincia (Empresa)")>
          Public Property ProvinciaEmpresa As String
          Public Shared ___ProvinciaEmpresa As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ProvinciaEmpresa"",""etiqueta"": ""Provincia (Empresa)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Provincia (Empresa)"",""descripcion"": """",""keyword"": ""ProvinciaEmpresa"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ProvinciaEmpresa As DinaNETCore.APID.DinaupAPI_CampoC = ___ProvinciaEmpresa
          <DisplayName("Dirección (Cliente)")>
          Public Property DireccionCliente As String
          Public Shared ___DireccionCliente As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DireccionCliente"",""etiqueta"": ""Dirección (Cliente)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 9,""decimales"": ""0"",""multilinea"": true,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Dirección (Cliente)"",""descripcion"": """",""keyword"": ""DireccionCliente"",""formato"": 5,""rol"": 9,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DireccionCliente As DinaNETCore.APID.DinaupAPI_CampoC = ___DireccionCliente
          <Description("Importe total sin impuestos ni retenciones." & vbCrLf & "Pero con todas las bonificaciones aplicadas y todos los importes sumados." & vbCrLf & "Es el paso anterior al resultado final.")>
          <DisplayName("Subtotal")>
          Public Property ImporteSubtotal As Decimal
          Public Shared ___ImporteSubtotal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSubtotal"",""etiqueta"": ""Subtotal"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Subtotal"",""descripcion"": """",""keyword"": ""ImporteSubtotal"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSubtotal As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSubtotal
          <DisplayName("Destinador")>
          Public Property ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaDestinador As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaDestinador"",""etiqueta"": ""Destinador"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""relacionesindirectas"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Destinador"",""descripcion"": """",""keyword"": ""ReferenciaDestinador"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaDestinador
          <DisplayName("Hora local")>
          Public Property HoraLocal As DateTime?
          Public Shared ___HoraLocal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""HoraLocal"",""etiqueta"": ""Hora local"",""oculta"": false,""formato"": 8,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Hora local"",""descripcion"": """",""keyword"": ""HoraLocal"",""formato"": 8,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __HoraLocal As DinaNETCore.APID.DinaupAPI_CampoC = ___HoraLocal
          <DisplayName("Suma de conceptos Impuesto 1")>
          Public Property ImporteSumaDeConceptosImpuesto1 As Decimal
          Public Shared ___ImporteSumaDeConceptosImpuesto1 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSumaDeConceptosImpuesto1"",""etiqueta"": ""Suma de conceptos Impuesto 1"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Suma de conceptos Impuesto 1"",""descripcion"": """",""keyword"": ""ImporteSumaDeConceptosImpuesto1"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSumaDeConceptosImpuesto1 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSumaDeConceptosImpuesto1
          <DisplayName("Presupuesto de Venta - Total (Sin pago con saldo)")>
          Public Property ImportePresupuestoDeVentaTotalSinPagoConSaldo As Decimal
          Public Shared ___ImportePresupuestoDeVentaTotalSinPagoConSaldo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImportePresupuestoDeVentaTotalSinPagoConSaldo"",""etiqueta"": ""Presupuesto de Venta - Total (Sin pago con saldo)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Presupuesto de Venta - Total (Sin pago con saldo)"",""descripcion"": """",""keyword"": ""ImportePresupuestoDeVentaTotalSinPagoConSaldo"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImportePresupuestoDeVentaTotalSinPagoConSaldo As DinaNETCore.APID.DinaupAPI_CampoC = ___ImportePresupuestoDeVentaTotalSinPagoConSaldo
          <DisplayName("Cuota R.E Impuesto 2")>
          Public Property ImporteCuotaREImpuesto2 As Decimal
          Public Shared ___ImporteCuotaREImpuesto2 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteCuotaREImpuesto2"",""etiqueta"": ""Cuota R.E Impuesto 2"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cuota R.E Impuesto 2"",""descripcion"": """",""keyword"": ""ImporteCuotaREImpuesto2"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteCuotaREImpuesto2 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteCuotaREImpuesto2
          <DisplayName("Provincia (Cliente)")>
          Public Property ProvinciaCliente As String
          Public Shared ___ProvinciaCliente As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ProvinciaCliente"",""etiqueta"": ""Provincia (Cliente)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Provincia (Cliente)"",""descripcion"": """",""keyword"": ""ProvinciaCliente"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ProvinciaCliente As DinaNETCore.APID.DinaupAPI_CampoC = ___ProvinciaCliente
          <DisplayName("Suma de conceptos Impuesto 3")>
          Public Property ImporteSumaDeConceptosImpuesto3 As Decimal
          Public Shared ___ImporteSumaDeConceptosImpuesto3 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSumaDeConceptosImpuesto3"",""etiqueta"": ""Suma de conceptos Impuesto 3"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Suma de conceptos Impuesto 3"",""descripcion"": """",""keyword"": ""ImporteSumaDeConceptosImpuesto3"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSumaDeConceptosImpuesto3 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSumaDeConceptosImpuesto3
          <DisplayName("Teléfono (Cliente)")>
          Public Property TelefonoCliente As String
          Public Shared ___TelefonoCliente As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TelefonoCliente"",""etiqueta"": ""Teléfono (Cliente)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 2,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Teléfono (Cliente)"",""descripcion"": """",""keyword"": ""TelefonoCliente"",""formato"": 5,""rol"": 2,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __TelefonoCliente As DinaNETCore.APID.DinaupAPI_CampoC = ___TelefonoCliente
          <DisplayName("Datos fiscales (Empresa)")>
          Public Property ReferenciaDatosFiscalesEmpresa As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaDatosFiscalesEmpresa As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaDatosFiscalesEmpresa"",""etiqueta"": ""Datos fiscales (Empresa)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""03e347ac-c694-4d4a-a81f-e577ba014d1d"",""titulo"": ""Base - Datos fiscales"",""iconoid"": ""773d55f9-1e21-41f1-b0b0-f6a1dd370ea3"",""etiquetasingular"": ""Datos fiscales"",""etiquetaplural"": ""Datos fiscales"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""03e347ac-c694-4d4a-a81f-e577ba014d1d"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Datos fiscales (Empresa)"",""descripcion"": """",""keyword"": ""ReferenciaDatosFiscalesEmpresa"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaDatosFiscalesEmpresa As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaDatosFiscalesEmpresa
          <DisplayName("Datos fiscales (Cliente)")>
          Public Property ReferenciaDatosFiscalesCliente As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaDatosFiscalesCliente As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaDatosFiscalesCliente"",""etiqueta"": ""Datos fiscales (Cliente)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""03e347ac-c694-4d4a-a81f-e577ba014d1d"",""titulo"": ""Base - Datos fiscales"",""iconoid"": ""773d55f9-1e21-41f1-b0b0-f6a1dd370ea3"",""etiquetasingular"": ""Datos fiscales"",""etiquetaplural"": ""Datos fiscales"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""03e347ac-c694-4d4a-a81f-e577ba014d1d"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Datos fiscales (Cliente)"",""descripcion"": """",""keyword"": ""ReferenciaDatosFiscalesCliente"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaDatosFiscalesCliente As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaDatosFiscalesCliente
          <DisplayName("Importe impuesto general")>
          Public Property ImporteImporteImpuestoGeneral As Decimal
          Public Shared ___ImporteImporteImpuestoGeneral As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteImporteImpuestoGeneral"",""etiqueta"": ""Importe impuesto general"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Importe impuesto general"",""descripcion"": """",""keyword"": ""ImporteImporteImpuestoGeneral"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteImporteImpuestoGeneral As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteImporteImpuestoGeneral
          <DisplayName("Impuesto general")>
          Public Property ReferenciaImpuestoGeneral As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaImpuestoGeneral As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaImpuestoGeneral"",""etiqueta"": ""Impuesto general"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""f3199ee0-dc83-4667-a9c1-f3b04e97a8a4"",""titulo"": ""Base - Impuestos"",""iconoid"": ""ff4a7189-6426-43b9-bdc4-070314999e81"",""etiquetasingular"": ""Impuesto"",""etiquetaplural"": ""Impuestos"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""f3199ee0-dc83-4667-a9c1-f3b04e97a8a4"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Impuesto general"",""descripcion"": """",""keyword"": ""ReferenciaImpuestoGeneral"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaImpuestoGeneral As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaImpuestoGeneral
          <DisplayName("Condiciones de pago")>
          Public Property CondicionesDePago As String
          Public Shared ___CondicionesDePago As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CondicionesDePago"",""etiqueta"": ""Condiciones de pago"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Condiciones de pago"",""descripcion"": """",""keyword"": ""CondicionesDePago"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CondicionesDePago As DinaNETCore.APID.DinaupAPI_CampoC = ___CondicionesDePago
          <DisplayName("Condición de pago (Días)")>
          Public Property CondicionDePagoDias As Integer
          Public Shared ___CondicionDePagoDias As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CondicionDePagoDias"",""etiqueta"": ""Condición de pago (Días)"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Condición de pago (Días)"",""descripcion"": """",""keyword"": ""CondicionDePagoDias"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CondicionDePagoDias As DinaNETCore.APID.DinaupAPI_CampoC = ___CondicionDePagoDias
          <ReadOnlyAttribute(True)>
          <DisplayName("ID")>
          Public Property ID As Guid
          Public Shared ___ID As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": true,""eseliminado"": false,""keyword"": ""ID"",""etiqueta"": ""ID"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""4cd4f471-e8f3-42b2-b653-55a4cf0f4e19"",""titulo"": ""Base - Facturas proforma"",""iconoid"": ""39d08324-2d04-4df7-bcc2-6945bc006a74"",""etiquetasingular"": ""Factura proforma"",""etiquetaplural"": ""Facturas proforma"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""4cd4f471-e8f3-42b2-b653-55a4cf0f4e19"",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""ID"",""descripcion"": """",""keyword"": ""ID"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
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
          me.ImporteImporteRetencion = _Datos.Leer_Decimal("pr_100401058015")
          me.IdentificacionCliente = _Datos.Leer_String("pr_10040107981")
          me.PaisCliente = _Datos.Leer_String("pr_10040107985")
          me.Terminos = _Datos.Leer_String("pr_100401079832")
          me.DescripcionDescuentoAdicionalB = _Datos.Leer_String("pr_100401058070")
          me.Observaciones = _Datos.Leer_String("pr_100401058071")
          me.ImporteSaldoObtenidoEntidad = _Datos.Leer_Decimal("pr_100401058016")
          me.ReferenciaTipoDeCliente = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_10040105803"), _Datos.Leer_String("pr_10040105803.nombre"))
          me.ImporteTotal = _Datos.Leer_Decimal("pr_100401058017")
          me.AplicarRecargoDeEquivalencia = _Datos.Leer_Boolean("pr_100401058075")
          me.ValidoHasta = _Datos.Leer_Date_Nulable("pr_100401079831")
          me.ImporteTotalDescuentosNoAplicados = _Datos.Leer_Decimal("pr_100401058019")
          me.ImporteDescuentosGeneralImpuesto1 = _Datos.Leer_Decimal("pr_100401058020")
          me.ImporteSaldoQueTeniaElClienteAntesDeLaVenta = _Datos.Leer_Decimal("pr_100401058021")
          me.NFacturaNumerico = _Datos.Leer_Integer("pr_100401058074")
          me.DireccionEmpresa = _Datos.Leer_String("pr_60040107984")
          me.ReferenciaAutorDelAlta = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_3004010555320"), _Datos.Leer_String("pr_3004010555320.nombre"))
          me.DescuentoTipoEntidadPorciento = _Datos.Leer_Decimal("pr_100401058022")
          me.DescuentoAdicionalAAplicadoPorciento = _Datos.Leer_Decimal("pr_100401058023")
          me.ImporteDescuentoSaldoImpuesto2 = _Datos.Leer_Decimal("pr_100401058024")
          me.DescuentoAdicionalADeseadoPorciento = _Datos.Leer_Decimal("pr_100401058025")
          me.ImporteDescuentoSaldoImpuesto3 = _Datos.Leer_Decimal("pr_100401058026")
          me.ImporteBaseImponibleImpuesto3 = _Datos.Leer_Decimal("pr_100401058027")
          me.ImporteTotalImpuestos = _Datos.Leer_Decimal("pr_100401058028")
          me.TotalPorcentajeDescuentosGeneralesPorciento = _Datos.Leer_Decimal("pr_100401058029")
          me.FechaFactura = _Datos.Leer_Date_Nulable("pr_50040107971")
          me.TelefonoEmpresa = _Datos.Leer_String("pr_50040108121")
          me.DescuentoVIPDeseadoPorciento = _Datos.Leer_Decimal("pr_100401058030")
          me.ImportePresupuestoDeVentaRatioDeProrrateo = _Datos.Leer_Decimal("pr_500401157210")
          me.PaisEmpresa = _Datos.Leer_String("pr_60040107983")
          me.DescripcionDescuentoAdicionalA = _Datos.Leer_String("pr_100401058072")
          me.ImporteSumaImporteProductosConImpuestos = _Datos.Leer_Decimal("pr_100401058031")
          me.NFactura = _Datos.Leer_String("pr_100401058073")
          me.CodigoPostalEmpresa = _Datos.Leer_String("pr_60040107981")
          me.SaldoPromocionalGeneradoDeseadoPorciento = _Datos.Leer_Decimal("pr_100401058032")
          me.DescuentoEntidadDeseadoPorciento = _Datos.Leer_Decimal("pr_100401058033")
          me.ImporteCuotaImpuesto2 = _Datos.Leer_Decimal("pr_100401058034")
          me.FechaDato_UTC = _Datos.Leer_DateTime_Nulable("pr_3004010555321")
          me.ReferenciaRetencion = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_10040105804"), _Datos.Leer_String("pr_10040105804.nombre"))
          me.DescuentoTipoDeEntidadDeseadoPorciento = _Datos.Leer_Decimal("pr_100401058035")
          me.IdentificacionEmpresa = _Datos.Leer_String("pr_60040107985")
          me.ImporteCuotaImpuesto3 = _Datos.Leer_Decimal("pr_100401058036")
          me.ImporteSumaDeConceptosImpuesto2 = _Datos.Leer_Decimal("pr_100401058037")
          me.FechaAlta_UTC = _Datos.Leer_DateTime_Nulable("pr_3004010555324")
          me.ReferenciaCliente = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_10040105805"), _Datos.Leer_String("pr_10040105805.nombre"))
          me.ReferenciaResumenImpuesto1 = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_10040105806"), _Datos.Leer_String("pr_10040105806.nombre"))
          me.ImporteDescuentosProductoImpuesto1 = _Datos.Leer_Decimal("pr_100401058038")
          me.DescuentoEntidadAplicadoPorciento = _Datos.Leer_Decimal("pr_100401058039")
          me.CIFNIFEmpresa = _Datos.Leer_String("pr_60040107986")
          me.EmpleadoTieneAccesoWeb = _Datos.Leer_Boolean("pr_3004010555335")
          me.ImportePresupuestoDeVentaSaldoPromocionalUtilizado = _Datos.Leer_Decimal("pr_50040115728")
          me.DescuentoAdicionalBDeseadoPorciento = _Datos.Leer_Decimal("pr_100401058040")
          me.ReferenciaResumenImpuesto3 = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_10040105807"), _Datos.Leer_String("pr_10040105807.nombre"))
          me.ImporteCuotaREImpuesto3 = _Datos.Leer_Decimal("pr_100401058041")
          me.ReferenciaEmpleadoPrincipal = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_3004010555318"), _Datos.Leer_String("pr_3004010555318.nombre"))
          me.ImporteSumaDeConceptosImpuestoExentos = _Datos.Leer_Decimal("pr_100401058042")
          me.DescuentoGeneralDeseadoPorciento = _Datos.Leer_Decimal("pr_100401058043")
          me.ImporteDescuentoGeneralImpuestoExento = _Datos.Leer_Decimal("pr_100401058044")
          me.DescuentoVIPAplicadoPorciento = _Datos.Leer_Decimal("pr_100401058045")
          me.DescuentoAdicionalBAplicadoPorciento = _Datos.Leer_Decimal("pr_100401058046")
          me.ImporteTotalSinPagoConSaldo = _Datos.Leer_Decimal("pr_20040115008")
          me.ImporteDescuentosProductoImpuesto2 = _Datos.Leer_Decimal("pr_100401058047")
          me.ReferenciaPresupuestoDeVenta = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_1004010580562"), _Datos.Leer_String("pr_1004010580562.nombre"))
          me.ImporteTotalDescontadoSinImpuestos = _Datos.Leer_Decimal("pr_100401058048")
          me.ImporteCuotaImpuesto1 = _Datos.Leer_Decimal("pr_100401058049")
          me.DescuentoGeneralAplicadoPorciento = _Datos.Leer_Decimal("pr_100401058050")
          me.ImporteBaseImponibleImpuesto1 = _Datos.Leer_Decimal("pr_100401058051")
          me.ReferenciaConfiguracionDeVenta = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_10040105808"), _Datos.Leer_String("pr_10040105808.nombre"))
          me.ImpuestosIncluidos = _Datos.Leer_Boolean("pr_100401058076")
          me.ClienteTieneAccesoWeb = _Datos.Leer_Boolean("pr_100401058014")
          me.UsoDeSaldoPersonalizado = _Datos.Leer_Boolean("pr_20040115732")
          me.ImporteCuotaREImpuesto1 = _Datos.Leer_Decimal("pr_100401058052")
          me.ReferenciaTipoDeMovimiento = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_10040105809"), _Datos.Leer_String("pr_10040105809.nombre"))
          me.SumaConceptosConImpuestos = _Datos.Leer_Decimal("pr_60040115044")
          me.ImporteDescuentosProductoImpuesto3 = _Datos.Leer_Decimal("pr_100401058053")
          me.Notas = _Datos.Leer_String("pr_100401079833")
          me.MunicipioEmpresa = _Datos.Leer_String("pr_10040108561")
          me.ImporteDescuentosGeneralImpuesto2 = _Datos.Leer_Decimal("pr_100401058054")
          me.ImporteBaseImponibleImpuesto2 = _Datos.Leer_Decimal("pr_100401058055")
          me.ImporteSumaConceptosSinImpuestos = _Datos.Leer_Decimal("pr_100401058056")
          me.CantidadDeProductos = _Datos.Leer_Decimal("pr_100401058057")
          me.ImporteDescuentoSaldoExento = _Datos.Leer_Decimal("pr_100401058058")
          me.ImporteDescuentoSaldoImpuesto1 = _Datos.Leer_Decimal("pr_100401058059")
          me.ImporteSaldoPromocionalUtilizado = _Datos.Leer_Decimal("pr_100401058060")
          me.ImporteDescuentosProductoExento = _Datos.Leer_Decimal("pr_100401058061")
          me.MunicipioCliente = _Datos.Leer_String("pr_50040108212")
          me.ImportePresupuestoDeVentaImporteTotal = _Datos.Leer_Decimal("pr_50040115727")
          me.ImporteBaseImponibleExenta = _Datos.Leer_Decimal("pr_100401058062")
          me.ReferenciaEstado = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_100401058010"), _Datos.Leer_String("pr_100401058010.nombre"))
          me.AutorDelAltaTieneAccesoWeb = _Datos.Leer_Boolean("pr_3004010555333")
          me.SaldoPromocionalGeneradoAplicadoPorciento = _Datos.Leer_Decimal("pr_100401058063")
          me.ReferenciaResumenImpuesto2 = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_100401058011"), _Datos.Leer_String("pr_100401058011.nombre"))
          me.CodigoPostalCliente = _Datos.Leer_String("pr_10040107984")
          me.ReferenciaPuestoDeTrabajo = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_100401058012"), _Datos.Leer_String("pr_100401058012.nombre"))
          me.ReferenciaUbicacionPrincipal = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_3004010555319"), _Datos.Leer_String("pr_3004010555319.nombre"))
          me.ImporteSumaImporteDeProductosSinImpuestos = _Datos.Leer_Decimal("pr_100401058064")
          me.ImporteDescuentosGeneralImpuesto3 = _Datos.Leer_Decimal("pr_100401058065")
          me.CIFNIFCliente = _Datos.Leer_String("pr_10040107983")
          me.ReferenciaNumeracionSerie = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_100401058013"), _Datos.Leer_String("pr_100401058013.nombre"))
          me.ProvinciaEmpresa = _Datos.Leer_String("pr_60040107982")
          me.DireccionCliente = _Datos.Leer_String("pr_100401079920")
          me.ImporteSubtotal = _Datos.Leer_Decimal("pr_100401058066")
          me.ReferenciaDestinador = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_3004010555327"), _Datos.Leer_String("pr_3004010555327.nombre"))
          me.HoraLocal = _Datos.Leer_Time_Nulable("pr_3004010555322")
          me.ImporteSumaDeConceptosImpuesto1 = _Datos.Leer_Decimal("pr_100401058067")
          me.ImportePresupuestoDeVentaTotalSinPagoConSaldo = _Datos.Leer_Decimal("pr_50040115729")
          me.ImporteCuotaREImpuesto2 = _Datos.Leer_Decimal("pr_100401058068")
          me.ProvinciaCliente = _Datos.Leer_String("pr_10040107986")
          me.ImporteSumaDeConceptosImpuesto3 = _Datos.Leer_Decimal("pr_100401058069")
          me.TelefonoCliente = _Datos.Leer_String("pr_10040138801")
          me.ReferenciaDatosFiscalesEmpresa = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_10040138802"), _Datos.Leer_String("pr_10040138802.nombre"))
          me.ReferenciaDatosFiscalesCliente = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_10040138803"), _Datos.Leer_String("pr_10040138803.nombre"))
          me.ImporteImporteImpuestoGeneral = _Datos.Leer_Decimal("pr_500401489611")
          me.ReferenciaImpuestoGeneral = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_600401489612"), _Datos.Leer_String("pr_600401489612.nombre"))
          me.CondicionesDePago = _Datos.Leer_String("pr_50040172141")
          me.CondicionDePagoDias = _Datos.Leer_Integer("pr_40040176512")
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
         R.add("pr_100401058015", me.ImporteImporteRetencion.AdaptarMySQL_Decimal())
         R.add("pr_10040107981", me.IdentificacionCliente.AdaptarMySQL_String())
         R.add("pr_10040107985", me.PaisCliente.AdaptarMySQL_String())
         R.add("pr_100401079832", me.Terminos.AdaptarMySQL_String())
         R.add("pr_100401058070", me.DescripcionDescuentoAdicionalB.AdaptarMySQL_String())
         R.add("pr_100401058071", me.Observaciones.AdaptarMySQL_String())
         R.add("pr_100401058016", me.ImporteSaldoObtenidoEntidad.AdaptarMySQL_Decimal())
         If Me.ReferenciaTipoDeCliente IsNot nothing then
           R.add("pr_10040105803",me.ReferenciaTipoDeCliente.ID.STR())
         Else
           R.add("pr_10040105803","")
         End if
         R.add("pr_100401058017", me.ImporteTotal.AdaptarMySQL_Decimal())
         R.add("pr_100401058075", me.AplicarRecargoDeEquivalencia.AdaptarMySQL_Boolean())
         R.add("pr_100401079831", me.ValidoHasta.AdaptarMySQL_Date_Nulable())
         R.add("pr_100401058019", me.ImporteTotalDescuentosNoAplicados.AdaptarMySQL_Decimal())
         R.add("pr_100401058020", me.ImporteDescuentosGeneralImpuesto1.AdaptarMySQL_Decimal())
         R.add("pr_100401058021", me.ImporteSaldoQueTeniaElClienteAntesDeLaVenta.AdaptarMySQL_Decimal())
         R.add("pr_100401058074", me.NFacturaNumerico.AdaptarMySQL_Integer())
         R.add("pr_60040107984", me.DireccionEmpresa.AdaptarMySQL_String())
         If Me.ReferenciaAutorDelAlta IsNot nothing then
           R.add("pr_3004010555320",me.ReferenciaAutorDelAlta.ID.STR())
         Else
           R.add("pr_3004010555320","")
         End if
         R.add("pr_100401058022", me.DescuentoTipoEntidadPorciento.AdaptarMySQL_Decimal())
         R.add("pr_100401058023", me.DescuentoAdicionalAAplicadoPorciento.AdaptarMySQL_Decimal())
         R.add("pr_100401058024", me.ImporteDescuentoSaldoImpuesto2.AdaptarMySQL_Decimal())
         R.add("pr_100401058025", me.DescuentoAdicionalADeseadoPorciento.AdaptarMySQL_Decimal())
         R.add("pr_100401058026", me.ImporteDescuentoSaldoImpuesto3.AdaptarMySQL_Decimal())
         R.add("pr_100401058027", me.ImporteBaseImponibleImpuesto3.AdaptarMySQL_Decimal())
         R.add("pr_100401058028", me.ImporteTotalImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_100401058029", me.TotalPorcentajeDescuentosGeneralesPorciento.AdaptarMySQL_Decimal())
         R.add("pr_50040107971", me.FechaFactura.AdaptarMySQL_Date_Nulable())
         R.add("pr_50040108121", me.TelefonoEmpresa.AdaptarMySQL_String())
         R.add("pr_100401058030", me.DescuentoVIPDeseadoPorciento.AdaptarMySQL_Decimal())
         R.add("pr_500401157210", me.ImportePresupuestoDeVentaRatioDeProrrateo.AdaptarMySQL_Decimal())
         R.add("pr_60040107983", me.PaisEmpresa.AdaptarMySQL_String())
         R.add("pr_100401058072", me.DescripcionDescuentoAdicionalA.AdaptarMySQL_String())
         R.add("pr_100401058031", me.ImporteSumaImporteProductosConImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_100401058073", me.NFactura.AdaptarMySQL_String())
         R.add("pr_60040107981", me.CodigoPostalEmpresa.AdaptarMySQL_String())
         R.add("pr_100401058032", me.SaldoPromocionalGeneradoDeseadoPorciento.AdaptarMySQL_Decimal())
         R.add("pr_100401058033", me.DescuentoEntidadDeseadoPorciento.AdaptarMySQL_Decimal())
         R.add("pr_100401058034", me.ImporteCuotaImpuesto2.AdaptarMySQL_Decimal())
         R.add("pr_3004010555321", me.FechaDato_UTC.AdaptarMySQL_DateTime_Nulable())
         If Me.ReferenciaRetencion IsNot nothing then
           R.add("pr_10040105804",me.ReferenciaRetencion.ID.STR())
         Else
           R.add("pr_10040105804","")
         End if
         R.add("pr_100401058035", me.DescuentoTipoDeEntidadDeseadoPorciento.AdaptarMySQL_Decimal())
         R.add("pr_60040107985", me.IdentificacionEmpresa.AdaptarMySQL_String())
         R.add("pr_100401058036", me.ImporteCuotaImpuesto3.AdaptarMySQL_Decimal())
         R.add("pr_100401058037", me.ImporteSumaDeConceptosImpuesto2.AdaptarMySQL_Decimal())
         R.add("pr_3004010555324", me.FechaAlta_UTC.AdaptarMySQL_DateTime_Nulable())
         If Me.ReferenciaCliente IsNot nothing then
           R.add("pr_10040105805",me.ReferenciaCliente.ID.STR())
         Else
           R.add("pr_10040105805","")
         End if
         If Me.ReferenciaResumenImpuesto1 IsNot nothing then
           R.add("pr_10040105806",me.ReferenciaResumenImpuesto1.ID.STR())
         Else
           R.add("pr_10040105806","")
         End if
         R.add("pr_100401058038", me.ImporteDescuentosProductoImpuesto1.AdaptarMySQL_Decimal())
         R.add("pr_100401058039", me.DescuentoEntidadAplicadoPorciento.AdaptarMySQL_Decimal())
         R.add("pr_60040107986", me.CIFNIFEmpresa.AdaptarMySQL_String())
         R.add("pr_3004010555335", me.EmpleadoTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_50040115728", me.ImportePresupuestoDeVentaSaldoPromocionalUtilizado.AdaptarMySQL_Decimal())
         R.add("pr_100401058040", me.DescuentoAdicionalBDeseadoPorciento.AdaptarMySQL_Decimal())
         If Me.ReferenciaResumenImpuesto3 IsNot nothing then
           R.add("pr_10040105807",me.ReferenciaResumenImpuesto3.ID.STR())
         Else
           R.add("pr_10040105807","")
         End if
         R.add("pr_100401058041", me.ImporteCuotaREImpuesto3.AdaptarMySQL_Decimal())
         If Me.ReferenciaEmpleadoPrincipal IsNot nothing then
           R.add("pr_3004010555318",me.ReferenciaEmpleadoPrincipal.ID.STR())
         Else
           R.add("pr_3004010555318","")
         End if
         R.add("pr_100401058042", me.ImporteSumaDeConceptosImpuestoExentos.AdaptarMySQL_Decimal())
         R.add("pr_100401058043", me.DescuentoGeneralDeseadoPorciento.AdaptarMySQL_Decimal())
         R.add("pr_100401058044", me.ImporteDescuentoGeneralImpuestoExento.AdaptarMySQL_Decimal())
         R.add("pr_100401058045", me.DescuentoVIPAplicadoPorciento.AdaptarMySQL_Decimal())
         R.add("pr_100401058046", me.DescuentoAdicionalBAplicadoPorciento.AdaptarMySQL_Decimal())
         R.add("pr_20040115008", me.ImporteTotalSinPagoConSaldo.AdaptarMySQL_Decimal())
         R.add("pr_100401058047", me.ImporteDescuentosProductoImpuesto2.AdaptarMySQL_Decimal())
         If Me.ReferenciaPresupuestoDeVenta IsNot nothing then
           R.add("pr_1004010580562",me.ReferenciaPresupuestoDeVenta.ID.STR())
         Else
           R.add("pr_1004010580562","")
         End if
         R.add("pr_100401058048", me.ImporteTotalDescontadoSinImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_100401058049", me.ImporteCuotaImpuesto1.AdaptarMySQL_Decimal())
         R.add("pr_100401058050", me.DescuentoGeneralAplicadoPorciento.AdaptarMySQL_Decimal())
         R.add("pr_100401058051", me.ImporteBaseImponibleImpuesto1.AdaptarMySQL_Decimal())
         If Me.ReferenciaConfiguracionDeVenta IsNot nothing then
           R.add("pr_10040105808",me.ReferenciaConfiguracionDeVenta.ID.STR())
         Else
           R.add("pr_10040105808","")
         End if
         R.add("pr_100401058076", me.ImpuestosIncluidos.AdaptarMySQL_Boolean())
         R.add("pr_100401058014", me.ClienteTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_20040115732", me.UsoDeSaldoPersonalizado.AdaptarMySQL_Boolean())
         R.add("pr_100401058052", me.ImporteCuotaREImpuesto1.AdaptarMySQL_Decimal())
         If Me.ReferenciaTipoDeMovimiento IsNot nothing then
           R.add("pr_10040105809",me.ReferenciaTipoDeMovimiento.ID.STR())
         Else
           R.add("pr_10040105809","")
         End if
         R.add("pr_60040115044", me.SumaConceptosConImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_100401058053", me.ImporteDescuentosProductoImpuesto3.AdaptarMySQL_Decimal())
         R.add("pr_100401079833", me.Notas.AdaptarMySQL_String())
         R.add("pr_10040108561", me.MunicipioEmpresa.AdaptarMySQL_String())
         R.add("pr_100401058054", me.ImporteDescuentosGeneralImpuesto2.AdaptarMySQL_Decimal())
         R.add("pr_100401058055", me.ImporteBaseImponibleImpuesto2.AdaptarMySQL_Decimal())
         R.add("pr_100401058056", me.ImporteSumaConceptosSinImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_100401058057", me.CantidadDeProductos.AdaptarMySQL_Decimal())
         R.add("pr_100401058058", me.ImporteDescuentoSaldoExento.AdaptarMySQL_Decimal())
         R.add("pr_100401058059", me.ImporteDescuentoSaldoImpuesto1.AdaptarMySQL_Decimal())
         R.add("pr_100401058060", me.ImporteSaldoPromocionalUtilizado.AdaptarMySQL_Decimal())
         R.add("pr_100401058061", me.ImporteDescuentosProductoExento.AdaptarMySQL_Decimal())
         R.add("pr_50040108212", me.MunicipioCliente.AdaptarMySQL_String())
         R.add("pr_50040115727", me.ImportePresupuestoDeVentaImporteTotal.AdaptarMySQL_Decimal())
         R.add("pr_100401058062", me.ImporteBaseImponibleExenta.AdaptarMySQL_Decimal())
         If Me.ReferenciaEstado IsNot nothing then
           R.add("pr_100401058010",me.ReferenciaEstado.ID.STR())
         Else
           R.add("pr_100401058010","")
         End if
         R.add("pr_3004010555333", me.AutorDelAltaTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_100401058063", me.SaldoPromocionalGeneradoAplicadoPorciento.AdaptarMySQL_Decimal())
         If Me.ReferenciaResumenImpuesto2 IsNot nothing then
           R.add("pr_100401058011",me.ReferenciaResumenImpuesto2.ID.STR())
         Else
           R.add("pr_100401058011","")
         End if
         R.add("pr_10040107984", me.CodigoPostalCliente.AdaptarMySQL_String())
         If Me.ReferenciaPuestoDeTrabajo IsNot nothing then
           R.add("pr_100401058012",me.ReferenciaPuestoDeTrabajo.ID.STR())
         Else
           R.add("pr_100401058012","")
         End if
         If Me.ReferenciaUbicacionPrincipal IsNot nothing then
           R.add("pr_3004010555319",me.ReferenciaUbicacionPrincipal.ID.STR())
         Else
           R.add("pr_3004010555319","")
         End if
         R.add("pr_100401058064", me.ImporteSumaImporteDeProductosSinImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_100401058065", me.ImporteDescuentosGeneralImpuesto3.AdaptarMySQL_Decimal())
         R.add("pr_10040107983", me.CIFNIFCliente.AdaptarMySQL_String())
         If Me.ReferenciaNumeracionSerie IsNot nothing then
           R.add("pr_100401058013",me.ReferenciaNumeracionSerie.ID.STR())
         Else
           R.add("pr_100401058013","")
         End if
         R.add("pr_60040107982", me.ProvinciaEmpresa.AdaptarMySQL_String())
         R.add("pr_100401079920", me.DireccionCliente.AdaptarMySQL_String())
         R.add("pr_100401058066", me.ImporteSubtotal.AdaptarMySQL_Decimal())
         If Me.ReferenciaDestinador IsNot nothing then
           R.add("pr_3004010555327",me.ReferenciaDestinador.ID.STR())
         Else
           R.add("pr_3004010555327","")
         End if
         R.add("pr_3004010555322", me.HoraLocal.AdaptarMySQL_Time_Nulable())
         R.add("pr_100401058067", me.ImporteSumaDeConceptosImpuesto1.AdaptarMySQL_Decimal())
         R.add("pr_50040115729", me.ImportePresupuestoDeVentaTotalSinPagoConSaldo.AdaptarMySQL_Decimal())
         R.add("pr_100401058068", me.ImporteCuotaREImpuesto2.AdaptarMySQL_Decimal())
         R.add("pr_10040107986", me.ProvinciaCliente.AdaptarMySQL_String())
         R.add("pr_100401058069", me.ImporteSumaDeConceptosImpuesto3.AdaptarMySQL_Decimal())
         R.add("pr_10040138801", me.TelefonoCliente.AdaptarMySQL_String())
         If Me.ReferenciaDatosFiscalesEmpresa IsNot nothing then
           R.add("pr_10040138802",me.ReferenciaDatosFiscalesEmpresa.ID.STR())
         Else
           R.add("pr_10040138802","")
         End if
         If Me.ReferenciaDatosFiscalesCliente IsNot nothing then
           R.add("pr_10040138803",me.ReferenciaDatosFiscalesCliente.ID.STR())
         Else
           R.add("pr_10040138803","")
         End if
         R.add("pr_500401489611", me.ImporteImporteImpuestoGeneral.AdaptarMySQL_Decimal())
         If Me.ReferenciaImpuestoGeneral IsNot nothing then
           R.add("pr_600401489612",me.ReferenciaImpuestoGeneral.ID.STR())
         Else
           R.add("pr_600401489612","")
         End if
         R.add("pr_50040172141", me.CondicionesDePago.AdaptarMySQL_String())
         R.add("pr_40040176512", me.CondicionDePagoDias.AdaptarMySQL_Integer())
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
