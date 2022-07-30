   Imports System.ComponentModel
   Imports DinaNETCore
   Imports DinaNETCore.APID
Partial Public Class SeccionesD
  Public Class EmpleadosD
      Public Shared _SeccionID As String = "c6e071c7-776f-4300-aa55-c711fd1da916"
      Public Shared _SeccionIDGUID As New Guid("c6e071c7-776f-4300-aa55-c711fd1da916")
      Public Shared Async Function ConsultarDatos_Async(Parametros As SeccionConsultaParametrosC) As Task(Of List(Of EmpleadosC )) 
          Dim R As New List(Of EmpleadosC )  
          Dim d = Await Parametros.DinaupSesion.ConexionServidor.Funcion_Datos_Recibir_Async(EmpleadosES._SeccionID, False, Parametros) 
          If d.Datos.TieneDatos Then 
              For Each Actual In d.Datos 
                  Dim Valores_Listador = Actual.Value.Item1
                  Dim Obj_Listador As New EmpleadosC 
                  Obj_Listador.CargarDatos(Valores_Listador) 
                  Obj_Listador.CargaInterna(Actual.Value)
                  R.Add(Obj_Listador) 
              Next 
          End If 
          Return R 
      End Function 
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As EmpleadosC, Optional CampoWhere$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Return Await DatosGuardar_Async(DinaupSesion, New List(Of EmpleadosC)({DAtos}), CampoWhere )
      End Function
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As List(Of EmpleadosC), Optional CampoWhere$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Dim Importar As New List(Of DinaupAPI_ImportacionProcesableC)
          For Each Actual In DAtos 
              Dim RegistroActual = New DinaupAPI_ImportacionProcesableC() 
               RegistroActual.dinaup_listador_datos = Actual.ToDic 
               Importar.Add(RegistroActual)  
          Next 
          Return Await DinaupSesion.ConexionServidor.Funcion_Importar_Ejecutar_Async(DinaupSesion, EmpleadosES._SeccionID, Importar, CampoWhere, "") 
      End Function
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As Empleados_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, EmpleadosES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New Empleados_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As Empleados_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, EmpleadosES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New Empleados_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class EmpleadosES
          Public shared _SeccionID as Guid = New Guid("c6e071c7-776f-4300-aa55-c711fd1da916")
          Public shared _Tabla$ = "tpr_2c597b"
      Public Shared FechaDeNacimiento$ = "pr_2c619d"
      Public Shared ReferenciaFoto$ = "pr_5f05940d"
      Public Shared ReferenciaConfiguracion$ = "pr_74e2017wd"
      Public Shared EsAdministrador$ = "pr_2086n"
      Public Shared ReferenciaTurnoRealizandoObsoleto$ = "pr_1a0c0a5d3exb6wd"
      Public Shared ContraseñaObsoleto$ = "pr_14196n"
      Public Shared ReferenciaUbicacionDeConexionObsoleto$ = "pr_1556n"
      Public Shared IdentificadorAcceso$ = "pr_2bba690w12"
      Public Shared ReferenciaRol$ = "pr_74e2013wd"
      Public Shared Genero$ = "pr_7cb26aawd"
      Public Shared SesionIniciadaObsoleto$ = "pr_1a0c0d2c8cxc7wd"
      Public Shared ContraseñaAccesoSistema$ = "pr_3ffd627x9ewc"
      Public Shared FechaAlta_UTC$ = "pr_14c9f3ea9cg142wd"
      Public Shared ColorIdentificativo$ = "pr_7cb2816wd"
      Public Shared NIFObsoleto$ = "pr_2c5a37"
      Public Shared ReferenciaPuestoDeTrabajo$ = "pr_441e166x11awc"
      Public Shared EstadoCivil$ = "pr_5f0bfbe5"
      Public Shared PuedeConectarAWeb$ = "pr_3ffdcd7x257wc"
      Public Shared Observaciones$ = "pr_2c6251"
      Public Shared PuedeConectarAlSistema$ = "pr_3ffd9c7x2fbwc"
      Public Shared ReferenciaCargoEnEmpresa$ = "pr_158a16b75ax2d6wd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_1463105af0x146wd"
      Public Shared FinalizacionAutomaticaDeTurno$ = "pr_1877f447c7x225wd"
      Public Shared NombreDePila$ = "pr_17da7be832x2f2wd"
      Public Shared UltimaInicioDeSesionObsoleto_UTC$ = "pr_1a0c164351x1a7wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_14631496d2x222wd"
      Public Shared ReferenciaDestinador$ = "pr_1463105b91g1f2wd"
      Public Shared HoraLocal$ = "pr_776ae62wd"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_1464b42080x42wd"
      Public Shared AusenteDesdeObsoleto_UTC$ = "pr_1a0c0b9973xbewd"
      Public Shared PuedeVincularUnTerminal$ = "pr_184973f89cxfcwd"
      Public Shared PuedeConectarFueraDelHorario$ = "pr_18466e3993x3d7wd"
      Public Shared AusenteObsoleto$ = "pr_1a0c0b37ecx2d3wd"
      Public Shared Cliente$ = "pr_400401177028"
      Public Shared ImporteSaldoAcumulado$ = "pr_2c6229"
      Public Shared ReferenciaDatosFiscales$ = "pr_40040138793"
      Public Shared Becario$ = "pr_50040147492"
      Public Shared ImporteImportePorHoraExtraTurnosObsoleto$ = "pr_6004017153109"
      Public Shared ImporteDescuentoPorHoraAusenciasYRetrasosTurnosObsoleto$ = "pr_6004017153108"
      Public Shared MargenDeInicioDeTurno$ = "pr_60040210342"
      Public Shared MargenDeFinDeTurno$ = "pr_60040210341"
      Public Shared ImporteImporteHoraExtraTurnosExtrasObsoleto$ = "pr_20040210881"
      Public Shared ImporteImportePorHoraExtraDeFuerzaMayorTurnosExtrasObsoleto$ = "pr_30040210801"
      Public Shared ImporteImportePorHoraExtraDeFuerzaMayorTurnosObsoleto$ = "pr_50040211301"
      Public Shared AdaptarElImporteAPagarSegunElHorarioRealizadoTurnos$ = "pr_60040211302"
      Public Shared AdaptarElImporteAPagarSegunElHorarioRealizadoTurnosExtras$ = "pr_20040210883"
      Public Shared TiempoMinimoParaEvaluarTiempoTrabajadoDeMas$ = "pr_30040211304"
      Public Shared TiempoMinimoParaEvaluarTiempoTrabajadoDeMenos$ = "pr_30040211305"
      Public Shared RegistrarTurnosAutomaticamenteEnBaseAHorario$ = "pr_20040212062"
      Public Shared MotivoDeBloqueoAccesoWeb$ = "pr_10040218972"
      Public Shared ReferenciaServidor$ = "pr_20040212332"
      Public Shared EsAdministradorDeLaEmpresa$ = "pr_30040222581"
      Public Shared EsUnaEntidadJuridica$ = "pr_60040222581"
      Public Shared SolicitarCambioDeContraseñaAlIniciarSesion$ = "pr_30040419861"
      Public Shared ReferenciaCorreoDeEmpresa$ = "pr_60040164241"
      Public Shared CorreoDondeEnviarLasNotificaciones$ = "pr_50040260013"
      Public Shared FirmaDeCorreo$ = "pr_20040425825"
      Public Shared PuedeAdministrarTodasLasEmpresas$ = "pr_40040291891"
      Public Shared PuedeConectarATodasLasUbicaciones$ = "pr_20040480317"
      Public Shared ReferenciaDepositoPreferente$ = "pr_40040114841"
      Public Shared DescuentoVentaPorciento$ = "pr_654454e9"
      Public Shared VenderConRecargoDeEquivalencia$ = "pr_15n"
      Public Shared ComprarConRecargoDeEquivalencia$ = "pr_41b6976x20cwc"
      Public Shared ImporteModificadorSaldoAjustes$ = "pr_17e4513d83x360wd"
      Public Shared DescuentoComprasPorciento$ = "pr_41b69c1x2a9wc"
      Public Shared ReferenciaTipoDeCliente$ = "pr_17f93d5e2exe8wd"
      Public Shared ReferenciaSubcuentaDeProveedor$ = "pr_60040136501"
      Public Shared ReferenciaSubcuentaDeCliente$ = "pr_10040133033"
      Public Shared ReferenciaSubcuentaPagoPendienteDeNominas$ = "pr_50040142261"
      Public Shared ReferenciaSubcuentaSueldosYSalarios$ = "pr_60040142383"
      Public Shared ReferenciaSubcuentaAdelantosDeNomina$ = "pr_30040146561"
      Public Shared ReferenciaSubcuentaSuplidos$ = "pr_40040256643"
      Public Shared EsChofer$ = "pr_20010421782"
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
      Public Class EmpleadosC
      Inherits Base_DatoC
          <DisplayName("Fecha de nacimiento")>
          Public Property FechaDeNacimiento As Date?
          Public Shared ___FechaDeNacimiento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaDeNacimiento"",""etiqueta"": ""Fecha de nacimiento"",""oculta"": false,""formato"": 7,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha de nacimiento"",""descripcion"": """",""keyword"": ""FechaDeNacimiento"",""formato"": 7,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaDeNacimiento As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaDeNacimiento
          <DisplayName("Foto")>
          Public Property ReferenciaFoto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaFoto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaFoto"",""etiqueta"": ""Foto"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""imagenes"",""rol"": 17,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Foto"",""descripcion"": """",""keyword"": ""ReferenciaFoto"",""formato"": 9,""rol"": 17,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaFoto As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaFoto
          <DisplayName("Configuración")>
          Public Property ReferenciaConfiguracion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaConfiguracion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaConfiguracion"",""etiqueta"": ""Configuración"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""de57325e-dc66-4782-aa5b-18fa69ed6c11"",""titulo"": ""Base - Configuración de Sistema"",""iconoid"": ""8221755a-6d58-4252-8620-820c14b8b2b9"",""etiquetasingular"": ""Parámetro de configuración"",""etiquetaplural"": ""Parámetros de configuración"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""de57325e-dc66-4782-aa5b-18fa69ed6c11"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Configuración"",""descripcion"": """",""keyword"": ""ReferenciaConfiguracion"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaConfiguracion As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaConfiguracion
          <DisplayName("Es administrador")>
          Public Property EsAdministrador As Boolean
          Public Shared ___EsAdministrador As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EsAdministrador"",""etiqueta"": ""Es administrador"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Es administrador"",""descripcion"": """",""keyword"": ""EsAdministrador"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EsAdministrador As DinaNETCore.APID.DinaupAPI_CampoC = ___EsAdministrador
          <DisplayName("Turno realizando (Obsoleto)")>
          Public Property ReferenciaTurnoRealizandoObsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaTurnoRealizandoObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaTurnoRealizandoObsoleto"",""etiqueta"": ""Turno realizando (Obsoleto)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""cd8de914-43c4-492e-a984-03bcdfc3fba5"",""titulo"": ""Base Lista - Horarios"",""iconoid"": ""a85f4a18-2aac-46c9-9cd6-60f8b1cd9883"",""etiquetasingular"": ""Jornada de Horario"",""etiquetaplural"": ""Jornadas de Horario"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": true,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""cd8de914-43c4-492e-a984-03bcdfc3fba5"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Turno realizando (Obsoleto)"",""descripcion"": """",""keyword"": ""ReferenciaTurnoRealizandoObsoleto"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaTurnoRealizandoObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaTurnoRealizandoObsoleto
          <DisplayName("Contraseña (Obsoleto)")>
          Public Property ContraseñaObsoleto As String
          Public Shared ___ContraseñaObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ContraseñaObsoleto"",""etiqueta"": ""Contraseña (Obsoleto)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 10,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Contraseña (Obsoleto)"",""descripcion"": """",""keyword"": ""ContraseñaObsoleto"",""formato"": 5,""rol"": 10,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ContraseñaObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___ContraseñaObsoleto
          <Description("La última ubicación en la que se conectó este empleado.")>
          <DisplayName("Ubicación de conexión (Obsoleto)")>
          Public Property ReferenciaUbicacionDeConexionObsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaUbicacionDeConexionObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaUbicacionDeConexionObsoleto"",""etiqueta"": ""Ubicación de conexión (Obsoleto)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""b9adbfbf-a81a-45fb-861c-90502902c982"",""titulo"": ""Ubicaciones"",""iconoid"": ""b985b58f-7275-46b8-9b66-2c54346b0185"",""etiquetasingular"": ""Ubicación"",""etiquetaplural"": ""Ubicaciones"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""b9adbfbf-a81a-45fb-861c-90502902c982"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Ubicación de conexión (Obsoleto)"",""descripcion"": """",""keyword"": ""ReferenciaUbicacionDeConexionObsoleto"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaUbicacionDeConexionObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaUbicacionDeConexionObsoleto
          <DisplayName("Identificador Acceso")>
          Public Property IdentificadorAcceso As String
          Public Shared ___IdentificadorAcceso As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""IdentificadorAcceso"",""etiqueta"": ""Identificador Acceso"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Identificador Acceso"",""descripcion"": """",""keyword"": ""IdentificadorAcceso"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __IdentificadorAcceso As DinaNETCore.APID.DinaupAPI_CampoC = ___IdentificadorAcceso
          <DisplayName("Rol")>
          Public Property ReferenciaRol As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaRol As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaRol"",""etiqueta"": ""Rol"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""rolesusuario"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Rol"",""descripcion"": """",""keyword"": ""ReferenciaRol"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaRol As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaRol
          <DisplayName("Género")>
          Public Property Genero As EnumGeneroE
          Public Shared ___Genero As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Genero"",""etiqueta"": ""Género"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 45,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [0,1,2],""predefinidos_textos"": [""Indefinido"",""Masculino"",""Femenino""],""predefinidos_iconos"": [""https://cdn.dinaup.com/ico/enums/45_0.png"",""https://cdn.dinaup.com/ico/enums/45_1.png"",""https://cdn.dinaup.com/ico/enums/45_2.png""],""filtro"": {""titulo"": ""Género"",""descripcion"": """",""keyword"": ""Genero"",""formato"": 2,""rol"": 45,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false,""enumeracion"": {""titulo"": ""Enum - Genero"", ""valores"": [{""valor"": 0, ""titulo"": ""Indefinido""},{""valor"": 1, ""titulo"": ""Masculino""},{""valor"": 2, ""titulo"": ""Femenino""}]}},""solovalorespredefinidos"": true}")
          Public  __Genero As DinaNETCore.APID.DinaupAPI_CampoC = ___Genero
          <DisplayName("Sesión iniciada (Obsoleto)")>
          Public Property SesionIniciadaObsoleto As Boolean
          Public Shared ___SesionIniciadaObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""SesionIniciadaObsoleto"",""etiqueta"": ""Sesión iniciada (Obsoleto)"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Sesión iniciada (Obsoleto)"",""descripcion"": """",""keyword"": ""SesionIniciadaObsoleto"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __SesionIniciadaObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___SesionIniciadaObsoleto
          <DisplayName("Contraseña acceso sistema")>
          Public Property ContraseñaAccesoSistema As String
          Public Shared ___ContraseñaAccesoSistema As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ContraseñaAccesoSistema"",""etiqueta"": ""Contraseña acceso sistema"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 10,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Contraseña acceso sistema"",""descripcion"": """",""keyword"": ""ContraseñaAccesoSistema"",""formato"": 5,""rol"": 10,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ContraseñaAccesoSistema As DinaNETCore.APID.DinaupAPI_CampoC = ___ContraseñaAccesoSistema
          <DisplayName("Fecha Alta del registro")>
          Public Property FechaAlta_UTC As Date?
          Public Shared ___FechaAlta_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaAlta_UTC"",""etiqueta"": ""Fecha Alta del registro"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Alta del registro"",""descripcion"": """",""keyword"": ""FechaAlta_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaAlta_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaAlta_UTC
          <DisplayName("Color identificativo")>
          Public Property ColorIdentificativo As String
          Public Shared ___ColorIdentificativo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ColorIdentificativo"",""etiqueta"": ""Color identificativo"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 29,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Color identificativo"",""descripcion"": """",""keyword"": ""ColorIdentificativo"",""formato"": 5,""rol"": 29,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ColorIdentificativo As DinaNETCore.APID.DinaupAPI_CampoC = ___ColorIdentificativo
          <DisplayName("NIF (Obsoleto)")>
          Public Property NIFObsoleto As String
          Public Shared ___NIFObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""NIFObsoleto"",""etiqueta"": ""NIF (Obsoleto)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 79,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""NIF (Obsoleto)"",""descripcion"": """",""keyword"": ""NIFObsoleto"",""formato"": 5,""rol"": 79,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __NIFObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___NIFObsoleto
          <DisplayName("Puesto de trabajo")>
          Public Property ReferenciaPuestoDeTrabajo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaPuestoDeTrabajo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaPuestoDeTrabajo"",""etiqueta"": ""Puesto de trabajo"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""f777486d-e709-41be-9211-d9c6b4bb05d6"",""titulo"": ""Base - Puestos de trabajo"",""iconoid"": ""5d7008ed-1e2f-4dbe-a376-6261de330414"",""etiquetasingular"": ""Puesto de trabajo"",""etiquetaplural"": ""Puestos de trabajo"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""f777486d-e709-41be-9211-d9c6b4bb05d6"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Puesto de trabajo"",""descripcion"": """",""keyword"": ""ReferenciaPuestoDeTrabajo"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaPuestoDeTrabajo As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaPuestoDeTrabajo
          <DisplayName("Estado Civil")>
          Public Property EstadoCivil As String
          Public Shared ___EstadoCivil As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EstadoCivil"",""etiqueta"": ""Estado Civil"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Estado Civil"",""descripcion"": """",""keyword"": ""EstadoCivil"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EstadoCivil As DinaNETCore.APID.DinaupAPI_CampoC = ___EstadoCivil
          <DisplayName("Puede conectar a web")>
          Public Property PuedeConectarAWeb As Boolean
          Public Shared ___PuedeConectarAWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""PuedeConectarAWeb"",""etiqueta"": ""Puede conectar a web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Puede conectar a web"",""descripcion"": """",""keyword"": ""PuedeConectarAWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __PuedeConectarAWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___PuedeConectarAWeb
          <Description("Observaciones y características adicionales sobre el empleado.")>
          <DisplayName("Observaciones")>
          Public Property Observaciones As String
          Public Shared ___Observaciones As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Observaciones"",""etiqueta"": ""Observaciones"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 9,""decimales"": ""0"",""multilinea"": true,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Observaciones"",""descripcion"": """",""keyword"": ""Observaciones"",""formato"": 5,""rol"": 9,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Observaciones As DinaNETCore.APID.DinaupAPI_CampoC = ___Observaciones
          <DisplayName("Puede conectar al sistema")>
          Public Property PuedeConectarAlSistema As Boolean
          Public Shared ___PuedeConectarAlSistema As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""PuedeConectarAlSistema"",""etiqueta"": ""Puede conectar al sistema"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Puede conectar al sistema"",""descripcion"": """",""keyword"": ""PuedeConectarAlSistema"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __PuedeConectarAlSistema As DinaNETCore.APID.DinaupAPI_CampoC = ___PuedeConectarAlSistema
          <DisplayName("Cargo en empresa")>
          Public Property ReferenciaCargoEnEmpresa As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaCargoEnEmpresa As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaCargoEnEmpresa"",""etiqueta"": ""Cargo en empresa"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""d5d11fe8-5a40-4854-8c44-69ec0c53cabc"",""titulo"": ""Base - Cargos de trabajo"",""iconoid"": ""cbbffb10-91b8-4059-8bfa-4f04a76d3637"",""etiquetasingular"": ""Cargo"",""etiquetaplural"": ""Cargos"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""d5d11fe8-5a40-4854-8c44-69ec0c53cabc"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cargo en empresa"",""descripcion"": """",""keyword"": ""ReferenciaCargoEnEmpresa"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaCargoEnEmpresa As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaCargoEnEmpresa
          <DisplayName("Autor del alta")>
          Public Property ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaAutorDelAlta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaAutorDelAlta"",""etiqueta"": ""Autor del alta"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta"",""descripcion"": """",""keyword"": ""ReferenciaAutorDelAlta"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaAutorDelAlta
          <DisplayName("Finalización automática de turno")>
          Public Property FinalizacionAutomaticaDeTurno As Boolean
          Public Shared ___FinalizacionAutomaticaDeTurno As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FinalizacionAutomaticaDeTurno"",""etiqueta"": ""Finalización automática de turno"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Finalización automática de turno"",""descripcion"": """",""keyword"": ""FinalizacionAutomaticaDeTurno"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __FinalizacionAutomaticaDeTurno As DinaNETCore.APID.DinaupAPI_CampoC = ___FinalizacionAutomaticaDeTurno
          <DisplayName("Nombre de pila")>
          Public Property NombreDePila As String
          Public Shared ___NombreDePila As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""NombreDePila"",""etiqueta"": ""Nombre de pila"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Nombre de pila"",""descripcion"": """",""keyword"": ""NombreDePila"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __NombreDePila As DinaNETCore.APID.DinaupAPI_CampoC = ___NombreDePila
          <DisplayName("Última inicio de sesión (Obsoleto)")>
          Public Property UltimaInicioDeSesionObsoleto_UTC As Date?
          Public Shared ___UltimaInicioDeSesionObsoleto_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""UltimaInicioDeSesionObsoleto_UTC"",""etiqueta"": ""Última inicio de sesión (Obsoleto)"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Última inicio de sesión (Obsoleto)"",""descripcion"": """",""keyword"": ""UltimaInicioDeSesionObsoleto_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __UltimaInicioDeSesionObsoleto_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___UltimaInicioDeSesionObsoleto_UTC
          <DisplayName("Autor del alta Tiene Acceso web")>
          Public Property AutorDelAltaTieneAccesoWeb As Boolean
          Public Shared ___AutorDelAltaTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AutorDelAltaTieneAccesoWeb"",""etiqueta"": ""Autor del alta Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta Tiene Acceso web"",""descripcion"": """",""keyword"": ""AutorDelAltaTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AutorDelAltaTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___AutorDelAltaTieneAccesoWeb
          <DisplayName("Destinador")>
          Public Property ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaDestinador As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaDestinador"",""etiqueta"": ""Destinador"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""relacionesindirectas"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Destinador"",""descripcion"": """",""keyword"": ""ReferenciaDestinador"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaDestinador
          <DisplayName("Hora local")>
          Public Property HoraLocal As DateTime?
          Public Shared ___HoraLocal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""HoraLocal"",""etiqueta"": ""Hora local"",""oculta"": false,""formato"": 8,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Hora local"",""descripcion"": """",""keyword"": ""HoraLocal"",""formato"": 8,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __HoraLocal As DinaNETCore.APID.DinaupAPI_CampoC = ___HoraLocal
          <Description("Ubicación en la cual inicia sesión el usuario, esto afectará a los datos que dependan de la ubicación en la que esté trabajando. Por ejemplo, el stock de un producto. Y los registros que cree el empleado quedarán relacionados a dicha ubicación.")>
          <DisplayName("Ubicación Principal")>
          Public Property ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaUbicacionPrincipal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaUbicacionPrincipal"",""etiqueta"": ""Ubicación Principal"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""b9adbfbf-a81a-45fb-861c-90502902c982"",""titulo"": ""Ubicaciones"",""iconoid"": ""b985b58f-7275-46b8-9b66-2c54346b0185"",""etiquetasingular"": ""Ubicación"",""etiquetaplural"": ""Ubicaciones"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""b9adbfbf-a81a-45fb-861c-90502902c982"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Ubicación Principal"",""descripcion"": """",""keyword"": ""ReferenciaUbicacionPrincipal"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaUbicacionPrincipal
          <DisplayName("Ausente desde (Obsoleto)")>
          Public Property AusenteDesdeObsoleto_UTC As Date?
          Public Shared ___AusenteDesdeObsoleto_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AusenteDesdeObsoleto_UTC"",""etiqueta"": ""Ausente desde (Obsoleto)"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 22,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Ausente desde (Obsoleto)"",""descripcion"": """",""keyword"": ""AusenteDesdeObsoleto_UTC"",""formato"": 6,""rol"": 22,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __AusenteDesdeObsoleto_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___AusenteDesdeObsoleto_UTC
          <Description("Determina si el empleado podrá vincular un terminal a un puesto de trabajo.")>
          <DisplayName("Puede vincular un terminal")>
          Public Property PuedeVincularUnTerminal As Boolean
          Public Shared ___PuedeVincularUnTerminal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""PuedeVincularUnTerminal"",""etiqueta"": ""Puede vincular un terminal"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Puede vincular un terminal"",""descripcion"": """",""keyword"": ""PuedeVincularUnTerminal"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __PuedeVincularUnTerminal As DinaNETCore.APID.DinaupAPI_CampoC = ___PuedeVincularUnTerminal
          <DisplayName("Puede conectar fuera del horario")>
          Public Property PuedeConectarFueraDelHorario As Boolean
          Public Shared ___PuedeConectarFueraDelHorario As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""PuedeConectarFueraDelHorario"",""etiqueta"": ""Puede conectar fuera del horario"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Puede conectar fuera del horario"",""descripcion"": """",""keyword"": ""PuedeConectarFueraDelHorario"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __PuedeConectarFueraDelHorario As DinaNETCore.APID.DinaupAPI_CampoC = ___PuedeConectarFueraDelHorario
          <DisplayName("Ausente (Obsoleto)")>
          Public Property AusenteObsoleto As Boolean
          Public Shared ___AusenteObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AusenteObsoleto"",""etiqueta"": ""Ausente (Obsoleto)"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Ausente (Obsoleto)"",""descripcion"": """",""keyword"": ""AusenteObsoleto"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AusenteObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___AusenteObsoleto
          <DisplayName("Cliente")>
          Public Property Cliente As Boolean
          Public Shared ___Cliente As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Cliente"",""etiqueta"": ""Cliente"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cliente"",""descripcion"": """",""keyword"": ""Cliente"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Cliente As DinaNETCore.APID.DinaupAPI_CampoC = ___Cliente
          <DisplayName("Saldo acumulado")>
          Public Property ImporteSaldoAcumulado As Decimal
          Public Shared ___ImporteSaldoAcumulado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteSaldoAcumulado"",""etiqueta"": ""Saldo acumulado"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Saldo acumulado"",""descripcion"": """",""keyword"": ""ImporteSaldoAcumulado"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteSaldoAcumulado As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteSaldoAcumulado
          <DisplayName("Datos fiscales")>
          Public Property ReferenciaDatosFiscales As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaDatosFiscales As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaDatosFiscales"",""etiqueta"": ""Datos fiscales"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""03e347ac-c694-4d4a-a81f-e577ba014d1d"",""titulo"": ""Base - Datos fiscales"",""iconoid"": ""773d55f9-1e21-41f1-b0b0-f6a1dd370ea3"",""etiquetasingular"": ""Datos fiscales"",""etiquetaplural"": ""Datos fiscales"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""03e347ac-c694-4d4a-a81f-e577ba014d1d"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Datos fiscales"",""descripcion"": """",""keyword"": ""ReferenciaDatosFiscales"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaDatosFiscales As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaDatosFiscales
          <DisplayName("Becario")>
          Public Property Becario As Boolean
          Public Shared ___Becario As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Becario"",""etiqueta"": ""Becario"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Becario"",""descripcion"": """",""keyword"": ""Becario"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Becario As DinaNETCore.APID.DinaupAPI_CampoC = ___Becario
          <DisplayName("Importe por hora extra (Turnos) (Obsoleto)")>
          Public Property ImporteImportePorHoraExtraTurnosObsoleto As Decimal
          Public Shared ___ImporteImportePorHoraExtraTurnosObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteImportePorHoraExtraTurnosObsoleto"",""etiqueta"": ""Importe por hora extra (Turnos) (Obsoleto)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Importe por hora extra (Turnos) (Obsoleto)"",""descripcion"": """",""keyword"": ""ImporteImportePorHoraExtraTurnosObsoleto"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteImportePorHoraExtraTurnosObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteImportePorHoraExtraTurnosObsoleto
          <DisplayName("Descuento por hora (Ausencias y Retrasos) (Turnos) (Obsoleto)")>
          Public Property ImporteDescuentoPorHoraAusenciasYRetrasosTurnosObsoleto As Decimal
          Public Shared ___ImporteDescuentoPorHoraAusenciasYRetrasosTurnosObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteDescuentoPorHoraAusenciasYRetrasosTurnosObsoleto"",""etiqueta"": ""Descuento por hora (Ausencias y Retrasos) (Turnos) (Obsoleto)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento por hora (Ausencias y Retrasos) (Turnos) (Obsoleto)"",""descripcion"": """",""keyword"": ""ImporteDescuentoPorHoraAusenciasYRetrasosTurnosObsoleto"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteDescuentoPorHoraAusenciasYRetrasosTurnosObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteDescuentoPorHoraAusenciasYRetrasosTurnosObsoleto
          <Description("Margen de tiempo en el cual el empleado puede iniciar de forma anticipada su turno.")>
          <DisplayName("Margen de inicio de turno")>
          Public Property MargenDeInicioDeTurno As Integer
          Public Shared ___MargenDeInicioDeTurno As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""MargenDeInicioDeTurno"",""etiqueta"": ""Margen de inicio de turno"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Margen de inicio de turno"",""descripcion"": """",""keyword"": ""MargenDeInicioDeTurno"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __MargenDeInicioDeTurno As DinaNETCore.APID.DinaupAPI_CampoC = ___MargenDeInicioDeTurno
          <Description("Cantidad de tiempo extra que puede permanecer el empleado una vez haya finalizado el turno.")>
          <DisplayName("Margen de fin de turno")>
          Public Property MargenDeFinDeTurno As Integer
          Public Shared ___MargenDeFinDeTurno As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""MargenDeFinDeTurno"",""etiqueta"": ""Margen de fin de turno"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Margen de fin de turno"",""descripcion"": """",""keyword"": ""MargenDeFinDeTurno"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __MargenDeFinDeTurno As DinaNETCore.APID.DinaupAPI_CampoC = ___MargenDeFinDeTurno
          <DisplayName("Importe hora extra (Turnos extras) (Obsoleto)")>
          Public Property ImporteImporteHoraExtraTurnosExtrasObsoleto As Decimal
          Public Shared ___ImporteImporteHoraExtraTurnosExtrasObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteImporteHoraExtraTurnosExtrasObsoleto"",""etiqueta"": ""Importe hora extra (Turnos extras) (Obsoleto)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Importe hora extra (Turnos extras) (Obsoleto)"",""descripcion"": """",""keyword"": ""ImporteImporteHoraExtraTurnosExtrasObsoleto"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteImporteHoraExtraTurnosExtrasObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteImporteHoraExtraTurnosExtrasObsoleto
          <DisplayName("Importe por hora extra de fuerza mayor (Turnos extras) (Obsoleto)")>
          Public Property ImporteImportePorHoraExtraDeFuerzaMayorTurnosExtrasObsoleto As Decimal
          Public Shared ___ImporteImportePorHoraExtraDeFuerzaMayorTurnosExtrasObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteImportePorHoraExtraDeFuerzaMayorTurnosExtrasObsoleto"",""etiqueta"": ""Importe por hora extra de fuerza mayor (Turnos extras) (Obsoleto)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Importe por hora extra de fuerza mayor (Turnos extras) (Obsoleto)"",""descripcion"": """",""keyword"": ""ImporteImportePorHoraExtraDeFuerzaMayorTurnosExtrasObsoleto"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteImportePorHoraExtraDeFuerzaMayorTurnosExtrasObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteImportePorHoraExtraDeFuerzaMayorTurnosExtrasObsoleto
          <DisplayName("Importe por hora extra de fuerza mayor (Turnos) (Obsoleto)")>
          Public Property ImporteImportePorHoraExtraDeFuerzaMayorTurnosObsoleto As Decimal
          Public Shared ___ImporteImportePorHoraExtraDeFuerzaMayorTurnosObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteImportePorHoraExtraDeFuerzaMayorTurnosObsoleto"",""etiqueta"": ""Importe por hora extra de fuerza mayor (Turnos) (Obsoleto)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Importe por hora extra de fuerza mayor (Turnos) (Obsoleto)"",""descripcion"": """",""keyword"": ""ImporteImportePorHoraExtraDeFuerzaMayorTurnosObsoleto"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteImportePorHoraExtraDeFuerzaMayorTurnosObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteImportePorHoraExtraDeFuerzaMayorTurnosObsoleto
          <DisplayName("Adaptar el importe a pagar según el horario realizado (Turnos)")>
          Public Property AdaptarElImporteAPagarSegunElHorarioRealizadoTurnos As Boolean
          Public Shared ___AdaptarElImporteAPagarSegunElHorarioRealizadoTurnos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AdaptarElImporteAPagarSegunElHorarioRealizadoTurnos"",""etiqueta"": ""Adaptar el importe a pagar según el horario realizado (Turnos)"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Adaptar el importe a pagar según el horario realizado (Turnos)"",""descripcion"": """",""keyword"": ""AdaptarElImporteAPagarSegunElHorarioRealizadoTurnos"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AdaptarElImporteAPagarSegunElHorarioRealizadoTurnos As DinaNETCore.APID.DinaupAPI_CampoC = ___AdaptarElImporteAPagarSegunElHorarioRealizadoTurnos
          <DisplayName("Adaptar el importe a pagar según el horario realizado (Turnos extras)")>
          Public Property AdaptarElImporteAPagarSegunElHorarioRealizadoTurnosExtras As Boolean
          Public Shared ___AdaptarElImporteAPagarSegunElHorarioRealizadoTurnosExtras As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AdaptarElImporteAPagarSegunElHorarioRealizadoTurnosExtras"",""etiqueta"": ""Adaptar el importe a pagar según el horario realizado (Turnos extras)"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Adaptar el importe a pagar según el horario realizado (Turnos extras)"",""descripcion"": """",""keyword"": ""AdaptarElImporteAPagarSegunElHorarioRealizadoTurnosExtras"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AdaptarElImporteAPagarSegunElHorarioRealizadoTurnosExtras As DinaNETCore.APID.DinaupAPI_CampoC = ___AdaptarElImporteAPagarSegunElHorarioRealizadoTurnosExtras
          <DisplayName("Tiempo mínimo para evaluar tiempo trabajado de más")>
          Public Property TiempoMinimoParaEvaluarTiempoTrabajadoDeMas As Decimal
          Public Shared ___TiempoMinimoParaEvaluarTiempoTrabajadoDeMas As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TiempoMinimoParaEvaluarTiempoTrabajadoDeMas"",""etiqueta"": ""Tiempo mínimo para evaluar tiempo trabajado de más"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 14,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Tiempo mínimo para evaluar tiempo trabajado de más"",""descripcion"": """",""keyword"": ""TiempoMinimoParaEvaluarTiempoTrabajadoDeMas"",""formato"": 3,""rol"": 14,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __TiempoMinimoParaEvaluarTiempoTrabajadoDeMas As DinaNETCore.APID.DinaupAPI_CampoC = ___TiempoMinimoParaEvaluarTiempoTrabajadoDeMas
          <DisplayName("Tiempo mínimo para evaluar tiempo trabajado de menos")>
          Public Property TiempoMinimoParaEvaluarTiempoTrabajadoDeMenos As Decimal
          Public Shared ___TiempoMinimoParaEvaluarTiempoTrabajadoDeMenos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TiempoMinimoParaEvaluarTiempoTrabajadoDeMenos"",""etiqueta"": ""Tiempo mínimo para evaluar tiempo trabajado de menos"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 14,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Tiempo mínimo para evaluar tiempo trabajado de menos"",""descripcion"": """",""keyword"": ""TiempoMinimoParaEvaluarTiempoTrabajadoDeMenos"",""formato"": 3,""rol"": 14,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __TiempoMinimoParaEvaluarTiempoTrabajadoDeMenos As DinaNETCore.APID.DinaupAPI_CampoC = ___TiempoMinimoParaEvaluarTiempoTrabajadoDeMenos
          <DisplayName("Registrar turnos automáticamente en base a horario")>
          Public Property RegistrarTurnosAutomaticamenteEnBaseAHorario As Boolean
          Public Shared ___RegistrarTurnosAutomaticamenteEnBaseAHorario As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RegistrarTurnosAutomaticamenteEnBaseAHorario"",""etiqueta"": ""Registrar turnos automáticamente en base a horario"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Registrar turnos automáticamente en base a horario"",""descripcion"": """",""keyword"": ""RegistrarTurnosAutomaticamenteEnBaseAHorario"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RegistrarTurnosAutomaticamenteEnBaseAHorario As DinaNETCore.APID.DinaupAPI_CampoC = ___RegistrarTurnosAutomaticamenteEnBaseAHorario
          <DisplayName("Motivo de bloqueo acceso web")>
          Public Property MotivoDeBloqueoAccesoWeb As String
          Public Shared ___MotivoDeBloqueoAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""MotivoDeBloqueoAccesoWeb"",""etiqueta"": ""Motivo de bloqueo acceso web"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Motivo de bloqueo acceso web"",""descripcion"": """",""keyword"": ""MotivoDeBloqueoAccesoWeb"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __MotivoDeBloqueoAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___MotivoDeBloqueoAccesoWeb
          <DisplayName("Servidor")>
          Public Property ReferenciaServidor As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaServidor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaServidor"",""etiqueta"": ""Servidor"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""eadd8f25-d9e0-46ef-89a7-e95efe769df1"",""titulo"": ""Base - Servidores"",""iconoid"": ""35aab678-4c97-4349-9cad-b4e5b4d301a3"",""etiquetasingular"": ""Servidor"",""etiquetaplural"": ""Servidores"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""eadd8f25-d9e0-46ef-89a7-e95efe769df1"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Servidor"",""descripcion"": """",""keyword"": ""ReferenciaServidor"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaServidor As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaServidor
          <Description("Indicar en aquellas personas o entidades que ostenten cargos de consejero, gestor, director, administrador general y otros análogos que supongan la" & vbCrLf & "dirección, administración o control de la empresa como entidad.")>
          <DisplayName("Es administrador de la empresa")>
          Public Property EsAdministradorDeLaEmpresa As Boolean
          Public Shared ___EsAdministradorDeLaEmpresa As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EsAdministradorDeLaEmpresa"",""etiqueta"": ""Es administrador de la empresa"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Es administrador de la empresa"",""descripcion"": """",""keyword"": ""EsAdministradorDeLaEmpresa"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EsAdministradorDeLaEmpresa As DinaNETCore.APID.DinaupAPI_CampoC = ___EsAdministradorDeLaEmpresa
          <DisplayName("Es una entidad jurídica")>
          Public Property EsUnaEntidadJuridica As Boolean
          Public Shared ___EsUnaEntidadJuridica As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EsUnaEntidadJuridica"",""etiqueta"": ""Es una entidad jurídica"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Es una entidad jurídica"",""descripcion"": """",""keyword"": ""EsUnaEntidadJuridica"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EsUnaEntidadJuridica As DinaNETCore.APID.DinaupAPI_CampoC = ___EsUnaEntidadJuridica
          <DisplayName("Solicitar cambio de contraseña al iniciar sesión")>
          Public Property SolicitarCambioDeContraseñaAlIniciarSesion As Boolean
          Public Shared ___SolicitarCambioDeContraseñaAlIniciarSesion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""SolicitarCambioDeContraseñaAlIniciarSesion"",""etiqueta"": ""Solicitar cambio de contraseña al iniciar sesión"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Solicitar cambio de contraseña al iniciar sesión"",""descripcion"": """",""keyword"": ""SolicitarCambioDeContraseñaAlIniciarSesion"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __SolicitarCambioDeContraseñaAlIniciarSesion As DinaNETCore.APID.DinaupAPI_CampoC = ___SolicitarCambioDeContraseñaAlIniciarSesion
          <DisplayName("Correo de empresa")>
          Public Property ReferenciaCorreoDeEmpresa As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaCorreoDeEmpresa As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaCorreoDeEmpresa"",""etiqueta"": ""Correo de empresa"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""e80ad188-9d6d-4b05-a7fb-e498cef51598"",""titulo"": ""Base - Cuentas de Correo electrónico"",""iconoid"": ""5fd758a4-dbc3-4365-ad56-18af81075b78"",""etiquetasingular"": ""Cuenta de correo electrónico"",""etiquetaplural"": ""Cuentas de Correo electrónico"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""e80ad188-9d6d-4b05-a7fb-e498cef51598"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Correo de empresa"",""descripcion"": """",""keyword"": ""ReferenciaCorreoDeEmpresa"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaCorreoDeEmpresa As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaCorreoDeEmpresa
          <DisplayName("Correo donde enviar las notificaciones")>
          Public Property CorreoDondeEnviarLasNotificaciones As String
          Public Shared ___CorreoDondeEnviarLasNotificaciones As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CorreoDondeEnviarLasNotificaciones"",""etiqueta"": ""Correo donde enviar las notificaciones"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 4,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Correo donde enviar las notificaciones"",""descripcion"": """",""keyword"": ""CorreoDondeEnviarLasNotificaciones"",""formato"": 5,""rol"": 4,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CorreoDondeEnviarLasNotificaciones As DinaNETCore.APID.DinaupAPI_CampoC = ___CorreoDondeEnviarLasNotificaciones
          <DisplayName("Firma de correo")>
          Public Property FirmaDeCorreo As String
          Public Shared ___FirmaDeCorreo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FirmaDeCorreo"",""etiqueta"": ""Firma de correo"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 140,""decimales"": ""0"",""multilinea"": true,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Firma de correo"",""descripcion"": """",""keyword"": ""FirmaDeCorreo"",""formato"": 5,""rol"": 140,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __FirmaDeCorreo As DinaNETCore.APID.DinaupAPI_CampoC = ___FirmaDeCorreo
          <DisplayName("Puede administrar todas las empresas")>
          Public Property PuedeAdministrarTodasLasEmpresas As Boolean
          Public Shared ___PuedeAdministrarTodasLasEmpresas As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""PuedeAdministrarTodasLasEmpresas"",""etiqueta"": ""Puede administrar todas las empresas"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Puede administrar todas las empresas"",""descripcion"": """",""keyword"": ""PuedeAdministrarTodasLasEmpresas"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __PuedeAdministrarTodasLasEmpresas As DinaNETCore.APID.DinaupAPI_CampoC = ___PuedeAdministrarTodasLasEmpresas
          <DisplayName("Puede conectar a todas las ubicaciones")>
          Public Property PuedeConectarATodasLasUbicaciones As Boolean
          Public Shared ___PuedeConectarATodasLasUbicaciones As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""PuedeConectarATodasLasUbicaciones"",""etiqueta"": ""Puede conectar a todas las ubicaciones"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Puede conectar a todas las ubicaciones"",""descripcion"": """",""keyword"": ""PuedeConectarATodasLasUbicaciones"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __PuedeConectarATodasLasUbicaciones As DinaNETCore.APID.DinaupAPI_CampoC = ___PuedeConectarATodasLasUbicaciones
          <Description("Depósito de empleado, este tendrá preferencia sobre el depósito de puesto de trabajo.")>
          <DisplayName("Depósito preferente")>
          Public Property ReferenciaDepositoPreferente As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaDepositoPreferente As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaDepositoPreferente"",""etiqueta"": ""Depósito preferente"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""cab2cf42-3cf6-4aa6-9930-c7ee704650bc"",""titulo"": ""Base - Depósitos monetarios"",""iconoid"": ""f037928c-b088-47e4-a79e-3d217109403b"",""etiquetasingular"": ""Depósito monetario"",""etiquetaplural"": ""Depósitos monetarios"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""cab2cf42-3cf6-4aa6-9930-c7ee704650bc"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Depósito preferente"",""descripcion"": """",""keyword"": ""ReferenciaDepositoPreferente"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaDepositoPreferente As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaDepositoPreferente
          <DisplayName("Descuento % (Venta)")>
          Public Property DescuentoVentaPorciento As Decimal
          Public Shared ___DescuentoVentaPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoVentaPorciento"",""etiqueta"": ""Descuento % (Venta)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento % (Venta)"",""descripcion"": """",""keyword"": ""DescuentoVentaPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoVentaPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoVentaPorciento
          <DisplayName("Vender con Recargo de Equivalencia")>
          Public Property VenderConRecargoDeEquivalencia As Boolean
          Public Shared ___VenderConRecargoDeEquivalencia As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""VenderConRecargoDeEquivalencia"",""etiqueta"": ""Vender con Recargo de Equivalencia"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Vender con Recargo de Equivalencia"",""descripcion"": """",""keyword"": ""VenderConRecargoDeEquivalencia"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __VenderConRecargoDeEquivalencia As DinaNETCore.APID.DinaupAPI_CampoC = ___VenderConRecargoDeEquivalencia
          <DisplayName("Comprar con recargo de equivalencia")>
          Public Property ComprarConRecargoDeEquivalencia As Boolean
          Public Shared ___ComprarConRecargoDeEquivalencia As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ComprarConRecargoDeEquivalencia"",""etiqueta"": ""Comprar con recargo de equivalencia"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Comprar con recargo de equivalencia"",""descripcion"": """",""keyword"": ""ComprarConRecargoDeEquivalencia"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ComprarConRecargoDeEquivalencia As DinaNETCore.APID.DinaupAPI_CampoC = ___ComprarConRecargoDeEquivalencia
          <DisplayName("Modificador Saldo Ajustes")>
          Public Property ImporteModificadorSaldoAjustes As Decimal
          Public Shared ___ImporteModificadorSaldoAjustes As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ImporteModificadorSaldoAjustes"",""etiqueta"": ""Modificador Saldo Ajustes"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 5,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Modificador Saldo Ajustes"",""descripcion"": """",""keyword"": ""ImporteModificadorSaldoAjustes"",""formato"": 3,""rol"": 5,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ImporteModificadorSaldoAjustes As DinaNETCore.APID.DinaupAPI_CampoC = ___ImporteModificadorSaldoAjustes
          <DisplayName("Descuento % (Compras)")>
          Public Property DescuentoComprasPorciento As Decimal
          Public Shared ___DescuentoComprasPorciento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DescuentoComprasPorciento"",""etiqueta"": ""Descuento % (Compras)"",""oculta"": false,""formato"": 3,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 6,""decimales"": ""2"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Descuento % (Compras)"",""descripcion"": """",""keyword"": ""DescuentoComprasPorciento"",""formato"": 3,""rol"": 6,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DescuentoComprasPorciento As DinaNETCore.APID.DinaupAPI_CampoC = ___DescuentoComprasPorciento
          <DisplayName("Tipo de Cliente")>
          Public Property ReferenciaTipoDeCliente As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaTipoDeCliente As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaTipoDeCliente"",""etiqueta"": ""Tipo de Cliente"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""8b1fa053-5abe-406e-9760-584ed34a3b97"",""titulo"": ""Base - Tipos de entidad"",""iconoid"": ""48978f8a-f2bd-4695-a897-3a0e7bfdc979"",""etiquetasingular"": ""Tipo de entidad"",""etiquetaplural"": ""Tipos de entidad"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""8b1fa053-5abe-406e-9760-584ed34a3b97"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Tipo de Cliente"",""descripcion"": """",""keyword"": ""ReferenciaTipoDeCliente"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaTipoDeCliente As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaTipoDeCliente
          <DisplayName("Subcuenta de Proveedor")>
          Public Property ReferenciaSubcuentaDeProveedor As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaSubcuentaDeProveedor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaSubcuentaDeProveedor"",""etiqueta"": ""Subcuenta de Proveedor"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c1578f25-c397-4882-a252-52b5fe65731c"",""titulo"": ""Base - Cuadro de cuentas"",""iconoid"": ""56e95fca-1432-4283-b4a2-1336964a155f"",""etiquetasingular"": ""Cuadro de cuenta"",""etiquetaplural"": ""Cuadro de cuentas"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""c1578f25-c397-4882-a252-52b5fe65731c"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Subcuenta de Proveedor"",""descripcion"": """",""keyword"": ""ReferenciaSubcuentaDeProveedor"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaSubcuentaDeProveedor As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaSubcuentaDeProveedor
          <DisplayName("Subcuenta de Cliente")>
          Public Property ReferenciaSubcuentaDeCliente As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaSubcuentaDeCliente As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaSubcuentaDeCliente"",""etiqueta"": ""Subcuenta de Cliente"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c1578f25-c397-4882-a252-52b5fe65731c"",""titulo"": ""Base - Cuadro de cuentas"",""iconoid"": ""56e95fca-1432-4283-b4a2-1336964a155f"",""etiquetasingular"": ""Cuadro de cuenta"",""etiquetaplural"": ""Cuadro de cuentas"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""c1578f25-c397-4882-a252-52b5fe65731c"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Subcuenta de Cliente"",""descripcion"": """",""keyword"": ""ReferenciaSubcuentaDeCliente"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaSubcuentaDeCliente As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaSubcuentaDeCliente
          <DisplayName("Subcuenta (Pago pendiente de nóminas)")>
          Public Property ReferenciaSubcuentaPagoPendienteDeNominas As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaSubcuentaPagoPendienteDeNominas As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaSubcuentaPagoPendienteDeNominas"",""etiqueta"": ""Subcuenta (Pago pendiente de nóminas)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c1578f25-c397-4882-a252-52b5fe65731c"",""titulo"": ""Base - Cuadro de cuentas"",""iconoid"": ""56e95fca-1432-4283-b4a2-1336964a155f"",""etiquetasingular"": ""Cuadro de cuenta"",""etiquetaplural"": ""Cuadro de cuentas"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""c1578f25-c397-4882-a252-52b5fe65731c"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Subcuenta (Pago pendiente de nóminas)"",""descripcion"": """",""keyword"": ""ReferenciaSubcuentaPagoPendienteDeNominas"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaSubcuentaPagoPendienteDeNominas As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaSubcuentaPagoPendienteDeNominas
          <DisplayName("Subcuenta (Sueldos y salarios)")>
          Public Property ReferenciaSubcuentaSueldosYSalarios As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaSubcuentaSueldosYSalarios As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaSubcuentaSueldosYSalarios"",""etiqueta"": ""Subcuenta (Sueldos y salarios)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c1578f25-c397-4882-a252-52b5fe65731c"",""titulo"": ""Base - Cuadro de cuentas"",""iconoid"": ""56e95fca-1432-4283-b4a2-1336964a155f"",""etiquetasingular"": ""Cuadro de cuenta"",""etiquetaplural"": ""Cuadro de cuentas"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""c1578f25-c397-4882-a252-52b5fe65731c"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Subcuenta (Sueldos y salarios)"",""descripcion"": """",""keyword"": ""ReferenciaSubcuentaSueldosYSalarios"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaSubcuentaSueldosYSalarios As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaSubcuentaSueldosYSalarios
          <DisplayName("Subcuenta (Adelantos de nómina)")>
          Public Property ReferenciaSubcuentaAdelantosDeNomina As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaSubcuentaAdelantosDeNomina As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaSubcuentaAdelantosDeNomina"",""etiqueta"": ""Subcuenta (Adelantos de nómina)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c1578f25-c397-4882-a252-52b5fe65731c"",""titulo"": ""Base - Cuadro de cuentas"",""iconoid"": ""56e95fca-1432-4283-b4a2-1336964a155f"",""etiquetasingular"": ""Cuadro de cuenta"",""etiquetaplural"": ""Cuadro de cuentas"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""c1578f25-c397-4882-a252-52b5fe65731c"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Subcuenta (Adelantos de nómina)"",""descripcion"": """",""keyword"": ""ReferenciaSubcuentaAdelantosDeNomina"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaSubcuentaAdelantosDeNomina As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaSubcuentaAdelantosDeNomina
          <DisplayName("Subcuenta (Suplidos)")>
          Public Property ReferenciaSubcuentaSuplidos As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaSubcuentaSuplidos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaSubcuentaSuplidos"",""etiqueta"": ""Subcuenta (Suplidos)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c1578f25-c397-4882-a252-52b5fe65731c"",""titulo"": ""Base - Cuadro de cuentas"",""iconoid"": ""56e95fca-1432-4283-b4a2-1336964a155f"",""etiquetasingular"": ""Cuadro de cuenta"",""etiquetaplural"": ""Cuadro de cuentas"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""c1578f25-c397-4882-a252-52b5fe65731c"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Subcuenta (Suplidos)"",""descripcion"": """",""keyword"": ""ReferenciaSubcuentaSuplidos"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaSubcuentaSuplidos As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaSubcuentaSuplidos
          <DisplayName("Es chofer")>
          Public Property EsChofer As Boolean
          Public Shared ___EsChofer As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EsChofer"",""etiqueta"": ""Es chofer"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Es chofer"",""descripcion"": """",""keyword"": ""EsChofer"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EsChofer As DinaNETCore.APID.DinaupAPI_CampoC = ___EsChofer
          <ReadOnlyAttribute(True)>
          <DisplayName("ID")>
          Public Property ID As Guid
          Public Shared ___ID As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": true,""eseliminado"": false,""keyword"": ""ID"",""etiqueta"": ""ID"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c6e071c7-776f-4300-aa55-c711fd1da916"",""titulo"": ""Empleados"",""iconoid"": ""1c8abf82-640c-4d18-b62c-89de310923dd"",""etiquetasingular"": ""Empleado"",""etiquetaplural"": ""Empleados"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""c6e071c7-776f-4300-aa55-c711fd1da916"",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""ID"",""descripcion"": """",""keyword"": ""ID"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ID As DinaNETCore.APID.DinaupAPI_CampoC = ___ID
          <DisplayName("Nombre completo")>
          Public Property TextoPrincipal As String
          Public Shared ___TextoPrincipal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TextoPrincipal"",""etiqueta"": ""Nombre completo"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Nombre completo"",""descripcion"": """",""keyword"": ""TextoPrincipal"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
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
          me.FechaDeNacimiento = _Datos.Leer_Date_Nulable("pr_2c619d")
          me.ReferenciaFoto = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_5f05940d"), _Datos.Leer_String("pr_5f05940d.nombre"))
          me.ReferenciaConfiguracion = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_74e2017wd"), _Datos.Leer_String("pr_74e2017wd.nombre"))
          me.EsAdministrador = _Datos.Leer_Boolean("pr_2086n")
          me.ReferenciaTurnoRealizandoObsoleto = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_1a0c0a5d3exb6wd"), _Datos.Leer_String("pr_1a0c0a5d3exb6wd.nombre"))
          me.ContraseñaObsoleto = _Datos.Leer_String("pr_14196n")
          me.ReferenciaUbicacionDeConexionObsoleto = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_1556n"), _Datos.Leer_String("pr_1556n.nombre"))
          me.IdentificadorAcceso = _Datos.Leer_String("pr_2bba690w12")
          me.ReferenciaRol = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_74e2013wd"), _Datos.Leer_String("pr_74e2013wd.nombre"))
          me.Genero = _Datos.Leer_EnumGeneroE("pr_7cb26aawd")
          me.SesionIniciadaObsoleto = _Datos.Leer_Boolean("pr_1a0c0d2c8cxc7wd")
          me.ContraseñaAccesoSistema = _Datos.Leer_String("pr_3ffd627x9ewc")
          me.FechaAlta_UTC = _Datos.Leer_DateTime_Nulable("pr_14c9f3ea9cg142wd")
          me.ColorIdentificativo = _Datos.Leer_String("pr_7cb2816wd")
          me.NIFObsoleto = _Datos.Leer_String("pr_2c5a37")
          me.ReferenciaPuestoDeTrabajo = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_441e166x11awc"), _Datos.Leer_String("pr_441e166x11awc.nombre"))
          me.EstadoCivil = _Datos.Leer_String("pr_5f0bfbe5")
          me.PuedeConectarAWeb = _Datos.Leer_Boolean("pr_3ffdcd7x257wc")
          me.Observaciones = _Datos.Leer_String("pr_2c6251")
          me.PuedeConectarAlSistema = _Datos.Leer_Boolean("pr_3ffd9c7x2fbwc")
          me.ReferenciaCargoEnEmpresa = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_158a16b75ax2d6wd"), _Datos.Leer_String("pr_158a16b75ax2d6wd.nombre"))
          me.ReferenciaAutorDelAlta = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_1463105af0x146wd"), _Datos.Leer_String("pr_1463105af0x146wd.nombre"))
          me.FinalizacionAutomaticaDeTurno = _Datos.Leer_Boolean("pr_1877f447c7x225wd")
          me.NombreDePila = _Datos.Leer_String("pr_17da7be832x2f2wd")
          me.UltimaInicioDeSesionObsoleto_UTC = _Datos.Leer_DateTime_Nulable("pr_1a0c164351x1a7wd")
          me.AutorDelAltaTieneAccesoWeb = _Datos.Leer_Boolean("pr_14631496d2x222wd")
          me.ReferenciaDestinador = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_1463105b91g1f2wd"), _Datos.Leer_String("pr_1463105b91g1f2wd.nombre"))
          me.HoraLocal = _Datos.Leer_Time_Nulable("pr_776ae62wd")
          me.ReferenciaUbicacionPrincipal = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_1464b42080x42wd"), _Datos.Leer_String("pr_1464b42080x42wd.nombre"))
          me.AusenteDesdeObsoleto_UTC = _Datos.Leer_DateTime_Nulable("pr_1a0c0b9973xbewd")
          me.PuedeVincularUnTerminal = _Datos.Leer_Boolean("pr_184973f89cxfcwd")
          me.PuedeConectarFueraDelHorario = _Datos.Leer_Boolean("pr_18466e3993x3d7wd")
          me.AusenteObsoleto = _Datos.Leer_Boolean("pr_1a0c0b37ecx2d3wd")
          me.Cliente = _Datos.Leer_Boolean("pr_400401177028")
          me.ImporteSaldoAcumulado = _Datos.Leer_Decimal("pr_2c6229")
          me.ReferenciaDatosFiscales = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_40040138793"), _Datos.Leer_String("pr_40040138793.nombre"))
          me.Becario = _Datos.Leer_Boolean("pr_50040147492")
          me.ImporteImportePorHoraExtraTurnosObsoleto = _Datos.Leer_Decimal("pr_6004017153109")
          me.ImporteDescuentoPorHoraAusenciasYRetrasosTurnosObsoleto = _Datos.Leer_Decimal("pr_6004017153108")
          me.MargenDeInicioDeTurno = _Datos.Leer_Integer("pr_60040210342")
          me.MargenDeFinDeTurno = _Datos.Leer_Integer("pr_60040210341")
          me.ImporteImporteHoraExtraTurnosExtrasObsoleto = _Datos.Leer_Decimal("pr_20040210881")
          me.ImporteImportePorHoraExtraDeFuerzaMayorTurnosExtrasObsoleto = _Datos.Leer_Decimal("pr_30040210801")
          me.ImporteImportePorHoraExtraDeFuerzaMayorTurnosObsoleto = _Datos.Leer_Decimal("pr_50040211301")
          me.AdaptarElImporteAPagarSegunElHorarioRealizadoTurnos = _Datos.Leer_Boolean("pr_60040211302")
          me.AdaptarElImporteAPagarSegunElHorarioRealizadoTurnosExtras = _Datos.Leer_Boolean("pr_20040210883")
          me.TiempoMinimoParaEvaluarTiempoTrabajadoDeMas = _Datos.Leer_Decimal("pr_30040211304")
          me.TiempoMinimoParaEvaluarTiempoTrabajadoDeMenos = _Datos.Leer_Decimal("pr_30040211305")
          me.RegistrarTurnosAutomaticamenteEnBaseAHorario = _Datos.Leer_Boolean("pr_20040212062")
          me.MotivoDeBloqueoAccesoWeb = _Datos.Leer_String("pr_10040218972")
          me.ReferenciaServidor = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_20040212332"), _Datos.Leer_String("pr_20040212332.nombre"))
          me.EsAdministradorDeLaEmpresa = _Datos.Leer_Boolean("pr_30040222581")
          me.EsUnaEntidadJuridica = _Datos.Leer_Boolean("pr_60040222581")
          me.SolicitarCambioDeContraseñaAlIniciarSesion = _Datos.Leer_Boolean("pr_30040419861")
          me.ReferenciaCorreoDeEmpresa = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_60040164241"), _Datos.Leer_String("pr_60040164241.nombre"))
          me.CorreoDondeEnviarLasNotificaciones = _Datos.Leer_String("pr_50040260013")
          me.FirmaDeCorreo = _Datos.Leer_String("pr_20040425825")
          me.PuedeAdministrarTodasLasEmpresas = _Datos.Leer_Boolean("pr_40040291891")
          me.PuedeConectarATodasLasUbicaciones = _Datos.Leer_Boolean("pr_20040480317")
          me.ReferenciaDepositoPreferente = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_40040114841"), _Datos.Leer_String("pr_40040114841.nombre"))
          me.DescuentoVentaPorciento = _Datos.Leer_Decimal("pr_654454e9")
          me.VenderConRecargoDeEquivalencia = _Datos.Leer_Boolean("pr_15n")
          me.ComprarConRecargoDeEquivalencia = _Datos.Leer_Boolean("pr_41b6976x20cwc")
          me.ImporteModificadorSaldoAjustes = _Datos.Leer_Decimal("pr_17e4513d83x360wd")
          me.DescuentoComprasPorciento = _Datos.Leer_Decimal("pr_41b69c1x2a9wc")
          me.ReferenciaTipoDeCliente = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_17f93d5e2exe8wd"), _Datos.Leer_String("pr_17f93d5e2exe8wd.nombre"))
          me.ReferenciaSubcuentaDeProveedor = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_60040136501"), _Datos.Leer_String("pr_60040136501.nombre"))
          me.ReferenciaSubcuentaDeCliente = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_10040133033"), _Datos.Leer_String("pr_10040133033.nombre"))
          me.ReferenciaSubcuentaPagoPendienteDeNominas = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_50040142261"), _Datos.Leer_String("pr_50040142261.nombre"))
          me.ReferenciaSubcuentaSueldosYSalarios = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_60040142383"), _Datos.Leer_String("pr_60040142383.nombre"))
          me.ReferenciaSubcuentaAdelantosDeNomina = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_30040146561"), _Datos.Leer_String("pr_30040146561.nombre"))
          me.ReferenciaSubcuentaSuplidos = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_40040256643"), _Datos.Leer_String("pr_40040256643.nombre"))
          me.EsChofer = _Datos.Leer_Boolean("pr_20010421782")
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
         R.add("pr_2c619d", me.FechaDeNacimiento.AdaptarMySQL_Date_Nulable())
         If Me.ReferenciaFoto IsNot nothing then
           R.add("pr_5f05940d",me.ReferenciaFoto.ID.STR())
         Else
           R.add("pr_5f05940d","")
         End if
         If Me.ReferenciaConfiguracion IsNot nothing then
           R.add("pr_74e2017wd",me.ReferenciaConfiguracion.ID.STR())
         Else
           R.add("pr_74e2017wd","")
         End if
         R.add("pr_2086n", me.EsAdministrador.AdaptarMySQL_Boolean())
         If Me.ReferenciaTurnoRealizandoObsoleto IsNot nothing then
           R.add("pr_1a0c0a5d3exb6wd",me.ReferenciaTurnoRealizandoObsoleto.ID.STR())
         Else
           R.add("pr_1a0c0a5d3exb6wd","")
         End if
         R.add("pr_14196n", me.ContraseñaObsoleto.AdaptarMySQL_String())
         If Me.ReferenciaUbicacionDeConexionObsoleto IsNot nothing then
           R.add("pr_1556n",me.ReferenciaUbicacionDeConexionObsoleto.ID.STR())
         Else
           R.add("pr_1556n","")
         End if
         R.add("pr_2bba690w12", me.IdentificadorAcceso.AdaptarMySQL_String())
         If Me.ReferenciaRol IsNot nothing then
           R.add("pr_74e2013wd",me.ReferenciaRol.ID.STR())
         Else
           R.add("pr_74e2013wd","")
         End if
         R.add("pr_7cb26aawd", me.Genero.AdaptarMySQL_EnumGeneroE())
         R.add("pr_1a0c0d2c8cxc7wd", me.SesionIniciadaObsoleto.AdaptarMySQL_Boolean())
         R.add("pr_3ffd627x9ewc", me.ContraseñaAccesoSistema.AdaptarMySQL_String())
         R.add("pr_14c9f3ea9cg142wd", me.FechaAlta_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_7cb2816wd", me.ColorIdentificativo.AdaptarMySQL_String())
         R.add("pr_2c5a37", me.NIFObsoleto.AdaptarMySQL_String())
         If Me.ReferenciaPuestoDeTrabajo IsNot nothing then
           R.add("pr_441e166x11awc",me.ReferenciaPuestoDeTrabajo.ID.STR())
         Else
           R.add("pr_441e166x11awc","")
         End if
         R.add("pr_5f0bfbe5", me.EstadoCivil.AdaptarMySQL_String())
         R.add("pr_3ffdcd7x257wc", me.PuedeConectarAWeb.AdaptarMySQL_Boolean())
         R.add("pr_2c6251", me.Observaciones.AdaptarMySQL_String())
         R.add("pr_3ffd9c7x2fbwc", me.PuedeConectarAlSistema.AdaptarMySQL_Boolean())
         If Me.ReferenciaCargoEnEmpresa IsNot nothing then
           R.add("pr_158a16b75ax2d6wd",me.ReferenciaCargoEnEmpresa.ID.STR())
         Else
           R.add("pr_158a16b75ax2d6wd","")
         End if
         If Me.ReferenciaAutorDelAlta IsNot nothing then
           R.add("pr_1463105af0x146wd",me.ReferenciaAutorDelAlta.ID.STR())
         Else
           R.add("pr_1463105af0x146wd","")
         End if
         R.add("pr_1877f447c7x225wd", me.FinalizacionAutomaticaDeTurno.AdaptarMySQL_Boolean())
         R.add("pr_17da7be832x2f2wd", me.NombreDePila.AdaptarMySQL_String())
         R.add("pr_1a0c164351x1a7wd", me.UltimaInicioDeSesionObsoleto_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_14631496d2x222wd", me.AutorDelAltaTieneAccesoWeb.AdaptarMySQL_Boolean())
         If Me.ReferenciaDestinador IsNot nothing then
           R.add("pr_1463105b91g1f2wd",me.ReferenciaDestinador.ID.STR())
         Else
           R.add("pr_1463105b91g1f2wd","")
         End if
         R.add("pr_776ae62wd", me.HoraLocal.AdaptarMySQL_Time_Nulable())
         If Me.ReferenciaUbicacionPrincipal IsNot nothing then
           R.add("pr_1464b42080x42wd",me.ReferenciaUbicacionPrincipal.ID.STR())
         Else
           R.add("pr_1464b42080x42wd","")
         End if
         R.add("pr_1a0c0b9973xbewd", me.AusenteDesdeObsoleto_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_184973f89cxfcwd", me.PuedeVincularUnTerminal.AdaptarMySQL_Boolean())
         R.add("pr_18466e3993x3d7wd", me.PuedeConectarFueraDelHorario.AdaptarMySQL_Boolean())
         R.add("pr_1a0c0b37ecx2d3wd", me.AusenteObsoleto.AdaptarMySQL_Boolean())
         R.add("pr_400401177028", me.Cliente.AdaptarMySQL_Boolean())
         R.add("pr_2c6229", me.ImporteSaldoAcumulado.AdaptarMySQL_Decimal())
         If Me.ReferenciaDatosFiscales IsNot nothing then
           R.add("pr_40040138793",me.ReferenciaDatosFiscales.ID.STR())
         Else
           R.add("pr_40040138793","")
         End if
         R.add("pr_50040147492", me.Becario.AdaptarMySQL_Boolean())
         R.add("pr_6004017153109", me.ImporteImportePorHoraExtraTurnosObsoleto.AdaptarMySQL_Decimal())
         R.add("pr_6004017153108", me.ImporteDescuentoPorHoraAusenciasYRetrasosTurnosObsoleto.AdaptarMySQL_Decimal())
         R.add("pr_60040210342", me.MargenDeInicioDeTurno.AdaptarMySQL_Integer())
         R.add("pr_60040210341", me.MargenDeFinDeTurno.AdaptarMySQL_Integer())
         R.add("pr_20040210881", me.ImporteImporteHoraExtraTurnosExtrasObsoleto.AdaptarMySQL_Decimal())
         R.add("pr_30040210801", me.ImporteImportePorHoraExtraDeFuerzaMayorTurnosExtrasObsoleto.AdaptarMySQL_Decimal())
         R.add("pr_50040211301", me.ImporteImportePorHoraExtraDeFuerzaMayorTurnosObsoleto.AdaptarMySQL_Decimal())
         R.add("pr_60040211302", me.AdaptarElImporteAPagarSegunElHorarioRealizadoTurnos.AdaptarMySQL_Boolean())
         R.add("pr_20040210883", me.AdaptarElImporteAPagarSegunElHorarioRealizadoTurnosExtras.AdaptarMySQL_Boolean())
         R.add("pr_30040211304", me.TiempoMinimoParaEvaluarTiempoTrabajadoDeMas.AdaptarMySQL_Decimal())
         R.add("pr_30040211305", me.TiempoMinimoParaEvaluarTiempoTrabajadoDeMenos.AdaptarMySQL_Decimal())
         R.add("pr_20040212062", me.RegistrarTurnosAutomaticamenteEnBaseAHorario.AdaptarMySQL_Boolean())
         R.add("pr_10040218972", me.MotivoDeBloqueoAccesoWeb.AdaptarMySQL_String())
         If Me.ReferenciaServidor IsNot nothing then
           R.add("pr_20040212332",me.ReferenciaServidor.ID.STR())
         Else
           R.add("pr_20040212332","")
         End if
         R.add("pr_30040222581", me.EsAdministradorDeLaEmpresa.AdaptarMySQL_Boolean())
         R.add("pr_60040222581", me.EsUnaEntidadJuridica.AdaptarMySQL_Boolean())
         R.add("pr_30040419861", me.SolicitarCambioDeContraseñaAlIniciarSesion.AdaptarMySQL_Boolean())
         If Me.ReferenciaCorreoDeEmpresa IsNot nothing then
           R.add("pr_60040164241",me.ReferenciaCorreoDeEmpresa.ID.STR())
         Else
           R.add("pr_60040164241","")
         End if
         R.add("pr_50040260013", me.CorreoDondeEnviarLasNotificaciones.AdaptarMySQL_String())
         R.add("pr_20040425825", me.FirmaDeCorreo.AdaptarMySQL_String())
         R.add("pr_40040291891", me.PuedeAdministrarTodasLasEmpresas.AdaptarMySQL_Boolean())
         R.add("pr_20040480317", me.PuedeConectarATodasLasUbicaciones.AdaptarMySQL_Boolean())
         If Me.ReferenciaDepositoPreferente IsNot nothing then
           R.add("pr_40040114841",me.ReferenciaDepositoPreferente.ID.STR())
         Else
           R.add("pr_40040114841","")
         End if
         R.add("pr_654454e9", me.DescuentoVentaPorciento.AdaptarMySQL_Decimal())
         R.add("pr_15n", me.VenderConRecargoDeEquivalencia.AdaptarMySQL_Boolean())
         R.add("pr_41b6976x20cwc", me.ComprarConRecargoDeEquivalencia.AdaptarMySQL_Boolean())
         R.add("pr_17e4513d83x360wd", me.ImporteModificadorSaldoAjustes.AdaptarMySQL_Decimal())
         R.add("pr_41b69c1x2a9wc", me.DescuentoComprasPorciento.AdaptarMySQL_Decimal())
         If Me.ReferenciaTipoDeCliente IsNot nothing then
           R.add("pr_17f93d5e2exe8wd",me.ReferenciaTipoDeCliente.ID.STR())
         Else
           R.add("pr_17f93d5e2exe8wd","")
         End if
         If Me.ReferenciaSubcuentaDeProveedor IsNot nothing then
           R.add("pr_60040136501",me.ReferenciaSubcuentaDeProveedor.ID.STR())
         Else
           R.add("pr_60040136501","")
         End if
         If Me.ReferenciaSubcuentaDeCliente IsNot nothing then
           R.add("pr_10040133033",me.ReferenciaSubcuentaDeCliente.ID.STR())
         Else
           R.add("pr_10040133033","")
         End if
         If Me.ReferenciaSubcuentaPagoPendienteDeNominas IsNot nothing then
           R.add("pr_50040142261",me.ReferenciaSubcuentaPagoPendienteDeNominas.ID.STR())
         Else
           R.add("pr_50040142261","")
         End if
         If Me.ReferenciaSubcuentaSueldosYSalarios IsNot nothing then
           R.add("pr_60040142383",me.ReferenciaSubcuentaSueldosYSalarios.ID.STR())
         Else
           R.add("pr_60040142383","")
         End if
         If Me.ReferenciaSubcuentaAdelantosDeNomina IsNot nothing then
           R.add("pr_30040146561",me.ReferenciaSubcuentaAdelantosDeNomina.ID.STR())
         Else
           R.add("pr_30040146561","")
         End if
         If Me.ReferenciaSubcuentaSuplidos IsNot nothing then
           R.add("pr_40040256643",me.ReferenciaSubcuentaSuplidos.ID.STR())
         Else
           R.add("pr_40040256643","")
         End if
         R.add("pr_20010421782", me.EsChofer.AdaptarMySQL_Boolean())
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
      Public Class Empleados_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
          Public property FechaDeNacimiento As Date
            get
                return me.GetValue_Date("pr_2c619d")
            End Get
            Set(value As Date)
                me.SetValue_Date("pr_2c619d", value)
            End Set
          End Property
          Public property ReferenciaFoto As Guid
            get
                return me.GetValue_Guid("pr_5f05940d")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_5f05940d", value)
            End Set
          End Property
          Public property ReferenciaConfiguracion As Guid
            get
                return me.GetValue_Guid("pr_74e2017wd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_74e2017wd", value)
            End Set
          End Property
        Public ReadOnly property EsAdministrador As Boolean
            get
                return me.GetValue_Boolean("pr_2086n")
            End Get   
        End Property
        Public ReadOnly property ReferenciaTurnoRealizandoObsoleto As Guid
            get
                return me.GetValue_Guid("pr_1a0c0a5d3exb6wd")
            End Get   
        End Property
          Public property ContraseñaObsoleto As String
            get
                return me.GetValue_String("pr_14196n")
            End Get
            Set(value As String)
                me.SetValue_String("pr_14196n", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaUbicacionDeConexionObsoleto As Guid
            get
                return me.GetValue_Guid("pr_1556n")
            End Get   
        End Property
          Public property IdentificadorAcceso As String
            get
                return me.GetValue_String("pr_2bba690w12")
            End Get
            Set(value As String)
                me.SetValue_String("pr_2bba690w12", value)
            End Set
          End Property
          Public property ReferenciaRol As Guid
            get
                return me.GetValue_Guid("pr_74e2013wd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_74e2013wd", value)
            End Set
          End Property
          Public property Genero__Int as Integer
            get
                return me.GetValue_Int("pr_7cb26aawd")
            End Get
            Set(value as Integer)
                me.SetValue_Int("pr_7cb26aawd", value)
            End Set
          End Property
          Public property Genero As EnumGeneroE
            get
                return me.GetValue_Int("pr_7cb26aawd")
            End Get
            Set(value As EnumGeneroE)
                me.SetValue_Int("pr_7cb26aawd", value)
            End Set
          End Property
        Public ReadOnly property SesionIniciadaObsoleto As Boolean
            get
                return me.GetValue_Boolean("pr_1a0c0d2c8cxc7wd")
            End Get   
        End Property
          Public property ContraseñaAccesoSistema As String
            get
                return me.GetValue_String("pr_3ffd627x9ewc")
            End Get
            Set(value As String)
                me.SetValue_String("pr_3ffd627x9ewc", value)
            End Set
          End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_14c9f3ea9cg142wd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_14c9f3ea9cg142wd", value)
            End Set
          End Property
          Public property ColorIdentificativo As String
            get
                return me.GetValue_String("pr_7cb2816wd")
            End Get
            Set(value As String)
                me.SetValue_String("pr_7cb2816wd", value)
            End Set
          End Property
          Public property NIFObsoleto As String
            get
                return me.GetValue_String("pr_2c5a37")
            End Get
            Set(value As String)
                me.SetValue_String("pr_2c5a37", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaPuestoDeTrabajo As Guid
            get
                return me.GetValue_Guid("pr_441e166x11awc")
            End Get   
        End Property
          Public property EstadoCivil As String
            get
                return me.GetValue_String("pr_5f0bfbe5")
            End Get
            Set(value As String)
                me.SetValue_String("pr_5f0bfbe5", value)
            End Set
          End Property
          Public property PuedeConectarAWeb As Boolean
            get
                return me.GetValue_Boolean("pr_3ffdcd7x257wc")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_3ffdcd7x257wc", value)
            End Set
          End Property
          Public property Observaciones As String
            get
                return me.GetValue_String("pr_2c6251")
            End Get
            Set(value As String)
                me.SetValue_String("pr_2c6251", value)
            End Set
          End Property
          Public property PuedeConectarAlSistema As Boolean
            get
                return me.GetValue_Boolean("pr_3ffd9c7x2fbwc")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_3ffd9c7x2fbwc", value)
            End Set
          End Property
          Public property ReferenciaCargoEnEmpresa As Guid
            get
                return me.GetValue_Guid("pr_158a16b75ax2d6wd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_158a16b75ax2d6wd", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_1463105af0x146wd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_1463105af0x146wd", value)
            End Set
          End Property
          Public property FinalizacionAutomaticaDeTurno As Boolean
            get
                return me.GetValue_Boolean("pr_1877f447c7x225wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_1877f447c7x225wd", value)
            End Set
          End Property
          Public property NombreDePila As String
            get
                return me.GetValue_String("pr_17da7be832x2f2wd")
            End Get
            Set(value As String)
                me.SetValue_String("pr_17da7be832x2f2wd", value)
            End Set
          End Property
        Public ReadOnly property UltimaInicioDeSesionObsoleto_UTC As Date
            get
                return me.GetValue_DateTime("pr_1a0c164351x1a7wd")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_14631496d2x222wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_14631496d2x222wd", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_1463105b91g1f2wd")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As DateTime
            get
                return me.GetValue_DateTime("pr_776ae62wd")
            End Get   
        End Property
          Public property ReferenciaUbicacionPrincipal As Guid
            get
                return me.GetValue_Guid("pr_1464b42080x42wd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_1464b42080x42wd", value)
            End Set
          End Property
        Public ReadOnly property AusenteDesdeObsoleto_UTC As Date
            get
                return me.GetValue_DateTime("pr_1a0c0b9973xbewd")
            End Get   
        End Property
          Public property PuedeVincularUnTerminal As Boolean
            get
                return me.GetValue_Boolean("pr_184973f89cxfcwd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_184973f89cxfcwd", value)
            End Set
          End Property
          Public property PuedeConectarFueraDelHorario As Boolean
            get
                return me.GetValue_Boolean("pr_18466e3993x3d7wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_18466e3993x3d7wd", value)
            End Set
          End Property
        Public ReadOnly property AusenteObsoleto As Boolean
            get
                return me.GetValue_Boolean("pr_1a0c0b37ecx2d3wd")
            End Get   
        End Property
          Public property Cliente As Boolean
            get
                return me.GetValue_Boolean("pr_400401177028")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_400401177028", value)
            End Set
          End Property
        Public ReadOnly property ImporteSaldoAcumulado As Decimal
            get
                return me.GetValue_Decimal("pr_2c6229")
            End Get   
        End Property
          Public property ReferenciaDatosFiscales As Guid
            get
                return me.GetValue_Guid("pr_40040138793")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_40040138793", value)
            End Set
          End Property
          Public property Becario As Boolean
            get
                return me.GetValue_Boolean("pr_50040147492")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_50040147492", value)
            End Set
          End Property
          Public property ImporteImportePorHoraExtraTurnosObsoleto As Decimal
            get
                return me.GetValue_Decimal("pr_6004017153109")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_6004017153109", value)
            End Set
          End Property
          Public property ImporteDescuentoPorHoraAusenciasYRetrasosTurnosObsoleto As Decimal
            get
                return me.GetValue_Decimal("pr_6004017153108")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_6004017153108", value)
            End Set
          End Property
          Public property MargenDeInicioDeTurno As Integer
            get
                return me.GetValue_Int("pr_60040210342")
            End Get
            Set(value As Integer)
                me.SetValue_Int("pr_60040210342", value)
            End Set
          End Property
          Public property MargenDeFinDeTurno As Integer
            get
                return me.GetValue_Int("pr_60040210341")
            End Get
            Set(value As Integer)
                me.SetValue_Int("pr_60040210341", value)
            End Set
          End Property
          Public property ImporteImporteHoraExtraTurnosExtrasObsoleto As Decimal
            get
                return me.GetValue_Decimal("pr_20040210881")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_20040210881", value)
            End Set
          End Property
          Public property ImporteImportePorHoraExtraDeFuerzaMayorTurnosExtrasObsoleto As Decimal
            get
                return me.GetValue_Decimal("pr_30040210801")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_30040210801", value)
            End Set
          End Property
          Public property ImporteImportePorHoraExtraDeFuerzaMayorTurnosObsoleto As Decimal
            get
                return me.GetValue_Decimal("pr_50040211301")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_50040211301", value)
            End Set
          End Property
          Public property AdaptarElImporteAPagarSegunElHorarioRealizadoTurnos As Boolean
            get
                return me.GetValue_Boolean("pr_60040211302")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_60040211302", value)
            End Set
          End Property
          Public property AdaptarElImporteAPagarSegunElHorarioRealizadoTurnosExtras As Boolean
            get
                return me.GetValue_Boolean("pr_20040210883")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_20040210883", value)
            End Set
          End Property
          Public property TiempoMinimoParaEvaluarTiempoTrabajadoDeMas As Decimal
            get
                return me.GetValue_Decimal("pr_30040211304")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_30040211304", value)
            End Set
          End Property
          Public property TiempoMinimoParaEvaluarTiempoTrabajadoDeMenos As Decimal
            get
                return me.GetValue_Decimal("pr_30040211305")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_30040211305", value)
            End Set
          End Property
        Public ReadOnly property RegistrarTurnosAutomaticamenteEnBaseAHorario As Boolean
            get
                return me.GetValue_Boolean("pr_20040212062")
            End Get   
        End Property
          Public property MotivoDeBloqueoAccesoWeb As String
            get
                return me.GetValue_String("pr_10040218972")
            End Get
            Set(value As String)
                me.SetValue_String("pr_10040218972", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaServidor As Guid
            get
                return me.GetValue_Guid("pr_20040212332")
            End Get   
        End Property
          Public property EsAdministradorDeLaEmpresa As Boolean
            get
                return me.GetValue_Boolean("pr_30040222581")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_30040222581", value)
            End Set
          End Property
          Public property EsUnaEntidadJuridica As Boolean
            get
                return me.GetValue_Boolean("pr_60040222581")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_60040222581", value)
            End Set
          End Property
          Public property SolicitarCambioDeContraseñaAlIniciarSesion As Boolean
            get
                return me.GetValue_Boolean("pr_30040419861")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_30040419861", value)
            End Set
          End Property
          Public property ReferenciaCorreoDeEmpresa As Guid
            get
                return me.GetValue_Guid("pr_60040164241")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_60040164241", value)
            End Set
          End Property
          Public property CorreoDondeEnviarLasNotificaciones As String
            get
                return me.GetValue_String("pr_50040260013")
            End Get
            Set(value As String)
                me.SetValue_String("pr_50040260013", value)
            End Set
          End Property
          Public property FirmaDeCorreo As String
            get
                return me.GetValue_String("pr_20040425825")
            End Get
            Set(value As String)
                me.SetValue_String("pr_20040425825", value)
            End Set
          End Property
          Public property PuedeAdministrarTodasLasEmpresas As Boolean
            get
                return me.GetValue_Boolean("pr_40040291891")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_40040291891", value)
            End Set
          End Property
          Public property PuedeConectarATodasLasUbicaciones As Boolean
            get
                return me.GetValue_Boolean("pr_20040480317")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_20040480317", value)
            End Set
          End Property
          Public property ReferenciaDepositoPreferente As Guid
            get
                return me.GetValue_Guid("pr_40040114841")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_40040114841", value)
            End Set
          End Property
          Public property DescuentoVentaPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_654454e9")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_654454e9", value)
            End Set
          End Property
          Public property VenderConRecargoDeEquivalencia As Boolean
            get
                return me.GetValue_Boolean("pr_15n")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_15n", value)
            End Set
          End Property
          Public property ComprarConRecargoDeEquivalencia As Boolean
            get
                return me.GetValue_Boolean("pr_41b6976x20cwc")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_41b6976x20cwc", value)
            End Set
          End Property
        Public ReadOnly property ImporteModificadorSaldoAjustes As Decimal
            get
                return me.GetValue_Decimal("pr_17e4513d83x360wd")
            End Get   
        End Property
          Public property DescuentoComprasPorciento As Decimal
            get
                return me.GetValue_Decimal("pr_41b69c1x2a9wc")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_41b69c1x2a9wc", value)
            End Set
          End Property
          Public property ReferenciaTipoDeCliente As Guid
            get
                return me.GetValue_Guid("pr_17f93d5e2exe8wd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_17f93d5e2exe8wd", value)
            End Set
          End Property
          Public property ReferenciaSubcuentaDeProveedor As Guid
            get
                return me.GetValue_Guid("pr_60040136501")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_60040136501", value)
            End Set
          End Property
          Public property ReferenciaSubcuentaDeCliente As Guid
            get
                return me.GetValue_Guid("pr_10040133033")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_10040133033", value)
            End Set
          End Property
          Public property ReferenciaSubcuentaPagoPendienteDeNominas As Guid
            get
                return me.GetValue_Guid("pr_50040142261")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_50040142261", value)
            End Set
          End Property
          Public property ReferenciaSubcuentaSueldosYSalarios As Guid
            get
                return me.GetValue_Guid("pr_60040142383")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_60040142383", value)
            End Set
          End Property
          Public property ReferenciaSubcuentaAdelantosDeNomina As Guid
            get
                return me.GetValue_Guid("pr_30040146561")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_30040146561", value)
            End Set
          End Property
          Public property ReferenciaSubcuentaSuplidos As Guid
            get
                return me.GetValue_Guid("pr_40040256643")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_40040256643", value)
            End Set
          End Property
          Public property EsChofer As Boolean
            get
                return me.GetValue_Boolean("pr_20010421782")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_20010421782", value)
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
