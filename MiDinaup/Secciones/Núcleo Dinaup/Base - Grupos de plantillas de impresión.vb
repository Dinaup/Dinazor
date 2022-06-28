Partial Public Class SeccionesD
  Public Class GruposDePlantillasDeImpresionBaseD
      Public Shared _SeccionID As String = "147e9f91-f43b-400b-96ab-239da1061ab9"
      Public Shared _SeccionIDGUID As New Guid("147e9f91-f43b-400b-96ab-239da1061ab9")
      Public Class GruposDePlantillasDeImpresionBaseES
          Public shared _SeccionID as Guid = New Guid("147e9f91-f43b-400b-96ab-239da1061ab9")
          Public shared _Tabla$ = "tpr_40040108251"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_400401082523"
      Public Shared ExportarEnModulos$ = "pr_40040108256"
      Public Shared FechaAlta_UTC$ = "pr_40040108257"
      Public Shared ReferenciaAutorDelAlta$ = "pr_40040108253"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_400401082522"
      Public Shared Observaciones$ = "pr_400401082526"
      Public Shared HoraLocal$ = "pr_40040108255"
      Public Shared ReferenciaDestinador$ = "pr_40040108258"
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
      Public Class GruposDePlantillasDeImpresionBaseC
          Public EmpleadoTieneAccesoWeb As Boolean
          Public FechaAlta_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public Observaciones As String
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
