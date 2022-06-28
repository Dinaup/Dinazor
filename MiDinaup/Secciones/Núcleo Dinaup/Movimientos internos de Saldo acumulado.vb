Partial Public Class SeccionesD
  Public Class MovimientosInternosDeSaldoAcumuladoD
      Public Shared _SeccionID As String = "cd864ef0-1109-4ec4-b99b-104b97957c96"
      Public Shared _SeccionIDGUID As New Guid("cd864ef0-1109-4ec4-b99b-104b97957c96")
      Public Class MovimientosInternosDeSaldoAcumuladoES
          Public shared _SeccionID as Guid = New Guid("cd864ef0-1109-4ec4-b99b-104b97957c96")
          Public shared _Tabla$ = "tpr_5ec7d37xd"
      Public Shared FechaAlta_UTC$ = "pr_1723d33b53x106wd"
      Public Shared FechaDato_UTC$ = "pr_172431ef36x34fwd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_191d9b55d4x6awd"
      Public Shared EntidadTieneAccesoWeb$ = "pr_17245df809x2afwd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_1723d33b13x2bcwd"
      Public Shared ImporteCantidadDeSaldoAcumulado$ = "pr_1724228b3dx1c2wd"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_191d8f4a7ex20cwd"
      Public Shared HoraLocal$ = "pr_776ae2ewd"
      Public Shared ReferenciaDestinador$ = "pr_1723d33bd8x6bwd"
      Public Shared ReferenciaSeccionRegistroDeOrigen$ = "pr_60040107042"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_1723d43839x109wd"
      Public Shared ReferenciaEntidad$ = "pr_17245d506fx2a0wd"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_191d8f4a2cx363wd"
      Public Shared ReferenciaRegistroDeOrigen$ = "pr_60040107041"
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
      Public Class MovimientosInternosDeSaldoAcumuladoC
          Public FechaAlta_UTC As Date
          Public FechaDato_UTC As Date
          Public EmpleadoTieneAccesoWeb As Boolean
          Public EntidadTieneAccesoWeb As Boolean
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ImporteCantidadDeSaldoAcumulado As Decimal
          Public ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaSeccionRegistroDeOrigen As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaEntidad As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaRegistroDeOrigen As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
