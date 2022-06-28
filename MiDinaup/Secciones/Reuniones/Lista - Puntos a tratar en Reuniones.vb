Partial Public Class SeccionesD
  Public Class PuntosATratarEnReunionesListaD
      Public Shared _SeccionID As String = "6ba1d828-be9b-49d7-bf95-4748edf2db1e"
      Public Shared _SeccionIDGUID As New Guid("6ba1d828-be9b-49d7-bf95-4748edf2db1e")
      Public Class PuntosATratarEnReunionesListaES
          Public shared _SeccionID as Guid = New Guid("6ba1d828-be9b-49d7-bf95-4748edf2db1e")
          Public shared _Tabla$ = "tpr_50040147511_e"
      Public Shared ReferenciaDestinador$ = "pr_500401475120"
      Public Shared FechaAlta_UTC$ = "pr_500401475119"
      Public Shared HoraLocal$ = "pr_500401475118"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_500401475123"
      Public Shared ReferenciaAutorDelAlta$ = "pr_500401475116"
      Public Shared ConclusionesDelPuntoATratar$ = "pr_10040147523"
      Public Shared DetallesDelPuntoATratar$ = "pr_10040147521"
      Public Shared ReferenciaReunion$ = "pr_30040147521"
      Public Shared PuntoTratadoObsoleto$ = "pr_20040147521"
      Public Shared PuntoCanceladoObsoleto$ = "pr_20040147522"
      Public Shared PuntoPospuestoObsoleto$ = "pr_20040147523"
      Public Shared AccionesATomar$ = "pr_50040147521"
      Public Shared Estado$ = "pr_60040405189"
      Public Shared DejarConstanciaEnActas$ = "pr_50040409251"
      Public Shared Inicio_UTC$ = "pr_50040409252"
      Public Shared Fin_UTC$ = "pr_50040409253"
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
      Public Class PuntosATratarEnReunionesListaC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ConclusionesDelPuntoATratar As String
          Public DetallesDelPuntoATratar As String
          Public ReferenciaReunion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public PuntoTratadoObsoleto As Boolean
          Public PuntoCanceladoObsoleto As Boolean
          Public PuntoPospuestoObsoleto As Boolean
          Public AccionesATomar As String
          Public Estado As Integer
          Public DejarConstanciaEnActas As Boolean
          Public Inicio_UTC As Date
          Public Fin_UTC As Date
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
      Public Class PuntosATratarEnReunionesLista_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_500401475120")
            End Get   
        End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_500401475119")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_500401475119", value)
            End Set
          End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_500401475118")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_500401475123")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_500401475123", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_500401475116")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_500401475116", value)
            End Set
          End Property
          Public property ConclusionesDelPuntoATratar As String
            get
                return me.GetValue_String("pr_10040147523")
            End Get
            Set(value As String)
                me.SetValue_String("pr_10040147523", value)
            End Set
          End Property
          Public property DetallesDelPuntoATratar As String
            get
                return me.GetValue_String("pr_10040147521")
            End Get
            Set(value As String)
                me.SetValue_String("pr_10040147521", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaReunion As Guid
            get
                return me.GetValue_Guid("pr_30040147521")
            End Get   
        End Property
          Public property PuntoTratadoObsoleto As Boolean
            get
                return me.GetValue_Boolean("pr_20040147521")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_20040147521", value)
            End Set
          End Property
          Public property PuntoCanceladoObsoleto As Boolean
            get
                return me.GetValue_Boolean("pr_20040147522")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_20040147522", value)
            End Set
          End Property
          Public property PuntoPospuestoObsoleto As Boolean
            get
                return me.GetValue_Boolean("pr_20040147523")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_20040147523", value)
            End Set
          End Property
          Public property AccionesATomar As String
            get
                return me.GetValue_String("pr_50040147521")
            End Get
            Set(value As String)
                me.SetValue_String("pr_50040147521", value)
            End Set
          End Property
          Public property Estado As Integer
            get
                return me.GetValue_Integer("pr_60040405189")
            End Get
            Set(value As Integer)
                me.SetValue_Integer("pr_60040405189", value)
            End Set
          End Property
          Public property DejarConstanciaEnActas As Boolean
            get
                return me.GetValue_Boolean("pr_50040409251")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_50040409251", value)
            End Set
          End Property
          Public property Inicio_UTC As Date
            get
                return me.GetValue_DateTime("pr_50040409252")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_50040409252", value)
            End Set
          End Property
          Public property Fin_UTC As Date
            get
                return me.GetValue_DateTime("pr_50040409253")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_50040409253", value)
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
