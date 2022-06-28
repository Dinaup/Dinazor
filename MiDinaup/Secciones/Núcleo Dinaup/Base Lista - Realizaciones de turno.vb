Partial Public Class SeccionesD
  Public Class RealizacionesDeTurnoBaseListaD
      Public Shared _SeccionID As String = "c2b019f7-ab5b-4d0e-a579-9adbbc19b87e"
      Public Shared _SeccionIDGUID As New Guid("c2b019f7-ab5b-4d0e-a579-9adbbc19b87e")
      Public Class RealizacionesDeTurnoBaseListaES
          Public shared _SeccionID as Guid = New Guid("c2b019f7-ab5b-4d0e-a579-9adbbc19b87e")
          Public shared _Tabla$ = "tpr_63e63f9xd_e"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_1863ce9b8bx2a9wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_1863c09ab7x1e1wd"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_1863ce9ba5x2d2wd"
      Public Shared ReferenciaDestinador$ = "pr_1863b69b41x1dcwd"
      Public Shared HoraLocal$ = "pr_776aedcwd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_1863b69b0ax1a7wd"
      Public Shared FechaAlta_UTC$ = "pr_1863b69b1dx1bawd"
      Public Shared FechaDato_UTC$ = "pr_1863ce9bbcx2e7wd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_1863cec60fx1bewd"
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
      Public Class RealizacionesDeTurnoBaseListaC
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public FechaDato_UTC As Date
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
