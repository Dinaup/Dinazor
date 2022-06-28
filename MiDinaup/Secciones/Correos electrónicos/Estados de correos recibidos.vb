Partial Public Class SeccionesD
  Public Class EstadosDeCorreosRecibidosD
      Public Shared _SeccionID As String = "151028d4-6add-45a2-9d76-07462e4d95df"
      Public Shared _SeccionIDGUID As New Guid("151028d4-6add-45a2-9d76-07462e4d95df")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As EstadosDeCorreosRecibidos_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, EstadosDeCorreosRecibidosES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New EstadosDeCorreosRecibidos_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As EstadosDeCorreosRecibidos_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, EstadosDeCorreosRecibidosES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New EstadosDeCorreosRecibidos_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class EstadosDeCorreosRecibidosES
          Public shared _SeccionID as Guid = New Guid("151028d4-6add-45a2-9d76-07462e4d95df")
          Public shared _Tabla$ = "tpr_40040257112"
      Public Shared ExportarEnModulos$ = "pr_400402571117"
      Public Shared FechaAlta_UTC$ = "pr_400402571118"
      Public Shared ReferenciaDestinador$ = "pr_400402571119"
      Public Shared HoraLocal$ = "pr_400402571116"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_400402571130"
      Public Shared ReferenciaAutorDelAlta$ = "pr_400402571114"
      Public Shared Descripcion$ = "pr_500402571132"
      Public Shared TipoDeEstado$ = "pr_500402571133"
      Public Shared EstadoPredeterminado$ = "pr_20040257213"
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
      Public Class EstadosDeCorreosRecibidosC
          Public FechaAlta_UTC As Date
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Descripcion As String
          Public TipoDeEstado As Integer
          Public EstadoPredeterminado As Boolean
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
      Public Class EstadosDeCorreosRecibidos_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_400402571118")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_400402571118", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_400402571119")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_400402571116")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_400402571130")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_400402571130", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_400402571114")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_400402571114", value)
            End Set
          End Property
          Public property Descripcion As String
            get
                return me.GetValue_String("pr_500402571132")
            End Get
            Set(value As String)
                me.SetValue_String("pr_500402571132", value)
            End Set
          End Property
          Public property TipoDeEstado As Integer
            get
                return me.GetValue_Integer("pr_500402571133")
            End Get
            Set(value As Integer)
                me.SetValue_Integer("pr_500402571133", value)
            End Set
          End Property
          Public property EstadoPredeterminado As Boolean
            get
                return me.GetValue_Boolean("pr_20040257213")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_20040257213", value)
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
