Partial Public Class SeccionesD
  Public Class MotivosDeRealizacionDeTurnosBaseD
      Public Shared _SeccionID As String = "93baaee5-b723-4642-8e9d-c8d34d683f15"
      Public Shared _SeccionIDGUID As New Guid("93baaee5-b723-4642-8e9d-c8d34d683f15")
      Public Class MotivosDeRealizacionDeTurnosBaseES
          Public shared _SeccionID as Guid = New Guid("93baaee5-b723-4642-8e9d-c8d34d683f15")
          Public shared _Tabla$ = "tpr_5ca512bxd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_169e4fa505x307wd"
      Public Shared ReferenciaDestinador$ = "pr_169e4d23b4xd1wd"
      Public Shared HoraLocal$ = "pr_776af02wd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_191d9b4feax3bfwd"
      Public Shared FechaAlta_UTC$ = "pr_169e4d2342x60wd"
      Public Shared ExportarEnModulos$ = "pr_191d3d4760x151wd"
      Public Shared Observaciones$ = "pr_169e507c38x7wd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_169e4d2314x24wd"
      Public Shared FuerzaMayor$ = "pr_10040211311"
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
      Public Class MotivosDeRealizacionDeTurnosBaseC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public EmpleadoTieneAccesoWeb As Boolean
          Public FechaAlta_UTC As Date
          Public Observaciones As String
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FuerzaMayor As Boolean
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
