Partial Public Class SeccionesD
  Public Class ModulosD
      Public Shared _SeccionID As String = "ce982846-8dff-4479-bdad-ad3e59e4a629"
      Public Shared _SeccionIDGUID As New Guid("ce982846-8dff-4479-bdad-ad3e59e4a629")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As Modulos_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, ModulosES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New Modulos_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As Modulos_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, ModulosES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New Modulos_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class ModulosES
          Public shared _SeccionID as Guid = New Guid("ce982846-8dff-4479-bdad-ad3e59e4a629")
          Public shared _Tabla$ = "tpr_558dd58wd"
      Public Shared ReferenciaContenidoDeModulo$ = "pr_782d849wd"
      Public Shared RevisionDinaup$ = "pr_151929289ax1f1wd"
      Public Shared ImportePrecio$ = "pr_1519267a78x10dwd"
      Public Shared IdentificadorDeAutor$ = "pr_14fee48cb3x177wd"
      Public Shared Grupo$ = "pr_1516c60518x26wd"
      Public Shared VersionDinaup$ = "pr_151927f87ax2c4wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_14e352981eg3cwd"
      Public Shared TamañoMegabytes$ = "pr_14fefc5b23x1d1wd"
      Public Shared ModulosDependientes$ = "pr_151923d5f0x311wd"
      Public Shared Instalado$ = "pr_1516ad6886xe4wd"
      Public Shared ReferenciaDestinador$ = "pr_14e3351692x88wd"
      Public Shared HoraLocal$ = "pr_776af3cwd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_14e33515b1x399wd"
      Public Shared FechaDeInstalacion_UTC$ = "pr_14fe328509x2edwd"
      Public Shared Version$ = "pr_14fe359f65x1ffwd"
      Public Shared FechaDePublicacion_UTC$ = "pr_14fe3193eex3d4wd"
      Public Shared Autor$ = "pr_14fe2ef494x3bawd"
      Public Shared Descripcion$ = "pr_15191dddaax1d6wd"
      Public Shared FechaAlta_UTC$ = "pr_14e3351614xfwd"
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
      Public Class ModulosC
          Public ReferenciaContenidoDeModulo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public RevisionDinaup As String
          Public ImportePrecio As Decimal
          Public IdentificadorDeAutor As Integer
          Public Grupo As String
          Public VersionDinaup As Decimal
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public TamañoMegabytes As Decimal
          Public ModulosDependientes As String
          Public Instalado As Boolean
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaDeInstalacion_UTC As Date
          Public Version As Integer
          Public FechaDePublicacion_UTC As Date
          Public Autor As String
          Public Descripcion As String
          Public FechaAlta_UTC As Date
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
      Public Class Modulos_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
          Public property ReferenciaContenidoDeModulo As Guid
            get
                return me.GetValue_Guid("pr_782d849wd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_782d849wd", value)
            End Set
          End Property
        Public ReadOnly property RevisionDinaup As String
            get
                return me.GetValue_String("pr_151929289ax1f1wd")
            End Get   
        End Property
        Public ReadOnly property ImportePrecio As Decimal
            get
                return me.GetValue_Decimal("pr_1519267a78x10dwd")
            End Get   
        End Property
        Public ReadOnly property IdentificadorDeAutor As Integer
            get
                return me.GetValue_Integer("pr_14fee48cb3x177wd")
            End Get   
        End Property
        Public ReadOnly property Grupo As String
            get
                return me.GetValue_String("pr_1516c60518x26wd")
            End Get   
        End Property
        Public ReadOnly property VersionDinaup As Decimal
            get
                return me.GetValue_Decimal("pr_151927f87ax2c4wd")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_14e352981eg3cwd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_14e352981eg3cwd", value)
            End Set
          End Property
        Public ReadOnly property TamañoMegabytes As Decimal
            get
                return me.GetValue_Decimal("pr_14fefc5b23x1d1wd")
            End Get   
        End Property
        Public ReadOnly property ModulosDependientes As String
            get
                return me.GetValue_String("pr_151923d5f0x311wd")
            End Get   
        End Property
        Public ReadOnly property Instalado As Boolean
            get
                return me.GetValue_Boolean("pr_1516ad6886xe4wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_14e3351692x88wd")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_776af3cwd")
            End Get   
        End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_14e33515b1x399wd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_14e33515b1x399wd", value)
            End Set
          End Property
        Public ReadOnly property FechaDeInstalacion_UTC As Date
            get
                return me.GetValue_DateTime("pr_14fe328509x2edwd")
            End Get   
        End Property
        Public ReadOnly property Version As Integer
            get
                return me.GetValue_Integer("pr_14fe359f65x1ffwd")
            End Get   
        End Property
        Public ReadOnly property FechaDePublicacion_UTC As Date
            get
                return me.GetValue_DateTime("pr_14fe3193eex3d4wd")
            End Get   
        End Property
        Public ReadOnly property Autor As String
            get
                return me.GetValue_String("pr_14fe2ef494x3bawd")
            End Get   
        End Property
        Public ReadOnly property Descripcion As String
            get
                return me.GetValue_String("pr_15191dddaax1d6wd")
            End Get   
        End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_14e3351614xfwd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_14e3351614xfwd", value)
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
