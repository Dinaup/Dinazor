Partial Public Class SeccionesD
  Public Class PermisoPuntualARegistrosD
      Public Shared _SeccionID As String = "97ae1f1a-22aa-4c06-8d11-dfd1590ac9f5"
      Public Shared _SeccionIDGUID As New Guid("97ae1f1a-22aa-4c06-8d11-dfd1590ac9f5")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As PermisoPuntualARegistros_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, PermisoPuntualARegistrosES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New PermisoPuntualARegistros_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As PermisoPuntualARegistros_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, PermisoPuntualARegistrosES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New PermisoPuntualARegistros_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class PermisoPuntualARegistrosES
          Public shared _SeccionID as Guid = New Guid("97ae1f1a-22aa-4c06-8d11-dfd1590ac9f5")
          Public shared _Tabla$ = "tpr_73b8202xd"
      Public Shared RegistrosAcceso$ = "pr_7ac197fwd"
      Public Shared Observaciones$ = "pr_30040104958"
      Public Shared EmpleadosAsignados$ = "pr_7ac197dwd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_73b820ewd"
      Public Shared ReferenciaRol$ = "pr_76ec8dfwd"
      Public Shared PuedeVerObsoleto$ = "pr_73b8361wd"
      Public Shared FechaAlta_UTC$ = "pr_73b821ewd"
      Public Shared FechaDeFin_UTC$ = "pr_73b8355wd"
      Public Shared PuedeComentarObsoleto$ = "pr_76e08f6wd"
      Public Shared PuedeVerComentariosObsoleto$ = "pr_76e08fawd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_73b8262wd"
      Public Shared FechaDeInicio_UTC$ = "pr_73b8351wd"
      Public Shared NoSePuedeUtilizarEstePermisoPuntualParaRealizarUnaModificacion$ = "pr_73b8365wd"
      Public Shared HoraLocal$ = "pr_77611c4wd"
      Public Shared ReferenciaDestinador$ = "pr_73b822awd"
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
      Public Class PermisoPuntualARegistrosC
          Public RegistrosAcceso As String
          Public Observaciones As String
          Public EmpleadosAsignados As String
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaRol As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public PuedeVerObsoleto As Boolean
          Public FechaAlta_UTC As Date
          Public FechaDeFin_UTC As Date
          Public PuedeComentarObsoleto As Boolean
          Public PuedeVerComentariosObsoleto As Boolean
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public FechaDeInicio_UTC As Date
          Public NoSePuedeUtilizarEstePermisoPuntualParaRealizarUnaModificacion As Boolean
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
      Public Class PermisoPuntualARegistros_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
          Public property RegistrosAcceso As String
            get
                return me.GetValue_String("pr_7ac197fwd")
            End Get
            Set(value As String)
                me.SetValue_String("pr_7ac197fwd", value)
            End Set
          End Property
          Public property Observaciones As String
            get
                return me.GetValue_String("pr_30040104958")
            End Get
            Set(value As String)
                me.SetValue_String("pr_30040104958", value)
            End Set
          End Property
          Public property EmpleadosAsignados As String
            get
                return me.GetValue_String("pr_7ac197dwd")
            End Get
            Set(value As String)
                me.SetValue_String("pr_7ac197dwd", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_73b820ewd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_73b820ewd", value)
            End Set
          End Property
          Public property ReferenciaRol As Guid
            get
                return me.GetValue_Guid("pr_76ec8dfwd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_76ec8dfwd", value)
            End Set
          End Property
          Public property PuedeVerObsoleto As Boolean
            get
                return me.GetValue_Boolean("pr_73b8361wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_73b8361wd", value)
            End Set
          End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_73b821ewd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_73b821ewd", value)
            End Set
          End Property
          Public property FechaDeFin_UTC As Date
            get
                return me.GetValue_DateTime("pr_73b8355wd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_73b8355wd", value)
            End Set
          End Property
          Public property PuedeComentarObsoleto As Boolean
            get
                return me.GetValue_Boolean("pr_76e08f6wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_76e08f6wd", value)
            End Set
          End Property
          Public property PuedeVerComentariosObsoleto As Boolean
            get
                return me.GetValue_Boolean("pr_76e08fawd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_76e08fawd", value)
            End Set
          End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_73b8262wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_73b8262wd", value)
            End Set
          End Property
          Public property FechaDeInicio_UTC As Date
            get
                return me.GetValue_DateTime("pr_73b8351wd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_73b8351wd", value)
            End Set
          End Property
          Public property NoSePuedeUtilizarEstePermisoPuntualParaRealizarUnaModificacion As Boolean
            get
                return me.GetValue_Boolean("pr_73b8365wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_73b8365wd", value)
            End Set
          End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_77611c4wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_73b822awd")
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
