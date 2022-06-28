Partial Public Class SeccionesD
  Public Class EstadosDeChatsBaseD
      Public Shared _SeccionID As String = "2617349d-e47f-4e27-8bfa-59f40e3b4acb"
      Public Shared _SeccionIDGUID As New Guid("2617349d-e47f-4e27-8bfa-59f40e3b4acb")
      Public Class EstadosDeChatsBaseES
          Public shared _SeccionID as Guid = New Guid("2617349d-e47f-4e27-8bfa-59f40e3b4acb")
          Public shared _Tabla$ = "tpr_70b1ff3xd"
      Public Shared FechaAlta_UTC$ = "pr_70b203fwd"
      Public Shared ExportarEnModulos$ = "pr_70b2037wd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_70b204fwd"
      Public Shared ReferenciaParticipacionEmpleadoSecundario$ = "pr_70b22c9wd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_70b202fwd"
      Public Shared LeidoHasta_UTC$ = "pr_70b22d1wd"
      Public Shared ReferenciaEmpleadoSecundario$ = "pr_70b22c1wd"
      Public Shared ReferenciaSala$ = "pr_70b22ddwd"
      Public Shared RecibidoHasta_UTC$ = "pr_70b22d9wd"
      Public Shared HoraLocal$ = "pr_776af32wd"
      Public Shared ReferenciaDestinador$ = "pr_70b204bwd"
      Public Shared ReferenciaParticipacionDeEmpleado$ = "pr_70b22bdwd"
      Public Shared EmpleadoSecundarioTieneAccesoWeb$ = "pr_70b22c5wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_70b2057wd"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_70b2027wd"
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
      Public Class EstadosDeChatsBaseC
          Public FechaAlta_UTC As Date
          Public EmpleadoTieneAccesoWeb As Boolean
          Public ReferenciaParticipacionEmpleadoSecundario As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public LeidoHasta_UTC As Date
          Public ReferenciaEmpleadoSecundario As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaSala As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public RecibidoHasta_UTC As Date
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaParticipacionDeEmpleado As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public EmpleadoSecundarioTieneAccesoWeb As Boolean
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
