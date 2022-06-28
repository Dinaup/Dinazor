Partial Public Class SeccionesD
  Public Class PermisosPuntualesAPlantillasDeImpresionBaseD
      Public Shared _SeccionID As String = "230970a9-0707-4f98-b042-ffdd8dbbd70a"
      Public Shared _SeccionIDGUID As New Guid("230970a9-0707-4f98-b042-ffdd8dbbd70a")
      Public Class PermisosPuntualesAPlantillasDeImpresionBaseES
          Public shared _SeccionID as Guid = New Guid("230970a9-0707-4f98-b042-ffdd8dbbd70a")
          Public shared _Tabla$ = "tpr_40040108252"
      Public Shared FechaAlta_UTC$ = "pr_400401082538"
      Public Shared ExportarEnModulos$ = "pr_400401082537"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_400401082555"
      Public Shared Observaciones$ = "pr_10040108261"
      Public Shared ReferenciaAutorDelAlta$ = "pr_400401082534"
      Public Shared EmpleadosPermiso$ = "pr_400401082557"
      Public Shared FechaDeInicio_UTC$ = "pr_10040108263"
      Public Shared PlantillasDeImpresion$ = "pr_400401082556"
      Public Shared ReferenciaDestinador$ = "pr_400401082539"
      Public Shared HoraLocal$ = "pr_400401082536"
      Public Shared FechaDeFin_UTC$ = "pr_10040108264"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_400401082552"
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
      Public Class PermisosPuntualesAPlantillasDeImpresionBaseC
          Public FechaAlta_UTC As Date
          Public EmpleadoTieneAccesoWeb As Boolean
          Public Observaciones As String
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public EmpleadosPermiso As String
          Public FechaDeInicio_UTC As Date
          Public PlantillasDeImpresion As String
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public FechaDeFin_UTC As Date
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
