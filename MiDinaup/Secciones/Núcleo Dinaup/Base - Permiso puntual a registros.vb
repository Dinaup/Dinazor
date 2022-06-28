Partial Public Class SeccionesD
  Public Class PermisoPuntualARegistrosBaseD
      Public Shared _SeccionID As String = "d1737cfb-e597-46b1-b14f-d93493a1ad45"
      Public Shared _SeccionIDGUID As New Guid("d1737cfb-e597-46b1-b14f-d93493a1ad45")
      Public Class PermisoPuntualARegistrosBaseES
          Public shared _SeccionID as Guid = New Guid("d1737cfb-e597-46b1-b14f-d93493a1ad45")
          Public shared _Tabla$ = "tpr_73b8202xd"
      Public Shared PuedeComentarObsoleto$ = "pr_76e08f6wd"
      Public Shared PuedeVerComentariosObsoleto$ = "pr_76e08fawd"
      Public Shared FechaDeFin_UTC$ = "pr_73b8355wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_73b8262wd"
      Public Shared FechaDeInicio_UTC$ = "pr_73b8351wd"
      Public Shared ReferenciaDestinador$ = "pr_73b822awd"
      Public Shared HoraLocal$ = "pr_77611c4wd"
      Public Shared NoSePuedeUtilizarEstePermisoPuntualParaRealizarUnaModificacion$ = "pr_73b8365wd"
      Public Shared RegistrosAcceso$ = "pr_7ac197fwd"
      Public Shared EmpleadosAsignados$ = "pr_7ac197dwd"
      Public Shared Observaciones$ = "pr_30040104958"
      Public Shared ReferenciaAutorDelAlta$ = "pr_73b820ewd"
      Public Shared ReferenciaRol$ = "pr_76ec8dfwd"
      Public Shared PuedeVerObsoleto$ = "pr_73b8361wd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_73b826awd"
      Public Shared ExportarEnModulos$ = "pr_73b8216wd"
      Public Shared FechaAlta_UTC$ = "pr_73b821ewd"
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
      Public Class PermisoPuntualARegistrosBaseC
          Public PuedeComentarObsoleto As Boolean
          Public PuedeVerComentariosObsoleto As Boolean
          Public FechaDeFin_UTC As Date
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public FechaDeInicio_UTC As Date
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public NoSePuedeUtilizarEstePermisoPuntualParaRealizarUnaModificacion As Boolean
          Public RegistrosAcceso As String
          Public EmpleadosAsignados As String
          Public Observaciones As String
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaRol As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public PuedeVerObsoleto As Boolean
          Public EmpleadoTieneAccesoWeb As Boolean
          Public FechaAlta_UTC As Date
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
