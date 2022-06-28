Partial Public Class SeccionesD
  Public Class PersonalizacionDeSeccionesD
      Public Shared _SeccionID As String = "7adf758d-1b5d-4b37-82c1-aedc5edc98fc"
      Public Shared _SeccionIDGUID As New Guid("7adf758d-1b5d-4b37-82c1-aedc5edc98fc")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As PersonalizacionDeSecciones_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, PersonalizacionDeSeccionesES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New PersonalizacionDeSecciones_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As PersonalizacionDeSecciones_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, PersonalizacionDeSeccionesES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New PersonalizacionDeSecciones_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class PersonalizacionDeSeccionesES
          Public shared _SeccionID as Guid = New Guid("7adf758d-1b5d-4b37-82c1-aedc5edc98fc")
          Public shared _Tabla$ = "tpr_7808436xd"
      Public Shared ReferenciaIcono$ = "pr_7850c27wd"
      Public Shared ReferenciaImpresionDefecto$ = "pr_7850c2bwd"
      Public Shared ReferenciaTooltip$ = "pr_78513a4wd"
      Public Shared ExportarEnModulos$ = "pr_7808442wd"
      Public Shared FechaAlta_UTC$ = "pr_7808446wd"
      Public Shared Color$ = "pr_7850c29wd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_780843cwd"
      Public Shared PersonalizarDocumentoCompacto$ = "pr_795a9e9wd"
      Public Shared PersonalizarImpresion$ = "pr_795a9ebwd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_780846ewd"
      Public Shared HoraLocal$ = "pr_7808440wd"
      Public Shared ReferenciaDestinador$ = "pr_780844cwd"
      Public Shared ReferenciaDocumentoCompacto$ = "pr_7850c2dwd"
      Public Shared ReferenciaSeccionPersonalizada$ = "pr_78560d4wd"
      Public Shared ActivarSistemaDeAgenda$ = "pr_7808470wd"
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
      Public Class PersonalizacionDeSeccionesC
          Public ReferenciaIcono As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaImpresionDefecto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaTooltip As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public Color As String
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public PersonalizarDocumentoCompacto As Boolean
          Public PersonalizarImpresion As Boolean
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaDocumentoCompacto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaSeccionPersonalizada As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ActivarSistemaDeAgenda As Boolean
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
      Public Class PersonalizacionDeSecciones_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
        Public ReadOnly property ReferenciaIcono As Guid
            get
                return me.GetValue_Guid("pr_7850c27wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaImpresionDefecto As Guid
            get
                return me.GetValue_Guid("pr_7850c2bwd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaTooltip As Guid
            get
                return me.GetValue_Guid("pr_78513a4wd")
            End Get   
        End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_7808446wd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_7808446wd", value)
            End Set
          End Property
        Public ReadOnly property Color As String
            get
                return me.GetValue_String("pr_7850c29wd")
            End Get   
        End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_780843cwd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_780843cwd", value)
            End Set
          End Property
        Public ReadOnly property PersonalizarDocumentoCompacto As Boolean
            get
                return me.GetValue_Boolean("pr_795a9e9wd")
            End Get   
        End Property
        Public ReadOnly property PersonalizarImpresion As Boolean
            get
                return me.GetValue_Boolean("pr_795a9ebwd")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_780846ewd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_780846ewd", value)
            End Set
          End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_7808440wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_780844cwd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDocumentoCompacto As Guid
            get
                return me.GetValue_Guid("pr_7850c2dwd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaSeccionPersonalizada As Guid
            get
                return me.GetValue_Guid("pr_78560d4wd")
            End Get   
        End Property
        Public ReadOnly property ActivarSistemaDeAgenda As Boolean
            get
                return me.GetValue_Boolean("pr_7808470wd")
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
