Partial Public Class SeccionesD
  Public Class PuntosATratarEnReunionesBaseListaD
      Public Shared _SeccionID As String = "60bfb175-66ee-4641-a08d-d99e3a451db8"
      Public Shared _SeccionIDGUID As New Guid("60bfb175-66ee-4641-a08d-d99e3a451db8")
      Public Class PuntosATratarEnReunionesBaseListaES
          Public shared _SeccionID as Guid = New Guid("60bfb175-66ee-4641-a08d-d99e3a451db8")
          Public shared _Tabla$ = "tpr_50040147511_e"
      Public Shared ReferenciaDestinador$ = "pr_500401475120"
      Public Shared FechaAlta_UTC$ = "pr_500401475119"
      Public Shared HoraLocal$ = "pr_500401475118"
      Public Shared ReferenciaAutorDelAlta$ = "pr_500401475116"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_500401475123"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_500401475124"
      Public Shared DetallesDelPuntoATratar$ = "pr_10040147521"
      Public Shared ConclusionesDelPuntoATratar$ = "pr_10040147523"
      Public Shared PuntoPospuestoObsoleto$ = "pr_20040147523"
      Public Shared PuntoCanceladoObsoleto$ = "pr_20040147522"
      Public Shared PuntoTratadoObsoleto$ = "pr_20040147521"
      Public Shared ReferenciaReunion$ = "pr_30040147521"
      Public Shared AccionesATomar$ = "pr_50040147521"
      Public Shared Estado$ = "pr_60040405189"
      Public Shared DejarConstanciaEnActas$ = "pr_50040409251"
      Public Shared Inicio_UTC$ = "pr_50040409252"
      Public Shared Fin_UTC$ = "pr_50040409253"
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
      Public Class PuntosATratarEnReunionesBaseListaC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public HoraLocal As Integer
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public EmpleadoTieneAccesoWeb As Boolean
          Public DetallesDelPuntoATratar As String
          Public ConclusionesDelPuntoATratar As String
          Public PuntoPospuestoObsoleto As Boolean
          Public PuntoCanceladoObsoleto As Boolean
          Public PuntoTratadoObsoleto As Boolean
          Public ReferenciaReunion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AccionesATomar As String
          Public Estado As Integer
          Public DejarConstanciaEnActas As Boolean
          Public Inicio_UTC As Date
          Public Fin_UTC As Date
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
