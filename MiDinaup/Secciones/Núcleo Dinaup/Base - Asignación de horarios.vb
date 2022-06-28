Partial Public Class SeccionesD
  Public Class AsignacionDeHorariosBaseD
      Public Shared _SeccionID As String = "642091f3-9857-4f52-9a8b-939f358f013d"
      Public Shared _SeccionIDGUID As New Guid("642091f3-9857-4f52-9a8b-939f358f013d")
      Public Class AsignacionDeHorariosBaseES
          Public shared _SeccionID as Guid = New Guid("642091f3-9857-4f52-9a8b-939f358f013d")
          Public shared _Tabla$ = "tpr_20040102881"
      Public Shared ReferenciaAgenda$ = "pr_30040102891"
      Public Shared ReferenciaAutorDelAlta$ = "pr_20040102885"
      Public Shared HorarioActivoDesde$ = "pr_20040103103"
      Public Shared HorarioActivoHasta$ = "pr_20040103102"
      Public Shared ExportarEnModulos$ = "pr_20040102888"
      Public Shared FechaAlta_UTC$ = "pr_200401028811"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_200401028828"
      Public Shared Vigente$ = "pr_30040103101"
      Public Shared ReferenciaAgendaSeccion$ = "pr_40040102891"
      Public Shared Observaciones$ = "pr_60040103331"
      Public Shared HoraLocal$ = "pr_20040102887"
      Public Shared ReferenciaDestinador$ = "pr_200401028814"
      Public Shared ReferenciaHorario$ = "pr_20040103101"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_200401028826"
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
      Public Class AsignacionDeHorariosBaseC
          Public ReferenciaAgenda As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HorarioActivoDesde As Date
          Public HorarioActivoHasta As Date
          Public FechaAlta_UTC As Date
          Public EmpleadoTieneAccesoWeb As Boolean
          Public Vigente As Boolean
          Public ReferenciaAgendaSeccion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Observaciones As String
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaHorario As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
