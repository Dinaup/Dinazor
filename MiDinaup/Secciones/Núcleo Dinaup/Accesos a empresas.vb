Partial Public Class SeccionesD
  Public Class AccesosAEmpresasD
      Public Shared _SeccionID As String = "5cc404f8-61f8-4976-b17e-2400a26025c6"
      Public Shared _SeccionIDGUID As New Guid("5cc404f8-61f8-4976-b17e-2400a26025c6")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As AccesosAEmpresas_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, AccesosAEmpresasES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New AccesosAEmpresas_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As AccesosAEmpresas_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, AccesosAEmpresasES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New AccesosAEmpresas_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class AccesosAEmpresasES
          Public shared _SeccionID as Guid = New Guid("5cc404f8-61f8-4976-b17e-2400a26025c6")
          Public shared _Tabla$ = "tpr_50040291741"
      Public Shared ReferenciaDestinador$ = "pr_500402917412"
      Public Shared HoraLocal$ = "pr_50040291749"
      Public Shared FechaAlta_UTC$ = "pr_500402917411"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_500402917423"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_500402917424"
      Public Shared ReferenciaAutorDelAlta$ = "pr_50040291747"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_50040291745"
      Public Shared AccesoHasta_UTC$ = "pr_600402917426"
      Public Shared AccesoDesde_UTC$ = "pr_600402917427"
      Public Shared AccesoVigente$ = "pr_10040291752"
      Public Shared ReferenciaEmpresaAcceso$ = "pr_30040291901"
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
      Public Class AccesosAEmpresasC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public FechaAlta_UTC As Date
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public EmpleadoTieneAccesoWeb As Boolean
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AccesoHasta_UTC As Date
          Public AccesoDesde_UTC As Date
          Public AccesoVigente As Boolean
          Public ReferenciaEmpresaAcceso As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
      Public Class AccesosAEmpresas_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_500402917412")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_50040291749")
            End Get   
        End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_500402917411")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_500402917411", value)
            End Set
          End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_500402917423")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_500402917423", value)
            End Set
          End Property
          Public property EmpleadoTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_500402917424")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_500402917424", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_50040291747")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_50040291747", value)
            End Set
          End Property
          Public property ReferenciaEmpleadoPrincipal As Guid
            get
                return me.GetValue_Guid("pr_50040291745")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_50040291745", value)
            End Set
          End Property
          Public property AccesoHasta_UTC As Date
            get
                return me.GetValue_DateTime("pr_600402917426")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_600402917426", value)
            End Set
          End Property
          Public property AccesoDesde_UTC As Date
            get
                return me.GetValue_DateTime("pr_600402917427")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_600402917427", value)
            End Set
          End Property
          Public property AccesoVigente As Boolean
            get
                return me.GetValue_Boolean("pr_10040291752")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_10040291752", value)
            End Set
          End Property
          Public property ReferenciaEmpresaAcceso As Guid
            get
                return me.GetValue_Guid("pr_30040291901")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_30040291901", value)
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
