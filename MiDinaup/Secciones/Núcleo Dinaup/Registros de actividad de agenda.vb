Partial Public Class SeccionesD
  Public Class RegistrosDeActividadDeAgendaD
      Public Shared _SeccionID As String = "e8276389-9081-42d6-9959-ba8720c0765b"
      Public Shared _SeccionIDGUID As New Guid("e8276389-9081-42d6-9959-ba8720c0765b")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As RegistrosDeActividadDeAgenda_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, RegistrosDeActividadDeAgendaES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New RegistrosDeActividadDeAgenda_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As RegistrosDeActividadDeAgenda_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, RegistrosDeActividadDeAgendaES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New RegistrosDeActividadDeAgenda_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class RegistrosDeActividadDeAgendaES
          Public shared _SeccionID as Guid = New Guid("e8276389-9081-42d6-9959-ba8720c0765b")
          Public shared _Tabla$ = "tpr_7c25e52xd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_7c25e60wd"
      Public Shared ReferenciaSeccionAgenda$ = "pr_7c27ce7wd"
      Public Shared SegundosAbierto$ = "pr_7c48d8ewd"
      Public Shared FechaDato_UTC$ = "pr_7c25e62wd"
      Public Shared FechaAlta_UTC$ = "pr_7c25e6cwd"
      Public Shared TiempoEjecucion$ = "pr_7c49703wd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_7c25e88wd"
      Public Shared FinalizacionInesperada$ = "pr_7c49705wd"
      Public Shared SegundosActividad$ = "pr_7c48d92wd"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_7c25e5cwd"
      Public Shared VecesFoco$ = "pr_7c48d94wd"
      Public Shared AgendaNombre$ = "pr_7c28201wd"
      Public Shared ReferenciaAgendaElemento$ = "pr_7c27ce9wd"
      Public Shared HoraLocal$ = "pr_7c25e64wd"
      Public Shared ReferenciaDestinador$ = "pr_7c25e72wd"
      Public Shared ReferenciaRegistroDeAccesoSesion$ = "pr_7c27cebwd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_7c25e8cwd"
      Public Shared ReferenciaServidor$ = "pr_50040212263"
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
      Public Class RegistrosDeActividadDeAgendaC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaSeccionAgenda As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public SegundosAbierto As Integer
          Public FechaDato_UTC As Date
          Public FechaAlta_UTC As Date
          Public TiempoEjecucion As Decimal
          Public EmpleadoTieneAccesoWeb As Boolean
          Public FinalizacionInesperada As Boolean
          Public SegundosActividad As Integer
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public VecesFoco As Integer
          Public AgendaNombre As String
          Public ReferenciaAgendaElemento As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaRegistroDeAccesoSesion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaServidor As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
      Public Class RegistrosDeActividadDeAgenda_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
        Public ReadOnly property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_7c25e60wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaSeccionAgenda As Guid
            get
                return me.GetValue_Guid("pr_7c27ce7wd")
            End Get   
        End Property
        Public ReadOnly property SegundosAbierto As Integer
            get
                return me.GetValue_Integer("pr_7c48d8ewd")
            End Get   
        End Property
        Public ReadOnly property FechaDato_UTC As Date
            get
                return me.GetValue_DateTime("pr_7c25e62wd")
            End Get   
        End Property
        Public ReadOnly property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_7c25e6cwd")
            End Get   
        End Property
        Public ReadOnly property TiempoEjecucion As Decimal
            get
                return me.GetValue_Decimal("pr_7c49703wd")
            End Get   
        End Property
          Public property EmpleadoTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_7c25e88wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_7c25e88wd", value)
            End Set
          End Property
        Public ReadOnly property FinalizacionInesperada As Boolean
            get
                return me.GetValue_Boolean("pr_7c49705wd")
            End Get   
        End Property
        Public ReadOnly property SegundosActividad As Integer
            get
                return me.GetValue_Integer("pr_7c48d92wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaEmpleadoPrincipal As Guid
            get
                return me.GetValue_Guid("pr_7c25e5cwd")
            End Get   
        End Property
        Public ReadOnly property VecesFoco As Integer
            get
                return me.GetValue_Integer("pr_7c48d94wd")
            End Get   
        End Property
        Public ReadOnly property AgendaNombre As String
            get
                return me.GetValue_String("pr_7c28201wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaAgendaElemento As Guid
            get
                return me.GetValue_Guid("pr_7c27ce9wd")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_7c25e64wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_7c25e72wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaRegistroDeAccesoSesion As Guid
            get
                return me.GetValue_Guid("pr_7c27cebwd")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_7c25e8cwd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_7c25e8cwd", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaServidor As Guid
            get
                return me.GetValue_Guid("pr_50040212263")
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
