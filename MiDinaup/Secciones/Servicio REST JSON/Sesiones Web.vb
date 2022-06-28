Partial Public Class SeccionesD
  Public Class SesionesWebD
      Public Shared _SeccionID As String = "46e9326b-ad98-456d-97ac-636e94c8ed76"
      Public Shared _SeccionIDGUID As New Guid("46e9326b-ad98-456d-97ac-636e94c8ed76")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As SesionesWeb_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, SesionesWebES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New SesionesWeb_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As SesionesWeb_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, SesionesWebES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New SesionesWeb_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class SesionesWebES
          Public shared _SeccionID as Guid = New Guid("46e9326b-ad98-456d-97ac-636e94c8ed76")
          Public shared _Tabla$ = "tpr_50040177761"
      Public Shared FechaDato_UTC$ = "pr_50040177768"
      Public Shared ReferenciaDestinador$ = "pr_500401777612"
      Public Shared HoraLocal$ = "pr_50040177769"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_500401777623"
      Public Shared Navegador$ = "pr_500401783924"
      Public Shared SesionActiva$ = "pr_60040178393"
      Public Shared ReferenciaAutorDelAlta$ = "pr_50040177767"
      Public Shared FechaAlta_UTC$ = "pr_500401777611"
      Public Shared UltimaActividad$ = "pr_500401783927"
      Public Shared DireccionIP$ = "pr_500401783923"
      Public Shared EntidadTieneAccesoWeb$ = "pr_60040178392"
      Public Shared Token$ = "pr_500401783926"
      Public Shared ReferenciaEntidad$ = "pr_60040178391"
      Public Shared Aplicacion$ = "pr_10040178401"
      Public Shared ReferenciaServidor$ = "pr_40040218985"
      Public Shared ReferenciaUbicacion$ = "pr_50040374515"
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
      Public Class SesionesWebC
          Public FechaDato_UTC As Date
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public Navegador As String
          Public SesionActiva As Boolean
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public UltimaActividad As Date
          Public DireccionIP As String
          Public EntidadTieneAccesoWeb As Boolean
          Public Token As String
          Public ReferenciaEntidad As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Aplicacion As String
          Public ReferenciaServidor As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaUbicacion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
      Public Class SesionesWeb_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
        Public ReadOnly property FechaDato_UTC As Date
            get
                return me.GetValue_DateTime("pr_50040177768")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_500401777612")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_50040177769")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_500401777623")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_500401777623", value)
            End Set
          End Property
        Public ReadOnly property Navegador As String
            get
                return me.GetValue_String("pr_500401783924")
            End Get   
        End Property
          Public property SesionActiva As Boolean
            get
                return me.GetValue_Boolean("pr_60040178393")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_60040178393", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_50040177767")
            End Get   
        End Property
        Public ReadOnly property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_500401777611")
            End Get   
        End Property
        Public ReadOnly property UltimaActividad As Date
            get
                return me.GetValue_Date("pr_500401783927")
            End Get   
        End Property
        Public ReadOnly property DireccionIP As String
            get
                return me.GetValue_String("pr_500401783923")
            End Get   
        End Property
          Public property EntidadTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_60040178392")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_60040178392", value)
            End Set
          End Property
        Public ReadOnly property Token As String
            get
                return me.GetValue_String("pr_500401783926")
            End Get   
        End Property
        Public ReadOnly property ReferenciaEntidad As Guid
            get
                return me.GetValue_Guid("pr_60040178391")
            End Get   
        End Property
        Public ReadOnly property Aplicacion As String
            get
                return me.GetValue_String("pr_10040178401")
            End Get   
        End Property
        Public ReadOnly property ReferenciaServidor As Guid
            get
                return me.GetValue_Guid("pr_40040218985")
            End Get   
        End Property
        Public ReadOnly property ReferenciaUbicacion As Guid
            get
                return me.GetValue_Guid("pr_50040374515")
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
