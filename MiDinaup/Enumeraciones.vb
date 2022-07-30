Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Reflection
Imports DinaNetCore.ExtensionesM
Public Enum EnumEventoAgendaE
   <Description("Indefinido")>
   Indefinido = 0
   <Description("Modificado")>
   Modificado = 1
   <Description("Agregado")>
   Agregado = 2
   <Description("Eliminado")>
   Eliminado = 3
   <Description("Restaurado")>
   Restaurado = 4
   <Description("Constante")>
   Constante = 5
   <Description("Agregar/Modificar")>
   AgregarModificar = 6
End enum
Public Enum EnumChatTipoMensajeE
   <Description("Indefinido")>
   Indefinido = 0
   <Description("Ordinario")>
   Ordinario = 1
   <Description("Ahora es participante")>
   AhoraEsParticipante = 2
   <Description("Ya no es participante")>
   YaNoEsParticipante = 3
   <Description("Titulo Cambiado")>
   TituloCambiado = 4
   <Description("Foto cambiada")>
   FotoCambiada = 5
End enum
Public Enum EnumTipoDeRealizacionDeTurnoE
   <Description("Indefinido")>
   Indefinido = 0
   <Description("Ausencia")>
   Ausencia = 1
   <Description("Presente")>
   Presente = 2
   <Description("Cancelada")>
   Cancelada = 3
   <Description("Programada")>
   Programada = 4
   <Description("En curso")>
   EnCurso = 5
   <Description("Esperando inicio")>
   EsperandoInicio = 6
End enum
Public Enum EnumTipoDeTurnoE
   <Description("Indefinido")>
   Indefinido = 0
   <Description("H. Ordinarias")>
   HOrdinarias = 1
   <Description("H. Extra")>
   HExtra = 2
   <Description("H. Complementarias")>
   HComplementarias = 3
End enum
Public Enum EnumCotizacionAusenciaE
   <Description("")>
   Indefinido = 0
   <Description("No cotiza")>
   NoCotiza = 1
   <Description("Cotiza base mes anterior")>
   CotizaBaseMesAnterior = 2
   <Description("Cotiza base mínima")>
   CotizaBaseMinima = 3
   <Description("Cotización exclusiva empresarial")>
   CotizacionExclusivaEmpresarial = 4
End enum
Public Enum EnumRAArchivoE
   <Description("Indefinido")>
   Indefinido = 0
   <Description("Subido")>
   Subido = 1
   <Description("Descargado")>
   Descargado = 2
   <Description("Subida interrumpida")>
   SubidaInterrumpida = 3
   <Description("Descarga interrumpida")>
   DescargaInterrumpida = 4
   <Description("Visualización")>
   Visualizacion = 5
   <Description("Vista previa")>
   VistaPrevia = 6
   <Description("Actualización")>
   Actualizacion = 7
   <Description("Actualización interrumpida")>
   ActualizacionInterrumpida = 8
End enum
Public Enum EnumGeneroE
   <Description("Indefinido")>
   Indefinido = 0
   <Description("Masculino")>
   Masculino = 1
   <Description("Femenino")>
   Femenino = 2
End enum
Public Enum EnumConfiguracionImpuestosIncluidosE
   <Description("Automático")>
   Automatico = 0
   <Description("Incluidos")>
   Incluidos = 1
   <Description("No incluidos")>
   NoIncluidos = 2
End enum
Public Enum EnumCriterioEvaluacionAgendaE
   <Description("Indefinido")>
   Indefinido = 0
   <Description("No evaluable")>
   NoEvaluable = 1
   <Description("Evaluar")>
   Evaluar = 2
End enum
Public Enum EnumSCDCarenciaE
   <Description("Indefinido")>
   Indefinido = 0
   <Description("Revisando")>
   Revisando = 1
   <Description("ReSincronizado")>
   ReSincronizado = 2
   <Description("Descartada")>
   Descartada = 3
End enum
Public Enum EnumSCDRegistroE
   <Description("Indefinido")>
   Indefinido = 0
   <Description("Revisando")>
   Revisando = 1
   <Description("Descartada")>
   Descartada = 2
   <Description("Reparada")>
   Reparada = 3
End enum
Public Enum EnumDiaDeLaSemanaE
   <Description("Indefinido")>
   Indefinido = 0
   <Description("Lunes")>
   Lunes = 1
   <Description("Martes")>
   Martes = 2
   <Description("Miércoles")>
   Miercoles = 3
   <Description("Jueves")>
   Jueves = 4
   <Description("Viernes")>
   Viernes = 5
   <Description("Sábado")>
   Sabado = 6
   <Description("Domingo")>
   Domingo = 7
End enum
Public Enum EnumRAPrincipalE
   <Description("Indefinido")>
   Indefinido = 0
   <Description("Agregar")>
   Agregar = 1
   <Description("Ver")>
   Ver = 2
   <Description("Editar")>
   Editar = 3
   <Description("No agregado")>
   NoAgregado = 4
   <Description("Contraseña Incorrecta")>
   ContraseñaIncorrecta = 5
End enum
Public Enum EnumALogAccesoE
   <Description("Indefinido")>
   Indefinido = 0
   <Description("Inicio fallido de sesión")>
   InicioFallidoDeSesion = 1
   <Description("Inicio de Sesión correcto")>
   InicioDeSesionCorrecto = 2
   <Description("Cierre de sesión")>
   CierreDeSesion = 3
   <Description("_Inicio de turno")>
   InicioDeTurno = 4
   <Description("_Cierre de turno")>
   CierreDeTurno = 5
End enum
Public Enum EnumAControlDePresenciaE
   <Description("Indefinido")>
   Indefinido = 0
   <Description("Inicio")>
   Inicio = 1
   <Description("Fin")>
   Fin = 2
   <Description("Fin automático")>
   FinAutomatico = 3
End enum
Public Enum EnumRAAccionPapeleraE
   <Description("Indefinido")>
   Indefinido = 0
   <Description("Eliminar")>
   Eliminar = 1
   <Description("Restaurar")>
   Restaurar = 2
