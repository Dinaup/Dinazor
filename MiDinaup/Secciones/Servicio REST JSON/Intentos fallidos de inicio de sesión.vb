Partial Public Class SeccionesD
  Public Class IntentosFallidosDeInicioDeSesionD
      Public Shared _SeccionID As String = "bd8e7893-4c8d-41c0-be2e-da9b3053fbe9"
      Public Shared _SeccionIDGUID As New Guid("bd8e7893-4c8d-41c0-be2e-da9b3053fbe9")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As IntentosFallidosDeInicioDeSesion_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, IntentosFallidosDeInicioDeSesionES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New IntentosFallidosDeInicioDeSesion_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As IntentosFallidosDeInicioDeSesion_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, IntentosFallidosDeInicioDeSesionES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New IntentosFallidosDeInicioDeSesion_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class IntentosFallidosDeInicioDeSesionES
          Public shared _SeccionID as Guid = New Guid("bd8e7893-4c8d-41c0-be2e-da9b3053fbe9")
          Public shared _Tabla$ = "tpr_10040178401"
      Public Shared ReferenciaDestinador$ = "pr_100401784013"
      Public Shared FechaDato_UTC$ = "pr_10040178409"
      Public Shared HoraLocal$ = "pr_100401784010"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_100401784024"
      Public Shared FechaAlta_UTC$ = "pr_100401784012"
      Public Shared ReferenciaAutorDelAlta$ = "pr_10040178408"
      Public Shared EntidadTieneAccesoWeb$ = "pr_20040178403"
      Public Shared Usuario$ = "pr_20040178402"
      Public Shared ReferenciaEntidad$ = "pr_20040178401"
      Public Shared DireccionIP$ = "pr_20040178404"
      Public Shared Aplicacion$ = "pr_20040178405"
      Public Shared Navegador$ = "pr_20040178406"
      Public Shared ReferenciaServidor$ = "pr_40040218984"
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
      Public Class IntentosFallidosDeInicioDeSesionC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaDato_UTC As Date
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public FechaAlta_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public EntidadTieneAccesoWeb As Boolean
          Public Usuario As String
          Public ReferenciaEntidad As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public DireccionIP As String
          Public Aplicacion As String
          Public Navegador As String
          Public ReferenciaServidor As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
      Public Class IntentosFallidosDeInicioDeSesion_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_100401784013")
            End Get   
        End Property
        Public ReadOnly property FechaDato_UTC As Date
            get
                return me.GetValue_DateTime("pr_10040178409")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_100401784010")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_100401784024")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_100401784024", value)
            End Set
          End Property
        Public ReadOnly property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_100401784012")
            End Get   
        End Property
        Public ReadOnly property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_10040178408")
            End Get   
        End Property
          Public property EntidadTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_20040178403")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_20040178403", value)
            End Set
          End Property
        Public ReadOnly property Usuario As String
            get
                return me.GetValue_String("pr_20040178402")
            End Get   
        End Property
        Public ReadOnly property ReferenciaEntidad As Guid
            get
                return me.GetValue_Guid("pr_20040178401")
            End Get   
        End Property
        Public ReadOnly property DireccionIP As String
            get
                return me.GetValue_String("pr_20040178404")
            End Get   
        End Property
        Public ReadOnly property Aplicacion As String
            get
                return me.GetValue_String("pr_20040178405")
            End Get   
        End Property
        Public ReadOnly property Navegador As String
            get
                return me.GetValue_String("pr_20040178406")
            End Get   
        End Property
        Public ReadOnly property ReferenciaServidor As Guid
            get
                return me.GetValue_Guid("pr_40040218984")
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
