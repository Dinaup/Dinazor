   Imports System.ComponentModel
   Imports DinaNETCore
   Imports DinaNETCore.APID
Partial Public Class SeccionesD
  Public Class FacturasProformaListaD
      Public Shared _SeccionID As String = "510172c2-7a98-4bc2-951f-a9c902e4bc75"
      Public Shared _SeccionIDGUID As New Guid("510172c2-7a98-4bc2-951f-a9c902e4bc75")
      Public Shared Async Function ConsultarDatos_Async(Parametros As SeccionConsultaParametrosC) As Task(Of List(Of FacturasProformaListaC )) 
          Dim R As New List(Of FacturasProformaListaC )  
          Dim d = Await Parametros.DinaupSesion.ConexionServidor.Funcion_Datos_Recibir_Async(FacturasProformaListaES._SeccionID, False, Parametros) 
          If d.Datos.TieneDatos Then 
              For Each Actual In d.Datos 
                  Dim Valores_Listador = Actual.Value.Item1
                  Dim Obj_Listador As New FacturasProformaListaC 
                  Obj_Listador.CargarDatos(Valores_Listador) 
                  Obj_Listador.CargaInterna(Actual.Value)
                  R.Add(Obj_Listador) 
              Next 
          End If 
          Return R 
      End Function 
      Public Class FacturasProformaListaES
          Public shared _SeccionID as Guid = New Guid("510172c2-7a98-4bc2-951f-a9c902e4bc75")
          Public shared _Tabla$ = "tpr_300401055512_e"
      Public Shared ReferenciaImpuesto$ = "pr_1004010580143"
      Public Shared Motivo$ = "pr_1004010580135"
      Public Shared ImporteTotalDescontadoSinImpuestos$ = "pr_1004010580102"
      Public Shared ImporteImporteSinImpuestos$ = "pr_100401058099"
      Public Shared ReferenciaMedida$ = "pr_1004010580142"
      Public Shared SaldoPromocionalGeneralGeneradoAplicadoPorciento$ = "pr_1004010580100"
      Public Shared ImporteImporteConImpuestos$ = "pr_100401064911"
      Public Shared DescuentoAdicionalBDeseadoPorciento$ = "pr_1004010580101"
      Public Shared DescuentoGeneralAplicadoPorciento$ = "pr_1004010580104"
      Public Shared SaldoPromocionalOfertaMinimoAjustablePorciento$ = "pr_1004010580105"
      Public Shared ReferenciaEntidadRelacionada$ = "pr_1004010580146"
      Public Shared ModificarDtoTipoEntidad$ = "pr_100401058081"
      Public Shared DescuentoAdicionalADeseadoPorciento$ = "pr_1004010580107"
      Public Shared DescuentoTipoEntidadDeseadoPorciento$ = "pr_1004010580106"
      Public Shared ImporteTotalDescuentosGeneralesSinImpuestos$ = "pr_1004010580108"
      Public Shared ReferenciaPresupuestoDeVenta$ = "pr_50040105802"
      Public Shared DescuentoTipoEntidadPorciento$ = "pr_1004010580109"
      Public Shared DescuentoEntidadDeseadoPorciento$ = "pr_1004010580110"
      Public Shared ReferenciaAutorDelAlta$ = "pr_3004010555311"
      Public Shared ElPrecioIndicadoIncluyeLosImpuestos$ = "pr_100401058080"
      Public Shared ImportePrecioUnidad$ = "pr_1004010580103"
      Public Shared ReferenciaTipoMovimiento$ = "pr_1004010580145"
      Public Shared TotalPorcentajeDeDescuentoAplicadoAProductoPorciento$ = "pr_100401058092"
      Public Shared ImportePrecioUnidadConImpuestos$ = "pr_10040106692"
      Public Shared ReferenciaMedidaBase$ = "pr_1004010580138"
      Public Shared Cantidad$ = "pr_100401058093"
      Public Shared DescuentoGeneralDeseadoPorciento$ = "pr_100401058089"
      Public Shared SaldoPromocionalGeneralGeneradoDeseadoPorciento$ = "pr_100401058090"
      Public Shared ModificarDtoVIP$ = "pr_100401058078"
      Public Shared DescuentoVIPDeseadoPorciento$ = "pr_100401058091"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_3004010555336"
      Public Shared DescuentoProductoDeseadoPorciento$ = "pr_100401058096"
      Public Shared ImporteSaldoPromocionalFijoPorUnidadDeseado$ = "pr_100401058097"
      Public Shared ImporteImporteFinalRetencion$ = "pr_100401058098"
      Public Shared FechaAlta_UTC$ = "pr_3004010555314"
      Public Shared ImporteSumaSinImpuestos$ = "pr_100401058094"
      Public Shared ReferenciaProducto$ = "pr_1004010580141"
      Public Shared ReferenciaElementoCatalogo$ = "pr_1004010580140"
      Public Shared FechaDato_UTC$ = "pr_3004010555312"
      Public Shared DescuentoAdicionalAAplicadoPorciento$ = "pr_100401058095"
      Public Shared CantidadUnidades$ = "pr_1004010580123"
      Public Shared ImportePrecioMinimo$ = "pr_1004010580124"
      Public Shared DescuentoOfertaAplicadoPorciento$ = "pr_1004010580125"
      Public Shared ModificarDtoEntidad$ = "pr_100401058087"
      Public Shared DescuentoAdicionalBAplicadoPorciento$ = "pr_1004010580127"
      Public Shared ImporteSaldoPromocionalGeneral$ = "pr_1004010580126"
      Public Shared DescuentoOfertaDeseadoPorciento$ = "pr_1004010580122"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_3004010555309"
      Public Shared ModificarDtoAdicionalB$ = "pr_100401058086"
      Public Shared ImportePrecioUnidadSinImpuestos$ = "pr_1004010580130"
      Public Shared CantidadMedidaBasePorUnd$ = "pr_1004010580132"
      Public Shared ImporteTotalDescuentosProductosSinImpuestos$ = "pr_1004010580131"
      Public Shared ImporteDtoFijoPorUnidadAplicado$ = "pr_1004010580133"
      Public Shared DescuentoVIPAplicadoPorciento$ = "pr_1004010580134"
      Public Shared ModificarSaldoPromocionalGeneral$ = "pr_100401058088"
      Public Shared PorcentajeDeImpuestosPorciento$ = "pr_1004010580128"
      Public Shared ImporteImporteFinalSaldoObtenido$ = "pr_1004010580129"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_3004010555334"
      Public Shared ImporteImporteFinalTotalDescuentoNoAplicados$ = "pr_1004010580113"
      Public Shared DescuentoAdicionalBMotivo$ = "pr_1004010580136"
      Public Shared ImporteImporteFinalTotal$ = "pr_1004010580115"
      Public Shared CantidadUnidadMedidaBase$ = "pr_1004010580114"
      Public Shared ReferenciaCatalogo$ = "pr_1004010580147"
      Public Shared ImporteDescuentoFijoUnidadDeseado$ = "pr_1004010580116"
      Public Shared EntidadRelacionadaTieneAccesoWeb$ = "pr_1004010580148"
      Public Shared ModificarDtoAdicionalA$ = "pr_100401058082"
      Public Shared DescuentoProductoAplicadoPorciento$ = "pr_1004010580111"
      Public Shared ModificarDtoGeneral$ = "pr_100401058083"
      Public Shared ImporteSumaConImpuestos$ = "pr_100401064912"
      Public Shared ImporteSaldoPromocionalFijoPorUnidadAplicado$ = "pr_1004010580112"
      Public Shared PermitirProductosFueraDeCatalogo$ = "pr_100401058085"
      Public Shared DescuentoEntidadAplicadoPorciento$ = "pr_1004010580119"
      Public Shared HoraLocal$ = "pr_3004010555313"
      Public Shared ImporteImporteFinalImpuestos$ = "pr_1004010580120"
      Public Shared SaldoPromocionalOfertaAplicadoPorciento$ = "pr_1004010580121"
      Public Shared ReferenciaDestinador$ = "pr_3004010555317"
      Public Shared ImporteSaldoPromocionalProducto$ = "pr_1004010580117"
      Public Shared SaldoPromocionalOfertaDeseadoPorciento$ = "pr_1004010580118"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_3004010555310"
      Public Shared ReferenciaElementoDePresupuestoDeVenta$ = "pr_50040105801"
      Public Shared DescuentoAdicionalAMotivo$ = "pr_1004010580137"
      Public Shared ReferenciaTipoDeVenta$ = "pr_10040136184"
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
      Public Class FacturasProformaListaC
      Inherits Base_DatoC
          <DisplayName("Impuesto")>
          Public Property ReferenciaImpuesto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaImpuesto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaImpuesto"",""etiqueta"": ""Impuesto"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""f3199ee0-dc83-4667-a9c1-f3b04e97a8a4"",""titulo"": ""Base - Impuestos"",""iconoid"": ""ff4a7189-6426-43b9-bdc4-070314999e81"",""etiquetasingular"": ""Impuesto"",""etiquetaplural"": ""Impuestos"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""f3199ee0-dc83-4667-a9c1-f3b04e97a8a4"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Impuesto"",""descripcion"": """",""keyword"": ""ReferenciaImpuesto"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaImpuesto As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaImpuesto
          <DisplayName("Motivo")>
          Public Property Motivo As String
          Public Shared ___Motivo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Motivo"",""etiqueta"": ""Motivo"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Motivo"",""descripcion"": """",""keyword"": ""Motivo"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Motivo As DinaNETCore.APID.DinaupAPI_CampoC = ___Motivo
          <DisplayName("Total Descontado (Sin Impuestos)")>
          Public Property ImporteTotalDescontadoSinImpuestos As Decimal
          Public Shared ___ImporteTotalDescontadoSinImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteTotalDescontadoSinImpuestos"",""etiqueta"": ""Total Descontado (Sin Impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""6"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total Descontado (Sin Impuestos)"",""descripcion"": """",""keyword"": ""ImporteTotalDescontadoSinImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteTotalDescontadoSinImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteTotalDescontadoSinImpuestos
          <Description("Precio total de venta, sin descuentos generales aplicados ni impuestos.")>
          <DisplayName("Importe (Sin impuestos)")>
          Public Property ImporteImporteSinImpuestos As Decimal
          Public Shared ___ImporteImporteSinImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteImporteSinImpuestos"",""etiqueta"": ""Importe (Sin impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Importe (Sin impuestos)"",""descripcion"": """",""keyword"": ""ImporteImporteSinImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteImporteSinImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteImporteSinImpuestos
          <DisplayName("Medida")>
          Public Property ReferenciaMedida As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaMedida As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaMedida"",""etiqueta"": ""Medida"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c84f0381-d030-4223-a4e1-da78dda62ab4"",""titulo"": ""Base - Unidades de medida"",""iconoid"": ""0323688b-82a5-4fb7-a9f5-ff1247a52998"",""etiquetasingular"": ""Unidad de medida"",""etiquetaplural"": ""Unidades de medida"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""c84f0381-d030-4223-a4e1-da78dda62ab4"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Medida"",""descripcion"": """",""keyword"": ""ReferenciaMedida"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaMedida As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaMedida
          <Description("El porcentaje de saldo obtenido por esta transacción.")>
          <DisplayName("Saldo promocional General generado % (Aplicado)")>
          Public Property SaldoPromocionalGeneralGeneradoAplicadoPorciento As Decimal
          Public Shared ___SaldoPromocionalGeneralGeneradoAplicadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""SaldoPromocionalGeneralGeneradoAplicadoPorciento"",""etiqueta"": ""Saldo promocional General generado % (Aplicado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Saldo promocional General generado % (Aplicado)"",""descripcion"": """",""keyword"": ""SaldoPromocionalGeneralGeneradoAplicadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __SaldoPromocionalGeneralGeneradoAplicadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___SaldoPromocionalGeneralGeneradoAplicadoPorciento
          <DisplayName("Importe (Con Impuestos)")>
          Public Property ImporteImporteConImpuestos As Decimal
          Public Shared ___ImporteImporteConImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteImporteConImpuestos"",""etiqueta"": ""Importe (Con Impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""10"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Importe (Con Impuestos)"",""descripcion"": """",""keyword"": ""ImporteImporteConImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteImporteConImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteImporteConImpuestos
          <Description("Descuento adicional configurable." & vbCrLf & "(Este es el ""Deseado"", podría modificarse según la configuración de ajustes de descuentos indicada y podría diferir del descuento aplicado finalmente)")>
          <DisplayName("Descuento Adicional B % (Deseado)")>
          Public Property DescuentoAdicionalBDeseadoPorciento As Decimal
          Public Shared ___DescuentoAdicionalBDeseadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoAdicionalBDeseadoPorciento"",""etiqueta"": ""Descuento Adicional B % (Deseado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento Adicional B % (Deseado)"",""descripcion"": """",""keyword"": ""DescuentoAdicionalBDeseadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoAdicionalBDeseadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoAdicionalBDeseadoPorciento
          <Description("Descuento general indicado que se ha aplicado.")>
          <DisplayName("Descuento General % (Aplicado)")>
          Public Property DescuentoGeneralAplicadoPorciento As Decimal
          Public Shared ___DescuentoGeneralAplicadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoGeneralAplicadoPorciento"",""etiqueta"": ""Descuento General % (Aplicado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento General % (Aplicado)"",""descripcion"": """",""keyword"": ""DescuentoGeneralAplicadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoGeneralAplicadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoGeneralAplicadoPorciento
          <Description("Porcentaje de saldo promocional mínimo que se ajustará por una oferta.")>
          <DisplayName("Saldo Promocional Oferta Mínimo Ajustable %")>
          Public Property SaldoPromocionalOfertaMinimoAjustablePorciento As Decimal
          Public Shared ___SaldoPromocionalOfertaMinimoAjustablePorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""SaldoPromocionalOfertaMinimoAjustablePorciento"",""etiqueta"": ""Saldo Promocional Oferta Mínimo Ajustable %"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Saldo Promocional Oferta Mínimo Ajustable %"",""descripcion"": """",""keyword"": ""SaldoPromocionalOfertaMinimoAjustablePorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __SaldoPromocionalOfertaMinimoAjustablePorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___SaldoPromocionalOfertaMinimoAjustablePorciento
          <DisplayName("Entidad Relacionada")>
          Public Property ReferenciaEntidadRelacionada As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaEntidadRelacionada As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaEntidadRelacionada"",""etiqueta"": ""Entidad Relacionada"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Entidad Relacionada"",""descripcion"": """",""keyword"": ""ReferenciaEntidadRelacionada"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaEntidadRelacionada As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaEntidadRelacionada
          <DisplayName("Modificar Dto. Tipo Entidad")>
          Public Property ModificarDtoTipoEntidad As Boolean
          Public Shared ___ModificarDtoTipoEntidad As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ModificarDtoTipoEntidad"",""etiqueta"": ""Modificar Dto. Tipo Entidad"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Modificar Dto. Tipo Entidad"",""descripcion"": """",""keyword"": ""ModificarDtoTipoEntidad"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ModificarDtoTipoEntidad As DinaNETCore.APID.DinaupAPI_CampoC = ___ModificarDtoTipoEntidad
          <Description("Descuento adicional configurable." & vbCrLf & "(Este es el ""Deseado"", podría modificarse según la configuración de ajustes de descuentos indicada, este valor puede ser distinto al aplicado finalmente)")>
          <DisplayName("Descuento Adicional A % (Deseado)")>
          Public Property DescuentoAdicionalADeseadoPorciento As Decimal
          Public Shared ___DescuentoAdicionalADeseadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoAdicionalADeseadoPorciento"",""etiqueta"": ""Descuento Adicional A % (Deseado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento Adicional A % (Deseado)"",""descripcion"": """",""keyword"": ""DescuentoAdicionalADeseadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoAdicionalADeseadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoAdicionalADeseadoPorciento
          <Description("Descuento indicado en la configuración del tipo de entidad." & vbCrLf & "(Este es el ""Deseado"", podría modificarse según la configuración de ajustes de descuentos indicada)")>
          <DisplayName("Descuento tipo entidad % (Deseado)")>
          Public Property DescuentoTipoEntidadDeseadoPorciento As Decimal
          Public Shared ___DescuentoTipoEntidadDeseadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoTipoEntidadDeseadoPorciento"",""etiqueta"": ""Descuento tipo entidad % (Deseado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento tipo entidad % (Deseado)"",""descripcion"": """",""keyword"": ""DescuentoTipoEntidadDeseadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoTipoEntidadDeseadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoTipoEntidadDeseadoPorciento
          <DisplayName("Total Descuentos (Generales) (Sin Impuestos)")>
          Public Property ImporteTotalDescuentosGeneralesSinImpuestos As Decimal
          Public Shared ___ImporteTotalDescuentosGeneralesSinImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteTotalDescuentosGeneralesSinImpuestos"",""etiqueta"": ""Total Descuentos (Generales) (Sin Impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""6"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total Descuentos (Generales) (Sin Impuestos)"",""descripcion"": """",""keyword"": ""ImporteTotalDescuentosGeneralesSinImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteTotalDescuentosGeneralesSinImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteTotalDescuentosGeneralesSinImpuestos
          <DisplayName("Presupuesto de venta")>
          Public Property ReferenciaPresupuestoDeVenta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaPresupuestoDeVenta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaPresupuestoDeVenta"",""etiqueta"": ""Presupuesto de venta"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""b0502d52-b315-487b-a911-0e60f022b6cc"",""titulo"": ""Base - Presupuestos de venta"",""iconoid"": ""9dbff307-faa5-4795-a496-c8334f0fa5f3"",""etiquetasingular"": ""Presupuesto de venta"",""etiquetaplural"": ""Presupuestos de venta"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""b0502d52-b315-487b-a911-0e60f022b6cc"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Presupuesto de venta"",""descripcion"": """",""keyword"": ""ReferenciaPresupuestoDeVenta"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaPresupuestoDeVenta As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaPresupuestoDeVenta
          <Description("Descuento configurado en el tipo de entidad.")>
          <DisplayName("Descuento tipo entidad %")>
          Public Property DescuentoTipoEntidadPorciento As Decimal
          Public Shared ___DescuentoTipoEntidadPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoTipoEntidadPorciento"",""etiqueta"": ""Descuento tipo entidad %"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento tipo entidad %"",""descripcion"": """",""keyword"": ""DescuentoTipoEntidadPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoTipoEntidadPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoTipoEntidadPorciento
          <Description("Descuento relacionado con la entidad indicada." & vbCrLf & "(Este es el ""Deseado"", podría modificarse según la configuración de ajustes de descuentos indicada, este valor puede ser distinto al aplicado finalmente)")>
          <DisplayName("Descuento Entidad % (Deseado)")>
          Public Property DescuentoEntidadDeseadoPorciento As Decimal
          Public Shared ___DescuentoEntidadDeseadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoEntidadDeseadoPorciento"",""etiqueta"": ""Descuento Entidad % (Deseado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento Entidad % (Deseado)"",""descripcion"": """",""keyword"": ""DescuentoEntidadDeseadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoEntidadDeseadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoEntidadDeseadoPorciento
          <DisplayName("Autor del alta")>
          Public Property ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaAutorDelAlta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaAutorDelAlta"",""etiqueta"": ""Autor del alta"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta"",""descripcion"": """",""keyword"": ""ReferenciaAutorDelAlta"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaAutorDelAlta
          <DisplayName("El precio indicado incluye los impuestos")>
          Public Property ElPrecioIndicadoIncluyeLosImpuestos As Boolean
          Public Shared ___ElPrecioIndicadoIncluyeLosImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ElPrecioIndicadoIncluyeLosImpuestos"",""etiqueta"": ""El precio indicado incluye los impuestos"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""El precio indicado incluye los impuestos"",""descripcion"": """",""keyword"": ""ElPrecioIndicadoIncluyeLosImpuestos"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ElPrecioIndicadoIncluyeLosImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ElPrecioIndicadoIncluyeLosImpuestos
          <DisplayName("Precio unidad")>
          Public Property ImportePrecioUnidad As Decimal
          Public Shared ___ImportePrecioUnidad As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImportePrecioUnidad"",""etiqueta"": ""Precio unidad"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""6"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Precio unidad"",""descripcion"": """",""keyword"": ""ImportePrecioUnidad"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImportePrecioUnidad As DinaNETCore.APID.DinaupAPI_CampoC = ___ImportePrecioUnidad
          <DisplayName("Tipo movimiento")>
          Public Property ReferenciaTipoMovimiento As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaTipoMovimiento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaTipoMovimiento"",""etiqueta"": ""Tipo movimiento"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""ef5644b0-fb98-4191-908d-99594d9e1cc5"",""titulo"": ""Base - Tipos de movimiento"",""iconoid"": ""d720d25f-f5b8-4c83-a9f3-a8bf6cb31468"",""etiquetasingular"": ""Tipo de movimiento"",""etiquetaplural"": ""Tipos de movimiento"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""ef5644b0-fb98-4191-908d-99594d9e1cc5"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Tipo movimiento"",""descripcion"": """",""keyword"": ""ReferenciaTipoMovimiento"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaTipoMovimiento As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaTipoMovimiento
          <DisplayName("Total Porcentaje de descuento aplicado a producto")>
          Public Property TotalPorcentajeDeDescuentoAplicadoAProductoPorciento As Decimal
          Public Shared ___TotalPorcentajeDeDescuentoAplicadoAProductoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TotalPorcentajeDeDescuentoAplicadoAProductoPorciento"",""etiqueta"": ""Total Porcentaje de descuento aplicado a producto"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total Porcentaje de descuento aplicado a producto"",""descripcion"": """",""keyword"": ""TotalPorcentajeDeDescuentoAplicadoAProductoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __TotalPorcentajeDeDescuentoAplicadoAProductoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___TotalPorcentajeDeDescuentoAplicadoAProductoPorciento
          <DisplayName("Precio Unidad (Con Impuestos)")>
          Public Property ImportePrecioUnidadConImpuestos As Decimal
          Public Shared ___ImportePrecioUnidadConImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImportePrecioUnidadConImpuestos"",""etiqueta"": ""Precio Unidad (Con Impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""10"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Precio Unidad (Con Impuestos)"",""descripcion"": """",""keyword"": ""ImportePrecioUnidadConImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImportePrecioUnidadConImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImportePrecioUnidadConImpuestos
          <DisplayName("Medida (Base)")>
          Public Property ReferenciaMedidaBase As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaMedidaBase As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaMedidaBase"",""etiqueta"": ""Medida (Base)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c84f0381-d030-4223-a4e1-da78dda62ab4"",""titulo"": ""Base - Unidades de medida"",""iconoid"": ""0323688b-82a5-4fb7-a9f5-ff1247a52998"",""etiquetasingular"": ""Unidad de medida"",""etiquetaplural"": ""Unidades de medida"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""c84f0381-d030-4223-a4e1-da78dda62ab4"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Medida (Base)"",""descripcion"": """",""keyword"": ""ReferenciaMedidaBase"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaMedidaBase As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaMedidaBase
          <Description("Cantidad de productos o cantidad de la medida seleccionada.")>
          <DisplayName("Cantidad")>
          Public Property Cantidad As Decimal
          Public Shared ___Cantidad As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Cantidad"",""etiqueta"": ""Cantidad"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""11"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": false,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cantidad"",""descripcion"": """",""keyword"": ""Cantidad"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Cantidad As DinaNETCore.APID.DinaupAPI_CampoC = ___Cantidad
          <Description("Descuento general indicado para esta transacción." & vbCrLf & "(Este es el ""Deseado"", podría modificarse según la configuración de ajustes de descuentos indicada, este valor puede ser distinto al aplicado finalmente)")>
          <DisplayName("Descuento General % (Deseado)")>
          Public Property DescuentoGeneralDeseadoPorciento As Decimal
          Public Shared ___DescuentoGeneralDeseadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoGeneralDeseadoPorciento"",""etiqueta"": ""Descuento General % (Deseado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento General % (Deseado)"",""descripcion"": """",""keyword"": ""DescuentoGeneralDeseadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoGeneralDeseadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoGeneralDeseadoPorciento
          <Description("El porcentaje de saldo obtenido por esta transacción." & vbCrLf & "Descuento adicional configurable." & vbCrLf & "(Este es el ""Deseado"", podría modificarse según la configuración de ajustes de bonificaciones indicada y podría diferir del valor aplicado finalmente)")>
          <DisplayName("Saldo promocional General generado % (Deseado)")>
          Public Property SaldoPromocionalGeneralGeneradoDeseadoPorciento As Decimal
          Public Shared ___SaldoPromocionalGeneralGeneradoDeseadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""SaldoPromocionalGeneralGeneradoDeseadoPorciento"",""etiqueta"": ""Saldo promocional General generado % (Deseado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Saldo promocional General generado % (Deseado)"",""descripcion"": """",""keyword"": ""SaldoPromocionalGeneralGeneradoDeseadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __SaldoPromocionalGeneralGeneradoDeseadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___SaldoPromocionalGeneralGeneradoDeseadoPorciento
          <DisplayName("Modificar Dto. V.I.P")>
          Public Property ModificarDtoVIP As Boolean
          Public Shared ___ModificarDtoVIP As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ModificarDtoVIP"",""etiqueta"": ""Modificar Dto. V.I.P"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Modificar Dto. V.I.P"",""descripcion"": """",""keyword"": ""ModificarDtoVIP"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ModificarDtoVIP As DinaNETCore.APID.DinaupAPI_CampoC = ___ModificarDtoVIP
          <Description("Descuento especial que se marca en la ficha de la entidad receptora de la transacción." & vbCrLf & "(Este es el ""Deseado"", podría modificarse según la configuración de ajustes de descuentos indicada, este valor puede ser distinto al aplicado finalmente)")>
          <DisplayName("Descuento V.I.P % (Deseado)")>
          Public Property DescuentoVIPDeseadoPorciento As Decimal
          Public Shared ___DescuentoVIPDeseadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoVIPDeseadoPorciento"",""etiqueta"": ""Descuento V.I.P % (Deseado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento V.I.P % (Deseado)"",""descripcion"": """",""keyword"": ""DescuentoVIPDeseadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoVIPDeseadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoVIPDeseadoPorciento
          <DisplayName("Empleado Tiene Acceso web")>
          Public Property EmpleadoTieneAccesoWeb As Boolean
          Public Shared ___EmpleadoTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EmpleadoTieneAccesoWeb"",""etiqueta"": ""Empleado Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empleado Tiene Acceso web"",""descripcion"": """",""keyword"": ""EmpleadoTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EmpleadoTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___EmpleadoTieneAccesoWeb
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
          <DisplayName("Importe Final - Retención")>
          Public Property ImporteImporteFinalRetencion As Decimal
          Public Shared ___ImporteImporteFinalRetencion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteImporteFinalRetencion"",""etiqueta"": ""Importe Final - Retención"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""6"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Importe Final - Retención"",""descripcion"": """",""keyword"": ""ImporteImporteFinalRetencion"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteImporteFinalRetencion As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteImporteFinalRetencion
          <DisplayName("Fecha Alta del registro")>
          Public Property FechaAlta_UTC As Date?
          Public Shared ___FechaAlta_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaAlta_UTC"",""etiqueta"": ""Fecha Alta del registro"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Alta del registro"",""descripcion"": """",""keyword"": ""FechaAlta_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaAlta_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaAlta_UTC
          <DisplayName("Suma (Sin Impuestos)")>
          Public Property ImporteSumaSinImpuestos As Decimal
          Public Shared ___ImporteSumaSinImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSumaSinImpuestos"",""etiqueta"": ""Suma (Sin Impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Suma (Sin Impuestos)"",""descripcion"": """",""keyword"": ""ImporteSumaSinImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSumaSinImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSumaSinImpuestos
          <DisplayName("Producto")>
          Public Property ReferenciaProducto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaProducto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaProducto"",""etiqueta"": ""Producto"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""e28959bb-b7f1-4558-9e8a-4048e6c5f51a"",""titulo"": ""Base - Productos"",""iconoid"": ""21a04b44-ad38-44e0-a63a-98951da57cfa"",""etiquetasingular"": ""Producto"",""etiquetaplural"": ""Productos"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""e28959bb-b7f1-4558-9e8a-4048e6c5f51a"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Producto"",""descripcion"": """",""keyword"": ""ReferenciaProducto"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaProducto As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaProducto
          <DisplayName("Elemento Catálogo")>
          Public Property ReferenciaElementoCatalogo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaElementoCatalogo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaElementoCatalogo"",""etiqueta"": ""Elemento Catálogo"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""d3797b08-0ca1-4ffd-9df1-7e86adf56575"",""titulo"": ""Lista - Catálogos de venta"",""iconoid"": ""6ef681f0-d0c9-420d-b6d2-c912636f0314"",""etiquetasingular"": ""Producto de catalogo"",""etiquetaplural"": ""Productos de catalogo"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": true,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""d3797b08-0ca1-4ffd-9df1-7e86adf56575"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Elemento Catálogo"",""descripcion"": """",""keyword"": ""ReferenciaElementoCatalogo"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaElementoCatalogo As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaElementoCatalogo
          <DisplayName("Fecha Dato")>
          Public Property FechaDato_UTC As Date?
          Public Shared ___FechaDato_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaDato_UTC"",""etiqueta"": ""Fecha Dato"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Dato"",""descripcion"": """",""keyword"": ""FechaDato_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaDato_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaDato_UTC
          <Description("Porcentaje de descuento adicional A que se ha aplicado.")>
          <DisplayName("Descuento Adicional A % (Aplicado)")>
          Public Property DescuentoAdicionalAAplicadoPorciento As Decimal
          Public Shared ___DescuentoAdicionalAAplicadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoAdicionalAAplicadoPorciento"",""etiqueta"": ""Descuento Adicional A % (Aplicado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento Adicional A % (Aplicado)"",""descripcion"": """",""keyword"": ""DescuentoAdicionalAAplicadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoAdicionalAAplicadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoAdicionalAAplicadoPorciento
          <DisplayName("Cantidad (Unidades)")>
          Public Property CantidadUnidades As Decimal
          Public Shared ___CantidadUnidades As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CantidadUnidades"",""etiqueta"": ""Cantidad (Unidades)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""11"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cantidad (Unidades)"",""descripcion"": """",""keyword"": ""CantidadUnidades"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CantidadUnidades As DinaNETCore.APID.DinaupAPI_CampoC = ___CantidadUnidades
          <Description("El precio mínimo por el que se puede vender este producto.")>
          <DisplayName("Precio mínimo")>
          Public Property ImportePrecioMinimo As Decimal
          Public Shared ___ImportePrecioMinimo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImportePrecioMinimo"",""etiqueta"": ""Precio mínimo"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""6"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Precio mínimo"",""descripcion"": """",""keyword"": ""ImportePrecioMinimo"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImportePrecioMinimo As DinaNETCore.APID.DinaupAPI_CampoC = ___ImportePrecioMinimo
          <Description("Descuento relacionado a una oferta que se ha aplicado.")>
          <DisplayName("Descuento Oferta % (Aplicado)")>
          Public Property DescuentoOfertaAplicadoPorciento As Decimal
          Public Shared ___DescuentoOfertaAplicadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoOfertaAplicadoPorciento"",""etiqueta"": ""Descuento Oferta % (Aplicado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento Oferta % (Aplicado)"",""descripcion"": """",""keyword"": ""DescuentoOfertaAplicadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoOfertaAplicadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoOfertaAplicadoPorciento
          <DisplayName("Modificar Dto. Entidad")>
          Public Property ModificarDtoEntidad As Boolean
          Public Shared ___ModificarDtoEntidad As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ModificarDtoEntidad"",""etiqueta"": ""Modificar Dto. Entidad"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Modificar Dto. Entidad"",""descripcion"": """",""keyword"": ""ModificarDtoEntidad"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ModificarDtoEntidad As DinaNETCore.APID.DinaupAPI_CampoC = ___ModificarDtoEntidad
          <Description("Porcentaje de descuento adicional B que se ha aplicado.")>
          <DisplayName("Descuento Adicional B % (Aplicado)")>
          Public Property DescuentoAdicionalBAplicadoPorciento As Decimal
          Public Shared ___DescuentoAdicionalBAplicadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoAdicionalBAplicadoPorciento"",""etiqueta"": ""Descuento Adicional B % (Aplicado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento Adicional B % (Aplicado)"",""descripcion"": """",""keyword"": ""DescuentoAdicionalBAplicadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoAdicionalBAplicadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoAdicionalBAplicadoPorciento
          <DisplayName("Saldo promocional (General)")>
          Public Property ImporteSaldoPromocionalGeneral As Decimal
          Public Shared ___ImporteSaldoPromocionalGeneral As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSaldoPromocionalGeneral"",""etiqueta"": ""Saldo promocional (General)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""6"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Saldo promocional (General)"",""descripcion"": """",""keyword"": ""ImporteSaldoPromocionalGeneral"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSaldoPromocionalGeneral As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSaldoPromocionalGeneral
          <Description("Descuento relacionado a una oferta." & vbCrLf & "(Este es el ""Deseado"", podría modificarse según la configuración de ajustes de descuentos indicada, este valor puede ser distinto al aplicado finalmente)")>
          <DisplayName("Descuento Oferta % (Deseado)")>
          Public Property DescuentoOfertaDeseadoPorciento As Decimal
          Public Shared ___DescuentoOfertaDeseadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoOfertaDeseadoPorciento"",""etiqueta"": ""Descuento Oferta % (Deseado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento Oferta % (Deseado)"",""descripcion"": """",""keyword"": ""DescuentoOfertaDeseadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoOfertaDeseadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoOfertaDeseadoPorciento
          <DisplayName("Empleado")>
          Public Property ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaEmpleadoPrincipal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaEmpleadoPrincipal"",""etiqueta"": ""Empleado"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c6e071c7-776f-4300-aa55-c711fd1da916"",""titulo"": ""Empleados"",""iconoid"": ""1c8abf82-640c-4d18-b62c-89de310923dd"",""etiquetasingular"": ""Empleado"",""etiquetaplural"": ""Empleados"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""c6e071c7-776f-4300-aa55-c711fd1da916"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empleado"",""descripcion"": """",""keyword"": ""ReferenciaEmpleadoPrincipal"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaEmpleadoPrincipal
          <DisplayName("Modificar Dto. Adicional B")>
          Public Property ModificarDtoAdicionalB As Boolean
          Public Shared ___ModificarDtoAdicionalB As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ModificarDtoAdicionalB"",""etiqueta"": ""Modificar Dto. Adicional B"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Modificar Dto. Adicional B"",""descripcion"": """",""keyword"": ""ModificarDtoAdicionalB"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ModificarDtoAdicionalB As DinaNETCore.APID.DinaupAPI_CampoC = ___ModificarDtoAdicionalB
          <Description("Precio por unidad sin impuestos")>
          <DisplayName("Precio unidad (Sin impuestos)")>
          Public Property ImportePrecioUnidadSinImpuestos As Decimal
          Public Shared ___ImportePrecioUnidadSinImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImportePrecioUnidadSinImpuestos"",""etiqueta"": ""Precio unidad (Sin impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""6"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Precio unidad (Sin impuestos)"",""descripcion"": """",""keyword"": ""ImportePrecioUnidadSinImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImportePrecioUnidadSinImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImportePrecioUnidadSinImpuestos
          <DisplayName("Cantidad (Medida Base Por Und.)")>
          Public Property CantidadMedidaBasePorUnd As Decimal
          Public Shared ___CantidadMedidaBasePorUnd As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CantidadMedidaBasePorUnd"",""etiqueta"": ""Cantidad (Medida Base Por Und.)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""11"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cantidad (Medida Base Por Und.)"",""descripcion"": """",""keyword"": ""CantidadMedidaBasePorUnd"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CantidadMedidaBasePorUnd As DinaNETCore.APID.DinaupAPI_CampoC = ___CantidadMedidaBasePorUnd
          <DisplayName("Total Descuentos (Productos) (Sin Impuestos)")>
          Public Property ImporteTotalDescuentosProductosSinImpuestos As Decimal
          Public Shared ___ImporteTotalDescuentosProductosSinImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteTotalDescuentosProductosSinImpuestos"",""etiqueta"": ""Total Descuentos (Productos) (Sin Impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total Descuentos (Productos) (Sin Impuestos)"",""descripcion"": """",""keyword"": ""ImporteTotalDescuentosProductosSinImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteTotalDescuentosProductosSinImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteTotalDescuentosProductosSinImpuestos
          <Description("Cantidad de descuento fijo que se aplica por cada unidad.")>
          <DisplayName("Dto. fijo por unidad (Aplicado)")>
          Public Property ImporteDtoFijoPorUnidadAplicado As Decimal
          Public Shared ___ImporteDtoFijoPorUnidadAplicado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDtoFijoPorUnidadAplicado"",""etiqueta"": ""Dto. fijo por unidad (Aplicado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""6"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Dto. fijo por unidad (Aplicado)"",""descripcion"": """",""keyword"": ""ImporteDtoFijoPorUnidadAplicado"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDtoFijoPorUnidadAplicado As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDtoFijoPorUnidadAplicado
          <Description("Porcentaje de descuento V.I.P que se ha aplicado.")>
          <DisplayName("Descuento V.I.P % (Aplicado)")>
          Public Property DescuentoVIPAplicadoPorciento As Decimal
          Public Shared ___DescuentoVIPAplicadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoVIPAplicadoPorciento"",""etiqueta"": ""Descuento V.I.P % (Aplicado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento V.I.P % (Aplicado)"",""descripcion"": """",""keyword"": ""DescuentoVIPAplicadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoVIPAplicadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoVIPAplicadoPorciento
          <DisplayName("Modificar Saldo promocional General")>
          Public Property ModificarSaldoPromocionalGeneral As Boolean
          Public Shared ___ModificarSaldoPromocionalGeneral As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ModificarSaldoPromocionalGeneral"",""etiqueta"": ""Modificar Saldo promocional General"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Modificar Saldo promocional General"",""descripcion"": """",""keyword"": ""ModificarSaldoPromocionalGeneral"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ModificarSaldoPromocionalGeneral As DinaNETCore.APID.DinaupAPI_CampoC = ___ModificarSaldoPromocionalGeneral
          <DisplayName("Porcentaje de impuestos")>
          Public Property PorcentajeDeImpuestosPorciento As Decimal
          Public Shared ___PorcentajeDeImpuestosPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""PorcentajeDeImpuestosPorciento"",""etiqueta"": ""Porcentaje de impuestos"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Porcentaje de impuestos"",""descripcion"": """",""keyword"": ""PorcentajeDeImpuestosPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __PorcentajeDeImpuestosPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___PorcentajeDeImpuestosPorciento
          <Description("Saldo obtenido")>
          <DisplayName("Importe Final - Saldo obtenido")>
          Public Property ImporteImporteFinalSaldoObtenido As Decimal
          Public Shared ___ImporteImporteFinalSaldoObtenido As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteImporteFinalSaldoObtenido"",""etiqueta"": ""Importe Final - Saldo obtenido"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Importe Final - Saldo obtenido"",""descripcion"": """",""keyword"": ""ImporteImporteFinalSaldoObtenido"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteImporteFinalSaldoObtenido As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteImporteFinalSaldoObtenido
          <DisplayName("Autor del alta Tiene Acceso web")>
          Public Property AutorDelAltaTieneAccesoWeb As Boolean
          Public Shared ___AutorDelAltaTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AutorDelAltaTieneAccesoWeb"",""etiqueta"": ""Autor del alta Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta Tiene Acceso web"",""descripcion"": """",""keyword"": ""AutorDelAltaTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AutorDelAltaTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___AutorDelAltaTieneAccesoWeb
          <DisplayName("Importe Final - Total descuento no aplicados")>
          Public Property ImporteImporteFinalTotalDescuentoNoAplicados As Decimal
          Public Shared ___ImporteImporteFinalTotalDescuentoNoAplicados As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteImporteFinalTotalDescuentoNoAplicados"",""etiqueta"": ""Importe Final - Total descuento no aplicados"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""6"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Importe Final - Total descuento no aplicados"",""descripcion"": """",""keyword"": ""ImporteImporteFinalTotalDescuentoNoAplicados"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteImporteFinalTotalDescuentoNoAplicados As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteImporteFinalTotalDescuentoNoAplicados
          <Description("Descripción que indica el motivo del descuento adicional configurable.")>
          <DisplayName("Descuento Adicional B Motivo")>
          Public Property DescuentoAdicionalBMotivo As String
          Public Shared ___DescuentoAdicionalBMotivo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoAdicionalBMotivo"",""etiqueta"": ""Descuento Adicional B Motivo"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento Adicional B Motivo"",""descripcion"": """",""keyword"": ""DescuentoAdicionalBMotivo"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoAdicionalBMotivo As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoAdicionalBMotivo
          <Description("Importe a pagar por el producto")>
          <DisplayName("Importe Final - Total")>
          Public Property ImporteImporteFinalTotal As Decimal
          Public Shared ___ImporteImporteFinalTotal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteImporteFinalTotal"",""etiqueta"": ""Importe Final - Total"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""10"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Importe Final - Total"",""descripcion"": """",""keyword"": ""ImporteImporteFinalTotal"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteImporteFinalTotal As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteImporteFinalTotal
          <DisplayName("Cantidad (Unidad medida base)")>
          Public Property CantidadUnidadMedidaBase As Decimal
          Public Shared ___CantidadUnidadMedidaBase As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CantidadUnidadMedidaBase"",""etiqueta"": ""Cantidad (Unidad medida base)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""11"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cantidad (Unidad medida base)"",""descripcion"": """",""keyword"": ""CantidadUnidadMedidaBase"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CantidadUnidadMedidaBase As DinaNETCore.APID.DinaupAPI_CampoC = ___CantidadUnidadMedidaBase
          <Description("Catálogo referencia de precios.")>
          <DisplayName("Catálogo")>
          Public Property ReferenciaCatalogo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaCatalogo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaCatalogo"",""etiqueta"": ""Catálogo"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""ff5a07a8-add8-4c23-8bac-530d23cdf82f"",""titulo"": ""Catálogos de venta"",""iconoid"": ""6ef681f0-d0c9-420d-b6d2-c912636f0314"",""etiquetasingular"": ""Catálogo de venta"",""etiquetaplural"": ""Catálogos de venta"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""ff5a07a8-add8-4c23-8bac-530d23cdf82f"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Catálogo"",""descripcion"": """",""keyword"": ""ReferenciaCatalogo"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaCatalogo As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaCatalogo
          <Description("Cantidad de descuento fijo que se aplica por cada unidad." & vbCrLf & "(Este es el ""Deseado"", podría modificarse según la configuración de ajustes de descuentos indicada, este valor puede ser distinto al aplicado finalmente)")>
          <DisplayName("Descuento Fijo Unidad (Deseado)")>
          Public Property ImporteDescuentoFijoUnidadDeseado As Decimal
          Public Shared ___ImporteDescuentoFijoUnidadDeseado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentoFijoUnidadDeseado"",""etiqueta"": ""Descuento Fijo Unidad (Deseado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""6"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento Fijo Unidad (Deseado)"",""descripcion"": """",""keyword"": ""ImporteDescuentoFijoUnidadDeseado"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentoFijoUnidadDeseado As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentoFijoUnidadDeseado
          <DisplayName("Entidad Relacionada Tiene Acceso web")>
          Public Property EntidadRelacionadaTieneAccesoWeb As Boolean
          Public Shared ___EntidadRelacionadaTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EntidadRelacionadaTieneAccesoWeb"",""etiqueta"": ""Entidad Relacionada Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Entidad Relacionada Tiene Acceso web"",""descripcion"": """",""keyword"": ""EntidadRelacionadaTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EntidadRelacionadaTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___EntidadRelacionadaTieneAccesoWeb
          <DisplayName("Modificar Dto. Adicional A")>
          Public Property ModificarDtoAdicionalA As Boolean
          Public Shared ___ModificarDtoAdicionalA As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ModificarDtoAdicionalA"",""etiqueta"": ""Modificar Dto. Adicional A"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Modificar Dto. Adicional A"",""descripcion"": """",""keyword"": ""ModificarDtoAdicionalA"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ModificarDtoAdicionalA As DinaNETCore.APID.DinaupAPI_CampoC = ___ModificarDtoAdicionalA
          <Description("Porcentaje de descuento en relación al producto seleccionado.")>
          <DisplayName("Descuento Producto % (Aplicado)")>
          Public Property DescuentoProductoAplicadoPorciento As Decimal
          Public Shared ___DescuentoProductoAplicadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoProductoAplicadoPorciento"",""etiqueta"": ""Descuento Producto % (Aplicado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento Producto % (Aplicado)"",""descripcion"": """",""keyword"": ""DescuentoProductoAplicadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoProductoAplicadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoProductoAplicadoPorciento
          <DisplayName("Modificar Dto. General")>
          Public Property ModificarDtoGeneral As Boolean
          Public Shared ___ModificarDtoGeneral As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ModificarDtoGeneral"",""etiqueta"": ""Modificar Dto. General"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Modificar Dto. General"",""descripcion"": """",""keyword"": ""ModificarDtoGeneral"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ModificarDtoGeneral As DinaNETCore.APID.DinaupAPI_CampoC = ___ModificarDtoGeneral
          <DisplayName("Suma (Con Impuestos)")>
          Public Property ImporteSumaConImpuestos As Decimal
          Public Shared ___ImporteSumaConImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSumaConImpuestos"",""etiqueta"": ""Suma (Con Impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""10"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Suma (Con Impuestos)"",""descripcion"": """",""keyword"": ""ImporteSumaConImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSumaConImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSumaConImpuestos
          <Description("Cantidad de Saldo promocional fijo que se ofrecerá con este producto.")>
          <DisplayName("Saldo promocional Fijo por unidad (Aplicado)")>
          Public Property ImporteSaldoPromocionalFijoPorUnidadAplicado As Decimal
          Public Shared ___ImporteSaldoPromocionalFijoPorUnidadAplicado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSaldoPromocionalFijoPorUnidadAplicado"",""etiqueta"": ""Saldo promocional Fijo por unidad (Aplicado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""6"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Saldo promocional Fijo por unidad (Aplicado)"",""descripcion"": """",""keyword"": ""ImporteSaldoPromocionalFijoPorUnidadAplicado"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSaldoPromocionalFijoPorUnidadAplicado As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSaldoPromocionalFijoPorUnidadAplicado
          <Description("Indicando esta opción se permitirá seleccionar productos que no estén en el catálogo que se ha asignado a la entidad o transacción.")>
          <DisplayName("Permitir productos fuera de catálogo")>
          Public Property PermitirProductosFueraDeCatalogo As Boolean
          Public Shared ___PermitirProductosFueraDeCatalogo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""PermitirProductosFueraDeCatalogo"",""etiqueta"": ""Permitir productos fuera de catálogo"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Permitir productos fuera de catálogo"",""descripcion"": """",""keyword"": ""PermitirProductosFueraDeCatalogo"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __PermitirProductosFueraDeCatalogo As DinaNETCore.APID.DinaupAPI_CampoC = ___PermitirProductosFueraDeCatalogo
          <Description("Descuento relacionado con la entidad que se ha aplicado.")>
          <DisplayName("Descuento Entidad % (Aplicado)")>
          Public Property DescuentoEntidadAplicadoPorciento As Decimal
          Public Shared ___DescuentoEntidadAplicadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoEntidadAplicadoPorciento"",""etiqueta"": ""Descuento Entidad % (Aplicado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento Entidad % (Aplicado)"",""descripcion"": """",""keyword"": ""DescuentoEntidadAplicadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoEntidadAplicadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoEntidadAplicadoPorciento
          <DisplayName("Hora local")>
          Public Property HoraLocal As DateTime?
          Public Shared ___HoraLocal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""HoraLocal"",""etiqueta"": ""Hora local"",""oculta"": false,""formato"": 8,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Hora local"",""descripcion"": """",""keyword"": ""HoraLocal"",""formato"": 8,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __HoraLocal As DinaNETCore.APID.DinaupAPI_CampoC = ___HoraLocal
          <DisplayName("Importe Final - Impuestos")>
          Public Property ImporteImporteFinalImpuestos As Decimal
          Public Shared ___ImporteImporteFinalImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteImporteFinalImpuestos"",""etiqueta"": ""Importe Final - Impuestos"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""6"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Importe Final - Impuestos"",""descripcion"": """",""keyword"": ""ImporteImporteFinalImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteImporteFinalImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteImporteFinalImpuestos
          <Description("Porcentaje de saldo promocional que se obtendrá por una oferta.")>
          <DisplayName("Saldo promocional Oferta % (Aplicado)")>
          Public Property SaldoPromocionalOfertaAplicadoPorciento As Decimal
          Public Shared ___SaldoPromocionalOfertaAplicadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""SaldoPromocionalOfertaAplicadoPorciento"",""etiqueta"": ""Saldo promocional Oferta % (Aplicado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Saldo promocional Oferta % (Aplicado)"",""descripcion"": """",""keyword"": ""SaldoPromocionalOfertaAplicadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __SaldoPromocionalOfertaAplicadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___SaldoPromocionalOfertaAplicadoPorciento
          <DisplayName("Destinador")>
          Public Property ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaDestinador As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaDestinador"",""etiqueta"": ""Destinador"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""relacionesindirectas"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Destinador"",""descripcion"": """",""keyword"": ""ReferenciaDestinador"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaDestinador
          <DisplayName("Saldo promocional (Producto)")>
          Public Property ImporteSaldoPromocionalProducto As Decimal
          Public Shared ___ImporteSaldoPromocionalProducto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSaldoPromocionalProducto"",""etiqueta"": ""Saldo promocional (Producto)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Saldo promocional (Producto)"",""descripcion"": """",""keyword"": ""ImporteSaldoPromocionalProducto"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSaldoPromocionalProducto As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSaldoPromocionalProducto
          <Description("Porcentaje de saldo promocional que se obtendrá por una oferta." & vbCrLf & "(Este es el ""Deseado"", podría modificarse según la configuración de ajustes de bonificaciones indicada, este valor puede ser distinto al aplicado finalmente)")>
          <DisplayName("Saldo promocional Oferta % (Deseado)")>
          Public Property SaldoPromocionalOfertaDeseadoPorciento As Decimal
          Public Shared ___SaldoPromocionalOfertaDeseadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""SaldoPromocionalOfertaDeseadoPorciento"",""etiqueta"": ""Saldo promocional Oferta % (Deseado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Saldo promocional Oferta % (Deseado)"",""descripcion"": """",""keyword"": ""SaldoPromocionalOfertaDeseadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __SaldoPromocionalOfertaDeseadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___SaldoPromocionalOfertaDeseadoPorciento
          <DisplayName("Ubicación Principal")>
          Public Property ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaUbicacionPrincipal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaUbicacionPrincipal"",""etiqueta"": ""Ubicación Principal"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""b9adbfbf-a81a-45fb-861c-90502902c982"",""titulo"": ""Ubicaciones"",""iconoid"": ""b985b58f-7275-46b8-9b66-2c54346b0185"",""etiquetasingular"": ""Ubicación"",""etiquetaplural"": ""Ubicaciones"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""b9adbfbf-a81a-45fb-861c-90502902c982"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Ubicación Principal"",""descripcion"": """",""keyword"": ""ReferenciaUbicacionPrincipal"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaUbicacionPrincipal
          <DisplayName("Elemento de presupuesto de venta")>
          Public Property ReferenciaElementoDePresupuestoDeVenta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaElementoDePresupuestoDeVenta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaElementoDePresupuestoDeVenta"",""etiqueta"": ""Elemento de presupuesto de venta"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""1334f04e-4478-42ba-81df-50029387b99a"",""titulo"": ""Base Lista - Presupuestos de venta"",""iconoid"": """",""etiquetasingular"": ""Producto de presupuesto de venta"",""etiquetaplural"": ""Productos de presupuesto de venta"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": true,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""1334f04e-4478-42ba-81df-50029387b99a"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Elemento de presupuesto de venta"",""descripcion"": """",""keyword"": ""ReferenciaElementoDePresupuestoDeVenta"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaElementoDePresupuestoDeVenta As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaElementoDePresupuestoDeVenta
          <Description("Descripción que indica el motivo del descuento adicional configurable.")>
          <DisplayName("Descuento Adicional A Motivo")>
          Public Property DescuentoAdicionalAMotivo As String
          Public Shared ___DescuentoAdicionalAMotivo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoAdicionalAMotivo"",""etiqueta"": ""Descuento Adicional A Motivo"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento Adicional A Motivo"",""descripcion"": """",""keyword"": ""DescuentoAdicionalAMotivo"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoAdicionalAMotivo As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoAdicionalAMotivo
          <DisplayName("Tipo de venta")>
          Public Property ReferenciaTipoDeVenta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaTipoDeVenta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaTipoDeVenta"",""etiqueta"": ""Tipo de venta"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""b1275848-3b6f-4b55-b6fa-9d77b9c0e6a5"",""titulo"": ""Base - Categorías de Ventas"",""iconoid"": ""41e2810f-985c-4e49-b283-9e43ff68cadb"",""etiquetasingular"": ""Categoría de Venta"",""etiquetaplural"": ""Categorías de Ventas"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""b1275848-3b6f-4b55-b6fa-9d77b9c0e6a5"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Tipo de venta"",""descripcion"": """",""keyword"": ""ReferenciaTipoDeVenta"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaTipoDeVenta As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaTipoDeVenta
          <ReadOnlyAttribute(True)>
          <DisplayName("ID")>
          Public Property ID As Guid
          Public Shared ___ID As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": true,""eseliminado"": false,""keyword"": ""ID"",""etiqueta"": ""ID"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""510172c2-7a98-4bc2-951f-a9c902e4bc75"",""titulo"": ""Lista - Facturas proforma"",""iconoid"": """",""etiquetasingular"": ""Producto de factura proforma"",""etiquetaplural"": ""Productos de factura proforma"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": true,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""510172c2-7a98-4bc2-951f-a9c902e4bc75"",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""ID"",""descripcion"": """",""keyword"": ""ID"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ID As DinaNETCore.APID.DinaupAPI_CampoC = ___ID
          <DisplayName("Nombre descriptivo del producto")>
          Public Property TextoPrincipal As String
          Public Shared ___TextoPrincipal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TextoPrincipal"",""etiqueta"": ""Nombre descriptivo del producto"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Nombre descriptivo del producto"",""descripcion"": """",""keyword"": ""TextoPrincipal"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
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
          <DisplayName("Factura proforma (Listador) (Relación)")>
          Public Property RelacionElementoContenedorListador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___RelacionElementoContenedorListador As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RelacionElementoContenedorListador"",""etiqueta"": ""Factura proforma (Listador) (Relación)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""ea144ec7-af10-466d-8370-76c5b9126f90"",""titulo"": ""Facturas proforma"",""iconoid"": ""39d08324-2d04-4df7-bcc2-6945bc006a74"",""etiquetasingular"": ""Factura proforma"",""etiquetaplural"": ""Facturas proforma"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""ea144ec7-af10-466d-8370-76c5b9126f90"",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Factura proforma (Listador) (Relación)"",""descripcion"": """",""keyword"": ""RelacionElementoContenedorListador"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RelacionElementoContenedorListador As DinaNETCore.APID.DinaupAPI_CampoC = ___RelacionElementoContenedorListador
          <DisplayName("Factura proforma (Listador) Eliminadoa *")>
          Public Property Listadoreliminado As Boolean
          Public Shared ___Listadoreliminado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Listadoreliminado"",""etiqueta"": ""Factura proforma (Listador) Eliminadoa *"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Factura proforma (Listador) Eliminadoa *"",""descripcion"": """",""keyword"": ""Listadoreliminado"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Listadoreliminado As DinaNETCore.APID.DinaupAPI_CampoC = ___Listadoreliminado
          Overrides Sub CargarDatos(_Datos as Dic(of string,string))
          me.ReferenciaImpuesto = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_1004010580143"), _Datos.Leer_String("pr_1004010580143.nombre"))
          me.Motivo = _Datos.Leer_String("pr_1004010580135")
          me.ImporteTotalDescontadoSinImpuestos = _Datos.Leer_Decimal("pr_1004010580102")
          me.ImporteImporteSinImpuestos = _Datos.Leer_Decimal("pr_100401058099")
          me.ReferenciaMedida = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_1004010580142"), _Datos.Leer_String("pr_1004010580142.nombre"))
          me.SaldoPromocionalGeneralGeneradoAplicadoPorciento = _Datos.Leer_Decimal("pr_1004010580100")
          me.ImporteImporteConImpuestos = _Datos.Leer_Decimal("pr_100401064911")
          me.DescuentoAdicionalBDeseadoPorciento = _Datos.Leer_Decimal("pr_1004010580101")
          me.DescuentoGeneralAplicadoPorciento = _Datos.Leer_Decimal("pr_1004010580104")
          me.SaldoPromocionalOfertaMinimoAjustablePorciento = _Datos.Leer_Decimal("pr_1004010580105")
          me.ReferenciaEntidadRelacionada = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_1004010580146"), _Datos.Leer_String("pr_1004010580146.nombre"))
          me.ModificarDtoTipoEntidad = _Datos.Leer_Boolean("pr_100401058081")
          me.DescuentoAdicionalADeseadoPorciento = _Datos.Leer_Decimal("pr_1004010580107")
          me.DescuentoTipoEntidadDeseadoPorciento = _Datos.Leer_Decimal("pr_1004010580106")
          me.ImporteTotalDescuentosGeneralesSinImpuestos = _Datos.Leer_Decimal("pr_1004010580108")
          me.ReferenciaPresupuestoDeVenta = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_50040105802"), _Datos.Leer_String("pr_50040105802.nombre"))
          me.DescuentoTipoEntidadPorciento = _Datos.Leer_Decimal("pr_1004010580109")
          me.DescuentoEntidadDeseadoPorciento = _Datos.Leer_Decimal("pr_1004010580110")
          me.ReferenciaAutorDelAlta = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_3004010555311"), _Datos.Leer_String("pr_3004010555311.nombre"))
          me.ElPrecioIndicadoIncluyeLosImpuestos = _Datos.Leer_Boolean("pr_100401058080")
          me.ImportePrecioUnidad = _Datos.Leer_Decimal("pr_1004010580103")
          me.ReferenciaTipoMovimiento = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_1004010580145"), _Datos.Leer_String("pr_1004010580145.nombre"))
          me.TotalPorcentajeDeDescuentoAplicadoAProductoPorciento = _Datos.Leer_Decimal("pr_100401058092")
          me.ImportePrecioUnidadConImpuestos = _Datos.Leer_Decimal("pr_10040106692")
          me.ReferenciaMedidaBase = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_1004010580138"), _Datos.Leer_String("pr_1004010580138.nombre"))
          me.Cantidad = _Datos.Leer_Decimal("pr_100401058093")
          me.DescuentoGeneralDeseadoPorciento = _Datos.Leer_Decimal("pr_100401058089")
          me.SaldoPromocionalGeneralGeneradoDeseadoPorciento = _Datos.Leer_Decimal("pr_100401058090")
          me.ModificarDtoVIP = _Datos.Leer_Boolean("pr_100401058078")
          me.DescuentoVIPDeseadoPorciento = _Datos.Leer_Decimal("pr_100401058091")
          me.EmpleadoTieneAccesoWeb = _Datos.Leer_Boolean("pr_3004010555336")
          me.DescuentoProductoDeseadoPorciento = _Datos.Leer_Decimal("pr_100401058096")
          me.ImporteSaldoPromocionalFijoPorUnidadDeseado = _Datos.Leer_Decimal("pr_100401058097")
          me.ImporteImporteFinalRetencion = _Datos.Leer_Decimal("pr_100401058098")
          me.FechaAlta_UTC = _Datos.Leer_DateTime_Nulable("pr_3004010555314")
          me.ImporteSumaSinImpuestos = _Datos.Leer_Decimal("pr_100401058094")
          me.ReferenciaProducto = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_1004010580141"), _Datos.Leer_String("pr_1004010580141.nombre"))
          me.ReferenciaElementoCatalogo = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_1004010580140"), _Datos.Leer_String("pr_1004010580140.nombre"))
          me.FechaDato_UTC = _Datos.Leer_DateTime_Nulable("pr_3004010555312")
          me.DescuentoAdicionalAAplicadoPorciento = _Datos.Leer_Decimal("pr_100401058095")
          me.CantidadUnidades = _Datos.Leer_Decimal("pr_1004010580123")
          me.ImportePrecioMinimo = _Datos.Leer_Decimal("pr_1004010580124")
          me.DescuentoOfertaAplicadoPorciento = _Datos.Leer_Decimal("pr_1004010580125")
          me.ModificarDtoEntidad = _Datos.Leer_Boolean("pr_100401058087")
          me.DescuentoAdicionalBAplicadoPorciento = _Datos.Leer_Decimal("pr_1004010580127")
          me.ImporteSaldoPromocionalGeneral = _Datos.Leer_Decimal("pr_1004010580126")
          me.DescuentoOfertaDeseadoPorciento = _Datos.Leer_Decimal("pr_1004010580122")
          me.ReferenciaEmpleadoPrincipal = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_3004010555309"), _Datos.Leer_String("pr_3004010555309.nombre"))
          me.ModificarDtoAdicionalB = _Datos.Leer_Boolean("pr_100401058086")
          me.ImportePrecioUnidadSinImpuestos = _Datos.Leer_Decimal("pr_1004010580130")
          me.CantidadMedidaBasePorUnd = _Datos.Leer_Decimal("pr_1004010580132")
          me.ImporteTotalDescuentosProductosSinImpuestos = _Datos.Leer_Decimal("pr_1004010580131")
          me.ImporteDtoFijoPorUnidadAplicado = _Datos.Leer_Decimal("pr_1004010580133")
          me.DescuentoVIPAplicadoPorciento = _Datos.Leer_Decimal("pr_1004010580134")
          me.ModificarSaldoPromocionalGeneral = _Datos.Leer_Boolean("pr_100401058088")
          me.PorcentajeDeImpuestosPorciento = _Datos.Leer_Decimal("pr_1004010580128")
          me.ImporteImporteFinalSaldoObtenido = _Datos.Leer_Decimal("pr_1004010580129")
          me.AutorDelAltaTieneAccesoWeb = _Datos.Leer_Boolean("pr_3004010555334")
          me.ImporteImporteFinalTotalDescuentoNoAplicados = _Datos.Leer_Decimal("pr_1004010580113")
          me.DescuentoAdicionalBMotivo = _Datos.Leer_String("pr_1004010580136")
          me.ImporteImporteFinalTotal = _Datos.Leer_Decimal("pr_1004010580115")
          me.CantidadUnidadMedidaBase = _Datos.Leer_Decimal("pr_1004010580114")
          me.ReferenciaCatalogo = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_1004010580147"), _Datos.Leer_String("pr_1004010580147.nombre"))
          me.ImporteDescuentoFijoUnidadDeseado = _Datos.Leer_Decimal("pr_1004010580116")
          me.EntidadRelacionadaTieneAccesoWeb = _Datos.Leer_Boolean("pr_1004010580148")
          me.ModificarDtoAdicionalA = _Datos.Leer_Boolean("pr_100401058082")
          me.DescuentoProductoAplicadoPorciento = _Datos.Leer_Decimal("pr_1004010580111")
          me.ModificarDtoGeneral = _Datos.Leer_Boolean("pr_100401058083")
          me.ImporteSumaConImpuestos = _Datos.Leer_Decimal("pr_100401064912")
          me.ImporteSaldoPromocionalFijoPorUnidadAplicado = _Datos.Leer_Decimal("pr_1004010580112")
          me.PermitirProductosFueraDeCatalogo = _Datos.Leer_Boolean("pr_100401058085")
          me.DescuentoEntidadAplicadoPorciento = _Datos.Leer_Decimal("pr_1004010580119")
          me.HoraLocal = _Datos.Leer_Time_Nulable("pr_3004010555313")
          me.ImporteImporteFinalImpuestos = _Datos.Leer_Decimal("pr_1004010580120")
          me.SaldoPromocionalOfertaAplicadoPorciento = _Datos.Leer_Decimal("pr_1004010580121")
          me.ReferenciaDestinador = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_3004010555317"), _Datos.Leer_String("pr_3004010555317.nombre"))
          me.ImporteSaldoPromocionalProducto = _Datos.Leer_Decimal("pr_1004010580117")
          me.SaldoPromocionalOfertaDeseadoPorciento = _Datos.Leer_Decimal("pr_1004010580118")
          me.ReferenciaUbicacionPrincipal = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_3004010555310"), _Datos.Leer_String("pr_3004010555310.nombre"))
          me.ReferenciaElementoDePresupuestoDeVenta = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_50040105801"), _Datos.Leer_String("pr_50040105801.nombre"))
          me.DescuentoAdicionalAMotivo = _Datos.Leer_String("pr_1004010580137")
          me.ReferenciaTipoDeVenta = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_10040136184"), _Datos.Leer_String("pr_10040136184.nombre"))
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
         If Me.ReferenciaImpuesto IsNot nothing then
           R.add("pr_1004010580143",me.ReferenciaImpuesto.ID.STR())
         Else
           R.add("pr_1004010580143","")
         End if
         R.add("pr_1004010580135", me.Motivo.AdaptarMySQL_String())
         R.add("pr_1004010580102", me.ImporteTotalDescontadoSinImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_100401058099", me.ImporteImporteSinImpuestos.AdaptarMySQL_Decimal())
         If Me.ReferenciaMedida IsNot nothing then
           R.add("pr_1004010580142",me.ReferenciaMedida.ID.STR())
         Else
           R.add("pr_1004010580142","")
         End if
         R.add("pr_1004010580100", me.SaldoPromocionalGeneralGeneradoAplicadoPorciento.AdaptarMySQL_Decimal())
         R.add("pr_100401064911", me.ImporteImporteConImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_1004010580101", me.DescuentoAdicionalBDeseadoPorciento.AdaptarMySQL_Decimal())
         R.add("pr_1004010580104", me.DescuentoGeneralAplicadoPorciento.AdaptarMySQL_Decimal())
         R.add("pr_1004010580105", me.SaldoPromocionalOfertaMinimoAjustablePorciento.AdaptarMySQL_Decimal())
         If Me.ReferenciaEntidadRelacionada IsNot nothing then
           R.add("pr_1004010580146",me.ReferenciaEntidadRelacionada.ID.STR())
         Else
           R.add("pr_1004010580146","")
         End if
         R.add("pr_100401058081", me.ModificarDtoTipoEntidad.AdaptarMySQL_Boolean())
         R.add("pr_1004010580107", me.DescuentoAdicionalADeseadoPorciento.AdaptarMySQL_Decimal())
         R.add("pr_1004010580106", me.DescuentoTipoEntidadDeseadoPorciento.AdaptarMySQL_Decimal())
         R.add("pr_1004010580108", me.ImporteTotalDescuentosGeneralesSinImpuestos.AdaptarMySQL_Decimal())
         If Me.ReferenciaPresupuestoDeVenta IsNot nothing then
           R.add("pr_50040105802",me.ReferenciaPresupuestoDeVenta.ID.STR())
         Else
           R.add("pr_50040105802","")
         End if
         R.add("pr_1004010580109", me.DescuentoTipoEntidadPorciento.AdaptarMySQL_Decimal())
         R.add("pr_1004010580110", me.DescuentoEntidadDeseadoPorciento.AdaptarMySQL_Decimal())
         If Me.ReferenciaAutorDelAlta IsNot nothing then
           R.add("pr_3004010555311",me.ReferenciaAutorDelAlta.ID.STR())
         Else
           R.add("pr_3004010555311","")
         End if
         R.add("pr_100401058080", me.ElPrecioIndicadoIncluyeLosImpuestos.AdaptarMySQL_Boolean())
         R.add("pr_1004010580103", me.ImportePrecioUnidad.AdaptarMySQL_Decimal())
         If Me.ReferenciaTipoMovimiento IsNot nothing then
           R.add("pr_1004010580145",me.ReferenciaTipoMovimiento.ID.STR())
         Else
           R.add("pr_1004010580145","")
         End if
         R.add("pr_100401058092", me.TotalPorcentajeDeDescuentoAplicadoAProductoPorciento.AdaptarMySQL_Decimal())
         R.add("pr_10040106692", me.ImportePrecioUnidadConImpuestos.AdaptarMySQL_Decimal())
         If Me.ReferenciaMedidaBase IsNot nothing then
           R.add("pr_1004010580138",me.ReferenciaMedidaBase.ID.STR())
         Else
           R.add("pr_1004010580138","")
         End if
         R.add("pr_100401058093", me.Cantidad.AdaptarMySQL_Decimal())
         R.add("pr_100401058089", me.DescuentoGeneralDeseadoPorciento.AdaptarMySQL_Decimal())
         R.add("pr_100401058090", me.SaldoPromocionalGeneralGeneradoDeseadoPorciento.AdaptarMySQL_Decimal())
         R.add("pr_100401058078", me.ModificarDtoVIP.AdaptarMySQL_Boolean())
         R.add("pr_100401058091", me.DescuentoVIPDeseadoPorciento.AdaptarMySQL_Decimal())
         R.add("pr_3004010555336", me.EmpleadoTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_100401058096", me.DescuentoProductoDeseadoPorciento.AdaptarMySQL_Decimal())
         R.add("pr_100401058097", me.ImporteSaldoPromocionalFijoPorUnidadDeseado.AdaptarMySQL_Decimal())
         R.add("pr_100401058098", me.ImporteImporteFinalRetencion.AdaptarMySQL_Decimal())
         R.add("pr_3004010555314", me.FechaAlta_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_100401058094", me.ImporteSumaSinImpuestos.AdaptarMySQL_Decimal())
         If Me.ReferenciaProducto IsNot nothing then
           R.add("pr_1004010580141",me.ReferenciaProducto.ID.STR())
         Else
           R.add("pr_1004010580141","")
         End if
         If Me.ReferenciaElementoCatalogo IsNot nothing then
           R.add("pr_1004010580140",me.ReferenciaElementoCatalogo.ID.STR())
         Else
           R.add("pr_1004010580140","")
         End if
         R.add("pr_3004010555312", me.FechaDato_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_100401058095", me.DescuentoAdicionalAAplicadoPorciento.AdaptarMySQL_Decimal())
         R.add("pr_1004010580123", me.CantidadUnidades.AdaptarMySQL_Decimal())
         R.add("pr_1004010580124", me.ImportePrecioMinimo.AdaptarMySQL_Decimal())
         R.add("pr_1004010580125", me.DescuentoOfertaAplicadoPorciento.AdaptarMySQL_Decimal())
         R.add("pr_100401058087", me.ModificarDtoEntidad.AdaptarMySQL_Boolean())
         R.add("pr_1004010580127", me.DescuentoAdicionalBAplicadoPorciento.AdaptarMySQL_Decimal())
         R.add("pr_1004010580126", me.ImporteSaldoPromocionalGeneral.AdaptarMySQL_Decimal())
         R.add("pr_1004010580122", me.DescuentoOfertaDeseadoPorciento.AdaptarMySQL_Decimal())
         If Me.ReferenciaEmpleadoPrincipal IsNot nothing then
           R.add("pr_3004010555309",me.ReferenciaEmpleadoPrincipal.ID.STR())
         Else
           R.add("pr_3004010555309","")
         End if
         R.add("pr_100401058086", me.ModificarDtoAdicionalB.AdaptarMySQL_Boolean())
         R.add("pr_1004010580130", me.ImportePrecioUnidadSinImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_1004010580132", me.CantidadMedidaBasePorUnd.AdaptarMySQL_Decimal())
         R.add("pr_1004010580131", me.ImporteTotalDescuentosProductosSinImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_1004010580133", me.ImporteDtoFijoPorUnidadAplicado.AdaptarMySQL_Decimal())
         R.add("pr_1004010580134", me.DescuentoVIPAplicadoPorciento.AdaptarMySQL_Decimal())
         R.add("pr_100401058088", me.ModificarSaldoPromocionalGeneral.AdaptarMySQL_Boolean())
         R.add("pr_1004010580128", me.PorcentajeDeImpuestosPorciento.AdaptarMySQL_Decimal())
         R.add("pr_1004010580129", me.ImporteImporteFinalSaldoObtenido.AdaptarMySQL_Decimal())
         R.add("pr_3004010555334", me.AutorDelAltaTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_1004010580113", me.ImporteImporteFinalTotalDescuentoNoAplicados.AdaptarMySQL_Decimal())
         R.add("pr_1004010580136", me.DescuentoAdicionalBMotivo.AdaptarMySQL_String())
         R.add("pr_1004010580115", me.ImporteImporteFinalTotal.AdaptarMySQL_Decimal())
         R.add("pr_1004010580114", me.CantidadUnidadMedidaBase.AdaptarMySQL_Decimal())
         If Me.ReferenciaCatalogo IsNot nothing then
           R.add("pr_1004010580147",me.ReferenciaCatalogo.ID.STR())
         Else
           R.add("pr_1004010580147","")
         End if
         R.add("pr_1004010580116", me.ImporteDescuentoFijoUnidadDeseado.AdaptarMySQL_Decimal())
         R.add("pr_1004010580148", me.EntidadRelacionadaTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_100401058082", me.ModificarDtoAdicionalA.AdaptarMySQL_Boolean())
         R.add("pr_1004010580111", me.DescuentoProductoAplicadoPorciento.AdaptarMySQL_Decimal())
         R.add("pr_100401058083", me.ModificarDtoGeneral.AdaptarMySQL_Boolean())
         R.add("pr_100401064912", me.ImporteSumaConImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_1004010580112", me.ImporteSaldoPromocionalFijoPorUnidadAplicado.AdaptarMySQL_Decimal())
         R.add("pr_100401058085", me.PermitirProductosFueraDeCatalogo.AdaptarMySQL_Boolean())
         R.add("pr_1004010580119", me.DescuentoEntidadAplicadoPorciento.AdaptarMySQL_Decimal())
         R.add("pr_3004010555313", me.HoraLocal.AdaptarMySQL_Time_Nulable())
         R.add("pr_1004010580120", me.ImporteImporteFinalImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_1004010580121", me.SaldoPromocionalOfertaAplicadoPorciento.AdaptarMySQL_Decimal())
         If Me.ReferenciaDestinador IsNot nothing then
           R.add("pr_3004010555317",me.ReferenciaDestinador.ID.STR())
         Else
           R.add("pr_3004010555317","")
         End if
         R.add("pr_1004010580117", me.ImporteSaldoPromocionalProducto.AdaptarMySQL_Decimal())
         R.add("pr_1004010580118", me.SaldoPromocionalOfertaDeseadoPorciento.AdaptarMySQL_Decimal())
         If Me.ReferenciaUbicacionPrincipal IsNot nothing then
           R.add("pr_3004010555310",me.ReferenciaUbicacionPrincipal.ID.STR())
         Else
           R.add("pr_3004010555310","")
         End if
         If Me.ReferenciaElementoDePresupuestoDeVenta IsNot nothing then
           R.add("pr_50040105801",me.ReferenciaElementoDePresupuestoDeVenta.ID.STR())
         Else
           R.add("pr_50040105801","")
         End if
         R.add("pr_1004010580137", me.DescuentoAdicionalAMotivo.AdaptarMySQL_String())
         If Me.ReferenciaTipoDeVenta IsNot nothing then
           R.add("pr_10040136184",me.ReferenciaTipoDeVenta.ID.STR())
         Else
           R.add("pr_10040136184","")
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
      Public Class FacturasProformaLista_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
          Public property ReferenciaImpuesto As Guid
            get
                return me.GetValue_Guid("pr_1004010580143")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_1004010580143", value)
            End Set
          End Property
          Public property Motivo As String
            get
                return me.GetValue_String("pr_1004010580135")
            End Get
            Set(value As String)
                me.SetValue_String("pr_1004010580135", value)
            End Set
          End Property
        Public ReadOnly property ImporteTotalDescontadoSinImpuestos As Decimal
            get
                return me.GetValue_Decimal("pr_1004010580102")
            End Get   
        End Property
        Public ReadOnly property ImporteImporteSinImpuestos As Decimal
            get
                return me.GetValue_Decimal("pr_100401058099")
            End Get   
        End Property
          Public property ReferenciaMedida As Guid
            get
                return me.GetValue_Guid("pr_1004010580142")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_1004010580142", value)
            End Set
          End Property
        Public ReadOnly property SaldoPromocionalGeneralGeneradoAplicadoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_1004010580100")
            End Get   
        End Property
          Public property ImporteImporteConImpuestos As Decimal
            get
                return me.GetValue_Decimal("pr_100401064911")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_100401064911", value)
            End Set
          End Property
          Public property DescuentoAdicionalBDeseadoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_1004010580101")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_1004010580101", value)
            End Set
          End Property
        Public ReadOnly property DescuentoGeneralAplicadoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_1004010580104")
            End Get   
        End Property
          Public property SaldoPromocionalOfertaMinimoAjustablePorciento As Decimal
            get
                return me.GetValue_Decimal("pr_1004010580105")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_1004010580105", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaEntidadRelacionada As Guid
            get
                return me.GetValue_Guid("pr_1004010580146")
            End Get   
        End Property
          Public property ModificarDtoTipoEntidad As Boolean
            get
                return me.GetValue_Boolean("pr_100401058081")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_100401058081", value)
            End Set
          End Property
          Public property DescuentoAdicionalADeseadoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_1004010580107")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_1004010580107", value)
            End Set
          End Property
          Public property DescuentoTipoEntidadDeseadoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_1004010580106")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_1004010580106", value)
            End Set
          End Property
        Public ReadOnly property ImporteTotalDescuentosGeneralesSinImpuestos As Decimal
            get
                return me.GetValue_Decimal("pr_1004010580108")
            End Get   
        End Property
          Public property ReferenciaPresupuestoDeVenta As Guid
            get
                return me.GetValue_Guid("pr_50040105802")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_50040105802", value)
            End Set
          End Property
        Public ReadOnly property DescuentoTipoEntidadPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_1004010580109")
            End Get   
        End Property
          Public property DescuentoEntidadDeseadoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_1004010580110")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_1004010580110", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_3004010555311")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_3004010555311", value)
            End Set
          End Property
        Public ReadOnly property ElPrecioIndicadoIncluyeLosImpuestos As Boolean
            get
                return me.GetValue_Boolean("pr_100401058080")
            End Get   
        End Property
          Public property ImportePrecioUnidad As Decimal
            get
                return me.GetValue_Decimal("pr_1004010580103")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_1004010580103", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaTipoMovimiento As Guid
            get
                return me.GetValue_Guid("pr_1004010580145")
            End Get   
        End Property
        Public ReadOnly property TotalPorcentajeDeDescuentoAplicadoAProductoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_100401058092")
            End Get   
        End Property
          Public property ImportePrecioUnidadConImpuestos As Decimal
            get
                return me.GetValue_Decimal("pr_10040106692")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_10040106692", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaMedidaBase As Guid
            get
                return me.GetValue_Guid("pr_1004010580138")
            End Get   
        End Property
          Public property Cantidad As Decimal
            get
                return me.GetValue_Decimal("pr_100401058093")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_100401058093", value)
            End Set
          End Property
          Public property DescuentoGeneralDeseadoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_100401058089")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_100401058089", value)
            End Set
          End Property
          Public property SaldoPromocionalGeneralGeneradoDeseadoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_100401058090")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_100401058090", value)
            End Set
          End Property
          Public property ModificarDtoVIP As Boolean
            get
                return me.GetValue_Boolean("pr_100401058078")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_100401058078", value)
            End Set
          End Property
          Public property DescuentoVIPDeseadoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_100401058091")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_100401058091", value)
            End Set
          End Property
          Public property EmpleadoTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_3004010555336")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_3004010555336", value)
            End Set
          End Property
          Public property DescuentoProductoDeseadoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_100401058096")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_100401058096", value)
            End Set
          End Property
          Public property ImporteSaldoPromocionalFijoPorUnidadDeseado As Decimal
            get
                return me.GetValue_Decimal("pr_100401058097")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_100401058097", value)
            End Set
          End Property
        Public ReadOnly property ImporteImporteFinalRetencion As Decimal
            get
                return me.GetValue_Decimal("pr_100401058098")
            End Get   
        End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_3004010555314")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_3004010555314", value)
            End Set
          End Property
        Public ReadOnly property ImporteSumaSinImpuestos As Decimal
            get
                return me.GetValue_Decimal("pr_100401058094")
            End Get   
        End Property
          Public property ReferenciaProducto As Guid
            get
                return me.GetValue_Guid("pr_1004010580141")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_1004010580141", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaElementoCatalogo As Guid
            get
                return me.GetValue_Guid("pr_1004010580140")
            End Get   
        End Property
        Public ReadOnly property FechaDato_UTC As Date
            get
                return me.GetValue_DateTime("pr_3004010555312")
            End Get   
        End Property
        Public ReadOnly property DescuentoAdicionalAAplicadoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_100401058095")
            End Get   
        End Property
        Public ReadOnly property CantidadUnidades As Decimal
            get
                return me.GetValue_Decimal("pr_1004010580123")
            End Get   
        End Property
          Public property ImportePrecioMinimo As Decimal
            get
                return me.GetValue_Decimal("pr_1004010580124")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_1004010580124", value)
            End Set
          End Property
        Public ReadOnly property DescuentoOfertaAplicadoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_1004010580125")
            End Get   
        End Property
          Public property ModificarDtoEntidad As Boolean
            get
                return me.GetValue_Boolean("pr_100401058087")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_100401058087", value)
            End Set
          End Property
        Public ReadOnly property DescuentoAdicionalBAplicadoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_1004010580127")
            End Get   
        End Property
        Public ReadOnly property ImporteSaldoPromocionalGeneral As Decimal
            get
                return me.GetValue_Decimal("pr_1004010580126")
            End Get   
        End Property
          Public property DescuentoOfertaDeseadoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_1004010580122")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_1004010580122", value)
            End Set
          End Property
          Public property ReferenciaEmpleadoPrincipal As Guid
            get
                return me.GetValue_Guid("pr_3004010555309")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_3004010555309", value)
            End Set
          End Property
          Public property ModificarDtoAdicionalB As Boolean
            get
                return me.GetValue_Boolean("pr_100401058086")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_100401058086", value)
            End Set
          End Property
        Public ReadOnly property ImportePrecioUnidadSinImpuestos As Decimal
            get
                return me.GetValue_Decimal("pr_1004010580130")
            End Get   
        End Property
        Public ReadOnly property CantidadMedidaBasePorUnd As Decimal
            get
                return me.GetValue_Decimal("pr_1004010580132")
            End Get   
        End Property
        Public ReadOnly property ImporteTotalDescuentosProductosSinImpuestos As Decimal
            get
                return me.GetValue_Decimal("pr_1004010580131")
            End Get   
        End Property
        Public ReadOnly property ImporteDtoFijoPorUnidadAplicado As Decimal
            get
                return me.GetValue_Decimal("pr_1004010580133")
            End Get   
        End Property
        Public ReadOnly property DescuentoVIPAplicadoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_1004010580134")
            End Get   
        End Property
          Public property ModificarSaldoPromocionalGeneral As Boolean
            get
                return me.GetValue_Boolean("pr_100401058088")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_100401058088", value)
            End Set
          End Property
        Public ReadOnly property PorcentajeDeImpuestosPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_1004010580128")
            End Get   
        End Property
        Public ReadOnly property ImporteImporteFinalSaldoObtenido As Decimal
            get
                return me.GetValue_Decimal("pr_1004010580129")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_3004010555334")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_3004010555334", value)
            End Set
          End Property
        Public ReadOnly property ImporteImporteFinalTotalDescuentoNoAplicados As Decimal
            get
                return me.GetValue_Decimal("pr_1004010580113")
            End Get   
        End Property
          Public property DescuentoAdicionalBMotivo As String
            get
                return me.GetValue_String("pr_1004010580136")
            End Get
            Set(value As String)
                me.SetValue_String("pr_1004010580136", value)
            End Set
          End Property
        Public ReadOnly property ImporteImporteFinalTotal As Decimal
            get
                return me.GetValue_Decimal("pr_1004010580115")
            End Get   
        End Property
        Public ReadOnly property CantidadUnidadMedidaBase As Decimal
            get
                return me.GetValue_Decimal("pr_1004010580114")
            End Get   
        End Property
        Public ReadOnly property ReferenciaCatalogo As Guid
            get
                return me.GetValue_Guid("pr_1004010580147")
            End Get   
        End Property
          Public property ImporteDescuentoFijoUnidadDeseado As Decimal
            get
                return me.GetValue_Decimal("pr_1004010580116")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_1004010580116", value)
            End Set
          End Property
          Public property EntidadRelacionadaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_1004010580148")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_1004010580148", value)
            End Set
          End Property
          Public property ModificarDtoAdicionalA As Boolean
            get
                return me.GetValue_Boolean("pr_100401058082")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_100401058082", value)
            End Set
          End Property
        Public ReadOnly property DescuentoProductoAplicadoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_1004010580111")
            End Get   
        End Property
          Public property ModificarDtoGeneral As Boolean
            get
                return me.GetValue_Boolean("pr_100401058083")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_100401058083", value)
            End Set
          End Property
        Public ReadOnly property ImporteSumaConImpuestos As Decimal
            get
                return me.GetValue_Decimal("pr_100401064912")
            End Get   
        End Property
        Public ReadOnly property ImporteSaldoPromocionalFijoPorUnidadAplicado As Decimal
            get
                return me.GetValue_Decimal("pr_1004010580112")
            End Get   
        End Property
          Public property PermitirProductosFueraDeCatalogo As Boolean
            get
                return me.GetValue_Boolean("pr_100401058085")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_100401058085", value)
            End Set
          End Property
        Public ReadOnly property DescuentoEntidadAplicadoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_1004010580119")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As DateTime
            get
                return me.GetValue_DateTime("pr_3004010555313")
            End Get   
        End Property
        Public ReadOnly property ImporteImporteFinalImpuestos As Decimal
            get
                return me.GetValue_Decimal("pr_1004010580120")
            End Get   
        End Property
        Public ReadOnly property SaldoPromocionalOfertaAplicadoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_1004010580121")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_3004010555317")
            End Get   
        End Property
        Public ReadOnly property ImporteSaldoPromocionalProducto As Decimal
            get
                return me.GetValue_Decimal("pr_1004010580117")
            End Get   
        End Property
          Public property SaldoPromocionalOfertaDeseadoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_1004010580118")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_1004010580118", value)
            End Set
          End Property
          Public property ReferenciaUbicacionPrincipal As Guid
            get
                return me.GetValue_Guid("pr_3004010555310")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_3004010555310", value)
            End Set
          End Property
          Public property ReferenciaElementoDePresupuestoDeVenta As Guid
            get
                return me.GetValue_Guid("pr_50040105801")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_50040105801", value)
            End Set
          End Property
          Public property DescuentoAdicionalAMotivo As String
            get
                return me.GetValue_String("pr_1004010580137")
            End Get
            Set(value As String)
                me.SetValue_String("pr_1004010580137", value)
            End Set
          End Property
          Public property ReferenciaTipoDeVenta As Guid
            get
                return me.GetValue_Guid("pr_10040136184")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_10040136184", value)
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
