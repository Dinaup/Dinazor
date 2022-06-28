Partial Public Class SeccionesD
  Public Class ReunionesBaseListaD
      Public Shared _SeccionID As String = "ee9f0da4-641a-4157-a65f-3d06c6202d7c"
      Public Shared _SeccionIDGUID As New Guid("ee9f0da4-641a-4157-a65f-3d06c6202d7c")
      Public Class ReunionesBaseListaES
          Public shared _SeccionID as Guid = New Guid("ee9f0da4-641a-4157-a65f-3d06c6202d7c")
          Public shared _Tabla$ = "tpr_7c1098axd_e"
      Public Shared ReferenciaAsistente$ = "pr_7c11365wd"
      Public Shared HoraLocal$ = "pr_7c109b4wd"
      Public Shared ReferenciaDestinador$ = "pr_7c109bcwd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_7c109c2wd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_7c109b0wd"
      Public Shared FechaAlta_UTC$ = "pr_7c109b6wd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_7c109bewd"
      Public Shared AsistenteTieneAccesoWeb$ = "pr_7c11367wd"
      Public Shared HaLlegadoTardeObsoleto$ = "pr_30040147532"
      Public Shared HaAportadoIdeas$ = "pr_30040147533"
      Public Shared Ponente$ = "pr_30040147534"
      Public Shared AusenciaObsoleto$ = "pr_30040147531"
      Public Shared AnotacionesSobreLaAsistencia$ = "pr_40040147531"
      Public Shared Asistencia$ = "pr_60040404262"
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
      Public Class ReunionesBaseListaC
          Public ReferenciaAsistente As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public EmpleadoTieneAccesoWeb As Boolean
          Public AsistenteTieneAccesoWeb As Boolean
          Public HaLlegadoTardeObsoleto As Boolean
          Public HaAportadoIdeas As Boolean
          Public Ponente As Boolean
          Public AusenciaObsoleto As Boolean
          Public AnotacionesSobreLaAsistencia As String
          Public Asistencia As Integer
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
  End Class
End Class
