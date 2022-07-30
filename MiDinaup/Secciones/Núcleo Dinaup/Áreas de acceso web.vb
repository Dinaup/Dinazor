   Imports System.ComponentModel
   Imports DinaNETCore
   Imports DinaNETCore.APID
Partial Public Class SeccionesD
  Public Class AreasDeAccesoWebD
      Public Class AreasDeAccesoWeb_ConListaC
      Public Listador as AreasDeAccesoWebC
      Public Lista As New List(of AreasDeAccesoWebListaD.AreasDeAccesoWebListaC)
        sub new(_listador  as AreasDeAccesoWebC, _lista as List(of AreasDeAccesoWebListaD.AreasDeAccesoWebListaC))
           me.Listador =_listador 
           me.Lista =_lista 
        End sub
      End Class
      Public Shared _SeccionID As String = "d62290ec-652d-4afd-933e-695235972ff1"
      Public Shared _SeccionIDGUID As New Guid("d62290ec-652d-4afd-933e-695235972ff1")
      Public Shared Async Function ConsultarDatos_Async(Parametros As SeccionConsultaParametrosC) As Task(Of List(Of AreasDeAccesoWebC )) 
          Dim R As New List(Of AreasDeAccesoWebC )  
          Dim d = Await Parametros.DinaupSesion.ConexionServidor.Funcion_Datos_Recibir_Async(AreasDeAccesoWebES._SeccionID, False, Parametros) 
          If d.Datos.TieneDatos Then 
              For Each Actual In d.Datos 
                  Dim Valores_Listador = Actual.Value.Item1
                  Dim Obj_Listador As New AreasDeAccesoWebC 
                  Obj_Listador.CargarDatos(Valores_Listador) 
                  Obj_Listador.CargaInterna(Actual.Value)
                  R.Add(Obj_Listador) 
              Next 
          End If 
          Return R 
      End Function 
      Public Shared Async Function ConsultarDatos_ConLista_Async(  Parametros As SeccionConsultaParametrosC ) As Task(Of List(Of  AreasDeAccesoWeb_ConListaC)) 
          Dim R As New List(Of AreasDeAccesoWeb_ConListaC )  
          Dim d =  Await Parametros.DinaupSesion.ConexionServidor.Funcion_Datos_Recibir_Async(AreasDeAccesoWebES._SeccionID, True, Parametros) 
          If d.Datos.TieneDatos Then 
              For Each Actual In d.Datos 
                  Dim Valores_Listador = Actual.Value.Item1
                  Dim Valores_Lista = Actual.Value.Item2
                  Dim Obj_Listador As New AreasDeAccesoWebC 
                  Obj_Listador.CargarDatos(Valores_Listador) 
                  Obj_Listador.CargaInterna(Actual.Value)
                  Dim Objs_Listas As New List(Of AreasDeAccesoWebListaD.AreasDeAccesoWebListaC) 
                  If Valores_Lista.TieneDatos Then  
                      For Each ValoresLista In Valores_Lista 
                         Dim nItem As New AreasDeAccesoWebListaD.AreasDeAccesoWebListaC 
                         nItem.CargarDatos(ValoresLista)   
                         Objs_Listas.Add(nItem)         
                      Next   
                  End If   
                  R.Add(New AreasDeAccesoWeb_ConListaC(Obj_Listador, Objs_Listas))
              Next 
          End If 
          Return R 
      End Function 
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As AreasDeAccesoWebC, Optional CampoWhere$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Return Await DatosGuardar_Async(DinaupSesion, New List(Of AreasDeAccesoWebC)({DAtos}), CampoWhere )
      End Function
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As List(Of AreasDeAccesoWebC), Optional CampoWhere$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Dim Importar As New List(Of DinaupAPI_ImportacionProcesableC)
          For Each Actual In DAtos 
              Dim RegistroActual = New DinaupAPI_ImportacionProcesableC() 
               RegistroActual.dinaup_listador_datos = Actual.ToDic 
               Importar.Add(RegistroActual)  
          Next 
          Return Await DinaupSesion.ConexionServidor.Funcion_Importar_Ejecutar_Async(DinaupSesion, AreasDeAccesoWebES._SeccionID, Importar, CampoWhere, "") 
      End Function
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As AreasDeAccesoWeb_ConListaC, Optional CampoWhere$ = "id", Optional CampoWhereLista$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
          Return Await DatosGuardar_Async(DinaupSesion, New List(Of AreasDeAccesoWeb_ConListaC)({DAtos}), CampoWhere, CampoWhereLista)
      End Function
      Public Shared Async Function DatosGuardar_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, DAtos As List(Of AreasDeAccesoWeb_ConListaC), Optional CampoWhere$ = "id", Optional CampoWhereLista$ = "id") As Task(Of HTTPRespuestaAPIC_Formualario_GuardarC)
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
          Return Await DinaupSesion.ConexionServidor.Funcion_Importar_Ejecutar_Async(DinaupSesion, AreasDeAccesoWebES._SeccionID, Importar, CampoWhere, CampoWhereLista) 
      End Function
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As AreasDeAccesoWeb_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, AreasDeAccesoWebES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New AreasDeAccesoWeb_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As AreasDeAccesoWeb_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, AreasDeAccesoWebES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New AreasDeAccesoWeb_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class AreasDeAccesoWebES
          Public shared _SeccionID as Guid = New Guid("d62290ec-652d-4afd-933e-695235972ff1")
          Public shared _Tabla$ = "tpr_536e7f7wd"
      Public Shared ReferenciaDestinador$ = "pr_14630fca3fx2fwd"
      Public Shared HoraLocal$ = "pr_776af12wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_1463149566h1e3wd"
      Public Shared ReferenciaFuncionAPIParaLoginObsoleto$ = "pr_148e29b6c0xd0wd"
      Public Shared DireccionWebURL$ = "pr_145f025afcx1cawd"
      Public Shared ReferenciaFuncionAPIParaNoEncontradasObsoleto$ = "pr_148e269484x12bwd"
      Public Shared FechaAlta_UTC$ = "pr_14c9f3d61fg31dwd"
      Public Shared ExportarEnModulos$ = "pr_14630fc9d2x180wd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_14630fc95fgacwd"
      Public Shared ReferenciaFuncionAPIParaErrorGenericoObsoleto$ = "pr_148e279b2fx111wd"
      Public Shared APIKey$ = "pr_148e42ba7ex1efwd"
      Public Shared DireccionesIPEnListaBlanca$ = "pr_60040138065"
      Public Shared TodasLasConexionesLocalesObsoleto$ = "pr_60040138064"
      Public Shared ActivarListaBlanca$ = "pr_60040138063"
      Public Shared EmpleadoPorDefectoDeSolicitudesObsoletoTieneAccesoWeb$ = "pr_20040140786"
      Public Shared ReferenciaUbicacionPorDefectoObsoleto$ = "pr_20040140787"
      Public Shared ReferenciaEmpleadoPorDefectoDeSolicitudesObsoleto$ = "pr_20040140785"
      Public Shared ReferenciaServidor$ = "pr_20040212264"
      Public Shared ReferenciaEmpresaPorDefectoObsoleto$ = "pr_40040371423"
      Public Shared DireccionCDN$ = "pr_20040433039"
      Public Shared ReferenciaCorreoNotificaciones$ = "pr_10040474833"
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
      Public Class AreasDeAccesoWebC
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
          <DisplayName("Función API para: Login (Obsoleto)")>
          Public Property ReferenciaFuncionAPIParaLoginObsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaFuncionAPIParaLoginObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaFuncionAPIParaLoginObsoleto"",""etiqueta"": ""Función API para: Login (Obsoleto)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""impresionhtml"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Función API para: Login (Obsoleto)"",""descripcion"": """",""keyword"": ""ReferenciaFuncionAPIParaLoginObsoleto"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaFuncionAPIParaLoginObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaFuncionAPIParaLoginObsoleto
          <DisplayName("Dirección Web (Opcional)")>
          Public Property DireccionWebURL As String
          Public Shared ___DireccionWebURL As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DireccionWebURL"",""etiqueta"": ""Dirección Web (Opcional)"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Dirección Web (Opcional)"",""descripcion"": """",""keyword"": ""DireccionWebURL"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DireccionWebURL As DinaNETCore.APID.DinaupAPI_CampoC = ___DireccionWebURL
          <DisplayName("Función API para: no encontradas (Obsoleto)")>
          Public Property ReferenciaFuncionAPIParaNoEncontradasObsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaFuncionAPIParaNoEncontradasObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaFuncionAPIParaNoEncontradasObsoleto"",""etiqueta"": ""Función API para: no encontradas (Obsoleto)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""impresionhtml"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Función API para: no encontradas (Obsoleto)"",""descripcion"": """",""keyword"": ""ReferenciaFuncionAPIParaNoEncontradasObsoleto"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaFuncionAPIParaNoEncontradasObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaFuncionAPIParaNoEncontradasObsoleto
          <DisplayName("Fecha Alta del registro")>
          Public Property FechaAlta_UTC As Date?
          Public Shared ___FechaAlta_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaAlta_UTC"",""etiqueta"": ""Fecha Alta del registro"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Alta del registro"",""descripcion"": """",""keyword"": ""FechaAlta_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaAlta_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaAlta_UTC
          <DisplayName("Autor del alta")>
          Public Property ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaAutorDelAlta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaAutorDelAlta"",""etiqueta"": ""Autor del alta"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": true,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta"",""descripcion"": """",""keyword"": ""ReferenciaAutorDelAlta"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaAutorDelAlta
          <DisplayName("Función API para: Error genérico (Obsoleto)")>
          Public Property ReferenciaFuncionAPIParaErrorGenericoObsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaFuncionAPIParaErrorGenericoObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaFuncionAPIParaErrorGenericoObsoleto"",""etiqueta"": ""Función API para: Error genérico (Obsoleto)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""impresionhtml"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Función API para: Error genérico (Obsoleto)"",""descripcion"": """",""keyword"": ""ReferenciaFuncionAPIParaErrorGenericoObsoleto"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaFuncionAPIParaErrorGenericoObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaFuncionAPIParaErrorGenericoObsoleto
          <DisplayName("API Key")>
          Public Property APIKey As String
          Public Shared ___APIKey As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""APIKey"",""etiqueta"": ""API Key"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""API Key"",""descripcion"": """",""keyword"": ""APIKey"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __APIKey As DinaNETCore.APID.DinaupAPI_CampoC = ___APIKey
          <Description("Direcciones IP separadas por salto de linea" & vbCrLf & "Ej:" & vbCrLf & "192.168.1.10" & vbCrLf & "192.*")>
          <DisplayName("Direcciones IP en lista blanca")>
          Public Property DireccionesIPEnListaBlanca As String
          Public Shared ___DireccionesIPEnListaBlanca As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DireccionesIPEnListaBlanca"",""etiqueta"": ""Direcciones IP en lista blanca"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 50,""decimales"": ""0"",""multilinea"": true,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Direcciones IP en lista blanca"",""descripcion"": """",""keyword"": ""DireccionesIPEnListaBlanca"",""formato"": 5,""rol"": 50,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DireccionesIPEnListaBlanca As DinaNETCore.APID.DinaupAPI_CampoC = ___DireccionesIPEnListaBlanca
          <DisplayName("Todas las conexiones locales (Obsoleto)")>
          Public Property TodasLasConexionesLocalesObsoleto As Boolean
          Public Shared ___TodasLasConexionesLocalesObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TodasLasConexionesLocalesObsoleto"",""etiqueta"": ""Todas las conexiones locales (Obsoleto)"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Todas las conexiones locales (Obsoleto)"",""descripcion"": """",""keyword"": ""TodasLasConexionesLocalesObsoleto"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __TodasLasConexionesLocalesObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___TodasLasConexionesLocalesObsoleto
          <DisplayName("Activar lista blanca")>
          Public Property ActivarListaBlanca As Boolean
          Public Shared ___ActivarListaBlanca As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ActivarListaBlanca"",""etiqueta"": ""Activar lista blanca"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Activar lista blanca"",""descripcion"": """",""keyword"": ""ActivarListaBlanca"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ActivarListaBlanca As DinaNETCore.APID.DinaupAPI_CampoC = ___ActivarListaBlanca
          <DisplayName("Empleado por defecto de solicitudes (Obsoleto) Tiene Acceso web")>
          Public Property EmpleadoPorDefectoDeSolicitudesObsoletoTieneAccesoWeb As Boolean
          Public Shared ___EmpleadoPorDefectoDeSolicitudesObsoletoTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EmpleadoPorDefectoDeSolicitudesObsoletoTieneAccesoWeb"",""etiqueta"": ""Empleado por defecto de solicitudes (Obsoleto) Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empleado por defecto de solicitudes (Obsoleto) Tiene Acceso web"",""descripcion"": """",""keyword"": ""EmpleadoPorDefectoDeSolicitudesObsoletoTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EmpleadoPorDefectoDeSolicitudesObsoletoTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___EmpleadoPorDefectoDeSolicitudesObsoletoTieneAccesoWeb
          <DisplayName("Ubicación por defecto (Obsoleto)")>
          Public Property ReferenciaUbicacionPorDefectoObsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaUbicacionPorDefectoObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaUbicacionPorDefectoObsoleto"",""etiqueta"": ""Ubicación por defecto (Obsoleto)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""bffd6c6e-a75b-455f-8367-067e7bb2fb47"",""titulo"": ""Base - Ubicaciones"",""iconoid"": ""b985b58f-7275-46b8-9b66-2c54346b0185"",""etiquetasingular"": ""Ubicación"",""etiquetaplural"": ""Ubicaciones"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""bffd6c6e-a75b-455f-8367-067e7bb2fb47"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Ubicación por defecto (Obsoleto)"",""descripcion"": """",""keyword"": ""ReferenciaUbicacionPorDefectoObsoleto"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaUbicacionPorDefectoObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaUbicacionPorDefectoObsoleto
          <DisplayName("Empleado por defecto de solicitudes (Obsoleto)")>
          Public Property ReferenciaEmpleadoPorDefectoDeSolicitudesObsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaEmpleadoPorDefectoDeSolicitudesObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaEmpleadoPorDefectoDeSolicitudesObsoleto"",""etiqueta"": ""Empleado por defecto de solicitudes (Obsoleto)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""c6e071c7-776f-4300-aa55-c711fd1da916"",""titulo"": ""Empleados"",""iconoid"": ""1c8abf82-640c-4d18-b62c-89de310923dd"",""etiquetasingular"": ""Empleado"",""etiquetaplural"": ""Empleados"",""etiquetaesfemenino"": false,""contienelista"": false,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""c6e071c7-776f-4300-aa55-c711fd1da916"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empleado por defecto de solicitudes (Obsoleto)"",""descripcion"": """",""keyword"": ""ReferenciaEmpleadoPorDefectoDeSolicitudesObsoleto"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaEmpleadoPorDefectoDeSolicitudesObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaEmpleadoPorDefectoDeSolicitudesObsoleto
          <DisplayName("Servidor")>
          Public Property ReferenciaServidor As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaServidor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaServidor"",""etiqueta"": ""Servidor"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""eadd8f25-d9e0-46ef-89a7-e95efe769df1"",""titulo"": ""Base - Servidores"",""iconoid"": ""35aab678-4c97-4349-9cad-b4e5b4d301a3"",""etiquetasingular"": ""Servidor"",""etiquetaplural"": ""Servidores"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""eadd8f25-d9e0-46ef-89a7-e95efe769df1"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Servidor"",""descripcion"": """",""keyword"": ""ReferenciaServidor"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaServidor As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaServidor
          <DisplayName("Empresa por defecto (Obsoleto)")>
          Public Property ReferenciaEmpresaPorDefectoObsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaEmpresaPorDefectoObsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaEmpresaPorDefectoObsoleto"",""etiqueta"": ""Empresa por defecto (Obsoleto)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""9d1bb1b3-06e1-425b-bd5a-1d03bae37094"",""titulo"": ""Base - Empresas administradas"",""iconoid"": ""b788149e-1c15-4807-9a25-72adf3333e5b"",""etiquetasingular"": ""Empresa administrada"",""etiquetaplural"": ""Empresas administradas"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""9d1bb1b3-06e1-425b-bd5a-1d03bae37094"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empresa por defecto (Obsoleto)"",""descripcion"": """",""keyword"": ""ReferenciaEmpresaPorDefectoObsoleto"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaEmpresaPorDefectoObsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaEmpresaPorDefectoObsoleto
          <DisplayName("Dirección CDN")>
          Public Property DireccionCDN As String
          Public Shared ___DireccionCDN As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DireccionCDN"",""etiqueta"": ""Dirección CDN"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 1,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Dirección CDN"",""descripcion"": """",""keyword"": ""DireccionCDN"",""formato"": 5,""rol"": 1,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DireccionCDN As DinaNETCore.APID.DinaupAPI_CampoC = ___DireccionCDN
          <DisplayName("Correo notificaciones")>
          Public Property ReferenciaCorreoNotificaciones As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaCorreoNotificaciones As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaCorreoNotificaciones"",""etiqueta"": ""Correo notificaciones"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""e80ad188-9d6d-4b05-a7fb-e498cef51598"",""titulo"": ""Base - Cuentas de Correo electrónico"",""iconoid"": ""5fd758a4-dbc3-4365-ad56-18af81075b78"",""etiquetasingular"": ""Cuenta de correo electrónico"",""etiquetaplural"": ""Cuentas de Correo electrónico"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""e80ad188-9d6d-4b05-a7fb-e498cef51598"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Correo notificaciones"",""descripcion"": """",""keyword"": ""ReferenciaCorreoNotificaciones"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaCorreoNotificaciones As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaCorreoNotificaciones
          <ReadOnlyAttribute(True)>
          <DisplayName("ID")>
          Public Property ID As Guid
          Public Shared ___ID As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": true,""eseliminado"": false,""keyword"": ""ID"",""etiqueta"": ""ID"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""d62290ec-652d-4afd-933e-695235972ff1"",""titulo"": ""Áreas de acceso web"",""iconoid"": ""d884fc46-9c8e-41cb-b744-ffcb56476168"",""etiquetasingular"": ""Área de acceso web"",""etiquetaplural"": ""Áreas de acceso web"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": false,""puedeagregar"": false},""seccionrelacionadaid"": ""d62290ec-652d-4afd-933e-695235972ff1"",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""ID"",""descripcion"": """",""keyword"": ""ID"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ID As DinaNETCore.APID.DinaupAPI_CampoC = ___ID
          <DisplayName("Área")>
          Public Property TextoPrincipal As String
          Public Shared ___TextoPrincipal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TextoPrincipal"",""etiqueta"": ""Área"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Área"",""descripcion"": """",""keyword"": ""TextoPrincipal"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
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
          me.ReferenciaDestinador = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_14630fca3fx2fwd"), _Datos.Leer_String("pr_14630fca3fx2fwd.nombre"))
          me.HoraLocal = _Datos.Leer_Time_Nulable("pr_776af12wd")
          me.AutorDelAltaTieneAccesoWeb = _Datos.Leer_Boolean("pr_1463149566h1e3wd")
          me.ReferenciaFuncionAPIParaLoginObsoleto = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_148e29b6c0xd0wd"), _Datos.Leer_String("pr_148e29b6c0xd0wd.nombre"))
          me.DireccionWebURL = _Datos.Leer_String("pr_145f025afcx1cawd")
          me.ReferenciaFuncionAPIParaNoEncontradasObsoleto = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_148e269484x12bwd"), _Datos.Leer_String("pr_148e269484x12bwd.nombre"))
          me.FechaAlta_UTC = _Datos.Leer_DateTime_Nulable("pr_14c9f3d61fg31dwd")
          me.ReferenciaAutorDelAlta = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_14630fc95fgacwd"), _Datos.Leer_String("pr_14630fc95fgacwd.nombre"))
          me.ReferenciaFuncionAPIParaErrorGenericoObsoleto = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_148e279b2fx111wd"), _Datos.Leer_String("pr_148e279b2fx111wd.nombre"))
          me.APIKey = _Datos.Leer_String("pr_148e42ba7ex1efwd")
          me.DireccionesIPEnListaBlanca = _Datos.Leer_String("pr_60040138065")
          me.TodasLasConexionesLocalesObsoleto = _Datos.Leer_Boolean("pr_60040138064")
          me.ActivarListaBlanca = _Datos.Leer_Boolean("pr_60040138063")
          me.EmpleadoPorDefectoDeSolicitudesObsoletoTieneAccesoWeb = _Datos.Leer_Boolean("pr_20040140786")
          me.ReferenciaUbicacionPorDefectoObsoleto = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_20040140787"), _Datos.Leer_String("pr_20040140787.nombre"))
          me.ReferenciaEmpleadoPorDefectoDeSolicitudesObsoleto = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_20040140785"), _Datos.Leer_String("pr_20040140785.nombre"))
          me.ReferenciaServidor = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_20040212264"), _Datos.Leer_String("pr_20040212264.nombre"))
          me.ReferenciaEmpresaPorDefectoObsoleto = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_40040371423"), _Datos.Leer_String("pr_40040371423.nombre"))
          me.DireccionCDN = _Datos.Leer_String("pr_20040433039")
          me.ReferenciaCorreoNotificaciones = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_10040474833"), _Datos.Leer_String("pr_10040474833.nombre"))
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
           R.add("pr_14630fca3fx2fwd",me.ReferenciaDestinador.ID.STR())
         Else
           R.add("pr_14630fca3fx2fwd","")
         End if
         R.add("pr_776af12wd", me.HoraLocal.AdaptarMySQL_Time_Nulable())
         R.add("pr_1463149566h1e3wd", me.AutorDelAltaTieneAccesoWeb.AdaptarMySQL_Boolean())
         If Me.ReferenciaFuncionAPIParaLoginObsoleto IsNot nothing then
           R.add("pr_148e29b6c0xd0wd",me.ReferenciaFuncionAPIParaLoginObsoleto.ID.STR())
         Else
           R.add("pr_148e29b6c0xd0wd","")
         End if
         R.add("pr_145f025afcx1cawd", me.DireccionWebURL.AdaptarMySQL_String())
         If Me.ReferenciaFuncionAPIParaNoEncontradasObsoleto IsNot nothing then
           R.add("pr_148e269484x12bwd",me.ReferenciaFuncionAPIParaNoEncontradasObsoleto.ID.STR())
         Else
           R.add("pr_148e269484x12bwd","")
         End if
         R.add("pr_14c9f3d61fg31dwd", me.FechaAlta_UTC.AdaptarMySQL_DateTime_Nulable())
         If Me.ReferenciaAutorDelAlta IsNot nothing then
           R.add("pr_14630fc95fgacwd",me.ReferenciaAutorDelAlta.ID.STR())
         Else
           R.add("pr_14630fc95fgacwd","")
         End if
         If Me.ReferenciaFuncionAPIParaErrorGenericoObsoleto IsNot nothing then
           R.add("pr_148e279b2fx111wd",me.ReferenciaFuncionAPIParaErrorGenericoObsoleto.ID.STR())
         Else
           R.add("pr_148e279b2fx111wd","")
         End if
         R.add("pr_148e42ba7ex1efwd", me.APIKey.AdaptarMySQL_String())
         R.add("pr_60040138065", me.DireccionesIPEnListaBlanca.AdaptarMySQL_String())
         R.add("pr_60040138064", me.TodasLasConexionesLocalesObsoleto.AdaptarMySQL_Boolean())
         R.add("pr_60040138063", me.ActivarListaBlanca.AdaptarMySQL_Boolean())
         R.add("pr_20040140786", me.EmpleadoPorDefectoDeSolicitudesObsoletoTieneAccesoWeb.AdaptarMySQL_Boolean())
         If Me.ReferenciaUbicacionPorDefectoObsoleto IsNot nothing then
           R.add("pr_20040140787",me.ReferenciaUbicacionPorDefectoObsoleto.ID.STR())
         Else
           R.add("pr_20040140787","")
         End if
         If Me.ReferenciaEmpleadoPorDefectoDeSolicitudesObsoleto IsNot nothing then
           R.add("pr_20040140785",me.ReferenciaEmpleadoPorDefectoDeSolicitudesObsoleto.ID.STR())
         Else
           R.add("pr_20040140785","")
         End if
         If Me.ReferenciaServidor IsNot nothing then
           R.add("pr_20040212264",me.ReferenciaServidor.ID.STR())
         Else
           R.add("pr_20040212264","")
         End if
         If Me.ReferenciaEmpresaPorDefectoObsoleto IsNot nothing then
           R.add("pr_40040371423",me.ReferenciaEmpresaPorDefectoObsoleto.ID.STR())
         Else
           R.add("pr_40040371423","")
         End if
         R.add("pr_20040433039", me.DireccionCDN.AdaptarMySQL_String())
         If Me.ReferenciaCorreoNotificaciones IsNot nothing then
           R.add("pr_10040474833",me.ReferenciaCorreoNotificaciones.ID.STR())
         Else
           R.add("pr_10040474833","")
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
      Public Class AreasDeAccesoWeb_FormularioC
        Inherits DinaNETCore.VentanaVirtualC

    Public _Lista As List(Of AreasDeAccesoWebListaD.AreasDeAccesoWebLista_FormularioC)



    Overrides Sub Evento_Actualizar()

        If Me.EsListador Then
            Dim FormLista = Me.__VV__.Formularios_Lista
            Dim CreandoLista As New List(Of AreasDeAccesoWebListaD.AreasDeAccesoWebLista_FormularioC)
            If FormLista IsNot Nothing Then
                For i = 0 To FormLista.Count - 1
                    Dim ElementoLista As New AreasDeAccesoWebListaD.AreasDeAccesoWebLista_FormularioC(Me.__VV__, FormLista(i).Token)
                    CreandoLista.Add(ElementoLista)
                Next
            End If
            _Lista = CreandoLista
        End If

    End Sub

                  


        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_14630fca3fx2fwd")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As DateTime
            get
                return me.GetValue_DateTime("pr_776af12wd")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_1463149566h1e3wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_1463149566h1e3wd", value)
            End Set
          End Property
          Public property ReferenciaFuncionAPIParaLoginObsoleto As Guid
            get
                return me.GetValue_Guid("pr_148e29b6c0xd0wd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_148e29b6c0xd0wd", value)
            End Set
          End Property
          Public property DireccionWebURL As String
            get
                return me.GetValue_String("pr_145f025afcx1cawd")
            End Get
            Set(value As String)
                me.SetValue_String("pr_145f025afcx1cawd", value)
            End Set
          End Property
          Public property ReferenciaFuncionAPIParaNoEncontradasObsoleto As Guid
            get
                return me.GetValue_Guid("pr_148e269484x12bwd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_148e269484x12bwd", value)
            End Set
          End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_14c9f3d61fg31dwd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_14c9f3d61fg31dwd", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_14630fc95fgacwd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_14630fc95fgacwd", value)
            End Set
          End Property
          Public property ReferenciaFuncionAPIParaErrorGenericoObsoleto As Guid
            get
                return me.GetValue_Guid("pr_148e279b2fx111wd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_148e279b2fx111wd", value)
            End Set
          End Property
        Public ReadOnly property APIKey As String
            get
                return me.GetValue_String("pr_148e42ba7ex1efwd")
            End Get   
        End Property
          Public property DireccionesIPEnListaBlanca As String
            get
                return me.GetValue_String("pr_60040138065")
            End Get
            Set(value As String)
                me.SetValue_String("pr_60040138065", value)
            End Set
          End Property
          Public property TodasLasConexionesLocalesObsoleto As Boolean
            get
                return me.GetValue_Boolean("pr_60040138064")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_60040138064", value)
            End Set
          End Property
          Public property ActivarListaBlanca As Boolean
            get
                return me.GetValue_Boolean("pr_60040138063")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_60040138063", value)
            End Set
          End Property
          Public property EmpleadoPorDefectoDeSolicitudesObsoletoTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_20040140786")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_20040140786", value)
            End Set
          End Property
          Public property ReferenciaUbicacionPorDefectoObsoleto As Guid
            get
                return me.GetValue_Guid("pr_20040140787")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_20040140787", value)
            End Set
          End Property
          Public property ReferenciaEmpleadoPorDefectoDeSolicitudesObsoleto As Guid
            get
                return me.GetValue_Guid("pr_20040140785")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_20040140785", value)
            End Set
          End Property
          Public property ReferenciaServidor As Guid
            get
                return me.GetValue_Guid("pr_20040212264")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_20040212264", value)
            End Set
          End Property
          Public property ReferenciaEmpresaPorDefectoObsoleto As Guid
            get
                return me.GetValue_Guid("pr_40040371423")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_40040371423", value)
            End Set
          End Property
          Public property DireccionCDN As String
            get
                return me.GetValue_String("pr_20040433039")
            End Get
            Set(value As String)
                me.SetValue_String("pr_20040433039", value)
            End Set
          End Property
          Public property ReferenciaCorreoNotificaciones As Guid
            get
                return me.GetValue_Guid("pr_10040474833")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_10040474833", value)
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
