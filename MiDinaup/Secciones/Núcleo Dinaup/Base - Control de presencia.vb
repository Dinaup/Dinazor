Partial Public Class SeccionesD
  Public Class ControlDePresenciaBaseD
      Public Shared _SeccionID As String = "ccc34d94-b2df-4307-b440-c45ee8ac8b81"
      Public Shared _SeccionIDGUID As New Guid("ccc34d94-b2df-4307-b440-c45ee8ac8b81")
      Public Class ControlDePresenciaBaseES
          Public shared _SeccionID as Guid = New Guid("ccc34d94-b2df-4307-b440-c45ee8ac8b81")
          Public shared _Tabla$ = "tpr_63535efxd"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_183fe6855ax276wd"
      Public Shared ReferenciaJornadaDeHorario$ = "pr_183fec773dxc7wd"
      Public Shared TipoAccion$ = "pr_7c219fbwd"
      Public Shared ReferenciaAsignacionDeHorario$ = "pr_30040103155"
      Public Shared DiferenciaEnMinutos$ = "pr_1844ca9f9cx61wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_183fdde8e4x376wd"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_183fe6856ex297wd"
      Public Shared ReferenciaHorario$ = "pr_183feba35cx3c6wd"
      Public Shared HoraLocal$ = "pr_776aebewd"
      Public Shared ReferenciaDestinador$ = "pr_183fdac3c6x81wd"
      Public Shared ReferenciaControlRelativo$ = "pr_1844a51abdx22dwd"
      Public Shared ReferenciaJornada$ = "pr_30040103151"
      Public Shared ReferenciaTurnoDeJornada$ = "pr_30040103152"
      Public Shared ReferenciaAutorDelAlta$ = "pr_183fdac371x2fwd"
      Public Shared ReferenciaUltimoCierreDeSesionEnTurnoSesion$ = "pr_18601891e8x258wd"
      Public Shared FechaDato_UTC$ = "pr_183fe68584xa8wd"
      Public Shared ExportarEnModulos$ = "pr_191d3d4679x3b8wd"
      Public Shared FechaAlta_UTC$ = "pr_183fdac389x47wd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_183fe84035x3b3wd"
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
      Public Class ControlDePresenciaBaseC
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaJornadaDeHorario As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public TipoAccion As Integer
          Public ReferenciaAsignacionDeHorario As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public DiferenciaEnMinutos As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaHorario As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaControlRelativo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaJornada As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaTurnoDeJornada As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaUltimoCierreDeSesionEnTurnoSesion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
          Sub new()
          End Sub
      End Class
  End Class
End Class
