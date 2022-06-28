Partial Public Class SeccionesD
  Public Class ControlDePresenciaBaseListaD
      Public Shared _SeccionID As String = "65e878e5-a0ba-4ba9-bccb-d7929d3d51f5"
      Public Shared _SeccionIDGUID As New Guid("65e878e5-a0ba-4ba9-bccb-d7929d3d51f5")
      Public Class ControlDePresenciaBaseListaES
          Public shared _SeccionID as Guid = New Guid("65e878e5-a0ba-4ba9-bccb-d7929d3d51f5")
          Public shared _Tabla$ = "tpr_63535efxd_e"
      Public Shared FechaDato_UTC$ = "pr_183fea36a2x320wd"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_183fea3676x102wd"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_183fea3696x120wd"
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
      Public Class ControlDePresenciaBaseListaC
          Public FechaDato_UTC As Date
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
