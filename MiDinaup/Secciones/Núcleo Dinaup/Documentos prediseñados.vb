Partial Public Class SeccionesD
  Public Class DocumentosPrediseñadosD
      Public Shared _SeccionID As String = "3218a172-ad32-412b-b34c-9283962f5e83"
      Public Shared _SeccionIDGUID As New Guid("3218a172-ad32-412b-b34c-9283962f5e83")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As DocumentosPrediseñados_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, DocumentosPrediseñadosES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New DocumentosPrediseñados_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As DocumentosPrediseñados_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, DocumentosPrediseñadosES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New DocumentosPrediseñados_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class DocumentosPrediseñadosES
          Public shared _SeccionID as Guid = New Guid("3218a172-ad32-412b-b34c-9283962f5e83")
          Public shared _Tabla$ = "tpr_50040237495"
      Public Shared ReferenciaDestinador$ = "pr_500402374913"
      Public Shared ExportarEnModulos$ = "pr_500402374911"
      Public Shared FechaAlta_UTC$ = "pr_500402374912"
      Public Shared ReferenciaAutorDelAlta$ = "pr_50040237498"
      Public Shared HoraLocal$ = "pr_500402374910"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_500402374924"
      Public Shared IdentificadorDeConfiguracionSha1$ = "pr_500402374927"
      Public Shared Configuracion$ = "pr_500402374926"
      Public Shared Version$ = "pr_60040237493"
      Public Shared ReferenciaDocumentoPrediseñadoPrimeraVersion$ = "pr_60040237495"
      Public Shared Tipo$ = "pr_20040237527"
      Public Shared Archivado$ = "pr_20040237671"
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
      Public Class DocumentosPrediseñadosC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public IdentificadorDeConfiguracionSha1 As String
          Public Configuracion As String
          Public Version As Integer
          Public ReferenciaDocumentoPrediseñadoPrimeraVersion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Tipo As Integer
          Public Archivado As Boolean
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
      Public Class DocumentosPrediseñados_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_500402374913")
            End Get   
        End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_500402374912")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_500402374912", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_50040237498")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_50040237498", value)
            End Set
          End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_500402374910")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_500402374924")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_500402374924", value)
            End Set
          End Property
          Public property IdentificadorDeConfiguracionSha1 As String
            get
                return me.GetValue_String("pr_500402374927")
            End Get
            Set(value As String)
                me.SetValue_String("pr_500402374927", value)
            End Set
          End Property
          Public property Configuracion As String
            get
                return me.GetValue_String("pr_500402374926")
            End Get
            Set(value As String)
                me.SetValue_String("pr_500402374926", value)
            End Set
          End Property
          Public property Version As Integer
            get
                return me.GetValue_Integer("pr_60040237493")
            End Get
            Set(value As Integer)
                me.SetValue_Integer("pr_60040237493", value)
            End Set
          End Property
          Public property ReferenciaDocumentoPrediseñadoPrimeraVersion As Guid
            get
                return me.GetValue_Guid("pr_60040237495")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_60040237495", value)
            End Set
          End Property
          Public property Tipo As Integer
            get
                return me.GetValue_Integer("pr_20040237527")
            End Get
            Set(value As Integer)
                me.SetValue_Integer("pr_20040237527", value)
            End Set
          End Property
          Public property Archivado As Boolean
            get
                return me.GetValue_Boolean("pr_20040237671")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_20040237671", value)
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
