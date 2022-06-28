Partial Public Class SeccionesD
  Public Class AreasDeAccesoWebListaD
      Public Shared _SeccionID As String = "0df22dce-edf1-4f4d-aff8-565362eb208b"
      Public Shared _SeccionIDGUID As New Guid("0df22dce-edf1-4f4d-aff8-565362eb208b")
      Public Class AreasDeAccesoWebListaES
          Public shared _SeccionID as Guid = New Guid("0df22dce-edf1-4f4d-aff8-565362eb208b")
          Public shared _Tabla$ = "tpr_536e7f7wd_e"
      Public Shared Identificador$ = "pr_148e0ceaf1x144wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_146314b3c7g3cdwd"
      Public Shared ReferenciaUsuarioAcceso$ = "pr_148e0b7859x362wd"
      Public Shared Contraseña$ = "pr_148e0e2666x2ecwd"
      Public Shared AccesoBloqueado$ = "pr_148e0f3146x2ebwd"
      Public Shared ReferenciaDestinador$ = "pr_14631011e4x2b8wd"
      Public Shared HoraLocal$ = "pr_776aed8wd"
      Public Shared MotivoDeBloqueo$ = "pr_148e0fe4b1x310wd"
      Public Shared UsuarioAccesoTieneAccesoWeb$ = "pr_148e0ba3ebx22fwd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_1463101147x31cwd"
      Public Shared FechaAlta_UTC$ = "pr_14c9f3dfc2xa0wd"
      Public Shared ReferenciaRolSoloParaModoTerminal$ = "pr_10040133765"
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
      Public Shared RelacionElementoContenedorListador$ = "idrelacionlistador"
      Public Shared Listadoreliminado$ = "listadoreliminado"
      End Class
      Public Class AreasDeAccesoWebListaC
          Public Identificador As String
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaUsuarioAcceso As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Contraseña As String
          Public AccesoBloqueado As Boolean
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public MotivoDeBloqueo As String
          Public UsuarioAccesoTieneAccesoWeb As Boolean
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public ReferenciaRolSoloParaModoTerminal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
          Public RelacionElementoContenedorListador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Listadoreliminado As Boolean
          Sub new()
          End Sub
      End Class
      Public Class AreasDeAccesoWebLista_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
          Public property Identificador As String
            get
                return me.GetValue_String("pr_148e0ceaf1x144wd")
            End Get
            Set(value As String)
                me.SetValue_String("pr_148e0ceaf1x144wd", value)
            End Set
          End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_146314b3c7g3cdwd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_146314b3c7g3cdwd", value)
            End Set
          End Property
          Public property ReferenciaUsuarioAcceso As Guid
            get
                return me.GetValue_Guid("pr_148e0b7859x362wd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_148e0b7859x362wd", value)
            End Set
          End Property
          Public property Contraseña As String
            get
                return me.GetValue_String("pr_148e0e2666x2ecwd")
            End Get
            Set(value As String)
                me.SetValue_String("pr_148e0e2666x2ecwd", value)
            End Set
          End Property
          Public property AccesoBloqueado As Boolean
            get
                return me.GetValue_Boolean("pr_148e0f3146x2ebwd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_148e0f3146x2ebwd", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_14631011e4x2b8wd")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_776aed8wd")
            End Get   
        End Property
          Public property MotivoDeBloqueo As String
            get
                return me.GetValue_String("pr_148e0fe4b1x310wd")
            End Get
            Set(value As String)
                me.SetValue_String("pr_148e0fe4b1x310wd", value)
            End Set
          End Property
          Public property UsuarioAccesoTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_148e0ba3ebx22fwd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_148e0ba3ebx22fwd", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_1463101147x31cwd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_1463101147x31cwd", value)
            End Set
          End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_14c9f3dfc2xa0wd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_14c9f3dfc2xa0wd", value)
            End Set
          End Property
          Public property ReferenciaRolSoloParaModoTerminal As Guid
            get
                return me.GetValue_Guid("pr_10040133765")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_10040133765", value)
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
        Public ReadOnly property RelacionElementoContenedorListador As Guid
            get
                return me.GetValue_Guid("idrelacionlistador")
            End Get   
        End Property
          Public property Listadoreliminado As Boolean
            get
                return me.GetValue_Boolean("listadoreliminado")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("listadoreliminado", value)
            End Set
          End Property
          Sub New(___VV__ As DinaNETCore.API_VVC , _Token$)
              MyBase.New(___VV__, _Token) 
              Me.Evento_Actualizar()
          End Sub
      End Class
  End Class
End Class