End enum
Public Enum EnumTipoIdentificacionFiscalE
   <Description("")>
   Indefinido = 0
   <Description("DNI")>
   DNI = 1
   <Description("K. Españoles menores de 14 años que carezcan de DNI")>
   KEspañolesMenoresDe14AñosQueCarezcanDeDNI = 2
   <Description("L. Españoles mayores de 14 años residentes en el extranjero y que no tengan DNI que se trasladan a España por un tiempo inferior a seis meses")>
   LEspañolesMayoresDe14AñosResidentesEnElExtranjeroYQueNoTenganDNIQueSeTrasladanAEspañaPorUnTiempoInferiorASeisMeses = 3
   <Description("M. Extranjeros sin NIE, de forma transitoria por estar obligados a tenerlo o bien de forma definitiva al no estar obligados a ello")>
   MExtranjerosSinNIEDeFormaTransitoriaPorEstarObligadosATenerloOBienDeFormaDefinitivaAlNoEstarObligadosAEllo = 4
   <Description("X. Extranjeros residentes en España e identificados por la Policía con un número de identidad de extranjero (NIE), asignado hasta el 15 de julio de 2008. ")>
   XExtranjerosResidentesEnEspañaEIdentificadosPorLaPoliciaConUnNumeroDeIdentidadDeExtranjeroNIEAsignadoHastaEl15DeJulioDe2008 = 5
   <Description("Y. Extranjeros residentes en España e identificados por la Policía con un NIE")>
   YExtranjerosResidentesEnEspañaEIdentificadosPorLaPoliciaConUnNIE = 6
   <Description("Z. Letra reservada para Extranjeros identificados por la Policía, para cuando se agoten los 'NIE Y'")>
   ZLetraReservadaParaExtranjerosIdentificadosPorLaPoliciaParaCuandoSeAgotenLosNIEY = 7
   <Description("A. Sociedades anónimas")>
   ASociedadesAnonimas = 8
   <Description("B. Sociedades de responsabilidad limitada")>
   BSociedadesDeResponsabilidadLimitada = 9
   <Description("C. Sociedades colectivas")>
   CSociedadesColectivas = 10
   <Description("D. Sociedades comanditarias")>
   DSociedadesComanditarias = 11
   <Description("E. Comunidades de bienes")>
   EComunidadesDeBienes = 12
   <Description("F. Sociedades cooperativas")>
   FSociedadesCooperativas = 13
   <Description("G. Asociaciones y Fundaciones")>
   GAsociacionesYFundaciones = 14
   <Description("H. Comunidades de propietarios en régimen de propiedad horizontal")>
   HComunidadesDePropietariosEnRegimenDePropiedadHorizontal = 15
   <Description("J. Sociedades civiles, con o sin personalidad jurídica")>
   JSociedadesCivilesConOSinPersonalidadJuridica = 16
   <Description("N. Entidades extranjeras")>
   NEntidadesExtranjeras = 17
   <Description("P. Corporaciones Locales")>
   PCorporacionesLocales = 18
   <Description("Q. Organismos públicos")>
   QOrganismosPublicos = 19
   <Description("R. Congregaciones e instituciones religiosas")>
   RCongregacionesEInstitucionesReligiosas = 20
   <Description("S. Órganos de la Administración General del Estado y de las Comunidades Autónomas")>
   SOrganosDeLaAdministracionGeneralDelEstadoYDeLasComunidadesAutonomas = 21
   <Description("U. Uniones Temporales de Empresas")>
   UUnionesTemporalesDeEmpresas = 22
   <Description("V. Otros tipos no definidos en el resto de claves")>
   VOtrosTiposNoDefinidosEnElRestoDeClaves = 23
   <Description("W. Establecimientos permanentes de entidades no residentes en España")>
   WEstablecimientosPermanentesDeEntidadesNoResidentesEnEspaña = 24
End enum
Public Enum EnumTipoDeAusenciaLaboralEE
   <Description("")>
   Indefinido = 0
   <Description("No laboral")>
   NoLaboral = 1
   <Description("Ausencia")>
   Ausencia = 2
End enum
Public Enum EnumTipoDeDocumentoE
   <Description("Indefinido")>
   Indefinido = 0
   <Description("Balance")>
   Balance = 1
   <Description("Modelo")>
   Modelo = 2
End enum
Public Enum EnumTipoBackUpEE
   <Description("")>
   Indefinido = 0
   <Description("Cambio de versión")>
   CambioDeVersion = 1
   <Description("Instalación de módulos")>
   InstalacionDeModulos = 2
   <Description("Puntual")>
   Puntual = 3
   <Description("Programada")>
   Programada = 4
End enum
Public Enum EnumEstilosTextoEE
   <Description("")>
   Indefinido = 0
   <Description("Estilo 1")>
   Estilo1 = 1
   <Description("Estilo 2")>
   Estilo2 = 2
   <Description("Estilo 3")>
   Estilo3 = 3
   <Description("Estilo 4")>
   Estilo4 = 4
   <Description("Estilo 5")>
   Estilo5 = 5
   <Description("Estilo 6")>
   Estilo6 = 6
   <Description("Estilo 7")>
   Estilo7 = 7
   <Description("Estilo 8")>
   Estilo8 = 8
   <Description("Estilo 9")>
   Estilo9 = 9
   <Description("Estilo 10")>
   Estilo10 = 10
   <Description("Estilo 11")>
   Estilo11 = 11
   <Description("Estilo 12")>
   Estilo12 = 12
   <Description("Estilo 13")>
   Estilo13 = 13
   <Description("Estilo 14")>
   Estilo14 = 14
   <Description("Estilo 15")>
   Estilo15 = 15
   <Description("Estilo 16")>
   Estilo16 = 16
   <Description("Estilo 17")>
   Estilo17 = 17
   <Description("Estilo 18")>
   Estilo18 = 18
   <Description("Estilo 19")>
   Estilo19 = 19
   <Description("Estilo 20")>
   Estilo20 = 20
End enum
Public Enum TipoJSONE
   <Description("Indefinido")>
   Indefinido = 0
   <Description("Detalles")>
   Detalles = 1
   <Description("Agregar")>
   Agregar = 2
   <Description("Editar")>
   Editar = 3
   <Description("Listar")>
   Listar = 4
   <Description("Informe")>
   Informe = 5
End enum
Public Enum EnumMesE
   <Description("Indefinido")>
   Indefinido = 0
   <Description("Enero")>
   Enero = 1
   <Description("Febrero")>
   Febrero = 2
   <Description("Marzo")>
   Marzo = 3
   <Description("Abril")>
   Abril = 4
   <Description("Mayo")>
   Mayo = 5
   <Description("Junio")>
   Junio = 6
   <Description("Julio")>
   Julio = 7
   <Description("Agosto")>
   Agosto = 8
   <Description("Septiembre")>
   Septiembre = 9
   <Description("Octubre")>
   Octubre = 10
   <Description("Noviembre")>
   Noviembre = 11
   <Description("Diciembre")>
   Diciembre = 12
End enum
Public Enum EnumTramitacionE
   <Description("Indefinido")>
   Indefinido = 0
   <Description("Pendiente")>
   Pendiente = 1
   <Description("Tramitado")>
   Tramitado = 2
   <Description("Cancelado")>
   Cancelado = 3
End enum
Public Enum EnumTipoServicioDeCorreoE
   <Description("")>
   Indefinido = 0
   <Description("SMTP")>
   SMTP = 1
   <Description("Gmail")>
   Gmail = 2
End enum
Public Enum EnumCorreoEntranteSalienteE
   <Description("Indefinido")>
   Indefinido = 0
   <Description("Entrante")>
   Entrante = 1
   <Description("Saliente")>
   Saliente = 2
End enum
Public Enum EnumEstadoDeTramiteE
   <Description("Indefinido")>
   Indefinido = 0
   <Description("Pendiente")>
   Pendiente = 1
   <Description("Tramitado")>
   Tramitado = 2
   <Description("Cancelado")>
   Cancelado = 3
End enum
Public Enum EnumAsistenciaAReunionE
   <Description("")>
   Indefinido = 0
   <Description("Tarde")>
   Tarde = 1
   <Description("Ausente")>
   Ausente = 2
   <Description("Presente")>
   Presente = 3
End enum
Public Enum EnumEstadoPuntoATratarE
   <Description("Indefinido")>
   Indefinido = 0
   <Description("Pendiente")>
   Pendiente = 1
   <Description("Tratado")>
   Tratado = 2
   <Description("Cancelado")>
   Cancelado = 3
   <Description("Aplazado")>
   Aplazado = 4
