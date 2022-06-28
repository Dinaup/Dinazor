Partial Public Class SeccionesD
  Public Class AnotacionesInternasBaseD
      Public Shared _SeccionID As String = "4c77852d-c0ae-46ad-92be-39d1ee01567b"
      Public Shared _SeccionIDGUID As New Guid("4c77852d-c0ae-46ad-92be-39d1ee01567b")
      Public Class AnotacionesInternasBaseES
          Public shared _SeccionID as Guid = New Guid("4c77852d-c0ae-46ad-92be-39d1ee01567b")
          Public shared _Tabla$ = "tpr_72cffdfxd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_72d0013wd"
      Public Shared Comentario$ = "pr_72ed0f9wd"
      Public Shared ReferenciaSeccionOrigenDeAnotacion$ = "pr_72fa89bwd"
      Public Shared FechaDato_UTC$ = "pr_72d0017wd"
      Public Shared ExportarEnModulos$ = "pr_72d001bwd"
      Public Shared FechaAlta_UTC$ = "pr_72d0023wd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_72d003fwd"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_72d000bwd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_72d0043wd"
      Public Shared ReferenciaDatoOrigenDeAnotacion$ = "pr_72fa897wd"
      Public Shared HoraLocal$ = "pr_77611e8wd"
      Public Shared ReferenciaDestinador$ = "pr_72d002fwd"
      Public Shared MostrarEnDocumentacion$ = "pr_60040161126"
      Public Shared MostrarComoComentario$ = "pr_20040161137"
      Public Shared GaleriaDeFotos$ = "pr_400404794517"
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
      Public Class AnotacionesInternasBaseC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Comentario As String
          Public ReferenciaSeccionOrigenDeAnotacion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaDato_UTC As Date
          Public FechaAlta_UTC As Date
          Public EmpleadoTieneAccesoWeb As Boolean
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaDatoOrigenDeAnotacion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public MostrarEnDocumentacion As Boolean
          Public MostrarComoComentario As Boolean
          Public GaleriaDeFotos As Boolean
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
