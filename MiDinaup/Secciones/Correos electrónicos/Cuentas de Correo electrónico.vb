Partial Public Class SeccionesD
  Public Class CuentasDeCorreoElectronicoD
      Public Shared _SeccionID As String = "cb53c54c-e1f7-47de-8978-0e5228ed81c4"
      Public Shared _SeccionIDGUID As New Guid("cb53c54c-e1f7-47de-8978-0e5228ed81c4")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As CuentasDeCorreoElectronico_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, CuentasDeCorreoElectronicoES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New CuentasDeCorreoElectronico_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As CuentasDeCorreoElectronico_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, CuentasDeCorreoElectronicoES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New CuentasDeCorreoElectronico_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class CuentasDeCorreoElectronicoES
          Public shared _SeccionID as Guid = New Guid("cb53c54c-e1f7-47de-8978-0e5228ed81c4")
          Public shared _Tabla$ = "tpr_30040163371001"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_30040163371022"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_30040163371009"
      Public Shared ReferenciaDestinador$ = "pr_30040163371015"
      Public Shared FechaAlta_UTC$ = "pr_30040163371014"
      Public Shared HoraLocal$ = "pr_30040163371012"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_30040163371021"
      Public Shared ReferenciaAutorDelAlta$ = "pr_30040163371010"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_30040163371008"
      Public Shared Configuracion$ = "pr_30040164802"
      Public Shared NumeroMaximoDeEnviosDeEmailsPorHora$ = "pr_50040165183"
      Public Shared DireccionSMTP$ = "pr_10040164242"
      Public Shared Contraseña$ = "pr_10040164241"
      Public Shared ActivarSSLEnSMPT$ = "pr_10040164243"
      Public Shared ReferenciaImagenPrevia$ = "pr_500401652940"
      Public Shared Puerto$ = "pr_10040164244"
      Public Shared DireccionDeCorreo$ = "pr_60040164231004"
      Public Shared NumeroMaximoDeEnviosDeEmailsPorDia$ = "pr_50040165184"
      Public Shared Protocolo$ = "pr_60040255942"
      Public Shared ReferenciaServidorEncargado$ = "pr_20040257112"
      Public Shared ServidorIMAP$ = "pr_40040257404"
      Public Shared PuertoIMAP$ = "pr_40040257402"
      Public Shared ActivarSSLEnIMAP$ = "pr_40040257403"
      Public Shared DescargarCorreosRecibidos$ = "pr_10040257112"
      Public Shared ReferenciaBuzonPredeterminado$ = "pr_600402574032"
      Public Shared ReferenciaBuzonPrincipal$ = "pr_40040391503"
      Public Shared ResponderA$ = "pr_50040408061"
      Public Shared FiltrarEnviadosA$ = "pr_50040408062"
      Public Shared DireccionDeEnvioAlias$ = "pr_30040408073"
      Public Shared DescargarCorreosEnviados$ = "pr_60040452763"
      Public Shared ReferenciaEstadoInicialCorreosEnviados$ = "pr_60040452765"
      Public Shared ReferenciaEstadoInicialCorreosRecibidos$ = "pr_10040452771"
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
      Public Class CuentasDeCorreoElectronicoC
          Public EmpleadoTieneAccesoWeb As Boolean
          Public ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Configuracion As String
          Public NumeroMaximoDeEnviosDeEmailsPorHora As Integer
          Public DireccionSMTP As String
          Public Contraseña As String
          Public ActivarSSLEnSMPT As Boolean
          Public ReferenciaImagenPrevia As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Puerto As Integer
          Public DireccionDeCorreo As String
          Public NumeroMaximoDeEnviosDeEmailsPorDia As Integer
          Public Protocolo As Integer
          Public ReferenciaServidorEncargado As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ServidorIMAP As String
          Public PuertoIMAP As Integer
          Public ActivarSSLEnIMAP As Boolean
          Public DescargarCorreosRecibidos As Boolean
          Public ReferenciaBuzonPredeterminado As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaBuzonPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ResponderA As String
          Public FiltrarEnviadosA As String
          Public DireccionDeEnvioAlias As String
          Public DescargarCorreosEnviados As Boolean
          Public ReferenciaEstadoInicialCorreosEnviados As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaEstadoInicialCorreosRecibidos As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
      Public Class CuentasDeCorreoElectronico_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
          Public property EmpleadoTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_30040163371022")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_30040163371022", value)
            End Set
          End Property
          Public property ReferenciaUbicacionPrincipal As Guid
            get
                return me.GetValue_Guid("pr_30040163371009")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_30040163371009", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_30040163371015")
            End Get   
        End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_30040163371014")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_30040163371014", value)
            End Set
          End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_30040163371012")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_30040163371021")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_30040163371021", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_30040163371010")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_30040163371010", value)
            End Set
          End Property
          Public property ReferenciaEmpleadoPrincipal As Guid
            get
                return me.GetValue_Guid("pr_30040163371008")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_30040163371008", value)
            End Set
          End Property
        Public ReadOnly property Configuracion As String
            get
                return me.GetValue_String("pr_30040164802")
            End Get   
        End Property
          Public property NumeroMaximoDeEnviosDeEmailsPorHora As Integer
            get
                return me.GetValue_Integer("pr_50040165183")
            End Get
            Set(value As Integer)
                me.SetValue_Integer("pr_50040165183", value)
            End Set
          End Property
        Public ReadOnly property DireccionSMTP As String
            get
                return me.GetValue_String("pr_10040164242")
            End Get   
        End Property
        Public ReadOnly property Contraseña As String
            get
                return me.GetValue_String("pr_10040164241")
            End Get   
        End Property
        Public ReadOnly property ActivarSSLEnSMPT As Boolean
            get
                return me.GetValue_Boolean("pr_10040164243")
            End Get   
        End Property
          Public property ReferenciaImagenPrevia As Guid
            get
                return me.GetValue_Guid("pr_500401652940")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_500401652940", value)
            End Set
          End Property
        Public ReadOnly property Puerto As Integer
            get
                return me.GetValue_Integer("pr_10040164244")
            End Get   
        End Property
        Public ReadOnly property DireccionDeCorreo As String
            get
                return me.GetValue_String("pr_60040164231004")
            End Get   
        End Property
          Public property NumeroMaximoDeEnviosDeEmailsPorDia As Integer
            get
                return me.GetValue_Integer("pr_50040165184")
            End Get
            Set(value As Integer)
                me.SetValue_Integer("pr_50040165184", value)
            End Set
          End Property
          Public property Protocolo As Integer
            get
                return me.GetValue_Integer("pr_60040255942")
            End Get
            Set(value As Integer)
                me.SetValue_Integer("pr_60040255942", value)
            End Set
          End Property
          Public property ReferenciaServidorEncargado As Guid
            get
                return me.GetValue_Guid("pr_20040257112")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_20040257112", value)
            End Set
          End Property
        Public ReadOnly property ServidorIMAP As String
            get
                return me.GetValue_String("pr_40040257404")
            End Get   
        End Property
        Public ReadOnly property PuertoIMAP As Integer
            get
                return me.GetValue_Integer("pr_40040257402")
            End Get   
        End Property
        Public ReadOnly property ActivarSSLEnIMAP As Boolean
            get
                return me.GetValue_Boolean("pr_40040257403")
            End Get   
        End Property
          Public property DescargarCorreosRecibidos As Boolean
            get
                return me.GetValue_Boolean("pr_10040257112")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_10040257112", value)
            End Set
          End Property
          Public property ReferenciaBuzonPredeterminado As Guid
            get
                return me.GetValue_Guid("pr_600402574032")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_600402574032", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaBuzonPrincipal As Guid
            get
                return me.GetValue_Guid("pr_40040391503")
            End Get   
        End Property
          Public property ResponderA As String
            get
                return me.GetValue_String("pr_50040408061")
            End Get
            Set(value As String)
                me.SetValue_String("pr_50040408061", value)
            End Set
          End Property
          Public property FiltrarEnviadosA As String
            get
                return me.GetValue_String("pr_50040408062")
            End Get
            Set(value As String)
                me.SetValue_String("pr_50040408062", value)
            End Set
          End Property
          Public property DireccionDeEnvioAlias As String
            get
                return me.GetValue_String("pr_30040408073")
            End Get
            Set(value As String)
                me.SetValue_String("pr_30040408073", value)
            End Set
          End Property
          Public property DescargarCorreosEnviados As Boolean
            get
                return me.GetValue_Boolean("pr_60040452763")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_60040452763", value)
            End Set
          End Property
          Public property ReferenciaEstadoInicialCorreosEnviados As Guid
            get
                return me.GetValue_Guid("pr_60040452765")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_60040452765", value)
            End Set
          End Property
          Public property ReferenciaEstadoInicialCorreosRecibidos As Guid
            get
                return me.GetValue_Guid("pr_10040452771")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_10040452771", value)
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
