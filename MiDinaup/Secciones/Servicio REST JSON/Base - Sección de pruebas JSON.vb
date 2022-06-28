Partial Public Class SeccionesD
  Public Class SeccionDePruebasJSONBaseD
      Public Shared _SeccionID As String = "2a8a863b-540d-4b4c-8898-3cebc52bba65"
      Public Shared _SeccionIDGUID As New Guid("2a8a863b-540d-4b4c-8898-3cebc52bba65")
      Public Class SeccionDePruebasJSONBaseES
          Public shared _SeccionID as Guid = New Guid("2a8a863b-540d-4b4c-8898-3cebc52bba65")
          Public shared _Tabla$ = "tpr_20040140791003"
      Public Shared ReferenciaDestinador$ = "pr_200401407913"
      Public Shared FechaAlta_UTC$ = "pr_200401407912"
      Public Shared ReferenciaAutorDelAlta$ = "pr_20040140798"
      Public Shared ExportarEnModulos$ = "pr_200401407911"
      Public Shared HoraLocal$ = "pr_200401407910"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_200401407924"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_200401407925"
      Public Shared TextoDePrueba$ = "pr_200401407926"
      Public Shared TextoMultilinea$ = "pr_200401407927"
      Public Shared CasillaSiNoDePrueba$ = "pr_200401407928"
      Public Shared FechaDePrueba$ = "pr_200401407929"
      Public Shared HoraConSegundos$ = "pr_200401407930"
      Public Shared HoraSinSegundos$ = "pr_300401407935"
      Public Shared FechaYHoraSinSegundos_UTC$ = "pr_300401407936"
      Public Shared FechaYHoraConSegundos_UTC$ = "pr_300401407937"
      Public Shared CampoDecimal$ = "pr_300401407938"
      Public Shared CampoDeTipoEnumeracionMeses$ = "pr_40040140791"
      Public Shared ReferenciaEjemploDeCampoRelacionado$ = "pr_500401798922"
      Public Shared FechaModificacionExterna_UTC$ = "pr_10040452014"
      Public Shared IDExterna$ = "pr_10040452015"
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
      Public Class SeccionDePruebasJSONBaseC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public EmpleadoTieneAccesoWeb As Boolean
          Public TextoDePrueba As String
          Public TextoMultilinea As String
          Public CasillaSiNoDePrueba As Boolean
          Public FechaDePrueba As Date
          Public HoraConSegundos As Integer
          Public HoraSinSegundos As Integer
          Public FechaYHoraSinSegundos_UTC As Date
          Public FechaYHoraConSegundos_UTC As Date
          Public CampoDecimal As Decimal
          Public CampoDeTipoEnumeracionMeses As Integer
          Public ReferenciaEjemploDeCampoRelacionado As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaModificacionExterna_UTC As Date
          Public IDExterna As Integer
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
