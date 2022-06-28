Partial Public Class SeccionesD
  Public Class TurnosDeTrabajoD
      Public Shared _SeccionID As String = "4709d046-d1c5-49bd-a76b-768c9acc1ceb"
      Public Shared _SeccionIDGUID As New Guid("4709d046-d1c5-49bd-a76b-768c9acc1ceb")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As TurnosDeTrabajo_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, TurnosDeTrabajoES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New TurnosDeTrabajo_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As TurnosDeTrabajo_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, TurnosDeTrabajoES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New TurnosDeTrabajo_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class TurnosDeTrabajoES
          Public shared _SeccionID as Guid = New Guid("4709d046-d1c5-49bd-a76b-768c9acc1ceb")
          Public shared _Tabla$ = "tpr_63e63f9xd"
      Public Shared MinutosRetrasoSalida$ = "pr_1863ea67cbx217wd"
      Public Shared ControlesPresencialesObsoleto$ = "pr_186415015fx7dwd"
      Public Shared HoraLocal$ = "pr_776ae16wd"
      Public Shared ReferenciaDestinador$ = "pr_1863b69bc5x86wd"
      Public Shared ReferenciaAsignacionDeHorario$ = "pr_30040103156"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_1863c96f56x31dwd"
      Public Shared RegistrosVisitados$ = "pr_1864133a72x194wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_1863c09a8ax1b5wd"
      Public Shared MinutosConSesionActiva$ = "pr_1873d23d48x3e4wd"
      Public Shared RegistrosEliminados$ = "pr_186415d176xccwd"
      Public Shared InformesVisualizados$ = "pr_186410cfabx328wd"
      Public Shared ReferenciaJornada$ = "pr_30040103153"
      Public Shared SesionesIniciadas$ = "pr_1864145b2axeawd"
      Public Shared HoraEnLaQueFinalizo_UTC$ = "pr_1863d56b05x327wd"
      Public Shared ReferenciaUltimoControlPresencialDeLaRealizacionObsoleto$ = "pr_1863f72522xd7wd"
      Public Shared MinutosRetrasoEntrada$ = "pr_1863e9ef8dx221wd"
      Public Shared HoraProgramadaDeFin_UTC$ = "pr_1863d05476x6awd"
      Public Shared RegistrosRestaurados$ = "pr_1864168675x2a5wd"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_1863c96f39x2awd"
      Public Shared RealizacionAgregadaAutomaticamente$ = "pr_18756c9ac6x85wd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_1863ca986fx36cwd"
      Public Shared RegistrosModificados$ = "pr_186412b750x102wd"
      Public Shared FechaAlta_UTC$ = "pr_1863b69b89x23ewd"
      Public Shared ReferenciaMotivoDeLaRealizacionObsoleto$ = "pr_50040112221"
      Public Shared RealizacionEnMinutos$ = "pr_1863e95bdfx236wd"
      Public Shared FechaDato_UTC$ = "pr_1863c96f6bx340wd"
      Public Shared ReferenciaHorario$ = "pr_1863d10038x3ccwd"
      Public Shared HoraEnLaQueInicio_UTC$ = "pr_1863d4dfc1x28ewd"
      Public Shared ReferenciaPrimerControlPresencialDeLaRealizacionObsoleto$ = "pr_1863f6083fx36wd"
      Public Shared MinutosExtrasTrabajados$ = "pr_1864ee2a65xfawd"
      Public Shared DuracionTurnoEnMinutos$ = "pr_1863e88aa5x128wd"
      Public Shared RegistrosAgregados$ = "pr_186411ab2dx4dwd"
      Public Shared ReferenciaTurnoDeJornada$ = "pr_30040103154"
      Public Shared EstadoDeLaRealizacion$ = "pr_30040103561"
      Public Shared ReferenciaAutorDelAlta$ = "pr_1863b69b6ex213wd"
      Public Shared HoraProgramadaDeInicio_UTC$ = "pr_1863cf7342x2cfwd"
      Public Shared ReferenciaTurnoDeHorario$ = "pr_1863d18f7bx1e7wd"
      Public Shared Observaciones$ = "pr_20040138403"
      Public Shared TotalHorasExtraEnNominaEnMinutos$ = "pr_30040139131"
      Public Shared ImporteImportePorHoraRealizadaFueraDeHorario$ = "pr_30040139132"
      Public Shared FechaDeRealizacion$ = "pr_10040139141"
      Public Shared ImporteImportePorHoraNoRealizadaDentroDeHorario$ = "pr_20040138406"
      Public Shared RealizacionConcluida$ = "pr_40040209613"
      Public Shared MargenDeInicioDeTurno$ = "pr_50040210385"
      Public Shared FechaMaximaDeFinDeTurno_UTC$ = "pr_60040210381"
      Public Shared MargenDeFinDeTurno$ = "pr_50040210384"
      Public Shared FechaMinimaDeInicioDeTurno_UTC$ = "pr_60040210382"
      Public Shared EsDeFuerzaMayor$ = "pr_20040138404"
      Public Shared AdaptarElImporteAPagarSegunElHorarioRealizado$ = "pr_10040139172"
      Public Shared TotalHorasRealizadasDeMenosEnNominaEnMinutos$ = "pr_50040211101"
      Public Shared ImporteImporteDeduccionPorHorasNoRealizadas$ = "pr_60040211101"
      Public Shared TiempoMinimoParaEvaluarTiempoTrabajadoDeMenos$ = "pr_30040211303"
      Public Shared TiempoMinimoParaEvaluarTiempoTrabajadoDeMas$ = "pr_30040211302"
      Public Shared ImporteImporteTotalDevengoPorHorasExtra$ = "pr_60040211102"
      Public Shared TipoDeTurno$ = "pr_40040210832"
      Public Shared ReferenciaMotivoAusenciaORetraso$ = "pr_30040212244"
      Public Shared ReferenciaMotivoHorasExtra$ = "pr_30040212245"
      Public Shared ReferenciaPrimerInicioDeSesion$ = "pr_10040243741"
      Public Shared ReferenciaUltimoCierreDeSesion$ = "pr_30040243742"
      Public Shared DescripcionCorta$ = "pr_10040256424"
      Public Shared ModoDeCotizacion$ = "pr_20040360102"
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
      Public Class TurnosDeTrabajoC
          Public MinutosRetrasoSalida As Integer
          Public ControlesPresencialesObsoleto As Integer
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaAsignacionDeHorario As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public RegistrosVisitados As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public MinutosConSesionActiva As Integer
          Public RegistrosEliminados As Integer
          Public InformesVisualizados As Integer
          Public ReferenciaJornada As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public SesionesIniciadas As Integer
          Public HoraEnLaQueFinalizo_UTC As Date
          Public ReferenciaUltimoControlPresencialDeLaRealizacionObsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public MinutosRetrasoEntrada As Integer
          Public HoraProgramadaDeFin_UTC As Date
          Public RegistrosRestaurados As Integer
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public RealizacionAgregadaAutomaticamente As Boolean
          Public EmpleadoTieneAccesoWeb As Boolean
          Public RegistrosModificados As Integer
          Public FechaAlta_UTC As Date
          Public ReferenciaMotivoDeLaRealizacionObsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public RealizacionEnMinutos As Integer
          Public FechaDato_UTC As Date
          Public ReferenciaHorario As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraEnLaQueInicio_UTC As Date
          Public ReferenciaPrimerControlPresencialDeLaRealizacionObsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public MinutosExtrasTrabajados As Integer
          Public DuracionTurnoEnMinutos As Integer
          Public RegistrosAgregados As Integer
          Public ReferenciaTurnoDeJornada As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public EstadoDeLaRealizacion As Integer
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraProgramadaDeInicio_UTC As Date
          Public ReferenciaTurnoDeHorario As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Observaciones As String
          Public TotalHorasExtraEnNominaEnMinutos As Decimal
          Public ImporteImportePorHoraRealizadaFueraDeHorario As Decimal
          Public FechaDeRealizacion As Date
          Public ImporteImportePorHoraNoRealizadaDentroDeHorario As Decimal
          Public RealizacionConcluida As Boolean
          Public MargenDeInicioDeTurno As Integer
          Public FechaMaximaDeFinDeTurno_UTC As Date
          Public MargenDeFinDeTurno As Integer
          Public FechaMinimaDeInicioDeTurno_UTC As Date
          Public EsDeFuerzaMayor As Boolean
          Public AdaptarElImporteAPagarSegunElHorarioRealizado As Boolean
          Public TotalHorasRealizadasDeMenosEnNominaEnMinutos As Decimal
          Public ImporteImporteDeduccionPorHorasNoRealizadas As Decimal
          Public TiempoMinimoParaEvaluarTiempoTrabajadoDeMenos As Decimal
          Public TiempoMinimoParaEvaluarTiempoTrabajadoDeMas As Decimal
          Public ImporteImporteTotalDevengoPorHorasExtra As Decimal
          Public TipoDeTurno As Integer
          Public ReferenciaMotivoAusenciaORetraso As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaMotivoHorasExtra As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaPrimerInicioDeSesion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaUltimoCierreDeSesion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public DescripcionCorta As String
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
      Public Class TurnosDeTrabajo_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
        Public ReadOnly property MinutosRetrasoSalida As Integer
            get
                return me.GetValue_Integer("pr_1863ea67cbx217wd")
            End Get   
        End Property
        Public ReadOnly property ControlesPresencialesObsoleto As Integer
            get
                return me.GetValue_Integer("pr_186415015fx7dwd")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_776ae16wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_1863b69bc5x86wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaAsignacionDeHorario As Guid
            get
                return me.GetValue_Guid("pr_30040103156")
            End Get   
        End Property
        Public ReadOnly property ReferenciaUbicacionPrincipal As Guid
            get
                return me.GetValue_Guid("pr_1863c96f56x31dwd")
            End Get   
        End Property
        Public ReadOnly property RegistrosVisitados As Integer
            get
                return me.GetValue_Integer("pr_1864133a72x194wd")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_1863c09a8ax1b5wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_1863c09a8ax1b5wd", value)
            End Set
          End Property
        Public ReadOnly property MinutosConSesionActiva As Integer
            get
                return me.GetValue_Integer("pr_1873d23d48x3e4wd")
            End Get   
        End Property
        Public ReadOnly property RegistrosEliminados As Integer
            get
                return me.GetValue_Integer("pr_186415d176xccwd")
            End Get   
        End Property
        Public ReadOnly property InformesVisualizados As Integer
            get
                return me.GetValue_Integer("pr_186410cfabx328wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaJornada As Guid
            get
                return me.GetValue_Guid("pr_30040103153")
            End Get   
        End Property
        Public ReadOnly property SesionesIniciadas As Integer
            get
                return me.GetValue_Integer("pr_1864145b2axeawd")
            End Get   
        End Property
          Public property HoraEnLaQueFinalizo_UTC As Date
            get
                return me.GetValue_DateTime("pr_1863d56b05x327wd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_1863d56b05x327wd", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaUltimoControlPresencialDeLaRealizacionObsoleto As Guid
            get
                return me.GetValue_Guid("pr_1863f72522xd7wd")
            End Get   
        End Property
        Public ReadOnly property MinutosRetrasoEntrada As Integer
            get
                return me.GetValue_Integer("pr_1863e9ef8dx221wd")
            End Get   
        End Property
          Public property HoraProgramadaDeFin_UTC As Date
            get
                return me.GetValue_DateTime("pr_1863d05476x6awd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_1863d05476x6awd", value)
            End Set
          End Property
        Public ReadOnly property RegistrosRestaurados As Integer
            get
                return me.GetValue_Integer("pr_1864168675x2a5wd")
            End Get   
        End Property
          Public property ReferenciaEmpleadoPrincipal As Guid
            get
                return me.GetValue_Guid("pr_1863c96f39x2awd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_1863c96f39x2awd", value)
            End Set
          End Property
          Public property RealizacionAgregadaAutomaticamente As Boolean
            get
                return me.GetValue_Boolean("pr_18756c9ac6x85wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_18756c9ac6x85wd", value)
            End Set
          End Property
          Public property EmpleadoTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_1863ca986fx36cwd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_1863ca986fx36cwd", value)
            End Set
          End Property
        Public ReadOnly property RegistrosModificados As Integer
            get
                return me.GetValue_Integer("pr_186412b750x102wd")
            End Get   
        End Property
        Public ReadOnly property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_1863b69b89x23ewd")
            End Get   
        End Property
          Public property ReferenciaMotivoDeLaRealizacionObsoleto As Guid
            get
                return me.GetValue_Guid("pr_50040112221")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_50040112221", value)
            End Set
          End Property
        Public ReadOnly property RealizacionEnMinutos As Integer
            get
                return me.GetValue_Integer("pr_1863e95bdfx236wd")
            End Get   
        End Property
          Public property FechaDato_UTC As Date
            get
                return me.GetValue_DateTime("pr_1863c96f6bx340wd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_1863c96f6bx340wd", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaHorario As Guid
            get
                return me.GetValue_Guid("pr_1863d10038x3ccwd")
            End Get   
        End Property
          Public property HoraEnLaQueInicio_UTC As Date
            get
                return me.GetValue_DateTime("pr_1863d4dfc1x28ewd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_1863d4dfc1x28ewd", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaPrimerControlPresencialDeLaRealizacionObsoleto As Guid
            get
                return me.GetValue_Guid("pr_1863f6083fx36wd")
            End Get   
        End Property
        Public ReadOnly property MinutosExtrasTrabajados As Integer
            get
                return me.GetValue_Integer("pr_1864ee2a65xfawd")
            End Get   
        End Property
        Public ReadOnly property DuracionTurnoEnMinutos As Integer
            get
                return me.GetValue_Integer("pr_1863e88aa5x128wd")
            End Get   
        End Property
        Public ReadOnly property RegistrosAgregados As Integer
            get
                return me.GetValue_Integer("pr_186411ab2dx4dwd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaTurnoDeJornada As Guid
            get
                return me.GetValue_Guid("pr_30040103154")
            End Get   
        End Property
          Public property EstadoDeLaRealizacion As Integer
            get
                return me.GetValue_Integer("pr_30040103561")
            End Get
            Set(value As Integer)
                me.SetValue_Integer("pr_30040103561", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_1863b69b6ex213wd")
            End Get   
        End Property
          Public property HoraProgramadaDeInicio_UTC As Date
            get
                return me.GetValue_DateTime("pr_1863cf7342x2cfwd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_1863cf7342x2cfwd", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaTurnoDeHorario As Guid
            get
                return me.GetValue_Guid("pr_1863d18f7bx1e7wd")
            End Get   
        End Property
          Public property Observaciones As String
            get
                return me.GetValue_String("pr_20040138403")
            End Get
            Set(value As String)
                me.SetValue_String("pr_20040138403", value)
            End Set
          End Property
        Public ReadOnly property TotalHorasExtraEnNominaEnMinutos As Decimal
            get
                return me.GetValue_Decimal("pr_30040139131")
            End Get   
        End Property
          Public property ImporteImportePorHoraRealizadaFueraDeHorario As Decimal
            get
                return me.GetValue_Decimal("pr_30040139132")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_30040139132", value)
            End Set
          End Property
        Public ReadOnly property FechaDeRealizacion As Date
            get
                return me.GetValue_Date("pr_10040139141")
            End Get   
        End Property
          Public property ImporteImportePorHoraNoRealizadaDentroDeHorario As Decimal
            get
                return me.GetValue_Decimal("pr_20040138406")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_20040138406", value)
            End Set
          End Property
          Public property RealizacionConcluida As Boolean
            get
                return me.GetValue_Boolean("pr_40040209613")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_40040209613", value)
            End Set
          End Property
          Public property MargenDeInicioDeTurno As Integer
            get
                return me.GetValue_Integer("pr_50040210385")
            End Get
            Set(value As Integer)
                me.SetValue_Integer("pr_50040210385", value)
            End Set
          End Property
        Public ReadOnly property FechaMaximaDeFinDeTurno_UTC As Date
            get
                return me.GetValue_DateTime("pr_60040210381")
            End Get   
        End Property
          Public property MargenDeFinDeTurno As Integer
            get
                return me.GetValue_Integer("pr_50040210384")
            End Get
            Set(value As Integer)
                me.SetValue_Integer("pr_50040210384", value)
            End Set
          End Property
        Public ReadOnly property FechaMinimaDeInicioDeTurno_UTC As Date
            get
                return me.GetValue_DateTime("pr_60040210382")
            End Get   
        End Property
          Public property EsDeFuerzaMayor As Boolean
            get
                return me.GetValue_Boolean("pr_20040138404")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_20040138404", value)
            End Set
          End Property
          Public property AdaptarElImporteAPagarSegunElHorarioRealizado As Boolean
            get
                return me.GetValue_Boolean("pr_10040139172")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_10040139172", value)
            End Set
          End Property
        Public ReadOnly property TotalHorasRealizadasDeMenosEnNominaEnMinutos As Decimal
            get
                return me.GetValue_Decimal("pr_50040211101")
            End Get   
        End Property
        Public ReadOnly property ImporteImporteDeduccionPorHorasNoRealizadas As Decimal
            get
                return me.GetValue_Decimal("pr_60040211101")
            End Get   
        End Property
          Public property TiempoMinimoParaEvaluarTiempoTrabajadoDeMenos As Decimal
            get
                return me.GetValue_Decimal("pr_30040211303")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_30040211303", value)
            End Set
          End Property
          Public property TiempoMinimoParaEvaluarTiempoTrabajadoDeMas As Decimal
            get
                return me.GetValue_Decimal("pr_30040211302")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_30040211302", value)
            End Set
          End Property
        Public ReadOnly property ImporteImporteTotalDevengoPorHorasExtra As Decimal
            get
                return me.GetValue_Decimal("pr_60040211102")
            End Get   
        End Property
          Public property TipoDeTurno As Integer
            get
                return me.GetValue_Integer("pr_40040210832")
            End Get
            Set(value As Integer)
                me.SetValue_Integer("pr_40040210832", value)
            End Set
          End Property
          Public property ReferenciaMotivoAusenciaORetraso As Guid
            get
                return me.GetValue_Guid("pr_30040212244")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_30040212244", value)
            End Set
          End Property
          Public property ReferenciaMotivoHorasExtra As Guid
            get
                return me.GetValue_Guid("pr_30040212245")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_30040212245", value)
            End Set
          End Property
          Public property ReferenciaPrimerInicioDeSesion As Guid
            get
                return me.GetValue_Guid("pr_10040243741")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_10040243741", value)
            End Set
          End Property
          Public property ReferenciaUltimoCierreDeSesion As Guid
            get
                return me.GetValue_Guid("pr_30040243742")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_30040243742", value)
            End Set
          End Property
          Public property DescripcionCorta As String
            get
                return me.GetValue_String("pr_10040256424")
            End Get
            Set(value As String)
                me.SetValue_String("pr_10040256424", value)
            End Set
          End Property
          Public property ModoDeCotizacion As Integer
            get
                return me.GetValue_Integer("pr_20040360102")
            End Get
            Set(value As Integer)
                me.SetValue_Integer("pr_20040360102", value)
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
