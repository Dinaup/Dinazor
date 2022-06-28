Partial Public Class SeccionesD
  Public Class ServidoresBaseD
      Public Shared _SeccionID As String = "eadd8f25-d9e0-46ef-89a7-e95efe769df1"
      Public Shared _SeccionIDGUID As New Guid("eadd8f25-d9e0-46ef-89a7-e95efe769df1")
      Public Class ServidoresBaseES
          Public shared _SeccionID as Guid = New Guid("eadd8f25-d9e0-46ef-89a7-e95efe769df1")
          Public shared _Tabla$ = "tpr_10040209432"
      Public Shared ReferenciaDestinador$ = "pr_100402094322"
      Public Shared ReferenciaAutorDelAlta$ = "pr_100402094317"
      Public Shared FechaAlta_UTC$ = "pr_100402094321"
      Public Shared ExportarEnModulos$ = "pr_100402094320"
      Public Shared HoraLocal$ = "pr_100402094319"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_100402094333"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_100402094334"
      Public Shared FechaDeCreacion_UTC$ = "pr_60040209431"
      Public Shared Serie$ = "pr_60040209433"
      Public Shared Guid4$ = "pr_10040209441"
      Public Shared Guid1$ = "pr_10040209443"
      Public Shared Guid2$ = "pr_10040209444"
      Public Shared EsServidorCentral$ = "pr_10040209445"
      Public Shared ReferenciaServidorSC$ = "pr_10040209446"
      Public Shared Guid3$ = "pr_10040209442"
      Public Shared FechaReferenciaEnvioSC_UTC$ = "pr_10040209447"
      Public Shared FechaSISC_UTC$ = "pr_10040209449"
      Public Shared FechaReferenciaRecepcionSC_UTC$ = "pr_10040209448"
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
      Public Class ServidoresBaseC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public EmpleadoTieneAccesoWeb As Boolean
          Public FechaDeCreacion_UTC As Date
          Public Serie As String
          Public Guid4 As String
          Public Guid1 As String
          Public Guid2 As String
          Public EsServidorCentral As Boolean
          Public ReferenciaServidorSC As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Guid3 As String
          Public FechaReferenciaEnvioSC_UTC As Date
          Public FechaSISC_UTC As Date
          Public FechaReferenciaRecepcionSC_UTC As Date
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
