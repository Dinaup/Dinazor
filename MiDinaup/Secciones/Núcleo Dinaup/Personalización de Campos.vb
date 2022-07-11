   Imports System.ComponentModel
   Imports DinaNETCore
   Imports DinaNETCore.APID
Partial Public Class SeccionesD
  Public Class PersonalizacionDeCamposD
      Public Shared _SeccionID As String = "68047911-e3a0-4347-82a8-af51dba12883"
      Public Shared _SeccionIDGUID As New Guid("68047911-e3a0-4347-82a8-af51dba12883")
      Public Shared Async Function ConsultarDatos_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, ParamArray Valor As String()) As Task(Of List(Of PersonalizacionDeCamposC )) 
          Dim R As New List(Of PersonalizacionDeCamposC )  
          Dim d = Await DinaupSesion.ConexionServidor.Funcion_Datos_Recibir_Async(DinaupSesion, PersonalizacionDeCamposES._SeccionID, False, Campo, Valor) 
          If d.Datos.TieneDatos Then 
              For Each Actual In d.Datos 
                  Dim Valores_Listador = Actual.Value.Item1
                  Dim Obj_Listador As New PersonalizacionDeCamposC 
                  Obj_Listador.CargarDatos(Valores_Listador) 
                  R.Add(Obj_Listador) 
              Next 
          End If 
          Return R 
      End Function 
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As PersonalizacionDeCamposC, Optional CampoWhere$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Return Await DatosGuardar_Async(DinaupSesion, New List(Of PersonalizacionDeCamposC)({DAtos}), CampoWhere )
      End Function
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As List(Of PersonalizacionDeCamposC), Optional CampoWhere$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Dim Importar As New List(Of DinaupAPI_ImportacionProcesableC)
          For Each Actual In DAtos 
              Dim RegistroActual = New DinaupAPI_ImportacionProcesableC() 
               RegistroActual.dinaup_listador_datos = Actual.ToDic 
               Importar.Add(RegistroActual)  
          Next 
          Return Await DinaupSesion.ConexionServidor.Funcion_Importar_Ejecutar_Async(DinaupSesion, PersonalizacionDeCamposES._SeccionID, Importar, CampoWhere, "") 
      End Function
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As PersonalizacionDeCampos_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, PersonalizacionDeCamposES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New PersonalizacionDeCampos_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As PersonalizacionDeCampos_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, PersonalizacionDeCamposES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New PersonalizacionDeCampos_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class PersonalizacionDeCamposES
          Public shared _SeccionID as Guid = New Guid("68047911-e3a0-4347-82a8-af51dba12883")
          Public shared _Tabla$ = "tpr_780923cxd"
      Public Shared ExtensionesPermitidas$ = "pr_7851a83wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_780926ewd"
      Public Shared ImagenAltoMaximo$ = "pr_7851a77wd"
      Public Shared ReferenciaDestinador$ = "pr_7809252wd"
      Public Shared HoraLocal$ = "pr_7809246wd"
      Public Shared ImagenAltoMinimo$ = "pr_7851a79wd"
      Public Shared ReferenciaIcono$ = "pr_7851a8bwd"
      Public Shared ReferenciaCampo$ = "pr_7809278wd"
      Public Shared MensajeFoco$ = "pr_7851a87wd"
      Public Shared Descripcion$ = "pr_7851a93wd"
      Public Shared Etiqueta$ = "pr_7851a8dwd"
      Public Shared ImagenCompatibleConRepresentacionCircular$ = "pr_792a86bwd"
      Public Shared CriterioSugerencias$ = "pr_7851a85wd"
      Public Shared TamañoMaximo$ = "pr_7851a7fwd"
      Public Shared EvaluarEnAgenda$ = "pr_7809276wd"
      Public Shared CompresionDeImagenes$ = "pr_7851a81wd"
      Public Shared ImagenAnchoMaximo$ = "pr_7851a7bwd"
      Public Shared EtiquetaAbreviada$ = "pr_7851a8fwd"
      Public Shared FechaAlta_UTC$ = "pr_780924cwd"
      Public Shared ReferenciaSeccionSeleccionPreferente$ = "pr_78513bawd"
      Public Shared ExportarEnModulos$ = "pr_7809248wd"
      Public Shared Observaciones$ = "pr_7851a91wd"
      Public Shared CriterioDeIndexacion$ = "pr_7851a89wd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_7809242wd"
      Public Shared ImagenAnchoMinimo$ = "pr_7851a7dwd"
      Public Shared KeyWord$ = "pr_20040430413"
      Public Shared ReferenciaSeccionDeCampo$ = "pr_20040430412"
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
      Public Class PersonalizacionDeCamposC
      Inherits Base_DatoC
          <DisplayName("Extensiones permitidas")>
          Public Property ExtensionesPermitidas As String
          Public Shared ___ExtensionesPermitidas As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ExtensionesPermitidas"",""etiqueta"": ""Extensiones permitidas"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Extensiones permitidas"",""descripcion"": """",""keyword"": ""ExtensionesPermitidas"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ExtensionesPermitidas As DinaNETCore.APID.DinaupAPI_CampoC = ___ExtensionesPermitidas
          <DisplayName("Autor del alta Tiene Acceso web")>
          Public Property AutorDelAltaTieneAccesoWeb As Boolean
          Public Shared ___AutorDelAltaTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AutorDelAltaTieneAccesoWeb"",""etiqueta"": ""Autor del alta Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta Tiene Acceso web"",""descripcion"": """",""keyword"": ""AutorDelAltaTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AutorDelAltaTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___AutorDelAltaTieneAccesoWeb
          <DisplayName("Imagen, alto máximo")>
          Public Property ImagenAltoMaximo As Integer
          Public Shared ___ImagenAltoMaximo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImagenAltoMaximo"",""etiqueta"": ""Imagen, alto máximo"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Imagen, alto máximo"",""descripcion"": """",""keyword"": ""ImagenAltoMaximo"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImagenAltoMaximo As DinaNETCore.APID.DinaupAPI_CampoC = ___ImagenAltoMaximo
          <DisplayName("Destinador")>
          Public Property ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaDestinador As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaDestinador"",""etiqueta"": ""Destinador"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""relacionesindirectas"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Destinador"",""descripcion"": """",""keyword"": ""ReferenciaDestinador"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaDestinador
          <DisplayName("Hora local")>
          Public Property HoraLocal As DateTime?
          Public Shared ___HoraLocal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""HoraLocal"",""etiqueta"": ""Hora local"",""oculta"": false,""formato"": 8,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Hora local"",""descripcion"": """",""keyword"": ""HoraLocal"",""formato"": 8,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __HoraLocal As DinaNETCore.APID.DinaupAPI_CampoC = ___HoraLocal
          <DisplayName("Imagen, alto mínimo")>
          Public Property ImagenAltoMinimo As Integer
          Public Shared ___ImagenAltoMinimo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImagenAltoMinimo"",""etiqueta"": ""Imagen, alto mínimo"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Imagen, alto mínimo"",""descripcion"": """",""keyword"": ""ImagenAltoMinimo"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImagenAltoMinimo As DinaNETCore.APID.DinaupAPI_CampoC = ___ImagenAltoMinimo
          <DisplayName("Icono")>
          Public Property ReferenciaIcono As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaIcono As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaIcono"",""etiqueta"": ""Icono"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""imagenes"",""rol"": 7,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Icono"",""descripcion"": """",""keyword"": ""ReferenciaIcono"",""formato"": 9,""rol"": 7,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaIcono As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaIcono
          <DisplayName("Campo")>
          Public Property ReferenciaCampo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaCampo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaCampo"",""etiqueta"": ""Campo"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""camposp"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Campo"",""descripcion"": """",""keyword"": ""ReferenciaCampo"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaCampo As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaCampo
          <DisplayName("Mensaje foco")>
          Public Property MensajeFoco As String
          Public Shared ___MensajeFoco As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""MensajeFoco"",""etiqueta"": ""Mensaje foco"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Mensaje foco"",""descripcion"": """",""keyword"": ""MensajeFoco"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __MensajeFoco As DinaNETCore.APID.DinaupAPI_CampoC = ___MensajeFoco
          <DisplayName("Descripción")>
          Public Property Descripcion As String
          Public Shared ___Descripcion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Descripcion"",""etiqueta"": ""Descripción"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 9,""decimales"": ""0"",""multilinea"": true,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descripción"",""descripcion"": """",""keyword"": ""Descripcion"",""formato"": 5,""rol"": 9,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Descripcion As DinaNETCore.APID.DinaupAPI_CampoC = ___Descripcion
          <DisplayName("Etiqueta")>
          Public Property Etiqueta As String
          Public Shared ___Etiqueta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Etiqueta"",""etiqueta"": ""Etiqueta"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Etiqueta"",""descripcion"": """",""keyword"": ""Etiqueta"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Etiqueta As DinaNETCore.APID.DinaupAPI_CampoC = ___Etiqueta
          <DisplayName("Imagen compatible con representación circular")>
          Public Property ImagenCompatibleConRepresentacionCircular As Boolean
          Public Shared ___ImagenCompatibleConRepresentacionCircular As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImagenCompatibleConRepresentacionCircular"",""etiqueta"": ""Imagen compatible con representación circular"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Imagen compatible con representación circular"",""descripcion"": """",""keyword"": ""ImagenCompatibleConRepresentacionCircular"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImagenCompatibleConRepresentacionCircular As DinaNETCore.APID.DinaupAPI_CampoC = ___ImagenCompatibleConRepresentacionCircular
          <DisplayName("Criterio sugerencias")>
          Public Property CriterioSugerencias As Integer
          Public Shared ___CriterioSugerencias As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CriterioSugerencias"",""etiqueta"": ""Criterio sugerencias"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Criterio sugerencias"",""descripcion"": """",""keyword"": ""CriterioSugerencias"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CriterioSugerencias As DinaNETCore.APID.DinaupAPI_CampoC = ___CriterioSugerencias
          <DisplayName("Tamaño máximo")>
          Public Property TamañoMaximo As Integer
          Public Shared ___TamañoMaximo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TamañoMaximo"",""etiqueta"": ""Tamaño máximo"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 26,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Tamaño máximo"",""descripcion"": """",""keyword"": ""TamañoMaximo"",""formato"": 2,""rol"": 26,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __TamañoMaximo As DinaNETCore.APID.DinaupAPI_CampoC = ___TamañoMaximo
          <DisplayName("Evaluar en agenda")>
          Public Property EvaluarEnAgenda As EnumCriterioEvaluacionAgendaE
          Public Shared ___EvaluarEnAgenda As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EvaluarEnAgenda"",""etiqueta"": ""Evaluar en agenda"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 32,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [0,1,2,3,4,5],""predefinidos_textos"": [""Indefinido"",""No evaluable"",""Evaluar"",""Evaluar, siempre ocupa (Obsoleto)"",""Evaluar, siempre ocupa (Obsoleto)"",""Evaluar, siempre ocupa (Obsoleto)""],""predefinidos_iconos"": [""https://cdn.dinaup.com/ico/enums/32_0.png"",""https://cdn.dinaup.com/ico/enums/32_1.png"",""https://cdn.dinaup.com/ico/enums/32_2.png"",""https://cdn.dinaup.com/ico/enums/32_3.png"",""https://cdn.dinaup.com/ico/enums/32_4.png"",""https://cdn.dinaup.com/ico/enums/32_5.png""],""filtro"": {""titulo"": ""Evaluar en agenda"",""descripcion"": """",""keyword"": ""EvaluarEnAgenda"",""formato"": 2,""rol"": 32,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false,""enumeracion"": {""titulo"": ""Enum - Criterio evaluación Agenda"", ""valores"": [{""valor"": 0, ""titulo"": ""Indefinido""},{""valor"": 1, ""titulo"": ""No evaluable""},{""valor"": 2, ""titulo"": ""Evaluar""},{""valor"": 3, ""titulo"": ""Evaluar, siempre ocupa (Obsoleto)""},{""valor"": 4, ""titulo"": ""Evaluar, siempre ocupa (Obsoleto)""},{""valor"": 5, ""titulo"": ""Evaluar, siempre ocupa (Obsoleto)""}]}},""solovalorespredefinidos"": true}")
          Public  __EvaluarEnAgenda As DinaNETCore.APID.DinaupAPI_CampoC = ___EvaluarEnAgenda
          <DisplayName("Compresión de imágenes")>
          Public Property CompresionDeImagenes As Integer
          Public Shared ___CompresionDeImagenes As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CompresionDeImagenes"",""etiqueta"": ""Compresión de imágenes"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Compresión de imágenes"",""descripcion"": """",""keyword"": ""CompresionDeImagenes"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CompresionDeImagenes As DinaNETCore.APID.DinaupAPI_CampoC = ___CompresionDeImagenes
          <DisplayName("Imagen, ancho máximo")>
          Public Property ImagenAnchoMaximo As Integer
          Public Shared ___ImagenAnchoMaximo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImagenAnchoMaximo"",""etiqueta"": ""Imagen, ancho máximo"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Imagen, ancho máximo"",""descripcion"": """",""keyword"": ""ImagenAnchoMaximo"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImagenAnchoMaximo As DinaNETCore.APID.DinaupAPI_CampoC = ___ImagenAnchoMaximo
          <DisplayName("Etiqueta Abreviada")>
          Public Property EtiquetaAbreviada As String
          Public Shared ___EtiquetaAbreviada As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EtiquetaAbreviada"",""etiqueta"": ""Etiqueta Abreviada"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Etiqueta Abreviada"",""descripcion"": """",""keyword"": ""EtiquetaAbreviada"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EtiquetaAbreviada As DinaNETCore.APID.DinaupAPI_CampoC = ___EtiquetaAbreviada
          <DisplayName("Fecha Alta del registro")>
          Public Property FechaAlta_UTC As Date?
          Public Shared ___FechaAlta_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaAlta_UTC"",""etiqueta"": ""Fecha Alta del registro"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Alta del registro"",""descripcion"": """",""keyword"": ""FechaAlta_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaAlta_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaAlta_UTC
          <DisplayName("Sección selección preferente")>
          Public Property ReferenciaSeccionSeleccionPreferente As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaSeccionSeleccionPreferente As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaSeccionSeleccionPreferente"",""etiqueta"": ""Sección selección preferente"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""plantillasp"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Sección selección preferente"",""descripcion"": """",""keyword"": ""ReferenciaSeccionSeleccionPreferente"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaSeccionSeleccionPreferente As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaSeccionSeleccionPreferente
          <DisplayName("Observaciones")>
          Public Property Observaciones As String
          Public Shared ___Observaciones As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Observaciones"",""etiqueta"": ""Observaciones"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 9,""decimales"": ""0"",""multilinea"": true,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Observaciones"",""descripcion"": """",""keyword"": ""Observaciones"",""formato"": 5,""rol"": 9,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Observaciones As DinaNETCore.APID.DinaupAPI_CampoC = ___Observaciones
          <DisplayName("Criterio de indexación")>
          Public Property CriterioDeIndexacion As Integer
          Public Shared ___CriterioDeIndexacion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CriterioDeIndexacion"",""etiqueta"": ""Criterio de indexación"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Criterio de indexación"",""descripcion"": """",""keyword"": ""CriterioDeIndexacion"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CriterioDeIndexacion As DinaNETCore.APID.DinaupAPI_CampoC = ___CriterioDeIndexacion
          <DisplayName("Autor del alta")>
          Public Property ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaAutorDelAlta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaAutorDelAlta"",""etiqueta"": ""Autor del alta"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta"",""descripcion"": """",""keyword"": ""ReferenciaAutorDelAlta"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaAutorDelAlta
          <DisplayName("Imagen, ancho mínimo")>
          Public Property ImagenAnchoMinimo As Integer
          Public Shared ___ImagenAnchoMinimo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImagenAnchoMinimo"",""etiqueta"": ""Imagen, ancho mínimo"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Imagen, ancho mínimo"",""descripcion"": """",""keyword"": ""ImagenAnchoMinimo"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImagenAnchoMinimo As DinaNETCore.APID.DinaupAPI_CampoC = ___ImagenAnchoMinimo
          <DisplayName("KeyWord")>
          Public Property KeyWord As String
          Public Shared ___KeyWord As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""KeyWord"",""etiqueta"": ""KeyWord"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 100,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""KeyWord"",""descripcion"": """",""keyword"": ""KeyWord"",""formato"": 5,""rol"": 100,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __KeyWord As DinaNETCore.APID.DinaupAPI_CampoC = ___KeyWord
          <DisplayName("Sección de Campo")>
          Public Property ReferenciaSeccionDeCampo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaSeccionDeCampo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaSeccionDeCampo"",""etiqueta"": ""Sección de Campo"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""plantillasp"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Sección de Campo"",""descripcion"": """",""keyword"": ""ReferenciaSeccionDeCampo"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaSeccionDeCampo As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaSeccionDeCampo
          <ReadOnlyAttribute(True)>
          <DisplayName("ID")>
          Public Property ID As Guid
          Public Shared ___ID As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": true,""eseliminado"": false,""keyword"": ""ID"",""etiqueta"": ""ID"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""68047911-e3a0-4347-82a8-af51dba12883"",""titulo"": ""Personalización de Campos"",""iconoid"": ""0c37e868-6de8-4254-b6c9-655c204b2949"",""etiquetasingular"": ""Personalización de Campo"",""etiquetaplural"": ""Personalizaciones de Campos"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""68047911-e3a0-4347-82a8-af51dba12883"",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""ID"",""descripcion"": """",""keyword"": ""ID"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
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
          me.ExtensionesPermitidas = _Datos.Leer_String("pr_7851a83wd")
          me.AutorDelAltaTieneAccesoWeb = _Datos.Leer_Boolean("pr_780926ewd")
          me.ImagenAltoMaximo = _Datos.Leer_Integer("pr_7851a77wd")
          me.ReferenciaDestinador = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_7809252wd"), _Datos.Leer_String("pr_7809252wd.nombre"))
          me.HoraLocal = _Datos.Leer_Time_Nulable("pr_7809246wd")
          me.ImagenAltoMinimo = _Datos.Leer_Integer("pr_7851a79wd")
          me.ReferenciaIcono = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_7851a8bwd"), _Datos.Leer_String("pr_7851a8bwd.nombre"))
          me.ReferenciaCampo = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_7809278wd"), _Datos.Leer_String("pr_7809278wd.nombre"))
          me.MensajeFoco = _Datos.Leer_String("pr_7851a87wd")
          me.Descripcion = _Datos.Leer_String("pr_7851a93wd")
          me.Etiqueta = _Datos.Leer_String("pr_7851a8dwd")
          me.ImagenCompatibleConRepresentacionCircular = _Datos.Leer_Boolean("pr_792a86bwd")
          me.CriterioSugerencias = _Datos.Leer_Integer("pr_7851a85wd")
          me.TamañoMaximo = _Datos.Leer_Integer("pr_7851a7fwd")
          me.EvaluarEnAgenda = _Datos.Leer_EnumCriterioEvaluacionAgendaE("pr_7809276wd")
          me.CompresionDeImagenes = _Datos.Leer_Integer("pr_7851a81wd")
          me.ImagenAnchoMaximo = _Datos.Leer_Integer("pr_7851a7bwd")
          me.EtiquetaAbreviada = _Datos.Leer_String("pr_7851a8fwd")
          me.FechaAlta_UTC = _Datos.Leer_DateTime_Nulable("pr_780924cwd")
          me.ReferenciaSeccionSeleccionPreferente = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_78513bawd"), _Datos.Leer_String("pr_78513bawd.nombre"))
          me.Observaciones = _Datos.Leer_String("pr_7851a91wd")
          me.CriterioDeIndexacion = _Datos.Leer_Integer("pr_7851a89wd")
          me.ReferenciaAutorDelAlta = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_7809242wd"), _Datos.Leer_String("pr_7809242wd.nombre"))
          me.ImagenAnchoMinimo = _Datos.Leer_Integer("pr_7851a7dwd")
          me.KeyWord = _Datos.Leer_String("pr_20040430413")
          me.ReferenciaSeccionDeCampo = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_20040430412"), _Datos.Leer_String("pr_20040430412.nombre"))
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
         R.add("pr_7851a83wd", me.ExtensionesPermitidas.AdaptarMySQL_String())
         R.add("pr_780926ewd", me.AutorDelAltaTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_7851a77wd", me.ImagenAltoMaximo.AdaptarMySQL_Integer())
         If Me.ReferenciaDestinador IsNot nothing then
           R.add("pr_7809252wd",me.ReferenciaDestinador.ID.STR())
         Else
           R.add("pr_7809252wd","")
         End if
         R.add("pr_7809246wd", me.HoraLocal.AdaptarMySQL_Time_Nulable())
         R.add("pr_7851a79wd", me.ImagenAltoMinimo.AdaptarMySQL_Integer())
         If Me.ReferenciaIcono IsNot nothing then
           R.add("pr_7851a8bwd",me.ReferenciaIcono.ID.STR())
         Else
           R.add("pr_7851a8bwd","")
         End if
         If Me.ReferenciaCampo IsNot nothing then
           R.add("pr_7809278wd",me.ReferenciaCampo.ID.STR())
         Else
           R.add("pr_7809278wd","")
         End if
         R.add("pr_7851a87wd", me.MensajeFoco.AdaptarMySQL_String())
         R.add("pr_7851a93wd", me.Descripcion.AdaptarMySQL_String())
         R.add("pr_7851a8dwd", me.Etiqueta.AdaptarMySQL_String())
         R.add("pr_792a86bwd", me.ImagenCompatibleConRepresentacionCircular.AdaptarMySQL_Boolean())
         R.add("pr_7851a85wd", me.CriterioSugerencias.AdaptarMySQL_Integer())
         R.add("pr_7851a7fwd", me.TamañoMaximo.AdaptarMySQL_Integer())
         R.add("pr_7809276wd", me.EvaluarEnAgenda.AdaptarMySQL_EnumCriterioEvaluacionAgendaE())
         R.add("pr_7851a81wd", me.CompresionDeImagenes.AdaptarMySQL_Integer())
         R.add("pr_7851a7bwd", me.ImagenAnchoMaximo.AdaptarMySQL_Integer())
         R.add("pr_7851a8fwd", me.EtiquetaAbreviada.AdaptarMySQL_String())
         R.add("pr_780924cwd", me.FechaAlta_UTC.AdaptarMySQL_DateTime_Nulable())
         If Me.ReferenciaSeccionSeleccionPreferente IsNot nothing then
           R.add("pr_78513bawd",me.ReferenciaSeccionSeleccionPreferente.ID.STR())
         Else
           R.add("pr_78513bawd","")
         End if
         R.add("pr_7851a91wd", me.Observaciones.AdaptarMySQL_String())
         R.add("pr_7851a89wd", me.CriterioDeIndexacion.AdaptarMySQL_Integer())
         If Me.ReferenciaAutorDelAlta IsNot nothing then
           R.add("pr_7809242wd",me.ReferenciaAutorDelAlta.ID.STR())
         Else
           R.add("pr_7809242wd","")
         End if
         R.add("pr_7851a7dwd", me.ImagenAnchoMinimo.AdaptarMySQL_Integer())
         R.add("pr_20040430413", me.KeyWord.AdaptarMySQL_String())
         If Me.ReferenciaSeccionDeCampo IsNot nothing then
           R.add("pr_20040430412",me.ReferenciaSeccionDeCampo.ID.STR())
         Else
           R.add("pr_20040430412","")
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
      Public Class PersonalizacionDeCampos_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
        Public ReadOnly property ExtensionesPermitidas As String
            get
                return me.GetValue_String("pr_7851a83wd")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_780926ewd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_780926ewd", value)
            End Set
          End Property
        Public ReadOnly property ImagenAltoMaximo As Integer
            get
                return me.GetValue_Int("pr_7851a77wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_7809252wd")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As DateTime
            get
                return me.GetValue_DateTime("pr_7809246wd")
            End Get   
        End Property
        Public ReadOnly property ImagenAltoMinimo As Integer
            get
                return me.GetValue_Int("pr_7851a79wd")
            End Get   
        End Property
          Public property ReferenciaIcono As Guid
            get
                return me.GetValue_Guid("pr_7851a8bwd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_7851a8bwd", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaCampo As Guid
            get
                return me.GetValue_Guid("pr_7809278wd")
            End Get   
        End Property
        Public ReadOnly property MensajeFoco As String
            get
                return me.GetValue_String("pr_7851a87wd")
            End Get   
        End Property
        Public ReadOnly property Descripcion As String
            get
                return me.GetValue_String("pr_7851a93wd")
            End Get   
        End Property
        Public ReadOnly property Etiqueta As String
            get
                return me.GetValue_String("pr_7851a8dwd")
            End Get   
        End Property
        Public ReadOnly property ImagenCompatibleConRepresentacionCircular As Boolean
            get
                return me.GetValue_Boolean("pr_792a86bwd")
            End Get   
        End Property
        Public ReadOnly property CriterioSugerencias As Integer
            get
                return me.GetValue_Int("pr_7851a85wd")
            End Get   
        End Property
        Public ReadOnly property TamañoMaximo As Integer
            get
                return me.GetValue_Int("pr_7851a7fwd")
            End Get   
        End Property
        Public ReadOnly property EvaluarEnAgenda As EnumCriterioEvaluacionAgendaE
            get
                return me.GetValue_Int("pr_7809276wd")
            End Get   
        End Property
        Public ReadOnly property CompresionDeImagenes As Integer
            get
                return me.GetValue_Int("pr_7851a81wd")
            End Get   
        End Property
        Public ReadOnly property ImagenAnchoMaximo As Integer
            get
                return me.GetValue_Int("pr_7851a7bwd")
            End Get   
        End Property
        Public ReadOnly property EtiquetaAbreviada As String
            get
                return me.GetValue_String("pr_7851a8fwd")
            End Get   
        End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_780924cwd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_780924cwd", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaSeccionSeleccionPreferente As Guid
            get
                return me.GetValue_Guid("pr_78513bawd")
            End Get   
        End Property
        Public ReadOnly property Observaciones As String
            get
                return me.GetValue_String("pr_7851a91wd")
            End Get   
        End Property
        Public ReadOnly property CriterioDeIndexacion As Integer
            get
                return me.GetValue_Int("pr_7851a89wd")
            End Get   
        End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_7809242wd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_7809242wd", value)
            End Set
          End Property
        Public ReadOnly property ImagenAnchoMinimo As Integer
            get
                return me.GetValue_Int("pr_7851a7dwd")
            End Get   
        End Property
          Public property KeyWord As String
            get
                return me.GetValue_String("pr_20040430413")
            End Get
            Set(value As String)
                me.SetValue_String("pr_20040430413", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaSeccionDeCampo As Guid
            get
                return me.GetValue_Guid("pr_20040430412")
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
