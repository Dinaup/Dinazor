Partial Public Class SeccionesD
  Public Class TareasBaseListaD
      Public Shared _SeccionID As String = "c7c9a0c5-36ba-466c-b523-61c3cc893c23"
      Public Shared _SeccionIDGUID As New Guid("c7c9a0c5-36ba-466c-b523-61c3cc893c23")
      Public Class TareasBaseListaES
          Public shared _SeccionID as Guid = New Guid("c7c9a0c5-36ba-466c-b523-61c3cc893c23")
          Public shared _Tabla$ = "tpr_7735f41xd_e"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_7735f6dwd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_7735f9dwd"
      Public Shared HoraLocal$ = "pr_77611c8wd"
      Public Shared ReferenciaDestinador$ = "pr_7735f89wd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_7735f75wd"
      Public Shared FechaAlta_UTC$ = "pr_7735f7dwd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_7735fa9wd"
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
      Public Class TareasBaseListaC
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
