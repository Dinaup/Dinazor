Partial Public Class SeccionesD
  Public Class CriteriosParaMostrarNotificacionesD
      Public Shared _SeccionID As String = "81252896-77f9-47b6-a720-2a8c71516800"
      Public Shared _SeccionIDGUID As New Guid("81252896-77f9-47b6-a720-2a8c71516800")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As CriteriosParaMostrarNotificaciones_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, CriteriosParaMostrarNotificacionesES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New CriteriosParaMostrarNotificaciones_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As CriteriosParaMostrarNotificaciones_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, CriteriosParaMostrarNotificacionesES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New CriteriosParaMostrarNotificaciones_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class CriteriosParaMostrarNotificacionesES
          Public shared _SeccionID as Guid = New Guid("81252896-77f9-47b6-a720-2a8c71516800")
          Public shared _Tabla$ = "tpr_733da88xd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_733da94wd"
      Public Shared NotificacionActiva$ = "pr_733f513wd"
      Public Shared InformacionAdicional$ = "pr_7a3e977wd"
      Public Shared TipoDeEvento$ = "pr_79db217wd"
      Public Shared FechaAlta_UTC$ = "pr_733daa4wd"
      Public Shared Condicion$ = "pr_79d7f69wd"
      Public Shared TituloNotificacion$ = "pr_738b686wd"
      Public Shared ReferenciaDestinador$ = "pr_733dab0wd"
      Public Shared HoraLocal$ = "pr_77611c0wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_733dae8wd"
      Public Shared EmpleadosANotificar$ = "pr_79d87edwd"
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
      Public Class CriteriosParaMostrarNotificacionesC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public NotificacionActiva As Boolean
          Public InformacionAdicional As String
          Public TipoDeEvento As Integer
          Public FechaAlta_UTC As Date
          Public Condicion As String
          Public TituloNotificacion As String
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public EmpleadosANotificar As String
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
      Public Class CriteriosParaMostrarNotificaciones_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_733da94wd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_733da94wd", value)
            End Set
          End Property
          Public property NotificacionActiva As Boolean
            get
                return me.GetValue_Boolean("pr_733f513wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_733f513wd", value)
            End Set
          End Property
          Public property InformacionAdicional As String
            get
                return me.GetValue_String("pr_7a3e977wd")
            End Get
            Set(value As String)
                me.SetValue_String("pr_7a3e977wd", value)
            End Set
          End Property
          Public property TipoDeEvento As Integer
            get
                return me.GetValue_Integer("pr_79db217wd")
            End Get
            Set(value As Integer)
                me.SetValue_Integer("pr_79db217wd", value)
            End Set
          End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_733daa4wd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_733daa4wd", value)
            End Set
          End Property
          Public property Condicion As String
            get
                return me.GetValue_String("pr_79d7f69wd")
            End Get
            Set(value As String)
                me.SetValue_String("pr_79d7f69wd", value)
            End Set
          End Property
          Public property TituloNotificacion As String
            get
                return me.GetValue_String("pr_738b686wd")
            End Get
            Set(value As String)
                me.SetValue_String("pr_738b686wd", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_733dab0wd")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_77611c0wd")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_733dae8wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_733dae8wd", value)
            End Set
          End Property
          Public property EmpleadosANotificar As String
            get
                return me.GetValue_String("pr_79d87edwd")
            End Get
            Set(value As String)
                me.SetValue_String("pr_79d87edwd", value)
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
