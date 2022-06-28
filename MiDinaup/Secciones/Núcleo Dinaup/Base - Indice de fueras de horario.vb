Partial Public Class SeccionesD
  Public Class IndiceDeFuerasDeHorarioBaseD
      Public Shared _SeccionID As String = "32927f63-7cea-4ff7-9580-5531601b7f2a"
      Public Shared _SeccionIDGUID As New Guid("32927f63-7cea-4ff7-9580-5531601b7f2a")
      Public Class IndiceDeFuerasDeHorarioBaseES
          Public shared _SeccionID as Guid = New Guid("32927f63-7cea-4ff7-9580-5531601b7f2a")
          Public shared _Tabla$ = "tpr_7b8b167xd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_7b8b1a1wd"
      Public Shared ReferenciaHorario$ = "pr_7b8d9d3wd"
      Public Shared FechaAlta_UTC$ = "pr_7b8b179wd"
      Public Shared ExportarEnModulos$ = "pr_7b8b173wd"
      Public Shared ReferenciaAgendaSeccion$ = "pr_7b8d9cbwd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_7b8b16dwd"
      Public Shared FechaHasta_UTC$ = "pr_7b8d9d1wd"
      Public Shared ReferenciaDestinador$ = "pr_7b8b17fwd"
      Public Shared HoraLocal$ = "pr_7b8b171wd"
      Public Shared FechaDesde_UTC$ = "pr_7b8d9cfwd"
      Public Shared ReferenciaAgendaRelacion$ = "pr_7b8d9cdwd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_7b8b19dwd"
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
      Public Class IndiceDeFuerasDeHorarioBaseC
          Public EmpleadoTieneAccesoWeb As Boolean
          Public ReferenciaHorario As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public ReferenciaAgendaSeccion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaHasta_UTC As Date
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public FechaDesde_UTC As Date
          Public ReferenciaAgendaRelacion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
          Sub new()
          End Sub
      End Class
  End Class
End Class
