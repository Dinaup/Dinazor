Partial Public Class SeccionesD
  Public Class CargosDeTrabajoBaseD
      Public Shared _SeccionID As String = "d5d11fe8-5a40-4854-8c44-69ec0c53cabc"
      Public Shared _SeccionIDGUID As New Guid("d5d11fe8-5a40-4854-8c44-69ec0c53cabc")
      Public Class CargosDeTrabajoBaseES
          Public shared _SeccionID as Guid = New Guid("d5d11fe8-5a40-4854-8c44-69ec0c53cabc")
          Public shared _Tabla$ = "tpr_5839737xd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_158a06bf64x110wd"
      Public Shared HoraLocal$ = "pr_776ae9awd"
      Public Shared ReferenciaDestinador$ = "pr_158a06bb4fx3aawd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_158a06baa8x78wd"
      Public Shared DetallesDelPuesto$ = "pr_18a1f03c39x51w7"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_191d9b56e6x1afwd"
      Public Shared ExportarEnModulos$ = "pr_191d3d4603x105wd"
      Public Shared FechaAlta_UTC$ = "pr_158a06bad5xc7wd"
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
      Public Class CargosDeTrabajoBaseC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public DetallesDelPuesto As String
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
          Sub new()
          End Sub
      End Class
  End Class
End Class
