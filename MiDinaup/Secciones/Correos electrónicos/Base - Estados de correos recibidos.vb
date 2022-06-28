Partial Public Class SeccionesD
  Public Class EstadosDeCorreosRecibidosBaseD
      Public Shared _SeccionID As String = "f887a106-8678-4e36-bf85-c9ea84129632"
      Public Shared _SeccionIDGUID As New Guid("f887a106-8678-4e36-bf85-c9ea84129632")
      Public Class EstadosDeCorreosRecibidosBaseES
          Public shared _SeccionID as Guid = New Guid("f887a106-8678-4e36-bf85-c9ea84129632")
          Public shared _Tabla$ = "tpr_40040257112"
      Public Shared FechaAlta_UTC$ = "pr_400402571118"
      Public Shared ReferenciaDestinador$ = "pr_400402571119"
      Public Shared ReferenciaAutorDelAlta$ = "pr_400402571114"
      Public Shared HoraLocal$ = "pr_400402571116"
      Public Shared ExportarEnModulos$ = "pr_400402571117"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_400402571130"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_400402571131"
      Public Shared Descripcion$ = "pr_500402571132"
      Public Shared TipoDeEstado$ = "pr_500402571133"
      Public Shared EstadoPredeterminado$ = "pr_20040257213"
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
      Public Class EstadosDeCorreosRecibidosBaseC
          Public FechaAlta_UTC As Date
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public EmpleadoTieneAccesoWeb As Boolean
          Public Descripcion As String
          Public TipoDeEstado As Integer
          Public EstadoPredeterminado As Boolean
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
