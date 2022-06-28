Partial Public Class SeccionesD
  Public Class IndiceDeEventosDeAgendaD
      Public Shared _SeccionID As String = "7876d5bd-3f40-4cc7-b884-eb9077319ad1"
      Public Shared _SeccionIDGUID As New Guid("7876d5bd-3f40-4cc7-b884-eb9077319ad1")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As IndiceDeEventosDeAgenda_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, IndiceDeEventosDeAgendaES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New IndiceDeEventosDeAgenda_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As IndiceDeEventosDeAgenda_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, IndiceDeEventosDeAgendaES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New IndiceDeEventosDeAgenda_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class IndiceDeEventosDeAgendaES
          Public shared _SeccionID as Guid = New Guid("7876d5bd-3f40-4cc7-b884-eb9077319ad1")
          Public shared _Tabla$ = "tpr_7795877xd"
      Public Shared ReferenciaEventoSeccion$ = "pr_7798689wd"
      Public Shared ReferenciaEventoRelacion$ = "pr_779868fwd"
      Public Shared Hasta_UTC$ = "pr_7bcb62dwd"
      Public Shared FechaAlta_UTC$ = "pr_779589dwd"
      Public Shared Desde_UTC$ = "pr_7bcb62bwd"
      Public Shared ReferenciaAgendaRelacion$ = "pr_7798693wd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_7795893wd"
      Public Shared ReferenciaAgendaSeccion$ = "pr_779868bwd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_77958afwd"
      Public Shared ReferenciaDestinador$ = "pr_77958a3wd"
      Public Shared HoraLocal$ = "pr_7795897wd"
      Public Shared Ocupa$ = "pr_7798691wd"
      Public Shared EventoNombre$ = "pr_60040147211"
      Public Shared AgendaNombre$ = "pr_60040147212"
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
      Public Class IndiceDeEventosDeAgendaC
          Public ReferenciaEventoSeccion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaEventoRelacion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Hasta_UTC As Date
          Public FechaAlta_UTC As Date
          Public Desde_UTC As Date
          Public ReferenciaAgendaRelacion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaAgendaSeccion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public Ocupa As Boolean
          Public EventoNombre As String
          Public AgendaNombre As String
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
      Public Class IndiceDeEventosDeAgenda_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
        Public ReadOnly property ReferenciaEventoSeccion As Guid
            get
                return me.GetValue_Guid("pr_7798689wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaEventoRelacion As Guid
            get
                return me.GetValue_Guid("pr_779868fwd")
            End Get   
        End Property
        Public ReadOnly property Hasta_UTC As Date
            get
                return me.GetValue_DateTime("pr_7bcb62dwd")
            End Get   
        End Property
        Public ReadOnly property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_779589dwd")
            End Get   
        End Property
        Public ReadOnly property Desde_UTC As Date
            get
                return me.GetValue_DateTime("pr_7bcb62bwd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaAgendaRelacion As Guid
            get
                return me.GetValue_Guid("pr_7798693wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_7795893wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaAgendaSeccion As Guid
            get
                return me.GetValue_Guid("pr_779868bwd")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_77958afwd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_77958afwd", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_77958a3wd")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_7795897wd")
            End Get   
        End Property
          Public property Ocupa As Boolean
            get
                return me.GetValue_Boolean("pr_7798691wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_7798691wd", value)
            End Set
          End Property
          Public property EventoNombre As String
            get
                return me.GetValue_String("pr_60040147211")
            End Get
            Set(value As String)
                me.SetValue_String("pr_60040147211", value)
            End Set
          End Property
          Public property AgendaNombre As String
            get
                return me.GetValue_String("pr_60040147212")
            End Get
            Set(value As String)
                me.SetValue_String("pr_60040147212", value)
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
