   Imports System.ComponentModel
   Imports DinaNETCore
   Imports DinaNETCore.APID
Partial Public Class SeccionesD
  Public Class ComprasRectificativasD
      Public Class ComprasRectificativas_ConListaC
      Public Listador as ComprasRectificativasC
      Public Lista As New List(of ComprasRectificativasListaD.ComprasRectificativasListaC)
        sub new(_listador  as ComprasRectificativasC, _lista as List(of ComprasRectificativasListaD.ComprasRectificativasListaC))
           me.Listador =_listador 
           me.Lista =_lista 
        End sub
      End Class
      Public Shared _SeccionID As String = "2744b5aa-d936-425b-8b57-ee4f15b896c9"
      Public Shared _SeccionIDGUID As New Guid("2744b5aa-d936-425b-8b57-ee4f15b896c9")
      Public Shared Async Function ConsultarDatos_Async(Parametros As SeccionConsultaParametrosC) As Task(Of List(Of ComprasRectificativasC )) 
          Dim R As New List(Of ComprasRectificativasC )  
          Dim d = Await Parametros.DinaupSesion.ConexionServidor.Funcion_Datos_Recibir_Async(ComprasRectificativasES._SeccionID, False, Parametros) 
          If d.Datos.TieneDatos Then 
              For Each Actual In d.Datos 
                  Dim Valores_Listador = Actual.Value.Item1
                  Dim Obj_Listador As New ComprasRectificativasC 
                  Obj_Listador.CargarDatos(Valores_Listador) 
                  Obj_Listador.CargaInterna(Actual.Value)
                  R.Add(Obj_Listador) 
              Next 
          End If 
          Return R 
      End Function 
      Public Shared Async Function ConsultarDatos_ConLista_Async(  Parametros As SeccionConsultaParametrosC ) As Task(Of List(Of  ComprasRectificativas_ConListaC)) 
          Dim R As New List(Of ComprasRectificativas_ConListaC )  
          Dim d =  Await Parametros.DinaupSesion.ConexionServidor.Funcion_Datos_Recibir_Async(ComprasRectificativasES._SeccionID, True, Parametros) 
          If d.Datos.TieneDatos Then 
              For Each Actual In d.Datos 
                  Dim Valores_Listador = Actual.Value.Item1
                  Dim Valores_Lista = Actual.Value.Item2
                  Dim Obj_Listador As New ComprasRectificativasC 
                  Obj_Listador.CargarDatos(Valores_Listador) 
                  Obj_Listador.CargaInterna(Actual.Value)
                  Dim Objs_Listas As New List(Of ComprasRectificativasListaD.ComprasRectificativasListaC) 
                  If Valores_Lista.TieneDatos Then  
                      For Each ValoresLista In Valores_Lista 
                         Dim nItem As New ComprasRectificativasListaD.ComprasRectificativasListaC 
                         nItem.CargarDatos(ValoresLista)   
                         Objs_Listas.Add(nItem)         
                      Next   
                  End If   
                  R.Add(New ComprasRectificativas_ConListaC(Obj_Listador, Objs_Listas))
              Next 
          End If 
          Return R 
      End Function 
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As ComprasRectificativasC, Optional CampoWhere$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Return Await DatosGuardar_Async(DinaupSesion, New List(Of ComprasRectificativasC)({DAtos}), CampoWhere )
      End Function
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As List(Of ComprasRectificativasC), Optional CampoWhere$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Dim Importar As New List(Of DinaupAPI_ImportacionProcesableC)
          For Each Actual In DAtos 
              Dim RegistroActual = New DinaupAPI_ImportacionProcesableC() 
               RegistroActual.dinaup_listador_datos = Actual.ToDic 
               Importar.Add(RegistroActual)  
          Next 
          Return Await DinaupSesion.ConexionServidor.Funcion_Importar_Ejecutar_Async(DinaupSesion, ComprasRectificativasES._SeccionID, Importar, CampoWhere, "") 
      End Function
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As ComprasRectificativas_ConListaC, Optional CampoWhere$ = "id", Optional CampoWhereLista$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Return Await DatosGuardar_Async(DinaupSesion, New List(Of ComprasRectificativas_ConListaC)({DAtos}), CampoWhere, CampoWhereLista)
      End Function
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As List(Of ComprasRectificativas_ConListaC), Optional CampoWhere$ = "id", Optional CampoWhereLista$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Dim Importar As New List(Of DinaupAPI_ImportacionProcesableC)
          For Each Actual In DAtos 
              Dim RegistroActual = New DinaupAPI_ImportacionProcesableC() 
               RegistroActual.dinaup_listador_datos = Actual.Listador.ToDic 
               If Actual.Lista.TieneDatos Then  
                   For Each ActualLista In Actual.Lista  
                       RegistroActual.dinaup_lista_datos.Add(ActualLista.ToDic) 
                   Next 
               End If 
               Importar.Add(RegistroActual)  
          Next 
          Return Await DinaupSesion.ConexionServidor.Funcion_Importar_Ejecutar_Async(DinaupSesion, ComprasRectificativasES._SeccionID, Importar, CampoWhere, CampoWhereLista) 
      End Function
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As ComprasRectificativas_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, ComprasRectificativasES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New ComprasRectificativas_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As ComprasRectificativas_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, ComprasRectificativasES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New ComprasRectificativas_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class ComprasRectificativasES
          Public shared _SeccionID as Guid = New Guid("2744b5aa-d936-425b-8b57-ee4f15b896c9")
          Public shared _Tabla$ = "tpr_300401055510"
      Public Shared ImporteDescuentosGeneralImpuesto1$ = "pr_4004010567848"
      Public Shared ReferenciaResumenImpuesto1$ = "pr_4004010567923"
      Public Shared ImporteTotalDeduccion$ = "pr_4004010567852"
      Public Shared Observaciones$ = "pr_4004010567936"
      Public Shared NumeroDeReferenciaInterna$ = "pr_4004010567943"
      Public Shared ReferenciaResumenImpuesto2$ = "pr_4004010567926"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_3004010555266"
      Public Shared ImporteCuotaImpuesto1$ = "pr_4004010567841"
      Public Shared ImporteBaseImponibleImpuesto2$ = "pr_4004010567840"
      Public Shared DescuentoEntidadAplicadoPorciento$ = "pr_4004010567843"
      Public Shared ReferenciaResumenImpuesto3$ = "pr_4004010567920"
      Public Shared ProveedorTieneAccesoWeb$ = "pr_4004010567935"
      Public Shared ImpuestosIncluidos$ = "pr_4004010567947"
      Public Shared ReferenciaConfiguracionDeCompra$ = "pr_4004010567922"
      Public Shared ReferenciaCompraARectificar$ = "pr_20040105793"
      Public Shared ImporteDescuentoGeneralImpuestoExento$ = "pr_4004010567847"
      Public Shared CantidadDeProductosQueDebenSalir$ = "pr_4004010567864"
      Public Shared AplicarRecargoDeEquivalencia$ = "pr_4004010567949"
      Public Shared ReferenciaTipoDeMovimiento$ = "pr_4004010567928"
      Public Shared ImporteCuotaREImpuesto1$ = "pr_4004010567863"
      Public Shared ImporteImporteRetencion$ = "pr_4004010567867"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_3004010555279"
      Public Shared ImporteSumaConceptosSinImpuestos$ = "pr_4004010567866"
      Public Shared ImporteCuotaImpuesto3$ = "pr_4004010567868"
      Public Shared ReferenciaNumeracionSerie$ = "pr_4004010567929"
      Public Shared TotalSalidosDestinadores$ = "pr_4004010567869"
      Public Shared ImporteSumaDeConceptosImpuesto1$ = "pr_4004010567870"
      Public Shared ImporteBaseImponibleImpuesto3$ = "pr_4004010567854"
      Public Shared ReferenciaDestinador$ = "pr_3004010555275"
      Public Shared HoraLocal$ = "pr_3004010555270"
      Public Shared ImporteTotal$ = "pr_4004010567857"
      Public Shared ImporteDescuentosProductoImpuesto3$ = "pr_4004010567858"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_3004010555267"
      Public Shared ImporteSumaDeConceptosImpuesto3$ = "pr_4004010567859"
      Public Shared DescuentoGeneralAplicadoPorciento$ = "pr_4004010567860"
      Public Shared DescuentoAdicionalAAplicadoPorciento$ = "pr_4004010567884"
      Public Shared DescripcionDescuentoAdicionalA$ = "pr_4004010567938"
      Public Shared ImporteTotalACobrar$ = "pr_4004010567890"
      Public Shared ImporteCuotaREImpuesto2$ = "pr_4004010567889"
      Public Shared ImporteSubtotal$ = "pr_4004010567886"
      Public Shared ImporteTotalImpuestos$ = "pr_4004010567888"
      Public Shared ImporteCuotaImpuesto2$ = "pr_4004010567891"
      Public Shared ImporteCuotaREImpuesto3$ = "pr_4004010567872"
      Public Shared ImporteSumaDeConceptosImpuestoExentos$ = "pr_4004010567879"
      Public Shared ImporteSumaDeConceptosImpuesto2$ = "pr_4004010567878"
      Public Shared ImporteSumaImporteProductosConImpuestos$ = "pr_4004010567882"
      Public Shared NumeroDeReferenciaInternaCompleto$ = "pr_4004010567937"
      Public Shared ReferenciaAutorDelAlta$ = "pr_3004010555268"
      Public Shared ReferenciaProveedor$ = "pr_4004010567934"
      Public Shared DescripcionDescuentoAdicionalB$ = "pr_4004010567939"
      Public Shared ImporteSumaImporteDeProductosSinImpuestos$ = "pr_4004010567910"
      Public Shared ImporteDescuentosProductoImpuesto1$ = "pr_4004010567915"
      Public Shared DescuentoAdicionalBAplicadoPorciento$ = "pr_4004010567913"
      Public Shared ImporteDescuentosGeneralImpuesto2$ = "pr_4004010567916"
      Public Shared ImporteDescuentosProductoExento$ = "pr_4004010567895"
      Public Shared ImporteBaseImponibleImpuesto1$ = "pr_4004010567900"
      Public Shared ReferenciaRetencion$ = "pr_4004010567931"
      Public Shared ImporteDescuentosProductoImpuesto2$ = "pr_4004010567896"
      Public Shared SumaConceptosConImpuestos$ = "pr_60040115042"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_3004010555277"
      Public Shared TotalPorcentajeDescuentosGeneralesPorciento$ = "pr_4004010567901"
      Public Shared FechaDato_UTC$ = "pr_3004010555269"
      Public Shared ImporteTotalCobrado$ = "pr_4004010567907"
      Public Shared CantidadDeProductos$ = "pr_4004010567908"
      Public Shared ReferenciaEstado$ = "pr_4004010567933"
      Public Shared ImporteTotalDescontadoSinImpuestos$ = "pr_4004010567904"
      Public Shared ImporteBaseImponibleExenta$ = "pr_4004010567905"
      Public Shared ImporteDescuentosGeneralImpuesto3$ = "pr_4004010567906"
      Public Shared ReferenciaPuestoDeTrabajo$ = "pr_4004010567932"
      Public Shared FechaAlta_UTC$ = "pr_3004010555272"
      Public Shared FechaContable$ = "pr_30040135704"
      Public Shared ReferenciaAsientoContable$ = "pr_40040135292"
      Public Shared DenominacionRazonSocialProveedor$ = "pr_20040138823"
      Public Shared MunicipioEmpresa$ = "pr_300401388210"
      Public Shared DireccionProveedor$ = "pr_20040138828"
      Public Shared ReferenciaDatosFiscalesProveedor$ = "pr_20040138821"
      Public Shared CodigoPostalProveedor$ = "pr_20040138822"
      Public Shared ProvinciaProveedor$ = "pr_20040138824"
      Public Shared PaisProveedor$ = "pr_20040138825"
      Public Shared DireccionEmpresa$ = "pr_30040138823"
      Public Shared TelefonoEmpresa$ = "pr_30040138822"
      Public Shared TelefonoProveedor$ = "pr_20040138826"
      Public Shared MunicipioProveedor$ = "pr_20040138829"
      Public Shared DenominacionRazonSocialEmpresa$ = "pr_30040138824"
      Public Shared ReferenciaDatosFiscalesEmpresa$ = "pr_30040138827"
      Public Shared CodigoPostalEmpresa$ = "pr_30040138826"
      Public Shared PaisEmpresa$ = "pr_30040138828"
      Public Shared CIFNIFEmpresa$ = "pr_30040138825"
      Public Shared ProvinciaEmpresa$ = "pr_30040138829"
      Public Shared CIFNIFProveedor$ = "pr_20040138827"
      Public Shared NumeroDeFactura$ = "pr_10040145301"
      Public Shared ImporteImporteImpuestoGeneral$ = "pr_30040148965"
      Public Shared ReferenciaImpuestoGeneral$ = "pr_30040148964"
      Public Shared EsGasto$ = "pr_30040163141"
      Public Shared MarcarComoConcluidaAunqueHayanProcesosPendientes$ = "pr_60040173901"
      Public Shared CondicionDePagoDias$ = "pr_60040176522"
      Public Shared FechaDeVencimiento$ = "pr_60040176521"
      Public Shared CondicionesDePago$ = "pr_60040176523"
      Public Shared OperacionIntragrupo$ = "pr_40040238923"
      Public Shared InversionDelSujetoPasivo$ = "pr_10040238942"
      Public Shared RegimenEspecialDeBienesUsados$ = "pr_50040238943"
      Public Shared CodigoPaisProveedor$ = "pr_20040241543"
      Public Shared CodigoProvinciaProveedor$ = "pr_20040241544"
      Public Shared TipoCIFNIFProveedor$ = "pr_20040241601"
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
      Public Class ComprasRectificativasC
      Inherits Base_DatoC
          <DisplayName("Descuentos General Impuesto 1")>
          Public Property ImporteDescuentosGeneralImpuesto1 As Decimal
          Public Shared ___ImporteDescuentosGeneralImpuesto1 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentosGeneralImpuesto1"",""etiqueta"": ""Descuentos General Impuesto 1"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuentos General Impuesto 1"",""descripcion"": """",""keyword"": ""ImporteDescuentosGeneralImpuesto1"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentosGeneralImpuesto1 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentosGeneralImpuesto1
          <DisplayName("Resumen Impuesto 1")>
          Public Property ReferenciaResumenImpuesto1 As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaResumenImpuesto1 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaResumenImpuesto1"",""etiqueta"": ""Resumen Impuesto 1"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""f3199ee0-dc83-4667-a9c1-f3b04e97a8a4"",""titulo"": ""Base - Impuestos"",""iconoid"": ""ff4a7189-6426-43b9-bdc4-070314999e81"",""etiquetasingular"": ""Impuesto"",""etiquetaplural"": ""Impuestos"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""f3199ee0-dc83-4667-a9c1-f3b04e97a8a4"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Resumen Impuesto 1"",""descripcion"": """",""keyword"": ""ReferenciaResumenImpuesto1"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaResumenImpuesto1 As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaResumenImpuesto1
          <DisplayName("Total Deducción")>
          Public Property ImporteTotalDeduccion As Decimal
          Public Shared ___ImporteTotalDeduccion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteTotalDeduccion"",""etiqueta"": ""Total Deducción"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total Deducción"",""descripcion"": """",""keyword"": ""ImporteTotalDeduccion"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteTotalDeduccion As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteTotalDeduccion
          <Description("Observaciones adicionales de la venta.")>
          <DisplayName("Observaciones y anotaciones")>
          Public Property Observaciones As String
          Public Shared ___Observaciones As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Observaciones"",""etiqueta"": ""Observaciones y anotaciones"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 9,""decimales"": ""0"",""multilinea"": true,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Observaciones y anotaciones"",""descripcion"": """",""keyword"": ""Observaciones"",""formato"": 5,""rol"": 9,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Observaciones As DinaNETCore.APID.DinaupAPI_CampoC = ___Observaciones
          <DisplayName("Número de referencia interna")>
          Public Property NumeroDeReferenciaInterna As Integer
          Public Shared ___NumeroDeReferenciaInterna As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""NumeroDeReferenciaInterna"",""etiqueta"": ""Número de referencia interna"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Número de referencia interna"",""descripcion"": """",""keyword"": ""NumeroDeReferenciaInterna"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __NumeroDeReferenciaInterna As DinaNETCore.APID.DinaupAPI_CampoC = ___NumeroDeReferenciaInterna
          <DisplayName("Resumen impuesto 2")>
          Public Property ReferenciaResumenImpuesto2 As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaResumenImpuesto2 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaResumenImpuesto2"",""etiqueta"": ""Resumen impuesto 2"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""f3199ee0-dc83-4667-a9c1-f3b04e97a8a4"",""titulo"": ""Base - Impuestos"",""iconoid"": ""ff4a7189-6426-43b9-bdc4-070314999e81"",""etiquetasingular"": ""Impuesto"",""etiquetaplural"": ""Impuestos"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""f3199ee0-dc83-4667-a9c1-f3b04e97a8a4"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Resumen impuesto 2"",""descripcion"": """",""keyword"": ""ReferenciaResumenImpuesto2"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaResumenImpuesto2 As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaResumenImpuesto2
          <DisplayName("Empleado")>
          Public Property ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaEmpleadoPrincipal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaEmpleadoPrincipal"",""etiqueta"": ""Empleado"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c6e071c7-776f-4300-aa55-c711fd1da916"",""titulo"": ""Empleados"",""iconoid"": ""1c8abf82-640c-4d18-b62c-89de310923dd"",""etiquetasingular"": ""Empleado"",""etiquetaplural"": ""Empleados"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""c6e071c7-776f-4300-aa55-c711fd1da916"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empleado"",""descripcion"": """",""keyword"": ""ReferenciaEmpleadoPrincipal"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaEmpleadoPrincipal
          <DisplayName("Cuota Impuesto 1")>
          Public Property ImporteCuotaImpuesto1 As Decimal
          Public Shared ___ImporteCuotaImpuesto1 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteCuotaImpuesto1"",""etiqueta"": ""Cuota Impuesto 1"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cuota Impuesto 1"",""descripcion"": """",""keyword"": ""ImporteCuotaImpuesto1"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteCuotaImpuesto1 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteCuotaImpuesto1
          <DisplayName("Base imponible impuesto 2")>
          Public Property ImporteBaseImponibleImpuesto2 As Decimal
          Public Shared ___ImporteBaseImponibleImpuesto2 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteBaseImponibleImpuesto2"",""etiqueta"": ""Base imponible impuesto 2"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Base imponible impuesto 2"",""descripcion"": """",""keyword"": ""ImporteBaseImponibleImpuesto2"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteBaseImponibleImpuesto2 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteBaseImponibleImpuesto2
          <Description("Descuento perteneciente a la entidad que se ha aplicado.")>
          <DisplayName("Descuento Entidad % (Aplicado)")>
          Public Property DescuentoEntidadAplicadoPorciento As Decimal
          Public Shared ___DescuentoEntidadAplicadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoEntidadAplicadoPorciento"",""etiqueta"": ""Descuento Entidad % (Aplicado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento Entidad % (Aplicado)"",""descripcion"": """",""keyword"": ""DescuentoEntidadAplicadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoEntidadAplicadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoEntidadAplicadoPorciento
          <DisplayName("Resumen impuesto 3")>
          Public Property ReferenciaResumenImpuesto3 As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaResumenImpuesto3 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaResumenImpuesto3"",""etiqueta"": ""Resumen impuesto 3"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""f3199ee0-dc83-4667-a9c1-f3b04e97a8a4"",""titulo"": ""Base - Impuestos"",""iconoid"": ""ff4a7189-6426-43b9-bdc4-070314999e81"",""etiquetasingular"": ""Impuesto"",""etiquetaplural"": ""Impuestos"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""f3199ee0-dc83-4667-a9c1-f3b04e97a8a4"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Resumen impuesto 3"",""descripcion"": """",""keyword"": ""ReferenciaResumenImpuesto3"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaResumenImpuesto3 As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaResumenImpuesto3
          <DisplayName("Proveedor Tiene Acceso web")>
          Public Property ProveedorTieneAccesoWeb As Boolean
          Public Shared ___ProveedorTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ProveedorTieneAccesoWeb"",""etiqueta"": ""Proveedor Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Proveedor Tiene Acceso web"",""descripcion"": """",""keyword"": ""ProveedorTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ProveedorTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___ProveedorTieneAccesoWeb
          <DisplayName("Impuestos incluidos")>
          Public Property ImpuestosIncluidos As Boolean
          Public Shared ___ImpuestosIncluidos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImpuestosIncluidos"",""etiqueta"": ""Impuestos incluidos"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Impuestos incluidos"",""descripcion"": """",""keyword"": ""ImpuestosIncluidos"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImpuestosIncluidos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImpuestosIncluidos
          <DisplayName("Configuración de compra")>
          Public Property ReferenciaConfiguracionDeCompra As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaConfiguracionDeCompra As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaConfiguracionDeCompra"",""etiqueta"": ""Configuración de compra"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""afd1a074-0e8f-4e19-916c-030b70b00354"",""titulo"": ""Base - Configuración Compras/Gastos"",""iconoid"": ""51dda3d6-b61f-45d3-a4fb-3a9d3bfc4128"",""etiquetasingular"": ""Configuración Compras/Gastos"",""etiquetaplural"": ""Configuraciones Compras/Gastos"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""afd1a074-0e8f-4e19-916c-030b70b00354"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Configuración de compra"",""descripcion"": """",""keyword"": ""ReferenciaConfiguracionDeCompra"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaConfiguracionDeCompra As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaConfiguracionDeCompra
          <DisplayName("Compra a rectificar")>
          Public Property ReferenciaCompraARectificar As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaCompraARectificar As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaCompraARectificar"",""etiqueta"": ""Compra a rectificar"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""340bde1f-cdc9-4471-b55e-44b9c96dd508"",""titulo"": ""Base - Compras y Gastos"",""iconoid"": ""5686dc42-beaf-4bc5-a068-97126541fa55"",""etiquetasingular"": ""Compra / Gasto"",""etiquetaplural"": ""Compras / Gastos"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""340bde1f-cdc9-4471-b55e-44b9c96dd508"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Compra a rectificar"",""descripcion"": """",""keyword"": ""ReferenciaCompraARectificar"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaCompraARectificar As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaCompraARectificar
          <DisplayName("Descuento General impuesto Exento")>
          Public Property ImporteDescuentoGeneralImpuestoExento As Decimal
          Public Shared ___ImporteDescuentoGeneralImpuestoExento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentoGeneralImpuestoExento"",""etiqueta"": ""Descuento General impuesto Exento"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento General impuesto Exento"",""descripcion"": """",""keyword"": ""ImporteDescuentoGeneralImpuestoExento"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentoGeneralImpuestoExento As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentoGeneralImpuestoExento
          <DisplayName("Cantidad de productos que deben salir")>
          Public Property CantidadDeProductosQueDebenSalir As Decimal
          Public Shared ___CantidadDeProductosQueDebenSalir As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CantidadDeProductosQueDebenSalir"",""etiqueta"": ""Cantidad de productos que deben salir"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""11"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cantidad de productos que deben salir"",""descripcion"": """",""keyword"": ""CantidadDeProductosQueDebenSalir"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CantidadDeProductosQueDebenSalir As DinaNETCore.APID.DinaupAPI_CampoC = ___CantidadDeProductosQueDebenSalir
          <DisplayName("Aplicar Recargo de equivalencia")>
          Public Property AplicarRecargoDeEquivalencia As Boolean
          Public Shared ___AplicarRecargoDeEquivalencia As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AplicarRecargoDeEquivalencia"",""etiqueta"": ""Aplicar Recargo de equivalencia"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Aplicar Recargo de equivalencia"",""descripcion"": """",""keyword"": ""AplicarRecargoDeEquivalencia"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AplicarRecargoDeEquivalencia As DinaNETCore.APID.DinaupAPI_CampoC = ___AplicarRecargoDeEquivalencia
          <DisplayName("Tipo de movimiento")>
          Public Property ReferenciaTipoDeMovimiento As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaTipoDeMovimiento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaTipoDeMovimiento"",""etiqueta"": ""Tipo de movimiento"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""ef5644b0-fb98-4191-908d-99594d9e1cc5"",""titulo"": ""Base - Tipos de movimiento"",""iconoid"": ""d720d25f-f5b8-4c83-a9f3-a8bf6cb31468"",""etiquetasingular"": ""Tipo de movimiento"",""etiquetaplural"": ""Tipos de movimiento"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""ef5644b0-fb98-4191-908d-99594d9e1cc5"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Tipo de movimiento"",""descripcion"": """",""keyword"": ""ReferenciaTipoDeMovimiento"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaTipoDeMovimiento As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaTipoDeMovimiento
          <DisplayName("Cuota R.E Impuesto 1")>
          Public Property ImporteCuotaREImpuesto1 As Decimal
          Public Shared ___ImporteCuotaREImpuesto1 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteCuotaREImpuesto1"",""etiqueta"": ""Cuota R.E Impuesto 1"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cuota R.E Impuesto 1"",""descripcion"": """",""keyword"": ""ImporteCuotaREImpuesto1"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteCuotaREImpuesto1 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteCuotaREImpuesto1
          <DisplayName("Importe retención")>
          Public Property ImporteImporteRetencion As Decimal
          Public Shared ___ImporteImporteRetencion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteImporteRetencion"",""etiqueta"": ""Importe retención"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Importe retención"",""descripcion"": """",""keyword"": ""ImporteImporteRetencion"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteImporteRetencion As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteImporteRetencion
          <DisplayName("Autor del alta Tiene Acceso web")>
          Public Property AutorDelAltaTieneAccesoWeb As Boolean
          Public Shared ___AutorDelAltaTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AutorDelAltaTieneAccesoWeb"",""etiqueta"": ""Autor del alta Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta Tiene Acceso web"",""descripcion"": """",""keyword"": ""AutorDelAltaTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AutorDelAltaTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___AutorDelAltaTieneAccesoWeb
          <Description("Importe total de los productos del documento, sin ningún tipo de descuento y/o impuestos aplicado.")>
          <DisplayName("Suma conceptos (Sin impuestos)")>
          Public Property ImporteSumaConceptosSinImpuestos As Decimal
          Public Shared ___ImporteSumaConceptosSinImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSumaConceptosSinImpuestos"",""etiqueta"": ""Suma conceptos (Sin impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Suma conceptos (Sin impuestos)"",""descripcion"": """",""keyword"": ""ImporteSumaConceptosSinImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSumaConceptosSinImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSumaConceptosSinImpuestos
          <DisplayName("Cuota Impuesto 3")>
          Public Property ImporteCuotaImpuesto3 As Decimal
          Public Shared ___ImporteCuotaImpuesto3 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteCuotaImpuesto3"",""etiqueta"": ""Cuota Impuesto 3"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cuota Impuesto 3"",""descripcion"": """",""keyword"": ""ImporteCuotaImpuesto3"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteCuotaImpuesto3 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteCuotaImpuesto3
          <DisplayName("Numeración / Serie")>
          Public Property ReferenciaNumeracionSerie As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaNumeracionSerie As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaNumeracionSerie"",""etiqueta"": ""Numeración / Serie"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""a93edb96-3ad2-4498-a1ca-696737b93cea"",""titulo"": ""Base - Numeraciones / Series"",""iconoid"": ""5ae6b089-a12a-417c-92c2-d64de875e355"",""etiquetasingular"": ""Numeración / Serie"",""etiquetaplural"": ""Numeraciones / Series"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""a93edb96-3ad2-4498-a1ca-696737b93cea"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Numeración / Serie"",""descripcion"": """",""keyword"": ""ReferenciaNumeracionSerie"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaNumeracionSerie As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaNumeracionSerie
          <DisplayName("Total salidos (Destinadores)")>
          Public Property TotalSalidosDestinadores As Decimal
          Public Shared ___TotalSalidosDestinadores As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TotalSalidosDestinadores"",""etiqueta"": ""Total salidos (Destinadores)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""11"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total salidos (Destinadores)"",""descripcion"": """",""keyword"": ""TotalSalidosDestinadores"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __TotalSalidosDestinadores As DinaNETCore.APID.DinaupAPI_CampoC = ___TotalSalidosDestinadores
          <DisplayName("Suma de conceptos Impuesto 1")>
          Public Property ImporteSumaDeConceptosImpuesto1 As Decimal
          Public Shared ___ImporteSumaDeConceptosImpuesto1 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSumaDeConceptosImpuesto1"",""etiqueta"": ""Suma de conceptos Impuesto 1"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Suma de conceptos Impuesto 1"",""descripcion"": """",""keyword"": ""ImporteSumaDeConceptosImpuesto1"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSumaDeConceptosImpuesto1 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSumaDeConceptosImpuesto1
          <DisplayName("Base imponible impuesto 3")>
          Public Property ImporteBaseImponibleImpuesto3 As Decimal
          Public Shared ___ImporteBaseImponibleImpuesto3 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteBaseImponibleImpuesto3"",""etiqueta"": ""Base imponible impuesto 3"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Base imponible impuesto 3"",""descripcion"": """",""keyword"": ""ImporteBaseImponibleImpuesto3"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteBaseImponibleImpuesto3 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteBaseImponibleImpuesto3
          <DisplayName("Destinador")>
          Public Property ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaDestinador As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaDestinador"",""etiqueta"": ""Destinador"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""relacionesindirectas"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Destinador"",""descripcion"": """",""keyword"": ""ReferenciaDestinador"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaDestinador
          <DisplayName("Hora local")>
          Public Property HoraLocal As DateTime?
          Public Shared ___HoraLocal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""HoraLocal"",""etiqueta"": ""Hora local"",""oculta"": false,""formato"": 8,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Hora local"",""descripcion"": """",""keyword"": ""HoraLocal"",""formato"": 8,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __HoraLocal As DinaNETCore.APID.DinaupAPI_CampoC = ___HoraLocal
          <DisplayName("Total")>
          Public Property ImporteTotal As Decimal
          Public Shared ___ImporteTotal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteTotal"",""etiqueta"": ""Total"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total"",""descripcion"": """",""keyword"": ""ImporteTotal"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteTotal As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteTotal
          <DisplayName("Descuentos Producto Impuesto 3")>
          Public Property ImporteDescuentosProductoImpuesto3 As Decimal
          Public Shared ___ImporteDescuentosProductoImpuesto3 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentosProductoImpuesto3"",""etiqueta"": ""Descuentos Producto Impuesto 3"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuentos Producto Impuesto 3"",""descripcion"": """",""keyword"": ""ImporteDescuentosProductoImpuesto3"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentosProductoImpuesto3 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentosProductoImpuesto3
          <DisplayName("Ubicación Principal")>
          Public Property ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaUbicacionPrincipal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaUbicacionPrincipal"",""etiqueta"": ""Ubicación Principal"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""b9adbfbf-a81a-45fb-861c-90502902c982"",""titulo"": ""Ubicaciones"",""iconoid"": ""b985b58f-7275-46b8-9b66-2c54346b0185"",""etiquetasingular"": ""Ubicación"",""etiquetaplural"": ""Ubicaciones"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""b9adbfbf-a81a-45fb-861c-90502902c982"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Ubicación Principal"",""descripcion"": """",""keyword"": ""ReferenciaUbicacionPrincipal"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaUbicacionPrincipal
          <DisplayName("Suma de conceptos Impuesto 3")>
          Public Property ImporteSumaDeConceptosImpuesto3 As Decimal
          Public Shared ___ImporteSumaDeConceptosImpuesto3 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSumaDeConceptosImpuesto3"",""etiqueta"": ""Suma de conceptos Impuesto 3"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Suma de conceptos Impuesto 3"",""descripcion"": """",""keyword"": ""ImporteSumaDeConceptosImpuesto3"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSumaDeConceptosImpuesto3 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSumaDeConceptosImpuesto3
          <Description("Descuento general de la venta que se ha aplicado.")>
          <DisplayName("Descuento General % (Aplicado)")>
          Public Property DescuentoGeneralAplicadoPorciento As Decimal
          Public Shared ___DescuentoGeneralAplicadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoGeneralAplicadoPorciento"",""etiqueta"": ""Descuento General % (Aplicado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento General % (Aplicado)"",""descripcion"": """",""keyword"": ""DescuentoGeneralAplicadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoGeneralAplicadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoGeneralAplicadoPorciento
          <Description("Porcentaje de  descuento adicional A que se ha aplicado.")>
          <DisplayName("Descuento adicional A % (Aplicado)")>
          Public Property DescuentoAdicionalAAplicadoPorciento As Decimal
          Public Shared ___DescuentoAdicionalAAplicadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoAdicionalAAplicadoPorciento"",""etiqueta"": ""Descuento adicional A % (Aplicado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento adicional A % (Aplicado)"",""descripcion"": """",""keyword"": ""DescuentoAdicionalAAplicadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoAdicionalAAplicadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoAdicionalAAplicadoPorciento
          <DisplayName("Descripción descuento adicional A")>
          Public Property DescripcionDescuentoAdicionalA As String
          Public Shared ___DescripcionDescuentoAdicionalA As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescripcionDescuentoAdicionalA"",""etiqueta"": ""Descripción descuento adicional A"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descripción descuento adicional A"",""descripcion"": """",""keyword"": ""DescripcionDescuentoAdicionalA"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescripcionDescuentoAdicionalA As DinaNETCore.APID.DinaupAPI_CampoC = ___DescripcionDescuentoAdicionalA
          <DisplayName("Total a cobrar")>
          Public Property ImporteTotalACobrar As Decimal
          Public Shared ___ImporteTotalACobrar As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteTotalACobrar"",""etiqueta"": ""Total a cobrar"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total a cobrar"",""descripcion"": """",""keyword"": ""ImporteTotalACobrar"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteTotalACobrar As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteTotalACobrar
          <DisplayName("Cuota R.E Impuesto 2")>
          Public Property ImporteCuotaREImpuesto2 As Decimal
          Public Shared ___ImporteCuotaREImpuesto2 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteCuotaREImpuesto2"",""etiqueta"": ""Cuota R.E Impuesto 2"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cuota R.E Impuesto 2"",""descripcion"": """",""keyword"": ""ImporteCuotaREImpuesto2"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteCuotaREImpuesto2 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteCuotaREImpuesto2
          <Description("Importe total sin impuestos ni retenciones." & vbCrLf & "Pero con todas las bonificaciones aplicadas y todos los importes sumados." & vbCrLf & "Es el paso anterior al resultado final.")>
          <DisplayName("Subtotal")>
          Public Property ImporteSubtotal As Decimal
          Public Shared ___ImporteSubtotal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSubtotal"",""etiqueta"": ""Subtotal"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Subtotal"",""descripcion"": """",""keyword"": ""ImporteSubtotal"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSubtotal As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSubtotal
          <Description("Importe total de impuestos.")>
          <DisplayName("Total impuestos")>
          Public Property ImporteTotalImpuestos As Decimal
          Public Shared ___ImporteTotalImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteTotalImpuestos"",""etiqueta"": ""Total impuestos"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total impuestos"",""descripcion"": """",""keyword"": ""ImporteTotalImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteTotalImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteTotalImpuestos
          <DisplayName("Cuota Impuesto 2")>
          Public Property ImporteCuotaImpuesto2 As Decimal
          Public Shared ___ImporteCuotaImpuesto2 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteCuotaImpuesto2"",""etiqueta"": ""Cuota Impuesto 2"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cuota Impuesto 2"",""descripcion"": """",""keyword"": ""ImporteCuotaImpuesto2"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteCuotaImpuesto2 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteCuotaImpuesto2
          <DisplayName("Cuota R.E Impuesto 3")>
          Public Property ImporteCuotaREImpuesto3 As Decimal
          Public Shared ___ImporteCuotaREImpuesto3 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteCuotaREImpuesto3"",""etiqueta"": ""Cuota R.E Impuesto 3"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cuota R.E Impuesto 3"",""descripcion"": """",""keyword"": ""ImporteCuotaREImpuesto3"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteCuotaREImpuesto3 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteCuotaREImpuesto3
          <DisplayName("Suma de conceptos Impuesto Exentos")>
          Public Property ImporteSumaDeConceptosImpuestoExentos As Decimal
          Public Shared ___ImporteSumaDeConceptosImpuestoExentos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSumaDeConceptosImpuestoExentos"",""etiqueta"": ""Suma de conceptos Impuesto Exentos"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Suma de conceptos Impuesto Exentos"",""descripcion"": """",""keyword"": ""ImporteSumaDeConceptosImpuestoExentos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSumaDeConceptosImpuestoExentos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSumaDeConceptosImpuestoExentos
          <DisplayName("Suma de conceptos Impuesto 2")>
          Public Property ImporteSumaDeConceptosImpuesto2 As Decimal
          Public Shared ___ImporteSumaDeConceptosImpuesto2 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSumaDeConceptosImpuesto2"",""etiqueta"": ""Suma de conceptos Impuesto 2"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Suma de conceptos Impuesto 2"",""descripcion"": """",""keyword"": ""ImporteSumaDeConceptosImpuesto2"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSumaDeConceptosImpuesto2 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSumaDeConceptosImpuesto2
          <DisplayName("Suma Importe Productos (Con impuestos)")>
          Public Property ImporteSumaImporteProductosConImpuestos As Decimal
          Public Shared ___ImporteSumaImporteProductosConImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSumaImporteProductosConImpuestos"",""etiqueta"": ""Suma Importe Productos (Con impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Suma Importe Productos (Con impuestos)"",""descripcion"": """",""keyword"": ""ImporteSumaImporteProductosConImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSumaImporteProductosConImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSumaImporteProductosConImpuestos
          <DisplayName("Número de referencia interna (Completo)")>
          Public Property NumeroDeReferenciaInternaCompleto As String
          Public Shared ___NumeroDeReferenciaInternaCompleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""NumeroDeReferenciaInternaCompleto"",""etiqueta"": ""Número de referencia interna (Completo)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Número de referencia interna (Completo)"",""descripcion"": """",""keyword"": ""NumeroDeReferenciaInternaCompleto"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __NumeroDeReferenciaInternaCompleto As DinaNETCore.APID.DinaupAPI_CampoC = ___NumeroDeReferenciaInternaCompleto
          <DisplayName("Autor del alta")>
          Public Property ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaAutorDelAlta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaAutorDelAlta"",""etiqueta"": ""Autor del alta"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta"",""descripcion"": """",""keyword"": ""ReferenciaAutorDelAlta"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaAutorDelAlta
          <DisplayName("Proveedor")>
          Public Property ReferenciaProveedor As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaProveedor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaProveedor"",""etiqueta"": ""Proveedor"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Proveedor"",""descripcion"": """",""keyword"": ""ReferenciaProveedor"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaProveedor As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaProveedor
          <DisplayName("Descripción descuento adicional B")>
          Public Property DescripcionDescuentoAdicionalB As String
          Public Shared ___DescripcionDescuentoAdicionalB As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescripcionDescuentoAdicionalB"",""etiqueta"": ""Descripción descuento adicional B"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descripción descuento adicional B"",""descripcion"": """",""keyword"": ""DescripcionDescuentoAdicionalB"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescripcionDescuentoAdicionalB As DinaNETCore.APID.DinaupAPI_CampoC = ___DescripcionDescuentoAdicionalB
          <DisplayName("Suma importe de productos (Sin Impuestos)")>
          Public Property ImporteSumaImporteDeProductosSinImpuestos As Decimal
          Public Shared ___ImporteSumaImporteDeProductosSinImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSumaImporteDeProductosSinImpuestos"",""etiqueta"": ""Suma importe de productos (Sin Impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Suma importe de productos (Sin Impuestos)"",""descripcion"": """",""keyword"": ""ImporteSumaImporteDeProductosSinImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSumaImporteDeProductosSinImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSumaImporteDeProductosSinImpuestos
          <DisplayName("Descuentos Producto Impuesto 1")>
          Public Property ImporteDescuentosProductoImpuesto1 As Decimal
          Public Shared ___ImporteDescuentosProductoImpuesto1 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentosProductoImpuesto1"",""etiqueta"": ""Descuentos Producto Impuesto 1"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuentos Producto Impuesto 1"",""descripcion"": """",""keyword"": ""ImporteDescuentosProductoImpuesto1"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentosProductoImpuesto1 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentosProductoImpuesto1
          <Description("Porcentaje de  descuento adicional B que se ha aplicado.")>
          <DisplayName("Descuento adicional B % (Aplicado)")>
          Public Property DescuentoAdicionalBAplicadoPorciento As Decimal
          Public Shared ___DescuentoAdicionalBAplicadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoAdicionalBAplicadoPorciento"",""etiqueta"": ""Descuento adicional B % (Aplicado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento adicional B % (Aplicado)"",""descripcion"": """",""keyword"": ""DescuentoAdicionalBAplicadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoAdicionalBAplicadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoAdicionalBAplicadoPorciento
          <DisplayName("Descuentos General Impuesto 2")>
          Public Property ImporteDescuentosGeneralImpuesto2 As Decimal
          Public Shared ___ImporteDescuentosGeneralImpuesto2 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentosGeneralImpuesto2"",""etiqueta"": ""Descuentos General Impuesto 2"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuentos General Impuesto 2"",""descripcion"": """",""keyword"": ""ImporteDescuentosGeneralImpuesto2"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentosGeneralImpuesto2 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentosGeneralImpuesto2
          <DisplayName("Descuentos Producto Exento")>
          Public Property ImporteDescuentosProductoExento As Decimal
          Public Shared ___ImporteDescuentosProductoExento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentosProductoExento"",""etiqueta"": ""Descuentos Producto Exento"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuentos Producto Exento"",""descripcion"": """",""keyword"": ""ImporteDescuentosProductoExento"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentosProductoExento As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentosProductoExento
          <DisplayName("Base imponible impuesto 1")>
          Public Property ImporteBaseImponibleImpuesto1 As Decimal
          Public Shared ___ImporteBaseImponibleImpuesto1 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteBaseImponibleImpuesto1"",""etiqueta"": ""Base imponible impuesto 1"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Base imponible impuesto 1"",""descripcion"": """",""keyword"": ""ImporteBaseImponibleImpuesto1"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteBaseImponibleImpuesto1 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteBaseImponibleImpuesto1
          <DisplayName("Retención")>
          Public Property ReferenciaRetencion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaRetencion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaRetencion"",""etiqueta"": ""Retención"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""1a89014d-3991-4d9d-8d0f-77fcf2ddff5e"",""titulo"": ""Base - Retenciones"",""iconoid"": ""13560fd4-34fc-42bc-b12d-007e26e5f428"",""etiquetasingular"": ""Retención"",""etiquetaplural"": ""Retenciones"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""1a89014d-3991-4d9d-8d0f-77fcf2ddff5e"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Retención"",""descripcion"": """",""keyword"": ""ReferenciaRetencion"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaRetencion As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaRetencion
          <DisplayName("Descuentos Producto Impuesto 2")>
          Public Property ImporteDescuentosProductoImpuesto2 As Decimal
          Public Shared ___ImporteDescuentosProductoImpuesto2 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentosProductoImpuesto2"",""etiqueta"": ""Descuentos Producto Impuesto 2"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuentos Producto Impuesto 2"",""descripcion"": """",""keyword"": ""ImporteDescuentosProductoImpuesto2"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentosProductoImpuesto2 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentosProductoImpuesto2
          <DisplayName("Suma conceptos (Con impuestos)")>
          Public Property SumaConceptosConImpuestos As Decimal
          Public Shared ___SumaConceptosConImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""SumaConceptosConImpuestos"",""etiqueta"": ""Suma conceptos (Con impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Suma conceptos (Con impuestos)"",""descripcion"": """",""keyword"": ""SumaConceptosConImpuestos"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __SumaConceptosConImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___SumaConceptosConImpuestos
          <DisplayName("Empleado Tiene Acceso web")>
          Public Property EmpleadoTieneAccesoWeb As Boolean
          Public Shared ___EmpleadoTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EmpleadoTieneAccesoWeb"",""etiqueta"": ""Empleado Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empleado Tiene Acceso web"",""descripcion"": """",""keyword"": ""EmpleadoTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EmpleadoTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___EmpleadoTieneAccesoWeb
          <DisplayName("Total porcentaje descuentos Generales")>
          Public Property TotalPorcentajeDescuentosGeneralesPorciento As Decimal
          Public Shared ___TotalPorcentajeDescuentosGeneralesPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TotalPorcentajeDescuentosGeneralesPorciento"",""etiqueta"": ""Total porcentaje descuentos Generales"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total porcentaje descuentos Generales"",""descripcion"": """",""keyword"": ""TotalPorcentajeDescuentosGeneralesPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __TotalPorcentajeDescuentosGeneralesPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___TotalPorcentajeDescuentosGeneralesPorciento
          <DisplayName("Fecha Dato")>
          Public Property FechaDato_UTC As Date?
          Public Shared ___FechaDato_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaDato_UTC"",""etiqueta"": ""Fecha Dato"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Dato"",""descripcion"": """",""keyword"": ""FechaDato_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaDato_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaDato_UTC
          <DisplayName("Total cobrado")>
          Public Property ImporteTotalCobrado As Decimal
          Public Shared ___ImporteTotalCobrado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteTotalCobrado"",""etiqueta"": ""Total cobrado"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total cobrado"",""descripcion"": """",""keyword"": ""ImporteTotalCobrado"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteTotalCobrado As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteTotalCobrado
          <Description("Número total de productos.")>
          <DisplayName("Cantidad de Productos")>
          Public Property CantidadDeProductos As Decimal
          Public Shared ___CantidadDeProductos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CantidadDeProductos"",""etiqueta"": ""Cantidad de Productos"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""11"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cantidad de Productos"",""descripcion"": """",""keyword"": ""CantidadDeProductos"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CantidadDeProductos As DinaNETCore.APID.DinaupAPI_CampoC = ___CantidadDeProductos
          <DisplayName("Estado")>
          Public Property ReferenciaEstado As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaEstado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaEstado"",""etiqueta"": ""Estado"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""2ec4f8ad-cec0-455e-a3ec-2557ec867762"",""titulo"": ""Estados de Compras/Gastos"",""iconoid"": ""1fbec552-994a-465e-a9ee-8502faa65d11"",""etiquetasingular"": ""Estado de Compras/Gasto"",""etiquetaplural"": ""Estados de Compras/Gastos"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""2ec4f8ad-cec0-455e-a3ec-2557ec867762"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Estado"",""descripcion"": """",""keyword"": ""ReferenciaEstado"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaEstado As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaEstado
          <Description("Importe total de todo los impuestos (Tanto generales como de productos) que se han aplicado.")>
          <DisplayName("Total Descontado (Sin impuestos)")>
          Public Property ImporteTotalDescontadoSinImpuestos As Decimal
          Public Shared ___ImporteTotalDescontadoSinImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteTotalDescontadoSinImpuestos"",""etiqueta"": ""Total Descontado (Sin impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total Descontado (Sin impuestos)"",""descripcion"": """",""keyword"": ""ImporteTotalDescontadoSinImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteTotalDescontadoSinImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteTotalDescontadoSinImpuestos
          <DisplayName("Base imponible Exenta")>
          Public Property ImporteBaseImponibleExenta As Decimal
          Public Shared ___ImporteBaseImponibleExenta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteBaseImponibleExenta"",""etiqueta"": ""Base imponible Exenta"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Base imponible Exenta"",""descripcion"": """",""keyword"": ""ImporteBaseImponibleExenta"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteBaseImponibleExenta As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteBaseImponibleExenta
          <DisplayName("Descuentos General Impuesto 3")>
          Public Property ImporteDescuentosGeneralImpuesto3 As Decimal
          Public Shared ___ImporteDescuentosGeneralImpuesto3 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentosGeneralImpuesto3"",""etiqueta"": ""Descuentos General Impuesto 3"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuentos General Impuesto 3"",""descripcion"": """",""keyword"": ""ImporteDescuentosGeneralImpuesto3"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentosGeneralImpuesto3 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentosGeneralImpuesto3
          <DisplayName("Puesto de trabajo")>
          Public Property ReferenciaPuestoDeTrabajo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaPuestoDeTrabajo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaPuestoDeTrabajo"",""etiqueta"": ""Puesto de trabajo"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""f777486d-e709-41be-9211-d9c6b4bb05d6"",""titulo"": ""Base - Puestos de trabajo"",""iconoid"": ""5d7008ed-1e2f-4dbe-a376-6261de330414"",""etiquetasingular"": ""Puesto de trabajo"",""etiquetaplural"": ""Puestos de trabajo"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""f777486d-e709-41be-9211-d9c6b4bb05d6"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Puesto de trabajo"",""descripcion"": """",""keyword"": ""ReferenciaPuestoDeTrabajo"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaPuestoDeTrabajo As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaPuestoDeTrabajo
          <DisplayName("Fecha Alta del registro")>
          Public Property FechaAlta_UTC As Date?
          Public Shared ___FechaAlta_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaAlta_UTC"",""etiqueta"": ""Fecha Alta del registro"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Alta del registro"",""descripcion"": """",""keyword"": ""FechaAlta_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaAlta_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaAlta_UTC
          <DisplayName("Fecha contable")>
          Public Property FechaContable As Date?
          Public Shared ___FechaContable As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaContable"",""etiqueta"": ""Fecha contable"",""oculta"": false,""formato"": 7,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 69,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha contable"",""descripcion"": """",""keyword"": ""FechaContable"",""formato"": 7,""rol"": 69,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaContable As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaContable
          <DisplayName("Asiento contable")>
          Public Property ReferenciaAsientoContable As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaAsientoContable As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaAsientoContable"",""etiqueta"": ""Asiento contable"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c4608471-b749-46fd-a0eb-d82dda66dcc8"",""titulo"": ""Base - Asientos contables"",""iconoid"": ""226684b8-fe3c-46a7-8f24-7462e48c0027"",""etiquetasingular"": ""Asiento contable"",""etiquetaplural"": ""Asientos contables"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""c4608471-b749-46fd-a0eb-d82dda66dcc8"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Asiento contable"",""descripcion"": """",""keyword"": ""ReferenciaAsientoContable"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaAsientoContable As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaAsientoContable
          <DisplayName("Denominación / Razón Social (Proveedor)")>
          Public Property DenominacionRazonSocialProveedor As String
          Public Shared ___DenominacionRazonSocialProveedor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DenominacionRazonSocialProveedor"",""etiqueta"": ""Denominación / Razón Social (Proveedor)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Denominación / Razón Social (Proveedor)"",""descripcion"": """",""keyword"": ""DenominacionRazonSocialProveedor"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DenominacionRazonSocialProveedor As DinaNETCore.APID.DinaupAPI_CampoC = ___DenominacionRazonSocialProveedor
          <DisplayName("Municipio (Empresa)")>
          Public Property MunicipioEmpresa As String
          Public Shared ___MunicipioEmpresa As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""MunicipioEmpresa"",""etiqueta"": ""Municipio (Empresa)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Municipio (Empresa)"",""descripcion"": """",""keyword"": ""MunicipioEmpresa"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __MunicipioEmpresa As DinaNETCore.APID.DinaupAPI_CampoC = ___MunicipioEmpresa
          <DisplayName("Dirección (Proveedor)")>
          Public Property DireccionProveedor As String
          Public Shared ___DireccionProveedor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DireccionProveedor"",""etiqueta"": ""Dirección (Proveedor)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 9,""decimales"": ""0"",""multilinea"": true,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Dirección (Proveedor)"",""descripcion"": """",""keyword"": ""DireccionProveedor"",""formato"": 5,""rol"": 9,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DireccionProveedor As DinaNETCore.APID.DinaupAPI_CampoC = ___DireccionProveedor
          <DisplayName("Datos fiscales (Proveedor)")>
          Public Property ReferenciaDatosFiscalesProveedor As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaDatosFiscalesProveedor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaDatosFiscalesProveedor"",""etiqueta"": ""Datos fiscales (Proveedor)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""03e347ac-c694-4d4a-a81f-e577ba014d1d"",""titulo"": ""Base - Datos fiscales"",""iconoid"": ""773d55f9-1e21-41f1-b0b0-f6a1dd370ea3"",""etiquetasingular"": ""Datos fiscales"",""etiquetaplural"": ""Datos fiscales"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""03e347ac-c694-4d4a-a81f-e577ba014d1d"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Datos fiscales (Proveedor)"",""descripcion"": """",""keyword"": ""ReferenciaDatosFiscalesProveedor"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaDatosFiscalesProveedor As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaDatosFiscalesProveedor
          <DisplayName("Código postal (Proveedor)")>
          Public Property CodigoPostalProveedor As String
          Public Shared ___CodigoPostalProveedor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CodigoPostalProveedor"",""etiqueta"": ""Código postal (Proveedor)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Código postal (Proveedor)"",""descripcion"": """",""keyword"": ""CodigoPostalProveedor"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CodigoPostalProveedor As DinaNETCore.APID.DinaupAPI_CampoC = ___CodigoPostalProveedor
          <DisplayName("Provincia (Proveedor)")>
          Public Property ProvinciaProveedor As String
          Public Shared ___ProvinciaProveedor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ProvinciaProveedor"",""etiqueta"": ""Provincia (Proveedor)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 84,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Provincia (Proveedor)"",""descripcion"": """",""keyword"": ""ProvinciaProveedor"",""formato"": 5,""rol"": 84,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ProvinciaProveedor As DinaNETCore.APID.DinaupAPI_CampoC = ___ProvinciaProveedor
          <DisplayName("País (Proveedor)")>
          Public Property PaisProveedor As String
          Public Shared ___PaisProveedor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""PaisProveedor"",""etiqueta"": ""País (Proveedor)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 83,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""País (Proveedor)"",""descripcion"": """",""keyword"": ""PaisProveedor"",""formato"": 5,""rol"": 83,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __PaisProveedor As DinaNETCore.APID.DinaupAPI_CampoC = ___PaisProveedor
          <DisplayName("Dirección (Empresa)")>
          Public Property DireccionEmpresa As String
          Public Shared ___DireccionEmpresa As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DireccionEmpresa"",""etiqueta"": ""Dirección (Empresa)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 9,""decimales"": ""0"",""multilinea"": true,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Dirección (Empresa)"",""descripcion"": """",""keyword"": ""DireccionEmpresa"",""formato"": 5,""rol"": 9,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DireccionEmpresa As DinaNETCore.APID.DinaupAPI_CampoC = ___DireccionEmpresa
          <DisplayName("Teléfono (Empresa)")>
          Public Property TelefonoEmpresa As String
          Public Shared ___TelefonoEmpresa As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TelefonoEmpresa"",""etiqueta"": ""Teléfono (Empresa)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 2,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Teléfono (Empresa)"",""descripcion"": """",""keyword"": ""TelefonoEmpresa"",""formato"": 5,""rol"": 2,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __TelefonoEmpresa As DinaNETCore.APID.DinaupAPI_CampoC = ___TelefonoEmpresa
          <DisplayName("Teléfono (Proveedor)")>
          Public Property TelefonoProveedor As String
          Public Shared ___TelefonoProveedor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TelefonoProveedor"",""etiqueta"": ""Teléfono (Proveedor)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 2,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Teléfono (Proveedor)"",""descripcion"": """",""keyword"": ""TelefonoProveedor"",""formato"": 5,""rol"": 2,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __TelefonoProveedor As DinaNETCore.APID.DinaupAPI_CampoC = ___TelefonoProveedor
          <DisplayName("Municipio (Proveedor)")>
          Public Property MunicipioProveedor As String
          Public Shared ___MunicipioProveedor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""MunicipioProveedor"",""etiqueta"": ""Municipio (Proveedor)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Municipio (Proveedor)"",""descripcion"": """",""keyword"": ""MunicipioProveedor"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __MunicipioProveedor As DinaNETCore.APID.DinaupAPI_CampoC = ___MunicipioProveedor
          <DisplayName("Denominación / Razón Social (Empresa)")>
          Public Property DenominacionRazonSocialEmpresa As String
          Public Shared ___DenominacionRazonSocialEmpresa As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DenominacionRazonSocialEmpresa"",""etiqueta"": ""Denominación / Razón Social (Empresa)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Denominación / Razón Social (Empresa)"",""descripcion"": """",""keyword"": ""DenominacionRazonSocialEmpresa"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DenominacionRazonSocialEmpresa As DinaNETCore.APID.DinaupAPI_CampoC = ___DenominacionRazonSocialEmpresa
          <DisplayName("Datos fiscales (Empresa)")>
          Public Property ReferenciaDatosFiscalesEmpresa As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaDatosFiscalesEmpresa As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaDatosFiscalesEmpresa"",""etiqueta"": ""Datos fiscales (Empresa)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""03e347ac-c694-4d4a-a81f-e577ba014d1d"",""titulo"": ""Base - Datos fiscales"",""iconoid"": ""773d55f9-1e21-41f1-b0b0-f6a1dd370ea3"",""etiquetasingular"": ""Datos fiscales"",""etiquetaplural"": ""Datos fiscales"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""03e347ac-c694-4d4a-a81f-e577ba014d1d"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Datos fiscales (Empresa)"",""descripcion"": """",""keyword"": ""ReferenciaDatosFiscalesEmpresa"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaDatosFiscalesEmpresa As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaDatosFiscalesEmpresa
          <DisplayName("Código postal (Empresa)")>
          Public Property CodigoPostalEmpresa As String
          Public Shared ___CodigoPostalEmpresa As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CodigoPostalEmpresa"",""etiqueta"": ""Código postal (Empresa)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Código postal (Empresa)"",""descripcion"": """",""keyword"": ""CodigoPostalEmpresa"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CodigoPostalEmpresa As DinaNETCore.APID.DinaupAPI_CampoC = ___CodigoPostalEmpresa
          <DisplayName("País (Empresa)")>
          Public Property PaisEmpresa As String
          Public Shared ___PaisEmpresa As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""PaisEmpresa"",""etiqueta"": ""País (Empresa)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""País (Empresa)"",""descripcion"": """",""keyword"": ""PaisEmpresa"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __PaisEmpresa As DinaNETCore.APID.DinaupAPI_CampoC = ___PaisEmpresa
          <DisplayName("CIF/NIF (Empresa)")>
          Public Property CIFNIFEmpresa As String
          Public Shared ___CIFNIFEmpresa As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CIFNIFEmpresa"",""etiqueta"": ""CIF/NIF (Empresa)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 79,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""CIF/NIF (Empresa)"",""descripcion"": """",""keyword"": ""CIFNIFEmpresa"",""formato"": 5,""rol"": 79,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CIFNIFEmpresa As DinaNETCore.APID.DinaupAPI_CampoC = ___CIFNIFEmpresa
          <DisplayName("Provincia (Empresa)")>
          Public Property ProvinciaEmpresa As String
          Public Shared ___ProvinciaEmpresa As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ProvinciaEmpresa"",""etiqueta"": ""Provincia (Empresa)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Provincia (Empresa)"",""descripcion"": """",""keyword"": ""ProvinciaEmpresa"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ProvinciaEmpresa As DinaNETCore.APID.DinaupAPI_CampoC = ___ProvinciaEmpresa
          <DisplayName("CIF/NIF (Proveedor)")>
          Public Property CIFNIFProveedor As String
          Public Shared ___CIFNIFProveedor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CIFNIFProveedor"",""etiqueta"": ""CIF/NIF (Proveedor)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 79,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""CIF/NIF (Proveedor)"",""descripcion"": """",""keyword"": ""CIFNIFProveedor"",""formato"": 5,""rol"": 79,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CIFNIFProveedor As DinaNETCore.APID.DinaupAPI_CampoC = ___CIFNIFProveedor
          <DisplayName("Número de factura")>
          Public Property NumeroDeFactura As String
          Public Shared ___NumeroDeFactura As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""NumeroDeFactura"",""etiqueta"": ""Número de factura"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Número de factura"",""descripcion"": """",""keyword"": ""NumeroDeFactura"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __NumeroDeFactura As DinaNETCore.APID.DinaupAPI_CampoC = ___NumeroDeFactura
          <DisplayName("Importe impuesto general")>
          Public Property ImporteImporteImpuestoGeneral As Decimal
          Public Shared ___ImporteImporteImpuestoGeneral As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteImporteImpuestoGeneral"",""etiqueta"": ""Importe impuesto general"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Importe impuesto general"",""descripcion"": """",""keyword"": ""ImporteImporteImpuestoGeneral"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteImporteImpuestoGeneral As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteImporteImpuestoGeneral
          <DisplayName("Impuesto general")>
          Public Property ReferenciaImpuestoGeneral As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaImpuestoGeneral As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaImpuestoGeneral"",""etiqueta"": ""Impuesto general"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""f3199ee0-dc83-4667-a9c1-f3b04e97a8a4"",""titulo"": ""Base - Impuestos"",""iconoid"": ""ff4a7189-6426-43b9-bdc4-070314999e81"",""etiquetasingular"": ""Impuesto"",""etiquetaplural"": ""Impuestos"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""f3199ee0-dc83-4667-a9c1-f3b04e97a8a4"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Impuesto general"",""descripcion"": """",""keyword"": ""ReferenciaImpuestoGeneral"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaImpuestoGeneral As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaImpuestoGeneral
          <DisplayName("Es gasto")>
          Public Property EsGasto As Boolean
          Public Shared ___EsGasto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EsGasto"",""etiqueta"": ""Es gasto"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Es gasto"",""descripcion"": """",""keyword"": ""EsGasto"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EsGasto As DinaNETCore.APID.DinaupAPI_CampoC = ___EsGasto
          <DisplayName("Marcar como concluida aunque hayan procesos pendientes")>
          Public Property MarcarComoConcluidaAunqueHayanProcesosPendientes As Boolean
          Public Shared ___MarcarComoConcluidaAunqueHayanProcesosPendientes As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""MarcarComoConcluidaAunqueHayanProcesosPendientes"",""etiqueta"": ""Marcar como concluida aunque hayan procesos pendientes"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Marcar como concluida aunque hayan procesos pendientes"",""descripcion"": """",""keyword"": ""MarcarComoConcluidaAunqueHayanProcesosPendientes"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __MarcarComoConcluidaAunqueHayanProcesosPendientes As DinaNETCore.APID.DinaupAPI_CampoC = ___MarcarComoConcluidaAunqueHayanProcesosPendientes
          <DisplayName("Condición de pago (Días)")>
          Public Property CondicionDePagoDias As Integer
          Public Shared ___CondicionDePagoDias As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CondicionDePagoDias"",""etiqueta"": ""Condición de pago (Días)"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Condición de pago (Días)"",""descripcion"": """",""keyword"": ""CondicionDePagoDias"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CondicionDePagoDias As DinaNETCore.APID.DinaupAPI_CampoC = ___CondicionDePagoDias
          <DisplayName("Fecha de vencimiento")>
          Public Property FechaDeVencimiento As Date?
          Public Shared ___FechaDeVencimiento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaDeVencimiento"",""etiqueta"": ""Fecha de vencimiento"",""oculta"": false,""formato"": 7,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha de vencimiento"",""descripcion"": """",""keyword"": ""FechaDeVencimiento"",""formato"": 7,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaDeVencimiento As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaDeVencimiento
          <DisplayName("Condiciones de pago")>
          Public Property CondicionesDePago As String
          Public Shared ___CondicionesDePago As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CondicionesDePago"",""etiqueta"": ""Condiciones de pago"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Condiciones de pago"",""descripcion"": """",""keyword"": ""CondicionesDePago"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CondicionesDePago As DinaNETCore.APID.DinaupAPI_CampoC = ___CondicionesDePago
          <DisplayName("Operación intragrupo")>
          Public Property OperacionIntragrupo As Boolean
          Public Shared ___OperacionIntragrupo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""OperacionIntragrupo"",""etiqueta"": ""Operación intragrupo"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Operación intragrupo"",""descripcion"": """",""keyword"": ""OperacionIntragrupo"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __OperacionIntragrupo As DinaNETCore.APID.DinaupAPI_CampoC = ___OperacionIntragrupo
          <DisplayName("Inversión del sujeto pasivo")>
          Public Property InversionDelSujetoPasivo As Boolean
          Public Shared ___InversionDelSujetoPasivo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""InversionDelSujetoPasivo"",""etiqueta"": ""Inversión del sujeto pasivo"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Inversión del sujeto pasivo"",""descripcion"": """",""keyword"": ""InversionDelSujetoPasivo"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __InversionDelSujetoPasivo As DinaNETCore.APID.DinaupAPI_CampoC = ___InversionDelSujetoPasivo
          <DisplayName("Régimen especial de bienes usados")>
          Public Property RegimenEspecialDeBienesUsados As Boolean
          Public Shared ___RegimenEspecialDeBienesUsados As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RegimenEspecialDeBienesUsados"",""etiqueta"": ""Régimen especial de bienes usados"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Régimen especial de bienes usados"",""descripcion"": """",""keyword"": ""RegimenEspecialDeBienesUsados"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RegimenEspecialDeBienesUsados As DinaNETCore.APID.DinaupAPI_CampoC = ___RegimenEspecialDeBienesUsados
          <DisplayName("Código País (Proveedor)")>
          Public Property CodigoPaisProveedor As String
          Public Shared ___CodigoPaisProveedor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CodigoPaisProveedor"",""etiqueta"": ""Código País (Proveedor)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 85,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Código País (Proveedor)"",""descripcion"": """",""keyword"": ""CodigoPaisProveedor"",""formato"": 5,""rol"": 85,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CodigoPaisProveedor As DinaNETCore.APID.DinaupAPI_CampoC = ___CodigoPaisProveedor
          <DisplayName("Código Provincia (Proveedor)")>
          Public Property CodigoProvinciaProveedor As String
          Public Shared ___CodigoProvinciaProveedor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CodigoProvinciaProveedor"",""etiqueta"": ""Código Provincia (Proveedor)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 86,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Código Provincia (Proveedor)"",""descripcion"": """",""keyword"": ""CodigoProvinciaProveedor"",""formato"": 5,""rol"": 86,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CodigoProvinciaProveedor As DinaNETCore.APID.DinaupAPI_CampoC = ___CodigoProvinciaProveedor
          <DisplayName("Tipo CIF/NIF (Proveedor)")>
          Public Property TipoCIFNIFProveedor As String
          Public Shared ___TipoCIFNIFProveedor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TipoCIFNIFProveedor"",""etiqueta"": ""Tipo CIF/NIF (Proveedor)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 87,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Tipo CIF/NIF (Proveedor)"",""descripcion"": """",""keyword"": ""TipoCIFNIFProveedor"",""formato"": 5,""rol"": 87,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __TipoCIFNIFProveedor As DinaNETCore.APID.DinaupAPI_CampoC = ___TipoCIFNIFProveedor
          <ReadOnlyAttribute(True)>
          <DisplayName("ID")>
          Public Property ID As Guid
          Public Shared ___ID As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": true,""eseliminado"": false,""keyword"": ""ID"",""etiqueta"": ""ID"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""2744b5aa-d936-425b-8b57-ee4f15b896c9"",""titulo"": ""Compras rectificativas"",""iconoid"": ""28ad3bf4-ea68-470a-90d5-949d6f88da18"",""etiquetasingular"": ""Compra rectificativa"",""etiquetaplural"": ""Compras rectificativas"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""2744b5aa-d936-425b-8b57-ee4f15b896c9"",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""ID"",""descripcion"": """",""keyword"": ""ID"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
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
          me.ImporteDescuentosGeneralImpuesto1 = _Datos.Leer_Decimal("pr_4004010567848")
          me.ReferenciaResumenImpuesto1 = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_4004010567923"), _Datos.Leer_String("pr_4004010567923.nombre"))
          me.ImporteTotalDeduccion = _Datos.Leer_Decimal("pr_4004010567852")
          me.Observaciones = _Datos.Leer_String("pr_4004010567936")
          me.NumeroDeReferenciaInterna = _Datos.Leer_Integer("pr_4004010567943")
          me.ReferenciaResumenImpuesto2 = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_4004010567926"), _Datos.Leer_String("pr_4004010567926.nombre"))
          me.ReferenciaEmpleadoPrincipal = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_3004010555266"), _Datos.Leer_String("pr_3004010555266.nombre"))
          me.ImporteCuotaImpuesto1 = _Datos.Leer_Decimal("pr_4004010567841")
          me.ImporteBaseImponibleImpuesto2 = _Datos.Leer_Decimal("pr_4004010567840")
          me.DescuentoEntidadAplicadoPorciento = _Datos.Leer_Decimal("pr_4004010567843")
          me.ReferenciaResumenImpuesto3 = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_4004010567920"), _Datos.Leer_String("pr_4004010567920.nombre"))
          me.ProveedorTieneAccesoWeb = _Datos.Leer_Boolean("pr_4004010567935")
          me.ImpuestosIncluidos = _Datos.Leer_Boolean("pr_4004010567947")
          me.ReferenciaConfiguracionDeCompra = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_4004010567922"), _Datos.Leer_String("pr_4004010567922.nombre"))
          me.ReferenciaCompraARectificar = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_20040105793"), _Datos.Leer_String("pr_20040105793.nombre"))
          me.ImporteDescuentoGeneralImpuestoExento = _Datos.Leer_Decimal("pr_4004010567847")
          me.CantidadDeProductosQueDebenSalir = _Datos.Leer_Decimal("pr_4004010567864")
          me.AplicarRecargoDeEquivalencia = _Datos.Leer_Boolean("pr_4004010567949")
          me.ReferenciaTipoDeMovimiento = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_4004010567928"), _Datos.Leer_String("pr_4004010567928.nombre"))
          me.ImporteCuotaREImpuesto1 = _Datos.Leer_Decimal("pr_4004010567863")
          me.ImporteImporteRetencion = _Datos.Leer_Decimal("pr_4004010567867")
          me.AutorDelAltaTieneAccesoWeb = _Datos.Leer_Boolean("pr_3004010555279")
          me.ImporteSumaConceptosSinImpuestos = _Datos.Leer_Decimal("pr_4004010567866")
          me.ImporteCuotaImpuesto3 = _Datos.Leer_Decimal("pr_4004010567868")
          me.ReferenciaNumeracionSerie = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_4004010567929"), _Datos.Leer_String("pr_4004010567929.nombre"))
          me.TotalSalidosDestinadores = _Datos.Leer_Decimal("pr_4004010567869")
          me.ImporteSumaDeConceptosImpuesto1 = _Datos.Leer_Decimal("pr_4004010567870")
          me.ImporteBaseImponibleImpuesto3 = _Datos.Leer_Decimal("pr_4004010567854")
          me.ReferenciaDestinador = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_3004010555275"), _Datos.Leer_String("pr_3004010555275.nombre"))
          me.HoraLocal = _Datos.Leer_Time_Nulable("pr_3004010555270")
          me.ImporteTotal = _Datos.Leer_Decimal("pr_4004010567857")
          me.ImporteDescuentosProductoImpuesto3 = _Datos.Leer_Decimal("pr_4004010567858")
          me.ReferenciaUbicacionPrincipal = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_3004010555267"), _Datos.Leer_String("pr_3004010555267.nombre"))
          me.ImporteSumaDeConceptosImpuesto3 = _Datos.Leer_Decimal("pr_4004010567859")
          me.DescuentoGeneralAplicadoPorciento = _Datos.Leer_Decimal("pr_4004010567860")
          me.DescuentoAdicionalAAplicadoPorciento = _Datos.Leer_Decimal("pr_4004010567884")
          me.DescripcionDescuentoAdicionalA = _Datos.Leer_String("pr_4004010567938")
          me.ImporteTotalACobrar = _Datos.Leer_Decimal("pr_4004010567890")
          me.ImporteCuotaREImpuesto2 = _Datos.Leer_Decimal("pr_4004010567889")
          me.ImporteSubtotal = _Datos.Leer_Decimal("pr_4004010567886")
          me.ImporteTotalImpuestos = _Datos.Leer_Decimal("pr_4004010567888")
          me.ImporteCuotaImpuesto2 = _Datos.Leer_Decimal("pr_4004010567891")
          me.ImporteCuotaREImpuesto3 = _Datos.Leer_Decimal("pr_4004010567872")
          me.ImporteSumaDeConceptosImpuestoExentos = _Datos.Leer_Decimal("pr_4004010567879")
          me.ImporteSumaDeConceptosImpuesto2 = _Datos.Leer_Decimal("pr_4004010567878")
          me.ImporteSumaImporteProductosConImpuestos = _Datos.Leer_Decimal("pr_4004010567882")
          me.NumeroDeReferenciaInternaCompleto = _Datos.Leer_String("pr_4004010567937")
          me.ReferenciaAutorDelAlta = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_3004010555268"), _Datos.Leer_String("pr_3004010555268.nombre"))
          me.ReferenciaProveedor = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_4004010567934"), _Datos.Leer_String("pr_4004010567934.nombre"))
          me.DescripcionDescuentoAdicionalB = _Datos.Leer_String("pr_4004010567939")
          me.ImporteSumaImporteDeProductosSinImpuestos = _Datos.Leer_Decimal("pr_4004010567910")
          me.ImporteDescuentosProductoImpuesto1 = _Datos.Leer_Decimal("pr_4004010567915")
          me.DescuentoAdicionalBAplicadoPorciento = _Datos.Leer_Decimal("pr_4004010567913")
          me.ImporteDescuentosGeneralImpuesto2 = _Datos.Leer_Decimal("pr_4004010567916")
          me.ImporteDescuentosProductoExento = _Datos.Leer_Decimal("pr_4004010567895")
          me.ImporteBaseImponibleImpuesto1 = _Datos.Leer_Decimal("pr_4004010567900")
          me.ReferenciaRetencion = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_4004010567931"), _Datos.Leer_String("pr_4004010567931.nombre"))
          me.ImporteDescuentosProductoImpuesto2 = _Datos.Leer_Decimal("pr_4004010567896")
          me.SumaConceptosConImpuestos = _Datos.Leer_Decimal("pr_60040115042")
          me.EmpleadoTieneAccesoWeb = _Datos.Leer_Boolean("pr_3004010555277")
          me.TotalPorcentajeDescuentosGeneralesPorciento = _Datos.Leer_Decimal("pr_4004010567901")
          me.FechaDato_UTC = _Datos.Leer_DateTime_Nulable("pr_3004010555269")
          me.ImporteTotalCobrado = _Datos.Leer_Decimal("pr_4004010567907")
          me.CantidadDeProductos = _Datos.Leer_Decimal("pr_4004010567908")
          me.ReferenciaEstado = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_4004010567933"), _Datos.Leer_String("pr_4004010567933.nombre"))
          me.ImporteTotalDescontadoSinImpuestos = _Datos.Leer_Decimal("pr_4004010567904")
          me.ImporteBaseImponibleExenta = _Datos.Leer_Decimal("pr_4004010567905")
          me.ImporteDescuentosGeneralImpuesto3 = _Datos.Leer_Decimal("pr_4004010567906")
          me.ReferenciaPuestoDeTrabajo = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_4004010567932"), _Datos.Leer_String("pr_4004010567932.nombre"))
          me.FechaAlta_UTC = _Datos.Leer_DateTime_Nulable("pr_3004010555272")
          me.FechaContable = _Datos.Leer_Date_Nulable("pr_30040135704")
          me.ReferenciaAsientoContable = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_40040135292"), _Datos.Leer_String("pr_40040135292.nombre"))
          me.DenominacionRazonSocialProveedor = _Datos.Leer_String("pr_20040138823")
          me.MunicipioEmpresa = _Datos.Leer_String("pr_300401388210")
          me.DireccionProveedor = _Datos.Leer_String("pr_20040138828")
          me.ReferenciaDatosFiscalesProveedor = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_20040138821"), _Datos.Leer_String("pr_20040138821.nombre"))
          me.CodigoPostalProveedor = _Datos.Leer_String("pr_20040138822")
          me.ProvinciaProveedor = _Datos.Leer_String("pr_20040138824")
          me.PaisProveedor = _Datos.Leer_String("pr_20040138825")
          me.DireccionEmpresa = _Datos.Leer_String("pr_30040138823")
          me.TelefonoEmpresa = _Datos.Leer_String("pr_30040138822")
          me.TelefonoProveedor = _Datos.Leer_String("pr_20040138826")
          me.MunicipioProveedor = _Datos.Leer_String("pr_20040138829")
          me.DenominacionRazonSocialEmpresa = _Datos.Leer_String("pr_30040138824")
          me.ReferenciaDatosFiscalesEmpresa = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_30040138827"), _Datos.Leer_String("pr_30040138827.nombre"))
          me.CodigoPostalEmpresa = _Datos.Leer_String("pr_30040138826")
          me.PaisEmpresa = _Datos.Leer_String("pr_30040138828")
          me.CIFNIFEmpresa = _Datos.Leer_String("pr_30040138825")
          me.ProvinciaEmpresa = _Datos.Leer_String("pr_30040138829")
          me.CIFNIFProveedor = _Datos.Leer_String("pr_20040138827")
          me.NumeroDeFactura = _Datos.Leer_String("pr_10040145301")
          me.ImporteImporteImpuestoGeneral = _Datos.Leer_Decimal("pr_30040148965")
          me.ReferenciaImpuestoGeneral = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_30040148964"), _Datos.Leer_String("pr_30040148964.nombre"))
          me.EsGasto = _Datos.Leer_Boolean("pr_30040163141")
          me.MarcarComoConcluidaAunqueHayanProcesosPendientes = _Datos.Leer_Boolean("pr_60040173901")
          me.CondicionDePagoDias = _Datos.Leer_Integer("pr_60040176522")
          me.FechaDeVencimiento = _Datos.Leer_Date_Nulable("pr_60040176521")
          me.CondicionesDePago = _Datos.Leer_String("pr_60040176523")
          me.OperacionIntragrupo = _Datos.Leer_Boolean("pr_40040238923")
          me.InversionDelSujetoPasivo = _Datos.Leer_Boolean("pr_10040238942")
          me.RegimenEspecialDeBienesUsados = _Datos.Leer_Boolean("pr_50040238943")
          me.CodigoPaisProveedor = _Datos.Leer_String("pr_20040241543")
          me.CodigoProvinciaProveedor = _Datos.Leer_String("pr_20040241544")
          me.TipoCIFNIFProveedor = _Datos.Leer_String("pr_20040241601")
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
         R.add("pr_4004010567848", me.ImporteDescuentosGeneralImpuesto1.AdaptarMySQL_Decimal())
         If Me.ReferenciaResumenImpuesto1 IsNot nothing then
           R.add("pr_4004010567923",me.ReferenciaResumenImpuesto1.ID.STR())
         Else
           R.add("pr_4004010567923","")
         End if
         R.add("pr_4004010567852", me.ImporteTotalDeduccion.AdaptarMySQL_Decimal())
         R.add("pr_4004010567936", me.Observaciones.AdaptarMySQL_String())
         R.add("pr_4004010567943", me.NumeroDeReferenciaInterna.AdaptarMySQL_Integer())
         If Me.ReferenciaResumenImpuesto2 IsNot nothing then
           R.add("pr_4004010567926",me.ReferenciaResumenImpuesto2.ID.STR())
         Else
           R.add("pr_4004010567926","")
         End if
         If Me.ReferenciaEmpleadoPrincipal IsNot nothing then
           R.add("pr_3004010555266",me.ReferenciaEmpleadoPrincipal.ID.STR())
         Else
           R.add("pr_3004010555266","")
         End if
         R.add("pr_4004010567841", me.ImporteCuotaImpuesto1.AdaptarMySQL_Decimal())
         R.add("pr_4004010567840", me.ImporteBaseImponibleImpuesto2.AdaptarMySQL_Decimal())
         R.add("pr_4004010567843", me.DescuentoEntidadAplicadoPorciento.AdaptarMySQL_Decimal())
         If Me.ReferenciaResumenImpuesto3 IsNot nothing then
           R.add("pr_4004010567920",me.ReferenciaResumenImpuesto3.ID.STR())
         Else
           R.add("pr_4004010567920","")
         End if
         R.add("pr_4004010567935", me.ProveedorTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_4004010567947", me.ImpuestosIncluidos.AdaptarMySQL_Boolean())
         If Me.ReferenciaConfiguracionDeCompra IsNot nothing then
           R.add("pr_4004010567922",me.ReferenciaConfiguracionDeCompra.ID.STR())
         Else
           R.add("pr_4004010567922","")
         End if
         If Me.ReferenciaCompraARectificar IsNot nothing then
           R.add("pr_20040105793",me.ReferenciaCompraARectificar.ID.STR())
         Else
           R.add("pr_20040105793","")
         End if
         R.add("pr_4004010567847", me.ImporteDescuentoGeneralImpuestoExento.AdaptarMySQL_Decimal())
         R.add("pr_4004010567864", me.CantidadDeProductosQueDebenSalir.AdaptarMySQL_Decimal())
         R.add("pr_4004010567949", me.AplicarRecargoDeEquivalencia.AdaptarMySQL_Boolean())
         If Me.ReferenciaTipoDeMovimiento IsNot nothing then
           R.add("pr_4004010567928",me.ReferenciaTipoDeMovimiento.ID.STR())
         Else
           R.add("pr_4004010567928","")
         End if
         R.add("pr_4004010567863", me.ImporteCuotaREImpuesto1.AdaptarMySQL_Decimal())
         R.add("pr_4004010567867", me.ImporteImporteRetencion.AdaptarMySQL_Decimal())
         R.add("pr_3004010555279", me.AutorDelAltaTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_4004010567866", me.ImporteSumaConceptosSinImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_4004010567868", me.ImporteCuotaImpuesto3.AdaptarMySQL_Decimal())
         If Me.ReferenciaNumeracionSerie IsNot nothing then
           R.add("pr_4004010567929",me.ReferenciaNumeracionSerie.ID.STR())
         Else
           R.add("pr_4004010567929","")
         End if
         R.add("pr_4004010567869", me.TotalSalidosDestinadores.AdaptarMySQL_Decimal())
         R.add("pr_4004010567870", me.ImporteSumaDeConceptosImpuesto1.AdaptarMySQL_Decimal())
         R.add("pr_4004010567854", me.ImporteBaseImponibleImpuesto3.AdaptarMySQL_Decimal())
         If Me.ReferenciaDestinador IsNot nothing then
           R.add("pr_3004010555275",me.ReferenciaDestinador.ID.STR())
         Else
           R.add("pr_3004010555275","")
         End if
         R.add("pr_3004010555270", me.HoraLocal.AdaptarMySQL_Time_Nulable())
         R.add("pr_4004010567857", me.ImporteTotal.AdaptarMySQL_Decimal())
         R.add("pr_4004010567858", me.ImporteDescuentosProductoImpuesto3.AdaptarMySQL_Decimal())
         If Me.ReferenciaUbicacionPrincipal IsNot nothing then
           R.add("pr_3004010555267",me.ReferenciaUbicacionPrincipal.ID.STR())
         Else
           R.add("pr_3004010555267","")
         End if
         R.add("pr_4004010567859", me.ImporteSumaDeConceptosImpuesto3.AdaptarMySQL_Decimal())
         R.add("pr_4004010567860", me.DescuentoGeneralAplicadoPorciento.AdaptarMySQL_Decimal())
         R.add("pr_4004010567884", me.DescuentoAdicionalAAplicadoPorciento.AdaptarMySQL_Decimal())
         R.add("pr_4004010567938", me.DescripcionDescuentoAdicionalA.AdaptarMySQL_String())
         R.add("pr_4004010567890", me.ImporteTotalACobrar.AdaptarMySQL_Decimal())
         R.add("pr_4004010567889", me.ImporteCuotaREImpuesto2.AdaptarMySQL_Decimal())
         R.add("pr_4004010567886", me.ImporteSubtotal.AdaptarMySQL_Decimal())
         R.add("pr_4004010567888", me.ImporteTotalImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_4004010567891", me.ImporteCuotaImpuesto2.AdaptarMySQL_Decimal())
         R.add("pr_4004010567872", me.ImporteCuotaREImpuesto3.AdaptarMySQL_Decimal())
         R.add("pr_4004010567879", me.ImporteSumaDeConceptosImpuestoExentos.AdaptarMySQL_Decimal())
         R.add("pr_4004010567878", me.ImporteSumaDeConceptosImpuesto2.AdaptarMySQL_Decimal())
         R.add("pr_4004010567882", me.ImporteSumaImporteProductosConImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_4004010567937", me.NumeroDeReferenciaInternaCompleto.AdaptarMySQL_String())
         If Me.ReferenciaAutorDelAlta IsNot nothing then
           R.add("pr_3004010555268",me.ReferenciaAutorDelAlta.ID.STR())
         Else
           R.add("pr_3004010555268","")
         End if
         If Me.ReferenciaProveedor IsNot nothing then
           R.add("pr_4004010567934",me.ReferenciaProveedor.ID.STR())
         Else
           R.add("pr_4004010567934","")
         End if
         R.add("pr_4004010567939", me.DescripcionDescuentoAdicionalB.AdaptarMySQL_String())
         R.add("pr_4004010567910", me.ImporteSumaImporteDeProductosSinImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_4004010567915", me.ImporteDescuentosProductoImpuesto1.AdaptarMySQL_Decimal())
         R.add("pr_4004010567913", me.DescuentoAdicionalBAplicadoPorciento.AdaptarMySQL_Decimal())
         R.add("pr_4004010567916", me.ImporteDescuentosGeneralImpuesto2.AdaptarMySQL_Decimal())
         R.add("pr_4004010567895", me.ImporteDescuentosProductoExento.AdaptarMySQL_Decimal())
         R.add("pr_4004010567900", me.ImporteBaseImponibleImpuesto1.AdaptarMySQL_Decimal())
         If Me.ReferenciaRetencion IsNot nothing then
           R.add("pr_4004010567931",me.ReferenciaRetencion.ID.STR())
         Else
           R.add("pr_4004010567931","")
         End if
         R.add("pr_4004010567896", me.ImporteDescuentosProductoImpuesto2.AdaptarMySQL_Decimal())
         R.add("pr_60040115042", me.SumaConceptosConImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_3004010555277", me.EmpleadoTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_4004010567901", me.TotalPorcentajeDescuentosGeneralesPorciento.AdaptarMySQL_Decimal())
         R.add("pr_3004010555269", me.FechaDato_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_4004010567907", me.ImporteTotalCobrado.AdaptarMySQL_Decimal())
         R.add("pr_4004010567908", me.CantidadDeProductos.AdaptarMySQL_Decimal())
         If Me.ReferenciaEstado IsNot nothing then
           R.add("pr_4004010567933",me.ReferenciaEstado.ID.STR())
         Else
           R.add("pr_4004010567933","")
         End if
         R.add("pr_4004010567904", me.ImporteTotalDescontadoSinImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_4004010567905", me.ImporteBaseImponibleExenta.AdaptarMySQL_Decimal())
         R.add("pr_4004010567906", me.ImporteDescuentosGeneralImpuesto3.AdaptarMySQL_Decimal())
         If Me.ReferenciaPuestoDeTrabajo IsNot nothing then
           R.add("pr_4004010567932",me.ReferenciaPuestoDeTrabajo.ID.STR())
         Else
           R.add("pr_4004010567932","")
         End if
         R.add("pr_3004010555272", me.FechaAlta_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_30040135704", me.FechaContable.AdaptarMySQL_Date_Nulable())
         If Me.ReferenciaAsientoContable IsNot nothing then
           R.add("pr_40040135292",me.ReferenciaAsientoContable.ID.STR())
         Else
           R.add("pr_40040135292","")
         End if
         R.add("pr_20040138823", me.DenominacionRazonSocialProveedor.AdaptarMySQL_String())
         R.add("pr_300401388210", me.MunicipioEmpresa.AdaptarMySQL_String())
         R.add("pr_20040138828", me.DireccionProveedor.AdaptarMySQL_String())
         If Me.ReferenciaDatosFiscalesProveedor IsNot nothing then
           R.add("pr_20040138821",me.ReferenciaDatosFiscalesProveedor.ID.STR())
         Else
           R.add("pr_20040138821","")
         End if
         R.add("pr_20040138822", me.CodigoPostalProveedor.AdaptarMySQL_String())
         R.add("pr_20040138824", me.ProvinciaProveedor.AdaptarMySQL_String())
         R.add("pr_20040138825", me.PaisProveedor.AdaptarMySQL_String())
         R.add("pr_30040138823", me.DireccionEmpresa.AdaptarMySQL_String())
         R.add("pr_30040138822", me.TelefonoEmpresa.AdaptarMySQL_String())
         R.add("pr_20040138826", me.TelefonoProveedor.AdaptarMySQL_String())
         R.add("pr_20040138829", me.MunicipioProveedor.AdaptarMySQL_String())
         R.add("pr_30040138824", me.DenominacionRazonSocialEmpresa.AdaptarMySQL_String())
         If Me.ReferenciaDatosFiscalesEmpresa IsNot nothing then
           R.add("pr_30040138827",me.ReferenciaDatosFiscalesEmpresa.ID.STR())
         Else
           R.add("pr_30040138827","")
         End if
         R.add("pr_30040138826", me.CodigoPostalEmpresa.AdaptarMySQL_String())
         R.add("pr_30040138828", me.PaisEmpresa.AdaptarMySQL_String())
         R.add("pr_30040138825", me.CIFNIFEmpresa.AdaptarMySQL_String())
         R.add("pr_30040138829", me.ProvinciaEmpresa.AdaptarMySQL_String())
         R.add("pr_20040138827", me.CIFNIFProveedor.AdaptarMySQL_String())
         R.add("pr_10040145301", me.NumeroDeFactura.AdaptarMySQL_String())
         R.add("pr_30040148965", me.ImporteImporteImpuestoGeneral.AdaptarMySQL_Decimal())
         If Me.ReferenciaImpuestoGeneral IsNot nothing then
           R.add("pr_30040148964",me.ReferenciaImpuestoGeneral.ID.STR())
         Else
           R.add("pr_30040148964","")
         End if
         R.add("pr_30040163141", me.EsGasto.AdaptarMySQL_Boolean())
         R.add("pr_60040173901", me.MarcarComoConcluidaAunqueHayanProcesosPendientes.AdaptarMySQL_Boolean())
         R.add("pr_60040176522", me.CondicionDePagoDias.AdaptarMySQL_Integer())
         R.add("pr_60040176521", me.FechaDeVencimiento.AdaptarMySQL_Date_Nulable())
         R.add("pr_60040176523", me.CondicionesDePago.AdaptarMySQL_String())
         R.add("pr_40040238923", me.OperacionIntragrupo.AdaptarMySQL_Boolean())
         R.add("pr_10040238942", me.InversionDelSujetoPasivo.AdaptarMySQL_Boolean())
         R.add("pr_50040238943", me.RegimenEspecialDeBienesUsados.AdaptarMySQL_Boolean())
         R.add("pr_20040241543", me.CodigoPaisProveedor.AdaptarMySQL_String())
         R.add("pr_20040241544", me.CodigoProvinciaProveedor.AdaptarMySQL_String())
         R.add("pr_20040241601", me.TipoCIFNIFProveedor.AdaptarMySQL_String())
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
      Public Class ComprasRectificativas_FormularioC
        Inherits DinaNETCore.VentanaVirtualC

    Public _Lista As List(Of ComprasRectificativasListaD.ComprasRectificativasLista_FormularioC)



    Overrides Sub Evento_Actualizar()

        If Me.EsListador Then
            Dim FormLista = Me.__VV__.Formularios_Lista
            Dim CreandoLista As New List(Of ComprasRectificativasListaD.ComprasRectificativasLista_FormularioC)
            If FormLista IsNot Nothing Then
                For i = 0 To FormLista.Count - 1
                    Dim ElementoLista As New ComprasRectificativasListaD.ComprasRectificativasLista_FormularioC(Me.__VV__, FormLista(i).Token)
                    CreandoLista.Add(ElementoLista)
                Next
            End If
            _Lista = CreandoLista
        End If

    End Sub

                  


        Public ReadOnly property ImporteDescuentosGeneralImpuesto1 As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567848")
            End Get   
        End Property
        Public ReadOnly property ReferenciaResumenImpuesto1 As Guid
            get
                return me.GetValue_Guid("pr_4004010567923")
            End Get   
        End Property
        Public ReadOnly property ImporteTotalDeduccion As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567852")
            End Get   
        End Property
          Public property Observaciones As String
            get
                return me.GetValue_String("pr_4004010567936")
            End Get
            Set(value As String)
                me.SetValue_String("pr_4004010567936", value)
            End Set
          End Property
          Public property NumeroDeReferenciaInterna As Integer
            get
                return me.GetValue_Int("pr_4004010567943")
            End Get
            Set(value As Integer)
                me.SetValue_Int("pr_4004010567943", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaResumenImpuesto2 As Guid
            get
                return me.GetValue_Guid("pr_4004010567926")
            End Get   
        End Property
          Public property ReferenciaEmpleadoPrincipal As Guid
            get
                return me.GetValue_Guid("pr_3004010555266")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_3004010555266", value)
            End Set
          End Property
        Public ReadOnly property ImporteCuotaImpuesto1 As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567841")
            End Get   
        End Property
        Public ReadOnly property ImporteBaseImponibleImpuesto2 As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567840")
            End Get   
        End Property
          Public property DescuentoEntidadAplicadoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567843")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_4004010567843", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaResumenImpuesto3 As Guid
            get
                return me.GetValue_Guid("pr_4004010567920")
            End Get   
        End Property
          Public property ProveedorTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_4004010567935")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_4004010567935", value)
            End Set
          End Property
          Public property ImpuestosIncluidos As Boolean
            get
                return me.GetValue_Boolean("pr_4004010567947")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_4004010567947", value)
            End Set
          End Property
          Public property ReferenciaConfiguracionDeCompra As Guid
            get
                return me.GetValue_Guid("pr_4004010567922")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_4004010567922", value)
            End Set
          End Property
          Public property ReferenciaCompraARectificar As Guid
            get
                return me.GetValue_Guid("pr_20040105793")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_20040105793", value)
            End Set
          End Property
        Public ReadOnly property ImporteDescuentoGeneralImpuestoExento As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567847")
            End Get   
        End Property
        Public ReadOnly property CantidadDeProductosQueDebenSalir As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567864")
            End Get   
        End Property
          Public property AplicarRecargoDeEquivalencia As Boolean
            get
                return me.GetValue_Boolean("pr_4004010567949")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_4004010567949", value)
            End Set
          End Property
          Public property ReferenciaTipoDeMovimiento As Guid
            get
                return me.GetValue_Guid("pr_4004010567928")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_4004010567928", value)
            End Set
          End Property
        Public ReadOnly property ImporteCuotaREImpuesto1 As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567863")
            End Get   
        End Property
        Public ReadOnly property ImporteImporteRetencion As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567867")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_3004010555279")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_3004010555279", value)
            End Set
          End Property
        Public ReadOnly property ImporteSumaConceptosSinImpuestos As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567866")
            End Get   
        End Property
        Public ReadOnly property ImporteCuotaImpuesto3 As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567868")
            End Get   
        End Property
          Public property ReferenciaNumeracionSerie As Guid
            get
                return me.GetValue_Guid("pr_4004010567929")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_4004010567929", value)
            End Set
          End Property
        Public ReadOnly property TotalSalidosDestinadores As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567869")
            End Get   
        End Property
        Public ReadOnly property ImporteSumaDeConceptosImpuesto1 As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567870")
            End Get   
        End Property
        Public ReadOnly property ImporteBaseImponibleImpuesto3 As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567854")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_3004010555275")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As DateTime
            get
                return me.GetValue_DateTime("pr_3004010555270")
            End Get   
        End Property
        Public ReadOnly property ImporteTotal As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567857")
            End Get   
        End Property
        Public ReadOnly property ImporteDescuentosProductoImpuesto3 As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567858")
            End Get   
        End Property
          Public property ReferenciaUbicacionPrincipal As Guid
            get
                return me.GetValue_Guid("pr_3004010555267")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_3004010555267", value)
            End Set
          End Property
        Public ReadOnly property ImporteSumaDeConceptosImpuesto3 As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567859")
            End Get   
        End Property
          Public property DescuentoGeneralAplicadoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567860")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_4004010567860", value)
            End Set
          End Property
          Public property DescuentoAdicionalAAplicadoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567884")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_4004010567884", value)
            End Set
          End Property
          Public property DescripcionDescuentoAdicionalA As String
            get
                return me.GetValue_String("pr_4004010567938")
            End Get
            Set(value As String)
                me.SetValue_String("pr_4004010567938", value)
            End Set
          End Property
        Public ReadOnly property ImporteTotalACobrar As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567890")
            End Get   
        End Property
        Public ReadOnly property ImporteCuotaREImpuesto2 As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567889")
            End Get   
        End Property
        Public ReadOnly property ImporteSubtotal As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567886")
            End Get   
        End Property
        Public ReadOnly property ImporteTotalImpuestos As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567888")
            End Get   
        End Property
        Public ReadOnly property ImporteCuotaImpuesto2 As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567891")
            End Get   
        End Property
        Public ReadOnly property ImporteCuotaREImpuesto3 As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567872")
            End Get   
        End Property
        Public ReadOnly property ImporteSumaDeConceptosImpuestoExentos As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567879")
            End Get   
        End Property
        Public ReadOnly property ImporteSumaDeConceptosImpuesto2 As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567878")
            End Get   
        End Property
        Public ReadOnly property ImporteSumaImporteProductosConImpuestos As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567882")
            End Get   
        End Property
        Public ReadOnly property NumeroDeReferenciaInternaCompleto As String
            get
                return me.GetValue_String("pr_4004010567937")
            End Get   
        End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_3004010555268")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_3004010555268", value)
            End Set
          End Property
          Public property ReferenciaProveedor As Guid
            get
                return me.GetValue_Guid("pr_4004010567934")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_4004010567934", value)
            End Set
          End Property
          Public property DescripcionDescuentoAdicionalB As String
            get
                return me.GetValue_String("pr_4004010567939")
            End Get
            Set(value As String)
                me.SetValue_String("pr_4004010567939", value)
            End Set
          End Property
        Public ReadOnly property ImporteSumaImporteDeProductosSinImpuestos As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567910")
            End Get   
        End Property
        Public ReadOnly property ImporteDescuentosProductoImpuesto1 As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567915")
            End Get   
        End Property
          Public property DescuentoAdicionalBAplicadoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567913")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_4004010567913", value)
            End Set
          End Property
        Public ReadOnly property ImporteDescuentosGeneralImpuesto2 As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567916")
            End Get   
        End Property
        Public ReadOnly property ImporteDescuentosProductoExento As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567895")
            End Get   
        End Property
        Public ReadOnly property ImporteBaseImponibleImpuesto1 As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567900")
            End Get   
        End Property
          Public property ReferenciaRetencion As Guid
            get
                return me.GetValue_Guid("pr_4004010567931")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_4004010567931", value)
            End Set
          End Property
        Public ReadOnly property ImporteDescuentosProductoImpuesto2 As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567896")
            End Get   
        End Property
        Public ReadOnly property SumaConceptosConImpuestos As Decimal
            get
                return me.GetValue_Decimal("pr_60040115042")
            End Get   
        End Property
          Public property EmpleadoTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_3004010555277")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_3004010555277", value)
            End Set
          End Property
        Public ReadOnly property TotalPorcentajeDescuentosGeneralesPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567901")
            End Get   
        End Property
          Public property FechaDato_UTC As Date
            get
                return me.GetValue_DateTime("pr_3004010555269")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_3004010555269", value)
            End Set
          End Property
        Public ReadOnly property ImporteTotalCobrado As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567907")
            End Get   
        End Property
        Public ReadOnly property CantidadDeProductos As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567908")
            End Get   
        End Property
          Public property ReferenciaEstado As Guid
            get
                return me.GetValue_Guid("pr_4004010567933")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_4004010567933", value)
            End Set
          End Property
        Public ReadOnly property ImporteTotalDescontadoSinImpuestos As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567904")
            End Get   
        End Property
        Public ReadOnly property ImporteBaseImponibleExenta As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567905")
            End Get   
        End Property
        Public ReadOnly property ImporteDescuentosGeneralImpuesto3 As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567906")
            End Get   
        End Property
          Public property ReferenciaPuestoDeTrabajo As Guid
            get
                return me.GetValue_Guid("pr_4004010567932")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_4004010567932", value)
            End Set
          End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_3004010555272")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_3004010555272", value)
            End Set
          End Property
          Public property FechaContable As Date
            get
                return me.GetValue_Date("pr_30040135704")
            End Get
            Set(value As Date)
                me.SetValue_Date("pr_30040135704", value)
            End Set
          End Property
          Public property ReferenciaAsientoContable As Guid
            get
                return me.GetValue_Guid("pr_40040135292")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_40040135292", value)
            End Set
          End Property
          Public property DenominacionRazonSocialProveedor As String
            get
                return me.GetValue_String("pr_20040138823")
            End Get
            Set(value As String)
                me.SetValue_String("pr_20040138823", value)
            End Set
          End Property
          Public property MunicipioEmpresa As String
            get
                return me.GetValue_String("pr_300401388210")
            End Get
            Set(value As String)
                me.SetValue_String("pr_300401388210", value)
            End Set
          End Property
          Public property DireccionProveedor As String
            get
                return me.GetValue_String("pr_20040138828")
            End Get
            Set(value As String)
                me.SetValue_String("pr_20040138828", value)
            End Set
          End Property
          Public property ReferenciaDatosFiscalesProveedor As Guid
            get
                return me.GetValue_Guid("pr_20040138821")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_20040138821", value)
            End Set
          End Property
          Public property CodigoPostalProveedor As String
            get
                return me.GetValue_String("pr_20040138822")
            End Get
            Set(value As String)
                me.SetValue_String("pr_20040138822", value)
            End Set
          End Property
          Public property ProvinciaProveedor As String
            get
                return me.GetValue_String("pr_20040138824")
            End Get
            Set(value As String)
                me.SetValue_String("pr_20040138824", value)
            End Set
          End Property
          Public property PaisProveedor As String
            get
                return me.GetValue_String("pr_20040138825")
            End Get
            Set(value As String)
                me.SetValue_String("pr_20040138825", value)
            End Set
          End Property
          Public property DireccionEmpresa As String
            get
                return me.GetValue_String("pr_30040138823")
            End Get
            Set(value As String)
                me.SetValue_String("pr_30040138823", value)
            End Set
          End Property
          Public property TelefonoEmpresa As String
            get
                return me.GetValue_String("pr_30040138822")
            End Get
            Set(value As String)
                me.SetValue_String("pr_30040138822", value)
            End Set
          End Property
          Public property TelefonoProveedor As String
            get
                return me.GetValue_String("pr_20040138826")
            End Get
            Set(value As String)
                me.SetValue_String("pr_20040138826", value)
            End Set
          End Property
          Public property MunicipioProveedor As String
            get
                return me.GetValue_String("pr_20040138829")
            End Get
            Set(value As String)
                me.SetValue_String("pr_20040138829", value)
            End Set
          End Property
          Public property DenominacionRazonSocialEmpresa As String
            get
                return me.GetValue_String("pr_30040138824")
            End Get
            Set(value As String)
                me.SetValue_String("pr_30040138824", value)
            End Set
          End Property
          Public property ReferenciaDatosFiscalesEmpresa As Guid
            get
                return me.GetValue_Guid("pr_30040138827")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_30040138827", value)
            End Set
          End Property
          Public property CodigoPostalEmpresa As String
            get
                return me.GetValue_String("pr_30040138826")
            End Get
            Set(value As String)
                me.SetValue_String("pr_30040138826", value)
            End Set
          End Property
          Public property PaisEmpresa As String
            get
                return me.GetValue_String("pr_30040138828")
            End Get
            Set(value As String)
                me.SetValue_String("pr_30040138828", value)
            End Set
          End Property
          Public property CIFNIFEmpresa As String
            get
                return me.GetValue_String("pr_30040138825")
            End Get
            Set(value As String)
                me.SetValue_String("pr_30040138825", value)
            End Set
          End Property
          Public property ProvinciaEmpresa As String
            get
                return me.GetValue_String("pr_30040138829")
            End Get
            Set(value As String)
                me.SetValue_String("pr_30040138829", value)
            End Set
          End Property
          Public property CIFNIFProveedor As String
            get
                return me.GetValue_String("pr_20040138827")
            End Get
            Set(value As String)
                me.SetValue_String("pr_20040138827", value)
            End Set
          End Property
          Public property NumeroDeFactura As String
            get
                return me.GetValue_String("pr_10040145301")
            End Get
            Set(value As String)
                me.SetValue_String("pr_10040145301", value)
            End Set
          End Property
        Public ReadOnly property ImporteImporteImpuestoGeneral As Decimal
            get
                return me.GetValue_Decimal("pr_30040148965")
            End Get   
        End Property
          Public property ReferenciaImpuestoGeneral As Guid
            get
                return me.GetValue_Guid("pr_30040148964")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_30040148964", value)
            End Set
          End Property
          Public property EsGasto As Boolean
            get
                return me.GetValue_Boolean("pr_30040163141")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_30040163141", value)
            End Set
          End Property
          Public property MarcarComoConcluidaAunqueHayanProcesosPendientes As Boolean
            get
                return me.GetValue_Boolean("pr_60040173901")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_60040173901", value)
            End Set
          End Property
          Public property CondicionDePagoDias As Integer
            get
                return me.GetValue_Int("pr_60040176522")
            End Get
            Set(value As Integer)
                me.SetValue_Int("pr_60040176522", value)
            End Set
          End Property
          Public property FechaDeVencimiento As Date
            get
                return me.GetValue_Date("pr_60040176521")
            End Get
            Set(value As Date)
                me.SetValue_Date("pr_60040176521", value)
            End Set
          End Property
          Public property CondicionesDePago As String
            get
                return me.GetValue_String("pr_60040176523")
            End Get
            Set(value As String)
                me.SetValue_String("pr_60040176523", value)
            End Set
          End Property
          Public property OperacionIntragrupo As Boolean
            get
                return me.GetValue_Boolean("pr_40040238923")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_40040238923", value)
            End Set
          End Property
          Public property InversionDelSujetoPasivo As Boolean
            get
                return me.GetValue_Boolean("pr_10040238942")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_10040238942", value)
            End Set
          End Property
          Public property RegimenEspecialDeBienesUsados As Boolean
            get
                return me.GetValue_Boolean("pr_50040238943")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_50040238943", value)
            End Set
          End Property
          Public property CodigoPaisProveedor As String
            get
                return me.GetValue_String("pr_20040241543")
            End Get
            Set(value As String)
                me.SetValue_String("pr_20040241543", value)
            End Set
          End Property
          Public property CodigoProvinciaProveedor As String
            get
                return me.GetValue_String("pr_20040241544")
            End Get
            Set(value As String)
                me.SetValue_String("pr_20040241544", value)
            End Set
          End Property
          Public property TipoCIFNIFProveedor As String
            get
                return me.GetValue_String("pr_20040241601")
            End Get
            Set(value As String)
                me.SetValue_String("pr_20040241601", value)
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
