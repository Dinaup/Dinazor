Partial Public Class SeccionesD
  Public Class EnviosProgramadosDeCorreosBaseListaD
      Public Shared _SeccionID As String = "4104e44c-411e-40dc-bef2-49e6c53685a4"
      Public Shared _SeccionIDGUID As New Guid("4104e44c-411e-40dc-bef2-49e6c53685a4")
      Public Class EnviosProgramadosDeCorreosBaseListaES
          Public shared _SeccionID as Guid = New Guid("4104e44c-411e-40dc-bef2-49e6c53685a4")
          Public shared _Tabla$ = "tpr_30040163371002_e"
      Public Shared HoraLocal$ = "pr_30040163371042"
      Public Shared FechaAlta_UTC$ = "pr_30040163371043"
      Public Shared ReferenciaAutorDelAlta$ = "pr_30040163371040"
      Public Shared FechaDato_UTC$ = "pr_30040163371041"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_30040163371039"
      Public Shared ReferenciaDestinador$ = "pr_30040163371044"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_30040163371038"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_30040163371045"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_30040163371046"
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
      Public Class EnviosProgramadosDeCorreosBaseListaC
          Public HoraLocal As Integer
          Public FechaAlta_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaDato_UTC As Date
          Public ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
