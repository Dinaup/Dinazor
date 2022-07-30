   Imports System.ComponentModel
   Imports DinaNETCore
   Imports DinaNETCore.APID
Partial Public Class SeccionesD
  Public Class VentasListaD
      Public Shared _SeccionID As String = "c59f4af2-da6b-4671-ad4f-8cf2d71c3a73"
      Public Shared _SeccionIDGUID As New Guid("c59f4af2-da6b-4671-ad4f-8cf2d71c3a73")
      Public Shared Async Function ConsultarDatos_Async(Parametros As SeccionConsultaParametrosC) As Task(Of List(Of VentasListaC )) 
          Dim R As New List(Of VentasListaC )  
          Dim d = Await Parametros.DinaupSesion.ConexionServidor.Funcion_Datos_Recibir_Async(VentasListaES._SeccionID, False, Parametros) 
          If d.Datos.TieneDatos Then 
              For Each Actual In d.Datos 
                  Dim Valores_Listador = Actual.Value.Item1
                  Dim Obj_Listador As New VentasListaC 
                  Obj_Listador.CargarDatos(Valores_Listador) 
                  Obj_Listador.CargaInterna(Actual.Value)
                  R.Add(Obj_Listador) 
              Next 
          End If 
          Return R 
      End Function 
      Public Class VentasListaES
          Public shared _SeccionID as Guid = New Guid("c59f4af2-da6b-4671-ad4f-8cf2d71c3a73")
          Public shared _Tabla$ = "tpr_50040105521_e"
      Public Shared FechaAlta_UTC$ = "pr_500401055221"
      Public Shared ImporteDescuentoFijoUnidadDeseado$ = "pr_5004010553163"
      Public Shared ReferenciaEntidadRelacionada$ = "pr_60040105653"
      Public Shared ImporteTotalDescontadoSinImpuestos$ = "pr_5004010553160"
      Public Shared PorcentajeDeImpuestosPorciento$ = "pr_5004010553169"
      Public Shared DescuentoOfertaAplicadoPorciento$ = "pr_5004010553171"
      Public Shared FechaDato_UTC$ = "pr_500401055219"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_500401055226"
      Public Shared DescuentoEntidadAplicadoPorciento$ = "pr_5004010553173"
      Public Shared SaldoPromocionalOfertaAplicadoPorciento$ = "pr_5004010553174"
      Public Shared ImporteImporteFinalTotalDescuentoNoAplicados$ = "pr_5004010553179"
      Public Shared MotivoNoSustitucion$ = "pr_5004010553186"
      Public Shared ReferenciaProducto$ = "pr_5004010553185"
      Public Shared ProductoEsSustitucion$ = "pr_5004010553192"
      Public Shared ModificarDtoAdicionalA$ = "pr_5004010553189"
      Public Shared ImporteSumaSinImpuestos$ = "pr_5004010553200"
      Public Shared DescuentoAdicionalBMotivo$ = "pr_5004010553195"
      Public Shared CantidadMedidaBasePorUnd$ = "pr_5004010553196"
      Public Shared ImporteSaldoPromocionalProducto$ = "pr_5004010553208"
      Public Shared ImporteTotalDescuentosGeneralesSinImpuestos$ = "pr_5004010553206"
      Public Shared ImporteImporteFinalSaldoObtenido$ = "pr_5004010553204"
      Public Shared Cantidad$ = "pr_5004010553107"
      Public Shared ReferenciaAutorDelAlta$ = "pr_500401055218"
      Public Shared DescuentoVIPDeseadoPorciento$ = "pr_5004010553106"
      Public Shared ReferenciaMedida$ = "pr_5004010553108"
      Public Shared ImporteImporteFinalTotal$ = "pr_5004010553104"
      Public Shared SaldoPromocionalOfertaDeseadoPorciento$ = "pr_5004010553116"
      Public Shared ImportePrecioUnidadSinImpuestos$ = "pr_5004010553109"
      Public Shared DescuentoProductoAplicadoPorciento$ = "pr_5004010553110"
      Public Shared ImporteTotalDescuentosProductosSinImpuestos$ = "pr_5004010553120"
      Public Shared SaldoPromocionalGeneralGeneradoAplicadoPorciento$ = "pr_5004010553119"
      Public Shared ImportePrecioMinimo$ = "pr_5004010553140"
      Public Shared ReferenciaLote$ = "pr_5004010553139"
      Public Shared DescuentoGeneralDeseadoPorciento$ = "pr_5004010553133"
      Public Shared ImporteSaldoPromocionalFijoPorUnidadAplicado$ = "pr_5004010553129"
      Public Shared ModificarDtoTipoEntidad$ = "pr_5004010553130"
      Public Shared DescuentoTipoEntidadPorciento$ = "pr_5004010553136"
      Public Shared DescuentoTipoEntidadDeseadoPorciento$ = "pr_5004010553134"
      Public Shared ReferenciaProductoSustituido$ = "pr_5004010553147"
      Public Shared SaldoPromocionalGeneralGeneradoDeseadoPorciento$ = "pr_5004010553141"
      Public Shared ImporteImporteConImpuestos$ = "pr_50040106485"
      Public Shared SaldoPromocionalOfertaMinimoAjustablePorciento$ = "pr_5004010553155"
      Public Shared ModificarDtoEntidad$ = "pr_5004010553153"
      Public Shared CantidadUnidades$ = "pr_500401055359"
      Public Shared ModificarSaldoPromocionalGeneral$ = "pr_500401055358"
      Public Shared ReferenciaElementoReservado$ = "pr_500401055355"
      Public Shared ReferenciaReserva$ = "pr_50040105793"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_500401055217"
      Public Shared DescuentoAdicionalAMotivo$ = "pr_500401055362"
      Public Shared ImporteImporteSinImpuestos$ = "pr_500401055361"
      Public Shared TotalPorcentajeDeDescuentoAplicadoAProductoPorciento$ = "pr_500401055360"
      Public Shared ModificarDtoAdicionalB$ = "pr_500401055371"
      Public Shared ImportePrecioUnidad$ = "pr_500401055369"
      Public Shared DescuentoAdicionalBAplicadoPorciento$ = "pr_500401055368"
      Public Shared ImporteImporteFinalRetencion$ = "pr_500401055379"
      Public Shared HoraLocal$ = "pr_500401055220"
      Public Shared DescuentoEntidadDeseadoPorciento$ = "pr_500401055374"
      Public Shared ReferenciaDestinador$ = "pr_500401055224"
      Public Shared DescuentoVIPAplicadoPorciento$ = "pr_500401055373"
      Public Shared CantidadDeProductosQueDebenDeSalir$ = "pr_500401055381"
      Public Shared ImportePrecioUnidadConImpuestos$ = "pr_50040106486"
      Public Shared DescuentoAdicionalBDeseadoPorciento$ = "pr_500401055383"
      Public Shared ReferenciaImpuesto$ = "pr_500401055380"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_500401055228"
      Public Shared ModificarDtoGeneral$ = "pr_5004010553100"
      Public Shared ModificarDtoVIP$ = "pr_5004010553102"
      Public Shared ReferenciaMovimientoInternoDeInventario$ = "pr_40040106601"
      Public Shared ImporteImporteFinalImpuestos$ = "pr_500401055393"
      Public Shared ImporteDtoFijoPorUnidadAplicado$ = "pr_500401055394"
      Public Shared CantidadDeProductosQuePuedenRectificarse$ = "pr_50040105533"
      Public Shared ReferenciaElementoDePresupuestoDeVenta$ = "pr_50040105792"
      Public Shared ReferenciaTipoMovimiento$ = "pr_50040105535"
      Public Shared PermitirProductosFueraDeCatalogo$ = "pr_50040105531"
      Public Shared ImporteSaldoPromocionalGeneral$ = "pr_50040105532"
      Public Shared ElPrecioIndicadoIncluyeLosImpuestos$ = "pr_500401055313"
      Public Shared DescuentoAdicionalADeseadoPorciento$ = "pr_500401055310"
      Public Shared ReferenciaCatalogo$ = "pr_500401055321"
      Public Shared ReferenciaMedidaBase$ = "pr_500401055319"
      Public Shared ReferenciaProductoNoSustituido$ = "pr_500401055316"
      Public Shared DescuentoProductoDeseadoPorciento$ = "pr_500401055315"
      Public Shared ImporteSaldoPromocionalFijoPorUnidadDeseado$ = "pr_500401055318"
      Public Shared DescuentoOfertaDeseadoPorciento$ = "pr_500401055327"
      Public Shared CantidadUnidadMedidaBase$ = "pr_500401055322"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_500401055216"
      Public Shared MovimientoDeInventarioAutomatico$ = "pr_500401055335"
      Public Shared DescuentoAdicionalAAplicadoPorciento$ = "pr_500401055341"
      Public Shared ReferenciaPresupuestoDeVenta$ = "pr_50040105791"
      Public Shared EvaluarStock$ = "pr_500401055337"
      Public Shared ReferenciaElementoCatalogo$ = "pr_500401055342"
      Public Shared DescuentoGeneralAplicadoPorciento$ = "pr_500401055343"
      Public Shared EntidadRelacionadaTieneAccesoWeb$ = "pr_60040105654"
      Public Shared ImporteSumaConImpuestos$ = "pr_50040106484"
      Public Shared ReferenciaCategoriaDeVenta$ = "pr_50040136172"
      Public Shared ReferenciaElementoDePack$ = "pr_20040148294"
      Public Shared UnidadesDeseadas$ = "pr_100401699816"
      Public Shared ImporteCosteUnd$ = "pr_40040192151"
      Public Shared ImporteCoste$ = "pr_50040192153"
      Public Shared ImporteMargenUnd$ = "pr_50040192151"
      Public Shared ImporteMargen$ = "pr_50040192152"
      Public Shared CantidadDeProductosQueDebenEntrar$ = "pr_40040242012"
      Public Shared TipoDeFactura$ = "pr_60040242001"
      Public Shared ReferenciaRectificandoVenta$ = "pr_30040241991"
      Public Shared ReferenciaRectificandoProductoVendido$ = "pr_20040241993"
      Public Shared ClaveDeOperacionIntracomunitaria$ = "pr_300402429916"
      Public Shared FechaContableDeVenta$ = "pr_30040252082"
      Public Shared ImporteProrrateoBI$ = "pr_40040255193"
      Public Shared ImporteProrrateoIVA$ = "pr_40040255192"
      Public Shared ImporteProrrateoRE$ = "pr_40040255191"
      Public Shared EsUnGastoSuplido$ = "pr_20040256622"
      Public Shared ImporteImporteGastoSuplido$ = "pr_20040256621"
      Public Shared ImporteProrrateoRetencion$ = "pr_10040266802"
      Public Shared ReferenciaActividad$ = "pr_60040281353"
      Public Shared ReferenciaRecurso$ = "pr_20040441201"
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
      Public Shared RelacionElementoContenedorListador$ = "idrelacionlistador"
      Public Shared Listadoreliminado$ = "listadoreliminado"
      End Class
      Public Class VentasListaC
      Inherits Base_DatoC
          <DisplayName("Fecha Alta del registro")>
          Public Property FechaAlta_UTC As Date?
          Public Shared ___FechaAlta_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaAlta_UTC"",""etiqueta"": ""Fecha Alta del registro"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Alta del registro"",""descripcion"": """",""keyword"": ""FechaAlta_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaAlta_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaAlta_UTC
          <Description("Cantidad de descuento fijo que se aplica por cada unidad." & vbCrLf & "(Este es el ""Deseado"", podría modificarse según la configuración de ajustes de descuentos indicada, este valor puede ser distinto al aplicado finalmente)")>
          <DisplayName("Descuento Fijo Unidad (Deseado)")>
          Public Property ImporteDescuentoFijoUnidadDeseado As Decimal
          Public Shared ___ImporteDescuentoFijoUnidadDeseado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentoFijoUnidadDeseado"",""etiqueta"": ""Descuento Fijo Unidad (Deseado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""6"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento Fijo Unidad (Deseado)"",""descripcion"": """",""keyword"": ""ImporteDescuentoFijoUnidadDeseado"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentoFijoUnidadDeseado As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentoFijoUnidadDeseado
          <DisplayName("Entidad Relacionada")>
          Public Property ReferenciaEntidadRelacionada As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaEntidadRelacionada As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaEntidadRelacionada"",""etiqueta"": ""Entidad Relacionada"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Entidad Relacionada"",""descripcion"": """",""keyword"": ""ReferenciaEntidadRelacionada"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaEntidadRelacionada As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaEntidadRelacionada
          <DisplayName("Total Descontado (Sin Impuestos)")>
          Public Property ImporteTotalDescontadoSinImpuestos As Decimal
          Public Shared ___ImporteTotalDescontadoSinImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteTotalDescontadoSinImpuestos"",""etiqueta"": ""Total Descontado (Sin Impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""6"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total Descontado (Sin Impuestos)"",""descripcion"": """",""keyword"": ""ImporteTotalDescontadoSinImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteTotalDescontadoSinImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteTotalDescontadoSinImpuestos
          <DisplayName("Porcentaje de impuestos")>
          Public Property PorcentajeDeImpuestosPorciento As Decimal
          Public Shared ___PorcentajeDeImpuestosPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""PorcentajeDeImpuestosPorciento"",""etiqueta"": ""Porcentaje de impuestos"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Porcentaje de impuestos"",""descripcion"": """",""keyword"": ""PorcentajeDeImpuestosPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __PorcentajeDeImpuestosPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___PorcentajeDeImpuestosPorciento
          <Description("Descuento relacionado a una oferta que se ha aplicado.")>
          <DisplayName("Descuento Oferta % (Aplicado)")>
          Public Property DescuentoOfertaAplicadoPorciento As Decimal
          Public Shared ___DescuentoOfertaAplicadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoOfertaAplicadoPorciento"",""etiqueta"": ""Descuento Oferta % (Aplicado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento Oferta % (Aplicado)"",""descripcion"": """",""keyword"": ""DescuentoOfertaAplicadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoOfertaAplicadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoOfertaAplicadoPorciento
          <DisplayName("Fecha Dato")>
          Public Property FechaDato_UTC As Date?
          Public Shared ___FechaDato_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaDato_UTC"",""etiqueta"": ""Fecha Dato"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Dato"",""descripcion"": """",""keyword"": ""FechaDato_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaDato_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaDato_UTC
          <DisplayName("Empleado Tiene Acceso web")>
          Public Property EmpleadoTieneAccesoWeb As Boolean
          Public Shared ___EmpleadoTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EmpleadoTieneAccesoWeb"",""etiqueta"": ""Empleado Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empleado Tiene Acceso web"",""descripcion"": """",""keyword"": ""EmpleadoTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EmpleadoTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___EmpleadoTieneAccesoWeb
          <Description("Descuento relacionado con la entidad que se ha aplicado.")>
          <DisplayName("Descuento Entidad % (Aplicado)")>
          Public Property DescuentoEntidadAplicadoPorciento As Decimal
          Public Shared ___DescuentoEntidadAplicadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoEntidadAplicadoPorciento"",""etiqueta"": ""Descuento Entidad % (Aplicado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento Entidad % (Aplicado)"",""descripcion"": """",""keyword"": ""DescuentoEntidadAplicadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoEntidadAplicadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoEntidadAplicadoPorciento
          <Description("Porcentaje de saldo promocional que se obtendrá por una oferta.")>
          <DisplayName("Saldo promocional Oferta % (Aplicado)")>
          Public Property SaldoPromocionalOfertaAplicadoPorciento As Decimal
          Public Shared ___SaldoPromocionalOfertaAplicadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""SaldoPromocionalOfertaAplicadoPorciento"",""etiqueta"": ""Saldo promocional Oferta % (Aplicado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Saldo promocional Oferta % (Aplicado)"",""descripcion"": """",""keyword"": ""SaldoPromocionalOfertaAplicadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __SaldoPromocionalOfertaAplicadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___SaldoPromocionalOfertaAplicadoPorciento
          <DisplayName("Importe Final - Total descuento no aplicados")>
          Public Property ImporteImporteFinalTotalDescuentoNoAplicados As Decimal
          Public Shared ___ImporteImporteFinalTotalDescuentoNoAplicados As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteImporteFinalTotalDescuentoNoAplicados"",""etiqueta"": ""Importe Final - Total descuento no aplicados"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""6"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Importe Final - Total descuento no aplicados"",""descripcion"": """",""keyword"": ""ImporteImporteFinalTotalDescuentoNoAplicados"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteImporteFinalTotalDescuentoNoAplicados As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteImporteFinalTotalDescuentoNoAplicados
          <Description("Motivo que ha dado el cliente por el que no ha deseado realizar la sustitución del producto por el recomendado.")>
          <DisplayName("Motivo no sustitución")>
          Public Property MotivoNoSustitucion As String
          Public Shared ___MotivoNoSustitucion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""MotivoNoSustitucion"",""etiqueta"": ""Motivo no sustitución"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Motivo no sustitución"",""descripcion"": """",""keyword"": ""MotivoNoSustitucion"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __MotivoNoSustitucion As DinaNETCore.APID.DinaupAPI_CampoC = ___MotivoNoSustitucion
          <DisplayName("Producto")>
          Public Property ReferenciaProducto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaProducto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaProducto"",""etiqueta"": ""Producto"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""e28959bb-b7f1-4558-9e8a-4048e6c5f51a"",""titulo"": ""Base - Productos"",""iconoid"": ""21a04b44-ad38-44e0-a63a-98951da57cfa"",""etiquetasingular"": ""Producto"",""etiquetaplural"": ""Productos"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""e28959bb-b7f1-4558-9e8a-4048e6c5f51a"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Producto"",""descripcion"": """",""keyword"": ""ReferenciaProducto"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaProducto As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaProducto
          <Description("Indica si el producto seleccionado ha sido una sustitución.")>
          <DisplayName("Producto es sustitución")>
          Public Property ProductoEsSustitucion As Boolean
          Public Shared ___ProductoEsSustitucion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ProductoEsSustitucion"",""etiqueta"": ""Producto es sustitución"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Producto es sustitución"",""descripcion"": """",""keyword"": ""ProductoEsSustitucion"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ProductoEsSustitucion As DinaNETCore.APID.DinaupAPI_CampoC = ___ProductoEsSustitucion
          <DisplayName("Modificar Dto. Adicional A")>
          Public Property ModificarDtoAdicionalA As Boolean
          Public Shared ___ModificarDtoAdicionalA As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ModificarDtoAdicionalA"",""etiqueta"": ""Modificar Dto. Adicional A"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Modificar Dto. Adicional A"",""descripcion"": """",""keyword"": ""ModificarDtoAdicionalA"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ModificarDtoAdicionalA As DinaNETCore.APID.DinaupAPI_CampoC = ___ModificarDtoAdicionalA
          <DisplayName("Suma (Sin Impuestos)")>
          Public Property ImporteSumaSinImpuestos As Decimal
          Public Shared ___ImporteSumaSinImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSumaSinImpuestos"",""etiqueta"": ""Suma (Sin Impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Suma (Sin Impuestos)"",""descripcion"": """",""keyword"": ""ImporteSumaSinImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSumaSinImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSumaSinImpuestos
          <Description("Descripción que indica el motivo del descuento adicional configurable.")>
          <DisplayName("Descuento Adicional B Motivo")>
          Public Property DescuentoAdicionalBMotivo As String
          Public Shared ___DescuentoAdicionalBMotivo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoAdicionalBMotivo"",""etiqueta"": ""Descuento Adicional B Motivo"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento Adicional B Motivo"",""descripcion"": """",""keyword"": ""DescuentoAdicionalBMotivo"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoAdicionalBMotivo As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoAdicionalBMotivo
          <DisplayName("Cantidad (Medida Base Por Und.)")>
          Public Property CantidadMedidaBasePorUnd As Decimal
          Public Shared ___CantidadMedidaBasePorUnd As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CantidadMedidaBasePorUnd"",""etiqueta"": ""Cantidad (Medida Base Por Und.)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""11"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cantidad (Medida Base Por Und.)"",""descripcion"": """",""keyword"": ""CantidadMedidaBasePorUnd"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CantidadMedidaBasePorUnd As DinaNETCore.APID.DinaupAPI_CampoC = ___CantidadMedidaBasePorUnd
          <DisplayName("Saldo promocional (Producto)")>
          Public Property ImporteSaldoPromocionalProducto As Decimal
          Public Shared ___ImporteSaldoPromocionalProducto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSaldoPromocionalProducto"",""etiqueta"": ""Saldo promocional (Producto)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Saldo promocional (Producto)"",""descripcion"": """",""keyword"": ""ImporteSaldoPromocionalProducto"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSaldoPromocionalProducto As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSaldoPromocionalProducto
          <DisplayName("Total Descuentos (Generales) (Sin Impuestos)")>
          Public Property ImporteTotalDescuentosGeneralesSinImpuestos As Decimal
          Public Shared ___ImporteTotalDescuentosGeneralesSinImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteTotalDescuentosGeneralesSinImpuestos"",""etiqueta"": ""Total Descuentos (Generales) (Sin Impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""6"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total Descuentos (Generales) (Sin Impuestos)"",""descripcion"": """",""keyword"": ""ImporteTotalDescuentosGeneralesSinImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteTotalDescuentosGeneralesSinImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteTotalDescuentosGeneralesSinImpuestos
          <Description("Saldo obtenido")>
          <DisplayName("Importe Final - Saldo obtenido")>
          Public Property ImporteImporteFinalSaldoObtenido As Decimal
          Public Shared ___ImporteImporteFinalSaldoObtenido As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteImporteFinalSaldoObtenido"",""etiqueta"": ""Importe Final - Saldo obtenido"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Importe Final - Saldo obtenido"",""descripcion"": """",""keyword"": ""ImporteImporteFinalSaldoObtenido"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteImporteFinalSaldoObtenido As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteImporteFinalSaldoObtenido
          <Description("Cantidad de productos o cantidad de la medida seleccionada.")>
          <DisplayName("Cantidad")>
          Public Property Cantidad As Decimal
          Public Shared ___Cantidad As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Cantidad"",""etiqueta"": ""Cantidad"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""11"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": false,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cantidad"",""descripcion"": """",""keyword"": ""Cantidad"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Cantidad As DinaNETCore.APID.DinaupAPI_CampoC = ___Cantidad
          <DisplayName("Autor del alta")>
          Public Property ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaAutorDelAlta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaAutorDelAlta"",""etiqueta"": ""Autor del alta"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta"",""descripcion"": """",""keyword"": ""ReferenciaAutorDelAlta"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaAutorDelAlta
          <Description("Descuento especial que se marca en la ficha de la entidad receptora de la transacción." & vbCrLf & "(Este es el ""Deseado"", podría modificarse según la configuración de ajustes de descuentos indicada, este valor puede ser distinto al aplicado finalmente)")>
          <DisplayName("Descuento V.I.P % (Deseado)")>
          Public Property DescuentoVIPDeseadoPorciento As Decimal
          Public Shared ___DescuentoVIPDeseadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoVIPDeseadoPorciento"",""etiqueta"": ""Descuento V.I.P % (Deseado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento V.I.P % (Deseado)"",""descripcion"": """",""keyword"": ""DescuentoVIPDeseadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoVIPDeseadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoVIPDeseadoPorciento
          <DisplayName("Medida")>
          Public Property ReferenciaMedida As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaMedida As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaMedida"",""etiqueta"": ""Medida"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c84f0381-d030-4223-a4e1-da78dda62ab4"",""titulo"": ""Base - Unidades de medida"",""iconoid"": ""0323688b-82a5-4fb7-a9f5-ff1247a52998"",""etiquetasingular"": ""Unidad de medida"",""etiquetaplural"": ""Unidades de medida"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""c84f0381-d030-4223-a4e1-da78dda62ab4"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Medida"",""descripcion"": """",""keyword"": ""ReferenciaMedida"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaMedida As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaMedida
          <Description("Importe a pagar por el producto")>
          <DisplayName("Importe Final - Total")>
          Public Property ImporteImporteFinalTotal As Decimal
          Public Shared ___ImporteImporteFinalTotal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteImporteFinalTotal"",""etiqueta"": ""Importe Final - Total"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""10"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Importe Final - Total"",""descripcion"": """",""keyword"": ""ImporteImporteFinalTotal"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteImporteFinalTotal As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteImporteFinalTotal
          <Description("Porcentaje de saldo promocional que se obtendrá por una oferta." & vbCrLf & "(Este es el ""Deseado"", podría modificarse según la configuración de ajustes de bonificaciones indicada, este valor puede ser distinto al aplicado finalmente)")>
          <DisplayName("Saldo promocional Oferta % (Deseado)")>
          Public Property SaldoPromocionalOfertaDeseadoPorciento As Decimal
          Public Shared ___SaldoPromocionalOfertaDeseadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""SaldoPromocionalOfertaDeseadoPorciento"",""etiqueta"": ""Saldo promocional Oferta % (Deseado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Saldo promocional Oferta % (Deseado)"",""descripcion"": """",""keyword"": ""SaldoPromocionalOfertaDeseadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __SaldoPromocionalOfertaDeseadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___SaldoPromocionalOfertaDeseadoPorciento
          <Description("Precio por unidad sin impuestos")>
          <DisplayName("Precio unidad (Sin impuestos)")>
          Public Property ImportePrecioUnidadSinImpuestos As Decimal
          Public Shared ___ImportePrecioUnidadSinImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImportePrecioUnidadSinImpuestos"",""etiqueta"": ""Precio unidad (Sin impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""6"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Precio unidad (Sin impuestos)"",""descripcion"": """",""keyword"": ""ImportePrecioUnidadSinImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImportePrecioUnidadSinImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImportePrecioUnidadSinImpuestos
          <Description("Porcentaje de descuento en relación al producto seleccionado.")>
          <DisplayName("Descuento Producto % (Aplicado)")>
          Public Property DescuentoProductoAplicadoPorciento As Decimal
          Public Shared ___DescuentoProductoAplicadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoProductoAplicadoPorciento"",""etiqueta"": ""Descuento Producto % (Aplicado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento Producto % (Aplicado)"",""descripcion"": """",""keyword"": ""DescuentoProductoAplicadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoProductoAplicadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoProductoAplicadoPorciento
          <DisplayName("Total Descuentos (Productos) (Sin Impuestos)")>
          Public Property ImporteTotalDescuentosProductosSinImpuestos As Decimal
          Public Shared ___ImporteTotalDescuentosProductosSinImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteTotalDescuentosProductosSinImpuestos"",""etiqueta"": ""Total Descuentos (Productos) (Sin Impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total Descuentos (Productos) (Sin Impuestos)"",""descripcion"": """",""keyword"": ""ImporteTotalDescuentosProductosSinImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteTotalDescuentosProductosSinImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteTotalDescuentosProductosSinImpuestos
          <Description("El porcentaje de saldo obtenido por esta transacción.")>
          <DisplayName("Saldo promocional General generado % (Aplicado)")>
          Public Property SaldoPromocionalGeneralGeneradoAplicadoPorciento As Decimal
          Public Shared ___SaldoPromocionalGeneralGeneradoAplicadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""SaldoPromocionalGeneralGeneradoAplicadoPorciento"",""etiqueta"": ""Saldo promocional General generado % (Aplicado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Saldo promocional General generado % (Aplicado)"",""descripcion"": """",""keyword"": ""SaldoPromocionalGeneralGeneradoAplicadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __SaldoPromocionalGeneralGeneradoAplicadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___SaldoPromocionalGeneralGeneradoAplicadoPorciento
          <Description("El precio mínimo por el que se puede vender este producto.")>
          <DisplayName("Precio mínimo")>
          Public Property ImportePrecioMinimo As Decimal
          Public Shared ___ImportePrecioMinimo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImportePrecioMinimo"",""etiqueta"": ""Precio mínimo"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""6"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Precio mínimo"",""descripcion"": """",""keyword"": ""ImportePrecioMinimo"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImportePrecioMinimo As DinaNETCore.APID.DinaupAPI_CampoC = ___ImportePrecioMinimo
          <Description("Lote asociado a esta transacción.")>
          <DisplayName("Lote")>
          Public Property ReferenciaLote As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaLote As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaLote"",""etiqueta"": ""Lote"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""a158c0a1-f824-44e6-b807-43584e53a5b4"",""titulo"": ""Base - Lotes de productos"",""iconoid"": ""dde28ea3-d0eb-4b04-9e2f-c9e44247be3d"",""etiquetasingular"": ""Lote de producto"",""etiquetaplural"": ""Lotes de producto"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""a158c0a1-f824-44e6-b807-43584e53a5b4"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Lote"",""descripcion"": """",""keyword"": ""ReferenciaLote"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaLote As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaLote
          <Description("Descuento general indicado para esta transacción." & vbCrLf & "(Este es el ""Deseado"", podría modificarse según la configuración de ajustes de descuentos indicada, este valor puede ser distinto al aplicado finalmente)")>
          <DisplayName("Descuento General % (Deseado)")>
          Public Property DescuentoGeneralDeseadoPorciento As Decimal
          Public Shared ___DescuentoGeneralDeseadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoGeneralDeseadoPorciento"",""etiqueta"": ""Descuento General % (Deseado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento General % (Deseado)"",""descripcion"": """",""keyword"": ""DescuentoGeneralDeseadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoGeneralDeseadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoGeneralDeseadoPorciento
          <Description("Cantidad de Saldo promocional fijo que se ofrecerá con este producto.")>
          <DisplayName("Saldo promocional Fijo por unidad (Aplicado)")>
          Public Property ImporteSaldoPromocionalFijoPorUnidadAplicado As Decimal
          Public Shared ___ImporteSaldoPromocionalFijoPorUnidadAplicado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSaldoPromocionalFijoPorUnidadAplicado"",""etiqueta"": ""Saldo promocional Fijo por unidad (Aplicado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""6"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Saldo promocional Fijo por unidad (Aplicado)"",""descripcion"": """",""keyword"": ""ImporteSaldoPromocionalFijoPorUnidadAplicado"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSaldoPromocionalFijoPorUnidadAplicado As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSaldoPromocionalFijoPorUnidadAplicado
          <DisplayName("Modificar Dto. Tipo Entidad")>
          Public Property ModificarDtoTipoEntidad As Boolean
          Public Shared ___ModificarDtoTipoEntidad As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ModificarDtoTipoEntidad"",""etiqueta"": ""Modificar Dto. Tipo Entidad"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Modificar Dto. Tipo Entidad"",""descripcion"": """",""keyword"": ""ModificarDtoTipoEntidad"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ModificarDtoTipoEntidad As DinaNETCore.APID.DinaupAPI_CampoC = ___ModificarDtoTipoEntidad
          <Description("Descuento configurado en el tipo de entidad.")>
          <DisplayName("Descuento tipo entidad %")>
          Public Property DescuentoTipoEntidadPorciento As Decimal
          Public Shared ___DescuentoTipoEntidadPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoTipoEntidadPorciento"",""etiqueta"": ""Descuento tipo entidad %"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento tipo entidad %"",""descripcion"": """",""keyword"": ""DescuentoTipoEntidadPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoTipoEntidadPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoTipoEntidadPorciento
          <Description("Descuento indicado en la configuración del tipo de entidad." & vbCrLf & "(Este es el ""Deseado"", podría modificarse según la configuración de ajustes de descuentos indicada)")>
          <DisplayName("Descuento tipo entidad % (Deseado)")>
          Public Property DescuentoTipoEntidadDeseadoPorciento As Decimal
          Public Shared ___DescuentoTipoEntidadDeseadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoTipoEntidadDeseadoPorciento"",""etiqueta"": ""Descuento tipo entidad % (Deseado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento tipo entidad % (Deseado)"",""descripcion"": """",""keyword"": ""DescuentoTipoEntidadDeseadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoTipoEntidadDeseadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoTipoEntidadDeseadoPorciento
          <DisplayName("Producto sustituido")>
          Public Property ReferenciaProductoSustituido As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaProductoSustituido As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaProductoSustituido"",""etiqueta"": ""Producto sustituido"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""e28959bb-b7f1-4558-9e8a-4048e6c5f51a"",""titulo"": ""Base - Productos"",""iconoid"": ""21a04b44-ad38-44e0-a63a-98951da57cfa"",""etiquetasingular"": ""Producto"",""etiquetaplural"": ""Productos"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""e28959bb-b7f1-4558-9e8a-4048e6c5f51a"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Producto sustituido"",""descripcion"": """",""keyword"": ""ReferenciaProductoSustituido"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaProductoSustituido As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaProductoSustituido
          <Description("El porcentaje de saldo obtenido por esta transacción." & vbCrLf & "Descuento adicional configurable." & vbCrLf & "(Este es el ""Deseado"", podría modificarse según la configuración de ajustes de bonificaciones indicada y podría diferir del valor aplicado finalmente)")>
          <DisplayName("Saldo promocional General generado % (Deseado)")>
          Public Property SaldoPromocionalGeneralGeneradoDeseadoPorciento As Decimal
          Public Shared ___SaldoPromocionalGeneralGeneradoDeseadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""SaldoPromocionalGeneralGeneradoDeseadoPorciento"",""etiqueta"": ""Saldo promocional General generado % (Deseado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Saldo promocional General generado % (Deseado)"",""descripcion"": """",""keyword"": ""SaldoPromocionalGeneralGeneradoDeseadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __SaldoPromocionalGeneralGeneradoDeseadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___SaldoPromocionalGeneralGeneradoDeseadoPorciento
          <DisplayName("Importe (Con Impuestos)")>
          Public Property ImporteImporteConImpuestos As Decimal
          Public Shared ___ImporteImporteConImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteImporteConImpuestos"",""etiqueta"": ""Importe (Con Impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""10"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Importe (Con Impuestos)"",""descripcion"": """",""keyword"": ""ImporteImporteConImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteImporteConImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteImporteConImpuestos
          <Description("Porcentaje de saldo promocional mínimo que se ajustará por una oferta.")>
          <DisplayName("Saldo Promocional Oferta Mínimo Ajustable %")>
          Public Property SaldoPromocionalOfertaMinimoAjustablePorciento As Decimal
          Public Shared ___SaldoPromocionalOfertaMinimoAjustablePorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""SaldoPromocionalOfertaMinimoAjustablePorciento"",""etiqueta"": ""Saldo Promocional Oferta Mínimo Ajustable %"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Saldo Promocional Oferta Mínimo Ajustable %"",""descripcion"": """",""keyword"": ""SaldoPromocionalOfertaMinimoAjustablePorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __SaldoPromocionalOfertaMinimoAjustablePorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___SaldoPromocionalOfertaMinimoAjustablePorciento
          <DisplayName("Modificar Dto. Entidad")>
          Public Property ModificarDtoEntidad As Boolean
          Public Shared ___ModificarDtoEntidad As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ModificarDtoEntidad"",""etiqueta"": ""Modificar Dto. Entidad"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Modificar Dto. Entidad"",""descripcion"": """",""keyword"": ""ModificarDtoEntidad"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ModificarDtoEntidad As DinaNETCore.APID.DinaupAPI_CampoC = ___ModificarDtoEntidad
          <DisplayName("Cantidad (Unidades)")>
          Public Property CantidadUnidades As Decimal
          Public Shared ___CantidadUnidades As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CantidadUnidades"",""etiqueta"": ""Cantidad (Unidades)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""11"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cantidad (Unidades)"",""descripcion"": """",""keyword"": ""CantidadUnidades"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CantidadUnidades As DinaNETCore.APID.DinaupAPI_CampoC = ___CantidadUnidades
          <DisplayName("Modificar Saldo promocional General")>
          Public Property ModificarSaldoPromocionalGeneral As Boolean
          Public Shared ___ModificarSaldoPromocionalGeneral As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ModificarSaldoPromocionalGeneral"",""etiqueta"": ""Modificar Saldo promocional General"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Modificar Saldo promocional General"",""descripcion"": """",""keyword"": ""ModificarSaldoPromocionalGeneral"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ModificarSaldoPromocionalGeneral As DinaNETCore.APID.DinaupAPI_CampoC = ___ModificarSaldoPromocionalGeneral
          <DisplayName("Elemento Reservado")>
          Public Property ReferenciaElementoReservado As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaElementoReservado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaElementoReservado"",""etiqueta"": ""Elemento Reservado"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""8048c3c1-5098-4a20-87dc-8fff3f08b855"",""titulo"": ""Base Lista - Reservas"",""iconoid"": ""ec24fd6c-b7a9-47eb-a472-0ef0defda086"",""etiquetasingular"": ""Producto reservado"",""etiquetaplural"": ""Productos reservados"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": true,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""8048c3c1-5098-4a20-87dc-8fff3f08b855"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Elemento Reservado"",""descripcion"": """",""keyword"": ""ReferenciaElementoReservado"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaElementoReservado As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaElementoReservado
          <DisplayName("Reserva")>
          Public Property ReferenciaReserva As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaReserva As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaReserva"",""etiqueta"": ""Reserva"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""218c713e-9eb1-4abd-93ae-2aa44a83adb7"",""titulo"": ""Base - Reservas"",""iconoid"": ""51822e7b-2d6f-4193-bff6-57a07cdcd886"",""etiquetasingular"": ""Reserva"",""etiquetaplural"": ""Reservas"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""218c713e-9eb1-4abd-93ae-2aa44a83adb7"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Reserva"",""descripcion"": """",""keyword"": ""ReferenciaReserva"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaReserva As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaReserva
          <DisplayName("Ubicación Principal")>
          Public Property ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaUbicacionPrincipal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaUbicacionPrincipal"",""etiqueta"": ""Ubicación Principal"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""b9adbfbf-a81a-45fb-861c-90502902c982"",""titulo"": ""Ubicaciones"",""iconoid"": ""b985b58f-7275-46b8-9b66-2c54346b0185"",""etiquetasingular"": ""Ubicación"",""etiquetaplural"": ""Ubicaciones"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""b9adbfbf-a81a-45fb-861c-90502902c982"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Ubicación Principal"",""descripcion"": """",""keyword"": ""ReferenciaUbicacionPrincipal"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaUbicacionPrincipal
          <Description("Descripción que indica el motivo del descuento adicional configurable.")>
          <DisplayName("Descuento Adicional A Motivo")>
          Public Property DescuentoAdicionalAMotivo As String
          Public Shared ___DescuentoAdicionalAMotivo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoAdicionalAMotivo"",""etiqueta"": ""Descuento Adicional A Motivo"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento Adicional A Motivo"",""descripcion"": """",""keyword"": ""DescuentoAdicionalAMotivo"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoAdicionalAMotivo As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoAdicionalAMotivo
          <Description("Precio total de venta, sin descuentos generales aplicados ni impuestos.")>
          <DisplayName("Importe (Sin impuestos)")>
          Public Property ImporteImporteSinImpuestos As Decimal
          Public Shared ___ImporteImporteSinImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteImporteSinImpuestos"",""etiqueta"": ""Importe (Sin impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Importe (Sin impuestos)"",""descripcion"": """",""keyword"": ""ImporteImporteSinImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteImporteSinImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteImporteSinImpuestos
          <DisplayName("Total Porcentaje de descuento aplicado a producto")>
          Public Property TotalPorcentajeDeDescuentoAplicadoAProductoPorciento As Decimal
          Public Shared ___TotalPorcentajeDeDescuentoAplicadoAProductoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TotalPorcentajeDeDescuentoAplicadoAProductoPorciento"",""etiqueta"": ""Total Porcentaje de descuento aplicado a producto"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total Porcentaje de descuento aplicado a producto"",""descripcion"": """",""keyword"": ""TotalPorcentajeDeDescuentoAplicadoAProductoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __TotalPorcentajeDeDescuentoAplicadoAProductoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___TotalPorcentajeDeDescuentoAplicadoAProductoPorciento
          <DisplayName("Modificar Dto. Adicional B")>
          Public Property ModificarDtoAdicionalB As Boolean
          Public Shared ___ModificarDtoAdicionalB As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ModificarDtoAdicionalB"",""etiqueta"": ""Modificar Dto. Adicional B"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Modificar Dto. Adicional B"",""descripcion"": """",""keyword"": ""ModificarDtoAdicionalB"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ModificarDtoAdicionalB As DinaNETCore.APID.DinaupAPI_CampoC = ___ModificarDtoAdicionalB
          <DisplayName("Precio unidad")>
          Public Property ImportePrecioUnidad As Decimal
          Public Shared ___ImportePrecioUnidad As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImportePrecioUnidad"",""etiqueta"": ""Precio unidad"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""6"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Precio unidad"",""descripcion"": """",""keyword"": ""ImportePrecioUnidad"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImportePrecioUnidad As DinaNETCore.APID.DinaupAPI_CampoC = ___ImportePrecioUnidad
          <Description("Porcentaje de descuento adicional B que se ha aplicado.")>
          <DisplayName("Descuento Adicional B % (Aplicado)")>
          Public Property DescuentoAdicionalBAplicadoPorciento As Decimal
          Public Shared ___DescuentoAdicionalBAplicadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoAdicionalBAplicadoPorciento"",""etiqueta"": ""Descuento Adicional B % (Aplicado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento Adicional B % (Aplicado)"",""descripcion"": """",""keyword"": ""DescuentoAdicionalBAplicadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoAdicionalBAplicadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoAdicionalBAplicadoPorciento
          <DisplayName("Importe Final - Retención")>
          Public Property ImporteImporteFinalRetencion As Decimal
          Public Shared ___ImporteImporteFinalRetencion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteImporteFinalRetencion"",""etiqueta"": ""Importe Final - Retención"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""6"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Importe Final - Retención"",""descripcion"": """",""keyword"": ""ImporteImporteFinalRetencion"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteImporteFinalRetencion As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteImporteFinalRetencion
          <DisplayName("Hora local")>
          Public Property HoraLocal As DateTime?
          Public Shared ___HoraLocal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""HoraLocal"",""etiqueta"": ""Hora local"",""oculta"": false,""formato"": 8,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Hora local"",""descripcion"": """",""keyword"": ""HoraLocal"",""formato"": 8,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __HoraLocal As DinaNETCore.APID.DinaupAPI_CampoC = ___HoraLocal
          <Description("Descuento relacionado con la entidad indicada." & vbCrLf & "(Este es el ""Deseado"", podría modificarse según la configuración de ajustes de descuentos indicada, este valor puede ser distinto al aplicado finalmente)")>
          <DisplayName("Descuento Entidad % (Deseado)")>
          Public Property DescuentoEntidadDeseadoPorciento As Decimal
          Public Shared ___DescuentoEntidadDeseadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoEntidadDeseadoPorciento"",""etiqueta"": ""Descuento Entidad % (Deseado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento Entidad % (Deseado)"",""descripcion"": """",""keyword"": ""DescuentoEntidadDeseadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoEntidadDeseadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoEntidadDeseadoPorciento
          <DisplayName("Destinador")>
          Public Property ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaDestinador As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaDestinador"",""etiqueta"": ""Destinador"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""relacionesindirectas"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Destinador"",""descripcion"": """",""keyword"": ""ReferenciaDestinador"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaDestinador
          <Description("Porcentaje de descuento V.I.P que se ha aplicado.")>
          <DisplayName("Descuento V.I.P % (Aplicado)")>
          Public Property DescuentoVIPAplicadoPorciento As Decimal
          Public Shared ___DescuentoVIPAplicadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoVIPAplicadoPorciento"",""etiqueta"": ""Descuento V.I.P % (Aplicado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento V.I.P % (Aplicado)"",""descripcion"": """",""keyword"": ""DescuentoVIPAplicadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoVIPAplicadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoVIPAplicadoPorciento
          <DisplayName("Cantidad de productos que deben de salir")>
          Public Property CantidadDeProductosQueDebenDeSalir As Decimal
          Public Shared ___CantidadDeProductosQueDebenDeSalir As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CantidadDeProductosQueDebenDeSalir"",""etiqueta"": ""Cantidad de productos que deben de salir"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""11"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cantidad de productos que deben de salir"",""descripcion"": """",""keyword"": ""CantidadDeProductosQueDebenDeSalir"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CantidadDeProductosQueDebenDeSalir As DinaNETCore.APID.DinaupAPI_CampoC = ___CantidadDeProductosQueDebenDeSalir
          <DisplayName("Precio Unidad (Con Impuestos)")>
          Public Property ImportePrecioUnidadConImpuestos As Decimal
          Public Shared ___ImportePrecioUnidadConImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImportePrecioUnidadConImpuestos"",""etiqueta"": ""Precio Unidad (Con Impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""10"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Precio Unidad (Con Impuestos)"",""descripcion"": """",""keyword"": ""ImportePrecioUnidadConImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImportePrecioUnidadConImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImportePrecioUnidadConImpuestos
          <Description("Descuento adicional configurable." & vbCrLf & "(Este es el ""Deseado"", podría modificarse según la configuración de ajustes de descuentos indicada y podría diferir del descuento aplicado finalmente)")>
          <DisplayName("Descuento Adicional B % (Deseado)")>
          Public Property DescuentoAdicionalBDeseadoPorciento As Decimal
          Public Shared ___DescuentoAdicionalBDeseadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoAdicionalBDeseadoPorciento"",""etiqueta"": ""Descuento Adicional B % (Deseado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento Adicional B % (Deseado)"",""descripcion"": """",""keyword"": ""DescuentoAdicionalBDeseadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoAdicionalBDeseadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoAdicionalBDeseadoPorciento
          <DisplayName("Impuesto")>
          Public Property ReferenciaImpuesto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaImpuesto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaImpuesto"",""etiqueta"": ""Impuesto"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""f3199ee0-dc83-4667-a9c1-f3b04e97a8a4"",""titulo"": ""Base - Impuestos"",""iconoid"": ""ff4a7189-6426-43b9-bdc4-070314999e81"",""etiquetasingular"": ""Impuesto"",""etiquetaplural"": ""Impuestos"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""f3199ee0-dc83-4667-a9c1-f3b04e97a8a4"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Impuesto"",""descripcion"": """",""keyword"": ""ReferenciaImpuesto"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaImpuesto As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaImpuesto
          <DisplayName("Autor del alta Tiene Acceso web")>
          Public Property AutorDelAltaTieneAccesoWeb As Boolean
          Public Shared ___AutorDelAltaTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AutorDelAltaTieneAccesoWeb"",""etiqueta"": ""Autor del alta Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta Tiene Acceso web"",""descripcion"": """",""keyword"": ""AutorDelAltaTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AutorDelAltaTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___AutorDelAltaTieneAccesoWeb
          <DisplayName("Modificar Dto. General")>
          Public Property ModificarDtoGeneral As Boolean
          Public Shared ___ModificarDtoGeneral As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ModificarDtoGeneral"",""etiqueta"": ""Modificar Dto. General"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Modificar Dto. General"",""descripcion"": """",""keyword"": ""ModificarDtoGeneral"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ModificarDtoGeneral As DinaNETCore.APID.DinaupAPI_CampoC = ___ModificarDtoGeneral
          <DisplayName("Modificar Dto. V.I.P")>
          Public Property ModificarDtoVIP As Boolean
          Public Shared ___ModificarDtoVIP As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ModificarDtoVIP"",""etiqueta"": ""Modificar Dto. V.I.P"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Modificar Dto. V.I.P"",""descripcion"": """",""keyword"": ""ModificarDtoVIP"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ModificarDtoVIP As DinaNETCore.APID.DinaupAPI_CampoC = ___ModificarDtoVIP
          <DisplayName("Movimiento interno de inventario")>
          Public Property ReferenciaMovimientoInternoDeInventario As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaMovimientoInternoDeInventario As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaMovimientoInternoDeInventario"",""etiqueta"": ""Movimiento interno de inventario"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""7c7f78fd-56d0-4030-b85a-d57e5ffd98cd"",""titulo"": ""Movimiento interno de inventario (Compra-Venta)"",""iconoid"": ""33d43c2b-a516-4975-9eda-e54195f74732"",""etiquetasingular"": ""Movimiento interno de inventario"",""etiquetaplural"": ""Movimientos internos de inventario"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""7c7f78fd-56d0-4030-b85a-d57e5ffd98cd"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Movimiento interno de inventario"",""descripcion"": """",""keyword"": ""ReferenciaMovimientoInternoDeInventario"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaMovimientoInternoDeInventario As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaMovimientoInternoDeInventario
          <DisplayName("Importe Final - Impuestos")>
          Public Property ImporteImporteFinalImpuestos As Decimal
          Public Shared ___ImporteImporteFinalImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteImporteFinalImpuestos"",""etiqueta"": ""Importe Final - Impuestos"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""6"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Importe Final - Impuestos"",""descripcion"": """",""keyword"": ""ImporteImporteFinalImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteImporteFinalImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteImporteFinalImpuestos
          <Description("Cantidad de descuento fijo que se aplica por cada unidad.")>
          <DisplayName("Dto. fijo por unidad (Aplicado)")>
          Public Property ImporteDtoFijoPorUnidadAplicado As Decimal
          Public Shared ___ImporteDtoFijoPorUnidadAplicado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDtoFijoPorUnidadAplicado"",""etiqueta"": ""Dto. fijo por unidad (Aplicado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""6"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Dto. fijo por unidad (Aplicado)"",""descripcion"": """",""keyword"": ""ImporteDtoFijoPorUnidadAplicado"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDtoFijoPorUnidadAplicado As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDtoFijoPorUnidadAplicado
          <DisplayName("Cantidad de productos que pueden rectificarse")>
          Public Property CantidadDeProductosQuePuedenRectificarse As Decimal
          Public Shared ___CantidadDeProductosQuePuedenRectificarse As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CantidadDeProductosQuePuedenRectificarse"",""etiqueta"": ""Cantidad de productos que pueden rectificarse"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""11"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cantidad de productos que pueden rectificarse"",""descripcion"": """",""keyword"": ""CantidadDeProductosQuePuedenRectificarse"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CantidadDeProductosQuePuedenRectificarse As DinaNETCore.APID.DinaupAPI_CampoC = ___CantidadDeProductosQuePuedenRectificarse
          <DisplayName("Elemento de presupuesto de venta")>
          Public Property ReferenciaElementoDePresupuestoDeVenta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaElementoDePresupuestoDeVenta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaElementoDePresupuestoDeVenta"",""etiqueta"": ""Elemento de presupuesto de venta"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""1334f04e-4478-42ba-81df-50029387b99a"",""titulo"": ""Base Lista - Presupuestos de venta"",""iconoid"": """",""etiquetasingular"": ""Producto de presupuesto de venta"",""etiquetaplural"": ""Productos de presupuesto de venta"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": true,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""1334f04e-4478-42ba-81df-50029387b99a"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Elemento de presupuesto de venta"",""descripcion"": """",""keyword"": ""ReferenciaElementoDePresupuestoDeVenta"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaElementoDePresupuestoDeVenta As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaElementoDePresupuestoDeVenta
          <DisplayName("Tipo movimiento")>
          Public Property ReferenciaTipoMovimiento As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaTipoMovimiento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaTipoMovimiento"",""etiqueta"": ""Tipo movimiento"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""ef5644b0-fb98-4191-908d-99594d9e1cc5"",""titulo"": ""Base - Tipos de movimiento"",""iconoid"": ""d720d25f-f5b8-4c83-a9f3-a8bf6cb31468"",""etiquetasingular"": ""Tipo de movimiento"",""etiquetaplural"": ""Tipos de movimiento"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""ef5644b0-fb98-4191-908d-99594d9e1cc5"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Tipo movimiento"",""descripcion"": """",""keyword"": ""ReferenciaTipoMovimiento"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaTipoMovimiento As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaTipoMovimiento
          <Description("Indicando esta opción se permitirá seleccionar productos que no estén en el catálogo que se ha asignado a la entidad o transacción.")>
          <DisplayName("Permitir productos fuera de catálogo")>
          Public Property PermitirProductosFueraDeCatalogo As Boolean
          Public Shared ___PermitirProductosFueraDeCatalogo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""PermitirProductosFueraDeCatalogo"",""etiqueta"": ""Permitir productos fuera de catálogo"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Permitir productos fuera de catálogo"",""descripcion"": """",""keyword"": ""PermitirProductosFueraDeCatalogo"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __PermitirProductosFueraDeCatalogo As DinaNETCore.APID.DinaupAPI_CampoC = ___PermitirProductosFueraDeCatalogo
          <DisplayName("Saldo promocional (General)")>
          Public Property ImporteSaldoPromocionalGeneral As Decimal
          Public Shared ___ImporteSaldoPromocionalGeneral As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSaldoPromocionalGeneral"",""etiqueta"": ""Saldo promocional (General)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""6"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Saldo promocional (General)"",""descripcion"": """",""keyword"": ""ImporteSaldoPromocionalGeneral"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSaldoPromocionalGeneral As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSaldoPromocionalGeneral
          <DisplayName("El precio indicado incluye los impuestos")>
          Public Property ElPrecioIndicadoIncluyeLosImpuestos As Boolean
          Public Shared ___ElPrecioIndicadoIncluyeLosImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ElPrecioIndicadoIncluyeLosImpuestos"",""etiqueta"": ""El precio indicado incluye los impuestos"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""El precio indicado incluye los impuestos"",""descripcion"": """",""keyword"": ""ElPrecioIndicadoIncluyeLosImpuestos"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ElPrecioIndicadoIncluyeLosImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ElPrecioIndicadoIncluyeLosImpuestos
          <Description("Descuento adicional configurable." & vbCrLf & "(Este es el ""Deseado"", podría modificarse según la configuración de ajustes de descuentos indicada, este valor puede ser distinto al aplicado finalmente)")>
          <DisplayName("Descuento Adicional A % (Deseado)")>
          Public Property DescuentoAdicionalADeseadoPorciento As Decimal
          Public Shared ___DescuentoAdicionalADeseadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoAdicionalADeseadoPorciento"",""etiqueta"": ""Descuento Adicional A % (Deseado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento Adicional A % (Deseado)"",""descripcion"": """",""keyword"": ""DescuentoAdicionalADeseadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoAdicionalADeseadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoAdicionalADeseadoPorciento
          <Description("Catálogo referencia de precios.")>
          <DisplayName("Catálogo")>
          Public Property ReferenciaCatalogo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaCatalogo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaCatalogo"",""etiqueta"": ""Catálogo"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""ff5a07a8-add8-4c23-8bac-530d23cdf82f"",""titulo"": ""Catálogos de venta"",""iconoid"": ""6ef681f0-d0c9-420d-b6d2-c912636f0314"",""etiquetasingular"": ""Catálogo de venta"",""etiquetaplural"": ""Catálogos de venta"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""ff5a07a8-add8-4c23-8bac-530d23cdf82f"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Catálogo"",""descripcion"": """",""keyword"": ""ReferenciaCatalogo"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaCatalogo As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaCatalogo
          <DisplayName("Medida (Base)")>
          Public Property ReferenciaMedidaBase As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaMedidaBase As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaMedidaBase"",""etiqueta"": ""Medida (Base)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c84f0381-d030-4223-a4e1-da78dda62ab4"",""titulo"": ""Base - Unidades de medida"",""iconoid"": ""0323688b-82a5-4fb7-a9f5-ff1247a52998"",""etiquetasingular"": ""Unidad de medida"",""etiquetaplural"": ""Unidades de medida"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""c84f0381-d030-4223-a4e1-da78dda62ab4"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Medida (Base)"",""descripcion"": """",""keyword"": ""ReferenciaMedidaBase"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaMedidaBase As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaMedidaBase
          <DisplayName("Producto no sustituido")>
          Public Property ReferenciaProductoNoSustituido As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaProductoNoSustituido As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaProductoNoSustituido"",""etiqueta"": ""Producto no sustituido"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""e28959bb-b7f1-4558-9e8a-4048e6c5f51a"",""titulo"": ""Base - Productos"",""iconoid"": ""21a04b44-ad38-44e0-a63a-98951da57cfa"",""etiquetasingular"": ""Producto"",""etiquetaplural"": ""Productos"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""e28959bb-b7f1-4558-9e8a-4048e6c5f51a"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Producto no sustituido"",""descripcion"": """",""keyword"": ""ReferenciaProductoNoSustituido"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaProductoNoSustituido As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaProductoNoSustituido
          <Description("Porcentaje de descuento en relación al producto seleccionado." & vbCrLf & "(Este es el ""Deseado"", podría modificarse según la configuración de ajustes de descuentos indicada, este valor puede ser distinto al aplicado finalmente)")>
          <DisplayName("Descuento Producto % (Deseado)")>
          Public Property DescuentoProductoDeseadoPorciento As Decimal
          Public Shared ___DescuentoProductoDeseadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoProductoDeseadoPorciento"",""etiqueta"": ""Descuento Producto % (Deseado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento Producto % (Deseado)"",""descripcion"": """",""keyword"": ""DescuentoProductoDeseadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoProductoDeseadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoProductoDeseadoPorciento
          <Description("Cantidad de Saldo promocional fijo que se ofrecerá con este producto." & vbCrLf & "(Este es el ""Deseado"", podría modificarse según la configuración de ajustes de descuentos indicada)")>
          <DisplayName("Saldo promocional Fijo por unidad (Deseado)")>
          Public Property ImporteSaldoPromocionalFijoPorUnidadDeseado As Decimal
          Public Shared ___ImporteSaldoPromocionalFijoPorUnidadDeseado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSaldoPromocionalFijoPorUnidadDeseado"",""etiqueta"": ""Saldo promocional Fijo por unidad (Deseado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""6"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Saldo promocional Fijo por unidad (Deseado)"",""descripcion"": """",""keyword"": ""ImporteSaldoPromocionalFijoPorUnidadDeseado"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSaldoPromocionalFijoPorUnidadDeseado As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSaldoPromocionalFijoPorUnidadDeseado
          <Description("Descuento relacionado a una oferta." & vbCrLf & "(Este es el ""Deseado"", podría modificarse según la configuración de ajustes de descuentos indicada, este valor puede ser distinto al aplicado finalmente)")>
          <DisplayName("Descuento Oferta % (Deseado)")>
          Public Property DescuentoOfertaDeseadoPorciento As Decimal
          Public Shared ___DescuentoOfertaDeseadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoOfertaDeseadoPorciento"",""etiqueta"": ""Descuento Oferta % (Deseado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento Oferta % (Deseado)"",""descripcion"": """",""keyword"": ""DescuentoOfertaDeseadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoOfertaDeseadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoOfertaDeseadoPorciento
          <DisplayName("Cantidad (Unidad medida base)")>
          Public Property CantidadUnidadMedidaBase As Decimal
          Public Shared ___CantidadUnidadMedidaBase As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CantidadUnidadMedidaBase"",""etiqueta"": ""Cantidad (Unidad medida base)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""11"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cantidad (Unidad medida base)"",""descripcion"": """",""keyword"": ""CantidadUnidadMedidaBase"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CantidadUnidadMedidaBase As DinaNETCore.APID.DinaupAPI_CampoC = ___CantidadUnidadMedidaBase
          <DisplayName("Empleado")>
          Public Property ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaEmpleadoPrincipal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaEmpleadoPrincipal"",""etiqueta"": ""Empleado"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c6e071c7-776f-4300-aa55-c711fd1da916"",""titulo"": ""Empleados"",""iconoid"": ""1c8abf82-640c-4d18-b62c-89de310923dd"",""etiquetasingular"": ""Empleado"",""etiquetaplural"": ""Empleados"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""c6e071c7-776f-4300-aa55-c711fd1da916"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empleado"",""descripcion"": """",""keyword"": ""ReferenciaEmpleadoPrincipal"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaEmpleadoPrincipal
          <Description("Determina que el sistema realizará la salida de inventario de forma automática al realizar la transacción.")>
          <DisplayName("Movimiento de inventario automático")>
          Public Property MovimientoDeInventarioAutomatico As Boolean
          Public Shared ___MovimientoDeInventarioAutomatico As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""MovimientoDeInventarioAutomatico"",""etiqueta"": ""Movimiento de inventario automático"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Movimiento de inventario automático"",""descripcion"": """",""keyword"": ""MovimientoDeInventarioAutomatico"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __MovimientoDeInventarioAutomatico As DinaNETCore.APID.DinaupAPI_CampoC = ___MovimientoDeInventarioAutomatico
          <Description("Porcentaje de descuento adicional A que se ha aplicado.")>
          <DisplayName("Descuento Adicional A % (Aplicado)")>
          Public Property DescuentoAdicionalAAplicadoPorciento As Decimal
          Public Shared ___DescuentoAdicionalAAplicadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoAdicionalAAplicadoPorciento"",""etiqueta"": ""Descuento Adicional A % (Aplicado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento Adicional A % (Aplicado)"",""descripcion"": """",""keyword"": ""DescuentoAdicionalAAplicadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoAdicionalAAplicadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoAdicionalAAplicadoPorciento
          <DisplayName("Presupuesto de venta")>
          Public Property ReferenciaPresupuestoDeVenta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaPresupuestoDeVenta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaPresupuestoDeVenta"",""etiqueta"": ""Presupuesto de venta"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""b0502d52-b315-487b-a911-0e60f022b6cc"",""titulo"": ""Base - Presupuestos de venta"",""iconoid"": ""9dbff307-faa5-4795-a496-c8334f0fa5f3"",""etiquetasingular"": ""Presupuesto de venta"",""etiquetaplural"": ""Presupuestos de venta"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""b0502d52-b315-487b-a911-0e60f022b6cc"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Presupuesto de venta"",""descripcion"": """",""keyword"": ""ReferenciaPresupuestoDeVenta"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaPresupuestoDeVenta As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaPresupuestoDeVenta
          <DisplayName("Evaluar stock")>
          Public Property EvaluarStock As Boolean
          Public Shared ___EvaluarStock As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EvaluarStock"",""etiqueta"": ""Evaluar stock"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Evaluar stock"",""descripcion"": """",""keyword"": ""EvaluarStock"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EvaluarStock As DinaNETCore.APID.DinaupAPI_CampoC = ___EvaluarStock
          <DisplayName("Elemento Catálogo")>
          Public Property ReferenciaElementoCatalogo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaElementoCatalogo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaElementoCatalogo"",""etiqueta"": ""Elemento Catálogo"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""d3797b08-0ca1-4ffd-9df1-7e86adf56575"",""titulo"": ""Lista - Catálogos de venta"",""iconoid"": ""6ef681f0-d0c9-420d-b6d2-c912636f0314"",""etiquetasingular"": ""Producto de catalogo"",""etiquetaplural"": ""Productos de catalogo"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": true,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""d3797b08-0ca1-4ffd-9df1-7e86adf56575"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Elemento Catálogo"",""descripcion"": """",""keyword"": ""ReferenciaElementoCatalogo"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaElementoCatalogo As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaElementoCatalogo
          <Description("Descuento general indicado que se ha aplicado.")>
          <DisplayName("Descuento General % (Aplicado)")>
          Public Property DescuentoGeneralAplicadoPorciento As Decimal
          Public Shared ___DescuentoGeneralAplicadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoGeneralAplicadoPorciento"",""etiqueta"": ""Descuento General % (Aplicado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento General % (Aplicado)"",""descripcion"": """",""keyword"": ""DescuentoGeneralAplicadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoGeneralAplicadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoGeneralAplicadoPorciento
          <DisplayName("Entidad Relacionada Tiene Acceso web")>
          Public Property EntidadRelacionadaTieneAccesoWeb As Boolean
          Public Shared ___EntidadRelacionadaTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EntidadRelacionadaTieneAccesoWeb"",""etiqueta"": ""Entidad Relacionada Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Entidad Relacionada Tiene Acceso web"",""descripcion"": """",""keyword"": ""EntidadRelacionadaTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EntidadRelacionadaTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___EntidadRelacionadaTieneAccesoWeb
          <DisplayName("Suma (Con Impuestos)")>
          Public Property ImporteSumaConImpuestos As Decimal
          Public Shared ___ImporteSumaConImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSumaConImpuestos"",""etiqueta"": ""Suma (Con Impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""10"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Suma (Con Impuestos)"",""descripcion"": """",""keyword"": ""ImporteSumaConImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSumaConImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSumaConImpuestos
          <DisplayName("Categoría de venta")>
          Public Property ReferenciaCategoriaDeVenta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaCategoriaDeVenta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaCategoriaDeVenta"",""etiqueta"": ""Categoría de venta"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""b1275848-3b6f-4b55-b6fa-9d77b9c0e6a5"",""titulo"": ""Base - Categorías de Ventas"",""iconoid"": ""41e2810f-985c-4e49-b283-9e43ff68cadb"",""etiquetasingular"": ""Categoría de Venta"",""etiquetaplural"": ""Categorías de Ventas"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""b1275848-3b6f-4b55-b6fa-9d77b9c0e6a5"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Categoría de venta"",""descripcion"": """",""keyword"": ""ReferenciaCategoriaDeVenta"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaCategoriaDeVenta As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaCategoriaDeVenta
          <DisplayName("Elemento de pack")>
          Public Property ReferenciaElementoDePack As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaElementoDePack As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaElementoDePack"",""etiqueta"": ""Elemento de pack"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""e702c5f3-72d3-4086-98f9-f66b2dfa570a"",""titulo"": ""Base Lista - Packs de productos de venta"",""iconoid"": ""11775b67-1fae-40ce-9d26-fff4e8148a8e"",""etiquetasingular"": ""Pack de productos de venta"",""etiquetaplural"": ""Packs de productos de venta"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": true,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""e702c5f3-72d3-4086-98f9-f66b2dfa570a"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Elemento de pack"",""descripcion"": """",""keyword"": ""ReferenciaElementoDePack"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaElementoDePack As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaElementoDePack
          <DisplayName("Unidades deseadas")>
          Public Property UnidadesDeseadas As Decimal
          Public Shared ___UnidadesDeseadas As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""UnidadesDeseadas"",""etiqueta"": ""Unidades deseadas"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""11"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Unidades deseadas"",""descripcion"": """",""keyword"": ""UnidadesDeseadas"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __UnidadesDeseadas As DinaNETCore.APID.DinaupAPI_CampoC = ___UnidadesDeseadas
          <DisplayName("Coste (Und.)")>
          Public Property ImporteCosteUnd As Decimal
          Public Shared ___ImporteCosteUnd As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteCosteUnd"",""etiqueta"": ""Coste (Und.)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Coste (Und.)"",""descripcion"": """",""keyword"": ""ImporteCosteUnd"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteCosteUnd As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteCosteUnd
          <DisplayName("Coste")>
          Public Property ImporteCoste As Decimal
          Public Shared ___ImporteCoste As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteCoste"",""etiqueta"": ""Coste"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Coste"",""descripcion"": """",""keyword"": ""ImporteCoste"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteCoste As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteCoste
          <DisplayName("Margen (Und.)")>
          Public Property ImporteMargenUnd As Decimal
          Public Shared ___ImporteMargenUnd As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteMargenUnd"",""etiqueta"": ""Margen (Und.)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Margen (Und.)"",""descripcion"": """",""keyword"": ""ImporteMargenUnd"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteMargenUnd As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteMargenUnd
          <DisplayName("Margen")>
          Public Property ImporteMargen As Decimal
          Public Shared ___ImporteMargen As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteMargen"",""etiqueta"": ""Margen"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Margen"",""descripcion"": """",""keyword"": ""ImporteMargen"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteMargen As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteMargen
          <DisplayName("Cantidad de productos que deben entrar")>
          Public Property CantidadDeProductosQueDebenEntrar As Decimal
          Public Shared ___CantidadDeProductosQueDebenEntrar As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CantidadDeProductosQueDebenEntrar"",""etiqueta"": ""Cantidad de productos que deben entrar"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""11"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cantidad de productos que deben entrar"",""descripcion"": """",""keyword"": ""CantidadDeProductosQueDebenEntrar"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CantidadDeProductosQueDebenEntrar As DinaNETCore.APID.DinaupAPI_CampoC = ___CantidadDeProductosQueDebenEntrar
          <DisplayName("Tipo de factura")>
          Public Property TipoDeFactura As EnumTipoMovimientoE
          Public Shared ___TipoDeFactura As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TipoDeFactura"",""etiqueta"": ""Tipo de factura"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 88,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [0,1,3],""predefinidos_textos"": [""Indefinido"",""Ordinario"",""Rectificativo""],""predefinidos_iconos"": [""https://cdn.dinaup.com/ico/enums/88_0.png"",""https://cdn.dinaup.com/ico/enums/88_1.png"",""https://cdn.dinaup.com/ico/enums/88_3.png""],""filtro"": {""titulo"": ""Tipo de factura"",""descripcion"": """",""keyword"": ""TipoDeFactura"",""formato"": 2,""rol"": 88,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false,""enumeracion"": {""titulo"": ""Enum - Tipo Movimiento"", ""valores"": [{""valor"": 0, ""titulo"": ""Indefinido""},{""valor"": 1, ""titulo"": ""Ordinario""},{""valor"": 3, ""titulo"": ""Rectificativo""}]}},""solovalorespredefinidos"": true}")
          Public  __TipoDeFactura As DinaNETCore.APID.DinaupAPI_CampoC = ___TipoDeFactura
          <DisplayName("Rectificando -Venta")>
          Public Property ReferenciaRectificandoVenta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaRectificandoVenta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaRectificandoVenta"",""etiqueta"": ""Rectificando -Venta"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""47379b9b-2168-407f-b876-d25265875af2"",""titulo"": ""Base - Ventas"",""iconoid"": ""23ed4a24-e01e-4972-9e11-1212732ee800"",""etiquetasingular"": ""Venta"",""etiquetaplural"": ""Ventas"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""47379b9b-2168-407f-b876-d25265875af2"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Rectificando -Venta"",""descripcion"": """",""keyword"": ""ReferenciaRectificandoVenta"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaRectificandoVenta As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaRectificandoVenta
          <DisplayName("Rectificando - Producto vendido")>
          Public Property ReferenciaRectificandoProductoVendido As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaRectificandoProductoVendido As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaRectificandoProductoVendido"",""etiqueta"": ""Rectificando - Producto vendido"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""e0a2b422-8962-4680-89af-a4952e4f5f13"",""titulo"": ""Base Lista - Ventas"",""iconoid"": """",""etiquetasingular"": ""Elemento de Venta"",""etiquetaplural"": ""Elementos de Ventas"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": true,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""e0a2b422-8962-4680-89af-a4952e4f5f13"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Rectificando - Producto vendido"",""descripcion"": """",""keyword"": ""ReferenciaRectificandoProductoVendido"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaRectificandoProductoVendido As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaRectificandoProductoVendido
          <DisplayName("Clave de operación intracomunitaria")>
          Public Property ClaveDeOperacionIntracomunitaria As String
          Public Shared ___ClaveDeOperacionIntracomunitaria As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ClaveDeOperacionIntracomunitaria"",""etiqueta"": ""Clave de operación intracomunitaria"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 89,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Clave de operación intracomunitaria"",""descripcion"": """",""keyword"": ""ClaveDeOperacionIntracomunitaria"",""formato"": 5,""rol"": 89,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ClaveDeOperacionIntracomunitaria As DinaNETCore.APID.DinaupAPI_CampoC = ___ClaveDeOperacionIntracomunitaria
          <DisplayName("Fecha contable de venta")>
          Public Property FechaContableDeVenta As Date?
          Public Shared ___FechaContableDeVenta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaContableDeVenta"",""etiqueta"": ""Fecha contable de venta"",""oculta"": false,""formato"": 7,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha contable de venta"",""descripcion"": """",""keyword"": ""FechaContableDeVenta"",""formato"": 7,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaContableDeVenta As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaContableDeVenta
          <DisplayName("Prorrateo B.I")>
          Public Property ImporteProrrateoBI As Decimal
          Public Shared ___ImporteProrrateoBI As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteProrrateoBI"",""etiqueta"": ""Prorrateo B.I"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Prorrateo B.I"",""descripcion"": """",""keyword"": ""ImporteProrrateoBI"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteProrrateoBI As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteProrrateoBI
          <DisplayName("Prorrateo IVA")>
          Public Property ImporteProrrateoIVA As Decimal
          Public Shared ___ImporteProrrateoIVA As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteProrrateoIVA"",""etiqueta"": ""Prorrateo IVA"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Prorrateo IVA"",""descripcion"": """",""keyword"": ""ImporteProrrateoIVA"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteProrrateoIVA As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteProrrateoIVA
          <DisplayName("Prorrateo R.E")>
          Public Property ImporteProrrateoRE As Decimal
          Public Shared ___ImporteProrrateoRE As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteProrrateoRE"",""etiqueta"": ""Prorrateo R.E"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Prorrateo R.E"",""descripcion"": """",""keyword"": ""ImporteProrrateoRE"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteProrrateoRE As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteProrrateoRE
          <DisplayName("Es un gasto suplido")>
          Public Property EsUnGastoSuplido As Boolean
          Public Shared ___EsUnGastoSuplido As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EsUnGastoSuplido"",""etiqueta"": ""Es un gasto suplido"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Es un gasto suplido"",""descripcion"": """",""keyword"": ""EsUnGastoSuplido"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EsUnGastoSuplido As DinaNETCore.APID.DinaupAPI_CampoC = ___EsUnGastoSuplido
          <DisplayName("Importe gasto suplido")>
          Public Property ImporteImporteGastoSuplido As Decimal
          Public Shared ___ImporteImporteGastoSuplido As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteImporteGastoSuplido"",""etiqueta"": ""Importe gasto suplido"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Importe gasto suplido"",""descripcion"": """",""keyword"": ""ImporteImporteGastoSuplido"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteImporteGastoSuplido As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteImporteGastoSuplido
          <DisplayName("Prorrateo Retención")>
          Public Property ImporteProrrateoRetencion As Decimal
          Public Shared ___ImporteProrrateoRetencion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteProrrateoRetencion"",""etiqueta"": ""Prorrateo Retención"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Prorrateo Retención"",""descripcion"": """",""keyword"": ""ImporteProrrateoRetencion"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteProrrateoRetencion As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteProrrateoRetencion
          <DisplayName("Actividad")>
          Public Property ReferenciaActividad As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaActividad As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaActividad"",""etiqueta"": ""Actividad"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""f6221df1-2f56-4f49-8e45-dd4914873fa8"",""titulo"": ""Base - Actividades de Empresas"",""iconoid"": ""c33cb208-e4a6-4189-af8f-00aa92e9599a"",""etiquetasingular"": ""Actividad de Empresa"",""etiquetaplural"": ""Actividades de Empresa"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""f6221df1-2f56-4f49-8e45-dd4914873fa8"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Actividad"",""descripcion"": """",""keyword"": ""ReferenciaActividad"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaActividad As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaActividad
          <DisplayName("Recurso")>
          Public Property ReferenciaRecurso As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaRecurso As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaRecurso"",""etiqueta"": ""Recurso"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""3b921d2c-89b7-4cfd-8999-6e44ddabeb72"",""titulo"": ""Base - Recursos de la empresa"",""iconoid"": ""424f5d43-6ae2-43f9-bbea-dacf5868d2aa"",""etiquetasingular"": ""Recurso de la empresa"",""etiquetaplural"": ""Recursos de la empresa"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""3b921d2c-89b7-4cfd-8999-6e44ddabeb72"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Recurso"",""descripcion"": """",""keyword"": ""ReferenciaRecurso"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaRecurso As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaRecurso
          <ReadOnlyAttribute(True)>
          <DisplayName("ID")>
          Public Property ID As Guid
          Public Shared ___ID As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": true,""eseliminado"": false,""keyword"": ""ID"",""etiqueta"": ""ID"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c59f4af2-da6b-4671-ad4f-8cf2d71c3a73"",""titulo"": ""Lista - Ventas"",""iconoid"": """",""etiquetasingular"": ""Elemento de Venta"",""etiquetaplural"": ""Elementos de Ventas"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": true,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""c59f4af2-da6b-4671-ad4f-8cf2d71c3a73"",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""ID"",""descripcion"": """",""keyword"": ""ID"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ID As DinaNETCore.APID.DinaupAPI_CampoC = ___ID
          <DisplayName("Concepto")>
          Public Property TextoPrincipal As String
          Public Shared ___TextoPrincipal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TextoPrincipal"",""etiqueta"": ""Concepto"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Concepto"",""descripcion"": """",""keyword"": ""TextoPrincipal"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
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
          <ReadOnlyAttribute(True)>
          <DisplayName("Venta (Listador) (Relación)")>
          Public Property RelacionElementoContenedorListador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___RelacionElementoContenedorListador As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RelacionElementoContenedorListador"",""etiqueta"": ""Venta (Listador) (Relación)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""0ce4c6ac-54aa-488d-b8b8-e3a20d79f7a4"",""titulo"": ""Ventas"",""iconoid"": ""97fc02d2-1b1d-4c9d-babe-b503d3af7825"",""etiquetasingular"": ""Venta"",""etiquetaplural"": ""Ventas"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""0ce4c6ac-54aa-488d-b8b8-e3a20d79f7a4"",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Venta (Listador) (Relación)"",""descripcion"": """",""keyword"": ""RelacionElementoContenedorListador"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RelacionElementoContenedorListador As DinaNETCore.APID.DinaupAPI_CampoC = ___RelacionElementoContenedorListador
          <DisplayName("Venta (Listador) Eliminadoa *")>
          Public Property Listadoreliminado As Boolean
          Public Shared ___Listadoreliminado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Listadoreliminado"",""etiqueta"": ""Venta (Listador) Eliminadoa *"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Venta (Listador) Eliminadoa *"",""descripcion"": """",""keyword"": ""Listadoreliminado"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Listadoreliminado As DinaNETCore.APID.DinaupAPI_CampoC = ___Listadoreliminado
          Overrides Sub CargarDatos(_Datos as Dic(of string,string))
          me.FechaAlta_UTC = _Datos.Leer_DateTime_Nulable("pr_500401055221")
          me.ImporteDescuentoFijoUnidadDeseado = _Datos.Leer_Decimal("pr_5004010553163")
          me.ReferenciaEntidadRelacionada = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_60040105653"), _Datos.Leer_String("pr_60040105653.nombre"))
          me.ImporteTotalDescontadoSinImpuestos = _Datos.Leer_Decimal("pr_5004010553160")
          me.PorcentajeDeImpuestosPorciento = _Datos.Leer_Decimal("pr_5004010553169")
          me.DescuentoOfertaAplicadoPorciento = _Datos.Leer_Decimal("pr_5004010553171")
          me.FechaDato_UTC = _Datos.Leer_DateTime_Nulable("pr_500401055219")
          me.EmpleadoTieneAccesoWeb = _Datos.Leer_Boolean("pr_500401055226")
          me.DescuentoEntidadAplicadoPorciento = _Datos.Leer_Decimal("pr_5004010553173")
          me.SaldoPromocionalOfertaAplicadoPorciento = _Datos.Leer_Decimal("pr_5004010553174")
          me.ImporteImporteFinalTotalDescuentoNoAplicados = _Datos.Leer_Decimal("pr_5004010553179")
          me.MotivoNoSustitucion = _Datos.Leer_String("pr_5004010553186")
          me.ReferenciaProducto = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_5004010553185"), _Datos.Leer_String("pr_5004010553185.nombre"))
          me.ProductoEsSustitucion = _Datos.Leer_Boolean("pr_5004010553192")
          me.ModificarDtoAdicionalA = _Datos.Leer_Boolean("pr_5004010553189")
          me.ImporteSumaSinImpuestos = _Datos.Leer_Decimal("pr_5004010553200")
          me.DescuentoAdicionalBMotivo = _Datos.Leer_String("pr_5004010553195")
          me.CantidadMedidaBasePorUnd = _Datos.Leer_Decimal("pr_5004010553196")
          me.ImporteSaldoPromocionalProducto = _Datos.Leer_Decimal("pr_5004010553208")
          me.ImporteTotalDescuentosGeneralesSinImpuestos = _Datos.Leer_Decimal("pr_5004010553206")
          me.ImporteImporteFinalSaldoObtenido = _Datos.Leer_Decimal("pr_5004010553204")
          me.Cantidad = _Datos.Leer_Decimal("pr_5004010553107")
          me.ReferenciaAutorDelAlta = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_500401055218"), _Datos.Leer_String("pr_500401055218.nombre"))
          me.DescuentoVIPDeseadoPorciento = _Datos.Leer_Decimal("pr_5004010553106")
          me.ReferenciaMedida = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_5004010553108"), _Datos.Leer_String("pr_5004010553108.nombre"))
          me.ImporteImporteFinalTotal = _Datos.Leer_Decimal("pr_5004010553104")
          me.SaldoPromocionalOfertaDeseadoPorciento = _Datos.Leer_Decimal("pr_5004010553116")
          me.ImportePrecioUnidadSinImpuestos = _Datos.Leer_Decimal("pr_5004010553109")
          me.DescuentoProductoAplicadoPorciento = _Datos.Leer_Decimal("pr_5004010553110")
          me.ImporteTotalDescuentosProductosSinImpuestos = _Datos.Leer_Decimal("pr_5004010553120")
          me.SaldoPromocionalGeneralGeneradoAplicadoPorciento = _Datos.Leer_Decimal("pr_5004010553119")
          me.ImportePrecioMinimo = _Datos.Leer_Decimal("pr_5004010553140")
          me.ReferenciaLote = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_5004010553139"), _Datos.Leer_String("pr_5004010553139.nombre"))
          me.DescuentoGeneralDeseadoPorciento = _Datos.Leer_Decimal("pr_5004010553133")
          me.ImporteSaldoPromocionalFijoPorUnidadAplicado = _Datos.Leer_Decimal("pr_5004010553129")
          me.ModificarDtoTipoEntidad = _Datos.Leer_Boolean("pr_5004010553130")
          me.DescuentoTipoEntidadPorciento = _Datos.Leer_Decimal("pr_5004010553136")
          me.DescuentoTipoEntidadDeseadoPorciento = _Datos.Leer_Decimal("pr_5004010553134")
          me.ReferenciaProductoSustituido = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_5004010553147"), _Datos.Leer_String("pr_5004010553147.nombre"))
          me.SaldoPromocionalGeneralGeneradoDeseadoPorciento = _Datos.Leer_Decimal("pr_5004010553141")
          me.ImporteImporteConImpuestos = _Datos.Leer_Decimal("pr_50040106485")
          me.SaldoPromocionalOfertaMinimoAjustablePorciento = _Datos.Leer_Decimal("pr_5004010553155")
          me.ModificarDtoEntidad = _Datos.Leer_Boolean("pr_5004010553153")
          me.CantidadUnidades = _Datos.Leer_Decimal("pr_500401055359")
          me.ModificarSaldoPromocionalGeneral = _Datos.Leer_Boolean("pr_500401055358")
          me.ReferenciaElementoReservado = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_500401055355"), _Datos.Leer_String("pr_500401055355.nombre"))
          me.ReferenciaReserva = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_50040105793"), _Datos.Leer_String("pr_50040105793.nombre"))
          me.ReferenciaUbicacionPrincipal = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_500401055217"), _Datos.Leer_String("pr_500401055217.nombre"))
          me.DescuentoAdicionalAMotivo = _Datos.Leer_String("pr_500401055362")
          me.ImporteImporteSinImpuestos = _Datos.Leer_Decimal("pr_500401055361")
          me.TotalPorcentajeDeDescuentoAplicadoAProductoPorciento = _Datos.Leer_Decimal("pr_500401055360")
          me.ModificarDtoAdicionalB = _Datos.Leer_Boolean("pr_500401055371")
          me.ImportePrecioUnidad = _Datos.Leer_Decimal("pr_500401055369")
          me.DescuentoAdicionalBAplicadoPorciento = _Datos.Leer_Decimal("pr_500401055368")
          me.ImporteImporteFinalRetencion = _Datos.Leer_Decimal("pr_500401055379")
          me.HoraLocal = _Datos.Leer_Time_Nulable("pr_500401055220")
          me.DescuentoEntidadDeseadoPorciento = _Datos.Leer_Decimal("pr_500401055374")
          me.ReferenciaDestinador = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_500401055224"), _Datos.Leer_String("pr_500401055224.nombre"))
          me.DescuentoVIPAplicadoPorciento = _Datos.Leer_Decimal("pr_500401055373")
          me.CantidadDeProductosQueDebenDeSalir = _Datos.Leer_Decimal("pr_500401055381")
          me.ImportePrecioUnidadConImpuestos = _Datos.Leer_Decimal("pr_50040106486")
          me.DescuentoAdicionalBDeseadoPorciento = _Datos.Leer_Decimal("pr_500401055383")
          me.ReferenciaImpuesto = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_500401055380"), _Datos.Leer_String("pr_500401055380.nombre"))
          me.AutorDelAltaTieneAccesoWeb = _Datos.Leer_Boolean("pr_500401055228")
          me.ModificarDtoGeneral = _Datos.Leer_Boolean("pr_5004010553100")
          me.ModificarDtoVIP = _Datos.Leer_Boolean("pr_5004010553102")
          me.ReferenciaMovimientoInternoDeInventario = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_40040106601"), _Datos.Leer_String("pr_40040106601.nombre"))
          me.ImporteImporteFinalImpuestos = _Datos.Leer_Decimal("pr_500401055393")
          me.ImporteDtoFijoPorUnidadAplicado = _Datos.Leer_Decimal("pr_500401055394")
          me.CantidadDeProductosQuePuedenRectificarse = _Datos.Leer_Decimal("pr_50040105533")
          me.ReferenciaElementoDePresupuestoDeVenta = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_50040105792"), _Datos.Leer_String("pr_50040105792.nombre"))
          me.ReferenciaTipoMovimiento = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_50040105535"), _Datos.Leer_String("pr_50040105535.nombre"))
          me.PermitirProductosFueraDeCatalogo = _Datos.Leer_Boolean("pr_50040105531")
          me.ImporteSaldoPromocionalGeneral = _Datos.Leer_Decimal("pr_50040105532")
          me.ElPrecioIndicadoIncluyeLosImpuestos = _Datos.Leer_Boolean("pr_500401055313")
          me.DescuentoAdicionalADeseadoPorciento = _Datos.Leer_Decimal("pr_500401055310")
          me.ReferenciaCatalogo = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_500401055321"), _Datos.Leer_String("pr_500401055321.nombre"))
          me.ReferenciaMedidaBase = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_500401055319"), _Datos.Leer_String("pr_500401055319.nombre"))
          me.ReferenciaProductoNoSustituido = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_500401055316"), _Datos.Leer_String("pr_500401055316.nombre"))
          me.DescuentoProductoDeseadoPorciento = _Datos.Leer_Decimal("pr_500401055315")
          me.ImporteSaldoPromocionalFijoPorUnidadDeseado = _Datos.Leer_Decimal("pr_500401055318")
          me.DescuentoOfertaDeseadoPorciento = _Datos.Leer_Decimal("pr_500401055327")
          me.CantidadUnidadMedidaBase = _Datos.Leer_Decimal("pr_500401055322")
          me.ReferenciaEmpleadoPrincipal = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_500401055216"), _Datos.Leer_String("pr_500401055216.nombre"))
          me.MovimientoDeInventarioAutomatico = _Datos.Leer_Boolean("pr_500401055335")
          me.DescuentoAdicionalAAplicadoPorciento = _Datos.Leer_Decimal("pr_500401055341")
          me.ReferenciaPresupuestoDeVenta = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_50040105791"), _Datos.Leer_String("pr_50040105791.nombre"))
          me.EvaluarStock = _Datos.Leer_Boolean("pr_500401055337")
          me.ReferenciaElementoCatalogo = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_500401055342"), _Datos.Leer_String("pr_500401055342.nombre"))
          me.DescuentoGeneralAplicadoPorciento = _Datos.Leer_Decimal("pr_500401055343")
          me.EntidadRelacionadaTieneAccesoWeb = _Datos.Leer_Boolean("pr_60040105654")
          me.ImporteSumaConImpuestos = _Datos.Leer_Decimal("pr_50040106484")
          me.ReferenciaCategoriaDeVenta = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_50040136172"), _Datos.Leer_String("pr_50040136172.nombre"))
          me.ReferenciaElementoDePack = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_20040148294"), _Datos.Leer_String("pr_20040148294.nombre"))
          me.UnidadesDeseadas = _Datos.Leer_Decimal("pr_100401699816")
          me.ImporteCosteUnd = _Datos.Leer_Decimal("pr_40040192151")
          me.ImporteCoste = _Datos.Leer_Decimal("pr_50040192153")
          me.ImporteMargenUnd = _Datos.Leer_Decimal("pr_50040192151")
          me.ImporteMargen = _Datos.Leer_Decimal("pr_50040192152")
          me.CantidadDeProductosQueDebenEntrar = _Datos.Leer_Decimal("pr_40040242012")
          me.TipoDeFactura = _Datos.Leer_EnumTipoMovimientoE("pr_60040242001")
          me.ReferenciaRectificandoVenta = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_30040241991"), _Datos.Leer_String("pr_30040241991.nombre"))
          me.ReferenciaRectificandoProductoVendido = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_20040241993"), _Datos.Leer_String("pr_20040241993.nombre"))
          me.ClaveDeOperacionIntracomunitaria = _Datos.Leer_String("pr_300402429916")
          me.FechaContableDeVenta = _Datos.Leer_Date_Nulable("pr_30040252082")
          me.ImporteProrrateoBI = _Datos.Leer_Decimal("pr_40040255193")
          me.ImporteProrrateoIVA = _Datos.Leer_Decimal("pr_40040255192")
          me.ImporteProrrateoRE = _Datos.Leer_Decimal("pr_40040255191")
          me.EsUnGastoSuplido = _Datos.Leer_Boolean("pr_20040256622")
          me.ImporteImporteGastoSuplido = _Datos.Leer_Decimal("pr_20040256621")
          me.ImporteProrrateoRetencion = _Datos.Leer_Decimal("pr_10040266802")
          me.ReferenciaActividad = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_60040281353"), _Datos.Leer_String("pr_60040281353.nombre"))
          me.ReferenciaRecurso = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_20040441201"), _Datos.Leer_String("pr_20040441201.nombre"))
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
          me.RelacionElementoContenedorListador = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("idrelacionlistador"), _Datos.Leer_String("idrelacionlistador.nombre"))
          me.Listadoreliminado = _Datos.Leer_Boolean("listadoreliminado")
          End Sub
          Overrides Function ToDic() as Dic(of String,String)
           dim R as new Dic(of String,String)
         R.add("pr_500401055221", me.FechaAlta_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_5004010553163", me.ImporteDescuentoFijoUnidadDeseado.AdaptarMySQL_Decimal())
         If Me.ReferenciaEntidadRelacionada IsNot nothing then
           R.add("pr_60040105653",me.ReferenciaEntidadRelacionada.ID.STR())
         Else
           R.add("pr_60040105653","")
         End if
         R.add("pr_5004010553160", me.ImporteTotalDescontadoSinImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_5004010553169", me.PorcentajeDeImpuestosPorciento.AdaptarMySQL_Decimal())
         R.add("pr_5004010553171", me.DescuentoOfertaAplicadoPorciento.AdaptarMySQL_Decimal())
         R.add("pr_500401055219", me.FechaDato_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_500401055226", me.EmpleadoTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_5004010553173", me.DescuentoEntidadAplicadoPorciento.AdaptarMySQL_Decimal())
         R.add("pr_5004010553174", me.SaldoPromocionalOfertaAplicadoPorciento.AdaptarMySQL_Decimal())
         R.add("pr_5004010553179", me.ImporteImporteFinalTotalDescuentoNoAplicados.AdaptarMySQL_Decimal())
         R.add("pr_5004010553186", me.MotivoNoSustitucion.AdaptarMySQL_String())
         If Me.ReferenciaProducto IsNot nothing then
           R.add("pr_5004010553185",me.ReferenciaProducto.ID.STR())
         Else
           R.add("pr_5004010553185","")
         End if
         R.add("pr_5004010553192", me.ProductoEsSustitucion.AdaptarMySQL_Boolean())
         R.add("pr_5004010553189", me.ModificarDtoAdicionalA.AdaptarMySQL_Boolean())
         R.add("pr_5004010553200", me.ImporteSumaSinImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_5004010553195", me.DescuentoAdicionalBMotivo.AdaptarMySQL_String())
         R.add("pr_5004010553196", me.CantidadMedidaBasePorUnd.AdaptarMySQL_Decimal())
         R.add("pr_5004010553208", me.ImporteSaldoPromocionalProducto.AdaptarMySQL_Decimal())
         R.add("pr_5004010553206", me.ImporteTotalDescuentosGeneralesSinImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_5004010553204", me.ImporteImporteFinalSaldoObtenido.AdaptarMySQL_Decimal())
         R.add("pr_5004010553107", me.Cantidad.AdaptarMySQL_Decimal())
         If Me.ReferenciaAutorDelAlta IsNot nothing then
           R.add("pr_500401055218",me.ReferenciaAutorDelAlta.ID.STR())
         Else
           R.add("pr_500401055218","")
         End if
         R.add("pr_5004010553106", me.DescuentoVIPDeseadoPorciento.AdaptarMySQL_Decimal())
         If Me.ReferenciaMedida IsNot nothing then
           R.add("pr_5004010553108",me.ReferenciaMedida.ID.STR())
         Else
           R.add("pr_5004010553108","")
         End if
         R.add("pr_5004010553104", me.ImporteImporteFinalTotal.AdaptarMySQL_Decimal())
         R.add("pr_5004010553116", me.SaldoPromocionalOfertaDeseadoPorciento.AdaptarMySQL_Decimal())
         R.add("pr_5004010553109", me.ImportePrecioUnidadSinImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_5004010553110", me.DescuentoProductoAplicadoPorciento.AdaptarMySQL_Decimal())
         R.add("pr_5004010553120", me.ImporteTotalDescuentosProductosSinImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_5004010553119", me.SaldoPromocionalGeneralGeneradoAplicadoPorciento.AdaptarMySQL_Decimal())
         R.add("pr_5004010553140", me.ImportePrecioMinimo.AdaptarMySQL_Decimal())
         If Me.ReferenciaLote IsNot nothing then
           R.add("pr_5004010553139",me.ReferenciaLote.ID.STR())
         Else
           R.add("pr_5004010553139","")
         End if
         R.add("pr_5004010553133", me.DescuentoGeneralDeseadoPorciento.AdaptarMySQL_Decimal())
         R.add("pr_5004010553129", me.ImporteSaldoPromocionalFijoPorUnidadAplicado.AdaptarMySQL_Decimal())
         R.add("pr_5004010553130", me.ModificarDtoTipoEntidad.AdaptarMySQL_Boolean())
         R.add("pr_5004010553136", me.DescuentoTipoEntidadPorciento.AdaptarMySQL_Decimal())
         R.add("pr_5004010553134", me.DescuentoTipoEntidadDeseadoPorciento.AdaptarMySQL_Decimal())
         If Me.ReferenciaProductoSustituido IsNot nothing then
           R.add("pr_5004010553147",me.ReferenciaProductoSustituido.ID.STR())
         Else
           R.add("pr_5004010553147","")
         End if
         R.add("pr_5004010553141", me.SaldoPromocionalGeneralGeneradoDeseadoPorciento.AdaptarMySQL_Decimal())
         R.add("pr_50040106485", me.ImporteImporteConImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_5004010553155", me.SaldoPromocionalOfertaMinimoAjustablePorciento.AdaptarMySQL_Decimal())
         R.add("pr_5004010553153", me.ModificarDtoEntidad.AdaptarMySQL_Boolean())
         R.add("pr_500401055359", me.CantidadUnidades.AdaptarMySQL_Decimal())
         R.add("pr_500401055358", me.ModificarSaldoPromocionalGeneral.AdaptarMySQL_Boolean())
         If Me.ReferenciaElementoReservado IsNot nothing then
           R.add("pr_500401055355",me.ReferenciaElementoReservado.ID.STR())
         Else
           R.add("pr_500401055355","")
         End if
         If Me.ReferenciaReserva IsNot nothing then
           R.add("pr_50040105793",me.ReferenciaReserva.ID.STR())
         Else
           R.add("pr_50040105793","")
         End if
         If Me.ReferenciaUbicacionPrincipal IsNot nothing then
           R.add("pr_500401055217",me.ReferenciaUbicacionPrincipal.ID.STR())
         Else
           R.add("pr_500401055217","")
         End if
         R.add("pr_500401055362", me.DescuentoAdicionalAMotivo.AdaptarMySQL_String())
         R.add("pr_500401055361", me.ImporteImporteSinImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_500401055360", me.TotalPorcentajeDeDescuentoAplicadoAProductoPorciento.AdaptarMySQL_Decimal())
         R.add("pr_500401055371", me.ModificarDtoAdicionalB.AdaptarMySQL_Boolean())
         R.add("pr_500401055369", me.ImportePrecioUnidad.AdaptarMySQL_Decimal())
         R.add("pr_500401055368", me.DescuentoAdicionalBAplicadoPorciento.AdaptarMySQL_Decimal())
         R.add("pr_500401055379", me.ImporteImporteFinalRetencion.AdaptarMySQL_Decimal())
         R.add("pr_500401055220", me.HoraLocal.AdaptarMySQL_Time_Nulable())
         R.add("pr_500401055374", me.DescuentoEntidadDeseadoPorciento.AdaptarMySQL_Decimal())
         If Me.ReferenciaDestinador IsNot nothing then
           R.add("pr_500401055224",me.ReferenciaDestinador.ID.STR())
         Else
           R.add("pr_500401055224","")
         End if
         R.add("pr_500401055373", me.DescuentoVIPAplicadoPorciento.AdaptarMySQL_Decimal())
         R.add("pr_500401055381", me.CantidadDeProductosQueDebenDeSalir.AdaptarMySQL_Decimal())
         R.add("pr_50040106486", me.ImportePrecioUnidadConImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_500401055383", me.DescuentoAdicionalBDeseadoPorciento.AdaptarMySQL_Decimal())
         If Me.ReferenciaImpuesto IsNot nothing then
           R.add("pr_500401055380",me.ReferenciaImpuesto.ID.STR())
         Else
           R.add("pr_500401055380","")
         End if
         R.add("pr_500401055228", me.AutorDelAltaTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_5004010553100", me.ModificarDtoGeneral.AdaptarMySQL_Boolean())
         R.add("pr_5004010553102", me.ModificarDtoVIP.AdaptarMySQL_Boolean())
         If Me.ReferenciaMovimientoInternoDeInventario IsNot nothing then
           R.add("pr_40040106601",me.ReferenciaMovimientoInternoDeInventario.ID.STR())
         Else
           R.add("pr_40040106601","")
         End if
         R.add("pr_500401055393", me.ImporteImporteFinalImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_500401055394", me.ImporteDtoFijoPorUnidadAplicado.AdaptarMySQL_Decimal())
         R.add("pr_50040105533", me.CantidadDeProductosQuePuedenRectificarse.AdaptarMySQL_Decimal())
         If Me.ReferenciaElementoDePresupuestoDeVenta IsNot nothing then
           R.add("pr_50040105792",me.ReferenciaElementoDePresupuestoDeVenta.ID.STR())
         Else
           R.add("pr_50040105792","")
         End if
         If Me.ReferenciaTipoMovimiento IsNot nothing then
           R.add("pr_50040105535",me.ReferenciaTipoMovimiento.ID.STR())
         Else
           R.add("pr_50040105535","")
         End if
         R.add("pr_50040105531", me.PermitirProductosFueraDeCatalogo.AdaptarMySQL_Boolean())
         R.add("pr_50040105532", me.ImporteSaldoPromocionalGeneral.AdaptarMySQL_Decimal())
         R.add("pr_500401055313", me.ElPrecioIndicadoIncluyeLosImpuestos.AdaptarMySQL_Boolean())
         R.add("pr_500401055310", me.DescuentoAdicionalADeseadoPorciento.AdaptarMySQL_Decimal())
         If Me.ReferenciaCatalogo IsNot nothing then
           R.add("pr_500401055321",me.ReferenciaCatalogo.ID.STR())
         Else
           R.add("pr_500401055321","")
         End if
         If Me.ReferenciaMedidaBase IsNot nothing then
           R.add("pr_500401055319",me.ReferenciaMedidaBase.ID.STR())
         Else
           R.add("pr_500401055319","")
         End if
         If Me.ReferenciaProductoNoSustituido IsNot nothing then
           R.add("pr_500401055316",me.ReferenciaProductoNoSustituido.ID.STR())
         Else
           R.add("pr_500401055316","")
         End if
         R.add("pr_500401055315", me.DescuentoProductoDeseadoPorciento.AdaptarMySQL_Decimal())
         R.add("pr_500401055318", me.ImporteSaldoPromocionalFijoPorUnidadDeseado.AdaptarMySQL_Decimal())
         R.add("pr_500401055327", me.DescuentoOfertaDeseadoPorciento.AdaptarMySQL_Decimal())
         R.add("pr_500401055322", me.CantidadUnidadMedidaBase.AdaptarMySQL_Decimal())
         If Me.ReferenciaEmpleadoPrincipal IsNot nothing then
           R.add("pr_500401055216",me.ReferenciaEmpleadoPrincipal.ID.STR())
         Else
           R.add("pr_500401055216","")
         End if
         R.add("pr_500401055335", me.MovimientoDeInventarioAutomatico.AdaptarMySQL_Boolean())
         R.add("pr_500401055341", me.DescuentoAdicionalAAplicadoPorciento.AdaptarMySQL_Decimal())
         If Me.ReferenciaPresupuestoDeVenta IsNot nothing then
           R.add("pr_50040105791",me.ReferenciaPresupuestoDeVenta.ID.STR())
         Else
           R.add("pr_50040105791","")
         End if
         R.add("pr_500401055337", me.EvaluarStock.AdaptarMySQL_Boolean())
         If Me.ReferenciaElementoCatalogo IsNot nothing then
           R.add("pr_500401055342",me.ReferenciaElementoCatalogo.ID.STR())
         Else
           R.add("pr_500401055342","")
         End if
         R.add("pr_500401055343", me.DescuentoGeneralAplicadoPorciento.AdaptarMySQL_Decimal())
         R.add("pr_60040105654", me.EntidadRelacionadaTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_50040106484", me.ImporteSumaConImpuestos.AdaptarMySQL_Decimal())
         If Me.ReferenciaCategoriaDeVenta IsNot nothing then
           R.add("pr_50040136172",me.ReferenciaCategoriaDeVenta.ID.STR())
         Else
           R.add("pr_50040136172","")
         End if
         If Me.ReferenciaElementoDePack IsNot nothing then
           R.add("pr_20040148294",me.ReferenciaElementoDePack.ID.STR())
         Else
           R.add("pr_20040148294","")
         End if
         R.add("pr_100401699816", me.UnidadesDeseadas.AdaptarMySQL_Decimal())
         R.add("pr_40040192151", me.ImporteCosteUnd.AdaptarMySQL_Decimal())
         R.add("pr_50040192153", me.ImporteCoste.AdaptarMySQL_Decimal())
         R.add("pr_50040192151", me.ImporteMargenUnd.AdaptarMySQL_Decimal())
         R.add("pr_50040192152", me.ImporteMargen.AdaptarMySQL_Decimal())
         R.add("pr_40040242012", me.CantidadDeProductosQueDebenEntrar.AdaptarMySQL_Decimal())
         R.add("pr_60040242001", me.TipoDeFactura.AdaptarMySQL_EnumTipoMovimientoE())
         If Me.ReferenciaRectificandoVenta IsNot nothing then
           R.add("pr_30040241991",me.ReferenciaRectificandoVenta.ID.STR())
         Else
           R.add("pr_30040241991","")
         End if
         If Me.ReferenciaRectificandoProductoVendido IsNot nothing then
           R.add("pr_20040241993",me.ReferenciaRectificandoProductoVendido.ID.STR())
         Else
           R.add("pr_20040241993","")
         End if
         R.add("pr_300402429916", me.ClaveDeOperacionIntracomunitaria.AdaptarMySQL_String())
         R.add("pr_30040252082", me.FechaContableDeVenta.AdaptarMySQL_Date_Nulable())
         R.add("pr_40040255193", me.ImporteProrrateoBI.AdaptarMySQL_Decimal())
         R.add("pr_40040255192", me.ImporteProrrateoIVA.AdaptarMySQL_Decimal())
         R.add("pr_40040255191", me.ImporteProrrateoRE.AdaptarMySQL_Decimal())
         R.add("pr_20040256622", me.EsUnGastoSuplido.AdaptarMySQL_Boolean())
         R.add("pr_20040256621", me.ImporteImporteGastoSuplido.AdaptarMySQL_Decimal())
         R.add("pr_10040266802", me.ImporteProrrateoRetencion.AdaptarMySQL_Decimal())
         If Me.ReferenciaActividad IsNot nothing then
           R.add("pr_60040281353",me.ReferenciaActividad.ID.STR())
         Else
           R.add("pr_60040281353","")
         End if
         If Me.ReferenciaRecurso IsNot nothing then
           R.add("pr_20040441201",me.ReferenciaRecurso.ID.STR())
         Else
           R.add("pr_20040441201","")
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
         If Me.RelacionElementoContenedorListador IsNot nothing then
           R.add("idrelacionlistador",me.RelacionElementoContenedorListador.ID.STR())
         Else
           R.add("idrelacionlistador","")
         End if
         R.add("listadoreliminado", me.Listadoreliminado.AdaptarMySQL_Boolean())
            Return R
          End Function
          Sub new()
          End Sub
      End Class
      Public Class VentasLista_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_500401055221")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_500401055221", value)
            End Set
          End Property
          Public property ImporteDescuentoFijoUnidadDeseado As Decimal
            get
                return me.GetValue_Decimal("pr_5004010553163")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_5004010553163", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaEntidadRelacionada As Guid
            get
                return me.GetValue_Guid("pr_60040105653")
            End Get   
        End Property
        Public ReadOnly property ImporteTotalDescontadoSinImpuestos As Decimal
            get
                return me.GetValue_Decimal("pr_5004010553160")
            End Get   
        End Property
        Public ReadOnly property PorcentajeDeImpuestosPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_5004010553169")
            End Get   
        End Property
        Public ReadOnly property DescuentoOfertaAplicadoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_5004010553171")
            End Get   
        End Property
        Public ReadOnly property FechaDato_UTC As Date
            get
                return me.GetValue_DateTime("pr_500401055219")
            End Get   
        End Property
          Public property EmpleadoTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_500401055226")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_500401055226", value)
            End Set
          End Property
        Public ReadOnly property DescuentoEntidadAplicadoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_5004010553173")
            End Get   
        End Property
        Public ReadOnly property SaldoPromocionalOfertaAplicadoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_5004010553174")
            End Get   
        End Property
        Public ReadOnly property ImporteImporteFinalTotalDescuentoNoAplicados As Decimal
            get
                return me.GetValue_Decimal("pr_5004010553179")
            End Get   
        End Property
          Public property MotivoNoSustitucion As String
            get
                return me.GetValue_String("pr_5004010553186")
            End Get
            Set(value As String)
                me.SetValue_String("pr_5004010553186", value)
            End Set
          End Property
          Public property ReferenciaProducto As Guid
            get
                return me.GetValue_Guid("pr_5004010553185")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_5004010553185", value)
            End Set
          End Property
        Public ReadOnly property ProductoEsSustitucion As Boolean
            get
                return me.GetValue_Boolean("pr_5004010553192")
            End Get   
        End Property
          Public property ModificarDtoAdicionalA As Boolean
            get
                return me.GetValue_Boolean("pr_5004010553189")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_5004010553189", value)
            End Set
          End Property
        Public ReadOnly property ImporteSumaSinImpuestos As Decimal
            get
                return me.GetValue_Decimal("pr_5004010553200")
            End Get   
        End Property
          Public property DescuentoAdicionalBMotivo As String
            get
                return me.GetValue_String("pr_5004010553195")
            End Get
            Set(value As String)
                me.SetValue_String("pr_5004010553195", value)
            End Set
          End Property
        Public ReadOnly property CantidadMedidaBasePorUnd As Decimal
            get
                return me.GetValue_Decimal("pr_5004010553196")
            End Get   
        End Property
        Public ReadOnly property ImporteSaldoPromocionalProducto As Decimal
            get
                return me.GetValue_Decimal("pr_5004010553208")
            End Get   
        End Property
        Public ReadOnly property ImporteTotalDescuentosGeneralesSinImpuestos As Decimal
            get
                return me.GetValue_Decimal("pr_5004010553206")
            End Get   
        End Property
        Public ReadOnly property ImporteImporteFinalSaldoObtenido As Decimal
            get
                return me.GetValue_Decimal("pr_5004010553204")
            End Get   
        End Property
          Public property Cantidad As Decimal
            get
                return me.GetValue_Decimal("pr_5004010553107")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_5004010553107", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_500401055218")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_500401055218", value)
            End Set
          End Property
          Public property DescuentoVIPDeseadoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_5004010553106")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_5004010553106", value)
            End Set
          End Property
          Public property ReferenciaMedida As Guid
            get
                return me.GetValue_Guid("pr_5004010553108")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_5004010553108", value)
            End Set
          End Property
        Public ReadOnly property ImporteImporteFinalTotal As Decimal
            get
                return me.GetValue_Decimal("pr_5004010553104")
            End Get   
        End Property
          Public property SaldoPromocionalOfertaDeseadoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_5004010553116")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_5004010553116", value)
            End Set
          End Property
        Public ReadOnly property ImportePrecioUnidadSinImpuestos As Decimal
            get
                return me.GetValue_Decimal("pr_5004010553109")
            End Get   
        End Property
        Public ReadOnly property DescuentoProductoAplicadoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_5004010553110")
            End Get   
        End Property
        Public ReadOnly property ImporteTotalDescuentosProductosSinImpuestos As Decimal
            get
                return me.GetValue_Decimal("pr_5004010553120")
            End Get   
        End Property
        Public ReadOnly property SaldoPromocionalGeneralGeneradoAplicadoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_5004010553119")
            End Get   
        End Property
          Public property ImportePrecioMinimo As Decimal
            get
                return me.GetValue_Decimal("pr_5004010553140")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_5004010553140", value)
            End Set
          End Property
          Public property ReferenciaLote As Guid
            get
                return me.GetValue_Guid("pr_5004010553139")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_5004010553139", value)
            End Set
          End Property
          Public property DescuentoGeneralDeseadoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_5004010553133")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_5004010553133", value)
            End Set
          End Property
        Public ReadOnly property ImporteSaldoPromocionalFijoPorUnidadAplicado As Decimal
            get
                return me.GetValue_Decimal("pr_5004010553129")
            End Get   
        End Property
          Public property ModificarDtoTipoEntidad As Boolean
            get
                return me.GetValue_Boolean("pr_5004010553130")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_5004010553130", value)
            End Set
          End Property
        Public ReadOnly property DescuentoTipoEntidadPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_5004010553136")
            End Get   
        End Property
          Public property DescuentoTipoEntidadDeseadoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_5004010553134")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_5004010553134", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaProductoSustituido As Guid
            get
                return me.GetValue_Guid("pr_5004010553147")
            End Get   
        End Property
          Public property SaldoPromocionalGeneralGeneradoDeseadoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_5004010553141")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_5004010553141", value)
            End Set
          End Property
        Public ReadOnly property ImporteImporteConImpuestos As Decimal
            get
                return me.GetValue_Decimal("pr_50040106485")
            End Get   
        End Property
          Public property SaldoPromocionalOfertaMinimoAjustablePorciento As Decimal
            get
                return me.GetValue_Decimal("pr_5004010553155")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_5004010553155", value)
            End Set
          End Property
          Public property ModificarDtoEntidad As Boolean
            get
                return me.GetValue_Boolean("pr_5004010553153")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_5004010553153", value)
            End Set
          End Property
        Public ReadOnly property CantidadUnidades As Decimal
            get
                return me.GetValue_Decimal("pr_500401055359")
            End Get   
        End Property
          Public property ModificarSaldoPromocionalGeneral As Boolean
            get
                return me.GetValue_Boolean("pr_500401055358")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_500401055358", value)
            End Set
          End Property
          Public property ReferenciaElementoReservado As Guid
            get
                return me.GetValue_Guid("pr_500401055355")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_500401055355", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaReserva As Guid
            get
                return me.GetValue_Guid("pr_50040105793")
            End Get   
        End Property
          Public property ReferenciaUbicacionPrincipal As Guid
            get
                return me.GetValue_Guid("pr_500401055217")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_500401055217", value)
            End Set
          End Property
          Public property DescuentoAdicionalAMotivo As String
            get
                return me.GetValue_String("pr_500401055362")
            End Get
            Set(value As String)
                me.SetValue_String("pr_500401055362", value)
            End Set
          End Property
        Public ReadOnly property ImporteImporteSinImpuestos As Decimal
            get
                return me.GetValue_Decimal("pr_500401055361")
            End Get   
        End Property
        Public ReadOnly property TotalPorcentajeDeDescuentoAplicadoAProductoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_500401055360")
            End Get   
        End Property
          Public property ModificarDtoAdicionalB As Boolean
            get
                return me.GetValue_Boolean("pr_500401055371")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_500401055371", value)
            End Set
          End Property
          Public property ImportePrecioUnidad As Decimal
            get
                return me.GetValue_Decimal("pr_500401055369")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_500401055369", value)
            End Set
          End Property
        Public ReadOnly property DescuentoAdicionalBAplicadoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_500401055368")
            End Get   
        End Property
        Public ReadOnly property ImporteImporteFinalRetencion As Decimal
            get
                return me.GetValue_Decimal("pr_500401055379")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As DateTime
            get
                return me.GetValue_DateTime("pr_500401055220")
            End Get   
        End Property
          Public property DescuentoEntidadDeseadoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_500401055374")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_500401055374", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_500401055224")
            End Get   
        End Property
        Public ReadOnly property DescuentoVIPAplicadoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_500401055373")
            End Get   
        End Property
        Public ReadOnly property CantidadDeProductosQueDebenDeSalir As Decimal
            get
                return me.GetValue_Decimal("pr_500401055381")
            End Get   
        End Property
        Public ReadOnly property ImportePrecioUnidadConImpuestos As Decimal
            get
                return me.GetValue_Decimal("pr_50040106486")
            End Get   
        End Property
          Public property DescuentoAdicionalBDeseadoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_500401055383")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_500401055383", value)
            End Set
          End Property
          Public property ReferenciaImpuesto As Guid
            get
                return me.GetValue_Guid("pr_500401055380")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_500401055380", value)
            End Set
          End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_500401055228")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_500401055228", value)
            End Set
          End Property
          Public property ModificarDtoGeneral As Boolean
            get
                return me.GetValue_Boolean("pr_5004010553100")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_5004010553100", value)
            End Set
          End Property
          Public property ModificarDtoVIP As Boolean
            get
                return me.GetValue_Boolean("pr_5004010553102")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_5004010553102", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaMovimientoInternoDeInventario As Guid
            get
                return me.GetValue_Guid("pr_40040106601")
            End Get   
        End Property
        Public ReadOnly property ImporteImporteFinalImpuestos As Decimal
            get
                return me.GetValue_Decimal("pr_500401055393")
            End Get   
        End Property
        Public ReadOnly property ImporteDtoFijoPorUnidadAplicado As Decimal
            get
                return me.GetValue_Decimal("pr_500401055394")
            End Get   
        End Property
        Public ReadOnly property CantidadDeProductosQuePuedenRectificarse As Decimal
            get
                return me.GetValue_Decimal("pr_50040105533")
            End Get   
        End Property
          Public property ReferenciaElementoDePresupuestoDeVenta As Guid
            get
                return me.GetValue_Guid("pr_50040105792")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_50040105792", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaTipoMovimiento As Guid
            get
                return me.GetValue_Guid("pr_50040105535")
            End Get   
        End Property
          Public property PermitirProductosFueraDeCatalogo As Boolean
            get
                return me.GetValue_Boolean("pr_50040105531")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_50040105531", value)
            End Set
          End Property
        Public ReadOnly property ImporteSaldoPromocionalGeneral As Decimal
            get
                return me.GetValue_Decimal("pr_50040105532")
            End Get   
        End Property
        Public ReadOnly property ElPrecioIndicadoIncluyeLosImpuestos As Boolean
            get
                return me.GetValue_Boolean("pr_500401055313")
            End Get   
        End Property
          Public property DescuentoAdicionalADeseadoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_500401055310")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_500401055310", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaCatalogo As Guid
            get
                return me.GetValue_Guid("pr_500401055321")
            End Get   
        End Property
        Public ReadOnly property ReferenciaMedidaBase As Guid
            get
                return me.GetValue_Guid("pr_500401055319")
            End Get   
        End Property
        Public ReadOnly property ReferenciaProductoNoSustituido As Guid
            get
                return me.GetValue_Guid("pr_500401055316")
            End Get   
        End Property
          Public property DescuentoProductoDeseadoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_500401055315")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_500401055315", value)
            End Set
          End Property
          Public property ImporteSaldoPromocionalFijoPorUnidadDeseado As Decimal
            get
                return me.GetValue_Decimal("pr_500401055318")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_500401055318", value)
            End Set
          End Property
          Public property DescuentoOfertaDeseadoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_500401055327")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_500401055327", value)
            End Set
          End Property
        Public ReadOnly property CantidadUnidadMedidaBase As Decimal
            get
                return me.GetValue_Decimal("pr_500401055322")
            End Get   
        End Property
          Public property ReferenciaEmpleadoPrincipal As Guid
            get
                return me.GetValue_Guid("pr_500401055216")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_500401055216", value)
            End Set
          End Property
          Public property MovimientoDeInventarioAutomatico As Boolean
            get
                return me.GetValue_Boolean("pr_500401055335")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_500401055335", value)
            End Set
          End Property
        Public ReadOnly property DescuentoAdicionalAAplicadoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_500401055341")
            End Get   
        End Property
          Public property ReferenciaPresupuestoDeVenta As Guid
            get
                return me.GetValue_Guid("pr_50040105791")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_50040105791", value)
            End Set
          End Property
          Public property EvaluarStock As Boolean
            get
                return me.GetValue_Boolean("pr_500401055337")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_500401055337", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaElementoCatalogo As Guid
            get
                return me.GetValue_Guid("pr_500401055342")
            End Get   
        End Property
        Public ReadOnly property DescuentoGeneralAplicadoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_500401055343")
            End Get   
        End Property
          Public property EntidadRelacionadaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_60040105654")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_60040105654", value)
            End Set
          End Property
        Public ReadOnly property ImporteSumaConImpuestos As Decimal
            get
                return me.GetValue_Decimal("pr_50040106484")
            End Get   
        End Property
          Public property ReferenciaCategoriaDeVenta As Guid
            get
                return me.GetValue_Guid("pr_50040136172")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_50040136172", value)
            End Set
          End Property
          Public property ReferenciaElementoDePack As Guid
            get
                return me.GetValue_Guid("pr_20040148294")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_20040148294", value)
            End Set
          End Property
          Public property UnidadesDeseadas As Decimal
            get
                return me.GetValue_Decimal("pr_100401699816")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_100401699816", value)
            End Set
          End Property
          Public property ImporteCosteUnd As Decimal
            get
                return me.GetValue_Decimal("pr_40040192151")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_40040192151", value)
            End Set
          End Property
        Public ReadOnly property ImporteCoste As Decimal
            get
                return me.GetValue_Decimal("pr_50040192153")
            End Get   
        End Property
        Public ReadOnly property ImporteMargenUnd As Decimal
            get
                return me.GetValue_Decimal("pr_50040192151")
            End Get   
        End Property
        Public ReadOnly property ImporteMargen As Decimal
            get
                return me.GetValue_Decimal("pr_50040192152")
            End Get   
        End Property
          Public property CantidadDeProductosQueDebenEntrar As Decimal
            get
                return me.GetValue_Decimal("pr_40040242012")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_40040242012", value)
            End Set
          End Property
          Public property TipoDeFactura__Int as Integer
            get
                return me.GetValue_Int("pr_60040242001")
            End Get
            Set(value as Integer)
                me.SetValue_Int("pr_60040242001", value)
            End Set
          End Property
          Public property TipoDeFactura As EnumTipoMovimientoE
            get
                return me.GetValue_Int("pr_60040242001")
            End Get
            Set(value As EnumTipoMovimientoE)
                me.SetValue_Int("pr_60040242001", value)
            End Set
          End Property
          Public property ReferenciaRectificandoVenta As Guid
            get
                return me.GetValue_Guid("pr_30040241991")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_30040241991", value)
            End Set
          End Property
          Public property ReferenciaRectificandoProductoVendido As Guid
            get
                return me.GetValue_Guid("pr_20040241993")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_20040241993", value)
            End Set
          End Property
          Public property ClaveDeOperacionIntracomunitaria As String
            get
                return me.GetValue_String("pr_300402429916")
            End Get
            Set(value As String)
                me.SetValue_String("pr_300402429916", value)
            End Set
          End Property
          Public property FechaContableDeVenta As Date
            get
                return me.GetValue_Date("pr_30040252082")
            End Get
            Set(value As Date)
                me.SetValue_Date("pr_30040252082", value)
            End Set
          End Property
        Public ReadOnly property ImporteProrrateoBI As Decimal
            get
                return me.GetValue_Decimal("pr_40040255193")
            End Get   
        End Property
        Public ReadOnly property ImporteProrrateoIVA As Decimal
            get
                return me.GetValue_Decimal("pr_40040255192")
            End Get   
        End Property
        Public ReadOnly property ImporteProrrateoRE As Decimal
            get
                return me.GetValue_Decimal("pr_40040255191")
            End Get   
        End Property
          Public property EsUnGastoSuplido As Boolean
            get
                return me.GetValue_Boolean("pr_20040256622")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_20040256622", value)
            End Set
          End Property
          Public property ImporteImporteGastoSuplido As Decimal
            get
                return me.GetValue_Decimal("pr_20040256621")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_20040256621", value)
            End Set
          End Property
          Public property ImporteProrrateoRetencion As Decimal
            get
                return me.GetValue_Decimal("pr_10040266802")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_10040266802", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaActividad As Guid
            get
                return me.GetValue_Guid("pr_60040281353")
            End Get   
        End Property
          Public property ReferenciaRecurso As Guid
            get
                return me.GetValue_Guid("pr_20040441201")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_20040441201", value)
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
        Public ReadOnly property RelacionElementoContenedorListador As Guid
            get
                return me.GetValue_Guid("idrelacionlistador")
            End Get   
        End Property
          Public property Listadoreliminado As Boolean
            get
                return me.GetValue_Boolean("listadoreliminado")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("listadoreliminado", value)
            End Set
          End Property
          Sub New(___VV__ As DinaNETCore.API_VVC , _Token$)
              MyBase.New(___VV__, _Token) 
              Me.Evento_Actualizar()
          End Sub
      End Class
  End Class
End Class
