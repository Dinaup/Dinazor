   Imports System.ComponentModel
   Imports DinaNETCore
   Imports DinaNETCore.APID
Partial Public Class SeccionesD
  Public Class EmpresasAdministradasD
      Public Shared _SeccionID As String = "8bcba7c2-11b2-4f81-a7a7-35f65de8aa51"
      Public Shared _SeccionIDGUID As New Guid("8bcba7c2-11b2-4f81-a7a7-35f65de8aa51")
      Public Shared Async Function ConsultarDatos_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, ParamArray Valor As String()) As Task(Of List(Of EmpresasAdministradasC )) 
          Dim R As New List(Of EmpresasAdministradasC )  
          Dim d = Await DinaupSesion.ConexionServidor.Funcion_Datos_Recibir_Async(DinaupSesion, EmpresasAdministradasES._SeccionID, False, Campo, Valor) 
          If d.Datos.TieneDatos Then 
              For Each Actual In d.Datos 
                  Dim Valores_Listador = Actual.Value.Item1
                  Dim Obj_Listador As New EmpresasAdministradasC 
                  Obj_Listador.CargarDatos(Valores_Listador) 
                  R.Add(Obj_Listador) 
              Next 
          End If 
          Return R 
      End Function 
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As EmpresasAdministradasC, Optional CampoWhere$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Return Await DatosGuardar_Async(DinaupSesion, New List(Of EmpresasAdministradasC)({DAtos}), CampoWhere )
      End Function
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As List(Of EmpresasAdministradasC), Optional CampoWhere$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Dim Importar As New List(Of DinaupAPI_ImportacionProcesableC)
          For Each Actual In DAtos 
              Dim RegistroActual = New DinaupAPI_ImportacionProcesableC() 
               RegistroActual.dinaup_listador_datos = Actual.ToDic 
               Importar.Add(RegistroActual)  
          Next 
          Return Await DinaupSesion.ConexionServidor.Funcion_Importar_Ejecutar_Async(DinaupSesion, EmpresasAdministradasES._SeccionID, Importar, CampoWhere, "") 
      End Function
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As EmpresasAdministradas_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, EmpresasAdministradasES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New EmpresasAdministradas_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As EmpresasAdministradas_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, EmpresasAdministradasES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New EmpresasAdministradas_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class EmpresasAdministradasES
          Public shared _SeccionID as Guid = New Guid("8bcba7c2-11b2-4f81-a7a7-35f65de8aa51")
          Public shared _Tabla$ = "tpr_30040180812"
      Public Shared RegistroMercantilDe$ = "pr_50040185685"
      Public Shared ExportarEnModulos$ = "pr_30040180811013"
      Public Shared ReferenciaDestinador$ = "pr_30040180811015"
      Public Shared FechaAlta_UTC$ = "pr_30040180811014"
      Public Shared HoraLocal$ = "pr_30040180811012"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_30040180811021"
      Public Shared ReferenciaAutorDelAlta$ = "pr_30040180811010"
      Public Shared ReferenciaLogoSobreBlanco$ = "pr_40040180811"
      Public Shared ReferenciaLogoSobreNegro$ = "pr_40040180812"
      Public Shared PaginaWeb$ = "pr_50040180811"
      Public Shared EmpresaPrincipal$ = "pr_60040180813"
      Public Shared Color$ = "pr_60040181031"
      Public Shared Archivar$ = "pr_40040183201"
      Public Shared DomicilioDireccionObsoleto$ = "pr_40040185681001"
      Public Shared MovilObsoleto$ = "pr_40040185681004"
      Public Shared CodigoPostalObsoleto$ = "pr_40040185681006"
      Public Shared RegistroMercantilInscripcion$ = "pr_50040185681"
      Public Shared DenominacionSocialObsoleto$ = "pr_50040185688"
      Public Shared PuertaObsoleto$ = "pr_40040185681007"
      Public Shared RegistroMercantilHoja$ = "pr_50040185683"
      Public Shared RegistroMercantilTomo$ = "pr_50040185684"
      Public Shared TelefonoObsoleto$ = "pr_40040185681002"
      Public Shared FaxObsoleto$ = "pr_40040185681003"
      Public Shared RegistroMercantilFolio$ = "pr_50040185682"
      Public Shared NIFObsoleto$ = "pr_50040185686"
      Public Shared NombreComercialObsoleto$ = "pr_50040185687"
      Public Shared PisoObsoleto$ = "pr_40040185681008"
      Public Shared EscaleraObsoleto$ = "pr_40040185681009"
      Public Shared ProvinciaObsoleto$ = "pr_40040185681005"
      Public Shared NumeroObsoleto$ = "pr_40040185681010"
      Public Shared MunicipioObsoleto$ = "pr_500401856810"
      Public Shared MargenMinutosDeFinalizacionDeHorarioSalidaParaNuevosEmpleados$ = "pr_50040210308"
      Public Shared MargenMinutosDeInicioDeHorarioEntradaParaNuevosEmpleados$ = "pr_50040210307"
      Public Shared ALosNuevosEmpleadosSeLesCerraraAutomaticamenteElSistemaCuandoFinaliceSuHorario$ = "pr_50040210306"
      Public Shared LosNuevosEmpleadosPodranConectarFueraDeHorario$ = "pr_50040210305"
      Public Shared TiempoMinimoParaEvaluarTiempoTrabajadoDeMenos$ = "pr_30040211996"
      Public Shared TiempoMinimoParaEvaluarTiempoTrabajadoDeMas$ = "pr_30040211997"
      Public Shared RegistrarTurnosAutomaticamenteEnBaseAHorario$ = "pr_30040212061"
      Public Shared CPlazaAvdaObsoleto$ = "pr_40040220651"
      Public Shared ReferenciaDatosFiscales$ = "pr_40040242242"
      Public Shared RegistroMercantilLibro$ = "pr_60040269564"
      Public Shared RegistroMercantilSeccion$ = "pr_60040269565"
      Public Shared ContraseñaDeProteccionParaLasCopiasDeSeguridad$ = "pr_50040276295"
      Public Shared FechaDeRenovacionDeCertificadoDeContraseña$ = "pr_60040276291"
      Public Shared NInscripcionSS$ = "pr_20040278023"
      Public Shared IdentificadorAcceso$ = "pr_40040332032"
      Public Shared Notas$ = "pr_40040291744"
      Public Shared ColorMarca$ = "pr_40040291743"
      Public Shared TodosLosEmpleadosTienenAcceso$ = "pr_30040291894"
      Public Shared ReferenciaCorreoUtilizadoParaAvisoDeNotificaciones$ = "pr_50040260011"
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
      Public Class EmpresasAdministradasC
      Inherits Base_DatoC
          <DisplayName("Registro mercantil de")>
          Public Property RegistroMercantilDe As String
          Public Shared ___RegistroMercantilDe As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RegistroMercantilDe"",""etiqueta"": ""Registro mercantil de"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Registro mercantil de"",""descripcion"": """",""keyword"": ""RegistroMercantilDe"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RegistroMercantilDe As DinaNETCore.APID.DinaupAPI_CampoC = ___RegistroMercantilDe
          <DisplayName("Destinador")>
          Public Property ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaDestinador As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaDestinador"",""etiqueta"": ""Destinador"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""relacionesindirectas"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Destinador"",""descripcion"": """",""keyword"": ""ReferenciaDestinador"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaDestinador
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
          <DisplayName("Autor del alta")>
          Public Property ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaAutorDelAlta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaAutorDelAlta"",""etiqueta"": ""Autor del alta"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta"",""descripcion"": """",""keyword"": ""ReferenciaAutorDelAlta"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaAutorDelAlta
          <Description("Imagen que utilizará el sistema para mostrar el logo de la empresa sobre fondos claros.")>
          <DisplayName("Logo sobre Blanco")>
          Public Property ReferenciaLogoSobreBlanco As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaLogoSobreBlanco As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaLogoSobreBlanco"",""etiqueta"": ""Logo sobre Blanco"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""imagenes"",""rol"": 17,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Logo sobre Blanco"",""descripcion"": """",""keyword"": ""ReferenciaLogoSobreBlanco"",""formato"": 9,""rol"": 17,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaLogoSobreBlanco As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaLogoSobreBlanco
          <Description("Imagen que utilizará el sistema para mostrar el logo de la empresa sobre fondos oscuros.")>
          <DisplayName("Logo sobre Negro")>
          Public Property ReferenciaLogoSobreNegro As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaLogoSobreNegro As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaLogoSobreNegro"",""etiqueta"": ""Logo sobre Negro"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""imagenes"",""rol"": 17,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Logo sobre Negro"",""descripcion"": """",""keyword"": ""ReferenciaLogoSobreNegro"",""formato"": 9,""rol"": 17,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaLogoSobreNegro As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaLogoSobreNegro
          <DisplayName("Página Web")>
          Public Property PaginaWeb As String
          Public Shared ___PaginaWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""PaginaWeb"",""etiqueta"": ""Página Web"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 1,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Página Web"",""descripcion"": """",""keyword"": ""PaginaWeb"",""formato"": 5,""rol"": 1,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __PaginaWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___PaginaWeb
          <DisplayName("Empresa principal")>
          Public Property EmpresaPrincipal As Boolean
          Public Shared ___EmpresaPrincipal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EmpresaPrincipal"",""etiqueta"": ""Empresa principal"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empresa principal"",""descripcion"": """",""keyword"": ""EmpresaPrincipal"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EmpresaPrincipal As DinaNETCore.APID.DinaupAPI_CampoC = ___EmpresaPrincipal
          <DisplayName("Color")>
          Public Property Color As String
          Public Shared ___Color As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Color"",""etiqueta"": ""Color"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 29,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Color"",""descripcion"": """",""keyword"": ""Color"",""formato"": 5,""rol"": 29,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Color As DinaNETCore.APID.DinaupAPI_CampoC = ___Color
          <DisplayName("Archivar")>
          Public Property Archivar As Boolean
          Public Shared ___Archivar As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Archivar"",""etiqueta"": ""Archivar"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Archivar"",""descripcion"": """",""keyword"": ""Archivar"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Archivar As DinaNETCore.APID.DinaupAPI_CampoC = ___Archivar
          <DisplayName("Domicilio / Dirección (Obsoleto)")>
          Public Property DomicilioDireccionObsoleto As String
          Public Shared ___DomicilioDireccionObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DomicilioDireccionObsoleto"",""etiqueta"": ""Domicilio / Dirección (Obsoleto)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Domicilio / Dirección (Obsoleto)"",""descripcion"": """",""keyword"": ""DomicilioDireccionObsoleto"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DomicilioDireccionObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___DomicilioDireccionObsoleto
          <DisplayName("Móvil (Obsoleto)")>
          Public Property MovilObsoleto As String
          Public Shared ___MovilObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""MovilObsoleto"",""etiqueta"": ""Móvil (Obsoleto)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Móvil (Obsoleto)"",""descripcion"": """",""keyword"": ""MovilObsoleto"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __MovilObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___MovilObsoleto
          <DisplayName("Código postal (Obsoleto)")>
          Public Property CodigoPostalObsoleto As String
          Public Shared ___CodigoPostalObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CodigoPostalObsoleto"",""etiqueta"": ""Código postal (Obsoleto)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Código postal (Obsoleto)"",""descripcion"": """",""keyword"": ""CodigoPostalObsoleto"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CodigoPostalObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___CodigoPostalObsoleto
          <DisplayName("Registro mercantil Inscripción")>
          Public Property RegistroMercantilInscripcion As String
          Public Shared ___RegistroMercantilInscripcion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RegistroMercantilInscripcion"",""etiqueta"": ""Registro mercantil Inscripción"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Registro mercantil Inscripción"",""descripcion"": """",""keyword"": ""RegistroMercantilInscripcion"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RegistroMercantilInscripcion As DinaNETCore.APID.DinaupAPI_CampoC = ___RegistroMercantilInscripcion
          <DisplayName("Denominación social (Obsoleto)")>
          Public Property DenominacionSocialObsoleto As String
          Public Shared ___DenominacionSocialObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DenominacionSocialObsoleto"",""etiqueta"": ""Denominación social (Obsoleto)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Denominación social (Obsoleto)"",""descripcion"": """",""keyword"": ""DenominacionSocialObsoleto"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DenominacionSocialObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___DenominacionSocialObsoleto
          <DisplayName("Puerta (Obsoleto)")>
          Public Property PuertaObsoleto As String
          Public Shared ___PuertaObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""PuertaObsoleto"",""etiqueta"": ""Puerta (Obsoleto)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Puerta (Obsoleto)"",""descripcion"": """",""keyword"": ""PuertaObsoleto"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __PuertaObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___PuertaObsoleto
          <DisplayName("Registro mercantil Hoja")>
          Public Property RegistroMercantilHoja As String
          Public Shared ___RegistroMercantilHoja As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RegistroMercantilHoja"",""etiqueta"": ""Registro mercantil Hoja"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Registro mercantil Hoja"",""descripcion"": """",""keyword"": ""RegistroMercantilHoja"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RegistroMercantilHoja As DinaNETCore.APID.DinaupAPI_CampoC = ___RegistroMercantilHoja
          <DisplayName("Registro mercantil Tomo")>
          Public Property RegistroMercantilTomo As String
          Public Shared ___RegistroMercantilTomo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RegistroMercantilTomo"",""etiqueta"": ""Registro mercantil Tomo"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Registro mercantil Tomo"",""descripcion"": """",""keyword"": ""RegistroMercantilTomo"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RegistroMercantilTomo As DinaNETCore.APID.DinaupAPI_CampoC = ___RegistroMercantilTomo
          <DisplayName("Teléfono (Obsoleto)")>
          Public Property TelefonoObsoleto As String
          Public Shared ___TelefonoObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TelefonoObsoleto"",""etiqueta"": ""Teléfono (Obsoleto)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 2,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Teléfono (Obsoleto)"",""descripcion"": """",""keyword"": ""TelefonoObsoleto"",""formato"": 5,""rol"": 2,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __TelefonoObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___TelefonoObsoleto
          <DisplayName("Fax (Obsoleto)")>
          Public Property FaxObsoleto As String
          Public Shared ___FaxObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FaxObsoleto"",""etiqueta"": ""Fax (Obsoleto)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fax (Obsoleto)"",""descripcion"": """",""keyword"": ""FaxObsoleto"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __FaxObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___FaxObsoleto
          <DisplayName("Registro mercantil Folio")>
          Public Property RegistroMercantilFolio As String
          Public Shared ___RegistroMercantilFolio As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RegistroMercantilFolio"",""etiqueta"": ""Registro mercantil Folio"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Registro mercantil Folio"",""descripcion"": """",""keyword"": ""RegistroMercantilFolio"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RegistroMercantilFolio As DinaNETCore.APID.DinaupAPI_CampoC = ___RegistroMercantilFolio
          <DisplayName("NIF (Obsoleto)")>
          Public Property NIFObsoleto As String
          Public Shared ___NIFObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""NIFObsoleto"",""etiqueta"": ""NIF (Obsoleto)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 79,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""NIF (Obsoleto)"",""descripcion"": """",""keyword"": ""NIFObsoleto"",""formato"": 5,""rol"": 79,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __NIFObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___NIFObsoleto
          <DisplayName("Nombre comercial (Obsoleto)")>
          Public Property NombreComercialObsoleto As String
          Public Shared ___NombreComercialObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""NombreComercialObsoleto"",""etiqueta"": ""Nombre comercial (Obsoleto)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Nombre comercial (Obsoleto)"",""descripcion"": """",""keyword"": ""NombreComercialObsoleto"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __NombreComercialObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___NombreComercialObsoleto
          <DisplayName("Piso (Obsoleto)")>
          Public Property PisoObsoleto As String
          Public Shared ___PisoObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""PisoObsoleto"",""etiqueta"": ""Piso (Obsoleto)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Piso (Obsoleto)"",""descripcion"": """",""keyword"": ""PisoObsoleto"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __PisoObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___PisoObsoleto
          <DisplayName("Escalera (Obsoleto)")>
          Public Property EscaleraObsoleto As String
          Public Shared ___EscaleraObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EscaleraObsoleto"",""etiqueta"": ""Escalera (Obsoleto)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Escalera (Obsoleto)"",""descripcion"": """",""keyword"": ""EscaleraObsoleto"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EscaleraObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___EscaleraObsoleto
          <DisplayName("Provincia (Obsoleto)")>
          Public Property ProvinciaObsoleto As String
          Public Shared ___ProvinciaObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ProvinciaObsoleto"",""etiqueta"": ""Provincia (Obsoleto)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Provincia (Obsoleto)"",""descripcion"": """",""keyword"": ""ProvinciaObsoleto"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ProvinciaObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___ProvinciaObsoleto
          <DisplayName("Número (Obsoleto)")>
          Public Property NumeroObsoleto As String
          Public Shared ___NumeroObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""NumeroObsoleto"",""etiqueta"": ""Número (Obsoleto)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Número (Obsoleto)"",""descripcion"": """",""keyword"": ""NumeroObsoleto"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __NumeroObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___NumeroObsoleto
          <DisplayName("Municipio (Obsoleto)")>
          Public Property MunicipioObsoleto As String
          Public Shared ___MunicipioObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""MunicipioObsoleto"",""etiqueta"": ""Municipio (Obsoleto)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Municipio (Obsoleto)"",""descripcion"": """",""keyword"": ""MunicipioObsoleto"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __MunicipioObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___MunicipioObsoleto
          <DisplayName("Margen minutos de finalización de horario (Salida), para nuevos empleados")>
          Public Property MargenMinutosDeFinalizacionDeHorarioSalidaParaNuevosEmpleados As Integer
          Public Shared ___MargenMinutosDeFinalizacionDeHorarioSalidaParaNuevosEmpleados As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""MargenMinutosDeFinalizacionDeHorarioSalidaParaNuevosEmpleados"",""etiqueta"": ""Margen minutos de finalización de horario (Salida), para nuevos empleados"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Margen minutos de finalización de horario (Salida), para nuevos empleados"",""descripcion"": """",""keyword"": ""MargenMinutosDeFinalizacionDeHorarioSalidaParaNuevosEmpleados"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __MargenMinutosDeFinalizacionDeHorarioSalidaParaNuevosEmpleados As DinaNETCore.APID.DinaupAPI_CampoC = ___MargenMinutosDeFinalizacionDeHorarioSalidaParaNuevosEmpleados
          <DisplayName("Margen minutos de inicio de horario (entrada), para nuevos empleados")>
          Public Property MargenMinutosDeInicioDeHorarioEntradaParaNuevosEmpleados As Integer
          Public Shared ___MargenMinutosDeInicioDeHorarioEntradaParaNuevosEmpleados As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""MargenMinutosDeInicioDeHorarioEntradaParaNuevosEmpleados"",""etiqueta"": ""Margen minutos de inicio de horario (entrada), para nuevos empleados"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Margen minutos de inicio de horario (entrada), para nuevos empleados"",""descripcion"": """",""keyword"": ""MargenMinutosDeInicioDeHorarioEntradaParaNuevosEmpleados"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __MargenMinutosDeInicioDeHorarioEntradaParaNuevosEmpleados As DinaNETCore.APID.DinaupAPI_CampoC = ___MargenMinutosDeInicioDeHorarioEntradaParaNuevosEmpleados
          <DisplayName("A los nuevos empleados, se les cerrará automáticamente el sistema cuando finalice su horario")>
          Public Property ALosNuevosEmpleadosSeLesCerraraAutomaticamenteElSistemaCuandoFinaliceSuHorario As Boolean
          Public Shared ___ALosNuevosEmpleadosSeLesCerraraAutomaticamenteElSistemaCuandoFinaliceSuHorario As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ALosNuevosEmpleadosSeLesCerraraAutomaticamenteElSistemaCuandoFinaliceSuHorario"",""etiqueta"": ""A los nuevos empleados, se les cerrará automáticamente el sistema cuando finalice su horario"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""A los nuevos empleados, se les cerrará automáticamente el sistema cuando finalice su horario"",""descripcion"": """",""keyword"": ""ALosNuevosEmpleadosSeLesCerraraAutomaticamenteElSistemaCuandoFinaliceSuHorario"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ALosNuevosEmpleadosSeLesCerraraAutomaticamenteElSistemaCuandoFinaliceSuHorario As DinaNETCore.APID.DinaupAPI_CampoC = ___ALosNuevosEmpleadosSeLesCerraraAutomaticamenteElSistemaCuandoFinaliceSuHorario
          <DisplayName("Los nuevos empleados, podrán conectar fuera de horario")>
          Public Property LosNuevosEmpleadosPodranConectarFueraDeHorario As Boolean
          Public Shared ___LosNuevosEmpleadosPodranConectarFueraDeHorario As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""LosNuevosEmpleadosPodranConectarFueraDeHorario"",""etiqueta"": ""Los nuevos empleados, podrán conectar fuera de horario"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Los nuevos empleados, podrán conectar fuera de horario"",""descripcion"": """",""keyword"": ""LosNuevosEmpleadosPodranConectarFueraDeHorario"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __LosNuevosEmpleadosPodranConectarFueraDeHorario As DinaNETCore.APID.DinaupAPI_CampoC = ___LosNuevosEmpleadosPodranConectarFueraDeHorario
          <DisplayName("Tiempo mínimo para evaluar tiempo trabajado de menos")>
          Public Property TiempoMinimoParaEvaluarTiempoTrabajadoDeMenos As Decimal
          Public Shared ___TiempoMinimoParaEvaluarTiempoTrabajadoDeMenos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TiempoMinimoParaEvaluarTiempoTrabajadoDeMenos"",""etiqueta"": ""Tiempo mínimo para evaluar tiempo trabajado de menos"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 14,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Tiempo mínimo para evaluar tiempo trabajado de menos"",""descripcion"": """",""keyword"": ""TiempoMinimoParaEvaluarTiempoTrabajadoDeMenos"",""formato"": 3,""rol"": 14,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __TiempoMinimoParaEvaluarTiempoTrabajadoDeMenos As DinaNETCore.APID.DinaupAPI_CampoC = ___TiempoMinimoParaEvaluarTiempoTrabajadoDeMenos
          <DisplayName("Tiempo mínimo para evaluar tiempo trabajado de más")>
          Public Property TiempoMinimoParaEvaluarTiempoTrabajadoDeMas As Decimal
          Public Shared ___TiempoMinimoParaEvaluarTiempoTrabajadoDeMas As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TiempoMinimoParaEvaluarTiempoTrabajadoDeMas"",""etiqueta"": ""Tiempo mínimo para evaluar tiempo trabajado de más"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 14,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Tiempo mínimo para evaluar tiempo trabajado de más"",""descripcion"": """",""keyword"": ""TiempoMinimoParaEvaluarTiempoTrabajadoDeMas"",""formato"": 3,""rol"": 14,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __TiempoMinimoParaEvaluarTiempoTrabajadoDeMas As DinaNETCore.APID.DinaupAPI_CampoC = ___TiempoMinimoParaEvaluarTiempoTrabajadoDeMas
          <DisplayName("Registrar turnos automáticamente en base a horario")>
          Public Property RegistrarTurnosAutomaticamenteEnBaseAHorario As Boolean
          Public Shared ___RegistrarTurnosAutomaticamenteEnBaseAHorario As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RegistrarTurnosAutomaticamenteEnBaseAHorario"",""etiqueta"": ""Registrar turnos automáticamente en base a horario"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Registrar turnos automáticamente en base a horario"",""descripcion"": """",""keyword"": ""RegistrarTurnosAutomaticamenteEnBaseAHorario"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RegistrarTurnosAutomaticamenteEnBaseAHorario As DinaNETCore.APID.DinaupAPI_CampoC = ___RegistrarTurnosAutomaticamenteEnBaseAHorario
          <DisplayName("C / Plaza / Avda (Obsoleto)")>
          Public Property CPlazaAvdaObsoleto As String
          Public Shared ___CPlazaAvdaObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CPlazaAvdaObsoleto"",""etiqueta"": ""C / Plaza / Avda (Obsoleto)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""C / Plaza / Avda (Obsoleto)"",""descripcion"": """",""keyword"": ""CPlazaAvdaObsoleto"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CPlazaAvdaObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___CPlazaAvdaObsoleto
          <DisplayName("Datos fiscales")>
          Public Property ReferenciaDatosFiscales As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaDatosFiscales As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaDatosFiscales"",""etiqueta"": ""Datos fiscales"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""03e347ac-c694-4d4a-a81f-e577ba014d1d"",""titulo"": ""Base - Datos fiscales"",""iconoid"": ""773d55f9-1e21-41f1-b0b0-f6a1dd370ea3"",""etiquetasingular"": ""Datos fiscales"",""etiquetaplural"": ""Datos fiscales"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""03e347ac-c694-4d4a-a81f-e577ba014d1d"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Datos fiscales"",""descripcion"": """",""keyword"": ""ReferenciaDatosFiscales"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaDatosFiscales As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaDatosFiscales
          <DisplayName("Registro mercantil Libro")>
          Public Property RegistroMercantilLibro As String
          Public Shared ___RegistroMercantilLibro As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RegistroMercantilLibro"",""etiqueta"": ""Registro mercantil Libro"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Registro mercantil Libro"",""descripcion"": """",""keyword"": ""RegistroMercantilLibro"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RegistroMercantilLibro As DinaNETCore.APID.DinaupAPI_CampoC = ___RegistroMercantilLibro
          <DisplayName("Registro mercantil Sección")>
          Public Property RegistroMercantilSeccion As String
          Public Shared ___RegistroMercantilSeccion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RegistroMercantilSeccion"",""etiqueta"": ""Registro mercantil Sección"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Registro mercantil Sección"",""descripcion"": """",""keyword"": ""RegistroMercantilSeccion"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RegistroMercantilSeccion As DinaNETCore.APID.DinaupAPI_CampoC = ___RegistroMercantilSeccion
          <DisplayName("Contraseña de protección para las Copias de Seguridad")>
          Public Property ContraseñaDeProteccionParaLasCopiasDeSeguridad As String
          Public Shared ___ContraseñaDeProteccionParaLasCopiasDeSeguridad As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ContraseñaDeProteccionParaLasCopiasDeSeguridad"",""etiqueta"": ""Contraseña de protección para las Copias de Seguridad"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 10,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Contraseña de protección para las Copias de Seguridad"",""descripcion"": """",""keyword"": ""ContraseñaDeProteccionParaLasCopiasDeSeguridad"",""formato"": 5,""rol"": 10,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ContraseñaDeProteccionParaLasCopiasDeSeguridad As DinaNETCore.APID.DinaupAPI_CampoC = ___ContraseñaDeProteccionParaLasCopiasDeSeguridad
          <DisplayName("Fecha de renovación de certificado de contraseña")>
          Public Property FechaDeRenovacionDeCertificadoDeContraseña As Date?
          Public Shared ___FechaDeRenovacionDeCertificadoDeContraseña As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaDeRenovacionDeCertificadoDeContraseña"",""etiqueta"": ""Fecha de renovación de certificado de contraseña"",""oculta"": false,""formato"": 7,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha de renovación de certificado de contraseña"",""descripcion"": """",""keyword"": ""FechaDeRenovacionDeCertificadoDeContraseña"",""formato"": 7,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaDeRenovacionDeCertificadoDeContraseña As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaDeRenovacionDeCertificadoDeContraseña
          <DisplayName("Nº Inscripción S.S")>
          Public Property NInscripcionSS As String
          Public Shared ___NInscripcionSS As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""NInscripcionSS"",""etiqueta"": ""Nº Inscripción S.S"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Nº Inscripción S.S"",""descripcion"": """",""keyword"": ""NInscripcionSS"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __NInscripcionSS As DinaNETCore.APID.DinaupAPI_CampoC = ___NInscripcionSS
          <DisplayName("Identificador Acceso")>
          Public Property IdentificadorAcceso As String
          Public Shared ___IdentificadorAcceso As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""IdentificadorAcceso"",""etiqueta"": ""Identificador Acceso"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Identificador Acceso"",""descripcion"": """",""keyword"": ""IdentificadorAcceso"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __IdentificadorAcceso As DinaNETCore.APID.DinaupAPI_CampoC = ___IdentificadorAcceso
          <DisplayName("Notas")>
          Public Property Notas As String
          Public Shared ___Notas As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Notas"",""etiqueta"": ""Notas"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 9,""decimales"": ""0"",""multilinea"": true,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Notas"",""descripcion"": """",""keyword"": ""Notas"",""formato"": 5,""rol"": 9,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Notas As DinaNETCore.APID.DinaupAPI_CampoC = ___Notas
          <DisplayName("Color Marca")>
          Public Property ColorMarca As String
          Public Shared ___ColorMarca As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ColorMarca"",""etiqueta"": ""Color Marca"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 29,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Color Marca"",""descripcion"": """",""keyword"": ""ColorMarca"",""formato"": 5,""rol"": 29,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ColorMarca As DinaNETCore.APID.DinaupAPI_CampoC = ___ColorMarca
          <DisplayName("Todos los empleados tienen acceso")>
          Public Property TodosLosEmpleadosTienenAcceso As Boolean
          Public Shared ___TodosLosEmpleadosTienenAcceso As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TodosLosEmpleadosTienenAcceso"",""etiqueta"": ""Todos los empleados tienen acceso"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Todos los empleados tienen acceso"",""descripcion"": """",""keyword"": ""TodosLosEmpleadosTienenAcceso"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __TodosLosEmpleadosTienenAcceso As DinaNETCore.APID.DinaupAPI_CampoC = ___TodosLosEmpleadosTienenAcceso
          <DisplayName("Correo utilizado para aviso de notificaciones")>
          Public Property ReferenciaCorreoUtilizadoParaAvisoDeNotificaciones As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaCorreoUtilizadoParaAvisoDeNotificaciones As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaCorreoUtilizadoParaAvisoDeNotificaciones"",""etiqueta"": ""Correo utilizado para aviso de notificaciones"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""e80ad188-9d6d-4b05-a7fb-e498cef51598"",""titulo"": ""Base - Cuentas de Correo electrónico"",""iconoid"": ""5fd758a4-dbc3-4365-ad56-18af81075b78"",""etiquetasingular"": ""Cuenta de correo electrónico"",""etiquetaplural"": ""Cuentas de Correo electrónico"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""e80ad188-9d6d-4b05-a7fb-e498cef51598"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Correo utilizado para aviso de notificaciones"",""descripcion"": """",""keyword"": ""ReferenciaCorreoUtilizadoParaAvisoDeNotificaciones"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaCorreoUtilizadoParaAvisoDeNotificaciones As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaCorreoUtilizadoParaAvisoDeNotificaciones
          <ReadOnlyAttribute(True)>
          <DisplayName("ID")>
          Public Property ID As Guid
          Public Shared ___ID As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": true,""eseliminado"": false,""keyword"": ""ID"",""etiqueta"": ""ID"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""8bcba7c2-11b2-4f81-a7a7-35f65de8aa51"",""titulo"": ""Empresas administradas"",""iconoid"": ""b788149e-1c15-4807-9a25-72adf3333e5b"",""etiquetasingular"": ""Empresa administrada"",""etiquetaplural"": ""Empresas administradas"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""8bcba7c2-11b2-4f81-a7a7-35f65de8aa51"",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""ID"",""descripcion"": """",""keyword"": ""ID"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
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
          me.RegistroMercantilDe = _Datos.Leer_String("pr_50040185685")
          me.ReferenciaDestinador = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_30040180811015"), _Datos.Leer_String("pr_30040180811015.nombre"))
          me.FechaAlta_UTC = _Datos.Leer_DateTime_Nulable("pr_30040180811014")
          me.HoraLocal = _Datos.Leer_Time_Nulable("pr_30040180811012")
          me.AutorDelAltaTieneAccesoWeb = _Datos.Leer_Boolean("pr_30040180811021")
          me.ReferenciaAutorDelAlta = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_30040180811010"), _Datos.Leer_String("pr_30040180811010.nombre"))
          me.ReferenciaLogoSobreBlanco = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_40040180811"), _Datos.Leer_String("pr_40040180811.nombre"))
          me.ReferenciaLogoSobreNegro = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_40040180812"), _Datos.Leer_String("pr_40040180812.nombre"))
          me.PaginaWeb = _Datos.Leer_String("pr_50040180811")
          me.EmpresaPrincipal = _Datos.Leer_Boolean("pr_60040180813")
          me.Color = _Datos.Leer_String("pr_60040181031")
          me.Archivar = _Datos.Leer_Boolean("pr_40040183201")
          me.DomicilioDireccionObsoleto = _Datos.Leer_String("pr_40040185681001")
          me.MovilObsoleto = _Datos.Leer_String("pr_40040185681004")
          me.CodigoPostalObsoleto = _Datos.Leer_String("pr_40040185681006")
          me.RegistroMercantilInscripcion = _Datos.Leer_String("pr_50040185681")
          me.DenominacionSocialObsoleto = _Datos.Leer_String("pr_50040185688")
          me.PuertaObsoleto = _Datos.Leer_String("pr_40040185681007")
          me.RegistroMercantilHoja = _Datos.Leer_String("pr_50040185683")
          me.RegistroMercantilTomo = _Datos.Leer_String("pr_50040185684")
          me.TelefonoObsoleto = _Datos.Leer_String("pr_40040185681002")
          me.FaxObsoleto = _Datos.Leer_String("pr_40040185681003")
          me.RegistroMercantilFolio = _Datos.Leer_String("pr_50040185682")
          me.NIFObsoleto = _Datos.Leer_String("pr_50040185686")
          me.NombreComercialObsoleto = _Datos.Leer_String("pr_50040185687")
          me.PisoObsoleto = _Datos.Leer_String("pr_40040185681008")
          me.EscaleraObsoleto = _Datos.Leer_String("pr_40040185681009")
          me.ProvinciaObsoleto = _Datos.Leer_String("pr_40040185681005")
          me.NumeroObsoleto = _Datos.Leer_String("pr_40040185681010")
          me.MunicipioObsoleto = _Datos.Leer_String("pr_500401856810")
          me.MargenMinutosDeFinalizacionDeHorarioSalidaParaNuevosEmpleados = _Datos.Leer_Integer("pr_50040210308")
          me.MargenMinutosDeInicioDeHorarioEntradaParaNuevosEmpleados = _Datos.Leer_Integer("pr_50040210307")
          me.ALosNuevosEmpleadosSeLesCerraraAutomaticamenteElSistemaCuandoFinaliceSuHorario = _Datos.Leer_Boolean("pr_50040210306")
          me.LosNuevosEmpleadosPodranConectarFueraDeHorario = _Datos.Leer_Boolean("pr_50040210305")
          me.TiempoMinimoParaEvaluarTiempoTrabajadoDeMenos = _Datos.Leer_Decimal("pr_30040211996")
          me.TiempoMinimoParaEvaluarTiempoTrabajadoDeMas = _Datos.Leer_Decimal("pr_30040211997")
          me.RegistrarTurnosAutomaticamenteEnBaseAHorario = _Datos.Leer_Boolean("pr_30040212061")
          me.CPlazaAvdaObsoleto = _Datos.Leer_String("pr_40040220651")
          me.ReferenciaDatosFiscales = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_40040242242"), _Datos.Leer_String("pr_40040242242.nombre"))
          me.RegistroMercantilLibro = _Datos.Leer_String("pr_60040269564")
          me.RegistroMercantilSeccion = _Datos.Leer_String("pr_60040269565")
          me.ContraseñaDeProteccionParaLasCopiasDeSeguridad = _Datos.Leer_String("pr_50040276295")
          me.FechaDeRenovacionDeCertificadoDeContraseña = _Datos.Leer_Date_Nulable("pr_60040276291")
          me.NInscripcionSS = _Datos.Leer_String("pr_20040278023")
          me.IdentificadorAcceso = _Datos.Leer_String("pr_40040332032")
          me.Notas = _Datos.Leer_String("pr_40040291744")
          me.ColorMarca = _Datos.Leer_String("pr_40040291743")
          me.TodosLosEmpleadosTienenAcceso = _Datos.Leer_Boolean("pr_30040291894")
          me.ReferenciaCorreoUtilizadoParaAvisoDeNotificaciones = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_50040260011"), _Datos.Leer_String("pr_50040260011.nombre"))
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
         R.add("pr_50040185685", me.RegistroMercantilDe.AdaptarMySQL_String())
         If Me.ReferenciaDestinador IsNot nothing then
           R.add("pr_30040180811015",me.ReferenciaDestinador.ID.STR())
         Else
           R.add("pr_30040180811015","")
         End if
         R.add("pr_30040180811014", me.FechaAlta_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_30040180811012", me.HoraLocal.AdaptarMySQL_Time_Nulable())
         R.add("pr_30040180811021", me.AutorDelAltaTieneAccesoWeb.AdaptarMySQL_Boolean())
         If Me.ReferenciaAutorDelAlta IsNot nothing then
           R.add("pr_30040180811010",me.ReferenciaAutorDelAlta.ID.STR())
         Else
           R.add("pr_30040180811010","")
         End if
         If Me.ReferenciaLogoSobreBlanco IsNot nothing then
           R.add("pr_40040180811",me.ReferenciaLogoSobreBlanco.ID.STR())
         Else
           R.add("pr_40040180811","")
         End if
         If Me.ReferenciaLogoSobreNegro IsNot nothing then
           R.add("pr_40040180812",me.ReferenciaLogoSobreNegro.ID.STR())
         Else
           R.add("pr_40040180812","")
         End if
         R.add("pr_50040180811", me.PaginaWeb.AdaptarMySQL_String())
         R.add("pr_60040180813", me.EmpresaPrincipal.AdaptarMySQL_Boolean())
         R.add("pr_60040181031", me.Color.AdaptarMySQL_String())
         R.add("pr_40040183201", me.Archivar.AdaptarMySQL_Boolean())
         R.add("pr_40040185681001", me.DomicilioDireccionObsoleto.AdaptarMySQL_String())
         R.add("pr_40040185681004", me.MovilObsoleto.AdaptarMySQL_String())
         R.add("pr_40040185681006", me.CodigoPostalObsoleto.AdaptarMySQL_String())
         R.add("pr_50040185681", me.RegistroMercantilInscripcion.AdaptarMySQL_String())
         R.add("pr_50040185688", me.DenominacionSocialObsoleto.AdaptarMySQL_String())
         R.add("pr_40040185681007", me.PuertaObsoleto.AdaptarMySQL_String())
         R.add("pr_50040185683", me.RegistroMercantilHoja.AdaptarMySQL_String())
         R.add("pr_50040185684", me.RegistroMercantilTomo.AdaptarMySQL_String())
         R.add("pr_40040185681002", me.TelefonoObsoleto.AdaptarMySQL_String())
         R.add("pr_40040185681003", me.FaxObsoleto.AdaptarMySQL_String())
         R.add("pr_50040185682", me.RegistroMercantilFolio.AdaptarMySQL_String())
         R.add("pr_50040185686", me.NIFObsoleto.AdaptarMySQL_String())
         R.add("pr_50040185687", me.NombreComercialObsoleto.AdaptarMySQL_String())
         R.add("pr_40040185681008", me.PisoObsoleto.AdaptarMySQL_String())
         R.add("pr_40040185681009", me.EscaleraObsoleto.AdaptarMySQL_String())
         R.add("pr_40040185681005", me.ProvinciaObsoleto.AdaptarMySQL_String())
         R.add("pr_40040185681010", me.NumeroObsoleto.AdaptarMySQL_String())
         R.add("pr_500401856810", me.MunicipioObsoleto.AdaptarMySQL_String())
         R.add("pr_50040210308", me.MargenMinutosDeFinalizacionDeHorarioSalidaParaNuevosEmpleados.AdaptarMySQL_Integer())
         R.add("pr_50040210307", me.MargenMinutosDeInicioDeHorarioEntradaParaNuevosEmpleados.AdaptarMySQL_Integer())
         R.add("pr_50040210306", me.ALosNuevosEmpleadosSeLesCerraraAutomaticamenteElSistemaCuandoFinaliceSuHorario.AdaptarMySQL_Boolean())
         R.add("pr_50040210305", me.LosNuevosEmpleadosPodranConectarFueraDeHorario.AdaptarMySQL_Boolean())
         R.add("pr_30040211996", me.TiempoMinimoParaEvaluarTiempoTrabajadoDeMenos.AdaptarMySQL_Decimal())
         R.add("pr_30040211997", me.TiempoMinimoParaEvaluarTiempoTrabajadoDeMas.AdaptarMySQL_Decimal())
         R.add("pr_30040212061", me.RegistrarTurnosAutomaticamenteEnBaseAHorario.AdaptarMySQL_Boolean())
         R.add("pr_40040220651", me.CPlazaAvdaObsoleto.AdaptarMySQL_String())
         If Me.ReferenciaDatosFiscales IsNot nothing then
           R.add("pr_40040242242",me.ReferenciaDatosFiscales.ID.STR())
         Else
           R.add("pr_40040242242","")
         End if
         R.add("pr_60040269564", me.RegistroMercantilLibro.AdaptarMySQL_String())
         R.add("pr_60040269565", me.RegistroMercantilSeccion.AdaptarMySQL_String())
         R.add("pr_50040276295", me.ContraseñaDeProteccionParaLasCopiasDeSeguridad.AdaptarMySQL_String())
         R.add("pr_60040276291", me.FechaDeRenovacionDeCertificadoDeContraseña.AdaptarMySQL_Date_Nulable())
         R.add("pr_20040278023", me.NInscripcionSS.AdaptarMySQL_String())
         R.add("pr_40040332032", me.IdentificadorAcceso.AdaptarMySQL_String())
         R.add("pr_40040291744", me.Notas.AdaptarMySQL_String())
         R.add("pr_40040291743", me.ColorMarca.AdaptarMySQL_String())
         R.add("pr_30040291894", me.TodosLosEmpleadosTienenAcceso.AdaptarMySQL_Boolean())
         If Me.ReferenciaCorreoUtilizadoParaAvisoDeNotificaciones IsNot nothing then
           R.add("pr_50040260011",me.ReferenciaCorreoUtilizadoParaAvisoDeNotificaciones.ID.STR())
         Else
           R.add("pr_50040260011","")
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
      Public Class EmpresasAdministradas_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
          Public property RegistroMercantilDe As String
            get
                return me.GetValue_String("pr_50040185685")
            End Get
            Set(value As String)
                me.SetValue_String("pr_50040185685", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_30040180811015")
            End Get   
        End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_30040180811014")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_30040180811014", value)
            End Set
          End Property
        Public ReadOnly property HoraLocal As DateTime
            get
                return me.GetValue_DateTime("pr_30040180811012")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_30040180811021")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_30040180811021", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_30040180811010")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_30040180811010", value)
            End Set
          End Property
          Public property ReferenciaLogoSobreBlanco As Guid
            get
                return me.GetValue_Guid("pr_40040180811")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_40040180811", value)
            End Set
          End Property
          Public property ReferenciaLogoSobreNegro As Guid
            get
                return me.GetValue_Guid("pr_40040180812")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_40040180812", value)
            End Set
          End Property
          Public property PaginaWeb As String
            get
                return me.GetValue_String("pr_50040180811")
            End Get
            Set(value As String)
                me.SetValue_String("pr_50040180811", value)
            End Set
          End Property
        Public ReadOnly property EmpresaPrincipal As Boolean
            get
                return me.GetValue_Boolean("pr_60040180813")
            End Get   
        End Property
          Public property Color As String
            get
                return me.GetValue_String("pr_60040181031")
            End Get
            Set(value As String)
                me.SetValue_String("pr_60040181031", value)
            End Set
          End Property
          Public property Archivar As Boolean
            get
                return me.GetValue_Boolean("pr_40040183201")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_40040183201", value)
            End Set
          End Property
          Public property DomicilioDireccionObsoleto As String
            get
                return me.GetValue_String("pr_40040185681001")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040185681001", value)
            End Set
          End Property
          Public property MovilObsoleto As String
            get
                return me.GetValue_String("pr_40040185681004")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040185681004", value)
            End Set
          End Property
          Public property CodigoPostalObsoleto As String
            get
                return me.GetValue_String("pr_40040185681006")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040185681006", value)
            End Set
          End Property
          Public property RegistroMercantilInscripcion As String
            get
                return me.GetValue_String("pr_50040185681")
            End Get
            Set(value As String)
                me.SetValue_String("pr_50040185681", value)
            End Set
          End Property
          Public property DenominacionSocialObsoleto As String
            get
                return me.GetValue_String("pr_50040185688")
            End Get
            Set(value As String)
                me.SetValue_String("pr_50040185688", value)
            End Set
          End Property
          Public property PuertaObsoleto As String
            get
                return me.GetValue_String("pr_40040185681007")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040185681007", value)
            End Set
          End Property
          Public property RegistroMercantilHoja As String
            get
                return me.GetValue_String("pr_50040185683")
            End Get
            Set(value As String)
                me.SetValue_String("pr_50040185683", value)
            End Set
          End Property
          Public property RegistroMercantilTomo As String
            get
                return me.GetValue_String("pr_50040185684")
            End Get
            Set(value As String)
                me.SetValue_String("pr_50040185684", value)
            End Set
          End Property
          Public property TelefonoObsoleto As String
            get
                return me.GetValue_String("pr_40040185681002")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040185681002", value)
            End Set
          End Property
          Public property FaxObsoleto As String
            get
                return me.GetValue_String("pr_40040185681003")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040185681003", value)
            End Set
          End Property
          Public property RegistroMercantilFolio As String
            get
                return me.GetValue_String("pr_50040185682")
            End Get
            Set(value As String)
                me.SetValue_String("pr_50040185682", value)
            End Set
          End Property
          Public property NIFObsoleto As String
            get
                return me.GetValue_String("pr_50040185686")
            End Get
            Set(value As String)
                me.SetValue_String("pr_50040185686", value)
            End Set
          End Property
          Public property NombreComercialObsoleto As String
            get
                return me.GetValue_String("pr_50040185687")
            End Get
            Set(value As String)
                me.SetValue_String("pr_50040185687", value)
            End Set
          End Property
          Public property PisoObsoleto As String
            get
                return me.GetValue_String("pr_40040185681008")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040185681008", value)
            End Set
          End Property
          Public property EscaleraObsoleto As String
            get
                return me.GetValue_String("pr_40040185681009")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040185681009", value)
            End Set
          End Property
          Public property ProvinciaObsoleto As String
            get
                return me.GetValue_String("pr_40040185681005")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040185681005", value)
            End Set
          End Property
          Public property NumeroObsoleto As String
            get
                return me.GetValue_String("pr_40040185681010")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040185681010", value)
            End Set
          End Property
          Public property MunicipioObsoleto As String
            get
                return me.GetValue_String("pr_500401856810")
            End Get
            Set(value As String)
                me.SetValue_String("pr_500401856810", value)
            End Set
          End Property
          Public property MargenMinutosDeFinalizacionDeHorarioSalidaParaNuevosEmpleados As Integer
            get
                return me.GetValue_Int("pr_50040210308")
            End Get
            Set(value As Integer)
                me.SetValue_Int("pr_50040210308", value)
            End Set
          End Property
          Public property MargenMinutosDeInicioDeHorarioEntradaParaNuevosEmpleados As Integer
            get
                return me.GetValue_Int("pr_50040210307")
            End Get
            Set(value As Integer)
                me.SetValue_Int("pr_50040210307", value)
            End Set
          End Property
          Public property ALosNuevosEmpleadosSeLesCerraraAutomaticamenteElSistemaCuandoFinaliceSuHorario As Boolean
            get
                return me.GetValue_Boolean("pr_50040210306")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_50040210306", value)
            End Set
          End Property
          Public property LosNuevosEmpleadosPodranConectarFueraDeHorario As Boolean
            get
                return me.GetValue_Boolean("pr_50040210305")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_50040210305", value)
            End Set
          End Property
          Public property TiempoMinimoParaEvaluarTiempoTrabajadoDeMenos As Decimal
            get
                return me.GetValue_Decimal("pr_30040211996")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_30040211996", value)
            End Set
          End Property
          Public property TiempoMinimoParaEvaluarTiempoTrabajadoDeMas As Decimal
            get
                return me.GetValue_Decimal("pr_30040211997")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_30040211997", value)
            End Set
          End Property
          Public property RegistrarTurnosAutomaticamenteEnBaseAHorario As Boolean
            get
                return me.GetValue_Boolean("pr_30040212061")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_30040212061", value)
            End Set
          End Property
          Public property CPlazaAvdaObsoleto As String
            get
                return me.GetValue_String("pr_40040220651")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040220651", value)
            End Set
          End Property
          Public property ReferenciaDatosFiscales As Guid
            get
                return me.GetValue_Guid("pr_40040242242")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_40040242242", value)
            End Set
          End Property
          Public property RegistroMercantilLibro As String
            get
                return me.GetValue_String("pr_60040269564")
            End Get
            Set(value As String)
                me.SetValue_String("pr_60040269564", value)
            End Set
          End Property
          Public property RegistroMercantilSeccion As String
            get
                return me.GetValue_String("pr_60040269565")
            End Get
            Set(value As String)
                me.SetValue_String("pr_60040269565", value)
            End Set
          End Property
          Public property ContraseñaDeProteccionParaLasCopiasDeSeguridad As String
            get
                return me.GetValue_String("pr_50040276295")
            End Get
            Set(value As String)
                me.SetValue_String("pr_50040276295", value)
            End Set
          End Property
          Public property FechaDeRenovacionDeCertificadoDeContraseña As Date
            get
                return me.GetValue_Date("pr_60040276291")
            End Get
            Set(value As Date)
                me.SetValue_Date("pr_60040276291", value)
            End Set
          End Property
          Public property NInscripcionSS As String
            get
                return me.GetValue_String("pr_20040278023")
            End Get
            Set(value As String)
                me.SetValue_String("pr_20040278023", value)
            End Set
          End Property
          Public property IdentificadorAcceso As String
            get
                return me.GetValue_String("pr_40040332032")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040332032", value)
            End Set
          End Property
          Public property Notas As String
            get
                return me.GetValue_String("pr_40040291744")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040291744", value)
            End Set
          End Property
          Public property ColorMarca As String
            get
                return me.GetValue_String("pr_40040291743")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040291743", value)
            End Set
          End Property
          Public property TodosLosEmpleadosTienenAcceso As Boolean
            get
                return me.GetValue_Boolean("pr_30040291894")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_30040291894", value)
            End Set
          End Property
          Public property ReferenciaCorreoUtilizadoParaAvisoDeNotificaciones As Guid
            get
                return me.GetValue_Guid("pr_50040260011")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_50040260011", value)
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
