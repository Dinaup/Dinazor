Partial Public Class SeccionesD
  Public Class CambiosDeContraseñasD
      Public Shared _SeccionID As String = "e203fcf2-b428-44a7-9121-3bd6b0a830af"
      Public Shared _SeccionIDGUID As New Guid("e203fcf2-b428-44a7-9121-3bd6b0a830af")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As CambiosDeContraseñas_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, CambiosDeContraseñasES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New CambiosDeContraseñas_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As CambiosDeContraseñas_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, CambiosDeContraseñasES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New CambiosDeContraseñas_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class CambiosDeContraseñasES
          Public shared _SeccionID as Guid = New Guid("e203fcf2-b428-44a7-9121-3bd6b0a830af")
          Public shared _Tabla$ = "tpr_60040474803"
      Public Shared ReferenciaDestinador$ = "pr_600404748015"
      Public Shared FechaAlta_UTC$ = "pr_600404748014"
      Public Shared HoraLocal$ = "pr_600404748012"
      Public Shared FechaDato_UTC$ = "pr_600404748011"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_600404748026"
      Public Shared ReferenciaServidor$ = "pr_600404748028"
      Public Shared ReferenciaEntidad$ = "pr_600404748029"
      Public Shared EntidadTieneAccesoWeb$ = "pr_600404748030"
      Public Shared Aplicacion$ = "pr_600404748031"
      Public Shared Usuario$ = "pr_600404748032"
      Public Shared Navegador$ = "pr_10040474811"
      Public Shared ReferenciaAutorDelAlta$ = "pr_600404748010"
      Public Shared DireccionIP$ = "pr_10040474812"
      Public Shared CambioEfectuado$ = "pr_10040474817"
      Public Shared ReferenciaCorreoEnviado$ = "pr_40040474832"
      Public Shared Codigo$ = "pr_20040480161001"
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
      Public Class CambiosDeContraseñasC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public HoraLocal As Integer
          Public FechaDato_UTC As Date
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaServidor As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaEntidad As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public EntidadTieneAccesoWeb As Boolean
          Public Aplicacion As String
          Public Usuario As String
          Public Navegador As String
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public DireccionIP As String
          Public CambioEfectuado As Boolean
          Public ReferenciaCorreoEnviado As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Codigo As String
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
      Public Class CambiosDeContraseñas_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_600404748015")
            End Get   
        End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_600404748014")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_600404748014", value)
            End Set
          End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_600404748012")
            End Get   
        End Property
          Public property FechaDato_UTC As Date
            get
                return me.GetValue_DateTime("pr_600404748011")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_600404748011", value)
            End Set
          End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_600404748026")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_600404748026", value)
            End Set
          End Property
          Public property ReferenciaServidor As Guid
            get
                return me.GetValue_Guid("pr_600404748028")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_600404748028", value)
            End Set
          End Property
          Public property ReferenciaEntidad As Guid
            get
                return me.GetValue_Guid("pr_600404748029")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_600404748029", value)
            End Set
          End Property
          Public property EntidadTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_600404748030")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_600404748030", value)
            End Set
          End Property
          Public property Aplicacion As String
            get
                return me.GetValue_String("pr_600404748031")
            End Get
            Set(value As String)
                me.SetValue_String("pr_600404748031", value)
            End Set
          End Property
          Public property Usuario As String
            get
                return me.GetValue_String("pr_600404748032")
            End Get
            Set(value As String)
                me.SetValue_String("pr_600404748032", value)
            End Set
          End Property
          Public property Navegador As String
            get
                return me.GetValue_String("pr_10040474811")
            End Get
            Set(value As String)
                me.SetValue_String("pr_10040474811", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_600404748010")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_600404748010", value)
            End Set
          End Property
          Public property DireccionIP As String
            get
                return me.GetValue_String("pr_10040474812")
            End Get
            Set(value As String)
                me.SetValue_String("pr_10040474812", value)
            End Set
          End Property
          Public property CambioEfectuado As Boolean
            get
                return me.GetValue_Boolean("pr_10040474817")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_10040474817", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaCorreoEnviado As Guid
            get
                return me.GetValue_Guid("pr_40040474832")
            End Get   
        End Property
        Public ReadOnly property Codigo As String
            get
                return me.GetValue_String("pr_20040480161001")
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
