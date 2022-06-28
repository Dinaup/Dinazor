Partial Public Class SeccionesD
  Public Class SCIntegridadDeRegistrosListaD
      Public Shared _SeccionID As String = "487d2cac-5415-4d44-bdd2-66f611ce6900"
      Public Shared _SeccionIDGUID As New Guid("487d2cac-5415-4d44-bdd2-66f611ce6900")
      Public Class SCIntegridadDeRegistrosListaES
          Public shared _SeccionID as Guid = New Guid("487d2cac-5415-4d44-bdd2-66f611ce6900")
          Public shared _Tabla$ = "tpr_71aeb47xd_e"
      Public Shared ReferenciaHistoricoValorLocal$ = "pr_71b17f9wd"
      Public Shared HistoricoServidorCentralFechaUTC_UTC$ = "pr_71b1805wd"
      Public Shared ReferenciaReferenciaServidorCentral$ = "pr_71b0471wd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_71aeb8bwd"
      Public Shared ReferenciaHistoricoValorServidorCentral$ = "pr_71b17fdwd"
      Public Shared ValorServidorCentral$ = "pr_71b17f5wd"
      Public Shared HistoricoServidorCentralCRC$ = "pr_71b180dwd"
      Public Shared Estado$ = "pr_71bdc5bwd"
      Public Shared ReferenciaRegistroID$ = "pr_71bef80wd"
      Public Shared FechaAlta_UTC$ = "pr_71aeb93wd"
      Public Shared FechaDato_UTC$ = "pr_71aeb8fwd"
      Public Shared Campo$ = "pr_71b17edwd"
      Public Shared HistoricoLocalFechaUTC_UTC$ = "pr_71b1801wd"
      Public Shared Detalles$ = "pr_724f7c7wd"
      Public Shared SeccionOTabla$ = "pr_71bef84wd"
      Public Shared HistoricoLocalCRC$ = "pr_71b1809wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_71aebabwd"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_71aeb87wd"
      Public Shared ValorLocal$ = "pr_71b17f1wd"
      Public Shared HoraLocal$ = "pr_776af38wd"
      Public Shared ReferenciaDestinador$ = "pr_71aeb9fwd"
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
      Public Class SCIntegridadDeRegistrosListaC
          Public ReferenciaHistoricoValorLocal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HistoricoServidorCentralFechaUTC_UTC As Date
          Public ReferenciaReferenciaServidorCentral As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaHistoricoValorServidorCentral As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ValorServidorCentral As String
          Public HistoricoServidorCentralCRC As String
          Public Estado As Integer
          Public ReferenciaRegistroID As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public FechaDato_UTC As Date
          Public Campo As String
          Public HistoricoLocalFechaUTC_UTC As Date
          Public Detalles As String
          Public SeccionOTabla As String
          Public HistoricoLocalCRC As String
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ValorLocal As String
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
      Public Class SCIntegridadDeRegistrosLista_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
        Public ReadOnly property ReferenciaHistoricoValorLocal As Guid
            get
                return me.GetValue_Guid("pr_71b17f9wd")
            End Get   
        End Property
        Public ReadOnly property HistoricoServidorCentralFechaUTC_UTC As Date
            get
                return me.GetValue_DateTime("pr_71b1805wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaReferenciaServidorCentral As Guid
            get
                return me.GetValue_Guid("pr_71b0471wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_71aeb8bwd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaHistoricoValorServidorCentral As Guid
            get
                return me.GetValue_Guid("pr_71b17fdwd")
            End Get   
        End Property
        Public ReadOnly property ValorServidorCentral As String
            get
                return me.GetValue_String("pr_71b17f5wd")
            End Get   
        End Property
        Public ReadOnly property HistoricoServidorCentralCRC As String
            get
                return me.GetValue_String("pr_71b180dwd")
            End Get   
        End Property
        Public ReadOnly property Estado As Integer
            get
                return me.GetValue_Integer("pr_71bdc5bwd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaRegistroID As Guid
            get
                return me.GetValue_Guid("pr_71bef80wd")
            End Get   
        End Property
        Public ReadOnly property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_71aeb93wd")
            End Get   
        End Property
        Public ReadOnly property FechaDato_UTC As Date
            get
                return me.GetValue_DateTime("pr_71aeb8fwd")
            End Get   
        End Property
        Public ReadOnly property Campo As String
            get
                return me.GetValue_String("pr_71b17edwd")
            End Get   
        End Property
        Public ReadOnly property HistoricoLocalFechaUTC_UTC As Date
            get
                return me.GetValue_DateTime("pr_71b1801wd")
            End Get   
        End Property
        Public ReadOnly property Detalles As String
            get
                return me.GetValue_String("pr_724f7c7wd")
            End Get   
        End Property
        Public ReadOnly property SeccionOTabla As String
            get
                return me.GetValue_String("pr_71bef84wd")
            End Get   
        End Property
        Public ReadOnly property HistoricoLocalCRC As String
            get
                return me.GetValue_String("pr_71b1809wd")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_71aebabwd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_71aebabwd", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaUbicacionPrincipal As Guid
            get
                return me.GetValue_Guid("pr_71aeb87wd")
            End Get   
        End Property
        Public ReadOnly property ValorLocal As String
            get
                return me.GetValue_String("pr_71b17f1wd")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_776af38wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_71aeb9fwd")
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
