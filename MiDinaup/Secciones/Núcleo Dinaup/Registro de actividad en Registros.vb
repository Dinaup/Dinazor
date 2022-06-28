Partial Public Class SeccionesD
  Public Class RegistroDeActividadEnRegistrosD
      Public Shared _SeccionID As String = "a4a4840b-d5c1-40d2-bf24-002d931982d8"
      Public Shared _SeccionIDGUID As New Guid("a4a4840b-d5c1-40d2-bf24-002d931982d8")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As RegistroDeActividadEnRegistros_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, RegistroDeActividadEnRegistrosES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New RegistroDeActividadEnRegistros_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As RegistroDeActividadEnRegistros_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, RegistroDeActividadEnRegistrosES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New RegistroDeActividadEnRegistros_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class RegistroDeActividadEnRegistrosES
          Public shared _SeccionID as Guid = New Guid("a4a4840b-d5c1-40d2-bf24-002d931982d8")
          Public shared _Tabla$ = "tpr_407f801wc"
      Public Shared HaImprimido$ = "pr_40a64ccx59wc"
      Public Shared ReferenciaAutorDelAlta$ = "pr_146310243ex306wd"
      Public Shared ReferenciaPermisoPuntual$ = "pr_73b8379wd"
      Public Shared ReferenciaElemento$ = "pr_407fc81x1a3wc"
      Public Shared ReferenciaRegistroDeAccesoSesion$ = "pr_185b34608cx16bwd"
      Public Shared FechaDato_UTC$ = "pr_1463102482xbcwd"
      Public Shared ElementoNombre$ = "pr_47137adx73wc"
      Public Shared FechaAlta_UTC$ = "pr_14c9f3e26dg13bwd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_1464b59d72x51wd"
      Public Shared VecesFoco$ = "pr_407faadx2a4wc"
      Public Shared SegundosAbierto$ = "pr_407fa69x1e3wc"
      Public Shared SegundosActividad$ = "pr_407fa49x391wc"
      Public Shared ReferenciaSeccion$ = "pr_407fc0ex312wc"
      Public Shared FinalizacionInesperada$ = "pr_4d832fcx2fawc"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_1464b41092x328wd"
      Public Shared TipoDeAccion$ = "pr_7c20cf7wd"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_1464b410d0x38cwd"
      Public Shared TiempoEjecucion$ = "pr_4d83377x2a6wc"
      Public Shared ReferenciaDestinador$ = "pr_146310256ex24dwd"
      Public Shared HoraLocal$ = "pr_776aebawd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_146314ac52h261wd"
      Public Shared ReferenciaServidor$ = "pr_40040212261"
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
      Public Class RegistroDeActividadEnRegistrosC
          Public HaImprimido As Boolean
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaPermisoPuntual As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaElemento As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaRegistroDeAccesoSesion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaDato_UTC As Date
          Public ElementoNombre As String
          Public FechaAlta_UTC As Date
          Public EmpleadoTieneAccesoWeb As Boolean
          Public VecesFoco As Integer
          Public SegundosAbierto As Integer
          Public SegundosActividad As Integer
          Public ReferenciaSeccion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FinalizacionInesperada As Boolean
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public TipoDeAccion As Integer
          Public ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public TiempoEjecucion As Decimal
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
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
      Public Class RegistroDeActividadEnRegistros_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
        Public ReadOnly property HaImprimido As Boolean
            get
                return me.GetValue_Boolean("pr_40a64ccx59wc")
            End Get   
        End Property
        Public ReadOnly property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_146310243ex306wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaPermisoPuntual As Guid
            get
                return me.GetValue_Guid("pr_73b8379wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaElemento As Guid
            get
                return me.GetValue_Guid("pr_407fc81x1a3wc")
            End Get   
        End Property
        Public ReadOnly property ReferenciaRegistroDeAccesoSesion As Guid
            get
                return me.GetValue_Guid("pr_185b34608cx16bwd")
            End Get   
        End Property
        Public ReadOnly property FechaDato_UTC As Date
            get
                return me.GetValue_DateTime("pr_1463102482xbcwd")
            End Get   
        End Property
        Public ReadOnly property ElementoNombre As String
            get
                return me.GetValue_String("pr_47137adx73wc")
            End Get   
        End Property
        Public ReadOnly property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_14c9f3e26dg13bwd")
            End Get   
        End Property
          Public property EmpleadoTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_1464b59d72x51wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_1464b59d72x51wd", value)
            End Set
          End Property
        Public ReadOnly property VecesFoco As Integer
            get
                return me.GetValue_Integer("pr_407faadx2a4wc")
            End Get   
        End Property
        Public ReadOnly property SegundosAbierto As Integer
            get
                return me.GetValue_Integer("pr_407fa69x1e3wc")
            End Get   
        End Property
        Public ReadOnly property SegundosActividad As Integer
            get
                return me.GetValue_Integer("pr_407fa49x391wc")
            End Get   
        End Property
        Public ReadOnly property ReferenciaSeccion As Guid
            get
                return me.GetValue_Guid("pr_407fc0ex312wc")
            End Get   
        End Property
        Public ReadOnly property FinalizacionInesperada As Boolean
            get
                return me.GetValue_Boolean("pr_4d832fcx2fawc")
            End Get   
        End Property
        Public ReadOnly property ReferenciaEmpleadoPrincipal As Guid
            get
                return me.GetValue_Guid("pr_1464b41092x328wd")
            End Get   
        End Property
        Public ReadOnly property TipoDeAccion As Integer
            get
                return me.GetValue_Integer("pr_7c20cf7wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaUbicacionPrincipal As Guid
            get
                return me.GetValue_Guid("pr_1464b410d0x38cwd")
            End Get   
        End Property
        Public ReadOnly property TiempoEjecucion As Decimal
            get
                return me.GetValue_Decimal("pr_4d83377x2a6wc")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_146310256ex24dwd")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_776aebawd")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_146314ac52h261wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_146314ac52h261wd", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaServidor As Guid
            get
                return me.GetValue_Guid("pr_40040212261")
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
