Partial Public Class SeccionesD
  Public Class EmpresasAdministradasD
      Public Shared _SeccionID As String = "8bcba7c2-11b2-4f81-a7a7-35f65de8aa51"
      Public Shared _SeccionIDGUID As New Guid("8bcba7c2-11b2-4f81-a7a7-35f65de8aa51")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As EmpresasAdministradas_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, EmpresasAdministradasES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New EmpresasAdministradas_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As EmpresasAdministradas_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, EmpresasAdministradasES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New EmpresasAdministradas_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class EmpresasAdministradasES
          Public shared _SeccionID as Guid = New Guid("8bcba7c2-11b2-4f81-a7a7-35f65de8aa51")
          Public shared _Tabla$ = "tpr_30040180812"
      Public Shared RegistroMercantilDe$ = "pr_50040185685"
      Public Shared ExportarEnModulos$ = "pr_30040180811013"
      Public Shared ReferenciaDestinador$ = "pr_30040180811015"
      Public Shared FechaAlta_UTC$ = "pr_30040180811014"
      Public Shared HoraLocal$ = "pr_30040180811012"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_30040180811021"
      Public Shared ReferenciaAutorDelAlta$ = "pr_30040180811010"
      Public Shared ReferenciaLogoSobreBlanco$ = "pr_40040180811"
      Public Shared ReferenciaLogoSobreNegro$ = "pr_40040180812"
      Public Shared PaginaWeb$ = "pr_50040180811"
      Public Shared EmpresaPrincipal$ = "pr_60040180813"
      Public Shared Color$ = "pr_60040181031"
      Public Shared Archivar$ = "pr_40040183201"
      Public Shared DomicilioDireccionObsoleto$ = "pr_40040185681001"
      Public Shared MovilObsoleto$ = "pr_40040185681004"
      Public Shared CodigoPostalObsoleto$ = "pr_40040185681006"
      Public Shared RegistroMercantilInscripcion$ = "pr_50040185681"
      Public Shared DenominacionSocialObsoleto$ = "pr_50040185688"
      Public Shared PuertaObsoleto$ = "pr_40040185681007"
      Public Shared RegistroMercantilHoja$ = "pr_50040185683"
      Public Shared RegistroMercantilTomo$ = "pr_50040185684"
      Public Shared TelefonoObsoleto$ = "pr_40040185681002"
      Public Shared FaxObsoleto$ = "pr_40040185681003"
      Public Shared RegistroMercantilFolio$ = "pr_50040185682"
      Public Shared NIFObsoleto$ = "pr_50040185686"
      Public Shared NombreComercialObsoleto$ = "pr_50040185687"
      Public Shared PisoObsoleto$ = "pr_40040185681008"
      Public Shared EscaleraObsoleto$ = "pr_40040185681009"
      Public Shared ProvinciaObsoleto$ = "pr_40040185681005"
      Public Shared NumeroObsoleto$ = "pr_40040185681010"
      Public Shared MunicipioObsoleto$ = "pr_500401856810"
      Public Shared MargenMinutosDeFinalizacionDeHorarioSalidaParaNuevosEmpleados$ = "pr_50040210308"
      Public Shared MargenMinutosDeInicioDeHorarioEntradaParaNuevosEmpleados$ = "pr_50040210307"
      Public Shared ALosNuevosEmpleadosSeLesCerraraAutomaticamenteElSistemaCuandoFinaliceSuHorario$ = "pr_50040210306"
      Public Shared LosNuevosEmpleadosPodranConectarFueraDeHorario$ = "pr_50040210305"
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
      Public Shared IdentificadorAcceso$ = "pr_40040332032"
      Public Shared Notas$ = "pr_40040291744"
      Public Shared ColorMarca$ = "pr_40040291743"
      Public Shared TodosLosEmpleadosTienenAcceso$ = "pr_30040291894"
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
      Public Class EmpresasAdministradasC
          Public RegistroMercantilDe As String
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaLogoSobreBlanco As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaLogoSobreNegro As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public PaginaWeb As String
          Public EmpresaPrincipal As Boolean
          Public Color As String
          Public Archivar As Boolean
          Public DomicilioDireccionObsoleto As String
          Public MovilObsoleto As String
          Public CodigoPostalObsoleto As String
          Public RegistroMercantilInscripcion As String
          Public DenominacionSocialObsoleto As String
          Public PuertaObsoleto As String
          Public RegistroMercantilHoja As String
          Public RegistroMercantilTomo As String
          Public TelefonoObsoleto As String
          Public FaxObsoleto As String
          Public RegistroMercantilFolio As String
          Public NIFObsoleto As String
          Public NombreComercialObsoleto As String
          Public PisoObsoleto As String
          Public EscaleraObsoleto As String
          Public ProvinciaObsoleto As String
          Public NumeroObsoleto As String
          Public MunicipioObsoleto As String
          Public MargenMinutosDeFinalizacionDeHorarioSalidaParaNuevosEmpleados As Integer
          Public MargenMinutosDeInicioDeHorarioEntradaParaNuevosEmpleados As Integer
          Public ALosNuevosEmpleadosSeLesCerraraAutomaticamenteElSistemaCuandoFinaliceSuHorario As Boolean
          Public LosNuevosEmpleadosPodranConectarFueraDeHorario As Boolean
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
          Public IdentificadorAcceso As String
          Public Notas As String
          Public ColorMarca As String
          Public TodosLosEmpleadosTienenAcceso As Boolean
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
      Public Class EmpresasAdministradas_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
          Public property RegistroMercantilDe As String
            get
                return me.GetValue_String("pr_50040185685")
            End Get
            Set(value As String)
                me.SetValue_String("pr_50040185685", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_30040180811015")
            End Get   
        End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_30040180811014")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_30040180811014", value)
            End Set
          End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_30040180811012")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_30040180811021")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_30040180811021", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_30040180811010")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_30040180811010", value)
            End Set
          End Property
          Public property ReferenciaLogoSobreBlanco As Guid
            get
                return me.GetValue_Guid("pr_40040180811")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_40040180811", value)
            End Set
          End Property
          Public property ReferenciaLogoSobreNegro As Guid
            get
                return me.GetValue_Guid("pr_40040180812")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_40040180812", value)
            End Set
          End Property
          Public property PaginaWeb As String
            get
                return me.GetValue_String("pr_50040180811")
            End Get
            Set(value As String)
                me.SetValue_String("pr_50040180811", value)
            End Set
          End Property
        Public ReadOnly property EmpresaPrincipal As Boolean
            get
                return me.GetValue_Boolean("pr_60040180813")
            End Get   
        End Property
          Public property Color As String
            get
                return me.GetValue_String("pr_60040181031")
            End Get
            Set(value As String)
                me.SetValue_String("pr_60040181031", value)
            End Set
          End Property
          Public property Archivar As Boolean
            get
                return me.GetValue_Boolean("pr_40040183201")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_40040183201", value)
            End Set
          End Property
          Public property DomicilioDireccionObsoleto As String
            get
                return me.GetValue_String("pr_40040185681001")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040185681001", value)
            End Set
          End Property
          Public property MovilObsoleto As String
            get
                return me.GetValue_String("pr_40040185681004")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040185681004", value)
            End Set
          End Property
          Public property CodigoPostalObsoleto As String
            get
                return me.GetValue_String("pr_40040185681006")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040185681006", value)
            End Set
          End Property
          Public property RegistroMercantilInscripcion As String
            get
                return me.GetValue_String("pr_50040185681")
            End Get
            Set(value As String)
                me.SetValue_String("pr_50040185681", value)
            End Set
          End Property
          Public property DenominacionSocialObsoleto As String
            get
                return me.GetValue_String("pr_50040185688")
            End Get
            Set(value As String)
                me.SetValue_String("pr_50040185688", value)
            End Set
          End Property
          Public property PuertaObsoleto As String
            get
                return me.GetValue_String("pr_40040185681007")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040185681007", value)
            End Set
          End Property
          Public property RegistroMercantilHoja As String
            get
                return me.GetValue_String("pr_50040185683")
            End Get
            Set(value As String)
                me.SetValue_String("pr_50040185683", value)
            End Set
          End Property
          Public property RegistroMercantilTomo As String
            get
                return me.GetValue_String("pr_50040185684")
            End Get
            Set(value As String)
                me.SetValue_String("pr_50040185684", value)
            End Set
          End Property
          Public property TelefonoObsoleto As String
            get
                return me.GetValue_String("pr_40040185681002")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040185681002", value)
            End Set
          End Property
          Public property FaxObsoleto As String
            get
                return me.GetValue_String("pr_40040185681003")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040185681003", value)
            End Set
          End Property
          Public property RegistroMercantilFolio As String
            get
                return me.GetValue_String("pr_50040185682")
            End Get
            Set(value As String)
                me.SetValue_String("pr_50040185682", value)
            End Set
          End Property
          Public property NIFObsoleto As String
            get
                return me.GetValue_String("pr_50040185686")
            End Get
            Set(value As String)
                me.SetValue_String("pr_50040185686", value)
            End Set
          End Property
          Public property NombreComercialObsoleto As String
            get
                return me.GetValue_String("pr_50040185687")
            End Get
            Set(value As String)
                me.SetValue_String("pr_50040185687", value)
            End Set
          End Property
          Public property PisoObsoleto As String
            get
                return me.GetValue_String("pr_40040185681008")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040185681008", value)
            End Set
          End Property
          Public property EscaleraObsoleto As String
            get
                return me.GetValue_String("pr_40040185681009")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040185681009", value)
            End Set
          End Property
          Public property ProvinciaObsoleto As String
            get
                return me.GetValue_String("pr_40040185681005")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040185681005", value)
            End Set
          End Property
          Public property NumeroObsoleto As String
            get
                return me.GetValue_String("pr_40040185681010")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040185681010", value)
            End Set
          End Property
          Public property MunicipioObsoleto As String
            get
                return me.GetValue_String("pr_500401856810")
            End Get
            Set(value As String)
                me.SetValue_String("pr_500401856810", value)
            End Set
          End Property
          Public property MargenMinutosDeFinalizacionDeHorarioSalidaParaNuevosEmpleados As Integer
            get
                return me.GetValue_Integer("pr_50040210308")
            End Get
            Set(value As Integer)
                me.SetValue_Integer("pr_50040210308", value)
            End Set
          End Property
          Public property MargenMinutosDeInicioDeHorarioEntradaParaNuevosEmpleados As Integer
            get
                return me.GetValue_Integer("pr_50040210307")
            End Get
            Set(value As Integer)
                me.SetValue_Integer("pr_50040210307", value)
            End Set
          End Property
          Public property ALosNuevosEmpleadosSeLesCerraraAutomaticamenteElSistemaCuandoFinaliceSuHorario As Boolean
            get
                return me.GetValue_Boolean("pr_50040210306")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_50040210306", value)
            End Set
          End Property
          Public property LosNuevosEmpleadosPodranConectarFueraDeHorario As Boolean
            get
                return me.GetValue_Boolean("pr_50040210305")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_50040210305", value)
            End Set
          End Property
          Public property TiempoMinimoParaEvaluarTiempoTrabajadoDeMenos As Decimal
            get
                return me.GetValue_Decimal("pr_30040211996")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_30040211996", value)
            End Set
          End Property
          Public property TiempoMinimoParaEvaluarTiempoTrabajadoDeMas As Decimal
            get
                return me.GetValue_Decimal("pr_30040211997")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_30040211997", value)
            End Set
          End Property
          Public property RegistrarTurnosAutomaticamenteEnBaseAHorario As Boolean
            get
                return me.GetValue_Boolean("pr_30040212061")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_30040212061", value)
            End Set
          End Property
          Public property CPlazaAvdaObsoleto As String
            get
                return me.GetValue_String("pr_40040220651")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040220651", value)
            End Set
          End Property
          Public property ReferenciaDatosFiscales As Guid
            get
                return me.GetValue_Guid("pr_40040242242")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_40040242242", value)
            End Set
          End Property
          Public property RegistroMercantilLibro As String
            get
                return me.GetValue_String("pr_60040269564")
            End Get
            Set(value As String)
                me.SetValue_String("pr_60040269564", value)
            End Set
          End Property
          Public property RegistroMercantilSeccion As String
            get
                return me.GetValue_String("pr_60040269565")
            End Get
            Set(value As String)
                me.SetValue_String("pr_60040269565", value)
            End Set
          End Property
          Public property ContraseñaDeProteccionParaLasCopiasDeSeguridad As String
            get
                return me.GetValue_String("pr_50040276295")
            End Get
            Set(value As String)
                me.SetValue_String("pr_50040276295", value)
            End Set
          End Property
          Public property FechaDeRenovacionDeCertificadoDeContraseña As Date
            get
                return me.GetValue_Date("pr_60040276291")
            End Get
            Set(value As Date)
                me.SetValue_Date("pr_60040276291", value)
            End Set
          End Property
          Public property NInscripcionSS As String
            get
                return me.GetValue_String("pr_20040278023")
            End Get
            Set(value As String)
                me.SetValue_String("pr_20040278023", value)
            End Set
          End Property
          Public property IdentificadorAcceso As String
            get
                return me.GetValue_String("pr_40040332032")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040332032", value)
            End Set
          End Property
          Public property Notas As String
            get
                return me.GetValue_String("pr_40040291744")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040291744", value)
            End Set
          End Property
          Public property ColorMarca As String
            get
                return me.GetValue_String("pr_40040291743")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040291743", value)
            End Set
          End Property
          Public property TodosLosEmpleadosTienenAcceso As Boolean
            get
                return me.GetValue_Boolean("pr_30040291894")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_30040291894", value)
            End Set
          End Property
          Public property ReferenciaCorreoUtilizadoParaAvisoDeNotificaciones As Guid
            get
                return me.GetValue_Guid("pr_50040260011")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_50040260011", value)
            End Set
          End Property
        Public ReadOnly property ID As Guid
            get
                return me.GetValue_Guid("id")
            End Get   
        End Property
          Public property TextoPrincipal As String
            get
                return me.GetValue_String("nombre")
            End Get
            Set(value As String)
                me.SetValue_String("nombre", value)
            End Set
          End Property
        Public ReadOnly property FechaAltaDato_UTC As Date
            get
                return me.GetValue_DateTime("fecha")
            End Get   
        End Property
        Public ReadOnly property FechaUltimaModificacion_UTC As Date
            get
                return me.GetValue_DateTime("fecham")
            End Get   
        End Property
        Public ReadOnly property Eliminado As Boolean
            get
                return me.GetValue_Boolean("eliminado")
            End Get   
        End Property
        Public ReadOnly property UsuarioCreadorDelDAto As Guid
            get
                return me.GetValue_Guid("usuarioid")
            End Get   
        End Property
          Public property Seccion As Guid
            get
                return me.GetValue_Guid("plantillapid")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("plantillapid", value)
            End Set
          End Property
          Public property Posicion As Integer
            get
                return me.GetValue_Integer("posicion")
            End Get
            Set(value As Integer)
                me.SetValue_Integer("posicion", value)
            End Set
          End Property
        Public ReadOnly property Empresa As Guid
            get
                return me.GetValue_Guid("ubicacion")
            End Get   
        End Property
        Public ReadOnly property Modificado As Boolean
            get
                return me.GetValue_Boolean("modificado")
            End Get   
        End Property
        Public ReadOnly property FechaIndiceActividad_UTC As Date
            get
                return me.GetValue_DateTime("fechaia")
            End Get   
        End Property
        Public ReadOnly property Fechadesincronizacion_UTC As Date
            get
                return me.GetValue_DateTime("fechasyn")
            End Get   
        End Property
          Sub New(___VV__ As DinaNETCore.API_VVC , _Token$)
              MyBase.New(___VV__, _Token) 
              Me.Evento_Actualizar()
          End Sub
      End Class
  End Class
End Class