End enum
Public Enum PrioridadE
   <Description("Indefinido")>
   Indefinido = 0
   <Description("Muy Baja")>
   MuyBaja = 1
   <Description("Baja")>
   Baja = 2
   <Description("Normal")>
   Normal = 3
   <Description("Alta")>
   Alta = 4
   <Description("Muy alta")>
   MuyAlta = 6
   <Description("Urgente")>
   Urgente = 7
End enum
Public Enum EnumTipoMovimientoE
   <Description("Indefinido")>
   Indefinido = 0
   <Description("Ordinario")>
   Ordinario = 1
   <Description("Rectificativo")>
   Rectificativo = 3
End enum
Public Enum EnumEstadoTransporteE
   <Description("Indefinido")>
   Indefinido = 0
   <Description("Programado")>
   Programado = 1
   <Description("Transportando")>
   Transportando = 2
   <Description("Completado")>
   Completado = 3
   <Description("Cancelado")>
   Cancelado = 4
   <Description("Incidencia")>
   Incidencia = 5
End enum
Public Enum EnumAsientoE
   <Description("Indefinido")>
   Indefinido = 0
   <Description("Operativo")>
   Operativo = 1
   <Description("Ajuste")>
   Ajuste = 2
   <Description("Apertura")>
   Apertura = 3
   <Description("Regularización")>
   Regularizacion = 4
   <Description("Cierre")>
   Cierre = 5
End enum
Public Enum EnumNivelCuentaContableE
   <Description("Indefinido")>
   Indefinido = 0
   <Description("Grupo nivel 1")>
   GrupoNivel1 = 1
   <Description("(x) Subgrupo nivel 2")>
   xSubgrupoNivel2 = 2
   <Description("(x) Subgrupo nivel 3")>
   xSubgrupoNivel3 = 3
   <Description("Cuenta")>
   Cuenta = 4
   <Description("(x) Subcuenta 1")>
   xSubcuenta1 = 5
   <Description("(x) Subcuenta 2")>
   xSubcuenta2 = 6
   <Description("Subcuenta")>
   Subcuenta = 7
End enum
Public Enum EnumNaturalezaDeCuentaE
   <Description("Indefinido")>
   Indefinido = 0
   <Description("Deudora")>
   Deudora = 1
   <Description("Acreedora")>
   Acreedora = 2
End enum
Public Enum EnumInmovilizadoEstadoAdquisicionEE
   <Description("")>
   Indefinido = 0
   <Description("Nuevo")>
   Nuevo = 1
   <Description("Usado")>
   Usado = 2
End enum
Public Enum EnumInmovilizadoNaturalezaEE
   <Description("")>
   Indefinido = 0
   <Description("Inmovilizado Material")>
   InmovilizadoMaterial = 1
   <Description("Inmovilizado Intangible")>
   InmovilizadoIntangible = 2
   <Description("Inversión Inmobiliaria")>
   InversionInmobiliaria = 3
End enum
Public Enum EnumIntervaloContablePeriodosE
   <Description("Indefinido")>
   Indefinido = 0
   <Description("Año")>
   Año = 1
   <Description("Mes 1")>
   Mes1 = 2
   <Description("Mes 2")>
   Mes2 = 3
   <Description("Mes 3")>
   Mes3 = 4
   <Description("Mes 4")>
   Mes4 = 5
   <Description("Mes 5")>
   Mes5 = 6
   <Description("Mes 6")>
   Mes6 = 7
   <Description("Mes 7")>
   Mes7 = 8
   <Description("Mes 8")>
   Mes8 = 9
   <Description("Mes 9")>
   Mes9 = 10
   <Description("Mes 10")>
   Mes10 = 11
   <Description("Mes 11")>
   Mes11 = 12
   <Description("Mes 12")>
   Mes12 = 13
   <Description("Bimestre 1")>
   Bimestre1 = 14
   <Description("Bimestre 2")>
   Bimestre2 = 15
   <Description("Bimestre 3")>
   Bimestre3 = 16
   <Description("Bimestre 4")>
   Bimestre4 = 17
   <Description("Bimestre 5")>
   Bimestre5 = 18
   <Description("Bimestre 6")>
   Bimestre6 = 19
   <Description("Trimestre 1")>
   Trimestre1 = 20
   <Description("Trimestre 2")>
   Trimestre2 = 21
   <Description("Trimestre 3")>
   Trimestre3 = 22
   <Description("Trimestre 4")>
   Trimestre4 = 23
   <Description("Semestre 1")>
   Semestre1 = 24
   <Description("Semestre 2")>
   Semestre2 = 25
End enum
Public Enum EnumIntervaloContableE
   <Description("Indefinido")>
   Indefinido = 0
   <Description("Mes completo")>
   MesCompleto = 1
   <Description("Bimestre completo")>
   BimestreCompleto = 2
   <Description("Trimestre completo")>
   TrimestreCompleto = 3
   <Description("Semestre completo")>
   SemestreCompleto = 4
   <Description("Año completo")>
   AñoCompleto = 5
   <Description("Mes 1")>
   Mes1 = 6
   <Description("Mes 2")>
   Mes2 = 7
   <Description("Mes 3")>
   Mes3 = 8
   <Description("Mes 4")>
   Mes4 = 9
   <Description("Mes 5")>
   Mes5 = 10
   <Description("Mes 6")>
   Mes6 = 11
   <Description("Mes 7")>
   Mes7 = 12
   <Description("Mes 8")>
   Mes8 = 13
   <Description("Mes 9")>
   Mes9 = 14
   <Description("Mes 10")>
   Mes10 = 15
   <Description("Mes 11")>
   Mes11 = 16
   <Description("Mes 12")>
   Mes12 = 17
   <Description("Bimestre 1")>
   Bimestre1 = 18
   <Description("Bimestre 2")>
   Bimestre2 = 19
   <Description("Bimestre 3")>
   Bimestre3 = 20
   <Description("Bimestre 4")>
   Bimestre4 = 21
   <Description("Bimestre 5")>
   Bimestre5 = 22
   <Description("Bimestre 6")>
   Bimestre6 = 23
   <Description("Trimestre 1")>
   Trimestre1 = 24
   <Description("Trimestre 2")>
   Trimestre2 = 25
   <Description("Trimestre 3")>
   Trimestre3 = 26
   <Description("Trimestre 4")>
   Trimestre4 = 27
   <Description("Intervalo preguntado")>
   IntervaloPreguntado = 28
   <Description("Semestre 2")>
   Semestre2 = 29
   <Description("Semestre 1")>
   Semestre1 = 30
End enum
Public Enum EnumTipoActividadE
   <Description("")>
   Indefinido = 0
   <Description("Empresarial")>
   Empresarial = 1
   <Description("Profesional")>
   Profesional = 2
   <Description("Agrícola")>
   Agricola = 3
