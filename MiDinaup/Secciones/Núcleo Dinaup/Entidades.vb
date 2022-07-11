   Imports System.ComponentModel
   Imports DinaNETCore
   Imports DinaNETCore.APID
Partial Public Class SeccionesD
  Public Class EntidadesD
      Public Shared _SeccionID As String = "eec5029a-440d-4505-8560-b88b3ff5917d"
      Public Shared _SeccionIDGUID As New Guid("eec5029a-440d-4505-8560-b88b3ff5917d")
      Public Shared Async Function ConsultarDatos_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, ParamArray Valor As String()) As Task(Of List(Of EntidadesC )) 
          Dim R As New List(Of EntidadesC )  
          Dim d = Await DinaupSesion.ConexionServidor.Funcion_Datos_Recibir_Async(DinaupSesion, EntidadesES._SeccionID, False, Campo, Valor) 
          If d.Datos.TieneDatos Then 
              For Each Actual In d.Datos 
                  Dim Valores_Listador = Actual.Value.Item1
                  Dim Obj_Listador As New EntidadesC 
                  Obj_Listador.CargarDatos(Valores_Listador) 
                  R.Add(Obj_Listador) 
              Next 
          End If 
          Return R 
      End Function 
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As EntidadesC, Optional CampoWhere$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Return Await DatosGuardar_Async(DinaupSesion, New List(Of EntidadesC)({DAtos}), CampoWhere )
      End Function
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As List(Of EntidadesC), Optional CampoWhere$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Dim Importar As New List(Of DinaupAPI_ImportacionProcesableC)
          For Each Actual In DAtos 
              Dim RegistroActual = New DinaupAPI_ImportacionProcesableC() 
               RegistroActual.dinaup_listador_datos = Actual.ToDic 
               Importar.Add(RegistroActual)  
          Next 
          Return Await DinaupSesion.ConexionServidor.Funcion_Importar_Ejecutar_Async(DinaupSesion, EntidadesES._SeccionID, Importar, CampoWhere, "") 
      End Function
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As Entidades_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, EntidadesES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New Entidades_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As Entidades_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, EntidadesES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New Entidades_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class EntidadesES
          Public shared _SeccionID as Guid = New Guid("eec5029a-440d-4505-8560-b88b3ff5917d")
          Public shared _Tabla$ = "tpr_2c597b"
      Public Shared AmbitoDeActividad$ = "pr_2222"
      Public Shared NDeSocio$ = "pr_2216"
      Public Shared FechaAlta_UTC$ = "pr_14c9f3ea9cg142wd"
      Public Shared FechaDeNacimiento$ = "pr_2c619d"
      Public Shared PaginaWeb$ = "pr_2225"
      Public Shared ReferenciaFoto$ = "pr_5f05940d"
      Public Shared ReferenciaCodigo$ = "pr_2c5e9f"
      Public Shared VIP$ = "pr_6122d4fd"
      Public Shared EstadoCivil$ = "pr_5f0bfbe5"
      Public Shared Profesion$ = "pr_2c60b5"
      Public Shared ReferenciaComercialEncargado$ = "pr_14109n"
      Public Shared NIFObsoleto$ = "pr_2c5a37"
      Public Shared ReferenciaAutorDelAlta$ = "pr_1463105af0x146wd"
      Public Shared Observaciones$ = "pr_2c6251"
      Public Shared ReferenciaDestinador$ = "pr_1463105b91g1f2wd"
      Public Shared Particular$ = "pr_20040105072"
      Public Shared HoraLocal$ = "pr_776ae62wd"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_1464b42080x42wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_14631496d2x222wd"
      Public Shared ComercialEncargadoTieneAccesoWeb$ = "pr_146310d66bg40wd"
      Public Shared NombreFiscalObsoleto$ = "pr_50040108211"
      Public Shared Contacto$ = "pr_20040105071"
      Public Shared Proveedor$ = "pr_20040105073"
      Public Shared Cliente$ = "pr_400401177028"
      Public Shared ImporteSaldoAcumulado$ = "pr_2c6229"
      Public Shared ReferenciaDatosFiscales$ = "pr_40040138793"
      Public Shared Fabricante$ = "pr_60040146992"
      Public Shared Autor$ = "pr_60040146993"
      Public Shared NumeroDeRegistroDeComercioNRC$ = "pr_30040181602"
      Public Shared EsUnaEntidadJuridica$ = "pr_60040222581"
      Public Shared ReferenciaRepresentanteLegal$ = "pr_20040242777"
      Public Shared RepresentanteLegalTieneAccesoWeb$ = "pr_20040242778"
      Public Shared NCliente$ = "pr_10040325042"
      Public Shared NProveedor$ = "pr_10040325041"
      Public Shared EmpresaPrincipalEnLaQueTrabajaTieneAccesoWeb$ = "pr_20040414082"
      Public Shared ReferenciaEmpresaPrincipalEnLaQueTrabaja$ = "pr_20040414081"
      Public Shared PuedeConectarAWeb$ = "pr_3ffdcd7x257wc"
      Public Shared ContraseñaObsoleto$ = "pr_14196n"
      Public Shared IdentificadorAcceso$ = "pr_2bba690w12"
      Public Shared ContraseñaAccesoSistema$ = "pr_3ffd627x9ewc"
      Public Shared MotivoDeBloqueoAccesoWeb$ = "pr_10040218972"
      Public Shared SolicitarCambioDeContraseñaAlIniciarSesion$ = "pr_30040419861"
      Public Shared ReferenciaRol$ = "pr_74e2013wd"
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
      Public Class EntidadesC
      Inherits Base_DatoC
          <DisplayName("Ámbito de Actividad")>
          Public Property AmbitoDeActividad As String
          Public Shared ___AmbitoDeActividad As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AmbitoDeActividad"",""etiqueta"": ""Ámbito de Actividad"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Ámbito de Actividad"",""descripcion"": """",""keyword"": ""AmbitoDeActividad"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AmbitoDeActividad As DinaNETCore.APID.DinaupAPI_CampoC = ___AmbitoDeActividad
          <DisplayName("Nº de Socio")>
          Public Property NDeSocio As Integer
          Public Shared ___NDeSocio As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""NDeSocio"",""etiqueta"": ""Nº de Socio"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": false,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Nº de Socio"",""descripcion"": """",""keyword"": ""NDeSocio"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __NDeSocio As DinaNETCore.APID.DinaupAPI_CampoC = ___NDeSocio
          <DisplayName("Fecha Alta del registro")>
          Public Property FechaAlta_UTC As Date?
          Public Shared ___FechaAlta_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaAlta_UTC"",""etiqueta"": ""Fecha Alta del registro"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Alta del registro"",""descripcion"": """",""keyword"": ""FechaAlta_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaAlta_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaAlta_UTC
          <DisplayName("Fecha de nacimiento")>
          Public Property FechaDeNacimiento As Date?
          Public Shared ___FechaDeNacimiento As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaDeNacimiento"",""etiqueta"": ""Fecha de nacimiento"",""oculta"": false,""formato"": 7,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha de nacimiento"",""descripcion"": """",""keyword"": ""FechaDeNacimiento"",""formato"": 7,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaDeNacimiento As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaDeNacimiento
          <DisplayName("Página Web")>
          Public Property PaginaWeb As String
          Public Shared ___PaginaWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""PaginaWeb"",""etiqueta"": ""Página Web"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 1,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Página Web"",""descripcion"": """",""keyword"": ""PaginaWeb"",""formato"": 5,""rol"": 1,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __PaginaWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___PaginaWeb
          <DisplayName("Foto")>
          Public Property ReferenciaFoto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaFoto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaFoto"",""etiqueta"": ""Foto"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""imagenes"",""rol"": 17,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Foto"",""descripcion"": """",""keyword"": ""ReferenciaFoto"",""formato"": 9,""rol"": 17,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaFoto As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaFoto
          <DisplayName("Referencia / Código")>
          Public Property ReferenciaCodigo As String
          Public Shared ___ReferenciaCodigo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaCodigo"",""etiqueta"": ""Referencia / Código"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Referencia / Código"",""descripcion"": """",""keyword"": ""ReferenciaCodigo"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaCodigo As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaCodigo
          <DisplayName("V.I.P.")>
          Public Property VIP As Boolean
          Public Shared ___VIP As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""VIP"",""etiqueta"": ""V.I.P."",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""V.I.P."",""descripcion"": """",""keyword"": ""VIP"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __VIP As DinaNETCore.APID.DinaupAPI_CampoC = ___VIP
          <DisplayName("Estado Civil")>
          Public Property EstadoCivil As String
          Public Shared ___EstadoCivil As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EstadoCivil"",""etiqueta"": ""Estado Civil"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Estado Civil"",""descripcion"": """",""keyword"": ""EstadoCivil"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EstadoCivil As DinaNETCore.APID.DinaupAPI_CampoC = ___EstadoCivil
          <DisplayName("Profesión")>
          Public Property Profesion As String
          Public Shared ___Profesion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Profesion"",""etiqueta"": ""Profesión"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Profesión"",""descripcion"": """",""keyword"": ""Profesion"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Profesion As DinaNETCore.APID.DinaupAPI_CampoC = ___Profesion
          <DisplayName("Comercial Encargado")>
          Public Property ReferenciaComercialEncargado As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaComercialEncargado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaComercialEncargado"",""etiqueta"": ""Comercial Encargado"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c6e071c7-776f-4300-aa55-c711fd1da916"",""titulo"": ""Empleados"",""iconoid"": ""1c8abf82-640c-4d18-b62c-89de310923dd"",""etiquetasingular"": ""Empleado"",""etiquetaplural"": ""Empleados"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""c6e071c7-776f-4300-aa55-c711fd1da916"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Comercial Encargado"",""descripcion"": """",""keyword"": ""ReferenciaComercialEncargado"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaComercialEncargado As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaComercialEncargado
          <DisplayName("NIF (Obsoleto)")>
          Public Property NIFObsoleto As String
          Public Shared ___NIFObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""NIFObsoleto"",""etiqueta"": ""NIF (Obsoleto)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 79,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""NIF (Obsoleto)"",""descripcion"": """",""keyword"": ""NIFObsoleto"",""formato"": 5,""rol"": 79,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __NIFObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___NIFObsoleto
          <DisplayName("Autor del alta")>
          Public Property ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaAutorDelAlta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaAutorDelAlta"",""etiqueta"": ""Autor del alta"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta"",""descripcion"": """",""keyword"": ""ReferenciaAutorDelAlta"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaAutorDelAlta
          <DisplayName("Observaciones")>
          Public Property Observaciones As String
          Public Shared ___Observaciones As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Observaciones"",""etiqueta"": ""Observaciones"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 9,""decimales"": ""0"",""multilinea"": true,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Observaciones"",""descripcion"": """",""keyword"": ""Observaciones"",""formato"": 5,""rol"": 9,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Observaciones As DinaNETCore.APID.DinaupAPI_CampoC = ___Observaciones
          <DisplayName("Destinador")>
          Public Property ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaDestinador As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaDestinador"",""etiqueta"": ""Destinador"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""relacionesindirectas"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Destinador"",""descripcion"": """",""keyword"": ""ReferenciaDestinador"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaDestinador
          <DisplayName("Particular")>
          Public Property Particular As Boolean
          Public Shared ___Particular As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Particular"",""etiqueta"": ""Particular"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Particular"",""descripcion"": """",""keyword"": ""Particular"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Particular As DinaNETCore.APID.DinaupAPI_CampoC = ___Particular
          <DisplayName("Hora local")>
          Public Property HoraLocal As DateTime?
          Public Shared ___HoraLocal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""HoraLocal"",""etiqueta"": ""Hora local"",""oculta"": false,""formato"": 8,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Hora local"",""descripcion"": """",""keyword"": ""HoraLocal"",""formato"": 8,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __HoraLocal As DinaNETCore.APID.DinaupAPI_CampoC = ___HoraLocal
          <Description("Ubicación en la que se administra principalmente este registro.")>
          <DisplayName("Ubicación Principal")>
          Public Property ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaUbicacionPrincipal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaUbicacionPrincipal"",""etiqueta"": ""Ubicación Principal"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""b9adbfbf-a81a-45fb-861c-90502902c982"",""titulo"": ""Ubicaciones"",""iconoid"": ""b985b58f-7275-46b8-9b66-2c54346b0185"",""etiquetasingular"": ""Ubicación"",""etiquetaplural"": ""Ubicaciones"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""b9adbfbf-a81a-45fb-861c-90502902c982"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Ubicación Principal"",""descripcion"": """",""keyword"": ""ReferenciaUbicacionPrincipal"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaUbicacionPrincipal
          <DisplayName("Autor del alta Tiene Acceso web")>
          Public Property AutorDelAltaTieneAccesoWeb As Boolean
          Public Shared ___AutorDelAltaTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AutorDelAltaTieneAccesoWeb"",""etiqueta"": ""Autor del alta Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta Tiene Acceso web"",""descripcion"": """",""keyword"": ""AutorDelAltaTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AutorDelAltaTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___AutorDelAltaTieneAccesoWeb
          <DisplayName("Comercial Encargado Tiene Acceso web")>
          Public Property ComercialEncargadoTieneAccesoWeb As Boolean
          Public Shared ___ComercialEncargadoTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ComercialEncargadoTieneAccesoWeb"",""etiqueta"": ""Comercial Encargado Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Comercial Encargado Tiene Acceso web"",""descripcion"": """",""keyword"": ""ComercialEncargadoTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ComercialEncargadoTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___ComercialEncargadoTieneAccesoWeb
          <DisplayName("Nombre fiscal (Obsoleto)")>
          Public Property NombreFiscalObsoleto As String
          Public Shared ___NombreFiscalObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""NombreFiscalObsoleto"",""etiqueta"": ""Nombre fiscal (Obsoleto)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Nombre fiscal (Obsoleto)"",""descripcion"": """",""keyword"": ""NombreFiscalObsoleto"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __NombreFiscalObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___NombreFiscalObsoleto
          <DisplayName("Contacto")>
          Public Property Contacto As Boolean
          Public Shared ___Contacto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Contacto"",""etiqueta"": ""Contacto"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Contacto"",""descripcion"": """",""keyword"": ""Contacto"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Contacto As DinaNETCore.APID.DinaupAPI_CampoC = ___Contacto
          <DisplayName("Proveedor")>
          Public Property Proveedor As Boolean
          Public Shared ___Proveedor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Proveedor"",""etiqueta"": ""Proveedor"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Proveedor"",""descripcion"": """",""keyword"": ""Proveedor"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Proveedor As DinaNETCore.APID.DinaupAPI_CampoC = ___Proveedor
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
          <DisplayName("Fabricante")>
          Public Property Fabricante As Boolean
          Public Shared ___Fabricante As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Fabricante"",""etiqueta"": ""Fabricante"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fabricante"",""descripcion"": """",""keyword"": ""Fabricante"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Fabricante As DinaNETCore.APID.DinaupAPI_CampoC = ___Fabricante
          <DisplayName("Autor")>
          Public Property Autor As Boolean
          Public Shared ___Autor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Autor"",""etiqueta"": ""Autor"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor"",""descripcion"": """",""keyword"": ""Autor"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Autor As DinaNETCore.APID.DinaupAPI_CampoC = ___Autor
          <DisplayName("Número de registro de comercio (NRC)")>
          Public Property NumeroDeRegistroDeComercioNRC As String
          Public Shared ___NumeroDeRegistroDeComercioNRC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""NumeroDeRegistroDeComercioNRC"",""etiqueta"": ""Número de registro de comercio (NRC)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Número de registro de comercio (NRC)"",""descripcion"": """",""keyword"": ""NumeroDeRegistroDeComercioNRC"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __NumeroDeRegistroDeComercioNRC As DinaNETCore.APID.DinaupAPI_CampoC = ___NumeroDeRegistroDeComercioNRC
          <DisplayName("Es una entidad jurídica")>
          Public Property EsUnaEntidadJuridica As Boolean
          Public Shared ___EsUnaEntidadJuridica As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EsUnaEntidadJuridica"",""etiqueta"": ""Es una entidad jurídica"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Es una entidad jurídica"",""descripcion"": """",""keyword"": ""EsUnaEntidadJuridica"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EsUnaEntidadJuridica As DinaNETCore.APID.DinaupAPI_CampoC = ___EsUnaEntidadJuridica
          <DisplayName("Representante legal")>
          Public Property ReferenciaRepresentanteLegal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaRepresentanteLegal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaRepresentanteLegal"",""etiqueta"": ""Representante legal"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Representante legal"",""descripcion"": """",""keyword"": ""ReferenciaRepresentanteLegal"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaRepresentanteLegal As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaRepresentanteLegal
          <DisplayName("Representante legal Tiene Acceso web")>
          Public Property RepresentanteLegalTieneAccesoWeb As Boolean
          Public Shared ___RepresentanteLegalTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""RepresentanteLegalTieneAccesoWeb"",""etiqueta"": ""Representante legal Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Representante legal Tiene Acceso web"",""descripcion"": """",""keyword"": ""RepresentanteLegalTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __RepresentanteLegalTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___RepresentanteLegalTieneAccesoWeb
          <DisplayName("Nº Cliente")>
          Public Property NCliente As String
          Public Shared ___NCliente As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""NCliente"",""etiqueta"": ""Nº Cliente"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Nº Cliente"",""descripcion"": """",""keyword"": ""NCliente"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __NCliente As DinaNETCore.APID.DinaupAPI_CampoC = ___NCliente
          <DisplayName("Nº Proveedor")>
          Public Property NProveedor As String
          Public Shared ___NProveedor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""NProveedor"",""etiqueta"": ""Nº Proveedor"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Nº Proveedor"",""descripcion"": """",""keyword"": ""NProveedor"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __NProveedor As DinaNETCore.APID.DinaupAPI_CampoC = ___NProveedor
          <DisplayName("Empresa principal en la que trabaja Tiene Acceso web")>
          Public Property EmpresaPrincipalEnLaQueTrabajaTieneAccesoWeb As Boolean
          Public Shared ___EmpresaPrincipalEnLaQueTrabajaTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EmpresaPrincipalEnLaQueTrabajaTieneAccesoWeb"",""etiqueta"": ""Empresa principal en la que trabaja Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empresa principal en la que trabaja Tiene Acceso web"",""descripcion"": """",""keyword"": ""EmpresaPrincipalEnLaQueTrabajaTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EmpresaPrincipalEnLaQueTrabajaTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___EmpresaPrincipalEnLaQueTrabajaTieneAccesoWeb
          <DisplayName("Empresa principal en la que trabaja")>
          Public Property ReferenciaEmpresaPrincipalEnLaQueTrabaja As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaEmpresaPrincipalEnLaQueTrabaja As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaEmpresaPrincipalEnLaQueTrabaja"",""etiqueta"": ""Empresa principal en la que trabaja"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empresa principal en la que trabaja"",""descripcion"": """",""keyword"": ""ReferenciaEmpresaPrincipalEnLaQueTrabaja"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaEmpresaPrincipalEnLaQueTrabaja As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaEmpresaPrincipalEnLaQueTrabaja
          <DisplayName("Puede conectar a web")>
          Public Property PuedeConectarAWeb As Boolean
          Public Shared ___PuedeConectarAWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""PuedeConectarAWeb"",""etiqueta"": ""Puede conectar a web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Puede conectar a web"",""descripcion"": """",""keyword"": ""PuedeConectarAWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __PuedeConectarAWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___PuedeConectarAWeb
          <DisplayName("Contraseña (Obsoleto)")>
          Public Property ContraseñaObsoleto As String
          Public Shared ___ContraseñaObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ContraseñaObsoleto"",""etiqueta"": ""Contraseña (Obsoleto)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 10,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Contraseña (Obsoleto)"",""descripcion"": """",""keyword"": ""ContraseñaObsoleto"",""formato"": 5,""rol"": 10,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ContraseñaObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___ContraseñaObsoleto
          <DisplayName("Identificador Acceso")>
          Public Property IdentificadorAcceso As String
          Public Shared ___IdentificadorAcceso As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""IdentificadorAcceso"",""etiqueta"": ""Identificador Acceso"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 13,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Identificador Acceso"",""descripcion"": """",""keyword"": ""IdentificadorAcceso"",""formato"": 5,""rol"": 13,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __IdentificadorAcceso As DinaNETCore.APID.DinaupAPI_CampoC = ___IdentificadorAcceso
          <DisplayName("Contraseña acceso sistema")>
          Public Property ContraseñaAccesoSistema As String
          Public Shared ___ContraseñaAccesoSistema As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ContraseñaAccesoSistema"",""etiqueta"": ""Contraseña acceso sistema"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 10,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Contraseña acceso sistema"",""descripcion"": """",""keyword"": ""ContraseñaAccesoSistema"",""formato"": 5,""rol"": 10,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ContraseñaAccesoSistema As DinaNETCore.APID.DinaupAPI_CampoC = ___ContraseñaAccesoSistema
          <DisplayName("Motivo de bloqueo acceso web")>
          Public Property MotivoDeBloqueoAccesoWeb As String
          Public Shared ___MotivoDeBloqueoAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""MotivoDeBloqueoAccesoWeb"",""etiqueta"": ""Motivo de bloqueo acceso web"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Motivo de bloqueo acceso web"",""descripcion"": """",""keyword"": ""MotivoDeBloqueoAccesoWeb"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __MotivoDeBloqueoAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___MotivoDeBloqueoAccesoWeb
          <DisplayName("Solicitar cambio de contraseña al iniciar sesión")>
          Public Property SolicitarCambioDeContraseñaAlIniciarSesion As Boolean
          Public Shared ___SolicitarCambioDeContraseñaAlIniciarSesion As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""SolicitarCambioDeContraseñaAlIniciarSesion"",""etiqueta"": ""Solicitar cambio de contraseña al iniciar sesión"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Solicitar cambio de contraseña al iniciar sesión"",""descripcion"": """",""keyword"": ""SolicitarCambioDeContraseñaAlIniciarSesion"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __SolicitarCambioDeContraseñaAlIniciarSesion As DinaNETCore.APID.DinaupAPI_CampoC = ___SolicitarCambioDeContraseñaAlIniciarSesion
          <DisplayName("Rol")>
          Public Property ReferenciaRol As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaRol As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaRol"",""etiqueta"": ""Rol"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""rolesusuario"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Rol"",""descripcion"": """",""keyword"": ""ReferenciaRol"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaRol As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaRol
          <ReadOnlyAttribute(True)>
          <DisplayName("ID")>
          Public Property ID As Guid
          Public Shared ___ID As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": true,""eseliminado"": false,""keyword"": ""ID"",""etiqueta"": ""ID"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""eec5029a-440d-4505-8560-b88b3ff5917d"",""titulo"": ""Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""eec5029a-440d-4505-8560-b88b3ff5917d"",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""ID"",""descripcion"": """",""keyword"": ""ID"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
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
          me.AmbitoDeActividad = _Datos.Leer_String("pr_2222")
          me.NDeSocio = _Datos.Leer_Integer("pr_2216")
          me.FechaAlta_UTC = _Datos.Leer_DateTime_Nulable("pr_14c9f3ea9cg142wd")
          me.FechaDeNacimiento = _Datos.Leer_Date_Nulable("pr_2c619d")
          me.PaginaWeb = _Datos.Leer_String("pr_2225")
          me.ReferenciaFoto = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_5f05940d"), _Datos.Leer_String("pr_5f05940d.nombre"))
          me.ReferenciaCodigo = _Datos.Leer_String("pr_2c5e9f")
          me.VIP = _Datos.Leer_Boolean("pr_6122d4fd")
          me.EstadoCivil = _Datos.Leer_String("pr_5f0bfbe5")
          me.Profesion = _Datos.Leer_String("pr_2c60b5")
          me.ReferenciaComercialEncargado = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_14109n"), _Datos.Leer_String("pr_14109n.nombre"))
          me.NIFObsoleto = _Datos.Leer_String("pr_2c5a37")
          me.ReferenciaAutorDelAlta = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_1463105af0x146wd"), _Datos.Leer_String("pr_1463105af0x146wd.nombre"))
          me.Observaciones = _Datos.Leer_String("pr_2c6251")
          me.ReferenciaDestinador = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_1463105b91g1f2wd"), _Datos.Leer_String("pr_1463105b91g1f2wd.nombre"))
          me.Particular = _Datos.Leer_Boolean("pr_20040105072")
          me.HoraLocal = _Datos.Leer_Time_Nulable("pr_776ae62wd")
          me.ReferenciaUbicacionPrincipal = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_1464b42080x42wd"), _Datos.Leer_String("pr_1464b42080x42wd.nombre"))
          me.AutorDelAltaTieneAccesoWeb = _Datos.Leer_Boolean("pr_14631496d2x222wd")
          me.ComercialEncargadoTieneAccesoWeb = _Datos.Leer_Boolean("pr_146310d66bg40wd")
          me.NombreFiscalObsoleto = _Datos.Leer_String("pr_50040108211")
          me.Contacto = _Datos.Leer_Boolean("pr_20040105071")
          me.Proveedor = _Datos.Leer_Boolean("pr_20040105073")
          me.Cliente = _Datos.Leer_Boolean("pr_400401177028")
          me.ImporteSaldoAcumulado = _Datos.Leer_Decimal("pr_2c6229")
          me.ReferenciaDatosFiscales = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_40040138793"), _Datos.Leer_String("pr_40040138793.nombre"))
          me.Fabricante = _Datos.Leer_Boolean("pr_60040146992")
          me.Autor = _Datos.Leer_Boolean("pr_60040146993")
          me.NumeroDeRegistroDeComercioNRC = _Datos.Leer_String("pr_30040181602")
          me.EsUnaEntidadJuridica = _Datos.Leer_Boolean("pr_60040222581")
          me.ReferenciaRepresentanteLegal = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_20040242777"), _Datos.Leer_String("pr_20040242777.nombre"))
          me.RepresentanteLegalTieneAccesoWeb = _Datos.Leer_Boolean("pr_20040242778")
          me.NCliente = _Datos.Leer_String("pr_10040325042")
          me.NProveedor = _Datos.Leer_String("pr_10040325041")
          me.EmpresaPrincipalEnLaQueTrabajaTieneAccesoWeb = _Datos.Leer_Boolean("pr_20040414082")
          me.ReferenciaEmpresaPrincipalEnLaQueTrabaja = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_20040414081"), _Datos.Leer_String("pr_20040414081.nombre"))
          me.PuedeConectarAWeb = _Datos.Leer_Boolean("pr_3ffdcd7x257wc")
          me.ContraseñaObsoleto = _Datos.Leer_String("pr_14196n")
          me.IdentificadorAcceso = _Datos.Leer_String("pr_2bba690w12")
          me.ContraseñaAccesoSistema = _Datos.Leer_String("pr_3ffd627x9ewc")
          me.MotivoDeBloqueoAccesoWeb = _Datos.Leer_String("pr_10040218972")
          me.SolicitarCambioDeContraseñaAlIniciarSesion = _Datos.Leer_Boolean("pr_30040419861")
          me.ReferenciaRol = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_74e2013wd"), _Datos.Leer_String("pr_74e2013wd.nombre"))
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
         R.add("pr_2222", me.AmbitoDeActividad.AdaptarMySQL_String())
         R.add("pr_2216", me.NDeSocio.AdaptarMySQL_Integer())
         R.add("pr_14c9f3ea9cg142wd", me.FechaAlta_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_2c619d", me.FechaDeNacimiento.AdaptarMySQL_Date_Nulable())
         R.add("pr_2225", me.PaginaWeb.AdaptarMySQL_String())
         If Me.ReferenciaFoto IsNot nothing then
           R.add("pr_5f05940d",me.ReferenciaFoto.ID.STR())
         Else
           R.add("pr_5f05940d","")
         End if
         R.add("pr_2c5e9f", me.ReferenciaCodigo.AdaptarMySQL_String())
         R.add("pr_6122d4fd", me.VIP.AdaptarMySQL_Boolean())
         R.add("pr_5f0bfbe5", me.EstadoCivil.AdaptarMySQL_String())
         R.add("pr_2c60b5", me.Profesion.AdaptarMySQL_String())
         If Me.ReferenciaComercialEncargado IsNot nothing then
           R.add("pr_14109n",me.ReferenciaComercialEncargado.ID.STR())
         Else
           R.add("pr_14109n","")
         End if
         R.add("pr_2c5a37", me.NIFObsoleto.AdaptarMySQL_String())
         If Me.ReferenciaAutorDelAlta IsNot nothing then
           R.add("pr_1463105af0x146wd",me.ReferenciaAutorDelAlta.ID.STR())
         Else
           R.add("pr_1463105af0x146wd","")
         End if
         R.add("pr_2c6251", me.Observaciones.AdaptarMySQL_String())
         If Me.ReferenciaDestinador IsNot nothing then
           R.add("pr_1463105b91g1f2wd",me.ReferenciaDestinador.ID.STR())
         Else
           R.add("pr_1463105b91g1f2wd","")
         End if
         R.add("pr_20040105072", me.Particular.AdaptarMySQL_Boolean())
         R.add("pr_776ae62wd", me.HoraLocal.AdaptarMySQL_Time_Nulable())
         If Me.ReferenciaUbicacionPrincipal IsNot nothing then
           R.add("pr_1464b42080x42wd",me.ReferenciaUbicacionPrincipal.ID.STR())
         Else
           R.add("pr_1464b42080x42wd","")
         End if
         R.add("pr_14631496d2x222wd", me.AutorDelAltaTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_146310d66bg40wd", me.ComercialEncargadoTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_50040108211", me.NombreFiscalObsoleto.AdaptarMySQL_String())
         R.add("pr_20040105071", me.Contacto.AdaptarMySQL_Boolean())
         R.add("pr_20040105073", me.Proveedor.AdaptarMySQL_Boolean())
         R.add("pr_400401177028", me.Cliente.AdaptarMySQL_Boolean())
         R.add("pr_2c6229", me.ImporteSaldoAcumulado.AdaptarMySQL_Decimal())
         If Me.ReferenciaDatosFiscales IsNot nothing then
           R.add("pr_40040138793",me.ReferenciaDatosFiscales.ID.STR())
         Else
           R.add("pr_40040138793","")
         End if
         R.add("pr_60040146992", me.Fabricante.AdaptarMySQL_Boolean())
         R.add("pr_60040146993", me.Autor.AdaptarMySQL_Boolean())
         R.add("pr_30040181602", me.NumeroDeRegistroDeComercioNRC.AdaptarMySQL_String())
         R.add("pr_60040222581", me.EsUnaEntidadJuridica.AdaptarMySQL_Boolean())
         If Me.ReferenciaRepresentanteLegal IsNot nothing then
           R.add("pr_20040242777",me.ReferenciaRepresentanteLegal.ID.STR())
         Else
           R.add("pr_20040242777","")
         End if
         R.add("pr_20040242778", me.RepresentanteLegalTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_10040325042", me.NCliente.AdaptarMySQL_String())
         R.add("pr_10040325041", me.NProveedor.AdaptarMySQL_String())
         R.add("pr_20040414082", me.EmpresaPrincipalEnLaQueTrabajaTieneAccesoWeb.AdaptarMySQL_Boolean())
         If Me.ReferenciaEmpresaPrincipalEnLaQueTrabaja IsNot nothing then
           R.add("pr_20040414081",me.ReferenciaEmpresaPrincipalEnLaQueTrabaja.ID.STR())
         Else
           R.add("pr_20040414081","")
         End if
         R.add("pr_3ffdcd7x257wc", me.PuedeConectarAWeb.AdaptarMySQL_Boolean())
         R.add("pr_14196n", me.ContraseñaObsoleto.AdaptarMySQL_String())
         R.add("pr_2bba690w12", me.IdentificadorAcceso.AdaptarMySQL_String())
         R.add("pr_3ffd627x9ewc", me.ContraseñaAccesoSistema.AdaptarMySQL_String())
         R.add("pr_10040218972", me.MotivoDeBloqueoAccesoWeb.AdaptarMySQL_String())
         R.add("pr_30040419861", me.SolicitarCambioDeContraseñaAlIniciarSesion.AdaptarMySQL_Boolean())
         If Me.ReferenciaRol IsNot nothing then
           R.add("pr_74e2013wd",me.ReferenciaRol.ID.STR())
         Else
           R.add("pr_74e2013wd","")
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
      Public Class Entidades_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
          Public property AmbitoDeActividad As String
            get
                return me.GetValue_String("pr_2222")
            End Get
            Set(value As String)
                me.SetValue_String("pr_2222", value)
            End Set
          End Property
          Public property NDeSocio As Integer
            get
                return me.GetValue_Int("pr_2216")
            End Get
            Set(value As Integer)
                me.SetValue_Int("pr_2216", value)
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
          Public property FechaDeNacimiento As Date
            get
                return me.GetValue_Date("pr_2c619d")
            End Get
            Set(value As Date)
                me.SetValue_Date("pr_2c619d", value)
            End Set
          End Property
          Public property PaginaWeb As String
            get
                return me.GetValue_String("pr_2225")
            End Get
            Set(value As String)
                me.SetValue_String("pr_2225", value)
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
          Public property ReferenciaCodigo As String
            get
                return me.GetValue_String("pr_2c5e9f")
            End Get
            Set(value As String)
                me.SetValue_String("pr_2c5e9f", value)
            End Set
          End Property
          Public property VIP As Boolean
            get
                return me.GetValue_Boolean("pr_6122d4fd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_6122d4fd", value)
            End Set
          End Property
          Public property EstadoCivil As String
            get
                return me.GetValue_String("pr_5f0bfbe5")
            End Get
            Set(value As String)
                me.SetValue_String("pr_5f0bfbe5", value)
            End Set
          End Property
          Public property Profesion As String
            get
                return me.GetValue_String("pr_2c60b5")
            End Get
            Set(value As String)
                me.SetValue_String("pr_2c60b5", value)
            End Set
          End Property
          Public property ReferenciaComercialEncargado As Guid
            get
                return me.GetValue_Guid("pr_14109n")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_14109n", value)
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
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_1463105af0x146wd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_1463105af0x146wd", value)
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
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_1463105b91g1f2wd")
            End Get   
        End Property
          Public property Particular As Boolean
            get
                return me.GetValue_Boolean("pr_20040105072")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_20040105072", value)
            End Set
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
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_14631496d2x222wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_14631496d2x222wd", value)
            End Set
          End Property
          Public property ComercialEncargadoTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_146310d66bg40wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_146310d66bg40wd", value)
            End Set
          End Property
          Public property NombreFiscalObsoleto As String
            get
                return me.GetValue_String("pr_50040108211")
            End Get
            Set(value As String)
                me.SetValue_String("pr_50040108211", value)
            End Set
          End Property
          Public property Contacto As Boolean
            get
                return me.GetValue_Boolean("pr_20040105071")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_20040105071", value)
            End Set
          End Property
          Public property Proveedor As Boolean
            get
                return me.GetValue_Boolean("pr_20040105073")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_20040105073", value)
            End Set
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
          Public property Fabricante As Boolean
            get
                return me.GetValue_Boolean("pr_60040146992")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_60040146992", value)
            End Set
          End Property
          Public property Autor As Boolean
            get
                return me.GetValue_Boolean("pr_60040146993")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_60040146993", value)
            End Set
          End Property
          Public property NumeroDeRegistroDeComercioNRC As String
            get
                return me.GetValue_String("pr_30040181602")
            End Get
            Set(value As String)
                me.SetValue_String("pr_30040181602", value)
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
          Public property ReferenciaRepresentanteLegal As Guid
            get
                return me.GetValue_Guid("pr_20040242777")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_20040242777", value)
            End Set
          End Property
          Public property RepresentanteLegalTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_20040242778")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_20040242778", value)
            End Set
          End Property
          Public property NCliente As String
            get
                return me.GetValue_String("pr_10040325042")
            End Get
            Set(value As String)
                me.SetValue_String("pr_10040325042", value)
            End Set
          End Property
          Public property NProveedor As String
            get
                return me.GetValue_String("pr_10040325041")
            End Get
            Set(value As String)
                me.SetValue_String("pr_10040325041", value)
            End Set
          End Property
          Public property EmpresaPrincipalEnLaQueTrabajaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_20040414082")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_20040414082", value)
            End Set
          End Property
          Public property ReferenciaEmpresaPrincipalEnLaQueTrabaja As Guid
            get
                return me.GetValue_Guid("pr_20040414081")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_20040414081", value)
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
          Public property ContraseñaObsoleto As String
            get
                return me.GetValue_String("pr_14196n")
            End Get
            Set(value As String)
                me.SetValue_String("pr_14196n", value)
            End Set
          End Property
          Public property IdentificadorAcceso As String
            get
                return me.GetValue_String("pr_2bba690w12")
            End Get
            Set(value As String)
                me.SetValue_String("pr_2bba690w12", value)
            End Set
          End Property
          Public property ContraseñaAccesoSistema As String
            get
                return me.GetValue_String("pr_3ffd627x9ewc")
            End Get
            Set(value As String)
                me.SetValue_String("pr_3ffd627x9ewc", value)
            End Set
          End Property
          Public property MotivoDeBloqueoAccesoWeb As String
            get
                return me.GetValue_String("pr_10040218972")
            End Get
            Set(value As String)
                me.SetValue_String("pr_10040218972", value)
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
          Public property ReferenciaRol As Guid
            get
                return me.GetValue_Guid("pr_74e2013wd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_74e2013wd", value)
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
