   Imports System.ComponentModel
   Imports DinaNETCore
   Imports DinaNETCore.APID
Partial Public Class SeccionesD
  Public Class PacksDeProductosDeVentaBaseD
      Public Class PacksDeProductosDeVentaBase_ConListaC
      Public Listador as PacksDeProductosDeVentaBaseC
      Public Lista As New List(of PacksDeProductosDeVentaBaseListaD.PacksDeProductosDeVentaBaseListaC)
        sub new(_listador  as PacksDeProductosDeVentaBaseC, _lista as List(of PacksDeProductosDeVentaBaseListaD.PacksDeProductosDeVentaBaseListaC))
           me.Listador =_listador 
           me.Lista =_lista 
        End sub
      End Class
      Public Shared _SeccionID As String = "08989c47-907e-4cd2-ad21-88aa260c03a4"
      Public Shared _SeccionIDGUID As New Guid("08989c47-907e-4cd2-ad21-88aa260c03a4")
      Public Shared Async Function ConsultarDatos_Async(Parametros As SeccionConsultaParametrosC) As Task(Of List(Of PacksDeProductosDeVentaBaseC )) 
          Dim R As New List(Of PacksDeProductosDeVentaBaseC )  
          Dim d = Await Parametros.DinaupSesion.ConexionServidor.Funcion_Datos_Recibir_Async(PacksDeProductosDeVentaBaseES._SeccionID, False, Parametros) 
          If d.Datos.TieneDatos Then 
              For Each Actual In d.Datos 
                  Dim Valores_Listador = Actual.Value.Item1
                  Dim Obj_Listador As New PacksDeProductosDeVentaBaseC 
                  Obj_Listador.CargarDatos(Valores_Listador) 
                  Obj_Listador.CargaInterna(Actual.Value)
                  R.Add(Obj_Listador) 
              Next 
          End If 
          Return R 
      End Function 
      Public Shared Async Function ConsultarDatos_ConLista_Async(  Parametros As SeccionConsultaParametrosC ) As Task(Of List(Of  PacksDeProductosDeVentaBase_ConListaC)) 
          Dim R As New List(Of PacksDeProductosDeVentaBase_ConListaC )  
          Dim d =  Await Parametros.DinaupSesion.ConexionServidor.Funcion_Datos_Recibir_Async(PacksDeProductosDeVentaBaseES._SeccionID, True, Parametros) 
          If d.Datos.TieneDatos Then 
              For Each Actual In d.Datos 
                  Dim Valores_Listador = Actual.Value.Item1
                  Dim Valores_Lista = Actual.Value.Item2
                  Dim Obj_Listador As New PacksDeProductosDeVentaBaseC 
                  Obj_Listador.CargarDatos(Valores_Listador) 
                  Obj_Listador.CargaInterna(Actual.Value)
                  Dim Objs_Listas As New List(Of PacksDeProductosDeVentaBaseListaD.PacksDeProductosDeVentaBaseListaC) 
                  If Valores_Lista.TieneDatos Then  
                      For Each ValoresLista In Valores_Lista 
                         Dim nItem As New PacksDeProductosDeVentaBaseListaD.PacksDeProductosDeVentaBaseListaC 
                         nItem.CargarDatos(ValoresLista)   
                         Objs_Listas.Add(nItem)         
                      Next   
                  End If   
                  R.Add(New PacksDeProductosDeVentaBase_ConListaC(Obj_Listador, Objs_Listas))
              Next 
          End If 
          Return R 
      End Function 
      Public Class PacksDeProductosDeVentaBaseES
          Public shared _SeccionID as Guid = New Guid("08989c47-907e-4cd2-ad21-88aa260c03a4")
          Public shared _Tabla$ = "tpr_10040147991"
      Public Shared ReferenciaDestinador$ = "pr_100401479912"
      Public Shared ReferenciaAutorDelAlta$ = "pr_10040147997"
      Public Shared FechaAlta_UTC$ = "pr_100401479911"
      Public Shared ExportarEnModulos$ = "pr_100401479910"
      Public Shared HoraLocal$ = "pr_10040147999"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_100401479924"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_100401479921"
      Public Shared ReferenciaLimitarAUbicacion$ = "pr_20040147991"
      Public Shared ReferenciaLimitarATipoDeCliente$ = "pr_20040147992"
      Public Shared Descatalogado$ = "pr_20040147995"
      Public Shared ImpuestosIncluidos$ = "pr_30040148001"
      Public Shared ImporteDescuentoSaldoImpuesto1$ = "pr_100401481711"
      Public Shared ReferenciaResumenImpuesto1$ = "pr_10040148174"
      Public Shared ImporteDescuentosProductoImpuesto1$ = "pr_10040148175"
      Public Shared ImporteBaseImponibleImpuesto1$ = "pr_10040148176"
      Public Shared ImporteDescuentosGeneralImpuesto1$ = "pr_10040148177"
      Public Shared ImporteCuotaREImpuesto1$ = "pr_10040148178"
      Public Shared ImporteCuotaImpuesto1$ = "pr_10040148179"
      Public Shared ImporteSumaDeConceptosImpuesto1$ = "pr_100401481710"
      Public Shared ImporteDescuentosGeneralImpuesto2$ = "pr_100401481712"
      Public Shared ImporteDescuentoSaldoImpuesto2$ = "pr_100401481713"
      Public Shared ImporteSumaDeConceptosImpuesto2$ = "pr_100401481714"
      Public Shared ReferenciaResumenImpuesto2$ = "pr_20040148172"
      Public Shared ImporteDescuentosProductoImpuesto2$ = "pr_20040148173"
      Public Shared ImporteCuotaREImpuesto2$ = "pr_20040148174"
      Public Shared ImporteBaseImponibleImpuesto2$ = "pr_20040148175"
      Public Shared ImporteCuotaImpuesto2$ = "pr_20040148176"
      Public Shared ImporteBaseImponibleImpuesto3$ = "pr_20040148179"
      Public Shared ImporteSumaDeConceptosImpuesto3$ = "pr_200401481711"
      Public Shared ImporteDescuentosGeneralImpuesto3$ = "pr_200401481712"
      Public Shared ImporteDescuentoSaldoImpuesto3$ = "pr_200401481715"
      Public Shared ImporteDescuentoSaldoExento$ = "pr_200401481717"
      Public Shared ImporteSumaDeConceptosImpuestoExentos$ = "pr_200401481719"
      Public Shared ImporteCuotaREImpuesto3$ = "pr_20040148178"
      Public Shared ImporteDescuentosProductoImpuesto3$ = "pr_200401481713"
      Public Shared ReferenciaResumenImpuesto3$ = "pr_200401481714"
      Public Shared ImporteCuotaImpuesto3$ = "pr_200401481710"
      Public Shared ImporteDescuentoGeneralImpuestoExento$ = "pr_200401481718"
      Public Shared ImporteBaseImponibleExenta$ = "pr_200401481720"
      Public Shared ImporteDescuentosProductoExento$ = "pr_200401481721"
      Public Shared ImporteTotal$ = "pr_10040148261001"
      Public Shared ImporteTotalImpuestos$ = "pr_10040148261002"
      Public Shared ImporteTotalDescontadoSinImpuestos$ = "pr_10040148261003"
      Public Shared ImporteSubtotal$ = "pr_20040148261"
      Public Shared SumaConceptosConImpuestos$ = "pr_20040148262"
      Public Shared ImporteSumaConceptosSinImpuestos$ = "pr_20040148263"
      Public Shared ImporteSumaImporteDeProductosSinImpuestos$ = "pr_20040148264"
      Public Shared ImporteSumaImporteProductosConImpuestos$ = "pr_20040148265"
      Public Shared CantidadDeUnidades$ = "pr_40040148421"
      Public Shared Elementos$ = "pr_30040148421"
      Public Shared ReferenciaBasadoEnCatalogo$ = "pr_600401700020"
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
      Public Class PacksDeProductosDeVentaBaseC
      Inherits Base_DatoC
          <DisplayName("Destinador")>
          Public Property ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaDestinador As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaDestinador"",""etiqueta"": ""Destinador"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""relacionesindirectas"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Destinador"",""descripcion"": """",""keyword"": ""ReferenciaDestinador"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaDestinador
          <DisplayName("Autor del alta")>
          Public Property ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaAutorDelAlta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaAutorDelAlta"",""etiqueta"": ""Autor del alta"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta"",""descripcion"": """",""keyword"": ""ReferenciaAutorDelAlta"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaAutorDelAlta
          <DisplayName("Fecha Alta del registro")>
          Public Property FechaAlta_UTC As Date?
          Public Shared ___FechaAlta_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaAlta_UTC"",""etiqueta"": ""Fecha Alta del registro"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Alta del registro"",""descripcion"": """",""keyword"": ""FechaAlta_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaAlta_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaAlta_UTC
          <DisplayName("Hora local")>
          Public Property HoraLocal As DateTime?
          Public Shared ___HoraLocal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""HoraLocal"",""etiqueta"": ""Hora local"",""oculta"": false,""formato"": 8,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Hora local"",""descripcion"": """",""keyword"": ""HoraLocal"",""formato"": 8,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __HoraLocal As DinaNETCore.APID.DinaupAPI_CampoC = ___HoraLocal
          <DisplayName("Autor del alta Tiene Acceso web")>
          Public Property AutorDelAltaTieneAccesoWeb As Boolean
          Public Shared ___AutorDelAltaTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AutorDelAltaTieneAccesoWeb"",""etiqueta"": ""Autor del alta Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta Tiene Acceso web"",""descripcion"": """",""keyword"": ""AutorDelAltaTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AutorDelAltaTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___AutorDelAltaTieneAccesoWeb
          <DisplayName("Empleado Tiene Acceso web")>
          Public Property EmpleadoTieneAccesoWeb As Boolean
          Public Shared ___EmpleadoTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EmpleadoTieneAccesoWeb"",""etiqueta"": ""Empleado Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empleado Tiene Acceso web"",""descripcion"": """",""keyword"": ""EmpleadoTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EmpleadoTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___EmpleadoTieneAccesoWeb
          <DisplayName("Limitar a ubicación")>
          Public Property ReferenciaLimitarAUbicacion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaLimitarAUbicacion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaLimitarAUbicacion"",""etiqueta"": ""Limitar a ubicación"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""bffd6c6e-a75b-455f-8367-067e7bb2fb47"",""titulo"": ""Base - Ubicaciones"",""iconoid"": ""b985b58f-7275-46b8-9b66-2c54346b0185"",""etiquetasingular"": ""Ubicación"",""etiquetaplural"": ""Ubicaciones"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""bffd6c6e-a75b-455f-8367-067e7bb2fb47"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Limitar a ubicación"",""descripcion"": """",""keyword"": ""ReferenciaLimitarAUbicacion"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaLimitarAUbicacion As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaLimitarAUbicacion
          <DisplayName("Limitar a tipo de cliente")>
          Public Property ReferenciaLimitarATipoDeCliente As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaLimitarATipoDeCliente As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaLimitarATipoDeCliente"",""etiqueta"": ""Limitar a tipo de cliente"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""8b1fa053-5abe-406e-9760-584ed34a3b97"",""titulo"": ""Base - Tipos de entidad"",""iconoid"": ""48978f8a-f2bd-4695-a897-3a0e7bfdc979"",""etiquetasingular"": ""Tipo de entidad"",""etiquetaplural"": ""Tipos de entidad"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""8b1fa053-5abe-406e-9760-584ed34a3b97"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Limitar a tipo de cliente"",""descripcion"": """",""keyword"": ""ReferenciaLimitarATipoDeCliente"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaLimitarATipoDeCliente As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaLimitarATipoDeCliente
          <DisplayName("Descatalogado")>
          Public Property Descatalogado As Boolean
          Public Shared ___Descatalogado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Descatalogado"",""etiqueta"": ""Descatalogado"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descatalogado"",""descripcion"": """",""keyword"": ""Descatalogado"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Descatalogado As DinaNETCore.APID.DinaupAPI_CampoC = ___Descatalogado
          <DisplayName("Impuestos incluidos")>
          Public Property ImpuestosIncluidos As Boolean
          Public Shared ___ImpuestosIncluidos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImpuestosIncluidos"",""etiqueta"": ""Impuestos incluidos"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Impuestos incluidos"",""descripcion"": """",""keyword"": ""ImpuestosIncluidos"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImpuestosIncluidos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImpuestosIncluidos
          <DisplayName("Descuento saldo impuesto 1")>
          Public Property ImporteDescuentoSaldoImpuesto1 As Decimal
          Public Shared ___ImporteDescuentoSaldoImpuesto1 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentoSaldoImpuesto1"",""etiqueta"": ""Descuento saldo impuesto 1"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento saldo impuesto 1"",""descripcion"": """",""keyword"": ""ImporteDescuentoSaldoImpuesto1"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentoSaldoImpuesto1 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentoSaldoImpuesto1
          <DisplayName("Resumen Impuesto 1")>
          Public Property ReferenciaResumenImpuesto1 As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaResumenImpuesto1 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaResumenImpuesto1"",""etiqueta"": ""Resumen Impuesto 1"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""f3199ee0-dc83-4667-a9c1-f3b04e97a8a4"",""titulo"": ""Base - Impuestos"",""iconoid"": ""ff4a7189-6426-43b9-bdc4-070314999e81"",""etiquetasingular"": ""Impuesto"",""etiquetaplural"": ""Impuestos"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""f3199ee0-dc83-4667-a9c1-f3b04e97a8a4"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Resumen Impuesto 1"",""descripcion"": """",""keyword"": ""ReferenciaResumenImpuesto1"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaResumenImpuesto1 As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaResumenImpuesto1
          <DisplayName("Descuentos Producto Impuesto 1")>
          Public Property ImporteDescuentosProductoImpuesto1 As Decimal
          Public Shared ___ImporteDescuentosProductoImpuesto1 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentosProductoImpuesto1"",""etiqueta"": ""Descuentos Producto Impuesto 1"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuentos Producto Impuesto 1"",""descripcion"": """",""keyword"": ""ImporteDescuentosProductoImpuesto1"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentosProductoImpuesto1 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentosProductoImpuesto1
          <DisplayName("Base imponible impuesto 1")>
          Public Property ImporteBaseImponibleImpuesto1 As Decimal
          Public Shared ___ImporteBaseImponibleImpuesto1 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteBaseImponibleImpuesto1"",""etiqueta"": ""Base imponible impuesto 1"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Base imponible impuesto 1"",""descripcion"": """",""keyword"": ""ImporteBaseImponibleImpuesto1"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteBaseImponibleImpuesto1 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteBaseImponibleImpuesto1
          <DisplayName("Descuentos General Impuesto 1")>
          Public Property ImporteDescuentosGeneralImpuesto1 As Decimal
          Public Shared ___ImporteDescuentosGeneralImpuesto1 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentosGeneralImpuesto1"",""etiqueta"": ""Descuentos General Impuesto 1"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuentos General Impuesto 1"",""descripcion"": """",""keyword"": ""ImporteDescuentosGeneralImpuesto1"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentosGeneralImpuesto1 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentosGeneralImpuesto1
          <DisplayName("Cuota R.E Impuesto 1")>
          Public Property ImporteCuotaREImpuesto1 As Decimal
          Public Shared ___ImporteCuotaREImpuesto1 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteCuotaREImpuesto1"",""etiqueta"": ""Cuota R.E Impuesto 1"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cuota R.E Impuesto 1"",""descripcion"": """",""keyword"": ""ImporteCuotaREImpuesto1"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteCuotaREImpuesto1 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteCuotaREImpuesto1
          <DisplayName("Cuota Impuesto 1")>
          Public Property ImporteCuotaImpuesto1 As Decimal
          Public Shared ___ImporteCuotaImpuesto1 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteCuotaImpuesto1"",""etiqueta"": ""Cuota Impuesto 1"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cuota Impuesto 1"",""descripcion"": """",""keyword"": ""ImporteCuotaImpuesto1"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteCuotaImpuesto1 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteCuotaImpuesto1
          <DisplayName("Suma de conceptos Impuesto 1")>
          Public Property ImporteSumaDeConceptosImpuesto1 As Decimal
          Public Shared ___ImporteSumaDeConceptosImpuesto1 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSumaDeConceptosImpuesto1"",""etiqueta"": ""Suma de conceptos Impuesto 1"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Suma de conceptos Impuesto 1"",""descripcion"": """",""keyword"": ""ImporteSumaDeConceptosImpuesto1"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSumaDeConceptosImpuesto1 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSumaDeConceptosImpuesto1
          <DisplayName("Descuentos General Impuesto 2")>
          Public Property ImporteDescuentosGeneralImpuesto2 As Decimal
          Public Shared ___ImporteDescuentosGeneralImpuesto2 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentosGeneralImpuesto2"",""etiqueta"": ""Descuentos General Impuesto 2"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuentos General Impuesto 2"",""descripcion"": """",""keyword"": ""ImporteDescuentosGeneralImpuesto2"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentosGeneralImpuesto2 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentosGeneralImpuesto2
          <DisplayName("Descuento saldo impuesto 2")>
          Public Property ImporteDescuentoSaldoImpuesto2 As Decimal
          Public Shared ___ImporteDescuentoSaldoImpuesto2 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentoSaldoImpuesto2"",""etiqueta"": ""Descuento saldo impuesto 2"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento saldo impuesto 2"",""descripcion"": """",""keyword"": ""ImporteDescuentoSaldoImpuesto2"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentoSaldoImpuesto2 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentoSaldoImpuesto2
          <DisplayName("Suma de conceptos Impuesto 2")>
          Public Property ImporteSumaDeConceptosImpuesto2 As Decimal
          Public Shared ___ImporteSumaDeConceptosImpuesto2 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSumaDeConceptosImpuesto2"",""etiqueta"": ""Suma de conceptos Impuesto 2"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Suma de conceptos Impuesto 2"",""descripcion"": """",""keyword"": ""ImporteSumaDeConceptosImpuesto2"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSumaDeConceptosImpuesto2 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSumaDeConceptosImpuesto2
          <DisplayName("Resumen impuesto 2")>
          Public Property ReferenciaResumenImpuesto2 As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaResumenImpuesto2 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaResumenImpuesto2"",""etiqueta"": ""Resumen impuesto 2"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""f3199ee0-dc83-4667-a9c1-f3b04e97a8a4"",""titulo"": ""Base - Impuestos"",""iconoid"": ""ff4a7189-6426-43b9-bdc4-070314999e81"",""etiquetasingular"": ""Impuesto"",""etiquetaplural"": ""Impuestos"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""f3199ee0-dc83-4667-a9c1-f3b04e97a8a4"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Resumen impuesto 2"",""descripcion"": """",""keyword"": ""ReferenciaResumenImpuesto2"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaResumenImpuesto2 As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaResumenImpuesto2
          <DisplayName("Descuentos Producto Impuesto 2")>
          Public Property ImporteDescuentosProductoImpuesto2 As Decimal
          Public Shared ___ImporteDescuentosProductoImpuesto2 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentosProductoImpuesto2"",""etiqueta"": ""Descuentos Producto Impuesto 2"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuentos Producto Impuesto 2"",""descripcion"": """",""keyword"": ""ImporteDescuentosProductoImpuesto2"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentosProductoImpuesto2 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentosProductoImpuesto2
          <DisplayName("Cuota R.E Impuesto 2")>
          Public Property ImporteCuotaREImpuesto2 As Decimal
          Public Shared ___ImporteCuotaREImpuesto2 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteCuotaREImpuesto2"",""etiqueta"": ""Cuota R.E Impuesto 2"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cuota R.E Impuesto 2"",""descripcion"": """",""keyword"": ""ImporteCuotaREImpuesto2"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteCuotaREImpuesto2 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteCuotaREImpuesto2
          <DisplayName("Base imponible impuesto 2")>
          Public Property ImporteBaseImponibleImpuesto2 As Decimal
          Public Shared ___ImporteBaseImponibleImpuesto2 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteBaseImponibleImpuesto2"",""etiqueta"": ""Base imponible impuesto 2"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Base imponible impuesto 2"",""descripcion"": """",""keyword"": ""ImporteBaseImponibleImpuesto2"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteBaseImponibleImpuesto2 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteBaseImponibleImpuesto2
          <DisplayName("Cuota Impuesto 2")>
          Public Property ImporteCuotaImpuesto2 As Decimal
          Public Shared ___ImporteCuotaImpuesto2 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteCuotaImpuesto2"",""etiqueta"": ""Cuota Impuesto 2"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cuota Impuesto 2"",""descripcion"": """",""keyword"": ""ImporteCuotaImpuesto2"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteCuotaImpuesto2 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteCuotaImpuesto2
          <DisplayName("Base imponible impuesto 3")>
          Public Property ImporteBaseImponibleImpuesto3 As Decimal
          Public Shared ___ImporteBaseImponibleImpuesto3 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteBaseImponibleImpuesto3"",""etiqueta"": ""Base imponible impuesto 3"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Base imponible impuesto 3"",""descripcion"": """",""keyword"": ""ImporteBaseImponibleImpuesto3"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteBaseImponibleImpuesto3 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteBaseImponibleImpuesto3
          <DisplayName("Suma de conceptos Impuesto 3")>
          Public Property ImporteSumaDeConceptosImpuesto3 As Decimal
          Public Shared ___ImporteSumaDeConceptosImpuesto3 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSumaDeConceptosImpuesto3"",""etiqueta"": ""Suma de conceptos Impuesto 3"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Suma de conceptos Impuesto 3"",""descripcion"": """",""keyword"": ""ImporteSumaDeConceptosImpuesto3"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSumaDeConceptosImpuesto3 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSumaDeConceptosImpuesto3
          <DisplayName("Descuentos General Impuesto 3")>
          Public Property ImporteDescuentosGeneralImpuesto3 As Decimal
          Public Shared ___ImporteDescuentosGeneralImpuesto3 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentosGeneralImpuesto3"",""etiqueta"": ""Descuentos General Impuesto 3"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuentos General Impuesto 3"",""descripcion"": """",""keyword"": ""ImporteDescuentosGeneralImpuesto3"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentosGeneralImpuesto3 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentosGeneralImpuesto3
          <DisplayName("Descuento saldo impuesto 3")>
          Public Property ImporteDescuentoSaldoImpuesto3 As Decimal
          Public Shared ___ImporteDescuentoSaldoImpuesto3 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentoSaldoImpuesto3"",""etiqueta"": ""Descuento saldo impuesto 3"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento saldo impuesto 3"",""descripcion"": """",""keyword"": ""ImporteDescuentoSaldoImpuesto3"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentoSaldoImpuesto3 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentoSaldoImpuesto3
          <DisplayName("Descuento saldo exento")>
          Public Property ImporteDescuentoSaldoExento As Decimal
          Public Shared ___ImporteDescuentoSaldoExento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentoSaldoExento"",""etiqueta"": ""Descuento saldo exento"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento saldo exento"",""descripcion"": """",""keyword"": ""ImporteDescuentoSaldoExento"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentoSaldoExento As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentoSaldoExento
          <DisplayName("Suma de conceptos Impuesto Exentos")>
          Public Property ImporteSumaDeConceptosImpuestoExentos As Decimal
          Public Shared ___ImporteSumaDeConceptosImpuestoExentos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSumaDeConceptosImpuestoExentos"",""etiqueta"": ""Suma de conceptos Impuesto Exentos"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Suma de conceptos Impuesto Exentos"",""descripcion"": """",""keyword"": ""ImporteSumaDeConceptosImpuestoExentos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSumaDeConceptosImpuestoExentos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSumaDeConceptosImpuestoExentos
          <DisplayName("Cuota R.E Impuesto 3")>
          Public Property ImporteCuotaREImpuesto3 As Decimal
          Public Shared ___ImporteCuotaREImpuesto3 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteCuotaREImpuesto3"",""etiqueta"": ""Cuota R.E Impuesto 3"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cuota R.E Impuesto 3"",""descripcion"": """",""keyword"": ""ImporteCuotaREImpuesto3"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteCuotaREImpuesto3 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteCuotaREImpuesto3
          <DisplayName("Descuentos Producto Impuesto 3")>
          Public Property ImporteDescuentosProductoImpuesto3 As Decimal
          Public Shared ___ImporteDescuentosProductoImpuesto3 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentosProductoImpuesto3"",""etiqueta"": ""Descuentos Producto Impuesto 3"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuentos Producto Impuesto 3"",""descripcion"": """",""keyword"": ""ImporteDescuentosProductoImpuesto3"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentosProductoImpuesto3 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentosProductoImpuesto3
          <DisplayName("Resumen impuesto 3")>
          Public Property ReferenciaResumenImpuesto3 As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaResumenImpuesto3 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaResumenImpuesto3"",""etiqueta"": ""Resumen impuesto 3"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""f3199ee0-dc83-4667-a9c1-f3b04e97a8a4"",""titulo"": ""Base - Impuestos"",""iconoid"": ""ff4a7189-6426-43b9-bdc4-070314999e81"",""etiquetasingular"": ""Impuesto"",""etiquetaplural"": ""Impuestos"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""f3199ee0-dc83-4667-a9c1-f3b04e97a8a4"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Resumen impuesto 3"",""descripcion"": """",""keyword"": ""ReferenciaResumenImpuesto3"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaResumenImpuesto3 As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaResumenImpuesto3
          <DisplayName("Cuota Impuesto 3")>
          Public Property ImporteCuotaImpuesto3 As Decimal
          Public Shared ___ImporteCuotaImpuesto3 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteCuotaImpuesto3"",""etiqueta"": ""Cuota Impuesto 3"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cuota Impuesto 3"",""descripcion"": """",""keyword"": ""ImporteCuotaImpuesto3"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteCuotaImpuesto3 As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteCuotaImpuesto3
          <DisplayName("Descuento General impuesto Exento")>
          Public Property ImporteDescuentoGeneralImpuestoExento As Decimal
          Public Shared ___ImporteDescuentoGeneralImpuestoExento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentoGeneralImpuestoExento"",""etiqueta"": ""Descuento General impuesto Exento"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento General impuesto Exento"",""descripcion"": """",""keyword"": ""ImporteDescuentoGeneralImpuestoExento"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentoGeneralImpuestoExento As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentoGeneralImpuestoExento
          <DisplayName("Base imponible Exenta")>
          Public Property ImporteBaseImponibleExenta As Decimal
          Public Shared ___ImporteBaseImponibleExenta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteBaseImponibleExenta"",""etiqueta"": ""Base imponible Exenta"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Base imponible Exenta"",""descripcion"": """",""keyword"": ""ImporteBaseImponibleExenta"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteBaseImponibleExenta As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteBaseImponibleExenta
          <DisplayName("Descuentos Producto Exento")>
          Public Property ImporteDescuentosProductoExento As Decimal
          Public Shared ___ImporteDescuentosProductoExento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentosProductoExento"",""etiqueta"": ""Descuentos Producto Exento"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuentos Producto Exento"",""descripcion"": """",""keyword"": ""ImporteDescuentosProductoExento"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentosProductoExento As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentosProductoExento
          <DisplayName("Total")>
          Public Property ImporteTotal As Decimal
          Public Shared ___ImporteTotal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteTotal"",""etiqueta"": ""Total"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total"",""descripcion"": """",""keyword"": ""ImporteTotal"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteTotal As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteTotal
          <DisplayName("Total impuestos")>
          Public Property ImporteTotalImpuestos As Decimal
          Public Shared ___ImporteTotalImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteTotalImpuestos"",""etiqueta"": ""Total impuestos"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total impuestos"",""descripcion"": """",""keyword"": ""ImporteTotalImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteTotalImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteTotalImpuestos
          <DisplayName("Total Descontado (Sin impuestos)")>
          Public Property ImporteTotalDescontadoSinImpuestos As Decimal
          Public Shared ___ImporteTotalDescontadoSinImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteTotalDescontadoSinImpuestos"",""etiqueta"": ""Total Descontado (Sin impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total Descontado (Sin impuestos)"",""descripcion"": """",""keyword"": ""ImporteTotalDescontadoSinImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteTotalDescontadoSinImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteTotalDescontadoSinImpuestos
          <DisplayName("Subtotal")>
          Public Property ImporteSubtotal As Decimal
          Public Shared ___ImporteSubtotal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSubtotal"",""etiqueta"": ""Subtotal"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Subtotal"",""descripcion"": """",""keyword"": ""ImporteSubtotal"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSubtotal As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSubtotal
          <DisplayName("Suma conceptos (Con impuestos)")>
          Public Property SumaConceptosConImpuestos As Decimal
          Public Shared ___SumaConceptosConImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""SumaConceptosConImpuestos"",""etiqueta"": ""Suma conceptos (Con impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Suma conceptos (Con impuestos)"",""descripcion"": """",""keyword"": ""SumaConceptosConImpuestos"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __SumaConceptosConImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___SumaConceptosConImpuestos
          <DisplayName("Suma conceptos (Sin impuestos)")>
          Public Property ImporteSumaConceptosSinImpuestos As Decimal
          Public Shared ___ImporteSumaConceptosSinImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSumaConceptosSinImpuestos"",""etiqueta"": ""Suma conceptos (Sin impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Suma conceptos (Sin impuestos)"",""descripcion"": """",""keyword"": ""ImporteSumaConceptosSinImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSumaConceptosSinImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSumaConceptosSinImpuestos
          <DisplayName("Suma importe de productos (Sin Impuestos)")>
          Public Property ImporteSumaImporteDeProductosSinImpuestos As Decimal
          Public Shared ___ImporteSumaImporteDeProductosSinImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSumaImporteDeProductosSinImpuestos"",""etiqueta"": ""Suma importe de productos (Sin Impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Suma importe de productos (Sin Impuestos)"",""descripcion"": """",""keyword"": ""ImporteSumaImporteDeProductosSinImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSumaImporteDeProductosSinImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSumaImporteDeProductosSinImpuestos
          <DisplayName("Suma Importe Productos (Con impuestos)")>
          Public Property ImporteSumaImporteProductosConImpuestos As Decimal
          Public Shared ___ImporteSumaImporteProductosConImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSumaImporteProductosConImpuestos"",""etiqueta"": ""Suma Importe Productos (Con impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Suma Importe Productos (Con impuestos)"",""descripcion"": """",""keyword"": ""ImporteSumaImporteProductosConImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSumaImporteProductosConImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSumaImporteProductosConImpuestos
          <DisplayName("Cantidad de unidades")>
          Public Property CantidadDeUnidades As Decimal
          Public Shared ___CantidadDeUnidades As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CantidadDeUnidades"",""etiqueta"": ""Cantidad de unidades"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cantidad de unidades"",""descripcion"": """",""keyword"": ""CantidadDeUnidades"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CantidadDeUnidades As DinaNETCore.APID.DinaupAPI_CampoC = ___CantidadDeUnidades
          <DisplayName("Elementos")>
          Public Property Elementos As Integer
          Public Shared ___Elementos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Elementos"",""etiqueta"": ""Elementos"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Elementos"",""descripcion"": """",""keyword"": ""Elementos"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Elementos As DinaNETCore.APID.DinaupAPI_CampoC = ___Elementos
          <DisplayName("Basado en catálogo")>
          Public Property ReferenciaBasadoEnCatalogo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaBasadoEnCatalogo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaBasadoEnCatalogo"",""etiqueta"": ""Basado en catálogo"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""e15a2977-589a-4981-bce0-6e1f8f320bc2"",""titulo"": ""Base - Catálogos de productos"",""iconoid"": ""dbbbc82f-61ee-4f21-85dc-42dff46157cd"",""etiquetasingular"": ""Catálogo de productos"",""etiquetaplural"": ""Catálogos de productos"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""e15a2977-589a-4981-bce0-6e1f8f320bc2"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Basado en catálogo"",""descripcion"": """",""keyword"": ""ReferenciaBasadoEnCatalogo"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaBasadoEnCatalogo As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaBasadoEnCatalogo
          <ReadOnlyAttribute(True)>
          <DisplayName("ID")>
          Public Property ID As Guid
          Public Shared ___ID As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": true,""eseliminado"": false,""keyword"": ""ID"",""etiqueta"": ""ID"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""08989c47-907e-4cd2-ad21-88aa260c03a4"",""titulo"": ""Base - Packs de productos de venta"",""iconoid"": ""11775b67-1fae-40ce-9d26-fff4e8148a8e"",""etiquetasingular"": ""Pack de productos de venta"",""etiquetaplural"": ""Packs de productos de venta"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""08989c47-907e-4cd2-ad21-88aa260c03a4"",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""ID"",""descripcion"": """",""keyword"": ""ID"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
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
          me.ReferenciaDestinador = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_100401479912"), _Datos.Leer_String("pr_100401479912.nombre"))
          me.ReferenciaAutorDelAlta = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_10040147997"), _Datos.Leer_String("pr_10040147997.nombre"))
          me.FechaAlta_UTC = _Datos.Leer_DateTime_Nulable("pr_100401479911")
          me.HoraLocal = _Datos.Leer_Time_Nulable("pr_10040147999")
          me.AutorDelAltaTieneAccesoWeb = _Datos.Leer_Boolean("pr_100401479924")
          me.EmpleadoTieneAccesoWeb = _Datos.Leer_Boolean("pr_100401479921")
          me.ReferenciaLimitarAUbicacion = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_20040147991"), _Datos.Leer_String("pr_20040147991.nombre"))
          me.ReferenciaLimitarATipoDeCliente = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_20040147992"), _Datos.Leer_String("pr_20040147992.nombre"))
          me.Descatalogado = _Datos.Leer_Boolean("pr_20040147995")
          me.ImpuestosIncluidos = _Datos.Leer_Boolean("pr_30040148001")
          me.ImporteDescuentoSaldoImpuesto1 = _Datos.Leer_Decimal("pr_100401481711")
          me.ReferenciaResumenImpuesto1 = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_10040148174"), _Datos.Leer_String("pr_10040148174.nombre"))
          me.ImporteDescuentosProductoImpuesto1 = _Datos.Leer_Decimal("pr_10040148175")
          me.ImporteBaseImponibleImpuesto1 = _Datos.Leer_Decimal("pr_10040148176")
          me.ImporteDescuentosGeneralImpuesto1 = _Datos.Leer_Decimal("pr_10040148177")
          me.ImporteCuotaREImpuesto1 = _Datos.Leer_Decimal("pr_10040148178")
          me.ImporteCuotaImpuesto1 = _Datos.Leer_Decimal("pr_10040148179")
          me.ImporteSumaDeConceptosImpuesto1 = _Datos.Leer_Decimal("pr_100401481710")
          me.ImporteDescuentosGeneralImpuesto2 = _Datos.Leer_Decimal("pr_100401481712")
          me.ImporteDescuentoSaldoImpuesto2 = _Datos.Leer_Decimal("pr_100401481713")
          me.ImporteSumaDeConceptosImpuesto2 = _Datos.Leer_Decimal("pr_100401481714")
          me.ReferenciaResumenImpuesto2 = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_20040148172"), _Datos.Leer_String("pr_20040148172.nombre"))
          me.ImporteDescuentosProductoImpuesto2 = _Datos.Leer_Decimal("pr_20040148173")
          me.ImporteCuotaREImpuesto2 = _Datos.Leer_Decimal("pr_20040148174")
          me.ImporteBaseImponibleImpuesto2 = _Datos.Leer_Decimal("pr_20040148175")
          me.ImporteCuotaImpuesto2 = _Datos.Leer_Decimal("pr_20040148176")
          me.ImporteBaseImponibleImpuesto3 = _Datos.Leer_Decimal("pr_20040148179")
          me.ImporteSumaDeConceptosImpuesto3 = _Datos.Leer_Decimal("pr_200401481711")
          me.ImporteDescuentosGeneralImpuesto3 = _Datos.Leer_Decimal("pr_200401481712")
          me.ImporteDescuentoSaldoImpuesto3 = _Datos.Leer_Decimal("pr_200401481715")
          me.ImporteDescuentoSaldoExento = _Datos.Leer_Decimal("pr_200401481717")
          me.ImporteSumaDeConceptosImpuestoExentos = _Datos.Leer_Decimal("pr_200401481719")
          me.ImporteCuotaREImpuesto3 = _Datos.Leer_Decimal("pr_20040148178")
          me.ImporteDescuentosProductoImpuesto3 = _Datos.Leer_Decimal("pr_200401481713")
          me.ReferenciaResumenImpuesto3 = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_200401481714"), _Datos.Leer_String("pr_200401481714.nombre"))
          me.ImporteCuotaImpuesto3 = _Datos.Leer_Decimal("pr_200401481710")
          me.ImporteDescuentoGeneralImpuestoExento = _Datos.Leer_Decimal("pr_200401481718")
          me.ImporteBaseImponibleExenta = _Datos.Leer_Decimal("pr_200401481720")
          me.ImporteDescuentosProductoExento = _Datos.Leer_Decimal("pr_200401481721")
          me.ImporteTotal = _Datos.Leer_Decimal("pr_10040148261001")
          me.ImporteTotalImpuestos = _Datos.Leer_Decimal("pr_10040148261002")
          me.ImporteTotalDescontadoSinImpuestos = _Datos.Leer_Decimal("pr_10040148261003")
          me.ImporteSubtotal = _Datos.Leer_Decimal("pr_20040148261")
          me.SumaConceptosConImpuestos = _Datos.Leer_Decimal("pr_20040148262")
          me.ImporteSumaConceptosSinImpuestos = _Datos.Leer_Decimal("pr_20040148263")
          me.ImporteSumaImporteDeProductosSinImpuestos = _Datos.Leer_Decimal("pr_20040148264")
          me.ImporteSumaImporteProductosConImpuestos = _Datos.Leer_Decimal("pr_20040148265")
          me.CantidadDeUnidades = _Datos.Leer_Decimal("pr_40040148421")
          me.Elementos = _Datos.Leer_Integer("pr_30040148421")
          me.ReferenciaBasadoEnCatalogo = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_600401700020"), _Datos.Leer_String("pr_600401700020.nombre"))
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
           R.add("pr_100401479912",me.ReferenciaDestinador.ID.STR())
         Else
           R.add("pr_100401479912","")
         End if
         If Me.ReferenciaAutorDelAlta IsNot nothing then
           R.add("pr_10040147997",me.ReferenciaAutorDelAlta.ID.STR())
         Else
           R.add("pr_10040147997","")
         End if
         R.add("pr_100401479911", me.FechaAlta_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_10040147999", me.HoraLocal.AdaptarMySQL_Time_Nulable())
         R.add("pr_100401479924", me.AutorDelAltaTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_100401479921", me.EmpleadoTieneAccesoWeb.AdaptarMySQL_Boolean())
         If Me.ReferenciaLimitarAUbicacion IsNot nothing then
           R.add("pr_20040147991",me.ReferenciaLimitarAUbicacion.ID.STR())
         Else
           R.add("pr_20040147991","")
         End if
         If Me.ReferenciaLimitarATipoDeCliente IsNot nothing then
           R.add("pr_20040147992",me.ReferenciaLimitarATipoDeCliente.ID.STR())
         Else
           R.add("pr_20040147992","")
         End if
         R.add("pr_20040147995", me.Descatalogado.AdaptarMySQL_Boolean())
         R.add("pr_30040148001", me.ImpuestosIncluidos.AdaptarMySQL_Boolean())
         R.add("pr_100401481711", me.ImporteDescuentoSaldoImpuesto1.AdaptarMySQL_Decimal())
         If Me.ReferenciaResumenImpuesto1 IsNot nothing then
           R.add("pr_10040148174",me.ReferenciaResumenImpuesto1.ID.STR())
         Else
           R.add("pr_10040148174","")
         End if
         R.add("pr_10040148175", me.ImporteDescuentosProductoImpuesto1.AdaptarMySQL_Decimal())
         R.add("pr_10040148176", me.ImporteBaseImponibleImpuesto1.AdaptarMySQL_Decimal())
         R.add("pr_10040148177", me.ImporteDescuentosGeneralImpuesto1.AdaptarMySQL_Decimal())
         R.add("pr_10040148178", me.ImporteCuotaREImpuesto1.AdaptarMySQL_Decimal())
         R.add("pr_10040148179", me.ImporteCuotaImpuesto1.AdaptarMySQL_Decimal())
         R.add("pr_100401481710", me.ImporteSumaDeConceptosImpuesto1.AdaptarMySQL_Decimal())
         R.add("pr_100401481712", me.ImporteDescuentosGeneralImpuesto2.AdaptarMySQL_Decimal())
         R.add("pr_100401481713", me.ImporteDescuentoSaldoImpuesto2.AdaptarMySQL_Decimal())
         R.add("pr_100401481714", me.ImporteSumaDeConceptosImpuesto2.AdaptarMySQL_Decimal())
         If Me.ReferenciaResumenImpuesto2 IsNot nothing then
           R.add("pr_20040148172",me.ReferenciaResumenImpuesto2.ID.STR())
         Else
           R.add("pr_20040148172","")
         End if
         R.add("pr_20040148173", me.ImporteDescuentosProductoImpuesto2.AdaptarMySQL_Decimal())
         R.add("pr_20040148174", me.ImporteCuotaREImpuesto2.AdaptarMySQL_Decimal())
         R.add("pr_20040148175", me.ImporteBaseImponibleImpuesto2.AdaptarMySQL_Decimal())
         R.add("pr_20040148176", me.ImporteCuotaImpuesto2.AdaptarMySQL_Decimal())
         R.add("pr_20040148179", me.ImporteBaseImponibleImpuesto3.AdaptarMySQL_Decimal())
         R.add("pr_200401481711", me.ImporteSumaDeConceptosImpuesto3.AdaptarMySQL_Decimal())
         R.add("pr_200401481712", me.ImporteDescuentosGeneralImpuesto3.AdaptarMySQL_Decimal())
         R.add("pr_200401481715", me.ImporteDescuentoSaldoImpuesto3.AdaptarMySQL_Decimal())
         R.add("pr_200401481717", me.ImporteDescuentoSaldoExento.AdaptarMySQL_Decimal())
         R.add("pr_200401481719", me.ImporteSumaDeConceptosImpuestoExentos.AdaptarMySQL_Decimal())
         R.add("pr_20040148178", me.ImporteCuotaREImpuesto3.AdaptarMySQL_Decimal())
         R.add("pr_200401481713", me.ImporteDescuentosProductoImpuesto3.AdaptarMySQL_Decimal())
         If Me.ReferenciaResumenImpuesto3 IsNot nothing then
           R.add("pr_200401481714",me.ReferenciaResumenImpuesto3.ID.STR())
         Else
           R.add("pr_200401481714","")
         End if
         R.add("pr_200401481710", me.ImporteCuotaImpuesto3.AdaptarMySQL_Decimal())
         R.add("pr_200401481718", me.ImporteDescuentoGeneralImpuestoExento.AdaptarMySQL_Decimal())
         R.add("pr_200401481720", me.ImporteBaseImponibleExenta.AdaptarMySQL_Decimal())
         R.add("pr_200401481721", me.ImporteDescuentosProductoExento.AdaptarMySQL_Decimal())
         R.add("pr_10040148261001", me.ImporteTotal.AdaptarMySQL_Decimal())
         R.add("pr_10040148261002", me.ImporteTotalImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_10040148261003", me.ImporteTotalDescontadoSinImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_20040148261", me.ImporteSubtotal.AdaptarMySQL_Decimal())
         R.add("pr_20040148262", me.SumaConceptosConImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_20040148263", me.ImporteSumaConceptosSinImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_20040148264", me.ImporteSumaImporteDeProductosSinImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_20040148265", me.ImporteSumaImporteProductosConImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_40040148421", me.CantidadDeUnidades.AdaptarMySQL_Decimal())
         R.add("pr_30040148421", me.Elementos.AdaptarMySQL_Integer())
         If Me.ReferenciaBasadoEnCatalogo IsNot nothing then
           R.add("pr_600401700020",me.ReferenciaBasadoEnCatalogo.ID.STR())
         Else
           R.add("pr_600401700020","")
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
  End Class
End Class
