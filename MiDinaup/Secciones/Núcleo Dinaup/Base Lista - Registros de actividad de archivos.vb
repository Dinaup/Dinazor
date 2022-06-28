Partial Public Class SeccionesD
  Public Class RegistrosDeActividadDeArchivosBaseListaD
      Public Shared _SeccionID As String = "5cadb070-7692-4430-9569-a563f54eeb0a"
      Public Shared _SeccionIDGUID As New Guid("5cadb070-7692-4430-9569-a563f54eeb0a")
      Public Class RegistrosDeActividadDeArchivosBaseListaES
          Public shared _SeccionID as Guid = New Guid("5cadb070-7692-4430-9569-a563f54eeb0a")
          Public shared _Tabla$ = "tpr_76da49fxd_e"
      Public Shared ReferenciaAutorDelAlta$ = "pr_76da4b3wd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_76da4fbwd"
      Public Shared FechaDato_UTC$ = "pr_76da4b7wd"
      Public Shared FechaAlta_UTC$ = "pr_76da4bbwd"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_76da4abwd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_76da503wd"
      Public Shared HoraLocal$ = "pr_77611dcwd"
      Public Shared ReferenciaDestinador$ = "pr_76da4c7wd"
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
      Public Class RegistrosDeActividadDeArchivosBaseListaC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public EmpleadoTieneAccesoWeb As Boolean
          Public FechaDato_UTC As Date
          Public FechaAlta_UTC As Date
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
