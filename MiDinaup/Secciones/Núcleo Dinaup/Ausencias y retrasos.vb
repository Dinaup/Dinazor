﻿Partial Public Class SeccionesD
  Public Class AusenciasYRetrasosD
      Public Shared _SeccionID As String = "97ed76fb-bc5b-4cf6-873f-548f24e4ff35"
      Public Shared _SeccionIDGUID As New Guid("97ed76fb-bc5b-4cf6-873f-548f24e4ff35")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As AusenciasYRetrasos_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, AusenciasYRetrasosES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New AusenciasYRetrasos_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As AusenciasYRetrasos_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, AusenciasYRetrasosES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New AusenciasYRetrasos_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class AusenciasYRetrasosES
          Public shared _SeccionID as Guid = New Guid("97ed76fb-bc5b-4cf6-873f-548f24e4ff35")
          Public shared _Tabla$ = "tpr_63e63f9xd"
      Public Shared EstadoDeLaRealizacion$ = "pr_30040103561"
      Public Shared ReferenciaAutorDelAlta$ = "pr_1863b69b6ex213wd"
      Public Shared DuracionTurnoEnMinutos$ = "pr_1863e88aa5x128wd"
      Public Shared RegistrosAgregados$ = "pr_186411ab2dx4dwd"
      Public Shared HoraProgramadaDeInicio_UTC$ = "pr_1863cf7342x2cfwd"
      Public Shared FechaAlta_UTC$ = "pr_1863b69b89x23ewd"
      Public Shared ReferenciaMotivoDeLaRealizacionObsoleto$ = "pr_50040112221"
      Public Shared RealizacionEnMinutos$ = "pr_1863e95bdfx236wd"
      Public Shared FechaDato_UTC$ = "pr_1863c96f6bx340wd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_1863ca986fx36cwd"
      Public Shared RegistrosModificados$ = "pr_186412b750x102wd"
      Public Shared MinutosExtrasTrabajados$ = "pr_1864ee2a65xfawd"
      Public Shared HoraEnLaQueInicio_UTC$ = "pr_1863d4dfc1x28ewd"
      Public Shared InformesVisualizados$ = "pr_186410cfabx328wd"
      Public Shared SesionesIniciadas$ = "pr_1864145b2axeawd"
      Public Shared HoraEnLaQueFinalizo_UTC$ = "pr_1863d56b05x327wd"
      Public Shared MinutosConSesionActiva$ = "pr_1873d23d48x3e4wd"
      Public Shared RegistrosEliminados$ = "pr_186415d176xccwd"
      Public Shared RegistrosRestaurados$ = "pr_1864168675x2a5wd"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_1863c96f39x2awd"
      Public Shared MinutosRetrasoEntrada$ = "pr_1863e9ef8dx221wd"
      Public Shared HoraProgramadaDeFin_UTC$ = "pr_1863d05476x6awd"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_1863c96f56x31dwd"
      Public Shared MinutosRetrasoSalida$ = "pr_1863ea67cbx217wd"
      Public Shared HoraLocal$ = "pr_776ae16wd"
      Public Shared ReferenciaDestinador$ = "pr_1863b69bc5x86wd"
      Public Shared RegistrosVisitados$ = "pr_1864133a72x194wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_1863c09a8ax1b5wd"
      Public Shared ImporteImportePorHoraNoRealizadaDentroDeHorario$ = "pr_20040138406"
      Public Shared TotalHorasExtraEnNominaEnMinutos$ = "pr_30040139131"
      Public Shared ImporteImportePorHoraRealizadaFueraDeHorario$ = "pr_30040139132"
      Public Shared FechaDeRealizacion$ = "pr_10040139141"
      Public Shared Observaciones$ = "pr_20040138403"
      Public Shared RealizacionConcluida$ = "pr_40040209613"
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
      Public Class AusenciasYRetrasosC
          Public EstadoDeLaRealizacion As Integer
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public DuracionTurnoEnMinutos As Integer
          Public RegistrosAgregados As Integer
          Public HoraProgramadaDeInicio_UTC As Date
          Public FechaAlta_UTC As Date
          Public ReferenciaMotivoDeLaRealizacionObsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public RealizacionEnMinutos As Integer
          Public FechaDato_UTC As Date
          Public EmpleadoTieneAccesoWeb As Boolean
          Public RegistrosModificados As Integer
          Public MinutosExtrasTrabajados As Integer
          Public HoraEnLaQueInicio_UTC As Date
          Public InformesVisualizados As Integer
          Public SesionesIniciadas As Integer
          Public HoraEnLaQueFinalizo_UTC As Date
          Public MinutosConSesionActiva As Integer
          Public RegistrosEliminados As Integer
          Public RegistrosRestaurados As Integer
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public MinutosRetrasoEntrada As Integer
          Public HoraProgramadaDeFin_UTC As Date
          Public ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public MinutosRetrasoSalida As Integer
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public RegistrosVisitados As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ImporteImportePorHoraNoRealizadaDentroDeHorario As Decimal
          Public TotalHorasExtraEnNominaEnMinutos As Decimal
          Public ImporteImportePorHoraRealizadaFueraDeHorario As Decimal
          Public FechaDeRealizacion As Date
          Public Observaciones As String
          Public RealizacionConcluida As Boolean
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
      Public Class AusenciasYRetrasos_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
          Public property EstadoDeLaRealizacion As Integer
            get
                return me.GetValue_Integer("pr_30040103561")
            End Get
            Set(value As Integer)
                me.SetValue_Integer("pr_30040103561", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_1863b69b6ex213wd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_1863b69b6ex213wd", value)
            End Set
          End Property
          Public property DuracionTurnoEnMinutos As Integer
            get
                return me.GetValue_Integer("pr_1863e88aa5x128wd")
            End Get
            Set(value As Integer)
                me.SetValue_Integer("pr_1863e88aa5x128wd", value)
            End Set
          End Property
        Public ReadOnly property RegistrosAgregados As Integer
            get
                return me.GetValue_Integer("pr_186411ab2dx4dwd")
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
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_1863b69b89x23ewd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_1863b69b89x23ewd", value)
            End Set
          End Property
          Public property ReferenciaMotivoDeLaRealizacionObsoleto As Guid
            get
                return me.GetValue_Guid("pr_50040112221")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_50040112221", value)
            End Set
          End Property
          Public property RealizacionEnMinutos As Integer
            get
                return me.GetValue_Integer("pr_1863e95bdfx236wd")
            End Get
            Set(value As Integer)
                me.SetValue_Integer("pr_1863e95bdfx236wd", value)
            End Set
          End Property
          Public property FechaDato_UTC As Date
            get
                return me.GetValue_DateTime("pr_1863c96f6bx340wd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_1863c96f6bx340wd", value)
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
        Public ReadOnly property MinutosExtrasTrabajados As Integer
            get
                return me.GetValue_Integer("pr_1864ee2a65xfawd")
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
        Public ReadOnly property InformesVisualizados As Integer
            get
                return me.GetValue_Integer("pr_186410cfabx328wd")
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
          Public property MinutosConSesionActiva As Integer
            get
                return me.GetValue_Integer("pr_1873d23d48x3e4wd")
            End Get
            Set(value As Integer)
                me.SetValue_Integer("pr_1873d23d48x3e4wd", value)
            End Set
          End Property
        Public ReadOnly property RegistrosEliminados As Integer
            get
                return me.GetValue_Integer("pr_186415d176xccwd")
            End Get   
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
          Public property MinutosRetrasoEntrada As Integer
            get
                return me.GetValue_Integer("pr_1863e9ef8dx221wd")
            End Get
            Set(value As Integer)
                me.SetValue_Integer("pr_1863e9ef8dx221wd", value)
            End Set
          End Property
          Public property HoraProgramadaDeFin_UTC As Date
            get
                return me.GetValue_DateTime("pr_1863d05476x6awd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_1863d05476x6awd", value)
            End Set
          End Property
          Public property ReferenciaUbicacionPrincipal As Guid
            get
                return me.GetValue_Guid("pr_1863c96f56x31dwd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_1863c96f56x31dwd", value)
            End Set
          End Property
          Public property MinutosRetrasoSalida As Integer
            get
                return me.GetValue_Integer("pr_1863ea67cbx217wd")
            End Get
            Set(value As Integer)
                me.SetValue_Integer("pr_1863ea67cbx217wd", value)
            End Set
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
          Public property ImporteImportePorHoraNoRealizadaDentroDeHorario As Decimal
            get
                return me.GetValue_Decimal("pr_20040138406")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_20040138406", value)
            End Set
          End Property
        Public ReadOnly property TotalHorasExtraEnNominaEnMinutos As Decimal
            get
                return me.GetValue_Decimal("pr_30040139131")
            End Get   
        End Property
        Public ReadOnly property ImporteImportePorHoraRealizadaFueraDeHorario As Decimal
            get
                return me.GetValue_Decimal("pr_30040139132")
            End Get   
        End Property
        Public ReadOnly property FechaDeRealizacion As Date
            get
                return me.GetValue_Date("pr_10040139141")
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
          Public property RealizacionConcluida As Boolean
            get
                return me.GetValue_Boolean("pr_40040209613")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_40040209613", value)
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
