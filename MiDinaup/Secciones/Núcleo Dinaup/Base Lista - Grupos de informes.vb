Partial Public Class SeccionesD
  Public Class GruposDeInformesBaseListaD
      Public Shared _SeccionID As String = "f3558a13-011e-48c6-be16-cbe2f0381981"
      Public Shared _SeccionIDGUID As New Guid("f3558a13-011e-48c6-be16-cbe2f0381981")
      Public Class GruposDeInformesBaseListaES
          Public shared _SeccionID as Guid = New Guid("f3558a13-011e-48c6-be16-cbe2f0381981")
          Public shared _Tabla$ = "tpr_20040104791_e"
      Public Shared ReferenciaInforme$ = "pr_40040104791"
      Public Shared ReferenciaDestinador$ = "pr_200401047922"
      Public Shared HoraLocal$ = "pr_200401047918"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_200401047927"
      Public Shared ReferenciaAutorDelAlta$ = "pr_200401047916"
      Public Shared Observaciones$ = "pr_40040104792"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_200401047925"
      Public Shared FechaAlta_UTC$ = "pr_200401047919"
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
      Public Class GruposDeInformesBaseListaC
          Public ReferenciaInforme As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Observaciones As String
          Public EmpleadoTieneAccesoWeb As Boolean
          Public FechaAlta_UTC As Date
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
