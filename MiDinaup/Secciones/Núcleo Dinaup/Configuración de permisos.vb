Partial Public Class SeccionesD
  Public Class ConfiguracionDePermisosD
      Public Shared _SeccionID As String = "9aa34fbe-1614-4ff7-84d1-e83c1b9d7cbf"
      Public Shared _SeccionIDGUID As New Guid("9aa34fbe-1614-4ff7-84d1-e83c1b9d7cbf")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As ConfiguracionDePermisos_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, ConfiguracionDePermisosES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New ConfiguracionDePermisos_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As ConfiguracionDePermisos_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, ConfiguracionDePermisosES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New ConfiguracionDePermisos_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class ConfiguracionDePermisosES
          Public shared _SeccionID as Guid = New Guid("9aa34fbe-1614-4ff7-84d1-e83c1b9d7cbf")
          Public shared _Tabla$ = "tpr_20040110491"
      Public Shared ReferenciaDestinador$ = "pr_200401104917"
      Public Shared HoraLocal$ = "pr_200401104914"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_200401104921"
      Public Shared FechaAlta_UTC$ = "pr_200401104916"
      Public Shared ExportarEnModulos$ = "pr_200401104915"
      Public Shared Diseño$ = "pr_200401104925"
      Public Shared ReferenciaSeccionDeConfiguracion$ = "pr_40040110531"
      Public Shared Observaciones$ = "pr_40040110532"
      Public Shared ReferenciaAutorDelAlta$ = "pr_200401104912"
      Public Shared IdentificadorDeConfiguracionSha1$ = "pr_60040110541"
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
      Public Class ConfiguracionDePermisosC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public FechaAlta_UTC As Date
          Public Diseño As String
          Public ReferenciaSeccionDeConfiguracion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Observaciones As String
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public IdentificadorDeConfiguracionSha1 As String
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
      Public Class ConfiguracionDePermisos_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_200401104917")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_200401104914")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_200401104921")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_200401104921", value)
            End Set
          End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_200401104916")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_200401104916", value)
            End Set
          End Property
          Public property Diseño As String
            get
                return me.GetValue_String("pr_200401104925")
            End Get
            Set(value As String)
                me.SetValue_String("pr_200401104925", value)
            End Set
          End Property
          Public property ReferenciaSeccionDeConfiguracion As Guid
            get
                return me.GetValue_Guid("pr_40040110531")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_40040110531", value)
            End Set
          End Property
          Public property Observaciones As String
            get
                return me.GetValue_String("pr_40040110532")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040110532", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_200401104912")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_200401104912", value)
            End Set
          End Property
        Public ReadOnly property IdentificadorDeConfiguracionSha1 As String
            get
                return me.GetValue_String("pr_60040110541")
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
