Partial Public Class SeccionesD
  Public Class PersonalizacionDeInformesD
      Public Shared _SeccionID As String = "50256ef1-4a58-4afc-bd3b-f6363f990ac0"
      Public Shared _SeccionIDGUID As New Guid("50256ef1-4a58-4afc-bd3b-f6363f990ac0")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As PersonalizacionDeInformes_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, PersonalizacionDeInformesES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New PersonalizacionDeInformes_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As PersonalizacionDeInformes_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, PersonalizacionDeInformesES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New PersonalizacionDeInformes_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class PersonalizacionDeInformesES
          Public shared _SeccionID as Guid = New Guid("50256ef1-4a58-4afc-bd3b-f6363f990ac0")
          Public shared _Tabla$ = "tpr_78331e0xd"
      Public Shared Descripcion$ = "pr_7850c19wd"
      Public Shared BloquearResumenes$ = "pr_7850c05wd"
      Public Shared Subcategoria$ = "pr_7850c1bwd"
      Public Shared ReferenciaInformes$ = "pr_78340afwd"
      Public Shared NoPermitirImprimir$ = "pr_7850c09wd"
      Public Shared ResultadosPorPagina$ = "pr_7850c17wd"
      Public Shared BloquearFiltros$ = "pr_7850c07wd"
      Public Shared NoPermitirCambioDePagina$ = "pr_7850c0fwd"
      Public Shared ReferenciaPlantillaDeImpresionPorDefecto$ = "pr_7850c23wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_7833212wd"
      Public Shared ReferenciaIcono$ = "pr_7850c21wd"
      Public Shared Filtrado11Obsoleto$ = "pr_7850c25wd"
      Public Shared TipoDeAviso$ = "pr_7850c13wd"
      Public Shared ReferenciaDestinador$ = "pr_7833208wd"
      Public Shared HoraLocal$ = "pr_78331fcwd"
      Public Shared NoMostrarEnInformesRelacionados$ = "pr_7850c0dwd"
      Public Shared Categoria$ = "pr_7850c1dwd"
      Public Shared BloquearOrden$ = "pr_7850c01wd"
      Public Shared NoMostrarEnRelacionesIndirectasDeRegistros$ = "pr_7850c0bwd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_78331f8wd"
      Public Shared ExportarEnModulos$ = "pr_78331fewd"
      Public Shared FechaAlta_UTC$ = "pr_7833202wd"
      Public Shared BloquearAgrupacion$ = "pr_7850c03wd"
      Public Shared Aviso$ = "pr_7850c15wd"
      Public Shared Titulo$ = "pr_7850c1fwd"
      Public Shared BloquearAccesoTotal$ = "pr_7850c11wd"
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
      Public Class PersonalizacionDeInformesC
          Public Descripcion As String
          Public BloquearResumenes As Boolean
          Public Subcategoria As String
          Public ReferenciaInformes As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public NoPermitirImprimir As Boolean
          Public ResultadosPorPagina As Integer
          Public BloquearFiltros As Boolean
          Public NoPermitirCambioDePagina As Boolean
          Public ReferenciaPlantillaDeImpresionPorDefecto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaIcono As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Filtrado11Obsoleto As String
          Public TipoDeAviso As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public NoMostrarEnInformesRelacionados As Boolean
          Public Categoria As String
          Public BloquearOrden As Boolean
          Public NoMostrarEnRelacionesIndirectasDeRegistros As Boolean
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public BloquearAgrupacion As Boolean
          Public Aviso As String
          Public Titulo As String
          Public BloquearAccesoTotal As Boolean
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
      Public Class PersonalizacionDeInformes_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
        Public ReadOnly property Descripcion As String
            get
                return me.GetValue_String("pr_7850c19wd")
            End Get   
        End Property
        Public ReadOnly property BloquearResumenes As Boolean
            get
                return me.GetValue_Boolean("pr_7850c05wd")
            End Get   
        End Property
        Public ReadOnly property Subcategoria As String
            get
                return me.GetValue_String("pr_7850c1bwd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaInformes As Guid
            get
                return me.GetValue_Guid("pr_78340afwd")
            End Get   
        End Property
        Public ReadOnly property NoPermitirImprimir As Boolean
            get
                return me.GetValue_Boolean("pr_7850c09wd")
            End Get   
        End Property
        Public ReadOnly property ResultadosPorPagina As Integer
            get
                return me.GetValue_Integer("pr_7850c17wd")
            End Get   
        End Property
        Public ReadOnly property BloquearFiltros As Boolean
            get
                return me.GetValue_Boolean("pr_7850c07wd")
            End Get   
        End Property
        Public ReadOnly property NoPermitirCambioDePagina As Boolean
            get
                return me.GetValue_Boolean("pr_7850c0fwd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaPlantillaDeImpresionPorDefecto As Guid
            get
                return me.GetValue_Guid("pr_7850c23wd")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_7833212wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_7833212wd", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaIcono As Guid
            get
                return me.GetValue_Guid("pr_7850c21wd")
            End Get   
        End Property
        Public ReadOnly property Filtrado11Obsoleto As String
            get
                return me.GetValue_String("pr_7850c25wd")
            End Get   
        End Property
        Public ReadOnly property TipoDeAviso As Integer
            get
                return me.GetValue_Integer("pr_7850c13wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_7833208wd")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_78331fcwd")
            End Get   
        End Property
        Public ReadOnly property NoMostrarEnInformesRelacionados As Boolean
            get
                return me.GetValue_Boolean("pr_7850c0dwd")
            End Get   
        End Property
        Public ReadOnly property Categoria As String
            get
                return me.GetValue_String("pr_7850c1dwd")
            End Get   
        End Property
        Public ReadOnly property BloquearOrden As Boolean
            get
                return me.GetValue_Boolean("pr_7850c01wd")
            End Get   
        End Property
        Public ReadOnly property NoMostrarEnRelacionesIndirectasDeRegistros As Boolean
            get
                return me.GetValue_Boolean("pr_7850c0bwd")
            End Get   
        End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_78331f8wd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_78331f8wd", value)
            End Set
          End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_7833202wd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_7833202wd", value)
            End Set
          End Property
        Public ReadOnly property BloquearAgrupacion As Boolean
            get
                return me.GetValue_Boolean("pr_7850c03wd")
            End Get   
        End Property
        Public ReadOnly property Aviso As String
            get
                return me.GetValue_String("pr_7850c15wd")
            End Get   
        End Property
        Public ReadOnly property Titulo As String
            get
                return me.GetValue_String("pr_7850c1fwd")
            End Get   
        End Property
        Public ReadOnly property BloquearAccesoTotal As Boolean
            get
                return me.GetValue_Boolean("pr_7850c11wd")
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
