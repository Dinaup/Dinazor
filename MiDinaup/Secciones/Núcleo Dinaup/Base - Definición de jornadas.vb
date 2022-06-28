Partial Public Class SeccionesD
  Public Class DefinicionDeJornadasBaseD
      Public Shared _SeccionID As String = "1b77c8fd-5ac4-4cf7-af16-dba29a1c2182"
      Public Shared _SeccionIDGUID As New Guid("1b77c8fd-5ac4-4cf7-af16-dba29a1c2182")
      Public Class DefinicionDeJornadasBaseES
          Public shared _SeccionID as Guid = New Guid("1b77c8fd-5ac4-4cf7-af16-dba29a1c2182")
          Public shared _Tabla$ = "tpr_7756c5exd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_7756cbawd"
      Public Shared FechaAlta_UTC$ = "pr_7756caawd"
      Public Shared ExportarEnModulos$ = "pr_7756ca2wd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_7756c9awd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_7756cc2wd"
      Public Shared ReferenciaDestinador$ = "pr_7756cb6wd"
      Public Shared HoraLocal$ = "pr_7761200wd"
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
      End Class
      Public Class DefinicionDeJornadasBaseC
          Public EmpleadoTieneAccesoWeb As Boolean
          Public FechaAlta_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
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
          Sub new()
          End Sub
      End Class
  End Class
End Class
