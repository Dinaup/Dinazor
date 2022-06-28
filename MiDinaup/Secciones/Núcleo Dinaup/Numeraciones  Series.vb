Partial Public Class SeccionesD
  Public Class NumeracionesSeriesD
      Public Shared _SeccionID As String = "a63e7622-30ca-425b-978e-1dd01c140de8"
      Public Shared _SeccionIDGUID As New Guid("a63e7622-30ca-425b-978e-1dd01c140de8")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As NumeracionesSeries_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, NumeracionesSeriesES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New NumeracionesSeries_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As NumeracionesSeries_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, NumeracionesSeriesES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New NumeracionesSeries_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class NumeracionesSeriesES
          Public shared _SeccionID as Guid = New Guid("a63e7622-30ca-425b-978e-1dd01c140de8")
          Public shared _Tabla$ = "tpr_41f2fd2wc"
      Public Shared Separador$ = "pr_41f9a48x307wc"
      Public Shared FechaAlta_UTC$ = "pr_14c9f3da34g31fwd"
      Public Shared ValorMaximo$ = "pr_41f9b31x45wc"
      Public Shared ConvertirALetras$ = "pr_41fa44dx3b5wc"
      Public Shared HabilitarValorMaximo$ = "pr_421ae79x11dwc"
      Public Shared Observaciones$ = "pr_41fa6ffx8ewc"
      Public Shared Clave$ = "pr_41f9a32x137wc"
      Public Shared ReferenciaAutorDelAlta$ = "pr_14630fe5feh1bwd"
      Public Shared NumeroActual$ = "pr_41f9a07x89wc"
      Public Shared ValorMinimo$ = "pr_41f9b47x2b2wc"
      Public Shared Modificador$ = "pr_41f9b06x179wc"
      Public Shared HabilitarValorMinimo$ = "pr_421aeb8x36ewc"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_146314946ex1bfwd"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_1464b40044g2fawd"
      Public Shared HoraLocal$ = "pr_776aef0wd"
      Public Shared ReferenciaDestinador$ = "pr_14630fe6c0i2d4wd"
      Public Shared PonerClaveALaDerechaDelNumero$ = "pr_40040239361"
      Public Shared ReferenciaLimitarUsoASeccion$ = "pr_20040348065"
      Public Shared ReferenciaLimitarUsoASeccion2$ = "pr_20040348066"
      Public Shared ReferenciaLimitarUsoASeccion3$ = "pr_20040348068"
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
      Public Class NumeracionesSeriesC
          Public Separador As String
          Public FechaAlta_UTC As Date
          Public ValorMaximo As Integer
          Public ConvertirALetras As Boolean
          Public HabilitarValorMaximo As Boolean
          Public Observaciones As String
          Public Clave As String
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public NumeroActual As Integer
          Public ValorMinimo As Integer
          Public Modificador As Integer
          Public HabilitarValorMinimo As Boolean
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public PonerClaveALaDerechaDelNumero As Boolean
          Public ReferenciaLimitarUsoASeccion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaLimitarUsoASeccion2 As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaLimitarUsoASeccion3 As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
      Public Class NumeracionesSeries_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
          Public property Separador As String
            get
                return me.GetValue_String("pr_41f9a48x307wc")
            End Get
            Set(value As String)
                me.SetValue_String("pr_41f9a48x307wc", value)
            End Set
          End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_14c9f3da34g31fwd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_14c9f3da34g31fwd", value)
            End Set
          End Property
          Public property ValorMaximo As Integer
            get
                return me.GetValue_Integer("pr_41f9b31x45wc")
            End Get
            Set(value As Integer)
                me.SetValue_Integer("pr_41f9b31x45wc", value)
            End Set
          End Property
          Public property ConvertirALetras As Boolean
            get
                return me.GetValue_Boolean("pr_41fa44dx3b5wc")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_41fa44dx3b5wc", value)
            End Set
          End Property
          Public property HabilitarValorMaximo As Boolean
            get
                return me.GetValue_Boolean("pr_421ae79x11dwc")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_421ae79x11dwc", value)
            End Set
          End Property
          Public property Observaciones As String
            get
                return me.GetValue_String("pr_41fa6ffx8ewc")
            End Get
            Set(value As String)
                me.SetValue_String("pr_41fa6ffx8ewc", value)
            End Set
          End Property
          Public property Clave As String
            get
                return me.GetValue_String("pr_41f9a32x137wc")
            End Get
            Set(value As String)
                me.SetValue_String("pr_41f9a32x137wc", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_14630fe5feh1bwd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_14630fe5feh1bwd", value)
            End Set
          End Property
          Public property NumeroActual As Integer
            get
                return me.GetValue_Integer("pr_41f9a07x89wc")
            End Get
            Set(value As Integer)
                me.SetValue_Integer("pr_41f9a07x89wc", value)
            End Set
          End Property
          Public property ValorMinimo As Integer
            get
                return me.GetValue_Integer("pr_41f9b47x2b2wc")
            End Get
            Set(value As Integer)
                me.SetValue_Integer("pr_41f9b47x2b2wc", value)
            End Set
          End Property
          Public property Modificador As Integer
            get
                return me.GetValue_Integer("pr_41f9b06x179wc")
            End Get
            Set(value As Integer)
                me.SetValue_Integer("pr_41f9b06x179wc", value)
            End Set
          End Property
          Public property HabilitarValorMinimo As Boolean
            get
                return me.GetValue_Boolean("pr_421aeb8x36ewc")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_421aeb8x36ewc", value)
            End Set
          End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_146314946ex1bfwd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_146314946ex1bfwd", value)
            End Set
          End Property
          Public property ReferenciaUbicacionPrincipal As Guid
            get
                return me.GetValue_Guid("pr_1464b40044g2fawd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_1464b40044g2fawd", value)
            End Set
          End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_776aef0wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_14630fe6c0i2d4wd")
            End Get   
        End Property
          Public property PonerClaveALaDerechaDelNumero As Boolean
            get
                return me.GetValue_Boolean("pr_40040239361")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_40040239361", value)
            End Set
          End Property
          Public property ReferenciaLimitarUsoASeccion As Guid
            get
                return me.GetValue_Guid("pr_20040348065")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_20040348065", value)
            End Set
          End Property
          Public property ReferenciaLimitarUsoASeccion2 As Guid
            get
                return me.GetValue_Guid("pr_20040348066")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_20040348066", value)
            End Set
          End Property
          Public property ReferenciaLimitarUsoASeccion3 As Guid
            get
                return me.GetValue_Guid("pr_20040348068")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_20040348068", value)
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
