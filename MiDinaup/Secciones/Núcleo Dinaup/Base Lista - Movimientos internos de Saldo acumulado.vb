Partial Public Class SeccionesD
  Public Class MovimientosInternosDeSaldoAcumuladoBaseListaD
      Public Shared _SeccionID As String = "f8cfe4e7-832b-4bd6-9378-e98249457563"
      Public Shared _SeccionIDGUID As New Guid("f8cfe4e7-832b-4bd6-9378-e98249457563")
      Public Class MovimientosInternosDeSaldoAcumuladoBaseListaES
          Public shared _SeccionID as Guid = New Guid("f8cfe4e7-832b-4bd6-9378-e98249457563")
          Public shared _Tabla$ = "tpr_5ec7d37xd_e"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_191d8f4932x39awd"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_191d8f4968xbdwd"
      Public Shared FechaDato_UTC$ = "pr_17244ba8eex4dwd"
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
      Public Class MovimientosInternosDeSaldoAcumuladoBaseListaC
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaDato_UTC As Date
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
