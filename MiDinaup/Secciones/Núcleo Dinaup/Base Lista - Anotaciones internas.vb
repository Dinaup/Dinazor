Partial Public Class SeccionesD
  Public Class AnotacionesInternasBaseListaD
      Public Shared _SeccionID As String = "7647188a-45f0-43c2-88c5-19eb9d1e153b"
      Public Shared _SeccionIDGUID As New Guid("7647188a-45f0-43c2-88c5-19eb9d1e153b")
      Public Class AnotacionesInternasBaseListaES
          Public shared _SeccionID as Guid = New Guid("7647188a-45f0-43c2-88c5-19eb9d1e153b")
          Public shared _Tabla$ = "tpr_72cffdfxd_e"
      Public Shared ReferenciaAutorDelAlta$ = "pr_72cfff3wd"
      Public Shared EmpleadoMencionadoTieneAccesoWeb$ = "pr_72ed227wd"
      Public Shared NotificacionRevisada$ = "pr_72ed22fwd"
      Public Shared DatoAdjuntoNombre$ = "pr_72ed933wd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_72d003bwd"
      Public Shared FechaAlta_UTC$ = "pr_72cfffbwd"
      Public Shared FechaDato_UTC$ = "pr_72cfff7wd"
      Public Shared ReferenciaDatoAdjunto$ = "pr_72ed92fwd"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_72cffebwd"
      Public Shared HoraLocal$ = "pr_77611d4wd"
      Public Shared ReferenciaDestinador$ = "pr_72d0007wd"
      Public Shared ReferenciaSeccionAdjuntada$ = "pr_72ed92bwd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_72d0047wd"
      Public Shared ReferenciaEmpleadoMencionado$ = "pr_72ed223wd"
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
      Public Class AnotacionesInternasBaseListaC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public EmpleadoMencionadoTieneAccesoWeb As Boolean
          Public NotificacionRevisada As Boolean
          Public DatoAdjuntoNombre As String
          Public EmpleadoTieneAccesoWeb As Boolean
          Public FechaAlta_UTC As Date
          Public FechaDato_UTC As Date
          Public ReferenciaDatoAdjunto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaSeccionAdjuntada As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaEmpleadoMencionado As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
