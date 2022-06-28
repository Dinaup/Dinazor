Partial Public Class SeccionesD
  Public Class HorariosListaD
      Public Shared _SeccionID As String = "9b7b29f9-392d-4a3e-a5c6-2c5e5910adbe"
      Public Shared _SeccionIDGUID As New Guid("9b7b29f9-392d-4a3e-a5c6-2c5e5910adbe")
      Public Class HorariosListaES
          Public shared _SeccionID as Guid = New Guid("9b7b29f9-392d-4a3e-a5c6-2c5e5910adbe")
          Public shared _Tabla$ = "tpr_6351d72xd_e"
      Public Shared ReferenciaJornada$ = "pr_7772a91wd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_183f7b1731x1d7wd"
      Public Shared DiaDeLaSemana$ = "pr_7772a8fwd"
      Public Shared FechaAlta_UTC$ = "pr_183f7b1744x3dewd"
      Public Shared Observaciones$ = "pr_7772a97wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_183f7cdcfax30awd"
      Public Shared HoraLocal$ = "pr_776aeb2wd"
      Public Shared ReferenciaDestinador$ = "pr_183f7b1776x219wd"
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
      Public Class HorariosListaC
          Public ReferenciaJornada As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public DiaDeLaSemana As Integer
          Public FechaAlta_UTC As Date
          Public Observaciones As String
          Public AutorDelAltaTieneAccesoWeb As Boolean
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
          Public RelacionElementoContenedorListador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Listadoreliminado As Boolean
          Sub new()
          End Sub
      End Class
      Public Class HorariosLista_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
          Public property ReferenciaJornada As Guid
            get
                return me.GetValue_Guid("pr_7772a91wd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_7772a91wd", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_183f7b1731x1d7wd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_183f7b1731x1d7wd", value)
            End Set
          End Property
          Public property DiaDeLaSemana As Integer
            get
                return me.GetValue_Integer("pr_7772a8fwd")
            End Get
            Set(value As Integer)
                me.SetValue_Integer("pr_7772a8fwd", value)
            End Set
          End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_183f7b1744x3dewd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_183f7b1744x3dewd", value)
            End Set
          End Property
          Public property Observaciones As String
            get
                return me.GetValue_String("pr_7772a97wd")
            End Get
            Set(value As String)
                me.SetValue_String("pr_7772a97wd", value)
            End Set
          End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_183f7cdcfax30awd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_183f7cdcfax30awd", value)
            End Set
          End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_776aeb2wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_183f7b1776x219wd")
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
