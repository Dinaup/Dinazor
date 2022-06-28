Partial Public Class SeccionesD
  Public Class PersonalizacionDeCamposD
      Public Shared _SeccionID As String = "68047911-e3a0-4347-82a8-af51dba12883"
      Public Shared _SeccionIDGUID As New Guid("68047911-e3a0-4347-82a8-af51dba12883")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As PersonalizacionDeCampos_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, PersonalizacionDeCamposES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New PersonalizacionDeCampos_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As PersonalizacionDeCampos_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, PersonalizacionDeCamposES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New PersonalizacionDeCampos_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class PersonalizacionDeCamposES
          Public shared _SeccionID as Guid = New Guid("68047911-e3a0-4347-82a8-af51dba12883")
          Public shared _Tabla$ = "tpr_780923cxd"
      Public Shared ExtensionesPermitidas$ = "pr_7851a83wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_780926ewd"
      Public Shared ImagenAltoMaximo$ = "pr_7851a77wd"
      Public Shared ReferenciaDestinador$ = "pr_7809252wd"
      Public Shared HoraLocal$ = "pr_7809246wd"
      Public Shared ImagenAltoMinimo$ = "pr_7851a79wd"
      Public Shared ReferenciaIcono$ = "pr_7851a8bwd"
      Public Shared ReferenciaCampo$ = "pr_7809278wd"
      Public Shared MensajeFoco$ = "pr_7851a87wd"
      Public Shared Descripcion$ = "pr_7851a93wd"
      Public Shared Etiqueta$ = "pr_7851a8dwd"
      Public Shared ImagenCompatibleConRepresentacionCircular$ = "pr_792a86bwd"
      Public Shared CriterioSugerencias$ = "pr_7851a85wd"
      Public Shared TamañoMaximo$ = "pr_7851a7fwd"
      Public Shared EvaluarEnAgenda$ = "pr_7809276wd"
      Public Shared CompresionDeImagenes$ = "pr_7851a81wd"
      Public Shared ImagenAnchoMaximo$ = "pr_7851a7bwd"
      Public Shared EtiquetaAbreviada$ = "pr_7851a8fwd"
      Public Shared FechaAlta_UTC$ = "pr_780924cwd"
      Public Shared ReferenciaSeccionSeleccionPreferente$ = "pr_78513bawd"
      Public Shared ExportarEnModulos$ = "pr_7809248wd"
      Public Shared Observaciones$ = "pr_7851a91wd"
      Public Shared CriterioDeIndexacion$ = "pr_7851a89wd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_7809242wd"
      Public Shared ImagenAnchoMinimo$ = "pr_7851a7dwd"
      Public Shared KeyWord$ = "pr_20040430413"
      Public Shared ReferenciaSeccionDeCampo$ = "pr_20040430412"
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
      Public Class PersonalizacionDeCamposC
          Public ExtensionesPermitidas As String
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ImagenAltoMaximo As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public ImagenAltoMinimo As Integer
          Public ReferenciaIcono As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaCampo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public MensajeFoco As String
          Public Descripcion As String
          Public Etiqueta As String
          Public ImagenCompatibleConRepresentacionCircular As Boolean
          Public CriterioSugerencias As Integer
          Public TamañoMaximo As Integer
          Public EvaluarEnAgenda As Integer
          Public CompresionDeImagenes As Integer
          Public ImagenAnchoMaximo As Integer
          Public EtiquetaAbreviada As String
          Public FechaAlta_UTC As Date
          Public ReferenciaSeccionSeleccionPreferente As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Observaciones As String
          Public CriterioDeIndexacion As Integer
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ImagenAnchoMinimo As Integer
          Public KeyWord As String
          Public ReferenciaSeccionDeCampo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
      Public Class PersonalizacionDeCampos_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
        Public ReadOnly property ExtensionesPermitidas As String
            get
                return me.GetValue_String("pr_7851a83wd")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_780926ewd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_780926ewd", value)
            End Set
          End Property
        Public ReadOnly property ImagenAltoMaximo As Integer
            get
                return me.GetValue_Integer("pr_7851a77wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_7809252wd")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_7809246wd")
            End Get   
        End Property
        Public ReadOnly property ImagenAltoMinimo As Integer
            get
                return me.GetValue_Integer("pr_7851a79wd")
            End Get   
        End Property
          Public property ReferenciaIcono As Guid
            get
                return me.GetValue_Guid("pr_7851a8bwd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_7851a8bwd", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaCampo As Guid
            get
                return me.GetValue_Guid("pr_7809278wd")
            End Get   
        End Property
        Public ReadOnly property MensajeFoco As String
            get
                return me.GetValue_String("pr_7851a87wd")
            End Get   
        End Property
        Public ReadOnly property Descripcion As String
            get
                return me.GetValue_String("pr_7851a93wd")
            End Get   
        End Property
        Public ReadOnly property Etiqueta As String
            get
                return me.GetValue_String("pr_7851a8dwd")
            End Get   
        End Property
        Public ReadOnly property ImagenCompatibleConRepresentacionCircular As Boolean
            get
                return me.GetValue_Boolean("pr_792a86bwd")
            End Get   
        End Property
        Public ReadOnly property CriterioSugerencias As Integer
            get
                return me.GetValue_Integer("pr_7851a85wd")
            End Get   
        End Property
        Public ReadOnly property TamañoMaximo As Integer
            get
                return me.GetValue_Integer("pr_7851a7fwd")
            End Get   
        End Property
        Public ReadOnly property EvaluarEnAgenda As Integer
            get
                return me.GetValue_Integer("pr_7809276wd")
            End Get   
        End Property
        Public ReadOnly property CompresionDeImagenes As Integer
            get
                return me.GetValue_Integer("pr_7851a81wd")
            End Get   
        End Property
        Public ReadOnly property ImagenAnchoMaximo As Integer
            get
                return me.GetValue_Integer("pr_7851a7bwd")
            End Get   
        End Property
        Public ReadOnly property EtiquetaAbreviada As String
            get
                return me.GetValue_String("pr_7851a8fwd")
            End Get   
        End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_780924cwd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_780924cwd", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaSeccionSeleccionPreferente As Guid
            get
                return me.GetValue_Guid("pr_78513bawd")
            End Get   
        End Property
        Public ReadOnly property Observaciones As String
            get
                return me.GetValue_String("pr_7851a91wd")
            End Get   
        End Property
        Public ReadOnly property CriterioDeIndexacion As Integer
            get
                return me.GetValue_Integer("pr_7851a89wd")
            End Get   
        End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_7809242wd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_7809242wd", value)
            End Set
          End Property
        Public ReadOnly property ImagenAnchoMinimo As Integer
            get
                return me.GetValue_Integer("pr_7851a7dwd")
            End Get   
        End Property
          Public property KeyWord As String
            get
                return me.GetValue_String("pr_20040430413")
            End Get
            Set(value As String)
                me.SetValue_String("pr_20040430413", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaSeccionDeCampo As Guid
            get
                return me.GetValue_Guid("pr_20040430412")
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
