Partial Public Class SeccionesD
  Public Class IndiceDeFuerasDeHorarioD
      Public Shared _SeccionID As String = "d27f1a6c-4f7a-4a54-9684-eb24124b5b05"
      Public Shared _SeccionIDGUID As New Guid("d27f1a6c-4f7a-4a54-9684-eb24124b5b05")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As IndiceDeFuerasDeHorario_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, IndiceDeFuerasDeHorarioES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New IndiceDeFuerasDeHorario_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As IndiceDeFuerasDeHorario_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, IndiceDeFuerasDeHorarioES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New IndiceDeFuerasDeHorario_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class IndiceDeFuerasDeHorarioES
          Public shared _SeccionID as Guid = New Guid("d27f1a6c-4f7a-4a54-9684-eb24124b5b05")
          Public shared _Tabla$ = "tpr_7b8b167xd"
      Public Shared FechaDesde_UTC$ = "pr_7b8d9cfwd"
      Public Shared ReferenciaDestinador$ = "pr_7b8b17fwd"
      Public Shared HoraLocal$ = "pr_7b8b171wd"
      Public Shared ReferenciaAgendaRelacion$ = "pr_7b8d9cdwd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_7b8b19dwd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_7b8b16dwd"
      Public Shared ReferenciaAgendaSeccion$ = "pr_7b8d9cbwd"
      Public Shared FechaHasta_UTC$ = "pr_7b8d9d1wd"
      Public Shared ReferenciaHorario$ = "pr_7b8d9d3wd"
      Public Shared FechaAlta_UTC$ = "pr_7b8b179wd"
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
      Public Class IndiceDeFuerasDeHorarioC
          Public FechaDesde_UTC As Date
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public ReferenciaAgendaRelacion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaAgendaSeccion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaHasta_UTC As Date
          Public ReferenciaHorario As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
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
      Public Class IndiceDeFuerasDeHorario_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
          Public property FechaDesde_UTC As Date
            get
                return me.GetValue_DateTime("pr_7b8d9cfwd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_7b8d9cfwd", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_7b8b17fwd")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_7b8b171wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaAgendaRelacion As Guid
            get
                return me.GetValue_Guid("pr_7b8d9cdwd")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_7b8b19dwd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_7b8b19dwd", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_7b8b16dwd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_7b8b16dwd", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaAgendaSeccion As Guid
            get
                return me.GetValue_Guid("pr_7b8d9cbwd")
            End Get   
        End Property
          Public property FechaHasta_UTC As Date
            get
                return me.GetValue_DateTime("pr_7b8d9d1wd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_7b8d9d1wd", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaHorario As Guid
            get
                return me.GetValue_Guid("pr_7b8d9d3wd")
            End Get   
        End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_7b8b179wd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_7b8b179wd", value)
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
