   Imports System.ComponentModel
   Imports DinaNETCore
   Imports DinaNETCore.APID
Partial Public Class SeccionesD
  Public Class EnviosProgramadosDeCorreosBaseD
      Public Class EnviosProgramadosDeCorreosBase_ConListaC
      Public Listador as EnviosProgramadosDeCorreosBaseC
      Public Lista As New List(of EnviosProgramadosDeCorreosBaseListaD.EnviosProgramadosDeCorreosBaseListaC)
        sub new(_listador  as EnviosProgramadosDeCorreosBaseC, _lista as List(of EnviosProgramadosDeCorreosBaseListaD.EnviosProgramadosDeCorreosBaseListaC))
           me.Listador =_listador 
           me.Lista =_lista 
        End sub
      End Class
      Public Shared _SeccionID As String = "44a58422-5df9-41a2-8af3-80675d611384"
      Public Shared _SeccionIDGUID As New Guid("44a58422-5df9-41a2-8af3-80675d611384")
      Public Shared Async Function ConsultarDatos_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, ParamArray Valor As String()) As Task(Of List(Of EnviosProgramadosDeCorreosBaseC )) 
          Dim R As New List(Of EnviosProgramadosDeCorreosBaseC )  
          Dim d = Await DinaupSesion.ConexionServidor.Funcion_Datos_Recibir_Async(DinaupSesion, EnviosProgramadosDeCorreosBaseES._SeccionID, False, Campo, Valor) 
          If d.Datos.TieneDatos Then 
              For Each Actual In d.Datos 
                  Dim Valores_Listador = Actual.Value.Item1
                  Dim Obj_Listador As New EnviosProgramadosDeCorreosBaseC 
                  Obj_Listador.CargarDatos(Valores_Listador) 
                  R.Add(Obj_Listador) 
              Next 
          End If 
          Return R 
      End Function 
      Public Shared Async Function ConsultarDatos_ConLista_Async(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, ParamArray Valor As String()) As Task(Of List(Of  EnviosProgramadosDeCorreosBase_ConListaC)) 
          Dim R As New List(Of EnviosProgramadosDeCorreosBase_ConListaC )  
          Dim d =  Await DinaupSesion.ConexionServidor.Funcion_Datos_Recibir_Async(DinaupSesion, EnviosProgramadosDeCorreosBaseES._SeccionID, True, Campo, Valor) 
          If d.Datos.TieneDatos Then 
              For Each Actual In d.Datos 
                  Dim Valores_Listador = Actual.Value.Item1
                  Dim Valores_Lista = Actual.Value.Item2
                  Dim Obj_Listador As New EnviosProgramadosDeCorreosBaseC 
                  Obj_Listador.CargarDatos(Valores_Listador) 
                  Dim Objs_Listas As New List(Of EnviosProgramadosDeCorreosBaseListaD.EnviosProgramadosDeCorreosBaseListaC) 
                  If Valores_Lista.TieneDatos Then  
                      For Each ValoresLista In Valores_Lista 
                         Dim nItem As New EnviosProgramadosDeCorreosBaseListaD.EnviosProgramadosDeCorreosBaseListaC 
                         nItem.CargarDatos(ValoresLista)   
                         Objs_Listas.Add(nItem)         
                      Next   
                  End If   
                  R.Add(New EnviosProgramadosDeCorreosBase_ConListaC(Obj_Listador, Objs_Listas))
              Next 
          End If 
          Return R 
      End Function 
      Public Class EnviosProgramadosDeCorreosBaseES
          Public shared _SeccionID as Guid = New Guid("44a58422-5df9-41a2-8af3-80675d611384")
          Public shared _Tabla$ = "tpr_30040163371002"
      Public Shared ReferenciaDestinador$ = "pr_30040163371036"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_30040163371029"
      Public Shared ReferenciaAutorDelAlta$ = "pr_30040163371031"
      Public Shared FechaAlta_UTC$ = "pr_30040163371035"
      Public Shared ExportarEnModulos$ = "pr_30040163371034"
      Public Shared HoraLocal$ = "pr_30040163371033"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_30040163371030"
      Public Shared FechaDato_UTC$ = "pr_30040163371032"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_30040163371047"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_30040163371048"
      Public Shared Asunto$ = "pr_30040163371049"
      Public Shared CorreoDeOrigen$ = "pr_30040163371051"
      Public Shared CorreoDestino$ = "pr_30040163371052"
      Public Shared ReferenciaInformeDeOrigen$ = "pr_30040163371053"
      Public Shared ReferenciaPlantillaDeCorreo$ = "pr_30040163371054"
      Public Shared ReintentosDeEnvio$ = "pr_40040163371"
      Public Shared ErrorDeEnvio$ = "pr_40040163372"
      Public Shared ReferenciaSeccionDeOrigen$ = "pr_40040163373"
      Public Shared ReferenciaRegistroDeOrigen$ = "pr_40040163374"
      Public Shared ReferenciaConfiguracionDeCorreoDeOrigen$ = "pr_20040164243"
      Public Shared EstadoDeEnvio$ = "pr_20040164244"
      Public Shared FechaDeUltimoIntentoFallido_UTC$ = "pr_30040164241"
      Public Shared FechaDeEnvio_UTC$ = "pr_30040164242"
      Public Shared HaSidoMarcadoComoCorreoNoDeseado$ = "pr_30040164243"
      Public Shared ReferenciaArchivo4Obsoleto$ = "pr_400401652136"
      Public Shared ReferenciaArchivo1Obsoleto$ = "pr_400401652137"
      Public Shared ReferenciaArchivo3$ = "pr_400401652138"
      Public Shared ReferenciaArchivo2Obsoleto$ = "pr_400401652139"
      Public Shared Contenido$ = "pr_30040163371050"
      Public Shared ReferenciaBuzon$ = "pr_30040257424"
      Public Shared CantidadDeArchivos$ = "pr_40040257421"
      Public Shared ReferenciaServidor$ = "pr_30040336411"
      Public Shared ResponderA$ = "pr_40040408072"
      Public Shared DireccionDeEnvioAlias$ = "pr_40040408073"
      Public Shared Autor$ = "pr_50040408086"
      Public Shared ReferenciaRespuestaA$ = "pr_40040452524"
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
      Public Class EnviosProgramadosDeCorreosBaseC
      Inherits Base_DatoC
          <DisplayName("Destinador")>
          Public Property ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaDestinador As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaDestinador"",""etiqueta"": ""Destinador"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""relacionesindirectas"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Destinador"",""descripcion"": """",""keyword"": ""ReferenciaDestinador"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaDestinador
          <DisplayName("Empleado")>
          Public Property ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaEmpleadoPrincipal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaEmpleadoPrincipal"",""etiqueta"": ""Empleado"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empleado"",""descripcion"": """",""keyword"": ""ReferenciaEmpleadoPrincipal"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaEmpleadoPrincipal
          <DisplayName("Autor del alta")>
          Public Property ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaAutorDelAlta As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaAutorDelAlta"",""etiqueta"": ""Autor del alta"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""titulo"": ""Base - Entidades"",""iconoid"": ""5d84d097-bef7-4628-89bf-22e584bc2dc8"",""etiquetasingular"": ""Entidad"",""etiquetaplural"": ""Entidades"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""dfd2c902-56e8-4200-90da-d429ff59dcee"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta"",""descripcion"": """",""keyword"": ""ReferenciaAutorDelAlta"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaAutorDelAlta
          <DisplayName("Fecha Alta del registro")>
          Public Property FechaAlta_UTC As Date?
          Public Shared ___FechaAlta_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaAlta_UTC"",""etiqueta"": ""Fecha Alta del registro"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Alta del registro"",""descripcion"": """",""keyword"": ""FechaAlta_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaAlta_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaAlta_UTC
          <DisplayName("Hora local")>
          Public Property HoraLocal As DateTime?
          Public Shared ___HoraLocal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""HoraLocal"",""etiqueta"": ""Hora local"",""oculta"": false,""formato"": 8,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Hora local"",""descripcion"": """",""keyword"": ""HoraLocal"",""formato"": 8,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __HoraLocal As DinaNETCore.APID.DinaupAPI_CampoC = ___HoraLocal
          <DisplayName("Ubicación Principal")>
          Public Property ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaUbicacionPrincipal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaUbicacionPrincipal"",""etiqueta"": ""Ubicación Principal"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""bffd6c6e-a75b-455f-8367-067e7bb2fb47"",""titulo"": ""Base - Ubicaciones"",""iconoid"": ""b985b58f-7275-46b8-9b66-2c54346b0185"",""etiquetasingular"": ""Ubicación"",""etiquetaplural"": ""Ubicaciones"",""etiquetaesfemenino"": true,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""bffd6c6e-a75b-455f-8367-067e7bb2fb47"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Ubicación Principal"",""descripcion"": """",""keyword"": ""ReferenciaUbicacionPrincipal"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaUbicacionPrincipal
          <DisplayName("Fecha Dato")>
          Public Property FechaDato_UTC As Date?
          Public Shared ___FechaDato_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaDato_UTC"",""etiqueta"": ""Fecha Dato"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 21,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": true,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha Dato"",""descripcion"": """",""keyword"": ""FechaDato_UTC"",""formato"": 6,""rol"": 21,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaDato_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaDato_UTC
          <DisplayName("Autor del alta Tiene Acceso web")>
          Public Property AutorDelAltaTieneAccesoWeb As Boolean
          Public Shared ___AutorDelAltaTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""AutorDelAltaTieneAccesoWeb"",""etiqueta"": ""Autor del alta Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor del alta Tiene Acceso web"",""descripcion"": """",""keyword"": ""AutorDelAltaTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __AutorDelAltaTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___AutorDelAltaTieneAccesoWeb
          <DisplayName("Empleado Tiene Acceso web")>
          Public Property EmpleadoTieneAccesoWeb As Boolean
          Public Shared ___EmpleadoTieneAccesoWeb As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EmpleadoTieneAccesoWeb"",""etiqueta"": ""Empleado Tiene Acceso web"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Empleado Tiene Acceso web"",""descripcion"": """",""keyword"": ""EmpleadoTieneAccesoWeb"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __EmpleadoTieneAccesoWeb As DinaNETCore.APID.DinaupAPI_CampoC = ___EmpleadoTieneAccesoWeb
          <DisplayName("Asunto")>
          Public Property Asunto As String
          Public Shared ___Asunto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Asunto"",""etiqueta"": ""Asunto"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Asunto"",""descripcion"": """",""keyword"": ""Asunto"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Asunto As DinaNETCore.APID.DinaupAPI_CampoC = ___Asunto
          <DisplayName("Correo de origen")>
          Public Property CorreoDeOrigen As String
          Public Shared ___CorreoDeOrigen As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CorreoDeOrigen"",""etiqueta"": ""Correo de origen"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 4,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Correo de origen"",""descripcion"": """",""keyword"": ""CorreoDeOrigen"",""formato"": 5,""rol"": 4,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CorreoDeOrigen As DinaNETCore.APID.DinaupAPI_CampoC = ___CorreoDeOrigen
          <DisplayName("Correo destino")>
          Public Property CorreoDestino As String
          Public Shared ___CorreoDestino As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CorreoDestino"",""etiqueta"": ""Correo destino"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 4,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Correo destino"",""descripcion"": """",""keyword"": ""CorreoDestino"",""formato"": 5,""rol"": 4,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CorreoDestino As DinaNETCore.APID.DinaupAPI_CampoC = ___CorreoDestino
          <DisplayName("Informe de origen")>
          Public Property ReferenciaInformeDeOrigen As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaInformeDeOrigen As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaInformeDeOrigen"",""etiqueta"": ""Informe de origen"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""informes"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Informe de origen"",""descripcion"": """",""keyword"": ""ReferenciaInformeDeOrigen"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaInformeDeOrigen As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaInformeDeOrigen
          <DisplayName("Plantilla de correo")>
          Public Property ReferenciaPlantillaDeCorreo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaPlantillaDeCorreo As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaPlantillaDeCorreo"",""etiqueta"": ""Plantilla de correo"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""impresionhtml"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Plantilla de correo"",""descripcion"": """",""keyword"": ""ReferenciaPlantillaDeCorreo"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaPlantillaDeCorreo As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaPlantillaDeCorreo
          <DisplayName("Reintentos de envío")>
          Public Property ReintentosDeEnvio As Integer
          Public Shared ___ReintentosDeEnvio As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReintentosDeEnvio"",""etiqueta"": ""Reintentos de envío"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Reintentos de envío"",""descripcion"": """",""keyword"": ""ReintentosDeEnvio"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReintentosDeEnvio As DinaNETCore.APID.DinaupAPI_CampoC = ___ReintentosDeEnvio
          <DisplayName("Error de envío")>
          Public Property ErrorDeEnvio As String
          Public Shared ___ErrorDeEnvio As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ErrorDeEnvio"",""etiqueta"": ""Error de envío"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Error de envío"",""descripcion"": """",""keyword"": ""ErrorDeEnvio"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ErrorDeEnvio As DinaNETCore.APID.DinaupAPI_CampoC = ___ErrorDeEnvio
          <DisplayName("Sección de Origen")>
          Public Property ReferenciaSeccionDeOrigen As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaSeccionDeOrigen As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaSeccionDeOrigen"",""etiqueta"": ""Sección de Origen"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""plantillasp"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Sección de Origen"",""descripcion"": """",""keyword"": ""ReferenciaSeccionDeOrigen"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaSeccionDeOrigen As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaSeccionDeOrigen
          <DisplayName("Registro de origen")>
          Public Property ReferenciaRegistroDeOrigen As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaRegistroDeOrigen As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaRegistroDeOrigen"",""etiqueta"": ""Registro de origen"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Registro de origen"",""descripcion"": """",""keyword"": ""ReferenciaRegistroDeOrigen"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaRegistroDeOrigen As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaRegistroDeOrigen
          <DisplayName("Configuración de correo de origen")>
          Public Property ReferenciaConfiguracionDeCorreoDeOrigen As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaConfiguracionDeCorreoDeOrigen As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaConfiguracionDeCorreoDeOrigen"",""etiqueta"": ""Configuración de correo de origen"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""e80ad188-9d6d-4b05-a7fb-e498cef51598"",""titulo"": ""Base - Cuentas de Correo electrónico"",""iconoid"": ""5fd758a4-dbc3-4365-ad56-18af81075b78"",""etiquetasingular"": ""Cuenta de correo electrónico"",""etiquetaplural"": ""Cuentas de Correo electrónico"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""e80ad188-9d6d-4b05-a7fb-e498cef51598"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Configuración de correo de origen"",""descripcion"": """",""keyword"": ""ReferenciaConfiguracionDeCorreoDeOrigen"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaConfiguracionDeCorreoDeOrigen As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaConfiguracionDeCorreoDeOrigen
          <DisplayName("Estado de envío")>
          Public Property EstadoDeEnvio As EnumTramitacionE
          Public Shared ___EstadoDeEnvio As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""EstadoDeEnvio"",""etiqueta"": ""Estado de envío"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 48,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [0,1,2,3],""predefinidos_textos"": [""Indefinido"",""Pendiente"",""Tramitado"",""Cancelado""],""predefinidos_iconos"": [""https://cdn.dinaup.com/ico/enums/48_0.png"",""https://cdn.dinaup.com/ico/enums/48_1.png"",""https://cdn.dinaup.com/ico/enums/48_2.png"",""https://cdn.dinaup.com/ico/enums/48_3.png""],""filtro"": {""titulo"": ""Estado de envío"",""descripcion"": """",""keyword"": ""EstadoDeEnvio"",""formato"": 2,""rol"": 48,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false,""enumeracion"": {""titulo"": ""Enum - Tramitación"", ""valores"": [{""valor"": 0, ""titulo"": ""Indefinido""},{""valor"": 1, ""titulo"": ""Pendiente""},{""valor"": 2, ""titulo"": ""Tramitado""},{""valor"": 3, ""titulo"": ""Cancelado""}]}},""solovalorespredefinidos"": true}")
          Public  __EstadoDeEnvio As DinaNETCore.APID.DinaupAPI_CampoC = ___EstadoDeEnvio
          <DisplayName("Fecha de último intento fallido")>
          Public Property FechaDeUltimoIntentoFallido_UTC As Date?
          Public Shared ___FechaDeUltimoIntentoFallido_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaDeUltimoIntentoFallido_UTC"",""etiqueta"": ""Fecha de último intento fallido"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 22,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha de último intento fallido"",""descripcion"": """",""keyword"": ""FechaDeUltimoIntentoFallido_UTC"",""formato"": 6,""rol"": 22,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaDeUltimoIntentoFallido_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaDeUltimoIntentoFallido_UTC
          <DisplayName("Fecha de envío")>
          Public Property FechaDeEnvio_UTC As Date?
          Public Shared ___FechaDeEnvio_UTC As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""FechaDeEnvio_UTC"",""etiqueta"": ""Fecha de envío"",""oculta"": false,""formato"": 6,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 22,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": true,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Fecha de envío"",""descripcion"": """",""keyword"": ""FechaDeEnvio_UTC"",""formato"": 6,""rol"": 22,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": true},""solovalorespredefinidos"": false}")
          Public  __FechaDeEnvio_UTC As DinaNETCore.APID.DinaupAPI_CampoC = ___FechaDeEnvio_UTC
          <DisplayName("Ha sido marcado como Correo no deseado")>
          Public Property HaSidoMarcadoComoCorreoNoDeseado As Boolean
          Public Shared ___HaSidoMarcadoComoCorreoNoDeseado As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""HaSidoMarcadoComoCorreoNoDeseado"",""etiqueta"": ""Ha sido marcado como Correo no deseado"",""oculta"": false,""formato"": 1,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Ha sido marcado como Correo no deseado"",""descripcion"": """",""keyword"": ""HaSidoMarcadoComoCorreoNoDeseado"",""formato"": 1,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __HaSidoMarcadoComoCorreoNoDeseado As DinaNETCore.APID.DinaupAPI_CampoC = ___HaSidoMarcadoComoCorreoNoDeseado
          <DisplayName("Archivo 4 (Obsoleto)")>
          Public Property ReferenciaArchivo4Obsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaArchivo4Obsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaArchivo4Obsoleto"",""etiqueta"": ""Archivo 4 (Obsoleto)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""imagenes"",""rol"": 8,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Archivo 4 (Obsoleto)"",""descripcion"": """",""keyword"": ""ReferenciaArchivo4Obsoleto"",""formato"": 9,""rol"": 8,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaArchivo4Obsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaArchivo4Obsoleto
          <DisplayName("Archivo 1 (Obsoleto)")>
          Public Property ReferenciaArchivo1Obsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaArchivo1Obsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaArchivo1Obsoleto"",""etiqueta"": ""Archivo 1 (Obsoleto)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""imagenes"",""rol"": 8,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Archivo 1 (Obsoleto)"",""descripcion"": """",""keyword"": ""ReferenciaArchivo1Obsoleto"",""formato"": 9,""rol"": 8,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaArchivo1Obsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaArchivo1Obsoleto
          <DisplayName("Archivo 3")>
          Public Property ReferenciaArchivo3 As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaArchivo3 As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaArchivo3"",""etiqueta"": ""Archivo 3"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""imagenes"",""rol"": 8,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Archivo 3"",""descripcion"": """",""keyword"": ""ReferenciaArchivo3"",""formato"": 9,""rol"": 8,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaArchivo3 As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaArchivo3
          <DisplayName("Archivo 2 (Obsoleto)")>
          Public Property ReferenciaArchivo2Obsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaArchivo2Obsoleto As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaArchivo2Obsoleto"",""etiqueta"": ""Archivo 2 (Obsoleto)"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": ""imagenes"",""rol"": 8,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Archivo 2 (Obsoleto)"",""descripcion"": """",""keyword"": ""ReferenciaArchivo2Obsoleto"",""formato"": 9,""rol"": 8,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaArchivo2Obsoleto As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaArchivo2Obsoleto
          <DisplayName("Contenido")>
          Public Property Contenido As String
          Public Shared ___Contenido As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Contenido"",""etiqueta"": ""Contenido"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 65,""decimales"": ""0"",""multilinea"": true,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Contenido"",""descripcion"": """",""keyword"": ""Contenido"",""formato"": 5,""rol"": 65,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Contenido As DinaNETCore.APID.DinaupAPI_CampoC = ___Contenido
          <DisplayName("Buzón")>
          Public Property ReferenciaBuzon As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaBuzon As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaBuzon"",""etiqueta"": ""Buzón"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""7e428fbb-1432-4807-b4d3-739346f15f37"",""titulo"": ""Base - Buzones de correo"",""iconoid"": ""a56f7a66-b0cd-4c38-ae69-d85b1c4ac09a"",""etiquetasingular"": ""Buzón de correos"",""etiquetaplural"": ""Buzones de correo"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""7e428fbb-1432-4807-b4d3-739346f15f37"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Buzón"",""descripcion"": """",""keyword"": ""ReferenciaBuzon"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaBuzon As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaBuzon
          <DisplayName("Cantidad de archivos")>
          Public Property CantidadDeArchivos As Integer
          Public Shared ___CantidadDeArchivos As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""CantidadDeArchivos"",""etiqueta"": ""Cantidad de archivos"",""oculta"": false,""formato"": 2,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Cantidad de archivos"",""descripcion"": """",""keyword"": ""CantidadDeArchivos"",""formato"": 2,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __CantidadDeArchivos As DinaNETCore.APID.DinaupAPI_CampoC = ___CantidadDeArchivos
          <DisplayName("Servidor")>
          Public Property ReferenciaServidor As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaServidor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaServidor"",""etiqueta"": ""Servidor"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""eadd8f25-d9e0-46ef-89a7-e95efe769df1"",""titulo"": ""Base - Servidores"",""iconoid"": ""35aab678-4c97-4349-9cad-b4e5b4d301a3"",""etiquetasingular"": ""Servidor"",""etiquetaplural"": ""Servidores"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""eadd8f25-d9e0-46ef-89a7-e95efe769df1"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Servidor"",""descripcion"": """",""keyword"": ""ReferenciaServidor"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaServidor As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaServidor
          <DisplayName("Responder A")>
          Public Property ResponderA As String
          Public Shared ___ResponderA As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ResponderA"",""etiqueta"": ""Responder A"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 4,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Responder A"",""descripcion"": """",""keyword"": ""ResponderA"",""formato"": 5,""rol"": 4,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ResponderA As DinaNETCore.APID.DinaupAPI_CampoC = ___ResponderA
          <DisplayName("Dirección de envío (Alias):")>
          Public Property DireccionDeEnvioAlias As String
          Public Shared ___DireccionDeEnvioAlias As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""DireccionDeEnvioAlias"",""etiqueta"": ""Dirección de envío (Alias):"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 4,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Dirección de envío (Alias):"",""descripcion"": """",""keyword"": ""DireccionDeEnvioAlias"",""formato"": 5,""rol"": 4,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __DireccionDeEnvioAlias As DinaNETCore.APID.DinaupAPI_CampoC = ___DireccionDeEnvioAlias
          <DisplayName("Autor")>
          Public Property Autor As String
          Public Shared ___Autor As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""Autor"",""etiqueta"": ""Autor"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Autor"",""descripcion"": """",""keyword"": ""Autor"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __Autor As DinaNETCore.APID.DinaupAPI_CampoC = ___Autor
          <DisplayName("Respuesta A")>
          Public Property ReferenciaRespuestaA As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Shared ___ReferenciaRespuestaA As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""ReferenciaRespuestaA"",""etiqueta"": ""Respuesta A"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""9121b827-441d-4eaf-883d-3efd40f44d45"",""titulo"": ""Base - Bandeja de correos"",""iconoid"": ""ec14206c-8b07-475d-98ab-6228a60d640a"",""etiquetasingular"": ""Bandeja de  correos"",""etiquetaplural"": ""Bandejas de  correos"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""9121b827-441d-4eaf-883d-3efd40f44d45"",""rol"": 0,""decimales"": ""0"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Respuesta A"",""descripcion"": """",""keyword"": ""ReferenciaRespuestaA"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ReferenciaRespuestaA As DinaNETCore.APID.DinaupAPI_CampoC = ___ReferenciaRespuestaA
          <ReadOnlyAttribute(True)>
          <DisplayName("ID")>
          Public Property ID As Guid
          Public Shared ___ID As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": true,""eseliminado"": false,""keyword"": ""ID"",""etiqueta"": ""ID"",""oculta"": false,""formato"": 9,""porubicacion"": false,""seccionrelacionada"": {""id"": ""44a58422-5df9-41a2-8af3-80675d611384"",""titulo"": ""Base - Envíos programados de correos"",""iconoid"": ""3fa003db-8231-412c-9d8e-5beda36b7dac"",""etiquetasingular"": ""Envío programado de correo"",""etiquetaplural"": ""Envíos programados de correos"",""etiquetaesfemenino"": false,""contienelista"": true,""eslista"": false,""esbase"": true,""puedeagregar"": false},""seccionrelacionadaid"": ""44a58422-5df9-41a2-8af3-80675d611384"",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""ID"",""descripcion"": """",""keyword"": ""ID"",""formato"": 9,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
          Public  __ID As DinaNETCore.APID.DinaupAPI_CampoC = ___ID
          <DisplayName("Título")>
          Public Property TextoPrincipal As String
          Public Shared ___TextoPrincipal As New DinaNETCore.APID.DinaupAPI_CampoC("{""esid"": false,""eseliminado"": false,""keyword"": ""TextoPrincipal"",""etiqueta"": ""Título"",""oculta"": false,""formato"": 5,""porubicacion"": false,""seccionrelacionada"": null,""seccionrelacionadaid"": """",""rol"": 0,""decimales"": ""22"",""multilinea"": false,""obligatorio"": false,""motivobloqueo"": """",""esutc"": false,""aceptasegundos"": false,""aceptacero"": true,""aceptapositivos"": true,""aceptanegativos"": true,""predefinidos_valores"": [],""predefinidos_textos"": [],""predefinidos_iconos"": [],""filtro"": {""titulo"": ""Título"",""descripcion"": """",""keyword"": ""TextoPrincipal"",""formato"": 5,""rol"": 0,""seccionrelacionada"": null,""desplegableinforme"": null,""rango"": false},""solovalorespredefinidos"": false}")
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
          me.ReferenciaDestinador = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_30040163371036"), _Datos.Leer_String("pr_30040163371036.nombre"))
          me.ReferenciaEmpleadoPrincipal = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_30040163371029"), _Datos.Leer_String("pr_30040163371029.nombre"))
          me.ReferenciaAutorDelAlta = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_30040163371031"), _Datos.Leer_String("pr_30040163371031.nombre"))
          me.FechaAlta_UTC = _Datos.Leer_DateTime_Nulable("pr_30040163371035")
          me.HoraLocal = _Datos.Leer_Time_Nulable("pr_30040163371033")
          me.ReferenciaUbicacionPrincipal = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_30040163371030"), _Datos.Leer_String("pr_30040163371030.nombre"))
          me.FechaDato_UTC = _Datos.Leer_DateTime_Nulable("pr_30040163371032")
          me.AutorDelAltaTieneAccesoWeb = _Datos.Leer_Boolean("pr_30040163371047")
          me.EmpleadoTieneAccesoWeb = _Datos.Leer_Boolean("pr_30040163371048")
          me.Asunto = _Datos.Leer_String("pr_30040163371049")
          me.CorreoDeOrigen = _Datos.Leer_String("pr_30040163371051")
          me.CorreoDestino = _Datos.Leer_String("pr_30040163371052")
          me.ReferenciaInformeDeOrigen = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_30040163371053"), _Datos.Leer_String("pr_30040163371053.nombre"))
          me.ReferenciaPlantillaDeCorreo = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_30040163371054"), _Datos.Leer_String("pr_30040163371054.nombre"))
          me.ReintentosDeEnvio = _Datos.Leer_Integer("pr_40040163371")
          me.ErrorDeEnvio = _Datos.Leer_String("pr_40040163372")
          me.ReferenciaSeccionDeOrigen = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_40040163373"), _Datos.Leer_String("pr_40040163373.nombre"))
          me.ReferenciaRegistroDeOrigen = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_40040163374"), _Datos.Leer_String("pr_40040163374.nombre"))
          me.ReferenciaConfiguracionDeCorreoDeOrigen = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_20040164243"), _Datos.Leer_String("pr_20040164243.nombre"))
          me.EstadoDeEnvio = _Datos.Leer_EnumTramitacionE("pr_20040164244")
          me.FechaDeUltimoIntentoFallido_UTC = _Datos.Leer_DateTime_Nulable("pr_30040164241")
          me.FechaDeEnvio_UTC = _Datos.Leer_DateTime_Nulable("pr_30040164242")
          me.HaSidoMarcadoComoCorreoNoDeseado = _Datos.Leer_Boolean("pr_30040164243")
          me.ReferenciaArchivo4Obsoleto = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_400401652136"), _Datos.Leer_String("pr_400401652136.nombre"))
          me.ReferenciaArchivo1Obsoleto = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_400401652137"), _Datos.Leer_String("pr_400401652137.nombre"))
          me.ReferenciaArchivo3 = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_400401652138"), _Datos.Leer_String("pr_400401652138.nombre"))
          me.ReferenciaArchivo2Obsoleto = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_400401652139"), _Datos.Leer_String("pr_400401652139.nombre"))
          me.Contenido = _Datos.Leer_String("pr_30040163371050")
          me.ReferenciaBuzon = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_30040257424"), _Datos.Leer_String("pr_30040257424.nombre"))
          me.CantidadDeArchivos = _Datos.Leer_Integer("pr_40040257421")
          me.ReferenciaServidor = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_30040336411"), _Datos.Leer_String("pr_30040336411.nombre"))
          me.ResponderA = _Datos.Leer_String("pr_40040408072")
          me.DireccionDeEnvioAlias = _Datos.Leer_String("pr_40040408073")
          me.Autor = _Datos.Leer_String("pr_50040408086")
          me.ReferenciaRespuestaA = new DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC( _Datos.Leer_Guid("pr_40040452524"), _Datos.Leer_String("pr_40040452524.nombre"))
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
           R.add("pr_30040163371036",me.ReferenciaDestinador.ID.STR())
         Else
           R.add("pr_30040163371036","")
         End if
         If Me.ReferenciaEmpleadoPrincipal IsNot nothing then
           R.add("pr_30040163371029",me.ReferenciaEmpleadoPrincipal.ID.STR())
         Else
           R.add("pr_30040163371029","")
         End if
         If Me.ReferenciaAutorDelAlta IsNot nothing then
           R.add("pr_30040163371031",me.ReferenciaAutorDelAlta.ID.STR())
         Else
           R.add("pr_30040163371031","")
         End if
         R.add("pr_30040163371035", me.FechaAlta_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_30040163371033", me.HoraLocal.AdaptarMySQL_Time_Nulable())
         If Me.ReferenciaUbicacionPrincipal IsNot nothing then
           R.add("pr_30040163371030",me.ReferenciaUbicacionPrincipal.ID.STR())
         Else
           R.add("pr_30040163371030","")
         End if
         R.add("pr_30040163371032", me.FechaDato_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_30040163371047", me.AutorDelAltaTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_30040163371048", me.EmpleadoTieneAccesoWeb.AdaptarMySQL_Boolean())
         R.add("pr_30040163371049", me.Asunto.AdaptarMySQL_String())
         R.add("pr_30040163371051", me.CorreoDeOrigen.AdaptarMySQL_String())
         R.add("pr_30040163371052", me.CorreoDestino.AdaptarMySQL_String())
         If Me.ReferenciaInformeDeOrigen IsNot nothing then
           R.add("pr_30040163371053",me.ReferenciaInformeDeOrigen.ID.STR())
         Else
           R.add("pr_30040163371053","")
         End if
         If Me.ReferenciaPlantillaDeCorreo IsNot nothing then
           R.add("pr_30040163371054",me.ReferenciaPlantillaDeCorreo.ID.STR())
         Else
           R.add("pr_30040163371054","")
         End if
         R.add("pr_40040163371", me.ReintentosDeEnvio.AdaptarMySQL_Integer())
         R.add("pr_40040163372", me.ErrorDeEnvio.AdaptarMySQL_String())
         If Me.ReferenciaSeccionDeOrigen IsNot nothing then
           R.add("pr_40040163373",me.ReferenciaSeccionDeOrigen.ID.STR())
         Else
           R.add("pr_40040163373","")
         End if
         If Me.ReferenciaRegistroDeOrigen IsNot nothing then
           R.add("pr_40040163374",me.ReferenciaRegistroDeOrigen.ID.STR())
         Else
           R.add("pr_40040163374","")
         End if
         If Me.ReferenciaConfiguracionDeCorreoDeOrigen IsNot nothing then
           R.add("pr_20040164243",me.ReferenciaConfiguracionDeCorreoDeOrigen.ID.STR())
         Else
           R.add("pr_20040164243","")
         End if
         R.add("pr_20040164244", me.EstadoDeEnvio.AdaptarMySQL_EnumTramitacionE())
         R.add("pr_30040164241", me.FechaDeUltimoIntentoFallido_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_30040164242", me.FechaDeEnvio_UTC.AdaptarMySQL_DateTime_Nulable())
         R.add("pr_30040164243", me.HaSidoMarcadoComoCorreoNoDeseado.AdaptarMySQL_Boolean())
         If Me.ReferenciaArchivo4Obsoleto IsNot nothing then
           R.add("pr_400401652136",me.ReferenciaArchivo4Obsoleto.ID.STR())
         Else
           R.add("pr_400401652136","")
         End if
         If Me.ReferenciaArchivo1Obsoleto IsNot nothing then
           R.add("pr_400401652137",me.ReferenciaArchivo1Obsoleto.ID.STR())
         Else
           R.add("pr_400401652137","")
         End if
         If Me.ReferenciaArchivo3 IsNot nothing then
           R.add("pr_400401652138",me.ReferenciaArchivo3.ID.STR())
         Else
           R.add("pr_400401652138","")
         End if
         If Me.ReferenciaArchivo2Obsoleto IsNot nothing then
           R.add("pr_400401652139",me.ReferenciaArchivo2Obsoleto.ID.STR())
         Else
           R.add("pr_400401652139","")
         End if
         R.add("pr_30040163371050", me.Contenido.AdaptarMySQL_String())
         If Me.ReferenciaBuzon IsNot nothing then
           R.add("pr_30040257424",me.ReferenciaBuzon.ID.STR())
         Else
           R.add("pr_30040257424","")
         End if
         R.add("pr_40040257421", me.CantidadDeArchivos.AdaptarMySQL_Integer())
         If Me.ReferenciaServidor IsNot nothing then
           R.add("pr_30040336411",me.ReferenciaServidor.ID.STR())
         Else
           R.add("pr_30040336411","")
         End if
         R.add("pr_40040408072", me.ResponderA.AdaptarMySQL_String())
         R.add("pr_40040408073", me.DireccionDeEnvioAlias.AdaptarMySQL_String())
         R.add("pr_50040408086", me.Autor.AdaptarMySQL_String())
         If Me.ReferenciaRespuestaA IsNot nothing then
           R.add("pr_40040452524",me.ReferenciaRespuestaA.ID.STR())
         Else
           R.add("pr_40040452524","")
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
  End Class
End Class
