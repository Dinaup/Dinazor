Partial Public Class SeccionesD
  Public Class RegistroDeCopiasDeSeguridadD
      Public Shared _SeccionID As String = "83eff819-305f-4bd6-bcad-cdad6dcc0f65"
      Public Shared _SeccionIDGUID As New Guid("83eff819-305f-4bd6-bcad-cdad6dcc0f65")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As RegistroDeCopiasDeSeguridad_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, RegistroDeCopiasDeSeguridadES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New RegistroDeCopiasDeSeguridad_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As RegistroDeCopiasDeSeguridad_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, RegistroDeCopiasDeSeguridadES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New RegistroDeCopiasDeSeguridad_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class RegistroDeCopiasDeSeguridadES
          Public shared _SeccionID as Guid = New Guid("83eff819-305f-4bd6-bcad-cdad6dcc0f65")
          Public shared _Tabla$ = "tpr_10040269571"
      Public Shared HoraLocal$ = "pr_10040269579"
      Public Shared FechaDato_UTC$ = "pr_10040269578"
      Public Shared ReferenciaDestinador$ = "pr_100402695712"
      Public Shared FechaAlta_UTC$ = "pr_100402695711"
      Public Shared ReferenciaAutorDelAlta$ = "pr_10040269577"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_100402695723"
      Public Shared Ubicacion$ = "pr_20040269572"
      Public Shared ReferenciaServidor$ = "pr_20040269574"
      Public Shared ExisteArchivo$ = "pr_20040269571"
      Public Shared TiempoEmpleadoEnHacerLaCopiaDeSeguridad$ = "pr_40040269573"
      Public Shared TamañoCopiaSinComprimir$ = "pr_40040269572"
      Public Shared ContieneLosArchivos$ = "pr_30040269571"
      Public Shared ContieneDatos$ = "pr_30040269572"
      Public Shared TamañoCopia$ = "pr_40040269571"
      Public Shared TiempoTotalEmpleado$ = "pr_60040269571"
      Public Shared InformacionAdicional$ = "pr_60040269573"
      Public Shared TiempoEmpleadoEnGuardar$ = "pr_40040269575"
      Public Shared TiempoEmpleadoEnComprimir$ = "pr_40040269574"
      Public Shared DinaupVersion$ = "pr_60040269574"
      Public Shared DinaupRevision$ = "pr_60040269575"
      Public Shared TipoDeCopia$ = "pr_20040269586"
      Public Shared SHA1$ = "pr_60040276312"
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
      Public Class RegistroDeCopiasDeSeguridadC
          Public HoraLocal As Integer
          Public FechaDato_UTC As Date
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public Ubicacion As String
          Public ReferenciaServidor As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ExisteArchivo As Boolean
          Public TiempoEmpleadoEnHacerLaCopiaDeSeguridad As Decimal
          Public TamañoCopiaSinComprimir As Decimal
          Public ContieneLosArchivos As Boolean
          Public ContieneDatos As Boolean
          Public TamañoCopia As Decimal
          Public TiempoTotalEmpleado As Decimal
          Public InformacionAdicional As String
          Public TiempoEmpleadoEnGuardar As Decimal
          Public TiempoEmpleadoEnComprimir As Decimal
          Public DinaupVersion As Integer
          Public DinaupRevision As Integer
          Public TipoDeCopia As Integer
          Public SHA1 As String
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
      Public Class RegistroDeCopiasDeSeguridad_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_10040269579")
            End Get   
        End Property
        Public ReadOnly property FechaDato_UTC As Date
            get
                return me.GetValue_DateTime("pr_10040269578")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_100402695712")
            End Get   
        End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_100402695711")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_100402695711", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_10040269577")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_100402695723")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_100402695723", value)
            End Set
          End Property
        Public ReadOnly property Ubicacion As String
            get
                return me.GetValue_String("pr_20040269572")
            End Get   
        End Property
        Public ReadOnly property ReferenciaServidor As Guid
            get
                return me.GetValue_Guid("pr_20040269574")
            End Get   
        End Property
        Public ReadOnly property ExisteArchivo As Boolean
            get
                return me.GetValue_Boolean("pr_20040269571")
            End Get   
        End Property
        Public ReadOnly property TiempoEmpleadoEnHacerLaCopiaDeSeguridad As Decimal
            get
                return me.GetValue_Decimal("pr_40040269573")
            End Get   
        End Property
        Public ReadOnly property TamañoCopiaSinComprimir As Decimal
            get
                return me.GetValue_Decimal("pr_40040269572")
            End Get   
        End Property
        Public ReadOnly property ContieneLosArchivos As Boolean
            get
                return me.GetValue_Boolean("pr_30040269571")
            End Get   
        End Property
        Public ReadOnly property ContieneDatos As Boolean
            get
                return me.GetValue_Boolean("pr_30040269572")
            End Get   
        End Property
        Public ReadOnly property TamañoCopia As Decimal
            get
                return me.GetValue_Decimal("pr_40040269571")
            End Get   
        End Property
        Public ReadOnly property TiempoTotalEmpleado As Decimal
            get
                return me.GetValue_Decimal("pr_60040269571")
            End Get   
        End Property
          Public property InformacionAdicional As String
            get
                return me.GetValue_String("pr_60040269573")
            End Get
            Set(value As String)
                me.SetValue_String("pr_60040269573", value)
            End Set
          End Property
        Public ReadOnly property TiempoEmpleadoEnGuardar As Decimal
            get
                return me.GetValue_Decimal("pr_40040269575")
            End Get   
        End Property
        Public ReadOnly property TiempoEmpleadoEnComprimir As Decimal
            get
                return me.GetValue_Decimal("pr_40040269574")
            End Get   
        End Property
        Public ReadOnly property DinaupVersion As Integer
            get
                return me.GetValue_Integer("pr_60040269574")
            End Get   
        End Property
        Public ReadOnly property DinaupRevision As Integer
            get
                return me.GetValue_Integer("pr_60040269575")
            End Get   
        End Property
        Public ReadOnly property TipoDeCopia As Integer
            get
                return me.GetValue_Integer("pr_20040269586")
            End Get   
        End Property
        Public ReadOnly property SHA1 As String
            get
                return me.GetValue_String("pr_60040276312")
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
