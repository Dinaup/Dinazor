Partial Public Class SeccionesD
  Public Class AjustesDeSaldoPromocionalBaseListaD
      Public Shared _SeccionID As String = "c9fc48d8-a322-4c32-bba2-e0da377b5c87"
      Public Shared _SeccionIDGUID As New Guid("c9fc48d8-a322-4c32-bba2-e0da377b5c87")
      Public Class AjustesDeSaldoPromocionalBaseListaES
          Public shared _SeccionID as Guid = New Guid("c9fc48d8-a322-4c32-bba2-e0da377b5c87")
          Public shared _Tabla$ = "tpr_20040113181_e"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_200401131814"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_200401131823"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_200401131815"
      Public Shared ReferenciaDestinador$ = "pr_200401131820"
      Public Shared HoraLocal$ = "pr_200401131818"
      Public Shared ReferenciaAutorDelAlta$ = "pr_200401131816"
      Public Shared FechaDato_UTC$ = "pr_200401131817"
      Public Shared FechaAlta_UTC$ = "pr_200401131819"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_200401131821"
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
      Public Shared RelacionElementoContenedorListador$ = "idrelacionlistador"
      Public Shared Listadoreliminado$ = "listadoreliminado"
      End Class
      Public Class AjustesDeSaldoPromocionalBaseListaC
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaDato_UTC As Date
          Public FechaAlta_UTC As Date
          Public EmpleadoTieneAccesoWeb As Boolean
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
          Public RelacionElementoContenedorListador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Listadoreliminado As Boolean
          Sub new()
          End Sub
      End Class
  End Class
End Class
