Partial Public Class SeccionesD
  Public Class MotivosDeAusenciasYRetrasosBaseD
      Public Shared _SeccionID As String = "86d66f59-4f8f-457d-8a05-f1c52f423b90"
      Public Shared _SeccionIDGUID As New Guid("86d66f59-4f8f-457d-8a05-f1c52f423b90")
      Public Class MotivosDeAusenciasYRetrasosBaseES
          Public shared _SeccionID as Guid = New Guid("86d66f59-4f8f-457d-8a05-f1c52f423b90")
          Public shared _Tabla$ = "tpr_10040212243"
      Public Shared ReferenciaDestinador$ = "pr_100402122413"
      Public Shared FechaAlta_UTC$ = "pr_100402122412"
      Public Shared ReferenciaAutorDelAlta$ = "pr_10040212248"
      Public Shared HoraLocal$ = "pr_100402122410"
      Public Shared ExportarEnModulos$ = "pr_100402122411"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_100402122424"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_100402122425"
      Public Shared Descripcion$ = "pr_20040347361"
      Public Shared CompatibleConCalendarioLaboral$ = "pr_20040347431"
      Public Shared ReferenciaIcono$ = "pr_30040347611"
      Public Shared Naturaleza$ = "pr_40040350274"
      Public Shared TipoIT$ = "pr_60040353383"
      Public Shared OcultarDeLaLeyendaDeCalendarioEnInformacionAdicionalDeNomina$ = "pr_20040353691"
      Public Shared ConservarHorasTrabajadasSegunElContratoPorDia$ = "pr_50040358476"
      Public Shared ModoDeCotizacion$ = "pr_30040360101"
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
      Public Class MotivosDeAusenciasYRetrasosBaseC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public EmpleadoTieneAccesoWeb As Boolean
          Public Descripcion As String
          Public CompatibleConCalendarioLaboral As Boolean
          Public ReferenciaIcono As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Naturaleza As Integer
          Public TipoIT As Boolean
          Public OcultarDeLaLeyendaDeCalendarioEnInformacionAdicionalDeNomina As Boolean
          Public ConservarHorasTrabajadasSegunElContratoPorDia As Boolean
          Public ModoDeCotizacion As Integer
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
