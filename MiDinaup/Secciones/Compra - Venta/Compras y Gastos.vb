   Imports System.ComponentModel
   Imports DinaNETCore
   Imports DinaNETCore.APID
Partial Public Class SeccionesD
  Public Class ComprasYGastosD
      Public Class ComprasYGastos_ConListaC
      Public Listador as ComprasYGastosC
      Public Lista As New List(of ComprasYGastosListaD.ComprasYGastosListaC)
        sub new(_listador  as ComprasYGastosC, _lista as List(of ComprasYGastosListaD.ComprasYGastosListaC))
           me.Listador =_listador 
           me.Lista =_lista 
        End sub
      End Class
      Public Shared _SeccionID As String = "8fac2930-c1ea-48b5-ab89-50a0725e86e2"
      Public Shared _SeccionIDGUID As New Guid("8fac2930-c1ea-48b5-ab89-50a0725e86e2")
      Public Shared Async Function ConsultarDatos_Async(Parametros As SeccionConsultaParametrosC) As Task(Of List(Of ComprasYGastosC )) 
          Dim R As New List(Of ComprasYGastosC )  
          Dim d = Await Parametros.DinaupSesion.ConexionServidor.Funcion_Datos_Recibir_Async(ComprasYGastosES._SeccionID, False, Parametros) 
          If d.Datos.TieneDatos Then 
              For Each Actual In d.Datos 
                  Dim Valores_Listador = Actual.Value.Item1
                  Dim Obj_Listador As New ComprasYGastosC 
                  Obj_Listador.CargarDatos(Valores_Listador) 
                  Obj_Listador.CargaInterna(Actual.Value)
                  R.Add(Obj_Listador) 
              Next 
          End If 
          Return R 
      End Function 
      Public Shared Async Function ConsultarDatos_ConLista_Async(  Parametros As SeccionConsultaParametrosC ) As Task(Of List(Of  ComprasYGastos_ConListaC)) 
          Dim R As New List(Of ComprasYGastos_ConListaC )  
          Dim d =  Await Parametros.DinaupSesion.ConexionServidor.Funcion_Datos_Recibir_Async(ComprasYGastosES._SeccionID, True, Parametros) 
          If d.Datos.TieneDatos Then 
              For Each Actual In d.Datos 
                  Dim Valores_Listador = Actual.Value.Item1
                  Dim Valores_Lista = Actual.Value.Item2
                  Dim Obj_Listador As New ComprasYGastosC 
                  Obj_Listador.CargarDatos(Valores_Listador) 
                  Obj_Listador.CargaInterna(Actual.Value)
                  Dim Objs_Listas As New List(Of ComprasYGastosListaD.ComprasYGastosListaC) 
                  If Valores_Lista.TieneDatos Then  
                      For Each ValoresLista In Valores_Lista 
                         Dim nItem As New ComprasYGastosListaD.ComprasYGastosListaC 
                         nItem.CargarDatos(ValoresLista)   
                         Objs_Listas.Add(nItem)         
                      Next   
                  End If   
                  R.Add(New ComprasYGastos_ConListaC(Obj_Listador, Objs_Listas))
              Next 
          End If 
          Return R 
      End Function 
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As ComprasYGastosC, Optional CampoWhere$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Return Await DatosGuardar_Async(DinaupSesion, New List(Of ComprasYGastosC)({DAtos}), CampoWhere )
      End Function
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As List(Of ComprasYGastosC), Optional CampoWhere$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Dim Importar As New List(Of DinaupAPI_ImportacionProcesableC)
          For Each Actual In DAtos 
              Dim RegistroActual = New DinaupAPI_ImportacionProcesableC() 
               RegistroActual.dinaup_listador_datos = Actual.ToDic 
               Importar.Add(RegistroActual)  
          Next 
          Return Await DinaupSesion.ConexionServidor.Funcion_Importar_Ejecutar_Async(DinaupSesion, ComprasYGastosES._SeccionID, Importar, CampoWhere, "") 
      End Function
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As ComprasYGastos_ConListaC, Optional CampoWhere$ = "id", Optional CampoWhereLista$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Return Await DatosGuardar_Async(DinaupSesion, New List(Of ComprasYGastos_ConListaC)({DAtos}), CampoWhere, CampoWhereLista)
      End Function
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As List(Of ComprasYGastos_ConListaC), Optional CampoWhere$ = "id", Optional CampoWhereLista$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
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
          Return Await DinaupSesion.ConexionServidor.Funcion_Importar_Ejecutar_Async(DinaupSesion, ComprasYGastosES._SeccionID, Importar, CampoWhere, CampoWhereLista) 
      End Function
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As ComprasYGastos_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, ComprasYGastosES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New ComprasYGastos_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As ComprasYGastos_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, ComprasYGastosES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New ComprasYGastos_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class ComprasYGastosES
          Public shared _SeccionID as Guid = New Guid("8fac2930-c1ea-48b5-ab89-50a0725e86e2")
          Public shared _Tabla$ = "tpr_30040105553"
      Public Shared ReferenciaDestinador$ = "pr_300401055575"
      Public Shared HoraLocal$ = "pr_300401055570"
      Public Shared ImporteBaseImponibleImpuesto1$ = "pr_4004010567628"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_300401055567"
      Public Shared ProveedorTieneAccesoWeb$ = "pr_4004010567692"
      Public Shared ReferenciaImpuesto3$ = "pr_4004010567684"
      Public Shared ImporteTotalAPagar$ = "pr_4004010567631"
      Public Shared ImporteSumaImporteDeProductosSinImpuestos$ = "pr_4004010567630"
      Public Shared DescuentoGeneralAplicadoPorciento$ = "pr_4004010567629"
      Public Shared ReferenciaConfiguracionDeCompra$ = "pr_4004010567685"
      Public Shared ImporteTotalImpuestos$ = "pr_4004010567637"
      Public Shared ImporteCuotaImpuesto1$ = "pr_4004010567635"
      Public Shared ImporteBaseImponibleExenta$ = "pr_4004010567636"
      Public Shared DescripcionDescuentoAdicionalB$ = "pr_4004010567695"
      Public Shared ImporteTotalPagado$ = "pr_4004010567634"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_300401055581"
      Public Shared ReferenciaEstado$ = "pr_4004010567688"
      Public Shared ImporteDescuentosGeneralImpuesto1$ = "pr_4004010567644"
      Public Shared ImporteBaseImponibleImpuesto3$ = "pr_4004010567642"
      Public Shared ReferenciaRetencion$ = "pr_4004010567686"
      Public Shared DescripcionDescuentoAdicionalA$ = "pr_4004010567696"
      Public Shared ImporteSumaConceptosSinImpuestos$ = "pr_4004010567640"
      Public Shared SumaConceptosConImpuestos$ = "pr_60040115043"
      Public Shared ImporteDescuentosProductoImpuesto1$ = "pr_4004010567639"
      Public Shared ImporteCuotaREImpuesto1$ = "pr_4004010567653"
      Public Shared ImporteSumaDeConceptosImpuesto2$ = "pr_4004010567650"
      Public Shared CantidadDeProductosQueDebenEntrar$ = "pr_4004010567649"
      Public Shared ImporteSumaImporteProductosConImpuestos$ = "pr_4004010567648"
      Public Shared ReferenciaPuestoDeTrabajo$ = "pr_4004010567691"
      Public Shared ImporteTotalDescontadoSinImpuestos$ = "pr_4004010567659"
      Public Shared ImporteCuotaImpuesto3$ = "pr_4004010567658"
      Public Shared ReferenciaImpuesto2$ = "pr_4004010567690"
      Public Shared DescuentoAdicionalAAplicadoPorciento$ = "pr_4004010567656"
      Public Shared ReferenciaNumeracionSerie$ = "pr_4004010567689"
      Public Shared TotalPorcentajeDescuentosGeneralesPorciento$ = "pr_4004010567655"
      Public Shared ImporteDescuentosProductoImpuesto2$ = "pr_4004010567663"
      Public Shared NumeroDeReferenciaInterna$ = "pr_4004010567700"
      Public Shared DescuentoEntidadAplicadoPorciento$ = "pr_4004010567674"
      Public Shared DescuentoAdicionalBAplicadoPorciento$ = "pr_4004010567673"
      Public Shared TotalEntradosDestinador$ = "pr_4004010567672"
      Public Shared ImporteSumaDeConceptosImpuesto3$ = "pr_4004010567669"
      Public Shared ImporteImporteRetencion$ = "pr_4004010567668"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_300401055566"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_300401055584"
      Public Shared ImporteBaseImponibleImpuesto2$ = "pr_4004010567598"
      Public Shared FechaDato_UTC$ = "pr_300401055569"
      Public Shared ImporteSumaDeConceptosImpuestoExentos$ = "pr_4004010567602"
      Public Shared FechaAlta_UTC$ = "pr_300401055572"
      Public Shared ImporteCuotaREImpuesto3$ = "pr_4004010567610"
      Public Shared Observaciones$ = "pr_4004010567693"
      Public Shared ImporteTotal$ = "pr_4004010567608"
      Public Shared ImporteTotalDeduccionIVA$ = "pr_4004010567606"
      Public Shared ImporteCuotaREImpuesto2$ = "pr_4004010567605"
      Public Shared ImporteDescuentosGeneralImpuesto2$ = "pr_4004010567604"
      Public Shared ImporteSumaDeConceptosImpuesto1$ = "pr_4004010567612"
      Public Shared NumeroDeReferenciaInternaCompleto$ = "pr_4004010567694"
      Public Shared ReferenciaPresupuestoDeCompra$ = "pr_20040105794"
      Public Shared TotalDevueltosDestinadores$ = "pr_4004010567615"
      Public Shared ImporteSubtotal$ = "pr_4004010567614"
      Public Shared ImporteDescuentosProductoImpuesto3$ = "pr_4004010567620"
      Public Shared ImporteDescuentosProductoExento$ = "pr_4004010567618"
      Public Shared ReferenciaImpuesto1$ = "pr_4004010567680"
      Public Shared ImporteDescuentoGeneralImpuestoExento$ = "pr_4004010567617"
      Public Shared CantidadDeProductosQueSePuedenRectificar$ = "pr_4004010567616"
      Public Shared ReferenciaAutorDelAlta$ = "pr_300401055568"
      Public Shared ImporteCuotaImpuesto2$ = "pr_4004010567622"
      Public Shared ReferenciaProveedor$ = "pr_4004010567681"
      Public Shared AplicarRecargoDeEquivalencia$ = "pr_4004010567706"
      Public Shared ImporteDescuentosGeneralImpuesto3$ = "pr_4004010567626"
      Public Shared CantidadDeProductos$ = "pr_4004010567625"
      Public Shared FechaContable$ = "pr_40040135702"
      Public Shared ReferenciaAsientoContable$ = "pr_40040135291"
      Public Shared DireccionProveedor$ = "pr_60040138819"
      Public Shared PaisProveedor$ = "pr_60040138817"
      Public Shared ProvinciaProveedor$ = "pr_60040138816"
      Public Shared CodigoPostalProveedor$ = "pr_600401388110"
      Public Shared MunicipioProveedor$ = "pr_60040138818"
      Public Shared PaisEmpresa$ = "pr_10040138823"
      Public Shared DireccionEmpresa$ = "pr_10040138826"
      Public Shared MunicipioEmpresa$ = "pr_10040138825"
      Public Shared ReferenciaDatosFiscalesEmpresa$ = "pr_10040138827"
      Public Shared NIFEmpresa$ = "pr_10040138829"
      Public Shared ReferenciaDatosFiscalesProveedor$ = "pr_60040138815"
      Public Shared NIFProveedor$ = "pr_600401388112"
      Public Shared ProvinciaEmpresa$ = "pr_100401388211"
      Public Shared TelefonoEmpresa$ = "pr_10040138824"
      Public Shared DenominacionRazonSocialProveedor$ = "pr_600401388111"
      Public Shared TelefonoProveedor$ = "pr_10040138822"
      Public Shared CodigoPostalEmpresa$ = "pr_10040138828"
      Public Shared DenominacionRazonSocialEmpresa$ = "pr_100401388210"
      Public Shared NumeroDeFactura$ = "pr_60040145291002"
      Public Shared ReferenciaImpuestoGeneral$ = "pr_30040148968"
      Public Shared ImporteImporteImpuestoGeneral$ = "pr_30040148969"
      Public Shared EsUnGastoSinFacturaObsoleto$ = "pr_50040163131"
      Public Shared MarcarComoConcluidaAunqueHayanProcesosPendientes$ = "pr_50040173901"
      Public Shared CondicionDePagoDias$ = "pr_40040176522"
      Public Shared CondicionesDePago$ = "pr_40040176524"
      Public Shared FechaDeVencimiento$ = "pr_40040176523"
      Public Shared TotalSalidosDestinadores$ = "pr_10040242021"
      Public Shared RegimenEspecialDeBienesUsadosObsoleto$ = "pr_50040238942"
      Public Shared OperacionIntragrupo$ = "pr_40040238924"
      Public Shared InversionDelSujetoPasivoObsoleto$ = "pr_10040238941"
      Public Shared CodigoPaisProveedor$ = "pr_20040241542"
      Public Shared CodigoProvinciaProveedor$ = "pr_20040241541"
      Public Shared TipoNIFProveedor$ = "pr_20040241602"
      Public Shared Tipo$ = "pr_200402418512"
      Public Shared ReferenciaCompraARectificar$ = "pr_200402418410"
      Public Shared CantidadDeProductosQueDebenSalir$ = "pr_10040242022"
      Public Shared ReferenciaArrendamiento$ = "pr_10040251095"
      Public Shared NIFIntracomunitarioEmpresa$ = "pr_30040255422"
      Public Shared NIFIntracomunitarioProveedor$ = "pr_30040255421"
      Public Shared ImporteTotalSuplidos$ = "pr_60040256611"
      Public Shared ImporteTotalOperacion$ = "pr_60040256621"
      Public Shared ReferenciaActividad$ = "pr_30040256141"
      Public Shared BienDeInversionObsoleto$ = "pr_20040256992"
      Public Shared ReferenciaClaveDeOperacion$ = "pr_20040256991"
      Public Shared EstablecerManualmenteLasCuotasDeImpuestos$ = "pr_10040259131"
      Public Shared ImporteSubtotalDeducibleIVA$ = "pr_40040258811"
      Public Shared ImporteSubtotalDeducibleIRPF$ = "pr_30040260241"
      Public Shared AsignarManualmenteLaFechaContable$ = "pr_10040268922"
      Public Shared ReferenciaRetoCapitalMobiliario$ = "pr_50040281131"
      Public Shared ReferenciaMonedaExtranjera$ = "pr_10040454262"
      Public Shared CambioMoneda$ = "pr_10040454261"
      Public Shared ImpuestosIncluidos$ = "pr_4004010567704"
      Public Shared ReferenciaTipoDeFactura$ = "pr_4004010567677"
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
      Public Class ComprasYGastosC
      Inherits Base_DatoC
          <DisplayName("Destinador")>
          Public Property ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaDestinador As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaDestinador"",""etiqueta"": ""Destinador"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""relacionesindirectas"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Destinador"",""descripcion"": """",""keyword"": ""ReferenciaDestinador"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaDestinador
          <DisplayName("Hora local")>
          Public Property HoraLocal As DateTime?
          Public Shared ___HoraLocal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""HoraLocal"",""etiqueta"": ""Hora local"",""oculta"": false,""formato"": 8,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Hora local"",""descripcion"": """",""keyword"": ""HoraLocal"",""formato"": 8,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __HoraLocal As DinaNETCore.APID.DinaupAPI_CampoC = ___HoraLocal
          <DisplayName("Base imponible impuesto 1")>
          Public Property ImporteBaseImponibleImpuesto1 As Decimal
          Public Shared ___ImporteBaseImponibleImpuesto1 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteBaseImponibleImpuesto1"",""etiqueta"": ""Base imponible impuesto 1"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Base imponible impuesto 1"",""descripcion"": """",""keyword"": ""ImporteBaseImponibleImpuesto1"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteBaseImponibleImpuesto1 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteBaseImponibleImpuesto1
          <DisplayName("Ubicación Principal")>
          Public Property ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaUbicacionPrincipal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaUbicacionPrincipal"",""etiqueta"": ""Ubicación Principal"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""b9adbfbf-a81a-45fb-861c-90502902c982"",""titulo"": ""Ubicaciones"",""iconoid"": ""b985b58f-7275-46b8-9b66-2c54346b0185"",""etiquetasingular"": ""Ubicación"",""etiquetaplural"": ""Ubicaciones"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""b9adbfbf-a81a-45fb-861c-90502902c982"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Ubicación Principal"",""descripcion"": """",""keyword"": ""ReferenciaUbicacionPrincipal"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaUbicacionPrincipal
          <DisplayName("Proveedor Tiene Acceso web")>
          Public Property ProveedorTieneAccesoWeb As Boolean
          Public Shared ___ProveedorTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ProveedorTieneAccesoWeb"",""etiqueta"": ""Proveedor Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Proveedor Tiene Acceso web"",""descripcion"": """",""keyword"": ""ProveedorTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ProveedorTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___ProveedorTieneAccesoWeb
          <DisplayName("Impuesto 3")>
          Public Property ReferenciaImpuesto3 As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaImpuesto3 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaImpuesto3"",""etiqueta"": ""Impuesto 3"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""f3199ee0-dc83-4667-a9c1-f3b04e97a8a4"",""titulo"": ""Base - Impuestos"",""iconoid"": ""ff4a7189-6426-43b9-bdc4-070314999e81"",""etiquetasingular"": ""Impuesto"",""etiquetaplural"": ""Impuestos"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""f3199ee0-dc83-4667-a9c1-f3b04e97a8a4"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Impuesto 3"",""descripcion"": """",""keyword"": ""ReferenciaImpuesto3"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaImpuesto3 As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaImpuesto3
          <DisplayName("Total a pagar")>
          Public Property ImporteTotalAPagar As Decimal
          Public Shared ___ImporteTotalAPagar As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteTotalAPagar"",""etiqueta"": ""Total a pagar"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total a pagar"",""descripcion"": """",""keyword"": ""ImporteTotalAPagar"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteTotalAPagar As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteTotalAPagar
          <DisplayName("Suma importe de productos (Sin Impuestos)")>
          Public Property ImporteSumaImporteDeProductosSinImpuestos As Decimal
          Public Shared ___ImporteSumaImporteDeProductosSinImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSumaImporteDeProductosSinImpuestos"",""etiqueta"": ""Suma importe de productos (Sin Impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Suma importe de productos (Sin Impuestos)"",""descripcion"": """",""keyword"": ""ImporteSumaImporteDeProductosSinImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSumaImporteDeProductosSinImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSumaImporteDeProductosSinImpuestos
          <Description("Descuento general de la venta que se ha aplicado.")>
          <DisplayName("Descuento General % (Aplicado)")>
          Public Property DescuentoGeneralAplicadoPorciento As Decimal
          Public Shared ___DescuentoGeneralAplicadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoGeneralAplicadoPorciento"",""etiqueta"": ""Descuento General % (Aplicado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento General % (Aplicado)"",""descripcion"": """",""keyword"": ""DescuentoGeneralAplicadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoGeneralAplicadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoGeneralAplicadoPorciento
          <DisplayName("Configuración de compra")>
          Public Property ReferenciaConfiguracionDeCompra As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaConfiguracionDeCompra As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaConfiguracionDeCompra"",""etiqueta"": ""Configuración de compra"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""afd1a074-0e8f-4e19-916c-030b70b00354"",""titulo"": ""Base - Configuración Compras/Gastos"",""iconoid"": ""51dda3d6-b61f-45d3-a4fb-3a9d3bfc4128"",""etiquetasingular"": ""Configuración Compras/Gastos"",""etiquetaplural"": ""Configuraciones Compras/Gastos"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""afd1a074-0e8f-4e19-916c-030b70b00354"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Configuración de compra"",""descripcion"": """",""keyword"": ""ReferenciaConfiguracionDeCompra"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaConfiguracionDeCompra As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaConfiguracionDeCompra
          <Description("Importe total de impuestos.")>
          <DisplayName("Total impuestos")>
          Public Property ImporteTotalImpuestos As Decimal
          Public Shared ___ImporteTotalImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteTotalImpuestos"",""etiqueta"": ""Total impuestos"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total impuestos"",""descripcion"": """",""keyword"": ""ImporteTotalImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteTotalImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteTotalImpuestos
          <DisplayName("Cuota Impuesto 1")>
          Public Property ImporteCuotaImpuesto1 As Decimal
          Public Shared ___ImporteCuotaImpuesto1 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteCuotaImpuesto1"",""etiqueta"": ""Cuota Impuesto 1"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cuota Impuesto 1"",""descripcion"": """",""keyword"": ""ImporteCuotaImpuesto1"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteCuotaImpuesto1 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteCuotaImpuesto1
          <DisplayName("Base imponible Exenta")>
          Public Property ImporteBaseImponibleExenta As Decimal
          Public Shared ___ImporteBaseImponibleExenta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteBaseImponibleExenta"",""etiqueta"": ""Base imponible Exenta"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Base imponible Exenta"",""descripcion"": """",""keyword"": ""ImporteBaseImponibleExenta"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteBaseImponibleExenta As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteBaseImponibleExenta
          <DisplayName("Descripción descuento adicional B")>
          Public Property DescripcionDescuentoAdicionalB As String
          Public Shared ___DescripcionDescuentoAdicionalB As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescripcionDescuentoAdicionalB"",""etiqueta"": ""Descripción descuento adicional B"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descripción descuento adicional B"",""descripcion"": """",""keyword"": ""DescripcionDescuentoAdicionalB"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescripcionDescuentoAdicionalB As DinaNETCore.APID.DinaupAPI_CampoC = ___DescripcionDescuentoAdicionalB
          <DisplayName("Total pagado")>
          Public Property ImporteTotalPagado As Decimal
          Public Shared ___ImporteTotalPagado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteTotalPagado"",""etiqueta"": ""Total pagado"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total pagado"",""descripcion"": """",""keyword"": ""ImporteTotalPagado"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteTotalPagado As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteTotalPagado
          <DisplayName("Autor del alta Tiene Acceso web")>
          Public Property AutorDelAltaTieneAccesoWeb As Boolean
          Public Shared ___AutorDelAltaTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AutorDelAltaTieneAccesoWeb"",""etiqueta"": ""Autor del alta Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta Tiene Acceso web"",""descripcion"": """",""keyword"": ""AutorDelAltaTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AutorDelAltaTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___AutorDelAltaTieneAccesoWeb
          <DisplayName("Estado")>
          Public Property ReferenciaEstado As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaEstado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaEstado"",""etiqueta"": ""Estado"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""2ec4f8ad-cec0-455e-a3ec-2557ec867762"",""titulo"": ""Estados de Compras/Gastos"",""iconoid"": ""1fbec552-994a-465e-a9ee-8502faa65d11"",""etiquetasingular"": ""Estado de Compras/Gasto"",""etiquetaplural"": ""Estados de Compras/Gastos"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""2ec4f8ad-cec0-455e-a3ec-2557ec867762"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Estado"",""descripcion"": """",""keyword"": ""ReferenciaEstado"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaEstado As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaEstado
          <DisplayName("Descuentos General Impuesto 1")>
          Public Property ImporteDescuentosGeneralImpuesto1 As Decimal
          Public Shared ___ImporteDescuentosGeneralImpuesto1 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentosGeneralImpuesto1"",""etiqueta"": ""Descuentos General Impuesto 1"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuentos General Impuesto 1"",""descripcion"": """",""keyword"": ""ImporteDescuentosGeneralImpuesto1"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentosGeneralImpuesto1 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentosGeneralImpuesto1
          <DisplayName("Base imponible impuesto 3")>
          Public Property ImporteBaseImponibleImpuesto3 As Decimal
          Public Shared ___ImporteBaseImponibleImpuesto3 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteBaseImponibleImpuesto3"",""etiqueta"": ""Base imponible impuesto 3"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Base imponible impuesto 3"",""descripcion"": """",""keyword"": ""ImporteBaseImponibleImpuesto3"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteBaseImponibleImpuesto3 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteBaseImponibleImpuesto3
          <DisplayName("Retención")>
          Public Property ReferenciaRetencion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaRetencion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaRetencion"",""etiqueta"": ""Retención"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""1a89014d-3991-4d9d-8d0f-77fcf2ddff5e"",""titulo"": ""Base - Retenciones"",""iconoid"": ""13560fd4-34fc-42bc-b12d-007e26e5f428"",""etiquetasingular"": ""Retención"",""etiquetaplural"": ""Retenciones"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""1a89014d-3991-4d9d-8d0f-77fcf2ddff5e"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Retención"",""descripcion"": """",""keyword"": ""ReferenciaRetencion"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaRetencion As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaRetencion
          <DisplayName("Descripción descuento adicional A")>
          Public Property DescripcionDescuentoAdicionalA As String
          Public Shared ___DescripcionDescuentoAdicionalA As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescripcionDescuentoAdicionalA"",""etiqueta"": ""Descripción descuento adicional A"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descripción descuento adicional A"",""descripcion"": """",""keyword"": ""DescripcionDescuentoAdicionalA"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescripcionDescuentoAdicionalA As DinaNETCore.APID.DinaupAPI_CampoC = ___DescripcionDescuentoAdicionalA
          <Description("Importe total de los productos del documento, sin ningún tipo de descuento y/o impuestos aplicado.")>
          <DisplayName("Suma conceptos (Sin impuestos)")>
          Public Property ImporteSumaConceptosSinImpuestos As Decimal
          Public Shared ___ImporteSumaConceptosSinImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSumaConceptosSinImpuestos"",""etiqueta"": ""Suma conceptos (Sin impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Suma conceptos (Sin impuestos)"",""descripcion"": """",""keyword"": ""ImporteSumaConceptosSinImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSumaConceptosSinImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSumaConceptosSinImpuestos
          <DisplayName("Suma conceptos (Con impuestos)")>
          Public Property SumaConceptosConImpuestos As Decimal
          Public Shared ___SumaConceptosConImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""SumaConceptosConImpuestos"",""etiqueta"": ""Suma conceptos (Con impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Suma conceptos (Con impuestos)"",""descripcion"": """",""keyword"": ""SumaConceptosConImpuestos"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __SumaConceptosConImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___SumaConceptosConImpuestos
          <DisplayName("Descuentos Producto Impuesto 1")>
          Public Property ImporteDescuentosProductoImpuesto1 As Decimal
          Public Shared ___ImporteDescuentosProductoImpuesto1 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentosProductoImpuesto1"",""etiqueta"": ""Descuentos Producto Impuesto 1"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuentos Producto Impuesto 1"",""descripcion"": """",""keyword"": ""ImporteDescuentosProductoImpuesto1"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentosProductoImpuesto1 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentosProductoImpuesto1
          <DisplayName("Cuota R.E Impuesto 1")>
          Public Property ImporteCuotaREImpuesto1 As Decimal
          Public Shared ___ImporteCuotaREImpuesto1 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteCuotaREImpuesto1"",""etiqueta"": ""Cuota R.E Impuesto 1"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cuota R.E Impuesto 1"",""descripcion"": """",""keyword"": ""ImporteCuotaREImpuesto1"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteCuotaREImpuesto1 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteCuotaREImpuesto1
          <DisplayName("Suma de conceptos Impuesto 2")>
          Public Property ImporteSumaDeConceptosImpuesto2 As Decimal
          Public Shared ___ImporteSumaDeConceptosImpuesto2 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSumaDeConceptosImpuesto2"",""etiqueta"": ""Suma de conceptos Impuesto 2"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Suma de conceptos Impuesto 2"",""descripcion"": """",""keyword"": ""ImporteSumaDeConceptosImpuesto2"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSumaDeConceptosImpuesto2 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSumaDeConceptosImpuesto2
          <DisplayName("Cantidad de productos que deben entrar")>
          Public Property CantidadDeProductosQueDebenEntrar As Decimal
          Public Shared ___CantidadDeProductosQueDebenEntrar As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CantidadDeProductosQueDebenEntrar"",""etiqueta"": ""Cantidad de productos que deben entrar"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""11"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cantidad de productos que deben entrar"",""descripcion"": """",""keyword"": ""CantidadDeProductosQueDebenEntrar"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CantidadDeProductosQueDebenEntrar As DinaNETCore.APID.DinaupAPI_CampoC = ___CantidadDeProductosQueDebenEntrar
          <DisplayName("Suma Importe Productos (Con impuestos)")>
          Public Property ImporteSumaImporteProductosConImpuestos As Decimal
          Public Shared ___ImporteSumaImporteProductosConImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSumaImporteProductosConImpuestos"",""etiqueta"": ""Suma Importe Productos (Con impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Suma Importe Productos (Con impuestos)"",""descripcion"": """",""keyword"": ""ImporteSumaImporteProductosConImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSumaImporteProductosConImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSumaImporteProductosConImpuestos
          <DisplayName("Puesto de trabajo")>
          Public Property ReferenciaPuestoDeTrabajo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaPuestoDeTrabajo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaPuestoDeTrabajo"",""etiqueta"": ""Puesto de trabajo"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""f777486d-e709-41be-9211-d9c6b4bb05d6"",""titulo"": ""Base - Puestos de trabajo"",""iconoid"": ""5d7008ed-1e2f-4dbe-a376-6261de330414"",""etiquetasingular"": ""Puesto de trabajo"",""etiquetaplural"": ""Puestos de trabajo"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""f777486d-e709-41be-9211-d9c6b4bb05d6"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Puesto de trabajo"",""descripcion"": """",""keyword"": ""ReferenciaPuestoDeTrabajo"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaPuestoDeTrabajo As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaPuestoDeTrabajo
          <Description("Importe total de todo los impuestos (Tanto generales como de productos) que se han aplicado.")>
          <DisplayName("Total Descontado (Sin impuestos)")>
          Public Property ImporteTotalDescontadoSinImpuestos As Decimal
          Public Shared ___ImporteTotalDescontadoSinImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteTotalDescontadoSinImpuestos"",""etiqueta"": ""Total Descontado (Sin impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total Descontado (Sin impuestos)"",""descripcion"": """",""keyword"": ""ImporteTotalDescontadoSinImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteTotalDescontadoSinImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteTotalDescontadoSinImpuestos
          <DisplayName("Cuota Impuesto 3")>
          Public Property ImporteCuotaImpuesto3 As Decimal
          Public Shared ___ImporteCuotaImpuesto3 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteCuotaImpuesto3"",""etiqueta"": ""Cuota Impuesto 3"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cuota Impuesto 3"",""descripcion"": """",""keyword"": ""ImporteCuotaImpuesto3"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteCuotaImpuesto3 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteCuotaImpuesto3
          <DisplayName("Impuesto 2")>
          Public Property ReferenciaImpuesto2 As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaImpuesto2 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaImpuesto2"",""etiqueta"": ""Impuesto 2"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""f3199ee0-dc83-4667-a9c1-f3b04e97a8a4"",""titulo"": ""Base - Impuestos"",""iconoid"": ""ff4a7189-6426-43b9-bdc4-070314999e81"",""etiquetasingular"": ""Impuesto"",""etiquetaplural"": ""Impuestos"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""f3199ee0-dc83-4667-a9c1-f3b04e97a8a4"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Impuesto 2"",""descripcion"": """",""keyword"": ""ReferenciaImpuesto2"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaImpuesto2 As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaImpuesto2
          <Description("Porcentaje de  descuento adicional A que se ha aplicado.")>
          <DisplayName("Descuento adicional A % (Aplicado)")>
          Public Property DescuentoAdicionalAAplicadoPorciento As Decimal
          Public Shared ___DescuentoAdicionalAAplicadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoAdicionalAAplicadoPorciento"",""etiqueta"": ""Descuento adicional A % (Aplicado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento adicional A % (Aplicado)"",""descripcion"": """",""keyword"": ""DescuentoAdicionalAAplicadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoAdicionalAAplicadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoAdicionalAAplicadoPorciento
          <DisplayName("Numeración / Serie")>
          Public Property ReferenciaNumeracionSerie As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaNumeracionSerie As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaNumeracionSerie"",""etiqueta"": ""Numeración / Serie"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""a93edb96-3ad2-4498-a1ca-696737b93cea"",""titulo"": ""Base - Numeraciones / Series"",""iconoid"": ""5ae6b089-a12a-417c-92c2-d64de875e355"",""etiquetasingular"": ""Numeración / Serie"",""etiquetaplural"": ""Numeraciones / Series"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""a93edb96-3ad2-4498-a1ca-696737b93cea"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Numeración / Serie"",""descripcion"": """",""keyword"": ""ReferenciaNumeracionSerie"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaNumeracionSerie As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaNumeracionSerie
          <DisplayName("Total porcentaje descuentos Generales")>
          Public Property TotalPorcentajeDescuentosGeneralesPorciento As Decimal
          Public Shared ___TotalPorcentajeDescuentosGeneralesPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TotalPorcentajeDescuentosGeneralesPorciento"",""etiqueta"": ""Total porcentaje descuentos Generales"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total porcentaje descuentos Generales"",""descripcion"": """",""keyword"": ""TotalPorcentajeDescuentosGeneralesPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __TotalPorcentajeDescuentosGeneralesPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___TotalPorcentajeDescuentosGeneralesPorciento
          <DisplayName("Descuentos Producto Impuesto 2")>
          Public Property ImporteDescuentosProductoImpuesto2 As Decimal
          Public Shared ___ImporteDescuentosProductoImpuesto2 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentosProductoImpuesto2"",""etiqueta"": ""Descuentos Producto Impuesto 2"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuentos Producto Impuesto 2"",""descripcion"": """",""keyword"": ""ImporteDescuentosProductoImpuesto2"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentosProductoImpuesto2 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentosProductoImpuesto2
          <DisplayName("Número de referencia interna")>
          Public Property NumeroDeReferenciaInterna As Integer
          Public Shared ___NumeroDeReferenciaInterna As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""NumeroDeReferenciaInterna"",""etiqueta"": ""Número de referencia interna"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Número de referencia interna"",""descripcion"": """",""keyword"": ""NumeroDeReferenciaInterna"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __NumeroDeReferenciaInterna As DinaNETCore.APID.DinaupAPI_CampoC = ___NumeroDeReferenciaInterna
          <Description("Descuento perteneciente a la entidad que se ha aplicado.")>
          <DisplayName("Descuento Entidad % (Aplicado)")>
          Public Property DescuentoEntidadAplicadoPorciento As Decimal
          Public Shared ___DescuentoEntidadAplicadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoEntidadAplicadoPorciento"",""etiqueta"": ""Descuento Entidad % (Aplicado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento Entidad % (Aplicado)"",""descripcion"": """",""keyword"": ""DescuentoEntidadAplicadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoEntidadAplicadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoEntidadAplicadoPorciento
          <Description("Porcentaje de  descuento adicional B que se ha aplicado.")>
          <DisplayName("Descuento adicional B % (Aplicado)")>
          Public Property DescuentoAdicionalBAplicadoPorciento As Decimal
          Public Shared ___DescuentoAdicionalBAplicadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoAdicionalBAplicadoPorciento"",""etiqueta"": ""Descuento adicional B % (Aplicado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento adicional B % (Aplicado)"",""descripcion"": """",""keyword"": ""DescuentoAdicionalBAplicadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoAdicionalBAplicadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoAdicionalBAplicadoPorciento
          <DisplayName("Total entrados (Destinador)")>
          Public Property TotalEntradosDestinador As Decimal
          Public Shared ___TotalEntradosDestinador As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TotalEntradosDestinador"",""etiqueta"": ""Total entrados (Destinador)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""11"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total entrados (Destinador)"",""descripcion"": """",""keyword"": ""TotalEntradosDestinador"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __TotalEntradosDestinador As DinaNETCore.APID.DinaupAPI_CampoC = ___TotalEntradosDestinador
          <DisplayName("Suma de conceptos Impuesto 3")>
          Public Property ImporteSumaDeConceptosImpuesto3 As Decimal
          Public Shared ___ImporteSumaDeConceptosImpuesto3 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSumaDeConceptosImpuesto3"",""etiqueta"": ""Suma de conceptos Impuesto 3"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Suma de conceptos Impuesto 3"",""descripcion"": """",""keyword"": ""ImporteSumaDeConceptosImpuesto3"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSumaDeConceptosImpuesto3 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSumaDeConceptosImpuesto3
          <DisplayName("Importe retención")>
          Public Property ImporteImporteRetencion As Decimal
          Public Shared ___ImporteImporteRetencion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteImporteRetencion"",""etiqueta"": ""Importe retención"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Importe retención"",""descripcion"": """",""keyword"": ""ImporteImporteRetencion"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteImporteRetencion As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteImporteRetencion
          <DisplayName("Empleado")>
          Public Property ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaEmpleadoPrincipal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaEmpleadoPrincipal"",""etiqueta"": ""Empleado"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c6e071c7-776f-4300-aa55-c711fd1da916"",""titulo"": ""Empleados"",""iconoid"": ""1c8abf82-640c-4d18-b62c-89de310923dd"",""etiquetasingular"": ""Empleado"",""etiquetaplural"": ""Empleados"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""c6e071c7-776f-4300-aa55-c711fd1da916"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empleado"",""descripcion"": """",""keyword"": ""ReferenciaEmpleadoPrincipal"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaEmpleadoPrincipal
          <DisplayName("Empleado Tiene Acceso web")>
          Public Property EmpleadoTieneAccesoWeb As Boolean
          Public Shared ___EmpleadoTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EmpleadoTieneAccesoWeb"",""etiqueta"": ""Empleado Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empleado Tiene Acceso web"",""descripcion"": """",""keyword"": ""EmpleadoTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EmpleadoTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___EmpleadoTieneAccesoWeb
          <DisplayName("Base imponible impuesto 2")>
          Public Property ImporteBaseImponibleImpuesto2 As Decimal
          Public Shared ___ImporteBaseImponibleImpuesto2 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteBaseImponibleImpuesto2"",""etiqueta"": ""Base imponible impuesto 2"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Base imponible impuesto 2"",""descripcion"": """",""keyword"": ""ImporteBaseImponibleImpuesto2"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteBaseImponibleImpuesto2 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteBaseImponibleImpuesto2
          <DisplayName("Fecha Dato")>
          Public Property FechaDato_UTC As Date?
          Public Shared ___FechaDato_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaDato_UTC"",""etiqueta"": ""Fecha Dato"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Dato"",""descripcion"": """",""keyword"": ""FechaDato_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaDato_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaDato_UTC
          <DisplayName("Suma de conceptos Impuesto Exentos")>
          Public Property ImporteSumaDeConceptosImpuestoExentos As Decimal
          Public Shared ___ImporteSumaDeConceptosImpuestoExentos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSumaDeConceptosImpuestoExentos"",""etiqueta"": ""Suma de conceptos Impuesto Exentos"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Suma de conceptos Impuesto Exentos"",""descripcion"": """",""keyword"": ""ImporteSumaDeConceptosImpuestoExentos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSumaDeConceptosImpuestoExentos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSumaDeConceptosImpuestoExentos
          <DisplayName("Fecha Alta del registro")>
          Public Property FechaAlta_UTC As Date?
          Public Shared ___FechaAlta_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaAlta_UTC"",""etiqueta"": ""Fecha Alta del registro"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Alta del registro"",""descripcion"": """",""keyword"": ""FechaAlta_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaAlta_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaAlta_UTC
          <DisplayName("Cuota R.E Impuesto 3")>
          Public Property ImporteCuotaREImpuesto3 As Decimal
          Public Shared ___ImporteCuotaREImpuesto3 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteCuotaREImpuesto3"",""etiqueta"": ""Cuota R.E Impuesto 3"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cuota R.E Impuesto 3"",""descripcion"": """",""keyword"": ""ImporteCuotaREImpuesto3"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteCuotaREImpuesto3 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteCuotaREImpuesto3
          <DisplayName("Observaciones y anotaciones")>
          Public Property Observaciones As String
          Public Shared ___Observaciones As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Observaciones"",""etiqueta"": ""Observaciones y anotaciones"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 9,""decimales"": ""0"",""multilinea"": true,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Observaciones y anotaciones"",""descripcion"": """",""keyword"": ""Observaciones"",""formato"": 5,""rol"": 9,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Observaciones As DinaNETCore.APID.DinaupAPI_CampoC = ___Observaciones
          <DisplayName("Total")>
          Public Property ImporteTotal As Decimal
          Public Shared ___ImporteTotal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteTotal"",""etiqueta"": ""Total"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total"",""descripcion"": """",""keyword"": ""ImporteTotal"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteTotal As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteTotal
          <DisplayName("Total Deducción IVA")>
          Public Property ImporteTotalDeduccionIVA As Decimal
          Public Shared ___ImporteTotalDeduccionIVA As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteTotalDeduccionIVA"",""etiqueta"": ""Total Deducción IVA"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total Deducción IVA"",""descripcion"": """",""keyword"": ""ImporteTotalDeduccionIVA"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteTotalDeduccionIVA As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteTotalDeduccionIVA
          <DisplayName("Cuota R.E Impuesto 2")>
          Public Property ImporteCuotaREImpuesto2 As Decimal
          Public Shared ___ImporteCuotaREImpuesto2 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteCuotaREImpuesto2"",""etiqueta"": ""Cuota R.E Impuesto 2"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cuota R.E Impuesto 2"",""descripcion"": """",""keyword"": ""ImporteCuotaREImpuesto2"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteCuotaREImpuesto2 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteCuotaREImpuesto2
          <DisplayName("Descuentos General Impuesto 2")>
          Public Property ImporteDescuentosGeneralImpuesto2 As Decimal
          Public Shared ___ImporteDescuentosGeneralImpuesto2 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentosGeneralImpuesto2"",""etiqueta"": ""Descuentos General Impuesto 2"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuentos General Impuesto 2"",""descripcion"": """",""keyword"": ""ImporteDescuentosGeneralImpuesto2"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentosGeneralImpuesto2 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentosGeneralImpuesto2
          <DisplayName("Suma de conceptos Impuesto 1")>
          Public Property ImporteSumaDeConceptosImpuesto1 As Decimal
          Public Shared ___ImporteSumaDeConceptosImpuesto1 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSumaDeConceptosImpuesto1"",""etiqueta"": ""Suma de conceptos Impuesto 1"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Suma de conceptos Impuesto 1"",""descripcion"": """",""keyword"": ""ImporteSumaDeConceptosImpuesto1"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSumaDeConceptosImpuesto1 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSumaDeConceptosImpuesto1
          <DisplayName("Número de referencia interna (Completo)")>
          Public Property NumeroDeReferenciaInternaCompleto As String
          Public Shared ___NumeroDeReferenciaInternaCompleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""NumeroDeReferenciaInternaCompleto"",""etiqueta"": ""Número de referencia interna (Completo)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Número de referencia interna (Completo)"",""descripcion"": """",""keyword"": ""NumeroDeReferenciaInternaCompleto"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __NumeroDeReferenciaInternaCompleto As DinaNETCore.APID.DinaupAPI_CampoC = ___NumeroDeReferenciaInternaCompleto
          <DisplayName("Presupuesto de compra")>
          Public Property ReferenciaPresupuestoDeCompra As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaPresupuestoDeCompra As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaPresupuestoDeCompra"",""etiqueta"": ""Presupuesto de compra"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""58e29a64-9f4a-4640-bf8f-dddbaa4158df"",""titulo"": ""Base - Presupuestos de Compras y Gastos"",""iconoid"": ""6c17ff24-7fbc-40de-b2c2-eba0c969191f"",""etiquetasingular"": ""Presupuesto de Compra / Gasto"",""etiquetaplural"": ""Presupuestos de Compras y Gastos"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""58e29a64-9f4a-4640-bf8f-dddbaa4158df"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Presupuesto de compra"",""descripcion"": """",""keyword"": ""ReferenciaPresupuestoDeCompra"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaPresupuestoDeCompra As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaPresupuestoDeCompra
          <DisplayName("Total Devueltos (Destinadores)")>
          Public Property TotalDevueltosDestinadores As Decimal
          Public Shared ___TotalDevueltosDestinadores As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TotalDevueltosDestinadores"",""etiqueta"": ""Total Devueltos (Destinadores)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""11"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total Devueltos (Destinadores)"",""descripcion"": """",""keyword"": ""TotalDevueltosDestinadores"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __TotalDevueltosDestinadores As DinaNETCore.APID.DinaupAPI_CampoC = ___TotalDevueltosDestinadores
          <Description("Importe total sin impuestos ni retenciones." & vbCrLf & "Pero con todas las bonificaciones aplicadas y todos los importes sumados." & vbCrLf & "Es el paso anterior al resultado final.")>
          <DisplayName("Subtotal")>
          Public Property ImporteSubtotal As Decimal
          Public Shared ___ImporteSubtotal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSubtotal"",""etiqueta"": ""Subtotal"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Subtotal"",""descripcion"": """",""keyword"": ""ImporteSubtotal"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSubtotal As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSubtotal
          <DisplayName("Descuentos Producto Impuesto 3")>
          Public Property ImporteDescuentosProductoImpuesto3 As Decimal
          Public Shared ___ImporteDescuentosProductoImpuesto3 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentosProductoImpuesto3"",""etiqueta"": ""Descuentos Producto Impuesto 3"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuentos Producto Impuesto 3"",""descripcion"": """",""keyword"": ""ImporteDescuentosProductoImpuesto3"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentosProductoImpuesto3 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentosProductoImpuesto3
          <DisplayName("Descuentos Producto Exento")>
          Public Property ImporteDescuentosProductoExento As Decimal
          Public Shared ___ImporteDescuentosProductoExento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentosProductoExento"",""etiqueta"": ""Descuentos Producto Exento"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuentos Producto Exento"",""descripcion"": """",""keyword"": ""ImporteDescuentosProductoExento"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentosProductoExento As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentosProductoExento
          <DisplayName("Impuesto 1")>
          Public Property ReferenciaImpuesto1 As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaImpuesto1 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaImpuesto1"",""etiqueta"": ""Impuesto 1"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""f3199ee0-dc83-4667-a9c1-f3b04e97a8a4"",""titulo"": ""Base - Impuestos"",""iconoid"": ""ff4a7189-6426-43b9-bdc4-070314999e81"",""etiquetasingular"": ""Impuesto"",""etiquetaplural"": ""Impuestos"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""f3199ee0-dc83-4667-a9c1-f3b04e97a8a4"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Impuesto 1"",""descripcion"": """",""keyword"": ""ReferenciaImpuesto1"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaImpuesto1 As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaImpuesto1
          <DisplayName("Descuento General impuesto Exento")>
          Public Property ImporteDescuentoGeneralImpuestoExento As Decimal
          Public Shared ___ImporteDescuentoGeneralImpuestoExento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentoGeneralImpuestoExento"",""etiqueta"": ""Descuento General impuesto Exento"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento General impuesto Exento"",""descripcion"": """",""keyword"": ""ImporteDescuentoGeneralImpuestoExento"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentoGeneralImpuestoExento As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentoGeneralImpuestoExento
          <DisplayName("Cantidad de productos que se pueden rectificar")>
          Public Property CantidadDeProductosQueSePuedenRectificar As Decimal
          Public Shared ___CantidadDeProductosQueSePuedenRectificar As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CantidadDeProductosQueSePuedenRectificar"",""etiqueta"": ""Cantidad de productos que se pueden rectificar"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""11"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cantidad de productos que se pueden rectificar"",""descripcion"": """",""keyword"": ""CantidadDeProductosQueSePuedenRectificar"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CantidadDeProductosQueSePuedenRectificar As DinaNETCore.APID.DinaupAPI_CampoC = ___CantidadDeProductosQueSePuedenRectificar
          <DisplayName("Autor del alta")>
          Public Property ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaAutorDelAlta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaAutorDelAlta"",""etiqueta"": ""Autor del alta"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta"",""descripcion"": """",""keyword"": ""ReferenciaAutorDelAlta"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaAutorDelAlta
          <DisplayName("Cuota Impuesto 2")>
          Public Property ImporteCuotaImpuesto2 As Decimal
          Public Shared ___ImporteCuotaImpuesto2 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteCuotaImpuesto2"",""etiqueta"": ""Cuota Impuesto 2"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cuota Impuesto 2"",""descripcion"": """",""keyword"": ""ImporteCuotaImpuesto2"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteCuotaImpuesto2 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteCuotaImpuesto2
          <DisplayName("Proveedor")>
          Public Property ReferenciaProveedor As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaProveedor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaProveedor"",""etiqueta"": ""Proveedor"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Proveedor"",""descripcion"": """",""keyword"": ""ReferenciaProveedor"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaProveedor As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaProveedor
          <DisplayName("Aplicar Recargo de equivalencia")>
          Public Property AplicarRecargoDeEquivalencia As Boolean
          Public Shared ___AplicarRecargoDeEquivalencia As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AplicarRecargoDeEquivalencia"",""etiqueta"": ""Aplicar Recargo de equivalencia"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Aplicar Recargo de equivalencia"",""descripcion"": """",""keyword"": ""AplicarRecargoDeEquivalencia"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AplicarRecargoDeEquivalencia As DinaNETCore.APID.DinaupAPI_CampoC = ___AplicarRecargoDeEquivalencia
          <DisplayName("Descuentos General Impuesto 3")>
          Public Property ImporteDescuentosGeneralImpuesto3 As Decimal
          Public Shared ___ImporteDescuentosGeneralImpuesto3 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentosGeneralImpuesto3"",""etiqueta"": ""Descuentos General Impuesto 3"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuentos General Impuesto 3"",""descripcion"": """",""keyword"": ""ImporteDescuentosGeneralImpuesto3"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentosGeneralImpuesto3 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentosGeneralImpuesto3
          <Description("Número total de productos.")>
          <DisplayName("Cantidad de Productos")>
          Public Property CantidadDeProductos As Decimal
          Public Shared ___CantidadDeProductos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CantidadDeProductos"",""etiqueta"": ""Cantidad de Productos"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""11"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cantidad de Productos"",""descripcion"": """",""keyword"": ""CantidadDeProductos"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CantidadDeProductos As DinaNETCore.APID.DinaupAPI_CampoC = ___CantidadDeProductos
          <DisplayName("Fecha contable")>
          Public Property FechaContable As Date?
          Public Shared ___FechaContable As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaContable"",""etiqueta"": ""Fecha contable"",""oculta"": false,""formato"": 7,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 69,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha contable"",""descripcion"": """",""keyword"": ""FechaContable"",""formato"": 7,""rol"": 69,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaContable As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaContable
          <DisplayName("Asiento contable")>
          Public Property ReferenciaAsientoContable As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaAsientoContable As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaAsientoContable"",""etiqueta"": ""Asiento contable"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c4608471-b749-46fd-a0eb-d82dda66dcc8"",""titulo"": ""Base - Asientos contables"",""iconoid"": ""226684b8-fe3c-46a7-8f24-7462e48c0027"",""etiquetasingular"": ""Asiento contable"",""etiquetaplural"": ""Asientos contables"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""c4608471-b749-46fd-a0eb-d82dda66dcc8"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Asiento contable"",""descripcion"": """",""keyword"": ""ReferenciaAsientoContable"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaAsientoContable As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaAsientoContable
          <DisplayName("Dirección (Proveedor)")>
          Public Property DireccionProveedor As String
          Public Shared ___DireccionProveedor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DireccionProveedor"",""etiqueta"": ""Dirección (Proveedor)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 9,""decimales"": ""0"",""multilinea"": true,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Dirección (Proveedor)"",""descripcion"": """",""keyword"": ""DireccionProveedor"",""formato"": 5,""rol"": 9,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DireccionProveedor As DinaNETCore.APID.DinaupAPI_CampoC = ___DireccionProveedor
          <DisplayName("País (Proveedor)")>
          Public Property PaisProveedor As String
          Public Shared ___PaisProveedor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""PaisProveedor"",""etiqueta"": ""País (Proveedor)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 83,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""País (Proveedor)"",""descripcion"": """",""keyword"": ""PaisProveedor"",""formato"": 5,""rol"": 83,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __PaisProveedor As DinaNETCore.APID.DinaupAPI_CampoC = ___PaisProveedor
          <DisplayName("Provincia (Proveedor)")>
          Public Property ProvinciaProveedor As String
          Public Shared ___ProvinciaProveedor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ProvinciaProveedor"",""etiqueta"": ""Provincia (Proveedor)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 84,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Provincia (Proveedor)"",""descripcion"": """",""keyword"": ""ProvinciaProveedor"",""formato"": 5,""rol"": 84,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ProvinciaProveedor As DinaNETCore.APID.DinaupAPI_CampoC = ___ProvinciaProveedor
          <DisplayName("Código postal (Proveedor)")>
          Public Property CodigoPostalProveedor As String
          Public Shared ___CodigoPostalProveedor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CodigoPostalProveedor"",""etiqueta"": ""Código postal (Proveedor)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Código postal (Proveedor)"",""descripcion"": """",""keyword"": ""CodigoPostalProveedor"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CodigoPostalProveedor As DinaNETCore.APID.DinaupAPI_CampoC = ___CodigoPostalProveedor
          <DisplayName("Municipio (Proveedor)")>
          Public Property MunicipioProveedor As String
          Public Shared ___MunicipioProveedor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""MunicipioProveedor"",""etiqueta"": ""Municipio (Proveedor)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Municipio (Proveedor)"",""descripcion"": """",""keyword"": ""MunicipioProveedor"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __MunicipioProveedor As DinaNETCore.APID.DinaupAPI_CampoC = ___MunicipioProveedor
          <DisplayName("País (Empresa)")>
          Public Property PaisEmpresa As String
          Public Shared ___PaisEmpresa As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""PaisEmpresa"",""etiqueta"": ""País (Empresa)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""País (Empresa)"",""descripcion"": """",""keyword"": ""PaisEmpresa"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __PaisEmpresa As DinaNETCore.APID.DinaupAPI_CampoC = ___PaisEmpresa
          <DisplayName("Dirección (Empresa)")>
          Public Property DireccionEmpresa As String
          Public Shared ___DireccionEmpresa As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DireccionEmpresa"",""etiqueta"": ""Dirección (Empresa)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 9,""decimales"": ""0"",""multilinea"": true,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Dirección (Empresa)"",""descripcion"": """",""keyword"": ""DireccionEmpresa"",""formato"": 5,""rol"": 9,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DireccionEmpresa As DinaNETCore.APID.DinaupAPI_CampoC = ___DireccionEmpresa
          <DisplayName("Municipio (Empresa)")>
          Public Property MunicipioEmpresa As String
          Public Shared ___MunicipioEmpresa As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""MunicipioEmpresa"",""etiqueta"": ""Municipio (Empresa)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Municipio (Empresa)"",""descripcion"": """",""keyword"": ""MunicipioEmpresa"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __MunicipioEmpresa As DinaNETCore.APID.DinaupAPI_CampoC = ___MunicipioEmpresa
          <DisplayName("Datos fiscales (Empresa)")>
          Public Property ReferenciaDatosFiscalesEmpresa As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaDatosFiscalesEmpresa As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaDatosFiscalesEmpresa"",""etiqueta"": ""Datos fiscales (Empresa)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""03e347ac-c694-4d4a-a81f-e577ba014d1d"",""titulo"": ""Base - Datos fiscales"",""iconoid"": ""773d55f9-1e21-41f1-b0b0-f6a1dd370ea3"",""etiquetasingular"": ""Datos fiscales"",""etiquetaplural"": ""Datos fiscales"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""03e347ac-c694-4d4a-a81f-e577ba014d1d"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Datos fiscales (Empresa)"",""descripcion"": """",""keyword"": ""ReferenciaDatosFiscalesEmpresa"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaDatosFiscalesEmpresa As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaDatosFiscalesEmpresa
          <DisplayName("NIF (Empresa)")>
          Public Property NIFEmpresa As String
          Public Shared ___NIFEmpresa As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""NIFEmpresa"",""etiqueta"": ""NIF (Empresa)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 79,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""NIF (Empresa)"",""descripcion"": """",""keyword"": ""NIFEmpresa"",""formato"": 5,""rol"": 79,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __NIFEmpresa As DinaNETCore.APID.DinaupAPI_CampoC = ___NIFEmpresa
          <DisplayName("Datos fiscales (Proveedor)")>
          Public Property ReferenciaDatosFiscalesProveedor As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaDatosFiscalesProveedor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaDatosFiscalesProveedor"",""etiqueta"": ""Datos fiscales (Proveedor)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""03e347ac-c694-4d4a-a81f-e577ba014d1d"",""titulo"": ""Base - Datos fiscales"",""iconoid"": ""773d55f9-1e21-41f1-b0b0-f6a1dd370ea3"",""etiquetasingular"": ""Datos fiscales"",""etiquetaplural"": ""Datos fiscales"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""03e347ac-c694-4d4a-a81f-e577ba014d1d"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Datos fiscales (Proveedor)"",""descripcion"": """",""keyword"": ""ReferenciaDatosFiscalesProveedor"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaDatosFiscalesProveedor As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaDatosFiscalesProveedor
          <DisplayName("NIF (Proveedor)")>
          Public Property NIFProveedor As String
          Public Shared ___NIFProveedor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""NIFProveedor"",""etiqueta"": ""NIF (Proveedor)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 79,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""NIF (Proveedor)"",""descripcion"": """",""keyword"": ""NIFProveedor"",""formato"": 5,""rol"": 79,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __NIFProveedor As DinaNETCore.APID.DinaupAPI_CampoC = ___NIFProveedor
          <DisplayName("Provincia (Empresa)")>
          Public Property ProvinciaEmpresa As String
          Public Shared ___ProvinciaEmpresa As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ProvinciaEmpresa"",""etiqueta"": ""Provincia (Empresa)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Provincia (Empresa)"",""descripcion"": """",""keyword"": ""ProvinciaEmpresa"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ProvinciaEmpresa As DinaNETCore.APID.DinaupAPI_CampoC = ___ProvinciaEmpresa
          <DisplayName("Teléfono (Empresa)")>
          Public Property TelefonoEmpresa As String
          Public Shared ___TelefonoEmpresa As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TelefonoEmpresa"",""etiqueta"": ""Teléfono (Empresa)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 2,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Teléfono (Empresa)"",""descripcion"": """",""keyword"": ""TelefonoEmpresa"",""formato"": 5,""rol"": 2,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __TelefonoEmpresa As DinaNETCore.APID.DinaupAPI_CampoC = ___TelefonoEmpresa
          <DisplayName("Denominación / Razón Social (Proveedor)")>
          Public Property DenominacionRazonSocialProveedor As String
          Public Shared ___DenominacionRazonSocialProveedor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DenominacionRazonSocialProveedor"",""etiqueta"": ""Denominación / Razón Social (Proveedor)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Denominación / Razón Social (Proveedor)"",""descripcion"": """",""keyword"": ""DenominacionRazonSocialProveedor"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DenominacionRazonSocialProveedor As DinaNETCore.APID.DinaupAPI_CampoC = ___DenominacionRazonSocialProveedor
          <DisplayName("Teléfono (Proveedor)")>
          Public Property TelefonoProveedor As String
          Public Shared ___TelefonoProveedor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TelefonoProveedor"",""etiqueta"": ""Teléfono (Proveedor)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 2,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Teléfono (Proveedor)"",""descripcion"": """",""keyword"": ""TelefonoProveedor"",""formato"": 5,""rol"": 2,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __TelefonoProveedor As DinaNETCore.APID.DinaupAPI_CampoC = ___TelefonoProveedor
          <DisplayName("Código postal (Empresa)")>
          Public Property CodigoPostalEmpresa As String
          Public Shared ___CodigoPostalEmpresa As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CodigoPostalEmpresa"",""etiqueta"": ""Código postal (Empresa)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Código postal (Empresa)"",""descripcion"": """",""keyword"": ""CodigoPostalEmpresa"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CodigoPostalEmpresa As DinaNETCore.APID.DinaupAPI_CampoC = ___CodigoPostalEmpresa
          <DisplayName("Denominación / Razón Social (Empresa)")>
          Public Property DenominacionRazonSocialEmpresa As String
          Public Shared ___DenominacionRazonSocialEmpresa As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DenominacionRazonSocialEmpresa"",""etiqueta"": ""Denominación / Razón Social (Empresa)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Denominación / Razón Social (Empresa)"",""descripcion"": """",""keyword"": ""DenominacionRazonSocialEmpresa"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DenominacionRazonSocialEmpresa As DinaNETCore.APID.DinaupAPI_CampoC = ___DenominacionRazonSocialEmpresa
          <DisplayName("Número de factura")>
          Public Property NumeroDeFactura As String
          Public Shared ___NumeroDeFactura As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""NumeroDeFactura"",""etiqueta"": ""Número de factura"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Número de factura"",""descripcion"": """",""keyword"": ""NumeroDeFactura"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __NumeroDeFactura As DinaNETCore.APID.DinaupAPI_CampoC = ___NumeroDeFactura
          <DisplayName("Impuesto general")>
          Public Property ReferenciaImpuestoGeneral As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaImpuestoGeneral As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaImpuestoGeneral"",""etiqueta"": ""Impuesto general"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""f3199ee0-dc83-4667-a9c1-f3b04e97a8a4"",""titulo"": ""Base - Impuestos"",""iconoid"": ""ff4a7189-6426-43b9-bdc4-070314999e81"",""etiquetasingular"": ""Impuesto"",""etiquetaplural"": ""Impuestos"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""f3199ee0-dc83-4667-a9c1-f3b04e97a8a4"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Impuesto general"",""descripcion"": """",""keyword"": ""ReferenciaImpuestoGeneral"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaImpuestoGeneral As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaImpuestoGeneral
          <DisplayName("Importe impuesto general")>
          Public Property ImporteImporteImpuestoGeneral As Decimal
          Public Shared ___ImporteImporteImpuestoGeneral As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteImporteImpuestoGeneral"",""etiqueta"": ""Importe impuesto general"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Importe impuesto general"",""descripcion"": """",""keyword"": ""ImporteImporteImpuestoGeneral"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteImporteImpuestoGeneral As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteImporteImpuestoGeneral
          <DisplayName("Es un gasto sin factura (Obsoleto)")>
          Public Property EsUnGastoSinFacturaObsoleto As Boolean
          Public Shared ___EsUnGastoSinFacturaObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EsUnGastoSinFacturaObsoleto"",""etiqueta"": ""Es un gasto sin factura (Obsoleto)"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Es un gasto sin factura (Obsoleto)"",""descripcion"": """",""keyword"": ""EsUnGastoSinFacturaObsoleto"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EsUnGastoSinFacturaObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___EsUnGastoSinFacturaObsoleto
          <DisplayName("Marcar como concluida aunque hayan procesos pendientes")>
          Public Property MarcarComoConcluidaAunqueHayanProcesosPendientes As Boolean
          Public Shared ___MarcarComoConcluidaAunqueHayanProcesosPendientes As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""MarcarComoConcluidaAunqueHayanProcesosPendientes"",""etiqueta"": ""Marcar como concluida aunque hayan procesos pendientes"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Marcar como concluida aunque hayan procesos pendientes"",""descripcion"": """",""keyword"": ""MarcarComoConcluidaAunqueHayanProcesosPendientes"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __MarcarComoConcluidaAunqueHayanProcesosPendientes As DinaNETCore.APID.DinaupAPI_CampoC = ___MarcarComoConcluidaAunqueHayanProcesosPendientes
          <DisplayName("Condición de pago (Días)")>
          Public Property CondicionDePagoDias As Integer
          Public Shared ___CondicionDePagoDias As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CondicionDePagoDias"",""etiqueta"": ""Condición de pago (Días)"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Condición de pago (Días)"",""descripcion"": """",""keyword"": ""CondicionDePagoDias"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CondicionDePagoDias As DinaNETCore.APID.DinaupAPI_CampoC = ___CondicionDePagoDias
          <DisplayName("Condiciones de pago")>
          Public Property CondicionesDePago As String
          Public Shared ___CondicionesDePago As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CondicionesDePago"",""etiqueta"": ""Condiciones de pago"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Condiciones de pago"",""descripcion"": """",""keyword"": ""CondicionesDePago"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CondicionesDePago As DinaNETCore.APID.DinaupAPI_CampoC = ___CondicionesDePago
          <DisplayName("Fecha de vencimiento")>
          Public Property FechaDeVencimiento As Date?
          Public Shared ___FechaDeVencimiento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaDeVencimiento"",""etiqueta"": ""Fecha de vencimiento"",""oculta"": false,""formato"": 7,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha de vencimiento"",""descripcion"": """",""keyword"": ""FechaDeVencimiento"",""formato"": 7,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaDeVencimiento As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaDeVencimiento
          <DisplayName("Total salidos (Destinadores)")>
          Public Property TotalSalidosDestinadores As Decimal
          Public Shared ___TotalSalidosDestinadores As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TotalSalidosDestinadores"",""etiqueta"": ""Total salidos (Destinadores)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""11"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total salidos (Destinadores)"",""descripcion"": """",""keyword"": ""TotalSalidosDestinadores"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __TotalSalidosDestinadores As DinaNETCore.APID.DinaupAPI_CampoC = ___TotalSalidosDestinadores
          <DisplayName("Régimen especial de bienes usados (Obsoleto)")>
          Public Property RegimenEspecialDeBienesUsadosObsoleto As Boolean
          Public Shared ___RegimenEspecialDeBienesUsadosObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RegimenEspecialDeBienesUsadosObsoleto"",""etiqueta"": ""Régimen especial de bienes usados (Obsoleto)"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Régimen especial de bienes usados (Obsoleto)"",""descripcion"": """",""keyword"": ""RegimenEspecialDeBienesUsadosObsoleto"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RegimenEspecialDeBienesUsadosObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___RegimenEspecialDeBienesUsadosObsoleto
          <DisplayName("Operación intragrupo")>
          Public Property OperacionIntragrupo As Boolean
          Public Shared ___OperacionIntragrupo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""OperacionIntragrupo"",""etiqueta"": ""Operación intragrupo"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Operación intragrupo"",""descripcion"": """",""keyword"": ""OperacionIntragrupo"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __OperacionIntragrupo As DinaNETCore.APID.DinaupAPI_CampoC = ___OperacionIntragrupo
          <DisplayName("Inversión del sujeto pasivo (Obsoleto)")>
          Public Property InversionDelSujetoPasivoObsoleto As Boolean
          Public Shared ___InversionDelSujetoPasivoObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""InversionDelSujetoPasivoObsoleto"",""etiqueta"": ""Inversión del sujeto pasivo (Obsoleto)"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Inversión del sujeto pasivo (Obsoleto)"",""descripcion"": """",""keyword"": ""InversionDelSujetoPasivoObsoleto"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __InversionDelSujetoPasivoObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___InversionDelSujetoPasivoObsoleto
          <DisplayName("Código País (Proveedor)")>
          Public Property CodigoPaisProveedor As String
          Public Shared ___CodigoPaisProveedor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CodigoPaisProveedor"",""etiqueta"": ""Código País (Proveedor)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 85,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Código País (Proveedor)"",""descripcion"": """",""keyword"": ""CodigoPaisProveedor"",""formato"": 5,""rol"": 85,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CodigoPaisProveedor As DinaNETCore.APID.DinaupAPI_CampoC = ___CodigoPaisProveedor
          <DisplayName("Código Provincia (Proveedor)")>
          Public Property CodigoProvinciaProveedor As String
          Public Shared ___CodigoProvinciaProveedor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CodigoProvinciaProveedor"",""etiqueta"": ""Código Provincia (Proveedor)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 86,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Código Provincia (Proveedor)"",""descripcion"": """",""keyword"": ""CodigoProvinciaProveedor"",""formato"": 5,""rol"": 86,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CodigoProvinciaProveedor As DinaNETCore.APID.DinaupAPI_CampoC = ___CodigoProvinciaProveedor
          <DisplayName("Tipo NIF (Proveedor)")>
          Public Property TipoNIFProveedor As String
          Public Shared ___TipoNIFProveedor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TipoNIFProveedor"",""etiqueta"": ""Tipo NIF (Proveedor)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 87,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Tipo NIF (Proveedor)"",""descripcion"": """",""keyword"": ""TipoNIFProveedor"",""formato"": 5,""rol"": 87,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __TipoNIFProveedor As DinaNETCore.APID.DinaupAPI_CampoC = ___TipoNIFProveedor
          <DisplayName("Tipo")>
          Public Property Tipo As EnumTipoMovimientoE
          Public Shared ___Tipo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Tipo"",""etiqueta"": ""Tipo"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 88,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [0,1,3],""predefinidos_textos"": [""Indefinido"",""Ordinario"",""Rectificativo""],""predefinidos_iconos"": [""https://cdn.dinaup.com/ico/enums/88_0.png"",""https://cdn.dinaup.com/ico/enums/88_1.png"",""https://cdn.dinaup.com/ico/enums/88_3.png""],""filtro"": {""titulo"": ""Tipo"",""descripcion"": """",""keyword"": ""Tipo"",""formato"": 2,""rol"": 88,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false,""enumeracion"": {""titulo"": ""Enum - Tipo Movimiento"", ""valores"": [{""valor"": 0, ""titulo"": ""Indefinido""},{""valor"": 1, ""titulo"": ""Ordinario""},{""valor"": 3, ""titulo"": ""Rectificativo""}]}},""solovalorespredefinidos"": true}")
          Public  __Tipo As DinaNETCore.APID.DinaupAPI_CampoC = ___Tipo
          <DisplayName("Compra a rectificar")>
          Public Property ReferenciaCompraARectificar As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaCompraARectificar As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaCompraARectificar"",""etiqueta"": ""Compra a rectificar"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""340bde1f-cdc9-4471-b55e-44b9c96dd508"",""titulo"": ""Base - Compras y Gastos"",""iconoid"": ""5686dc42-beaf-4bc5-a068-97126541fa55"",""etiquetasingular"": ""Compra / Gasto"",""etiquetaplural"": ""Compras / Gastos"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""340bde1f-cdc9-4471-b55e-44b9c96dd508"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Compra a rectificar"",""descripcion"": """",""keyword"": ""ReferenciaCompraARectificar"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaCompraARectificar As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaCompraARectificar
          <DisplayName("Cantidad de productos que deben salir")>
          Public Property CantidadDeProductosQueDebenSalir As Decimal
          Public Shared ___CantidadDeProductosQueDebenSalir As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CantidadDeProductosQueDebenSalir"",""etiqueta"": ""Cantidad de productos que deben salir"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""11"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cantidad de productos que deben salir"",""descripcion"": """",""keyword"": ""CantidadDeProductosQueDebenSalir"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CantidadDeProductosQueDebenSalir As DinaNETCore.APID.DinaupAPI_CampoC = ___CantidadDeProductosQueDebenSalir
          <DisplayName("Arrendamiento")>
          Public Property ReferenciaArrendamiento As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaArrendamiento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaArrendamiento"",""etiqueta"": ""Arrendamiento"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""af0c264f-ce03-438c-8d6a-e8db65a35a09"",""titulo"": ""Base - Arrendamientos"",""iconoid"": ""d375c3af-9675-4a22-a6ae-8d6cad100b19"",""etiquetasingular"": ""Arrendamiento"",""etiquetaplural"": ""Arrendamientos"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""af0c264f-ce03-438c-8d6a-e8db65a35a09"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Arrendamiento"",""descripcion"": """",""keyword"": ""ReferenciaArrendamiento"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaArrendamiento As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaArrendamiento
          <DisplayName("NIF Intracomunitario (Empresa)")>
          Public Property NIFIntracomunitarioEmpresa As String
          Public Shared ___NIFIntracomunitarioEmpresa As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""NIFIntracomunitarioEmpresa"",""etiqueta"": ""NIF Intracomunitario (Empresa)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 79,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""NIF Intracomunitario (Empresa)"",""descripcion"": """",""keyword"": ""NIFIntracomunitarioEmpresa"",""formato"": 5,""rol"": 79,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __NIFIntracomunitarioEmpresa As DinaNETCore.APID.DinaupAPI_CampoC = ___NIFIntracomunitarioEmpresa
          <DisplayName("NIF Intracomunitario (Proveedor)")>
          Public Property NIFIntracomunitarioProveedor As String
          Public Shared ___NIFIntracomunitarioProveedor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""NIFIntracomunitarioProveedor"",""etiqueta"": ""NIF Intracomunitario (Proveedor)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 79,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""NIF Intracomunitario (Proveedor)"",""descripcion"": """",""keyword"": ""NIFIntracomunitarioProveedor"",""formato"": 5,""rol"": 79,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __NIFIntracomunitarioProveedor As DinaNETCore.APID.DinaupAPI_CampoC = ___NIFIntracomunitarioProveedor
          <DisplayName("Total suplidos")>
          Public Property ImporteTotalSuplidos As Decimal
          Public Shared ___ImporteTotalSuplidos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteTotalSuplidos"",""etiqueta"": ""Total suplidos"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total suplidos"",""descripcion"": """",""keyword"": ""ImporteTotalSuplidos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteTotalSuplidos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteTotalSuplidos
          <Description("Total de la factura, sin incluir suplidos.")>
          <DisplayName("Total operación")>
          Public Property ImporteTotalOperacion As Decimal
          Public Shared ___ImporteTotalOperacion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteTotalOperacion"",""etiqueta"": ""Total operación"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total operación"",""descripcion"": """",""keyword"": ""ImporteTotalOperacion"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteTotalOperacion As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteTotalOperacion
          <DisplayName("Actividad")>
          Public Property ReferenciaActividad As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaActividad As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaActividad"",""etiqueta"": ""Actividad"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""f6221df1-2f56-4f49-8e45-dd4914873fa8"",""titulo"": ""Base - Actividades de Empresas"",""iconoid"": ""c33cb208-e4a6-4189-af8f-00aa92e9599a"",""etiquetasingular"": ""Actividad de Empresa"",""etiquetaplural"": ""Actividades de Empresa"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""f6221df1-2f56-4f49-8e45-dd4914873fa8"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Actividad"",""descripcion"": """",""keyword"": ""ReferenciaActividad"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaActividad As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaActividad
          <DisplayName("Bien de inversión (Obsoleto)")>
          Public Property BienDeInversionObsoleto As Boolean
          Public Shared ___BienDeInversionObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""BienDeInversionObsoleto"",""etiqueta"": ""Bien de inversión (Obsoleto)"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Bien de inversión (Obsoleto)"",""descripcion"": """",""keyword"": ""BienDeInversionObsoleto"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __BienDeInversionObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___BienDeInversionObsoleto
          <DisplayName("Clave de operación")>
          Public Property ReferenciaClaveDeOperacion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaClaveDeOperacion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaClaveDeOperacion"",""etiqueta"": ""Clave de operación"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""953e3b4c-09d4-4c99-8890-0e9caf431c4b"",""titulo"": ""Base - Claves de operaciones"",""iconoid"": ""82fa82ed-055f-4f1b-8f3c-79d2b6777e7e"",""etiquetasingular"": ""Clave de operación"",""etiquetaplural"": ""Claves de operaciones"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""953e3b4c-09d4-4c99-8890-0e9caf431c4b"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Clave de operación"",""descripcion"": """",""keyword"": ""ReferenciaClaveDeOperacion"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaClaveDeOperacion As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaClaveDeOperacion
          <DisplayName("Establecer manualmente las cuotas de impuestos")>
          Public Property EstablecerManualmenteLasCuotasDeImpuestos As Boolean
          Public Shared ___EstablecerManualmenteLasCuotasDeImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EstablecerManualmenteLasCuotasDeImpuestos"",""etiqueta"": ""Establecer manualmente las cuotas de impuestos"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Establecer manualmente las cuotas de impuestos"",""descripcion"": """",""keyword"": ""EstablecerManualmenteLasCuotasDeImpuestos"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EstablecerManualmenteLasCuotasDeImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___EstablecerManualmenteLasCuotasDeImpuestos
          <DisplayName("Subtotal Deducible IVA")>
          Public Property ImporteSubtotalDeducibleIVA As Decimal
          Public Shared ___ImporteSubtotalDeducibleIVA As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSubtotalDeducibleIVA"",""etiqueta"": ""Subtotal Deducible IVA"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Subtotal Deducible IVA"",""descripcion"": """",""keyword"": ""ImporteSubtotalDeducibleIVA"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSubtotalDeducibleIVA As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSubtotalDeducibleIVA
          <DisplayName("Subtotal Deducible IRPF")>
          Public Property ImporteSubtotalDeducibleIRPF As Decimal
          Public Shared ___ImporteSubtotalDeducibleIRPF As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSubtotalDeducibleIRPF"",""etiqueta"": ""Subtotal Deducible IRPF"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Subtotal Deducible IRPF"",""descripcion"": """",""keyword"": ""ImporteSubtotalDeducibleIRPF"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSubtotalDeducibleIRPF As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSubtotalDeducibleIRPF
          <DisplayName("Asignar manualmente la fecha contable")>
          Public Property AsignarManualmenteLaFechaContable As Boolean
          Public Shared ___AsignarManualmenteLaFechaContable As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AsignarManualmenteLaFechaContable"",""etiqueta"": ""Asignar manualmente la fecha contable"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 103,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Asignar manualmente la fecha contable"",""descripcion"": """",""keyword"": ""AsignarManualmenteLaFechaContable"",""formato"": 1,""rol"": 103,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AsignarManualmenteLaFechaContable As DinaNETCore.APID.DinaupAPI_CampoC = ___AsignarManualmenteLaFechaContable
          <DisplayName("Reto. Capital Mobiliario")>
          Public Property ReferenciaRetoCapitalMobiliario As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaRetoCapitalMobiliario As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaRetoCapitalMobiliario"",""etiqueta"": ""Reto. Capital Mobiliario"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""06d82973-f218-402f-99c2-20ec1daf9f2e"",""titulo"": ""Base - Tipos Retenciones capital mobiliario"",""iconoid"": ""0c37e868-6de8-4254-b6c9-655c204b2949"",""etiquetasingular"": ""Tipo retención capital mobiliario"",""etiquetaplural"": ""Tipos Retenciones capital mobiliario"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""06d82973-f218-402f-99c2-20ec1daf9f2e"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Reto. Capital Mobiliario"",""descripcion"": """",""keyword"": ""ReferenciaRetoCapitalMobiliario"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaRetoCapitalMobiliario As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaRetoCapitalMobiliario
          <DisplayName("Moneda extranjera")>
          Public Property ReferenciaMonedaExtranjera As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaMonedaExtranjera As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaMonedaExtranjera"",""etiqueta"": ""Moneda extranjera"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""9aca170f-337d-4b5b-8fbe-7909230c07ee"",""titulo"": ""Base - Monedas"",""iconoid"": ""57920f46-6dfa-4a3e-ac49-44e802a5b141"",""etiquetasingular"": ""Moneda"",""etiquetaplural"": ""Monedas"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""9aca170f-337d-4b5b-8fbe-7909230c07ee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Moneda extranjera"",""descripcion"": """",""keyword"": ""ReferenciaMonedaExtranjera"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaMonedaExtranjera As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaMonedaExtranjera
          <DisplayName("Cambio moneda")>
          Public Property CambioMoneda As Decimal
          Public Shared ___CambioMoneda As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CambioMoneda"",""etiqueta"": ""Cambio moneda"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""10"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cambio moneda"",""descripcion"": """",""keyword"": ""CambioMoneda"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CambioMoneda As DinaNETCore.APID.DinaupAPI_CampoC = ___CambioMoneda
          <DisplayName("Impuestos incluidos")>
          Public Property ImpuestosIncluidos As Boolean
          Public Shared ___ImpuestosIncluidos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImpuestosIncluidos"",""etiqueta"": ""Impuestos incluidos"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Impuestos incluidos"",""descripcion"": """",""keyword"": ""ImpuestosIncluidos"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImpuestosIncluidos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImpuestosIncluidos
          <DisplayName("Tipo de Factura")>
          Public Property ReferenciaTipoDeFactura As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaTipoDeFactura As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaTipoDeFactura"",""etiqueta"": ""Tipo de Factura"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""ef5644b0-fb98-4191-908d-99594d9e1cc5"",""titulo"": ""Base - Tipos de movimiento"",""iconoid"": ""d720d25f-f5b8-4c83-a9f3-a8bf6cb31468"",""etiquetasingular"": ""Tipo de movimiento"",""etiquetaplural"": ""Tipos de movimiento"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""ef5644b0-fb98-4191-908d-99594d9e1cc5"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Tipo de Factura"",""descripcion"": """",""keyword"": ""ReferenciaTipoDeFactura"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaTipoDeFactura As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaTipoDeFactura
          <ReadOnlyAttribute(True)>
          <DisplayName("ID")>
          Public Property ID As Guid
          Public Shared ___ID As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": true,""eseliminado"": false,""keyword"": ""ID"",""etiqueta"": ""ID"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""8fac2930-c1ea-48b5-ab89-50a0725e86e2"",""titulo"": ""Compras y Gastos"",""iconoid"": ""5686dc42-beaf-4bc5-a068-97126541fa55"",""etiquetasingular"": ""Compra / Gasto"",""etiquetaplural"": ""Compras / Gastos"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""8fac2930-c1ea-48b5-ab89-50a0725e86e2"",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""ID"",""descripcion"": """",""keyword"": ""ID"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
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
          me.ReferenciaDestinador = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_300401055575"), _Datos.Leer_String("pr_300401055575.nombre"))
          me.HoraLocal = _Datos.Leer_Time_Nulable("pr_300401055570")
          me.ImporteBaseImponibleImpuesto1 = _Datos.Leer_Decimal("pr_4004010567628")
          me.ReferenciaUbicacionPrincipal = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_300401055567"), _Datos.Leer_String("pr_300401055567.nombre"))
          me.ProveedorTieneAccesoWeb = _Datos.Leer_Boolean("pr_4004010567692")
          me.ReferenciaImpuesto3 = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_4004010567684"), _Datos.Leer_String("pr_4004010567684.nombre"))
          me.ImporteTotalAPagar = _Datos.Leer_Decimal("pr_4004010567631")
          me.ImporteSumaImporteDeProductosSinImpuestos = _Datos.Leer_Decimal("pr_4004010567630")
          me.DescuentoGeneralAplicadoPorciento = _Datos.Leer_Decimal("pr_4004010567629")
          me.ReferenciaConfiguracionDeCompra = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_4004010567685"), _Datos.Leer_String("pr_4004010567685.nombre"))
          me.ImporteTotalImpuestos = _Datos.Leer_Decimal("pr_4004010567637")
          me.ImporteCuotaImpuesto1 = _Datos.Leer_Decimal("pr_4004010567635")
          me.ImporteBaseImponibleExenta = _Datos.Leer_Decimal("pr_4004010567636")
          me.DescripcionDescuentoAdicionalB = _Datos.Leer_String("pr_4004010567695")
          me.ImporteTotalPagado = _Datos.Leer_Decimal("pr_4004010567634")
          me.AutorDelAltaTieneAccesoWeb = _Datos.Leer_Boolean("pr_300401055581")
          me.ReferenciaEstado = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_4004010567688"), _Datos.Leer_String("pr_4004010567688.nombre"))
          me.ImporteDescuentosGeneralImpuesto1 = _Datos.Leer_Decimal("pr_4004010567644")
          me.ImporteBaseImponibleImpuesto3 = _Datos.Leer_Decimal("pr_4004010567642")
          me.ReferenciaRetencion = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_4004010567686"), _Datos.Leer_String("pr_4004010567686.nombre"))
          me.DescripcionDescuentoAdicionalA = _Datos.Leer_String("pr_4004010567696")
          me.ImporteSumaConceptosSinImpuestos = _Datos.Leer_Decimal("pr_4004010567640")
          me.SumaConceptosConImpuestos = _Datos.Leer_Decimal("pr_60040115043")
          me.ImporteDescuentosProductoImpuesto1 = _Datos.Leer_Decimal("pr_4004010567639")
          me.ImporteCuotaREImpuesto1 = _Datos.Leer_Decimal("pr_4004010567653")
          me.ImporteSumaDeConceptosImpuesto2 = _Datos.Leer_Decimal("pr_4004010567650")
          me.CantidadDeProductosQueDebenEntrar = _Datos.Leer_Decimal("pr_4004010567649")
          me.ImporteSumaImporteProductosConImpuestos = _Datos.Leer_Decimal("pr_4004010567648")
          me.ReferenciaPuestoDeTrabajo = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_4004010567691"), _Datos.Leer_String("pr_4004010567691.nombre"))
          me.ImporteTotalDescontadoSinImpuestos = _Datos.Leer_Decimal("pr_4004010567659")
          me.ImporteCuotaImpuesto3 = _Datos.Leer_Decimal("pr_4004010567658")
          me.ReferenciaImpuesto2 = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_4004010567690"), _Datos.Leer_String("pr_4004010567690.nombre"))
          me.DescuentoAdicionalAAplicadoPorciento = _Datos.Leer_Decimal("pr_4004010567656")
          me.ReferenciaNumeracionSerie = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_4004010567689"), _Datos.Leer_String("pr_4004010567689.nombre"))
          me.TotalPorcentajeDescuentosGeneralesPorciento = _Datos.Leer_Decimal("pr_4004010567655")
          me.ImporteDescuentosProductoImpuesto2 = _Datos.Leer_Decimal("pr_4004010567663")
          me.NumeroDeReferenciaInterna = _Datos.Leer_Integer("pr_4004010567700")
          me.DescuentoEntidadAplicadoPorciento = _Datos.Leer_Decimal("pr_4004010567674")
          me.DescuentoAdicionalBAplicadoPorciento = _Datos.Leer_Decimal("pr_4004010567673")
          me.TotalEntradosDestinador = _Datos.Leer_Decimal("pr_4004010567672")
          me.ImporteSumaDeConceptosImpuesto3 = _Datos.Leer_Decimal("pr_4004010567669")
          me.ImporteImporteRetencion = _Datos.Leer_Decimal("pr_4004010567668")
          me.ReferenciaEmpleadoPrincipal = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_300401055566"), _Datos.Leer_String("pr_300401055566.nombre"))
          me.EmpleadoTieneAccesoWeb = _Datos.Leer_Boolean("pr_300401055584")
          me.ImporteBaseImponibleImpuesto2 = _Datos.Leer_Decimal("pr_4004010567598")
          me.FechaDato_UTC = _Datos.Leer_DateTime_Nulable("pr_300401055569")
          me.ImporteSumaDeConceptosImpuestoExentos = _Datos.Leer_Decimal("pr_4004010567602")
          me.FechaAlta_UTC = _Datos.Leer_DateTime_Nulable("pr_300401055572")
          me.ImporteCuotaREImpuesto3 = _Datos.Leer_Decimal("pr_4004010567610")
          me.Observaciones = _Datos.Leer_String("pr_4004010567693")
          me.ImporteTotal = _Datos.Leer_Decimal("pr_4004010567608")
          me.ImporteTotalDeduccionIVA = _Datos.Leer_Decimal("pr_4004010567606")
          me.ImporteCuotaREImpuesto2 = _Datos.Leer_Decimal("pr_4004010567605")
          me.ImporteDescuentosGeneralImpuesto2 = _Datos.Leer_Decimal("pr_4004010567604")
          me.ImporteSumaDeConceptosImpuesto1 = _Datos.Leer_Decimal("pr_4004010567612")
          me.NumeroDeReferenciaInternaCompleto = _Datos.Leer_String("pr_4004010567694")
          me.ReferenciaPresupuestoDeCompra = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_20040105794"), _Datos.Leer_String("pr_20040105794.nombre"))
          me.TotalDevueltosDestinadores = _Datos.Leer_Decimal("pr_4004010567615")
          me.ImporteSubtotal = _Datos.Leer_Decimal("pr_4004010567614")
          me.ImporteDescuentosProductoImpuesto3 = _Datos.Leer_Decimal("pr_4004010567620")
          me.ImporteDescuentosProductoExento = _Datos.Leer_Decimal("pr_4004010567618")
          me.ReferenciaImpuesto1 = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_4004010567680"), _Datos.Leer_String("pr_4004010567680.nombre"))
          me.ImporteDescuentoGeneralImpuestoExento = _Datos.Leer_Decimal("pr_4004010567617")
          me.CantidadDeProductosQueSePuedenRectificar = _Datos.Leer_Decimal("pr_4004010567616")
          me.ReferenciaAutorDelAlta = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_300401055568"), _Datos.Leer_String("pr_300401055568.nombre"))
          me.ImporteCuotaImpuesto2 = _Datos.Leer_Decimal("pr_4004010567622")
          me.ReferenciaProveedor = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_4004010567681"), _Datos.Leer_String("pr_4004010567681.nombre"))
          me.AplicarRecargoDeEquivalencia = _Datos.Leer_Boolean("pr_4004010567706")
          me.ImporteDescuentosGeneralImpuesto3 = _Datos.Leer_Decimal("pr_4004010567626")
          me.CantidadDeProductos = _Datos.Leer_Decimal("pr_4004010567625")
          me.FechaContable = _Datos.Leer_Date_Nulable("pr_40040135702")
          me.ReferenciaAsientoContable = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_40040135291"), _Datos.Leer_String("pr_40040135291.nombre"))
          me.DireccionProveedor = _Datos.Leer_String("pr_60040138819")
          me.PaisProveedor = _Datos.Leer_String("pr_60040138817")
          me.ProvinciaProveedor = _Datos.Leer_String("pr_60040138816")
          me.CodigoPostalProveedor = _Datos.Leer_String("pr_600401388110")
          me.MunicipioProveedor = _Datos.Leer_String("pr_60040138818")
          me.PaisEmpresa = _Datos.Leer_String("pr_10040138823")
          me.DireccionEmpresa = _Datos.Leer_String("pr_10040138826")
          me.MunicipioEmpresa = _Datos.Leer_String("pr_10040138825")
          me.ReferenciaDatosFiscalesEmpresa = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_10040138827"), _Datos.Leer_String("pr_10040138827.nombre"))
          me.NIFEmpresa = _Datos.Leer_String("pr_10040138829")
          me.ReferenciaDatosFiscalesProveedor = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_60040138815"), _Datos.Leer_String("pr_60040138815.nombre"))
          me.NIFProveedor = _Datos.Leer_String("pr_600401388112")
          me.ProvinciaEmpresa = _Datos.Leer_String("pr_100401388211")
          me.TelefonoEmpresa = _Datos.Leer_String("pr_10040138824")
          me.DenominacionRazonSocialProveedor = _Datos.Leer_String("pr_600401388111")
          me.TelefonoProveedor = _Datos.Leer_String("pr_10040138822")
          me.CodigoPostalEmpresa = _Datos.Leer_String("pr_10040138828")
          me.DenominacionRazonSocialEmpresa = _Datos.Leer_String("pr_100401388210")
          me.NumeroDeFactura = _Datos.Leer_String("pr_60040145291002")
          me.ReferenciaImpuestoGeneral = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_30040148968"), _Datos.Leer_String("pr_30040148968.nombre"))
          me.ImporteImporteImpuestoGeneral = _Datos.Leer_Decimal("pr_30040148969")
          me.EsUnGastoSinFacturaObsoleto = _Datos.Leer_Boolean("pr_50040163131")
          me.MarcarComoConcluidaAunqueHayanProcesosPendientes = _Datos.Leer_Boolean("pr_50040173901")
          me.CondicionDePagoDias = _Datos.Leer_Integer("pr_40040176522")
          me.CondicionesDePago = _Datos.Leer_String("pr_40040176524")
          me.FechaDeVencimiento = _Datos.Leer_Date_Nulable("pr_40040176523")
          me.TotalSalidosDestinadores = _Datos.Leer_Decimal("pr_10040242021")
          me.RegimenEspecialDeBienesUsadosObsoleto = _Datos.Leer_Boolean("pr_50040238942")
          me.OperacionIntragrupo = _Datos.Leer_Boolean("pr_40040238924")
          me.InversionDelSujetoPasivoObsoleto = _Datos.Leer_Boolean("pr_10040238941")
          me.CodigoPaisProveedor = _Datos.Leer_String("pr_20040241542")
          me.CodigoProvinciaProveedor = _Datos.Leer_String("pr_20040241541")
          me.TipoNIFProveedor = _Datos.Leer_String("pr_20040241602")
          me.Tipo = _Datos.Leer_EnumTipoMovimientoE("pr_200402418512")
          me.ReferenciaCompraARectificar = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_200402418410"), _Datos.Leer_String("pr_200402418410.nombre"))
          me.CantidadDeProductosQueDebenSalir = _Datos.Leer_Decimal("pr_10040242022")
          me.ReferenciaArrendamiento = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_10040251095"), _Datos.Leer_String("pr_10040251095.nombre"))
          me.NIFIntracomunitarioEmpresa = _Datos.Leer_String("pr_30040255422")
          me.NIFIntracomunitarioProveedor = _Datos.Leer_String("pr_30040255421")
          me.ImporteTotalSuplidos = _Datos.Leer_Decimal("pr_60040256611")
          me.ImporteTotalOperacion = _Datos.Leer_Decimal("pr_60040256621")
          me.ReferenciaActividad = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_30040256141"), _Datos.Leer_String("pr_30040256141.nombre"))
          me.BienDeInversionObsoleto = _Datos.Leer_Boolean("pr_20040256992")
          me.ReferenciaClaveDeOperacion = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_20040256991"), _Datos.Leer_String("pr_20040256991.nombre"))
          me.EstablecerManualmenteLasCuotasDeImpuestos = _Datos.Leer_Boolean("pr_10040259131")
          me.ImporteSubtotalDeducibleIVA = _Datos.Leer_Decimal("pr_40040258811")
          me.ImporteSubtotalDeducibleIRPF = _Datos.Leer_Decimal("pr_30040260241")
          me.AsignarManualmenteLaFechaContable = _Datos.Leer_Boolean("pr_10040268922")
          me.ReferenciaRetoCapitalMobiliario = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_50040281131"), _Datos.Leer_String("pr_50040281131.nombre"))
          me.ReferenciaMonedaExtranjera = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_10040454262"), _Datos.Leer_String("pr_10040454262.nombre"))
          me.CambioMoneda = _Datos.Leer_Decimal("pr_10040454261")
          me.ImpuestosIncluidos = _Datos.Leer_Boolean("pr_4004010567704")
          me.ReferenciaTipoDeFactura = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_4004010567677"), _Datos.Leer_String("pr_4004010567677.nombre"))
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
           R.add("pr_300401055575",me.ReferenciaDestinador.ID.STR())
         Else
           R.add("pr_300401055575","")
         End if
         R.add("pr_300401055570", me.HoraLocal.AdaptarMySQL_Time_Nulable())
         R.add("pr_4004010567628", me.ImporteBaseImponibleImpuesto1.AdaptarMySQL_Decimal())
         If Me.ReferenciaUbicacionPrincipal IsNot nothing then
           R.add("pr_300401055567",me.ReferenciaUbicacionPrincipal.ID.STR())
         Else
           R.add("pr_300401055567","")
         End if
         R.add("pr_4004010567692", me.ProveedorTieneAccesoWeb.AdaptarMySQL_Boolean())
         If Me.ReferenciaImpuesto3 IsNot nothing then
           R.add("pr_4004010567684",me.ReferenciaImpuesto3.ID.STR())
         Else
           R.add("pr_4004010567684","")
         End if
         R.add("pr_4004010567631", me.ImporteTotalAPagar.AdaptarMySQL_Decimal())
         R.add("pr_4004010567630", me.ImporteSumaImporteDeProductosSinImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_4004010567629", me.DescuentoGeneralAplicadoPorciento.AdaptarMySQL_Decimal())
         If Me.ReferenciaConfiguracionDeCompra IsNot nothing then
           R.add("pr_4004010567685",me.ReferenciaConfiguracionDeCompra.ID.STR())
         Else
           R.add("pr_4004010567685","")
         End if
         R.add("pr_4004010567637", me.ImporteTotalImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_4004010567635", me.ImporteCuotaImpuesto1.AdaptarMySQL_Decimal())
         R.add("pr_4004010567636", me.ImporteBaseImponibleExenta.AdaptarMySQL_Decimal())
         R.add("pr_4004010567695", me.DescripcionDescuentoAdicionalB.AdaptarMySQL_String())
         R.add("pr_4004010567634", me.ImporteTotalPagado.AdaptarMySQL_Decimal())
         R.add("pr_300401055581", me.AutorDelAltaTieneAccesoWeb.AdaptarMySQL_Boolean())
         If Me.ReferenciaEstado IsNot nothing then
           R.add("pr_4004010567688",me.ReferenciaEstado.ID.STR())
         Else
           R.add("pr_4004010567688","")
         End if
         R.add("pr_4004010567644", me.ImporteDescuentosGeneralImpuesto1.AdaptarMySQL_Decimal())
         R.add("pr_4004010567642", me.ImporteBaseImponibleImpuesto3.AdaptarMySQL_Decimal())
         If Me.ReferenciaRetencion IsNot nothing then
           R.add("pr_4004010567686",me.ReferenciaRetencion.ID.STR())
         Else
           R.add("pr_4004010567686","")
         End if
         R.add("pr_4004010567696", me.DescripcionDescuentoAdicionalA.AdaptarMySQL_String())
         R.add("pr_4004010567640", me.ImporteSumaConceptosSinImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_60040115043", me.SumaConceptosConImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_4004010567639", me.ImporteDescuentosProductoImpuesto1.AdaptarMySQL_Decimal())
         R.add("pr_4004010567653", me.ImporteCuotaREImpuesto1.AdaptarMySQL_Decimal())
         R.add("pr_4004010567650", me.ImporteSumaDeConceptosImpuesto2.AdaptarMySQL_Decimal())
         R.add("pr_4004010567649", me.CantidadDeProductosQueDebenEntrar.AdaptarMySQL_Decimal())
         R.add("pr_4004010567648", me.ImporteSumaImporteProductosConImpuestos.AdaptarMySQL_Decimal())
         If Me.ReferenciaPuestoDeTrabajo IsNot nothing then
           R.add("pr_4004010567691",me.ReferenciaPuestoDeTrabajo.ID.STR())
         Else
           R.add("pr_4004010567691","")
         End if
         R.add("pr_4004010567659", me.ImporteTotalDescontadoSinImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_4004010567658", me.ImporteCuotaImpuesto3.AdaptarMySQL_Decimal())
         If Me.ReferenciaImpuesto2 IsNot nothing then
           R.add("pr_4004010567690",me.ReferenciaImpuesto2.ID.STR())
         Else
           R.add("pr_4004010567690","")
         End if
         R.add("pr_4004010567656", me.DescuentoAdicionalAAplicadoPorciento.AdaptarMySQL_Decimal())
         If Me.ReferenciaNumeracionSerie IsNot nothing then
           R.add("pr_4004010567689",me.ReferenciaNumeracionSerie.ID.STR())
         Else
           R.add("pr_4004010567689","")
         End if
         R.add("pr_4004010567655", me.TotalPorcentajeDescuentosGeneralesPorciento.AdaptarMySQL_Decimal())
         R.add("pr_4004010567663", me.ImporteDescuentosProductoImpuesto2.AdaptarMySQL_Decimal())
         R.add("pr_4004010567700", me.NumeroDeReferenciaInterna.AdaptarMySQL_Integer())
         R.add("pr_4004010567674", me.DescuentoEntidadAplicadoPorciento.AdaptarMySQL_Decimal())
         R.add("pr_4004010567673", me.DescuentoAdicionalBAplicadoPorciento.AdaptarMySQL_Decimal())
         R.add("pr_4004010567672", me.TotalEntradosDestinador.AdaptarMySQL_Decimal())
         R.add("pr_4004010567669", me.ImporteSumaDeConceptosImpuesto3.AdaptarMySQL_Decimal())
         R.add("pr_4004010567668", me.ImporteImporteRetencion.AdaptarMySQL_Decimal())
         If Me.ReferenciaEmpleadoPrincipal IsNot nothing then
           R.add("pr_300401055566",me.ReferenciaEmpleadoPrincipal.ID.STR())
         Else
           R.add("pr_300401055566","")
         End if
         R.add("pr_300401055584", me.EmpleadoTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_4004010567598", me.ImporteBaseImponibleImpuesto2.AdaptarMySQL_Decimal())
         R.add("pr_300401055569", me.FechaDato_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_4004010567602", me.ImporteSumaDeConceptosImpuestoExentos.AdaptarMySQL_Decimal())
         R.add("pr_300401055572", me.FechaAlta_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_4004010567610", me.ImporteCuotaREImpuesto3.AdaptarMySQL_Decimal())
         R.add("pr_4004010567693", me.Observaciones.AdaptarMySQL_String())
         R.add("pr_4004010567608", me.ImporteTotal.AdaptarMySQL_Decimal())
         R.add("pr_4004010567606", me.ImporteTotalDeduccionIVA.AdaptarMySQL_Decimal())
         R.add("pr_4004010567605", me.ImporteCuotaREImpuesto2.AdaptarMySQL_Decimal())
         R.add("pr_4004010567604", me.ImporteDescuentosGeneralImpuesto2.AdaptarMySQL_Decimal())
         R.add("pr_4004010567612", me.ImporteSumaDeConceptosImpuesto1.AdaptarMySQL_Decimal())
         R.add("pr_4004010567694", me.NumeroDeReferenciaInternaCompleto.AdaptarMySQL_String())
         If Me.ReferenciaPresupuestoDeCompra IsNot nothing then
           R.add("pr_20040105794",me.ReferenciaPresupuestoDeCompra.ID.STR())
         Else
           R.add("pr_20040105794","")
         End if
         R.add("pr_4004010567615", me.TotalDevueltosDestinadores.AdaptarMySQL_Decimal())
         R.add("pr_4004010567614", me.ImporteSubtotal.AdaptarMySQL_Decimal())
         R.add("pr_4004010567620", me.ImporteDescuentosProductoImpuesto3.AdaptarMySQL_Decimal())
         R.add("pr_4004010567618", me.ImporteDescuentosProductoExento.AdaptarMySQL_Decimal())
         If Me.ReferenciaImpuesto1 IsNot nothing then
           R.add("pr_4004010567680",me.ReferenciaImpuesto1.ID.STR())
         Else
           R.add("pr_4004010567680","")
         End if
         R.add("pr_4004010567617", me.ImporteDescuentoGeneralImpuestoExento.AdaptarMySQL_Decimal())
         R.add("pr_4004010567616", me.CantidadDeProductosQueSePuedenRectificar.AdaptarMySQL_Decimal())
         If Me.ReferenciaAutorDelAlta IsNot nothing then
           R.add("pr_300401055568",me.ReferenciaAutorDelAlta.ID.STR())
         Else
           R.add("pr_300401055568","")
         End if
         R.add("pr_4004010567622", me.ImporteCuotaImpuesto2.AdaptarMySQL_Decimal())
         If Me.ReferenciaProveedor IsNot nothing then
           R.add("pr_4004010567681",me.ReferenciaProveedor.ID.STR())
         Else
           R.add("pr_4004010567681","")
         End if
         R.add("pr_4004010567706", me.AplicarRecargoDeEquivalencia.AdaptarMySQL_Boolean())
         R.add("pr_4004010567626", me.ImporteDescuentosGeneralImpuesto3.AdaptarMySQL_Decimal())
         R.add("pr_4004010567625", me.CantidadDeProductos.AdaptarMySQL_Decimal())
         R.add("pr_40040135702", me.FechaContable.AdaptarMySQL_Date_Nulable())
         If Me.ReferenciaAsientoContable IsNot nothing then
           R.add("pr_40040135291",me.ReferenciaAsientoContable.ID.STR())
         Else
           R.add("pr_40040135291","")
         End if
         R.add("pr_60040138819", me.DireccionProveedor.AdaptarMySQL_String())
         R.add("pr_60040138817", me.PaisProveedor.AdaptarMySQL_String())
         R.add("pr_60040138816", me.ProvinciaProveedor.AdaptarMySQL_String())
         R.add("pr_600401388110", me.CodigoPostalProveedor.AdaptarMySQL_String())
         R.add("pr_60040138818", me.MunicipioProveedor.AdaptarMySQL_String())
         R.add("pr_10040138823", me.PaisEmpresa.AdaptarMySQL_String())
         R.add("pr_10040138826", me.DireccionEmpresa.AdaptarMySQL_String())
         R.add("pr_10040138825", me.MunicipioEmpresa.AdaptarMySQL_String())
         If Me.ReferenciaDatosFiscalesEmpresa IsNot nothing then
           R.add("pr_10040138827",me.ReferenciaDatosFiscalesEmpresa.ID.STR())
         Else
           R.add("pr_10040138827","")
         End if
         R.add("pr_10040138829", me.NIFEmpresa.AdaptarMySQL_String())
         If Me.ReferenciaDatosFiscalesProveedor IsNot nothing then
           R.add("pr_60040138815",me.ReferenciaDatosFiscalesProveedor.ID.STR())
         Else
           R.add("pr_60040138815","")
         End if
         R.add("pr_600401388112", me.NIFProveedor.AdaptarMySQL_String())
         R.add("pr_100401388211", me.ProvinciaEmpresa.AdaptarMySQL_String())
         R.add("pr_10040138824", me.TelefonoEmpresa.AdaptarMySQL_String())
         R.add("pr_600401388111", me.DenominacionRazonSocialProveedor.AdaptarMySQL_String())
         R.add("pr_10040138822", me.TelefonoProveedor.AdaptarMySQL_String())
         R.add("pr_10040138828", me.CodigoPostalEmpresa.AdaptarMySQL_String())
         R.add("pr_100401388210", me.DenominacionRazonSocialEmpresa.AdaptarMySQL_String())
         R.add("pr_60040145291002", me.NumeroDeFactura.AdaptarMySQL_String())
         If Me.ReferenciaImpuestoGeneral IsNot nothing then
           R.add("pr_30040148968",me.ReferenciaImpuestoGeneral.ID.STR())
         Else
           R.add("pr_30040148968","")
         End if
         R.add("pr_30040148969", me.ImporteImporteImpuestoGeneral.AdaptarMySQL_Decimal())
         R.add("pr_50040163131", me.EsUnGastoSinFacturaObsoleto.AdaptarMySQL_Boolean())
         R.add("pr_50040173901", me.MarcarComoConcluidaAunqueHayanProcesosPendientes.AdaptarMySQL_Boolean())
         R.add("pr_40040176522", me.CondicionDePagoDias.AdaptarMySQL_Integer())
         R.add("pr_40040176524", me.CondicionesDePago.AdaptarMySQL_String())
         R.add("pr_40040176523", me.FechaDeVencimiento.AdaptarMySQL_Date_Nulable())
         R.add("pr_10040242021", me.TotalSalidosDestinadores.AdaptarMySQL_Decimal())
         R.add("pr_50040238942", me.RegimenEspecialDeBienesUsadosObsoleto.AdaptarMySQL_Boolean())
         R.add("pr_40040238924", me.OperacionIntragrupo.AdaptarMySQL_Boolean())
         R.add("pr_10040238941", me.InversionDelSujetoPasivoObsoleto.AdaptarMySQL_Boolean())
         R.add("pr_20040241542", me.CodigoPaisProveedor.AdaptarMySQL_String())
         R.add("pr_20040241541", me.CodigoProvinciaProveedor.AdaptarMySQL_String())
         R.add("pr_20040241602", me.TipoNIFProveedor.AdaptarMySQL_String())
         R.add("pr_200402418512", me.Tipo.AdaptarMySQL_EnumTipoMovimientoE())
         If Me.ReferenciaCompraARectificar IsNot nothing then
           R.add("pr_200402418410",me.ReferenciaCompraARectificar.ID.STR())
         Else
           R.add("pr_200402418410","")
         End if
         R.add("pr_10040242022", me.CantidadDeProductosQueDebenSalir.AdaptarMySQL_Decimal())
         If Me.ReferenciaArrendamiento IsNot nothing then
           R.add("pr_10040251095",me.ReferenciaArrendamiento.ID.STR())
         Else
           R.add("pr_10040251095","")
         End if
         R.add("pr_30040255422", me.NIFIntracomunitarioEmpresa.AdaptarMySQL_String())
         R.add("pr_30040255421", me.NIFIntracomunitarioProveedor.AdaptarMySQL_String())
         R.add("pr_60040256611", me.ImporteTotalSuplidos.AdaptarMySQL_Decimal())
         R.add("pr_60040256621", me.ImporteTotalOperacion.AdaptarMySQL_Decimal())
         If Me.ReferenciaActividad IsNot nothing then
           R.add("pr_30040256141",me.ReferenciaActividad.ID.STR())
         Else
           R.add("pr_30040256141","")
         End if
         R.add("pr_20040256992", me.BienDeInversionObsoleto.AdaptarMySQL_Boolean())
         If Me.ReferenciaClaveDeOperacion IsNot nothing then
           R.add("pr_20040256991",me.ReferenciaClaveDeOperacion.ID.STR())
         Else
           R.add("pr_20040256991","")
         End if
         R.add("pr_10040259131", me.EstablecerManualmenteLasCuotasDeImpuestos.AdaptarMySQL_Boolean())
         R.add("pr_40040258811", me.ImporteSubtotalDeducibleIVA.AdaptarMySQL_Decimal())
         R.add("pr_30040260241", me.ImporteSubtotalDeducibleIRPF.AdaptarMySQL_Decimal())
         R.add("pr_10040268922", me.AsignarManualmenteLaFechaContable.AdaptarMySQL_Boolean())
         If Me.ReferenciaRetoCapitalMobiliario IsNot nothing then
           R.add("pr_50040281131",me.ReferenciaRetoCapitalMobiliario.ID.STR())
         Else
           R.add("pr_50040281131","")
         End if
         If Me.ReferenciaMonedaExtranjera IsNot nothing then
           R.add("pr_10040454262",me.ReferenciaMonedaExtranjera.ID.STR())
         Else
           R.add("pr_10040454262","")
         End if
         R.add("pr_10040454261", me.CambioMoneda.AdaptarMySQL_Decimal())
         R.add("pr_4004010567704", me.ImpuestosIncluidos.AdaptarMySQL_Boolean())
         If Me.ReferenciaTipoDeFactura IsNot nothing then
           R.add("pr_4004010567677",me.ReferenciaTipoDeFactura.ID.STR())
         Else
           R.add("pr_4004010567677","")
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
      Public Class ComprasYGastos_FormularioC
        Inherits DinaNETCore.VentanaVirtualC

    Public _Lista As List(Of ComprasYGastosListaD.ComprasYGastosLista_FormularioC)



    Overrides Sub Evento_Actualizar()

        If Me.EsListador Then
            Dim FormLista = Me.__VV__.Formularios_Lista
            Dim CreandoLista As New List(Of ComprasYGastosListaD.ComprasYGastosLista_FormularioC)
            If FormLista IsNot Nothing Then
                For i = 0 To FormLista.Count - 1
                    Dim ElementoLista As New ComprasYGastosListaD.ComprasYGastosLista_FormularioC(Me.__VV__, FormLista(i).Token)
                    CreandoLista.Add(ElementoLista)
                Next
            End If
            _Lista = CreandoLista
        End If

    End Sub

                  


        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_300401055575")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As DateTime
            get
                return me.GetValue_DateTime("pr_300401055570")
            End Get   
        End Property
        Public ReadOnly property ImporteBaseImponibleImpuesto1 As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567628")
            End Get   
        End Property
          Public property ReferenciaUbicacionPrincipal As Guid
            get
                return me.GetValue_Guid("pr_300401055567")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_300401055567", value)
            End Set
          End Property
          Public property ProveedorTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_4004010567692")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_4004010567692", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaImpuesto3 As Guid
            get
                return me.GetValue_Guid("pr_4004010567684")
            End Get   
        End Property
        Public ReadOnly property ImporteTotalAPagar As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567631")
            End Get   
        End Property
        Public ReadOnly property ImporteSumaImporteDeProductosSinImpuestos As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567630")
            End Get   
        End Property
          Public property DescuentoGeneralAplicadoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567629")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_4004010567629", value)
            End Set
          End Property
          Public property ReferenciaConfiguracionDeCompra As Guid
            get
                return me.GetValue_Guid("pr_4004010567685")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_4004010567685", value)
            End Set
          End Property
        Public ReadOnly property ImporteTotalImpuestos As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567637")
            End Get   
        End Property
          Public property ImporteCuotaImpuesto1 As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567635")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_4004010567635", value)
            End Set
          End Property
        Public ReadOnly property ImporteBaseImponibleExenta As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567636")
            End Get   
        End Property
          Public property DescripcionDescuentoAdicionalB As String
            get
                return me.GetValue_String("pr_4004010567695")
            End Get
            Set(value As String)
                me.SetValue_String("pr_4004010567695", value)
            End Set
          End Property
        Public ReadOnly property ImporteTotalPagado As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567634")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_300401055581")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_300401055581", value)
            End Set
          End Property
          Public property ReferenciaEstado As Guid
            get
                return me.GetValue_Guid("pr_4004010567688")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_4004010567688", value)
            End Set
          End Property
        Public ReadOnly property ImporteDescuentosGeneralImpuesto1 As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567644")
            End Get   
        End Property
        Public ReadOnly property ImporteBaseImponibleImpuesto3 As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567642")
            End Get   
        End Property
          Public property ReferenciaRetencion As Guid
            get
                return me.GetValue_Guid("pr_4004010567686")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_4004010567686", value)
            End Set
          End Property
          Public property DescripcionDescuentoAdicionalA As String
            get
                return me.GetValue_String("pr_4004010567696")
            End Get
            Set(value As String)
                me.SetValue_String("pr_4004010567696", value)
            End Set
          End Property
        Public ReadOnly property ImporteSumaConceptosSinImpuestos As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567640")
            End Get   
        End Property
        Public ReadOnly property SumaConceptosConImpuestos As Decimal
            get
                return me.GetValue_Decimal("pr_60040115043")
            End Get   
        End Property
        Public ReadOnly property ImporteDescuentosProductoImpuesto1 As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567639")
            End Get   
        End Property
          Public property ImporteCuotaREImpuesto1 As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567653")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_4004010567653", value)
            End Set
          End Property
        Public ReadOnly property ImporteSumaDeConceptosImpuesto2 As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567650")
            End Get   
        End Property
        Public ReadOnly property CantidadDeProductosQueDebenEntrar As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567649")
            End Get   
        End Property
        Public ReadOnly property ImporteSumaImporteProductosConImpuestos As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567648")
            End Get   
        End Property
          Public property ReferenciaPuestoDeTrabajo As Guid
            get
                return me.GetValue_Guid("pr_4004010567691")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_4004010567691", value)
            End Set
          End Property
        Public ReadOnly property ImporteTotalDescontadoSinImpuestos As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567659")
            End Get   
        End Property
          Public property ImporteCuotaImpuesto3 As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567658")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_4004010567658", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaImpuesto2 As Guid
            get
                return me.GetValue_Guid("pr_4004010567690")
            End Get   
        End Property
          Public property DescuentoAdicionalAAplicadoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567656")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_4004010567656", value)
            End Set
          End Property
          Public property ReferenciaNumeracionSerie As Guid
            get
                return me.GetValue_Guid("pr_4004010567689")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_4004010567689", value)
            End Set
          End Property
        Public ReadOnly property TotalPorcentajeDescuentosGeneralesPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567655")
            End Get   
        End Property
        Public ReadOnly property ImporteDescuentosProductoImpuesto2 As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567663")
            End Get   
        End Property
          Public property NumeroDeReferenciaInterna As Integer
            get
                return me.GetValue_Int("pr_4004010567700")
            End Get
            Set(value As Integer)
                me.SetValue_Int("pr_4004010567700", value)
            End Set
          End Property
          Public property DescuentoEntidadAplicadoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567674")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_4004010567674", value)
            End Set
          End Property
          Public property DescuentoAdicionalBAplicadoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567673")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_4004010567673", value)
            End Set
          End Property
        Public ReadOnly property TotalEntradosDestinador As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567672")
            End Get   
        End Property
        Public ReadOnly property ImporteSumaDeConceptosImpuesto3 As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567669")
            End Get   
        End Property
        Public ReadOnly property ImporteImporteRetencion As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567668")
            End Get   
        End Property
          Public property ReferenciaEmpleadoPrincipal As Guid
            get
                return me.GetValue_Guid("pr_300401055566")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_300401055566", value)
            End Set
          End Property
          Public property EmpleadoTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_300401055584")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_300401055584", value)
            End Set
          End Property
        Public ReadOnly property ImporteBaseImponibleImpuesto2 As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567598")
            End Get   
        End Property
          Public property FechaDato_UTC As Date
            get
                return me.GetValue_DateTime("pr_300401055569")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_300401055569", value)
            End Set
          End Property
        Public ReadOnly property ImporteSumaDeConceptosImpuestoExentos As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567602")
            End Get   
        End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_300401055572")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_300401055572", value)
            End Set
          End Property
          Public property ImporteCuotaREImpuesto3 As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567610")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_4004010567610", value)
            End Set
          End Property
          Public property Observaciones As String
            get
                return me.GetValue_String("pr_4004010567693")
            End Get
            Set(value As String)
                me.SetValue_String("pr_4004010567693", value)
            End Set
          End Property
        Public ReadOnly property ImporteTotal As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567608")
            End Get   
        End Property
        Public ReadOnly property ImporteTotalDeduccionIVA As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567606")
            End Get   
        End Property
          Public property ImporteCuotaREImpuesto2 As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567605")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_4004010567605", value)
            End Set
          End Property
        Public ReadOnly property ImporteDescuentosGeneralImpuesto2 As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567604")
            End Get   
        End Property
        Public ReadOnly property ImporteSumaDeConceptosImpuesto1 As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567612")
            End Get   
        End Property
          Public property NumeroDeReferenciaInternaCompleto As String
            get
                return me.GetValue_String("pr_4004010567694")
            End Get
            Set(value As String)
                me.SetValue_String("pr_4004010567694", value)
            End Set
          End Property
          Public property ReferenciaPresupuestoDeCompra As Guid
            get
                return me.GetValue_Guid("pr_20040105794")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_20040105794", value)
            End Set
          End Property
        Public ReadOnly property TotalDevueltosDestinadores As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567615")
            End Get   
        End Property
        Public ReadOnly property ImporteSubtotal As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567614")
            End Get   
        End Property
        Public ReadOnly property ImporteDescuentosProductoImpuesto3 As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567620")
            End Get   
        End Property
        Public ReadOnly property ImporteDescuentosProductoExento As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567618")
            End Get   
        End Property
        Public ReadOnly property ReferenciaImpuesto1 As Guid
            get
                return me.GetValue_Guid("pr_4004010567680")
            End Get   
        End Property
        Public ReadOnly property ImporteDescuentoGeneralImpuestoExento As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567617")
            End Get   
        End Property
        Public ReadOnly property CantidadDeProductosQueSePuedenRectificar As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567616")
            End Get   
        End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_300401055568")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_300401055568", value)
            End Set
          End Property
          Public property ImporteCuotaImpuesto2 As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567622")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_4004010567622", value)
            End Set
          End Property
          Public property ReferenciaProveedor As Guid
            get
                return me.GetValue_Guid("pr_4004010567681")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_4004010567681", value)
            End Set
          End Property
          Public property AplicarRecargoDeEquivalencia As Boolean
            get
                return me.GetValue_Boolean("pr_4004010567706")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_4004010567706", value)
            End Set
          End Property
        Public ReadOnly property ImporteDescuentosGeneralImpuesto3 As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567626")
            End Get   
        End Property
        Public ReadOnly property CantidadDeProductos As Decimal
            get
                return me.GetValue_Decimal("pr_4004010567625")
            End Get   
        End Property
          Public property FechaContable As Date
            get
                return me.GetValue_Date("pr_40040135702")
            End Get
            Set(value As Date)
                me.SetValue_Date("pr_40040135702", value)
            End Set
          End Property
          Public property ReferenciaAsientoContable As Guid
            get
                return me.GetValue_Guid("pr_40040135291")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_40040135291", value)
            End Set
          End Property
          Public property DireccionProveedor As String
            get
                return me.GetValue_String("pr_60040138819")
            End Get
            Set(value As String)
                me.SetValue_String("pr_60040138819", value)
            End Set
          End Property
          Public property PaisProveedor As String
            get
                return me.GetValue_String("pr_60040138817")
            End Get
            Set(value As String)
                me.SetValue_String("pr_60040138817", value)
            End Set
          End Property
          Public property ProvinciaProveedor As String
            get
                return me.GetValue_String("pr_60040138816")
            End Get
            Set(value As String)
                me.SetValue_String("pr_60040138816", value)
            End Set
          End Property
          Public property CodigoPostalProveedor As String
            get
                return me.GetValue_String("pr_600401388110")
            End Get
            Set(value As String)
                me.SetValue_String("pr_600401388110", value)
            End Set
          End Property
          Public property MunicipioProveedor As String
            get
                return me.GetValue_String("pr_60040138818")
            End Get
            Set(value As String)
                me.SetValue_String("pr_60040138818", value)
            End Set
          End Property
          Public property PaisEmpresa As String
            get
                return me.GetValue_String("pr_10040138823")
            End Get
            Set(value As String)
                me.SetValue_String("pr_10040138823", value)
            End Set
          End Property
          Public property DireccionEmpresa As String
            get
                return me.GetValue_String("pr_10040138826")
            End Get
            Set(value As String)
                me.SetValue_String("pr_10040138826", value)
            End Set
          End Property
          Public property MunicipioEmpresa As String
            get
                return me.GetValue_String("pr_10040138825")
            End Get
            Set(value As String)
                me.SetValue_String("pr_10040138825", value)
            End Set
          End Property
          Public property ReferenciaDatosFiscalesEmpresa As Guid
            get
                return me.GetValue_Guid("pr_10040138827")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_10040138827", value)
            End Set
          End Property
          Public property NIFEmpresa As String
            get
                return me.GetValue_String("pr_10040138829")
            End Get
            Set(value As String)
                me.SetValue_String("pr_10040138829", value)
            End Set
          End Property
          Public property ReferenciaDatosFiscalesProveedor As Guid
            get
                return me.GetValue_Guid("pr_60040138815")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_60040138815", value)
            End Set
          End Property
          Public property NIFProveedor As String
            get
                return me.GetValue_String("pr_600401388112")
            End Get
            Set(value As String)
                me.SetValue_String("pr_600401388112", value)
            End Set
          End Property
          Public property ProvinciaEmpresa As String
            get
                return me.GetValue_String("pr_100401388211")
            End Get
            Set(value As String)
                me.SetValue_String("pr_100401388211", value)
            End Set
          End Property
          Public property TelefonoEmpresa As String
            get
                return me.GetValue_String("pr_10040138824")
            End Get
            Set(value As String)
                me.SetValue_String("pr_10040138824", value)
            End Set
          End Property
          Public property DenominacionRazonSocialProveedor As String
            get
                return me.GetValue_String("pr_600401388111")
            End Get
            Set(value As String)
                me.SetValue_String("pr_600401388111", value)
            End Set
          End Property
          Public property TelefonoProveedor As String
            get
                return me.GetValue_String("pr_10040138822")
            End Get
            Set(value As String)
                me.SetValue_String("pr_10040138822", value)
            End Set
          End Property
          Public property CodigoPostalEmpresa As String
            get
                return me.GetValue_String("pr_10040138828")
            End Get
            Set(value As String)
                me.SetValue_String("pr_10040138828", value)
            End Set
          End Property
          Public property DenominacionRazonSocialEmpresa As String
            get
                return me.GetValue_String("pr_100401388210")
            End Get
            Set(value As String)
                me.SetValue_String("pr_100401388210", value)
            End Set
          End Property
          Public property NumeroDeFactura As String
            get
                return me.GetValue_String("pr_60040145291002")
            End Get
            Set(value As String)
                me.SetValue_String("pr_60040145291002", value)
            End Set
          End Property
          Public property ReferenciaImpuestoGeneral As Guid
            get
                return me.GetValue_Guid("pr_30040148968")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_30040148968", value)
            End Set
          End Property
        Public ReadOnly property ImporteImporteImpuestoGeneral As Decimal
            get
                return me.GetValue_Decimal("pr_30040148969")
            End Get   
        End Property
          Public property EsUnGastoSinFacturaObsoleto As Boolean
            get
                return me.GetValue_Boolean("pr_50040163131")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_50040163131", value)
            End Set
          End Property
          Public property MarcarComoConcluidaAunqueHayanProcesosPendientes As Boolean
            get
                return me.GetValue_Boolean("pr_50040173901")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_50040173901", value)
            End Set
          End Property
          Public property CondicionDePagoDias As Integer
            get
                return me.GetValue_Int("pr_40040176522")
            End Get
            Set(value As Integer)
                me.SetValue_Int("pr_40040176522", value)
            End Set
          End Property
          Public property CondicionesDePago As String
            get
                return me.GetValue_String("pr_40040176524")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040176524", value)
            End Set
          End Property
          Public property FechaDeVencimiento As Date
            get
                return me.GetValue_Date("pr_40040176523")
            End Get
            Set(value As Date)
                me.SetValue_Date("pr_40040176523", value)
            End Set
          End Property
          Public property TotalSalidosDestinadores As Decimal
            get
                return me.GetValue_Decimal("pr_10040242021")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_10040242021", value)
            End Set
          End Property
          Public property RegimenEspecialDeBienesUsadosObsoleto As Boolean
            get
                return me.GetValue_Boolean("pr_50040238942")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_50040238942", value)
            End Set
          End Property
          Public property OperacionIntragrupo As Boolean
            get
                return me.GetValue_Boolean("pr_40040238924")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_40040238924", value)
            End Set
          End Property
          Public property InversionDelSujetoPasivoObsoleto As Boolean
            get
                return me.GetValue_Boolean("pr_10040238941")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_10040238941", value)
            End Set
          End Property
          Public property CodigoPaisProveedor As String
            get
                return me.GetValue_String("pr_20040241542")
            End Get
            Set(value As String)
                me.SetValue_String("pr_20040241542", value)
            End Set
          End Property
          Public property CodigoProvinciaProveedor As String
            get
                return me.GetValue_String("pr_20040241541")
            End Get
            Set(value As String)
                me.SetValue_String("pr_20040241541", value)
            End Set
          End Property
          Public property TipoNIFProveedor As String
            get
                return me.GetValue_String("pr_20040241602")
            End Get
            Set(value As String)
                me.SetValue_String("pr_20040241602", value)
            End Set
          End Property
          Public property Tipo__Int as Integer
            get
                return me.GetValue_Int("pr_200402418512")
            End Get
            Set(value as Integer)
                me.SetValue_Int("pr_200402418512", value)
            End Set
          End Property
          Public property Tipo As EnumTipoMovimientoE
            get
                return me.GetValue_Int("pr_200402418512")
            End Get
            Set(value As EnumTipoMovimientoE)
                me.SetValue_Int("pr_200402418512", value)
            End Set
          End Property
          Public property ReferenciaCompraARectificar As Guid
            get
                return me.GetValue_Guid("pr_200402418410")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_200402418410", value)
            End Set
          End Property
          Public property CantidadDeProductosQueDebenSalir As Decimal
            get
                return me.GetValue_Decimal("pr_10040242022")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_10040242022", value)
            End Set
          End Property
          Public property ReferenciaArrendamiento As Guid
            get
                return me.GetValue_Guid("pr_10040251095")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_10040251095", value)
            End Set
          End Property
          Public property NIFIntracomunitarioEmpresa As String
            get
                return me.GetValue_String("pr_30040255422")
            End Get
            Set(value As String)
                me.SetValue_String("pr_30040255422", value)
            End Set
          End Property
          Public property NIFIntracomunitarioProveedor As String
            get
                return me.GetValue_String("pr_30040255421")
            End Get
            Set(value As String)
                me.SetValue_String("pr_30040255421", value)
            End Set
          End Property
        Public ReadOnly property ImporteTotalSuplidos As Decimal
            get
                return me.GetValue_Decimal("pr_60040256611")
            End Get   
        End Property
        Public ReadOnly property ImporteTotalOperacion As Decimal
            get
                return me.GetValue_Decimal("pr_60040256621")
            End Get   
        End Property
          Public property ReferenciaActividad As Guid
            get
                return me.GetValue_Guid("pr_30040256141")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_30040256141", value)
            End Set
          End Property
          Public property BienDeInversionObsoleto As Boolean
            get
                return me.GetValue_Boolean("pr_20040256992")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_20040256992", value)
            End Set
          End Property
          Public property ReferenciaClaveDeOperacion As Guid
            get
                return me.GetValue_Guid("pr_20040256991")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_20040256991", value)
            End Set
          End Property
          Public property EstablecerManualmenteLasCuotasDeImpuestos As Boolean
            get
                return me.GetValue_Boolean("pr_10040259131")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_10040259131", value)
            End Set
          End Property
        Public ReadOnly property ImporteSubtotalDeducibleIVA As Decimal
            get
                return me.GetValue_Decimal("pr_40040258811")
            End Get   
        End Property
        Public ReadOnly property ImporteSubtotalDeducibleIRPF As Decimal
            get
                return me.GetValue_Decimal("pr_30040260241")
            End Get   
        End Property
          Public property AsignarManualmenteLaFechaContable As Boolean
            get
                return me.GetValue_Boolean("pr_10040268922")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_10040268922", value)
            End Set
          End Property
          Public property ReferenciaRetoCapitalMobiliario As Guid
            get
                return me.GetValue_Guid("pr_50040281131")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_50040281131", value)
            End Set
          End Property
          Public property ReferenciaMonedaExtranjera As Guid
            get
                return me.GetValue_Guid("pr_10040454262")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_10040454262", value)
            End Set
          End Property
          Public property CambioMoneda As Decimal
            get
                return me.GetValue_Decimal("pr_10040454261")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_10040454261", value)
            End Set
          End Property
          Public property ImpuestosIncluidos As Boolean
            get
                return me.GetValue_Boolean("pr_4004010567704")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_4004010567704", value)
            End Set
          End Property
          Public property ReferenciaTipoDeFactura As Guid
            get
                return me.GetValue_Guid("pr_4004010567677")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_4004010567677", value)
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
