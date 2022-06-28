Partial Public Class SeccionesD
  Public Class AjustesDeSaldoPromocionalBaseD
      Public Shared _SeccionID As String = "3cdb877c-0318-4594-8d69-1cd2d4db495e"
      Public Shared _SeccionIDGUID As New Guid("3cdb877c-0318-4594-8d69-1cd2d4db495e")
      Public Class AjustesDeSaldoPromocionalBaseES
          Public shared _SeccionID as Guid = New Guid("3cdb877c-0318-4594-8d69-1cd2d4db495e")
          Public shared _Tabla$ = "tpr_20040113181"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_200401131824"
      Public Shared FechaDato_UTC$ = "pr_20040113188"
      Public Shared ExportarEnModulos$ = "pr_200401131810"
      Public Shared FechaAlta_UTC$ = "pr_200401131811"
      Public Shared ImporteImporte$ = "pr_200401131828"
      Public Shared ReferenciaMovimientoInterno$ = "pr_200401131825"
      Public Shared ReferenciaAutorDelAlta$ = "pr_20040113187"
      Public Shared ClienteTieneAccesoWeb$ = "pr_200401131827"
      Public Shared HoraLocal$ = "pr_20040113189"
      Public Shared ReferenciaDestinador$ = "pr_200401131812"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_20040113186"
      Public Shared ReferenciaCliente$ = "pr_200401131826"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_200401131822"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_20040113185"
      Public Shared MotivoDelAjuste$ = "pr_40040242732"
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
      Public Class AjustesDeSaldoPromocionalBaseC
          Public EmpleadoTieneAccesoWeb As Boolean
          Public FechaDato_UTC As Date
          Public FechaAlta_UTC As Date
          Public ImporteImporte As Decimal
          Public ReferenciaMovimientoInterno As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ClienteTieneAccesoWeb As Boolean
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaCliente As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public MotivoDelAjuste As String
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
