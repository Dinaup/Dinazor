Partial Public Class SeccionesD
  Public Class AgrupadoresDeRegistrosBaseD
      Public Shared _SeccionID As String = "bafc0f45-a734-4bb1-8193-1447cb0fc2c5"
      Public Shared _SeccionIDGUID As New Guid("bafc0f45-a734-4bb1-8193-1447cb0fc2c5")
      Public Class AgrupadoresDeRegistrosBaseES
          Public shared _SeccionID as Guid = New Guid("bafc0f45-a734-4bb1-8193-1447cb0fc2c5")
          Public shared _Tabla$ = "tpr_7795803xd"
      Public Shared ReferenciaDestinador$ = "pr_7795819wd"
      Public Shared HoraLocal$ = "pr_779580dwd"
      Public Shared CantidadElementos$ = "pr_77c1040wd"
      Public Shared ReferenciaSeccionDeGrupo$ = "pr_77968a5wd"
      Public Shared FechaUltimaOptimizacionDeIndice_UTC$ = "pr_77c1d10wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_7795835wd"
      Public Shared AgruparTodo$ = "pr_79aab74wd"
      Public Shared CampoValor$ = "pr_7800d76wd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_7795839wd"
      Public Shared ReferenciaCampoValorSeccion$ = "pr_77bd7cdwd"
      Public Shared FechaAlta_UTC$ = "pr_7795813wd"
      Public Shared ExportarEnModulos$ = "pr_779580fwd"
      Public Shared Desactivar$ = "pr_79bcbafwd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_7795809wd"
      Public Shared CampoDeGrupo$ = "pr_77968a7wd"
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
      Public Class AgrupadoresDeRegistrosBaseC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public CantidadElementos As Integer
          Public ReferenciaSeccionDeGrupo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaUltimaOptimizacionDeIndice_UTC As Date
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public AgruparTodo As Boolean
          Public CampoValor As String
          Public EmpleadoTieneAccesoWeb As Boolean
          Public ReferenciaCampoValorSeccion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public Desactivar As Boolean
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public CampoDeGrupo As String
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
