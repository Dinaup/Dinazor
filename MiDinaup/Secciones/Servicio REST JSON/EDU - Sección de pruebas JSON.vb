Partial Public Class SeccionesD
  Public Class SeccionDePruebasJSONEDUD
      Public Shared _SeccionID As String = "ab33bc6d-f454-448d-b00b-6043d3b501cb"
      Public Shared _SeccionIDGUID As New Guid("ab33bc6d-f454-448d-b00b-6043d3b501cb")
      Public Class SeccionDePruebasJSONEDUES
          Public shared _SeccionID as Guid = New Guid("ab33bc6d-f454-448d-b00b-6043d3b501cb")
          Public shared _Tabla$ = "tpr_20040140791003_u"
      Public Shared ReferenciaUbicacionDeLosDatos$ = "pr_20040140793"
      Public Shared ReferenciaRelacionElemento$ = "pr_20040140792"
      Public Shared PruebaDeTextoPorUbicacionEDU$ = "pr_40040140793"
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
      Public Class SeccionDePruebasJSONEDUC
          Public ReferenciaUbicacionDeLosDatos As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaRelacionElemento As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public PruebaDeTextoPorUbicacionEDU As String
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
