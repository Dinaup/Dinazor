Partial Public Class SeccionesD
  Public Class GruposDeUbicacionesBaseD
      Public Shared _SeccionID As String = "4adc7b5d-2e38-43aa-b416-8b7486536490"
      Public Shared _SeccionIDGUID As New Guid("4adc7b5d-2e38-43aa-b416-8b7486536490")
      Public Class GruposDeUbicacionesBaseES
          Public shared _SeccionID as Guid = New Guid("4adc7b5d-2e38-43aa-b416-8b7486536490")
          Public shared _Tabla$ = "tpr_20040180171"
      Public Shared ReferenciaDestinador$ = "pr_200401801712"
      Public Shared FechaAlta_UTC$ = "pr_200401801711"
      Public Shared HoraLocal$ = "pr_20040180179"
      Public Shared ReferenciaAutorDelAlta$ = "pr_20040180177"
      Public Shared ExportarEnModulos$ = "pr_200401801710"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_200401801723"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_200401801724"
      Public Shared Observaciones$ = "pr_200401801726"
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
      Public Class GruposDeUbicacionesBaseC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public HoraLocal As Integer
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public EmpleadoTieneAccesoWeb As Boolean
          Public Observaciones As String
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
