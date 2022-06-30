Partial Public Class SeccionesD
  Public Class EstadosDeRegistrosD
      Public Shared _SeccionID As String = "ed63af98-e1b4-4017-849b-93873bfd830d"
      Public Shared _SeccionIDGUID As New Guid("ed63af98-e1b4-4017-849b-93873bfd830d")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As EstadosDeRegistros_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, EstadosDeRegistrosES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New EstadosDeRegistros_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As EstadosDeRegistros_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, EstadosDeRegistrosES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New EstadosDeRegistros_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class EstadosDeRegistrosES
          Public shared _SeccionID as Guid = New Guid("ed63af98-e1b4-4017-849b-93873bfd830d")
          Public shared _Tabla$ = "tpr_50040382151"
      Public Shared ReferenciaDestinador$ = "pr_500403821512"
      Public Shared ExportarEnModulos$ = "pr_500403821510"
      Public Shared HoraLocal$ = "pr_50040382159"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_500403821522"
      Public Shared FechaAlta_UTC$ = "pr_500403821511"
      Public Shared ReferenciaAutorDelAlta$ = "pr_50040382157"
      Public Shared Observaciones$ = "pr_20040382222"
      Public Shared Estado$ = "pr_20040382221"
      Public Shared TituloObsoleto$ = "pr_30040384562"
      Public Shared ReferenciaIcono$ = "pr_400103845414"
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
      Public Class EstadosDeRegistrosC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public FechaAlta_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Observaciones As String
          Public Estado As Integer
          Public TituloObsoleto As String
          Public ReferenciaIcono As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
      Public Class EstadosDeRegistros_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_500403821512")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_50040382159")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_500403821522")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_500403821522", value)
            End Set
          End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_500403821511")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_500403821511", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_50040382157")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_50040382157", value)
            End Set
          End Property
          Public property Observaciones As String
            get
                return me.GetValue_String("pr_20040382222")
            End Get
            Set(value As String)
                me.SetValue_String("pr_20040382222", value)
            End Set
          End Property
          Public property Estado As Integer
            get
                return me.GetValue_Integer("pr_20040382221")
            End Get
            Set(value As Integer)
                me.SetValue_Integer("pr_20040382221", value)
            End Set
          End Property
          Public property TituloObsoleto As String
            get
                return me.GetValue_String("pr_30040384562")
            End Get
            Set(value As String)
                me.SetValue_String("pr_30040384562", value)
            End Set
          End Property
          Public property ReferenciaIcono As Guid
            get
                return me.GetValue_Guid("pr_400103845414")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_400103845414", value)
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
