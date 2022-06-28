Partial Public Class SeccionesD
  Public Class RegistrosDeAccesoASistemaBaseListaD
      Public Shared _SeccionID As String = "e470ac1d-4903-4e65-b9d8-f4742d57221d"
      Public Shared _SeccionIDGUID As New Guid("e470ac1d-4903-4e65-b9d8-f4742d57221d")
      Public Class RegistrosDeAccesoASistemaBaseListaES
          Public shared _SeccionID as Guid = New Guid("e470ac1d-4903-4e65-b9d8-f4742d57221d")
          Public shared _Tabla$ = "tpr_3fff25bwc_e"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_1464b423f2x2f2wd"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_1464b4241ex136wd"
      Public Shared FechaDato_UTC$ = "pr_14631068c0xdbwd"
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
      Public Class RegistrosDeAccesoASistemaBaseListaC
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
