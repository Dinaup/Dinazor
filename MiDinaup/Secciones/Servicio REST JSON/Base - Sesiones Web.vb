Partial Public Class SeccionesD
  Public Class SesionesWebBaseD
      Public Shared _SeccionID As String = "c9d56230-117b-41a3-91fe-57a4a60a4493"
      Public Shared _SeccionIDGUID As New Guid("c9d56230-117b-41a3-91fe-57a4a60a4493")
      Public Class SesionesWebBaseES
          Public shared _SeccionID as Guid = New Guid("c9d56230-117b-41a3-91fe-57a4a60a4493")
          Public shared _Tabla$ = "tpr_50040177761"
      Public Shared ReferenciaDestinador$ = "pr_500401777612"
      Public Shared FechaAlta_UTC$ = "pr_500401777611"
      Public Shared ExportarEnModulos$ = "pr_500401777610"
      Public Shared HoraLocal$ = "pr_50040177769"
      Public Shared FechaDato_UTC$ = "pr_50040177768"
      Public Shared ReferenciaAutorDelAlta$ = "pr_50040177767"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_500401777623"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_500401777624"
      Public Shared SesionActiva$ = "pr_60040178393"
      Public Shared DireccionIP$ = "pr_500401783923"
      Public Shared Navegador$ = "pr_500401783924"
      Public Shared Token$ = "pr_500401783926"
      Public Shared UltimaActividad$ = "pr_500401783927"
      Public Shared ReferenciaEntidad$ = "pr_60040178391"
      Public Shared EntidadTieneAccesoWeb$ = "pr_60040178392"
      Public Shared Aplicacion$ = "pr_10040178401"
      Public Shared ReferenciaServidor$ = "pr_40040218985"
      Public Shared ReferenciaUbicacion$ = "pr_50040374515"
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
      Public Class SesionesWebBaseC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public HoraLocal As Integer
          Public FechaDato_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public EmpleadoTieneAccesoWeb As Boolean
          Public SesionActiva As Boolean
          Public DireccionIP As String
          Public Navegador As String
          Public Token As String
          Public UltimaActividad As Date
          Public ReferenciaEntidad As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public EntidadTieneAccesoWeb As Boolean
          Public Aplicacion As String
          Public ReferenciaServidor As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaUbicacion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
