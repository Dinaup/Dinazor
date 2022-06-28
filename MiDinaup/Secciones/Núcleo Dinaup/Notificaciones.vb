Partial Public Class SeccionesD
  Public Class NotificacionesD
      Public Shared _SeccionID As String = "36bde3e5-7ae8-4f16-bf09-bc7e805d964c"
      Public Shared _SeccionIDGUID As New Guid("36bde3e5-7ae8-4f16-bf09-bc7e805d964c")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As Notificaciones_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, NotificacionesES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New Notificaciones_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As Notificaciones_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, NotificacionesES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New Notificaciones_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class NotificacionesES
          Public shared _SeccionID as Guid = New Guid("36bde3e5-7ae8-4f16-bf09-bc7e805d964c")
          Public shared _Tabla$ = "tpr_737d4c8xd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_737d528wd"
      Public Shared ReferenciaConfiguracionDeNotificacion$ = "pr_737ddfewd"
      Public Shared NotificacionLocal$ = "pr_7a54d71wd"
      Public Shared ReferenciaDestinador$ = "pr_737d4f8wd"
      Public Shared HoraLocal$ = "pr_77611d0wd"
      Public Shared ReferenciaReferenciaSeccionDatoRelativo$ = "pr_737de0awd"
      Public Shared NotificacionFinalizada$ = "pr_7a1855awd"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_737d4d4wd"
      Public Shared CantidadDeNotificaciones$ = "pr_7a545d3wd"
      Public Shared NombreDatoRelativo$ = "pr_737de02wd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_737d530wd"
      Public Shared FechaDato_UTC$ = "pr_737d4e0wd"
      Public Shared FechaAlta_UTC$ = "pr_737d4ecwd"
      Public Shared ReferenciaReferenciaDatoRelativo$ = "pr_737de06wd"
      Public Shared FechaDeNotificacion_UTC$ = "pr_7a18558wd"
      Public Shared FechaDeLectura_UTC$ = "pr_737ddeawd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_737d4dcwd"
      Public Shared CausanteTieneAccesoWeb$ = "pr_10040155921002"
      Public Shared ReferenciaCausante$ = "pr_10040155921001"
      Public Shared Descripcion$ = "pr_500404126517"
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
      Public Class NotificacionesC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaConfiguracionDeNotificacion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public NotificacionLocal As Boolean
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public ReferenciaReferenciaSeccionDatoRelativo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public NotificacionFinalizada As Boolean
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public CantidadDeNotificaciones As Integer
          Public NombreDatoRelativo As String
          Public EmpleadoTieneAccesoWeb As Boolean
          Public FechaDato_UTC As Date
          Public FechaAlta_UTC As Date
          Public ReferenciaReferenciaDatoRelativo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaDeNotificacion_UTC As Date
          Public FechaDeLectura_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public CausanteTieneAccesoWeb As Boolean
          Public ReferenciaCausante As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Descripcion As String
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
      Public Class Notificaciones_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_737d528wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_737d528wd", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaConfiguracionDeNotificacion As Guid
            get
                return me.GetValue_Guid("pr_737ddfewd")
            End Get   
        End Property
        Public ReadOnly property NotificacionLocal As Boolean
            get
                return me.GetValue_Boolean("pr_7a54d71wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_737d4f8wd")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_77611d0wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaReferenciaSeccionDatoRelativo As Guid
            get
                return me.GetValue_Guid("pr_737de0awd")
            End Get   
        End Property
          Public property NotificacionFinalizada As Boolean
            get
                return me.GetValue_Boolean("pr_7a1855awd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_7a1855awd", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaEmpleadoPrincipal As Guid
            get
                return me.GetValue_Guid("pr_737d4d4wd")
            End Get   
        End Property
        Public ReadOnly property CantidadDeNotificaciones As Integer
            get
                return me.GetValue_Integer("pr_7a545d3wd")
            End Get   
        End Property
        Public ReadOnly property NombreDatoRelativo As String
            get
                return me.GetValue_String("pr_737de02wd")
            End Get   
        End Property
          Public property EmpleadoTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_737d530wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_737d530wd", value)
            End Set
          End Property
        Public ReadOnly property FechaDato_UTC As Date
            get
                return me.GetValue_DateTime("pr_737d4e0wd")
            End Get   
        End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_737d4ecwd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_737d4ecwd", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaReferenciaDatoRelativo As Guid
            get
                return me.GetValue_Guid("pr_737de06wd")
            End Get   
        End Property
          Public property FechaDeNotificacion_UTC As Date
            get
                return me.GetValue_DateTime("pr_7a18558wd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_7a18558wd", value)
            End Set
          End Property
        Public ReadOnly property FechaDeLectura_UTC As Date
            get
                return me.GetValue_DateTime("pr_737ddeawd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_737d4dcwd")
            End Get   
        End Property
          Public property CausanteTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_10040155921002")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_10040155921002", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaCausante As Guid
            get
                return me.GetValue_Guid("pr_10040155921001")
            End Get   
        End Property
        Public ReadOnly property Descripcion As String
            get
                return me.GetValue_String("pr_500404126517")
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
