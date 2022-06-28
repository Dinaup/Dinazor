Partial Public Class SeccionesD
  Public Class CriteriosDeNotificacionesBaseListaD
      Public Shared _SeccionID As String = "c5b69d42-9057-4719-9647-788dd6e60898"
      Public Shared _SeccionIDGUID As New Guid("c5b69d42-9057-4719-9647-788dd6e60898")
      Public Class CriteriosDeNotificacionesBaseListaES
          Public shared _SeccionID as Guid = New Guid("c5b69d42-9057-4719-9647-788dd6e60898")
          Public shared _Tabla$ = "tpr_733da88xd_e"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_733dae4wd"
      Public Shared HoraLocal$ = "pr_77611ccwd"
      Public Shared ReferenciaDestinador$ = "pr_733dad0wd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_733dabcwd"
      Public Shared FechaAlta_UTC$ = "pr_733dac4wd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_733daf0wd"
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
      Public Class CriteriosDeNotificacionesBaseListaC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public EmpleadoTieneAccesoWeb As Boolean
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
