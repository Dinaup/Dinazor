Partial Public Class SeccionesD
  Public Class ValoresEnumeracionesNativasD
      Public Shared _SeccionID As String = "53bdcc8e-5c1f-4bd4-9906-5cb86b6992d3"
      Public Shared _SeccionIDGUID As New Guid("53bdcc8e-5c1f-4bd4-9906-5cb86b6992d3")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As ValoresEnumeracionesNativas_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, ValoresEnumeracionesNativasES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New ValoresEnumeracionesNativas_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As ValoresEnumeracionesNativas_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, ValoresEnumeracionesNativasES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New ValoresEnumeracionesNativas_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class ValoresEnumeracionesNativasES
          Public shared _SeccionID as Guid = New Guid("53bdcc8e-5c1f-4bd4-9906-5cb86b6992d3")
          Public shared _Tabla$ = "tpr_50040447691"
      Public Shared ReferenciaDestinador$ = "pr_500404476916"
      Public Shared HoraLocal$ = "pr_500404476913"
      Public Shared ExportarEnModulos$ = "pr_500404476914"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_500404476927"
      Public Shared FechaAlta_UTC$ = "pr_500404476915"
      Public Shared ReferenciaAutorDelAlta$ = "pr_500404476911"
      Public Shared ValorNativo$ = "pr_500404476931"
      Public Shared IDEnumRolCampo$ = "pr_500404476932"
      Public Shared Descripcion$ = "pr_500404476935"
      Public Shared Titulo$ = "pr_500404476933"
      Public Shared EstiloTexto$ = "pr_60040447691"
      Public Shared ReferenciaEnumeracionNativa$ = "pr_500404476934"
      Public Shared Obsoleto$ = "pr_60040447693"
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
      Public Class ValoresEnumeracionesNativasC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public FechaAlta_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ValorNativo As Integer
          Public IDEnumRolCampo As Integer
          Public Descripcion As String
          Public Titulo As String
          Public EstiloTexto As Integer
          Public ReferenciaEnumeracionNativa As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Obsoleto As Boolean
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
      Public Class ValoresEnumeracionesNativas_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_500404476916")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_500404476913")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_500404476927")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_500404476927", value)
            End Set
          End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_500404476915")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_500404476915", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_500404476911")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_500404476911", value)
            End Set
          End Property
        Public ReadOnly property ValorNativo As Integer
            get
                return me.GetValue_Integer("pr_500404476931")
            End Get   
        End Property
        Public ReadOnly property IDEnumRolCampo As Integer
            get
                return me.GetValue_Integer("pr_500404476932")
            End Get   
        End Property
          Public property Descripcion As String
            get
                return me.GetValue_String("pr_500404476935")
            End Get
            Set(value As String)
                me.SetValue_String("pr_500404476935", value)
            End Set
          End Property
          Public property Titulo As String
            get
                return me.GetValue_String("pr_500404476933")
            End Get
            Set(value As String)
                me.SetValue_String("pr_500404476933", value)
            End Set
          End Property
          Public property EstiloTexto As Integer
            get
                return me.GetValue_Integer("pr_60040447691")
            End Get
            Set(value As Integer)
                me.SetValue_Integer("pr_60040447691", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaEnumeracionNativa As Guid
            get
                return me.GetValue_Guid("pr_500404476934")
            End Get   
        End Property
          Public property Obsoleto As Boolean
            get
                return me.GetValue_Boolean("pr_60040447693")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_60040447693", value)
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
