Partial Public Class SeccionesD
  Public Class PuestosDeTrabajoD
      Public Shared _SeccionID As String = "a150171e-6bcc-47dd-a235-918b9883154e"
      Public Shared _SeccionIDGUID As New Guid("a150171e-6bcc-47dd-a235-918b9883154e")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As PuestosDeTrabajo_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, PuestosDeTrabajoES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New PuestosDeTrabajo_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As PuestosDeTrabajo_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, PuestosDeTrabajoES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New PuestosDeTrabajo_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class PuestosDeTrabajoES
          Public shared _SeccionID as Guid = New Guid("a150171e-6bcc-47dd-a235-918b9883154e")
          Public shared _Tabla$ = "tpr_441ce4bwc"
      Public Shared Plataforma$ = "pr_14878783aax1ebwd"
      Public Shared SistemaOperativo$ = "pr_14726eb53bx32wd"
      Public Shared MemoriaGigabyte$ = "pr_14726ce393x7ewd"
      Public Shared ReferenciaEmpleadoQueProcesoLaVinculacion$ = "pr_1472614c73x26dwd"
      Public Shared PuestoEnDesuso$ = "pr_147cb0c17cx39awd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_146310848ax262wd"
      Public Shared Procesador$ = "pr_148785a0c9x18ewd"
      Public Shared Bloqueado$ = "pr_147cb5778bxe4wd"
      Public Shared VersionEnUltimaConexion$ = "pr_14727a6962x397wd"
      Public Shared TokenDeIdentificacion$ = "pr_1472584b9ax2a0wd"
      Public Shared Procesadores$ = "pr_1487870e11x261wd"
      Public Shared EspacioDisponibleUnidadC$ = "pr_1472729dd6x63wd"
      Public Shared FechaAlta_UTC$ = "pr_14c9f3f2b7x32bwd"
      Public Shared Idioma$ = "pr_1487b8bf67x12ewd"
      Public Shared FechaDeVinculacion_UTC$ = "pr_14725cda53x2acwd"
      Public Shared ResolucionAncho$ = "pr_14878e20cax323wd"
      Public Shared ResolucionAlto$ = "pr_14878ed063x1aawd"
      Public Shared MotivoDeBloqueo$ = "pr_147cb50188x1eawd"
      Public Shared EspacioTotalUnidadC$ = "pr_148783f9f9x22fwd"
      Public Shared VersionSistemaOperativo$ = "pr_147cb20cbbx1e8wd"
      Public Shared NombreDeEquipo$ = "pr_147276d4c5x4cwd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_146314ad5ch142wd"
      Public Shared UltimaConexion_UTC$ = "pr_1472741fe1x28wd"
      Public Shared HoraLocal$ = "pr_776ae0ewd"
      Public Shared ReferenciaDestinador$ = "pr_1463108555x208wd"
      Public Shared EmpleadoQueProcesoLaVinculacionTieneAccesoWeb$ = "pr_1472617b07xb2wd"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_1464b42b99h1dawd"
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
      Public Class PuestosDeTrabajoC
          Public Plataforma As String
          Public SistemaOperativo As String
          Public MemoriaGigabyte As Decimal
          Public ReferenciaEmpleadoQueProcesoLaVinculacion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public PuestoEnDesuso As Boolean
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Procesador As String
          Public Bloqueado As Boolean
          Public VersionEnUltimaConexion As String
          Public TokenDeIdentificacion As String
          Public Procesadores As Decimal
          Public EspacioDisponibleUnidadC As Decimal
          Public FechaAlta_UTC As Date
          Public Idioma As String
          Public FechaDeVinculacion_UTC As Date
          Public ResolucionAncho As Decimal
          Public ResolucionAlto As Decimal
          Public MotivoDeBloqueo As String
          Public EspacioTotalUnidadC As Decimal
          Public VersionSistemaOperativo As String
          Public NombreDeEquipo As String
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public UltimaConexion_UTC As Date
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public EmpleadoQueProcesoLaVinculacionTieneAccesoWeb As Boolean
          Public ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
      Public Class PuestosDeTrabajo_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
        Public ReadOnly property Plataforma As String
            get
                return me.GetValue_String("pr_14878783aax1ebwd")
            End Get   
        End Property
        Public ReadOnly property SistemaOperativo As String
            get
                return me.GetValue_String("pr_14726eb53bx32wd")
            End Get   
        End Property
        Public ReadOnly property MemoriaGigabyte As Decimal
            get
                return me.GetValue_Decimal("pr_14726ce393x7ewd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaEmpleadoQueProcesoLaVinculacion As Guid
            get
                return me.GetValue_Guid("pr_1472614c73x26dwd")
            End Get   
        End Property
          Public property PuestoEnDesuso As Boolean
            get
                return me.GetValue_Boolean("pr_147cb0c17cx39awd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_147cb0c17cx39awd", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_146310848ax262wd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_146310848ax262wd", value)
            End Set
          End Property
        Public ReadOnly property Procesador As String
            get
                return me.GetValue_String("pr_148785a0c9x18ewd")
            End Get   
        End Property
          Public property Bloqueado As Boolean
            get
                return me.GetValue_Boolean("pr_147cb5778bxe4wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_147cb5778bxe4wd", value)
            End Set
          End Property
        Public ReadOnly property VersionEnUltimaConexion As String
            get
                return me.GetValue_String("pr_14727a6962x397wd")
            End Get   
        End Property
        Public ReadOnly property TokenDeIdentificacion As String
            get
                return me.GetValue_String("pr_1472584b9ax2a0wd")
            End Get   
        End Property
        Public ReadOnly property Procesadores As Decimal
            get
                return me.GetValue_Decimal("pr_1487870e11x261wd")
            End Get   
        End Property
        Public ReadOnly property EspacioDisponibleUnidadC As Decimal
            get
                return me.GetValue_Decimal("pr_1472729dd6x63wd")
            End Get   
        End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_14c9f3f2b7x32bwd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_14c9f3f2b7x32bwd", value)
            End Set
          End Property
        Public ReadOnly property Idioma As String
            get
                return me.GetValue_String("pr_1487b8bf67x12ewd")
            End Get   
        End Property
        Public ReadOnly property FechaDeVinculacion_UTC As Date
            get
                return me.GetValue_DateTime("pr_14725cda53x2acwd")
            End Get   
        End Property
        Public ReadOnly property ResolucionAncho As Decimal
            get
                return me.GetValue_Decimal("pr_14878e20cax323wd")
            End Get   
        End Property
        Public ReadOnly property ResolucionAlto As Decimal
            get
                return me.GetValue_Decimal("pr_14878ed063x1aawd")
            End Get   
        End Property
          Public property MotivoDeBloqueo As String
            get
                return me.GetValue_String("pr_147cb50188x1eawd")
            End Get
            Set(value As String)
                me.SetValue_String("pr_147cb50188x1eawd", value)
            End Set
          End Property
        Public ReadOnly property EspacioTotalUnidadC As Decimal
            get
                return me.GetValue_Decimal("pr_148783f9f9x22fwd")
            End Get   
        End Property
        Public ReadOnly property VersionSistemaOperativo As String
            get
                return me.GetValue_String("pr_147cb20cbbx1e8wd")
            End Get   
        End Property
        Public ReadOnly property NombreDeEquipo As String
            get
                return me.GetValue_String("pr_147276d4c5x4cwd")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_146314ad5ch142wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_146314ad5ch142wd", value)
            End Set
          End Property
        Public ReadOnly property UltimaConexion_UTC As Date
            get
                return me.GetValue_DateTime("pr_1472741fe1x28wd")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_776ae0ewd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_1463108555x208wd")
            End Get   
        End Property
          Public property EmpleadoQueProcesoLaVinculacionTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_1472617b07xb2wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_1472617b07xb2wd", value)
            End Set
          End Property
          Public property ReferenciaUbicacionPrincipal As Guid
            get
                return me.GetValue_Guid("pr_1464b42b99h1dawd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_1464b42b99h1dawd", value)
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
