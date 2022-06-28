Partial Public Class SeccionesD
  Public Class PermisosPuntualesAInformesD
      Public Shared _SeccionID As String = "ed76cf1b-f7b3-4d75-9cb1-7bf7070d54f5"
      Public Shared _SeccionIDGUID As New Guid("ed76cf1b-f7b3-4d75-9cb1-7bf7070d54f5")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As PermisosPuntualesAInformes_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, PermisosPuntualesAInformesES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New PermisosPuntualesAInformes_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As PermisosPuntualesAInformes_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, PermisosPuntualesAInformesES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New PermisosPuntualesAInformes_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class PermisosPuntualesAInformesES
          Public shared _SeccionID as Guid = New Guid("ed76cf1b-f7b3-4d75-9cb1-7bf7070d54f5")
          Public shared _Tabla$ = "tpr_7ac1b8axd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_7ac1bc0wd"
      Public Shared EmpleadosPermiso$ = "pr_7ac1e96wd"
      Public Shared HoraLocal$ = "pr_7ac1b98wd"
      Public Shared ReferenciaDestinador$ = "pr_7ac1ba6wd"
      Public Shared FechaDeFin_UTC$ = "pr_30040104952"
      Public Shared FechaDeInicio_UTC$ = "pr_30040104951"
      Public Shared Observaciones$ = "pr_30040104956"
      Public Shared FechaAlta_UTC$ = "pr_7ac1ba0wd"
      Public Shared Informes$ = "pr_7ac1e98wd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_7ac1b94wd"
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
      Public Class PermisosPuntualesAInformesC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public EmpleadosPermiso As String
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaDeFin_UTC As Date
          Public FechaDeInicio_UTC As Date
          Public Observaciones As String
          Public FechaAlta_UTC As Date
          Public Informes As String
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
      Public Class PermisosPuntualesAInformes_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_7ac1bc0wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_7ac1bc0wd", value)
            End Set
          End Property
          Public property EmpleadosPermiso As String
            get
                return me.GetValue_String("pr_7ac1e96wd")
            End Get
            Set(value As String)
                me.SetValue_String("pr_7ac1e96wd", value)
            End Set
          End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_7ac1b98wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_7ac1ba6wd")
            End Get   
        End Property
          Public property FechaDeFin_UTC As Date
            get
                return me.GetValue_DateTime("pr_30040104952")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_30040104952", value)
            End Set
          End Property
          Public property FechaDeInicio_UTC As Date
            get
                return me.GetValue_DateTime("pr_30040104951")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_30040104951", value)
            End Set
          End Property
          Public property Observaciones As String
            get
                return me.GetValue_String("pr_30040104956")
            End Get
            Set(value As String)
                me.SetValue_String("pr_30040104956", value)
            End Set
          End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_7ac1ba0wd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_7ac1ba0wd", value)
            End Set
          End Property
          Public property Informes As String
            get
                return me.GetValue_String("pr_7ac1e98wd")
            End Get
            Set(value As String)
                me.SetValue_String("pr_7ac1e98wd", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_7ac1b94wd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_7ac1b94wd", value)
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
