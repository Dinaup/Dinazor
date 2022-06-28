Partial Public Class SeccionesD
  Public Class EnviosProgramadosDeCorreosBaseD
      Public Shared _SeccionID As String = "44a58422-5df9-41a2-8af3-80675d611384"
      Public Shared _SeccionIDGUID As New Guid("44a58422-5df9-41a2-8af3-80675d611384")
      Public Class EnviosProgramadosDeCorreosBaseES
          Public shared _SeccionID as Guid = New Guid("44a58422-5df9-41a2-8af3-80675d611384")
          Public shared _Tabla$ = "tpr_30040163371002"
      Public Shared ReferenciaDestinador$ = "pr_30040163371036"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_30040163371029"
      Public Shared ReferenciaAutorDelAlta$ = "pr_30040163371031"
      Public Shared FechaAlta_UTC$ = "pr_30040163371035"
      Public Shared ExportarEnModulos$ = "pr_30040163371034"
      Public Shared HoraLocal$ = "pr_30040163371033"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_30040163371030"
      Public Shared FechaDato_UTC$ = "pr_30040163371032"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_30040163371047"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_30040163371048"
      Public Shared Asunto$ = "pr_30040163371049"
      Public Shared CorreoDeOrigen$ = "pr_30040163371051"
      Public Shared CorreoDestino$ = "pr_30040163371052"
      Public Shared ReferenciaInformeDeOrigen$ = "pr_30040163371053"
      Public Shared ReferenciaPlantillaDeCorreo$ = "pr_30040163371054"
      Public Shared ReintentosDeEnvio$ = "pr_40040163371"
      Public Shared ErrorDeEnvio$ = "pr_40040163372"
      Public Shared ReferenciaSeccionDeOrigen$ = "pr_40040163373"
      Public Shared ReferenciaRegistroDeOrigen$ = "pr_40040163374"
      Public Shared ReferenciaConfiguracionDeCorreoDeOrigen$ = "pr_20040164243"
      Public Shared EstadoDeEnvio$ = "pr_20040164244"
      Public Shared FechaDeUltimoIntentoFallido_UTC$ = "pr_30040164241"
      Public Shared FechaDeEnvio_UTC$ = "pr_30040164242"
      Public Shared HaSidoMarcadoComoCorreoNoDeseado$ = "pr_30040164243"
      Public Shared ReferenciaArchivo4Obsoleto$ = "pr_400401652136"
      Public Shared ReferenciaArchivo1Obsoleto$ = "pr_400401652137"
      Public Shared ReferenciaArchivo3$ = "pr_400401652138"
      Public Shared ReferenciaArchivo2Obsoleto$ = "pr_400401652139"
      Public Shared Contenido$ = "pr_30040163371050"
      Public Shared ReferenciaBuzon$ = "pr_30040257424"
      Public Shared CantidadDeArchivos$ = "pr_40040257421"
      Public Shared ReferenciaServidor$ = "pr_30040336411"
      Public Shared ResponderA$ = "pr_40040408072"
      Public Shared DireccionDeEnvioAlias$ = "pr_40040408073"
      Public Shared Autor$ = "pr_50040408086"
      Public Shared ReferenciaRespuestaA$ = "pr_40040452524"
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
      Public Class EnviosProgramadosDeCorreosBaseC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public HoraLocal As Integer
          Public ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaDato_UTC As Date
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public EmpleadoTieneAccesoWeb As Boolean
          Public Asunto As String
          Public CorreoDeOrigen As String
          Public CorreoDestino As String
          Public ReferenciaInformeDeOrigen As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaPlantillaDeCorreo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReintentosDeEnvio As Integer
          Public ErrorDeEnvio As String
          Public ReferenciaSeccionDeOrigen As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaRegistroDeOrigen As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaConfiguracionDeCorreoDeOrigen As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public EstadoDeEnvio As Integer
          Public FechaDeUltimoIntentoFallido_UTC As Date
          Public FechaDeEnvio_UTC As Date
          Public HaSidoMarcadoComoCorreoNoDeseado As Boolean
          Public ReferenciaArchivo4Obsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaArchivo1Obsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaArchivo3 As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaArchivo2Obsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Contenido As String
          Public ReferenciaBuzon As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public CantidadDeArchivos As Integer
          Public ReferenciaServidor As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ResponderA As String
          Public DireccionDeEnvioAlias As String
          Public Autor As String
          Public ReferenciaRespuestaA As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
