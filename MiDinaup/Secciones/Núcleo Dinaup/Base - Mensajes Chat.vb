Partial Public Class SeccionesD
  Public Class MensajesChatBaseD
      Public Shared _SeccionID As String = "39afbe41-66d1-4fca-8365-7b86ba9b42e2"
      Public Shared _SeccionIDGUID As New Guid("39afbe41-66d1-4fca-8365-7b86ba9b42e2")
      Public Class MensajesChatBaseES
          Public shared _SeccionID as Guid = New Guid("39afbe41-66d1-4fca-8365-7b86ba9b42e2")
          Public shared _Tabla$ = "tpr_4f133f0wc"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_1464b59f4dxbdwd"
      Public Shared FechaDato_UTC$ = "pr_14630fba5bx286wd"
      Public Shared ExportarEnModulos$ = "pr_14630fba5bg286wd"
      Public Shared FechaAlta_UTC$ = "pr_14c9f3d455g35bwd"
      Public Shared Mensaje$ = "pr_4f139a3x2ffwc"
      Public Shared ReferenciaAutorDelAlta$ = "pr_14630fb9d5h3d5wd"
      Public Shared ReferenciaChatSala$ = "pr_4f13d3fx139wc"
      Public Shared ReferenciaDestinador$ = "pr_14630fbafdg12dwd"
      Public Shared HoraLocal$ = "pr_776af28wd"
      Public Shared ReferenciaDatoAdjunto$ = "pr_72ede71wd"
      Public Shared Tipo$ = "pr_1a3d742384x22awd"
      Public Shared NombreArchivoDatoAdjunto$ = "pr_4f1404dx14bwc"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_146314ae2dh2cewd"
      Public Shared CRCArchivoObsoleto$ = "pr_4f13f34x195wc"
      Public Shared TamañoArchivoObsoleto$ = "pr_1a195a208cx20awd"
      Public Shared ReferenciaMensajeAnterior$ = "pr_4f13e9bx2a3wc"
      Public Shared MensajeOculto$ = "pr_4f140cbx31bwc"
      Public Shared ReferenciaSeccionAdjunta$ = "pr_72edd08wd"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_1464b3f3bbg94wd"
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
      Public Class MensajesChatBaseC
          Public EmpleadoTieneAccesoWeb As Boolean
          Public FechaDato_UTC As Date
          Public FechaAlta_UTC As Date
          Public Mensaje As String
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaChatSala As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public ReferenciaDatoAdjunto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Tipo As Integer
          Public NombreArchivoDatoAdjunto As String
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public CRCArchivoObsoleto As String
          Public TamañoArchivoObsoleto As Integer
          Public ReferenciaMensajeAnterior As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public MensajeOculto As Boolean
          Public ReferenciaSeccionAdjunta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
