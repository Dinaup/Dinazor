Partial Public Class SeccionesD
  Public Class RegistrosDeActividadDeServidorD
      Public Shared _SeccionID As String = "2463c953-c539-40b9-998c-ad290b2c5b41"
      Public Shared _SeccionIDGUID As New Guid("2463c953-c539-40b9-998c-ad290b2c5b41")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As RegistrosDeActividadDeServidor_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, RegistrosDeActividadDeServidorES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New RegistrosDeActividadDeServidor_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As RegistrosDeActividadDeServidor_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, RegistrosDeActividadDeServidorES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New RegistrosDeActividadDeServidor_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class RegistrosDeActividadDeServidorES
          Public shared _SeccionID as Guid = New Guid("2463c953-c539-40b9-998c-ad290b2c5b41")
          Public shared _Tabla$ = "tpr_70b1f89xd"
      Public Shared Idioma$ = "pr_70b22e9wd"
      Public Shared MemoriaGigabyte$ = "pr_70b22fdwd"
      Public Shared Detalles$ = "pr_70b2315wd"
      Public Shared NombreDeEquipo$ = "pr_70b22e1wd"
      Public Shared EspacioTotalUnidadC$ = "pr_70b2301wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_70b1fe5wd"
      Public Shared RevisionDinaup$ = "pr_70b230dwd"
      Public Shared Plataforma$ = "pr_70b22e5wd"
      Public Shared HoraLocal$ = "pr_776ae1ewd"
      Public Shared ReferenciaDestinador$ = "pr_70b1fb1wd"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_70b1f91wd"
      Public Shared VersionDinaup$ = "pr_70b2309wd"
      Public Shared VersionSistemaOperativo$ = "pr_70b22f1wd"
      Public Shared Procesador$ = "pr_70b22f5wd"
      Public Shared VersionSincronizabilidad$ = "pr_70daa64wd"
      Public Shared EspacioDisponibleUnidadC$ = "pr_70b2305wd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_70b1f95wd"
      Public Shared VersionMinima$ = "pr_70daa60wd"
      Public Shared TiempoDeInicioSegundos$ = "pr_70b2311wd"
      Public Shared ActualizacionesImportantesDeWindowsPendientesDeInstalar$ = "pr_70bf6a0wd"
      Public Shared EsPropioSRV$ = "pr_70dae47wd"
      Public Shared FechaAlta_UTC$ = "pr_70b1fa5wd"
      Public Shared Procesadores$ = "pr_70b22f9wd"
      Public Shared FechaDato_UTC$ = "pr_70b1f99wd"
      Public Shared SistemaOperativo$ = "pr_70b22edwd"
      Public Shared ReferenciaServidor$ = "pr_60040209452"
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
      Public Class RegistrosDeActividadDeServidorC
          Public Idioma As String
          Public MemoriaGigabyte As Integer
          Public Detalles As String
          Public NombreDeEquipo As String
          Public EspacioTotalUnidadC As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public RevisionDinaup As Decimal
          Public Plataforma As String
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public VersionDinaup As Decimal
          Public VersionSistemaOperativo As String
          Public Procesador As String
          Public VersionSincronizabilidad As Decimal
          Public EspacioDisponibleUnidadC As Integer
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public VersionMinima As Decimal
          Public TiempoDeInicioSegundos As Decimal
          Public ActualizacionesImportantesDeWindowsPendientesDeInstalar As Boolean
          Public EsPropioSRV As Boolean
          Public FechaAlta_UTC As Date
          Public Procesadores As Integer
          Public FechaDato_UTC As Date
          Public SistemaOperativo As String
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
      Public Class RegistrosDeActividadDeServidor_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
        Public ReadOnly property Idioma As String
            get
                return me.GetValue_String("pr_70b22e9wd")
            End Get   
        End Property
        Public ReadOnly property MemoriaGigabyte As Integer
            get
                return me.GetValue_Integer("pr_70b22fdwd")
            End Get   
        End Property
        Public ReadOnly property Detalles As String
            get
                return me.GetValue_String("pr_70b2315wd")
            End Get   
        End Property
        Public ReadOnly property NombreDeEquipo As String
            get
                return me.GetValue_String("pr_70b22e1wd")
            End Get   
        End Property
        Public ReadOnly property EspacioTotalUnidadC As Integer
            get
                return me.GetValue_Integer("pr_70b2301wd")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_70b1fe5wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_70b1fe5wd", value)
            End Set
          End Property
        Public ReadOnly property RevisionDinaup As Decimal
            get
                return me.GetValue_Decimal("pr_70b230dwd")
            End Get   
        End Property
        Public ReadOnly property Plataforma As String
            get
                return me.GetValue_String("pr_70b22e5wd")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_776ae1ewd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_70b1fb1wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaUbicacionPrincipal As Guid
            get
                return me.GetValue_Guid("pr_70b1f91wd")
            End Get   
        End Property
        Public ReadOnly property VersionDinaup As Decimal
            get
                return me.GetValue_Decimal("pr_70b2309wd")
            End Get   
        End Property
        Public ReadOnly property VersionSistemaOperativo As String
            get
                return me.GetValue_String("pr_70b22f1wd")
            End Get   
        End Property
        Public ReadOnly property Procesador As String
            get
                return me.GetValue_String("pr_70b22f5wd")
            End Get   
        End Property
        Public ReadOnly property VersionSincronizabilidad As Decimal
            get
                return me.GetValue_Decimal("pr_70daa64wd")
            End Get   
        End Property
        Public ReadOnly property EspacioDisponibleUnidadC As Integer
            get
                return me.GetValue_Integer("pr_70b2305wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_70b1f95wd")
            End Get   
        End Property
        Public ReadOnly property VersionMinima As Decimal
            get
                return me.GetValue_Decimal("pr_70daa60wd")
            End Get   
        End Property
        Public ReadOnly property TiempoDeInicioSegundos As Decimal
            get
                return me.GetValue_Decimal("pr_70b2311wd")
            End Get   
        End Property
        Public ReadOnly property ActualizacionesImportantesDeWindowsPendientesDeInstalar As Boolean
            get
                return me.GetValue_Boolean("pr_70bf6a0wd")
            End Get   
        End Property
        Public ReadOnly property EsPropioSRV As Boolean
            get
                return me.GetValue_Boolean("pr_70dae47wd")
            End Get   
        End Property
        Public ReadOnly property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_70b1fa5wd")
            End Get   
        End Property
        Public ReadOnly property Procesadores As Integer
            get
                return me.GetValue_Integer("pr_70b22f9wd")
            End Get   
        End Property
        Public ReadOnly property FechaDato_UTC As Date
            get
                return me.GetValue_DateTime("pr_70b1f99wd")
            End Get   
        End Property
        Public ReadOnly property SistemaOperativo As String
            get
                return me.GetValue_String("pr_70b22edwd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaServidor As Guid
            get
                return me.GetValue_Guid("pr_60040209452")
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
