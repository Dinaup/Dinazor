Partial Public Class SeccionesD
  Public Class RegistrosDeActividadDeArchivosD
      Public Shared _SeccionID As String = "a0aa8e03-4fe5-4e52-9d89-ec5f6d237212"
      Public Shared _SeccionIDGUID As New Guid("a0aa8e03-4fe5-4e52-9d89-ec5f6d237212")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As RegistrosDeActividadDeArchivos_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, RegistrosDeActividadDeArchivosES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New RegistrosDeActividadDeArchivos_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As RegistrosDeActividadDeArchivos_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, RegistrosDeActividadDeArchivosES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New RegistrosDeActividadDeArchivos_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class RegistrosDeActividadDeArchivosES
          Public shared _SeccionID as Guid = New Guid("a0aa8e03-4fe5-4e52-9d89-ec5f6d237212")
          Public shared _Tabla$ = "tpr_76da49fxd"
      Public Shared ReferenciaArchivo$ = "pr_76df4cbwd"
      Public Shared NombreDeRegistroDeOrigen$ = "pr_7c28356wd"
      Public Shared SegundosActividad$ = "pr_7c49e39wd"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_76da4cbwd"
      Public Shared TransferenciaDeDatosKBs$ = "pr_7c343b0wd"
      Public Shared HoraLocal$ = "pr_77611e4wd"
      Public Shared ReferenciaDestinador$ = "pr_76da4efwd"
      Public Shared DuracionTransferenciaDeDatos$ = "pr_7c343aewd"
      Public Shared ReferenciaRegistroOrigenAccesoSeccion$ = "pr_7c28354wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_76da507wd"
      Public Shared ReferenciaRegistroDeAccesoSesion$ = "pr_7c28350wd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_76da4d3wd"
      Public Shared TipoDeEvento$ = "pr_7c34961wd"
      Public Shared FinalizacionInesperada$ = "pr_7c4970dwd"
      Public Shared SegundosAbierto$ = "pr_7c49e3bwd"
      Public Shared FechaDato_UTC$ = "pr_76da4d7wd"
      Public Shared FechaAlta_UTC$ = "pr_76da4e3wd"
      Public Shared TiempoEjecucion$ = "pr_7c4970bwd"
      Public Shared VecesFoco$ = "pr_7c49e37wd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_76da4ffwd"
      Public Shared ReferenciaRegistrosOrigenAcceso$ = "pr_7c28352wd"
      Public Shared ReferenciaServidor$ = "pr_60040212261"
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
      Public Class RegistrosDeActividadDeArchivosC
          Public ReferenciaArchivo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public NombreDeRegistroDeOrigen As String
          Public SegundosActividad As Integer
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public TransferenciaDeDatosKBs As Decimal
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public DuracionTransferenciaDeDatos As Integer
          Public ReferenciaRegistroOrigenAccesoSeccion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaRegistroDeAccesoSesion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public TipoDeEvento As Integer
          Public FinalizacionInesperada As Boolean
          Public SegundosAbierto As Integer
          Public FechaDato_UTC As Date
          Public FechaAlta_UTC As Date
          Public TiempoEjecucion As Decimal
          Public VecesFoco As Integer
          Public EmpleadoTieneAccesoWeb As Boolean
          Public ReferenciaRegistrosOrigenAcceso As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
      Public Class RegistrosDeActividadDeArchivos_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
          Public property ReferenciaArchivo As Guid
            get
                return me.GetValue_Guid("pr_76df4cbwd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_76df4cbwd", value)
            End Set
          End Property
        Public ReadOnly property NombreDeRegistroDeOrigen As String
            get
                return me.GetValue_String("pr_7c28356wd")
            End Get   
        End Property
        Public ReadOnly property SegundosActividad As Integer
            get
                return me.GetValue_Integer("pr_7c49e39wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaEmpleadoPrincipal As Guid
            get
                return me.GetValue_Guid("pr_76da4cbwd")
            End Get   
        End Property
        Public ReadOnly property TransferenciaDeDatosKBs As Decimal
            get
                return me.GetValue_Decimal("pr_7c343b0wd")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_77611e4wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_76da4efwd")
            End Get   
        End Property
        Public ReadOnly property DuracionTransferenciaDeDatos As Integer
            get
                return me.GetValue_Integer("pr_7c343aewd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaRegistroOrigenAccesoSeccion As Guid
            get
                return me.GetValue_Guid("pr_7c28354wd")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_76da507wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_76da507wd", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaRegistroDeAccesoSesion As Guid
            get
                return me.GetValue_Guid("pr_7c28350wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_76da4d3wd")
            End Get   
        End Property
        Public ReadOnly property TipoDeEvento As Integer
            get
                return me.GetValue_Integer("pr_7c34961wd")
            End Get   
        End Property
        Public ReadOnly property FinalizacionInesperada As Boolean
            get
                return me.GetValue_Boolean("pr_7c4970dwd")
            End Get   
        End Property
        Public ReadOnly property SegundosAbierto As Integer
            get
                return me.GetValue_Integer("pr_7c49e3bwd")
            End Get   
        End Property
        Public ReadOnly property FechaDato_UTC As Date
            get
                return me.GetValue_DateTime("pr_76da4d7wd")
            End Get   
        End Property
        Public ReadOnly property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_76da4e3wd")
            End Get   
        End Property
        Public ReadOnly property TiempoEjecucion As Decimal
            get
                return me.GetValue_Decimal("pr_7c4970bwd")
            End Get   
        End Property
        Public ReadOnly property VecesFoco As Integer
            get
                return me.GetValue_Integer("pr_7c49e37wd")
            End Get   
        End Property
          Public property EmpleadoTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_76da4ffwd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_76da4ffwd", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaRegistrosOrigenAcceso As Guid
            get
                return me.GetValue_Guid("pr_7c28352wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaServidor As Guid
            get
                return me.GetValue_Guid("pr_60040212261")
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
