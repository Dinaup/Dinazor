Partial Public Class SeccionesD
  Public Class TiposDeRegistrosBaseD
      Public Shared _SeccionID As String = "624c7113-dc7f-4692-873a-b93b39445931"
      Public Shared _SeccionIDGUID As New Guid("624c7113-dc7f-4692-873a-b93b39445931")
      Public Class TiposDeRegistrosBaseES
          Public shared _SeccionID as Guid = New Guid("624c7113-dc7f-4692-873a-b93b39445931")
          Public shared _Tabla$ = "tpr_50010427301"
      Public Shared ReferenciaDestinador$ = "pr_500104273014"
      Public Shared FechaAlta_UTC$ = "pr_500104273013"
      Public Shared ReferenciaAutorDelAlta$ = "pr_50010427309"
      Public Shared HoraLocal$ = "pr_500104273011"
      Public Shared ExportarEnModulos$ = "pr_500104273012"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_500104273025"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_500104273026"
      Public Shared Descripcion$ = "pr_500104273028"
      Public Shared ReferenciaIcono$ = "pr_500104273029"
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
      Public Class TiposDeRegistrosBaseC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public EmpleadoTieneAccesoWeb As Boolean
          Public Descripcion As String
          Public ReferenciaIcono As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
