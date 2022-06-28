Partial Public Class SeccionesD
  Public Class EmpleadosD
      Public Shared _SeccionID As String = "c6e071c7-776f-4300-aa55-c711fd1da916"
      Public Shared _SeccionIDGUID As New Guid("c6e071c7-776f-4300-aa55-c711fd1da916")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As Empleados_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, EmpleadosES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New Empleados_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As Empleados_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, EmpleadosES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New Empleados_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class EmpleadosES
          Public shared _SeccionID as Guid = New Guid("c6e071c7-776f-4300-aa55-c711fd1da916")
          Public shared _Tabla$ = "tpr_2c597b"
      Public Shared FechaDeNacimiento$ = "pr_2c619d"
      Public Shared ReferenciaFoto$ = "pr_5f05940d"
      Public Shared ReferenciaConfiguracion$ = "pr_74e2017wd"
      Public Shared EsAdministrador$ = "pr_2086n"
      Public Shared ReferenciaTurnoRealizandoObsoleto$ = "pr_1a0c0a5d3exb6wd"
      Public Shared ContraseñaObsoleto$ = "pr_14196n"
      Public Shared ReferenciaUbicacionDeConexionObsoleto$ = "pr_1556n"
      Public Shared IdentificadorAcceso$ = "pr_2bba690w12"
      Public Shared ReferenciaRol$ = "pr_74e2013wd"
      Public Shared Genero$ = "pr_7cb26aawd"
      Public Shared SesionIniciadaObsoleto$ = "pr_1a0c0d2c8cxc7wd"
      Public Shared ContraseñaAccesoSistema$ = "pr_3ffd627x9ewc"
      Public Shared FechaAlta_UTC$ = "pr_14c9f3ea9cg142wd"
      Public Shared ColorIdentificativo$ = "pr_7cb2816wd"
      Public Shared NIFObsoleto$ = "pr_2c5a37"
      Public Shared ReferenciaPuestoDeTrabajo$ = "pr_441e166x11awc"
      Public Shared EstadoCivil$ = "pr_5f0bfbe5"
      Public Shared PuedeConectarAWeb$ = "pr_3ffdcd7x257wc"
      Public Shared Observaciones$ = "pr_2c6251"
      Public Shared PuedeConectarAlSistema$ = "pr_3ffd9c7x2fbwc"
      Public Shared ReferenciaCargoEnEmpresa$ = "pr_158a16b75ax2d6wd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_1463105af0x146wd"
      Public Shared FinalizacionAutomaticaDeTurno$ = "pr_1877f447c7x225wd"
      Public Shared NombreDePila$ = "pr_17da7be832x2f2wd"
      Public Shared UltimaInicioDeSesionObsoleto_UTC$ = "pr_1a0c164351x1a7wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_14631496d2x222wd"
      Public Shared ReferenciaDestinador$ = "pr_1463105b91g1f2wd"
      Public Shared HoraLocal$ = "pr_776ae62wd"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_1464b42080x42wd"
      Public Shared AusenteDesdeObsoleto_UTC$ = "pr_1a0c0b9973xbewd"
      Public Shared PuedeVincularUnTerminal$ = "pr_184973f89cxfcwd"
      Public Shared PuedeConectarFueraDelHorario$ = "pr_18466e3993x3d7wd"
      Public Shared AusenteObsoleto$ = "pr_1a0c0b37ecx2d3wd"
      Public Shared Cliente$ = "pr_400401177028"
      Public Shared ImporteSaldoAcumulado$ = "pr_2c6229"
      Public Shared ReferenciaDatosFiscales$ = "pr_40040138793"
      Public Shared Becario$ = "pr_50040147492"
      Public Shared ImporteImportePorHoraExtraTurnosObsoleto$ = "pr_6004017153109"
      Public Shared ImporteDescuentoPorHoraAusenciasYRetrasosTurnosObsoleto$ = "pr_6004017153108"
      Public Shared MargenDeInicioDeTurno$ = "pr_60040210342"
      Public Shared MargenDeFinDeTurno$ = "pr_60040210341"
      Public Shared ImporteImporteHoraExtraTurnosExtrasObsoleto$ = "pr_20040210881"
      Public Shared ImporteImportePorHoraExtraDeFuerzaMayorTurnosExtrasObsoleto$ = "pr_30040210801"
      Public Shared ImporteImportePorHoraExtraDeFuerzaMayorTurnosObsoleto$ = "pr_50040211301"
      Public Shared AdaptarElImporteAPagarSegunElHorarioRealizadoTurnos$ = "pr_60040211302"
      Public Shared AdaptarElImporteAPagarSegunElHorarioRealizadoTurnosExtras$ = "pr_20040210883"
      Public Shared TiempoMinimoParaEvaluarTiempoTrabajadoDeMas$ = "pr_30040211304"
      Public Shared TiempoMinimoParaEvaluarTiempoTrabajadoDeMenos$ = "pr_30040211305"
      Public Shared RegistrarTurnosAutomaticamenteEnBaseAHorario$ = "pr_20040212062"
      Public Shared MotivoDeBloqueoAccesoWeb$ = "pr_10040218972"
      Public Shared ReferenciaServidor$ = "pr_20040212332"
      Public Shared EsAdministradorDeLaEmpresa$ = "pr_30040222581"
      Public Shared EsUnaEntidadJuridica$ = "pr_60040222581"
      Public Shared SolicitarCambioDeContraseñaAlIniciarSesion$ = "pr_30040419861"
      Public Shared ReferenciaCorreoDeEmpresa$ = "pr_60040164241"
      Public Shared CorreoDondeEnviarLasNotificaciones$ = "pr_50040260013"
      Public Shared FirmaDeCorreo$ = "pr_20040425825"
      Public Shared PuedeAdministrarTodasLasEmpresas$ = "pr_40040291891"
      Public Shared PuedeConectarATodasLasUbicaciones$ = "pr_20040480317"
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
      Public Class EmpleadosC
          Public FechaDeNacimiento As Date
          Public ReferenciaFoto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaConfiguracion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public EsAdministrador As Boolean
          Public ReferenciaTurnoRealizandoObsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ContraseñaObsoleto As String
          Public ReferenciaUbicacionDeConexionObsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public IdentificadorAcceso As String
          Public ReferenciaRol As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Genero As Integer
          Public SesionIniciadaObsoleto As Boolean
          Public ContraseñaAccesoSistema As String
          Public FechaAlta_UTC As Date
          Public ColorIdentificativo As String
          Public NIFObsoleto As String
          Public ReferenciaPuestoDeTrabajo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public EstadoCivil As String
          Public PuedeConectarAWeb As Boolean
          Public Observaciones As String
          Public PuedeConectarAlSistema As Boolean
          Public ReferenciaCargoEnEmpresa As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FinalizacionAutomaticaDeTurno As Boolean
          Public NombreDePila As String
          Public UltimaInicioDeSesionObsoleto_UTC As Date
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AusenteDesdeObsoleto_UTC As Date
          Public PuedeVincularUnTerminal As Boolean
          Public PuedeConectarFueraDelHorario As Boolean
          Public AusenteObsoleto As Boolean
          Public Cliente As Boolean
          Public ImporteSaldoAcumulado As Decimal
          Public ReferenciaDatosFiscales As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Becario As Boolean
          Public ImporteImportePorHoraExtraTurnosObsoleto As Decimal
          Public ImporteDescuentoPorHoraAusenciasYRetrasosTurnosObsoleto As Decimal
          Public MargenDeInicioDeTurno As Integer
          Public MargenDeFinDeTurno As Integer
          Public ImporteImporteHoraExtraTurnosExtrasObsoleto As Decimal
          Public ImporteImportePorHoraExtraDeFuerzaMayorTurnosExtrasObsoleto As Decimal
          Public ImporteImportePorHoraExtraDeFuerzaMayorTurnosObsoleto As Decimal
          Public AdaptarElImporteAPagarSegunElHorarioRealizadoTurnos As Boolean
          Public AdaptarElImporteAPagarSegunElHorarioRealizadoTurnosExtras As Boolean
          Public TiempoMinimoParaEvaluarTiempoTrabajadoDeMas As Decimal
          Public TiempoMinimoParaEvaluarTiempoTrabajadoDeMenos As Decimal
          Public RegistrarTurnosAutomaticamenteEnBaseAHorario As Boolean
          Public MotivoDeBloqueoAccesoWeb As String
          Public ReferenciaServidor As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public EsAdministradorDeLaEmpresa As Boolean
          Public EsUnaEntidadJuridica As Boolean
          Public SolicitarCambioDeContraseñaAlIniciarSesion As Boolean
          Public ReferenciaCorreoDeEmpresa As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public CorreoDondeEnviarLasNotificaciones As String
          Public FirmaDeCorreo As String
          Public PuedeAdministrarTodasLasEmpresas As Boolean
          Public PuedeConectarATodasLasUbicaciones As Boolean
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
      Public Class Empleados_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
          Public property FechaDeNacimiento As Date
            get
                return me.GetValue_Date("pr_2c619d")
            End Get
            Set(value As Date)
                me.SetValue_Date("pr_2c619d", value)
            End Set
          End Property
          Public property ReferenciaFoto As Guid
            get
                return me.GetValue_Guid("pr_5f05940d")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_5f05940d", value)
            End Set
          End Property
          Public property ReferenciaConfiguracion As Guid
            get
                return me.GetValue_Guid("pr_74e2017wd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_74e2017wd", value)
            End Set
          End Property
        Public ReadOnly property EsAdministrador As Boolean
            get
                return me.GetValue_Boolean("pr_2086n")
            End Get   
        End Property
        Public ReadOnly property ReferenciaTurnoRealizandoObsoleto As Guid
            get
                return me.GetValue_Guid("pr_1a0c0a5d3exb6wd")
            End Get   
        End Property
          Public property ContraseñaObsoleto As String
            get
                return me.GetValue_String("pr_14196n")
            End Get
            Set(value As String)
                me.SetValue_String("pr_14196n", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaUbicacionDeConexionObsoleto As Guid
            get
                return me.GetValue_Guid("pr_1556n")
            End Get   
        End Property
          Public property IdentificadorAcceso As String
            get
                return me.GetValue_String("pr_2bba690w12")
            End Get
            Set(value As String)
                me.SetValue_String("pr_2bba690w12", value)
            End Set
          End Property
          Public property ReferenciaRol As Guid
            get
                return me.GetValue_Guid("pr_74e2013wd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_74e2013wd", value)
            End Set
          End Property
          Public property Genero As Integer
            get
                return me.GetValue_Integer("pr_7cb26aawd")
            End Get
            Set(value As Integer)
                me.SetValue_Integer("pr_7cb26aawd", value)
            End Set
          End Property
        Public ReadOnly property SesionIniciadaObsoleto As Boolean
            get
                return me.GetValue_Boolean("pr_1a0c0d2c8cxc7wd")
            End Get   
        End Property
          Public property ContraseñaAccesoSistema As String
            get
                return me.GetValue_String("pr_3ffd627x9ewc")
            End Get
            Set(value As String)
                me.SetValue_String("pr_3ffd627x9ewc", value)
            End Set
          End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_14c9f3ea9cg142wd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_14c9f3ea9cg142wd", value)
            End Set
          End Property
          Public property ColorIdentificativo As String
            get
                return me.GetValue_String("pr_7cb2816wd")
            End Get
            Set(value As String)
                me.SetValue_String("pr_7cb2816wd", value)
            End Set
          End Property
          Public property NIFObsoleto As String
            get
                return me.GetValue_String("pr_2c5a37")
            End Get
            Set(value As String)
                me.SetValue_String("pr_2c5a37", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaPuestoDeTrabajo As Guid
            get
                return me.GetValue_Guid("pr_441e166x11awc")
            End Get   
        End Property
          Public property EstadoCivil As String
            get
                return me.GetValue_String("pr_5f0bfbe5")
            End Get
            Set(value As String)
                me.SetValue_String("pr_5f0bfbe5", value)
            End Set
          End Property
          Public property PuedeConectarAWeb As Boolean
            get
                return me.GetValue_Boolean("pr_3ffdcd7x257wc")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_3ffdcd7x257wc", value)
            End Set
          End Property
          Public property Observaciones As String
            get
                return me.GetValue_String("pr_2c6251")
            End Get
            Set(value As String)
                me.SetValue_String("pr_2c6251", value)
            End Set
          End Property
          Public property PuedeConectarAlSistema As Boolean
            get
                return me.GetValue_Boolean("pr_3ffd9c7x2fbwc")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_3ffd9c7x2fbwc", value)
            End Set
          End Property
          Public property ReferenciaCargoEnEmpresa As Guid
            get
                return me.GetValue_Guid("pr_158a16b75ax2d6wd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_158a16b75ax2d6wd", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_1463105af0x146wd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_1463105af0x146wd", value)
            End Set
          End Property
          Public property FinalizacionAutomaticaDeTurno As Boolean
            get
                return me.GetValue_Boolean("pr_1877f447c7x225wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_1877f447c7x225wd", value)
            End Set
          End Property
          Public property NombreDePila As String
            get
                return me.GetValue_String("pr_17da7be832x2f2wd")
            End Get
            Set(value As String)
                me.SetValue_String("pr_17da7be832x2f2wd", value)
            End Set
          End Property
        Public ReadOnly property UltimaInicioDeSesionObsoleto_UTC As Date
            get
                return me.GetValue_DateTime("pr_1a0c164351x1a7wd")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_14631496d2x222wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_14631496d2x222wd", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_1463105b91g1f2wd")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_776ae62wd")
            End Get   
        End Property
          Public property ReferenciaUbicacionPrincipal As Guid
            get
                return me.GetValue_Guid("pr_1464b42080x42wd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_1464b42080x42wd", value)
            End Set
          End Property
        Public ReadOnly property AusenteDesdeObsoleto_UTC As Date
            get
                return me.GetValue_DateTime("pr_1a0c0b9973xbewd")
            End Get   
        End Property
          Public property PuedeVincularUnTerminal As Boolean
            get
                return me.GetValue_Boolean("pr_184973f89cxfcwd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_184973f89cxfcwd", value)
            End Set
          End Property
          Public property PuedeConectarFueraDelHorario As Boolean
            get
                return me.GetValue_Boolean("pr_18466e3993x3d7wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_18466e3993x3d7wd", value)
            End Set
          End Property
        Public ReadOnly property AusenteObsoleto As Boolean
            get
                return me.GetValue_Boolean("pr_1a0c0b37ecx2d3wd")
            End Get   
        End Property
          Public property Cliente As Boolean
            get
                return me.GetValue_Boolean("pr_400401177028")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_400401177028", value)
            End Set
          End Property
        Public ReadOnly property ImporteSaldoAcumulado As Decimal
            get
                return me.GetValue_Decimal("pr_2c6229")
            End Get   
        End Property
          Public property ReferenciaDatosFiscales As Guid
            get
                return me.GetValue_Guid("pr_40040138793")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_40040138793", value)
            End Set
          End Property
          Public property Becario As Boolean
            get
                return me.GetValue_Boolean("pr_50040147492")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_50040147492", value)
            End Set
          End Property
          Public property ImporteImportePorHoraExtraTurnosObsoleto As Decimal
            get
                return me.GetValue_Decimal("pr_6004017153109")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_6004017153109", value)
            End Set
          End Property
          Public property ImporteDescuentoPorHoraAusenciasYRetrasosTurnosObsoleto As Decimal
            get
                return me.GetValue_Decimal("pr_6004017153108")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_6004017153108", value)
            End Set
          End Property
          Public property MargenDeInicioDeTurno As Integer
            get
                return me.GetValue_Integer("pr_60040210342")
            End Get
            Set(value As Integer)
                me.SetValue_Integer("pr_60040210342", value)
            End Set
          End Property
          Public property MargenDeFinDeTurno As Integer
            get
                return me.GetValue_Integer("pr_60040210341")
            End Get
            Set(value As Integer)
                me.SetValue_Integer("pr_60040210341", value)
            End Set
          End Property
          Public property ImporteImporteHoraExtraTurnosExtrasObsoleto As Decimal
            get
                return me.GetValue_Decimal("pr_20040210881")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_20040210881", value)
            End Set
          End Property
          Public property ImporteImportePorHoraExtraDeFuerzaMayorTurnosExtrasObsoleto As Decimal
            get
                return me.GetValue_Decimal("pr_30040210801")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_30040210801", value)
            End Set
          End Property
          Public property ImporteImportePorHoraExtraDeFuerzaMayorTurnosObsoleto As Decimal
            get
                return me.GetValue_Decimal("pr_50040211301")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_50040211301", value)
            End Set
          End Property
          Public property AdaptarElImporteAPagarSegunElHorarioRealizadoTurnos As Boolean
            get
                return me.GetValue_Boolean("pr_60040211302")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_60040211302", value)
            End Set
          End Property
          Public property AdaptarElImporteAPagarSegunElHorarioRealizadoTurnosExtras As Boolean
            get
                return me.GetValue_Boolean("pr_20040210883")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_20040210883", value)
            End Set
          End Property
          Public property TiempoMinimoParaEvaluarTiempoTrabajadoDeMas As Decimal
            get
                return me.GetValue_Decimal("pr_30040211304")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_30040211304", value)
            End Set
          End Property
          Public property TiempoMinimoParaEvaluarTiempoTrabajadoDeMenos As Decimal
            get
                return me.GetValue_Decimal("pr_30040211305")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_30040211305", value)
            End Set
          End Property
        Public ReadOnly property RegistrarTurnosAutomaticamenteEnBaseAHorario As Boolean
            get
                return me.GetValue_Boolean("pr_20040212062")
            End Get   
        End Property
          Public property MotivoDeBloqueoAccesoWeb As String
            get
                return me.GetValue_String("pr_10040218972")
            End Get
            Set(value As String)
                me.SetValue_String("pr_10040218972", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaServidor As Guid
            get
                return me.GetValue_Guid("pr_20040212332")
            End Get   
        End Property
          Public property EsAdministradorDeLaEmpresa As Boolean
            get
                return me.GetValue_Boolean("pr_30040222581")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_30040222581", value)
            End Set
          End Property
          Public property EsUnaEntidadJuridica As Boolean
            get
                return me.GetValue_Boolean("pr_60040222581")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_60040222581", value)
            End Set
          End Property
          Public property SolicitarCambioDeContraseñaAlIniciarSesion As Boolean
            get
                return me.GetValue_Boolean("pr_30040419861")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_30040419861", value)
            End Set
          End Property
          Public property ReferenciaCorreoDeEmpresa As Guid
            get
                return me.GetValue_Guid("pr_60040164241")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_60040164241", value)
            End Set
          End Property
          Public property CorreoDondeEnviarLasNotificaciones As String
            get
                return me.GetValue_String("pr_50040260013")
            End Get
            Set(value As String)
                me.SetValue_String("pr_50040260013", value)
            End Set
          End Property
          Public property FirmaDeCorreo As String
            get
                return me.GetValue_String("pr_20040425825")
            End Get
            Set(value As String)
                me.SetValue_String("pr_20040425825", value)
            End Set
          End Property
          Public property PuedeAdministrarTodasLasEmpresas As Boolean
            get
                return me.GetValue_Boolean("pr_40040291891")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_40040291891", value)
            End Set
          End Property
          Public property PuedeConectarATodasLasUbicaciones As Boolean
            get
                return me.GetValue_Boolean("pr_20040480317")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_20040480317", value)
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
