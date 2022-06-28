Partial Public Class SeccionesD
  Public Class RegistrosDeActividadDeInformesD
      Public Shared _SeccionID As String = "de9186ea-dc29-4078-bfda-0c7f0cb82fb6"
      Public Shared _SeccionIDGUID As New Guid("de9186ea-dc29-4078-bfda-0c7f0cb82fb6")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As RegistrosDeActividadDeInformes_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, RegistrosDeActividadDeInformesES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New RegistrosDeActividadDeInformes_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As RegistrosDeActividadDeInformes_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, RegistrosDeActividadDeInformesES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New RegistrosDeActividadDeInformes_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class RegistrosDeActividadDeInformesES
          Public shared _SeccionID as Guid = New Guid("de9186ea-dc29-4078-bfda-0c7f0cb82fb6")
          Public shared _Tabla$ = "tpr_40a1e3fwc"
      Public Shared FinalizacionInesperada$ = "pr_4d84155x34cwc"
      Public Shared FechaDato_UTC$ = "pr_1463102f73x1e4wd"
      Public Shared Pagina$ = "pr_40a240bx2a2wc"
      Public Shared TiempoActividadSegundo$ = "pr_40a23e2x3cdwc"
      Public Shared FechaAlta_UTC$ = "pr_14c9f3e43bx101wd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_1464b598fdh3e0wd"
      Public Shared ReferenciaPermisoPuntual$ = "pr_7c20d01wd"
      Public Shared HaImprimido$ = "pr_40a6468xf1wc"
      Public Shared ReferenciaAutorDelAlta$ = "pr_1463102f2ex39cwd"
      Public Shared TiempoEjecucion$ = "pr_4d8406dx301wc"
      Public Shared ReferenciaInforme$ = "pr_40a22c4x241wc"
      Public Shared DuracionVisitaSegundos$ = "pr_40a239bx155wc"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_14631491edh3a4wd"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_1464b4143exfcwd"
      Public Shared HoraLocal$ = "pr_776aeaawd"
      Public Shared ReferenciaDestinador$ = "pr_1463103011ge9wd"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_1464b413bah2f7wd"
      Public Shared ReferenciaRegistroDeAccesoSesion$ = "pr_185b31d232x2cwd"
      Public Shared ReferenciaServidor$ = "pr_50040212262"
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
      Public Class RegistrosDeActividadDeInformesC
          Public FinalizacionInesperada As Boolean
          Public FechaDato_UTC As Date
          Public Pagina As Integer
          Public TiempoActividadSegundo As Integer
          Public FechaAlta_UTC As Date
          Public EmpleadoTieneAccesoWeb As Boolean
          Public ReferenciaPermisoPuntual As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HaImprimido As Boolean
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public TiempoEjecucion As Decimal
          Public ReferenciaInforme As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public DuracionVisitaSegundos As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaRegistroDeAccesoSesion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
      Public Class RegistrosDeActividadDeInformes_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
        Public ReadOnly property FinalizacionInesperada As Boolean
            get
                return me.GetValue_Boolean("pr_4d84155x34cwc")
            End Get   
        End Property
        Public ReadOnly property FechaDato_UTC As Date
            get
                return me.GetValue_DateTime("pr_1463102f73x1e4wd")
            End Get   
        End Property
        Public ReadOnly property Pagina As Integer
            get
                return me.GetValue_Integer("pr_40a240bx2a2wc")
            End Get   
        End Property
        Public ReadOnly property TiempoActividadSegundo As Integer
            get
                return me.GetValue_Integer("pr_40a23e2x3cdwc")
            End Get   
        End Property
        Public ReadOnly property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_14c9f3e43bx101wd")
            End Get   
        End Property
          Public property EmpleadoTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_1464b598fdh3e0wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_1464b598fdh3e0wd", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaPermisoPuntual As Guid
            get
                return me.GetValue_Guid("pr_7c20d01wd")
            End Get   
        End Property
        Public ReadOnly property HaImprimido As Boolean
            get
                return me.GetValue_Boolean("pr_40a6468xf1wc")
            End Get   
        End Property
        Public ReadOnly property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_1463102f2ex39cwd")
            End Get   
        End Property
        Public ReadOnly property TiempoEjecucion As Decimal
            get
                return me.GetValue_Decimal("pr_4d8406dx301wc")
            End Get   
        End Property
        Public ReadOnly property ReferenciaInforme As Guid
            get
                return me.GetValue_Guid("pr_40a22c4x241wc")
            End Get   
        End Property
        Public ReadOnly property DuracionVisitaSegundos As Integer
            get
                return me.GetValue_Integer("pr_40a239bx155wc")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_14631491edh3a4wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_14631491edh3a4wd", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaUbicacionPrincipal As Guid
            get
                return me.GetValue_Guid("pr_1464b4143exfcwd")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_776aeaawd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_1463103011ge9wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaEmpleadoPrincipal As Guid
            get
                return me.GetValue_Guid("pr_1464b413bah2f7wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaRegistroDeAccesoSesion As Guid
            get
                return me.GetValue_Guid("pr_185b31d232x2cwd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaServidor As Guid
            get
                return me.GetValue_Guid("pr_50040212262")
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
