Partial Public Class SeccionesD
  Public Class HorariosBaseD
      Public Shared _SeccionID As String = "71a50a3a-b4d6-4cb0-8a52-aa38c7a5b697"
      Public Shared _SeccionIDGUID As New Guid("71a50a3a-b4d6-4cb0-8a52-aa38c7a5b697")
      Public Class HorariosBaseES
          Public shared _SeccionID as Guid = New Guid("71a50a3a-b4d6-4cb0-8a52-aa38c7a5b697")
          Public shared _Tabla$ = "tpr_6351d72xd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_183f7b167ax31bwd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_191d9a6513x167wd"
      Public Shared ExportarEnModulos$ = "pr_191d3d48acx2c7wd"
      Public Shared FechaAlta_UTC$ = "pr_183f7b16acx158wd"
      Public Shared ReferenciaDestinador$ = "pr_183f7b16e7x192wd"
      Public Shared HoraLocal$ = "pr_776af14wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_183f7cdcd5x2f4wd"
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
      Public Class HorariosBaseC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public EmpleadoTieneAccesoWeb As Boolean
          Public FechaAlta_UTC As Date
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
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
