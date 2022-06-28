Partial Public Class SeccionesD
  Public Class PuntosATratarEnReunionesBaseD
      Public Shared _SeccionID As String = "8ca92524-2f3f-4815-a721-d33aea53ad55"
      Public Shared _SeccionIDGUID As New Guid("8ca92524-2f3f-4815-a721-d33aea53ad55")
      Public Class PuntosATratarEnReunionesBaseES
          Public shared _SeccionID as Guid = New Guid("8ca92524-2f3f-4815-a721-d33aea53ad55")
          Public shared _Tabla$ = "tpr_50040147511"
      Public Shared HoraLocal$ = "pr_50040147519"
      Public Shared ReferenciaAutorDelAlta$ = "pr_50040147517"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_500401475121"
      Public Shared ReferenciaDestinador$ = "pr_500401475112"
      Public Shared FechaAlta_UTC$ = "pr_500401475111"
      Public Shared ExportarEnModulos$ = "pr_500401475110"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_500401475122"
      Public Shared ReferenciaReunion$ = "pr_400404051910"
      Public Shared CantidadDePuntos$ = "pr_100404088424"
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
      Public Class PuntosATratarEnReunionesBaseC
          Public HoraLocal As Integer
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public EmpleadoTieneAccesoWeb As Boolean
          Public ReferenciaReunion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public CantidadDePuntos As Integer
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
