   Imports System.ComponentModel
   Imports DinaNETCore
   Imports DinaNETCore.APID
Partial Public Class SeccionesD
  Public Class RegistrosDeActividadDeServidorD
      Public Shared _SeccionID As String = "2463c953-c539-40b9-998c-ad290b2c5b41"
      Public Shared _SeccionIDGUID As New Guid("2463c953-c539-40b9-998c-ad290b2c5b41")
      Public Shared Async Function ConsultarDatos_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, ParamArray Valor As String()) As Task(Of List(Of RegistrosDeActividadDeServidorC )) 
          Dim R As New List(Of RegistrosDeActividadDeServidorC )  
          Dim d = Await DinaupSesion.ConexionServidor.Funcion_Datos_Recibir_Async(DinaupSesion, RegistrosDeActividadDeServidorES._SeccionID, False, Campo, Valor) 
          If d.Datos.TieneDatos Then 
              For Each Actual In d.Datos 
                  Dim Valores_Listador = Actual.Value.Item1
                  Dim Obj_Listador As New RegistrosDeActividadDeServidorC 
                  Obj_Listador.CargarDatos(Valores_Listador) 
                  R.Add(Obj_Listador) 
              Next 
          End If 
          Return R 
      End Function 
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As RegistrosDeActividadDeServidorC, Optional CampoWhere$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Return Await DatosGuardar_Async(DinaupSesion, New List(Of RegistrosDeActividadDeServidorC)({DAtos}), CampoWhere )
      End Function
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As List(Of RegistrosDeActividadDeServidorC), Optional CampoWhere$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Dim Importar As New List(Of DinaupAPI_ImportacionProcesableC)
          For Each Actual In DAtos 
              Dim RegistroActual = New DinaupAPI_ImportacionProcesableC() 
               RegistroActual.dinaup_listador_datos = Actual.ToDic 
               Importar.Add(RegistroActual)  
          Next 
          Return Await DinaupSesion.ConexionServidor.Funcion_Importar_Ejecutar_Async(DinaupSesion, RegistrosDeActividadDeServidorES._SeccionID, Importar, CampoWhere, "") 
      End Function
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As RegistrosDeActividadDeServidor_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, RegistrosDeActividadDeServidorES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New RegistrosDeActividadDeServidor_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As RegistrosDeActividadDeServidor_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, RegistrosDeActividadDeServidorES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New RegistrosDeActividadDeServidor_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class RegistrosDeActividadDeServidorES
          Public shared _SeccionID as Guid = New Guid("2463c953-c539-40b9-998c-ad290b2c5b41")
          Public shared _Tabla$ = "tpr_70b1f89xd"
      Public Shared Idioma$ = "pr_70b22e9wd"
      Public Shared MemoriaGigabyte$ = "pr_70b22fdwd"
      Public Shared Detalles$ = "pr_70b2315wd"
      Public Shared NombreDeEquipo$ = "pr_70b22e1wd"
      Public Shared EspacioTotalUnidadC$ = "pr_70b2301wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_70b1fe5wd"
      Public Shared RevisionDinaup$ = "pr_70b230dwd"
      Public Shared Plataforma$ = "pr_70b22e5wd"
      Public Shared HoraLocal$ = "pr_776ae1ewd"
      Public Shared ReferenciaDestinador$ = "pr_70b1fb1wd"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_70b1f91wd"
      Public Shared VersionDinaup$ = "pr_70b2309wd"
      Public Shared VersionSistemaOperativo$ = "pr_70b22f1wd"
      Public Shared Procesador$ = "pr_70b22f5wd"
      Public Shared VersionSincronizabilidad$ = "pr_70daa64wd"
      Public Shared EspacioDisponibleUnidadC$ = "pr_70b2305wd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_70b1f95wd"
      Public Shared VersionMinima$ = "pr_70daa60wd"
      Public Shared TiempoDeInicioSegundos$ = "pr_70b2311wd"
      Public Shared ActualizacionesImportantesDeWindowsPendientesDeInstalar$ = "pr_70bf6a0wd"
      Public Shared EsPropioSRV$ = "pr_70dae47wd"
      Public Shared FechaAlta_UTC$ = "pr_70b1fa5wd"
      Public Shared Procesadores$ = "pr_70b22f9wd"
      Public Shared FechaDato_UTC$ = "pr_70b1f99wd"
      Public Shared SistemaOperativo$ = "pr_70b22edwd"
      Public Shared ReferenciaServidor$ = "pr_60040209452"
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
      Public Class RegistrosDeActividadDeServidorC
      Inherits Base_DatoC
          <DisplayName("Idioma")>
          Public Property Idioma As String
          Public Shared ___Idioma As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Idioma"",""etiqueta"": ""Idioma"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Idioma"",""descripcion"": """",""keyword"": ""Idioma"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Idioma As DinaNETCore.APID.DinaupAPI_CampoC = ___Idioma
          <DisplayName("Memoria (Gigabyte)")>
          Public Property MemoriaGigabyte As Integer
          Public Shared ___MemoriaGigabyte As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""MemoriaGigabyte"",""etiqueta"": ""Memoria (Gigabyte)"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Memoria (Gigabyte)"",""descripcion"": """",""keyword"": ""MemoriaGigabyte"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __MemoriaGigabyte As DinaNETCore.APID.DinaupAPI_CampoC = ___MemoriaGigabyte
          <DisplayName("Detalles")>
          Public Property Detalles As String
          Public Shared ___Detalles As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Detalles"",""etiqueta"": ""Detalles"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 9,""decimales"": ""0"",""multilinea"": true,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Detalles"",""descripcion"": """",""keyword"": ""Detalles"",""formato"": 5,""rol"": 9,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Detalles As DinaNETCore.APID.DinaupAPI_CampoC = ___Detalles
          <DisplayName("Nombre de equipo")>
          Public Property NombreDeEquipo As String
          Public Shared ___NombreDeEquipo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""NombreDeEquipo"",""etiqueta"": ""Nombre de equipo"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Nombre de equipo"",""descripcion"": """",""keyword"": ""NombreDeEquipo"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __NombreDeEquipo As DinaNETCore.APID.DinaupAPI_CampoC = ___NombreDeEquipo
          <DisplayName("Espacio total (Unidad C:)")>
          Public Property EspacioTotalUnidadC As Integer
          Public Shared ___EspacioTotalUnidadC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EspacioTotalUnidadC"",""etiqueta"": ""Espacio total (Unidad C:)"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Espacio total (Unidad C:)"",""descripcion"": """",""keyword"": ""EspacioTotalUnidadC"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EspacioTotalUnidadC As DinaNETCore.APID.DinaupAPI_CampoC = ___EspacioTotalUnidadC
          <DisplayName("Autor del alta Tiene Acceso web")>
          Public Property AutorDelAltaTieneAccesoWeb As Boolean
          Public Shared ___AutorDelAltaTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AutorDelAltaTieneAccesoWeb"",""etiqueta"": ""Autor del alta Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta Tiene Acceso web"",""descripcion"": """",""keyword"": ""AutorDelAltaTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AutorDelAltaTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___AutorDelAltaTieneAccesoWeb
          <DisplayName("Revisión Dinaup")>
          Public Property RevisionDinaup As Decimal
          Public Shared ___RevisionDinaup As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RevisionDinaup"",""etiqueta"": ""Revisión Dinaup"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""6"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Revisión Dinaup"",""descripcion"": """",""keyword"": ""RevisionDinaup"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RevisionDinaup As DinaNETCore.APID.DinaupAPI_CampoC = ___RevisionDinaup
          <DisplayName("Plataforma")>
          Public Property Plataforma As String
          Public Shared ___Plataforma As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Plataforma"",""etiqueta"": ""Plataforma"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Plataforma"",""descripcion"": """",""keyword"": ""Plataforma"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Plataforma As DinaNETCore.APID.DinaupAPI_CampoC = ___Plataforma
          <DisplayName("Hora local")>
          Public Property HoraLocal As DateTime?
          Public Shared ___HoraLocal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""HoraLocal"",""etiqueta"": ""Hora local"",""oculta"": false,""formato"": 8,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Hora local"",""descripcion"": """",""keyword"": ""HoraLocal"",""formato"": 8,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __HoraLocal As DinaNETCore.APID.DinaupAPI_CampoC = ___HoraLocal
          <DisplayName("Destinador")>
          Public Property ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaDestinador As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaDestinador"",""etiqueta"": ""Destinador"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""relacionesindirectas"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Destinador"",""descripcion"": """",""keyword"": ""ReferenciaDestinador"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaDestinador
          <DisplayName("Ubicación Principal")>
          Public Property ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaUbicacionPrincipal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaUbicacionPrincipal"",""etiqueta"": ""Ubicación Principal"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""b9adbfbf-a81a-45fb-861c-90502902c982"",""titulo"": ""Ubicaciones"",""iconoid"": ""b985b58f-7275-46b8-9b66-2c54346b0185"",""etiquetasingular"": ""Ubicación"",""etiquetaplural"": ""Ubicaciones"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""b9adbfbf-a81a-45fb-861c-90502902c982"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Ubicación Principal"",""descripcion"": """",""keyword"": ""ReferenciaUbicacionPrincipal"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaUbicacionPrincipal
          <DisplayName("Versión Dinaup")>
          Public Property VersionDinaup As Decimal
          Public Shared ___VersionDinaup As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""VersionDinaup"",""etiqueta"": ""Versión Dinaup"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""6"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Versión Dinaup"",""descripcion"": """",""keyword"": ""VersionDinaup"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __VersionDinaup As DinaNETCore.APID.DinaupAPI_CampoC = ___VersionDinaup
          <DisplayName("Versión Sistema operativo")>
          Public Property VersionSistemaOperativo As String
          Public Shared ___VersionSistemaOperativo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""VersionSistemaOperativo"",""etiqueta"": ""Versión Sistema operativo"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Versión Sistema operativo"",""descripcion"": """",""keyword"": ""VersionSistemaOperativo"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __VersionSistemaOperativo As DinaNETCore.APID.DinaupAPI_CampoC = ___VersionSistemaOperativo
          <DisplayName("Procesador")>
          Public Property Procesador As String
          Public Shared ___Procesador As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Procesador"",""etiqueta"": ""Procesador"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Procesador"",""descripcion"": """",""keyword"": ""Procesador"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Procesador As DinaNETCore.APID.DinaupAPI_CampoC = ___Procesador
          <DisplayName("Versión sincronizabilidad")>
          Public Property VersionSincronizabilidad As Decimal
          Public Shared ___VersionSincronizabilidad As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""VersionSincronizabilidad"",""etiqueta"": ""Versión sincronizabilidad"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""6"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": false,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Versión sincronizabilidad"",""descripcion"": """",""keyword"": ""VersionSincronizabilidad"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __VersionSincronizabilidad As DinaNETCore.APID.DinaupAPI_CampoC = ___VersionSincronizabilidad
          <DisplayName("Espacio disponible (Unidad C:)")>
          Public Property EspacioDisponibleUnidadC As Integer
          Public Shared ___EspacioDisponibleUnidadC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EspacioDisponibleUnidadC"",""etiqueta"": ""Espacio disponible (Unidad C:)"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Espacio disponible (Unidad C:)"",""descripcion"": """",""keyword"": ""EspacioDisponibleUnidadC"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EspacioDisponibleUnidadC As DinaNETCore.APID.DinaupAPI_CampoC = ___EspacioDisponibleUnidadC
          <DisplayName("Autor del alta")>
          Public Property ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaAutorDelAlta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaAutorDelAlta"",""etiqueta"": ""Autor del alta"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta"",""descripcion"": """",""keyword"": ""ReferenciaAutorDelAlta"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaAutorDelAlta
          <DisplayName("Versión mínima")>
          Public Property VersionMinima As Decimal
          Public Shared ___VersionMinima As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""VersionMinima"",""etiqueta"": ""Versión mínima"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""6"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Versión mínima"",""descripcion"": """",""keyword"": ""VersionMinima"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __VersionMinima As DinaNETCore.APID.DinaupAPI_CampoC = ___VersionMinima
          <DisplayName("Tiempo de inicio (Segundos)")>
          Public Property TiempoDeInicioSegundos As Decimal
          Public Shared ___TiempoDeInicioSegundos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TiempoDeInicioSegundos"",""etiqueta"": ""Tiempo de inicio (Segundos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""4"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Tiempo de inicio (Segundos)"",""descripcion"": """",""keyword"": ""TiempoDeInicioSegundos"",""formato"": 3,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __TiempoDeInicioSegundos As DinaNETCore.APID.DinaupAPI_CampoC = ___TiempoDeInicioSegundos
          <DisplayName("Actualizaciones importantes de windows pendientes de instalar")>
          Public Property ActualizacionesImportantesDeWindowsPendientesDeInstalar As Boolean
          Public Shared ___ActualizacionesImportantesDeWindowsPendientesDeInstalar As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ActualizacionesImportantesDeWindowsPendientesDeInstalar"",""etiqueta"": ""Actualizaciones importantes de windows pendientes de instalar"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Actualizaciones importantes de windows pendientes de instalar"",""descripcion"": """",""keyword"": ""ActualizacionesImportantesDeWindowsPendientesDeInstalar"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ActualizacionesImportantesDeWindowsPendientesDeInstalar As DinaNETCore.APID.DinaupAPI_CampoC = ___ActualizacionesImportantesDeWindowsPendientesDeInstalar
          <DisplayName("Es propio SRV")>
          Public Property EsPropioSRV As Boolean
          Public Shared ___EsPropioSRV As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EsPropioSRV"",""etiqueta"": ""Es propio SRV"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Es propio SRV"",""descripcion"": """",""keyword"": ""EsPropioSRV"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EsPropioSRV As DinaNETCore.APID.DinaupAPI_CampoC = ___EsPropioSRV
          <DisplayName("Fecha Alta del registro")>
          Public Property FechaAlta_UTC As Date?
          Public Shared ___FechaAlta_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaAlta_UTC"",""etiqueta"": ""Fecha Alta del registro"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Alta del registro"",""descripcion"": """",""keyword"": ""FechaAlta_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaAlta_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaAlta_UTC
          <DisplayName("Procesadores")>
          Public Property Procesadores As Integer
          Public Shared ___Procesadores As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Procesadores"",""etiqueta"": ""Procesadores"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Procesadores"",""descripcion"": """",""keyword"": ""Procesadores"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Procesadores As DinaNETCore.APID.DinaupAPI_CampoC = ___Procesadores
          <DisplayName("Fecha Dato")>
          Public Property FechaDato_UTC As Date?
          Public Shared ___FechaDato_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaDato_UTC"",""etiqueta"": ""Fecha Dato"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Dato"",""descripcion"": """",""keyword"": ""FechaDato_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaDato_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaDato_UTC
          <DisplayName("Sistema operativo")>
          Public Property SistemaOperativo As String
          Public Shared ___SistemaOperativo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""SistemaOperativo"",""etiqueta"": ""Sistema operativo"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Sistema operativo"",""descripcion"": """",""keyword"": ""SistemaOperativo"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __SistemaOperativo As DinaNETCore.APID.DinaupAPI_CampoC = ___SistemaOperativo
          <DisplayName("Servidor")>
          Public Property ReferenciaServidor As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaServidor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaServidor"",""etiqueta"": ""Servidor"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""eadd8f25-d9e0-46ef-89a7-e95efe769df1"",""titulo"": ""Base - Servidores"",""iconoid"": ""35aab678-4c97-4349-9cad-b4e5b4d301a3"",""etiquetasingular"": ""Servidor"",""etiquetaplural"": ""Servidores"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""eadd8f25-d9e0-46ef-89a7-e95efe769df1"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Servidor"",""descripcion"": """",""keyword"": ""ReferenciaServidor"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaServidor As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaServidor
          <ReadOnlyAttribute(True)>
          <DisplayName("ID")>
          Public Property ID As Guid
          Public Shared ___ID As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": true,""eseliminado"": false,""keyword"": ""ID"",""etiqueta"": ""ID"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""2463c953-c539-40b9-998c-ad290b2c5b41"",""titulo"": ""Registros de actividad de servidor"",""iconoid"": ""693ab0f2-17c1-4865-a0f0-8284e7c8e2ba"",""etiquetasingular"": ""Log de servidor"",""etiquetaplural"": ""Logs de servidores"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""2463c953-c539-40b9-998c-ad290b2c5b41"",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""ID"",""descripcion"": """",""keyword"": ""ID"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
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
          me.Idioma = _Datos.Leer_String("pr_70b22e9wd")
          me.MemoriaGigabyte = _Datos.Leer_Integer("pr_70b22fdwd")
          me.Detalles = _Datos.Leer_String("pr_70b2315wd")
          me.NombreDeEquipo = _Datos.Leer_String("pr_70b22e1wd")
          me.EspacioTotalUnidadC = _Datos.Leer_Integer("pr_70b2301wd")
          me.AutorDelAltaTieneAccesoWeb = _Datos.Leer_Boolean("pr_70b1fe5wd")
          me.RevisionDinaup = _Datos.Leer_Decimal("pr_70b230dwd")
          me.Plataforma = _Datos.Leer_String("pr_70b22e5wd")
          me.HoraLocal = _Datos.Leer_Time_Nulable("pr_776ae1ewd")
          me.ReferenciaDestinador = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_70b1fb1wd"), _Datos.Leer_String("pr_70b1fb1wd.nombre"))
          me.ReferenciaUbicacionPrincipal = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_70b1f91wd"), _Datos.Leer_String("pr_70b1f91wd.nombre"))
          me.VersionDinaup = _Datos.Leer_Decimal("pr_70b2309wd")
          me.VersionSistemaOperativo = _Datos.Leer_String("pr_70b22f1wd")
          me.Procesador = _Datos.Leer_String("pr_70b22f5wd")
          me.VersionSincronizabilidad = _Datos.Leer_Decimal("pr_70daa64wd")
          me.EspacioDisponibleUnidadC = _Datos.Leer_Integer("pr_70b2305wd")
          me.ReferenciaAutorDelAlta = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_70b1f95wd"), _Datos.Leer_String("pr_70b1f95wd.nombre"))
          me.VersionMinima = _Datos.Leer_Decimal("pr_70daa60wd")
          me.TiempoDeInicioSegundos = _Datos.Leer_Decimal("pr_70b2311wd")
          me.ActualizacionesImportantesDeWindowsPendientesDeInstalar = _Datos.Leer_Boolean("pr_70bf6a0wd")
          me.EsPropioSRV = _Datos.Leer_Boolean("pr_70dae47wd")
          me.FechaAlta_UTC = _Datos.Leer_DateTime_Nulable("pr_70b1fa5wd")
          me.Procesadores = _Datos.Leer_Integer("pr_70b22f9wd")
          me.FechaDato_UTC = _Datos.Leer_DateTime_Nulable("pr_70b1f99wd")
          me.SistemaOperativo = _Datos.Leer_String("pr_70b22edwd")
          me.ReferenciaServidor = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_60040209452"), _Datos.Leer_String("pr_60040209452.nombre"))
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
         R.add("pr_70b22e9wd", me.Idioma.AdaptarMySQL_String())
         R.add("pr_70b22fdwd", me.MemoriaGigabyte.AdaptarMySQL_Integer())
         R.add("pr_70b2315wd", me.Detalles.AdaptarMySQL_String())
         R.add("pr_70b22e1wd", me.NombreDeEquipo.AdaptarMySQL_String())
         R.add("pr_70b2301wd", me.EspacioTotalUnidadC.AdaptarMySQL_Integer())
         R.add("pr_70b1fe5wd", me.AutorDelAltaTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_70b230dwd", me.RevisionDinaup.AdaptarMySQL_Decimal())
         R.add("pr_70b22e5wd", me.Plataforma.AdaptarMySQL_String())
         R.add("pr_776ae1ewd", me.HoraLocal.AdaptarMySQL_Time_Nulable())
         If Me.ReferenciaDestinador IsNot nothing then
           R.add("pr_70b1fb1wd",me.ReferenciaDestinador.ID.STR())
         Else
           R.add("pr_70b1fb1wd","")
         End if
         If Me.ReferenciaUbicacionPrincipal IsNot nothing then
           R.add("pr_70b1f91wd",me.ReferenciaUbicacionPrincipal.ID.STR())
         Else
           R.add("pr_70b1f91wd","")
         End if
         R.add("pr_70b2309wd", me.VersionDinaup.AdaptarMySQL_Decimal())
         R.add("pr_70b22f1wd", me.VersionSistemaOperativo.AdaptarMySQL_String())
         R.add("pr_70b22f5wd", me.Procesador.AdaptarMySQL_String())
         R.add("pr_70daa64wd", me.VersionSincronizabilidad.AdaptarMySQL_Decimal())
         R.add("pr_70b2305wd", me.EspacioDisponibleUnidadC.AdaptarMySQL_Integer())
         If Me.ReferenciaAutorDelAlta IsNot nothing then
           R.add("pr_70b1f95wd",me.ReferenciaAutorDelAlta.ID.STR())
         Else
           R.add("pr_70b1f95wd","")
         End if
         R.add("pr_70daa60wd", me.VersionMinima.AdaptarMySQL_Decimal())
         R.add("pr_70b2311wd", me.TiempoDeInicioSegundos.AdaptarMySQL_Decimal())
         R.add("pr_70bf6a0wd", me.ActualizacionesImportantesDeWindowsPendientesDeInstalar.AdaptarMySQL_Boolean())
         R.add("pr_70dae47wd", me.EsPropioSRV.AdaptarMySQL_Boolean())
         R.add("pr_70b1fa5wd", me.FechaAlta_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_70b22f9wd", me.Procesadores.AdaptarMySQL_Integer())
         R.add("pr_70b1f99wd", me.FechaDato_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_70b22edwd", me.SistemaOperativo.AdaptarMySQL_String())
         If Me.ReferenciaServidor IsNot nothing then
           R.add("pr_60040209452",me.ReferenciaServidor.ID.STR())
         Else
           R.add("pr_60040209452","")
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
      Public Class RegistrosDeActividadDeServidor_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
        Public ReadOnly property Idioma As String
            get
                return me.GetValue_String("pr_70b22e9wd")
            End Get   
        End Property
        Public ReadOnly property MemoriaGigabyte As Integer
            get
                return me.GetValue_Int("pr_70b22fdwd")
            End Get   
        End Property
        Public ReadOnly property Detalles As String
            get
                return me.GetValue_String("pr_70b2315wd")
            End Get   
        End Property
        Public ReadOnly property NombreDeEquipo As String
            get
                return me.GetValue_String("pr_70b22e1wd")
            End Get   
        End Property
        Public ReadOnly property EspacioTotalUnidadC As Integer
            get
                return me.GetValue_Int("pr_70b2301wd")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_70b1fe5wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_70b1fe5wd", value)
            End Set
          End Property
        Public ReadOnly property RevisionDinaup As Decimal
            get
                return me.GetValue_Decimal("pr_70b230dwd")
            End Get   
        End Property
        Public ReadOnly property Plataforma As String
            get
                return me.GetValue_String("pr_70b22e5wd")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As DateTime
            get
                return me.GetValue_DateTime("pr_776ae1ewd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_70b1fb1wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaUbicacionPrincipal As Guid
            get
                return me.GetValue_Guid("pr_70b1f91wd")
            End Get   
        End Property
        Public ReadOnly property VersionDinaup As Decimal
            get
                return me.GetValue_Decimal("pr_70b2309wd")
            End Get   
        End Property
        Public ReadOnly property VersionSistemaOperativo As String
            get
                return me.GetValue_String("pr_70b22f1wd")
            End Get   
        End Property
        Public ReadOnly property Procesador As String
            get
                return me.GetValue_String("pr_70b22f5wd")
            End Get   
        End Property
        Public ReadOnly property VersionSincronizabilidad As Decimal
            get
                return me.GetValue_Decimal("pr_70daa64wd")
            End Get   
        End Property
        Public ReadOnly property EspacioDisponibleUnidadC As Integer
            get
                return me.GetValue_Int("pr_70b2305wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_70b1f95wd")
            End Get   
        End Property
        Public ReadOnly property VersionMinima As Decimal
            get
                return me.GetValue_Decimal("pr_70daa60wd")
            End Get   
        End Property
        Public ReadOnly property TiempoDeInicioSegundos As Decimal
            get
                return me.GetValue_Decimal("pr_70b2311wd")
            End Get   
        End Property
        Public ReadOnly property ActualizacionesImportantesDeWindowsPendientesDeInstalar As Boolean
            get
                return me.GetValue_Boolean("pr_70bf6a0wd")
            End Get   
        End Property
        Public ReadOnly property EsPropioSRV As Boolean
            get
                return me.GetValue_Boolean("pr_70dae47wd")
            End Get   
        End Property
        Public ReadOnly property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_70b1fa5wd")
            End Get   
        End Property
        Public ReadOnly property Procesadores As Integer
            get
                return me.GetValue_Int("pr_70b22f9wd")
            End Get   
        End Property
        Public ReadOnly property FechaDato_UTC As Date
            get
                return me.GetValue_DateTime("pr_70b1f99wd")
            End Get   
        End Property
        Public ReadOnly property SistemaOperativo As String
            get
                return me.GetValue_String("pr_70b22edwd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaServidor As Guid
            get
                return me.GetValue_Guid("pr_60040209452")
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
