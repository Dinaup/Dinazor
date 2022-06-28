Partial Public Class SeccionesD
  Public Class BandejaDeCorreosBaseD
      Public Shared _SeccionID As String = "9121b827-441d-4eaf-883d-3efd40f44d45"
      Public Shared _SeccionIDGUID As New Guid("9121b827-441d-4eaf-883d-3efd40f44d45")
      Public Class BandejaDeCorreosBaseES
          Public shared _SeccionID as Guid = New Guid("9121b827-441d-4eaf-883d-3efd40f44d45")
          Public shared _Tabla$ = "tpr_20040257111"
      Public Shared ReferenciaAutorDelAlta$ = "pr_20040257119"
      Public Shared ReferenciaDestinador$ = "pr_200402571114"
      Public Shared FechaAlta_UTC$ = "pr_200402571113"
      Public Shared FechaDato_UTC$ = "pr_200402571110"
      Public Shared ExportarEnModulos$ = "pr_200402571112"
      Public Shared HoraLocal$ = "pr_200402571111"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_200402571125"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_200402571126"
      Public Shared Contenido$ = "pr_300402571127"
      Public Shared HaSidoMarcadoComoCorreoNoDeseado$ = "pr_300402571128"
      Public Shared CorreoDeOrigen$ = "pr_300402571129"
      Public Shared CorreoDestino$ = "pr_300402571130"
      Public Shared ReferenciaConfiguracionDeCorreo$ = "pr_300402571134"
      Public Shared Asunto$ = "pr_300402571131"
      Public Shared FechaDeCorreo_UTC$ = "pr_300402571136"
      Public Shared ReferenciaEntidadRelacionada$ = "pr_40040257111"
      Public Shared EntidadRelacionadaTieneAccesoWeb$ = "pr_40040257112"
      Public Shared ReferenciaEmpresaRelacionada$ = "pr_40040257113"
      Public Shared Cabecera$ = "pr_40040257114"
      Public Shared ReferenciaEstado$ = "pr_500402571131"
      Public Shared CantidadDeArchivosAdjuntos$ = "pr_60040257111"
      Public Shared IdentificadorUnico$ = "pr_10040257122"
      Public Shared ReferenciaBuzon$ = "pr_50040257411"
      Public Shared ReferenciaRegistroRelacionado$ = "pr_20040257682"
      Public Shared ReferenciaRegistroRelacionadoSeccion$ = "pr_20040257684"
      Public Shared DireccionDeRespuesta$ = "pr_10040408085"
      Public Shared Autor$ = "pr_10040408083"
      Public Shared DireccionDeEnvioAlias$ = "pr_10040408084"
      Public Shared MensajeIDEmail$ = "pr_20040452512"
      Public Shared Tipo$ = "pr_50040452752"
      Public Shared Carpeta$ = "pr_10040474828"
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
      Public Class BandejaDeCorreosBaseC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public FechaDato_UTC As Date
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public EmpleadoTieneAccesoWeb As Boolean
          Public Contenido As String
          Public HaSidoMarcadoComoCorreoNoDeseado As Boolean
          Public CorreoDeOrigen As String
          Public CorreoDestino As String
          Public ReferenciaConfiguracionDeCorreo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Asunto As String
          Public FechaDeCorreo_UTC As Date
          Public ReferenciaEntidadRelacionada As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public EntidadRelacionadaTieneAccesoWeb As Boolean
          Public ReferenciaEmpresaRelacionada As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Cabecera As String
          Public ReferenciaEstado As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public CantidadDeArchivosAdjuntos As Integer
          Public IdentificadorUnico As String
          Public ReferenciaBuzon As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaRegistroRelacionado As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaRegistroRelacionadoSeccion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public DireccionDeRespuesta As String
          Public Autor As String
          Public DireccionDeEnvioAlias As String
          Public MensajeIDEmail As String
          Public Tipo As Integer
          Public Carpeta As String
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
