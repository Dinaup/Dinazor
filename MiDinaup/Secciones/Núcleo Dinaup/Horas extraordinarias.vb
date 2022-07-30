   Imports System.ComponentModel
   Imports DinaNETCore
   Imports DinaNETCore.APID
Partial Public Class SeccionesD
  Public Class HorasExtraordinariasD
      Public Shared _SeccionID As String = "f5dc61e5-af83-4760-9393-1c6e2e6ddf22"
      Public Shared _SeccionIDGUID As New Guid("f5dc61e5-af83-4760-9393-1c6e2e6ddf22")
      Public Shared Async Function ConsultarDatos_Async(Parametros As SeccionConsultaParametrosC) As Task(Of List(Of HorasExtraordinariasC )) 
          Dim R As New List(Of HorasExtraordinariasC )  
          Dim d = Await Parametros.DinaupSesion.ConexionServidor.Funcion_Datos_Recibir_Async(HorasExtraordinariasES._SeccionID, False, Parametros) 
          If d.Datos.TieneDatos Then 
              For Each Actual In d.Datos 
                  Dim Valores_Listador = Actual.Value.Item1
                  Dim Obj_Listador As New HorasExtraordinariasC 
                  Obj_Listador.CargarDatos(Valores_Listador) 
                  Obj_Listador.CargaInterna(Actual.Value)
                  R.Add(Obj_Listador) 
              Next 
          End If 
          Return R 
      End Function 
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As HorasExtraordinariasC, Optional CampoWhere$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Return Await DatosGuardar_Async(DinaupSesion, New List(Of HorasExtraordinariasC)({DAtos}), CampoWhere )
      End Function
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As List(Of HorasExtraordinariasC), Optional CampoWhere$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Dim Importar As New List(Of DinaupAPI_ImportacionProcesableC)
          For Each Actual In DAtos 
              Dim RegistroActual = New DinaupAPI_ImportacionProcesableC() 
               RegistroActual.dinaup_listador_datos = Actual.ToDic 
               Importar.Add(RegistroActual)  
          Next 
          Return Await DinaupSesion.ConexionServidor.Funcion_Importar_Ejecutar_Async(DinaupSesion, HorasExtraordinariasES._SeccionID, Importar, CampoWhere, "") 
      End Function
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As HorasExtraordinarias_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, HorasExtraordinariasES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New HorasExtraordinarias_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As HorasExtraordinarias_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, HorasExtraordinariasES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New HorasExtraordinarias_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class HorasExtraordinariasES
          Public shared _SeccionID as Guid = New Guid("f5dc61e5-af83-4760-9393-1c6e2e6ddf22")
          Public shared _Tabla$ = "tpr_63e63f9xd"
      Public Shared FechaDato_UTC$ = "pr_1863c96f6bx340wd"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_1863c96f56x31dwd"
      Public Shared TotalHorasExtraEnNominaEnMinutos$ = "pr_30040139131"
      Public Shared ImporteImportePorHoraRealizadaFueraDeHorario$ = "pr_30040139132"
      Public Shared EstadoDeLaRealizacion$ = "pr_30040103561"
      Public Shared HoraEnLaQueFinalizo_UTC$ = "pr_1863d56b05x327wd"
      Public Shared MinutosConSesionActiva$ = "pr_1873d23d48x3e4wd"
      Public Shared RegistrosEliminados$ = "pr_186415d176xccwd"
      Public Shared SesionesIniciadas$ = "pr_1864145b2axeawd"
      Public Shared MinutosRetrasoEntrada$ = "pr_1863e9ef8dx221wd"
      Public Shared RegistrosRestaurados$ = "pr_1864168675x2a5wd"
      Public Shared MinutosRetrasoSalida$ = "pr_1863ea67cbx217wd"
      Public Shared HoraProgramadaDeFin_UTC$ = "pr_1863d05476x6awd"
      Public Shared RegistrosAgregados$ = "pr_186411ab2dx4dwd"
      Public Shared RegistrosVisitados$ = "pr_1864133a72x194wd"
      Public Shared DuracionTurnoEnMinutos$ = "pr_1863e88aa5x128wd"
      Public Shared HoraProgramadaDeInicio_UTC$ = "pr_1863cf7342x2cfwd"
      Public Shared RegistrosModificados$ = "pr_186412b750x102wd"
      Public Shared RealizacionEnMinutos$ = "pr_1863e95bdfx236wd"
      Public Shared HoraEnLaQueInicio_UTC$ = "pr_1863d4dfc1x28ewd"
      Public Shared MinutosExtrasTrabajados$ = "pr_1864ee2a65xfawd"
      Public Shared Observaciones$ = "pr_20040138403"
      Public Shared EsDeFuerzaMayor$ = "pr_20040138404"
      Public Shared ReferenciaDestinador$ = "pr_1863b69bc5x86wd"
      Public Shared HoraLocal$ = "pr_776ae16wd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_1863ca986fx36cwd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_1863c09a8ax1b5wd"
      Public Shared AdaptarElImporteAPagarSegunElHorarioRealizado$ = "pr_10040139172"
      Public Shared InformesVisualizados$ = "pr_186410cfabx328wd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_1863b69b6ex213wd"
      Public Shared FechaAlta_UTC$ = "pr_1863b69b89x23ewd"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_1863c96f39x2awd"
      Public Shared ImporteImportePorHoraNoRealizadaDentroDeHorario$ = "pr_20040138406"
      Public Shared FechaDeRealizacion$ = "pr_10040139141"
      Public Shared ReferenciaMotivoDeLaRealizacionObsoleto$ = "pr_50040112221"
      Public Shared RealizacionConcluida$ = "pr_40040209613"
      Public Shared MargenDeInicioDeTurno$ = "pr_50040210385"
      Public Shared MargenDeFinDeTurno$ = "pr_50040210384"
      Public Shared FechaMaximaDeFinDeTurno_UTC$ = "pr_60040210381"
      Public Shared ReferenciaPrimerControlPresencialDeLaRealizacionObsoleto$ = "pr_1863f6083fx36wd"
      Public Shared ReferenciaUltimoControlPresencialDeLaRealizacionObsoleto$ = "pr_1863f72522xd7wd"
      Public Shared FechaMinimaDeInicioDeTurno_UTC$ = "pr_60040210382"
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
      Public Class HorasExtraordinariasC
      Inherits Base_DatoC
          <DisplayName("Fecha Dato")>
          Public Property FechaDato_UTC As Date?
          Public Shared ___FechaDato_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaDato_UTC"",""etiqueta"": ""Fecha Dato"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Dato"",""descripcion"": """",""keyword"": ""FechaDato_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaDato_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaDato_UTC
          <DisplayName("Ubicación Principal")>
          Public Property ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaUbicacionPrincipal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaUbicacionPrincipal"",""etiqueta"": ""Ubicación Principal"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""b9adbfbf-a81a-45fb-861c-90502902c982"",""titulo"": ""Ubicaciones"",""iconoid"": ""b985b58f-7275-46b8-9b66-2c54346b0185"",""etiquetasingular"": ""Ubicación"",""etiquetaplural"": ""Ubicaciones"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""b9adbfbf-a81a-45fb-861c-90502902c982"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Ubicación Principal"",""descripcion"": """",""keyword"": ""ReferenciaUbicacionPrincipal"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaUbicacionPrincipal
          <DisplayName("Total horas extra en nómina (En minutos)")>
          Public Property TotalHorasExtraEnNominaEnMinutos As Decimal
          Public Shared ___TotalHorasExtraEnNominaEnMinutos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TotalHorasExtraEnNominaEnMinutos"",""etiqueta"": ""Total horas extra en nómina (En minutos)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 14,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Total horas extra en nómina (En minutos)"",""descripcion"": """",""keyword"": ""TotalHorasExtraEnNominaEnMinutos"",""formato"": 3,""rol"": 14,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __TotalHorasExtraEnNominaEnMinutos As DinaNETCore.APID.DinaupAPI_CampoC = ___TotalHorasExtraEnNominaEnMinutos
          <DisplayName("Importe por hora realizada fuera de horario")>
          Public Property ImporteImportePorHoraRealizadaFueraDeHorario As Decimal
          Public Shared ___ImporteImportePorHoraRealizadaFueraDeHorario As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteImportePorHoraRealizadaFueraDeHorario"",""etiqueta"": ""Importe por hora realizada fuera de horario"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Importe por hora realizada fuera de horario"",""descripcion"": """",""keyword"": ""ImporteImportePorHoraRealizadaFueraDeHorario"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteImportePorHoraRealizadaFueraDeHorario As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteImportePorHoraRealizadaFueraDeHorario
          <DisplayName("Estado de la realización")>
          Public Property EstadoDeLaRealizacion As EnumTipoDeRealizacionDeTurnoE
          Public Shared ___EstadoDeLaRealizacion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EstadoDeLaRealizacion"",""etiqueta"": ""Estado de la realización"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 46,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [0,1,2,3,4,5,6],""predefinidos_textos"": [""Indefinido"",""Ausencia"",""Presente"",""Cancelada"",""Programada"",""En curso"",""Esperando inicio""],""predefinidos_iconos"": [""https://cdn.dinaup.com/ico/enums/46_0.png"",""https://cdn.dinaup.com/ico/enums/46_1.png"",""https://cdn.dinaup.com/ico/enums/46_2.png"",""https://cdn.dinaup.com/ico/enums/46_3.png"",""https://cdn.dinaup.com/ico/enums/46_4.png"",""https://cdn.dinaup.com/ico/enums/46_5.png"",""https://cdn.dinaup.com/ico/enums/46_6.png""],""filtro"": {""titulo"": ""Estado de la realización"",""descripcion"": """",""keyword"": ""EstadoDeLaRealizacion"",""formato"": 2,""rol"": 46,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false,""enumeracion"": {""titulo"": ""Enum - Tipo de realización de turno"", ""valores"": [{""valor"": 0, ""titulo"": ""Indefinido""},{""valor"": 1, ""titulo"": ""Ausencia""},{""valor"": 2, ""titulo"": ""Presente""},{""valor"": 3, ""titulo"": ""Cancelada""},{""valor"": 4, ""titulo"": ""Programada""},{""valor"": 5, ""titulo"": ""En curso""},{""valor"": 6, ""titulo"": ""Esperando inicio""}]}},""solovalorespredefinidos"": true}")
          Public  __EstadoDeLaRealizacion As DinaNETCore.APID.DinaupAPI_CampoC = ___EstadoDeLaRealizacion
          <DisplayName("Hora en la que finalizó")>
          Public Property HoraEnLaQueFinalizo_UTC As Date?
          Public Shared ___HoraEnLaQueFinalizo_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""HoraEnLaQueFinalizo_UTC"",""etiqueta"": ""Hora en la que finalizó"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 22,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Hora en la que finalizó"",""descripcion"": """",""keyword"": ""HoraEnLaQueFinalizo_UTC"",""formato"": 6,""rol"": 22,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __HoraEnLaQueFinalizo_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___HoraEnLaQueFinalizo_UTC
          <DisplayName("Minutos con sesión activa")>
          Public Property MinutosConSesionActiva As Integer
          Public Shared ___MinutosConSesionActiva As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""MinutosConSesionActiva"",""etiqueta"": ""Minutos con sesión activa"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 14,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Minutos con sesión activa"",""descripcion"": """",""keyword"": ""MinutosConSesionActiva"",""formato"": 2,""rol"": 14,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __MinutosConSesionActiva As DinaNETCore.APID.DinaupAPI_CampoC = ___MinutosConSesionActiva
          <DisplayName("Registros eliminados")>
          Public Property RegistrosEliminados As Integer
          Public Shared ___RegistrosEliminados As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RegistrosEliminados"",""etiqueta"": ""Registros eliminados"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Registros eliminados"",""descripcion"": """",""keyword"": ""RegistrosEliminados"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RegistrosEliminados As DinaNETCore.APID.DinaupAPI_CampoC = ___RegistrosEliminados
          <DisplayName("Sesiones iniciadas")>
          Public Property SesionesIniciadas As Integer
          Public Shared ___SesionesIniciadas As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""SesionesIniciadas"",""etiqueta"": ""Sesiones iniciadas"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Sesiones iniciadas"",""descripcion"": """",""keyword"": ""SesionesIniciadas"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __SesionesIniciadas As DinaNETCore.APID.DinaupAPI_CampoC = ___SesionesIniciadas
          <DisplayName("Minutos retraso entrada")>
          Public Property MinutosRetrasoEntrada As Integer
          Public Shared ___MinutosRetrasoEntrada As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""MinutosRetrasoEntrada"",""etiqueta"": ""Minutos retraso entrada"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 14,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Minutos retraso entrada"",""descripcion"": """",""keyword"": ""MinutosRetrasoEntrada"",""formato"": 2,""rol"": 14,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __MinutosRetrasoEntrada As DinaNETCore.APID.DinaupAPI_CampoC = ___MinutosRetrasoEntrada
          <DisplayName("Registros restaurados")>
          Public Property RegistrosRestaurados As Integer
          Public Shared ___RegistrosRestaurados As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RegistrosRestaurados"",""etiqueta"": ""Registros restaurados"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Registros restaurados"",""descripcion"": """",""keyword"": ""RegistrosRestaurados"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RegistrosRestaurados As DinaNETCore.APID.DinaupAPI_CampoC = ___RegistrosRestaurados
          <DisplayName("Minutos retraso salida")>
          Public Property MinutosRetrasoSalida As Integer
          Public Shared ___MinutosRetrasoSalida As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""MinutosRetrasoSalida"",""etiqueta"": ""Minutos retraso salida"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 14,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Minutos retraso salida"",""descripcion"": """",""keyword"": ""MinutosRetrasoSalida"",""formato"": 2,""rol"": 14,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __MinutosRetrasoSalida As DinaNETCore.APID.DinaupAPI_CampoC = ___MinutosRetrasoSalida
          <DisplayName("Hora programada de fin")>
          Public Property HoraProgramadaDeFin_UTC As Date?
          Public Shared ___HoraProgramadaDeFin_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""HoraProgramadaDeFin_UTC"",""etiqueta"": ""Hora programada de fin"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 22,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Hora programada de fin"",""descripcion"": """",""keyword"": ""HoraProgramadaDeFin_UTC"",""formato"": 6,""rol"": 22,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __HoraProgramadaDeFin_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___HoraProgramadaDeFin_UTC
          <DisplayName("Registros agregados")>
          Public Property RegistrosAgregados As Integer
          Public Shared ___RegistrosAgregados As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RegistrosAgregados"",""etiqueta"": ""Registros agregados"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Registros agregados"",""descripcion"": """",""keyword"": ""RegistrosAgregados"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RegistrosAgregados As DinaNETCore.APID.DinaupAPI_CampoC = ___RegistrosAgregados
          <DisplayName("Registros visitados")>
          Public Property RegistrosVisitados As Integer
          Public Shared ___RegistrosVisitados As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RegistrosVisitados"",""etiqueta"": ""Registros visitados"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Registros visitados"",""descripcion"": """",""keyword"": ""RegistrosVisitados"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RegistrosVisitados As DinaNETCore.APID.DinaupAPI_CampoC = ___RegistrosVisitados
          <DisplayName("Duración turno en minutos")>
          Public Property DuracionTurnoEnMinutos As Integer
          Public Shared ___DuracionTurnoEnMinutos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DuracionTurnoEnMinutos"",""etiqueta"": ""Duración turno en minutos"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 14,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Duración turno en minutos"",""descripcion"": """",""keyword"": ""DuracionTurnoEnMinutos"",""formato"": 2,""rol"": 14,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DuracionTurnoEnMinutos As DinaNETCore.APID.DinaupAPI_CampoC = ___DuracionTurnoEnMinutos
          <DisplayName("Hora programada de inicio")>
          Public Property HoraProgramadaDeInicio_UTC As Date?
          Public Shared ___HoraProgramadaDeInicio_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""HoraProgramadaDeInicio_UTC"",""etiqueta"": ""Hora programada de inicio"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 22,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Hora programada de inicio"",""descripcion"": """",""keyword"": ""HoraProgramadaDeInicio_UTC"",""formato"": 6,""rol"": 22,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __HoraProgramadaDeInicio_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___HoraProgramadaDeInicio_UTC
          <DisplayName("Registros modificados")>
          Public Property RegistrosModificados As Integer
          Public Shared ___RegistrosModificados As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RegistrosModificados"",""etiqueta"": ""Registros modificados"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Registros modificados"",""descripcion"": """",""keyword"": ""RegistrosModificados"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RegistrosModificados As DinaNETCore.APID.DinaupAPI_CampoC = ___RegistrosModificados
          <DisplayName("Realización en minutos")>
          Public Property RealizacionEnMinutos As Integer
          Public Shared ___RealizacionEnMinutos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RealizacionEnMinutos"",""etiqueta"": ""Realización en minutos"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 14,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Realización en minutos"",""descripcion"": """",""keyword"": ""RealizacionEnMinutos"",""formato"": 2,""rol"": 14,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RealizacionEnMinutos As DinaNETCore.APID.DinaupAPI_CampoC = ___RealizacionEnMinutos
          <DisplayName("Hora en la que inició")>
          Public Property HoraEnLaQueInicio_UTC As Date?
          Public Shared ___HoraEnLaQueInicio_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""HoraEnLaQueInicio_UTC"",""etiqueta"": ""Hora en la que inició"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 22,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Hora en la que inició"",""descripcion"": """",""keyword"": ""HoraEnLaQueInicio_UTC"",""formato"": 6,""rol"": 22,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __HoraEnLaQueInicio_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___HoraEnLaQueInicio_UTC
          <DisplayName("Minutos extras trabajados")>
          Public Property MinutosExtrasTrabajados As Integer
          Public Shared ___MinutosExtrasTrabajados As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""MinutosExtrasTrabajados"",""etiqueta"": ""Minutos extras trabajados"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 14,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Minutos extras trabajados"",""descripcion"": """",""keyword"": ""MinutosExtrasTrabajados"",""formato"": 2,""rol"": 14,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __MinutosExtrasTrabajados As DinaNETCore.APID.DinaupAPI_CampoC = ___MinutosExtrasTrabajados
          <DisplayName("Observaciones")>
          Public Property Observaciones As String
          Public Shared ___Observaciones As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Observaciones"",""etiqueta"": ""Observaciones"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 9,""decimales"": ""0"",""multilinea"": true,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Observaciones"",""descripcion"": """",""keyword"": ""Observaciones"",""formato"": 5,""rol"": 9,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Observaciones As DinaNETCore.APID.DinaupAPI_CampoC = ___Observaciones
          <DisplayName("Es de fuerza mayor")>
          Public Property EsDeFuerzaMayor As Boolean
          Public Shared ___EsDeFuerzaMayor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EsDeFuerzaMayor"",""etiqueta"": ""Es de fuerza mayor"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Es de fuerza mayor"",""descripcion"": """",""keyword"": ""EsDeFuerzaMayor"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EsDeFuerzaMayor As DinaNETCore.APID.DinaupAPI_CampoC = ___EsDeFuerzaMayor
          <DisplayName("Destinador")>
          Public Property ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaDestinador As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaDestinador"",""etiqueta"": ""Destinador"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""relacionesindirectas"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Destinador"",""descripcion"": """",""keyword"": ""ReferenciaDestinador"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaDestinador
          <DisplayName("Hora local")>
          Public Property HoraLocal As DateTime?
          Public Shared ___HoraLocal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""HoraLocal"",""etiqueta"": ""Hora local"",""oculta"": false,""formato"": 8,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Hora local"",""descripcion"": """",""keyword"": ""HoraLocal"",""formato"": 8,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __HoraLocal As DinaNETCore.APID.DinaupAPI_CampoC = ___HoraLocal
          <DisplayName("Empleado Tiene Acceso web")>
          Public Property EmpleadoTieneAccesoWeb As Boolean
          Public Shared ___EmpleadoTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EmpleadoTieneAccesoWeb"",""etiqueta"": ""Empleado Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empleado Tiene Acceso web"",""descripcion"": """",""keyword"": ""EmpleadoTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EmpleadoTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___EmpleadoTieneAccesoWeb
          <DisplayName("Autor del alta Tiene Acceso web")>
          Public Property AutorDelAltaTieneAccesoWeb As Boolean
          Public Shared ___AutorDelAltaTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AutorDelAltaTieneAccesoWeb"",""etiqueta"": ""Autor del alta Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta Tiene Acceso web"",""descripcion"": """",""keyword"": ""AutorDelAltaTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AutorDelAltaTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___AutorDelAltaTieneAccesoWeb
          <DisplayName("Adaptar el importe a pagar según el horario realizado.")>
          Public Property AdaptarElImporteAPagarSegunElHorarioRealizado As Boolean
          Public Shared ___AdaptarElImporteAPagarSegunElHorarioRealizado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AdaptarElImporteAPagarSegunElHorarioRealizado"",""etiqueta"": ""Adaptar el importe a pagar según el horario realizado."",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Adaptar el importe a pagar según el horario realizado."",""descripcion"": """",""keyword"": ""AdaptarElImporteAPagarSegunElHorarioRealizado"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AdaptarElImporteAPagarSegunElHorarioRealizado As DinaNETCore.APID.DinaupAPI_CampoC = ___AdaptarElImporteAPagarSegunElHorarioRealizado
          <DisplayName("Informes visualizados")>
          Public Property InformesVisualizados As Integer
          Public Shared ___InformesVisualizados As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""InformesVisualizados"",""etiqueta"": ""Informes visualizados"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Informes visualizados"",""descripcion"": """",""keyword"": ""InformesVisualizados"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __InformesVisualizados As DinaNETCore.APID.DinaupAPI_CampoC = ___InformesVisualizados
          <DisplayName("Autor del alta")>
          Public Property ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaAutorDelAlta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaAutorDelAlta"",""etiqueta"": ""Autor del alta"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta"",""descripcion"": """",""keyword"": ""ReferenciaAutorDelAlta"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaAutorDelAlta
          <DisplayName("Fecha Alta del registro")>
          Public Property FechaAlta_UTC As Date?
          Public Shared ___FechaAlta_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaAlta_UTC"",""etiqueta"": ""Fecha Alta del registro"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Alta del registro"",""descripcion"": """",""keyword"": ""FechaAlta_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaAlta_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaAlta_UTC
          <DisplayName("Empleado")>
          Public Property ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaEmpleadoPrincipal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaEmpleadoPrincipal"",""etiqueta"": ""Empleado"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c6e071c7-776f-4300-aa55-c711fd1da916"",""titulo"": ""Empleados"",""iconoid"": ""1c8abf82-640c-4d18-b62c-89de310923dd"",""etiquetasingular"": ""Empleado"",""etiquetaplural"": ""Empleados"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""c6e071c7-776f-4300-aa55-c711fd1da916"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empleado"",""descripcion"": """",""keyword"": ""ReferenciaEmpleadoPrincipal"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaEmpleadoPrincipal
          <DisplayName("Importe por hora no realizada dentro de horario")>
          Public Property ImporteImportePorHoraNoRealizadaDentroDeHorario As Decimal
          Public Shared ___ImporteImportePorHoraNoRealizadaDentroDeHorario As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteImportePorHoraNoRealizadaDentroDeHorario"",""etiqueta"": ""Importe por hora no realizada dentro de horario"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Importe por hora no realizada dentro de horario"",""descripcion"": """",""keyword"": ""ImporteImportePorHoraNoRealizadaDentroDeHorario"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteImportePorHoraNoRealizadaDentroDeHorario As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteImportePorHoraNoRealizadaDentroDeHorario
          <DisplayName("Fecha de realización")>
          Public Property FechaDeRealizacion As Date?
          Public Shared ___FechaDeRealizacion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaDeRealizacion"",""etiqueta"": ""Fecha de realización"",""oculta"": false,""formato"": 7,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha de realización"",""descripcion"": """",""keyword"": ""FechaDeRealizacion"",""formato"": 7,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaDeRealizacion As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaDeRealizacion
          <DisplayName("Motivo de la realización (Obsoleto)")>
          Public Property ReferenciaMotivoDeLaRealizacionObsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaMotivoDeLaRealizacionObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaMotivoDeLaRealizacionObsoleto"",""etiqueta"": ""Motivo de la realización (Obsoleto)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""93baaee5-b723-4642-8e9d-c8d34d683f15"",""titulo"": ""Base - Motivos de realización de turnos"",""iconoid"": ""91bfd55e-338f-47ac-a7ca-4c0af172d491"",""etiquetasingular"": ""Motivo de realización de turno"",""etiquetaplural"": ""Motivos de realización de turnos"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""93baaee5-b723-4642-8e9d-c8d34d683f15"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Motivo de la realización (Obsoleto)"",""descripcion"": """",""keyword"": ""ReferenciaMotivoDeLaRealizacionObsoleto"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaMotivoDeLaRealizacionObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaMotivoDeLaRealizacionObsoleto
          <DisplayName("Realización concluida")>
          Public Property RealizacionConcluida As Boolean
          Public Shared ___RealizacionConcluida As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RealizacionConcluida"",""etiqueta"": ""Realización concluida"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Realización concluida"",""descripcion"": """",""keyword"": ""RealizacionConcluida"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RealizacionConcluida As DinaNETCore.APID.DinaupAPI_CampoC = ___RealizacionConcluida
          <DisplayName("Margen de inicio de turno")>
          Public Property MargenDeInicioDeTurno As Integer
          Public Shared ___MargenDeInicioDeTurno As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""MargenDeInicioDeTurno"",""etiqueta"": ""Margen de inicio de turno"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 14,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Margen de inicio de turno"",""descripcion"": """",""keyword"": ""MargenDeInicioDeTurno"",""formato"": 2,""rol"": 14,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __MargenDeInicioDeTurno As DinaNETCore.APID.DinaupAPI_CampoC = ___MargenDeInicioDeTurno
          <DisplayName("Margen de fin de turno")>
          Public Property MargenDeFinDeTurno As Integer
          Public Shared ___MargenDeFinDeTurno As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""MargenDeFinDeTurno"",""etiqueta"": ""Margen de fin de turno"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 14,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Margen de fin de turno"",""descripcion"": """",""keyword"": ""MargenDeFinDeTurno"",""formato"": 2,""rol"": 14,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __MargenDeFinDeTurno As DinaNETCore.APID.DinaupAPI_CampoC = ___MargenDeFinDeTurno
          <DisplayName("Fecha máxima de fin de turno")>
          Public Property FechaMaximaDeFinDeTurno_UTC As Date?
          Public Shared ___FechaMaximaDeFinDeTurno_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaMaximaDeFinDeTurno_UTC"",""etiqueta"": ""Fecha máxima de fin de turno"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 22,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha máxima de fin de turno"",""descripcion"": """",""keyword"": ""FechaMaximaDeFinDeTurno_UTC"",""formato"": 6,""rol"": 22,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaMaximaDeFinDeTurno_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaMaximaDeFinDeTurno_UTC
          <DisplayName("Primer control presencial de la realización (Obsoleto)")>
          Public Property ReferenciaPrimerControlPresencialDeLaRealizacionObsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaPrimerControlPresencialDeLaRealizacionObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaPrimerControlPresencialDeLaRealizacionObsoleto"",""etiqueta"": ""Primer control presencial de la realización (Obsoleto)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""ccc34d94-b2df-4307-b440-c45ee8ac8b81"",""titulo"": ""Base - Control de presencia"",""iconoid"": ""5ada56f9-4d51-412b-af3b-d39db1391cbd"",""etiquetasingular"": ""Control de presencia"",""etiquetaplural"": ""Controles de presencia"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""ccc34d94-b2df-4307-b440-c45ee8ac8b81"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Primer control presencial de la realización (Obsoleto)"",""descripcion"": """",""keyword"": ""ReferenciaPrimerControlPresencialDeLaRealizacionObsoleto"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaPrimerControlPresencialDeLaRealizacionObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaPrimerControlPresencialDeLaRealizacionObsoleto
          <DisplayName("Último control presencial de la realización (Obsoleto)")>
          Public Property ReferenciaUltimoControlPresencialDeLaRealizacionObsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaUltimoControlPresencialDeLaRealizacionObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaUltimoControlPresencialDeLaRealizacionObsoleto"",""etiqueta"": ""Último control presencial de la realización (Obsoleto)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""ccc34d94-b2df-4307-b440-c45ee8ac8b81"",""titulo"": ""Base - Control de presencia"",""iconoid"": ""5ada56f9-4d51-412b-af3b-d39db1391cbd"",""etiquetasingular"": ""Control de presencia"",""etiquetaplural"": ""Controles de presencia"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""ccc34d94-b2df-4307-b440-c45ee8ac8b81"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Último control presencial de la realización (Obsoleto)"",""descripcion"": """",""keyword"": ""ReferenciaUltimoControlPresencialDeLaRealizacionObsoleto"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaUltimoControlPresencialDeLaRealizacionObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaUltimoControlPresencialDeLaRealizacionObsoleto
          <DisplayName("Fecha mínima de inicio de turno")>
          Public Property FechaMinimaDeInicioDeTurno_UTC As Date?
          Public Shared ___FechaMinimaDeInicioDeTurno_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaMinimaDeInicioDeTurno_UTC"",""etiqueta"": ""Fecha mínima de inicio de turno"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 22,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha mínima de inicio de turno"",""descripcion"": """",""keyword"": ""FechaMinimaDeInicioDeTurno_UTC"",""formato"": 6,""rol"": 22,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaMinimaDeInicioDeTurno_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaMinimaDeInicioDeTurno_UTC
          <ReadOnlyAttribute(True)>
          <DisplayName("ID")>
          Public Property ID As Guid
          Public Shared ___ID As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": true,""eseliminado"": false,""keyword"": ""ID"",""etiqueta"": ""ID"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""f5dc61e5-af83-4760-9393-1c6e2e6ddf22"",""titulo"": ""Horas extraordinarias"",""iconoid"": ""382876b3-2eef-4b6e-aec7-c299a4b8d58f"",""etiquetasingular"": ""Horas extraordinarias"",""etiquetaplural"": ""Horas extraordinarias"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""f5dc61e5-af83-4760-9393-1c6e2e6ddf22"",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""ID"",""descripcion"": """",""keyword"": ""ID"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
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
          me.FechaDato_UTC = _Datos.Leer_DateTime_Nulable("pr_1863c96f6bx340wd")
          me.ReferenciaUbicacionPrincipal = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_1863c96f56x31dwd"), _Datos.Leer_String("pr_1863c96f56x31dwd.nombre"))
          me.TotalHorasExtraEnNominaEnMinutos = _Datos.Leer_Decimal("pr_30040139131")
          me.ImporteImportePorHoraRealizadaFueraDeHorario = _Datos.Leer_Decimal("pr_30040139132")
          me.EstadoDeLaRealizacion = _Datos.Leer_EnumTipoDeRealizacionDeTurnoE("pr_30040103561")
          me.HoraEnLaQueFinalizo_UTC = _Datos.Leer_DateTime_Nulable("pr_1863d56b05x327wd")
          me.MinutosConSesionActiva = _Datos.Leer_Integer("pr_1873d23d48x3e4wd")
          me.RegistrosEliminados = _Datos.Leer_Integer("pr_186415d176xccwd")
          me.SesionesIniciadas = _Datos.Leer_Integer("pr_1864145b2axeawd")
          me.MinutosRetrasoEntrada = _Datos.Leer_Integer("pr_1863e9ef8dx221wd")
          me.RegistrosRestaurados = _Datos.Leer_Integer("pr_1864168675x2a5wd")
          me.MinutosRetrasoSalida = _Datos.Leer_Integer("pr_1863ea67cbx217wd")
          me.HoraProgramadaDeFin_UTC = _Datos.Leer_DateTime_Nulable("pr_1863d05476x6awd")
          me.RegistrosAgregados = _Datos.Leer_Integer("pr_186411ab2dx4dwd")
          me.RegistrosVisitados = _Datos.Leer_Integer("pr_1864133a72x194wd")
          me.DuracionTurnoEnMinutos = _Datos.Leer_Integer("pr_1863e88aa5x128wd")
          me.HoraProgramadaDeInicio_UTC = _Datos.Leer_DateTime_Nulable("pr_1863cf7342x2cfwd")
          me.RegistrosModificados = _Datos.Leer_Integer("pr_186412b750x102wd")
          me.RealizacionEnMinutos = _Datos.Leer_Integer("pr_1863e95bdfx236wd")
          me.HoraEnLaQueInicio_UTC = _Datos.Leer_DateTime_Nulable("pr_1863d4dfc1x28ewd")
          me.MinutosExtrasTrabajados = _Datos.Leer_Integer("pr_1864ee2a65xfawd")
          me.Observaciones = _Datos.Leer_String("pr_20040138403")
          me.EsDeFuerzaMayor = _Datos.Leer_Boolean("pr_20040138404")
          me.ReferenciaDestinador = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_1863b69bc5x86wd"), _Datos.Leer_String("pr_1863b69bc5x86wd.nombre"))
          me.HoraLocal = _Datos.Leer_Time_Nulable("pr_776ae16wd")
          me.EmpleadoTieneAccesoWeb = _Datos.Leer_Boolean("pr_1863ca986fx36cwd")
          me.AutorDelAltaTieneAccesoWeb = _Datos.Leer_Boolean("pr_1863c09a8ax1b5wd")
          me.AdaptarElImporteAPagarSegunElHorarioRealizado = _Datos.Leer_Boolean("pr_10040139172")
          me.InformesVisualizados = _Datos.Leer_Integer("pr_186410cfabx328wd")
          me.ReferenciaAutorDelAlta = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_1863b69b6ex213wd"), _Datos.Leer_String("pr_1863b69b6ex213wd.nombre"))
          me.FechaAlta_UTC = _Datos.Leer_DateTime_Nulable("pr_1863b69b89x23ewd")
          me.ReferenciaEmpleadoPrincipal = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_1863c96f39x2awd"), _Datos.Leer_String("pr_1863c96f39x2awd.nombre"))
          me.ImporteImportePorHoraNoRealizadaDentroDeHorario = _Datos.Leer_Decimal("pr_20040138406")
          me.FechaDeRealizacion = _Datos.Leer_Date_Nulable("pr_10040139141")
          me.ReferenciaMotivoDeLaRealizacionObsoleto = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_50040112221"), _Datos.Leer_String("pr_50040112221.nombre"))
          me.RealizacionConcluida = _Datos.Leer_Boolean("pr_40040209613")
          me.MargenDeInicioDeTurno = _Datos.Leer_Integer("pr_50040210385")
          me.MargenDeFinDeTurno = _Datos.Leer_Integer("pr_50040210384")
          me.FechaMaximaDeFinDeTurno_UTC = _Datos.Leer_DateTime_Nulable("pr_60040210381")
          me.ReferenciaPrimerControlPresencialDeLaRealizacionObsoleto = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_1863f6083fx36wd"), _Datos.Leer_String("pr_1863f6083fx36wd.nombre"))
          me.ReferenciaUltimoControlPresencialDeLaRealizacionObsoleto = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_1863f72522xd7wd"), _Datos.Leer_String("pr_1863f72522xd7wd.nombre"))
          me.FechaMinimaDeInicioDeTurno_UTC = _Datos.Leer_DateTime_Nulable("pr_60040210382")
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
         R.add("pr_1863c96f6bx340wd", me.FechaDato_UTC.AdaptarMySQL_DateTime_Nulable())
         If Me.ReferenciaUbicacionPrincipal IsNot nothing then
           R.add("pr_1863c96f56x31dwd",me.ReferenciaUbicacionPrincipal.ID.STR())
         Else
           R.add("pr_1863c96f56x31dwd","")
         End if
         R.add("pr_30040139131", me.TotalHorasExtraEnNominaEnMinutos.AdaptarMySQL_Decimal())
         R.add("pr_30040139132", me.ImporteImportePorHoraRealizadaFueraDeHorario.AdaptarMySQL_Decimal())
         R.add("pr_30040103561", me.EstadoDeLaRealizacion.AdaptarMySQL_EnumTipoDeRealizacionDeTurnoE())
         R.add("pr_1863d56b05x327wd", me.HoraEnLaQueFinalizo_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_1873d23d48x3e4wd", me.MinutosConSesionActiva.AdaptarMySQL_Integer())
         R.add("pr_186415d176xccwd", me.RegistrosEliminados.AdaptarMySQL_Integer())
         R.add("pr_1864145b2axeawd", me.SesionesIniciadas.AdaptarMySQL_Integer())
         R.add("pr_1863e9ef8dx221wd", me.MinutosRetrasoEntrada.AdaptarMySQL_Integer())
         R.add("pr_1864168675x2a5wd", me.RegistrosRestaurados.AdaptarMySQL_Integer())
         R.add("pr_1863ea67cbx217wd", me.MinutosRetrasoSalida.AdaptarMySQL_Integer())
         R.add("pr_1863d05476x6awd", me.HoraProgramadaDeFin_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_186411ab2dx4dwd", me.RegistrosAgregados.AdaptarMySQL_Integer())
         R.add("pr_1864133a72x194wd", me.RegistrosVisitados.AdaptarMySQL_Integer())
         R.add("pr_1863e88aa5x128wd", me.DuracionTurnoEnMinutos.AdaptarMySQL_Integer())
         R.add("pr_1863cf7342x2cfwd", me.HoraProgramadaDeInicio_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_186412b750x102wd", me.RegistrosModificados.AdaptarMySQL_Integer())
         R.add("pr_1863e95bdfx236wd", me.RealizacionEnMinutos.AdaptarMySQL_Integer())
         R.add("pr_1863d4dfc1x28ewd", me.HoraEnLaQueInicio_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_1864ee2a65xfawd", me.MinutosExtrasTrabajados.AdaptarMySQL_Integer())
         R.add("pr_20040138403", me.Observaciones.AdaptarMySQL_String())
         R.add("pr_20040138404", me.EsDeFuerzaMayor.AdaptarMySQL_Boolean())
         If Me.ReferenciaDestinador IsNot nothing then
           R.add("pr_1863b69bc5x86wd",me.ReferenciaDestinador.ID.STR())
         Else
           R.add("pr_1863b69bc5x86wd","")
         End if
         R.add("pr_776ae16wd", me.HoraLocal.AdaptarMySQL_Time_Nulable())
         R.add("pr_1863ca986fx36cwd", me.EmpleadoTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_1863c09a8ax1b5wd", me.AutorDelAltaTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_10040139172", me.AdaptarElImporteAPagarSegunElHorarioRealizado.AdaptarMySQL_Boolean())
         R.add("pr_186410cfabx328wd", me.InformesVisualizados.AdaptarMySQL_Integer())
         If Me.ReferenciaAutorDelAlta IsNot nothing then
           R.add("pr_1863b69b6ex213wd",me.ReferenciaAutorDelAlta.ID.STR())
         Else
           R.add("pr_1863b69b6ex213wd","")
         End if
         R.add("pr_1863b69b89x23ewd", me.FechaAlta_UTC.AdaptarMySQL_DateTime_Nulable())
         If Me.ReferenciaEmpleadoPrincipal IsNot nothing then
           R.add("pr_1863c96f39x2awd",me.ReferenciaEmpleadoPrincipal.ID.STR())
         Else
           R.add("pr_1863c96f39x2awd","")
         End if
         R.add("pr_20040138406", me.ImporteImportePorHoraNoRealizadaDentroDeHorario.AdaptarMySQL_Decimal())
         R.add("pr_10040139141", me.FechaDeRealizacion.AdaptarMySQL_Date_Nulable())
         If Me.ReferenciaMotivoDeLaRealizacionObsoleto IsNot nothing then
           R.add("pr_50040112221",me.ReferenciaMotivoDeLaRealizacionObsoleto.ID.STR())
         Else
           R.add("pr_50040112221","")
         End if
         R.add("pr_40040209613", me.RealizacionConcluida.AdaptarMySQL_Boolean())
         R.add("pr_50040210385", me.MargenDeInicioDeTurno.AdaptarMySQL_Integer())
         R.add("pr_50040210384", me.MargenDeFinDeTurno.AdaptarMySQL_Integer())
         R.add("pr_60040210381", me.FechaMaximaDeFinDeTurno_UTC.AdaptarMySQL_DateTime_Nulable())
         If Me.ReferenciaPrimerControlPresencialDeLaRealizacionObsoleto IsNot nothing then
           R.add("pr_1863f6083fx36wd",me.ReferenciaPrimerControlPresencialDeLaRealizacionObsoleto.ID.STR())
         Else
           R.add("pr_1863f6083fx36wd","")
         End if
         If Me.ReferenciaUltimoControlPresencialDeLaRealizacionObsoleto IsNot nothing then
           R.add("pr_1863f72522xd7wd",me.ReferenciaUltimoControlPresencialDeLaRealizacionObsoleto.ID.STR())
         Else
           R.add("pr_1863f72522xd7wd","")
         End if
         R.add("pr_60040210382", me.FechaMinimaDeInicioDeTurno_UTC.AdaptarMySQL_DateTime_Nulable())
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
      Public Class HorasExtraordinarias_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
          Public property FechaDato_UTC As Date
            get
                return me.GetValue_DateTime("pr_1863c96f6bx340wd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_1863c96f6bx340wd", value)
            End Set
          End Property
          Public property ReferenciaUbicacionPrincipal As Guid
            get
                return me.GetValue_Guid("pr_1863c96f56x31dwd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_1863c96f56x31dwd", value)
            End Set
          End Property
        Public ReadOnly property TotalHorasExtraEnNominaEnMinutos As Decimal
            get
                return me.GetValue_Decimal("pr_30040139131")
            End Get   
        End Property
        Public ReadOnly property ImporteImportePorHoraRealizadaFueraDeHorario As Decimal
            get
                return me.GetValue_Decimal("pr_30040139132")
            End Get   
        End Property
          Public property EstadoDeLaRealizacion__Int as Integer
            get
                return me.GetValue_Int("pr_30040103561")
            End Get
            Set(value as Integer)
                me.SetValue_Int("pr_30040103561", value)
            End Set
          End Property
          Public property EstadoDeLaRealizacion As EnumTipoDeRealizacionDeTurnoE
            get
                return me.GetValue_Int("pr_30040103561")
            End Get
            Set(value As EnumTipoDeRealizacionDeTurnoE)
                me.SetValue_Int("pr_30040103561", value)
            End Set
          End Property
          Public property HoraEnLaQueFinalizo_UTC As Date
            get
                return me.GetValue_DateTime("pr_1863d56b05x327wd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_1863d56b05x327wd", value)
            End Set
          End Property
          Public property MinutosConSesionActiva As Integer
            get
                return me.GetValue_Int("pr_1873d23d48x3e4wd")
            End Get
            Set(value As Integer)
                me.SetValue_Int("pr_1873d23d48x3e4wd", value)
            End Set
          End Property
        Public ReadOnly property RegistrosEliminados As Integer
            get
                return me.GetValue_Int("pr_186415d176xccwd")
            End Get   
        End Property
        Public ReadOnly property SesionesIniciadas As Integer
            get
                return me.GetValue_Int("pr_1864145b2axeawd")
            End Get   
        End Property
          Public property MinutosRetrasoEntrada As Integer
            get
                return me.GetValue_Int("pr_1863e9ef8dx221wd")
            End Get
            Set(value As Integer)
                me.SetValue_Int("pr_1863e9ef8dx221wd", value)
            End Set
          End Property
        Public ReadOnly property RegistrosRestaurados As Integer
            get
                return me.GetValue_Int("pr_1864168675x2a5wd")
            End Get   
        End Property
          Public property MinutosRetrasoSalida As Integer
            get
                return me.GetValue_Int("pr_1863ea67cbx217wd")
            End Get
            Set(value As Integer)
                me.SetValue_Int("pr_1863ea67cbx217wd", value)
            End Set
          End Property
          Public property HoraProgramadaDeFin_UTC As Date
            get
                return me.GetValue_DateTime("pr_1863d05476x6awd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_1863d05476x6awd", value)
            End Set
          End Property
        Public ReadOnly property RegistrosAgregados As Integer
            get
                return me.GetValue_Int("pr_186411ab2dx4dwd")
            End Get   
        End Property
        Public ReadOnly property RegistrosVisitados As Integer
            get
                return me.GetValue_Int("pr_1864133a72x194wd")
            End Get   
        End Property
          Public property DuracionTurnoEnMinutos As Integer
            get
                return me.GetValue_Int("pr_1863e88aa5x128wd")
            End Get
            Set(value As Integer)
                me.SetValue_Int("pr_1863e88aa5x128wd", value)
            End Set
          End Property
          Public property HoraProgramadaDeInicio_UTC As Date
            get
                return me.GetValue_DateTime("pr_1863cf7342x2cfwd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_1863cf7342x2cfwd", value)
            End Set
          End Property
        Public ReadOnly property RegistrosModificados As Integer
            get
                return me.GetValue_Int("pr_186412b750x102wd")
            End Get   
        End Property
          Public property RealizacionEnMinutos As Integer
            get
                return me.GetValue_Int("pr_1863e95bdfx236wd")
            End Get
            Set(value As Integer)
                me.SetValue_Int("pr_1863e95bdfx236wd", value)
            End Set
          End Property
          Public property HoraEnLaQueInicio_UTC As Date
            get
                return me.GetValue_DateTime("pr_1863d4dfc1x28ewd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_1863d4dfc1x28ewd", value)
            End Set
          End Property
        Public ReadOnly property MinutosExtrasTrabajados As Integer
            get
                return me.GetValue_Int("pr_1864ee2a65xfawd")
            End Get   
        End Property
          Public property Observaciones As String
            get
                return me.GetValue_String("pr_20040138403")
            End Get
            Set(value As String)
                me.SetValue_String("pr_20040138403", value)
            End Set
          End Property
          Public property EsDeFuerzaMayor As Boolean
            get
                return me.GetValue_Boolean("pr_20040138404")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_20040138404", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_1863b69bc5x86wd")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As DateTime
            get
                return me.GetValue_DateTime("pr_776ae16wd")
            End Get   
        End Property
          Public property EmpleadoTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_1863ca986fx36cwd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_1863ca986fx36cwd", value)
            End Set
          End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_1863c09a8ax1b5wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_1863c09a8ax1b5wd", value)
            End Set
          End Property
          Public property AdaptarElImporteAPagarSegunElHorarioRealizado As Boolean
            get
                return me.GetValue_Boolean("pr_10040139172")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_10040139172", value)
            End Set
          End Property
        Public ReadOnly property InformesVisualizados As Integer
            get
                return me.GetValue_Int("pr_186410cfabx328wd")
            End Get   
        End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_1863b69b6ex213wd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_1863b69b6ex213wd", value)
            End Set
          End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_1863b69b89x23ewd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_1863b69b89x23ewd", value)
            End Set
          End Property
          Public property ReferenciaEmpleadoPrincipal As Guid
            get
                return me.GetValue_Guid("pr_1863c96f39x2awd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_1863c96f39x2awd", value)
            End Set
          End Property
          Public property ImporteImportePorHoraNoRealizadaDentroDeHorario As Decimal
            get
                return me.GetValue_Decimal("pr_20040138406")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_20040138406", value)
            End Set
          End Property
        Public ReadOnly property FechaDeRealizacion As Date
            get
                return me.GetValue_Date("pr_10040139141")
            End Get   
        End Property
          Public property ReferenciaMotivoDeLaRealizacionObsoleto As Guid
            get
                return me.GetValue_Guid("pr_50040112221")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_50040112221", value)
            End Set
          End Property
          Public property RealizacionConcluida As Boolean
            get
                return me.GetValue_Boolean("pr_40040209613")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_40040209613", value)
            End Set
          End Property
          Public property MargenDeInicioDeTurno As Integer
            get
                return me.GetValue_Int("pr_50040210385")
            End Get
            Set(value As Integer)
                me.SetValue_Int("pr_50040210385", value)
            End Set
          End Property
          Public property MargenDeFinDeTurno As Integer
            get
                return me.GetValue_Int("pr_50040210384")
            End Get
            Set(value As Integer)
                me.SetValue_Int("pr_50040210384", value)
            End Set
          End Property
        Public ReadOnly property FechaMaximaDeFinDeTurno_UTC As Date
            get
                return me.GetValue_DateTime("pr_60040210381")
            End Get   
        End Property
          Public property ReferenciaPrimerControlPresencialDeLaRealizacionObsoleto As Guid
            get
                return me.GetValue_Guid("pr_1863f6083fx36wd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_1863f6083fx36wd", value)
            End Set
          End Property
          Public property ReferenciaUltimoControlPresencialDeLaRealizacionObsoleto As Guid
            get
                return me.GetValue_Guid("pr_1863f72522xd7wd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_1863f72522xd7wd", value)
            End Set
          End Property
        Public ReadOnly property FechaMinimaDeInicioDeTurno_UTC As Date
            get
                return me.GetValue_DateTime("pr_60040210382")
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
