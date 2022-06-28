Partial Public Class SeccionesD
  Public Class ConfiguracionSistemaListaD
      Public Shared _SeccionID As String = "b479f6b0-3c50-4a00-aa2c-01a232bbf062"
      Public Shared _SeccionIDGUID As New Guid("b479f6b0-3c50-4a00-aa2c-01a232bbf062")
      Public Class ConfiguracionSistemaListaES
          Public shared _SeccionID as Guid = New Guid("b479f6b0-3c50-4a00-aa2c-01a232bbf062")
          Public shared _Tabla$ = "tpr_41de99bwc_e"
      Public Shared ReferenciaAutorDelAlta$ = "pr_14631032dfg292wd"
      Public Shared ReferenciaSeccionValorRelacion$ = "pr_41e0235x2fdwc"
      Public Shared ReferenciaValorImagen$ = "pr_41e0185x96wc"
      Public Shared Valor$ = "pr_41e0266x2d7wc"
      Public Shared FechaAlta_UTC$ = "pr_14c9f3e49eg355wd"
      Public Shared ReferenciaReferenciaValor$ = "pr_41e0214x50wc"
      Public Shared ReferenciaParametro$ = "pr_41dff90x265wc"
      Public Shared HoraLocal$ = "pr_776aea2wd"
      Public Shared ReferenciaDestinador$ = "pr_146310355axc7wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_146314960fg295wd"
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
      Public Shared RelacionElementoContenedorListador$ = "idrelacionlistador"
      Public Shared Listadoreliminado$ = "listadoreliminado"
      End Class
      Public Class ConfiguracionSistemaListaC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaSeccionValorRelacion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaValorImagen As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Valor As String
          Public FechaAlta_UTC As Date
          Public ReferenciaReferenciaValor As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaParametro As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
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
          Public RelacionElementoContenedorListador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Listadoreliminado As Boolean
          Sub new()
          End Sub
      End Class
      Public Class ConfiguracionSistemaLista_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_14631032dfg292wd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_14631032dfg292wd", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaSeccionValorRelacion As Guid
            get
                return me.GetValue_Guid("pr_41e0235x2fdwc")
            End Get   
        End Property
          Public property ReferenciaValorImagen As Guid
            get
                return me.GetValue_Guid("pr_41e0185x96wc")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_41e0185x96wc", value)
            End Set
          End Property
          Public property Valor As String
            get
                return me.GetValue_String("pr_41e0266x2d7wc")
            End Get
            Set(value As String)
                me.SetValue_String("pr_41e0266x2d7wc", value)
            End Set
          End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_14c9f3e49eg355wd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_14c9f3e49eg355wd", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaReferenciaValor As Guid
            get
                return me.GetValue_Guid("pr_41e0214x50wc")
            End Get   
        End Property
        Public ReadOnly property ReferenciaParametro As Guid
            get
                return me.GetValue_Guid("pr_41dff90x265wc")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_776aea2wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_146310355axc7wd")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_146314960fg295wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_146314960fg295wd", value)
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
        Public ReadOnly property RelacionElementoContenedorListador As Guid
            get
                return me.GetValue_Guid("idrelacionlistador")
            End Get   
        End Property
          Public property Listadoreliminado As Boolean
            get
                return me.GetValue_Boolean("listadoreliminado")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("listadoreliminado", value)
            End Set
          End Property
          Sub New(___VV__ As DinaNETCore.API_VVC , _Token$)
              MyBase.New(___VV__, _Token) 
              Me.Evento_Actualizar()
          End Sub
      End Class
  End Class
End Class
