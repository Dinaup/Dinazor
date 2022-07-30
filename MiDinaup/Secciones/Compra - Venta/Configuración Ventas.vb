   Imports System.ComponentModel
   Imports DinaNETCore
   Imports DinaNETCore.APID
Partial Public Class SeccionesD
  Public Class ConfiguracionVentasD
      Public Shared _SeccionID As String = "e01d87f4-82b0-4142-a108-b18c2e11b8c8"
      Public Shared _SeccionIDGUID As New Guid("e01d87f4-82b0-4142-a108-b18c2e11b8c8")
      Public Shared Async Function ConsultarDatos_Async(Parametros As SeccionConsultaParametrosC) As Task(Of List(Of ConfiguracionVentasC )) 
          Dim R As New List(Of ConfiguracionVentasC )  
          Dim d = Await Parametros.DinaupSesion.ConexionServidor.Funcion_Datos_Recibir_Async(ConfiguracionVentasES._SeccionID, False, Parametros) 
          If d.Datos.TieneDatos Then 
              For Each Actual In d.Datos 
                  Dim Valores_Listador = Actual.Value.Item1
                  Dim Obj_Listador As New ConfiguracionVentasC 
                  Obj_Listador.CargarDatos(Valores_Listador) 
                  Obj_Listador.CargaInterna(Actual.Value)
                  R.Add(Obj_Listador) 
              Next 
          End If 
          Return R 
      End Function 
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As ConfiguracionVentasC, Optional CampoWhere$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Return Await DatosGuardar_Async(DinaupSesion, New List(Of ConfiguracionVentasC)({DAtos}), CampoWhere )
      End Function
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As List(Of ConfiguracionVentasC), Optional CampoWhere$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Dim Importar As New List(Of DinaupAPI_ImportacionProcesableC)
          For Each Actual In DAtos 
              Dim RegistroActual = New DinaupAPI_ImportacionProcesableC() 
               RegistroActual.dinaup_listador_datos = Actual.ToDic 
               Importar.Add(RegistroActual)  
          Next 
          Return Await DinaupSesion.ConexionServidor.Funcion_Importar_Ejecutar_Async(DinaupSesion, ConfiguracionVentasES._SeccionID, Importar, CampoWhere, "") 
      End Function
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As ConfiguracionVentas_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, ConfiguracionVentasES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New ConfiguracionVentas_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As ConfiguracionVentas_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, ConfiguracionVentasES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New ConfiguracionVentas_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class ConfiguracionVentasES
          Public shared _SeccionID as Guid = New Guid("e01d87f4-82b0-4142-a108-b18c2e11b8c8")
          Public shared _Tabla$ = "tpr_10040105781"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_100401057825"
      Public Shared AutoOmitirDescuentoProductoFijoSiLlegaAlLimite$ = "pr_100401057879"
      Public Shared AutoOmitirDescuentoOfertaSiLlegaAlLimitePorciento$ = "pr_100401057880"
      Public Shared AutoOmitirTentidadSiLlegaAlLimite$ = "pr_100401057881"
      Public Shared AplicarPagoDeSaldoPromocionalTeniendoEnCuentaLosImpuestosObsoleto$ = "pr_100401057882"
      Public Shared OrdenDeAjusteDeDescuentoEntidad$ = "pr_100401057891"
      Public Shared ReferenciaDestinador$ = "pr_100401057810"
      Public Shared HoraLocal$ = "pr_10040105785"
      Public Shared OrdenDeAjusteDescuentoProducto$ = "pr_100401057890"
      Public Shared AjustarDescuentoProducto$ = "pr_100401057877"
      Public Shared AutoOmitirAdicionalASiLlegaAlLimite$ = "pr_100401057878"
      Public Shared DescuentoProductoMinimoAjustablePorciento$ = "pr_100401057899"
      Public Shared DescuentoAdicionalBMinimoAjustablePorciento$ = "pr_1004010578100"
      Public Shared TenerEnCuentaLosImpuestosParaGenerarSaldoPromocionalObsoleto$ = "pr_100401057875"
      Public Shared AjustarDescuentoFijoDeProducto$ = "pr_100401057876"
      Public Shared DescuentoEntidadMinimoAjustablePorciento$ = "pr_100401057897"
      Public Shared DescuentoTipoDeEntidadMinimoAjustablePorciento$ = "pr_100401057898"
      Public Shared Observaciones$ = "pr_100401057857"
      Public Shared AplicarSaldoPromocionalEnNegativoObsoleto$ = "pr_100401057869"
      Public Shared DescuentoOfertaProductoMinimoAjustablePorciento$ = "pr_100401057896"
      Public Shared AutoOmitirVIPSiLlegaAlLimite$ = "pr_100401057870"
      Public Shared OrdenDeAjusteDeDescuentoAdicionalB$ = "pr_100401057889"
      Public Shared DescripcionDescuentoAdicionalB$ = "pr_100401057858"
      Public Shared AjustarDescuentoTipoDeEntidad$ = "pr_100401057871"
      Public Shared AutoOmitirGeneralSiLlegaAlLimite$ = "pr_100401057872"
      Public Shared AjustarDescuentoEntidad$ = "pr_100401057873"
      Public Shared DescripcionDescuentoAdicionalA$ = "pr_100401057859"
      Public Shared DescuentoVIPMinimoAjustablePorciento$ = "pr_100401057894"
      Public Shared DescuentoAdicionalAMinimoAjustablePorciento$ = "pr_100401057895"
      Public Shared OrdenDeAjusteDescuentoFijoDeProducto$ = "pr_100401057887"
      Public Shared OrdenDeAjusteDeDescuentoVIP$ = "pr_100401057888"
      Public Shared OrdenDeAjusteDeDescuentoAdicionalA$ = "pr_100401057884"
      Public Shared OrdenDeAjusteDeDescuentoGeneral$ = "pr_100401057885"
      Public Shared AjustarDescuentoB$ = "pr_100401057867"
      Public Shared OrdenDeAjusteDescuentoOfertaDeProducto$ = "pr_100401057886"
      Public Shared FechaAlta_UTC$ = "pr_10040105787"
      Public Shared AjustarDescuentoGeneral$ = "pr_100401057868"
      Public Shared ExportarEnModulos$ = "pr_10040105786"
      Public Shared AjustarDescuentoVIP$ = "pr_100401057861"
      Public Shared AjustarElSaldoPromocionalGeneradoEvitandoPosiblesPerdidasEnBaseAlPrecioMinimo$ = "pr_100401057862"
      Public Shared AutoOmitirEntidadSiLlegaAlLimite$ = "pr_100401057863"
      Public Shared AutoOmitirDescuentoProductoPorcientoSiLlegaAlLimite$ = "pr_100401057864"
      Public Shared AjustarDescuentoOfertaDeProducto$ = "pr_100401057865"
      Public Shared DescuentoGeneralMinimoAjustablePorciento$ = "pr_100401057892"
      Public Shared ImporteDescuentoProductoFijoMinimoAjustable$ = "pr_100401057893"
      Public Shared AutoOmitirAdicionalBSiLlegaAlLimite$ = "pr_100401057866"
      Public Shared OrdenDeAjusteDeDescuentoTipoDeEntidad$ = "pr_100401057883"
      Public Shared ReferenciaAutorDelAlta$ = "pr_10040105783"
      Public Shared AjusteDescuentoA$ = "pr_100401057860"
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
      Public Class ConfiguracionVentasC
      Inherits Base_DatoC
          <DisplayName("Autor del alta Tiene Acceso web")>
          Public Property AutorDelAltaTieneAccesoWeb As Boolean
          Public Shared ___AutorDelAltaTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AutorDelAltaTieneAccesoWeb"",""etiqueta"": ""Autor del alta Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta Tiene Acceso web"",""descripcion"": """",""keyword"": ""AutorDelAltaTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AutorDelAltaTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___AutorDelAltaTieneAccesoWeb
          <DisplayName("Auto omitir descuento Producto Fijo si llega al límite")>
          Public Property AutoOmitirDescuentoProductoFijoSiLlegaAlLimite As Boolean
          Public Shared ___AutoOmitirDescuentoProductoFijoSiLlegaAlLimite As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AutoOmitirDescuentoProductoFijoSiLlegaAlLimite"",""etiqueta"": ""Auto omitir descuento Producto Fijo si llega al límite"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Auto omitir descuento Producto Fijo si llega al límite"",""descripcion"": """",""keyword"": ""AutoOmitirDescuentoProductoFijoSiLlegaAlLimite"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AutoOmitirDescuentoProductoFijoSiLlegaAlLimite As DinaNETCore.APID.DinaupAPI_CampoC = ___AutoOmitirDescuentoProductoFijoSiLlegaAlLimite
          <DisplayName("Auto omitir descuento oferta % si llega al límite")>
          Public Property AutoOmitirDescuentoOfertaSiLlegaAlLimitePorciento As Boolean
          Public Shared ___AutoOmitirDescuentoOfertaSiLlegaAlLimitePorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AutoOmitirDescuentoOfertaSiLlegaAlLimitePorciento"",""etiqueta"": ""Auto omitir descuento oferta % si llega al límite"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Auto omitir descuento oferta % si llega al límite"",""descripcion"": """",""keyword"": ""AutoOmitirDescuentoOfertaSiLlegaAlLimitePorciento"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AutoOmitirDescuentoOfertaSiLlegaAlLimitePorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___AutoOmitirDescuentoOfertaSiLlegaAlLimitePorciento
          <DisplayName("Auto omitir T.entidad si llega al límite")>
          Public Property AutoOmitirTentidadSiLlegaAlLimite As Boolean
          Public Shared ___AutoOmitirTentidadSiLlegaAlLimite As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AutoOmitirTentidadSiLlegaAlLimite"",""etiqueta"": ""Auto omitir T.entidad si llega al límite"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Auto omitir T.entidad si llega al límite"",""descripcion"": """",""keyword"": ""AutoOmitirTentidadSiLlegaAlLimite"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AutoOmitirTentidadSiLlegaAlLimite As DinaNETCore.APID.DinaupAPI_CampoC = ___AutoOmitirTentidadSiLlegaAlLimite
          <Description("Activando esta opción el cliente podrá pagar los impuestos utilizando su saldo promocional.")>
          <DisplayName("Aplicar pago de saldo promocional teniendo en cuenta los impuestos (Obsoleto)")>
          Public Property AplicarPagoDeSaldoPromocionalTeniendoEnCuentaLosImpuestosObsoleto As Boolean
          Public Shared ___AplicarPagoDeSaldoPromocionalTeniendoEnCuentaLosImpuestosObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AplicarPagoDeSaldoPromocionalTeniendoEnCuentaLosImpuestosObsoleto"",""etiqueta"": ""Aplicar pago de saldo promocional teniendo en cuenta los impuestos (Obsoleto)"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Aplicar pago de saldo promocional teniendo en cuenta los impuestos (Obsoleto)"",""descripcion"": """",""keyword"": ""AplicarPagoDeSaldoPromocionalTeniendoEnCuentaLosImpuestosObsoleto"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AplicarPagoDeSaldoPromocionalTeniendoEnCuentaLosImpuestosObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___AplicarPagoDeSaldoPromocionalTeniendoEnCuentaLosImpuestosObsoleto
          <DisplayName("Orden de ajuste de descuento Entidad")>
          Public Property OrdenDeAjusteDeDescuentoEntidad As Integer
          Public Shared ___OrdenDeAjusteDeDescuentoEntidad As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""OrdenDeAjusteDeDescuentoEntidad"",""etiqueta"": ""Orden de ajuste de descuento Entidad"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Orden de ajuste de descuento Entidad"",""descripcion"": """",""keyword"": ""OrdenDeAjusteDeDescuentoEntidad"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __OrdenDeAjusteDeDescuentoEntidad As DinaNETCore.APID.DinaupAPI_CampoC = ___OrdenDeAjusteDeDescuentoEntidad
          <DisplayName("Destinador")>
          Public Property ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaDestinador As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaDestinador"",""etiqueta"": ""Destinador"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""relacionesindirectas"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Destinador"",""descripcion"": """",""keyword"": ""ReferenciaDestinador"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaDestinador
          <DisplayName("Hora local")>
          Public Property HoraLocal As DateTime?
          Public Shared ___HoraLocal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""HoraLocal"",""etiqueta"": ""Hora local"",""oculta"": false,""formato"": 8,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Hora local"",""descripcion"": """",""keyword"": ""HoraLocal"",""formato"": 8,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __HoraLocal As DinaNETCore.APID.DinaupAPI_CampoC = ___HoraLocal
          <DisplayName("Orden de ajuste descuento Producto")>
          Public Property OrdenDeAjusteDescuentoProducto As Integer
          Public Shared ___OrdenDeAjusteDescuentoProducto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""OrdenDeAjusteDescuentoProducto"",""etiqueta"": ""Orden de ajuste descuento Producto"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Orden de ajuste descuento Producto"",""descripcion"": """",""keyword"": ""OrdenDeAjusteDescuentoProducto"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __OrdenDeAjusteDescuentoProducto As DinaNETCore.APID.DinaupAPI_CampoC = ___OrdenDeAjusteDescuentoProducto
          <DisplayName("Ajustar descuento Producto")>
          Public Property AjustarDescuentoProducto As Boolean
          Public Shared ___AjustarDescuentoProducto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AjustarDescuentoProducto"",""etiqueta"": ""Ajustar descuento Producto"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Ajustar descuento Producto"",""descripcion"": """",""keyword"": ""AjustarDescuentoProducto"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AjustarDescuentoProducto As DinaNETCore.APID.DinaupAPI_CampoC = ___AjustarDescuentoProducto
          <DisplayName("Auto omitir Adicional A si llega al límite")>
          Public Property AutoOmitirAdicionalASiLlegaAlLimite As Boolean
          Public Shared ___AutoOmitirAdicionalASiLlegaAlLimite As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AutoOmitirAdicionalASiLlegaAlLimite"",""etiqueta"": ""Auto omitir Adicional A si llega al límite"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Auto omitir Adicional A si llega al límite"",""descripcion"": """",""keyword"": ""AutoOmitirAdicionalASiLlegaAlLimite"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AutoOmitirAdicionalASiLlegaAlLimite As DinaNETCore.APID.DinaupAPI_CampoC = ___AutoOmitirAdicionalASiLlegaAlLimite
          <DisplayName("Descuento producto % mínimo ajustable")>
          Public Property DescuentoProductoMinimoAjustablePorciento As Decimal
          Public Shared ___DescuentoProductoMinimoAjustablePorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoProductoMinimoAjustablePorciento"",""etiqueta"": ""Descuento producto % mínimo ajustable"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento producto % mínimo ajustable"",""descripcion"": """",""keyword"": ""DescuentoProductoMinimoAjustablePorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoProductoMinimoAjustablePorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoProductoMinimoAjustablePorciento
          <DisplayName("Descuento Adicional B mínimo ajustable")>
          Public Property DescuentoAdicionalBMinimoAjustablePorciento As Decimal
          Public Shared ___DescuentoAdicionalBMinimoAjustablePorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoAdicionalBMinimoAjustablePorciento"",""etiqueta"": ""Descuento Adicional B mínimo ajustable"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento Adicional B mínimo ajustable"",""descripcion"": """",""keyword"": ""DescuentoAdicionalBMinimoAjustablePorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoAdicionalBMinimoAjustablePorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoAdicionalBMinimoAjustablePorciento
          <Description("Mediante esta opción el sistema incluirá los impuestos en el cálculo para generar el saldo promocional, de este modo el saldo promocional se basará en el importe total de la venta en lugar de basarlo en el subtotal.")>
          <DisplayName("Tener en cuenta los impuestos para generar saldo promocional (Obsoleto)")>
          Public Property TenerEnCuentaLosImpuestosParaGenerarSaldoPromocionalObsoleto As Boolean
          Public Shared ___TenerEnCuentaLosImpuestosParaGenerarSaldoPromocionalObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TenerEnCuentaLosImpuestosParaGenerarSaldoPromocionalObsoleto"",""etiqueta"": ""Tener en cuenta los impuestos para generar saldo promocional (Obsoleto)"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Tener en cuenta los impuestos para generar saldo promocional (Obsoleto)"",""descripcion"": """",""keyword"": ""TenerEnCuentaLosImpuestosParaGenerarSaldoPromocionalObsoleto"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __TenerEnCuentaLosImpuestosParaGenerarSaldoPromocionalObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___TenerEnCuentaLosImpuestosParaGenerarSaldoPromocionalObsoleto
          <DisplayName("Ajustar descuento Fijo de Producto")>
          Public Property AjustarDescuentoFijoDeProducto As Boolean
          Public Shared ___AjustarDescuentoFijoDeProducto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AjustarDescuentoFijoDeProducto"",""etiqueta"": ""Ajustar descuento Fijo de Producto"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Ajustar descuento Fijo de Producto"",""descripcion"": """",""keyword"": ""AjustarDescuentoFijoDeProducto"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AjustarDescuentoFijoDeProducto As DinaNETCore.APID.DinaupAPI_CampoC = ___AjustarDescuentoFijoDeProducto
          <DisplayName("Descuento Entidad mínimo ajustable")>
          Public Property DescuentoEntidadMinimoAjustablePorciento As Decimal
          Public Shared ___DescuentoEntidadMinimoAjustablePorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoEntidadMinimoAjustablePorciento"",""etiqueta"": ""Descuento Entidad mínimo ajustable"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento Entidad mínimo ajustable"",""descripcion"": """",""keyword"": ""DescuentoEntidadMinimoAjustablePorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoEntidadMinimoAjustablePorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoEntidadMinimoAjustablePorciento
          <DisplayName("Descuento tipo de entidad mínimo ajustable")>
          Public Property DescuentoTipoDeEntidadMinimoAjustablePorciento As Decimal
          Public Shared ___DescuentoTipoDeEntidadMinimoAjustablePorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoTipoDeEntidadMinimoAjustablePorciento"",""etiqueta"": ""Descuento tipo de entidad mínimo ajustable"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento tipo de entidad mínimo ajustable"",""descripcion"": """",""keyword"": ""DescuentoTipoDeEntidadMinimoAjustablePorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoTipoDeEntidadMinimoAjustablePorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoTipoDeEntidadMinimoAjustablePorciento
          <DisplayName("Observaciones")>
          Public Property Observaciones As String
          Public Shared ___Observaciones As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Observaciones"",""etiqueta"": ""Observaciones"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 9,""decimales"": ""0"",""multilinea"": true,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Observaciones"",""descripcion"": """",""keyword"": ""Observaciones"",""formato"": 5,""rol"": 9,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Observaciones As DinaNETCore.APID.DinaupAPI_CampoC = ___Observaciones
          <DisplayName("Aplicar saldo promocional en negativo (Obsoleto)")>
          Public Property AplicarSaldoPromocionalEnNegativoObsoleto As Boolean
          Public Shared ___AplicarSaldoPromocionalEnNegativoObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AplicarSaldoPromocionalEnNegativoObsoleto"",""etiqueta"": ""Aplicar saldo promocional en negativo (Obsoleto)"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Aplicar saldo promocional en negativo (Obsoleto)"",""descripcion"": """",""keyword"": ""AplicarSaldoPromocionalEnNegativoObsoleto"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AplicarSaldoPromocionalEnNegativoObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___AplicarSaldoPromocionalEnNegativoObsoleto
          <DisplayName("Descuento % oferta producto mínimo ajustable")>
          Public Property DescuentoOfertaProductoMinimoAjustablePorciento As Decimal
          Public Shared ___DescuentoOfertaProductoMinimoAjustablePorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoOfertaProductoMinimoAjustablePorciento"",""etiqueta"": ""Descuento % oferta producto mínimo ajustable"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento % oferta producto mínimo ajustable"",""descripcion"": """",""keyword"": ""DescuentoOfertaProductoMinimoAjustablePorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoOfertaProductoMinimoAjustablePorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoOfertaProductoMinimoAjustablePorciento
          <DisplayName("Auto omitir VIP si llega al límite")>
          Public Property AutoOmitirVIPSiLlegaAlLimite As Boolean
          Public Shared ___AutoOmitirVIPSiLlegaAlLimite As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AutoOmitirVIPSiLlegaAlLimite"",""etiqueta"": ""Auto omitir VIP si llega al límite"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Auto omitir VIP si llega al límite"",""descripcion"": """",""keyword"": ""AutoOmitirVIPSiLlegaAlLimite"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AutoOmitirVIPSiLlegaAlLimite As DinaNETCore.APID.DinaupAPI_CampoC = ___AutoOmitirVIPSiLlegaAlLimite
          <DisplayName("Orden de ajuste de descuento adicional B")>
          Public Property OrdenDeAjusteDeDescuentoAdicionalB As Integer
          Public Shared ___OrdenDeAjusteDeDescuentoAdicionalB As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""OrdenDeAjusteDeDescuentoAdicionalB"",""etiqueta"": ""Orden de ajuste de descuento adicional B"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Orden de ajuste de descuento adicional B"",""descripcion"": """",""keyword"": ""OrdenDeAjusteDeDescuentoAdicionalB"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __OrdenDeAjusteDeDescuentoAdicionalB As DinaNETCore.APID.DinaupAPI_CampoC = ___OrdenDeAjusteDeDescuentoAdicionalB
          <DisplayName("Descripción descuento adicional B")>
          Public Property DescripcionDescuentoAdicionalB As String
          Public Shared ___DescripcionDescuentoAdicionalB As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescripcionDescuentoAdicionalB"",""etiqueta"": ""Descripción descuento adicional B"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descripción descuento adicional B"",""descripcion"": """",""keyword"": ""DescripcionDescuentoAdicionalB"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescripcionDescuentoAdicionalB As DinaNETCore.APID.DinaupAPI_CampoC = ___DescripcionDescuentoAdicionalB
          <DisplayName("Ajustar descuento Tipo de entidad")>
          Public Property AjustarDescuentoTipoDeEntidad As Boolean
          Public Shared ___AjustarDescuentoTipoDeEntidad As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AjustarDescuentoTipoDeEntidad"",""etiqueta"": ""Ajustar descuento Tipo de entidad"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Ajustar descuento Tipo de entidad"",""descripcion"": """",""keyword"": ""AjustarDescuentoTipoDeEntidad"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AjustarDescuentoTipoDeEntidad As DinaNETCore.APID.DinaupAPI_CampoC = ___AjustarDescuentoTipoDeEntidad
          <DisplayName("Auto omitir General si llega al límite")>
          Public Property AutoOmitirGeneralSiLlegaAlLimite As Boolean
          Public Shared ___AutoOmitirGeneralSiLlegaAlLimite As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AutoOmitirGeneralSiLlegaAlLimite"",""etiqueta"": ""Auto omitir General si llega al límite"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Auto omitir General si llega al límite"",""descripcion"": """",""keyword"": ""AutoOmitirGeneralSiLlegaAlLimite"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AutoOmitirGeneralSiLlegaAlLimite As DinaNETCore.APID.DinaupAPI_CampoC = ___AutoOmitirGeneralSiLlegaAlLimite
          <DisplayName("Ajustar descuento Entidad")>
          Public Property AjustarDescuentoEntidad As Boolean
          Public Shared ___AjustarDescuentoEntidad As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AjustarDescuentoEntidad"",""etiqueta"": ""Ajustar descuento Entidad"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Ajustar descuento Entidad"",""descripcion"": """",""keyword"": ""AjustarDescuentoEntidad"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AjustarDescuentoEntidad As DinaNETCore.APID.DinaupAPI_CampoC = ___AjustarDescuentoEntidad
          <DisplayName("Descripción descuento adicional A")>
          Public Property DescripcionDescuentoAdicionalA As String
          Public Shared ___DescripcionDescuentoAdicionalA As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescripcionDescuentoAdicionalA"",""etiqueta"": ""Descripción descuento adicional A"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descripción descuento adicional A"",""descripcion"": """",""keyword"": ""DescripcionDescuentoAdicionalA"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescripcionDescuentoAdicionalA As DinaNETCore.APID.DinaupAPI_CampoC = ___DescripcionDescuentoAdicionalA
          <DisplayName("Descuento VIP mínimo ajustable")>
          Public Property DescuentoVIPMinimoAjustablePorciento As Decimal
          Public Shared ___DescuentoVIPMinimoAjustablePorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoVIPMinimoAjustablePorciento"",""etiqueta"": ""Descuento VIP mínimo ajustable"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento VIP mínimo ajustable"",""descripcion"": """",""keyword"": ""DescuentoVIPMinimoAjustablePorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoVIPMinimoAjustablePorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoVIPMinimoAjustablePorciento
          <DisplayName("Descuento Adicional A mínimo ajustable")>
          Public Property DescuentoAdicionalAMinimoAjustablePorciento As Decimal
          Public Shared ___DescuentoAdicionalAMinimoAjustablePorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoAdicionalAMinimoAjustablePorciento"",""etiqueta"": ""Descuento Adicional A mínimo ajustable"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento Adicional A mínimo ajustable"",""descripcion"": """",""keyword"": ""DescuentoAdicionalAMinimoAjustablePorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoAdicionalAMinimoAjustablePorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoAdicionalAMinimoAjustablePorciento
          <DisplayName("Orden de ajuste descuento Fijo de Producto")>
          Public Property OrdenDeAjusteDescuentoFijoDeProducto As Integer
          Public Shared ___OrdenDeAjusteDescuentoFijoDeProducto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""OrdenDeAjusteDescuentoFijoDeProducto"",""etiqueta"": ""Orden de ajuste descuento Fijo de Producto"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Orden de ajuste descuento Fijo de Producto"",""descripcion"": """",""keyword"": ""OrdenDeAjusteDescuentoFijoDeProducto"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __OrdenDeAjusteDescuentoFijoDeProducto As DinaNETCore.APID.DinaupAPI_CampoC = ___OrdenDeAjusteDescuentoFijoDeProducto
          <DisplayName("Orden de ajuste de descuento VIP")>
          Public Property OrdenDeAjusteDeDescuentoVIP As Integer
          Public Shared ___OrdenDeAjusteDeDescuentoVIP As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""OrdenDeAjusteDeDescuentoVIP"",""etiqueta"": ""Orden de ajuste de descuento VIP"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Orden de ajuste de descuento VIP"",""descripcion"": """",""keyword"": ""OrdenDeAjusteDeDescuentoVIP"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __OrdenDeAjusteDeDescuentoVIP As DinaNETCore.APID.DinaupAPI_CampoC = ___OrdenDeAjusteDeDescuentoVIP
          <DisplayName("Orden de ajuste de descuento adicional A")>
          Public Property OrdenDeAjusteDeDescuentoAdicionalA As Integer
          Public Shared ___OrdenDeAjusteDeDescuentoAdicionalA As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""OrdenDeAjusteDeDescuentoAdicionalA"",""etiqueta"": ""Orden de ajuste de descuento adicional A"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Orden de ajuste de descuento adicional A"",""descripcion"": """",""keyword"": ""OrdenDeAjusteDeDescuentoAdicionalA"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __OrdenDeAjusteDeDescuentoAdicionalA As DinaNETCore.APID.DinaupAPI_CampoC = ___OrdenDeAjusteDeDescuentoAdicionalA
          <DisplayName("Orden de ajuste de descuento General")>
          Public Property OrdenDeAjusteDeDescuentoGeneral As Integer
          Public Shared ___OrdenDeAjusteDeDescuentoGeneral As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""OrdenDeAjusteDeDescuentoGeneral"",""etiqueta"": ""Orden de ajuste de descuento General"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Orden de ajuste de descuento General"",""descripcion"": """",""keyword"": ""OrdenDeAjusteDeDescuentoGeneral"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __OrdenDeAjusteDeDescuentoGeneral As DinaNETCore.APID.DinaupAPI_CampoC = ___OrdenDeAjusteDeDescuentoGeneral
          <DisplayName("Ajustar descuento B")>
          Public Property AjustarDescuentoB As Boolean
          Public Shared ___AjustarDescuentoB As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AjustarDescuentoB"",""etiqueta"": ""Ajustar descuento B"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Ajustar descuento B"",""descripcion"": """",""keyword"": ""AjustarDescuentoB"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AjustarDescuentoB As DinaNETCore.APID.DinaupAPI_CampoC = ___AjustarDescuentoB
          <DisplayName("Orden de ajuste descuento Oferta de Producto")>
          Public Property OrdenDeAjusteDescuentoOfertaDeProducto As Integer
          Public Shared ___OrdenDeAjusteDescuentoOfertaDeProducto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""OrdenDeAjusteDescuentoOfertaDeProducto"",""etiqueta"": ""Orden de ajuste descuento Oferta de Producto"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Orden de ajuste descuento Oferta de Producto"",""descripcion"": """",""keyword"": ""OrdenDeAjusteDescuentoOfertaDeProducto"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __OrdenDeAjusteDescuentoOfertaDeProducto As DinaNETCore.APID.DinaupAPI_CampoC = ___OrdenDeAjusteDescuentoOfertaDeProducto
          <DisplayName("Fecha Alta del registro")>
          Public Property FechaAlta_UTC As Date?
          Public Shared ___FechaAlta_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaAlta_UTC"",""etiqueta"": ""Fecha Alta del registro"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Alta del registro"",""descripcion"": """",""keyword"": ""FechaAlta_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaAlta_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaAlta_UTC
          <DisplayName("Ajustar descuento General")>
          Public Property AjustarDescuentoGeneral As Boolean
          Public Shared ___AjustarDescuentoGeneral As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AjustarDescuentoGeneral"",""etiqueta"": ""Ajustar descuento General"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Ajustar descuento General"",""descripcion"": """",""keyword"": ""AjustarDescuentoGeneral"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AjustarDescuentoGeneral As DinaNETCore.APID.DinaupAPI_CampoC = ___AjustarDescuentoGeneral
          <DisplayName("Ajustar descuento VIP")>
          Public Property AjustarDescuentoVIP As Boolean
          Public Shared ___AjustarDescuentoVIP As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AjustarDescuentoVIP"",""etiqueta"": ""Ajustar descuento VIP"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Ajustar descuento VIP"",""descripcion"": """",""keyword"": ""AjustarDescuentoVIP"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AjustarDescuentoVIP As DinaNETCore.APID.DinaupAPI_CampoC = ___AjustarDescuentoVIP
          <Description("Mediante esta opción el sistema reducirá el saldo promocional generado en la venta del producto para evitar posibles pérdidas basándose en el precio mínimo. (El precio mínimo es indicado por el catálogo o directamente en la venta y podría asumir pérdidas controladas por estrategias de marketing u otros motivos)")>
          <DisplayName("Ajustar el saldo promocional generado evitando posibles pérdidas en base al precio mínimo")>
          Public Property AjustarElSaldoPromocionalGeneradoEvitandoPosiblesPerdidasEnBaseAlPrecioMinimo As Boolean
          Public Shared ___AjustarElSaldoPromocionalGeneradoEvitandoPosiblesPerdidasEnBaseAlPrecioMinimo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AjustarElSaldoPromocionalGeneradoEvitandoPosiblesPerdidasEnBaseAlPrecioMinimo"",""etiqueta"": ""Ajustar el saldo promocional generado evitando posibles pérdidas en base al precio mínimo"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Ajustar el saldo promocional generado evitando posibles pérdidas en base al precio mínimo"",""descripcion"": """",""keyword"": ""AjustarElSaldoPromocionalGeneradoEvitandoPosiblesPerdidasEnBaseAlPrecioMinimo"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AjustarElSaldoPromocionalGeneradoEvitandoPosiblesPerdidasEnBaseAlPrecioMinimo As DinaNETCore.APID.DinaupAPI_CampoC = ___AjustarElSaldoPromocionalGeneradoEvitandoPosiblesPerdidasEnBaseAlPrecioMinimo
          <DisplayName("Auto omitir Entidad si llega al límite")>
          Public Property AutoOmitirEntidadSiLlegaAlLimite As Boolean
          Public Shared ___AutoOmitirEntidadSiLlegaAlLimite As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AutoOmitirEntidadSiLlegaAlLimite"",""etiqueta"": ""Auto omitir Entidad si llega al límite"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Auto omitir Entidad si llega al límite"",""descripcion"": """",""keyword"": ""AutoOmitirEntidadSiLlegaAlLimite"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AutoOmitirEntidadSiLlegaAlLimite As DinaNETCore.APID.DinaupAPI_CampoC = ___AutoOmitirEntidadSiLlegaAlLimite
          <DisplayName("Auto omitir descuento Producto porciento si llega al límite")>
          Public Property AutoOmitirDescuentoProductoPorcientoSiLlegaAlLimite As Boolean
          Public Shared ___AutoOmitirDescuentoProductoPorcientoSiLlegaAlLimite As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AutoOmitirDescuentoProductoPorcientoSiLlegaAlLimite"",""etiqueta"": ""Auto omitir descuento Producto porciento si llega al límite"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Auto omitir descuento Producto porciento si llega al límite"",""descripcion"": """",""keyword"": ""AutoOmitirDescuentoProductoPorcientoSiLlegaAlLimite"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AutoOmitirDescuentoProductoPorcientoSiLlegaAlLimite As DinaNETCore.APID.DinaupAPI_CampoC = ___AutoOmitirDescuentoProductoPorcientoSiLlegaAlLimite
          <DisplayName("Ajustar descuento Oferta de Producto")>
          Public Property AjustarDescuentoOfertaDeProducto As Boolean
          Public Shared ___AjustarDescuentoOfertaDeProducto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AjustarDescuentoOfertaDeProducto"",""etiqueta"": ""Ajustar descuento Oferta de Producto"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Ajustar descuento Oferta de Producto"",""descripcion"": """",""keyword"": ""AjustarDescuentoOfertaDeProducto"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AjustarDescuentoOfertaDeProducto As DinaNETCore.APID.DinaupAPI_CampoC = ___AjustarDescuentoOfertaDeProducto
          <DisplayName("Descuento General mínimo ajustable")>
          Public Property DescuentoGeneralMinimoAjustablePorciento As Decimal
          Public Shared ___DescuentoGeneralMinimoAjustablePorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoGeneralMinimoAjustablePorciento"",""etiqueta"": ""Descuento General mínimo ajustable"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento General mínimo ajustable"",""descripcion"": """",""keyword"": ""DescuentoGeneralMinimoAjustablePorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoGeneralMinimoAjustablePorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoGeneralMinimoAjustablePorciento
          <DisplayName("Descuento Producto Fijo Mínimo Ajustable")>
          Public Property ImporteDescuentoProductoFijoMinimoAjustable As Decimal
          Public Shared ___ImporteDescuentoProductoFijoMinimoAjustable As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentoProductoFijoMinimoAjustable"",""etiqueta"": ""Descuento Producto Fijo Mínimo Ajustable"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento Producto Fijo Mínimo Ajustable"",""descripcion"": """",""keyword"": ""ImporteDescuentoProductoFijoMinimoAjustable"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentoProductoFijoMinimoAjustable As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentoProductoFijoMinimoAjustable
          <DisplayName("Auto omitir Adicional B si llega al límite")>
          Public Property AutoOmitirAdicionalBSiLlegaAlLimite As Boolean
          Public Shared ___AutoOmitirAdicionalBSiLlegaAlLimite As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AutoOmitirAdicionalBSiLlegaAlLimite"",""etiqueta"": ""Auto omitir Adicional B si llega al límite"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Auto omitir Adicional B si llega al límite"",""descripcion"": """",""keyword"": ""AutoOmitirAdicionalBSiLlegaAlLimite"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AutoOmitirAdicionalBSiLlegaAlLimite As DinaNETCore.APID.DinaupAPI_CampoC = ___AutoOmitirAdicionalBSiLlegaAlLimite
          <DisplayName("Orden de ajuste de descuento tipo de entidad")>
          Public Property OrdenDeAjusteDeDescuentoTipoDeEntidad As Integer
          Public Shared ___OrdenDeAjusteDeDescuentoTipoDeEntidad As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""OrdenDeAjusteDeDescuentoTipoDeEntidad"",""etiqueta"": ""Orden de ajuste de descuento tipo de entidad"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Orden de ajuste de descuento tipo de entidad"",""descripcion"": """",""keyword"": ""OrdenDeAjusteDeDescuentoTipoDeEntidad"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __OrdenDeAjusteDeDescuentoTipoDeEntidad As DinaNETCore.APID.DinaupAPI_CampoC = ___OrdenDeAjusteDeDescuentoTipoDeEntidad
          <DisplayName("Autor del alta")>
          Public Property ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaAutorDelAlta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaAutorDelAlta"",""etiqueta"": ""Autor del alta"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta"",""descripcion"": """",""keyword"": ""ReferenciaAutorDelAlta"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaAutorDelAlta
          <DisplayName("Ajuste descuento A")>
          Public Property AjusteDescuentoA As Boolean
          Public Shared ___AjusteDescuentoA As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AjusteDescuentoA"",""etiqueta"": ""Ajuste descuento A"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Ajuste descuento A"",""descripcion"": """",""keyword"": ""AjusteDescuentoA"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AjusteDescuentoA As DinaNETCore.APID.DinaupAPI_CampoC = ___AjusteDescuentoA
          <ReadOnlyAttribute(True)>
          <DisplayName("ID")>
          Public Property ID As Guid
          Public Shared ___ID As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": true,""eseliminado"": false,""keyword"": ""ID"",""etiqueta"": ""ID"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""e01d87f4-82b0-4142-a108-b18c2e11b8c8"",""titulo"": ""Configuración Ventas"",""iconoid"": ""877786af-aff4-49b3-aede-a9b1d80f3395"",""etiquetasingular"": ""Configuración de venta"",""etiquetaplural"": ""Configuraciones de venta"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""e01d87f4-82b0-4142-a108-b18c2e11b8c8"",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""ID"",""descripcion"": """",""keyword"": ""ID"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
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
          me.AutorDelAltaTieneAccesoWeb = _Datos.Leer_Boolean("pr_100401057825")
          me.AutoOmitirDescuentoProductoFijoSiLlegaAlLimite = _Datos.Leer_Boolean("pr_100401057879")
          me.AutoOmitirDescuentoOfertaSiLlegaAlLimitePorciento = _Datos.Leer_Boolean("pr_100401057880")
          me.AutoOmitirTentidadSiLlegaAlLimite = _Datos.Leer_Boolean("pr_100401057881")
          me.AplicarPagoDeSaldoPromocionalTeniendoEnCuentaLosImpuestosObsoleto = _Datos.Leer_Boolean("pr_100401057882")
          me.OrdenDeAjusteDeDescuentoEntidad = _Datos.Leer_Integer("pr_100401057891")
          me.ReferenciaDestinador = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_100401057810"), _Datos.Leer_String("pr_100401057810.nombre"))
          me.HoraLocal = _Datos.Leer_Time_Nulable("pr_10040105785")
          me.OrdenDeAjusteDescuentoProducto = _Datos.Leer_Integer("pr_100401057890")
          me.AjustarDescuentoProducto = _Datos.Leer_Boolean("pr_100401057877")
          me.AutoOmitirAdicionalASiLlegaAlLimite = _Datos.Leer_Boolean("pr_100401057878")
          me.DescuentoProductoMinimoAjustablePorciento = _Datos.Leer_Decimal("pr_100401057899")
          me.DescuentoAdicionalBMinimoAjustablePorciento = _Datos.Leer_Decimal("pr_1004010578100")
          me.TenerEnCuentaLosImpuestosParaGenerarSaldoPromocionalObsoleto = _Datos.Leer_Boolean("pr_100401057875")
          me.AjustarDescuentoFijoDeProducto = _Datos.Leer_Boolean("pr_100401057876")
          me.DescuentoEntidadMinimoAjustablePorciento = _Datos.Leer_Decimal("pr_100401057897")
          me.DescuentoTipoDeEntidadMinimoAjustablePorciento = _Datos.Leer_Decimal("pr_100401057898")
          me.Observaciones = _Datos.Leer_String("pr_100401057857")
          me.AplicarSaldoPromocionalEnNegativoObsoleto = _Datos.Leer_Boolean("pr_100401057869")
          me.DescuentoOfertaProductoMinimoAjustablePorciento = _Datos.Leer_Decimal("pr_100401057896")
          me.AutoOmitirVIPSiLlegaAlLimite = _Datos.Leer_Boolean("pr_100401057870")
          me.OrdenDeAjusteDeDescuentoAdicionalB = _Datos.Leer_Integer("pr_100401057889")
          me.DescripcionDescuentoAdicionalB = _Datos.Leer_String("pr_100401057858")
          me.AjustarDescuentoTipoDeEntidad = _Datos.Leer_Boolean("pr_100401057871")
          me.AutoOmitirGeneralSiLlegaAlLimite = _Datos.Leer_Boolean("pr_100401057872")
          me.AjustarDescuentoEntidad = _Datos.Leer_Boolean("pr_100401057873")
          me.DescripcionDescuentoAdicionalA = _Datos.Leer_String("pr_100401057859")
          me.DescuentoVIPMinimoAjustablePorciento = _Datos.Leer_Decimal("pr_100401057894")
          me.DescuentoAdicionalAMinimoAjustablePorciento = _Datos.Leer_Decimal("pr_100401057895")
          me.OrdenDeAjusteDescuentoFijoDeProducto = _Datos.Leer_Integer("pr_100401057887")
          me.OrdenDeAjusteDeDescuentoVIP = _Datos.Leer_Integer("pr_100401057888")
          me.OrdenDeAjusteDeDescuentoAdicionalA = _Datos.Leer_Integer("pr_100401057884")
          me.OrdenDeAjusteDeDescuentoGeneral = _Datos.Leer_Integer("pr_100401057885")
          me.AjustarDescuentoB = _Datos.Leer_Boolean("pr_100401057867")
          me.OrdenDeAjusteDescuentoOfertaDeProducto = _Datos.Leer_Integer("pr_100401057886")
          me.FechaAlta_UTC = _Datos.Leer_DateTime_Nulable("pr_10040105787")
          me.AjustarDescuentoGeneral = _Datos.Leer_Boolean("pr_100401057868")
          me.AjustarDescuentoVIP = _Datos.Leer_Boolean("pr_100401057861")
          me.AjustarElSaldoPromocionalGeneradoEvitandoPosiblesPerdidasEnBaseAlPrecioMinimo = _Datos.Leer_Boolean("pr_100401057862")
          me.AutoOmitirEntidadSiLlegaAlLimite = _Datos.Leer_Boolean("pr_100401057863")
          me.AutoOmitirDescuentoProductoPorcientoSiLlegaAlLimite = _Datos.Leer_Boolean("pr_100401057864")
          me.AjustarDescuentoOfertaDeProducto = _Datos.Leer_Boolean("pr_100401057865")
          me.DescuentoGeneralMinimoAjustablePorciento = _Datos.Leer_Decimal("pr_100401057892")
          me.ImporteDescuentoProductoFijoMinimoAjustable = _Datos.Leer_Decimal("pr_100401057893")
          me.AutoOmitirAdicionalBSiLlegaAlLimite = _Datos.Leer_Boolean("pr_100401057866")
          me.OrdenDeAjusteDeDescuentoTipoDeEntidad = _Datos.Leer_Integer("pr_100401057883")
          me.ReferenciaAutorDelAlta = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_10040105783"), _Datos.Leer_String("pr_10040105783.nombre"))
          me.AjusteDescuentoA = _Datos.Leer_Boolean("pr_100401057860")
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
         R.add("pr_100401057825", me.AutorDelAltaTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_100401057879", me.AutoOmitirDescuentoProductoFijoSiLlegaAlLimite.AdaptarMySQL_Boolean())
         R.add("pr_100401057880", me.AutoOmitirDescuentoOfertaSiLlegaAlLimitePorciento.AdaptarMySQL_Boolean())
         R.add("pr_100401057881", me.AutoOmitirTentidadSiLlegaAlLimite.AdaptarMySQL_Boolean())
         R.add("pr_100401057882", me.AplicarPagoDeSaldoPromocionalTeniendoEnCuentaLosImpuestosObsoleto.AdaptarMySQL_Boolean())
         R.add("pr_100401057891", me.OrdenDeAjusteDeDescuentoEntidad.AdaptarMySQL_Integer())
         If Me.ReferenciaDestinador IsNot nothing then
           R.add("pr_100401057810",me.ReferenciaDestinador.ID.STR())
         Else
           R.add("pr_100401057810","")
         End if
         R.add("pr_10040105785", me.HoraLocal.AdaptarMySQL_Time_Nulable())
         R.add("pr_100401057890", me.OrdenDeAjusteDescuentoProducto.AdaptarMySQL_Integer())
         R.add("pr_100401057877", me.AjustarDescuentoProducto.AdaptarMySQL_Boolean())
         R.add("pr_100401057878", me.AutoOmitirAdicionalASiLlegaAlLimite.AdaptarMySQL_Boolean())
         R.add("pr_100401057899", me.DescuentoProductoMinimoAjustablePorciento.AdaptarMySQL_Decimal())
         R.add("pr_1004010578100", me.DescuentoAdicionalBMinimoAjustablePorciento.AdaptarMySQL_Decimal())
         R.add("pr_100401057875", me.TenerEnCuentaLosImpuestosParaGenerarSaldoPromocionalObsoleto.AdaptarMySQL_Boolean())
         R.add("pr_100401057876", me.AjustarDescuentoFijoDeProducto.AdaptarMySQL_Boolean())
         R.add("pr_100401057897", me.DescuentoEntidadMinimoAjustablePorciento.AdaptarMySQL_Decimal())
         R.add("pr_100401057898", me.DescuentoTipoDeEntidadMinimoAjustablePorciento.AdaptarMySQL_Decimal())
         R.add("pr_100401057857", me.Observaciones.AdaptarMySQL_String())
         R.add("pr_100401057869", me.AplicarSaldoPromocionalEnNegativoObsoleto.AdaptarMySQL_Boolean())
         R.add("pr_100401057896", me.DescuentoOfertaProductoMinimoAjustablePorciento.AdaptarMySQL_Decimal())
         R.add("pr_100401057870", me.AutoOmitirVIPSiLlegaAlLimite.AdaptarMySQL_Boolean())
         R.add("pr_100401057889", me.OrdenDeAjusteDeDescuentoAdicionalB.AdaptarMySQL_Integer())
         R.add("pr_100401057858", me.DescripcionDescuentoAdicionalB.AdaptarMySQL_String())
         R.add("pr_100401057871", me.AjustarDescuentoTipoDeEntidad.AdaptarMySQL_Boolean())
         R.add("pr_100401057872", me.AutoOmitirGeneralSiLlegaAlLimite.AdaptarMySQL_Boolean())
         R.add("pr_100401057873", me.AjustarDescuentoEntidad.AdaptarMySQL_Boolean())
         R.add("pr_100401057859", me.DescripcionDescuentoAdicionalA.AdaptarMySQL_String())
         R.add("pr_100401057894", me.DescuentoVIPMinimoAjustablePorciento.AdaptarMySQL_Decimal())
         R.add("pr_100401057895", me.DescuentoAdicionalAMinimoAjustablePorciento.AdaptarMySQL_Decimal())
         R.add("pr_100401057887", me.OrdenDeAjusteDescuentoFijoDeProducto.AdaptarMySQL_Integer())
         R.add("pr_100401057888", me.OrdenDeAjusteDeDescuentoVIP.AdaptarMySQL_Integer())
         R.add("pr_100401057884", me.OrdenDeAjusteDeDescuentoAdicionalA.AdaptarMySQL_Integer())
         R.add("pr_100401057885", me.OrdenDeAjusteDeDescuentoGeneral.AdaptarMySQL_Integer())
         R.add("pr_100401057867", me.AjustarDescuentoB.AdaptarMySQL_Boolean())
         R.add("pr_100401057886", me.OrdenDeAjusteDescuentoOfertaDeProducto.AdaptarMySQL_Integer())
         R.add("pr_10040105787", me.FechaAlta_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_100401057868", me.AjustarDescuentoGeneral.AdaptarMySQL_Boolean())
         R.add("pr_100401057861", me.AjustarDescuentoVIP.AdaptarMySQL_Boolean())
         R.add("pr_100401057862", me.AjustarElSaldoPromocionalGeneradoEvitandoPosiblesPerdidasEnBaseAlPrecioMinimo.AdaptarMySQL_Boolean())
         R.add("pr_100401057863", me.AutoOmitirEntidadSiLlegaAlLimite.AdaptarMySQL_Boolean())
         R.add("pr_100401057864", me.AutoOmitirDescuentoProductoPorcientoSiLlegaAlLimite.AdaptarMySQL_Boolean())
         R.add("pr_100401057865", me.AjustarDescuentoOfertaDeProducto.AdaptarMySQL_Boolean())
         R.add("pr_100401057892", me.DescuentoGeneralMinimoAjustablePorciento.AdaptarMySQL_Decimal())
         R.add("pr_100401057893", me.ImporteDescuentoProductoFijoMinimoAjustable.AdaptarMySQL_Decimal())
         R.add("pr_100401057866", me.AutoOmitirAdicionalBSiLlegaAlLimite.AdaptarMySQL_Boolean())
         R.add("pr_100401057883", me.OrdenDeAjusteDeDescuentoTipoDeEntidad.AdaptarMySQL_Integer())
         If Me.ReferenciaAutorDelAlta IsNot nothing then
           R.add("pr_10040105783",me.ReferenciaAutorDelAlta.ID.STR())
         Else
           R.add("pr_10040105783","")
         End if
         R.add("pr_100401057860", me.AjusteDescuentoA.AdaptarMySQL_Boolean())
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
      Public Class ConfiguracionVentas_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_100401057825")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_100401057825", value)
            End Set
          End Property
          Public property AutoOmitirDescuentoProductoFijoSiLlegaAlLimite As Boolean
            get
                return me.GetValue_Boolean("pr_100401057879")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_100401057879", value)
            End Set
          End Property
          Public property AutoOmitirDescuentoOfertaSiLlegaAlLimitePorciento As Boolean
            get
                return me.GetValue_Boolean("pr_100401057880")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_100401057880", value)
            End Set
          End Property
          Public property AutoOmitirTentidadSiLlegaAlLimite As Boolean
            get
                return me.GetValue_Boolean("pr_100401057881")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_100401057881", value)
            End Set
          End Property
          Public property AplicarPagoDeSaldoPromocionalTeniendoEnCuentaLosImpuestosObsoleto As Boolean
            get
                return me.GetValue_Boolean("pr_100401057882")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_100401057882", value)
            End Set
          End Property
          Public property OrdenDeAjusteDeDescuentoEntidad As Integer
            get
                return me.GetValue_Int("pr_100401057891")
            End Get
            Set(value As Integer)
                me.SetValue_Int("pr_100401057891", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_100401057810")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As DateTime
            get
                return me.GetValue_DateTime("pr_10040105785")
            End Get   
        End Property
          Public property OrdenDeAjusteDescuentoProducto As Integer
            get
                return me.GetValue_Int("pr_100401057890")
            End Get
            Set(value As Integer)
                me.SetValue_Int("pr_100401057890", value)
            End Set
          End Property
          Public property AjustarDescuentoProducto As Boolean
            get
                return me.GetValue_Boolean("pr_100401057877")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_100401057877", value)
            End Set
          End Property
          Public property AutoOmitirAdicionalASiLlegaAlLimite As Boolean
            get
                return me.GetValue_Boolean("pr_100401057878")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_100401057878", value)
            End Set
          End Property
          Public property DescuentoProductoMinimoAjustablePorciento As Decimal
            get
                return me.GetValue_Decimal("pr_100401057899")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_100401057899", value)
            End Set
          End Property
          Public property DescuentoAdicionalBMinimoAjustablePorciento As Decimal
            get
                return me.GetValue_Decimal("pr_1004010578100")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_1004010578100", value)
            End Set
          End Property
          Public property TenerEnCuentaLosImpuestosParaGenerarSaldoPromocionalObsoleto As Boolean
            get
                return me.GetValue_Boolean("pr_100401057875")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_100401057875", value)
            End Set
          End Property
          Public property AjustarDescuentoFijoDeProducto As Boolean
            get
                return me.GetValue_Boolean("pr_100401057876")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_100401057876", value)
            End Set
          End Property
          Public property DescuentoEntidadMinimoAjustablePorciento As Decimal
            get
                return me.GetValue_Decimal("pr_100401057897")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_100401057897", value)
            End Set
          End Property
          Public property DescuentoTipoDeEntidadMinimoAjustablePorciento As Decimal
            get
                return me.GetValue_Decimal("pr_100401057898")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_100401057898", value)
            End Set
          End Property
          Public property Observaciones As String
            get
                return me.GetValue_String("pr_100401057857")
            End Get
            Set(value As String)
                me.SetValue_String("pr_100401057857", value)
            End Set
          End Property
          Public property AplicarSaldoPromocionalEnNegativoObsoleto As Boolean
            get
                return me.GetValue_Boolean("pr_100401057869")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_100401057869", value)
            End Set
          End Property
          Public property DescuentoOfertaProductoMinimoAjustablePorciento As Decimal
            get
                return me.GetValue_Decimal("pr_100401057896")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_100401057896", value)
            End Set
          End Property
          Public property AutoOmitirVIPSiLlegaAlLimite As Boolean
            get
                return me.GetValue_Boolean("pr_100401057870")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_100401057870", value)
            End Set
          End Property
          Public property OrdenDeAjusteDeDescuentoAdicionalB As Integer
            get
                return me.GetValue_Int("pr_100401057889")
            End Get
            Set(value As Integer)
                me.SetValue_Int("pr_100401057889", value)
            End Set
          End Property
          Public property DescripcionDescuentoAdicionalB As String
            get
                return me.GetValue_String("pr_100401057858")
            End Get
            Set(value As String)
                me.SetValue_String("pr_100401057858", value)
            End Set
          End Property
          Public property AjustarDescuentoTipoDeEntidad As Boolean
            get
                return me.GetValue_Boolean("pr_100401057871")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_100401057871", value)
            End Set
          End Property
          Public property AutoOmitirGeneralSiLlegaAlLimite As Boolean
            get
                return me.GetValue_Boolean("pr_100401057872")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_100401057872", value)
            End Set
          End Property
          Public property AjustarDescuentoEntidad As Boolean
            get
                return me.GetValue_Boolean("pr_100401057873")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_100401057873", value)
            End Set
          End Property
          Public property DescripcionDescuentoAdicionalA As String
            get
                return me.GetValue_String("pr_100401057859")
            End Get
            Set(value As String)
                me.SetValue_String("pr_100401057859", value)
            End Set
          End Property
          Public property DescuentoVIPMinimoAjustablePorciento As Decimal
            get
                return me.GetValue_Decimal("pr_100401057894")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_100401057894", value)
            End Set
          End Property
          Public property DescuentoAdicionalAMinimoAjustablePorciento As Decimal
            get
                return me.GetValue_Decimal("pr_100401057895")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_100401057895", value)
            End Set
          End Property
          Public property OrdenDeAjusteDescuentoFijoDeProducto As Integer
            get
                return me.GetValue_Int("pr_100401057887")
            End Get
            Set(value As Integer)
                me.SetValue_Int("pr_100401057887", value)
            End Set
          End Property
          Public property OrdenDeAjusteDeDescuentoVIP As Integer
            get
                return me.GetValue_Int("pr_100401057888")
            End Get
            Set(value As Integer)
                me.SetValue_Int("pr_100401057888", value)
            End Set
          End Property
          Public property OrdenDeAjusteDeDescuentoAdicionalA As Integer
            get
                return me.GetValue_Int("pr_100401057884")
            End Get
            Set(value As Integer)
                me.SetValue_Int("pr_100401057884", value)
            End Set
          End Property
          Public property OrdenDeAjusteDeDescuentoGeneral As Integer
            get
                return me.GetValue_Int("pr_100401057885")
            End Get
            Set(value As Integer)
                me.SetValue_Int("pr_100401057885", value)
            End Set
          End Property
          Public property AjustarDescuentoB As Boolean
            get
                return me.GetValue_Boolean("pr_100401057867")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_100401057867", value)
            End Set
          End Property
          Public property OrdenDeAjusteDescuentoOfertaDeProducto As Integer
            get
                return me.GetValue_Int("pr_100401057886")
            End Get
            Set(value As Integer)
                me.SetValue_Int("pr_100401057886", value)
            End Set
          End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_10040105787")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_10040105787", value)
            End Set
          End Property
          Public property AjustarDescuentoGeneral As Boolean
            get
                return me.GetValue_Boolean("pr_100401057868")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_100401057868", value)
            End Set
          End Property
          Public property AjustarDescuentoVIP As Boolean
            get
                return me.GetValue_Boolean("pr_100401057861")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_100401057861", value)
            End Set
          End Property
          Public property AjustarElSaldoPromocionalGeneradoEvitandoPosiblesPerdidasEnBaseAlPrecioMinimo As Boolean
            get
                return me.GetValue_Boolean("pr_100401057862")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_100401057862", value)
            End Set
          End Property
          Public property AutoOmitirEntidadSiLlegaAlLimite As Boolean
            get
                return me.GetValue_Boolean("pr_100401057863")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_100401057863", value)
            End Set
          End Property
          Public property AutoOmitirDescuentoProductoPorcientoSiLlegaAlLimite As Boolean
            get
                return me.GetValue_Boolean("pr_100401057864")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_100401057864", value)
            End Set
          End Property
          Public property AjustarDescuentoOfertaDeProducto As Boolean
            get
                return me.GetValue_Boolean("pr_100401057865")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_100401057865", value)
            End Set
          End Property
          Public property DescuentoGeneralMinimoAjustablePorciento As Decimal
            get
                return me.GetValue_Decimal("pr_100401057892")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_100401057892", value)
            End Set
          End Property
          Public property ImporteDescuentoProductoFijoMinimoAjustable As Decimal
            get
                return me.GetValue_Decimal("pr_100401057893")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_100401057893", value)
            End Set
          End Property
          Public property AutoOmitirAdicionalBSiLlegaAlLimite As Boolean
            get
                return me.GetValue_Boolean("pr_100401057866")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_100401057866", value)
            End Set
          End Property
          Public property OrdenDeAjusteDeDescuentoTipoDeEntidad As Integer
            get
                return me.GetValue_Int("pr_100401057883")
            End Get
            Set(value As Integer)
                me.SetValue_Int("pr_100401057883", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_10040105783")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_10040105783", value)
            End Set
          End Property
          Public property AjusteDescuentoA As Boolean
            get
                return me.GetValue_Boolean("pr_100401057860")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_100401057860", value)
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
