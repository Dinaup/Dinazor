   Imports System.ComponentModel
   Imports DinaNETCore
   Imports DinaNETCore.APID
Partial Public Class SeccionesD
  Public Class CuadroDeCuentasD
      Public Shared _SeccionID As String = "ba5315ec-72b7-4795-b612-9f1fdf299635"
      Public Shared _SeccionIDGUID As New Guid("ba5315ec-72b7-4795-b612-9f1fdf299635")
      Public Shared Async Function ConsultarDatos_Async(Parametros As SeccionConsultaParametrosC) As Task(Of List(Of CuadroDeCuentasC )) 
          Dim R As New List(Of CuadroDeCuentasC )  
          Dim d = Await Parametros.DinaupSesion.ConexionServidor.Funcion_Datos_Recibir_Async(CuadroDeCuentasES._SeccionID, False, Parametros) 
          If d.Datos.TieneDatos Then 
              For Each Actual In d.Datos 
                  Dim Valores_Listador = Actual.Value.Item1
                  Dim Obj_Listador As New CuadroDeCuentasC 
                  Obj_Listador.CargarDatos(Valores_Listador) 
                  Obj_Listador.CargaInterna(Actual.Value)
                  R.Add(Obj_Listador) 
              Next 
          End If 
          Return R 
      End Function 
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As CuadroDeCuentasC, Optional CampoWhere$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Return Await DatosGuardar_Async(DinaupSesion, New List(Of CuadroDeCuentasC)({DAtos}), CampoWhere )
      End Function
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As List(Of CuadroDeCuentasC), Optional CampoWhere$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Dim Importar As New List(Of DinaupAPI_ImportacionProcesableC)
          For Each Actual In DAtos 
              Dim RegistroActual = New DinaupAPI_ImportacionProcesableC() 
               RegistroActual.dinaup_listador_datos = Actual.ToDic 
               Importar.Add(RegistroActual)  
          Next 
          Return Await DinaupSesion.ConexionServidor.Funcion_Importar_Ejecutar_Async(DinaupSesion, CuadroDeCuentasES._SeccionID, Importar, CampoWhere, "") 
      End Function
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As CuadroDeCuentas_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, CuadroDeCuentasES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New CuadroDeCuentas_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As CuadroDeCuentas_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, CuadroDeCuentasES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New CuadroDeCuentas_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class CuadroDeCuentasES
          Public shared _SeccionID as Guid = New Guid("ba5315ec-72b7-4795-b612-9f1fdf299635")
          Public shared _Tabla$ = "tpr_50040132181"
      Public Shared ReferenciaDestinador$ = "pr_50040132181015"
      Public Shared ReferenciaAutorDelAlta$ = "pr_50040132181010"
      Public Shared ExportarEnModulos$ = "pr_50040132181013"
      Public Shared HoraLocal$ = "pr_50040132181012"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_50040132181021"
      Public Shared CodigoDeCuenta$ = "pr_60040132382"
      Public Shared FechaAlta_UTC$ = "pr_50040132181014"
      Public Shared EntidadRelacionadaTieneAccesoWeb$ = "pr_60040132393"
      Public Shared CodigoDeCuentaFormatoTexto$ = "pr_20040132811"
      Public Shared ReferenciaEntidadRelacionada$ = "pr_60040132392"
      Public Shared CodigoCuentaSuperiorNivel4Obsoleto$ = "pr_30040133312"
      Public Shared ReferenciaCuentaObsoletaObsoleto$ = "pr_60040133332"
      Public Shared ReferenciaGrupoObsoleto$ = "pr_60040133333"
      Public Shared CodigoDeCuentaFormatoTextoObsoleto$ = "pr_40040133343"
      Public Shared CodigoDeGrupoObsoleto$ = "pr_60040133334"
      Public Shared CodigoDeGrupoFormatoTexto$ = "pr_40040133342"
      Public Shared Descripcion$ = "pr_20040133344"
      Public Shared ReferenciaCuentaSuperiorNivel1$ = "pr_10040143601003"
      Public Shared ReferenciaCuentaSuperiorNivel6Obsoleto$ = "pr_30040143603"
      Public Shared ReferenciaCuentaSuperiorNivel3Obsoleto$ = "pr_20040143601005"
      Public Shared CodigoDeCuentaFinDeRango$ = "pr_40040143603"
      Public Shared Tipo$ = "pr_20040143881"
      Public Shared CodigoCuentaSuperiorNivel1Obsoleto$ = "pr_30040143606"
      Public Shared CodigoCuentaSuperiorNivel2Obsoleto$ = "pr_30040143607"
      Public Shared CodigoCuentaSuperiorNivel3Obsoleto$ = "pr_30040143608"
      Public Shared ReferenciaCuentaSuperiorNivel2Obsoleto$ = "pr_10040143601004"
      Public Shared ReferenciaCuentaSuperiorNivel5Obsoleto$ = "pr_30040143601"
      Public Shared CodigoDeCuentaInicioDeRango$ = "pr_40040143601"
      Public Shared SePuedenRealizarAsientosSobreEstaCuenta$ = "pr_50040143921"
      Public Shared ReferenciaGrupoPrincipal$ = "pr_20040144082"
      Public Shared ColorIdentificativo$ = "pr_20040144083"
      Public Shared UtilizarCriterioDeIdentificacionEnCuentasDeNivelesInferiores$ = "pr_30040144083"
      Public Shared ReferenciaIcono$ = "pr_20040144084"
      Public Shared ReferenciaCuentaSuperiorNivel4Obsoleto$ = "pr_30040144356"
      Public Shared Titulo$ = "pr_10040173141001"
      Public Shared ReferenciaPlanContableObsoleto$ = "pr_40040180101"
      Public Shared EmpresaPlanContableObsoletoTieneAccesoWeb$ = "pr_30040180124"
      Public Shared ReferenciaEmpresaPlanContableObsoleto$ = "pr_30040180123"
      Public Shared ActividadesAgricolasGanaderasYForestales$ = "pr_20040221382"
      Public Shared GastosFiscalmenteNoDeducibles$ = "pr_20040221384"
      Public Shared EnEspecie$ = "pr_50040221604"
      Public Shared ReferenciaArrendamientoObsoleto$ = "pr_40040244942"
      Public Shared ArrendamientoRetencionObsoletoPorciento$ = "pr_30040244951"
      Public Shared Niveles$ = "pr_30040270667"
      Public Shared IVAPorciento$ = "pr_10040402161"
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
      Public Class CuadroDeCuentasC
      Inherits Base_DatoC
          <DisplayName("Destinador")>
          Public Property ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaDestinador As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaDestinador"",""etiqueta"": ""Destinador"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""relacionesindirectas"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Destinador"",""descripcion"": """",""keyword"": ""ReferenciaDestinador"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaDestinador
          <DisplayName("Autor del alta")>
          Public Property ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaAutorDelAlta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaAutorDelAlta"",""etiqueta"": ""Autor del alta"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta"",""descripcion"": """",""keyword"": ""ReferenciaAutorDelAlta"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaAutorDelAlta
          <DisplayName("Hora local")>
          Public Property HoraLocal As DateTime?
          Public Shared ___HoraLocal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""HoraLocal"",""etiqueta"": ""Hora local"",""oculta"": false,""formato"": 8,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Hora local"",""descripcion"": """",""keyword"": ""HoraLocal"",""formato"": 8,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __HoraLocal As DinaNETCore.APID.DinaupAPI_CampoC = ___HoraLocal
          <DisplayName("Autor del alta Tiene Acceso web")>
          Public Property AutorDelAltaTieneAccesoWeb As Boolean
          Public Shared ___AutorDelAltaTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AutorDelAltaTieneAccesoWeb"",""etiqueta"": ""Autor del alta Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta Tiene Acceso web"",""descripcion"": """",""keyword"": ""AutorDelAltaTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AutorDelAltaTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___AutorDelAltaTieneAccesoWeb
          <DisplayName("Código de cuenta")>
          Public Property CodigoDeCuenta As Integer
          Public Shared ___CodigoDeCuenta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CodigoDeCuenta"",""etiqueta"": ""Código de cuenta"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 54,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": false,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Código de cuenta"",""descripcion"": """",""keyword"": ""CodigoDeCuenta"",""formato"": 2,""rol"": 54,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CodigoDeCuenta As DinaNETCore.APID.DinaupAPI_CampoC = ___CodigoDeCuenta
          <DisplayName("Fecha Alta del registro")>
          Public Property FechaAlta_UTC As Date?
          Public Shared ___FechaAlta_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaAlta_UTC"",""etiqueta"": ""Fecha Alta del registro"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Alta del registro"",""descripcion"": """",""keyword"": ""FechaAlta_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaAlta_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaAlta_UTC
          <DisplayName("Entidad relacionada Tiene Acceso web")>
          Public Property EntidadRelacionadaTieneAccesoWeb As Boolean
          Public Shared ___EntidadRelacionadaTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EntidadRelacionadaTieneAccesoWeb"",""etiqueta"": ""Entidad relacionada Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Entidad relacionada Tiene Acceso web"",""descripcion"": """",""keyword"": ""EntidadRelacionadaTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EntidadRelacionadaTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___EntidadRelacionadaTieneAccesoWeb
          <DisplayName("Código de Cuenta (Formato texto)")>
          Public Property CodigoDeCuentaFormatoTexto As String
          Public Shared ___CodigoDeCuentaFormatoTexto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CodigoDeCuentaFormatoTexto"",""etiqueta"": ""Código de Cuenta (Formato texto)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 54,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Código de Cuenta (Formato texto)"",""descripcion"": """",""keyword"": ""CodigoDeCuentaFormatoTexto"",""formato"": 5,""rol"": 54,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CodigoDeCuentaFormatoTexto As DinaNETCore.APID.DinaupAPI_CampoC = ___CodigoDeCuentaFormatoTexto
          <DisplayName("Entidad relacionada")>
          Public Property ReferenciaEntidadRelacionada As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaEntidadRelacionada As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaEntidadRelacionada"",""etiqueta"": ""Entidad relacionada"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Entidad relacionada"",""descripcion"": """",""keyword"": ""ReferenciaEntidadRelacionada"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaEntidadRelacionada As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaEntidadRelacionada
          <DisplayName("Código (Cuenta Superior Nivel 4) (Obsoleto)")>
          Public Property CodigoCuentaSuperiorNivel4Obsoleto As Integer
          Public Shared ___CodigoCuentaSuperiorNivel4Obsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CodigoCuentaSuperiorNivel4Obsoleto"",""etiqueta"": ""Código (Cuenta Superior Nivel 4) (Obsoleto)"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Código (Cuenta Superior Nivel 4) (Obsoleto)"",""descripcion"": """",""keyword"": ""CodigoCuentaSuperiorNivel4Obsoleto"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CodigoCuentaSuperiorNivel4Obsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___CodigoCuentaSuperiorNivel4Obsoleto
          <DisplayName("Cuenta (Obsoleta) (Obsoleto)")>
          Public Property ReferenciaCuentaObsoletaObsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaCuentaObsoletaObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaCuentaObsoletaObsoleto"",""etiqueta"": ""Cuenta (Obsoleta) (Obsoleto)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""aed7e97f-92e5-4aa8-884c-2a1f0f6df85f"",""titulo"": ""Base - CC (Obsoleto)"",""iconoid"": ""79445811-9f6d-4013-bb0a-1e3679283474"",""etiquetasingular"": ""CC"",""etiquetaplural"": ""CCs"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""aed7e97f-92e5-4aa8-884c-2a1f0f6df85f"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cuenta (Obsoleta) (Obsoleto)"",""descripcion"": """",""keyword"": ""ReferenciaCuentaObsoletaObsoleto"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaCuentaObsoletaObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaCuentaObsoletaObsoleto
          <DisplayName("Grupo (Obsoleto)")>
          Public Property ReferenciaGrupoObsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaGrupoObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaGrupoObsoleto"",""etiqueta"": ""Grupo (Obsoleto)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""a979af7f-7763-4e7f-a9ce-ef1c555ae222"",""titulo"": ""Base - Grupos contables"",""iconoid"": ""5f43e14d-d3ba-4c24-a0b0-e2f605ada71f"",""etiquetasingular"": ""Grupo contable"",""etiquetaplural"": ""Grupos contables"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""a979af7f-7763-4e7f-a9ce-ef1c555ae222"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Grupo (Obsoleto)"",""descripcion"": """",""keyword"": ""ReferenciaGrupoObsoleto"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaGrupoObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaGrupoObsoleto
          <DisplayName("Código de cuenta (Formato texto) (Obsoleto)")>
          Public Property CodigoDeCuentaFormatoTextoObsoleto As String
          Public Shared ___CodigoDeCuentaFormatoTextoObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CodigoDeCuentaFormatoTextoObsoleto"",""etiqueta"": ""Código de cuenta (Formato texto) (Obsoleto)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Código de cuenta (Formato texto) (Obsoleto)"",""descripcion"": """",""keyword"": ""CodigoDeCuentaFormatoTextoObsoleto"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CodigoDeCuentaFormatoTextoObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___CodigoDeCuentaFormatoTextoObsoleto
          <DisplayName("Código de grupo (Obsoleto)")>
          Public Property CodigoDeGrupoObsoleto As Integer
          Public Shared ___CodigoDeGrupoObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CodigoDeGrupoObsoleto"",""etiqueta"": ""Código de grupo (Obsoleto)"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Código de grupo (Obsoleto)"",""descripcion"": """",""keyword"": ""CodigoDeGrupoObsoleto"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CodigoDeGrupoObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___CodigoDeGrupoObsoleto
          <DisplayName("Código de grupo (Formato texto)")>
          Public Property CodigoDeGrupoFormatoTexto As String
          Public Shared ___CodigoDeGrupoFormatoTexto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CodigoDeGrupoFormatoTexto"",""etiqueta"": ""Código de grupo (Formato texto)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Código de grupo (Formato texto)"",""descripcion"": """",""keyword"": ""CodigoDeGrupoFormatoTexto"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CodigoDeGrupoFormatoTexto As DinaNETCore.APID.DinaupAPI_CampoC = ___CodigoDeGrupoFormatoTexto
          <DisplayName("Descripción")>
          Public Property Descripcion As String
          Public Shared ___Descripcion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Descripcion"",""etiqueta"": ""Descripción"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 51,""decimales"": ""0"",""multilinea"": true,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descripción"",""descripcion"": """",""keyword"": ""Descripcion"",""formato"": 5,""rol"": 51,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Descripcion As DinaNETCore.APID.DinaupAPI_CampoC = ___Descripcion
          <DisplayName("Cuenta Superior Nivel 1")>
          Public Property ReferenciaCuentaSuperiorNivel1 As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaCuentaSuperiorNivel1 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaCuentaSuperiorNivel1"",""etiqueta"": ""Cuenta Superior Nivel 1"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c1578f25-c397-4882-a252-52b5fe65731c"",""titulo"": ""Base - Cuadro de cuentas"",""iconoid"": ""56e95fca-1432-4283-b4a2-1336964a155f"",""etiquetasingular"": ""Cuadro de cuenta"",""etiquetaplural"": ""Cuadro de cuentas"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""c1578f25-c397-4882-a252-52b5fe65731c"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cuenta Superior Nivel 1"",""descripcion"": """",""keyword"": ""ReferenciaCuentaSuperiorNivel1"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaCuentaSuperiorNivel1 As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaCuentaSuperiorNivel1
          <DisplayName("Cuenta Superior Nivel 6 (Obsoleto)")>
          Public Property ReferenciaCuentaSuperiorNivel6Obsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaCuentaSuperiorNivel6Obsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaCuentaSuperiorNivel6Obsoleto"",""etiqueta"": ""Cuenta Superior Nivel 6 (Obsoleto)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c1578f25-c397-4882-a252-52b5fe65731c"",""titulo"": ""Base - Cuadro de cuentas"",""iconoid"": ""56e95fca-1432-4283-b4a2-1336964a155f"",""etiquetasingular"": ""Cuadro de cuenta"",""etiquetaplural"": ""Cuadro de cuentas"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""c1578f25-c397-4882-a252-52b5fe65731c"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cuenta Superior Nivel 6 (Obsoleto)"",""descripcion"": """",""keyword"": ""ReferenciaCuentaSuperiorNivel6Obsoleto"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaCuentaSuperiorNivel6Obsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaCuentaSuperiorNivel6Obsoleto
          <DisplayName("Cuenta Superior Nivel 3 (Obsoleto)")>
          Public Property ReferenciaCuentaSuperiorNivel3Obsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaCuentaSuperiorNivel3Obsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaCuentaSuperiorNivel3Obsoleto"",""etiqueta"": ""Cuenta Superior Nivel 3 (Obsoleto)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c1578f25-c397-4882-a252-52b5fe65731c"",""titulo"": ""Base - Cuadro de cuentas"",""iconoid"": ""56e95fca-1432-4283-b4a2-1336964a155f"",""etiquetasingular"": ""Cuadro de cuenta"",""etiquetaplural"": ""Cuadro de cuentas"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""c1578f25-c397-4882-a252-52b5fe65731c"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cuenta Superior Nivel 3 (Obsoleto)"",""descripcion"": """",""keyword"": ""ReferenciaCuentaSuperiorNivel3Obsoleto"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaCuentaSuperiorNivel3Obsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaCuentaSuperiorNivel3Obsoleto
          <DisplayName("Código de cuenta fin de rango")>
          Public Property CodigoDeCuentaFinDeRango As Integer
          Public Shared ___CodigoDeCuentaFinDeRango As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CodigoDeCuentaFinDeRango"",""etiqueta"": ""Código de cuenta fin de rango"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Código de cuenta fin de rango"",""descripcion"": """",""keyword"": ""CodigoDeCuentaFinDeRango"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CodigoDeCuentaFinDeRango As DinaNETCore.APID.DinaupAPI_CampoC = ___CodigoDeCuentaFinDeRango
          <DisplayName("Tipo")>
          Public Property Tipo As EnumNivelCuentaContableE
          Public Shared ___Tipo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Tipo"",""etiqueta"": ""Tipo"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 58,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": false,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [0,1,2,3,4,5,6,7],""predefinidos_textos"": [""Indefinido"",""Grupo nivel 1"",""(x) Subgrupo nivel 2"",""(x) Subgrupo nivel 3"",""Cuenta"",""(x) Subcuenta 1"",""(x) Subcuenta 2"",""Subcuenta""],""predefinidos_iconos"": [""https://cdn.dinaup.com/ico/enums/58_0.png"",""https://cdn.dinaup.com/ico/enums/58_1.png"",""https://cdn.dinaup.com/ico/enums/58_2.png"",""https://cdn.dinaup.com/ico/enums/58_3.png"",""https://cdn.dinaup.com/ico/enums/58_4.png"",""https://cdn.dinaup.com/ico/enums/58_5.png"",""https://cdn.dinaup.com/ico/enums/58_6.png"",""https://cdn.dinaup.com/ico/enums/58_7.png""],""filtro"": {""titulo"": ""Tipo"",""descripcion"": """",""keyword"": ""Tipo"",""formato"": 2,""rol"": 58,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false,""enumeracion"": {""titulo"": ""Enum - Nivel Cuenta Contable"", ""valores"": [{""valor"": 0, ""titulo"": ""Indefinido""},{""valor"": 1, ""titulo"": ""Grupo nivel 1""},{""valor"": 2, ""titulo"": ""(x) Subgrupo nivel 2""},{""valor"": 3, ""titulo"": ""(x) Subgrupo nivel 3""},{""valor"": 4, ""titulo"": ""Cuenta""},{""valor"": 5, ""titulo"": ""(x) Subcuenta 1""},{""valor"": 6, ""titulo"": ""(x) Subcuenta 2""},{""valor"": 7, ""titulo"": ""Subcuenta""}]}},""solovalorespredefinidos"": true}")
          Public  __Tipo As DinaNETCore.APID.DinaupAPI_CampoC = ___Tipo
          <DisplayName("Código (Cuenta Superior Nivel 1) (Obsoleto)")>
          Public Property CodigoCuentaSuperiorNivel1Obsoleto As Integer
          Public Shared ___CodigoCuentaSuperiorNivel1Obsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CodigoCuentaSuperiorNivel1Obsoleto"",""etiqueta"": ""Código (Cuenta Superior Nivel 1) (Obsoleto)"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Código (Cuenta Superior Nivel 1) (Obsoleto)"",""descripcion"": """",""keyword"": ""CodigoCuentaSuperiorNivel1Obsoleto"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CodigoCuentaSuperiorNivel1Obsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___CodigoCuentaSuperiorNivel1Obsoleto
          <DisplayName("Código (Cuenta Superior Nivel 2) (Obsoleto)")>
          Public Property CodigoCuentaSuperiorNivel2Obsoleto As Integer
          Public Shared ___CodigoCuentaSuperiorNivel2Obsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CodigoCuentaSuperiorNivel2Obsoleto"",""etiqueta"": ""Código (Cuenta Superior Nivel 2) (Obsoleto)"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Código (Cuenta Superior Nivel 2) (Obsoleto)"",""descripcion"": """",""keyword"": ""CodigoCuentaSuperiorNivel2Obsoleto"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CodigoCuentaSuperiorNivel2Obsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___CodigoCuentaSuperiorNivel2Obsoleto
          <DisplayName("Código (Cuenta Superior Nivel 3) (Obsoleto)")>
          Public Property CodigoCuentaSuperiorNivel3Obsoleto As Integer
          Public Shared ___CodigoCuentaSuperiorNivel3Obsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CodigoCuentaSuperiorNivel3Obsoleto"",""etiqueta"": ""Código (Cuenta Superior Nivel 3) (Obsoleto)"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Código (Cuenta Superior Nivel 3) (Obsoleto)"",""descripcion"": """",""keyword"": ""CodigoCuentaSuperiorNivel3Obsoleto"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CodigoCuentaSuperiorNivel3Obsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___CodigoCuentaSuperiorNivel3Obsoleto
          <DisplayName("Cuenta Superior Nivel 2 (Obsoleto)")>
          Public Property ReferenciaCuentaSuperiorNivel2Obsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaCuentaSuperiorNivel2Obsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaCuentaSuperiorNivel2Obsoleto"",""etiqueta"": ""Cuenta Superior Nivel 2 (Obsoleto)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c1578f25-c397-4882-a252-52b5fe65731c"",""titulo"": ""Base - Cuadro de cuentas"",""iconoid"": ""56e95fca-1432-4283-b4a2-1336964a155f"",""etiquetasingular"": ""Cuadro de cuenta"",""etiquetaplural"": ""Cuadro de cuentas"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""c1578f25-c397-4882-a252-52b5fe65731c"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cuenta Superior Nivel 2 (Obsoleto)"",""descripcion"": """",""keyword"": ""ReferenciaCuentaSuperiorNivel2Obsoleto"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaCuentaSuperiorNivel2Obsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaCuentaSuperiorNivel2Obsoleto
          <DisplayName("Cuenta Superior Nivel 5 (Obsoleto)")>
          Public Property ReferenciaCuentaSuperiorNivel5Obsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaCuentaSuperiorNivel5Obsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaCuentaSuperiorNivel5Obsoleto"",""etiqueta"": ""Cuenta Superior Nivel 5 (Obsoleto)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c1578f25-c397-4882-a252-52b5fe65731c"",""titulo"": ""Base - Cuadro de cuentas"",""iconoid"": ""56e95fca-1432-4283-b4a2-1336964a155f"",""etiquetasingular"": ""Cuadro de cuenta"",""etiquetaplural"": ""Cuadro de cuentas"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""c1578f25-c397-4882-a252-52b5fe65731c"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cuenta Superior Nivel 5 (Obsoleto)"",""descripcion"": """",""keyword"": ""ReferenciaCuentaSuperiorNivel5Obsoleto"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaCuentaSuperiorNivel5Obsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaCuentaSuperiorNivel5Obsoleto
          <DisplayName("Código de cuenta inicio de rango")>
          Public Property CodigoDeCuentaInicioDeRango As Integer
          Public Shared ___CodigoDeCuentaInicioDeRango As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CodigoDeCuentaInicioDeRango"",""etiqueta"": ""Código de cuenta inicio de rango"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Código de cuenta inicio de rango"",""descripcion"": """",""keyword"": ""CodigoDeCuentaInicioDeRango"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CodigoDeCuentaInicioDeRango As DinaNETCore.APID.DinaupAPI_CampoC = ___CodigoDeCuentaInicioDeRango
          <DisplayName("Se pueden realizar asientos sobre esta cuenta")>
          Public Property SePuedenRealizarAsientosSobreEstaCuenta As Boolean
          Public Shared ___SePuedenRealizarAsientosSobreEstaCuenta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""SePuedenRealizarAsientosSobreEstaCuenta"",""etiqueta"": ""Se pueden realizar asientos sobre esta cuenta"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Se pueden realizar asientos sobre esta cuenta"",""descripcion"": """",""keyword"": ""SePuedenRealizarAsientosSobreEstaCuenta"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __SePuedenRealizarAsientosSobreEstaCuenta As DinaNETCore.APID.DinaupAPI_CampoC = ___SePuedenRealizarAsientosSobreEstaCuenta
          <DisplayName("Grupo principal")>
          Public Property ReferenciaGrupoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaGrupoPrincipal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaGrupoPrincipal"",""etiqueta"": ""Grupo principal"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c1578f25-c397-4882-a252-52b5fe65731c"",""titulo"": ""Base - Cuadro de cuentas"",""iconoid"": ""56e95fca-1432-4283-b4a2-1336964a155f"",""etiquetasingular"": ""Cuadro de cuenta"",""etiquetaplural"": ""Cuadro de cuentas"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""c1578f25-c397-4882-a252-52b5fe65731c"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Grupo principal"",""descripcion"": """",""keyword"": ""ReferenciaGrupoPrincipal"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaGrupoPrincipal As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaGrupoPrincipal
          <DisplayName("Color identificativo")>
          Public Property ColorIdentificativo As String
          Public Shared ___ColorIdentificativo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ColorIdentificativo"",""etiqueta"": ""Color identificativo"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 29,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Color identificativo"",""descripcion"": """",""keyword"": ""ColorIdentificativo"",""formato"": 5,""rol"": 29,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ColorIdentificativo As DinaNETCore.APID.DinaupAPI_CampoC = ___ColorIdentificativo
          <Description("Cuando esta opción está activa las cuenta de nivel inferior heredan las propiedades de identificación visual.")>
          <DisplayName("Utilizar criterio de identificación en cuentas de niveles inferiores")>
          Public Property UtilizarCriterioDeIdentificacionEnCuentasDeNivelesInferiores As Boolean
          Public Shared ___UtilizarCriterioDeIdentificacionEnCuentasDeNivelesInferiores As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""UtilizarCriterioDeIdentificacionEnCuentasDeNivelesInferiores"",""etiqueta"": ""Utilizar criterio de identificación en cuentas de niveles inferiores"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Utilizar criterio de identificación en cuentas de niveles inferiores"",""descripcion"": """",""keyword"": ""UtilizarCriterioDeIdentificacionEnCuentasDeNivelesInferiores"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __UtilizarCriterioDeIdentificacionEnCuentasDeNivelesInferiores As DinaNETCore.APID.DinaupAPI_CampoC = ___UtilizarCriterioDeIdentificacionEnCuentasDeNivelesInferiores
          <DisplayName("Icono")>
          Public Property ReferenciaIcono As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaIcono As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaIcono"",""etiqueta"": ""Icono"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""imagenes"",""rol"": 7,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Icono"",""descripcion"": """",""keyword"": ""ReferenciaIcono"",""formato"": 9,""rol"": 7,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaIcono As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaIcono
          <DisplayName("Cuenta Superior Nivel 4 (Obsoleto)")>
          Public Property ReferenciaCuentaSuperiorNivel4Obsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaCuentaSuperiorNivel4Obsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaCuentaSuperiorNivel4Obsoleto"",""etiqueta"": ""Cuenta Superior Nivel 4 (Obsoleto)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c1578f25-c397-4882-a252-52b5fe65731c"",""titulo"": ""Base - Cuadro de cuentas"",""iconoid"": ""56e95fca-1432-4283-b4a2-1336964a155f"",""etiquetasingular"": ""Cuadro de cuenta"",""etiquetaplural"": ""Cuadro de cuentas"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""c1578f25-c397-4882-a252-52b5fe65731c"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cuenta Superior Nivel 4 (Obsoleto)"",""descripcion"": """",""keyword"": ""ReferenciaCuentaSuperiorNivel4Obsoleto"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaCuentaSuperiorNivel4Obsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaCuentaSuperiorNivel4Obsoleto
          <DisplayName("Título")>
          Public Property Titulo As String
          Public Shared ___Titulo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Titulo"",""etiqueta"": ""Título"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Título"",""descripcion"": """",""keyword"": ""Titulo"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Titulo As DinaNETCore.APID.DinaupAPI_CampoC = ___Titulo
          <DisplayName("Plan contable (Obsoleto)")>
          Public Property ReferenciaPlanContableObsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaPlanContableObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaPlanContableObsoleto"",""etiqueta"": ""Plan contable (Obsoleto)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""2c6bd0f7-cead-437f-a8ae-b4daa0219e32"",""titulo"": ""Base - Cuadros de cuentas oficiales"",""iconoid"": ""1879b6d0-dfd6-416e-a6f7-21468ad7d6ab"",""etiquetasingular"": ""Cuadro de cuenta oficial"",""etiquetaplural"": ""Cuadros de cuentas oficiales"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""2c6bd0f7-cead-437f-a8ae-b4daa0219e32"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Plan contable (Obsoleto)"",""descripcion"": """",""keyword"": ""ReferenciaPlanContableObsoleto"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaPlanContableObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaPlanContableObsoleto
          <DisplayName("Empresa Plan Contable (Obsoleto) Tiene Acceso web")>
          Public Property EmpresaPlanContableObsoletoTieneAccesoWeb As Boolean
          Public Shared ___EmpresaPlanContableObsoletoTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EmpresaPlanContableObsoletoTieneAccesoWeb"",""etiqueta"": ""Empresa Plan Contable (Obsoleto) Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empresa Plan Contable (Obsoleto) Tiene Acceso web"",""descripcion"": """",""keyword"": ""EmpresaPlanContableObsoletoTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EmpresaPlanContableObsoletoTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___EmpresaPlanContableObsoletoTieneAccesoWeb
          <DisplayName("Empresa Plan Contable (Obsoleto)")>
          Public Property ReferenciaEmpresaPlanContableObsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaEmpresaPlanContableObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaEmpresaPlanContableObsoleto"",""etiqueta"": ""Empresa Plan Contable (Obsoleto)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empresa Plan Contable (Obsoleto)"",""descripcion"": """",""keyword"": ""ReferenciaEmpresaPlanContableObsoleto"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaEmpresaPlanContableObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaEmpresaPlanContableObsoleto
          <DisplayName("Actividades agrícolas, ganaderas y forestales")>
          Public Property ActividadesAgricolasGanaderasYForestales As Boolean
          Public Shared ___ActividadesAgricolasGanaderasYForestales As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ActividadesAgricolasGanaderasYForestales"",""etiqueta"": ""Actividades agrícolas, ganaderas y forestales"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Actividades agrícolas, ganaderas y forestales"",""descripcion"": """",""keyword"": ""ActividadesAgricolasGanaderasYForestales"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ActividadesAgricolasGanaderasYForestales As DinaNETCore.APID.DinaupAPI_CampoC = ___ActividadesAgricolasGanaderasYForestales
          <DisplayName("Gastos fiscalmente no deducibles")>
          Public Property GastosFiscalmenteNoDeducibles As Boolean
          Public Shared ___GastosFiscalmenteNoDeducibles As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""GastosFiscalmenteNoDeducibles"",""etiqueta"": ""Gastos fiscalmente no deducibles"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Gastos fiscalmente no deducibles"",""descripcion"": """",""keyword"": ""GastosFiscalmenteNoDeducibles"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __GastosFiscalmenteNoDeducibles As DinaNETCore.APID.DinaupAPI_CampoC = ___GastosFiscalmenteNoDeducibles
          <DisplayName("En especie")>
          Public Property EnEspecie As Boolean
          Public Shared ___EnEspecie As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EnEspecie"",""etiqueta"": ""En especie"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""En especie"",""descripcion"": """",""keyword"": ""EnEspecie"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EnEspecie As DinaNETCore.APID.DinaupAPI_CampoC = ___EnEspecie
          <DisplayName("Arrendamiento (Obsoleto)")>
          Public Property ReferenciaArrendamientoObsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaArrendamientoObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaArrendamientoObsoleto"",""etiqueta"": ""Arrendamiento (Obsoleto)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""af0c264f-ce03-438c-8d6a-e8db65a35a09"",""titulo"": ""Base - Arrendamientos"",""iconoid"": ""d375c3af-9675-4a22-a6ae-8d6cad100b19"",""etiquetasingular"": ""Arrendamiento"",""etiquetaplural"": ""Arrendamientos"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""af0c264f-ce03-438c-8d6a-e8db65a35a09"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Arrendamiento (Obsoleto)"",""descripcion"": """",""keyword"": ""ReferenciaArrendamientoObsoleto"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaArrendamientoObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaArrendamientoObsoleto
          <DisplayName("Arrendamiento retención % (Obsoleto)")>
          Public Property ArrendamientoRetencionObsoletoPorciento As Decimal
          Public Shared ___ArrendamientoRetencionObsoletoPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ArrendamientoRetencionObsoletoPorciento"",""etiqueta"": ""Arrendamiento retención % (Obsoleto)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Arrendamiento retención % (Obsoleto)"",""descripcion"": """",""keyword"": ""ArrendamientoRetencionObsoletoPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ArrendamientoRetencionObsoletoPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___ArrendamientoRetencionObsoletoPorciento
          <DisplayName("Niveles")>
          Public Property Niveles As Integer
          Public Shared ___Niveles As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Niveles"",""etiqueta"": ""Niveles"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Niveles"",""descripcion"": """",""keyword"": ""Niveles"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Niveles As DinaNETCore.APID.DinaupAPI_CampoC = ___Niveles
          <DisplayName("IVA %")>
          Public Property IVAPorciento As Decimal
          Public Shared ___IVAPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""IVAPorciento"",""etiqueta"": ""IVA %"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""IVA %"",""descripcion"": """",""keyword"": ""IVAPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __IVAPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___IVAPorciento
          <ReadOnlyAttribute(True)>
          <DisplayName("ID")>
          Public Property ID As Guid
          Public Shared ___ID As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": true,""eseliminado"": false,""keyword"": ""ID"",""etiqueta"": ""ID"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""ba5315ec-72b7-4795-b612-9f1fdf299635"",""titulo"": ""Cuadro de cuentas"",""iconoid"": ""56e95fca-1432-4283-b4a2-1336964a155f"",""etiquetasingular"": ""Cuadro de cuenta"",""etiquetaplural"": ""Cuadro de cuentas"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""ba5315ec-72b7-4795-b612-9f1fdf299635"",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""ID"",""descripcion"": """",""keyword"": ""ID"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
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
          me.ReferenciaDestinador = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_50040132181015"), _Datos.Leer_String("pr_50040132181015.nombre"))
          me.ReferenciaAutorDelAlta = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_50040132181010"), _Datos.Leer_String("pr_50040132181010.nombre"))
          me.HoraLocal = _Datos.Leer_Time_Nulable("pr_50040132181012")
          me.AutorDelAltaTieneAccesoWeb = _Datos.Leer_Boolean("pr_50040132181021")
          me.CodigoDeCuenta = _Datos.Leer_Integer("pr_60040132382")
          me.FechaAlta_UTC = _Datos.Leer_DateTime_Nulable("pr_50040132181014")
          me.EntidadRelacionadaTieneAccesoWeb = _Datos.Leer_Boolean("pr_60040132393")
          me.CodigoDeCuentaFormatoTexto = _Datos.Leer_String("pr_20040132811")
          me.ReferenciaEntidadRelacionada = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_60040132392"), _Datos.Leer_String("pr_60040132392.nombre"))
          me.CodigoCuentaSuperiorNivel4Obsoleto = _Datos.Leer_Integer("pr_30040133312")
          me.ReferenciaCuentaObsoletaObsoleto = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_60040133332"), _Datos.Leer_String("pr_60040133332.nombre"))
          me.ReferenciaGrupoObsoleto = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_60040133333"), _Datos.Leer_String("pr_60040133333.nombre"))
          me.CodigoDeCuentaFormatoTextoObsoleto = _Datos.Leer_String("pr_40040133343")
          me.CodigoDeGrupoObsoleto = _Datos.Leer_Integer("pr_60040133334")
          me.CodigoDeGrupoFormatoTexto = _Datos.Leer_String("pr_40040133342")
          me.Descripcion = _Datos.Leer_String("pr_20040133344")
          me.ReferenciaCuentaSuperiorNivel1 = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_10040143601003"), _Datos.Leer_String("pr_10040143601003.nombre"))
          me.ReferenciaCuentaSuperiorNivel6Obsoleto = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_30040143603"), _Datos.Leer_String("pr_30040143603.nombre"))
          me.ReferenciaCuentaSuperiorNivel3Obsoleto = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_20040143601005"), _Datos.Leer_String("pr_20040143601005.nombre"))
          me.CodigoDeCuentaFinDeRango = _Datos.Leer_Integer("pr_40040143603")
          me.Tipo = _Datos.Leer_EnumNivelCuentaContableE("pr_20040143881")
          me.CodigoCuentaSuperiorNivel1Obsoleto = _Datos.Leer_Integer("pr_30040143606")
          me.CodigoCuentaSuperiorNivel2Obsoleto = _Datos.Leer_Integer("pr_30040143607")
          me.CodigoCuentaSuperiorNivel3Obsoleto = _Datos.Leer_Integer("pr_30040143608")
          me.ReferenciaCuentaSuperiorNivel2Obsoleto = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_10040143601004"), _Datos.Leer_String("pr_10040143601004.nombre"))
          me.ReferenciaCuentaSuperiorNivel5Obsoleto = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_30040143601"), _Datos.Leer_String("pr_30040143601.nombre"))
          me.CodigoDeCuentaInicioDeRango = _Datos.Leer_Integer("pr_40040143601")
          me.SePuedenRealizarAsientosSobreEstaCuenta = _Datos.Leer_Boolean("pr_50040143921")
          me.ReferenciaGrupoPrincipal = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_20040144082"), _Datos.Leer_String("pr_20040144082.nombre"))
          me.ColorIdentificativo = _Datos.Leer_String("pr_20040144083")
          me.UtilizarCriterioDeIdentificacionEnCuentasDeNivelesInferiores = _Datos.Leer_Boolean("pr_30040144083")
          me.ReferenciaIcono = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_20040144084"), _Datos.Leer_String("pr_20040144084.nombre"))
          me.ReferenciaCuentaSuperiorNivel4Obsoleto = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_30040144356"), _Datos.Leer_String("pr_30040144356.nombre"))
          me.Titulo = _Datos.Leer_String("pr_10040173141001")
          me.ReferenciaPlanContableObsoleto = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_40040180101"), _Datos.Leer_String("pr_40040180101.nombre"))
          me.EmpresaPlanContableObsoletoTieneAccesoWeb = _Datos.Leer_Boolean("pr_30040180124")
          me.ReferenciaEmpresaPlanContableObsoleto = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_30040180123"), _Datos.Leer_String("pr_30040180123.nombre"))
          me.ActividadesAgricolasGanaderasYForestales = _Datos.Leer_Boolean("pr_20040221382")
          me.GastosFiscalmenteNoDeducibles = _Datos.Leer_Boolean("pr_20040221384")
          me.EnEspecie = _Datos.Leer_Boolean("pr_50040221604")
          me.ReferenciaArrendamientoObsoleto = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_40040244942"), _Datos.Leer_String("pr_40040244942.nombre"))
          me.ArrendamientoRetencionObsoletoPorciento = _Datos.Leer_Decimal("pr_30040244951")
          me.Niveles = _Datos.Leer_Integer("pr_30040270667")
          me.IVAPorciento = _Datos.Leer_Decimal("pr_10040402161")
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
           R.add("pr_50040132181015",me.ReferenciaDestinador.ID.STR())
         Else
           R.add("pr_50040132181015","")
         End if
         If Me.ReferenciaAutorDelAlta IsNot nothing then
           R.add("pr_50040132181010",me.ReferenciaAutorDelAlta.ID.STR())
         Else
           R.add("pr_50040132181010","")
         End if
         R.add("pr_50040132181012", me.HoraLocal.AdaptarMySQL_Time_Nulable())
         R.add("pr_50040132181021", me.AutorDelAltaTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_60040132382", me.CodigoDeCuenta.AdaptarMySQL_Integer())
         R.add("pr_50040132181014", me.FechaAlta_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_60040132393", me.EntidadRelacionadaTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_20040132811", me.CodigoDeCuentaFormatoTexto.AdaptarMySQL_String())
         If Me.ReferenciaEntidadRelacionada IsNot nothing then
           R.add("pr_60040132392",me.ReferenciaEntidadRelacionada.ID.STR())
         Else
           R.add("pr_60040132392","")
         End if
         R.add("pr_30040133312", me.CodigoCuentaSuperiorNivel4Obsoleto.AdaptarMySQL_Integer())
         If Me.ReferenciaCuentaObsoletaObsoleto IsNot nothing then
           R.add("pr_60040133332",me.ReferenciaCuentaObsoletaObsoleto.ID.STR())
         Else
           R.add("pr_60040133332","")
         End if
         If Me.ReferenciaGrupoObsoleto IsNot nothing then
           R.add("pr_60040133333",me.ReferenciaGrupoObsoleto.ID.STR())
         Else
           R.add("pr_60040133333","")
         End if
         R.add("pr_40040133343", me.CodigoDeCuentaFormatoTextoObsoleto.AdaptarMySQL_String())
         R.add("pr_60040133334", me.CodigoDeGrupoObsoleto.AdaptarMySQL_Integer())
         R.add("pr_40040133342", me.CodigoDeGrupoFormatoTexto.AdaptarMySQL_String())
         R.add("pr_20040133344", me.Descripcion.AdaptarMySQL_String())
         If Me.ReferenciaCuentaSuperiorNivel1 IsNot nothing then
           R.add("pr_10040143601003",me.ReferenciaCuentaSuperiorNivel1.ID.STR())
         Else
           R.add("pr_10040143601003","")
         End if
         If Me.ReferenciaCuentaSuperiorNivel6Obsoleto IsNot nothing then
           R.add("pr_30040143603",me.ReferenciaCuentaSuperiorNivel6Obsoleto.ID.STR())
         Else
           R.add("pr_30040143603","")
         End if
         If Me.ReferenciaCuentaSuperiorNivel3Obsoleto IsNot nothing then
           R.add("pr_20040143601005",me.ReferenciaCuentaSuperiorNivel3Obsoleto.ID.STR())
         Else
           R.add("pr_20040143601005","")
         End if
         R.add("pr_40040143603", me.CodigoDeCuentaFinDeRango.AdaptarMySQL_Integer())
         R.add("pr_20040143881", me.Tipo.AdaptarMySQL_EnumNivelCuentaContableE())
         R.add("pr_30040143606", me.CodigoCuentaSuperiorNivel1Obsoleto.AdaptarMySQL_Integer())
         R.add("pr_30040143607", me.CodigoCuentaSuperiorNivel2Obsoleto.AdaptarMySQL_Integer())
         R.add("pr_30040143608", me.CodigoCuentaSuperiorNivel3Obsoleto.AdaptarMySQL_Integer())
         If Me.ReferenciaCuentaSuperiorNivel2Obsoleto IsNot nothing then
           R.add("pr_10040143601004",me.ReferenciaCuentaSuperiorNivel2Obsoleto.ID.STR())
         Else
           R.add("pr_10040143601004","")
         End if
         If Me.ReferenciaCuentaSuperiorNivel5Obsoleto IsNot nothing then
           R.add("pr_30040143601",me.ReferenciaCuentaSuperiorNivel5Obsoleto.ID.STR())
         Else
           R.add("pr_30040143601","")
         End if
         R.add("pr_40040143601", me.CodigoDeCuentaInicioDeRango.AdaptarMySQL_Integer())
         R.add("pr_50040143921", me.SePuedenRealizarAsientosSobreEstaCuenta.AdaptarMySQL_Boolean())
         If Me.ReferenciaGrupoPrincipal IsNot nothing then
           R.add("pr_20040144082",me.ReferenciaGrupoPrincipal.ID.STR())
         Else
           R.add("pr_20040144082","")
         End if
         R.add("pr_20040144083", me.ColorIdentificativo.AdaptarMySQL_String())
         R.add("pr_30040144083", me.UtilizarCriterioDeIdentificacionEnCuentasDeNivelesInferiores.AdaptarMySQL_Boolean())
         If Me.ReferenciaIcono IsNot nothing then
           R.add("pr_20040144084",me.ReferenciaIcono.ID.STR())
         Else
           R.add("pr_20040144084","")
         End if
         If Me.ReferenciaCuentaSuperiorNivel4Obsoleto IsNot nothing then
           R.add("pr_30040144356",me.ReferenciaCuentaSuperiorNivel4Obsoleto.ID.STR())
         Else
           R.add("pr_30040144356","")
         End if
         R.add("pr_10040173141001", me.Titulo.AdaptarMySQL_String())
         If Me.ReferenciaPlanContableObsoleto IsNot nothing then
           R.add("pr_40040180101",me.ReferenciaPlanContableObsoleto.ID.STR())
         Else
           R.add("pr_40040180101","")
         End if
         R.add("pr_30040180124", me.EmpresaPlanContableObsoletoTieneAccesoWeb.AdaptarMySQL_Boolean())
         If Me.ReferenciaEmpresaPlanContableObsoleto IsNot nothing then
           R.add("pr_30040180123",me.ReferenciaEmpresaPlanContableObsoleto.ID.STR())
         Else
           R.add("pr_30040180123","")
         End if
         R.add("pr_20040221382", me.ActividadesAgricolasGanaderasYForestales.AdaptarMySQL_Boolean())
         R.add("pr_20040221384", me.GastosFiscalmenteNoDeducibles.AdaptarMySQL_Boolean())
         R.add("pr_50040221604", me.EnEspecie.AdaptarMySQL_Boolean())
         If Me.ReferenciaArrendamientoObsoleto IsNot nothing then
           R.add("pr_40040244942",me.ReferenciaArrendamientoObsoleto.ID.STR())
         Else
           R.add("pr_40040244942","")
         End if
         R.add("pr_30040244951", me.ArrendamientoRetencionObsoletoPorciento.AdaptarMySQL_Decimal())
         R.add("pr_30040270667", me.Niveles.AdaptarMySQL_Integer())
         R.add("pr_10040402161", me.IVAPorciento.AdaptarMySQL_Decimal())
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
      Public Class CuadroDeCuentas_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_50040132181015")
            End Get   
        End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_50040132181010")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_50040132181010", value)
            End Set
          End Property
        Public ReadOnly property HoraLocal As DateTime
            get
                return me.GetValue_DateTime("pr_50040132181012")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_50040132181021")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_50040132181021", value)
            End Set
          End Property
          Public property CodigoDeCuenta As Integer
            get
                return me.GetValue_Int("pr_60040132382")
            End Get
            Set(value As Integer)
                me.SetValue_Int("pr_60040132382", value)
            End Set
          End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_50040132181014")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_50040132181014", value)
            End Set
          End Property
          Public property EntidadRelacionadaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_60040132393")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_60040132393", value)
            End Set
          End Property
          Public property CodigoDeCuentaFormatoTexto As String
            get
                return me.GetValue_String("pr_20040132811")
            End Get
            Set(value As String)
                me.SetValue_String("pr_20040132811", value)
            End Set
          End Property
          Public property ReferenciaEntidadRelacionada As Guid
            get
                return me.GetValue_Guid("pr_60040132392")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_60040132392", value)
            End Set
          End Property
        Public ReadOnly property CodigoCuentaSuperiorNivel4Obsoleto As Integer
            get
                return me.GetValue_Int("pr_30040133312")
            End Get   
        End Property
          Public property ReferenciaCuentaObsoletaObsoleto As Guid
            get
                return me.GetValue_Guid("pr_60040133332")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_60040133332", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaGrupoObsoleto As Guid
            get
                return me.GetValue_Guid("pr_60040133333")
            End Get   
        End Property
        Public ReadOnly property CodigoDeCuentaFormatoTextoObsoleto As String
            get
                return me.GetValue_String("pr_40040133343")
            End Get   
        End Property
        Public ReadOnly property CodigoDeGrupoObsoleto As Integer
            get
                return me.GetValue_Int("pr_60040133334")
            End Get   
        End Property
        Public ReadOnly property CodigoDeGrupoFormatoTexto As String
            get
                return me.GetValue_String("pr_40040133342")
            End Get   
        End Property
          Public property Descripcion As String
            get
                return me.GetValue_String("pr_20040133344")
            End Get
            Set(value As String)
                me.SetValue_String("pr_20040133344", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaCuentaSuperiorNivel1 As Guid
            get
                return me.GetValue_Guid("pr_10040143601003")
            End Get   
        End Property
        Public ReadOnly property ReferenciaCuentaSuperiorNivel6Obsoleto As Guid
            get
                return me.GetValue_Guid("pr_30040143603")
            End Get   
        End Property
        Public ReadOnly property ReferenciaCuentaSuperiorNivel3Obsoleto As Guid
            get
                return me.GetValue_Guid("pr_20040143601005")
            End Get   
        End Property
        Public ReadOnly property CodigoDeCuentaFinDeRango As Integer
            get
                return me.GetValue_Int("pr_40040143603")
            End Get   
        End Property
          Public property Tipo__Int as Integer
            get
                return me.GetValue_Int("pr_20040143881")
            End Get
            Set(value as Integer)
                me.SetValue_Int("pr_20040143881", value)
            End Set
          End Property
          Public property Tipo As EnumNivelCuentaContableE
            get
                return me.GetValue_Int("pr_20040143881")
            End Get
            Set(value As EnumNivelCuentaContableE)
                me.SetValue_Int("pr_20040143881", value)
            End Set
          End Property
        Public ReadOnly property CodigoCuentaSuperiorNivel1Obsoleto As Integer
            get
                return me.GetValue_Int("pr_30040143606")
            End Get   
        End Property
        Public ReadOnly property CodigoCuentaSuperiorNivel2Obsoleto As Integer
            get
                return me.GetValue_Int("pr_30040143607")
            End Get   
        End Property
        Public ReadOnly property CodigoCuentaSuperiorNivel3Obsoleto As Integer
            get
                return me.GetValue_Int("pr_30040143608")
            End Get   
        End Property
        Public ReadOnly property ReferenciaCuentaSuperiorNivel2Obsoleto As Guid
            get
                return me.GetValue_Guid("pr_10040143601004")
            End Get   
        End Property
        Public ReadOnly property ReferenciaCuentaSuperiorNivel5Obsoleto As Guid
            get
                return me.GetValue_Guid("pr_30040143601")
            End Get   
        End Property
        Public ReadOnly property CodigoDeCuentaInicioDeRango As Integer
            get
                return me.GetValue_Int("pr_40040143601")
            End Get   
        End Property
          Public property SePuedenRealizarAsientosSobreEstaCuenta As Boolean
            get
                return me.GetValue_Boolean("pr_50040143921")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_50040143921", value)
            End Set
          End Property
          Public property ReferenciaGrupoPrincipal As Guid
            get
                return me.GetValue_Guid("pr_20040144082")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_20040144082", value)
            End Set
          End Property
          Public property ColorIdentificativo As String
            get
                return me.GetValue_String("pr_20040144083")
            End Get
            Set(value As String)
                me.SetValue_String("pr_20040144083", value)
            End Set
          End Property
          Public property UtilizarCriterioDeIdentificacionEnCuentasDeNivelesInferiores As Boolean
            get
                return me.GetValue_Boolean("pr_30040144083")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_30040144083", value)
            End Set
          End Property
          Public property ReferenciaIcono As Guid
            get
                return me.GetValue_Guid("pr_20040144084")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_20040144084", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaCuentaSuperiorNivel4Obsoleto As Guid
            get
                return me.GetValue_Guid("pr_30040144356")
            End Get   
        End Property
          Public property Titulo As String
            get
                return me.GetValue_String("pr_10040173141001")
            End Get
            Set(value As String)
                me.SetValue_String("pr_10040173141001", value)
            End Set
          End Property
          Public property ReferenciaPlanContableObsoleto As Guid
            get
                return me.GetValue_Guid("pr_40040180101")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_40040180101", value)
            End Set
          End Property
          Public property EmpresaPlanContableObsoletoTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_30040180124")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_30040180124", value)
            End Set
          End Property
          Public property ReferenciaEmpresaPlanContableObsoleto As Guid
            get
                return me.GetValue_Guid("pr_30040180123")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_30040180123", value)
            End Set
          End Property
          Public property ActividadesAgricolasGanaderasYForestales As Boolean
            get
                return me.GetValue_Boolean("pr_20040221382")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_20040221382", value)
            End Set
          End Property
          Public property GastosFiscalmenteNoDeducibles As Boolean
            get
                return me.GetValue_Boolean("pr_20040221384")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_20040221384", value)
            End Set
          End Property
          Public property EnEspecie As Boolean
            get
                return me.GetValue_Boolean("pr_50040221604")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_50040221604", value)
            End Set
          End Property
          Public property ReferenciaArrendamientoObsoleto As Guid
            get
                return me.GetValue_Guid("pr_40040244942")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_40040244942", value)
            End Set
          End Property
          Public property ArrendamientoRetencionObsoletoPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_30040244951")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_30040244951", value)
            End Set
          End Property
          Public property Niveles As Integer
            get
                return me.GetValue_Int("pr_30040270667")
            End Get
            Set(value As Integer)
                me.SetValue_Int("pr_30040270667", value)
            End Set
          End Property
          Public property IVAPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_10040402161")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_10040402161", value)
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
