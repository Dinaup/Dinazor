Partial Public Class SeccionesD
  Public Class FuncionesJSOND
      Public Shared _SeccionID As String = "94b3db6e-1ff2-417e-ba89-c5d888be6281"
      Public Shared _SeccionIDGUID As New Guid("94b3db6e-1ff2-417e-ba89-c5d888be6281")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As FuncionesJSON_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, FuncionesJSONES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New FuncionesJSON_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As FuncionesJSON_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, FuncionesJSONES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New FuncionesJSON_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class FuncionesJSONES
          Public shared _SeccionID as Guid = New Guid("94b3db6e-1ff2-417e-ba89-c5d888be6281")
          Public shared _Tabla$ = "tpr_60040133853"
      Public Shared Bloquear$ = "pr_50040133895"
      Public Shared ExportarEnModulos$ = "pr_600401338518"
      Public Shared ReferenciaDestinador$ = "pr_600401338520"
      Public Shared FechaAlta_UTC$ = "pr_600401338519"
      Public Shared ReferenciaAutorDelAlta$ = "pr_600401338515"
      Public Shared HoraLocal$ = "pr_600401338517"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_600401338526"
      Public Shared Configuracion$ = "pr_10040133862"
      Public Shared IdentificadorDeConfiguracionSha1$ = "pr_10040133864"
      Public Shared TipoDeAPI$ = "pr_30040134242"
      Public Shared ReferenciaSeccionDelAPI$ = "pr_30040134241"
      Public Shared InformacionAdicional$ = "pr_30040140483"
      Public Shared Categoria$ = "pr_50040140791"
      Public Shared FiltradoDeContenido$ = "pr_30040178441002"
      Public Shared ParametrosPersonalizados$ = "pr_60040373351"
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
      Public Class FuncionesJSONC
          Public Bloquear As Boolean
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public Configuracion As String
          Public IdentificadorDeConfiguracionSha1 As String
          Public TipoDeAPI As Integer
          Public ReferenciaSeccionDelAPI As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public InformacionAdicional As String
          Public Categoria As String
          Public FiltradoDeContenido As String
          Public ParametrosPersonalizados As String
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
      Public Class FuncionesJSON_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
          Public property Bloquear As Boolean
            get
                return me.GetValue_Boolean("pr_50040133895")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_50040133895", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_600401338520")
            End Get   
        End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_600401338519")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_600401338519", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_600401338515")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_600401338515", value)
            End Set
          End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_600401338517")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_600401338526")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_600401338526", value)
            End Set
          End Property
        Public ReadOnly property Configuracion As String
            get
                return me.GetValue_String("pr_10040133862")
            End Get   
        End Property
        Public ReadOnly property IdentificadorDeConfiguracionSha1 As String
            get
                return me.GetValue_String("pr_10040133864")
            End Get   
        End Property
        Public ReadOnly property TipoDeAPI As Integer
            get
                return me.GetValue_Integer("pr_30040134242")
            End Get   
        End Property
        Public ReadOnly property ReferenciaSeccionDelAPI As Guid
            get
                return me.GetValue_Guid("pr_30040134241")
            End Get   
        End Property
          Public property InformacionAdicional As String
            get
                return me.GetValue_String("pr_30040140483")
            End Get
            Set(value As String)
                me.SetValue_String("pr_30040140483", value)
            End Set
          End Property
          Public property Categoria As String
            get
                return me.GetValue_String("pr_50040140791")
            End Get
            Set(value As String)
                me.SetValue_String("pr_50040140791", value)
            End Set
          End Property
        Public ReadOnly property FiltradoDeContenido As String
            get
                return me.GetValue_String("pr_30040178441002")
            End Get   
        End Property
          Public property ParametrosPersonalizados As String
            get
                return me.GetValue_String("pr_60040373351")
            End Get
            Set(value As String)
                me.SetValue_String("pr_60040373351", value)
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
