   Imports System.ComponentModel
   Imports DinaNETCore
   Imports DinaNETCore.APID
Partial Public Class SeccionesD
  Public Class CCObsoletoD
      Public Shared _SeccionID As String = "a4e613e4-e649-4b8e-b64e-9d56a3e78a4e"
      Public Shared _SeccionIDGUID As New Guid("a4e613e4-e649-4b8e-b64e-9d56a3e78a4e")
      Public Shared Async Function ConsultarDatos_Async(Parametros As SeccionConsultaParametrosC) As Task(Of List(Of CCObsoletoC )) 
          Dim R As New List(Of CCObsoletoC )  
          Dim d = Await Parametros.DinaupSesion.ConexionServidor.Funcion_Datos_Recibir_Async(CCObsoletoES._SeccionID, False, Parametros) 
          If d.Datos.TieneDatos Then 
              For Each Actual In d.Datos 
                  Dim Valores_Listador = Actual.Value.Item1
                  Dim Obj_Listador As New CCObsoletoC 
                  Obj_Listador.CargarDatos(Valores_Listador) 
                  Obj_Listador.CargaInterna(Actual.Value)
                  R.Add(Obj_Listador) 
              Next 
          End If 
          Return R 
      End Function 
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As CCObsoletoC, Optional CampoWhere$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Return Await DatosGuardar_Async(DinaupSesion, New List(Of CCObsoletoC)({DAtos}), CampoWhere )
      End Function
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As List(Of CCObsoletoC), Optional CampoWhere$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Dim Importar As New List(Of DinaupAPI_ImportacionProcesableC)
          For Each Actual In DAtos 
              Dim RegistroActual = New DinaupAPI_ImportacionProcesableC() 
               RegistroActual.dinaup_listador_datos = Actual.ToDic 
               Importar.Add(RegistroActual)  
          Next 
          Return Await DinaupSesion.ConexionServidor.Funcion_Importar_Ejecutar_Async(DinaupSesion, CCObsoletoES._SeccionID, Importar, CampoWhere, "") 
      End Function
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As CCObsoleto_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, CCObsoletoES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New CCObsoleto_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As CCObsoleto_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, CCObsoletoES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New CCObsoleto_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class CCObsoletoES
          Public shared _SeccionID as Guid = New Guid("a4e613e4-e649-4b8e-b64e-9d56a3e78a4e")
          Public shared _Tabla$ = "tpr_50040133332"
      Public Shared MultiplicadorSaldo$ = "pr_60040136482"
      Public Shared Naturaleza$ = "pr_60040136481"
      Public Shared ReferenciaDestinador$ = "pr_500401333339"
      Public Shared ExportarEnModulos$ = "pr_500401333337"
      Public Shared FechaAlta_UTC$ = "pr_500401333338"
      Public Shared ReferenciaAutorDelAlta$ = "pr_500401333334"
      Public Shared HoraLocal$ = "pr_500401333336"
      Public Shared CodigoDeGrupoFormatoDeTexto$ = "pr_10040133364"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_500401333345"
      Public Shared ReferenciaGrupo$ = "pr_10040133343"
      Public Shared Descripcion$ = "pr_20040133343"
      Public Shared CodigoDeCuenta$ = "pr_30040133341"
      Public Shared CodigoDeGrupo$ = "pr_10040133342"
      Public Shared CodigoDeCuentaFormatoDeTexto$ = "pr_40040133341"
      Public Shared ReferenciaGrupoNivel3$ = "pr_10040143646"
      Public Shared ReferenciaCuentaNivel1$ = "pr_100401436410"
      Public Shared Nivel$ = "pr_60040143624"
      Public Shared ReferenciaGrupoNivel1$ = "pr_10040143647"
      Public Shared CodigoGrupoNivel1$ = "pr_10040143645"
      Public Shared CodigoGrupoNivel3$ = "pr_10040143643"
      Public Shared CodigoCuentaNivel1$ = "pr_100401436411"
      Public Shared ReferenciaGrupoNivel2$ = "pr_10040143648"
      Public Shared ReferenciaCuentaNivel2$ = "pr_20040143647"
      Public Shared ReferenciaSubcuenta$ = "pr_40040143651"
      Public Shared CodigoGrupoNivel2$ = "pr_10040143644"
      Public Shared CodigoSubcuenta$ = "pr_20040143643"
      Public Shared CodigoCuentaNivel2$ = "pr_20040143642"
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
      Public Class CCObsoletoC
      Inherits Base_DatoC
          <DisplayName("Multiplicador saldo")>
          Public Property MultiplicadorSaldo As Integer
          Public Shared ___MultiplicadorSaldo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""MultiplicadorSaldo"",""etiqueta"": ""Multiplicador saldo"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": false,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Multiplicador saldo"",""descripcion"": """",""keyword"": ""MultiplicadorSaldo"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __MultiplicadorSaldo As DinaNETCore.APID.DinaupAPI_CampoC = ___MultiplicadorSaldo
          <DisplayName("Naturaleza")>
          Public Property Naturaleza As EnumNaturalezaDeCuentaE
          Public Shared ___Naturaleza As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Naturaleza"",""etiqueta"": ""Naturaleza"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 53,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [0,1,2],""predefinidos_textos"": [""Indefinido"",""Deudora"",""Acreedora""],""predefinidos_iconos"": [""https://cdn.dinaup.com/ico/enums/53_0.png"",""https://cdn.dinaup.com/ico/enums/53_1.png"",""https://cdn.dinaup.com/ico/enums/53_2.png""],""filtro"": {""titulo"": ""Naturaleza"",""descripcion"": """",""keyword"": ""Naturaleza"",""formato"": 2,""rol"": 53,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false,""enumeracion"": {""titulo"": ""Enum - Naturaleza de cuenta"", ""valores"": [{""valor"": 0, ""titulo"": ""Indefinido""},{""valor"": 1, ""titulo"": ""Deudora""},{""valor"": 2, ""titulo"": ""Acreedora""}]}},""solovalorespredefinidos"": true}")
          Public  __Naturaleza As DinaNETCore.APID.DinaupAPI_CampoC = ___Naturaleza
          <DisplayName("Destinador")>
          Public Property ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaDestinador As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaDestinador"",""etiqueta"": ""Destinador"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""relacionesindirectas"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Destinador"",""descripcion"": """",""keyword"": ""ReferenciaDestinador"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaDestinador
          <DisplayName("Fecha Alta del registro")>
          Public Property FechaAlta_UTC As Date?
          Public Shared ___FechaAlta_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaAlta_UTC"",""etiqueta"": ""Fecha Alta del registro"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Alta del registro"",""descripcion"": """",""keyword"": ""FechaAlta_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaAlta_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaAlta_UTC
          <DisplayName("Autor del alta")>
          Public Property ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaAutorDelAlta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaAutorDelAlta"",""etiqueta"": ""Autor del alta"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta"",""descripcion"": """",""keyword"": ""ReferenciaAutorDelAlta"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaAutorDelAlta
          <DisplayName("Hora local")>
          Public Property HoraLocal As DateTime?
          Public Shared ___HoraLocal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""HoraLocal"",""etiqueta"": ""Hora local"",""oculta"": false,""formato"": 8,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Hora local"",""descripcion"": """",""keyword"": ""HoraLocal"",""formato"": 8,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __HoraLocal As DinaNETCore.APID.DinaupAPI_CampoC = ___HoraLocal
          <DisplayName("Código de grupo (Formato de texto) (Obsoleto)")>
          Public Property CodigoDeGrupoFormatoDeTexto As String
          Public Shared ___CodigoDeGrupoFormatoDeTexto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CodigoDeGrupoFormatoDeTexto"",""etiqueta"": ""Código de grupo (Formato de texto) (Obsoleto)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Código de grupo (Formato de texto) (Obsoleto)"",""descripcion"": """",""keyword"": ""CodigoDeGrupoFormatoDeTexto"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CodigoDeGrupoFormatoDeTexto As DinaNETCore.APID.DinaupAPI_CampoC = ___CodigoDeGrupoFormatoDeTexto
          <DisplayName("Autor del alta Tiene Acceso web")>
          Public Property AutorDelAltaTieneAccesoWeb As Boolean
          Public Shared ___AutorDelAltaTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AutorDelAltaTieneAccesoWeb"",""etiqueta"": ""Autor del alta Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta Tiene Acceso web"",""descripcion"": """",""keyword"": ""AutorDelAltaTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AutorDelAltaTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___AutorDelAltaTieneAccesoWeb
          <DisplayName("Grupo (Obsoleto)")>
          Public Property ReferenciaGrupo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaGrupo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaGrupo"",""etiqueta"": ""Grupo (Obsoleto)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""a979af7f-7763-4e7f-a9ce-ef1c555ae222"",""titulo"": ""Base - Grupos contables"",""iconoid"": ""5f43e14d-d3ba-4c24-a0b0-e2f605ada71f"",""etiquetasingular"": ""Grupo contable"",""etiquetaplural"": ""Grupos contables"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""a979af7f-7763-4e7f-a9ce-ef1c555ae222"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Grupo (Obsoleto)"",""descripcion"": """",""keyword"": ""ReferenciaGrupo"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaGrupo As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaGrupo
          <DisplayName("Descripción")>
          Public Property Descripcion As String
          Public Shared ___Descripcion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Descripcion"",""etiqueta"": ""Descripción"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 51,""decimales"": ""0"",""multilinea"": true,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descripción"",""descripcion"": """",""keyword"": ""Descripcion"",""formato"": 5,""rol"": 51,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Descripcion As DinaNETCore.APID.DinaupAPI_CampoC = ___Descripcion
          <DisplayName("Código de cuenta")>
          Public Property CodigoDeCuenta As Integer
          Public Shared ___CodigoDeCuenta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CodigoDeCuenta"",""etiqueta"": ""Código de cuenta"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": false,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Código de cuenta"",""descripcion"": """",""keyword"": ""CodigoDeCuenta"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CodigoDeCuenta As DinaNETCore.APID.DinaupAPI_CampoC = ___CodigoDeCuenta
          <DisplayName("Código de grupo (Obsoleto)")>
          Public Property CodigoDeGrupo As Integer
          Public Shared ___CodigoDeGrupo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CodigoDeGrupo"",""etiqueta"": ""Código de grupo (Obsoleto)"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Código de grupo (Obsoleto)"",""descripcion"": """",""keyword"": ""CodigoDeGrupo"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CodigoDeGrupo As DinaNETCore.APID.DinaupAPI_CampoC = ___CodigoDeGrupo
          <DisplayName("Código de cuenta (Formato de texto)")>
          Public Property CodigoDeCuentaFormatoDeTexto As String
          Public Shared ___CodigoDeCuentaFormatoDeTexto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CodigoDeCuentaFormatoDeTexto"",""etiqueta"": ""Código de cuenta (Formato de texto)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Código de cuenta (Formato de texto)"",""descripcion"": """",""keyword"": ""CodigoDeCuentaFormatoDeTexto"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CodigoDeCuentaFormatoDeTexto As DinaNETCore.APID.DinaupAPI_CampoC = ___CodigoDeCuentaFormatoDeTexto
          <DisplayName("Grupo Nivel 3")>
          Public Property ReferenciaGrupoNivel3 As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaGrupoNivel3 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaGrupoNivel3"",""etiqueta"": ""Grupo Nivel 3"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""aed7e97f-92e5-4aa8-884c-2a1f0f6df85f"",""titulo"": ""Base - CC (Obsoleto)"",""iconoid"": ""79445811-9f6d-4013-bb0a-1e3679283474"",""etiquetasingular"": ""CC"",""etiquetaplural"": ""CCs"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""aed7e97f-92e5-4aa8-884c-2a1f0f6df85f"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Grupo Nivel 3"",""descripcion"": """",""keyword"": ""ReferenciaGrupoNivel3"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaGrupoNivel3 As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaGrupoNivel3
          <DisplayName("Cuenta Nivel 1")>
          Public Property ReferenciaCuentaNivel1 As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaCuentaNivel1 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaCuentaNivel1"",""etiqueta"": ""Cuenta Nivel 1"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""aed7e97f-92e5-4aa8-884c-2a1f0f6df85f"",""titulo"": ""Base - CC (Obsoleto)"",""iconoid"": ""79445811-9f6d-4013-bb0a-1e3679283474"",""etiquetasingular"": ""CC"",""etiquetaplural"": ""CCs"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""aed7e97f-92e5-4aa8-884c-2a1f0f6df85f"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cuenta Nivel 1"",""descripcion"": """",""keyword"": ""ReferenciaCuentaNivel1"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaCuentaNivel1 As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaCuentaNivel1
          <DisplayName("Nivel")>
          Public Property Nivel As EnumNivelCuentaContableE
          Public Shared ___Nivel As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Nivel"",""etiqueta"": ""Nivel"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 58,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": false,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [0,1,2,3,4,5,6,7],""predefinidos_textos"": [""Indefinido"",""Grupo nivel 1"",""(x) Subgrupo nivel 2"",""(x) Subgrupo nivel 3"",""Cuenta"",""(x) Subcuenta 1"",""(x) Subcuenta 2"",""Subcuenta""],""predefinidos_iconos"": [""https://cdn.dinaup.com/ico/enums/58_0.png"",""https://cdn.dinaup.com/ico/enums/58_1.png"",""https://cdn.dinaup.com/ico/enums/58_2.png"",""https://cdn.dinaup.com/ico/enums/58_3.png"",""https://cdn.dinaup.com/ico/enums/58_4.png"",""https://cdn.dinaup.com/ico/enums/58_5.png"",""https://cdn.dinaup.com/ico/enums/58_6.png"",""https://cdn.dinaup.com/ico/enums/58_7.png""],""filtro"": {""titulo"": ""Nivel"",""descripcion"": """",""keyword"": ""Nivel"",""formato"": 2,""rol"": 58,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false,""enumeracion"": {""titulo"": ""Enum - Nivel Cuenta Contable"", ""valores"": [{""valor"": 0, ""titulo"": ""Indefinido""},{""valor"": 1, ""titulo"": ""Grupo nivel 1""},{""valor"": 2, ""titulo"": ""(x) Subgrupo nivel 2""},{""valor"": 3, ""titulo"": ""(x) Subgrupo nivel 3""},{""valor"": 4, ""titulo"": ""Cuenta""},{""valor"": 5, ""titulo"": ""(x) Subcuenta 1""},{""valor"": 6, ""titulo"": ""(x) Subcuenta 2""},{""valor"": 7, ""titulo"": ""Subcuenta""}]}},""solovalorespredefinidos"": true}")
          Public  __Nivel As DinaNETCore.APID.DinaupAPI_CampoC = ___Nivel
          <DisplayName("Grupo Nivel 1")>
          Public Property ReferenciaGrupoNivel1 As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaGrupoNivel1 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaGrupoNivel1"",""etiqueta"": ""Grupo Nivel 1"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""aed7e97f-92e5-4aa8-884c-2a1f0f6df85f"",""titulo"": ""Base - CC (Obsoleto)"",""iconoid"": ""79445811-9f6d-4013-bb0a-1e3679283474"",""etiquetasingular"": ""CC"",""etiquetaplural"": ""CCs"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""aed7e97f-92e5-4aa8-884c-2a1f0f6df85f"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Grupo Nivel 1"",""descripcion"": """",""keyword"": ""ReferenciaGrupoNivel1"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaGrupoNivel1 As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaGrupoNivel1
          <DisplayName("Código (Grupo Nivel 1)")>
          Public Property CodigoGrupoNivel1 As Integer
          Public Shared ___CodigoGrupoNivel1 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CodigoGrupoNivel1"",""etiqueta"": ""Código (Grupo Nivel 1)"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Código (Grupo Nivel 1)"",""descripcion"": """",""keyword"": ""CodigoGrupoNivel1"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CodigoGrupoNivel1 As DinaNETCore.APID.DinaupAPI_CampoC = ___CodigoGrupoNivel1
          <DisplayName("Código (Grupo Nivel 3)")>
          Public Property CodigoGrupoNivel3 As Integer
          Public Shared ___CodigoGrupoNivel3 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CodigoGrupoNivel3"",""etiqueta"": ""Código (Grupo Nivel 3)"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Código (Grupo Nivel 3)"",""descripcion"": """",""keyword"": ""CodigoGrupoNivel3"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CodigoGrupoNivel3 As DinaNETCore.APID.DinaupAPI_CampoC = ___CodigoGrupoNivel3
          <DisplayName("Código (Cuenta Nivel 1)")>
          Public Property CodigoCuentaNivel1 As Integer
          Public Shared ___CodigoCuentaNivel1 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CodigoCuentaNivel1"",""etiqueta"": ""Código (Cuenta Nivel 1)"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Código (Cuenta Nivel 1)"",""descripcion"": """",""keyword"": ""CodigoCuentaNivel1"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CodigoCuentaNivel1 As DinaNETCore.APID.DinaupAPI_CampoC = ___CodigoCuentaNivel1
          <DisplayName("Grupo Nivel 2")>
          Public Property ReferenciaGrupoNivel2 As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaGrupoNivel2 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaGrupoNivel2"",""etiqueta"": ""Grupo Nivel 2"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""aed7e97f-92e5-4aa8-884c-2a1f0f6df85f"",""titulo"": ""Base - CC (Obsoleto)"",""iconoid"": ""79445811-9f6d-4013-bb0a-1e3679283474"",""etiquetasingular"": ""CC"",""etiquetaplural"": ""CCs"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""aed7e97f-92e5-4aa8-884c-2a1f0f6df85f"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Grupo Nivel 2"",""descripcion"": """",""keyword"": ""ReferenciaGrupoNivel2"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaGrupoNivel2 As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaGrupoNivel2
          <DisplayName("Cuenta Nivel 2")>
          Public Property ReferenciaCuentaNivel2 As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaCuentaNivel2 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaCuentaNivel2"",""etiqueta"": ""Cuenta Nivel 2"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""aed7e97f-92e5-4aa8-884c-2a1f0f6df85f"",""titulo"": ""Base - CC (Obsoleto)"",""iconoid"": ""79445811-9f6d-4013-bb0a-1e3679283474"",""etiquetasingular"": ""CC"",""etiquetaplural"": ""CCs"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""aed7e97f-92e5-4aa8-884c-2a1f0f6df85f"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cuenta Nivel 2"",""descripcion"": """",""keyword"": ""ReferenciaCuentaNivel2"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaCuentaNivel2 As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaCuentaNivel2
          <DisplayName("Subcuenta")>
          Public Property ReferenciaSubcuenta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaSubcuenta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaSubcuenta"",""etiqueta"": ""Subcuenta"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c1578f25-c397-4882-a252-52b5fe65731c"",""titulo"": ""Base - Cuadro de cuentas"",""iconoid"": ""56e95fca-1432-4283-b4a2-1336964a155f"",""etiquetasingular"": ""Cuadro de cuenta"",""etiquetaplural"": ""Cuadro de cuentas"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""c1578f25-c397-4882-a252-52b5fe65731c"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Subcuenta"",""descripcion"": """",""keyword"": ""ReferenciaSubcuenta"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaSubcuenta As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaSubcuenta
          <DisplayName("Código (Grupo Nivel 2)")>
          Public Property CodigoGrupoNivel2 As Integer
          Public Shared ___CodigoGrupoNivel2 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CodigoGrupoNivel2"",""etiqueta"": ""Código (Grupo Nivel 2)"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Código (Grupo Nivel 2)"",""descripcion"": """",""keyword"": ""CodigoGrupoNivel2"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CodigoGrupoNivel2 As DinaNETCore.APID.DinaupAPI_CampoC = ___CodigoGrupoNivel2
          <DisplayName("Código Subcuenta")>
          Public Property CodigoSubcuenta As Integer
          Public Shared ___CodigoSubcuenta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CodigoSubcuenta"",""etiqueta"": ""Código Subcuenta"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Código Subcuenta"",""descripcion"": """",""keyword"": ""CodigoSubcuenta"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CodigoSubcuenta As DinaNETCore.APID.DinaupAPI_CampoC = ___CodigoSubcuenta
          <DisplayName("Código (Cuenta Nivel 2)")>
          Public Property CodigoCuentaNivel2 As Integer
          Public Shared ___CodigoCuentaNivel2 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CodigoCuentaNivel2"",""etiqueta"": ""Código (Cuenta Nivel 2)"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Código (Cuenta Nivel 2)"",""descripcion"": """",""keyword"": ""CodigoCuentaNivel2"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CodigoCuentaNivel2 As DinaNETCore.APID.DinaupAPI_CampoC = ___CodigoCuentaNivel2
          <ReadOnlyAttribute(True)>
          <DisplayName("ID")>
          Public Property ID As Guid
          Public Shared ___ID As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": true,""eseliminado"": false,""keyword"": ""ID"",""etiqueta"": ""ID"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""a4e613e4-e649-4b8e-b64e-9d56a3e78a4e"",""titulo"": ""CC (Obsoleto)"",""iconoid"": ""79445811-9f6d-4013-bb0a-1e3679283474"",""etiquetasingular"": ""CC"",""etiquetaplural"": ""CCs"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""a4e613e4-e649-4b8e-b64e-9d56a3e78a4e"",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""ID"",""descripcion"": """",""keyword"": ""ID"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
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
          me.MultiplicadorSaldo = _Datos.Leer_Integer("pr_60040136482")
          me.Naturaleza = _Datos.Leer_EnumNaturalezaDeCuentaE("pr_60040136481")
          me.ReferenciaDestinador = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_500401333339"), _Datos.Leer_String("pr_500401333339.nombre"))
          me.FechaAlta_UTC = _Datos.Leer_DateTime_Nulable("pr_500401333338")
          me.ReferenciaAutorDelAlta = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_500401333334"), _Datos.Leer_String("pr_500401333334.nombre"))
          me.HoraLocal = _Datos.Leer_Time_Nulable("pr_500401333336")
          me.CodigoDeGrupoFormatoDeTexto = _Datos.Leer_String("pr_10040133364")
          me.AutorDelAltaTieneAccesoWeb = _Datos.Leer_Boolean("pr_500401333345")
          me.ReferenciaGrupo = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_10040133343"), _Datos.Leer_String("pr_10040133343.nombre"))
          me.Descripcion = _Datos.Leer_String("pr_20040133343")
          me.CodigoDeCuenta = _Datos.Leer_Integer("pr_30040133341")
          me.CodigoDeGrupo = _Datos.Leer_Integer("pr_10040133342")
          me.CodigoDeCuentaFormatoDeTexto = _Datos.Leer_String("pr_40040133341")
          me.ReferenciaGrupoNivel3 = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_10040143646"), _Datos.Leer_String("pr_10040143646.nombre"))
          me.ReferenciaCuentaNivel1 = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_100401436410"), _Datos.Leer_String("pr_100401436410.nombre"))
          me.Nivel = _Datos.Leer_EnumNivelCuentaContableE("pr_60040143624")
          me.ReferenciaGrupoNivel1 = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_10040143647"), _Datos.Leer_String("pr_10040143647.nombre"))
          me.CodigoGrupoNivel1 = _Datos.Leer_Integer("pr_10040143645")
          me.CodigoGrupoNivel3 = _Datos.Leer_Integer("pr_10040143643")
          me.CodigoCuentaNivel1 = _Datos.Leer_Integer("pr_100401436411")
          me.ReferenciaGrupoNivel2 = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_10040143648"), _Datos.Leer_String("pr_10040143648.nombre"))
          me.ReferenciaCuentaNivel2 = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_20040143647"), _Datos.Leer_String("pr_20040143647.nombre"))
          me.ReferenciaSubcuenta = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_40040143651"), _Datos.Leer_String("pr_40040143651.nombre"))
          me.CodigoGrupoNivel2 = _Datos.Leer_Integer("pr_10040143644")
          me.CodigoSubcuenta = _Datos.Leer_Integer("pr_20040143643")
          me.CodigoCuentaNivel2 = _Datos.Leer_Integer("pr_20040143642")
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
         R.add("pr_60040136482", me.MultiplicadorSaldo.AdaptarMySQL_Integer())
         R.add("pr_60040136481", me.Naturaleza.AdaptarMySQL_EnumNaturalezaDeCuentaE())
         If Me.ReferenciaDestinador IsNot nothing then
           R.add("pr_500401333339",me.ReferenciaDestinador.ID.STR())
         Else
           R.add("pr_500401333339","")
         End if
         R.add("pr_500401333338", me.FechaAlta_UTC.AdaptarMySQL_DateTime_Nulable())
         If Me.ReferenciaAutorDelAlta IsNot nothing then
           R.add("pr_500401333334",me.ReferenciaAutorDelAlta.ID.STR())
         Else
           R.add("pr_500401333334","")
         End if
         R.add("pr_500401333336", me.HoraLocal.AdaptarMySQL_Time_Nulable())
         R.add("pr_10040133364", me.CodigoDeGrupoFormatoDeTexto.AdaptarMySQL_String())
         R.add("pr_500401333345", me.AutorDelAltaTieneAccesoWeb.AdaptarMySQL_Boolean())
         If Me.ReferenciaGrupo IsNot nothing then
           R.add("pr_10040133343",me.ReferenciaGrupo.ID.STR())
         Else
           R.add("pr_10040133343","")
         End if
         R.add("pr_20040133343", me.Descripcion.AdaptarMySQL_String())
         R.add("pr_30040133341", me.CodigoDeCuenta.AdaptarMySQL_Integer())
         R.add("pr_10040133342", me.CodigoDeGrupo.AdaptarMySQL_Integer())
         R.add("pr_40040133341", me.CodigoDeCuentaFormatoDeTexto.AdaptarMySQL_String())
         If Me.ReferenciaGrupoNivel3 IsNot nothing then
           R.add("pr_10040143646",me.ReferenciaGrupoNivel3.ID.STR())
         Else
           R.add("pr_10040143646","")
         End if
         If Me.ReferenciaCuentaNivel1 IsNot nothing then
           R.add("pr_100401436410",me.ReferenciaCuentaNivel1.ID.STR())
         Else
           R.add("pr_100401436410","")
         End if
         R.add("pr_60040143624", me.Nivel.AdaptarMySQL_EnumNivelCuentaContableE())
         If Me.ReferenciaGrupoNivel1 IsNot nothing then
           R.add("pr_10040143647",me.ReferenciaGrupoNivel1.ID.STR())
         Else
           R.add("pr_10040143647","")
         End if
         R.add("pr_10040143645", me.CodigoGrupoNivel1.AdaptarMySQL_Integer())
         R.add("pr_10040143643", me.CodigoGrupoNivel3.AdaptarMySQL_Integer())
         R.add("pr_100401436411", me.CodigoCuentaNivel1.AdaptarMySQL_Integer())
         If Me.ReferenciaGrupoNivel2 IsNot nothing then
           R.add("pr_10040143648",me.ReferenciaGrupoNivel2.ID.STR())
         Else
           R.add("pr_10040143648","")
         End if
         If Me.ReferenciaCuentaNivel2 IsNot nothing then
           R.add("pr_20040143647",me.ReferenciaCuentaNivel2.ID.STR())
         Else
           R.add("pr_20040143647","")
         End if
         If Me.ReferenciaSubcuenta IsNot nothing then
           R.add("pr_40040143651",me.ReferenciaSubcuenta.ID.STR())
         Else
           R.add("pr_40040143651","")
         End if
         R.add("pr_10040143644", me.CodigoGrupoNivel2.AdaptarMySQL_Integer())
         R.add("pr_20040143643", me.CodigoSubcuenta.AdaptarMySQL_Integer())
         R.add("pr_20040143642", me.CodigoCuentaNivel2.AdaptarMySQL_Integer())
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
      Public Class CCObsoleto_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
        Public ReadOnly property MultiplicadorSaldo As Integer
            get
                return me.GetValue_Int("pr_60040136482")
            End Get   
        End Property
          Public property Naturaleza__Int as Integer
            get
                return me.GetValue_Int("pr_60040136481")
            End Get
            Set(value as Integer)
                me.SetValue_Int("pr_60040136481", value)
            End Set
          End Property
          Public property Naturaleza As EnumNaturalezaDeCuentaE
            get
                return me.GetValue_Int("pr_60040136481")
            End Get
            Set(value As EnumNaturalezaDeCuentaE)
                me.SetValue_Int("pr_60040136481", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_500401333339")
            End Get   
        End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_500401333338")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_500401333338", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_500401333334")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_500401333334", value)
            End Set
          End Property
        Public ReadOnly property HoraLocal As DateTime
            get
                return me.GetValue_DateTime("pr_500401333336")
            End Get   
        End Property
        Public ReadOnly property CodigoDeGrupoFormatoDeTexto As String
            get
                return me.GetValue_String("pr_10040133364")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_500401333345")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_500401333345", value)
            End Set
          End Property
          Public property ReferenciaGrupo As Guid
            get
                return me.GetValue_Guid("pr_10040133343")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_10040133343", value)
            End Set
          End Property
          Public property Descripcion As String
            get
                return me.GetValue_String("pr_20040133343")
            End Get
            Set(value As String)
                me.SetValue_String("pr_20040133343", value)
            End Set
          End Property
          Public property CodigoDeCuenta As Integer
            get
                return me.GetValue_Int("pr_30040133341")
            End Get
            Set(value As Integer)
                me.SetValue_Int("pr_30040133341", value)
            End Set
          End Property
        Public ReadOnly property CodigoDeGrupo As Integer
            get
                return me.GetValue_Int("pr_10040133342")
            End Get   
        End Property
        Public ReadOnly property CodigoDeCuentaFormatoDeTexto As String
            get
                return me.GetValue_String("pr_40040133341")
            End Get   
        End Property
          Public property ReferenciaGrupoNivel3 As Guid
            get
                return me.GetValue_Guid("pr_10040143646")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_10040143646", value)
            End Set
          End Property
          Public property ReferenciaCuentaNivel1 As Guid
            get
                return me.GetValue_Guid("pr_100401436410")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_100401436410", value)
            End Set
          End Property
          Public property Nivel__Int as Integer
            get
                return me.GetValue_Int("pr_60040143624")
            End Get
            Set(value as Integer)
                me.SetValue_Int("pr_60040143624", value)
            End Set
          End Property
          Public property Nivel As EnumNivelCuentaContableE
            get
                return me.GetValue_Int("pr_60040143624")
            End Get
            Set(value As EnumNivelCuentaContableE)
                me.SetValue_Int("pr_60040143624", value)
            End Set
          End Property
          Public property ReferenciaGrupoNivel1 As Guid
            get
                return me.GetValue_Guid("pr_10040143647")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_10040143647", value)
            End Set
          End Property
        Public ReadOnly property CodigoGrupoNivel1 As Integer
            get
                return me.GetValue_Int("pr_10040143645")
            End Get   
        End Property
        Public ReadOnly property CodigoGrupoNivel3 As Integer
            get
                return me.GetValue_Int("pr_10040143643")
            End Get   
        End Property
        Public ReadOnly property CodigoCuentaNivel1 As Integer
            get
                return me.GetValue_Int("pr_100401436411")
            End Get   
        End Property
          Public property ReferenciaGrupoNivel2 As Guid
            get
                return me.GetValue_Guid("pr_10040143648")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_10040143648", value)
            End Set
          End Property
          Public property ReferenciaCuentaNivel2 As Guid
            get
                return me.GetValue_Guid("pr_20040143647")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_20040143647", value)
            End Set
          End Property
          Public property ReferenciaSubcuenta As Guid
            get
                return me.GetValue_Guid("pr_40040143651")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_40040143651", value)
            End Set
          End Property
        Public ReadOnly property CodigoGrupoNivel2 As Integer
            get
                return me.GetValue_Int("pr_10040143644")
            End Get   
        End Property
        Public ReadOnly property CodigoSubcuenta As Integer
            get
                return me.GetValue_Int("pr_20040143643")
            End Get   
        End Property
        Public ReadOnly property CodigoCuentaNivel2 As Integer
            get
                return me.GetValue_Int("pr_20040143642")
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
