Partial Public Class SeccionesD
  Public Class ConfiguracionDePermisosBaseD
      Public Shared _SeccionID As String = "2912705c-ce77-4f3f-a949-1a29378fe7f6"
      Public Shared _SeccionIDGUID As New Guid("2912705c-ce77-4f3f-a949-1a29378fe7f6")
      Public Class ConfiguracionDePermisosBaseES
          Public shared _SeccionID as Guid = New Guid("2912705c-ce77-4f3f-a949-1a29378fe7f6")
          Public shared _Tabla$ = "tpr_20040110491"
      Public Shared ExportarEnModulos$ = "pr_200401104915"
      Public Shared FechaAlta_UTC$ = "pr_200401104916"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_200401104924"
      Public Shared Observaciones$ = "pr_40040110532"
      Public Shared ReferenciaSeccionDeConfiguracion$ = "pr_40040110531"
      Public Shared Diseño$ = "pr_200401104925"
      Public Shared ReferenciaAutorDelAlta$ = "pr_200401104912"
      Public Shared IdentificadorDeConfiguracionSha1$ = "pr_60040110541"
      Public Shared HoraLocal$ = "pr_200401104914"
      Public Shared ReferenciaDestinador$ = "pr_200401104917"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_200401104921"
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
      Public Class ConfiguracionDePermisosBaseC
          Public FechaAlta_UTC As Date
          Public EmpleadoTieneAccesoWeb As Boolean
          Public Observaciones As String
          Public ReferenciaSeccionDeConfiguracion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Diseño As String
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public IdentificadorDeConfiguracionSha1 As String
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
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
