Partial Public Class SeccionesD
  Public Class EmpresasAdministradasBaseD
      Public Shared _SeccionID As String = "9d1bb1b3-06e1-425b-bd5a-1d03bae37094"
      Public Shared _SeccionIDGUID As New Guid("9d1bb1b3-06e1-425b-bd5a-1d03bae37094")
      Public Class EmpresasAdministradasBaseES
          Public shared _SeccionID as Guid = New Guid("9d1bb1b3-06e1-425b-bd5a-1d03bae37094")
          Public shared _Tabla$ = "tpr_30040180812"
      Public Shared ExportarEnModulos$ = "pr_30040180811013"
      Public Shared FechaAlta_UTC$ = "pr_30040180811014"
      Public Shared ReferenciaAutorDelAlta$ = "pr_30040180811010"
      Public Shared ReferenciaDestinador$ = "pr_30040180811015"
      Public Shared HoraLocal$ = "pr_30040180811012"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_30040180811021"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_30040180811022"
      Public Shared ReferenciaLogoSobreBlanco$ = "pr_40040180811"
      Public Shared ReferenciaLogoSobreNegro$ = "pr_40040180812"
      Public Shared PaginaWeb$ = "pr_50040180811"
      Public Shared EmpresaPrincipal$ = "pr_60040180813"
      Public Shared Color$ = "pr_60040181031"
      Public Shared Archivar$ = "pr_40040183201"
      Public Shared DomicilioDireccionObsoleto$ = "pr_40040185681001"
      Public Shared TelefonoObsoleto$ = "pr_40040185681002"
      Public Shared FaxObsoleto$ = "pr_40040185681003"
      Public Shared MovilObsoleto$ = "pr_40040185681004"
      Public Shared ProvinciaObsoleto$ = "pr_40040185681005"
      Public Shared CodigoPostalObsoleto$ = "pr_40040185681006"
      Public Shared RegistroMercantilInscripcion$ = "pr_50040185681"
      Public Shared DenominacionSocialObsoleto$ = "pr_50040185688"
      Public Shared PuertaObsoleto$ = "pr_40040185681007"
      Public Shared PisoObsoleto$ = "pr_40040185681008"
      Public Shared EscaleraObsoleto$ = "pr_40040185681009"
      Public Shared NumeroObsoleto$ = "pr_40040185681010"
      Public Shared RegistroMercantilFolio$ = "pr_50040185682"
      Public Shared RegistroMercantilHoja$ = "pr_50040185683"
      Public Shared RegistroMercantilTomo$ = "pr_50040185684"
      Public Shared RegistroMercantilDe$ = "pr_50040185685"
      Public Shared NIFObsoleto$ = "pr_50040185686"
      Public Shared NombreComercialObsoleto$ = "pr_50040185687"
      Public Shared MunicipioObsoleto$ = "pr_500401856810"
      Public Shared LosNuevosEmpleadosPodranConectarFueraDeHorario$ = "pr_50040210305"
      Public Shared ALosNuevosEmpleadosSeLesCerraraAutomaticamenteElSistemaCuandoFinaliceSuHorario$ = "pr_50040210306"
      Public Shared MargenMinutosDeInicioDeHorarioEntradaParaNuevosEmpleados$ = "pr_50040210307"
      Public Shared MargenMinutosDeFinalizacionDeHorarioSalidaParaNuevosEmpleados$ = "pr_50040210308"
      Public Shared TiempoMinimoParaEvaluarTiempoTrabajadoDeMenos$ = "pr_30040211996"
      Public Shared TiempoMinimoParaEvaluarTiempoTrabajadoDeMas$ = "pr_30040211997"
      Public Shared RegistrarTurnosAutomaticamenteEnBaseAHorario$ = "pr_30040212061"
      Public Shared CPlazaAvdaObsoleto$ = "pr_40040220651"
      Public Shared ReferenciaDatosFiscales$ = "pr_40040242242"
      Public Shared RegistroMercantilLibro$ = "pr_60040269564"
      Public Shared RegistroMercantilSeccion$ = "pr_60040269565"
      Public Shared ContraseñaDeProteccionParaLasCopiasDeSeguridad$ = "pr_50040276295"
      Public Shared FechaDeRenovacionDeCertificadoDeContraseña$ = "pr_60040276291"
      Public Shared NInscripcionSS$ = "pr_20040278023"
      Public Shared Notas$ = "pr_40040291744"
      Public Shared ColorMarca$ = "pr_40040291743"
      Public Shared TodosLosEmpleadosTienenAcceso$ = "pr_30040291894"
      Public Shared IdentificadorAcceso$ = "pr_40040332032"
      Public Shared ReferenciaCorreoUtilizadoParaAvisoDeNotificaciones$ = "pr_50040260011"
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
      Public Class EmpresasAdministradasBaseC
          Public FechaAlta_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public EmpleadoTieneAccesoWeb As Boolean
          Public ReferenciaLogoSobreBlanco As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaLogoSobreNegro As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public PaginaWeb As String
          Public EmpresaPrincipal As Boolean
          Public Color As String
          Public Archivar As Boolean
          Public DomicilioDireccionObsoleto As String
          Public TelefonoObsoleto As String
          Public FaxObsoleto As String
          Public MovilObsoleto As String
          Public ProvinciaObsoleto As String
          Public CodigoPostalObsoleto As String
          Public RegistroMercantilInscripcion As String
          Public DenominacionSocialObsoleto As String
          Public PuertaObsoleto As String
          Public PisoObsoleto As String
          Public EscaleraObsoleto As String
          Public NumeroObsoleto As String
          Public RegistroMercantilFolio As String
          Public RegistroMercantilHoja As String
          Public RegistroMercantilTomo As String
          Public RegistroMercantilDe As String
          Public NIFObsoleto As String
          Public NombreComercialObsoleto As String
          Public MunicipioObsoleto As String
          Public LosNuevosEmpleadosPodranConectarFueraDeHorario As Boolean
          Public ALosNuevosEmpleadosSeLesCerraraAutomaticamenteElSistemaCuandoFinaliceSuHorario As Boolean
          Public MargenMinutosDeInicioDeHorarioEntradaParaNuevosEmpleados As Integer
          Public MargenMinutosDeFinalizacionDeHorarioSalidaParaNuevosEmpleados As Integer
          Public TiempoMinimoParaEvaluarTiempoTrabajadoDeMenos As Decimal
          Public TiempoMinimoParaEvaluarTiempoTrabajadoDeMas As Decimal
          Public RegistrarTurnosAutomaticamenteEnBaseAHorario As Boolean
          Public CPlazaAvdaObsoleto As String
          Public ReferenciaDatosFiscales As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public RegistroMercantilLibro As String
          Public RegistroMercantilSeccion As String
          Public ContraseñaDeProteccionParaLasCopiasDeSeguridad As String
          Public FechaDeRenovacionDeCertificadoDeContraseña As Date
          Public NInscripcionSS As String
          Public Notas As String
          Public ColorMarca As String
          Public TodosLosEmpleadosTienenAcceso As Boolean
          Public IdentificadorAcceso As String
          Public ReferenciaCorreoUtilizadoParaAvisoDeNotificaciones As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