End enum
Public Module Ext
  <Extension>
    Public Function STR(v As EnumEventoAgendaE) As String
        Return GetEnumDescription(v)
    End Function

    <Extension>
    Public Function INT(v As EnumEventoAgendaE) As Integer
        Return CInt(v)
    End Function
      
    
    <Extension>
    Public Function AdaptarMySQL_Integer(v As EnumEventoAgendaE) As String
        Return CInt(v).ToString()
    End Function

        
    <Extension>
    Public Function AdaptarMySQL_EnumEventoAgendaE(v As EnumEventoAgendaE) As String
        Return CInt(v).ToString()
    End Function

    
    
    <Extension>
    Public Function Leer_EnumEventoAgendaE(ElSTR As Dic(Of String, String), key$) As EnumEventoAgendaE
        Return Ctype( ElSTR.HacerMagia(key).int(0),  EnumEventoAgendaE)
    End Function



  <Extension>
    Public Function STR(v As EnumChatTipoMensajeE) As String
        Return GetEnumDescription(v)
    End Function

    <Extension>
    Public Function INT(v As EnumChatTipoMensajeE) As Integer
        Return CInt(v)
    End Function
      
    
    <Extension>
    Public Function AdaptarMySQL_Integer(v As EnumChatTipoMensajeE) As String
        Return CInt(v).ToString()
    End Function

        
    <Extension>
    Public Function AdaptarMySQL_EnumChatTipoMensajeE(v As EnumChatTipoMensajeE) As String
        Return CInt(v).ToString()
    End Function

    
    
    <Extension>
    Public Function Leer_EnumChatTipoMensajeE(ElSTR As Dic(Of String, String), key$) As EnumChatTipoMensajeE
        Return Ctype( ElSTR.HacerMagia(key).int(0),  EnumChatTipoMensajeE)
    End Function



  <Extension>
    Public Function STR(v As EnumTipoDeRealizacionDeTurnoE) As String
        Return GetEnumDescription(v)
    End Function

    <Extension>
    Public Function INT(v As EnumTipoDeRealizacionDeTurnoE) As Integer
        Return CInt(v)
    End Function
      
    
    <Extension>
    Public Function AdaptarMySQL_Integer(v As EnumTipoDeRealizacionDeTurnoE) As String
        Return CInt(v).ToString()
    End Function

        
    <Extension>
    Public Function AdaptarMySQL_EnumTipoDeRealizacionDeTurnoE(v As EnumTipoDeRealizacionDeTurnoE) As String
        Return CInt(v).ToString()
    End Function

    
    
    <Extension>
    Public Function Leer_EnumTipoDeRealizacionDeTurnoE(ElSTR As Dic(Of String, String), key$) As EnumTipoDeRealizacionDeTurnoE
        Return Ctype( ElSTR.HacerMagia(key).int(0),  EnumTipoDeRealizacionDeTurnoE)
    End Function



  <Extension>
    Public Function STR(v As EnumTipoDeTurnoE) As String
        Return GetEnumDescription(v)
    End Function

    <Extension>
    Public Function INT(v As EnumTipoDeTurnoE) As Integer
        Return CInt(v)
    End Function
      
    
    <Extension>
    Public Function AdaptarMySQL_Integer(v As EnumTipoDeTurnoE) As String
        Return CInt(v).ToString()
    End Function

        
    <Extension>
    Public Function AdaptarMySQL_EnumTipoDeTurnoE(v As EnumTipoDeTurnoE) As String
        Return CInt(v).ToString()
    End Function

    
    
    <Extension>
    Public Function Leer_EnumTipoDeTurnoE(ElSTR As Dic(Of String, String), key$) As EnumTipoDeTurnoE
        Return Ctype( ElSTR.HacerMagia(key).int(0),  EnumTipoDeTurnoE)
    End Function



  <Extension>
    Public Function STR(v As EnumCotizacionAusenciaE) As String
        Return GetEnumDescription(v)
    End Function

    <Extension>
    Public Function INT(v As EnumCotizacionAusenciaE) As Integer
        Return CInt(v)
    End Function
      
    
    <Extension>
    Public Function AdaptarMySQL_Integer(v As EnumCotizacionAusenciaE) As String
        Return CInt(v).ToString()
    End Function

        
    <Extension>
    Public Function AdaptarMySQL_EnumCotizacionAusenciaE(v As EnumCotizacionAusenciaE) As String
        Return CInt(v).ToString()
    End Function

    
    
    <Extension>
    Public Function Leer_EnumCotizacionAusenciaE(ElSTR As Dic(Of String, String), key$) As EnumCotizacionAusenciaE
        Return Ctype( ElSTR.HacerMagia(key).int(0),  EnumCotizacionAusenciaE)
    End Function



  <Extension>
    Public Function STR(v As EnumRAArchivoE) As String
        Return GetEnumDescription(v)
    End Function

    <Extension>
    Public Function INT(v As EnumRAArchivoE) As Integer
        Return CInt(v)
    End Function
      
    
    <Extension>
    Public Function AdaptarMySQL_Integer(v As EnumRAArchivoE) As String
        Return CInt(v).ToString()
    End Function

        
    <Extension>
    Public Function AdaptarMySQL_EnumRAArchivoE(v As EnumRAArchivoE) As String
        Return CInt(v).ToString()
    End Function

    
    
    <Extension>
    Public Function Leer_EnumRAArchivoE(ElSTR As Dic(Of String, String), key$) As EnumRAArchivoE
        Return Ctype( ElSTR.HacerMagia(key).int(0),  EnumRAArchivoE)
    End Function



  <Extension>
    Public Function STR(v As EnumGeneroE) As String
        Return GetEnumDescription(v)
    End Function

    <Extension>
    Public Function INT(v As EnumGeneroE) As Integer
        Return CInt(v)
    End Function
      
    
    <Extension>
    Public Function AdaptarMySQL_Integer(v As EnumGeneroE) As String
        Return CInt(v).ToString()
    End Function

        
    <Extension>
    Public Function AdaptarMySQL_EnumGeneroE(v As EnumGeneroE) As String
        Return CInt(v).ToString()
    End Function

    
    
    <Extension>
    Public Function Leer_EnumGeneroE(ElSTR As Dic(Of String, String), key$) As EnumGeneroE
        Return Ctype( ElSTR.HacerMagia(key).int(0),  EnumGeneroE)
    End Function



  <Extension>
    Public Function STR(v As EnumConfiguracionImpuestosIncluidosE) As String
        Return GetEnumDescription(v)
    End Function

    <Extension>
    Public Function INT(v As EnumConfiguracionImpuestosIncluidosE) As Integer
        Return CInt(v)
    End Function
      
    
    <Extension>
    Public Function AdaptarMySQL_Integer(v As EnumConfiguracionImpuestosIncluidosE) As String
        Return CInt(v).ToString()
    End Function

        
    <Extension>
    Public Function AdaptarMySQL_EnumConfiguracionImpuestosIncluidosE(v As EnumConfiguracionImpuestosIncluidosE) As String
        Return CInt(v).ToString()
    End Function

    
    
    <Extension>
    Public Function Leer_EnumConfiguracionImpuestosIncluidosE(ElSTR As Dic(Of String, String), key$) As EnumConfiguracionImpuestosIncluidosE
        Return Ctype( ElSTR.HacerMagia(key).int(0),  EnumConfiguracionImpuestosIncluidosE)
    End Function



  <Extension>
    Public Function STR(v As EnumCriterioEvaluacionAgendaE) As String
        Return GetEnumDescription(v)
    End Function

    <Extension>
    Public Function INT(v As EnumCriterioEvaluacionAgendaE) As Integer
        Return CInt(v)
    End Function
      
    
    <Extension>
    Public Function AdaptarMySQL_Integer(v As EnumCriterioEvaluacionAgendaE) As String
        Return CInt(v).ToString()
    End Function

        
    <Extension>
    Public Function AdaptarMySQL_EnumCriterioEvaluacionAgendaE(v As EnumCriterioEvaluacionAgendaE) As String
        Return CInt(v).ToString()
    End Function

    
    
    <Extension>
    Public Function Leer_EnumCriterioEvaluacionAgendaE(ElSTR As Dic(Of String, String), key$) As EnumCriterioEvaluacionAgendaE
        Return Ctype( ElSTR.HacerMagia(key).int(0),  EnumCriterioEvaluacionAgendaE)
    End Function



  <Extension>
    Public Function STR(v As EnumSCDCarenciaE) As String
        Return GetEnumDescription(v)
    End Function

    <Extension>
    Public Function INT(v As EnumSCDCarenciaE) As Integer
        Return CInt(v)
    End Function
      
    
    <Extension>
    Public Function AdaptarMySQL_Integer(v As EnumSCDCarenciaE) As String
        Return CInt(v).ToString()
    End Function

        
    <Extension>
    Public Function AdaptarMySQL_EnumSCDCarenciaE(v As EnumSCDCarenciaE) As String
        Return CInt(v).ToString()
    End Function

    
    
    <Extension>
    Public Function Leer_EnumSCDCarenciaE(ElSTR As Dic(Of String, String), key$) As EnumSCDCarenciaE
        Return Ctype( ElSTR.HacerMagia(key).int(0),  EnumSCDCarenciaE)
    End Function



  <Extension>
    Public Function STR(v As EnumSCDRegistroE) As String
        Return GetEnumDescription(v)
    End Function

    <Extension>
    Public Function INT(v As EnumSCDRegistroE) As Integer
        Return CInt(v)
    End Function
      
    
    <Extension>
    Public Function AdaptarMySQL_Integer(v As EnumSCDRegistroE) As String
        Return CInt(v).ToString()
    End Function

        
    <Extension>
    Public Function AdaptarMySQL_EnumSCDRegistroE(v As EnumSCDRegistroE) As String
        Return CInt(v).ToString()
    End Function

    
    
    <Extension>
    Public Function Leer_EnumSCDRegistroE(ElSTR As Dic(Of String, String), key$) As EnumSCDRegistroE
        Return Ctype( ElSTR.HacerMagia(key).int(0),  EnumSCDRegistroE)
    End Function



  <Extension>
    Public Function STR(v As EnumDiaDeLaSemanaE) As String
        Return GetEnumDescription(v)
    End Function

    <Extension>
    Public Function INT(v As EnumDiaDeLaSemanaE) As Integer
        Return CInt(v)
    End Function
      
    
    <Extension>
    Public Function AdaptarMySQL_Integer(v As EnumDiaDeLaSemanaE) As String
        Return CInt(v).ToString()
    End Function

        
    <Extension>
    Public Function AdaptarMySQL_EnumDiaDeLaSemanaE(v As EnumDiaDeLaSemanaE) As String
        Return CInt(v).ToString()
    End Function

    
    
    <Extension>
    Public Function Leer_EnumDiaDeLaSemanaE(ElSTR As Dic(Of String, String), key$) As EnumDiaDeLaSemanaE
        Return Ctype( ElSTR.HacerMagia(key).int(0),  EnumDiaDeLaSemanaE)
    End Function



  <Extension>
    Public Function STR(v As EnumRAPrincipalE) As String
        Return GetEnumDescription(v)
    End Function

    <Extension>
    Public Function INT(v As EnumRAPrincipalE) As Integer
        Return CInt(v)
    End Function
      
    
    <Extension>
    Public Function AdaptarMySQL_Integer(v As EnumRAPrincipalE) As String
        Return CInt(v).ToString()
    End Function

        
    <Extension>
    Public Function AdaptarMySQL_EnumRAPrincipalE(v As EnumRAPrincipalE) As String
        Return CInt(v).ToString()
    End Function

    
    
    <Extension>
    Public Function Leer_EnumRAPrincipalE(ElSTR As Dic(Of String, String), key$) As EnumRAPrincipalE
        Return Ctype( ElSTR.HacerMagia(key).int(0),  EnumRAPrincipalE)
    End Function



  <Extension>
    Public Function STR(v As EnumALogAccesoE) As String
        Return GetEnumDescription(v)
    End Function

    <Extension>
    Public Function INT(v As EnumALogAccesoE) As Integer
        Return CInt(v)
    End Function
      
    
    <Extension>
    Public Function AdaptarMySQL_Integer(v As EnumALogAccesoE) As String
        Return CInt(v).ToString()
    End Function

        
    <Extension>
    Public Function AdaptarMySQL_EnumALogAccesoE(v As EnumALogAccesoE) As String
        Return CInt(v).ToString()
    End Function

    
    
    <Extension>
    Public Function Leer_EnumALogAccesoE(ElSTR As Dic(Of String, String), key$) As EnumALogAccesoE
        Return Ctype( ElSTR.HacerMagia(key).int(0),  EnumALogAccesoE)
    End Function



  <Extension>
    Public Function STR(v As EnumAControlDePresenciaE) As String
        Return GetEnumDescription(v)
    End Function

    <Extension>
    Public Function INT(v As EnumAControlDePresenciaE) As Integer
        Return CInt(v)
    End Function
      
    
    <Extension>
    Public Function AdaptarMySQL_Integer(v As EnumAControlDePresenciaE) As String
        Return CInt(v).ToString()
    End Function

        
    <Extension>
    Public Function AdaptarMySQL_EnumAControlDePresenciaE(v As EnumAControlDePresenciaE) As String
        Return CInt(v).ToString()
    End Function

    
    
    <Extension>
    Public Function Leer_EnumAControlDePresenciaE(ElSTR As Dic(Of String, String), key$) As EnumAControlDePresenciaE
        Return Ctype( ElSTR.HacerMagia(key).int(0),  EnumAControlDePresenciaE)
    End Function



  <Extension>
    Public Function STR(v As EnumRAAccionPapeleraE) As String
        Return GetEnumDescription(v)
    End Function

    <Extension>
    Public Function INT(v As EnumRAAccionPapeleraE) As Integer
        Return CInt(v)
    End Function
      
    
    <Extension>
    Public Function AdaptarMySQL_Integer(v As EnumRAAccionPapeleraE) As String
        Return CInt(v).ToString()
    End Function

        
    <Extension>
    Public Function AdaptarMySQL_EnumRAAccionPapeleraE(v As EnumRAAccionPapeleraE) As String
        Return CInt(v).ToString()
    End Function

    
    
    <Extension>
    Public Function Leer_EnumRAAccionPapeleraE(ElSTR As Dic(Of String, String), key$) As EnumRAAccionPapeleraE
        Return Ctype( ElSTR.HacerMagia(key).int(0),  EnumRAAccionPapeleraE)
    End Function



  <Extension>
    Public Function STR(v As EnumTipoIdentificacionFiscalE) As String
        Return GetEnumDescription(v)
    End Function

    <Extension>
    Public Function INT(v As EnumTipoIdentificacionFiscalE) As Integer
        Return CInt(v)
    End Function
      
    
    <Extension>
    Public Function AdaptarMySQL_Integer(v As EnumTipoIdentificacionFiscalE) As String
        Return CInt(v).ToString()
    End Function

        
    <Extension>
    Public Function AdaptarMySQL_EnumTipoIdentificacionFiscalE(v As EnumTipoIdentificacionFiscalE) As String
        Return CInt(v).ToString()
    End Function

    
    
    <Extension>
    Public Function Leer_EnumTipoIdentificacionFiscalE(ElSTR As Dic(Of String, String), key$) As EnumTipoIdentificacionFiscalE
        Return Ctype( ElSTR.HacerMagia(key).int(0),  EnumTipoIdentificacionFiscalE)
    End Function



  <Extension>
    Public Function STR(v As EnumTipoDeAusenciaLaboralEE) As String
        Return GetEnumDescription(v)
    End Function

    <Extension>
    Public Function INT(v As EnumTipoDeAusenciaLaboralEE) As Integer
        Return CInt(v)
    End Function
      
    
    <Extension>
    Public Function AdaptarMySQL_Integer(v As EnumTipoDeAusenciaLaboralEE) As String
        Return CInt(v).ToString()
    End Function

        
    <Extension>
    Public Function AdaptarMySQL_EnumTipoDeAusenciaLaboralEE(v As EnumTipoDeAusenciaLaboralEE) As String
        Return CInt(v).ToString()
    End Function

    
    
    <Extension>
    Public Function Leer_EnumTipoDeAusenciaLaboralEE(ElSTR As Dic(Of String, String), key$) As EnumTipoDeAusenciaLaboralEE
        Return Ctype( ElSTR.HacerMagia(key).int(0),  EnumTipoDeAusenciaLaboralEE)
    End Function



  <Extension>
    Public Function STR(v As EnumTipoDeDocumentoE) As String
        Return GetEnumDescription(v)
    End Function

    <Extension>
    Public Function INT(v As EnumTipoDeDocumentoE) As Integer
        Return CInt(v)
    End Function
      
    
    <Extension>
    Public Function AdaptarMySQL_Integer(v As EnumTipoDeDocumentoE) As String
        Return CInt(v).ToString()
    End Function

        
    <Extension>
    Public Function AdaptarMySQL_EnumTipoDeDocumentoE(v As EnumTipoDeDocumentoE) As String
        Return CInt(v).ToString()
    End Function

    
    
    <Extension>
    Public Function Leer_EnumTipoDeDocumentoE(ElSTR As Dic(Of String, String), key$) As EnumTipoDeDocumentoE
        Return Ctype( ElSTR.HacerMagia(key).int(0),  EnumTipoDeDocumentoE)
    End Function



  <Extension>
    Public Function STR(v As EnumTipoBackUpEE) As String
        Return GetEnumDescription(v)
    End Function

    <Extension>
    Public Function INT(v As EnumTipoBackUpEE) As Integer
        Return CInt(v)
    End Function
      
    
    <Extension>
    Public Function AdaptarMySQL_Integer(v As EnumTipoBackUpEE) As String
        Return CInt(v).ToString()
    End Function

        
    <Extension>
    Public Function AdaptarMySQL_EnumTipoBackUpEE(v As EnumTipoBackUpEE) As String
        Return CInt(v).ToString()
    End Function

    
    
    <Extension>
    Public Function Leer_EnumTipoBackUpEE(ElSTR As Dic(Of String, String), key$) As EnumTipoBackUpEE
        Return Ctype( ElSTR.HacerMagia(key).int(0),  EnumTipoBackUpEE)
    End Function



  <Extension>
    Public Function STR(v As EnumEstilosTextoEE) As String
        Return GetEnumDescription(v)
    End Function

    <Extension>
    Public Function INT(v As EnumEstilosTextoEE) As Integer
        Return CInt(v)
    End Function
      
    
    <Extension>
    Public Function AdaptarMySQL_Integer(v As EnumEstilosTextoEE) As String
        Return CInt(v).ToString()
    End Function

        
    <Extension>
    Public Function AdaptarMySQL_EnumEstilosTextoEE(v As EnumEstilosTextoEE) As String
        Return CInt(v).ToString()
    End Function

    
    
    <Extension>
    Public Function Leer_EnumEstilosTextoEE(ElSTR As Dic(Of String, String), key$) As EnumEstilosTextoEE
        Return Ctype( ElSTR.HacerMagia(key).int(0),  EnumEstilosTextoEE)
    End Function



  <Extension>
    Public Function STR(v As TipoJSONE) As String
        Return GetEnumDescription(v)
    End Function

    <Extension>
    Public Function INT(v As TipoJSONE) As Integer
        Return CInt(v)
    End Function
      
    
    <Extension>
    Public Function AdaptarMySQL_Integer(v As TipoJSONE) As String
        Return CInt(v).ToString()
    End Function

        
    <Extension>
    Public Function AdaptarMySQL_TipoJSONE(v As TipoJSONE) As String
        Return CInt(v).ToString()
    End Function

    
    
    <Extension>
    Public Function Leer_TipoJSONE(ElSTR As Dic(Of String, String), key$) As TipoJSONE
        Return Ctype( ElSTR.HacerMagia(key).int(0),  TipoJSONE)
    End Function



  <Extension>
    Public Function STR(v As EnumMesE) As String
        Return GetEnumDescription(v)
    End Function

    <Extension>
    Public Function INT(v As EnumMesE) As Integer
        Return CInt(v)
    End Function
      
    
    <Extension>
    Public Function AdaptarMySQL_Integer(v As EnumMesE) As String
        Return CInt(v).ToString()
    End Function

        
    <Extension>
    Public Function AdaptarMySQL_EnumMesE(v As EnumMesE) As String
        Return CInt(v).ToString()
    End Function

    
    
    <Extension>
    Public Function Leer_EnumMesE(ElSTR As Dic(Of String, String), key$) As EnumMesE
        Return Ctype( ElSTR.HacerMagia(key).int(0),  EnumMesE)
    End Function



  <Extension>
    Public Function STR(v As EnumTramitacionE) As String
        Return GetEnumDescription(v)
    End Function

    <Extension>
    Public Function INT(v As EnumTramitacionE) As Integer
        Return CInt(v)
    End Function
      
    
    <Extension>
    Public Function AdaptarMySQL_Integer(v As EnumTramitacionE) As String
        Return CInt(v).ToString()
    End Function

        
    <Extension>
    Public Function AdaptarMySQL_EnumTramitacionE(v As EnumTramitacionE) As String
        Return CInt(v).ToString()
    End Function

    
    
    <Extension>
    Public Function Leer_EnumTramitacionE(ElSTR As Dic(Of String, String), key$) As EnumTramitacionE
        Return Ctype( ElSTR.HacerMagia(key).int(0),  EnumTramitacionE)
    End Function



  <Extension>
    Public Function STR(v As EnumTipoServicioDeCorreoE) As String
        Return GetEnumDescription(v)
    End Function

    <Extension>
    Public Function INT(v As EnumTipoServicioDeCorreoE) As Integer
        Return CInt(v)
    End Function
      
    
    <Extension>
    Public Function AdaptarMySQL_Integer(v As EnumTipoServicioDeCorreoE) As String
        Return CInt(v).ToString()
    End Function

        
    <Extension>
    Public Function AdaptarMySQL_EnumTipoServicioDeCorreoE(v As EnumTipoServicioDeCorreoE) As String
        Return CInt(v).ToString()
    End Function

    
    
    <Extension>
    Public Function Leer_EnumTipoServicioDeCorreoE(ElSTR As Dic(Of String, String), key$) As EnumTipoServicioDeCorreoE
        Return Ctype( ElSTR.HacerMagia(key).int(0),  EnumTipoServicioDeCorreoE)
    End Function



  <Extension>
    Public Function STR(v As EnumCorreoEntranteSalienteE) As String
        Return GetEnumDescription(v)
    End Function

    <Extension>
    Public Function INT(v As EnumCorreoEntranteSalienteE) As Integer
        Return CInt(v)
    End Function
      
    
    <Extension>
    Public Function AdaptarMySQL_Integer(v As EnumCorreoEntranteSalienteE) As String
        Return CInt(v).ToString()
    End Function

        
    <Extension>
    Public Function AdaptarMySQL_EnumCorreoEntranteSalienteE(v As EnumCorreoEntranteSalienteE) As String
        Return CInt(v).ToString()
    End Function

    
    
    <Extension>
    Public Function Leer_EnumCorreoEntranteSalienteE(ElSTR As Dic(Of String, String), key$) As EnumCorreoEntranteSalienteE
        Return Ctype( ElSTR.HacerMagia(key).int(0),  EnumCorreoEntranteSalienteE)
    End Function



  <Extension>
    Public Function STR(v As EnumEstadoDeTramiteE) As String
        Return GetEnumDescription(v)
    End Function

    <Extension>
    Public Function INT(v As EnumEstadoDeTramiteE) As Integer
        Return CInt(v)
    End Function
      
    
    <Extension>
    Public Function AdaptarMySQL_Integer(v As EnumEstadoDeTramiteE) As String
        Return CInt(v).ToString()
    End Function

        
    <Extension>
    Public Function AdaptarMySQL_EnumEstadoDeTramiteE(v As EnumEstadoDeTramiteE) As String
        Return CInt(v).ToString()
    End Function

    
    
    <Extension>
    Public Function Leer_EnumEstadoDeTramiteE(ElSTR As Dic(Of String, String), key$) As EnumEstadoDeTramiteE
        Return Ctype( ElSTR.HacerMagia(key).int(0),  EnumEstadoDeTramiteE)
    End Function



  <Extension>
    Public Function STR(v As EnumAsistenciaAReunionE) As String
        Return GetEnumDescription(v)
    End Function

    <Extension>
    Public Function INT(v As EnumAsistenciaAReunionE) As Integer
        Return CInt(v)
    End Function
      
    
    <Extension>
    Public Function AdaptarMySQL_Integer(v As EnumAsistenciaAReunionE) As String
        Return CInt(v).ToString()
    End Function

        
    <Extension>
    Public Function AdaptarMySQL_EnumAsistenciaAReunionE(v As EnumAsistenciaAReunionE) As String
        Return CInt(v).ToString()
    End Function

    
    
    <Extension>
    Public Function Leer_EnumAsistenciaAReunionE(ElSTR As Dic(Of String, String), key$) As EnumAsistenciaAReunionE
        Return Ctype( ElSTR.HacerMagia(key).int(0),  EnumAsistenciaAReunionE)
    End Function



  <Extension>
    Public Function STR(v As EnumEstadoPuntoATratarE) As String
        Return GetEnumDescription(v)
    End Function

    <Extension>
    Public Function INT(v As EnumEstadoPuntoATratarE) As Integer
        Return CInt(v)
    End Function
      
    
    <Extension>
    Public Function AdaptarMySQL_Integer(v As EnumEstadoPuntoATratarE) As String
        Return CInt(v).ToString()
    End Function

        
    <Extension>
    Public Function AdaptarMySQL_EnumEstadoPuntoATratarE(v As EnumEstadoPuntoATratarE) As String
        Return CInt(v).ToString()
    End Function

    
    
    <Extension>
    Public Function Leer_EnumEstadoPuntoATratarE(ElSTR As Dic(Of String, String), key$) As EnumEstadoPuntoATratarE
        Return Ctype( ElSTR.HacerMagia(key).int(0),  EnumEstadoPuntoATratarE)
    End Function



  <Extension>
    Public Function STR(v As PrioridadE) As String
        Return GetEnumDescription(v)
    End Function

    <Extension>
    Public Function INT(v As PrioridadE) As Integer
        Return CInt(v)
    End Function
      
    
    <Extension>
    Public Function AdaptarMySQL_Integer(v As PrioridadE) As String
        Return CInt(v).ToString()
    End Function

        
    <Extension>
    Public Function AdaptarMySQL_PrioridadE(v As PrioridadE) As String
        Return CInt(v).ToString()
    End Function

    
    
    <Extension>
    Public Function Leer_PrioridadE(ElSTR As Dic(Of String, String), key$) As PrioridadE
        Return Ctype( ElSTR.HacerMagia(key).int(0),  PrioridadE)
    End Function



  <Extension>
    Public Function STR(v As EnumTipoMovimientoE) As String
        Return GetEnumDescription(v)
    End Function

    <Extension>
    Public Function INT(v As EnumTipoMovimientoE) As Integer
        Return CInt(v)
    End Function
      
    
    <Extension>
    Public Function AdaptarMySQL_Integer(v As EnumTipoMovimientoE) As String
        Return CInt(v).ToString()
    End Function

        
    <Extension>
    Public Function AdaptarMySQL_EnumTipoMovimientoE(v As EnumTipoMovimientoE) As String
        Return CInt(v).ToString()
    End Function

    
    
    <Extension>
    Public Function Leer_EnumTipoMovimientoE(ElSTR As Dic(Of String, String), key$) As EnumTipoMovimientoE
        Return Ctype( ElSTR.HacerMagia(key).int(0),  EnumTipoMovimientoE)
    End Function



  <Extension>
    Public Function STR(v As EnumEstadoTransporteE) As String
        Return GetEnumDescription(v)
    End Function

    <Extension>
    Public Function INT(v As EnumEstadoTransporteE) As Integer
        Return CInt(v)
    End Function
      
    
    <Extension>
    Public Function AdaptarMySQL_Integer(v As EnumEstadoTransporteE) As String
        Return CInt(v).ToString()
    End Function

        
    <Extension>
    Public Function AdaptarMySQL_EnumEstadoTransporteE(v As EnumEstadoTransporteE) As String
        Return CInt(v).ToString()
    End Function

    
    
    <Extension>
    Public Function Leer_EnumEstadoTransporteE(ElSTR As Dic(Of String, String), key$) As EnumEstadoTransporteE
        Return Ctype( ElSTR.HacerMagia(key).int(0),  EnumEstadoTransporteE)
    End Function



  <Extension>
    Public Function STR(v As EnumAsientoE) As String
        Return GetEnumDescription(v)
    End Function

    <Extension>
    Public Function INT(v As EnumAsientoE) As Integer
        Return CInt(v)
    End Function
      
    
    <Extension>
    Public Function AdaptarMySQL_Integer(v As EnumAsientoE) As String
        Return CInt(v).ToString()
    End Function

        
    <Extension>
    Public Function AdaptarMySQL_EnumAsientoE(v As EnumAsientoE) As String
        Return CInt(v).ToString()
    End Function

    
    
    <Extension>
    Public Function Leer_EnumAsientoE(ElSTR As Dic(Of String, String), key$) As EnumAsientoE
        Return Ctype( ElSTR.HacerMagia(key).int(0),  EnumAsientoE)
    End Function



  <Extension>
    Public Function STR(v As EnumNivelCuentaContableE) As String
        Return GetEnumDescription(v)
    End Function

    <Extension>
    Public Function INT(v As EnumNivelCuentaContableE) As Integer
        Return CInt(v)
    End Function
      
    
    <Extension>
    Public Function AdaptarMySQL_Integer(v As EnumNivelCuentaContableE) As String
        Return CInt(v).ToString()
    End Function

        
    <Extension>
    Public Function AdaptarMySQL_EnumNivelCuentaContableE(v As EnumNivelCuentaContableE) As String
        Return CInt(v).ToString()
    End Function

    
    
    <Extension>
    Public Function Leer_EnumNivelCuentaContableE(ElSTR As Dic(Of String, String), key$) As EnumNivelCuentaContableE
        Return Ctype( ElSTR.HacerMagia(key).int(0),  EnumNivelCuentaContableE)
    End Function



  <Extension>
    Public Function STR(v As EnumNaturalezaDeCuentaE) As String
        Return GetEnumDescription(v)
    End Function

    <Extension>
    Public Function INT(v As EnumNaturalezaDeCuentaE) As Integer
        Return CInt(v)
    End Function
      
    
    <Extension>
    Public Function AdaptarMySQL_Integer(v As EnumNaturalezaDeCuentaE) As String
        Return CInt(v).ToString()
    End Function

        
    <Extension>
    Public Function AdaptarMySQL_EnumNaturalezaDeCuentaE(v As EnumNaturalezaDeCuentaE) As String
        Return CInt(v).ToString()
    End Function

    
    
    <Extension>
    Public Function Leer_EnumNaturalezaDeCuentaE(ElSTR As Dic(Of String, String), key$) As EnumNaturalezaDeCuentaE
        Return Ctype( ElSTR.HacerMagia(key).int(0),  EnumNaturalezaDeCuentaE)
    End Function



  <Extension>
    Public Function STR(v As EnumInmovilizadoEstadoAdquisicionEE) As String
        Return GetEnumDescription(v)
    End Function

    <Extension>
    Public Function INT(v As EnumInmovilizadoEstadoAdquisicionEE) As Integer
        Return CInt(v)
    End Function
      
    
    <Extension>
    Public Function AdaptarMySQL_Integer(v As EnumInmovilizadoEstadoAdquisicionEE) As String
        Return CInt(v).ToString()
    End Function

        
    <Extension>
    Public Function AdaptarMySQL_EnumInmovilizadoEstadoAdquisicionEE(v As EnumInmovilizadoEstadoAdquisicionEE) As String
        Return CInt(v).ToString()
    End Function

    
    
    <Extension>
    Public Function Leer_EnumInmovilizadoEstadoAdquisicionEE(ElSTR As Dic(Of String, String), key$) As EnumInmovilizadoEstadoAdquisicionEE
        Return Ctype( ElSTR.HacerMagia(key).int(0),  EnumInmovilizadoEstadoAdquisicionEE)
    End Function



  <Extension>
    Public Function STR(v As EnumInmovilizadoNaturalezaEE) As String
        Return GetEnumDescription(v)
    End Function

    <Extension>
    Public Function INT(v As EnumInmovilizadoNaturalezaEE) As Integer
        Return CInt(v)
    End Function
      
    
    <Extension>
    Public Function AdaptarMySQL_Integer(v As EnumInmovilizadoNaturalezaEE) As String
        Return CInt(v).ToString()
    End Function

        
    <Extension>
    Public Function AdaptarMySQL_EnumInmovilizadoNaturalezaEE(v As EnumInmovilizadoNaturalezaEE) As String
        Return CInt(v).ToString()
    End Function

    
    
    <Extension>
    Public Function Leer_EnumInmovilizadoNaturalezaEE(ElSTR As Dic(Of String, String), key$) As EnumInmovilizadoNaturalezaEE
        Return Ctype( ElSTR.HacerMagia(key).int(0),  EnumInmovilizadoNaturalezaEE)
    End Function



  <Extension>
    Public Function STR(v As EnumIntervaloContablePeriodosE) As String
        Return GetEnumDescription(v)
    End Function

    <Extension>
    Public Function INT(v As EnumIntervaloContablePeriodosE) As Integer
        Return CInt(v)
    End Function
      
    
    <Extension>
    Public Function AdaptarMySQL_Integer(v As EnumIntervaloContablePeriodosE) As String
        Return CInt(v).ToString()
    End Function

        
    <Extension>
    Public Function AdaptarMySQL_EnumIntervaloContablePeriodosE(v As EnumIntervaloContablePeriodosE) As String
        Return CInt(v).ToString()
    End Function

    
    
    <Extension>
    Public Function Leer_EnumIntervaloContablePeriodosE(ElSTR As Dic(Of String, String), key$) As EnumIntervaloContablePeriodosE
        Return Ctype( ElSTR.HacerMagia(key).int(0),  EnumIntervaloContablePeriodosE)
    End Function



  <Extension>
    Public Function STR(v As EnumIntervaloContableE) As String
        Return GetEnumDescription(v)
    End Function

    <Extension>
    Public Function INT(v As EnumIntervaloContableE) As Integer
        Return CInt(v)
    End Function
      
    
    <Extension>
    Public Function AdaptarMySQL_Integer(v As EnumIntervaloContableE) As String
        Return CInt(v).ToString()
    End Function

        
    <Extension>
    Public Function AdaptarMySQL_EnumIntervaloContableE(v As EnumIntervaloContableE) As String
        Return CInt(v).ToString()
    End Function

    
    
    <Extension>
    Public Function Leer_EnumIntervaloContableE(ElSTR As Dic(Of String, String), key$) As EnumIntervaloContableE
        Return Ctype( ElSTR.HacerMagia(key).int(0),  EnumIntervaloContableE)
    End Function



  <Extension>
    Public Function STR(v As EnumTipoActividadE) As String
        Return GetEnumDescription(v)
    End Function

    <Extension>
    Public Function INT(v As EnumTipoActividadE) As Integer
        Return CInt(v)
    End Function
      
    
    <Extension>
    Public Function AdaptarMySQL_Integer(v As EnumTipoActividadE) As String
        Return CInt(v).ToString()
    End Function

        
    <Extension>
    Public Function AdaptarMySQL_EnumTipoActividadE(v As EnumTipoActividadE) As String
        Return CInt(v).ToString()
    End Function

    
    
    <Extension>
    Public Function Leer_EnumTipoActividadE(ElSTR As Dic(Of String, String), key$) As EnumTipoActividadE
        Return Ctype( ElSTR.HacerMagia(key).int(0),  EnumTipoActividadE)
    End Function



    Friend Function GetEnumDescription(Of TEnum)(enumObj As TEnum) As String
        Dim fi As FieldInfo = enumObj.GetType().GetField(enumObj.ToString())
        Dim attributes As DescriptionAttribute() = fi.GetCustomAttributes(GetType(DescriptionAttribute), False)
        If attributes IsNot Nothing AndAlso attributes.Length > 0 Then
            Return attributes(0).Description
        Else
            Return enumObj.ToString()
        End If
    End Function
End Module
