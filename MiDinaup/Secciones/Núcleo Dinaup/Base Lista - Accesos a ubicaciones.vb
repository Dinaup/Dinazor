Partial Public Class SeccionesD
  Public Class AccesosAUbicacionesBaseListaD
      Public Shared _SeccionID As String = "bb4dfb45-89b0-4b42-8e68-882477f4189c"
      Public Shared _SeccionIDGUID As New Guid("bb4dfb45-89b0-4b42-8e68-882477f4189c")
      Public Class AccesosAUbicacionesBaseListaES
          Public shared _SeccionID as Guid = New Guid("bb4dfb45-89b0-4b42-8e68-882477f4189c")
          Public shared _Tabla$ = "tpr_30040480302_e"
      Public Shared ReferenciaDestinador$ = "pr_30040480301022"
      Public Shared FechaAlta_UTC$ = "pr_30040480301021"
      Public Shared ReferenciaAutorDelAlta$ = "pr_30040480301018"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_30040480301016"
      Public Shared FechaDato_UTC$ = "pr_30040480301019"
      Public Shared HoraLocal$ = "pr_30040480301020"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_30040480301017"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_30040480301023"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_30040480301024"
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
      Public Class AccesosAUbicacionesBaseListaC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaDato_UTC As Date
          Public HoraLocal As Integer
          Public ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
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
