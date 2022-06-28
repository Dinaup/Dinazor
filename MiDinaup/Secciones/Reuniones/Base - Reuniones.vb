Partial Public Class SeccionesD
  Public Class ReunionesBaseD
      Public Shared _SeccionID As String = "866f8680-19c4-432e-bad2-75a987cd41af"
      Public Shared _SeccionIDGUID As New Guid("866f8680-19c4-432e-bad2-75a987cd41af")
      Public Class ReunionesBaseES
          Public shared _SeccionID as Guid = New Guid("866f8680-19c4-432e-bad2-75a987cd41af")
          Public shared _Tabla$ = "tpr_7c1098axd"
      Public Shared FechaAlta_UTC$ = "pr_7c109a0wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_7c109c4wd"
      Public Shared HoraLocal$ = "pr_7c10998wd"
      Public Shared ReferenciaDestinador$ = "pr_7c109a6wd"
      Public Shared ReunionHasta_UTC$ = "pr_7c11361wd"
      Public Shared ExportarEnModulos$ = "pr_7c1099awd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_7c109c0wd"
      Public Shared MostrarEnAgenda$ = "pr_7c11363wd"
      Public Shared ReunionDesde_UTC$ = "pr_7c1135fwd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_7c10994wd"
      Public Shared ReferenciaPuntosATratar$ = "pr_10040147532"
      Public Shared ReunionCancelada$ = "pr_20040147531"
      Public Shared Conclusiones$ = "pr_60040404251"
      Public Shared Detalles$ = "pr_50040404252"
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
      Public Class ReunionesBaseC
          Public FechaAlta_UTC As Date
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReunionHasta_UTC As Date
          Public EmpleadoTieneAccesoWeb As Boolean
          Public MostrarEnAgenda As Boolean
          Public ReunionDesde_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaPuntosATratar As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReunionCancelada As Boolean
          Public Conclusiones As String
          Public Detalles As String
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
