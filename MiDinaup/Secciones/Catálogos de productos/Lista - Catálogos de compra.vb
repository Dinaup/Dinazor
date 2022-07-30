   Imports System.ComponentModel
   Imports DinaNETCore
   Imports DinaNETCore.APID
Partial Public Class SeccionesD
  Public Class CatalogosDeCompraListaD
      Public Shared _SeccionID As String = "e3c28bfa-d9fc-47b8-834b-c4200c6f5292"
      Public Shared _SeccionIDGUID As New Guid("e3c28bfa-d9fc-47b8-834b-c4200c6f5292")
      Public Shared Async Function ConsultarDatos_Async(Parametros As SeccionConsultaParametrosC) As Task(Of List(Of CatalogosDeCompraListaC )) 
          Dim R As New List(Of CatalogosDeCompraListaC )  
          Dim d = Await Parametros.DinaupSesion.ConexionServidor.Funcion_Datos_Recibir_Async(CatalogosDeCompraListaES._SeccionID, False, Parametros) 
          If d.Datos.TieneDatos Then 
              For Each Actual In d.Datos 
                  Dim Valores_Listador = Actual.Value.Item1
                  Dim Obj_Listador As New CatalogosDeCompraListaC 
                  Obj_Listador.CargarDatos(Valores_Listador) 
                  Obj_Listador.CargaInterna(Actual.Value)
                  R.Add(Obj_Listador) 
              Next 
          End If 
          Return R 
      End Function 
      Public Class CatalogosDeCompraListaES
          Public shared _SeccionID as Guid = New Guid("e3c28bfa-d9fc-47b8-834b-c4200c6f5292")
          Public shared _Tabla$ = "tpr_2448_e"
      Public Shared ReferenciaImpuesto$ = "pr_45d4b8ax156wc"
      Public Shared FechaAlta_UTC$ = "pr_14c9f3de68g33ewd"
      Public Shared ReferenciaProducto$ = "pr_45c4348x164wc"
      Public Shared Advertencia$ = "pr_2623"
      Public Shared CatalogoActivo$ = "pr_1475n"
      Public Shared ImportePrecioUnidad$ = "pr_1154n"
      Public Shared Observaciones$ = "pr_1127n"
      Public Shared DisponibilidadBajoConsulta$ = "pr_1130n"
      Public Shared PedidoMinimo$ = "pr_1131n"
      Public Shared DescuentoPorciento$ = "pr_1368n"
      Public Shared PedidoMaximo$ = "pr_1153n"
      Public Shared ReferenciaAutorDelAlta$ = "pr_146310089fx53wd"
      Public Shared ReferenciaEntidad$ = "pr_1474n"
      Public Shared PedidoMaximoUnidades$ = "pr_6da5143wd"
      Public Shared ImporteDescuentoFijoUnidad$ = "pr_1369n"
      Public Shared Disponible$ = "pr_2624"
      Public Shared PreciosConImpuestosIncluidos$ = "pr_17edac5755x161wd"
      Public Shared ReferenciaDestinador$ = "pr_1463100935x269wd"
      Public Shared HoraLocal$ = "pr_776aedewd"
      Public Shared PedidoMinimoUnidades$ = "pr_6da5102wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_1463149014g47wd"
      Public Shared TiempoDeRecepcion$ = "pr_30040108581"
      Public Shared EntidadTieneAccesoWeb$ = "pr_146310d16di251wd"
      Public Shared ReferenciaMedida$ = "pr_4e83d1cx25awc"
      Public Shared CantidadMedidaBasePorUnd$ = "pr_6da51ddwd"
      Public Shared ReferenciaLimitarAUbicacion$ = "pr_40040136901"
      Public Shared SiempreSeAplica$ = "pr_60040340242"
      Public Shared ValoresConfiguradosAutomaticamente$ = "pr_50040339942"
      Public Shared IndicarManualmenteValoresImpuestosIncluidos$ = "pr_20040339953"
      Public Shared ImportePrecioUnidadImpuestosIncluidos$ = "pr_30040339953"
      Public Shared IndicarManualmenteValoresImpuestosNoIncluidos$ = "pr_20040339954"
      Public Shared ImporteDescuentoFijoImpuestosIncluidos$ = "pr_30040339952"
      Public Shared ImporteDescuentoFijoImpuestosNoIncluidos$ = "pr_30040339951"
      Public Shared ImporteTotalUnidadImpuestosIncluidos$ = "pr_30040339956"
      Public Shared ImportePrecioUnidadImpuestosNoIncluidos$ = "pr_20040339955"
      Public Shared ImporteTotalUnidadImpuestosNoIncluidos$ = "pr_30040339957"
      Public Shared DescuentoImpuestosNoIncluidosPorciento$ = "pr_20040340201"
      Public Shared DescuentoImpuestosIncluidosPorciento$ = "pr_20040340202"
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
      Public Class CatalogosDeCompraListaC
      Inherits Base_DatoC
          <DisplayName("Impuesto")>
          Public Property ReferenciaImpuesto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaImpuesto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaImpuesto"",""etiqueta"": ""Impuesto"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""f3199ee0-dc83-4667-a9c1-f3b04e97a8a4"",""titulo"": ""Base - Impuestos"",""iconoid"": ""ff4a7189-6426-43b9-bdc4-070314999e81"",""etiquetasingular"": ""Impuesto"",""etiquetaplural"": ""Impuestos"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""f3199ee0-dc83-4667-a9c1-f3b04e97a8a4"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Impuesto"",""descripcion"": """",""keyword"": ""ReferenciaImpuesto"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaImpuesto As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaImpuesto
          <DisplayName("Fecha Alta del registro")>
          Public Property FechaAlta_UTC As Date?
          Public Shared ___FechaAlta_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaAlta_UTC"",""etiqueta"": ""Fecha Alta del registro"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Alta del registro"",""descripcion"": """",""keyword"": ""FechaAlta_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaAlta_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaAlta_UTC
          <DisplayName("Producto")>
          Public Property ReferenciaProducto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaProducto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaProducto"",""etiqueta"": ""Producto"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""e28959bb-b7f1-4558-9e8a-4048e6c5f51a"",""titulo"": ""Base - Productos"",""iconoid"": ""21a04b44-ad38-44e0-a63a-98951da57cfa"",""etiquetasingular"": ""Producto"",""etiquetaplural"": ""Productos"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""e28959bb-b7f1-4558-9e8a-4048e6c5f51a"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Producto"",""descripcion"": """",""keyword"": ""ReferenciaProducto"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaProducto As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaProducto
          <DisplayName("Advertencia")>
          Public Property Advertencia As String
          Public Shared ___Advertencia As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Advertencia"",""etiqueta"": ""Advertencia"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Advertencia"",""descripcion"": """",""keyword"": ""Advertencia"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Advertencia As DinaNETCore.APID.DinaupAPI_CampoC = ___Advertencia
          <DisplayName("Catálogo Activo")>
          Public Property CatalogoActivo As Boolean
          Public Shared ___CatalogoActivo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CatalogoActivo"",""etiqueta"": ""Catálogo Activo"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Catálogo Activo"",""descripcion"": """",""keyword"": ""CatalogoActivo"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CatalogoActivo As DinaNETCore.APID.DinaupAPI_CampoC = ___CatalogoActivo
          <DisplayName("Precio Unidad")>
          Public Property ImportePrecioUnidad As Decimal
          Public Shared ___ImportePrecioUnidad As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImportePrecioUnidad"",""etiqueta"": ""Precio Unidad"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""6"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Precio Unidad"",""descripcion"": """",""keyword"": ""ImportePrecioUnidad"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImportePrecioUnidad As DinaNETCore.APID.DinaupAPI_CampoC = ___ImportePrecioUnidad
          <DisplayName("Observaciones")>
          Public Property Observaciones As String
          Public Shared ___Observaciones As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Observaciones"",""etiqueta"": ""Observaciones"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 9,""decimales"": ""0"",""multilinea"": true,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Observaciones"",""descripcion"": """",""keyword"": ""Observaciones"",""formato"": 5,""rol"": 9,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Observaciones As DinaNETCore.APID.DinaupAPI_CampoC = ___Observaciones
          <Description("Si esta casilla está marcada, quiere decir que el producto puede que no esté disponible y se deberá consultar al proveedor su disponibilidad.")>
          <DisplayName("Disponibilidad bajo consulta")>
          Public Property DisponibilidadBajoConsulta As Boolean
          Public Shared ___DisponibilidadBajoConsulta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DisponibilidadBajoConsulta"",""etiqueta"": ""Disponibilidad bajo consulta"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Disponibilidad bajo consulta"",""descripcion"": """",""keyword"": ""DisponibilidadBajoConsulta"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DisponibilidadBajoConsulta As DinaNETCore.APID.DinaupAPI_CampoC = ___DisponibilidadBajoConsulta
          <DisplayName("Pedido mínimo")>
          Public Property PedidoMinimo As Decimal
          Public Shared ___PedidoMinimo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""PedidoMinimo"",""etiqueta"": ""Pedido mínimo"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""11"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Pedido mínimo"",""descripcion"": """",""keyword"": ""PedidoMinimo"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __PedidoMinimo As DinaNETCore.APID.DinaupAPI_CampoC = ___PedidoMinimo
          <DisplayName("Descuento %")>
          Public Property DescuentoPorciento As Decimal
          Public Shared ___DescuentoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoPorciento"",""etiqueta"": ""Descuento %"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento %"",""descripcion"": """",""keyword"": ""DescuentoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoPorciento
          <DisplayName("Pedido máximo")>
          Public Property PedidoMaximo As Decimal
          Public Shared ___PedidoMaximo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""PedidoMaximo"",""etiqueta"": ""Pedido máximo"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""11"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Pedido máximo"",""descripcion"": """",""keyword"": ""PedidoMaximo"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __PedidoMaximo As DinaNETCore.APID.DinaupAPI_CampoC = ___PedidoMaximo
          <DisplayName("Autor del alta")>
          Public Property ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaAutorDelAlta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaAutorDelAlta"",""etiqueta"": ""Autor del alta"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta"",""descripcion"": """",""keyword"": ""ReferenciaAutorDelAlta"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaAutorDelAlta
          <DisplayName("Entidad")>
          Public Property ReferenciaEntidad As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaEntidad As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaEntidad"",""etiqueta"": ""Entidad"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Entidad"",""descripcion"": """",""keyword"": ""ReferenciaEntidad"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaEntidad As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaEntidad
          <DisplayName("Pedido máximo (Unidades)")>
          Public Property PedidoMaximoUnidades As Decimal
          Public Shared ___PedidoMaximoUnidades As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""PedidoMaximoUnidades"",""etiqueta"": ""Pedido máximo (Unidades)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""11"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Pedido máximo (Unidades)"",""descripcion"": """",""keyword"": ""PedidoMaximoUnidades"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __PedidoMaximoUnidades As DinaNETCore.APID.DinaupAPI_CampoC = ___PedidoMaximoUnidades
          <DisplayName("Descuento fijo unidad")>
          Public Property ImporteDescuentoFijoUnidad As Decimal
          Public Shared ___ImporteDescuentoFijoUnidad As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentoFijoUnidad"",""etiqueta"": ""Descuento fijo unidad"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento fijo unidad"",""descripcion"": """",""keyword"": ""ImporteDescuentoFijoUnidad"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentoFijoUnidad As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentoFijoUnidad
          <DisplayName("Disponible")>
          Public Property Disponible As Boolean
          Public Shared ___Disponible As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Disponible"",""etiqueta"": ""Disponible"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Disponible"",""descripcion"": """",""keyword"": ""Disponible"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Disponible As DinaNETCore.APID.DinaupAPI_CampoC = ___Disponible
          <DisplayName("Precios con impuestos incluidos")>
          Public Property PreciosConImpuestosIncluidos As Boolean
          Public Shared ___PreciosConImpuestosIncluidos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""PreciosConImpuestosIncluidos"",""etiqueta"": ""Precios con impuestos incluidos"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Precios con impuestos incluidos"",""descripcion"": """",""keyword"": ""PreciosConImpuestosIncluidos"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __PreciosConImpuestosIncluidos As DinaNETCore.APID.DinaupAPI_CampoC = ___PreciosConImpuestosIncluidos
          <DisplayName("Destinador")>
          Public Property ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaDestinador As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaDestinador"",""etiqueta"": ""Destinador"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""relacionesindirectas"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Destinador"",""descripcion"": """",""keyword"": ""ReferenciaDestinador"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaDestinador
          <DisplayName("Hora local")>
          Public Property HoraLocal As DateTime?
          Public Shared ___HoraLocal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""HoraLocal"",""etiqueta"": ""Hora local"",""oculta"": false,""formato"": 8,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Hora local"",""descripcion"": """",""keyword"": ""HoraLocal"",""formato"": 8,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __HoraLocal As DinaNETCore.APID.DinaupAPI_CampoC = ___HoraLocal
          <DisplayName("Pedido mínimo (Unidades)")>
          Public Property PedidoMinimoUnidades As Decimal
          Public Shared ___PedidoMinimoUnidades As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""PedidoMinimoUnidades"",""etiqueta"": ""Pedido mínimo (Unidades)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""11"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Pedido mínimo (Unidades)"",""descripcion"": """",""keyword"": ""PedidoMinimoUnidades"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __PedidoMinimoUnidades As DinaNETCore.APID.DinaupAPI_CampoC = ___PedidoMinimoUnidades
          <DisplayName("Autor del alta Tiene Acceso web")>
          Public Property AutorDelAltaTieneAccesoWeb As Boolean
          Public Shared ___AutorDelAltaTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AutorDelAltaTieneAccesoWeb"",""etiqueta"": ""Autor del alta Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta Tiene Acceso web"",""descripcion"": """",""keyword"": ""AutorDelAltaTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AutorDelAltaTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___AutorDelAltaTieneAccesoWeb
          <Description("El tiempo aproximado que tardará el producto en llegar para estar disponible a la venta una vez pedido al proveedor.")>
          <DisplayName("Tiempo de recepción")>
          Public Property TiempoDeRecepcion As String
          Public Shared ___TiempoDeRecepcion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TiempoDeRecepcion"",""etiqueta"": ""Tiempo de recepción"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Tiempo de recepción"",""descripcion"": """",""keyword"": ""TiempoDeRecepcion"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __TiempoDeRecepcion As DinaNETCore.APID.DinaupAPI_CampoC = ___TiempoDeRecepcion
          <DisplayName("Entidad Tiene Acceso web")>
          Public Property EntidadTieneAccesoWeb As Boolean
          Public Shared ___EntidadTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EntidadTieneAccesoWeb"",""etiqueta"": ""Entidad Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Entidad Tiene Acceso web"",""descripcion"": """",""keyword"": ""EntidadTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EntidadTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___EntidadTieneAccesoWeb
          <DisplayName("Medida")>
          Public Property ReferenciaMedida As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaMedida As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaMedida"",""etiqueta"": ""Medida"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c84f0381-d030-4223-a4e1-da78dda62ab4"",""titulo"": ""Base - Unidades de medida"",""iconoid"": ""0323688b-82a5-4fb7-a9f5-ff1247a52998"",""etiquetasingular"": ""Unidad de medida"",""etiquetaplural"": ""Unidades de medida"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""c84f0381-d030-4223-a4e1-da78dda62ab4"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Medida"",""descripcion"": """",""keyword"": ""ReferenciaMedida"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaMedida As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaMedida
          <DisplayName("Cantidad (Medida Base Por Und.)")>
          Public Property CantidadMedidaBasePorUnd As Decimal
          Public Shared ___CantidadMedidaBasePorUnd As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CantidadMedidaBasePorUnd"",""etiqueta"": ""Cantidad (Medida Base Por Und.)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""11"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cantidad (Medida Base Por Und.)"",""descripcion"": """",""keyword"": ""CantidadMedidaBasePorUnd"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CantidadMedidaBasePorUnd As DinaNETCore.APID.DinaupAPI_CampoC = ___CantidadMedidaBasePorUnd
          <DisplayName("Limitar a ubicación")>
          Public Property ReferenciaLimitarAUbicacion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaLimitarAUbicacion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaLimitarAUbicacion"",""etiqueta"": ""Limitar a ubicación"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""bffd6c6e-a75b-455f-8367-067e7bb2fb47"",""titulo"": ""Base - Ubicaciones"",""iconoid"": ""b985b58f-7275-46b8-9b66-2c54346b0185"",""etiquetasingular"": ""Ubicación"",""etiquetaplural"": ""Ubicaciones"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""bffd6c6e-a75b-455f-8367-067e7bb2fb47"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Limitar a ubicación"",""descripcion"": """",""keyword"": ""ReferenciaLimitarAUbicacion"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaLimitarAUbicacion As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaLimitarAUbicacion
          <DisplayName("Siempre se aplica")>
          Public Property SiempreSeAplica As Boolean
          Public Shared ___SiempreSeAplica As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""SiempreSeAplica"",""etiqueta"": ""Siempre se aplica"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Siempre se aplica"",""descripcion"": """",""keyword"": ""SiempreSeAplica"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __SiempreSeAplica As DinaNETCore.APID.DinaupAPI_CampoC = ___SiempreSeAplica
          <DisplayName("Valores configurados automáticamente")>
          Public Property ValoresConfiguradosAutomaticamente As Boolean
          Public Shared ___ValoresConfiguradosAutomaticamente As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ValoresConfiguradosAutomaticamente"",""etiqueta"": ""Valores configurados automáticamente"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Valores configurados automáticamente"",""descripcion"": """",""keyword"": ""ValoresConfiguradosAutomaticamente"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ValoresConfiguradosAutomaticamente As DinaNETCore.APID.DinaupAPI_CampoC = ___ValoresConfiguradosAutomaticamente
          <DisplayName("Indicar manualmente valores Impuestos incluidos")>
          Public Property IndicarManualmenteValoresImpuestosIncluidos As Boolean
          Public Shared ___IndicarManualmenteValoresImpuestosIncluidos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""IndicarManualmenteValoresImpuestosIncluidos"",""etiqueta"": ""Indicar manualmente valores Impuestos incluidos"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Indicar manualmente valores Impuestos incluidos"",""descripcion"": """",""keyword"": ""IndicarManualmenteValoresImpuestosIncluidos"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __IndicarManualmenteValoresImpuestosIncluidos As DinaNETCore.APID.DinaupAPI_CampoC = ___IndicarManualmenteValoresImpuestosIncluidos
          <DisplayName("Precio unidad (Impuestos incluidos)")>
          Public Property ImportePrecioUnidadImpuestosIncluidos As Decimal
          Public Shared ___ImportePrecioUnidadImpuestosIncluidos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImportePrecioUnidadImpuestosIncluidos"",""etiqueta"": ""Precio unidad (Impuestos incluidos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""6"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Precio unidad (Impuestos incluidos)"",""descripcion"": """",""keyword"": ""ImportePrecioUnidadImpuestosIncluidos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImportePrecioUnidadImpuestosIncluidos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImportePrecioUnidadImpuestosIncluidos
          <DisplayName("Indicar manualmente valores Impuestos no incluidos")>
          Public Property IndicarManualmenteValoresImpuestosNoIncluidos As Boolean
          Public Shared ___IndicarManualmenteValoresImpuestosNoIncluidos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""IndicarManualmenteValoresImpuestosNoIncluidos"",""etiqueta"": ""Indicar manualmente valores Impuestos no incluidos"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Indicar manualmente valores Impuestos no incluidos"",""descripcion"": """",""keyword"": ""IndicarManualmenteValoresImpuestosNoIncluidos"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __IndicarManualmenteValoresImpuestosNoIncluidos As DinaNETCore.APID.DinaupAPI_CampoC = ___IndicarManualmenteValoresImpuestosNoIncluidos
          <DisplayName("Descuento Fijo (Impuestos incluidos)")>
          Public Property ImporteDescuentoFijoImpuestosIncluidos As Decimal
          Public Shared ___ImporteDescuentoFijoImpuestosIncluidos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentoFijoImpuestosIncluidos"",""etiqueta"": ""Descuento Fijo (Impuestos incluidos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""6"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento Fijo (Impuestos incluidos)"",""descripcion"": """",""keyword"": ""ImporteDescuentoFijoImpuestosIncluidos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentoFijoImpuestosIncluidos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentoFijoImpuestosIncluidos
          <DisplayName("Descuento Fijo (Impuestos no incluidos)")>
          Public Property ImporteDescuentoFijoImpuestosNoIncluidos As Decimal
          Public Shared ___ImporteDescuentoFijoImpuestosNoIncluidos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentoFijoImpuestosNoIncluidos"",""etiqueta"": ""Descuento Fijo (Impuestos no incluidos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""6"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento Fijo (Impuestos no incluidos)"",""descripcion"": """",""keyword"": ""ImporteDescuentoFijoImpuestosNoIncluidos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentoFijoImpuestosNoIncluidos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentoFijoImpuestosNoIncluidos
          <DisplayName("Total unidad Impuestos Incluidos")>
          Public Property ImporteTotalUnidadImpuestosIncluidos As Decimal
          Public Shared ___ImporteTotalUnidadImpuestosIncluidos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteTotalUnidadImpuestosIncluidos"",""etiqueta"": ""Total unidad Impuestos Incluidos"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""6"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total unidad Impuestos Incluidos"",""descripcion"": """",""keyword"": ""ImporteTotalUnidadImpuestosIncluidos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteTotalUnidadImpuestosIncluidos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteTotalUnidadImpuestosIncluidos
          <DisplayName("Precio unidad (Impuestos no incluidos)")>
          Public Property ImportePrecioUnidadImpuestosNoIncluidos As Decimal
          Public Shared ___ImportePrecioUnidadImpuestosNoIncluidos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImportePrecioUnidadImpuestosNoIncluidos"",""etiqueta"": ""Precio unidad (Impuestos no incluidos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""6"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Precio unidad (Impuestos no incluidos)"",""descripcion"": """",""keyword"": ""ImportePrecioUnidadImpuestosNoIncluidos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImportePrecioUnidadImpuestosNoIncluidos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImportePrecioUnidadImpuestosNoIncluidos
          <DisplayName("Total unidad Impuestos no Incluidos")>
          Public Property ImporteTotalUnidadImpuestosNoIncluidos As Decimal
          Public Shared ___ImporteTotalUnidadImpuestosNoIncluidos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteTotalUnidadImpuestosNoIncluidos"",""etiqueta"": ""Total unidad Impuestos no Incluidos"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""6"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total unidad Impuestos no Incluidos"",""descripcion"": """",""keyword"": ""ImporteTotalUnidadImpuestosNoIncluidos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteTotalUnidadImpuestosNoIncluidos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteTotalUnidadImpuestosNoIncluidos
          <DisplayName("Descuento % (Impuestos no Incluidos)")>
          Public Property DescuentoImpuestosNoIncluidosPorciento As Decimal
          Public Shared ___DescuentoImpuestosNoIncluidosPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoImpuestosNoIncluidosPorciento"",""etiqueta"": ""Descuento % (Impuestos no Incluidos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento % (Impuestos no Incluidos)"",""descripcion"": """",""keyword"": ""DescuentoImpuestosNoIncluidosPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoImpuestosNoIncluidosPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoImpuestosNoIncluidosPorciento
          <DisplayName("Descuento % (Impuestos Incluidos)")>
          Public Property DescuentoImpuestosIncluidosPorciento As Decimal
          Public Shared ___DescuentoImpuestosIncluidosPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoImpuestosIncluidosPorciento"",""etiqueta"": ""Descuento % (Impuestos Incluidos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento % (Impuestos Incluidos)"",""descripcion"": """",""keyword"": ""DescuentoImpuestosIncluidosPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoImpuestosIncluidosPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoImpuestosIncluidosPorciento
          <ReadOnlyAttribute(True)>
          <DisplayName("ID")>
          Public Property ID As Guid
          Public Shared ___ID As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": true,""eseliminado"": false,""keyword"": ""ID"",""etiqueta"": ""ID"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""e3c28bfa-d9fc-47b8-834b-c4200c6f5292"",""titulo"": ""Lista - Catálogos de compra"",""iconoid"": ""a1be92bf-0bf1-4ebe-b8ea-d6fa6e44b0b1"",""etiquetasingular"": ""Producto de catalogo"",""etiquetaplural"": ""Productos de catalogo"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": true,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""e3c28bfa-d9fc-47b8-834b-c4200c6f5292"",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""ID"",""descripcion"": """",""keyword"": ""ID"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
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
          <ReadOnlyAttribute(True)>
          <DisplayName("Catálogo de compra (Listador) (Relación)")>
          Public Property RelacionElementoContenedorListador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___RelacionElementoContenedorListador As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RelacionElementoContenedorListador"",""etiqueta"": ""Catálogo de compra (Listador) (Relación)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""d64c88c8-080f-436e-a5e3-74cf009b10e6"",""titulo"": ""Catálogos de compra"",""iconoid"": ""a1be92bf-0bf1-4ebe-b8ea-d6fa6e44b0b1"",""etiquetasingular"": ""Catálogo de compra"",""etiquetaplural"": ""Catálogos de compra"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""d64c88c8-080f-436e-a5e3-74cf009b10e6"",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Catálogo de compra (Listador) (Relación)"",""descripcion"": """",""keyword"": ""RelacionElementoContenedorListador"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RelacionElementoContenedorListador As DinaNETCore.APID.DinaupAPI_CampoC = ___RelacionElementoContenedorListador
          <DisplayName("Catálogo de compra (Listador) Eliminadoo *")>
          Public Property Listadoreliminado As Boolean
          Public Shared ___Listadoreliminado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Listadoreliminado"",""etiqueta"": ""Catálogo de compra (Listador) Eliminadoo *"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Catálogo de compra (Listador) Eliminadoo *"",""descripcion"": """",""keyword"": ""Listadoreliminado"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Listadoreliminado As DinaNETCore.APID.DinaupAPI_CampoC = ___Listadoreliminado
          Overrides Sub CargarDatos(_Datos as Dic(of string,string))
          me.ReferenciaImpuesto = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_45d4b8ax156wc"), _Datos.Leer_String("pr_45d4b8ax156wc.nombre"))
          me.FechaAlta_UTC = _Datos.Leer_DateTime_Nulable("pr_14c9f3de68g33ewd")
          me.ReferenciaProducto = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_45c4348x164wc"), _Datos.Leer_String("pr_45c4348x164wc.nombre"))
          me.Advertencia = _Datos.Leer_String("pr_2623")
          me.CatalogoActivo = _Datos.Leer_Boolean("pr_1475n")
          me.ImportePrecioUnidad = _Datos.Leer_Decimal("pr_1154n")
          me.Observaciones = _Datos.Leer_String("pr_1127n")
          me.DisponibilidadBajoConsulta = _Datos.Leer_Boolean("pr_1130n")
          me.PedidoMinimo = _Datos.Leer_Decimal("pr_1131n")
          me.DescuentoPorciento = _Datos.Leer_Decimal("pr_1368n")
          me.PedidoMaximo = _Datos.Leer_Decimal("pr_1153n")
          me.ReferenciaAutorDelAlta = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_146310089fx53wd"), _Datos.Leer_String("pr_146310089fx53wd.nombre"))
          me.ReferenciaEntidad = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_1474n"), _Datos.Leer_String("pr_1474n.nombre"))
          me.PedidoMaximoUnidades = _Datos.Leer_Decimal("pr_6da5143wd")
          me.ImporteDescuentoFijoUnidad = _Datos.Leer_Decimal("pr_1369n")
          me.Disponible = _Datos.Leer_Boolean("pr_2624")
          me.PreciosConImpuestosIncluidos = _Datos.Leer_Boolean("pr_17edac5755x161wd")
          me.ReferenciaDestinador = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_1463100935x269wd"), _Datos.Leer_String("pr_1463100935x269wd.nombre"))
          me.HoraLocal = _Datos.Leer_Time_Nulable("pr_776aedewd")
          me.PedidoMinimoUnidades = _Datos.Leer_Decimal("pr_6da5102wd")
          me.AutorDelAltaTieneAccesoWeb = _Datos.Leer_Boolean("pr_1463149014g47wd")
          me.TiempoDeRecepcion = _Datos.Leer_String("pr_30040108581")
          me.EntidadTieneAccesoWeb = _Datos.Leer_Boolean("pr_146310d16di251wd")
          me.ReferenciaMedida = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_4e83d1cx25awc"), _Datos.Leer_String("pr_4e83d1cx25awc.nombre"))
          me.CantidadMedidaBasePorUnd = _Datos.Leer_Decimal("pr_6da51ddwd")
          me.ReferenciaLimitarAUbicacion = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_40040136901"), _Datos.Leer_String("pr_40040136901.nombre"))
          me.SiempreSeAplica = _Datos.Leer_Boolean("pr_60040340242")
          me.ValoresConfiguradosAutomaticamente = _Datos.Leer_Boolean("pr_50040339942")
          me.IndicarManualmenteValoresImpuestosIncluidos = _Datos.Leer_Boolean("pr_20040339953")
          me.ImportePrecioUnidadImpuestosIncluidos = _Datos.Leer_Decimal("pr_30040339953")
          me.IndicarManualmenteValoresImpuestosNoIncluidos = _Datos.Leer_Boolean("pr_20040339954")
          me.ImporteDescuentoFijoImpuestosIncluidos = _Datos.Leer_Decimal("pr_30040339952")
          me.ImporteDescuentoFijoImpuestosNoIncluidos = _Datos.Leer_Decimal("pr_30040339951")
          me.ImporteTotalUnidadImpuestosIncluidos = _Datos.Leer_Decimal("pr_30040339956")
          me.ImportePrecioUnidadImpuestosNoIncluidos = _Datos.Leer_Decimal("pr_20040339955")
          me.ImporteTotalUnidadImpuestosNoIncluidos = _Datos.Leer_Decimal("pr_30040339957")
          me.DescuentoImpuestosNoIncluidosPorciento = _Datos.Leer_Decimal("pr_20040340201")
          me.DescuentoImpuestosIncluidosPorciento = _Datos.Leer_Decimal("pr_20040340202")
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
           R.add("pr_45d4b8ax156wc",me.ReferenciaImpuesto.ID.STR())
         Else
           R.add("pr_45d4b8ax156wc","")
         End if
         R.add("pr_14c9f3de68g33ewd", me.FechaAlta_UTC.AdaptarMySQL_DateTime_Nulable())
         If Me.ReferenciaProducto IsNot nothing then
           R.add("pr_45c4348x164wc",me.ReferenciaProducto.ID.STR())
         Else
           R.add("pr_45c4348x164wc","")
         End if
         R.add("pr_2623", me.Advertencia.AdaptarMySQL_String())
         R.add("pr_1475n", me.CatalogoActivo.AdaptarMySQL_Boolean())
         R.add("pr_1154n", me.ImportePrecioUnidad.AdaptarMySQL_Decimal())
         R.add("pr_1127n", me.Observaciones.AdaptarMySQL_String())
         R.add("pr_1130n", me.DisponibilidadBajoConsulta.AdaptarMySQL_Boolean())
         R.add("pr_1131n", me.PedidoMinimo.AdaptarMySQL_Decimal())
         R.add("pr_1368n", me.DescuentoPorciento.AdaptarMySQL_Decimal())
         R.add("pr_1153n", me.PedidoMaximo.AdaptarMySQL_Decimal())
         If Me.ReferenciaAutorDelAlta IsNot nothing then
           R.add("pr_146310089fx53wd",me.ReferenciaAutorDelAlta.ID.STR())
         Else
           R.add("pr_146310089fx53wd","")
         End if
         If Me.ReferenciaEntidad IsNot nothing then
           R.add("pr_1474n",me.ReferenciaEntidad.ID.STR())
         Else
           R.add("pr_1474n","")
         End if
         R.add("pr_6da5143wd", me.PedidoMaximoUnidades.AdaptarMySQL_Decimal())
         R.add("pr_1369n", me.ImporteDescuentoFijoUnidad.AdaptarMySQL_Decimal())
         R.add("pr_2624", me.Disponible.AdaptarMySQL_Boolean())
         R.add("pr_17edac5755x161wd", me.PreciosConImpuestosIncluidos.AdaptarMySQL_Boolean())
         If Me.ReferenciaDestinador IsNot nothing then
           R.add("pr_1463100935x269wd",me.ReferenciaDestinador.ID.STR())
         Else
           R.add("pr_1463100935x269wd","")
         End if
         R.add("pr_776aedewd", me.HoraLocal.AdaptarMySQL_Time_Nulable())
         R.add("pr_6da5102wd", me.PedidoMinimoUnidades.AdaptarMySQL_Decimal())
         R.add("pr_1463149014g47wd", me.AutorDelAltaTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_30040108581", me.TiempoDeRecepcion.AdaptarMySQL_String())
         R.add("pr_146310d16di251wd", me.EntidadTieneAccesoWeb.AdaptarMySQL_Boolean())
         If Me.ReferenciaMedida IsNot nothing then
           R.add("pr_4e83d1cx25awc",me.ReferenciaMedida.ID.STR())
         Else
           R.add("pr_4e83d1cx25awc","")
         End if
         R.add("pr_6da51ddwd", me.CantidadMedidaBasePorUnd.AdaptarMySQL_Decimal())
         If Me.ReferenciaLimitarAUbicacion IsNot nothing then
           R.add("pr_40040136901",me.ReferenciaLimitarAUbicacion.ID.STR())
         Else
           R.add("pr_40040136901","")
         End if
         R.add("pr_60040340242", me.SiempreSeAplica.AdaptarMySQL_Boolean())
         R.add("pr_50040339942", me.ValoresConfiguradosAutomaticamente.AdaptarMySQL_Boolean())
         R.add("pr_20040339953", me.IndicarManualmenteValoresImpuestosIncluidos.AdaptarMySQL_Boolean())
         R.add("pr_30040339953", me.ImportePrecioUnidadImpuestosIncluidos.AdaptarMySQL_Decimal())
         R.add("pr_20040339954", me.IndicarManualmenteValoresImpuestosNoIncluidos.AdaptarMySQL_Boolean())
         R.add("pr_30040339952", me.ImporteDescuentoFijoImpuestosIncluidos.AdaptarMySQL_Decimal())
         R.add("pr_30040339951", me.ImporteDescuentoFijoImpuestosNoIncluidos.AdaptarMySQL_Decimal())
         R.add("pr_30040339956", me.ImporteTotalUnidadImpuestosIncluidos.AdaptarMySQL_Decimal())
         R.add("pr_20040339955", me.ImportePrecioUnidadImpuestosNoIncluidos.AdaptarMySQL_Decimal())
         R.add("pr_30040339957", me.ImporteTotalUnidadImpuestosNoIncluidos.AdaptarMySQL_Decimal())
         R.add("pr_20040340201", me.DescuentoImpuestosNoIncluidosPorciento.AdaptarMySQL_Decimal())
         R.add("pr_20040340202", me.DescuentoImpuestosIncluidosPorciento.AdaptarMySQL_Decimal())
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
      Public Class CatalogosDeCompraLista_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
          Public property ReferenciaImpuesto As Guid
            get
                return me.GetValue_Guid("pr_45d4b8ax156wc")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_45d4b8ax156wc", value)
            End Set
          End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_14c9f3de68g33ewd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_14c9f3de68g33ewd", value)
            End Set
          End Property
          Public property ReferenciaProducto As Guid
            get
                return me.GetValue_Guid("pr_45c4348x164wc")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_45c4348x164wc", value)
            End Set
          End Property
          Public property Advertencia As String
            get
                return me.GetValue_String("pr_2623")
            End Get
            Set(value As String)
                me.SetValue_String("pr_2623", value)
            End Set
          End Property
          Public property CatalogoActivo As Boolean
            get
                return me.GetValue_Boolean("pr_1475n")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_1475n", value)
            End Set
          End Property
          Public property ImportePrecioUnidad As Decimal
            get
                return me.GetValue_Decimal("pr_1154n")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_1154n", value)
            End Set
          End Property
          Public property Observaciones As String
            get
                return me.GetValue_String("pr_1127n")
            End Get
            Set(value As String)
                me.SetValue_String("pr_1127n", value)
            End Set
          End Property
          Public property DisponibilidadBajoConsulta As Boolean
            get
                return me.GetValue_Boolean("pr_1130n")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_1130n", value)
            End Set
          End Property
          Public property PedidoMinimo As Decimal
            get
                return me.GetValue_Decimal("pr_1131n")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_1131n", value)
            End Set
          End Property
          Public property DescuentoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_1368n")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_1368n", value)
            End Set
          End Property
          Public property PedidoMaximo As Decimal
            get
                return me.GetValue_Decimal("pr_1153n")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_1153n", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_146310089fx53wd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_146310089fx53wd", value)
            End Set
          End Property
          Public property ReferenciaEntidad As Guid
            get
                return me.GetValue_Guid("pr_1474n")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_1474n", value)
            End Set
          End Property
          Public property PedidoMaximoUnidades As Decimal
            get
                return me.GetValue_Decimal("pr_6da5143wd")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_6da5143wd", value)
            End Set
          End Property
          Public property ImporteDescuentoFijoUnidad As Decimal
            get
                return me.GetValue_Decimal("pr_1369n")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_1369n", value)
            End Set
          End Property
          Public property Disponible As Boolean
            get
                return me.GetValue_Boolean("pr_2624")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_2624", value)
            End Set
          End Property
        Public ReadOnly property PreciosConImpuestosIncluidos As Boolean
            get
                return me.GetValue_Boolean("pr_17edac5755x161wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_1463100935x269wd")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As DateTime
            get
                return me.GetValue_DateTime("pr_776aedewd")
            End Get   
        End Property
          Public property PedidoMinimoUnidades As Decimal
            get
                return me.GetValue_Decimal("pr_6da5102wd")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_6da5102wd", value)
            End Set
          End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_1463149014g47wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_1463149014g47wd", value)
            End Set
          End Property
          Public property TiempoDeRecepcion As String
            get
                return me.GetValue_String("pr_30040108581")
            End Get
            Set(value As String)
                me.SetValue_String("pr_30040108581", value)
            End Set
          End Property
          Public property EntidadTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_146310d16di251wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_146310d16di251wd", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaMedida As Guid
            get
                return me.GetValue_Guid("pr_4e83d1cx25awc")
            End Get   
        End Property
        Public ReadOnly property CantidadMedidaBasePorUnd As Decimal
            get
                return me.GetValue_Decimal("pr_6da51ddwd")
            End Get   
        End Property
          Public property ReferenciaLimitarAUbicacion As Guid
            get
                return me.GetValue_Guid("pr_40040136901")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_40040136901", value)
            End Set
          End Property
          Public property SiempreSeAplica As Boolean
            get
                return me.GetValue_Boolean("pr_60040340242")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_60040340242", value)
            End Set
          End Property
          Public property ValoresConfiguradosAutomaticamente As Boolean
            get
                return me.GetValue_Boolean("pr_50040339942")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_50040339942", value)
            End Set
          End Property
          Public property IndicarManualmenteValoresImpuestosIncluidos As Boolean
            get
                return me.GetValue_Boolean("pr_20040339953")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_20040339953", value)
            End Set
          End Property
          Public property ImportePrecioUnidadImpuestosIncluidos As Decimal
            get
                return me.GetValue_Decimal("pr_30040339953")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_30040339953", value)
            End Set
          End Property
          Public property IndicarManualmenteValoresImpuestosNoIncluidos As Boolean
            get
                return me.GetValue_Boolean("pr_20040339954")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_20040339954", value)
            End Set
          End Property
          Public property ImporteDescuentoFijoImpuestosIncluidos As Decimal
            get
                return me.GetValue_Decimal("pr_30040339952")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_30040339952", value)
            End Set
          End Property
          Public property ImporteDescuentoFijoImpuestosNoIncluidos As Decimal
            get
                return me.GetValue_Decimal("pr_30040339951")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_30040339951", value)
            End Set
          End Property
        Public ReadOnly property ImporteTotalUnidadImpuestosIncluidos As Decimal
            get
                return me.GetValue_Decimal("pr_30040339956")
            End Get   
        End Property
          Public property ImportePrecioUnidadImpuestosNoIncluidos As Decimal
            get
                return me.GetValue_Decimal("pr_20040339955")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_20040339955", value)
            End Set
          End Property
        Public ReadOnly property ImporteTotalUnidadImpuestosNoIncluidos As Decimal
            get
                return me.GetValue_Decimal("pr_30040339957")
            End Get   
        End Property
          Public property DescuentoImpuestosNoIncluidosPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_20040340201")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_20040340201", value)
            End Set
          End Property
          Public property DescuentoImpuestosIncluidosPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_20040340202")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_20040340202", value)
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
