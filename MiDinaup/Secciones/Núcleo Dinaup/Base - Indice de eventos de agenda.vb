Partial Public Class SeccionesD
  Public Class IndiceDeEventosDeAgendaBaseD
      Public Shared _SeccionID As String = "6b2f0caa-b5d2-42c5-917f-77ef9b68e2fa"
      Public Shared _SeccionIDGUID As New Guid("6b2f0caa-b5d2-42c5-917f-77ef9b68e2fa")
      Public Class IndiceDeEventosDeAgendaBaseES
          Public shared _SeccionID as Guid = New Guid("6b2f0caa-b5d2-42c5-917f-77ef9b68e2fa")
          Public shared _Tabla$ = "tpr_7795877xd"
      Public Shared ReferenciaAgendaSeccion$ = "pr_779868bwd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_7795893wd"
      Public Shared ReferenciaAgendaRelacion$ = "pr_7798693wd"
      Public Shared Desde_UTC$ = "pr_7bcb62bwd"
      Public Shared FechaAlta_UTC$ = "pr_779589dwd"
      Public Shared ExportarEnModulos$ = "pr_7795899wd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_77958abwd"
      Public Shared ReferenciaEventoRelacion$ = "pr_779868fwd"
      Public Shared Hasta_UTC$ = "pr_7bcb62dwd"
      Public Shared ReferenciaEventoSeccion$ = "pr_7798689wd"
      Public Shared Ocupa$ = "pr_7798691wd"
      Public Shared ReferenciaDestinador$ = "pr_77958a3wd"
      Public Shared HoraLocal$ = "pr_7795897wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_77958afwd"
      Public Shared EventoNombre$ = "pr_60040147211"
      Public Shared AgendaNombre$ = "pr_60040147212"
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
      Public Class IndiceDeEventosDeAgendaBaseC
          Public ReferenciaAgendaSeccion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaAgendaRelacion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Desde_UTC As Date
          Public FechaAlta_UTC As Date
          Public EmpleadoTieneAccesoWeb As Boolean
          Public ReferenciaEventoRelacion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Hasta_UTC As Date
          Public ReferenciaEventoSeccion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Ocupa As Boolean
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public EventoNombre As String
          Public AgendaNombre As String
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
