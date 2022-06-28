Partial Public Class SeccionesD
  Public Class CronometrajesInternosBaseD
      Public Shared _SeccionID As String = "064fdda8-a65d-4b9f-a7e4-0dfe8a3d1994"
      Public Shared _SeccionIDGUID As New Guid("064fdda8-a65d-4b9f-a7e4-0dfe8a3d1994")
      Public Class CronometrajesInternosBaseES
          Public shared _SeccionID as Guid = New Guid("064fdda8-a65d-4b9f-a7e4-0dfe8a3d1994")
          Public shared _Tabla$ = "tpr_30040429686"
      Public Shared ReferenciaDestinador$ = "pr_300404296826"
      Public Shared FechaAlta_UTC$ = "pr_300404296825"
      Public Shared ExportarEnModulos$ = "pr_300404296824"
      Public Shared HoraLocal$ = "pr_300404296823"
      Public Shared ReferenciaAutorDelAlta$ = "pr_300404296821"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_300404296837"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_300404296838"
      Public Shared ReferenciaSeccionDeDatoCronometrado$ = "pr_40040429681"
      Public Shared ReferenciaServidor$ = "pr_40040429682"
      Public Shared ReferenciaCampo$ = "pr_40040429683"
      Public Shared InicioCronometro_UTC$ = "pr_40040429685"
      Public Shared ReferenciaRegistroCronometrado$ = "pr_40040429684"
      Public Shared FinCronometro_UTC$ = "pr_40040429686"
      Public Shared MinutosCronometrados$ = "pr_40040429688"
      Public Shared Finalizado$ = "pr_400404296810"
      Public Shared NombreDeRegistroCronometrado$ = "pr_40040429689"
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
      Public Class CronometrajesInternosBaseC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public HoraLocal As Integer
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public EmpleadoTieneAccesoWeb As Boolean
          Public ReferenciaSeccionDeDatoCronometrado As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaServidor As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaCampo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public InicioCronometro_UTC As Date
          Public ReferenciaRegistroCronometrado As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FinCronometro_UTC As Date
          Public MinutosCronometrados As Decimal
          Public Finalizado As Boolean
          Public NombreDeRegistroCronometrado As String
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
