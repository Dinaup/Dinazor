Partial Public Class SeccionesD
  Public Class CambiosDeContraseñasBaseD
      Public Shared _SeccionID As String = "72cb52df-988a-4751-89e8-db6f1e40c629"
      Public Shared _SeccionIDGUID As New Guid("72cb52df-988a-4751-89e8-db6f1e40c629")
      Public Class CambiosDeContraseñasBaseES
          Public shared _SeccionID as Guid = New Guid("72cb52df-988a-4751-89e8-db6f1e40c629")
          Public shared _Tabla$ = "tpr_60040474803"
      Public Shared FechaDato_UTC$ = "pr_600404748011"
      Public Shared HoraLocal$ = "pr_600404748012"
      Public Shared ReferenciaDestinador$ = "pr_600404748015"
      Public Shared FechaAlta_UTC$ = "pr_600404748014"
      Public Shared ExportarEnModulos$ = "pr_600404748013"
      Public Shared ReferenciaAutorDelAlta$ = "pr_600404748010"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_600404748026"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_600404748027"
      Public Shared ReferenciaServidor$ = "pr_600404748028"
      Public Shared ReferenciaEntidad$ = "pr_600404748029"
      Public Shared EntidadTieneAccesoWeb$ = "pr_600404748030"
      Public Shared Aplicacion$ = "pr_600404748031"
      Public Shared Usuario$ = "pr_600404748032"
      Public Shared Navegador$ = "pr_10040474811"
      Public Shared DireccionIP$ = "pr_10040474812"
      Public Shared CambioEfectuado$ = "pr_10040474817"
      Public Shared ReferenciaCorreoEnviado$ = "pr_40040474832"
      Public Shared Codigo$ = "pr_20040480161001"
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
      Public Class CambiosDeContraseñasBaseC
          Public FechaDato_UTC As Date
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public EmpleadoTieneAccesoWeb As Boolean
          Public ReferenciaServidor As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaEntidad As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public EntidadTieneAccesoWeb As Boolean
          Public Aplicacion As String
          Public Usuario As String
          Public Navegador As String
          Public DireccionIP As String
          Public CambioEfectuado As Boolean
          Public ReferenciaCorreoEnviado As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Codigo As String
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
