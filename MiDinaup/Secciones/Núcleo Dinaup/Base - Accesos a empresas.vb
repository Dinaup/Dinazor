Partial Public Class SeccionesD
  Public Class AccesosAEmpresasBaseD
      Public Shared _SeccionID As String = "448b2757-8bf8-4010-880b-f0b5db96c240"
      Public Shared _SeccionIDGUID As New Guid("448b2757-8bf8-4010-880b-f0b5db96c240")
      Public Class AccesosAEmpresasBaseES
          Public shared _SeccionID as Guid = New Guid("448b2757-8bf8-4010-880b-f0b5db96c240")
          Public shared _Tabla$ = "tpr_50040291741"
      Public Shared ReferenciaDestinador$ = "pr_500402917412"
      Public Shared FechaAlta_UTC$ = "pr_500402917411"
      Public Shared HoraLocal$ = "pr_50040291749"
      Public Shared ReferenciaAutorDelAlta$ = "pr_50040291747"
      Public Shared ExportarEnModulos$ = "pr_500402917410"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_50040291745"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_500402917423"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_500402917424"
      Public Shared AccesoHasta_UTC$ = "pr_600402917426"
      Public Shared AccesoDesde_UTC$ = "pr_600402917427"
      Public Shared AccesoVigente$ = "pr_10040291752"
      Public Shared ReferenciaEmpresaAcceso$ = "pr_30040291901"
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
      Public Class AccesosAEmpresasBaseC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public HoraLocal As Integer
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public EmpleadoTieneAccesoWeb As Boolean
          Public AccesoHasta_UTC As Date
          Public AccesoDesde_UTC As Date
          Public AccesoVigente As Boolean
          Public ReferenciaEmpresaAcceso As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
