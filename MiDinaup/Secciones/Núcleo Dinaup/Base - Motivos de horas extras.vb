Partial Public Class SeccionesD
  Public Class MotivosDeHorasExtrasBaseD
      Public Shared _SeccionID As String = "6860d8fc-8939-47ba-8e03-c30a6cbb5dee"
      Public Shared _SeccionIDGUID As New Guid("6860d8fc-8939-47ba-8e03-c30a6cbb5dee")
      Public Class MotivosDeHorasExtrasBaseES
          Public shared _SeccionID as Guid = New Guid("6860d8fc-8939-47ba-8e03-c30a6cbb5dee")
          Public shared _Tabla$ = "tpr_10040212244"
      Public Shared ReferenciaAutorDelAlta$ = "pr_100402122432"
      Public Shared ExportarEnModulos$ = "pr_100402122435"
      Public Shared FechaAlta_UTC$ = "pr_100402122436"
      Public Shared HoraLocal$ = "pr_100402122434"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_100402122448"
      Public Shared ReferenciaDestinador$ = "pr_100402122437"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_100402122449"
      Public Shared FuerzaMayor$ = "pr_30040212242"
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
      Public Class MotivosDeHorasExtrasBaseC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public EmpleadoTieneAccesoWeb As Boolean
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
