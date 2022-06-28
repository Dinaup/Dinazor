Partial Public Class SeccionesD
  Public Class EnumeracionesNativasD
      Public Shared _SeccionID As String = "aa26761b-141d-44be-a783-3ab58d01da93"
      Public Shared _SeccionIDGUID As New Guid("aa26761b-141d-44be-a783-3ab58d01da93")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As EnumeracionesNativas_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, EnumeracionesNativasES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New EnumeracionesNativas_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As EnumeracionesNativas_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, EnumeracionesNativasES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New EnumeracionesNativas_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class EnumeracionesNativasES
          Public shared _SeccionID as Guid = New Guid("aa26761b-141d-44be-a783-3ab58d01da93")
          Public shared _Tabla$ = "tpr_40040447692"
      Public Shared ReferenciaDestinador$ = "pr_400404476913"
      Public Shared ExportarEnModulos$ = "pr_400404476911"
      Public Shared FechaAlta_UTC$ = "pr_400404476912"
      Public Shared HoraLocal$ = "pr_400404476910"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_400404476924"
      Public Shared ReferenciaAutorDelAlta$ = "pr_40040447698"
      Public Shared IDEnumRolCampo$ = "pr_50040447693"
      Public Shared Titulo$ = "pr_50040447694"
      Public Shared Descripcion$ = "pr_60040447692"
      Public Shared EnumeracionObsoleta$ = "pr_40040447914"
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
      Public Class EnumeracionesNativasC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public IDEnumRolCampo As Integer
          Public Titulo As String
          Public Descripcion As String
          Public EnumeracionObsoleta As Boolean
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
      Public Class EnumeracionesNativas_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_400404476913")
            End Get   
        End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_400404476912")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_400404476912", value)
            End Set
          End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_400404476910")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_400404476924")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_400404476924", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_40040447698")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_40040447698", value)
            End Set
          End Property
        Public ReadOnly property IDEnumRolCampo As Integer
            get
                return me.GetValue_Integer("pr_50040447693")
            End Get   
        End Property
          Public property Titulo As String
            get
                return me.GetValue_String("pr_50040447694")
            End Get
            Set(value As String)
                me.SetValue_String("pr_50040447694", value)
            End Set
          End Property
          Public property Descripcion As String
            get
                return me.GetValue_String("pr_60040447692")
            End Get
            Set(value As String)
                me.SetValue_String("pr_60040447692", value)
            End Set
          End Property
          Public property EnumeracionObsoleta As Boolean
            get
                return me.GetValue_Boolean("pr_40040447914")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_40040447914", value)
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
