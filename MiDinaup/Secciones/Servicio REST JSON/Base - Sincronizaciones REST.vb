Partial Public Class SeccionesD
  Public Class SincronizacionesRESTBaseD
      Public Shared _SeccionID As String = "1f92c6cf-9fe8-4bb5-8fb0-268e7f87933e"
      Public Shared _SeccionIDGUID As New Guid("1f92c6cf-9fe8-4bb5-8fb0-268e7f87933e")
      Public Class SincronizacionesRESTBaseES
          Public shared _SeccionID as Guid = New Guid("1f92c6cf-9fe8-4bb5-8fb0-268e7f87933e")
          Public shared _Tabla$ = "tpr_20040450401"
      Public Shared HoraLocal$ = "pr_20040450409"
      Public Shared ReferenciaDestinador$ = "pr_200404504012"
      Public Shared FechaAlta_UTC$ = "pr_200404504011"
      Public Shared ReferenciaAutorDelAlta$ = "pr_20040450407"
      Public Shared ExportarEnModulos$ = "pr_200404504010"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_200404504023"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_200404504024"
      Public Shared Detalles$ = "pr_30040450402"
      Public Shared ReferenciaSecccionDeDestino$ = "pr_30040450404"
      Public Shared MarcadorDePosicion$ = "pr_30040450405"
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
      Public Class SincronizacionesRESTBaseC
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public EmpleadoTieneAccesoWeb As Boolean
          Public Detalles As String
          Public ReferenciaSecccionDeDestino As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public MarcadorDePosicion As String
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
