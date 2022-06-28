Partial Public Class SeccionesD
  Public Class IntegridadDeRegistrosBaseD
      Public Shared _SeccionID As String = "dd10b9d7-771b-4957-93fb-aea098b2b13e"
      Public Shared _SeccionIDGUID As New Guid("dd10b9d7-771b-4957-93fb-aea098b2b13e")
      Public Class IntegridadDeRegistrosBaseES
          Public shared _SeccionID as Guid = New Guid("dd10b9d7-771b-4957-93fb-aea098b2b13e")
          Public shared _Tabla$ = "tpr_71aeb47xd"
      Public Shared ReferenciaRegistroID$ = "pr_71bcd28wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_71aeba7wd"
      Public Shared Detalles$ = "pr_724f415wd"
      Public Shared HoraLocal$ = "pr_776ae76wd"
      Public Shared ReferenciaDestinador$ = "pr_71aeb6fwd"
      Public Shared MarcadorFechaSynMaximaSRVUTC_UTC$ = "pr_724f411wd"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_71aeb4fwd"
      Public Shared ReferenciaReferenciaUbicacionServidorCentralObsoleto$ = "pr_71af6f1wd"
      Public Shared TablaOSeccion$ = "pr_71af6f5wd"
      Public Shared FechaReparacionUTC_UTC$ = "pr_71b0451wd"
      Public Shared Estado$ = "pr_71b0449wd"
      Public Shared CRCServidorCentral$ = "pr_71b0441wd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_71aeb53wd"
      Public Shared MarcadorFechaMaxima_UTC$ = "pr_724e037wd"
      Public Shared FechaResincronizacion_UTC$ = "pr_71b044dwd"
      Public Shared CRCServidorLocal$ = "pr_71b0445wd"
      Public Shared MarcadorFechaSynMaximaSCUTC_UTC$ = "pr_724f40dwd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_71aebafwd"
      Public Shared FechaDato_UTC$ = "pr_71aeb57wd"
      Public Shared ExportarEnModulos$ = "pr_71aeb5bwd"
      Public Shared FechaAlta_UTC$ = "pr_71aeb63wd"
      Public Shared ReferenciaServidorSRV$ = "pr_10040212261"
      Public Shared ReferenciaServidorSC$ = "pr_10040212262"
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
      Public Class IntegridadDeRegistrosBaseC
          Public ReferenciaRegistroID As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public Detalles As String
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public MarcadorFechaSynMaximaSRVUTC_UTC As Date
          Public ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaReferenciaUbicacionServidorCentralObsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public TablaOSeccion As String
          Public FechaReparacionUTC_UTC As Date
          Public Estado As Integer
          Public CRCServidorCentral As String
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public MarcadorFechaMaxima_UTC As Date
          Public FechaResincronizacion_UTC As Date
          Public CRCServidorLocal As String
          Public MarcadorFechaSynMaximaSCUTC_UTC As Date
          Public EmpleadoTieneAccesoWeb As Boolean
          Public FechaDato_UTC As Date
          Public FechaAlta_UTC As Date
          Public ReferenciaServidorSRV As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaServidorSC As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
