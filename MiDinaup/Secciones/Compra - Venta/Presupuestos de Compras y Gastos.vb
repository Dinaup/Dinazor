   Imports System.ComponentModel
   Imports DinaNETCore
   Imports DinaNETCore.APID
Partial Public Class SeccionesD
  Public Class PresupuestosDeComprasYGastosD
      Public Class PresupuestosDeComprasYGastos_ConListaC
      Public Listador as PresupuestosDeComprasYGastosC
      Public Lista As New List(of PresupuestosDeComprasYGastosListaD.PresupuestosDeComprasYGastosListaC)
        sub new(_listador  as PresupuestosDeComprasYGastosC, _lista as List(of PresupuestosDeComprasYGastosListaD.PresupuestosDeComprasYGastosListaC))
           me.Listador =_listador 
           me.Lista =_lista 
        End sub
      End Class
      Public Shared _SeccionID As String = "e9fd98be-d22e-4bfd-84a3-ad22df3173e3"
      Public Shared _SeccionIDGUID As New Guid("e9fd98be-d22e-4bfd-84a3-ad22df3173e3")
      Public Shared Async Function ConsultarDatos_Async(Parametros As SeccionConsultaParametrosC) As Task(Of List(Of PresupuestosDeComprasYGastosC )) 
          Dim R As New List(Of PresupuestosDeComprasYGastosC )  
          Dim d = Await Parametros.DinaupSesion.ConexionServidor.Funcion_Datos_Recibir_Async(PresupuestosDeComprasYGastosES._SeccionID, False, Parametros) 
          If d.Datos.TieneDatos Then 
              For Each Actual In d.Datos 
                  Dim Valores_Listador = Actual.Value.Item1
                  Dim Obj_Listador As New PresupuestosDeComprasYGastosC 
                  Obj_Listador.CargarDatos(Valores_Listador) 
                  Obj_Listador.CargaInterna(Actual.Value)
                  R.Add(Obj_Listador) 
              Next 
          End If 
          Return R 
      End Function 
      Public Shared Async Function ConsultarDatos_ConLista_Async(  Parametros As SeccionConsultaParametrosC ) As Task(Of List(Of  PresupuestosDeComprasYGastos_ConListaC)) 
          Dim R As New List(Of PresupuestosDeComprasYGastos_ConListaC )  
          Dim d =  Await Parametros.DinaupSesion.ConexionServidor.Funcion_Datos_Recibir_Async(PresupuestosDeComprasYGastosES._SeccionID, True, Parametros) 
          If d.Datos.TieneDatos Then 
              For Each Actual In d.Datos 
                  Dim Valores_Listador = Actual.Value.Item1
                  Dim Valores_Lista = Actual.Value.Item2
                  Dim Obj_Listador As New PresupuestosDeComprasYGastosC 
                  Obj_Listador.CargarDatos(Valores_Listador) 
                  Obj_Listador.CargaInterna(Actual.Value)
                  Dim Objs_Listas As New List(Of PresupuestosDeComprasYGastosListaD.PresupuestosDeComprasYGastosListaC) 
                  If Valores_Lista.TieneDatos Then  
                      For Each ValoresLista In Valores_Lista 
                         Dim nItem As New PresupuestosDeComprasYGastosListaD.PresupuestosDeComprasYGastosListaC 
                         nItem.CargarDatos(ValoresLista)   
                         Objs_Listas.Add(nItem)         
                      Next   
                  End If   
                  R.Add(New PresupuestosDeComprasYGastos_ConListaC(Obj_Listador, Objs_Listas))
              Next 
          End If 
          Return R 
      End Function 
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As PresupuestosDeComprasYGastosC, Optional CampoWhere$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Return Await DatosGuardar_Async(DinaupSesion, New List(Of PresupuestosDeComprasYGastosC)({DAtos}), CampoWhere )
      End Function
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As List(Of PresupuestosDeComprasYGastosC), Optional CampoWhere$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Dim Importar As New List(Of DinaupAPI_ImportacionProcesableC)
          For Each Actual In DAtos 
              Dim RegistroActual = New DinaupAPI_ImportacionProcesableC() 
               RegistroActual.dinaup_listador_datos = Actual.ToDic 
               Importar.Add(RegistroActual)  
          Next 
          Return Await DinaupSesion.ConexionServidor.Funcion_Importar_Ejecutar_Async(DinaupSesion, PresupuestosDeComprasYGastosES._SeccionID, Importar, CampoWhere, "") 
      End Function
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As PresupuestosDeComprasYGastos_ConListaC, Optional CampoWhere$ = "id", Optional CampoWhereLista$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Return Await DatosGuardar_Async(DinaupSesion, New List(Of PresupuestosDeComprasYGastos_ConListaC)({DAtos}), CampoWhere, CampoWhereLista)
      End Function
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As List(Of PresupuestosDeComprasYGastos_ConListaC), Optional CampoWhere$ = "id", Optional CampoWhereLista$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
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
          Return Await DinaupSesion.ConexionServidor.Funcion_Importar_Ejecutar_Async(DinaupSesion, PresupuestosDeComprasYGastosES._SeccionID, Importar, CampoWhere, CampoWhereLista) 
      End Function
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As PresupuestosDeComprasYGastos_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, PresupuestosDeComprasYGastosES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New PresupuestosDeComprasYGastos_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As PresupuestosDeComprasYGastos_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, PresupuestosDeComprasYGastosES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New PresupuestosDeComprasYGastos_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class PresupuestosDeComprasYGastosES
          Public shared _SeccionID as Guid = New Guid("e9fd98be-d22e-4bfd-84a3-ad22df3173e3")
          Public shared _Tabla$ = "tpr_30040105559"
      Public Shared ImporteSumaDeConceptosImpuestoExentos$ = "pr_40040105671153"
      Public Shared ImporteImporteRetencion$ = "pr_40040105671157"
      Public Shared DescuentoAdicionalAAplicadoPorciento$ = "pr_40040105671156"
      Public Shared ReferenciaDestinador$ = "pr_3004010555243"
      Public Shared ImporteDescuentosGeneralImpuesto3$ = "pr_40040105671152"
      Public Shared HoraLocal$ = "pr_3004010555238"
      Public Shared Observaciones$ = "pr_40040105671182"
      Public Shared ImporteCuotaImpuesto1$ = "pr_40040105671158"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_3004010555235"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_3004010555249"
      Public Shared DescuentoGeneralAplicadoPorciento$ = "pr_40040105671145"
      Public Shared ReferenciaProveedor$ = "pr_40040105671174"
      Public Shared ReferenciaEstado$ = "pr_40040105671175"
      Public Shared ImporteDescuentosGeneralImpuesto2$ = "pr_40040105671149"
      Public Shared ImporteTotalImpuestos$ = "pr_40040105671148"
      Public Shared ImpuestosIncluidos$ = "pr_40040105671194"
      Public Shared ImporteDescuentosGeneralImpuesto1$ = "pr_40040105671150"
      Public Shared ImporteSumaImporteProductosConImpuestos$ = "pr_40040105671146"
      Public Shared ReferenciaConfiguracionDeCompra$ = "pr_40040105671176"
      Public Shared ReferenciaImpuesto2$ = "pr_40040105671177"
      Public Shared ImporteCuotaREImpuesto3$ = "pr_40040105671147"
      Public Shared ImporteCuotaREImpuesto1$ = "pr_40040105671137"
      Public Shared ReferenciaImpuesto3$ = "pr_40040105671173"
      Public Shared NumeroDeReferenciaInternaCompleto$ = "pr_40040105671181"
      Public Shared ImporteDescuentosProductoImpuesto2$ = "pr_40040105671139"
      Public Shared DescripcionDescuentoAdicionalA$ = "pr_40040105671179"
      Public Shared ReferenciaImpuesto1$ = "pr_40040105671171"
      Public Shared ImporteDescuentosProductoExento$ = "pr_40040105671127"
      Public Shared ReferenciaPuestoDeTrabajo$ = "pr_40040105671170"
      Public Shared ImporteSumaConceptosSinImpuestos$ = "pr_40040105671123"
      Public Shared ImporteTotalDescontadoSinImpuestos$ = "pr_40040105671124"
      Public Shared DescuentoAdicionalBAplicadoPorciento$ = "pr_40040105671135"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_3004010555234"
      Public Shared CantidadDeProductos$ = "pr_40040105671128"
      Public Shared DescripcionDescuentoAdicionalB$ = "pr_40040105671180"
      Public Shared ImporteCuotaREImpuesto2$ = "pr_40040105671130"
      Public Shared TotalPorcentajeDescuentosGeneralesPorciento$ = "pr_40040105671131"
      Public Shared ImporteSumaDeConceptosImpuesto2$ = "pr_40040105671132"
      Public Shared ImporteCuotaImpuesto2$ = "pr_40040105671110"
      Public Shared CantidadDeProductosComprados$ = "pr_50040107181"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_3004010555251"
      Public Shared ImporteBaseImponibleExenta$ = "pr_40040105671108"
      Public Shared SumaConceptosConImpuestos$ = "pr_60040115045"
      Public Shared AplicarRecargoDeEquivalencia$ = "pr_40040105671192"
      Public Shared ImporteBaseImponibleImpuesto2$ = "pr_40040105671119"
      Public Shared ImporteBaseImponibleImpuesto3$ = "pr_40040105671121"
      Public Shared ReferenciaNumeracionSerie$ = "pr_40040105671169"
      Public Shared ReferenciaRetencion$ = "pr_40040105671168"
      Public Shared NumeroDeReferenciaInterna$ = "pr_40040105671186"
      Public Shared FechaAlta_UTC$ = "pr_3004010555240"
      Public Shared ImporteCuotaImpuesto3$ = "pr_40040105671113"
      Public Shared FechaDato_UTC$ = "pr_3004010555237"
      Public Shared ImporteDescuentoGeneralImpuestoExento$ = "pr_40040105671099"
      Public Shared CantidadDeProductosQueSePuedenComprar$ = "pr_50040107182"
      Public Shared ImporteSumaImporteDeProductosSinImpuestos$ = "pr_40040105671101"
      Public Shared ImporteBaseImponibleImpuesto1$ = "pr_40040105671105"
      Public Shared ImporteDescuentosProductoImpuesto1$ = "pr_40040105671103"
      Public Shared ImporteDescuentosProductoImpuesto3$ = "pr_40040105671093"
      Public Shared ImporteTotal$ = "pr_40040105671092"
      Public Shared ImporteSubtotal$ = "pr_40040105671097"
      Public Shared ReferenciaAutorDelAlta$ = "pr_3004010555236"
      Public Shared ProveedorTieneAccesoWeb$ = "pr_40040105671178"
      Public Shared ImporteSumaDeConceptosImpuesto3$ = "pr_40040105671094"
      Public Shared DescuentoEntidadAplicadoPorciento$ = "pr_40040105671084"
      Public Shared ReferenciaTipoDeFactura$ = "pr_40040105671162"
      Public Shared ImporteTotalDeduccion$ = "pr_40040105671090"
      Public Shared ImporteSumaDeConceptosImpuesto1$ = "pr_40040105671088"
      Public Shared FechaContable$ = "pr_40040135703"
      Public Shared ReferenciaDatosFiscalesProveedor$ = "pr_50040138829"
      Public Shared PaisEmpresa$ = "pr_300401388212"
      Public Shared DireccionEmpresa$ = "pr_300401388211"
      Public Shared NIFEmpresa$ = "pr_300401388215"
      Public Shared ProvinciaEmpresa$ = "pr_300401388213"
      Public Shared DenominacionRazonSocialEmpresa$ = "pr_300401388214"
      Public Shared MunicipioEmpresa$ = "pr_40040138823"
      Public Shared DenominacionRazonSocialProveedor$ = "pr_50040138825"
      Public Shared PaisProveedor$ = "pr_50040138821"
      Public Shared ProvinciaProveedor$ = "pr_50040138822"
      Public Shared TelefonoProveedor$ = "pr_50040138823"
      Public Shared MunicipioProveedor$ = "pr_50040138828"
      Public Shared CodigoPostalProveedor$ = "pr_50040138826"
      Public Shared DireccionProveedor$ = "pr_50040138827"
      Public Shared ReferenciaDatosFiscalesEmpresa$ = "pr_40040138821"
      Public Shared CodigoPostalEmpresa$ = "pr_300401388216"
      Public Shared TelefonoEmpresa$ = "pr_40040138822"
      Public Shared NIFProveedor$ = "pr_50040138824"
      Public Shared NumeroDeFactura$ = "pr_60040145291001"
      Public Shared ImporteImporteImpuestoGeneral$ = "pr_30040148966"
      Public Shared ReferenciaImpuestoGeneral$ = "pr_30040148967"
      Public Shared EsUnGastoSinFacturaObsoleto$ = "pr_30040163143"
      Public Shared MarcarComoConcluidaAunqueHayanProcesosPendientes$ = "pr_10040173912"
      Public Shared ValidoHasta$ = "pr_60040173902"
      Public Shared Anulado$ = "pr_10040173911"
      Public Shared CondicionDePagoDias$ = "pr_60040176526"
      Public Shared CondicionesDePago$ = "pr_60040176527"
      Public Shared FechaDeVencimiento$ = "pr_60040176525"
      Public Shared OperacionIntragrupoObsoleto$ = "pr_40040238926"
      Public Shared RegimenEspecialDeBienesUsadosObsoleto$ = "pr_50040238944"
      Public Shared InversionDelSujetoPasivoObsoleto$ = "pr_10040238943"
      Public Shared CodigoPaisProveedor$ = "pr_20040241546"
      Public Shared CodigoProvinciaProveedor$ = "pr_20040241545"
      Public Shared TipoNIFProveedor$ = "pr_20040241603"
      Public Shared NIFIntracomunitarioEmpresa$ = "pr_40040255422"
      Public Shared NIFIntracomunitarioProveedor$ = "pr_40040255421"
      Public Shared ImporteTotalOperacion$ = "pr_10040256633"
      Public Shared ImporteTotalSuplidos$ = "pr_10040256634"
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
      Public Class PresupuestosDeComprasYGastosC
      Inherits Base_DatoC
          <DisplayName("Suma de conceptos Impuesto Exentos")>
          Public Property ImporteSumaDeConceptosImpuestoExentos As Decimal
          Public Shared ___ImporteSumaDeConceptosImpuestoExentos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSumaDeConceptosImpuestoExentos"",""etiqueta"": ""Suma de conceptos Impuesto Exentos"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Suma de conceptos Impuesto Exentos"",""descripcion"": """",""keyword"": ""ImporteSumaDeConceptosImpuestoExentos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSumaDeConceptosImpuestoExentos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSumaDeConceptosImpuestoExentos
          <DisplayName("Importe retención")>
          Public Property ImporteImporteRetencion As Decimal
          Public Shared ___ImporteImporteRetencion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteImporteRetencion"",""etiqueta"": ""Importe retención"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Importe retención"",""descripcion"": """",""keyword"": ""ImporteImporteRetencion"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteImporteRetencion As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteImporteRetencion
          <Description("Porcentaje de  descuento adicional A que se ha aplicado.")>
          <DisplayName("Descuento adicional A % (Aplicado)")>
          Public Property DescuentoAdicionalAAplicadoPorciento As Decimal
          Public Shared ___DescuentoAdicionalAAplicadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoAdicionalAAplicadoPorciento"",""etiqueta"": ""Descuento adicional A % (Aplicado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento adicional A % (Aplicado)"",""descripcion"": """",""keyword"": ""DescuentoAdicionalAAplicadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoAdicionalAAplicadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoAdicionalAAplicadoPorciento
          <DisplayName("Destinador")>
          Public Property ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaDestinador As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaDestinador"",""etiqueta"": ""Destinador"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""relacionesindirectas"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Destinador"",""descripcion"": """",""keyword"": ""ReferenciaDestinador"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaDestinador
          <DisplayName("Descuentos General Impuesto 3")>
          Public Property ImporteDescuentosGeneralImpuesto3 As Decimal
          Public Shared ___ImporteDescuentosGeneralImpuesto3 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentosGeneralImpuesto3"",""etiqueta"": ""Descuentos General Impuesto 3"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuentos General Impuesto 3"",""descripcion"": """",""keyword"": ""ImporteDescuentosGeneralImpuesto3"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentosGeneralImpuesto3 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentosGeneralImpuesto3
          <DisplayName("Hora local")>
          Public Property HoraLocal As DateTime?
          Public Shared ___HoraLocal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""HoraLocal"",""etiqueta"": ""Hora local"",""oculta"": false,""formato"": 8,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Hora local"",""descripcion"": """",""keyword"": ""HoraLocal"",""formato"": 8,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __HoraLocal As DinaNETCore.APID.DinaupAPI_CampoC = ___HoraLocal
          <Description("Observaciones adicionales de la venta.")>
          <DisplayName("Observaciones y anotaciones")>
          Public Property Observaciones As String
          Public Shared ___Observaciones As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Observaciones"",""etiqueta"": ""Observaciones y anotaciones"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 9,""decimales"": ""0"",""multilinea"": true,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Observaciones y anotaciones"",""descripcion"": """",""keyword"": ""Observaciones"",""formato"": 5,""rol"": 9,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Observaciones As DinaNETCore.APID.DinaupAPI_CampoC = ___Observaciones
          <DisplayName("Cuota Impuesto 1")>
          Public Property ImporteCuotaImpuesto1 As Decimal
          Public Shared ___ImporteCuotaImpuesto1 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteCuotaImpuesto1"",""etiqueta"": ""Cuota Impuesto 1"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cuota Impuesto 1"",""descripcion"": """",""keyword"": ""ImporteCuotaImpuesto1"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteCuotaImpuesto1 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteCuotaImpuesto1
          <DisplayName("Ubicación Principal")>
          Public Property ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaUbicacionPrincipal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaUbicacionPrincipal"",""etiqueta"": ""Ubicación Principal"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""b9adbfbf-a81a-45fb-861c-90502902c982"",""titulo"": ""Ubicaciones"",""iconoid"": ""b985b58f-7275-46b8-9b66-2c54346b0185"",""etiquetasingular"": ""Ubicación"",""etiquetaplural"": ""Ubicaciones"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""b9adbfbf-a81a-45fb-861c-90502902c982"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Ubicación Principal"",""descripcion"": """",""keyword"": ""ReferenciaUbicacionPrincipal"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaUbicacionPrincipal
          <DisplayName("Autor del alta Tiene Acceso web")>
          Public Property AutorDelAltaTieneAccesoWeb As Boolean
          Public Shared ___AutorDelAltaTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AutorDelAltaTieneAccesoWeb"",""etiqueta"": ""Autor del alta Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta Tiene Acceso web"",""descripcion"": """",""keyword"": ""AutorDelAltaTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AutorDelAltaTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___AutorDelAltaTieneAccesoWeb
          <Description("Descuento general de la venta que se ha aplicado.")>
          <DisplayName("Descuento General % (Aplicado)")>
          Public Property DescuentoGeneralAplicadoPorciento As Decimal
          Public Shared ___DescuentoGeneralAplicadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoGeneralAplicadoPorciento"",""etiqueta"": ""Descuento General % (Aplicado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento General % (Aplicado)"",""descripcion"": """",""keyword"": ""DescuentoGeneralAplicadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoGeneralAplicadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoGeneralAplicadoPorciento
          <DisplayName("Proveedor")>
          Public Property ReferenciaProveedor As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaProveedor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaProveedor"",""etiqueta"": ""Proveedor"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Proveedor"",""descripcion"": """",""keyword"": ""ReferenciaProveedor"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaProveedor As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaProveedor
          <DisplayName("Estado")>
          Public Property ReferenciaEstado As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaEstado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaEstado"",""etiqueta"": ""Estado"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""2ec4f8ad-cec0-455e-a3ec-2557ec867762"",""titulo"": ""Estados de Compras/Gastos"",""iconoid"": ""1fbec552-994a-465e-a9ee-8502faa65d11"",""etiquetasingular"": ""Estado de Compras/Gasto"",""etiquetaplural"": ""Estados de Compras/Gastos"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""2ec4f8ad-cec0-455e-a3ec-2557ec867762"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Estado"",""descripcion"": """",""keyword"": ""ReferenciaEstado"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaEstado As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaEstado
          <DisplayName("Descuentos General Impuesto 2")>
          Public Property ImporteDescuentosGeneralImpuesto2 As Decimal
          Public Shared ___ImporteDescuentosGeneralImpuesto2 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentosGeneralImpuesto2"",""etiqueta"": ""Descuentos General Impuesto 2"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuentos General Impuesto 2"",""descripcion"": """",""keyword"": ""ImporteDescuentosGeneralImpuesto2"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentosGeneralImpuesto2 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentosGeneralImpuesto2
          <Description("Importe total de impuestos.")>
          <DisplayName("Total impuestos")>
          Public Property ImporteTotalImpuestos As Decimal
          Public Shared ___ImporteTotalImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteTotalImpuestos"",""etiqueta"": ""Total impuestos"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total impuestos"",""descripcion"": """",""keyword"": ""ImporteTotalImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteTotalImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteTotalImpuestos
          <DisplayName("Impuestos incluidos")>
          Public Property ImpuestosIncluidos As Boolean
          Public Shared ___ImpuestosIncluidos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImpuestosIncluidos"",""etiqueta"": ""Impuestos incluidos"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Impuestos incluidos"",""descripcion"": """",""keyword"": ""ImpuestosIncluidos"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImpuestosIncluidos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImpuestosIncluidos
          <DisplayName("Descuentos General Impuesto 1")>
          Public Property ImporteDescuentosGeneralImpuesto1 As Decimal
          Public Shared ___ImporteDescuentosGeneralImpuesto1 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentosGeneralImpuesto1"",""etiqueta"": ""Descuentos General Impuesto 1"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuentos General Impuesto 1"",""descripcion"": """",""keyword"": ""ImporteDescuentosGeneralImpuesto1"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentosGeneralImpuesto1 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentosGeneralImpuesto1
          <DisplayName("Suma Importe Productos (Con impuestos)")>
          Public Property ImporteSumaImporteProductosConImpuestos As Decimal
          Public Shared ___ImporteSumaImporteProductosConImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSumaImporteProductosConImpuestos"",""etiqueta"": ""Suma Importe Productos (Con impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Suma Importe Productos (Con impuestos)"",""descripcion"": """",""keyword"": ""ImporteSumaImporteProductosConImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSumaImporteProductosConImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSumaImporteProductosConImpuestos
          <DisplayName("Configuración de compra")>
          Public Property ReferenciaConfiguracionDeCompra As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaConfiguracionDeCompra As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaConfiguracionDeCompra"",""etiqueta"": ""Configuración de compra"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""afd1a074-0e8f-4e19-916c-030b70b00354"",""titulo"": ""Base - Configuración Compras/Gastos"",""iconoid"": ""51dda3d6-b61f-45d3-a4fb-3a9d3bfc4128"",""etiquetasingular"": ""Configuración Compras/Gastos"",""etiquetaplural"": ""Configuraciones Compras/Gastos"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""afd1a074-0e8f-4e19-916c-030b70b00354"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Configuración de compra"",""descripcion"": """",""keyword"": ""ReferenciaConfiguracionDeCompra"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaConfiguracionDeCompra As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaConfiguracionDeCompra
          <DisplayName("Impuesto 2")>
          Public Property ReferenciaImpuesto2 As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaImpuesto2 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaImpuesto2"",""etiqueta"": ""Impuesto 2"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""f3199ee0-dc83-4667-a9c1-f3b04e97a8a4"",""titulo"": ""Base - Impuestos"",""iconoid"": ""ff4a7189-6426-43b9-bdc4-070314999e81"",""etiquetasingular"": ""Impuesto"",""etiquetaplural"": ""Impuestos"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""f3199ee0-dc83-4667-a9c1-f3b04e97a8a4"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Impuesto 2"",""descripcion"": """",""keyword"": ""ReferenciaImpuesto2"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaImpuesto2 As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaImpuesto2
          <DisplayName("Cuota R.E Impuesto 3")>
          Public Property ImporteCuotaREImpuesto3 As Decimal
          Public Shared ___ImporteCuotaREImpuesto3 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteCuotaREImpuesto3"",""etiqueta"": ""Cuota R.E Impuesto 3"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cuota R.E Impuesto 3"",""descripcion"": """",""keyword"": ""ImporteCuotaREImpuesto3"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteCuotaREImpuesto3 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteCuotaREImpuesto3
          <DisplayName("Cuota R.E Impuesto 1")>
          Public Property ImporteCuotaREImpuesto1 As Decimal
          Public Shared ___ImporteCuotaREImpuesto1 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteCuotaREImpuesto1"",""etiqueta"": ""Cuota R.E Impuesto 1"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cuota R.E Impuesto 1"",""descripcion"": """",""keyword"": ""ImporteCuotaREImpuesto1"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteCuotaREImpuesto1 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteCuotaREImpuesto1
          <DisplayName("Impuesto 3")>
          Public Property ReferenciaImpuesto3 As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaImpuesto3 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaImpuesto3"",""etiqueta"": ""Impuesto 3"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""f3199ee0-dc83-4667-a9c1-f3b04e97a8a4"",""titulo"": ""Base - Impuestos"",""iconoid"": ""ff4a7189-6426-43b9-bdc4-070314999e81"",""etiquetasingular"": ""Impuesto"",""etiquetaplural"": ""Impuestos"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""f3199ee0-dc83-4667-a9c1-f3b04e97a8a4"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Impuesto 3"",""descripcion"": """",""keyword"": ""ReferenciaImpuesto3"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaImpuesto3 As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaImpuesto3
          <DisplayName("Número de referencia interna (Completo)")>
          Public Property NumeroDeReferenciaInternaCompleto As String
          Public Shared ___NumeroDeReferenciaInternaCompleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""NumeroDeReferenciaInternaCompleto"",""etiqueta"": ""Número de referencia interna (Completo)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Número de referencia interna (Completo)"",""descripcion"": """",""keyword"": ""NumeroDeReferenciaInternaCompleto"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __NumeroDeReferenciaInternaCompleto As DinaNETCore.APID.DinaupAPI_CampoC = ___NumeroDeReferenciaInternaCompleto
          <DisplayName("Descuentos Producto Impuesto 2")>
          Public Property ImporteDescuentosProductoImpuesto2 As Decimal
          Public Shared ___ImporteDescuentosProductoImpuesto2 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentosProductoImpuesto2"",""etiqueta"": ""Descuentos Producto Impuesto 2"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuentos Producto Impuesto 2"",""descripcion"": """",""keyword"": ""ImporteDescuentosProductoImpuesto2"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentosProductoImpuesto2 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentosProductoImpuesto2
          <DisplayName("Descripción descuento adicional A")>
          Public Property DescripcionDescuentoAdicionalA As String
          Public Shared ___DescripcionDescuentoAdicionalA As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescripcionDescuentoAdicionalA"",""etiqueta"": ""Descripción descuento adicional A"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descripción descuento adicional A"",""descripcion"": """",""keyword"": ""DescripcionDescuentoAdicionalA"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescripcionDescuentoAdicionalA As DinaNETCore.APID.DinaupAPI_CampoC = ___DescripcionDescuentoAdicionalA
          <DisplayName("Impuesto 1")>
          Public Property ReferenciaImpuesto1 As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaImpuesto1 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaImpuesto1"",""etiqueta"": ""Impuesto 1"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""f3199ee0-dc83-4667-a9c1-f3b04e97a8a4"",""titulo"": ""Base - Impuestos"",""iconoid"": ""ff4a7189-6426-43b9-bdc4-070314999e81"",""etiquetasingular"": ""Impuesto"",""etiquetaplural"": ""Impuestos"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""f3199ee0-dc83-4667-a9c1-f3b04e97a8a4"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Impuesto 1"",""descripcion"": """",""keyword"": ""ReferenciaImpuesto1"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaImpuesto1 As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaImpuesto1
          <DisplayName("Descuentos Producto Exento")>
          Public Property ImporteDescuentosProductoExento As Decimal
          Public Shared ___ImporteDescuentosProductoExento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentosProductoExento"",""etiqueta"": ""Descuentos Producto Exento"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuentos Producto Exento"",""descripcion"": """",""keyword"": ""ImporteDescuentosProductoExento"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentosProductoExento As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentosProductoExento
          <DisplayName("Puesto de trabajo")>
          Public Property ReferenciaPuestoDeTrabajo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaPuestoDeTrabajo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaPuestoDeTrabajo"",""etiqueta"": ""Puesto de trabajo"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""f777486d-e709-41be-9211-d9c6b4bb05d6"",""titulo"": ""Base - Puestos de trabajo"",""iconoid"": ""5d7008ed-1e2f-4dbe-a376-6261de330414"",""etiquetasingular"": ""Puesto de trabajo"",""etiquetaplural"": ""Puestos de trabajo"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""f777486d-e709-41be-9211-d9c6b4bb05d6"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Puesto de trabajo"",""descripcion"": """",""keyword"": ""ReferenciaPuestoDeTrabajo"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaPuestoDeTrabajo As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaPuestoDeTrabajo
          <Description("Importe total de los productos del documento, sin ningún tipo de descuento y/o impuestos aplicado.")>
          <DisplayName("Suma conceptos (Sin impuestos)")>
          Public Property ImporteSumaConceptosSinImpuestos As Decimal
          Public Shared ___ImporteSumaConceptosSinImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSumaConceptosSinImpuestos"",""etiqueta"": ""Suma conceptos (Sin impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Suma conceptos (Sin impuestos)"",""descripcion"": """",""keyword"": ""ImporteSumaConceptosSinImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSumaConceptosSinImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSumaConceptosSinImpuestos
          <Description("Importe total de todo los impuestos (Tanto generales como de productos) que se han aplicado.")>
          <DisplayName("Total Descontado (Sin impuestos)")>
          Public Property ImporteTotalDescontadoSinImpuestos As Decimal
          Public Shared ___ImporteTotalDescontadoSinImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteTotalDescontadoSinImpuestos"",""etiqueta"": ""Total Descontado (Sin impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total Descontado (Sin impuestos)"",""descripcion"": """",""keyword"": ""ImporteTotalDescontadoSinImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteTotalDescontadoSinImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteTotalDescontadoSinImpuestos
          <Description("Porcentaje de  descuento adicional B que se ha aplicado.")>
          <DisplayName("Descuento adicional B % (Aplicado)")>
          Public Property DescuentoAdicionalBAplicadoPorciento As Decimal
          Public Shared ___DescuentoAdicionalBAplicadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoAdicionalBAplicadoPorciento"",""etiqueta"": ""Descuento adicional B % (Aplicado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento adicional B % (Aplicado)"",""descripcion"": """",""keyword"": ""DescuentoAdicionalBAplicadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoAdicionalBAplicadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoAdicionalBAplicadoPorciento
          <DisplayName("Empleado")>
          Public Property ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaEmpleadoPrincipal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaEmpleadoPrincipal"",""etiqueta"": ""Empleado"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c6e071c7-776f-4300-aa55-c711fd1da916"",""titulo"": ""Empleados"",""iconoid"": ""1c8abf82-640c-4d18-b62c-89de310923dd"",""etiquetasingular"": ""Empleado"",""etiquetaplural"": ""Empleados"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""c6e071c7-776f-4300-aa55-c711fd1da916"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empleado"",""descripcion"": """",""keyword"": ""ReferenciaEmpleadoPrincipal"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaEmpleadoPrincipal
          <Description("Número total de productos.")>
          <DisplayName("Cantidad de Productos")>
          Public Property CantidadDeProductos As Decimal
          Public Shared ___CantidadDeProductos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CantidadDeProductos"",""etiqueta"": ""Cantidad de Productos"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""11"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cantidad de Productos"",""descripcion"": """",""keyword"": ""CantidadDeProductos"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CantidadDeProductos As DinaNETCore.APID.DinaupAPI_CampoC = ___CantidadDeProductos
          <DisplayName("Descripción descuento adicional B")>
          Public Property DescripcionDescuentoAdicionalB As String
          Public Shared ___DescripcionDescuentoAdicionalB As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescripcionDescuentoAdicionalB"",""etiqueta"": ""Descripción descuento adicional B"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descripción descuento adicional B"",""descripcion"": """",""keyword"": ""DescripcionDescuentoAdicionalB"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescripcionDescuentoAdicionalB As DinaNETCore.APID.DinaupAPI_CampoC = ___DescripcionDescuentoAdicionalB
          <DisplayName("Cuota R.E Impuesto 2")>
          Public Property ImporteCuotaREImpuesto2 As Decimal
          Public Shared ___ImporteCuotaREImpuesto2 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteCuotaREImpuesto2"",""etiqueta"": ""Cuota R.E Impuesto 2"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cuota R.E Impuesto 2"",""descripcion"": """",""keyword"": ""ImporteCuotaREImpuesto2"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteCuotaREImpuesto2 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteCuotaREImpuesto2
          <DisplayName("Total porcentaje descuentos Generales")>
          Public Property TotalPorcentajeDescuentosGeneralesPorciento As Decimal
          Public Shared ___TotalPorcentajeDescuentosGeneralesPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TotalPorcentajeDescuentosGeneralesPorciento"",""etiqueta"": ""Total porcentaje descuentos Generales"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total porcentaje descuentos Generales"",""descripcion"": """",""keyword"": ""TotalPorcentajeDescuentosGeneralesPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __TotalPorcentajeDescuentosGeneralesPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___TotalPorcentajeDescuentosGeneralesPorciento
          <DisplayName("Suma de conceptos Impuesto 2")>
          Public Property ImporteSumaDeConceptosImpuesto2 As Decimal
          Public Shared ___ImporteSumaDeConceptosImpuesto2 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSumaDeConceptosImpuesto2"",""etiqueta"": ""Suma de conceptos Impuesto 2"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Suma de conceptos Impuesto 2"",""descripcion"": """",""keyword"": ""ImporteSumaDeConceptosImpuesto2"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSumaDeConceptosImpuesto2 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSumaDeConceptosImpuesto2
          <DisplayName("Cuota Impuesto 2")>
          Public Property ImporteCuotaImpuesto2 As Decimal
          Public Shared ___ImporteCuotaImpuesto2 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteCuotaImpuesto2"",""etiqueta"": ""Cuota Impuesto 2"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cuota Impuesto 2"",""descripcion"": """",""keyword"": ""ImporteCuotaImpuesto2"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteCuotaImpuesto2 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteCuotaImpuesto2
          <DisplayName("Cantidad de productos comprados")>
          Public Property CantidadDeProductosComprados As Decimal
          Public Shared ___CantidadDeProductosComprados As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CantidadDeProductosComprados"",""etiqueta"": ""Cantidad de productos comprados"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""11"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cantidad de productos comprados"",""descripcion"": """",""keyword"": ""CantidadDeProductosComprados"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CantidadDeProductosComprados As DinaNETCore.APID.DinaupAPI_CampoC = ___CantidadDeProductosComprados
          <DisplayName("Empleado Tiene Acceso web")>
          Public Property EmpleadoTieneAccesoWeb As Boolean
          Public Shared ___EmpleadoTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EmpleadoTieneAccesoWeb"",""etiqueta"": ""Empleado Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empleado Tiene Acceso web"",""descripcion"": """",""keyword"": ""EmpleadoTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EmpleadoTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___EmpleadoTieneAccesoWeb
          <DisplayName("Base imponible Exenta")>
          Public Property ImporteBaseImponibleExenta As Decimal
          Public Shared ___ImporteBaseImponibleExenta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteBaseImponibleExenta"",""etiqueta"": ""Base imponible Exenta"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Base imponible Exenta"",""descripcion"": """",""keyword"": ""ImporteBaseImponibleExenta"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteBaseImponibleExenta As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteBaseImponibleExenta
          <DisplayName("Suma conceptos (Con impuestos)")>
          Public Property SumaConceptosConImpuestos As Decimal
          Public Shared ___SumaConceptosConImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""SumaConceptosConImpuestos"",""etiqueta"": ""Suma conceptos (Con impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Suma conceptos (Con impuestos)"",""descripcion"": """",""keyword"": ""SumaConceptosConImpuestos"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __SumaConceptosConImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___SumaConceptosConImpuestos
          <DisplayName("Aplicar Recargo de equivalencia")>
          Public Property AplicarRecargoDeEquivalencia As Boolean
          Public Shared ___AplicarRecargoDeEquivalencia As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AplicarRecargoDeEquivalencia"",""etiqueta"": ""Aplicar Recargo de equivalencia"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Aplicar Recargo de equivalencia"",""descripcion"": """",""keyword"": ""AplicarRecargoDeEquivalencia"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AplicarRecargoDeEquivalencia As DinaNETCore.APID.DinaupAPI_CampoC = ___AplicarRecargoDeEquivalencia
          <DisplayName("Base imponible impuesto 2")>
          Public Property ImporteBaseImponibleImpuesto2 As Decimal
          Public Shared ___ImporteBaseImponibleImpuesto2 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteBaseImponibleImpuesto2"",""etiqueta"": ""Base imponible impuesto 2"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Base imponible impuesto 2"",""descripcion"": """",""keyword"": ""ImporteBaseImponibleImpuesto2"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteBaseImponibleImpuesto2 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteBaseImponibleImpuesto2
          <DisplayName("Base imponible impuesto 3")>
          Public Property ImporteBaseImponibleImpuesto3 As Decimal
          Public Shared ___ImporteBaseImponibleImpuesto3 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteBaseImponibleImpuesto3"",""etiqueta"": ""Base imponible impuesto 3"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Base imponible impuesto 3"",""descripcion"": """",""keyword"": ""ImporteBaseImponibleImpuesto3"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteBaseImponibleImpuesto3 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteBaseImponibleImpuesto3
          <DisplayName("Numeración / Serie")>
          Public Property ReferenciaNumeracionSerie As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaNumeracionSerie As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaNumeracionSerie"",""etiqueta"": ""Numeración / Serie"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""a93edb96-3ad2-4498-a1ca-696737b93cea"",""titulo"": ""Base - Numeraciones / Series"",""iconoid"": ""5ae6b089-a12a-417c-92c2-d64de875e355"",""etiquetasingular"": ""Numeración / Serie"",""etiquetaplural"": ""Numeraciones / Series"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""a93edb96-3ad2-4498-a1ca-696737b93cea"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Numeración / Serie"",""descripcion"": """",""keyword"": ""ReferenciaNumeracionSerie"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaNumeracionSerie As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaNumeracionSerie
          <DisplayName("Retención")>
          Public Property ReferenciaRetencion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaRetencion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaRetencion"",""etiqueta"": ""Retención"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""1a89014d-3991-4d9d-8d0f-77fcf2ddff5e"",""titulo"": ""Base - Retenciones"",""iconoid"": ""13560fd4-34fc-42bc-b12d-007e26e5f428"",""etiquetasingular"": ""Retención"",""etiquetaplural"": ""Retenciones"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""1a89014d-3991-4d9d-8d0f-77fcf2ddff5e"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Retención"",""descripcion"": """",""keyword"": ""ReferenciaRetencion"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaRetencion As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaRetencion
          <DisplayName("Número de referencia interna")>
          Public Property NumeroDeReferenciaInterna As Integer
          Public Shared ___NumeroDeReferenciaInterna As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""NumeroDeReferenciaInterna"",""etiqueta"": ""Número de referencia interna"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Número de referencia interna"",""descripcion"": """",""keyword"": ""NumeroDeReferenciaInterna"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __NumeroDeReferenciaInterna As DinaNETCore.APID.DinaupAPI_CampoC = ___NumeroDeReferenciaInterna
          <DisplayName("Fecha Alta del registro")>
          Public Property FechaAlta_UTC As Date?
          Public Shared ___FechaAlta_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaAlta_UTC"",""etiqueta"": ""Fecha Alta del registro"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Alta del registro"",""descripcion"": """",""keyword"": ""FechaAlta_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaAlta_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaAlta_UTC
          <DisplayName("Cuota Impuesto 3")>
          Public Property ImporteCuotaImpuesto3 As Decimal
          Public Shared ___ImporteCuotaImpuesto3 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteCuotaImpuesto3"",""etiqueta"": ""Cuota Impuesto 3"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cuota Impuesto 3"",""descripcion"": """",""keyword"": ""ImporteCuotaImpuesto3"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteCuotaImpuesto3 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteCuotaImpuesto3
          <DisplayName("Fecha Dato")>
          Public Property FechaDato_UTC As Date?
          Public Shared ___FechaDato_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaDato_UTC"",""etiqueta"": ""Fecha Dato"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Dato"",""descripcion"": """",""keyword"": ""FechaDato_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaDato_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaDato_UTC
          <DisplayName("Descuento General impuesto Exento")>
          Public Property ImporteDescuentoGeneralImpuestoExento As Decimal
          Public Shared ___ImporteDescuentoGeneralImpuestoExento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentoGeneralImpuestoExento"",""etiqueta"": ""Descuento General impuesto Exento"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento General impuesto Exento"",""descripcion"": """",""keyword"": ""ImporteDescuentoGeneralImpuestoExento"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentoGeneralImpuestoExento As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentoGeneralImpuestoExento
          <DisplayName("Cantidad de productos que se pueden comprar")>
          Public Property CantidadDeProductosQueSePuedenComprar As Decimal
          Public Shared ___CantidadDeProductosQueSePuedenComprar As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CantidadDeProductosQueSePuedenComprar"",""etiqueta"": ""Cantidad de productos que se pueden comprar"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""11"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cantidad de productos que se pueden comprar"",""descripcion"": """",""keyword"": ""CantidadDeProductosQueSePuedenComprar"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CantidadDeProductosQueSePuedenComprar As DinaNETCore.APID.DinaupAPI_CampoC = ___CantidadDeProductosQueSePuedenComprar
          <DisplayName("Suma importe de productos (Sin Impuestos)")>
          Public Property ImporteSumaImporteDeProductosSinImpuestos As Decimal
          Public Shared ___ImporteSumaImporteDeProductosSinImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSumaImporteDeProductosSinImpuestos"",""etiqueta"": ""Suma importe de productos (Sin Impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Suma importe de productos (Sin Impuestos)"",""descripcion"": """",""keyword"": ""ImporteSumaImporteDeProductosSinImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSumaImporteDeProductosSinImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSumaImporteDeProductosSinImpuestos
          <DisplayName("Base imponible impuesto 1")>
          Public Property ImporteBaseImponibleImpuesto1 As Decimal
          Public Shared ___ImporteBaseImponibleImpuesto1 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteBaseImponibleImpuesto1"",""etiqueta"": ""Base imponible impuesto 1"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Base imponible impuesto 1"",""descripcion"": """",""keyword"": ""ImporteBaseImponibleImpuesto1"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteBaseImponibleImpuesto1 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteBaseImponibleImpuesto1
          <DisplayName("Descuentos Producto Impuesto 1")>
          Public Property ImporteDescuentosProductoImpuesto1 As Decimal
          Public Shared ___ImporteDescuentosProductoImpuesto1 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentosProductoImpuesto1"",""etiqueta"": ""Descuentos Producto Impuesto 1"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuentos Producto Impuesto 1"",""descripcion"": """",""keyword"": ""ImporteDescuentosProductoImpuesto1"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentosProductoImpuesto1 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentosProductoImpuesto1
          <DisplayName("Descuentos Producto Impuesto 3")>
          Public Property ImporteDescuentosProductoImpuesto3 As Decimal
          Public Shared ___ImporteDescuentosProductoImpuesto3 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentosProductoImpuesto3"",""etiqueta"": ""Descuentos Producto Impuesto 3"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuentos Producto Impuesto 3"",""descripcion"": """",""keyword"": ""ImporteDescuentosProductoImpuesto3"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentosProductoImpuesto3 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentosProductoImpuesto3
          <DisplayName("Total")>
          Public Property ImporteTotal As Decimal
          Public Shared ___ImporteTotal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteTotal"",""etiqueta"": ""Total"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total"",""descripcion"": """",""keyword"": ""ImporteTotal"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteTotal As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteTotal
          <Description("Importe total sin impuestos ni retenciones." & vbCrLf & "Pero con todas las bonificaciones aplicadas y todos los importes sumados." & vbCrLf & "Es el paso anterior al resultado final.")>
          <DisplayName("Subtotal")>
          Public Property ImporteSubtotal As Decimal
          Public Shared ___ImporteSubtotal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSubtotal"",""etiqueta"": ""Subtotal"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Subtotal"",""descripcion"": """",""keyword"": ""ImporteSubtotal"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSubtotal As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSubtotal
          <DisplayName("Autor del alta")>
          Public Property ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaAutorDelAlta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaAutorDelAlta"",""etiqueta"": ""Autor del alta"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta"",""descripcion"": """",""keyword"": ""ReferenciaAutorDelAlta"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaAutorDelAlta
          <DisplayName("Proveedor Tiene Acceso web")>
          Public Property ProveedorTieneAccesoWeb As Boolean
          Public Shared ___ProveedorTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ProveedorTieneAccesoWeb"",""etiqueta"": ""Proveedor Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Proveedor Tiene Acceso web"",""descripcion"": """",""keyword"": ""ProveedorTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ProveedorTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___ProveedorTieneAccesoWeb
          <DisplayName("Suma de conceptos Impuesto 3")>
          Public Property ImporteSumaDeConceptosImpuesto3 As Decimal
          Public Shared ___ImporteSumaDeConceptosImpuesto3 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSumaDeConceptosImpuesto3"",""etiqueta"": ""Suma de conceptos Impuesto 3"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Suma de conceptos Impuesto 3"",""descripcion"": """",""keyword"": ""ImporteSumaDeConceptosImpuesto3"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSumaDeConceptosImpuesto3 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSumaDeConceptosImpuesto3
          <Description("Descuento perteneciente a la entidad que se ha aplicado.")>
          <DisplayName("Descuento Entidad % (Aplicado)")>
          Public Property DescuentoEntidadAplicadoPorciento As Decimal
          Public Shared ___DescuentoEntidadAplicadoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoEntidadAplicadoPorciento"",""etiqueta"": ""Descuento Entidad % (Aplicado)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento Entidad % (Aplicado)"",""descripcion"": """",""keyword"": ""DescuentoEntidadAplicadoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoEntidadAplicadoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoEntidadAplicadoPorciento
          <DisplayName("Tipo de Factura")>
          Public Property ReferenciaTipoDeFactura As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaTipoDeFactura As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaTipoDeFactura"",""etiqueta"": ""Tipo de Factura"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""ef5644b0-fb98-4191-908d-99594d9e1cc5"",""titulo"": ""Base - Tipos de movimiento"",""iconoid"": ""d720d25f-f5b8-4c83-a9f3-a8bf6cb31468"",""etiquetasingular"": ""Tipo de movimiento"",""etiquetaplural"": ""Tipos de movimiento"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""ef5644b0-fb98-4191-908d-99594d9e1cc5"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Tipo de Factura"",""descripcion"": """",""keyword"": ""ReferenciaTipoDeFactura"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaTipoDeFactura As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaTipoDeFactura
          <DisplayName("Total Deducción")>
          Public Property ImporteTotalDeduccion As Decimal
          Public Shared ___ImporteTotalDeduccion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteTotalDeduccion"",""etiqueta"": ""Total Deducción"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total Deducción"",""descripcion"": """",""keyword"": ""ImporteTotalDeduccion"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteTotalDeduccion As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteTotalDeduccion
          <DisplayName("Suma de conceptos Impuesto 1")>
          Public Property ImporteSumaDeConceptosImpuesto1 As Decimal
          Public Shared ___ImporteSumaDeConceptosImpuesto1 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSumaDeConceptosImpuesto1"",""etiqueta"": ""Suma de conceptos Impuesto 1"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Suma de conceptos Impuesto 1"",""descripcion"": """",""keyword"": ""ImporteSumaDeConceptosImpuesto1"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSumaDeConceptosImpuesto1 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSumaDeConceptosImpuesto1
          <DisplayName("Fecha contable")>
          Public Property FechaContable As Date?
          Public Shared ___FechaContable As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaContable"",""etiqueta"": ""Fecha contable"",""oculta"": false,""formato"": 7,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 69,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha contable"",""descripcion"": """",""keyword"": ""FechaContable"",""formato"": 7,""rol"": 69,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaContable As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaContable
          <DisplayName("Datos fiscales (Proveedor)")>
          Public Property ReferenciaDatosFiscalesProveedor As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaDatosFiscalesProveedor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaDatosFiscalesProveedor"",""etiqueta"": ""Datos fiscales (Proveedor)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""03e347ac-c694-4d4a-a81f-e577ba014d1d"",""titulo"": ""Base - Datos fiscales"",""iconoid"": ""773d55f9-1e21-41f1-b0b0-f6a1dd370ea3"",""etiquetasingular"": ""Datos fiscales"",""etiquetaplural"": ""Datos fiscales"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""03e347ac-c694-4d4a-a81f-e577ba014d1d"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Datos fiscales (Proveedor)"",""descripcion"": """",""keyword"": ""ReferenciaDatosFiscalesProveedor"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaDatosFiscalesProveedor As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaDatosFiscalesProveedor
          <DisplayName("País (Empresa)")>
          Public Property PaisEmpresa As String
          Public Shared ___PaisEmpresa As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""PaisEmpresa"",""etiqueta"": ""País (Empresa)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""País (Empresa)"",""descripcion"": """",""keyword"": ""PaisEmpresa"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __PaisEmpresa As DinaNETCore.APID.DinaupAPI_CampoC = ___PaisEmpresa
          <DisplayName("Dirección (Empresa)")>
          Public Property DireccionEmpresa As String
          Public Shared ___DireccionEmpresa As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DireccionEmpresa"",""etiqueta"": ""Dirección (Empresa)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 9,""decimales"": ""0"",""multilinea"": true,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Dirección (Empresa)"",""descripcion"": """",""keyword"": ""DireccionEmpresa"",""formato"": 5,""rol"": 9,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DireccionEmpresa As DinaNETCore.APID.DinaupAPI_CampoC = ___DireccionEmpresa
          <DisplayName("NIF (Empresa)")>
          Public Property NIFEmpresa As String
          Public Shared ___NIFEmpresa As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""NIFEmpresa"",""etiqueta"": ""NIF (Empresa)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 79,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""NIF (Empresa)"",""descripcion"": """",""keyword"": ""NIFEmpresa"",""formato"": 5,""rol"": 79,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __NIFEmpresa As DinaNETCore.APID.DinaupAPI_CampoC = ___NIFEmpresa
          <DisplayName("Provincia (Empresa)")>
          Public Property ProvinciaEmpresa As String
          Public Shared ___ProvinciaEmpresa As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ProvinciaEmpresa"",""etiqueta"": ""Provincia (Empresa)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Provincia (Empresa)"",""descripcion"": """",""keyword"": ""ProvinciaEmpresa"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ProvinciaEmpresa As DinaNETCore.APID.DinaupAPI_CampoC = ___ProvinciaEmpresa
          <DisplayName("Denominación / Razón Social (Empresa)")>
          Public Property DenominacionRazonSocialEmpresa As String
          Public Shared ___DenominacionRazonSocialEmpresa As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DenominacionRazonSocialEmpresa"",""etiqueta"": ""Denominación / Razón Social (Empresa)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Denominación / Razón Social (Empresa)"",""descripcion"": """",""keyword"": ""DenominacionRazonSocialEmpresa"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DenominacionRazonSocialEmpresa As DinaNETCore.APID.DinaupAPI_CampoC = ___DenominacionRazonSocialEmpresa
          <DisplayName("Municipio (Empresa)")>
          Public Property MunicipioEmpresa As String
          Public Shared ___MunicipioEmpresa As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""MunicipioEmpresa"",""etiqueta"": ""Municipio (Empresa)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Municipio (Empresa)"",""descripcion"": """",""keyword"": ""MunicipioEmpresa"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __MunicipioEmpresa As DinaNETCore.APID.DinaupAPI_CampoC = ___MunicipioEmpresa
          <DisplayName("Denominación / Razón Social (Proveedor)")>
          Public Property DenominacionRazonSocialProveedor As String
          Public Shared ___DenominacionRazonSocialProveedor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DenominacionRazonSocialProveedor"",""etiqueta"": ""Denominación / Razón Social (Proveedor)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Denominación / Razón Social (Proveedor)"",""descripcion"": """",""keyword"": ""DenominacionRazonSocialProveedor"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DenominacionRazonSocialProveedor As DinaNETCore.APID.DinaupAPI_CampoC = ___DenominacionRazonSocialProveedor
          <DisplayName("País (Proveedor)")>
          Public Property PaisProveedor As String
          Public Shared ___PaisProveedor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""PaisProveedor"",""etiqueta"": ""País (Proveedor)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 83,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""País (Proveedor)"",""descripcion"": """",""keyword"": ""PaisProveedor"",""formato"": 5,""rol"": 83,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __PaisProveedor As DinaNETCore.APID.DinaupAPI_CampoC = ___PaisProveedor
          <DisplayName("Provincia (Proveedor)")>
          Public Property ProvinciaProveedor As String
          Public Shared ___ProvinciaProveedor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ProvinciaProveedor"",""etiqueta"": ""Provincia (Proveedor)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 84,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Provincia (Proveedor)"",""descripcion"": """",""keyword"": ""ProvinciaProveedor"",""formato"": 5,""rol"": 84,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ProvinciaProveedor As DinaNETCore.APID.DinaupAPI_CampoC = ___ProvinciaProveedor
          <DisplayName("Teléfono (Proveedor)")>
          Public Property TelefonoProveedor As String
          Public Shared ___TelefonoProveedor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TelefonoProveedor"",""etiqueta"": ""Teléfono (Proveedor)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 2,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Teléfono (Proveedor)"",""descripcion"": """",""keyword"": ""TelefonoProveedor"",""formato"": 5,""rol"": 2,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __TelefonoProveedor As DinaNETCore.APID.DinaupAPI_CampoC = ___TelefonoProveedor
          <DisplayName("Municipio (Proveedor)")>
          Public Property MunicipioProveedor As String
          Public Shared ___MunicipioProveedor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""MunicipioProveedor"",""etiqueta"": ""Municipio (Proveedor)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Municipio (Proveedor)"",""descripcion"": """",""keyword"": ""MunicipioProveedor"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __MunicipioProveedor As DinaNETCore.APID.DinaupAPI_CampoC = ___MunicipioProveedor
          <DisplayName("Código postal (Proveedor)")>
          Public Property CodigoPostalProveedor As String
          Public Shared ___CodigoPostalProveedor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CodigoPostalProveedor"",""etiqueta"": ""Código postal (Proveedor)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Código postal (Proveedor)"",""descripcion"": """",""keyword"": ""CodigoPostalProveedor"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CodigoPostalProveedor As DinaNETCore.APID.DinaupAPI_CampoC = ___CodigoPostalProveedor
          <DisplayName("Dirección (Proveedor)")>
          Public Property DireccionProveedor As String
          Public Shared ___DireccionProveedor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DireccionProveedor"",""etiqueta"": ""Dirección (Proveedor)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 9,""decimales"": ""0"",""multilinea"": true,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Dirección (Proveedor)"",""descripcion"": """",""keyword"": ""DireccionProveedor"",""formato"": 5,""rol"": 9,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DireccionProveedor As DinaNETCore.APID.DinaupAPI_CampoC = ___DireccionProveedor
          <DisplayName("Datos fiscales (Empresa)")>
          Public Property ReferenciaDatosFiscalesEmpresa As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaDatosFiscalesEmpresa As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaDatosFiscalesEmpresa"",""etiqueta"": ""Datos fiscales (Empresa)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""03e347ac-c694-4d4a-a81f-e577ba014d1d"",""titulo"": ""Base - Datos fiscales"",""iconoid"": ""773d55f9-1e21-41f1-b0b0-f6a1dd370ea3"",""etiquetasingular"": ""Datos fiscales"",""etiquetaplural"": ""Datos fiscales"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""03e347ac-c694-4d4a-a81f-e577ba014d1d"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Datos fiscales (Empresa)"",""descripcion"": """",""keyword"": ""ReferenciaDatosFiscalesEmpresa"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaDatosFiscalesEmpresa As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaDatosFiscalesEmpresa
          <DisplayName("Código postal (Empresa)")>
          Public Property CodigoPostalEmpresa As String
          Public Shared ___CodigoPostalEmpresa As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CodigoPostalEmpresa"",""etiqueta"": ""Código postal (Empresa)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Código postal (Empresa)"",""descripcion"": """",""keyword"": ""CodigoPostalEmpresa"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CodigoPostalEmpresa As DinaNETCore.APID.DinaupAPI_CampoC = ___CodigoPostalEmpresa
          <DisplayName("Teléfono (Empresa)")>
          Public Property TelefonoEmpresa As String
          Public Shared ___TelefonoEmpresa As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TelefonoEmpresa"",""etiqueta"": ""Teléfono (Empresa)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 2,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Teléfono (Empresa)"",""descripcion"": """",""keyword"": ""TelefonoEmpresa"",""formato"": 5,""rol"": 2,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __TelefonoEmpresa As DinaNETCore.APID.DinaupAPI_CampoC = ___TelefonoEmpresa
          <DisplayName("NIF (Proveedor)")>
          Public Property NIFProveedor As String
          Public Shared ___NIFProveedor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""NIFProveedor"",""etiqueta"": ""NIF (Proveedor)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 79,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""NIF (Proveedor)"",""descripcion"": """",""keyword"": ""NIFProveedor"",""formato"": 5,""rol"": 79,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __NIFProveedor As DinaNETCore.APID.DinaupAPI_CampoC = ___NIFProveedor
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
          <DisplayName("Es un gasto sin factura (Obsoleto)")>
          Public Property EsUnGastoSinFacturaObsoleto As Boolean
          Public Shared ___EsUnGastoSinFacturaObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EsUnGastoSinFacturaObsoleto"",""etiqueta"": ""Es un gasto sin factura (Obsoleto)"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Es un gasto sin factura (Obsoleto)"",""descripcion"": """",""keyword"": ""EsUnGastoSinFacturaObsoleto"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EsUnGastoSinFacturaObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___EsUnGastoSinFacturaObsoleto
          <DisplayName("Marcar como concluida aunque hayan procesos pendientes")>
          Public Property MarcarComoConcluidaAunqueHayanProcesosPendientes As Boolean
          Public Shared ___MarcarComoConcluidaAunqueHayanProcesosPendientes As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""MarcarComoConcluidaAunqueHayanProcesosPendientes"",""etiqueta"": ""Marcar como concluida aunque hayan procesos pendientes"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Marcar como concluida aunque hayan procesos pendientes"",""descripcion"": """",""keyword"": ""MarcarComoConcluidaAunqueHayanProcesosPendientes"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __MarcarComoConcluidaAunqueHayanProcesosPendientes As DinaNETCore.APID.DinaupAPI_CampoC = ___MarcarComoConcluidaAunqueHayanProcesosPendientes
          <DisplayName("Válido hasta")>
          Public Property ValidoHasta As Date?
          Public Shared ___ValidoHasta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ValidoHasta"",""etiqueta"": ""Válido hasta"",""oculta"": false,""formato"": 7,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Válido hasta"",""descripcion"": """",""keyword"": ""ValidoHasta"",""formato"": 7,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __ValidoHasta As DinaNETCore.APID.DinaupAPI_CampoC = ___ValidoHasta
          <DisplayName("Anulado")>
          Public Property Anulado As Boolean
          Public Shared ___Anulado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Anulado"",""etiqueta"": ""Anulado"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Anulado"",""descripcion"": """",""keyword"": ""Anulado"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Anulado As DinaNETCore.APID.DinaupAPI_CampoC = ___Anulado
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
          <DisplayName("Operación intragrupo (Obsoleto)")>
          Public Property OperacionIntragrupoObsoleto As Boolean
          Public Shared ___OperacionIntragrupoObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""OperacionIntragrupoObsoleto"",""etiqueta"": ""Operación intragrupo (Obsoleto)"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Operación intragrupo (Obsoleto)"",""descripcion"": """",""keyword"": ""OperacionIntragrupoObsoleto"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __OperacionIntragrupoObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___OperacionIntragrupoObsoleto
          <DisplayName("Régimen especial de bienes usados (Obsoleto)")>
          Public Property RegimenEspecialDeBienesUsadosObsoleto As Boolean
          Public Shared ___RegimenEspecialDeBienesUsadosObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RegimenEspecialDeBienesUsadosObsoleto"",""etiqueta"": ""Régimen especial de bienes usados (Obsoleto)"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Régimen especial de bienes usados (Obsoleto)"",""descripcion"": """",""keyword"": ""RegimenEspecialDeBienesUsadosObsoleto"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RegimenEspecialDeBienesUsadosObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___RegimenEspecialDeBienesUsadosObsoleto
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
          <DisplayName("NIF Intracomunitario (Empresa)")>
          Public Property NIFIntracomunitarioEmpresa As String
          Public Shared ___NIFIntracomunitarioEmpresa As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""NIFIntracomunitarioEmpresa"",""etiqueta"": ""NIF Intracomunitario (Empresa)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 79,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""NIF Intracomunitario (Empresa)"",""descripcion"": """",""keyword"": ""NIFIntracomunitarioEmpresa"",""formato"": 5,""rol"": 79,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __NIFIntracomunitarioEmpresa As DinaNETCore.APID.DinaupAPI_CampoC = ___NIFIntracomunitarioEmpresa
          <DisplayName("NIF Intracomunitario (Proveedor)")>
          Public Property NIFIntracomunitarioProveedor As String
          Public Shared ___NIFIntracomunitarioProveedor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""NIFIntracomunitarioProveedor"",""etiqueta"": ""NIF Intracomunitario (Proveedor)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 79,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""NIF Intracomunitario (Proveedor)"",""descripcion"": """",""keyword"": ""NIFIntracomunitarioProveedor"",""formato"": 5,""rol"": 79,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __NIFIntracomunitarioProveedor As DinaNETCore.APID.DinaupAPI_CampoC = ___NIFIntracomunitarioProveedor
          <DisplayName("Total operación")>
          Public Property ImporteTotalOperacion As Decimal
          Public Shared ___ImporteTotalOperacion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteTotalOperacion"",""etiqueta"": ""Total operación"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total operación"",""descripcion"": """",""keyword"": ""ImporteTotalOperacion"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteTotalOperacion As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteTotalOperacion
          <DisplayName("Total suplidos")>
          Public Property ImporteTotalSuplidos As Decimal
          Public Shared ___ImporteTotalSuplidos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteTotalSuplidos"",""etiqueta"": ""Total suplidos"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total suplidos"",""descripcion"": """",""keyword"": ""ImporteTotalSuplidos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteTotalSuplidos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteTotalSuplidos
          <ReadOnlyAttribute(True)>
          <DisplayName("ID")>
          Public Property ID As Guid
          Public Shared ___ID As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": true,""eseliminado"": false,""keyword"": ""ID"",""etiqueta"": ""ID"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""e9fd98be-d22e-4bfd-84a3-ad22df3173e3"",""titulo"": ""Presupuestos de Compras y Gastos"",""iconoid"": ""6c17ff24-7fbc-40de-b2c2-eba0c969191f"",""etiquetasingular"": ""Presupuesto de Compra / Gasto"",""etiquetaplural"": ""Presupuestos de Compras y Gastos"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""e9fd98be-d22e-4bfd-84a3-ad22df3173e3"",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""ID"",""descripcion"": """",""keyword"": ""ID"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
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
          me.ImporteSumaDeConceptosImpuestoExentos = _Datos.Leer_Decimal("pr_40040105671153")
          me.ImporteImporteRetencion = _Datos.Leer_Decimal("pr_40040105671157")
          me.DescuentoAdicionalAAplicadoPorciento = _Datos.Leer_Decimal("pr_40040105671156")
          me.ReferenciaDestinador = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_3004010555243"), _Datos.Leer_String("pr_3004010555243.nombre"))
          me.ImporteDescuentosGeneralImpuesto3 = _Datos.Leer_Decimal("pr_40040105671152")
          me.HoraLocal = _Datos.Leer_Time_Nulable("pr_3004010555238")
          me.Observaciones = _Datos.Leer_String("pr_40040105671182")
          me.ImporteCuotaImpuesto1 = _Datos.Leer_Decimal("pr_40040105671158")
          me.ReferenciaUbicacionPrincipal = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_3004010555235"), _Datos.Leer_String("pr_3004010555235.nombre"))
          me.AutorDelAltaTieneAccesoWeb = _Datos.Leer_Boolean("pr_3004010555249")
          me.DescuentoGeneralAplicadoPorciento = _Datos.Leer_Decimal("pr_40040105671145")
          me.ReferenciaProveedor = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_40040105671174"), _Datos.Leer_String("pr_40040105671174.nombre"))
          me.ReferenciaEstado = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_40040105671175"), _Datos.Leer_String("pr_40040105671175.nombre"))
          me.ImporteDescuentosGeneralImpuesto2 = _Datos.Leer_Decimal("pr_40040105671149")
          me.ImporteTotalImpuestos = _Datos.Leer_Decimal("pr_40040105671148")
          me.ImpuestosIncluidos = _Datos.Leer_Boolean("pr_40040105671194")
          me.ImporteDescuentosGeneralImpuesto1 = _Datos.Leer_Decimal("pr_40040105671150")
          me.ImporteSumaImporteProductosConImpuestos = _Datos.Leer_Decimal("pr_40040105671146")
          me.ReferenciaConfiguracionDeCompra = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_40040105671176"), _Datos.Leer_String("pr_40040105671176.nombre"))
          me.ReferenciaImpuesto2 = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_40040105671177"), _Datos.Leer_String("pr_40040105671177.nombre"))
          me.ImporteCuotaREImpuesto3 = _Datos.Leer_Decimal("pr_40040105671147")
          me.ImporteCuotaREImpuesto1 = _Datos.Leer_Decimal("pr_40040105671137")
          me.ReferenciaImpuesto3 = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_40040105671173"), _Datos.Leer_String("pr_40040105671173.nombre"))
          me.NumeroDeReferenciaInternaCompleto = _Datos.Leer_String("pr_40040105671181")
          me.ImporteDescuentosProductoImpuesto2 = _Datos.Leer_Decimal("pr_40040105671139")
          me.DescripcionDescuentoAdicionalA = _Datos.Leer_String("pr_40040105671179")
          me.ReferenciaImpuesto1 = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_40040105671171"), _Datos.Leer_String("pr_40040105671171.nombre"))
          me.ImporteDescuentosProductoExento = _Datos.Leer_Decimal("pr_40040105671127")
          me.ReferenciaPuestoDeTrabajo = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_40040105671170"), _Datos.Leer_String("pr_40040105671170.nombre"))
          me.ImporteSumaConceptosSinImpuestos = _Datos.Leer_Decimal("pr_40040105671123")
          me.ImporteTotalDescontadoSinImpuestos = _Datos.Leer_Decimal("pr_40040105671124")
          me.DescuentoAdicionalBAplicadoPorciento = _Datos.Leer_Decimal("pr_40040105671135")
          me.ReferenciaEmpleadoPrincipal = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_3004010555234"), _Datos.Leer_String("pr_3004010555234.nombre"))
          me.CantidadDeProductos = _Datos.Leer_Decimal("pr_40040105671128")
          me.DescripcionDescuentoAdicionalB = _Datos.Leer_String("pr_40040105671180")
          me.ImporteCuotaREImpuesto2 = _Datos.Leer_Decimal("pr_40040105671130")
          me.TotalPorcentajeDescuentosGeneralesPorciento = _Datos.Leer_Decimal("pr_40040105671131")
          me.ImporteSumaDeConceptosImpuesto2 = _Datos.Leer_Decimal("pr_40040105671132")
          me.ImporteCuotaImpuesto2 = _Datos.Leer_Decimal("pr_40040105671110")
          me.CantidadDeProductosComprados = _Datos.Leer_Decimal("pr_50040107181")
          me.EmpleadoTieneAccesoWeb = _Datos.Leer_Boolean("pr_3004010555251")
          me.ImporteBaseImponibleExenta = _Datos.Leer_Decimal("pr_40040105671108")
          me.SumaConceptosConImpuestos = _Datos.Leer_Decimal("pr_60040115045")
          me.AplicarRecargoDeEquivalencia = _Datos.Leer_Boolean("pr_40040105671192")
          me.ImporteBaseImponibleImpuesto2 = _Datos.Leer_Decimal("pr_40040105671119")
          me.ImporteBaseImponibleImpuesto3 = _Datos.Leer_Decimal("pr_40040105671121")
          me.ReferenciaNumeracionSerie = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_40040105671169"), _Datos.Leer_String("pr_40040105671169.nombre"))
          me.ReferenciaRetencion = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_40040105671168"), _Datos.Leer_String("pr_40040105671168.nombre"))
          me.NumeroDeReferenciaInterna = _Datos.Leer_Integer("pr_40040105671186")
          me.FechaAlta_UTC = _Datos.Leer_DateTime_Nulable("pr_3004010555240")
          me.ImporteCuotaImpuesto3 = _Datos.Leer_Decimal("pr_40040105671113")
          me.FechaDato_UTC = _Datos.Leer_DateTime_Nulable("pr_3004010555237")
          me.ImporteDescuentoGeneralImpuestoExento = _Datos.Leer_Decimal("pr_40040105671099")
          me.CantidadDeProductosQueSePuedenComprar = _Datos.Leer_Decimal("pr_50040107182")
          me.ImporteSumaImporteDeProductosSinImpuestos = _Datos.Leer_Decimal("pr_40040105671101")
          me.ImporteBaseImponibleImpuesto1 = _Datos.Leer_Decimal("pr_40040105671105")
          me.ImporteDescuentosProductoImpuesto1 = _Datos.Leer_Decimal("pr_40040105671103")
          me.ImporteDescuentosProductoImpuesto3 = _Datos.Leer_Decimal("pr_40040105671093")
          me.ImporteTotal = _Datos.Leer_Decimal("pr_40040105671092")
          me.ImporteSubtotal = _Datos.Leer_Decimal("pr_40040105671097")
          me.ReferenciaAutorDelAlta = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_3004010555236"), _Datos.Leer_String("pr_3004010555236.nombre"))
          me.ProveedorTieneAccesoWeb = _Datos.Leer_Boolean("pr_40040105671178")
          me.ImporteSumaDeConceptosImpuesto3 = _Datos.Leer_Decimal("pr_40040105671094")
          me.DescuentoEntidadAplicadoPorciento = _Datos.Leer_Decimal("pr_40040105671084")
          me.ReferenciaTipoDeFactura = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_40040105671162"), _Datos.Leer_String("pr_40040105671162.nombre"))
          me.ImporteTotalDeduccion = _Datos.Leer_Decimal("pr_40040105671090")
          me.ImporteSumaDeConceptosImpuesto1 = _Datos.Leer_Decimal("pr_40040105671088")
          me.FechaContable = _Datos.Leer_Date_Nulable("pr_40040135703")
          me.ReferenciaDatosFiscalesProveedor = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_50040138829"), _Datos.Leer_String("pr_50040138829.nombre"))
          me.PaisEmpresa = _Datos.Leer_String("pr_300401388212")
          me.DireccionEmpresa = _Datos.Leer_String("pr_300401388211")
          me.NIFEmpresa = _Datos.Leer_String("pr_300401388215")
          me.ProvinciaEmpresa = _Datos.Leer_String("pr_300401388213")
          me.DenominacionRazonSocialEmpresa = _Datos.Leer_String("pr_300401388214")
          me.MunicipioEmpresa = _Datos.Leer_String("pr_40040138823")
          me.DenominacionRazonSocialProveedor = _Datos.Leer_String("pr_50040138825")
          me.PaisProveedor = _Datos.Leer_String("pr_50040138821")
          me.ProvinciaProveedor = _Datos.Leer_String("pr_50040138822")
          me.TelefonoProveedor = _Datos.Leer_String("pr_50040138823")
          me.MunicipioProveedor = _Datos.Leer_String("pr_50040138828")
          me.CodigoPostalProveedor = _Datos.Leer_String("pr_50040138826")
          me.DireccionProveedor = _Datos.Leer_String("pr_50040138827")
          me.ReferenciaDatosFiscalesEmpresa = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_40040138821"), _Datos.Leer_String("pr_40040138821.nombre"))
          me.CodigoPostalEmpresa = _Datos.Leer_String("pr_300401388216")
          me.TelefonoEmpresa = _Datos.Leer_String("pr_40040138822")
          me.NIFProveedor = _Datos.Leer_String("pr_50040138824")
          me.NumeroDeFactura = _Datos.Leer_String("pr_60040145291001")
          me.ImporteImporteImpuestoGeneral = _Datos.Leer_Decimal("pr_30040148966")
          me.ReferenciaImpuestoGeneral = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_30040148967"), _Datos.Leer_String("pr_30040148967.nombre"))
          me.EsUnGastoSinFacturaObsoleto = _Datos.Leer_Boolean("pr_30040163143")
          me.MarcarComoConcluidaAunqueHayanProcesosPendientes = _Datos.Leer_Boolean("pr_10040173912")
          me.ValidoHasta = _Datos.Leer_Date_Nulable("pr_60040173902")
          me.Anulado = _Datos.Leer_Boolean("pr_10040173911")
          me.CondicionDePagoDias = _Datos.Leer_Integer("pr_60040176526")
          me.CondicionesDePago = _Datos.Leer_String("pr_60040176527")
          me.FechaDeVencimiento = _Datos.Leer_Date_Nulable("pr_60040176525")
          me.OperacionIntragrupoObsoleto = _Datos.Leer_Boolean("pr_40040238926")
          me.RegimenEspecialDeBienesUsadosObsoleto = _Datos.Leer_Boolean("pr_50040238944")
          me.InversionDelSujetoPasivoObsoleto = _Datos.Leer_Boolean("pr_10040238943")
          me.CodigoPaisProveedor = _Datos.Leer_String("pr_20040241546")
          me.CodigoProvinciaProveedor = _Datos.Leer_String("pr_20040241545")
          me.TipoNIFProveedor = _Datos.Leer_String("pr_20040241603")
          me.NIFIntracomunitarioEmpresa = _Datos.Leer_String("pr_40040255422")
          me.NIFIntracomunitarioProveedor = _Datos.Leer_String("pr_40040255421")
          me.ImporteTotalOperacion = _Datos.Leer_Decimal("pr_10040256633")
          me.ImporteTotalSuplidos = _Datos.Leer_Decimal("pr_10040256634")
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
         R.add("pr_40040105671153", me.ImporteSumaDeConceptosImpuestoExentos.AdaptarMySQL_Decimal())
         R.add("pr_40040105671157", me.ImporteImporteRetencion.AdaptarMySQL_Decimal())
         R.add("pr_40040105671156", me.DescuentoAdicionalAAplicadoPorciento.AdaptarMySQL_Decimal())
         If Me.ReferenciaDestinador IsNot nothing then
           R.add("pr_3004010555243",me.ReferenciaDestinador.ID.STR())
         Else
           R.add("pr_3004010555243","")
         End if
         R.add("pr_40040105671152", me.ImporteDescuentosGeneralImpuesto3.AdaptarMySQL_Decimal())
         R.add("pr_3004010555238", me.HoraLocal.AdaptarMySQL_Time_Nulable())
         R.add("pr_40040105671182", me.Observaciones.AdaptarMySQL_String())
         R.add("pr_40040105671158", me.ImporteCuotaImpuesto1.AdaptarMySQL_Decimal())
         If Me.ReferenciaUbicacionPrincipal IsNot nothing then
           R.add("pr_3004010555235",me.ReferenciaUbicacionPrincipal.ID.STR())
         Else
           R.add("pr_3004010555235","")
         End if
         R.add("pr_3004010555249", me.AutorDelAltaTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_40040105671145", me.DescuentoGeneralAplicadoPorciento.AdaptarMySQL_Decimal())
         If Me.ReferenciaProveedor IsNot nothing then
           R.add("pr_40040105671174",me.ReferenciaProveedor.ID.STR())
         Else
           R.add("pr_40040105671174","")
         End if
         If Me.ReferenciaEstado IsNot nothing then
           R.add("pr_40040105671175",me.ReferenciaEstado.ID.STR())
         Else
           R.add("pr_40040105671175","")
         End if
         R.add("pr_40040105671149", me.ImporteDescuentosGeneralImpuesto2.AdaptarMySQL_Decimal())
         R.add("pr_40040105671148", me.ImporteTotalImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_40040105671194", me.ImpuestosIncluidos.AdaptarMySQL_Boolean())
         R.add("pr_40040105671150", me.ImporteDescuentosGeneralImpuesto1.AdaptarMySQL_Decimal())
         R.add("pr_40040105671146", me.ImporteSumaImporteProductosConImpuestos.AdaptarMySQL_Decimal())
         If Me.ReferenciaConfiguracionDeCompra IsNot nothing then
           R.add("pr_40040105671176",me.ReferenciaConfiguracionDeCompra.ID.STR())
         Else
           R.add("pr_40040105671176","")
         End if
         If Me.ReferenciaImpuesto2 IsNot nothing then
           R.add("pr_40040105671177",me.ReferenciaImpuesto2.ID.STR())
         Else
           R.add("pr_40040105671177","")
         End if
         R.add("pr_40040105671147", me.ImporteCuotaREImpuesto3.AdaptarMySQL_Decimal())
         R.add("pr_40040105671137", me.ImporteCuotaREImpuesto1.AdaptarMySQL_Decimal())
         If Me.ReferenciaImpuesto3 IsNot nothing then
           R.add("pr_40040105671173",me.ReferenciaImpuesto3.ID.STR())
         Else
           R.add("pr_40040105671173","")
         End if
         R.add("pr_40040105671181", me.NumeroDeReferenciaInternaCompleto.AdaptarMySQL_String())
         R.add("pr_40040105671139", me.ImporteDescuentosProductoImpuesto2.AdaptarMySQL_Decimal())
         R.add("pr_40040105671179", me.DescripcionDescuentoAdicionalA.AdaptarMySQL_String())
         If Me.ReferenciaImpuesto1 IsNot nothing then
           R.add("pr_40040105671171",me.ReferenciaImpuesto1.ID.STR())
         Else
           R.add("pr_40040105671171","")
         End if
         R.add("pr_40040105671127", me.ImporteDescuentosProductoExento.AdaptarMySQL_Decimal())
         If Me.ReferenciaPuestoDeTrabajo IsNot nothing then
           R.add("pr_40040105671170",me.ReferenciaPuestoDeTrabajo.ID.STR())
         Else
           R.add("pr_40040105671170","")
         End if
         R.add("pr_40040105671123", me.ImporteSumaConceptosSinImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_40040105671124", me.ImporteTotalDescontadoSinImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_40040105671135", me.DescuentoAdicionalBAplicadoPorciento.AdaptarMySQL_Decimal())
         If Me.ReferenciaEmpleadoPrincipal IsNot nothing then
           R.add("pr_3004010555234",me.ReferenciaEmpleadoPrincipal.ID.STR())
         Else
           R.add("pr_3004010555234","")
         End if
         R.add("pr_40040105671128", me.CantidadDeProductos.AdaptarMySQL_Decimal())
         R.add("pr_40040105671180", me.DescripcionDescuentoAdicionalB.AdaptarMySQL_String())
         R.add("pr_40040105671130", me.ImporteCuotaREImpuesto2.AdaptarMySQL_Decimal())
         R.add("pr_40040105671131", me.TotalPorcentajeDescuentosGeneralesPorciento.AdaptarMySQL_Decimal())
         R.add("pr_40040105671132", me.ImporteSumaDeConceptosImpuesto2.AdaptarMySQL_Decimal())
         R.add("pr_40040105671110", me.ImporteCuotaImpuesto2.AdaptarMySQL_Decimal())
         R.add("pr_50040107181", me.CantidadDeProductosComprados.AdaptarMySQL_Decimal())
         R.add("pr_3004010555251", me.EmpleadoTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_40040105671108", me.ImporteBaseImponibleExenta.AdaptarMySQL_Decimal())
         R.add("pr_60040115045", me.SumaConceptosConImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_40040105671192", me.AplicarRecargoDeEquivalencia.AdaptarMySQL_Boolean())
         R.add("pr_40040105671119", me.ImporteBaseImponibleImpuesto2.AdaptarMySQL_Decimal())
         R.add("pr_40040105671121", me.ImporteBaseImponibleImpuesto3.AdaptarMySQL_Decimal())
         If Me.ReferenciaNumeracionSerie IsNot nothing then
           R.add("pr_40040105671169",me.ReferenciaNumeracionSerie.ID.STR())
         Else
           R.add("pr_40040105671169","")
         End if
         If Me.ReferenciaRetencion IsNot nothing then
           R.add("pr_40040105671168",me.ReferenciaRetencion.ID.STR())
         Else
           R.add("pr_40040105671168","")
         End if
         R.add("pr_40040105671186", me.NumeroDeReferenciaInterna.AdaptarMySQL_Integer())
         R.add("pr_3004010555240", me.FechaAlta_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_40040105671113", me.ImporteCuotaImpuesto3.AdaptarMySQL_Decimal())
         R.add("pr_3004010555237", me.FechaDato_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_40040105671099", me.ImporteDescuentoGeneralImpuestoExento.AdaptarMySQL_Decimal())
         R.add("pr_50040107182", me.CantidadDeProductosQueSePuedenComprar.AdaptarMySQL_Decimal())
         R.add("pr_40040105671101", me.ImporteSumaImporteDeProductosSinImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_40040105671105", me.ImporteBaseImponibleImpuesto1.AdaptarMySQL_Decimal())
         R.add("pr_40040105671103", me.ImporteDescuentosProductoImpuesto1.AdaptarMySQL_Decimal())
         R.add("pr_40040105671093", me.ImporteDescuentosProductoImpuesto3.AdaptarMySQL_Decimal())
         R.add("pr_40040105671092", me.ImporteTotal.AdaptarMySQL_Decimal())
         R.add("pr_40040105671097", me.ImporteSubtotal.AdaptarMySQL_Decimal())
         If Me.ReferenciaAutorDelAlta IsNot nothing then
           R.add("pr_3004010555236",me.ReferenciaAutorDelAlta.ID.STR())
         Else
           R.add("pr_3004010555236","")
         End if
         R.add("pr_40040105671178", me.ProveedorTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_40040105671094", me.ImporteSumaDeConceptosImpuesto3.AdaptarMySQL_Decimal())
         R.add("pr_40040105671084", me.DescuentoEntidadAplicadoPorciento.AdaptarMySQL_Decimal())
         If Me.ReferenciaTipoDeFactura IsNot nothing then
           R.add("pr_40040105671162",me.ReferenciaTipoDeFactura.ID.STR())
         Else
           R.add("pr_40040105671162","")
         End if
         R.add("pr_40040105671090", me.ImporteTotalDeduccion.AdaptarMySQL_Decimal())
         R.add("pr_40040105671088", me.ImporteSumaDeConceptosImpuesto1.AdaptarMySQL_Decimal())
         R.add("pr_40040135703", me.FechaContable.AdaptarMySQL_Date_Nulable())
         If Me.ReferenciaDatosFiscalesProveedor IsNot nothing then
           R.add("pr_50040138829",me.ReferenciaDatosFiscalesProveedor.ID.STR())
         Else
           R.add("pr_50040138829","")
         End if
         R.add("pr_300401388212", me.PaisEmpresa.AdaptarMySQL_String())
         R.add("pr_300401388211", me.DireccionEmpresa.AdaptarMySQL_String())
         R.add("pr_300401388215", me.NIFEmpresa.AdaptarMySQL_String())
         R.add("pr_300401388213", me.ProvinciaEmpresa.AdaptarMySQL_String())
         R.add("pr_300401388214", me.DenominacionRazonSocialEmpresa.AdaptarMySQL_String())
         R.add("pr_40040138823", me.MunicipioEmpresa.AdaptarMySQL_String())
         R.add("pr_50040138825", me.DenominacionRazonSocialProveedor.AdaptarMySQL_String())
         R.add("pr_50040138821", me.PaisProveedor.AdaptarMySQL_String())
         R.add("pr_50040138822", me.ProvinciaProveedor.AdaptarMySQL_String())
         R.add("pr_50040138823", me.TelefonoProveedor.AdaptarMySQL_String())
         R.add("pr_50040138828", me.MunicipioProveedor.AdaptarMySQL_String())
         R.add("pr_50040138826", me.CodigoPostalProveedor.AdaptarMySQL_String())
         R.add("pr_50040138827", me.DireccionProveedor.AdaptarMySQL_String())
         If Me.ReferenciaDatosFiscalesEmpresa IsNot nothing then
           R.add("pr_40040138821",me.ReferenciaDatosFiscalesEmpresa.ID.STR())
         Else
           R.add("pr_40040138821","")
         End if
         R.add("pr_300401388216", me.CodigoPostalEmpresa.AdaptarMySQL_String())
         R.add("pr_40040138822", me.TelefonoEmpresa.AdaptarMySQL_String())
         R.add("pr_50040138824", me.NIFProveedor.AdaptarMySQL_String())
         R.add("pr_60040145291001", me.NumeroDeFactura.AdaptarMySQL_String())
         R.add("pr_30040148966", me.ImporteImporteImpuestoGeneral.AdaptarMySQL_Decimal())
         If Me.ReferenciaImpuestoGeneral IsNot nothing then
           R.add("pr_30040148967",me.ReferenciaImpuestoGeneral.ID.STR())
         Else
           R.add("pr_30040148967","")
         End if
         R.add("pr_30040163143", me.EsUnGastoSinFacturaObsoleto.AdaptarMySQL_Boolean())
         R.add("pr_10040173912", me.MarcarComoConcluidaAunqueHayanProcesosPendientes.AdaptarMySQL_Boolean())
         R.add("pr_60040173902", me.ValidoHasta.AdaptarMySQL_Date_Nulable())
         R.add("pr_10040173911", me.Anulado.AdaptarMySQL_Boolean())
         R.add("pr_60040176526", me.CondicionDePagoDias.AdaptarMySQL_Integer())
         R.add("pr_60040176527", me.CondicionesDePago.AdaptarMySQL_String())
         R.add("pr_60040176525", me.FechaDeVencimiento.AdaptarMySQL_Date_Nulable())
         R.add("pr_40040238926", me.OperacionIntragrupoObsoleto.AdaptarMySQL_Boolean())
         R.add("pr_50040238944", me.RegimenEspecialDeBienesUsadosObsoleto.AdaptarMySQL_Boolean())
         R.add("pr_10040238943", me.InversionDelSujetoPasivoObsoleto.AdaptarMySQL_Boolean())
         R.add("pr_20040241546", me.CodigoPaisProveedor.AdaptarMySQL_String())
         R.add("pr_20040241545", me.CodigoProvinciaProveedor.AdaptarMySQL_String())
         R.add("pr_20040241603", me.TipoNIFProveedor.AdaptarMySQL_String())
         R.add("pr_40040255422", me.NIFIntracomunitarioEmpresa.AdaptarMySQL_String())
         R.add("pr_40040255421", me.NIFIntracomunitarioProveedor.AdaptarMySQL_String())
         R.add("pr_10040256633", me.ImporteTotalOperacion.AdaptarMySQL_Decimal())
         R.add("pr_10040256634", me.ImporteTotalSuplidos.AdaptarMySQL_Decimal())
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
      Public Class PresupuestosDeComprasYGastos_FormularioC
        Inherits DinaNETCore.VentanaVirtualC

    Public _Lista As List(Of PresupuestosDeComprasYGastosListaD.PresupuestosDeComprasYGastosLista_FormularioC)



    Overrides Sub Evento_Actualizar()

        If Me.EsListador Then
            Dim FormLista = Me.__VV__.Formularios_Lista
            Dim CreandoLista As New List(Of PresupuestosDeComprasYGastosListaD.PresupuestosDeComprasYGastosLista_FormularioC)
            If FormLista IsNot Nothing Then
                For i = 0 To FormLista.Count - 1
                    Dim ElementoLista As New PresupuestosDeComprasYGastosListaD.PresupuestosDeComprasYGastosLista_FormularioC(Me.__VV__, FormLista(i).Token)
                    CreandoLista.Add(ElementoLista)
                Next
            End If
            _Lista = CreandoLista
        End If

    End Sub

                  


        Public ReadOnly property ImporteSumaDeConceptosImpuestoExentos As Decimal
            get
                return me.GetValue_Decimal("pr_40040105671153")
            End Get   
        End Property
        Public ReadOnly property ImporteImporteRetencion As Decimal
            get
                return me.GetValue_Decimal("pr_40040105671157")
            End Get   
        End Property
          Public property DescuentoAdicionalAAplicadoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_40040105671156")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_40040105671156", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_3004010555243")
            End Get   
        End Property
        Public ReadOnly property ImporteDescuentosGeneralImpuesto3 As Decimal
            get
                return me.GetValue_Decimal("pr_40040105671152")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As DateTime
            get
                return me.GetValue_DateTime("pr_3004010555238")
            End Get   
        End Property
          Public property Observaciones As String
            get
                return me.GetValue_String("pr_40040105671182")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040105671182", value)
            End Set
          End Property
        Public ReadOnly property ImporteCuotaImpuesto1 As Decimal
            get
                return me.GetValue_Decimal("pr_40040105671158")
            End Get   
        End Property
          Public property ReferenciaUbicacionPrincipal As Guid
            get
                return me.GetValue_Guid("pr_3004010555235")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_3004010555235", value)
            End Set
          End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_3004010555249")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_3004010555249", value)
            End Set
          End Property
          Public property DescuentoGeneralAplicadoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_40040105671145")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_40040105671145", value)
            End Set
          End Property
          Public property ReferenciaProveedor As Guid
            get
                return me.GetValue_Guid("pr_40040105671174")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_40040105671174", value)
            End Set
          End Property
          Public property ReferenciaEstado As Guid
            get
                return me.GetValue_Guid("pr_40040105671175")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_40040105671175", value)
            End Set
          End Property
        Public ReadOnly property ImporteDescuentosGeneralImpuesto2 As Decimal
            get
                return me.GetValue_Decimal("pr_40040105671149")
            End Get   
        End Property
        Public ReadOnly property ImporteTotalImpuestos As Decimal
            get
                return me.GetValue_Decimal("pr_40040105671148")
            End Get   
        End Property
          Public property ImpuestosIncluidos As Boolean
            get
                return me.GetValue_Boolean("pr_40040105671194")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_40040105671194", value)
            End Set
          End Property
        Public ReadOnly property ImporteDescuentosGeneralImpuesto1 As Decimal
            get
                return me.GetValue_Decimal("pr_40040105671150")
            End Get   
        End Property
        Public ReadOnly property ImporteSumaImporteProductosConImpuestos As Decimal
            get
                return me.GetValue_Decimal("pr_40040105671146")
            End Get   
        End Property
          Public property ReferenciaConfiguracionDeCompra As Guid
            get
                return me.GetValue_Guid("pr_40040105671176")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_40040105671176", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaImpuesto2 As Guid
            get
                return me.GetValue_Guid("pr_40040105671177")
            End Get   
        End Property
        Public ReadOnly property ImporteCuotaREImpuesto3 As Decimal
            get
                return me.GetValue_Decimal("pr_40040105671147")
            End Get   
        End Property
        Public ReadOnly property ImporteCuotaREImpuesto1 As Decimal
            get
                return me.GetValue_Decimal("pr_40040105671137")
            End Get   
        End Property
        Public ReadOnly property ReferenciaImpuesto3 As Guid
            get
                return me.GetValue_Guid("pr_40040105671173")
            End Get   
        End Property
          Public property NumeroDeReferenciaInternaCompleto As String
            get
                return me.GetValue_String("pr_40040105671181")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040105671181", value)
            End Set
          End Property
        Public ReadOnly property ImporteDescuentosProductoImpuesto2 As Decimal
            get
                return me.GetValue_Decimal("pr_40040105671139")
            End Get   
        End Property
          Public property DescripcionDescuentoAdicionalA As String
            get
                return me.GetValue_String("pr_40040105671179")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040105671179", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaImpuesto1 As Guid
            get
                return me.GetValue_Guid("pr_40040105671171")
            End Get   
        End Property
        Public ReadOnly property ImporteDescuentosProductoExento As Decimal
            get
                return me.GetValue_Decimal("pr_40040105671127")
            End Get   
        End Property
          Public property ReferenciaPuestoDeTrabajo As Guid
            get
                return me.GetValue_Guid("pr_40040105671170")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_40040105671170", value)
            End Set
          End Property
        Public ReadOnly property ImporteSumaConceptosSinImpuestos As Decimal
            get
                return me.GetValue_Decimal("pr_40040105671123")
            End Get   
        End Property
        Public ReadOnly property ImporteTotalDescontadoSinImpuestos As Decimal
            get
                return me.GetValue_Decimal("pr_40040105671124")
            End Get   
        End Property
          Public property DescuentoAdicionalBAplicadoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_40040105671135")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_40040105671135", value)
            End Set
          End Property
          Public property ReferenciaEmpleadoPrincipal As Guid
            get
                return me.GetValue_Guid("pr_3004010555234")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_3004010555234", value)
            End Set
          End Property
        Public ReadOnly property CantidadDeProductos As Decimal
            get
                return me.GetValue_Decimal("pr_40040105671128")
            End Get   
        End Property
          Public property DescripcionDescuentoAdicionalB As String
            get
                return me.GetValue_String("pr_40040105671180")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040105671180", value)
            End Set
          End Property
        Public ReadOnly property ImporteCuotaREImpuesto2 As Decimal
            get
                return me.GetValue_Decimal("pr_40040105671130")
            End Get   
        End Property
        Public ReadOnly property TotalPorcentajeDescuentosGeneralesPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_40040105671131")
            End Get   
        End Property
        Public ReadOnly property ImporteSumaDeConceptosImpuesto2 As Decimal
            get
                return me.GetValue_Decimal("pr_40040105671132")
            End Get   
        End Property
        Public ReadOnly property ImporteCuotaImpuesto2 As Decimal
            get
                return me.GetValue_Decimal("pr_40040105671110")
            End Get   
        End Property
        Public ReadOnly property CantidadDeProductosComprados As Decimal
            get
                return me.GetValue_Decimal("pr_50040107181")
            End Get   
        End Property
          Public property EmpleadoTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_3004010555251")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_3004010555251", value)
            End Set
          End Property
        Public ReadOnly property ImporteBaseImponibleExenta As Decimal
            get
                return me.GetValue_Decimal("pr_40040105671108")
            End Get   
        End Property
        Public ReadOnly property SumaConceptosConImpuestos As Decimal
            get
                return me.GetValue_Decimal("pr_60040115045")
            End Get   
        End Property
          Public property AplicarRecargoDeEquivalencia As Boolean
            get
                return me.GetValue_Boolean("pr_40040105671192")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_40040105671192", value)
            End Set
          End Property
        Public ReadOnly property ImporteBaseImponibleImpuesto2 As Decimal
            get
                return me.GetValue_Decimal("pr_40040105671119")
            End Get   
        End Property
        Public ReadOnly property ImporteBaseImponibleImpuesto3 As Decimal
            get
                return me.GetValue_Decimal("pr_40040105671121")
            End Get   
        End Property
          Public property ReferenciaNumeracionSerie As Guid
            get
                return me.GetValue_Guid("pr_40040105671169")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_40040105671169", value)
            End Set
          End Property
          Public property ReferenciaRetencion As Guid
            get
                return me.GetValue_Guid("pr_40040105671168")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_40040105671168", value)
            End Set
          End Property
          Public property NumeroDeReferenciaInterna As Integer
            get
                return me.GetValue_Int("pr_40040105671186")
            End Get
            Set(value As Integer)
                me.SetValue_Int("pr_40040105671186", value)
            End Set
          End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_3004010555240")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_3004010555240", value)
            End Set
          End Property
        Public ReadOnly property ImporteCuotaImpuesto3 As Decimal
            get
                return me.GetValue_Decimal("pr_40040105671113")
            End Get   
        End Property
          Public property FechaDato_UTC As Date
            get
                return me.GetValue_DateTime("pr_3004010555237")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_3004010555237", value)
            End Set
          End Property
        Public ReadOnly property ImporteDescuentoGeneralImpuestoExento As Decimal
            get
                return me.GetValue_Decimal("pr_40040105671099")
            End Get   
        End Property
        Public ReadOnly property CantidadDeProductosQueSePuedenComprar As Decimal
            get
                return me.GetValue_Decimal("pr_50040107182")
            End Get   
        End Property
        Public ReadOnly property ImporteSumaImporteDeProductosSinImpuestos As Decimal
            get
                return me.GetValue_Decimal("pr_40040105671101")
            End Get   
        End Property
        Public ReadOnly property ImporteBaseImponibleImpuesto1 As Decimal
            get
                return me.GetValue_Decimal("pr_40040105671105")
            End Get   
        End Property
        Public ReadOnly property ImporteDescuentosProductoImpuesto1 As Decimal
            get
                return me.GetValue_Decimal("pr_40040105671103")
            End Get   
        End Property
        Public ReadOnly property ImporteDescuentosProductoImpuesto3 As Decimal
            get
                return me.GetValue_Decimal("pr_40040105671093")
            End Get   
        End Property
        Public ReadOnly property ImporteTotal As Decimal
            get
                return me.GetValue_Decimal("pr_40040105671092")
            End Get   
        End Property
        Public ReadOnly property ImporteSubtotal As Decimal
            get
                return me.GetValue_Decimal("pr_40040105671097")
            End Get   
        End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_3004010555236")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_3004010555236", value)
            End Set
          End Property
          Public property ProveedorTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_40040105671178")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_40040105671178", value)
            End Set
          End Property
        Public ReadOnly property ImporteSumaDeConceptosImpuesto3 As Decimal
            get
                return me.GetValue_Decimal("pr_40040105671094")
            End Get   
        End Property
          Public property DescuentoEntidadAplicadoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_40040105671084")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_40040105671084", value)
            End Set
          End Property
          Public property ReferenciaTipoDeFactura As Guid
            get
                return me.GetValue_Guid("pr_40040105671162")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_40040105671162", value)
            End Set
          End Property
        Public ReadOnly property ImporteTotalDeduccion As Decimal
            get
                return me.GetValue_Decimal("pr_40040105671090")
            End Get   
        End Property
        Public ReadOnly property ImporteSumaDeConceptosImpuesto1 As Decimal
            get
                return me.GetValue_Decimal("pr_40040105671088")
            End Get   
        End Property
          Public property FechaContable As Date
            get
                return me.GetValue_Date("pr_40040135703")
            End Get
            Set(value As Date)
                me.SetValue_Date("pr_40040135703", value)
            End Set
          End Property
          Public property ReferenciaDatosFiscalesProveedor As Guid
            get
                return me.GetValue_Guid("pr_50040138829")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_50040138829", value)
            End Set
          End Property
          Public property PaisEmpresa As String
            get
                return me.GetValue_String("pr_300401388212")
            End Get
            Set(value As String)
                me.SetValue_String("pr_300401388212", value)
            End Set
          End Property
          Public property DireccionEmpresa As String
            get
                return me.GetValue_String("pr_300401388211")
            End Get
            Set(value As String)
                me.SetValue_String("pr_300401388211", value)
            End Set
          End Property
          Public property NIFEmpresa As String
            get
                return me.GetValue_String("pr_300401388215")
            End Get
            Set(value As String)
                me.SetValue_String("pr_300401388215", value)
            End Set
          End Property
          Public property ProvinciaEmpresa As String
            get
                return me.GetValue_String("pr_300401388213")
            End Get
            Set(value As String)
                me.SetValue_String("pr_300401388213", value)
            End Set
          End Property
          Public property DenominacionRazonSocialEmpresa As String
            get
                return me.GetValue_String("pr_300401388214")
            End Get
            Set(value As String)
                me.SetValue_String("pr_300401388214", value)
            End Set
          End Property
          Public property MunicipioEmpresa As String
            get
                return me.GetValue_String("pr_40040138823")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040138823", value)
            End Set
          End Property
          Public property DenominacionRazonSocialProveedor As String
            get
                return me.GetValue_String("pr_50040138825")
            End Get
            Set(value As String)
                me.SetValue_String("pr_50040138825", value)
            End Set
          End Property
          Public property PaisProveedor As String
            get
                return me.GetValue_String("pr_50040138821")
            End Get
            Set(value As String)
                me.SetValue_String("pr_50040138821", value)
            End Set
          End Property
          Public property ProvinciaProveedor As String
            get
                return me.GetValue_String("pr_50040138822")
            End Get
            Set(value As String)
                me.SetValue_String("pr_50040138822", value)
            End Set
          End Property
          Public property TelefonoProveedor As String
            get
                return me.GetValue_String("pr_50040138823")
            End Get
            Set(value As String)
                me.SetValue_String("pr_50040138823", value)
            End Set
          End Property
          Public property MunicipioProveedor As String
            get
                return me.GetValue_String("pr_50040138828")
            End Get
            Set(value As String)
                me.SetValue_String("pr_50040138828", value)
            End Set
          End Property
          Public property CodigoPostalProveedor As String
            get
                return me.GetValue_String("pr_50040138826")
            End Get
            Set(value As String)
                me.SetValue_String("pr_50040138826", value)
            End Set
          End Property
          Public property DireccionProveedor As String
            get
                return me.GetValue_String("pr_50040138827")
            End Get
            Set(value As String)
                me.SetValue_String("pr_50040138827", value)
            End Set
          End Property
          Public property ReferenciaDatosFiscalesEmpresa As Guid
            get
                return me.GetValue_Guid("pr_40040138821")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_40040138821", value)
            End Set
          End Property
          Public property CodigoPostalEmpresa As String
            get
                return me.GetValue_String("pr_300401388216")
            End Get
            Set(value As String)
                me.SetValue_String("pr_300401388216", value)
            End Set
          End Property
          Public property TelefonoEmpresa As String
            get
                return me.GetValue_String("pr_40040138822")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040138822", value)
            End Set
          End Property
          Public property NIFProveedor As String
            get
                return me.GetValue_String("pr_50040138824")
            End Get
            Set(value As String)
                me.SetValue_String("pr_50040138824", value)
            End Set
          End Property
          Public property NumeroDeFactura As String
            get
                return me.GetValue_String("pr_60040145291001")
            End Get
            Set(value As String)
                me.SetValue_String("pr_60040145291001", value)
            End Set
          End Property
        Public ReadOnly property ImporteImporteImpuestoGeneral As Decimal
            get
                return me.GetValue_Decimal("pr_30040148966")
            End Get   
        End Property
          Public property ReferenciaImpuestoGeneral As Guid
            get
                return me.GetValue_Guid("pr_30040148967")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_30040148967", value)
            End Set
          End Property
          Public property EsUnGastoSinFacturaObsoleto As Boolean
            get
                return me.GetValue_Boolean("pr_30040163143")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_30040163143", value)
            End Set
          End Property
          Public property MarcarComoConcluidaAunqueHayanProcesosPendientes As Boolean
            get
                return me.GetValue_Boolean("pr_10040173912")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_10040173912", value)
            End Set
          End Property
          Public property ValidoHasta As Date
            get
                return me.GetValue_Date("pr_60040173902")
            End Get
            Set(value As Date)
                me.SetValue_Date("pr_60040173902", value)
            End Set
          End Property
          Public property Anulado As Boolean
            get
                return me.GetValue_Boolean("pr_10040173911")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_10040173911", value)
            End Set
          End Property
          Public property CondicionDePagoDias As Integer
            get
                return me.GetValue_Int("pr_60040176526")
            End Get
            Set(value As Integer)
                me.SetValue_Int("pr_60040176526", value)
            End Set
          End Property
          Public property CondicionesDePago As String
            get
                return me.GetValue_String("pr_60040176527")
            End Get
            Set(value As String)
                me.SetValue_String("pr_60040176527", value)
            End Set
          End Property
          Public property FechaDeVencimiento As Date
            get
                return me.GetValue_Date("pr_60040176525")
            End Get
            Set(value As Date)
                me.SetValue_Date("pr_60040176525", value)
            End Set
          End Property
          Public property OperacionIntragrupoObsoleto As Boolean
            get
                return me.GetValue_Boolean("pr_40040238926")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_40040238926", value)
            End Set
          End Property
          Public property RegimenEspecialDeBienesUsadosObsoleto As Boolean
            get
                return me.GetValue_Boolean("pr_50040238944")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_50040238944", value)
            End Set
          End Property
          Public property InversionDelSujetoPasivoObsoleto As Boolean
            get
                return me.GetValue_Boolean("pr_10040238943")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_10040238943", value)
            End Set
          End Property
          Public property CodigoPaisProveedor As String
            get
                return me.GetValue_String("pr_20040241546")
            End Get
            Set(value As String)
                me.SetValue_String("pr_20040241546", value)
            End Set
          End Property
          Public property CodigoProvinciaProveedor As String
            get
                return me.GetValue_String("pr_20040241545")
            End Get
            Set(value As String)
                me.SetValue_String("pr_20040241545", value)
            End Set
          End Property
          Public property TipoNIFProveedor As String
            get
                return me.GetValue_String("pr_20040241603")
            End Get
            Set(value As String)
                me.SetValue_String("pr_20040241603", value)
            End Set
          End Property
          Public property NIFIntracomunitarioEmpresa As String
            get
                return me.GetValue_String("pr_40040255422")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040255422", value)
            End Set
          End Property
          Public property NIFIntracomunitarioProveedor As String
            get
                return me.GetValue_String("pr_40040255421")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040255421", value)
            End Set
          End Property
        Public ReadOnly property ImporteTotalOperacion As Decimal
            get
                return me.GetValue_Decimal("pr_10040256633")
            End Get   
        End Property
        Public ReadOnly property ImporteTotalSuplidos As Decimal
            get
                return me.GetValue_Decimal("pr_10040256634")
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
