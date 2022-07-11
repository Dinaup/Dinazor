   Imports System.ComponentModel
   Imports DinaNETCore
   Imports DinaNETCore.APID
Partial Public Class SeccionesD
  Public Class BuzonesDeCorreoD
      Public Class BuzonesDeCorreo_ConListaC
      Public Listador as BuzonesDeCorreoC
      Public Lista As New List(of BuzonesDeCorreoListaD.BuzonesDeCorreoListaC)
        sub new(_listador  as BuzonesDeCorreoC, _lista as List(of BuzonesDeCorreoListaD.BuzonesDeCorreoListaC))
           me.Listador =_listador 
           me.Lista =_lista 
        End sub
      End Class
      Public Shared _SeccionID As String = "93dc3756-c5c1-44d8-b11f-a23250336260"
      Public Shared _SeccionIDGUID As New Guid("93dc3756-c5c1-44d8-b11f-a23250336260")
      Public Shared Async Function ConsultarDatos_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, ParamArray Valor As String()) As Task(Of List(Of BuzonesDeCorreoC )) 
          Dim R As New List(Of BuzonesDeCorreoC )  
          Dim d = Await DinaupSesion.ConexionServidor.Funcion_Datos_Recibir_Async(DinaupSesion, BuzonesDeCorreoES._SeccionID, False, Campo, Valor) 
          If d.Datos.TieneDatos Then 
              For Each Actual In d.Datos 
                  Dim Valores_Listador = Actual.Value.Item1
                  Dim Obj_Listador As New BuzonesDeCorreoC 
                  Obj_Listador.CargarDatos(Valores_Listador) 
                  R.Add(Obj_Listador) 
              Next 
          End If 
          Return R 
      End Function 
      Public Shared Async Function ConsultarDatos_ConLista_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, ParamArray Valor As String()) As Task(Of List(Of  BuzonesDeCorreo_ConListaC)) 
          Dim R As New List(Of BuzonesDeCorreo_ConListaC )  
          Dim d =  Await DinaupSesion.ConexionServidor.Funcion_Datos_Recibir_Async(DinaupSesion, BuzonesDeCorreoES._SeccionID, True, Campo, Valor) 
          If d.Datos.TieneDatos Then 
              For Each Actual In d.Datos 
                  Dim Valores_Listador = Actual.Value.Item1
                  Dim Valores_Lista = Actual.Value.Item2
                  Dim Obj_Listador As New BuzonesDeCorreoC 
                  Obj_Listador.CargarDatos(Valores_Listador) 
                  Dim Objs_Listas As New List(Of BuzonesDeCorreoListaD.BuzonesDeCorreoListaC) 
                  If Valores_Lista.TieneDatos Then  
                      For Each ValoresLista In Valores_Lista 
                         Dim nItem As New BuzonesDeCorreoListaD.BuzonesDeCorreoListaC 
                         nItem.CargarDatos(ValoresLista)   
                         Objs_Listas.Add(nItem)         
                      Next   
                  End If   
                  R.Add(New BuzonesDeCorreo_ConListaC(Obj_Listador, Objs_Listas))
              Next 
          End If 
          Return R 
      End Function 
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As BuzonesDeCorreoC, Optional CampoWhere$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Return Await DatosGuardar_Async(DinaupSesion, New List(Of BuzonesDeCorreoC)({DAtos}), CampoWhere )
      End Function
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As List(Of BuzonesDeCorreoC), Optional CampoWhere$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Dim Importar As New List(Of DinaupAPI_ImportacionProcesableC)
          For Each Actual In DAtos 
              Dim RegistroActual = New DinaupAPI_ImportacionProcesableC() 
               RegistroActual.dinaup_listador_datos = Actual.ToDic 
               Importar.Add(RegistroActual)  
          Next 
          Return Await DinaupSesion.ConexionServidor.Funcion_Importar_Ejecutar_Async(DinaupSesion, BuzonesDeCorreoES._SeccionID, Importar, CampoWhere, "") 
      End Function
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As BuzonesDeCorreo_ConListaC, Optional CampoWhere$ = "id", Optional CampoWhereLista$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Return Await DatosGuardar_Async(DinaupSesion, New List(Of BuzonesDeCorreo_ConListaC)({DAtos}), CampoWhere, CampoWhereLista)
      End Function
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As List(Of BuzonesDeCorreo_ConListaC), Optional CampoWhere$ = "id", Optional CampoWhereLista$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Dim Importar As New List(Of DinaupAPI_ImportacionProcesableC)
          For Each Actual In DAtos 
              Dim RegistroActual = New DinaupAPI_ImportacionProcesableC() 
               RegistroActual.dinaup_listador_datos = Actual.Listador.ToDic 
               If Actual.Lista.TieneDatos Then  
                   For Each ActualLista In Actual.Lista  
                       RegistroActual.dinaup_lista_datos.Add(ActualLista.ToDic) 
                   Next 
               End If 
               Importar.Add(RegistroActual)  
          Next 
          Return Await DinaupSesion.ConexionServidor.Funcion_Importar_Ejecutar_Async(DinaupSesion, BuzonesDeCorreoES._SeccionID, Importar, CampoWhere, CampoWhereLista) 
      End Function
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As BuzonesDeCorreo_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, BuzonesDeCorreoES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New BuzonesDeCorreo_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As BuzonesDeCorreo_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, BuzonesDeCorreoES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New BuzonesDeCorreo_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class BuzonesDeCorreoES
          Public shared _SeccionID as Guid = New Guid("93dc3756-c5c1-44d8-b11f-a23250336260")
          Public shared _Tabla$ = "tpr_50040257403"
      Public Shared ReferenciaDestinador$ = "pr_500402574016"
      Public Shared ExportarEnModulos$ = "pr_500402574014"
      Public Shared HoraLocal$ = "pr_500402574013"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_500402574027"
      Public Shared FechaAlta_UTC$ = "pr_500402574015"
      Public Shared ReferenciaAutorDelAlta$ = "pr_500402574011"
      Public Shared ReferenciaCuentaDeCorreo$ = "pr_600402574029"
      Public Shared EtiquetaDelBuzon$ = "pr_40040257411"
      Public Shared ReferenciaEmpresaALaQueAsociarLosCorreos$ = "pr_60040257411"
      Public Shared BuzonDesactivado$ = "pr_40040257422"
      Public Shared ReferenciaSeccionDeDestino1$ = "pr_40040257431"
      Public Shared ReferenciaSeccionDeDestino2$ = "pr_40040257432"
      Public Shared ReferenciaSeccionDeDestino3$ = "pr_40040257433"
      Public Shared ReferenciaSeccionDeDestino4$ = "pr_40040257434"
      Public Shared ReferenciaSeccionDeDestino5$ = "pr_40040257435"
      Public Shared ReferenciaSeccionDeDestino6$ = "pr_40040257436"
      Public Shared EntidadALaQueAsociarLosCorreosTieneAccesoWeb$ = "pr_60040257449"
      Public Shared ReferenciaEntidadALaQueAsociarLosCorreos$ = "pr_60040257448"
      Public Shared ReferenciaEstadoParaNuevos$ = "pr_10040257451"
      Public Shared PermisosDeEnvio$ = "pr_60040257882"
      Public Shared PermisosDeLectura$ = "pr_60040257881"
      Public Shared EtiquetaComoAliasRecomendado$ = "pr_20040474821"
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
      Public Class BuzonesDeCorreoC
      Inherits Base_DatoC
          <DisplayName("Destinador")>
          Public Property ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaDestinador As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaDestinador"",""etiqueta"": ""Destinador"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""relacionesindirectas"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Destinador"",""descripcion"": """",""keyword"": ""ReferenciaDestinador"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaDestinador
          <DisplayName("Hora local")>
          Public Property HoraLocal As DateTime?
          Public Shared ___HoraLocal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""HoraLocal"",""etiqueta"": ""Hora local"",""oculta"": false,""formato"": 8,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Hora local"",""descripcion"": """",""keyword"": ""HoraLocal"",""formato"": 8,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __HoraLocal As DinaNETCore.APID.DinaupAPI_CampoC = ___HoraLocal
          <DisplayName("Autor del alta Tiene Acceso web")>
          Public Property AutorDelAltaTieneAccesoWeb As Boolean
          Public Shared ___AutorDelAltaTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AutorDelAltaTieneAccesoWeb"",""etiqueta"": ""Autor del alta Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta Tiene Acceso web"",""descripcion"": """",""keyword"": ""AutorDelAltaTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AutorDelAltaTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___AutorDelAltaTieneAccesoWeb
          <DisplayName("Fecha Alta del registro")>
          Public Property FechaAlta_UTC As Date?
          Public Shared ___FechaAlta_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaAlta_UTC"",""etiqueta"": ""Fecha Alta del registro"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Alta del registro"",""descripcion"": """",""keyword"": ""FechaAlta_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaAlta_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaAlta_UTC
          <DisplayName("Autor del alta")>
          Public Property ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaAutorDelAlta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaAutorDelAlta"",""etiqueta"": ""Autor del alta"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta"",""descripcion"": """",""keyword"": ""ReferenciaAutorDelAlta"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaAutorDelAlta
          <DisplayName("Cuenta de correo")>
          Public Property ReferenciaCuentaDeCorreo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaCuentaDeCorreo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaCuentaDeCorreo"",""etiqueta"": ""Cuenta de correo"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""e80ad188-9d6d-4b05-a7fb-e498cef51598"",""titulo"": ""Base - Cuentas de Correo electrónico"",""iconoid"": ""5fd758a4-dbc3-4365-ad56-18af81075b78"",""etiquetasingular"": ""Cuenta de correo electrónico"",""etiquetaplural"": ""Cuentas de Correo electrónico"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""e80ad188-9d6d-4b05-a7fb-e498cef51598"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cuenta de correo"",""descripcion"": """",""keyword"": ""ReferenciaCuentaDeCorreo"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaCuentaDeCorreo As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaCuentaDeCorreo
          <DisplayName("Etiqueta del buzón")>
          Public Property EtiquetaDelBuzon As String
          Public Shared ___EtiquetaDelBuzon As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EtiquetaDelBuzon"",""etiqueta"": ""Etiqueta del buzón"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 100,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Etiqueta del buzón"",""descripcion"": """",""keyword"": ""EtiquetaDelBuzon"",""formato"": 5,""rol"": 100,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EtiquetaDelBuzon As DinaNETCore.APID.DinaupAPI_CampoC = ___EtiquetaDelBuzon
          <DisplayName("Empresa a la que asociar los correos")>
          Public Property ReferenciaEmpresaALaQueAsociarLosCorreos As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaEmpresaALaQueAsociarLosCorreos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaEmpresaALaQueAsociarLosCorreos"",""etiqueta"": ""Empresa a la que asociar los correos"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""9d1bb1b3-06e1-425b-bd5a-1d03bae37094"",""titulo"": ""Base - Empresas administradas"",""iconoid"": ""b788149e-1c15-4807-9a25-72adf3333e5b"",""etiquetasingular"": ""Empresa administrada"",""etiquetaplural"": ""Empresas administradas"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""9d1bb1b3-06e1-425b-bd5a-1d03bae37094"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empresa a la que asociar los correos"",""descripcion"": """",""keyword"": ""ReferenciaEmpresaALaQueAsociarLosCorreos"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaEmpresaALaQueAsociarLosCorreos As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaEmpresaALaQueAsociarLosCorreos
          <DisplayName("Buzón desactivado")>
          Public Property BuzonDesactivado As Boolean
          Public Shared ___BuzonDesactivado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""BuzonDesactivado"",""etiqueta"": ""Buzón desactivado"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Buzón desactivado"",""descripcion"": """",""keyword"": ""BuzonDesactivado"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __BuzonDesactivado As DinaNETCore.APID.DinaupAPI_CampoC = ___BuzonDesactivado
          <DisplayName("Sección de destino 1")>
          Public Property ReferenciaSeccionDeDestino1 As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaSeccionDeDestino1 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaSeccionDeDestino1"",""etiqueta"": ""Sección de destino 1"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""plantillasp"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Sección de destino 1"",""descripcion"": """",""keyword"": ""ReferenciaSeccionDeDestino1"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaSeccionDeDestino1 As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaSeccionDeDestino1
          <DisplayName("Sección de destino 2")>
          Public Property ReferenciaSeccionDeDestino2 As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaSeccionDeDestino2 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaSeccionDeDestino2"",""etiqueta"": ""Sección de destino 2"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""plantillasp"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Sección de destino 2"",""descripcion"": """",""keyword"": ""ReferenciaSeccionDeDestino2"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaSeccionDeDestino2 As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaSeccionDeDestino2
          <DisplayName("Sección de destino 3")>
          Public Property ReferenciaSeccionDeDestino3 As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaSeccionDeDestino3 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaSeccionDeDestino3"",""etiqueta"": ""Sección de destino 3"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""plantillasp"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Sección de destino 3"",""descripcion"": """",""keyword"": ""ReferenciaSeccionDeDestino3"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaSeccionDeDestino3 As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaSeccionDeDestino3
          <DisplayName("Sección de destino 4")>
          Public Property ReferenciaSeccionDeDestino4 As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaSeccionDeDestino4 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaSeccionDeDestino4"",""etiqueta"": ""Sección de destino 4"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""plantillasp"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Sección de destino 4"",""descripcion"": """",""keyword"": ""ReferenciaSeccionDeDestino4"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaSeccionDeDestino4 As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaSeccionDeDestino4
          <DisplayName("Sección de destino 5")>
          Public Property ReferenciaSeccionDeDestino5 As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaSeccionDeDestino5 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaSeccionDeDestino5"",""etiqueta"": ""Sección de destino 5"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""plantillasp"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Sección de destino 5"",""descripcion"": """",""keyword"": ""ReferenciaSeccionDeDestino5"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaSeccionDeDestino5 As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaSeccionDeDestino5
          <DisplayName("Sección de destino 6")>
          Public Property ReferenciaSeccionDeDestino6 As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaSeccionDeDestino6 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaSeccionDeDestino6"",""etiqueta"": ""Sección de destino 6"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""plantillasp"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Sección de destino 6"",""descripcion"": """",""keyword"": ""ReferenciaSeccionDeDestino6"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaSeccionDeDestino6 As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaSeccionDeDestino6
          <DisplayName("Entidad a la que asociar los correos Tiene Acceso web")>
          Public Property EntidadALaQueAsociarLosCorreosTieneAccesoWeb As Boolean
          Public Shared ___EntidadALaQueAsociarLosCorreosTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EntidadALaQueAsociarLosCorreosTieneAccesoWeb"",""etiqueta"": ""Entidad a la que asociar los correos Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Entidad a la que asociar los correos Tiene Acceso web"",""descripcion"": """",""keyword"": ""EntidadALaQueAsociarLosCorreosTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EntidadALaQueAsociarLosCorreosTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___EntidadALaQueAsociarLosCorreosTieneAccesoWeb
          <DisplayName("Entidad a la que asociar los correos")>
          Public Property ReferenciaEntidadALaQueAsociarLosCorreos As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaEntidadALaQueAsociarLosCorreos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaEntidadALaQueAsociarLosCorreos"",""etiqueta"": ""Entidad a la que asociar los correos"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Entidad a la que asociar los correos"",""descripcion"": """",""keyword"": ""ReferenciaEntidadALaQueAsociarLosCorreos"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaEntidadALaQueAsociarLosCorreos As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaEntidadALaQueAsociarLosCorreos
          <DisplayName("Estado para nuevos")>
          Public Property ReferenciaEstadoParaNuevos As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaEstadoParaNuevos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaEstadoParaNuevos"",""etiqueta"": ""Estado para nuevos"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""f887a106-8678-4e36-bf85-c9ea84129632"",""titulo"": ""Base - Estados de correos recibidos"",""iconoid"": ""d29b6e1e-0922-4c61-926d-1182f1d705ab"",""etiquetasingular"": ""Estado de correos recibidos"",""etiquetaplural"": ""Estados de correos recibidos"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""f887a106-8678-4e36-bf85-c9ea84129632"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Estado para nuevos"",""descripcion"": """",""keyword"": ""ReferenciaEstadoParaNuevos"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaEstadoParaNuevos As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaEstadoParaNuevos
          <DisplayName("Permisos de envío")>
          Public Property PermisosDeEnvio As Integer
          Public Shared ___PermisosDeEnvio As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""PermisosDeEnvio"",""etiqueta"": ""Permisos de envío"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Permisos de envío"",""descripcion"": """",""keyword"": ""PermisosDeEnvio"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __PermisosDeEnvio As DinaNETCore.APID.DinaupAPI_CampoC = ___PermisosDeEnvio
          <DisplayName("Permisos de lectura")>
          Public Property PermisosDeLectura As Integer
          Public Shared ___PermisosDeLectura As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""PermisosDeLectura"",""etiqueta"": ""Permisos de lectura"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Permisos de lectura"",""descripcion"": """",""keyword"": ""PermisosDeLectura"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __PermisosDeLectura As DinaNETCore.APID.DinaupAPI_CampoC = ___PermisosDeLectura
          <DisplayName("Etiqueta como alias (Recomendado)")>
          Public Property EtiquetaComoAliasRecomendado As Boolean
          Public Shared ___EtiquetaComoAliasRecomendado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EtiquetaComoAliasRecomendado"",""etiqueta"": ""Etiqueta como alias (Recomendado)"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Etiqueta como alias (Recomendado)"",""descripcion"": """",""keyword"": ""EtiquetaComoAliasRecomendado"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EtiquetaComoAliasRecomendado As DinaNETCore.APID.DinaupAPI_CampoC = ___EtiquetaComoAliasRecomendado
          <ReadOnlyAttribute(True)>
          <DisplayName("ID")>
          Public Property ID As Guid
          Public Shared ___ID As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": true,""eseliminado"": false,""keyword"": ""ID"",""etiqueta"": ""ID"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""93dc3756-c5c1-44d8-b11f-a23250336260"",""titulo"": ""Buzones de correo"",""iconoid"": ""a56f7a66-b0cd-4c38-ae69-d85b1c4ac09a"",""etiquetasingular"": ""Buzón de correos"",""etiquetaplural"": ""Buzones de correo"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""93dc3756-c5c1-44d8-b11f-a23250336260"",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""ID"",""descripcion"": """",""keyword"": ""ID"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
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
          me.ReferenciaDestinador = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_500402574016"), _Datos.Leer_String("pr_500402574016.nombre"))
          me.HoraLocal = _Datos.Leer_Time_Nulable("pr_500402574013")
          me.AutorDelAltaTieneAccesoWeb = _Datos.Leer_Boolean("pr_500402574027")
          me.FechaAlta_UTC = _Datos.Leer_DateTime_Nulable("pr_500402574015")
          me.ReferenciaAutorDelAlta = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_500402574011"), _Datos.Leer_String("pr_500402574011.nombre"))
          me.ReferenciaCuentaDeCorreo = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_600402574029"), _Datos.Leer_String("pr_600402574029.nombre"))
          me.EtiquetaDelBuzon = _Datos.Leer_String("pr_40040257411")
          me.ReferenciaEmpresaALaQueAsociarLosCorreos = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_60040257411"), _Datos.Leer_String("pr_60040257411.nombre"))
          me.BuzonDesactivado = _Datos.Leer_Boolean("pr_40040257422")
          me.ReferenciaSeccionDeDestino1 = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_40040257431"), _Datos.Leer_String("pr_40040257431.nombre"))
          me.ReferenciaSeccionDeDestino2 = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_40040257432"), _Datos.Leer_String("pr_40040257432.nombre"))
          me.ReferenciaSeccionDeDestino3 = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_40040257433"), _Datos.Leer_String("pr_40040257433.nombre"))
          me.ReferenciaSeccionDeDestino4 = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_40040257434"), _Datos.Leer_String("pr_40040257434.nombre"))
          me.ReferenciaSeccionDeDestino5 = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_40040257435"), _Datos.Leer_String("pr_40040257435.nombre"))
          me.ReferenciaSeccionDeDestino6 = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_40040257436"), _Datos.Leer_String("pr_40040257436.nombre"))
          me.EntidadALaQueAsociarLosCorreosTieneAccesoWeb = _Datos.Leer_Boolean("pr_60040257449")
          me.ReferenciaEntidadALaQueAsociarLosCorreos = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_60040257448"), _Datos.Leer_String("pr_60040257448.nombre"))
          me.ReferenciaEstadoParaNuevos = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_10040257451"), _Datos.Leer_String("pr_10040257451.nombre"))
          me.PermisosDeEnvio = _Datos.Leer_Integer("pr_60040257882")
          me.PermisosDeLectura = _Datos.Leer_Integer("pr_60040257881")
          me.EtiquetaComoAliasRecomendado = _Datos.Leer_Boolean("pr_20040474821")
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
           R.add("pr_500402574016",me.ReferenciaDestinador.ID.STR())
         Else
           R.add("pr_500402574016","")
         End if
         R.add("pr_500402574013", me.HoraLocal.AdaptarMySQL_Time_Nulable())
         R.add("pr_500402574027", me.AutorDelAltaTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_500402574015", me.FechaAlta_UTC.AdaptarMySQL_DateTime_Nulable())
         If Me.ReferenciaAutorDelAlta IsNot nothing then
           R.add("pr_500402574011",me.ReferenciaAutorDelAlta.ID.STR())
         Else
           R.add("pr_500402574011","")
         End if
         If Me.ReferenciaCuentaDeCorreo IsNot nothing then
           R.add("pr_600402574029",me.ReferenciaCuentaDeCorreo.ID.STR())
         Else
           R.add("pr_600402574029","")
         End if
         R.add("pr_40040257411", me.EtiquetaDelBuzon.AdaptarMySQL_String())
         If Me.ReferenciaEmpresaALaQueAsociarLosCorreos IsNot nothing then
           R.add("pr_60040257411",me.ReferenciaEmpresaALaQueAsociarLosCorreos.ID.STR())
         Else
           R.add("pr_60040257411","")
         End if
         R.add("pr_40040257422", me.BuzonDesactivado.AdaptarMySQL_Boolean())
         If Me.ReferenciaSeccionDeDestino1 IsNot nothing then
           R.add("pr_40040257431",me.ReferenciaSeccionDeDestino1.ID.STR())
         Else
           R.add("pr_40040257431","")
         End if
         If Me.ReferenciaSeccionDeDestino2 IsNot nothing then
           R.add("pr_40040257432",me.ReferenciaSeccionDeDestino2.ID.STR())
         Else
           R.add("pr_40040257432","")
         End if
         If Me.ReferenciaSeccionDeDestino3 IsNot nothing then
           R.add("pr_40040257433",me.ReferenciaSeccionDeDestino3.ID.STR())
         Else
           R.add("pr_40040257433","")
         End if
         If Me.ReferenciaSeccionDeDestino4 IsNot nothing then
           R.add("pr_40040257434",me.ReferenciaSeccionDeDestino4.ID.STR())
         Else
           R.add("pr_40040257434","")
         End if
         If Me.ReferenciaSeccionDeDestino5 IsNot nothing then
           R.add("pr_40040257435",me.ReferenciaSeccionDeDestino5.ID.STR())
         Else
           R.add("pr_40040257435","")
         End if
         If Me.ReferenciaSeccionDeDestino6 IsNot nothing then
           R.add("pr_40040257436",me.ReferenciaSeccionDeDestino6.ID.STR())
         Else
           R.add("pr_40040257436","")
         End if
         R.add("pr_60040257449", me.EntidadALaQueAsociarLosCorreosTieneAccesoWeb.AdaptarMySQL_Boolean())
         If Me.ReferenciaEntidadALaQueAsociarLosCorreos IsNot nothing then
           R.add("pr_60040257448",me.ReferenciaEntidadALaQueAsociarLosCorreos.ID.STR())
         Else
           R.add("pr_60040257448","")
         End if
         If Me.ReferenciaEstadoParaNuevos IsNot nothing then
           R.add("pr_10040257451",me.ReferenciaEstadoParaNuevos.ID.STR())
         Else
           R.add("pr_10040257451","")
         End if
         R.add("pr_60040257882", me.PermisosDeEnvio.AdaptarMySQL_Integer())
         R.add("pr_60040257881", me.PermisosDeLectura.AdaptarMySQL_Integer())
         R.add("pr_20040474821", me.EtiquetaComoAliasRecomendado.AdaptarMySQL_Boolean())
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
      Public Class BuzonesDeCorreo_FormularioC
        Inherits DinaNETCore.VentanaVirtualC

    Public _Lista As List(Of BuzonesDeCorreoListaD.BuzonesDeCorreoLista_FormularioC)



    Overrides Sub Evento_Actualizar()

        If Me.EsListador Then
            Dim FormLista = Me.__VV__.Formularios_Lista
            Dim CreandoLista As New List(Of BuzonesDeCorreoListaD.BuzonesDeCorreoLista_FormularioC)
            If FormLista IsNot Nothing Then
                For i = 0 To FormLista.Count - 1
                    Dim ElementoLista As New BuzonesDeCorreoListaD.BuzonesDeCorreoLista_FormularioC(Me.__VV__, FormLista(i).Token)
                    CreandoLista.Add(ElementoLista)
                Next
            End If
            _Lista = CreandoLista
        End If

    End Sub

                  


        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_500402574016")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As DateTime
            get
                return me.GetValue_DateTime("pr_500402574013")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_500402574027")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_500402574027", value)
            End Set
          End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_500402574015")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_500402574015", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_500402574011")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_500402574011", value)
            End Set
          End Property
          Public property ReferenciaCuentaDeCorreo As Guid
            get
                return me.GetValue_Guid("pr_600402574029")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_600402574029", value)
            End Set
          End Property
          Public property EtiquetaDelBuzon As String
            get
                return me.GetValue_String("pr_40040257411")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040257411", value)
            End Set
          End Property
          Public property ReferenciaEmpresaALaQueAsociarLosCorreos As Guid
            get
                return me.GetValue_Guid("pr_60040257411")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_60040257411", value)
            End Set
          End Property
          Public property BuzonDesactivado As Boolean
            get
                return me.GetValue_Boolean("pr_40040257422")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_40040257422", value)
            End Set
          End Property
          Public property ReferenciaSeccionDeDestino1 As Guid
            get
                return me.GetValue_Guid("pr_40040257431")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_40040257431", value)
            End Set
          End Property
          Public property ReferenciaSeccionDeDestino2 As Guid
            get
                return me.GetValue_Guid("pr_40040257432")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_40040257432", value)
            End Set
          End Property
          Public property ReferenciaSeccionDeDestino3 As Guid
            get
                return me.GetValue_Guid("pr_40040257433")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_40040257433", value)
            End Set
          End Property
          Public property ReferenciaSeccionDeDestino4 As Guid
            get
                return me.GetValue_Guid("pr_40040257434")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_40040257434", value)
            End Set
          End Property
          Public property ReferenciaSeccionDeDestino5 As Guid
            get
                return me.GetValue_Guid("pr_40040257435")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_40040257435", value)
            End Set
          End Property
          Public property ReferenciaSeccionDeDestino6 As Guid
            get
                return me.GetValue_Guid("pr_40040257436")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_40040257436", value)
            End Set
          End Property
          Public property EntidadALaQueAsociarLosCorreosTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_60040257449")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_60040257449", value)
            End Set
          End Property
          Public property ReferenciaEntidadALaQueAsociarLosCorreos As Guid
            get
                return me.GetValue_Guid("pr_60040257448")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_60040257448", value)
            End Set
          End Property
          Public property ReferenciaEstadoParaNuevos As Guid
            get
                return me.GetValue_Guid("pr_10040257451")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_10040257451", value)
            End Set
          End Property
        Public ReadOnly property PermisosDeEnvio As Integer
            get
                return me.GetValue_Int("pr_60040257882")
            End Get   
        End Property
        Public ReadOnly property PermisosDeLectura As Integer
            get
                return me.GetValue_Int("pr_60040257881")
            End Get   
        End Property
        Public ReadOnly property EtiquetaComoAliasRecomendado As Boolean
            get
                return me.GetValue_Boolean("pr_20040474821")
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
