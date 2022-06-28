Partial Public Class SeccionesD
  Public Class ComentariosDeAgendasD
      Public Shared _SeccionID As String = "eab46ae1-aacf-490c-9a7e-dbe149cf5520"
      Public Shared _SeccionIDGUID As New Guid("eab46ae1-aacf-490c-9a7e-dbe149cf5520")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As ComentariosDeAgendas_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, ComentariosDeAgendasES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New ComentariosDeAgendas_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As ComentariosDeAgendas_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, ComentariosDeAgendasES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New ComentariosDeAgendas_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class ComentariosDeAgendasES
          Public shared _SeccionID as Guid = New Guid("eab46ae1-aacf-490c-9a7e-dbe149cf5520")
          Public shared _Tabla$ = "tpr_7ccd47fxd"
      Public Shared FechaDeComentario$ = "pr_7cce650wd"
      Public Shared ReferenciaAgenda$ = "pr_7ccd94awd"
      Public Shared ComentarioSecundario$ = "pr_7ccfc9fwd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_7ccd4b5wd"
      Public Shared Comentario$ = "pr_7ccd94ewd"
      Public Shared ReferenciaDestinador$ = "pr_7ccd49bwd"
      Public Shared HoraLocal$ = "pr_7ccd48dwd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_7ccd489wd"
      Public Shared ReferenciaAgendaSeccion$ = "pr_7ccd94cwd"
      Public Shared FechaAlta_UTC$ = "pr_7ccd495wd"
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
      Public Class ComentariosDeAgendasC
          Public FechaDeComentario As Date
          Public ReferenciaAgenda As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ComentarioSecundario As String
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public Comentario As String
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaAgendaSeccion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
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
      Public Class ComentariosDeAgendas_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
        Public ReadOnly property FechaDeComentario As Date
            get
                return me.GetValue_Date("pr_7cce650wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaAgenda As Guid
            get
                return me.GetValue_Guid("pr_7ccd94awd")
            End Get   
        End Property
          Public property ComentarioSecundario As String
            get
                return me.GetValue_String("pr_7ccfc9fwd")
            End Get
            Set(value As String)
                me.SetValue_String("pr_7ccfc9fwd", value)
            End Set
          End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_7ccd4b5wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_7ccd4b5wd", value)
            End Set
          End Property
          Public property Comentario As String
            get
                return me.GetValue_String("pr_7ccd94ewd")
            End Get
            Set(value As String)
                me.SetValue_String("pr_7ccd94ewd", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_7ccd49bwd")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_7ccd48dwd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_7ccd489wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaAgendaSeccion As Guid
            get
                return me.GetValue_Guid("pr_7ccd94cwd")
            End Get   
        End Property
        Public ReadOnly property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_7ccd495wd")
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
