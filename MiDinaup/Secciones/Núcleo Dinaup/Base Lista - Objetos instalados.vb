Partial Public Class SeccionesD
  Public Class ObjetosInstaladosBaseListaD
      Public Shared _SeccionID As String = "4a46529b-29d3-404f-a0e3-dc403ebfd55c"
      Public Shared _SeccionIDGUID As New Guid("4a46529b-29d3-404f-a0e3-dc403ebfd55c")
      Public Class ObjetosInstaladosBaseListaES
          Public shared _SeccionID as Guid = New Guid("4a46529b-29d3-404f-a0e3-dc403ebfd55c")
          Public shared _Tabla$ = "tpr_20040198072_e"
      Public Shared HoraLocal$ = "pr_200401980748"
      Public Shared ReferenciaDestinador$ = "pr_200401980750"
      Public Shared FechaDato_UTC$ = "pr_200401980747"
      Public Shared ReferenciaAutorDelAlta$ = "pr_200401980746"
      Public Shared FechaAlta_UTC$ = "pr_200401980749"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_200401980751"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_200401980752"
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
      Public Class ObjetosInstaladosBaseListaC
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaDato_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public AutorDelAltaTieneAccesoWeb As Boolean
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
