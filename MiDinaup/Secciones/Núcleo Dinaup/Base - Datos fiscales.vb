Partial Public Class SeccionesD
  Public Class DatosFiscalesBaseD
      Public Shared _SeccionID As String = "03e347ac-c694-4d4a-a81f-e577ba014d1d"
      Public Shared _SeccionIDGUID As New Guid("03e347ac-c694-4d4a-a81f-e577ba014d1d")
      Public Class DatosFiscalesBaseES
          Public shared _SeccionID as Guid = New Guid("03e347ac-c694-4d4a-a81f-e577ba014d1d")
          Public shared _Tabla$ = "tpr_20040138792"
      Public Shared ReferenciaDestinador$ = "pr_200401387916"
      Public Shared ExportarEnModulos$ = "pr_200401387914"
      Public Shared FechaAlta_UTC$ = "pr_200401387915"
      Public Shared HoraLocal$ = "pr_200401387913"
      Public Shared ReferenciaAutorDelAlta$ = "pr_200401387911"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_200401387927"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_200401387928"
      Public Shared ApellidosYNombreORazonSocial$ = "pr_30040138791"
      Public Shared NIF$ = "pr_30040138792"
      Public Shared Pais$ = "pr_30040138793"
      Public Shared Municipio$ = "pr_30040138794"
      Public Shared CodigoPostal$ = "pr_30040138795"
      Public Shared ReferenciaEntidad$ = "pr_30040138796"
      Public Shared EntidadTieneAccesoWeb$ = "pr_30040138797"
      Public Shared Provincia$ = "pr_40040138791"
      Public Shared DireccionCompleta$ = "pr_40040138792"
      Public Shared Telefono$ = "pr_50040138793"
      Public Shared ReferenciaUbicacion$ = "pr_50040138795"
      Public Shared CodigoProvincia$ = "pr_60040241501"
      Public Shared CodigoPais$ = "pr_60040241502"
      Public Shared TipoNIF$ = "pr_50040241502"
      Public Shared Numero$ = "pr_60040242243"
      Public Shared Puerta$ = "pr_60040242241"
      Public Shared CPlazaAvda$ = "pr_60040242242"
      Public Shared Piso$ = "pr_60040242244"
      Public Shared Escalera$ = "pr_60040242245"
      Public Shared DomicilioDireccion$ = "pr_10040242251"
      Public Shared Movil$ = "pr_10040242252"
      Public Shared Fax$ = "pr_10040242253"
      Public Shared EditarDireccionCompleta$ = "pr_20040242251"
      Public Shared NIFIntracomunitario$ = "pr_40040251451"
      Public Shared ApellidosPersonaFisica$ = "pr_40040254941"
      Public Shared NombrePersonaFisica$ = "pr_40040254942"
      Public Shared EsUnaPersonaFisica$ = "pr_50040254941"
      Public Shared Tipo$ = "pr_40040254952"
      Public Shared CodigoMunicipio$ = "pr_20040275833"
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
      Public Class DatosFiscalesBaseC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public HoraLocal As Integer
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public EmpleadoTieneAccesoWeb As Boolean
          Public ApellidosYNombreORazonSocial As String
          Public NIF As String
          Public Pais As String
          Public Municipio As String
          Public CodigoPostal As String
          Public ReferenciaEntidad As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public EntidadTieneAccesoWeb As Boolean
          Public Provincia As String
          Public DireccionCompleta As String
          Public Telefono As String
          Public ReferenciaUbicacion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public CodigoProvincia As String
          Public CodigoPais As String
          Public TipoNIF As String
          Public Numero As String
          Public Puerta As String
          Public CPlazaAvda As String
          Public Piso As String
          Public Escalera As String
          Public DomicilioDireccion As String
          Public Movil As String
          Public Fax As String
          Public EditarDireccionCompleta As Boolean
          Public NIFIntracomunitario As String
          Public ApellidosPersonaFisica As String
          Public NombrePersonaFisica As String
          Public EsUnaPersonaFisica As Boolean
          Public Tipo As Integer
          Public CodigoMunicipio As String
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
