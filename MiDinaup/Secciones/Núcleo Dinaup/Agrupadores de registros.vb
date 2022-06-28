Partial Public Class SeccionesD
  Public Class AgrupadoresDeRegistrosD
      Public Shared _SeccionID As String = "035e845d-71cf-41c9-8cb5-26035a509003"
      Public Shared _SeccionIDGUID As New Guid("035e845d-71cf-41c9-8cb5-26035a509003")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As AgrupadoresDeRegistros_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, AgrupadoresDeRegistrosES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New AgrupadoresDeRegistros_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As AgrupadoresDeRegistros_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, AgrupadoresDeRegistrosES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New AgrupadoresDeRegistros_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class AgrupadoresDeRegistrosES
          Public shared _SeccionID as Guid = New Guid("035e845d-71cf-41c9-8cb5-26035a509003")
          Public shared _Tabla$ = "tpr_7795803xd"
      Public Shared ReferenciaDestinador$ = "pr_7795819wd"
      Public Shared CantidadElementos$ = "pr_77c1040wd"
      Public Shared HoraLocal$ = "pr_779580dwd"
      Public Shared ReferenciaSeccionDeGrupo$ = "pr_77968a5wd"
      Public Shared FechaUltimaOptimizacionDeIndice_UTC$ = "pr_77c1d10wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_7795835wd"
      Public Shared AgruparTodo$ = "pr_79aab74wd"
      Public Shared CampoValor$ = "pr_7800d76wd"
      Public Shared ReferenciaCampoValorSeccion$ = "pr_77bd7cdwd"
      Public Shared ExportarEnModulos$ = "pr_779580fwd"
      Public Shared FechaAlta_UTC$ = "pr_7795813wd"
      Public Shared Desactivar$ = "pr_79bcbafwd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_7795809wd"
      Public Shared CampoDeGrupo$ = "pr_77968a7wd"
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
      Public Class AgrupadoresDeRegistrosC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public CantidadElementos As Integer
          Public HoraLocal As Integer
          Public ReferenciaSeccionDeGrupo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaUltimaOptimizacionDeIndice_UTC As Date
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public AgruparTodo As Boolean
          Public CampoValor As String
          Public ReferenciaCampoValorSeccion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public Desactivar As Boolean
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public CampoDeGrupo As String
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
      Public Class AgrupadoresDeRegistros_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_7795819wd")
            End Get   
        End Property
        Public ReadOnly property CantidadElementos As Integer
            get
                return me.GetValue_Integer("pr_77c1040wd")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_779580dwd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaSeccionDeGrupo As Guid
            get
                return me.GetValue_Guid("pr_77968a5wd")
            End Get   
        End Property
        Public ReadOnly property FechaUltimaOptimizacionDeIndice_UTC As Date
            get
                return me.GetValue_DateTime("pr_77c1d10wd")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_7795835wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_7795835wd", value)
            End Set
          End Property
        Public ReadOnly property AgruparTodo As Boolean
            get
                return me.GetValue_Boolean("pr_79aab74wd")
            End Get   
        End Property
        Public ReadOnly property CampoValor As String
            get
                return me.GetValue_String("pr_7800d76wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaCampoValorSeccion As Guid
            get
                return me.GetValue_Guid("pr_77bd7cdwd")
            End Get   
        End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_7795813wd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_7795813wd", value)
            End Set
          End Property
        Public ReadOnly property Desactivar As Boolean
            get
                return me.GetValue_Boolean("pr_79bcbafwd")
            End Get   
        End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_7795809wd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_7795809wd", value)
            End Set
          End Property
        Public ReadOnly property CampoDeGrupo As String
            get
                return me.GetValue_String("pr_77968a7wd")
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
