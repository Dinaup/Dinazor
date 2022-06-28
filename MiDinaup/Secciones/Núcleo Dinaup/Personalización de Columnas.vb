Partial Public Class SeccionesD
  Public Class PersonalizacionDeColumnasD
      Public Shared _SeccionID As String = "52b7139f-dcd4-4d34-bd99-bee192778ef8"
      Public Shared _SeccionIDGUID As New Guid("52b7139f-dcd4-4d34-bd99-bee192778ef8")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As PersonalizacionDeColumnas_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, PersonalizacionDeColumnasES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New PersonalizacionDeColumnas_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As PersonalizacionDeColumnas_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, PersonalizacionDeColumnasES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New PersonalizacionDeColumnas_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class PersonalizacionDeColumnasES
          Public shared _SeccionID as Guid = New Guid("52b7139f-dcd4-4d34-bd99-bee192778ef8")
          Public shared _Tabla$ = "tpr_7833a70xd"
      Public Shared FechaAlta_UTC$ = "pr_7833a84wd"
      Public Shared ExportarEnModulos$ = "pr_7833a80wd"
      Public Shared NoPermitirBloquear$ = "pr_78513acwd"
      Public Shared ModoOcultado$ = "pr_78513a6wd"
      Public Shared NoPermitirOrdenar$ = "pr_78513aawd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_7833a7awd"
      Public Shared Titulo$ = "pr_78513b6wd"
      Public Shared ReferenciaColumna$ = "pr_783422bwd"
      Public Shared NoPermitirAgrupar$ = "pr_78513aewd"
      Public Shared NoPermitirFiltrar$ = "pr_78513a8wd"
      Public Shared Observaciones$ = "pr_78513b8wd"
      Public Shared ReferenciaDestinador$ = "pr_7833a8awd"
      Public Shared HoraLocal$ = "pr_7833a7ewd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_7833aa8wd"
      Public Shared NoPermitirResumenes$ = "pr_78513b0wd"
      Public Shared Descripcion$ = "pr_78513b4wd"
      Public Shared ReferenciaIcono$ = "pr_78513b2wd"
      Public Shared KeywordJSON$ = "pr_500404304027"
      Public Shared ReferenciaInforme$ = "pr_10040430412"
      Public Shared TituloEtiquetaVirtual$ = "pr_30040430496"
      Public Shared ColumnaVirtualID$ = "pr_30040430497"
      Public Shared EsVirtual$ = "pr_10040430494"
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
      Public Class PersonalizacionDeColumnasC
          Public FechaAlta_UTC As Date
          Public NoPermitirBloquear As Boolean
          Public ModoOcultado As Integer
          Public NoPermitirOrdenar As Boolean
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Titulo As String
          Public ReferenciaColumna As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public NoPermitirAgrupar As Boolean
          Public NoPermitirFiltrar As Boolean
          Public Observaciones As String
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public NoPermitirResumenes As Boolean
          Public Descripcion As String
          Public ReferenciaIcono As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public KeywordJSON As String
          Public ReferenciaInforme As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public TituloEtiquetaVirtual As String
          Public ColumnaVirtualID As String
          Public EsVirtual As Boolean
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
      Public Class PersonalizacionDeColumnas_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_7833a84wd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_7833a84wd", value)
            End Set
          End Property
        Public ReadOnly property NoPermitirBloquear As Boolean
            get
                return me.GetValue_Boolean("pr_78513acwd")
            End Get   
        End Property
        Public ReadOnly property ModoOcultado As Integer
            get
                return me.GetValue_Integer("pr_78513a6wd")
            End Get   
        End Property
        Public ReadOnly property NoPermitirOrdenar As Boolean
            get
                return me.GetValue_Boolean("pr_78513aawd")
            End Get   
        End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_7833a7awd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_7833a7awd", value)
            End Set
          End Property
          Public property Titulo As String
            get
                return me.GetValue_String("pr_78513b6wd")
            End Get
            Set(value As String)
                me.SetValue_String("pr_78513b6wd", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaColumna As Guid
            get
                return me.GetValue_Guid("pr_783422bwd")
            End Get   
        End Property
        Public ReadOnly property NoPermitirAgrupar As Boolean
            get
                return me.GetValue_Boolean("pr_78513aewd")
            End Get   
        End Property
        Public ReadOnly property NoPermitirFiltrar As Boolean
            get
                return me.GetValue_Boolean("pr_78513a8wd")
            End Get   
        End Property
        Public ReadOnly property Observaciones As String
            get
                return me.GetValue_String("pr_78513b8wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_7833a8awd")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_7833a7ewd")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_7833aa8wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_7833aa8wd", value)
            End Set
          End Property
        Public ReadOnly property NoPermitirResumenes As Boolean
            get
                return me.GetValue_Boolean("pr_78513b0wd")
            End Get   
        End Property
        Public ReadOnly property Descripcion As String
            get
                return me.GetValue_String("pr_78513b4wd")
            End Get   
        End Property
          Public property ReferenciaIcono As Guid
            get
                return me.GetValue_Guid("pr_78513b2wd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_78513b2wd", value)
            End Set
          End Property
          Public property KeywordJSON As String
            get
                return me.GetValue_String("pr_500404304027")
            End Get
            Set(value As String)
                me.SetValue_String("pr_500404304027", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaInforme As Guid
            get
                return me.GetValue_Guid("pr_10040430412")
            End Get   
        End Property
        Public ReadOnly property TituloEtiquetaVirtual As String
            get
                return me.GetValue_String("pr_30040430496")
            End Get   
        End Property
        Public ReadOnly property ColumnaVirtualID As String
            get
                return me.GetValue_String("pr_30040430497")
            End Get   
        End Property
        Public ReadOnly property EsVirtual As Boolean
            get
                return me.GetValue_Boolean("pr_10040430494")
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
