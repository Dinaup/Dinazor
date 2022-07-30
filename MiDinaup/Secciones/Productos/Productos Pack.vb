   Imports System.ComponentModel
   Imports DinaNETCore
   Imports DinaNETCore.APID
Partial Public Class SeccionesD
  Public Class ProductosPackD
      Public Shared _SeccionID As String = "0ceb234a-5a91-4f33-b70e-62e17f020a3c"
      Public Shared _SeccionIDGUID As New Guid("0ceb234a-5a91-4f33-b70e-62e17f020a3c")
      Public Shared Async Function ConsultarDatos_Async(Parametros As SeccionConsultaParametrosC) As Task(Of List(Of ProductosPackC )) 
          Dim R As New List(Of ProductosPackC )  
          Dim d = Await Parametros.DinaupSesion.ConexionServidor.Funcion_Datos_Recibir_Async(ProductosPackES._SeccionID, False, Parametros) 
          If d.Datos.TieneDatos Then 
              For Each Actual In d.Datos 
                  Dim Valores_Listador = Actual.Value.Item1
                  Dim Obj_Listador As New ProductosPackC 
                  Obj_Listador.CargarDatos(Valores_Listador) 
                  Obj_Listador.CargaInterna(Actual.Value)
                  R.Add(Obj_Listador) 
              Next 
          End If 
          Return R 
      End Function 
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As ProductosPackC, Optional CampoWhere$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Return Await DatosGuardar_Async(DinaupSesion, New List(Of ProductosPackC)({DAtos}), CampoWhere )
      End Function
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As List(Of ProductosPackC), Optional CampoWhere$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Dim Importar As New List(Of DinaupAPI_ImportacionProcesableC)
          For Each Actual In DAtos 
              Dim RegistroActual = New DinaupAPI_ImportacionProcesableC() 
               RegistroActual.dinaup_listador_datos = Actual.ToDic 
               Importar.Add(RegistroActual)  
          Next 
          Return Await DinaupSesion.ConexionServidor.Funcion_Importar_Ejecutar_Async(DinaupSesion, ProductosPackES._SeccionID, Importar, CampoWhere, "") 
      End Function
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As ProductosPack_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, ProductosPackES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New ProductosPack_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As ProductosPack_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, ProductosPackES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New ProductosPack_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class ProductosPackES
          Public shared _SeccionID as Guid = New Guid("0ceb234a-5a91-4f33-b70e-62e17f020a3c")
          Public shared _Tabla$ = "tpr_50"
      Public Shared ProveedorHabitualTieneAccesoWeb$ = "pr_146310d337x298wd"
      Public Shared EsPack$ = "pr_491fa38x1cbwc"
      Public Shared HoraLocal$ = "pr_776ae56wd"
      Public Shared ReferenciaDestinador$ = "pr_14631062fcx362wd"
      Public Shared ReferenciaMarca$ = "pr_10040108751"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_146314929fg3b1wd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_14631061f4j175wd"
      Public Shared ReferenciaUnidadDeMedidaPesoBase$ = "pr_48e6710xbewc"
      Public Shared CodigoInterno$ = "pr_14087n"
      Public Shared EvaluarStock$ = "pr_14183n"
      Public Shared ReferenciaCategoria$ = "pr_400401087449"
      Public Shared PesoPorUnd$ = "pr_1031n"
      Public Shared RecomendarEsteProductoAlCoincidirLaEquivalenciaConOtroSustitucion$ = "pr_14"
      Public Shared FormatoDePresentacion$ = "pr_611cf641"
      Public Shared ReferenciaImagen$ = "pr_18"
      Public Shared ReferenciaCodigoDeBarras$ = "pr_4"
      Public Shared CantidadMedida$ = "pr_1030n"
      Public Shared CantidadMedidaBase$ = "pr_1040n"
      Public Shared ReferenciaMedidaBase$ = "pr_48e660ax2a7wc"
      Public Shared Descontinuado$ = "pr_64f65875"
      Public Shared AlertaAlVender$ = "pr_14262n"
      Public Shared FechaAlta_UTC$ = "pr_14c9f3ec87g125wd"
      Public Shared ExportarEnModulos$ = "pr_1463106270g23awd"
      Public Shared PesoEnUnidadBasica$ = "pr_1039n"
      Public Shared ReferenciaUnidadMedidaPeso$ = "pr_1032n"
      Public Shared Equivalencia$ = "pr_6"
      Public Shared ArgumentosDeSustitucionDeEquivalenciaParaElCliente$ = "pr_2226"
      Public Shared ReferenciaProveedorHabitual$ = "pr_34"
      Public Shared AlertaAlComprar$ = "pr_14266n"
      Public Shared Descripcion$ = "pr_5"
      Public Shared ReferenciaMedidaAccesible$ = "pr_1035n"
      Public Shared NombrePublico$ = "pr_17dac2f6d6x35bwd"
      Public Shared ImportePrecioMedioDeVentaConImpuestos$ = "pr_20040195741005"
      Public Shared ImportePrecioMedioDeCompraSinImpuestos$ = "pr_60040195711002"
      Public Shared ImportePrecioMedioDeVentaSinImpuestos$ = "pr_60040195711001"
      Public Shared ReferenciaCategoriaDeCompraPorDefecto$ = "pr_40040133302"
      Public Shared ImportePrecioMedioDeCompraConImpuestos$ = "pr_20040195741004"
      Public Shared ReferenciaCategoriaDeVentaPorDefecto$ = "pr_40040133303"
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
      Public Class ProductosPackC
      Inherits Base_DatoC
          <DisplayName("Proveedor habitual Tiene Acceso web")>
          Public Property ProveedorHabitualTieneAccesoWeb As Boolean
          Public Shared ___ProveedorHabitualTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ProveedorHabitualTieneAccesoWeb"",""etiqueta"": ""Proveedor habitual Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Proveedor habitual Tiene Acceso web"",""descripcion"": """",""keyword"": ""ProveedorHabitualTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ProveedorHabitualTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___ProveedorHabitualTieneAccesoWeb
          <DisplayName("Es pack")>
          Public Property EsPack As Boolean
          Public Shared ___EsPack As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EsPack"",""etiqueta"": ""Es pack"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Es pack"",""descripcion"": """",""keyword"": ""EsPack"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EsPack As DinaNETCore.APID.DinaupAPI_CampoC = ___EsPack
          <DisplayName("Hora local")>
          Public Property HoraLocal As DateTime?
          Public Shared ___HoraLocal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""HoraLocal"",""etiqueta"": ""Hora local"",""oculta"": false,""formato"": 8,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Hora local"",""descripcion"": """",""keyword"": ""HoraLocal"",""formato"": 8,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __HoraLocal As DinaNETCore.APID.DinaupAPI_CampoC = ___HoraLocal
          <DisplayName("Destinador")>
          Public Property ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaDestinador As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaDestinador"",""etiqueta"": ""Destinador"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""relacionesindirectas"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Destinador"",""descripcion"": """",""keyword"": ""ReferenciaDestinador"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaDestinador
          <DisplayName("Marca")>
          Public Property ReferenciaMarca As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaMarca As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaMarca"",""etiqueta"": ""Marca"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""fa425ef0-9001-4a0b-8795-93e4dba8719f"",""titulo"": ""Base - Marcas comerciales"",""iconoid"": ""46bff251-7bbe-4c8d-adb2-7605e6393ab2"",""etiquetasingular"": ""Marca comercial"",""etiquetaplural"": ""Marcas comerciales"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""fa425ef0-9001-4a0b-8795-93e4dba8719f"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Marca"",""descripcion"": """",""keyword"": ""ReferenciaMarca"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaMarca As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaMarca
          <DisplayName("Autor del alta Tiene Acceso web")>
          Public Property AutorDelAltaTieneAccesoWeb As Boolean
          Public Shared ___AutorDelAltaTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AutorDelAltaTieneAccesoWeb"",""etiqueta"": ""Autor del alta Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta Tiene Acceso web"",""descripcion"": """",""keyword"": ""AutorDelAltaTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AutorDelAltaTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___AutorDelAltaTieneAccesoWeb
          <DisplayName("Autor del alta")>
          Public Property ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaAutorDelAlta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaAutorDelAlta"",""etiqueta"": ""Autor del alta"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta"",""descripcion"": """",""keyword"": ""ReferenciaAutorDelAlta"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaAutorDelAlta
          <DisplayName("Unidad de medida peso (Base)")>
          Public Property ReferenciaUnidadDeMedidaPesoBase As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaUnidadDeMedidaPesoBase As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaUnidadDeMedidaPesoBase"",""etiqueta"": ""Unidad de medida peso (Base)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c84f0381-d030-4223-a4e1-da78dda62ab4"",""titulo"": ""Base - Unidades de medida"",""iconoid"": ""0323688b-82a5-4fb7-a9f5-ff1247a52998"",""etiquetasingular"": ""Unidad de medida"",""etiquetaplural"": ""Unidades de medida"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""c84f0381-d030-4223-a4e1-da78dda62ab4"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Unidad de medida peso (Base)"",""descripcion"": """",""keyword"": ""ReferenciaUnidadDeMedidaPesoBase"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaUnidadDeMedidaPesoBase As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaUnidadDeMedidaPesoBase
          <DisplayName("Código Interno")>
          Public Property CodigoInterno As String
          Public Shared ___CodigoInterno As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CodigoInterno"",""etiqueta"": ""Código Interno"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Código Interno"",""descripcion"": """",""keyword"": ""CodigoInterno"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CodigoInterno As DinaNETCore.APID.DinaupAPI_CampoC = ___CodigoInterno
          <DisplayName("Evaluar Stock")>
          Public Property EvaluarStock As Boolean
          Public Shared ___EvaluarStock As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EvaluarStock"",""etiqueta"": ""Evaluar Stock"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Evaluar Stock"",""descripcion"": """",""keyword"": ""EvaluarStock"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EvaluarStock As DinaNETCore.APID.DinaupAPI_CampoC = ___EvaluarStock
          <DisplayName("Categoría")>
          Public Property ReferenciaCategoria As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaCategoria As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaCategoria"",""etiqueta"": ""Categoría"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""9adc0784-ef94-4dd2-a6ed-6b2c41847136"",""titulo"": ""Base - Categorías de productos"",""iconoid"": ""6c8b5d81-54ed-480b-a63b-58df294493fc"",""etiquetasingular"": ""Categoría de productos"",""etiquetaplural"": ""Categorías de productos"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""9adc0784-ef94-4dd2-a6ed-6b2c41847136"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Categoría"",""descripcion"": """",""keyword"": ""ReferenciaCategoria"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaCategoria As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaCategoria
          <DisplayName("Peso por Und.")>
          Public Property PesoPorUnd As Decimal
          Public Shared ___PesoPorUnd As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""PesoPorUnd"",""etiqueta"": ""Peso por Und."",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""11"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Peso por Und."",""descripcion"": """",""keyword"": ""PesoPorUnd"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __PesoPorUnd As DinaNETCore.APID.DinaupAPI_CampoC = ___PesoPorUnd
          <DisplayName("Recomendar este producto al coincidir la equivalencia con otro (Sustitución)")>
          Public Property RecomendarEsteProductoAlCoincidirLaEquivalenciaConOtroSustitucion As Boolean
          Public Shared ___RecomendarEsteProductoAlCoincidirLaEquivalenciaConOtroSustitucion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RecomendarEsteProductoAlCoincidirLaEquivalenciaConOtroSustitucion"",""etiqueta"": ""Recomendar este producto al coincidir la equivalencia con otro (Sustitución)"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Recomendar este producto al coincidir la equivalencia con otro (Sustitución)"",""descripcion"": """",""keyword"": ""RecomendarEsteProductoAlCoincidirLaEquivalenciaConOtroSustitucion"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RecomendarEsteProductoAlCoincidirLaEquivalenciaConOtroSustitucion As DinaNETCore.APID.DinaupAPI_CampoC = ___RecomendarEsteProductoAlCoincidirLaEquivalenciaConOtroSustitucion
          <DisplayName("Formato de presentación")>
          Public Property FormatoDePresentacion As String
          Public Shared ___FormatoDePresentacion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FormatoDePresentacion"",""etiqueta"": ""Formato de presentación"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Formato de presentación"",""descripcion"": """",""keyword"": ""FormatoDePresentacion"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __FormatoDePresentacion As DinaNETCore.APID.DinaupAPI_CampoC = ___FormatoDePresentacion
          <DisplayName("Imagen")>
          Public Property ReferenciaImagen As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaImagen As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaImagen"",""etiqueta"": ""Imagen"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""imagenes"",""rol"": 17,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Imagen"",""descripcion"": """",""keyword"": ""ReferenciaImagen"",""formato"": 9,""rol"": 17,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaImagen As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaImagen
          <DisplayName("Referencia / Código de Barras")>
          Public Property ReferenciaCodigoDeBarras As String
          Public Shared ___ReferenciaCodigoDeBarras As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaCodigoDeBarras"",""etiqueta"": ""Referencia / Código de Barras"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 12,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Referencia / Código de Barras"",""descripcion"": """",""keyword"": ""ReferenciaCodigoDeBarras"",""formato"": 5,""rol"": 12,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaCodigoDeBarras As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaCodigoDeBarras
          <DisplayName("Cantidad (Medida)")>
          Public Property CantidadMedida As Decimal
          Public Shared ___CantidadMedida As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CantidadMedida"",""etiqueta"": ""Cantidad (Medida)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""11"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cantidad (Medida)"",""descripcion"": """",""keyword"": ""CantidadMedida"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CantidadMedida As DinaNETCore.APID.DinaupAPI_CampoC = ___CantidadMedida
          <DisplayName("Cantidad (Medida Base)")>
          Public Property CantidadMedidaBase As Decimal
          Public Shared ___CantidadMedidaBase As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CantidadMedidaBase"",""etiqueta"": ""Cantidad (Medida Base)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""11"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cantidad (Medida Base)"",""descripcion"": """",""keyword"": ""CantidadMedidaBase"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CantidadMedidaBase As DinaNETCore.APID.DinaupAPI_CampoC = ___CantidadMedidaBase
          <DisplayName("Medida (Base)")>
          Public Property ReferenciaMedidaBase As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaMedidaBase As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaMedidaBase"",""etiqueta"": ""Medida (Base)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c84f0381-d030-4223-a4e1-da78dda62ab4"",""titulo"": ""Base - Unidades de medida"",""iconoid"": ""0323688b-82a5-4fb7-a9f5-ff1247a52998"",""etiquetasingular"": ""Unidad de medida"",""etiquetaplural"": ""Unidades de medida"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""c84f0381-d030-4223-a4e1-da78dda62ab4"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Medida (Base)"",""descripcion"": """",""keyword"": ""ReferenciaMedidaBase"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaMedidaBase As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaMedidaBase
          <DisplayName("Descontinuado")>
          Public Property Descontinuado As Boolean
          Public Shared ___Descontinuado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Descontinuado"",""etiqueta"": ""Descontinuado"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descontinuado"",""descripcion"": """",""keyword"": ""Descontinuado"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Descontinuado As DinaNETCore.APID.DinaupAPI_CampoC = ___Descontinuado
          <DisplayName("Alerta al Vender")>
          Public Property AlertaAlVender As String
          Public Shared ___AlertaAlVender As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AlertaAlVender"",""etiqueta"": ""Alerta al Vender"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Alerta al Vender"",""descripcion"": """",""keyword"": ""AlertaAlVender"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AlertaAlVender As DinaNETCore.APID.DinaupAPI_CampoC = ___AlertaAlVender
          <DisplayName("Fecha Alta del registro")>
          Public Property FechaAlta_UTC As Date?
          Public Shared ___FechaAlta_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaAlta_UTC"",""etiqueta"": ""Fecha Alta del registro"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Alta del registro"",""descripcion"": """",""keyword"": ""FechaAlta_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaAlta_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaAlta_UTC
          <DisplayName("Peso en unidad básica")>
          Public Property PesoEnUnidadBasica As Decimal
          Public Shared ___PesoEnUnidadBasica As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""PesoEnUnidadBasica"",""etiqueta"": ""Peso en unidad básica"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""11"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Peso en unidad básica"",""descripcion"": """",""keyword"": ""PesoEnUnidadBasica"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __PesoEnUnidadBasica As DinaNETCore.APID.DinaupAPI_CampoC = ___PesoEnUnidadBasica
          <DisplayName("Unidad medida peso")>
          Public Property ReferenciaUnidadMedidaPeso As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaUnidadMedidaPeso As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaUnidadMedidaPeso"",""etiqueta"": ""Unidad medida peso"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c84f0381-d030-4223-a4e1-da78dda62ab4"",""titulo"": ""Base - Unidades de medida"",""iconoid"": ""0323688b-82a5-4fb7-a9f5-ff1247a52998"",""etiquetasingular"": ""Unidad de medida"",""etiquetaplural"": ""Unidades de medida"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""c84f0381-d030-4223-a4e1-da78dda62ab4"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Unidad medida peso"",""descripcion"": """",""keyword"": ""ReferenciaUnidadMedidaPeso"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaUnidadMedidaPeso As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaUnidadMedidaPeso
          <Description("Se debe indicar el mismo texto en los productos que deban relacionarse y en el que quiera venderse en su lugar deberá marcarse para recomendar.")>
          <DisplayName("Equivalencia")>
          Public Property Equivalencia As String
          Public Shared ___Equivalencia As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Equivalencia"",""etiqueta"": ""Equivalencia"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Equivalencia"",""descripcion"": """",""keyword"": ""Equivalencia"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Equivalencia As DinaNETCore.APID.DinaupAPI_CampoC = ___Equivalencia
          <DisplayName("Argumentos de Sustitución de equivalencia para el Cliente")>
          Public Property ArgumentosDeSustitucionDeEquivalenciaParaElCliente As String
          Public Shared ___ArgumentosDeSustitucionDeEquivalenciaParaElCliente As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ArgumentosDeSustitucionDeEquivalenciaParaElCliente"",""etiqueta"": ""Argumentos de Sustitución de equivalencia para el Cliente"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Argumentos de Sustitución de equivalencia para el Cliente"",""descripcion"": """",""keyword"": ""ArgumentosDeSustitucionDeEquivalenciaParaElCliente"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ArgumentosDeSustitucionDeEquivalenciaParaElCliente As DinaNETCore.APID.DinaupAPI_CampoC = ___ArgumentosDeSustitucionDeEquivalenciaParaElCliente
          <DisplayName("Proveedor habitual")>
          Public Property ReferenciaProveedorHabitual As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaProveedorHabitual As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaProveedorHabitual"",""etiqueta"": ""Proveedor habitual"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Proveedor habitual"",""descripcion"": """",""keyword"": ""ReferenciaProveedorHabitual"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaProveedorHabitual As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaProveedorHabitual
          <DisplayName("Alerta al Comprar")>
          Public Property AlertaAlComprar As String
          Public Shared ___AlertaAlComprar As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AlertaAlComprar"",""etiqueta"": ""Alerta al Comprar"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Alerta al Comprar"",""descripcion"": """",""keyword"": ""AlertaAlComprar"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AlertaAlComprar As DinaNETCore.APID.DinaupAPI_CampoC = ___AlertaAlComprar
          <DisplayName("Descripción")>
          Public Property Descripcion As String
          Public Shared ___Descripcion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Descripcion"",""etiqueta"": ""Descripción"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 140,""decimales"": ""0"",""multilinea"": true,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descripción"",""descripcion"": """",""keyword"": ""Descripcion"",""formato"": 5,""rol"": 140,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Descripcion As DinaNETCore.APID.DinaupAPI_CampoC = ___Descripcion
          <Description("Unidad Medida")>
          <DisplayName("Medida (Accesible)")>
          Public Property ReferenciaMedidaAccesible As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaMedidaAccesible As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaMedidaAccesible"",""etiqueta"": ""Medida (Accesible)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c84f0381-d030-4223-a4e1-da78dda62ab4"",""titulo"": ""Base - Unidades de medida"",""iconoid"": ""0323688b-82a5-4fb7-a9f5-ff1247a52998"",""etiquetasingular"": ""Unidad de medida"",""etiquetaplural"": ""Unidades de medida"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""c84f0381-d030-4223-a4e1-da78dda62ab4"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Medida (Accesible)"",""descripcion"": """",""keyword"": ""ReferenciaMedidaAccesible"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaMedidaAccesible As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaMedidaAccesible
          <DisplayName("Nombre público")>
          Public Property NombrePublico As String
          Public Shared ___NombrePublico As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""NombrePublico"",""etiqueta"": ""Nombre público"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Nombre público"",""descripcion"": """",""keyword"": ""NombrePublico"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __NombrePublico As DinaNETCore.APID.DinaupAPI_CampoC = ___NombrePublico
          <DisplayName("Precio medio de Venta (Con impuestos)")>
          Public Property ImportePrecioMedioDeVentaConImpuestos As Decimal
          Public Shared ___ImportePrecioMedioDeVentaConImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImportePrecioMedioDeVentaConImpuestos"",""etiqueta"": ""Precio medio de Venta (Con impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""12"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Precio medio de Venta (Con impuestos)"",""descripcion"": """",""keyword"": ""ImportePrecioMedioDeVentaConImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImportePrecioMedioDeVentaConImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImportePrecioMedioDeVentaConImpuestos
          <DisplayName("Precio medio de Compra (Sin impuestos)")>
          Public Property ImportePrecioMedioDeCompraSinImpuestos As Decimal
          Public Shared ___ImportePrecioMedioDeCompraSinImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImportePrecioMedioDeCompraSinImpuestos"",""etiqueta"": ""Precio medio de Compra (Sin impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""12"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Precio medio de Compra (Sin impuestos)"",""descripcion"": """",""keyword"": ""ImportePrecioMedioDeCompraSinImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImportePrecioMedioDeCompraSinImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImportePrecioMedioDeCompraSinImpuestos
          <DisplayName("Precio medio de Venta (Sin impuestos)")>
          Public Property ImportePrecioMedioDeVentaSinImpuestos As Decimal
          Public Shared ___ImportePrecioMedioDeVentaSinImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImportePrecioMedioDeVentaSinImpuestos"",""etiqueta"": ""Precio medio de Venta (Sin impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""12"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Precio medio de Venta (Sin impuestos)"",""descripcion"": """",""keyword"": ""ImportePrecioMedioDeVentaSinImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImportePrecioMedioDeVentaSinImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImportePrecioMedioDeVentaSinImpuestos
          <DisplayName("Categoría de Compra por defecto")>
          Public Property ReferenciaCategoriaDeCompraPorDefecto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaCategoriaDeCompraPorDefecto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaCategoriaDeCompraPorDefecto"",""etiqueta"": ""Categoría de Compra por defecto"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""e42cfcc0-282e-4e01-8973-abe0cd6f5231"",""titulo"": ""Base - Categorías de Compra"",""iconoid"": ""bc114f16-6aa6-4f43-9ef7-f99f41567980"",""etiquetasingular"": ""Categoría de Compra"",""etiquetaplural"": ""Categorías de Compra"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""e42cfcc0-282e-4e01-8973-abe0cd6f5231"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Categoría de Compra por defecto"",""descripcion"": """",""keyword"": ""ReferenciaCategoriaDeCompraPorDefecto"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaCategoriaDeCompraPorDefecto As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaCategoriaDeCompraPorDefecto
          <DisplayName("Precio medio de Compra (Con impuestos)")>
          Public Property ImportePrecioMedioDeCompraConImpuestos As Decimal
          Public Shared ___ImportePrecioMedioDeCompraConImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImportePrecioMedioDeCompraConImpuestos"",""etiqueta"": ""Precio medio de Compra (Con impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""12"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Precio medio de Compra (Con impuestos)"",""descripcion"": """",""keyword"": ""ImportePrecioMedioDeCompraConImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImportePrecioMedioDeCompraConImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImportePrecioMedioDeCompraConImpuestos
          <DisplayName("Categoría de Venta por defecto")>
          Public Property ReferenciaCategoriaDeVentaPorDefecto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaCategoriaDeVentaPorDefecto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaCategoriaDeVentaPorDefecto"",""etiqueta"": ""Categoría de Venta por defecto"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""b1275848-3b6f-4b55-b6fa-9d77b9c0e6a5"",""titulo"": ""Base - Categorías de Ventas"",""iconoid"": ""41e2810f-985c-4e49-b283-9e43ff68cadb"",""etiquetasingular"": ""Categoría de Venta"",""etiquetaplural"": ""Categorías de Ventas"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""b1275848-3b6f-4b55-b6fa-9d77b9c0e6a5"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Categoría de Venta por defecto"",""descripcion"": """",""keyword"": ""ReferenciaCategoriaDeVentaPorDefecto"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaCategoriaDeVentaPorDefecto As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaCategoriaDeVentaPorDefecto
          <ReadOnlyAttribute(True)>
          <DisplayName("ID")>
          Public Property ID As Guid
          Public Shared ___ID As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": true,""eseliminado"": false,""keyword"": ""ID"",""etiqueta"": ""ID"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""0ceb234a-5a91-4f33-b70e-62e17f020a3c"",""titulo"": ""Productos Pack"",""iconoid"": ""3eace6d4-ac1e-4c9a-9587-3e40515d10ad"",""etiquetasingular"": ""Producto Pack"",""etiquetaplural"": ""Productos Pack"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""0ceb234a-5a91-4f33-b70e-62e17f020a3c"",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""ID"",""descripcion"": """",""keyword"": ""ID"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
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
          me.ProveedorHabitualTieneAccesoWeb = _Datos.Leer_Boolean("pr_146310d337x298wd")
          me.EsPack = _Datos.Leer_Boolean("pr_491fa38x1cbwc")
          me.HoraLocal = _Datos.Leer_Time_Nulable("pr_776ae56wd")
          me.ReferenciaDestinador = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_14631062fcx362wd"), _Datos.Leer_String("pr_14631062fcx362wd.nombre"))
          me.ReferenciaMarca = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_10040108751"), _Datos.Leer_String("pr_10040108751.nombre"))
          me.AutorDelAltaTieneAccesoWeb = _Datos.Leer_Boolean("pr_146314929fg3b1wd")
          me.ReferenciaAutorDelAlta = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_14631061f4j175wd"), _Datos.Leer_String("pr_14631061f4j175wd.nombre"))
          me.ReferenciaUnidadDeMedidaPesoBase = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_48e6710xbewc"), _Datos.Leer_String("pr_48e6710xbewc.nombre"))
          me.CodigoInterno = _Datos.Leer_String("pr_14087n")
          me.EvaluarStock = _Datos.Leer_Boolean("pr_14183n")
          me.ReferenciaCategoria = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_400401087449"), _Datos.Leer_String("pr_400401087449.nombre"))
          me.PesoPorUnd = _Datos.Leer_Decimal("pr_1031n")
          me.RecomendarEsteProductoAlCoincidirLaEquivalenciaConOtroSustitucion = _Datos.Leer_Boolean("pr_14")
          me.FormatoDePresentacion = _Datos.Leer_String("pr_611cf641")
          me.ReferenciaImagen = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_18"), _Datos.Leer_String("pr_18.nombre"))
          me.ReferenciaCodigoDeBarras = _Datos.Leer_String("pr_4")
          me.CantidadMedida = _Datos.Leer_Decimal("pr_1030n")
          me.CantidadMedidaBase = _Datos.Leer_Decimal("pr_1040n")
          me.ReferenciaMedidaBase = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_48e660ax2a7wc"), _Datos.Leer_String("pr_48e660ax2a7wc.nombre"))
          me.Descontinuado = _Datos.Leer_Boolean("pr_64f65875")
          me.AlertaAlVender = _Datos.Leer_String("pr_14262n")
          me.FechaAlta_UTC = _Datos.Leer_DateTime_Nulable("pr_14c9f3ec87g125wd")
          me.PesoEnUnidadBasica = _Datos.Leer_Decimal("pr_1039n")
          me.ReferenciaUnidadMedidaPeso = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_1032n"), _Datos.Leer_String("pr_1032n.nombre"))
          me.Equivalencia = _Datos.Leer_String("pr_6")
          me.ArgumentosDeSustitucionDeEquivalenciaParaElCliente = _Datos.Leer_String("pr_2226")
          me.ReferenciaProveedorHabitual = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_34"), _Datos.Leer_String("pr_34.nombre"))
          me.AlertaAlComprar = _Datos.Leer_String("pr_14266n")
          me.Descripcion = _Datos.Leer_String("pr_5")
          me.ReferenciaMedidaAccesible = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_1035n"), _Datos.Leer_String("pr_1035n.nombre"))
          me.NombrePublico = _Datos.Leer_String("pr_17dac2f6d6x35bwd")
          me.ImportePrecioMedioDeVentaConImpuestos = _Datos.Leer_Decimal("pr_20040195741005")
          me.ImportePrecioMedioDeCompraSinImpuestos = _Datos.Leer_Decimal("pr_60040195711002")
          me.ImportePrecioMedioDeVentaSinImpuestos = _Datos.Leer_Decimal("pr_60040195711001")
          me.ReferenciaCategoriaDeCompraPorDefecto = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_40040133302"), _Datos.Leer_String("pr_40040133302.nombre"))
          me.ImportePrecioMedioDeCompraConImpuestos = _Datos.Leer_Decimal("pr_20040195741004")
          me.ReferenciaCategoriaDeVentaPorDefecto = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_40040133303"), _Datos.Leer_String("pr_40040133303.nombre"))
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
         R.add("pr_146310d337x298wd", me.ProveedorHabitualTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_491fa38x1cbwc", me.EsPack.AdaptarMySQL_Boolean())
         R.add("pr_776ae56wd", me.HoraLocal.AdaptarMySQL_Time_Nulable())
         If Me.ReferenciaDestinador IsNot nothing then
           R.add("pr_14631062fcx362wd",me.ReferenciaDestinador.ID.STR())
         Else
           R.add("pr_14631062fcx362wd","")
         End if
         If Me.ReferenciaMarca IsNot nothing then
           R.add("pr_10040108751",me.ReferenciaMarca.ID.STR())
         Else
           R.add("pr_10040108751","")
         End if
         R.add("pr_146314929fg3b1wd", me.AutorDelAltaTieneAccesoWeb.AdaptarMySQL_Boolean())
         If Me.ReferenciaAutorDelAlta IsNot nothing then
           R.add("pr_14631061f4j175wd",me.ReferenciaAutorDelAlta.ID.STR())
         Else
           R.add("pr_14631061f4j175wd","")
         End if
         If Me.ReferenciaUnidadDeMedidaPesoBase IsNot nothing then
           R.add("pr_48e6710xbewc",me.ReferenciaUnidadDeMedidaPesoBase.ID.STR())
         Else
           R.add("pr_48e6710xbewc","")
         End if
         R.add("pr_14087n", me.CodigoInterno.AdaptarMySQL_String())
         R.add("pr_14183n", me.EvaluarStock.AdaptarMySQL_Boolean())
         If Me.ReferenciaCategoria IsNot nothing then
           R.add("pr_400401087449",me.ReferenciaCategoria.ID.STR())
         Else
           R.add("pr_400401087449","")
         End if
         R.add("pr_1031n", me.PesoPorUnd.AdaptarMySQL_Decimal())
         R.add("pr_14", me.RecomendarEsteProductoAlCoincidirLaEquivalenciaConOtroSustitucion.AdaptarMySQL_Boolean())
         R.add("pr_611cf641", me.FormatoDePresentacion.AdaptarMySQL_String())
         If Me.ReferenciaImagen IsNot nothing then
           R.add("pr_18",me.ReferenciaImagen.ID.STR())
         Else
           R.add("pr_18","")
         End if
         R.add("pr_4", me.ReferenciaCodigoDeBarras.AdaptarMySQL_String())
         R.add("pr_1030n", me.CantidadMedida.AdaptarMySQL_Decimal())
         R.add("pr_1040n", me.CantidadMedidaBase.AdaptarMySQL_Decimal())
         If Me.ReferenciaMedidaBase IsNot nothing then
           R.add("pr_48e660ax2a7wc",me.ReferenciaMedidaBase.ID.STR())
         Else
           R.add("pr_48e660ax2a7wc","")
         End if
         R.add("pr_64f65875", me.Descontinuado.AdaptarMySQL_Boolean())
         R.add("pr_14262n", me.AlertaAlVender.AdaptarMySQL_String())
         R.add("pr_14c9f3ec87g125wd", me.FechaAlta_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_1039n", me.PesoEnUnidadBasica.AdaptarMySQL_Decimal())
         If Me.ReferenciaUnidadMedidaPeso IsNot nothing then
           R.add("pr_1032n",me.ReferenciaUnidadMedidaPeso.ID.STR())
         Else
           R.add("pr_1032n","")
         End if
         R.add("pr_6", me.Equivalencia.AdaptarMySQL_String())
         R.add("pr_2226", me.ArgumentosDeSustitucionDeEquivalenciaParaElCliente.AdaptarMySQL_String())
         If Me.ReferenciaProveedorHabitual IsNot nothing then
           R.add("pr_34",me.ReferenciaProveedorHabitual.ID.STR())
         Else
           R.add("pr_34","")
         End if
         R.add("pr_14266n", me.AlertaAlComprar.AdaptarMySQL_String())
         R.add("pr_5", me.Descripcion.AdaptarMySQL_String())
         If Me.ReferenciaMedidaAccesible IsNot nothing then
           R.add("pr_1035n",me.ReferenciaMedidaAccesible.ID.STR())
         Else
           R.add("pr_1035n","")
         End if
         R.add("pr_17dac2f6d6x35bwd", me.NombrePublico.AdaptarMySQL_String())
         R.add("pr_20040195741005", me.ImportePrecioMedioDeVentaConImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_60040195711002", me.ImportePrecioMedioDeCompraSinImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_60040195711001", me.ImportePrecioMedioDeVentaSinImpuestos.AdaptarMySQL_Decimal())
         If Me.ReferenciaCategoriaDeCompraPorDefecto IsNot nothing then
           R.add("pr_40040133302",me.ReferenciaCategoriaDeCompraPorDefecto.ID.STR())
         Else
           R.add("pr_40040133302","")
         End if
         R.add("pr_20040195741004", me.ImportePrecioMedioDeCompraConImpuestos.AdaptarMySQL_Decimal())
         If Me.ReferenciaCategoriaDeVentaPorDefecto IsNot nothing then
           R.add("pr_40040133303",me.ReferenciaCategoriaDeVentaPorDefecto.ID.STR())
         Else
           R.add("pr_40040133303","")
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
      Public Class ProductosPack_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
          Public property ProveedorHabitualTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_146310d337x298wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_146310d337x298wd", value)
            End Set
          End Property
        Public ReadOnly property EsPack As Boolean
            get
                return me.GetValue_Boolean("pr_491fa38x1cbwc")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As DateTime
            get
                return me.GetValue_DateTime("pr_776ae56wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_14631062fcx362wd")
            End Get   
        End Property
          Public property ReferenciaMarca As Guid
            get
                return me.GetValue_Guid("pr_10040108751")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_10040108751", value)
            End Set
          End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_146314929fg3b1wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_146314929fg3b1wd", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_14631061f4j175wd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_14631061f4j175wd", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaUnidadDeMedidaPesoBase As Guid
            get
                return me.GetValue_Guid("pr_48e6710xbewc")
            End Get   
        End Property
          Public property CodigoInterno As String
            get
                return me.GetValue_String("pr_14087n")
            End Get
            Set(value As String)
                me.SetValue_String("pr_14087n", value)
            End Set
          End Property
          Public property EvaluarStock As Boolean
            get
                return me.GetValue_Boolean("pr_14183n")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_14183n", value)
            End Set
          End Property
          Public property ReferenciaCategoria As Guid
            get
                return me.GetValue_Guid("pr_400401087449")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_400401087449", value)
            End Set
          End Property
          Public property PesoPorUnd As Decimal
            get
                return me.GetValue_Decimal("pr_1031n")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_1031n", value)
            End Set
          End Property
          Public property RecomendarEsteProductoAlCoincidirLaEquivalenciaConOtroSustitucion As Boolean
            get
                return me.GetValue_Boolean("pr_14")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_14", value)
            End Set
          End Property
          Public property FormatoDePresentacion As String
            get
                return me.GetValue_String("pr_611cf641")
            End Get
            Set(value As String)
                me.SetValue_String("pr_611cf641", value)
            End Set
          End Property
          Public property ReferenciaImagen As Guid
            get
                return me.GetValue_Guid("pr_18")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_18", value)
            End Set
          End Property
          Public property ReferenciaCodigoDeBarras As String
            get
                return me.GetValue_String("pr_4")
            End Get
            Set(value As String)
                me.SetValue_String("pr_4", value)
            End Set
          End Property
        Public ReadOnly property CantidadMedida As Decimal
            get
                return me.GetValue_Decimal("pr_1030n")
            End Get   
        End Property
        Public ReadOnly property CantidadMedidaBase As Decimal
            get
                return me.GetValue_Decimal("pr_1040n")
            End Get   
        End Property
        Public ReadOnly property ReferenciaMedidaBase As Guid
            get
                return me.GetValue_Guid("pr_48e660ax2a7wc")
            End Get   
        End Property
          Public property Descontinuado As Boolean
            get
                return me.GetValue_Boolean("pr_64f65875")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_64f65875", value)
            End Set
          End Property
          Public property AlertaAlVender As String
            get
                return me.GetValue_String("pr_14262n")
            End Get
            Set(value As String)
                me.SetValue_String("pr_14262n", value)
            End Set
          End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_14c9f3ec87g125wd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_14c9f3ec87g125wd", value)
            End Set
          End Property
        Public ReadOnly property PesoEnUnidadBasica As Decimal
            get
                return me.GetValue_Decimal("pr_1039n")
            End Get   
        End Property
          Public property ReferenciaUnidadMedidaPeso As Guid
            get
                return me.GetValue_Guid("pr_1032n")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_1032n", value)
            End Set
          End Property
          Public property Equivalencia As String
            get
                return me.GetValue_String("pr_6")
            End Get
            Set(value As String)
                me.SetValue_String("pr_6", value)
            End Set
          End Property
          Public property ArgumentosDeSustitucionDeEquivalenciaParaElCliente As String
            get
                return me.GetValue_String("pr_2226")
            End Get
            Set(value As String)
                me.SetValue_String("pr_2226", value)
            End Set
          End Property
          Public property ReferenciaProveedorHabitual As Guid
            get
                return me.GetValue_Guid("pr_34")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_34", value)
            End Set
          End Property
          Public property AlertaAlComprar As String
            get
                return me.GetValue_String("pr_14266n")
            End Get
            Set(value As String)
                me.SetValue_String("pr_14266n", value)
            End Set
          End Property
          Public property Descripcion As String
            get
                return me.GetValue_String("pr_5")
            End Get
            Set(value As String)
                me.SetValue_String("pr_5", value)
            End Set
          End Property
          Public property ReferenciaMedidaAccesible As Guid
            get
                return me.GetValue_Guid("pr_1035n")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_1035n", value)
            End Set
          End Property
          Public property NombrePublico As String
            get
                return me.GetValue_String("pr_17dac2f6d6x35bwd")
            End Get
            Set(value As String)
                me.SetValue_String("pr_17dac2f6d6x35bwd", value)
            End Set
          End Property
          Public property ImportePrecioMedioDeVentaConImpuestos As Decimal
            get
                return me.GetValue_Decimal("pr_20040195741005")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_20040195741005", value)
            End Set
          End Property
          Public property ImportePrecioMedioDeCompraSinImpuestos As Decimal
            get
                return me.GetValue_Decimal("pr_60040195711002")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_60040195711002", value)
            End Set
          End Property
          Public property ImportePrecioMedioDeVentaSinImpuestos As Decimal
            get
                return me.GetValue_Decimal("pr_60040195711001")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_60040195711001", value)
            End Set
          End Property
          Public property ReferenciaCategoriaDeCompraPorDefecto As Guid
            get
                return me.GetValue_Guid("pr_40040133302")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_40040133302", value)
            End Set
          End Property
          Public property ImportePrecioMedioDeCompraConImpuestos As Decimal
            get
                return me.GetValue_Decimal("pr_20040195741004")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_20040195741004", value)
            End Set
          End Property
          Public property ReferenciaCategoriaDeVentaPorDefecto As Guid
            get
                return me.GetValue_Guid("pr_40040133303")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_40040133303", value)
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
