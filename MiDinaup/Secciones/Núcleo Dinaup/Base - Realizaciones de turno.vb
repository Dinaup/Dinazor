   Imports System.ComponentModel
   Imports DinaNETCore
   Imports DinaNETCore.APID
Partial Public Class SeccionesD
  Public Class RealizacionesDeTurnoBaseD
      Public Class RealizacionesDeTurnoBase_ConListaC
      Public Listador as RealizacionesDeTurnoBaseC
      Public Lista As New List(of RealizacionesDeTurnoBaseListaD.RealizacionesDeTurnoBaseListaC)
        sub new(_listador  as RealizacionesDeTurnoBaseC, _lista as List(of RealizacionesDeTurnoBaseListaD.RealizacionesDeTurnoBaseListaC))
           me.Listador =_listador 
           me.Lista =_lista 
        End sub
      End Class
      Public Shared _SeccionID As String = "f37b92fc-5a3d-4d1e-ace9-30404c40a5f3"
      Public Shared _SeccionIDGUID As New Guid("f37b92fc-5a3d-4d1e-ace9-30404c40a5f3")
      Public Shared Async Function ConsultarDatos_Async(Parametros As SeccionConsultaParametrosC) As Task(Of List(Of RealizacionesDeTurnoBaseC )) 
          Dim R As New List(Of RealizacionesDeTurnoBaseC )  
          Dim d = Await Parametros.DinaupSesion.ConexionServidor.Funcion_Datos_Recibir_Async(RealizacionesDeTurnoBaseES._SeccionID, False, Parametros) 
          If d.Datos.TieneDatos Then 
              For Each Actual In d.Datos 
                  Dim Valores_Listador = Actual.Value.Item1
                  Dim Obj_Listador As New RealizacionesDeTurnoBaseC 
                  Obj_Listador.CargarDatos(Valores_Listador) 
                  Obj_Listador.CargaInterna(Actual.Value)
                  R.Add(Obj_Listador) 
              Next 
          End If 
          Return R 
      End Function 
      Public Shared Async Function ConsultarDatos_ConLista_Async(  Parametros As SeccionConsultaParametrosC ) As Task(Of List(Of  RealizacionesDeTurnoBase_ConListaC)) 
          Dim R As New List(Of RealizacionesDeTurnoBase_ConListaC )  
          Dim d =  Await Parametros.DinaupSesion.ConexionServidor.Funcion_Datos_Recibir_Async(RealizacionesDeTurnoBaseES._SeccionID, True, Parametros) 
          If d.Datos.TieneDatos Then 
              For Each Actual In d.Datos 
                  Dim Valores_Listador = Actual.Value.Item1
                  Dim Valores_Lista = Actual.Value.Item2
                  Dim Obj_Listador As New RealizacionesDeTurnoBaseC 
                  Obj_Listador.CargarDatos(Valores_Listador) 
                  Obj_Listador.CargaInterna(Actual.Value)
                  Dim Objs_Listas As New List(Of RealizacionesDeTurnoBaseListaD.RealizacionesDeTurnoBaseListaC) 
                  If Valores_Lista.TieneDatos Then  
                      For Each ValoresLista In Valores_Lista 
                         Dim nItem As New RealizacionesDeTurnoBaseListaD.RealizacionesDeTurnoBaseListaC 
                         nItem.CargarDatos(ValoresLista)   
                         Objs_Listas.Add(nItem)         
                      Next   
                  End If   
                  R.Add(New RealizacionesDeTurnoBase_ConListaC(Obj_Listador, Objs_Listas))
              Next 
          End If 
          Return R 
      End Function 
      Public Class RealizacionesDeTurnoBaseES
          Public shared _SeccionID as Guid = New Guid("f37b92fc-5a3d-4d1e-ace9-30404c40a5f3")
          Public shared _Tabla$ = "tpr_63e63f9xd"
      Public Shared MinutosConSesionActiva$ = "pr_1873d23d48x3e4wd"
      Public Shared RegistrosEliminados$ = "pr_186415d176xccwd"
      Public Shared ReferenciaJornada$ = "pr_30040103153"
      Public Shared InformesVisualizados$ = "pr_186410cfabx328wd"
      Public Shared ReferenciaUltimoControlPresencialDeLaRealizacionObsoleto$ = "pr_1863f72522xd7wd"
      Public Shared HoraEnLaQueFinalizo_UTC$ = "pr_1863d56b05x327wd"
      Public Shared SesionesIniciadas$ = "pr_1864145b2axeawd"
      Public Shared MinutosRetrasoEntrada$ = "pr_1863e9ef8dx221wd"
      Public Shared HoraProgramadaDeFin_UTC$ = "pr_1863d05476x6awd"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_1863c96f39x2awd"
      Public Shared RegistrosRestaurados$ = "pr_1864168675x2a5wd"
      Public Shared RealizacionAgregadaAutomaticamente$ = "pr_18756c9ac6x85wd"
      Public Shared MinutosRetrasoSalida$ = "pr_1863ea67cbx217wd"
      Public Shared ReferenciaDestinador$ = "pr_1863b69bc5x86wd"
      Public Shared HoraLocal$ = "pr_776ae16wd"
      Public Shared ControlesPresencialesObsoleto$ = "pr_186415015fx7dwd"
      Public Shared ReferenciaAsignacionDeHorario$ = "pr_30040103156"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_1863c96f56x31dwd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_1863c09a8ax1b5wd"
      Public Shared RegistrosVisitados$ = "pr_1864133a72x194wd"
      Public Shared RegistrosAgregados$ = "pr_186411ab2dx4dwd"
      Public Shared DuracionTurnoEnMinutos$ = "pr_1863e88aa5x128wd"
      Public Shared ReferenciaTurnoDeJornada$ = "pr_30040103154"
      Public Shared ReferenciaAutorDelAlta$ = "pr_1863b69b6ex213wd"
      Public Shared EstadoDeLaRealizacion$ = "pr_30040103561"
      Public Shared HoraProgramadaDeInicio_UTC$ = "pr_1863cf7342x2cfwd"
      Public Shared ReferenciaTurnoDeHorario$ = "pr_1863d18f7bx1e7wd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_1863ca986fx36cwd"
      Public Shared RegistrosModificados$ = "pr_186412b750x102wd"
      Public Shared RealizacionEnMinutos$ = "pr_1863e95bdfx236wd"
      Public Shared ReferenciaMotivoDeLaRealizacionObsoleto$ = "pr_50040112221"
      Public Shared FechaAlta_UTC$ = "pr_1863b69b89x23ewd"
      Public Shared ExportarEnModulos$ = "pr_191d3d44fbx2bfwd"
      Public Shared FechaDato_UTC$ = "pr_1863c96f6bx340wd"
      Public Shared HoraEnLaQueInicio_UTC$ = "pr_1863d4dfc1x28ewd"
      Public Shared ReferenciaHorario$ = "pr_1863d10038x3ccwd"
      Public Shared ReferenciaPrimerControlPresencialDeLaRealizacionObsoleto$ = "pr_1863f6083fx36wd"
      Public Shared MinutosExtrasTrabajados$ = "pr_1864ee2a65xfawd"
      Public Shared AdaptarElImporteAPagarSegunElHorarioRealizado$ = "pr_10040139172"
      Public Shared Observaciones$ = "pr_20040138403"
      Public Shared EsDeFuerzaMayor$ = "pr_20040138404"
      Public Shared ImporteImportePorHoraNoRealizadaDentroDeHorario$ = "pr_20040138406"
      Public Shared TotalHorasExtraEnNominaEnMinutos$ = "pr_30040139131"
      Public Shared ImporteImportePorHoraRealizadaFueraDeHorario$ = "pr_30040139132"
      Public Shared FechaDeRealizacion$ = "pr_10040139141"
      Public Shared RealizacionConcluida$ = "pr_40040209613"
      Public Shared MargenDeFinDeTurno$ = "pr_50040210384"
      Public Shared MargenDeInicioDeTurno$ = "pr_50040210385"
      Public Shared FechaMaximaDeFinDeTurno_UTC$ = "pr_60040210381"
      Public Shared FechaMinimaDeInicioDeTurno_UTC$ = "pr_60040210382"
      Public Shared TipoDeTurno$ = "pr_40040210832"
      Public Shared ImporteImporteDeduccionPorHorasNoRealizadas$ = "pr_60040211101"
      Public Shared ImporteImporteTotalDevengoPorHorasExtra$ = "pr_60040211102"
      Public Shared TotalHorasRealizadasDeMenosEnNominaEnMinutos$ = "pr_50040211101"
      Public Shared TiempoMinimoParaEvaluarTiempoTrabajadoDeMas$ = "pr_30040211302"
      Public Shared TiempoMinimoParaEvaluarTiempoTrabajadoDeMenos$ = "pr_30040211303"
      Public Shared ReferenciaMotivoAusenciaORetraso$ = "pr_30040212244"
      Public Shared ReferenciaMotivoHorasExtra$ = "pr_30040212245"
      Public Shared ReferenciaPrimerInicioDeSesion$ = "pr_10040243741"
      Public Shared ReferenciaUltimoCierreDeSesion$ = "pr_30040243742"
      Public Shared DescripcionCorta$ = "pr_10040256424"
      Public Shared ModoDeCotizacion$ = "pr_20040360102"
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
      Public Class RealizacionesDeTurnoBaseC
      Inherits Base_DatoC
          <DisplayName("Minutos con sesión activa")>
          Public Property MinutosConSesionActiva As Integer
          Public Shared ___MinutosConSesionActiva As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""MinutosConSesionActiva"",""etiqueta"": ""Minutos con sesión activa"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 14,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Minutos con sesión activa"",""descripcion"": """",""keyword"": ""MinutosConSesionActiva"",""formato"": 2,""rol"": 14,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __MinutosConSesionActiva As DinaNETCore.APID.DinaupAPI_CampoC = ___MinutosConSesionActiva
          <DisplayName("Registros eliminados")>
          Public Property RegistrosEliminados As Integer
          Public Shared ___RegistrosEliminados As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RegistrosEliminados"",""etiqueta"": ""Registros eliminados"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Registros eliminados"",""descripcion"": """",""keyword"": ""RegistrosEliminados"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RegistrosEliminados As DinaNETCore.APID.DinaupAPI_CampoC = ___RegistrosEliminados
          <DisplayName("Jornada")>
          Public Property ReferenciaJornada As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaJornada As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaJornada"",""etiqueta"": ""Jornada"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""1b77c8fd-5ac4-4cf7-af16-dba29a1c2182"",""titulo"": ""Base - Definición de jornadas"",""iconoid"": ""9c1f72f0-020e-4368-b411-13bb93284755"",""etiquetasingular"": ""Definición de jornada"",""etiquetaplural"": ""Definiciones de jornada"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""1b77c8fd-5ac4-4cf7-af16-dba29a1c2182"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Jornada"",""descripcion"": """",""keyword"": ""ReferenciaJornada"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaJornada As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaJornada
          <DisplayName("Informes visualizados")>
          Public Property InformesVisualizados As Integer
          Public Shared ___InformesVisualizados As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""InformesVisualizados"",""etiqueta"": ""Informes visualizados"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Informes visualizados"",""descripcion"": """",""keyword"": ""InformesVisualizados"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __InformesVisualizados As DinaNETCore.APID.DinaupAPI_CampoC = ___InformesVisualizados
          <DisplayName("Último control presencial de la realización (Obsoleto)")>
          Public Property ReferenciaUltimoControlPresencialDeLaRealizacionObsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaUltimoControlPresencialDeLaRealizacionObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaUltimoControlPresencialDeLaRealizacionObsoleto"",""etiqueta"": ""Último control presencial de la realización (Obsoleto)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""ccc34d94-b2df-4307-b440-c45ee8ac8b81"",""titulo"": ""Base - Control de presencia"",""iconoid"": ""5ada56f9-4d51-412b-af3b-d39db1391cbd"",""etiquetasingular"": ""Control de presencia"",""etiquetaplural"": ""Controles de presencia"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""ccc34d94-b2df-4307-b440-c45ee8ac8b81"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Último control presencial de la realización (Obsoleto)"",""descripcion"": """",""keyword"": ""ReferenciaUltimoControlPresencialDeLaRealizacionObsoleto"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaUltimoControlPresencialDeLaRealizacionObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaUltimoControlPresencialDeLaRealizacionObsoleto
          <DisplayName("Hora en la que finalizó")>
          Public Property HoraEnLaQueFinalizo_UTC As Date?
          Public Shared ___HoraEnLaQueFinalizo_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""HoraEnLaQueFinalizo_UTC"",""etiqueta"": ""Hora en la que finalizó"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 22,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Hora en la que finalizó"",""descripcion"": """",""keyword"": ""HoraEnLaQueFinalizo_UTC"",""formato"": 6,""rol"": 22,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __HoraEnLaQueFinalizo_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___HoraEnLaQueFinalizo_UTC
          <DisplayName("Sesiones iniciadas")>
          Public Property SesionesIniciadas As Integer
          Public Shared ___SesionesIniciadas As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""SesionesIniciadas"",""etiqueta"": ""Sesiones iniciadas"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Sesiones iniciadas"",""descripcion"": """",""keyword"": ""SesionesIniciadas"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __SesionesIniciadas As DinaNETCore.APID.DinaupAPI_CampoC = ___SesionesIniciadas
          <DisplayName("Minutos retraso entrada")>
          Public Property MinutosRetrasoEntrada As Integer
          Public Shared ___MinutosRetrasoEntrada As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""MinutosRetrasoEntrada"",""etiqueta"": ""Minutos retraso entrada"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 14,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Minutos retraso entrada"",""descripcion"": """",""keyword"": ""MinutosRetrasoEntrada"",""formato"": 2,""rol"": 14,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __MinutosRetrasoEntrada As DinaNETCore.APID.DinaupAPI_CampoC = ___MinutosRetrasoEntrada
          <DisplayName("Hora programada de fin")>
          Public Property HoraProgramadaDeFin_UTC As Date?
          Public Shared ___HoraProgramadaDeFin_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""HoraProgramadaDeFin_UTC"",""etiqueta"": ""Hora programada de fin"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 22,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Hora programada de fin"",""descripcion"": """",""keyword"": ""HoraProgramadaDeFin_UTC"",""formato"": 6,""rol"": 22,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __HoraProgramadaDeFin_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___HoraProgramadaDeFin_UTC
          <DisplayName("Empleado")>
          Public Property ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaEmpleadoPrincipal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaEmpleadoPrincipal"",""etiqueta"": ""Empleado"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empleado"",""descripcion"": """",""keyword"": ""ReferenciaEmpleadoPrincipal"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaEmpleadoPrincipal
          <DisplayName("Registros restaurados")>
          Public Property RegistrosRestaurados As Integer
          Public Shared ___RegistrosRestaurados As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RegistrosRestaurados"",""etiqueta"": ""Registros restaurados"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Registros restaurados"",""descripcion"": """",""keyword"": ""RegistrosRestaurados"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RegistrosRestaurados As DinaNETCore.APID.DinaupAPI_CampoC = ___RegistrosRestaurados
          <DisplayName("Realización agregada automáticamente")>
          Public Property RealizacionAgregadaAutomaticamente As Boolean
          Public Shared ___RealizacionAgregadaAutomaticamente As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RealizacionAgregadaAutomaticamente"",""etiqueta"": ""Realización agregada automáticamente"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Realización agregada automáticamente"",""descripcion"": """",""keyword"": ""RealizacionAgregadaAutomaticamente"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RealizacionAgregadaAutomaticamente As DinaNETCore.APID.DinaupAPI_CampoC = ___RealizacionAgregadaAutomaticamente
          <DisplayName("Minutos retraso salida")>
          Public Property MinutosRetrasoSalida As Integer
          Public Shared ___MinutosRetrasoSalida As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""MinutosRetrasoSalida"",""etiqueta"": ""Minutos retraso salida"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 14,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Minutos retraso salida"",""descripcion"": """",""keyword"": ""MinutosRetrasoSalida"",""formato"": 2,""rol"": 14,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __MinutosRetrasoSalida As DinaNETCore.APID.DinaupAPI_CampoC = ___MinutosRetrasoSalida
          <DisplayName("Destinador")>
          Public Property ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaDestinador As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaDestinador"",""etiqueta"": ""Destinador"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""relacionesindirectas"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Destinador"",""descripcion"": """",""keyword"": ""ReferenciaDestinador"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaDestinador
          <DisplayName("Hora local")>
          Public Property HoraLocal As DateTime?
          Public Shared ___HoraLocal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""HoraLocal"",""etiqueta"": ""Hora local"",""oculta"": false,""formato"": 8,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Hora local"",""descripcion"": """",""keyword"": ""HoraLocal"",""formato"": 8,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __HoraLocal As DinaNETCore.APID.DinaupAPI_CampoC = ___HoraLocal
          <DisplayName("Controles presenciales (Obsoleto)")>
          Public Property ControlesPresencialesObsoleto As Integer
          Public Shared ___ControlesPresencialesObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ControlesPresencialesObsoleto"",""etiqueta"": ""Controles presenciales (Obsoleto)"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Controles presenciales (Obsoleto)"",""descripcion"": """",""keyword"": ""ControlesPresencialesObsoleto"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ControlesPresencialesObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___ControlesPresencialesObsoleto
          <DisplayName("Asignación de horario")>
          Public Property ReferenciaAsignacionDeHorario As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaAsignacionDeHorario As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaAsignacionDeHorario"",""etiqueta"": ""Asignación de horario"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""642091f3-9857-4f52-9a8b-939f358f013d"",""titulo"": ""Base - Asignación de horarios"",""iconoid"": ""bd322bd3-25ec-4b5b-9bf2-99874fa1c224"",""etiquetasingular"": ""Asignación de horario"",""etiquetaplural"": ""Asignaciones de horario"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""642091f3-9857-4f52-9a8b-939f358f013d"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Asignación de horario"",""descripcion"": """",""keyword"": ""ReferenciaAsignacionDeHorario"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaAsignacionDeHorario As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaAsignacionDeHorario
          <DisplayName("Ubicación Principal")>
          Public Property ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaUbicacionPrincipal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaUbicacionPrincipal"",""etiqueta"": ""Ubicación Principal"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""bffd6c6e-a75b-455f-8367-067e7bb2fb47"",""titulo"": ""Base - Ubicaciones"",""iconoid"": ""b985b58f-7275-46b8-9b66-2c54346b0185"",""etiquetasingular"": ""Ubicación"",""etiquetaplural"": ""Ubicaciones"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""bffd6c6e-a75b-455f-8367-067e7bb2fb47"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Ubicación Principal"",""descripcion"": """",""keyword"": ""ReferenciaUbicacionPrincipal"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaUbicacionPrincipal
          <DisplayName("Autor del alta Tiene Acceso web")>
          Public Property AutorDelAltaTieneAccesoWeb As Boolean
          Public Shared ___AutorDelAltaTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AutorDelAltaTieneAccesoWeb"",""etiqueta"": ""Autor del alta Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta Tiene Acceso web"",""descripcion"": """",""keyword"": ""AutorDelAltaTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AutorDelAltaTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___AutorDelAltaTieneAccesoWeb
          <DisplayName("Registros visitados")>
          Public Property RegistrosVisitados As Integer
          Public Shared ___RegistrosVisitados As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RegistrosVisitados"",""etiqueta"": ""Registros visitados"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Registros visitados"",""descripcion"": """",""keyword"": ""RegistrosVisitados"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RegistrosVisitados As DinaNETCore.APID.DinaupAPI_CampoC = ___RegistrosVisitados
          <DisplayName("Registros agregados")>
          Public Property RegistrosAgregados As Integer
          Public Shared ___RegistrosAgregados As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RegistrosAgregados"",""etiqueta"": ""Registros agregados"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Registros agregados"",""descripcion"": """",""keyword"": ""RegistrosAgregados"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RegistrosAgregados As DinaNETCore.APID.DinaupAPI_CampoC = ___RegistrosAgregados
          <DisplayName("Duración turno en minutos")>
          Public Property DuracionTurnoEnMinutos As Integer
          Public Shared ___DuracionTurnoEnMinutos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DuracionTurnoEnMinutos"",""etiqueta"": ""Duración turno en minutos"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 14,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Duración turno en minutos"",""descripcion"": """",""keyword"": ""DuracionTurnoEnMinutos"",""formato"": 2,""rol"": 14,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DuracionTurnoEnMinutos As DinaNETCore.APID.DinaupAPI_CampoC = ___DuracionTurnoEnMinutos
          <DisplayName("Turno de Jornada")>
          Public Property ReferenciaTurnoDeJornada As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaTurnoDeJornada As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaTurnoDeJornada"",""etiqueta"": ""Turno de Jornada"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""605ee753-64fa-4cce-84e3-651382a794db"",""titulo"": ""Base Lista - Definición de jornadas"",""iconoid"": ""9c1f72f0-020e-4368-b411-13bb93284755"",""etiquetasingular"": ""Intervalo de jornada"",""etiquetaplural"": ""Intervalos de jornada"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": true,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""605ee753-64fa-4cce-84e3-651382a794db"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Turno de Jornada"",""descripcion"": """",""keyword"": ""ReferenciaTurnoDeJornada"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaTurnoDeJornada As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaTurnoDeJornada
          <DisplayName("Autor del alta")>
          Public Property ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaAutorDelAlta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaAutorDelAlta"",""etiqueta"": ""Autor del alta"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta"",""descripcion"": """",""keyword"": ""ReferenciaAutorDelAlta"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaAutorDelAlta
          <DisplayName("Estado de la realización")>
          Public Property EstadoDeLaRealizacion As EnumTipoDeRealizacionDeTurnoE
          Public Shared ___EstadoDeLaRealizacion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EstadoDeLaRealizacion"",""etiqueta"": ""Estado de la realización"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 46,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [0,1,2,3,4,5,6],""predefinidos_textos"": [""Indefinido"",""Ausencia"",""Presente"",""Cancelada"",""Programada"",""En curso"",""Esperando inicio""],""predefinidos_iconos"": [""https://cdn.dinaup.com/ico/enums/46_0.png"",""https://cdn.dinaup.com/ico/enums/46_1.png"",""https://cdn.dinaup.com/ico/enums/46_2.png"",""https://cdn.dinaup.com/ico/enums/46_3.png"",""https://cdn.dinaup.com/ico/enums/46_4.png"",""https://cdn.dinaup.com/ico/enums/46_5.png"",""https://cdn.dinaup.com/ico/enums/46_6.png""],""filtro"": {""titulo"": ""Estado de la realización"",""descripcion"": """",""keyword"": ""EstadoDeLaRealizacion"",""formato"": 2,""rol"": 46,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false,""enumeracion"": {""titulo"": ""Enum - Tipo de realización de turno"", ""valores"": [{""valor"": 0, ""titulo"": ""Indefinido""},{""valor"": 1, ""titulo"": ""Ausencia""},{""valor"": 2, ""titulo"": ""Presente""},{""valor"": 3, ""titulo"": ""Cancelada""},{""valor"": 4, ""titulo"": ""Programada""},{""valor"": 5, ""titulo"": ""En curso""},{""valor"": 6, ""titulo"": ""Esperando inicio""}]}},""solovalorespredefinidos"": true}")
          Public  __EstadoDeLaRealizacion As DinaNETCore.APID.DinaupAPI_CampoC = ___EstadoDeLaRealizacion
          <DisplayName("Hora programada de inicio")>
          Public Property HoraProgramadaDeInicio_UTC As Date?
          Public Shared ___HoraProgramadaDeInicio_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""HoraProgramadaDeInicio_UTC"",""etiqueta"": ""Hora programada de inicio"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 22,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Hora programada de inicio"",""descripcion"": """",""keyword"": ""HoraProgramadaDeInicio_UTC"",""formato"": 6,""rol"": 22,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __HoraProgramadaDeInicio_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___HoraProgramadaDeInicio_UTC
          <DisplayName("Turno de horario")>
          Public Property ReferenciaTurnoDeHorario As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaTurnoDeHorario As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaTurnoDeHorario"",""etiqueta"": ""Turno de horario"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""cd8de914-43c4-492e-a984-03bcdfc3fba5"",""titulo"": ""Base Lista - Horarios"",""iconoid"": ""a85f4a18-2aac-46c9-9cd6-60f8b1cd9883"",""etiquetasingular"": ""Jornada de Horario"",""etiquetaplural"": ""Jornadas de Horario"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": true,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""cd8de914-43c4-492e-a984-03bcdfc3fba5"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Turno de horario"",""descripcion"": """",""keyword"": ""ReferenciaTurnoDeHorario"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaTurnoDeHorario As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaTurnoDeHorario
          <DisplayName("Empleado Tiene Acceso web")>
          Public Property EmpleadoTieneAccesoWeb As Boolean
          Public Shared ___EmpleadoTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EmpleadoTieneAccesoWeb"",""etiqueta"": ""Empleado Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empleado Tiene Acceso web"",""descripcion"": """",""keyword"": ""EmpleadoTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EmpleadoTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___EmpleadoTieneAccesoWeb
          <DisplayName("Registros modificados")>
          Public Property RegistrosModificados As Integer
          Public Shared ___RegistrosModificados As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RegistrosModificados"",""etiqueta"": ""Registros modificados"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Registros modificados"",""descripcion"": """",""keyword"": ""RegistrosModificados"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RegistrosModificados As DinaNETCore.APID.DinaupAPI_CampoC = ___RegistrosModificados
          <DisplayName("Realización en minutos")>
          Public Property RealizacionEnMinutos As Integer
          Public Shared ___RealizacionEnMinutos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RealizacionEnMinutos"",""etiqueta"": ""Realización en minutos"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 14,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Realización en minutos"",""descripcion"": """",""keyword"": ""RealizacionEnMinutos"",""formato"": 2,""rol"": 14,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RealizacionEnMinutos As DinaNETCore.APID.DinaupAPI_CampoC = ___RealizacionEnMinutos
          <DisplayName("Motivo de la realización (Obsoleto)")>
          Public Property ReferenciaMotivoDeLaRealizacionObsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaMotivoDeLaRealizacionObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaMotivoDeLaRealizacionObsoleto"",""etiqueta"": ""Motivo de la realización (Obsoleto)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""93baaee5-b723-4642-8e9d-c8d34d683f15"",""titulo"": ""Base - Motivos de realización de turnos"",""iconoid"": ""91bfd55e-338f-47ac-a7ca-4c0af172d491"",""etiquetasingular"": ""Motivo de realización de turno"",""etiquetaplural"": ""Motivos de realización de turnos"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""93baaee5-b723-4642-8e9d-c8d34d683f15"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Motivo de la realización (Obsoleto)"",""descripcion"": """",""keyword"": ""ReferenciaMotivoDeLaRealizacionObsoleto"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaMotivoDeLaRealizacionObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaMotivoDeLaRealizacionObsoleto
          <DisplayName("Fecha Alta del registro")>
          Public Property FechaAlta_UTC As Date?
          Public Shared ___FechaAlta_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaAlta_UTC"",""etiqueta"": ""Fecha Alta del registro"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Alta del registro"",""descripcion"": """",""keyword"": ""FechaAlta_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaAlta_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaAlta_UTC
          <DisplayName("Fecha Dato")>
          Public Property FechaDato_UTC As Date?
          Public Shared ___FechaDato_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaDato_UTC"",""etiqueta"": ""Fecha Dato"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Dato"",""descripcion"": """",""keyword"": ""FechaDato_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaDato_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaDato_UTC
          <DisplayName("Hora en la que inició")>
          Public Property HoraEnLaQueInicio_UTC As Date?
          Public Shared ___HoraEnLaQueInicio_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""HoraEnLaQueInicio_UTC"",""etiqueta"": ""Hora en la que inició"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 22,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Hora en la que inició"",""descripcion"": """",""keyword"": ""HoraEnLaQueInicio_UTC"",""formato"": 6,""rol"": 22,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __HoraEnLaQueInicio_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___HoraEnLaQueInicio_UTC
          <DisplayName("Horario")>
          Public Property ReferenciaHorario As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaHorario As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaHorario"",""etiqueta"": ""Horario"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""71a50a3a-b4d6-4cb0-8a52-aa38c7a5b697"",""titulo"": ""Base - Horarios"",""iconoid"": ""f1130b1d-ee71-406d-ae30-f16ac94e0e45"",""etiquetasingular"": ""Horario"",""etiquetaplural"": ""Horarios"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""71a50a3a-b4d6-4cb0-8a52-aa38c7a5b697"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Horario"",""descripcion"": """",""keyword"": ""ReferenciaHorario"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaHorario As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaHorario
          <DisplayName("Primer control presencial de la realización (Obsoleto)")>
          Public Property ReferenciaPrimerControlPresencialDeLaRealizacionObsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaPrimerControlPresencialDeLaRealizacionObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaPrimerControlPresencialDeLaRealizacionObsoleto"",""etiqueta"": ""Primer control presencial de la realización (Obsoleto)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""ccc34d94-b2df-4307-b440-c45ee8ac8b81"",""titulo"": ""Base - Control de presencia"",""iconoid"": ""5ada56f9-4d51-412b-af3b-d39db1391cbd"",""etiquetasingular"": ""Control de presencia"",""etiquetaplural"": ""Controles de presencia"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""ccc34d94-b2df-4307-b440-c45ee8ac8b81"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Primer control presencial de la realización (Obsoleto)"",""descripcion"": """",""keyword"": ""ReferenciaPrimerControlPresencialDeLaRealizacionObsoleto"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaPrimerControlPresencialDeLaRealizacionObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaPrimerControlPresencialDeLaRealizacionObsoleto
          <DisplayName("Minutos extras trabajados")>
          Public Property MinutosExtrasTrabajados As Integer
          Public Shared ___MinutosExtrasTrabajados As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""MinutosExtrasTrabajados"",""etiqueta"": ""Minutos extras trabajados"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 14,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Minutos extras trabajados"",""descripcion"": """",""keyword"": ""MinutosExtrasTrabajados"",""formato"": 2,""rol"": 14,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __MinutosExtrasTrabajados As DinaNETCore.APID.DinaupAPI_CampoC = ___MinutosExtrasTrabajados
          <DisplayName("Adaptar el importe a pagar según el horario realizado.")>
          Public Property AdaptarElImporteAPagarSegunElHorarioRealizado As Boolean
          Public Shared ___AdaptarElImporteAPagarSegunElHorarioRealizado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AdaptarElImporteAPagarSegunElHorarioRealizado"",""etiqueta"": ""Adaptar el importe a pagar según el horario realizado."",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Adaptar el importe a pagar según el horario realizado."",""descripcion"": """",""keyword"": ""AdaptarElImporteAPagarSegunElHorarioRealizado"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AdaptarElImporteAPagarSegunElHorarioRealizado As DinaNETCore.APID.DinaupAPI_CampoC = ___AdaptarElImporteAPagarSegunElHorarioRealizado
          <DisplayName("Observaciones")>
          Public Property Observaciones As String
          Public Shared ___Observaciones As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Observaciones"",""etiqueta"": ""Observaciones"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 9,""decimales"": ""0"",""multilinea"": true,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Observaciones"",""descripcion"": """",""keyword"": ""Observaciones"",""formato"": 5,""rol"": 9,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Observaciones As DinaNETCore.APID.DinaupAPI_CampoC = ___Observaciones
          <DisplayName("Es de fuerza mayor")>
          Public Property EsDeFuerzaMayor As Boolean
          Public Shared ___EsDeFuerzaMayor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EsDeFuerzaMayor"",""etiqueta"": ""Es de fuerza mayor"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Es de fuerza mayor"",""descripcion"": """",""keyword"": ""EsDeFuerzaMayor"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EsDeFuerzaMayor As DinaNETCore.APID.DinaupAPI_CampoC = ___EsDeFuerzaMayor
          <DisplayName("Importe por hora no realizada dentro de horario")>
          Public Property ImporteImportePorHoraNoRealizadaDentroDeHorario As Decimal
          Public Shared ___ImporteImportePorHoraNoRealizadaDentroDeHorario As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteImportePorHoraNoRealizadaDentroDeHorario"",""etiqueta"": ""Importe por hora no realizada dentro de horario"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Importe por hora no realizada dentro de horario"",""descripcion"": """",""keyword"": ""ImporteImportePorHoraNoRealizadaDentroDeHorario"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteImportePorHoraNoRealizadaDentroDeHorario As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteImportePorHoraNoRealizadaDentroDeHorario
          <DisplayName("Total horas extra en nómina (En minutos)")>
          Public Property TotalHorasExtraEnNominaEnMinutos As Decimal
          Public Shared ___TotalHorasExtraEnNominaEnMinutos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TotalHorasExtraEnNominaEnMinutos"",""etiqueta"": ""Total horas extra en nómina (En minutos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 14,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total horas extra en nómina (En minutos)"",""descripcion"": """",""keyword"": ""TotalHorasExtraEnNominaEnMinutos"",""formato"": 3,""rol"": 14,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __TotalHorasExtraEnNominaEnMinutos As DinaNETCore.APID.DinaupAPI_CampoC = ___TotalHorasExtraEnNominaEnMinutos
          <DisplayName("Importe por hora realizada fuera de horario")>
          Public Property ImporteImportePorHoraRealizadaFueraDeHorario As Decimal
          Public Shared ___ImporteImportePorHoraRealizadaFueraDeHorario As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteImportePorHoraRealizadaFueraDeHorario"",""etiqueta"": ""Importe por hora realizada fuera de horario"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Importe por hora realizada fuera de horario"",""descripcion"": """",""keyword"": ""ImporteImportePorHoraRealizadaFueraDeHorario"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteImportePorHoraRealizadaFueraDeHorario As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteImportePorHoraRealizadaFueraDeHorario
          <DisplayName("Fecha de realización")>
          Public Property FechaDeRealizacion As Date?
          Public Shared ___FechaDeRealizacion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaDeRealizacion"",""etiqueta"": ""Fecha de realización"",""oculta"": false,""formato"": 7,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha de realización"",""descripcion"": """",""keyword"": ""FechaDeRealizacion"",""formato"": 7,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaDeRealizacion As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaDeRealizacion
          <DisplayName("Realización concluida")>
          Public Property RealizacionConcluida As Boolean
          Public Shared ___RealizacionConcluida As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RealizacionConcluida"",""etiqueta"": ""Realización concluida"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Realización concluida"",""descripcion"": """",""keyword"": ""RealizacionConcluida"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RealizacionConcluida As DinaNETCore.APID.DinaupAPI_CampoC = ___RealizacionConcluida
          <DisplayName("Margen de fin de turno")>
          Public Property MargenDeFinDeTurno As Integer
          Public Shared ___MargenDeFinDeTurno As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""MargenDeFinDeTurno"",""etiqueta"": ""Margen de fin de turno"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 14,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Margen de fin de turno"",""descripcion"": """",""keyword"": ""MargenDeFinDeTurno"",""formato"": 2,""rol"": 14,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __MargenDeFinDeTurno As DinaNETCore.APID.DinaupAPI_CampoC = ___MargenDeFinDeTurno
          <DisplayName("Margen de inicio de turno")>
          Public Property MargenDeInicioDeTurno As Integer
          Public Shared ___MargenDeInicioDeTurno As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""MargenDeInicioDeTurno"",""etiqueta"": ""Margen de inicio de turno"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 14,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Margen de inicio de turno"",""descripcion"": """",""keyword"": ""MargenDeInicioDeTurno"",""formato"": 2,""rol"": 14,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __MargenDeInicioDeTurno As DinaNETCore.APID.DinaupAPI_CampoC = ___MargenDeInicioDeTurno
          <DisplayName("Fecha máxima de fin de turno")>
          Public Property FechaMaximaDeFinDeTurno_UTC As Date?
          Public Shared ___FechaMaximaDeFinDeTurno_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaMaximaDeFinDeTurno_UTC"",""etiqueta"": ""Fecha máxima de fin de turno"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 22,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha máxima de fin de turno"",""descripcion"": """",""keyword"": ""FechaMaximaDeFinDeTurno_UTC"",""formato"": 6,""rol"": 22,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaMaximaDeFinDeTurno_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaMaximaDeFinDeTurno_UTC
          <DisplayName("Fecha mínima de inicio de turno")>
          Public Property FechaMinimaDeInicioDeTurno_UTC As Date?
          Public Shared ___FechaMinimaDeInicioDeTurno_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaMinimaDeInicioDeTurno_UTC"",""etiqueta"": ""Fecha mínima de inicio de turno"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 22,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha mínima de inicio de turno"",""descripcion"": """",""keyword"": ""FechaMinimaDeInicioDeTurno_UTC"",""formato"": 6,""rol"": 22,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaMinimaDeInicioDeTurno_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaMinimaDeInicioDeTurno_UTC
          <DisplayName("Tipo de turno")>
          Public Property TipoDeTurno As EnumTipoDeTurnoE
          Public Shared ___TipoDeTurno As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TipoDeTurno"",""etiqueta"": ""Tipo de turno"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 75,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [0,1,2,3],""predefinidos_textos"": [""Indefinido"",""H. Ordinarias"",""H. Extra"",""H. Complementarias""],""predefinidos_iconos"": [""https://cdn.dinaup.com/ico/enums/75_0.png"",""https://cdn.dinaup.com/ico/enums/75_1.png"",""https://cdn.dinaup.com/ico/enums/75_2.png"",""https://cdn.dinaup.com/ico/enums/75_3.png""],""filtro"": {""titulo"": ""Tipo de turno"",""descripcion"": """",""keyword"": ""TipoDeTurno"",""formato"": 2,""rol"": 75,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false,""enumeracion"": {""titulo"": ""Enum - Tipo de turno"", ""valores"": [{""valor"": 0, ""titulo"": ""Indefinido""},{""valor"": 1, ""titulo"": ""H. Ordinarias""},{""valor"": 2, ""titulo"": ""H. Extra""},{""valor"": 3, ""titulo"": ""H. Complementarias""}]}},""solovalorespredefinidos"": true}")
          Public  __TipoDeTurno As DinaNETCore.APID.DinaupAPI_CampoC = ___TipoDeTurno
          <DisplayName("Importe deducción por horas no realizadas")>
          Public Property ImporteImporteDeduccionPorHorasNoRealizadas As Decimal
          Public Shared ___ImporteImporteDeduccionPorHorasNoRealizadas As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteImporteDeduccionPorHorasNoRealizadas"",""etiqueta"": ""Importe deducción por horas no realizadas"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Importe deducción por horas no realizadas"",""descripcion"": """",""keyword"": ""ImporteImporteDeduccionPorHorasNoRealizadas"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteImporteDeduccionPorHorasNoRealizadas As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteImporteDeduccionPorHorasNoRealizadas
          <DisplayName("Importe total devengo por horas extra")>
          Public Property ImporteImporteTotalDevengoPorHorasExtra As Decimal
          Public Shared ___ImporteImporteTotalDevengoPorHorasExtra As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteImporteTotalDevengoPorHorasExtra"",""etiqueta"": ""Importe total devengo por horas extra"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Importe total devengo por horas extra"",""descripcion"": """",""keyword"": ""ImporteImporteTotalDevengoPorHorasExtra"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteImporteTotalDevengoPorHorasExtra As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteImporteTotalDevengoPorHorasExtra
          <DisplayName("Total horas realizadas de menos en nómina (En minutos)")>
          Public Property TotalHorasRealizadasDeMenosEnNominaEnMinutos As Decimal
          Public Shared ___TotalHorasRealizadasDeMenosEnNominaEnMinutos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TotalHorasRealizadasDeMenosEnNominaEnMinutos"",""etiqueta"": ""Total horas realizadas de menos en nómina (En minutos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 14,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total horas realizadas de menos en nómina (En minutos)"",""descripcion"": """",""keyword"": ""TotalHorasRealizadasDeMenosEnNominaEnMinutos"",""formato"": 3,""rol"": 14,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __TotalHorasRealizadasDeMenosEnNominaEnMinutos As DinaNETCore.APID.DinaupAPI_CampoC = ___TotalHorasRealizadasDeMenosEnNominaEnMinutos
          <DisplayName("Tiempo mínimo para evaluar tiempo trabajado de más")>
          Public Property TiempoMinimoParaEvaluarTiempoTrabajadoDeMas As Decimal
          Public Shared ___TiempoMinimoParaEvaluarTiempoTrabajadoDeMas As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TiempoMinimoParaEvaluarTiempoTrabajadoDeMas"",""etiqueta"": ""Tiempo mínimo para evaluar tiempo trabajado de más"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 14,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Tiempo mínimo para evaluar tiempo trabajado de más"",""descripcion"": """",""keyword"": ""TiempoMinimoParaEvaluarTiempoTrabajadoDeMas"",""formato"": 3,""rol"": 14,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __TiempoMinimoParaEvaluarTiempoTrabajadoDeMas As DinaNETCore.APID.DinaupAPI_CampoC = ___TiempoMinimoParaEvaluarTiempoTrabajadoDeMas
          <DisplayName("Tiempo mínimo para evaluar tiempo trabajado de menos")>
          Public Property TiempoMinimoParaEvaluarTiempoTrabajadoDeMenos As Decimal
          Public Shared ___TiempoMinimoParaEvaluarTiempoTrabajadoDeMenos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TiempoMinimoParaEvaluarTiempoTrabajadoDeMenos"",""etiqueta"": ""Tiempo mínimo para evaluar tiempo trabajado de menos"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 14,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Tiempo mínimo para evaluar tiempo trabajado de menos"",""descripcion"": """",""keyword"": ""TiempoMinimoParaEvaluarTiempoTrabajadoDeMenos"",""formato"": 3,""rol"": 14,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __TiempoMinimoParaEvaluarTiempoTrabajadoDeMenos As DinaNETCore.APID.DinaupAPI_CampoC = ___TiempoMinimoParaEvaluarTiempoTrabajadoDeMenos
          <DisplayName("Motivo Ausencia o retraso")>
          Public Property ReferenciaMotivoAusenciaORetraso As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaMotivoAusenciaORetraso As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaMotivoAusenciaORetraso"",""etiqueta"": ""Motivo Ausencia o retraso"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""86d66f59-4f8f-457d-8a05-f1c52f423b90"",""titulo"": ""Base - Motivos de ausencias y retrasos"",""iconoid"": ""93467278-d6f7-4d1e-9a79-b419778f9b10"",""etiquetasingular"": ""Motivo de ausencias y retrasos"",""etiquetaplural"": ""Motivos de ausencias y retrasos"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""86d66f59-4f8f-457d-8a05-f1c52f423b90"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Motivo Ausencia o retraso"",""descripcion"": """",""keyword"": ""ReferenciaMotivoAusenciaORetraso"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaMotivoAusenciaORetraso As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaMotivoAusenciaORetraso
          <DisplayName("Motivo Horas extra")>
          Public Property ReferenciaMotivoHorasExtra As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaMotivoHorasExtra As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaMotivoHorasExtra"",""etiqueta"": ""Motivo Horas extra"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""6860d8fc-8939-47ba-8e03-c30a6cbb5dee"",""titulo"": ""Base - Motivos de horas extras"",""iconoid"": ""3e0b0307-ecf6-461b-9c5f-0a8cfc54f581"",""etiquetasingular"": ""Motivo de horas extras"",""etiquetaplural"": ""Motivos de horas extras"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""6860d8fc-8939-47ba-8e03-c30a6cbb5dee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Motivo Horas extra"",""descripcion"": """",""keyword"": ""ReferenciaMotivoHorasExtra"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaMotivoHorasExtra As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaMotivoHorasExtra
          <DisplayName("Primer inicio de sesión")>
          Public Property ReferenciaPrimerInicioDeSesion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaPrimerInicioDeSesion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaPrimerInicioDeSesion"",""etiqueta"": ""Primer inicio de sesión"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c5250d97-16c1-420f-bd6b-94cf0216ea32"",""titulo"": ""Base - Registros de acceso a sistema"",""iconoid"": ""d601858e-c944-474a-9f6d-fa55326d6ef0"",""etiquetasingular"": ""Registro de acceso a sistema"",""etiquetaplural"": ""Registros de acceso a sistema"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""c5250d97-16c1-420f-bd6b-94cf0216ea32"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Primer inicio de sesión"",""descripcion"": """",""keyword"": ""ReferenciaPrimerInicioDeSesion"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaPrimerInicioDeSesion As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaPrimerInicioDeSesion
          <DisplayName("Último cierre de sesión")>
          Public Property ReferenciaUltimoCierreDeSesion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaUltimoCierreDeSesion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaUltimoCierreDeSesion"",""etiqueta"": ""Último cierre de sesión"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c5250d97-16c1-420f-bd6b-94cf0216ea32"",""titulo"": ""Base - Registros de acceso a sistema"",""iconoid"": ""d601858e-c944-474a-9f6d-fa55326d6ef0"",""etiquetasingular"": ""Registro de acceso a sistema"",""etiquetaplural"": ""Registros de acceso a sistema"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""c5250d97-16c1-420f-bd6b-94cf0216ea32"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Último cierre de sesión"",""descripcion"": """",""keyword"": ""ReferenciaUltimoCierreDeSesion"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaUltimoCierreDeSesion As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaUltimoCierreDeSesion
          <DisplayName("Descripción corta")>
          Public Property DescripcionCorta As String
          Public Shared ___DescripcionCorta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescripcionCorta"",""etiqueta"": ""Descripción corta"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descripción corta"",""descripcion"": """",""keyword"": ""DescripcionCorta"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescripcionCorta As DinaNETCore.APID.DinaupAPI_CampoC = ___DescripcionCorta
          <DisplayName("Modo de cotización")>
          Public Property ModoDeCotizacion As EnumCotizacionAusenciaE
          Public Shared ___ModoDeCotizacion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ModoDeCotizacion"",""etiqueta"": ""Modo de cotización"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 128,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [0,1,2,3,4],""predefinidos_textos"": ["""",""No cotiza"",""Cotiza base mes anterior"",""Cotiza base mínima"",""Cotización exclusiva empresarial""],""predefinidos_iconos"": [""https://cdn.dinaup.com/ico/enums/128_0.png"",""https://cdn.dinaup.com/ico/enums/128_1.png"",""https://cdn.dinaup.com/ico/enums/128_2.png"",""https://cdn.dinaup.com/ico/enums/128_3.png"",""https://cdn.dinaup.com/ico/enums/128_4.png""],""filtro"": {""titulo"": ""Modo de cotización"",""descripcion"": """",""keyword"": ""ModoDeCotizacion"",""formato"": 2,""rol"": 128,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false,""enumeracion"": {""titulo"": ""Enum - Cotización ausencia"", ""valores"": [{""valor"": 0, ""titulo"": """"},{""valor"": 1, ""titulo"": ""No cotiza""},{""valor"": 2, ""titulo"": ""Cotiza base mes anterior""},{""valor"": 3, ""titulo"": ""Cotiza base mínima""},{""valor"": 4, ""titulo"": ""Cotización exclusiva empresarial""}]}},""solovalorespredefinidos"": true}")
          Public  __ModoDeCotizacion As DinaNETCore.APID.DinaupAPI_CampoC = ___ModoDeCotizacion
          <ReadOnlyAttribute(True)>
          <DisplayName("ID")>
          Public Property ID As Guid
          Public Shared ___ID As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": true,""eseliminado"": false,""keyword"": ""ID"",""etiqueta"": ""ID"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""f37b92fc-5a3d-4d1e-ace9-30404c40a5f3"",""titulo"": ""Base - Realizaciones de turno"",""iconoid"": ""3a18af50-e7e1-46a2-a90b-d6381a8ad026"",""etiquetasingular"": ""Realización de turno"",""etiquetaplural"": ""Realizaciones de turno"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""f37b92fc-5a3d-4d1e-ace9-30404c40a5f3"",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""ID"",""descripcion"": """",""keyword"": ""ID"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
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
          me.MinutosConSesionActiva = _Datos.Leer_Integer("pr_1873d23d48x3e4wd")
          me.RegistrosEliminados = _Datos.Leer_Integer("pr_186415d176xccwd")
          me.ReferenciaJornada = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_30040103153"), _Datos.Leer_String("pr_30040103153.nombre"))
          me.InformesVisualizados = _Datos.Leer_Integer("pr_186410cfabx328wd")
          me.ReferenciaUltimoControlPresencialDeLaRealizacionObsoleto = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_1863f72522xd7wd"), _Datos.Leer_String("pr_1863f72522xd7wd.nombre"))
          me.HoraEnLaQueFinalizo_UTC = _Datos.Leer_DateTime_Nulable("pr_1863d56b05x327wd")
          me.SesionesIniciadas = _Datos.Leer_Integer("pr_1864145b2axeawd")
          me.MinutosRetrasoEntrada = _Datos.Leer_Integer("pr_1863e9ef8dx221wd")
          me.HoraProgramadaDeFin_UTC = _Datos.Leer_DateTime_Nulable("pr_1863d05476x6awd")
          me.ReferenciaEmpleadoPrincipal = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_1863c96f39x2awd"), _Datos.Leer_String("pr_1863c96f39x2awd.nombre"))
          me.RegistrosRestaurados = _Datos.Leer_Integer("pr_1864168675x2a5wd")
          me.RealizacionAgregadaAutomaticamente = _Datos.Leer_Boolean("pr_18756c9ac6x85wd")
          me.MinutosRetrasoSalida = _Datos.Leer_Integer("pr_1863ea67cbx217wd")
          me.ReferenciaDestinador = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_1863b69bc5x86wd"), _Datos.Leer_String("pr_1863b69bc5x86wd.nombre"))
          me.HoraLocal = _Datos.Leer_Time_Nulable("pr_776ae16wd")
          me.ControlesPresencialesObsoleto = _Datos.Leer_Integer("pr_186415015fx7dwd")
          me.ReferenciaAsignacionDeHorario = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_30040103156"), _Datos.Leer_String("pr_30040103156.nombre"))
          me.ReferenciaUbicacionPrincipal = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_1863c96f56x31dwd"), _Datos.Leer_String("pr_1863c96f56x31dwd.nombre"))
          me.AutorDelAltaTieneAccesoWeb = _Datos.Leer_Boolean("pr_1863c09a8ax1b5wd")
          me.RegistrosVisitados = _Datos.Leer_Integer("pr_1864133a72x194wd")
          me.RegistrosAgregados = _Datos.Leer_Integer("pr_186411ab2dx4dwd")
          me.DuracionTurnoEnMinutos = _Datos.Leer_Integer("pr_1863e88aa5x128wd")
          me.ReferenciaTurnoDeJornada = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_30040103154"), _Datos.Leer_String("pr_30040103154.nombre"))
          me.ReferenciaAutorDelAlta = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_1863b69b6ex213wd"), _Datos.Leer_String("pr_1863b69b6ex213wd.nombre"))
          me.EstadoDeLaRealizacion = _Datos.Leer_EnumTipoDeRealizacionDeTurnoE("pr_30040103561")
          me.HoraProgramadaDeInicio_UTC = _Datos.Leer_DateTime_Nulable("pr_1863cf7342x2cfwd")
          me.ReferenciaTurnoDeHorario = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_1863d18f7bx1e7wd"), _Datos.Leer_String("pr_1863d18f7bx1e7wd.nombre"))
          me.EmpleadoTieneAccesoWeb = _Datos.Leer_Boolean("pr_1863ca986fx36cwd")
          me.RegistrosModificados = _Datos.Leer_Integer("pr_186412b750x102wd")
          me.RealizacionEnMinutos = _Datos.Leer_Integer("pr_1863e95bdfx236wd")
          me.ReferenciaMotivoDeLaRealizacionObsoleto = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_50040112221"), _Datos.Leer_String("pr_50040112221.nombre"))
          me.FechaAlta_UTC = _Datos.Leer_DateTime_Nulable("pr_1863b69b89x23ewd")
          me.FechaDato_UTC = _Datos.Leer_DateTime_Nulable("pr_1863c96f6bx340wd")
          me.HoraEnLaQueInicio_UTC = _Datos.Leer_DateTime_Nulable("pr_1863d4dfc1x28ewd")
          me.ReferenciaHorario = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_1863d10038x3ccwd"), _Datos.Leer_String("pr_1863d10038x3ccwd.nombre"))
          me.ReferenciaPrimerControlPresencialDeLaRealizacionObsoleto = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_1863f6083fx36wd"), _Datos.Leer_String("pr_1863f6083fx36wd.nombre"))
          me.MinutosExtrasTrabajados = _Datos.Leer_Integer("pr_1864ee2a65xfawd")
          me.AdaptarElImporteAPagarSegunElHorarioRealizado = _Datos.Leer_Boolean("pr_10040139172")
          me.Observaciones = _Datos.Leer_String("pr_20040138403")
          me.EsDeFuerzaMayor = _Datos.Leer_Boolean("pr_20040138404")
          me.ImporteImportePorHoraNoRealizadaDentroDeHorario = _Datos.Leer_Decimal("pr_20040138406")
          me.TotalHorasExtraEnNominaEnMinutos = _Datos.Leer_Decimal("pr_30040139131")
          me.ImporteImportePorHoraRealizadaFueraDeHorario = _Datos.Leer_Decimal("pr_30040139132")
          me.FechaDeRealizacion = _Datos.Leer_Date_Nulable("pr_10040139141")
          me.RealizacionConcluida = _Datos.Leer_Boolean("pr_40040209613")
          me.MargenDeFinDeTurno = _Datos.Leer_Integer("pr_50040210384")
          me.MargenDeInicioDeTurno = _Datos.Leer_Integer("pr_50040210385")
          me.FechaMaximaDeFinDeTurno_UTC = _Datos.Leer_DateTime_Nulable("pr_60040210381")
          me.FechaMinimaDeInicioDeTurno_UTC = _Datos.Leer_DateTime_Nulable("pr_60040210382")
          me.TipoDeTurno = _Datos.Leer_EnumTipoDeTurnoE("pr_40040210832")
          me.ImporteImporteDeduccionPorHorasNoRealizadas = _Datos.Leer_Decimal("pr_60040211101")
          me.ImporteImporteTotalDevengoPorHorasExtra = _Datos.Leer_Decimal("pr_60040211102")
          me.TotalHorasRealizadasDeMenosEnNominaEnMinutos = _Datos.Leer_Decimal("pr_50040211101")
          me.TiempoMinimoParaEvaluarTiempoTrabajadoDeMas = _Datos.Leer_Decimal("pr_30040211302")
          me.TiempoMinimoParaEvaluarTiempoTrabajadoDeMenos = _Datos.Leer_Decimal("pr_30040211303")
          me.ReferenciaMotivoAusenciaORetraso = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_30040212244"), _Datos.Leer_String("pr_30040212244.nombre"))
          me.ReferenciaMotivoHorasExtra = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_30040212245"), _Datos.Leer_String("pr_30040212245.nombre"))
          me.ReferenciaPrimerInicioDeSesion = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_10040243741"), _Datos.Leer_String("pr_10040243741.nombre"))
          me.ReferenciaUltimoCierreDeSesion = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_30040243742"), _Datos.Leer_String("pr_30040243742.nombre"))
          me.DescripcionCorta = _Datos.Leer_String("pr_10040256424")
          me.ModoDeCotizacion = _Datos.Leer_EnumCotizacionAusenciaE("pr_20040360102")
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
         R.add("pr_1873d23d48x3e4wd", me.MinutosConSesionActiva.AdaptarMySQL_Integer())
         R.add("pr_186415d176xccwd", me.RegistrosEliminados.AdaptarMySQL_Integer())
         If Me.ReferenciaJornada IsNot nothing then
           R.add("pr_30040103153",me.ReferenciaJornada.ID.STR())
         Else
           R.add("pr_30040103153","")
         End if
         R.add("pr_186410cfabx328wd", me.InformesVisualizados.AdaptarMySQL_Integer())
         If Me.ReferenciaUltimoControlPresencialDeLaRealizacionObsoleto IsNot nothing then
           R.add("pr_1863f72522xd7wd",me.ReferenciaUltimoControlPresencialDeLaRealizacionObsoleto.ID.STR())
         Else
           R.add("pr_1863f72522xd7wd","")
         End if
         R.add("pr_1863d56b05x327wd", me.HoraEnLaQueFinalizo_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_1864145b2axeawd", me.SesionesIniciadas.AdaptarMySQL_Integer())
         R.add("pr_1863e9ef8dx221wd", me.MinutosRetrasoEntrada.AdaptarMySQL_Integer())
         R.add("pr_1863d05476x6awd", me.HoraProgramadaDeFin_UTC.AdaptarMySQL_DateTime_Nulable())
         If Me.ReferenciaEmpleadoPrincipal IsNot nothing then
           R.add("pr_1863c96f39x2awd",me.ReferenciaEmpleadoPrincipal.ID.STR())
         Else
           R.add("pr_1863c96f39x2awd","")
         End if
         R.add("pr_1864168675x2a5wd", me.RegistrosRestaurados.AdaptarMySQL_Integer())
         R.add("pr_18756c9ac6x85wd", me.RealizacionAgregadaAutomaticamente.AdaptarMySQL_Boolean())
         R.add("pr_1863ea67cbx217wd", me.MinutosRetrasoSalida.AdaptarMySQL_Integer())
         If Me.ReferenciaDestinador IsNot nothing then
           R.add("pr_1863b69bc5x86wd",me.ReferenciaDestinador.ID.STR())
         Else
           R.add("pr_1863b69bc5x86wd","")
         End if
         R.add("pr_776ae16wd", me.HoraLocal.AdaptarMySQL_Time_Nulable())
         R.add("pr_186415015fx7dwd", me.ControlesPresencialesObsoleto.AdaptarMySQL_Integer())
         If Me.ReferenciaAsignacionDeHorario IsNot nothing then
           R.add("pr_30040103156",me.ReferenciaAsignacionDeHorario.ID.STR())
         Else
           R.add("pr_30040103156","")
         End if
         If Me.ReferenciaUbicacionPrincipal IsNot nothing then
           R.add("pr_1863c96f56x31dwd",me.ReferenciaUbicacionPrincipal.ID.STR())
         Else
           R.add("pr_1863c96f56x31dwd","")
         End if
         R.add("pr_1863c09a8ax1b5wd", me.AutorDelAltaTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_1864133a72x194wd", me.RegistrosVisitados.AdaptarMySQL_Integer())
         R.add("pr_186411ab2dx4dwd", me.RegistrosAgregados.AdaptarMySQL_Integer())
         R.add("pr_1863e88aa5x128wd", me.DuracionTurnoEnMinutos.AdaptarMySQL_Integer())
         If Me.ReferenciaTurnoDeJornada IsNot nothing then
           R.add("pr_30040103154",me.ReferenciaTurnoDeJornada.ID.STR())
         Else
           R.add("pr_30040103154","")
         End if
         If Me.ReferenciaAutorDelAlta IsNot nothing then
           R.add("pr_1863b69b6ex213wd",me.ReferenciaAutorDelAlta.ID.STR())
         Else
           R.add("pr_1863b69b6ex213wd","")
         End if
         R.add("pr_30040103561", me.EstadoDeLaRealizacion.AdaptarMySQL_EnumTipoDeRealizacionDeTurnoE())
         R.add("pr_1863cf7342x2cfwd", me.HoraProgramadaDeInicio_UTC.AdaptarMySQL_DateTime_Nulable())
         If Me.ReferenciaTurnoDeHorario IsNot nothing then
           R.add("pr_1863d18f7bx1e7wd",me.ReferenciaTurnoDeHorario.ID.STR())
         Else
           R.add("pr_1863d18f7bx1e7wd","")
         End if
         R.add("pr_1863ca986fx36cwd", me.EmpleadoTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_186412b750x102wd", me.RegistrosModificados.AdaptarMySQL_Integer())
         R.add("pr_1863e95bdfx236wd", me.RealizacionEnMinutos.AdaptarMySQL_Integer())
         If Me.ReferenciaMotivoDeLaRealizacionObsoleto IsNot nothing then
           R.add("pr_50040112221",me.ReferenciaMotivoDeLaRealizacionObsoleto.ID.STR())
         Else
           R.add("pr_50040112221","")
         End if
         R.add("pr_1863b69b89x23ewd", me.FechaAlta_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_1863c96f6bx340wd", me.FechaDato_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_1863d4dfc1x28ewd", me.HoraEnLaQueInicio_UTC.AdaptarMySQL_DateTime_Nulable())
         If Me.ReferenciaHorario IsNot nothing then
           R.add("pr_1863d10038x3ccwd",me.ReferenciaHorario.ID.STR())
         Else
           R.add("pr_1863d10038x3ccwd","")
         End if
         If Me.ReferenciaPrimerControlPresencialDeLaRealizacionObsoleto IsNot nothing then
           R.add("pr_1863f6083fx36wd",me.ReferenciaPrimerControlPresencialDeLaRealizacionObsoleto.ID.STR())
         Else
           R.add("pr_1863f6083fx36wd","")
         End if
         R.add("pr_1864ee2a65xfawd", me.MinutosExtrasTrabajados.AdaptarMySQL_Integer())
         R.add("pr_10040139172", me.AdaptarElImporteAPagarSegunElHorarioRealizado.AdaptarMySQL_Boolean())
         R.add("pr_20040138403", me.Observaciones.AdaptarMySQL_String())
         R.add("pr_20040138404", me.EsDeFuerzaMayor.AdaptarMySQL_Boolean())
         R.add("pr_20040138406", me.ImporteImportePorHoraNoRealizadaDentroDeHorario.AdaptarMySQL_Decimal())
         R.add("pr_30040139131", me.TotalHorasExtraEnNominaEnMinutos.AdaptarMySQL_Decimal())
         R.add("pr_30040139132", me.ImporteImportePorHoraRealizadaFueraDeHorario.AdaptarMySQL_Decimal())
         R.add("pr_10040139141", me.FechaDeRealizacion.AdaptarMySQL_Date_Nulable())
         R.add("pr_40040209613", me.RealizacionConcluida.AdaptarMySQL_Boolean())
         R.add("pr_50040210384", me.MargenDeFinDeTurno.AdaptarMySQL_Integer())
         R.add("pr_50040210385", me.MargenDeInicioDeTurno.AdaptarMySQL_Integer())
         R.add("pr_60040210381", me.FechaMaximaDeFinDeTurno_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_60040210382", me.FechaMinimaDeInicioDeTurno_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_40040210832", me.TipoDeTurno.AdaptarMySQL_EnumTipoDeTurnoE())
         R.add("pr_60040211101", me.ImporteImporteDeduccionPorHorasNoRealizadas.AdaptarMySQL_Decimal())
         R.add("pr_60040211102", me.ImporteImporteTotalDevengoPorHorasExtra.AdaptarMySQL_Decimal())
         R.add("pr_50040211101", me.TotalHorasRealizadasDeMenosEnNominaEnMinutos.AdaptarMySQL_Decimal())
         R.add("pr_30040211302", me.TiempoMinimoParaEvaluarTiempoTrabajadoDeMas.AdaptarMySQL_Decimal())
         R.add("pr_30040211303", me.TiempoMinimoParaEvaluarTiempoTrabajadoDeMenos.AdaptarMySQL_Decimal())
         If Me.ReferenciaMotivoAusenciaORetraso IsNot nothing then
           R.add("pr_30040212244",me.ReferenciaMotivoAusenciaORetraso.ID.STR())
         Else
           R.add("pr_30040212244","")
         End if
         If Me.ReferenciaMotivoHorasExtra IsNot nothing then
           R.add("pr_30040212245",me.ReferenciaMotivoHorasExtra.ID.STR())
         Else
           R.add("pr_30040212245","")
         End if
         If Me.ReferenciaPrimerInicioDeSesion IsNot nothing then
           R.add("pr_10040243741",me.ReferenciaPrimerInicioDeSesion.ID.STR())
         Else
           R.add("pr_10040243741","")
         End if
         If Me.ReferenciaUltimoCierreDeSesion IsNot nothing then
           R.add("pr_30040243742",me.ReferenciaUltimoCierreDeSesion.ID.STR())
         Else
           R.add("pr_30040243742","")
         End if
         R.add("pr_10040256424", me.DescripcionCorta.AdaptarMySQL_String())
         R.add("pr_20040360102", me.ModoDeCotizacion.AdaptarMySQL_EnumCotizacionAusenciaE())
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
