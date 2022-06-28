Partial Public Class SeccionesD
  Public Class FuncionesJSONBaseD
      Public Shared _SeccionID As String = "bb0db802-2232-4cf0-ad11-36d68b4b0679"
      Public Shared _SeccionIDGUID As New Guid("bb0db802-2232-4cf0-ad11-36d68b4b0679")
      Public Class FuncionesJSONBaseES
          Public shared _SeccionID as Guid = New Guid("bb0db802-2232-4cf0-ad11-36d68b4b0679")
          Public shared _Tabla$ = "tpr_60040133853"
      Public Shared Bloquear$ = "pr_50040133895"
      Public Shared ReferenciaDestinador$ = "pr_600401338520"
      Public Shared FechaAlta_UTC$ = "pr_600401338519"
      Public Shared ReferenciaAutorDelAlta$ = "pr_600401338515"
      Public Shared ExportarEnModulos$ = "pr_600401338518"
      Public Shared HoraLocal$ = "pr_600401338517"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_600401338526"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_600401338527"
      Public Shared Configuracion$ = "pr_10040133862"
      Public Shared IdentificadorDeConfiguracionSha1$ = "pr_10040133864"
      Public Shared ReferenciaSeccionDelAPI$ = "pr_30040134241"
      Public Shared TipoDeAPI$ = "pr_30040134242"
      Public Shared InformacionAdicional$ = "pr_30040140483"
      Public Shared Categoria$ = "pr_50040140791"
      Public Shared FiltradoDeContenido$ = "pr_30040178441002"
      Public Shared ParametrosPersonalizados$ = "pr_60040373351"
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
      Public Class FuncionesJSONBaseC
          Public Bloquear As Boolean
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public EmpleadoTieneAccesoWeb As Boolean
          Public Configuracion As String
          Public IdentificadorDeConfiguracionSha1 As String
          Public ReferenciaSeccionDelAPI As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public TipoDeAPI As Integer
          Public InformacionAdicional As String
          Public Categoria As String
          Public FiltradoDeContenido As String
          Public ParametrosPersonalizados As String
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
  End Class
End Class
