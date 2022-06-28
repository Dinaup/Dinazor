Partial Public Class SeccionesD
  Public Class AsignacionesDeHorariosD
      Public Shared _SeccionID As String = "02dccb8a-f5aa-4604-b2d9-a1be0bc157c4"
      Public Shared _SeccionIDGUID As New Guid("02dccb8a-f5aa-4604-b2d9-a1be0bc157c4")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As AsignacionesDeHorarios_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, AsignacionesDeHorariosES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New AsignacionesDeHorarios_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As AsignacionesDeHorarios_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, AsignacionesDeHorariosES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New AsignacionesDeHorarios_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class AsignacionesDeHorariosES
          Public shared _SeccionID as Guid = New Guid("02dccb8a-f5aa-4604-b2d9-a1be0bc157c4")
          Public shared _Tabla$ = "tpr_20040102881"
      Public Shared ReferenciaAgenda$ = "pr_30040102891"
      Public Shared ReferenciaAutorDelAlta$ = "pr_20040102885"
      Public Shared HorarioActivoDesde$ = "pr_20040103103"
      Public Shared HorarioActivoHasta$ = "pr_20040103102"
      Public Shared FechaAlta_UTC$ = "pr_200401028811"
      Public Shared Vigente$ = "pr_30040103101"
      Public Shared ReferenciaAgendaSeccion$ = "pr_40040102891"
      Public Shared Observaciones$ = "pr_60040103331"
      Public Shared HoraLocal$ = "pr_20040102887"
      Public Shared ReferenciaDestinador$ = "pr_200401028814"
      Public Shared ReferenciaHorario$ = "pr_20040103101"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_200401028826"
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
      Public Class AsignacionesDeHorariosC
          Public ReferenciaAgenda As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HorarioActivoDesde As Date
          Public HorarioActivoHasta As Date
          Public FechaAlta_UTC As Date
          Public Vigente As Boolean
          Public ReferenciaAgendaSeccion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Observaciones As String
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaHorario As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
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
      Public Class AsignacionesDeHorarios_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
        Public ReadOnly property ReferenciaAgenda As Guid
            get
                return me.GetValue_Guid("pr_30040102891")
            End Get   
        End Property
        Public ReadOnly property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_20040102885")
            End Get   
        End Property
          Public property HorarioActivoDesde As Date
            get
                return me.GetValue_Date("pr_20040103103")
            End Get
            Set(value As Date)
                me.SetValue_Date("pr_20040103103", value)
            End Set
          End Property
          Public property HorarioActivoHasta As Date
            get
                return me.GetValue_Date("pr_20040103102")
            End Get
            Set(value As Date)
                me.SetValue_Date("pr_20040103102", value)
            End Set
          End Property
        Public ReadOnly property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_200401028811")
            End Get   
        End Property
          Public property Vigente As Boolean
            get
                return me.GetValue_Boolean("pr_30040103101")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_30040103101", value)
            End Set
          End Property
          Public property ReferenciaAgendaSeccion As Guid
            get
                return me.GetValue_Guid("pr_40040102891")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_40040102891", value)
            End Set
          End Property
          Public property Observaciones As String
            get
                return me.GetValue_String("pr_60040103331")
            End Get
            Set(value As String)
                me.SetValue_String("pr_60040103331", value)
            End Set
          End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_20040102887")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_200401028814")
            End Get   
        End Property
          Public property ReferenciaHorario As Guid
            get
                return me.GetValue_Guid("pr_20040103101")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_20040103101", value)
            End Set
          End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_200401028826")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_200401028826", value)
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
