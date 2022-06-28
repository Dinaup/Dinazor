Partial Public Class SeccionesD
  Public Class EnviosProgramadosDeCorreosD
      Public Shared _SeccionID As String = "fe5f53f0-3ad0-499b-b30b-3d72675f8d91"
      Public Shared _SeccionIDGUID As New Guid("fe5f53f0-3ad0-499b-b30b-3d72675f8d91")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As EnviosProgramadosDeCorreos_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, EnviosProgramadosDeCorreosES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New EnviosProgramadosDeCorreos_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As EnviosProgramadosDeCorreos_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, EnviosProgramadosDeCorreosES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New EnviosProgramadosDeCorreos_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class EnviosProgramadosDeCorreosES
          Public shared _SeccionID as Guid = New Guid("fe5f53f0-3ad0-499b-b30b-3d72675f8d91")
          Public shared _Tabla$ = "tpr_30040163371002"
      Public Shared ReferenciaDestinador$ = "pr_30040163371036"
      Public Shared FechaAlta_UTC$ = "pr_30040163371035"
      Public Shared ReferenciaAutorDelAlta$ = "pr_30040163371031"
      Public Shared FechaDato_UTC$ = "pr_30040163371032"
      Public Shared CorreoDeOrigen$ = "pr_30040163371051"
      Public Shared HoraLocal$ = "pr_30040163371033"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_30040163371047"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_30040163371048"
      Public Shared Asunto$ = "pr_30040163371049"
      Public Shared CorreoDestino$ = "pr_30040163371052"
      Public Shared ReferenciaInformeDeOrigen$ = "pr_30040163371053"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_30040163371030"
      Public Shared ReferenciaPlantillaDeCorreo$ = "pr_30040163371054"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_30040163371029"
      Public Shared ErrorDeEnvio$ = "pr_40040163372"
      Public Shared ReferenciaRegistroDeOrigen$ = "pr_40040163374"
      Public Shared ReferenciaSeccionDeOrigen$ = "pr_40040163373"
      Public Shared ReintentosDeEnvio$ = "pr_40040163371"
      Public Shared ReferenciaConfiguracionDeCorreoDeOrigen$ = "pr_20040164243"
      Public Shared EstadoDeEnvio$ = "pr_20040164244"
      Public Shared FechaDeUltimoIntentoFallido_UTC$ = "pr_30040164241"
      Public Shared FechaDeEnvio_UTC$ = "pr_30040164242"
      Public Shared HaSidoMarcadoComoCorreoNoDeseado$ = "pr_30040164243"
      Public Shared ReferenciaArchivo4Obsoleto$ = "pr_400401652136"
      Public Shared ReferenciaArchivo1Obsoleto$ = "pr_400401652137"
      Public Shared ReferenciaArchivo2Obsoleto$ = "pr_400401652139"
      Public Shared ReferenciaArchivo3$ = "pr_400401652138"
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
      Public Class EnviosProgramadosDeCorreosC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaDato_UTC As Date
          Public CorreoDeOrigen As String
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public EmpleadoTieneAccesoWeb As Boolean
          Public Asunto As String
          Public CorreoDestino As String
          Public ReferenciaInformeDeOrigen As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaPlantillaDeCorreo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ErrorDeEnvio As String
          Public ReferenciaRegistroDeOrigen As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaSeccionDeOrigen As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReintentosDeEnvio As Integer
          Public ReferenciaConfiguracionDeCorreoDeOrigen As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public EstadoDeEnvio As Integer
          Public FechaDeUltimoIntentoFallido_UTC As Date
          Public FechaDeEnvio_UTC As Date
          Public HaSidoMarcadoComoCorreoNoDeseado As Boolean
          Public ReferenciaArchivo4Obsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaArchivo1Obsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaArchivo2Obsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaArchivo3 As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Contenido As String
          Public ReferenciaBuzon As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public CantidadDeArchivos As Integer
          Public ReferenciaServidor As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ResponderA As String
          Public DireccionDeEnvioAlias As String
          Public Autor As String
          Public ReferenciaRespuestaA As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ID As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public TextoPrincipal As String
          Public FechaAltaDato_UTC As Date
          Public FechaUltimaModificacion_UTC As Date
          Public Eliminado As Boolean
          Public UsuarioCreadorDelDAto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Seccion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Posicion As Integer
          Public Empresa As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Modificado As Boolean
          Public FechaIndiceActividad_UTC As Date
          Public Fechadesincronizacion_UTC As Date
          Sub new()
          End Sub
      End Class
      Public Class EnviosProgramadosDeCorreos_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_30040163371036")
            End Get   
        End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_30040163371035")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_30040163371035", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_30040163371031")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_30040163371031", value)
            End Set
          End Property
          Public property FechaDato_UTC As Date
            get
                return me.GetValue_DateTime("pr_30040163371032")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_30040163371032", value)
            End Set
          End Property
        Public ReadOnly property CorreoDeOrigen As String
            get
                return me.GetValue_String("pr_30040163371051")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_30040163371033")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_30040163371047")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_30040163371047", value)
            End Set
          End Property
          Public property EmpleadoTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_30040163371048")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_30040163371048", value)
            End Set
          End Property
        Public ReadOnly property Asunto As String
            get
                return me.GetValue_String("pr_30040163371049")
            End Get   
        End Property
        Public ReadOnly property CorreoDestino As String
            get
                return me.GetValue_String("pr_30040163371052")
            End Get   
        End Property
        Public ReadOnly property ReferenciaInformeDeOrigen As Guid
            get
                return me.GetValue_Guid("pr_30040163371053")
            End Get   
        End Property
          Public property ReferenciaUbicacionPrincipal As Guid
            get
                return me.GetValue_Guid("pr_30040163371030")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_30040163371030", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaPlantillaDeCorreo As Guid
            get
                return me.GetValue_Guid("pr_30040163371054")
            End Get   
        End Property
          Public property ReferenciaEmpleadoPrincipal As Guid
            get
                return me.GetValue_Guid("pr_30040163371029")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_30040163371029", value)
            End Set
          End Property
        Public ReadOnly property ErrorDeEnvio As String
            get
                return me.GetValue_String("pr_40040163372")
            End Get   
        End Property
        Public ReadOnly property ReferenciaRegistroDeOrigen As Guid
            get
                return me.GetValue_Guid("pr_40040163374")
            End Get   
        End Property
        Public ReadOnly property ReferenciaSeccionDeOrigen As Guid
            get
                return me.GetValue_Guid("pr_40040163373")
            End Get   
        End Property
        Public ReadOnly property ReintentosDeEnvio As Integer
            get
                return me.GetValue_Integer("pr_40040163371")
            End Get   
        End Property
        Public ReadOnly property ReferenciaConfiguracionDeCorreoDeOrigen As Guid
            get
                return me.GetValue_Guid("pr_20040164243")
            End Get   
        End Property
        Public ReadOnly property EstadoDeEnvio As Integer
            get
                return me.GetValue_Integer("pr_20040164244")
            End Get   
        End Property
        Public ReadOnly property FechaDeUltimoIntentoFallido_UTC As Date
            get
                return me.GetValue_DateTime("pr_30040164241")
            End Get   
        End Property
        Public ReadOnly property FechaDeEnvio_UTC As Date
            get
                return me.GetValue_DateTime("pr_30040164242")
            End Get   
        End Property
          Public property HaSidoMarcadoComoCorreoNoDeseado As Boolean
            get
                return me.GetValue_Boolean("pr_30040164243")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_30040164243", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaArchivo4Obsoleto As Guid
            get
                return me.GetValue_Guid("pr_400401652136")
            End Get   
        End Property
        Public ReadOnly property ReferenciaArchivo1Obsoleto As Guid
            get
                return me.GetValue_Guid("pr_400401652137")
            End Get   
        End Property
        Public ReadOnly property ReferenciaArchivo2Obsoleto As Guid
            get
                return me.GetValue_Guid("pr_400401652139")
            End Get   
        End Property
        Public ReadOnly property ReferenciaArchivo3 As Guid
            get
                return me.GetValue_Guid("pr_400401652138")
            End Get   
        End Property
        Public ReadOnly property Contenido As String
            get
                return me.GetValue_String("pr_30040163371050")
            End Get   
        End Property
          Public property ReferenciaBuzon As Guid
            get
                return me.GetValue_Guid("pr_30040257424")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_30040257424", value)
            End Set
          End Property
        Public ReadOnly property CantidadDeArchivos As Integer
            get
                return me.GetValue_Integer("pr_40040257421")
            End Get   
        End Property
          Public property ReferenciaServidor As Guid
            get
                return me.GetValue_Guid("pr_30040336411")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_30040336411", value)
            End Set
          End Property
        Public ReadOnly property ResponderA As String
            get
                return me.GetValue_String("pr_40040408072")
            End Get   
        End Property
        Public ReadOnly property DireccionDeEnvioAlias As String
            get
                return me.GetValue_String("pr_40040408073")
            End Get   
        End Property
        Public ReadOnly property Autor As String
            get
                return me.GetValue_String("pr_50040408086")
            End Get   
        End Property
        Public ReadOnly property ReferenciaRespuestaA As Guid
            get
                return me.GetValue_Guid("pr_40040452524")
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
          Public property Posicion As Integer
            get
                return me.GetValue_Integer("posicion")
            End Get
            Set(value As Integer)
                me.SetValue_Integer("posicion", value)
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
