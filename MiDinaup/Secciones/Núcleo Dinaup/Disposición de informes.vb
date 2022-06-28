Partial Public Class SeccionesD
  Public Class DisposicionDeInformesD
      Public Shared _SeccionID As String = "aa98232b-669a-4fbc-9b21-d09307bdb9da"
      Public Shared _SeccionIDGUID As New Guid("aa98232b-669a-4fbc-9b21-d09307bdb9da")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As DisposicionDeInformes_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, DisposicionDeInformesES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New DisposicionDeInformes_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As DisposicionDeInformes_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, DisposicionDeInformesES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New DisposicionDeInformes_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class DisposicionDeInformesES
          Public shared _SeccionID as Guid = New Guid("aa98232b-669a-4fbc-9b21-d09307bdb9da")
          Public shared _Tabla$ = "tpr_10040166171"
      Public Shared Descripcion$ = "pr_20040166174"
      Public Shared ExportarEnModulos$ = "pr_100401661710"
      Public Shared FechaAlta_UTC$ = "pr_100401661711"
      Public Shared ReferenciaDestinador$ = "pr_100401661712"
      Public Shared ReferenciaAutorDelAlta$ = "pr_10040166177"
      Public Shared HoraLocal$ = "pr_10040166179"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_100401661723"
      Public Shared ReferenciaIcono$ = "pr_100401661729"
      Public Shared ReferenciaInforme$ = "pr_100401661727"
      Public Shared ConfiguracionSHA1$ = "pr_20040166171"
      Public Shared Configuracion$ = "pr_20040166172"
      Public Shared Activo$ = "pr_100401661728"
      Public Shared Titulo$ = "pr_20040166173"
      Public Shared ConvertirEnDisposicionPorDefecto$ = "pr_20040279921"
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
      Public Class DisposicionDeInformesC
          Public Descripcion As String
          Public FechaAlta_UTC As Date
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaIcono As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaInforme As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ConfiguracionSHA1 As String
          Public Configuracion As String
          Public Activo As Boolean
          Public Titulo As String
          Public ConvertirEnDisposicionPorDefecto As Boolean
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
      Public Class DisposicionDeInformes_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
          Public property Descripcion As String
            get
                return me.GetValue_String("pr_20040166174")
            End Get
            Set(value As String)
                me.SetValue_String("pr_20040166174", value)
            End Set
          End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_100401661711")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_100401661711", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_100401661712")
            End Get   
        End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_10040166177")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_10040166177", value)
            End Set
          End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_10040166179")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_100401661723")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_100401661723", value)
            End Set
          End Property
          Public property ReferenciaIcono As Guid
            get
                return me.GetValue_Guid("pr_100401661729")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_100401661729", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaInforme As Guid
            get
                return me.GetValue_Guid("pr_100401661727")
            End Get   
        End Property
        Public ReadOnly property ConfiguracionSHA1 As String
            get
                return me.GetValue_String("pr_20040166171")
            End Get   
        End Property
        Public ReadOnly property Configuracion As String
            get
                return me.GetValue_String("pr_20040166172")
            End Get   
        End Property
          Public property Activo As Boolean
            get
                return me.GetValue_Boolean("pr_100401661728")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_100401661728", value)
            End Set
          End Property
          Public property Titulo As String
            get
                return me.GetValue_String("pr_20040166173")
            End Get
            Set(value As String)
                me.SetValue_String("pr_20040166173", value)
            End Set
          End Property
          Public property ConvertirEnDisposicionPorDefecto As Boolean
            get
                return me.GetValue_Boolean("pr_20040279921")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_20040279921", value)
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
