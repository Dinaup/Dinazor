Partial Public Class SeccionesD
  Public Class CuentasCreadasRemotamenteD
      Public Shared _SeccionID As String = "db2adcba-6da4-4f0e-8578-52500159dc09"
      Public Shared _SeccionIDGUID As New Guid("db2adcba-6da4-4f0e-8578-52500159dc09")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As CuentasCreadasRemotamente_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, CuentasCreadasRemotamenteES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New CuentasCreadasRemotamente_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As CuentasCreadasRemotamente_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, CuentasCreadasRemotamenteES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New CuentasCreadasRemotamente_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class CuentasCreadasRemotamenteES
          Public shared _SeccionID as Guid = New Guid("db2adcba-6da4-4f0e-8578-52500159dc09")
          Public shared _Tabla$ = "tpr_50040480343"
      Public Shared HoraLocal$ = "pr_500404803413"
      Public Shared FechaDato_UTC$ = "pr_500404803412"
      Public Shared ReferenciaDestinador$ = "pr_500404803416"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_500404803427"
      Public Shared ReferenciaAutorDelAlta$ = "pr_500404803411"
      Public Shared FechaAlta_UTC$ = "pr_500404803415"
      Public Shared CodigoDeVerificacion$ = "pr_500404803430"
      Public Shared CorreoElectronico$ = "pr_500404803432"
      Public Shared EntidadCreadaTieneAccesoWeb$ = "pr_500404803435"
      Public Shared ReferenciaEntidadCreada$ = "pr_500404803434"
      Public Shared UsuarioAplicacion$ = "pr_60040480341"
      Public Shared UsuarioNavegador$ = "pr_500404803437"
      Public Shared ReferenciaCorreoEnviado$ = "pr_60040480343"
      Public Shared UsuarioIP$ = "pr_500404803438"
      Public Shared Contraseña$ = "pr_10040480555"
      Public Shared NombreRazonSocial$ = "pr_10040480556"
      Public Shared Apellidos$ = "pr_10040480557"
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
      Public Class CuentasCreadasRemotamenteC
          Public HoraLocal As Integer
          Public FechaDato_UTC As Date
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public CodigoDeVerificacion As String
          Public CorreoElectronico As String
          Public EntidadCreadaTieneAccesoWeb As Boolean
          Public ReferenciaEntidadCreada As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public UsuarioAplicacion As String
          Public UsuarioNavegador As String
          Public ReferenciaCorreoEnviado As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public UsuarioIP As String
          Public Contraseña As String
          Public NombreRazonSocial As String
          Public Apellidos As String
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
      Public Class CuentasCreadasRemotamente_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_500404803413")
            End Get   
        End Property
          Public property FechaDato_UTC As Date
            get
                return me.GetValue_DateTime("pr_500404803412")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_500404803412", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_500404803416")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_500404803427")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_500404803427", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_500404803411")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_500404803411", value)
            End Set
          End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_500404803415")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_500404803415", value)
            End Set
          End Property
        Public ReadOnly property CodigoDeVerificacion As String
            get
                return me.GetValue_String("pr_500404803430")
            End Get   
        End Property
        Public ReadOnly property CorreoElectronico As String
            get
                return me.GetValue_String("pr_500404803432")
            End Get   
        End Property
          Public property EntidadCreadaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_500404803435")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_500404803435", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaEntidadCreada As Guid
            get
                return me.GetValue_Guid("pr_500404803434")
            End Get   
        End Property
        Public ReadOnly property UsuarioAplicacion As String
            get
                return me.GetValue_String("pr_60040480341")
            End Get   
        End Property
        Public ReadOnly property UsuarioNavegador As String
            get
                return me.GetValue_String("pr_500404803437")
            End Get   
        End Property
        Public ReadOnly property ReferenciaCorreoEnviado As Guid
            get
                return me.GetValue_Guid("pr_60040480343")
            End Get   
        End Property
        Public ReadOnly property UsuarioIP As String
            get
                return me.GetValue_String("pr_500404803438")
            End Get   
        End Property
        Public ReadOnly property Contraseña As String
            get
                return me.GetValue_String("pr_10040480555")
            End Get   
        End Property
        Public ReadOnly property NombreRazonSocial As String
            get
                return me.GetValue_String("pr_10040480556")
            End Get   
        End Property
        Public ReadOnly property Apellidos As String
            get
                return me.GetValue_String("pr_10040480557")
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
