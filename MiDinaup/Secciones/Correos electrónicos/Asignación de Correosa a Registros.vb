Partial Public Class SeccionesD
  Public Class AsignacionDeCorreosaARegistrosD
      Public Shared _SeccionID As String = "ddae2c8d-3a30-408e-9210-c18898943955"
      Public Shared _SeccionIDGUID As New Guid("ddae2c8d-3a30-408e-9210-c18898943955")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As AsignacionDeCorreosaARegistros_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, AsignacionDeCorreosaARegistrosES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New AsignacionDeCorreosaARegistros_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As AsignacionDeCorreosaARegistros_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, AsignacionDeCorreosaARegistrosES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New AsignacionDeCorreosaARegistros_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class AsignacionDeCorreosaARegistrosES
          Public shared _SeccionID as Guid = New Guid("ddae2c8d-3a30-408e-9210-c18898943955")
          Public shared _Tabla$ = "tpr_30040452751"
      Public Shared ReferenciaDestinador$ = "pr_300404527512"
      Public Shared ExportarEnModulos$ = "pr_300404527510"
      Public Shared HoraLocal$ = "pr_30040452759"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_300404527523"
      Public Shared FechaAlta_UTC$ = "pr_300404527511"
      Public Shared ReferenciaAutorDelAlta$ = "pr_30040452757"
      Public Shared ReferenciaRegistroSeccion$ = "pr_300404527526"
      Public Shared NombreDeRegistro$ = "pr_300404527528"
      Public Shared ReferenciaRegistroRelacionado$ = "pr_300404527529"
      Public Shared ReferenciaCorreo$ = "pr_40040452751"
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
      Public Class AsignacionDeCorreosaARegistrosC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public FechaAlta_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaRegistroSeccion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public NombreDeRegistro As String
          Public ReferenciaRegistroRelacionado As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaCorreo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
      Public Class AsignacionDeCorreosaARegistros_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_300404527512")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_30040452759")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_300404527523")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_300404527523", value)
            End Set
          End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_300404527511")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_300404527511", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_30040452757")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_30040452757", value)
            End Set
          End Property
          Public property ReferenciaRegistroSeccion As Guid
            get
                return me.GetValue_Guid("pr_300404527526")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_300404527526", value)
            End Set
          End Property
          Public property NombreDeRegistro As String
            get
                return me.GetValue_String("pr_300404527528")
            End Get
            Set(value As String)
                me.SetValue_String("pr_300404527528", value)
            End Set
          End Property
          Public property ReferenciaRegistroRelacionado As Guid
            get
                return me.GetValue_Guid("pr_300404527529")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_300404527529", value)
            End Set
          End Property
          Public property ReferenciaCorreo As Guid
            get
                return me.GetValue_Guid("pr_40040452751")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_40040452751", value)
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
