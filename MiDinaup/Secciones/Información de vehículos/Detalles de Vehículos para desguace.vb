   Imports System.ComponentModel
   Imports DinaNETCore
   Imports DinaNETCore.APID
Partial Public Class SeccionesD
  Public Class DetallesDeVehiculosParaDesguaceD
      Public Shared _SeccionID As String = "2a361175-27c8-43be-943b-f9c7f171a18d"
      Public Shared _SeccionIDGUID As New Guid("2a361175-27c8-43be-943b-f9c7f171a18d")
      Public Shared Async Function ConsultarDatos_Async(Parametros As SeccionConsultaParametrosC) As Task(Of List(Of DetallesDeVehiculosParaDesguaceC )) 
          Dim R As New List(Of DetallesDeVehiculosParaDesguaceC )  
          Dim d = Await Parametros.DinaupSesion.ConexionServidor.Funcion_Datos_Recibir_Async(DetallesDeVehiculosParaDesguaceES._SeccionID, False, Parametros) 
          If d.Datos.TieneDatos Then 
              For Each Actual In d.Datos 
                  Dim Valores_Listador = Actual.Value.Item1
                  Dim Obj_Listador As New DetallesDeVehiculosParaDesguaceC 
                  Obj_Listador.CargarDatos(Valores_Listador) 
                  Obj_Listador.CargaInterna(Actual.Value)
                  R.Add(Obj_Listador) 
              Next 
          End If 
          Return R 
      End Function 
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As DetallesDeVehiculosParaDesguaceC, Optional CampoWhere$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Return Await DatosGuardar_Async(DinaupSesion, New List(Of DetallesDeVehiculosParaDesguaceC)({DAtos}), CampoWhere )
      End Function
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As List(Of DetallesDeVehiculosParaDesguaceC), Optional CampoWhere$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Dim Importar As New List(Of DinaupAPI_ImportacionProcesableC)
          For Each Actual In DAtos 
              Dim RegistroActual = New DinaupAPI_ImportacionProcesableC() 
               RegistroActual.dinaup_listador_datos = Actual.ToDic 
               Importar.Add(RegistroActual)  
          Next 
          Return Await DinaupSesion.ConexionServidor.Funcion_Importar_Ejecutar_Async(DinaupSesion, DetallesDeVehiculosParaDesguaceES._SeccionID, Importar, CampoWhere, "") 
      End Function
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As DetallesDeVehiculosParaDesguace_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, DetallesDeVehiculosParaDesguaceES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New DetallesDeVehiculosParaDesguace_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As DetallesDeVehiculosParaDesguace_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, DetallesDeVehiculosParaDesguaceES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New DetallesDeVehiculosParaDesguace_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class DetallesDeVehiculosParaDesguaceES
          Public shared _SeccionID as Guid = New Guid("2a361175-27c8-43be-943b-f9c7f171a18d")
          Public shared _Tabla$ = "tpr_10010421306"
      Public Shared Puertas$ = "pr_40040473185"
      Public Shared ReferenciaCombustibles$ = "pr_500404731825"
      Public Shared Cambio$ = "pr_500404731826"
      Public Shared IDExterna$ = "pr_60040475822"
      Public Shared FechaModificacionExterna_UTC$ = "pr_60040475823"
      Public Shared PotenciaKW$ = "pr_30040477532"
      Public Shared PotenciaCV$ = "pr_30040477531"
      Public Shared Potencia$ = "pr_20040477533"
      Public Shared ReferenciaDestinador$ = "pr_100104213063"
      Public Shared ExportarEnModulos$ = "pr_100104213061"
      Public Shared ReferenciaAutorDelAlta$ = "pr_100104213058"
      Public Shared FechaAlta_UTC$ = "pr_100104213062"
      Public Shared HoraLocal$ = "pr_100104213060"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_100104213074"
      Public Shared ReferenciaMarca$ = "pr_60010421322"
      Public Shared ReferenciaModelo$ = "pr_60010421321"
      Public Shared ReferenciaFoto$ = "pr_50010421328"
      Public Shared AñoInicio$ = "pr_10010421331"
      Public Shared AñoFin$ = "pr_10010421491"
      Public Shared Version$ = "pr_10010421492"
      Public Shared ReferenciaProducto$ = "pr_50010421581"
      Public Shared ReferenciaImpuesto$ = "pr_40010421711"
      Public Shared ImportePrecioDeReferenciaDeVentaConImpuestos$ = "pr_30010421717"
      Public Shared ImporteCosteMaxSinImpuestos$ = "pr_50010421711"
      Public Shared ImportePVPMinSinImpuestos$ = "pr_50010421713"
      Public Shared ImportePVPMinConImpuestos$ = "pr_50010421714"
      Public Shared ImporteCosteMaxConImpuestos$ = "pr_50010421712"
      Public Shared InformacionTecnica$ = "pr_20010421724"
      Public Shared ImportePrecioDeReferenciaDeVentaSinImpuestos$ = "pr_30010421716"
      Public Shared ImporteCosteReferenciaConImpuestos$ = "pr_10010421722"
      Public Shared ImporteCosteReferenciaSinImpuestos$ = "pr_10010421721"
      Public Shared ReferenciaTipo$ = "pr_50010421802"
      Public Shared ReferenciaCategoriaDeCompra$ = "pr_60040441203"
      Public Shared ReferenciaCategoriaDeVenta$ = "pr_60040441204"
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
      Public Class DetallesDeVehiculosParaDesguaceC
      Inherits Base_DatoC
          <DisplayName("Puertas")>
          Public Property Puertas As Integer
          Public Shared ___Puertas As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Puertas"",""etiqueta"": ""Puertas"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Puertas"",""descripcion"": """",""keyword"": ""Puertas"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Puertas As DinaNETCore.APID.DinaupAPI_CampoC = ___Puertas
          <DisplayName("Combustibles")>
          Public Property ReferenciaCombustibles As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaCombustibles As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaCombustibles"",""etiqueta"": ""Combustibles"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""309ce40c-0bb2-4afb-bcc9-9947178f9e01"",""titulo"": ""Base - Combustibles"",""iconoid"": ""1cd976ab-3d85-4c44-ba7d-dfc2d6920edb"",""etiquetasingular"": ""Combustible"",""etiquetaplural"": ""Combustibles"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""309ce40c-0bb2-4afb-bcc9-9947178f9e01"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Combustibles"",""descripcion"": """",""keyword"": ""ReferenciaCombustibles"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaCombustibles As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaCombustibles
          <DisplayName("Cambio")>
          Public Property Cambio As String
          Public Shared ___Cambio As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Cambio"",""etiqueta"": ""Cambio"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cambio"",""descripcion"": """",""keyword"": ""Cambio"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Cambio As DinaNETCore.APID.DinaupAPI_CampoC = ___Cambio
          <DisplayName("ID Externa")>
          Public Property IDExterna As String
          Public Shared ___IDExterna As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""IDExterna"",""etiqueta"": ""ID Externa"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""ID Externa"",""descripcion"": """",""keyword"": ""IDExterna"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __IDExterna As DinaNETCore.APID.DinaupAPI_CampoC = ___IDExterna
          <DisplayName("Fecha modificación (Externa)")>
          Public Property FechaModificacionExterna_UTC As Date?
          Public Shared ___FechaModificacionExterna_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaModificacionExterna_UTC"",""etiqueta"": ""Fecha modificación (Externa)"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha modificación (Externa)"",""descripcion"": """",""keyword"": ""FechaModificacionExterna_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaModificacionExterna_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaModificacionExterna_UTC
          <DisplayName("Potencia KW")>
          Public Property PotenciaKW As Decimal
          Public Shared ___PotenciaKW As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""PotenciaKW"",""etiqueta"": ""Potencia KW"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Potencia KW"",""descripcion"": """",""keyword"": ""PotenciaKW"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __PotenciaKW As DinaNETCore.APID.DinaupAPI_CampoC = ___PotenciaKW
          <DisplayName("Potencia CV")>
          Public Property PotenciaCV As Decimal
          Public Shared ___PotenciaCV As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""PotenciaCV"",""etiqueta"": ""Potencia CV"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Potencia CV"",""descripcion"": """",""keyword"": ""PotenciaCV"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __PotenciaCV As DinaNETCore.APID.DinaupAPI_CampoC = ___PotenciaCV
          <DisplayName("Potencia")>
          Public Property Potencia As String
          Public Shared ___Potencia As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Potencia"",""etiqueta"": ""Potencia"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Potencia"",""descripcion"": """",""keyword"": ""Potencia"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Potencia As DinaNETCore.APID.DinaupAPI_CampoC = ___Potencia
          <DisplayName("Destinador")>
          Public Property ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaDestinador As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaDestinador"",""etiqueta"": ""Destinador"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""relacionesindirectas"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Destinador"",""descripcion"": """",""keyword"": ""ReferenciaDestinador"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaDestinador
          <DisplayName("Autor del alta")>
          Public Property ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaAutorDelAlta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaAutorDelAlta"",""etiqueta"": ""Autor del alta"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta"",""descripcion"": """",""keyword"": ""ReferenciaAutorDelAlta"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaAutorDelAlta
          <DisplayName("Fecha Alta del registro")>
          Public Property FechaAlta_UTC As Date?
          Public Shared ___FechaAlta_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaAlta_UTC"",""etiqueta"": ""Fecha Alta del registro"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Alta del registro"",""descripcion"": """",""keyword"": ""FechaAlta_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaAlta_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaAlta_UTC
          <DisplayName("Hora local")>
          Public Property HoraLocal As DateTime?
          Public Shared ___HoraLocal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""HoraLocal"",""etiqueta"": ""Hora local"",""oculta"": false,""formato"": 8,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Hora local"",""descripcion"": """",""keyword"": ""HoraLocal"",""formato"": 8,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __HoraLocal As DinaNETCore.APID.DinaupAPI_CampoC = ___HoraLocal
          <DisplayName("Autor del alta Tiene Acceso web")>
          Public Property AutorDelAltaTieneAccesoWeb As Boolean
          Public Shared ___AutorDelAltaTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AutorDelAltaTieneAccesoWeb"",""etiqueta"": ""Autor del alta Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta Tiene Acceso web"",""descripcion"": """",""keyword"": ""AutorDelAltaTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AutorDelAltaTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___AutorDelAltaTieneAccesoWeb
          <DisplayName("Marca")>
          Public Property ReferenciaMarca As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaMarca As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaMarca"",""etiqueta"": ""Marca"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""fa425ef0-9001-4a0b-8795-93e4dba8719f"",""titulo"": ""Base - Marcas comerciales"",""iconoid"": ""46bff251-7bbe-4c8d-adb2-7605e6393ab2"",""etiquetasingular"": ""Marca comercial"",""etiquetaplural"": ""Marcas comerciales"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""fa425ef0-9001-4a0b-8795-93e4dba8719f"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Marca"",""descripcion"": """",""keyword"": ""ReferenciaMarca"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaMarca As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaMarca
          <DisplayName("Modelo")>
          Public Property ReferenciaModelo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaModelo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaModelo"",""etiqueta"": ""Modelo"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""327b63e9-1c53-4562-88d7-687499b785b9"",""titulo"": ""Base - Modelos de vehículos"",""iconoid"": ""0d7ac9ca-39ec-4ae9-a8ea-ea7d3d45405e"",""etiquetasingular"": ""Modelo de vehículo"",""etiquetaplural"": ""Modelos de vehículos"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""327b63e9-1c53-4562-88d7-687499b785b9"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Modelo"",""descripcion"": """",""keyword"": ""ReferenciaModelo"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaModelo As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaModelo
          <DisplayName("Foto")>
          Public Property ReferenciaFoto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaFoto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaFoto"",""etiqueta"": ""Foto"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""imagenes"",""rol"": 17,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Foto"",""descripcion"": """",""keyword"": ""ReferenciaFoto"",""formato"": 9,""rol"": 17,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaFoto As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaFoto
          <DisplayName("Año Inicio")>
          Public Property AñoInicio As Integer
          Public Shared ___AñoInicio As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AñoInicio"",""etiqueta"": ""Año Inicio"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 25,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Año Inicio"",""descripcion"": """",""keyword"": ""AñoInicio"",""formato"": 2,""rol"": 25,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AñoInicio As DinaNETCore.APID.DinaupAPI_CampoC = ___AñoInicio
          <DisplayName("Año Fin")>
          Public Property AñoFin As Integer
          Public Shared ___AñoFin As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AñoFin"",""etiqueta"": ""Año Fin"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 25,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Año Fin"",""descripcion"": """",""keyword"": ""AñoFin"",""formato"": 2,""rol"": 25,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AñoFin As DinaNETCore.APID.DinaupAPI_CampoC = ___AñoFin
          <DisplayName("Versión")>
          Public Property Version As String
          Public Shared ___Version As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Version"",""etiqueta"": ""Versión"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Versión"",""descripcion"": """",""keyword"": ""Version"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Version As DinaNETCore.APID.DinaupAPI_CampoC = ___Version
          <DisplayName("Producto")>
          Public Property ReferenciaProducto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaProducto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaProducto"",""etiqueta"": ""Producto"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""e28959bb-b7f1-4558-9e8a-4048e6c5f51a"",""titulo"": ""Base - Productos"",""iconoid"": ""21a04b44-ad38-44e0-a63a-98951da57cfa"",""etiquetasingular"": ""Producto"",""etiquetaplural"": ""Productos"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""e28959bb-b7f1-4558-9e8a-4048e6c5f51a"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Producto"",""descripcion"": """",""keyword"": ""ReferenciaProducto"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaProducto As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaProducto
          <DisplayName("Impuesto")>
          Public Property ReferenciaImpuesto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaImpuesto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaImpuesto"",""etiqueta"": ""Impuesto"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""f3199ee0-dc83-4667-a9c1-f3b04e97a8a4"",""titulo"": ""Base - Impuestos"",""iconoid"": ""ff4a7189-6426-43b9-bdc4-070314999e81"",""etiquetasingular"": ""Impuesto"",""etiquetaplural"": ""Impuestos"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""f3199ee0-dc83-4667-a9c1-f3b04e97a8a4"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Impuesto"",""descripcion"": """",""keyword"": ""ReferenciaImpuesto"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaImpuesto As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaImpuesto
          <DisplayName("Precio de referencia de Venta (Con Impuestos)")>
          Public Property ImportePrecioDeReferenciaDeVentaConImpuestos As Decimal
          Public Shared ___ImportePrecioDeReferenciaDeVentaConImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImportePrecioDeReferenciaDeVentaConImpuestos"",""etiqueta"": ""Precio de referencia de Venta (Con Impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Precio de referencia de Venta (Con Impuestos)"",""descripcion"": """",""keyword"": ""ImportePrecioDeReferenciaDeVentaConImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImportePrecioDeReferenciaDeVentaConImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImportePrecioDeReferenciaDeVentaConImpuestos
          <DisplayName("Coste Max (Sin Impuestos)")>
          Public Property ImporteCosteMaxSinImpuestos As Decimal
          Public Shared ___ImporteCosteMaxSinImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteCosteMaxSinImpuestos"",""etiqueta"": ""Coste Max (Sin Impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Coste Max (Sin Impuestos)"",""descripcion"": """",""keyword"": ""ImporteCosteMaxSinImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteCosteMaxSinImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteCosteMaxSinImpuestos
          <DisplayName("PVP Min (Sin Impuestos)")>
          Public Property ImportePVPMinSinImpuestos As Decimal
          Public Shared ___ImportePVPMinSinImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImportePVPMinSinImpuestos"",""etiqueta"": ""PVP Min (Sin Impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""PVP Min (Sin Impuestos)"",""descripcion"": """",""keyword"": ""ImportePVPMinSinImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImportePVPMinSinImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImportePVPMinSinImpuestos
          <DisplayName("PVP Min (Con Impuestos)")>
          Public Property ImportePVPMinConImpuestos As Decimal
          Public Shared ___ImportePVPMinConImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImportePVPMinConImpuestos"",""etiqueta"": ""PVP Min (Con Impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""PVP Min (Con Impuestos)"",""descripcion"": """",""keyword"": ""ImportePVPMinConImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImportePVPMinConImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImportePVPMinConImpuestos
          <DisplayName("Coste Max (Con Impuestos)")>
          Public Property ImporteCosteMaxConImpuestos As Decimal
          Public Shared ___ImporteCosteMaxConImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteCosteMaxConImpuestos"",""etiqueta"": ""Coste Max (Con Impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Coste Max (Con Impuestos)"",""descripcion"": """",""keyword"": ""ImporteCosteMaxConImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteCosteMaxConImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteCosteMaxConImpuestos
          <DisplayName("Información Técnica")>
          Public Property InformacionTecnica As String
          Public Shared ___InformacionTecnica As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""InformacionTecnica"",""etiqueta"": ""Información Técnica"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 140,""decimales"": ""0"",""multilinea"": true,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Información Técnica"",""descripcion"": """",""keyword"": ""InformacionTecnica"",""formato"": 5,""rol"": 140,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __InformacionTecnica As DinaNETCore.APID.DinaupAPI_CampoC = ___InformacionTecnica
          <DisplayName("Precio de referencia de Venta (Sin Impuestos)")>
          Public Property ImportePrecioDeReferenciaDeVentaSinImpuestos As Decimal
          Public Shared ___ImportePrecioDeReferenciaDeVentaSinImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImportePrecioDeReferenciaDeVentaSinImpuestos"",""etiqueta"": ""Precio de referencia de Venta (Sin Impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Precio de referencia de Venta (Sin Impuestos)"",""descripcion"": """",""keyword"": ""ImportePrecioDeReferenciaDeVentaSinImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImportePrecioDeReferenciaDeVentaSinImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImportePrecioDeReferenciaDeVentaSinImpuestos
          <DisplayName("Coste Referencia (Con Impuestos)")>
          Public Property ImporteCosteReferenciaConImpuestos As Decimal
          Public Shared ___ImporteCosteReferenciaConImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteCosteReferenciaConImpuestos"",""etiqueta"": ""Coste Referencia (Con Impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Coste Referencia (Con Impuestos)"",""descripcion"": """",""keyword"": ""ImporteCosteReferenciaConImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteCosteReferenciaConImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteCosteReferenciaConImpuestos
          <DisplayName("Coste Referencia (Sin Impuestos)")>
          Public Property ImporteCosteReferenciaSinImpuestos As Decimal
          Public Shared ___ImporteCosteReferenciaSinImpuestos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteCosteReferenciaSinImpuestos"",""etiqueta"": ""Coste Referencia (Sin Impuestos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Coste Referencia (Sin Impuestos)"",""descripcion"": """",""keyword"": ""ImporteCosteReferenciaSinImpuestos"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteCosteReferenciaSinImpuestos As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteCosteReferenciaSinImpuestos
          <DisplayName("Tipo")>
          Public Property ReferenciaTipo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaTipo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaTipo"",""etiqueta"": ""Tipo"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""9d9a96fc-3cbd-4afa-997a-b215d0c8066e"",""titulo"": ""Tipos de Vehículos para Desguace"",""iconoid"": ""36063abf-3174-41d8-bf5d-ee31a6a1b705"",""etiquetasingular"": ""Tipo de Vehículo para Desguace"",""etiquetaplural"": ""Tipos de Vehículos para Desguace"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""9d9a96fc-3cbd-4afa-997a-b215d0c8066e"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Tipo"",""descripcion"": """",""keyword"": ""ReferenciaTipo"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaTipo As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaTipo
          <DisplayName("Categoría de compra")>
          Public Property ReferenciaCategoriaDeCompra As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaCategoriaDeCompra As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaCategoriaDeCompra"",""etiqueta"": ""Categoría de compra"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""e42cfcc0-282e-4e01-8973-abe0cd6f5231"",""titulo"": ""Base - Categorías de Compra"",""iconoid"": ""bc114f16-6aa6-4f43-9ef7-f99f41567980"",""etiquetasingular"": ""Categoría de Compra"",""etiquetaplural"": ""Categorías de Compra"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""e42cfcc0-282e-4e01-8973-abe0cd6f5231"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Categoría de compra"",""descripcion"": """",""keyword"": ""ReferenciaCategoriaDeCompra"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaCategoriaDeCompra As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaCategoriaDeCompra
          <DisplayName("Categoría de venta")>
          Public Property ReferenciaCategoriaDeVenta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaCategoriaDeVenta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaCategoriaDeVenta"",""etiqueta"": ""Categoría de venta"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""b1275848-3b6f-4b55-b6fa-9d77b9c0e6a5"",""titulo"": ""Base - Categorías de Ventas"",""iconoid"": ""41e2810f-985c-4e49-b283-9e43ff68cadb"",""etiquetasingular"": ""Categoría de Venta"",""etiquetaplural"": ""Categorías de Ventas"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""b1275848-3b6f-4b55-b6fa-9d77b9c0e6a5"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Categoría de venta"",""descripcion"": """",""keyword"": ""ReferenciaCategoriaDeVenta"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaCategoriaDeVenta As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaCategoriaDeVenta
          <ReadOnlyAttribute(True)>
          <DisplayName("ID")>
          Public Property ID As Guid
          Public Shared ___ID As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": true,""eseliminado"": false,""keyword"": ""ID"",""etiqueta"": ""ID"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""2a361175-27c8-43be-943b-f9c7f171a18d"",""titulo"": ""Detalles de Vehículos para desguace"",""iconoid"": ""a41af84a-0444-40ae-997f-707d779dabd9"",""etiquetasingular"": ""Detalles de Vehículo para desguace"",""etiquetaplural"": ""Detalles de Vehículos para desguace"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""2a361175-27c8-43be-943b-f9c7f171a18d"",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""ID"",""descripcion"": """",""keyword"": ""ID"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
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
          me.Puertas = _Datos.Leer_Integer("pr_40040473185")
          me.ReferenciaCombustibles = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_500404731825"), _Datos.Leer_String("pr_500404731825.nombre"))
          me.Cambio = _Datos.Leer_String("pr_500404731826")
          me.IDExterna = _Datos.Leer_String("pr_60040475822")
          me.FechaModificacionExterna_UTC = _Datos.Leer_DateTime_Nulable("pr_60040475823")
          me.PotenciaKW = _Datos.Leer_Decimal("pr_30040477532")
          me.PotenciaCV = _Datos.Leer_Decimal("pr_30040477531")
          me.Potencia = _Datos.Leer_String("pr_20040477533")
          me.ReferenciaDestinador = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_100104213063"), _Datos.Leer_String("pr_100104213063.nombre"))
          me.ReferenciaAutorDelAlta = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_100104213058"), _Datos.Leer_String("pr_100104213058.nombre"))
          me.FechaAlta_UTC = _Datos.Leer_DateTime_Nulable("pr_100104213062")
          me.HoraLocal = _Datos.Leer_Time_Nulable("pr_100104213060")
          me.AutorDelAltaTieneAccesoWeb = _Datos.Leer_Boolean("pr_100104213074")
          me.ReferenciaMarca = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_60010421322"), _Datos.Leer_String("pr_60010421322.nombre"))
          me.ReferenciaModelo = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_60010421321"), _Datos.Leer_String("pr_60010421321.nombre"))
          me.ReferenciaFoto = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_50010421328"), _Datos.Leer_String("pr_50010421328.nombre"))
          me.AñoInicio = _Datos.Leer_Integer("pr_10010421331")
          me.AñoFin = _Datos.Leer_Integer("pr_10010421491")
          me.Version = _Datos.Leer_String("pr_10010421492")
          me.ReferenciaProducto = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_50010421581"), _Datos.Leer_String("pr_50010421581.nombre"))
          me.ReferenciaImpuesto = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_40010421711"), _Datos.Leer_String("pr_40010421711.nombre"))
          me.ImportePrecioDeReferenciaDeVentaConImpuestos = _Datos.Leer_Decimal("pr_30010421717")
          me.ImporteCosteMaxSinImpuestos = _Datos.Leer_Decimal("pr_50010421711")
          me.ImportePVPMinSinImpuestos = _Datos.Leer_Decimal("pr_50010421713")
          me.ImportePVPMinConImpuestos = _Datos.Leer_Decimal("pr_50010421714")
          me.ImporteCosteMaxConImpuestos = _Datos.Leer_Decimal("pr_50010421712")
          me.InformacionTecnica = _Datos.Leer_String("pr_20010421724")
          me.ImportePrecioDeReferenciaDeVentaSinImpuestos = _Datos.Leer_Decimal("pr_30010421716")
          me.ImporteCosteReferenciaConImpuestos = _Datos.Leer_Decimal("pr_10010421722")
          me.ImporteCosteReferenciaSinImpuestos = _Datos.Leer_Decimal("pr_10010421721")
          me.ReferenciaTipo = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_50010421802"), _Datos.Leer_String("pr_50010421802.nombre"))
          me.ReferenciaCategoriaDeCompra = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_60040441203"), _Datos.Leer_String("pr_60040441203.nombre"))
          me.ReferenciaCategoriaDeVenta = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_60040441204"), _Datos.Leer_String("pr_60040441204.nombre"))
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
         R.add("pr_40040473185", me.Puertas.AdaptarMySQL_Integer())
         If Me.ReferenciaCombustibles IsNot nothing then
           R.add("pr_500404731825",me.ReferenciaCombustibles.ID.STR())
         Else
           R.add("pr_500404731825","")
         End if
         R.add("pr_500404731826", me.Cambio.AdaptarMySQL_String())
         R.add("pr_60040475822", me.IDExterna.AdaptarMySQL_String())
         R.add("pr_60040475823", me.FechaModificacionExterna_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_30040477532", me.PotenciaKW.AdaptarMySQL_Decimal())
         R.add("pr_30040477531", me.PotenciaCV.AdaptarMySQL_Decimal())
         R.add("pr_20040477533", me.Potencia.AdaptarMySQL_String())
         If Me.ReferenciaDestinador IsNot nothing then
           R.add("pr_100104213063",me.ReferenciaDestinador.ID.STR())
         Else
           R.add("pr_100104213063","")
         End if
         If Me.ReferenciaAutorDelAlta IsNot nothing then
           R.add("pr_100104213058",me.ReferenciaAutorDelAlta.ID.STR())
         Else
           R.add("pr_100104213058","")
         End if
         R.add("pr_100104213062", me.FechaAlta_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_100104213060", me.HoraLocal.AdaptarMySQL_Time_Nulable())
         R.add("pr_100104213074", me.AutorDelAltaTieneAccesoWeb.AdaptarMySQL_Boolean())
         If Me.ReferenciaMarca IsNot nothing then
           R.add("pr_60010421322",me.ReferenciaMarca.ID.STR())
         Else
           R.add("pr_60010421322","")
         End if
         If Me.ReferenciaModelo IsNot nothing then
           R.add("pr_60010421321",me.ReferenciaModelo.ID.STR())
         Else
           R.add("pr_60010421321","")
         End if
         If Me.ReferenciaFoto IsNot nothing then
           R.add("pr_50010421328",me.ReferenciaFoto.ID.STR())
         Else
           R.add("pr_50010421328","")
         End if
         R.add("pr_10010421331", me.AñoInicio.AdaptarMySQL_Integer())
         R.add("pr_10010421491", me.AñoFin.AdaptarMySQL_Integer())
         R.add("pr_10010421492", me.Version.AdaptarMySQL_String())
         If Me.ReferenciaProducto IsNot nothing then
           R.add("pr_50010421581",me.ReferenciaProducto.ID.STR())
         Else
           R.add("pr_50010421581","")
         End if
         If Me.ReferenciaImpuesto IsNot nothing then
           R.add("pr_40010421711",me.ReferenciaImpuesto.ID.STR())
         Else
           R.add("pr_40010421711","")
         End if
         R.add("pr_30010421717", me.ImportePrecioDeReferenciaDeVentaConImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_50010421711", me.ImporteCosteMaxSinImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_50010421713", me.ImportePVPMinSinImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_50010421714", me.ImportePVPMinConImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_50010421712", me.ImporteCosteMaxConImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_20010421724", me.InformacionTecnica.AdaptarMySQL_String())
         R.add("pr_30010421716", me.ImportePrecioDeReferenciaDeVentaSinImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_10010421722", me.ImporteCosteReferenciaConImpuestos.AdaptarMySQL_Decimal())
         R.add("pr_10010421721", me.ImporteCosteReferenciaSinImpuestos.AdaptarMySQL_Decimal())
         If Me.ReferenciaTipo IsNot nothing then
           R.add("pr_50010421802",me.ReferenciaTipo.ID.STR())
         Else
           R.add("pr_50010421802","")
         End if
         If Me.ReferenciaCategoriaDeCompra IsNot nothing then
           R.add("pr_60040441203",me.ReferenciaCategoriaDeCompra.ID.STR())
         Else
           R.add("pr_60040441203","")
         End if
         If Me.ReferenciaCategoriaDeVenta IsNot nothing then
           R.add("pr_60040441204",me.ReferenciaCategoriaDeVenta.ID.STR())
         Else
           R.add("pr_60040441204","")
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
      Public Class DetallesDeVehiculosParaDesguace_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
          Public property Puertas As Integer
            get
                return me.GetValue_Int("pr_40040473185")
            End Get
            Set(value As Integer)
                me.SetValue_Int("pr_40040473185", value)
            End Set
          End Property
          Public property ReferenciaCombustibles As Guid
            get
                return me.GetValue_Guid("pr_500404731825")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_500404731825", value)
            End Set
          End Property
          Public property Cambio As String
            get
                return me.GetValue_String("pr_500404731826")
            End Get
            Set(value As String)
                me.SetValue_String("pr_500404731826", value)
            End Set
          End Property
          Public property IDExterna As String
            get
                return me.GetValue_String("pr_60040475822")
            End Get
            Set(value As String)
                me.SetValue_String("pr_60040475822", value)
            End Set
          End Property
          Public property FechaModificacionExterna_UTC As Date
            get
                return me.GetValue_DateTime("pr_60040475823")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_60040475823", value)
            End Set
          End Property
          Public property PotenciaKW As Decimal
            get
                return me.GetValue_Decimal("pr_30040477532")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_30040477532", value)
            End Set
          End Property
          Public property PotenciaCV As Decimal
            get
                return me.GetValue_Decimal("pr_30040477531")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_30040477531", value)
            End Set
          End Property
          Public property Potencia As String
            get
                return me.GetValue_String("pr_20040477533")
            End Get
            Set(value As String)
                me.SetValue_String("pr_20040477533", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_100104213063")
            End Get   
        End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_100104213058")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_100104213058", value)
            End Set
          End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_100104213062")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_100104213062", value)
            End Set
          End Property
        Public ReadOnly property HoraLocal As DateTime
            get
                return me.GetValue_DateTime("pr_100104213060")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_100104213074")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_100104213074", value)
            End Set
          End Property
          Public property ReferenciaMarca As Guid
            get
                return me.GetValue_Guid("pr_60010421322")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_60010421322", value)
            End Set
          End Property
          Public property ReferenciaModelo As Guid
            get
                return me.GetValue_Guid("pr_60010421321")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_60010421321", value)
            End Set
          End Property
          Public property ReferenciaFoto As Guid
            get
                return me.GetValue_Guid("pr_50010421328")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_50010421328", value)
            End Set
          End Property
          Public property AñoInicio As Integer
            get
                return me.GetValue_Int("pr_10010421331")
            End Get
            Set(value As Integer)
                me.SetValue_Int("pr_10010421331", value)
            End Set
          End Property
          Public property AñoFin As Integer
            get
                return me.GetValue_Int("pr_10010421491")
            End Get
            Set(value As Integer)
                me.SetValue_Int("pr_10010421491", value)
            End Set
          End Property
          Public property Version As String
            get
                return me.GetValue_String("pr_10010421492")
            End Get
            Set(value As String)
                me.SetValue_String("pr_10010421492", value)
            End Set
          End Property
          Public property ReferenciaProducto As Guid
            get
                return me.GetValue_Guid("pr_50010421581")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_50010421581", value)
            End Set
          End Property
          Public property ReferenciaImpuesto As Guid
            get
                return me.GetValue_Guid("pr_40010421711")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_40010421711", value)
            End Set
          End Property
        Public ReadOnly property ImportePrecioDeReferenciaDeVentaConImpuestos As Decimal
            get
                return me.GetValue_Decimal("pr_30010421717")
            End Get   
        End Property
          Public property ImporteCosteMaxSinImpuestos As Decimal
            get
                return me.GetValue_Decimal("pr_50010421711")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_50010421711", value)
            End Set
          End Property
          Public property ImportePVPMinSinImpuestos As Decimal
            get
                return me.GetValue_Decimal("pr_50010421713")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_50010421713", value)
            End Set
          End Property
        Public ReadOnly property ImportePVPMinConImpuestos As Decimal
            get
                return me.GetValue_Decimal("pr_50010421714")
            End Get   
        End Property
        Public ReadOnly property ImporteCosteMaxConImpuestos As Decimal
            get
                return me.GetValue_Decimal("pr_50010421712")
            End Get   
        End Property
          Public property InformacionTecnica As String
            get
                return me.GetValue_String("pr_20010421724")
            End Get
            Set(value As String)
                me.SetValue_String("pr_20010421724", value)
            End Set
          End Property
          Public property ImportePrecioDeReferenciaDeVentaSinImpuestos As Decimal
            get
                return me.GetValue_Decimal("pr_30010421716")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_30010421716", value)
            End Set
          End Property
        Public ReadOnly property ImporteCosteReferenciaConImpuestos As Decimal
            get
                return me.GetValue_Decimal("pr_10010421722")
            End Get   
        End Property
          Public property ImporteCosteReferenciaSinImpuestos As Decimal
            get
                return me.GetValue_Decimal("pr_10010421721")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_10010421721", value)
            End Set
          End Property
          Public property ReferenciaTipo As Guid
            get
                return me.GetValue_Guid("pr_50010421802")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_50010421802", value)
            End Set
          End Property
          Public property ReferenciaCategoriaDeCompra As Guid
            get
                return me.GetValue_Guid("pr_60040441203")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_60040441203", value)
            End Set
          End Property
          Public property ReferenciaCategoriaDeVenta As Guid
            get
                return me.GetValue_Guid("pr_60040441204")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_60040441204", value)
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
