Partial Public Class SeccionesD
  Public Class EntidadesBaseListaD
      Public Shared _SeccionID As String = "a60839d4-9864-4f39-8b20-5fb4b78d9921"
      Public Shared _SeccionIDGUID As New Guid("a60839d4-9864-4f39-8b20-5fb4b78d9921")
      Public Class EntidadesBaseListaES
          Public shared _SeccionID as Guid = New Guid("a60839d4-9864-4f39-8b20-5fb4b78d9921")
          Public shared _Tabla$ = "tpr_2c597b_e"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_1464b3ff1bg93wd"
      Public Shared HoraLocal$ = "pr_776aef4wd"
      Public Shared ReferenciaDestinador$ = "pr_14630fe220x2f5wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_1463148f21h143wd"
      Public Shared FechaAlta_UTC$ = "pr_14c9f3d98cx89wd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_1464b5917eg289wd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_14630fe154g203wd"
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
      Public Class EntidadesBaseListaC
          Public ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public FechaAlta_UTC As Date
          Public EmpleadoTieneAccesoWeb As Boolean
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
