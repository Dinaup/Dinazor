Partial Public Class SeccionesD
  Public Class SCIntegridadDeExistenciaD
      Public Shared _SeccionID As String = "7ca0a101-abe1-492c-87da-2eed30b2d79f"
      Public Shared _SeccionIDGUID As New Guid("7ca0a101-abe1-492c-87da-2eed30b2d79f")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As SCIntegridadDeExistencia_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, SCIntegridadDeExistenciaES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New SCIntegridadDeExistencia_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As SCIntegridadDeExistencia_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, SCIntegridadDeExistenciaES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New SCIntegridadDeExistencia_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class SCIntegridadDeExistenciaES
          Public shared _SeccionID as Guid = New Guid("7ca0a101-abe1-492c-87da-2eed30b2d79f")
          Public shared _Tabla$ = "tpr_71ae9ebxd"
      Public Shared FechaAlta_UTC$ = "pr_71aea2fwd"
      Public Shared ReferenciaLocalizadoEnUbicacionObsoleto$ = "pr_71af6d5wd"
      Public Shared FechaDato_UTC$ = "pr_71aea23wd"
      Public Shared FechaReparacionUTC_UTC$ = "pr_71af6ddwd"
      Public Shared FechaReparacionObsoleto_UTC$ = "pr_71af6d9wd"
      Public Shared ReferenciaRegistroID$ = "pr_71bcd24wd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_71aea1fwd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_71aea53wd"
      Public Shared SeccionOTabla$ = "pr_71af6cdwd"
      Public Shared HoraLocal$ = "pr_776af18wd"
      Public Shared ReferenciaDestinador$ = "pr_71aea3bwd"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_71aea1bwd"
      Public Shared Estado$ = "pr_71af6e1wd"
      Public Shared ReferenciaServidorDondeExiste$ = "pr_20040212262"
      Public Shared ReferenciaServidorDondeFalta$ = "pr_20040212261"
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
      Public Class SCIntegridadDeExistenciaC
          Public FechaAlta_UTC As Date
          Public ReferenciaLocalizadoEnUbicacionObsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaDato_UTC As Date
          Public FechaReparacionUTC_UTC As Date
          Public FechaReparacionObsoleto_UTC As Date
          Public ReferenciaRegistroID As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public SeccionOTabla As String
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Estado As Integer
          Public ReferenciaServidorDondeExiste As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaServidorDondeFalta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
      Public Class SCIntegridadDeExistencia_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
        Public ReadOnly property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_71aea2fwd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaLocalizadoEnUbicacionObsoleto As Guid
            get
                return me.GetValue_Guid("pr_71af6d5wd")
            End Get   
        End Property
        Public ReadOnly property FechaDato_UTC As Date
            get
                return me.GetValue_DateTime("pr_71aea23wd")
            End Get   
        End Property
        Public ReadOnly property FechaReparacionUTC_UTC As Date
            get
                return me.GetValue_DateTime("pr_71af6ddwd")
            End Get   
        End Property
        Public ReadOnly property FechaReparacionObsoleto_UTC As Date
            get
                return me.GetValue_DateTime("pr_71af6d9wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaRegistroID As Guid
            get
                return me.GetValue_Guid("pr_71bcd24wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_71aea1fwd")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_71aea53wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_71aea53wd", value)
            End Set
          End Property
        Public ReadOnly property SeccionOTabla As String
            get
                return me.GetValue_String("pr_71af6cdwd")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_776af18wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_71aea3bwd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaUbicacionPrincipal As Guid
            get
                return me.GetValue_Guid("pr_71aea1bwd")
            End Get   
        End Property
        Public ReadOnly property Estado As Integer
            get
                return me.GetValue_Integer("pr_71af6e1wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaServidorDondeExiste As Guid
            get
                return me.GetValue_Guid("pr_20040212262")
            End Get   
        End Property
        Public ReadOnly property ReferenciaServidorDondeFalta As Guid
            get
                return me.GetValue_Guid("pr_20040212261")
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
