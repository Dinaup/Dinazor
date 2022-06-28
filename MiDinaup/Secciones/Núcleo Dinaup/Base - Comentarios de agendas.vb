Partial Public Class SeccionesD
  Public Class ComentariosDeAgendasBaseD
      Public Shared _SeccionID As String = "38ddb432-cdf2-45aa-beef-2aa76584af62"
      Public Shared _SeccionIDGUID As New Guid("38ddb432-cdf2-45aa-beef-2aa76584af62")
      Public Class ComentariosDeAgendasBaseES
          Public shared _SeccionID as Guid = New Guid("38ddb432-cdf2-45aa-beef-2aa76584af62")
          Public shared _Tabla$ = "tpr_7ccd47fxd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_7ccd4b9wd"
      Public Shared FechaAlta_UTC$ = "pr_7ccd495wd"
      Public Shared ExportarEnModulos$ = "pr_7ccd48fwd"
      Public Shared ReferenciaAgendaSeccion$ = "pr_7ccd94cwd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_7ccd489wd"
      Public Shared ReferenciaDestinador$ = "pr_7ccd49bwd"
      Public Shared HoraLocal$ = "pr_7ccd48dwd"
      Public Shared Comentario$ = "pr_7ccd94ewd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_7ccd4b5wd"
      Public Shared ReferenciaAgenda$ = "pr_7ccd94awd"
      Public Shared ComentarioSecundario$ = "pr_7ccfc9fwd"
      Public Shared FechaDeComentario$ = "pr_7cce650wd"
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
      Public Class ComentariosDeAgendasBaseC
          Public EmpleadoTieneAccesoWeb As Boolean
          Public FechaAlta_UTC As Date
          Public ReferenciaAgendaSeccion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public Comentario As String
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaAgenda As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ComentarioSecundario As String
          Public FechaDeComentario As Date
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
