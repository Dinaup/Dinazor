Partial Public Class SeccionesD
  Public Class GruposDeUbicacionesBaseListaD
      Public Shared _SeccionID As String = "faaf6195-9730-4168-8930-79cbc532a796"
      Public Shared _SeccionIDGUID As New Guid("faaf6195-9730-4168-8930-79cbc532a796")
      Public Class GruposDeUbicacionesBaseListaES
          Public shared _SeccionID as Guid = New Guid("faaf6195-9730-4168-8930-79cbc532a796")
          Public shared _Tabla$ = "tpr_20040180171_e"
      Public Shared FechaAlta_UTC$ = "pr_200401801719"
      Public Shared ReferenciaDestinador$ = "pr_200401801720"
      Public Shared HoraLocal$ = "pr_200401801718"
      Public Shared ReferenciaAutorDelAlta$ = "pr_200401801716"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_200401801721"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_200401801722"
      Public Shared ReferenciaUbicacion$ = "pr_200401801729"
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
      Public Class GruposDeUbicacionesBaseListaC
          Public FechaAlta_UTC As Date
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public EmpleadoTieneAccesoWeb As Boolean
          Public ReferenciaUbicacion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
