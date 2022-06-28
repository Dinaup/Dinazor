Partial Public Class SeccionesD
  Public Class ChatEstadosD
      Public Shared _SeccionID As String = "cf0f944e-7078-44bf-8f3f-1e27986df75a"
      Public Shared _SeccionIDGUID As New Guid("cf0f944e-7078-44bf-8f3f-1e27986df75a")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As ChatEstados_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, ChatEstadosES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New ChatEstados_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As ChatEstados_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, ChatEstadosES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New ChatEstados_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class ChatEstadosES
          Public shared _SeccionID as Guid = New Guid("cf0f944e-7078-44bf-8f3f-1e27986df75a")
          Public shared _Tabla$ = "tpr_70b1ff3xd"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_70b2027wd"
      Public Shared ReferenciaDestinador$ = "pr_70b204bwd"
      Public Shared HoraLocal$ = "pr_776af32wd"
      Public Shared EmpleadoSecundarioTieneAccesoWeb$ = "pr_70b22c5wd"
      Public Shared ReferenciaParticipacionDeEmpleado$ = "pr_70b22bdwd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_70b2057wd"
      Public Shared LeidoHasta_UTC$ = "pr_70b22d1wd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_70b202fwd"
      Public Shared ReferenciaEmpleadoSecundario$ = "pr_70b22c1wd"
      Public Shared RecibidoHasta_UTC$ = "pr_70b22d9wd"
      Public Shared ReferenciaSala$ = "pr_70b22ddwd"
      Public Shared FechaAlta_UTC$ = "pr_70b203fwd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_70b204fwd"
      Public Shared ReferenciaParticipacionEmpleadoSecundario$ = "pr_70b22c9wd"
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
      Public Class ChatEstadosC
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public EmpleadoSecundarioTieneAccesoWeb As Boolean
          Public ReferenciaParticipacionDeEmpleado As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public LeidoHasta_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaEmpleadoSecundario As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public RecibidoHasta_UTC As Date
          Public ReferenciaSala As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public EmpleadoTieneAccesoWeb As Boolean
          Public ReferenciaParticipacionEmpleadoSecundario As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
      Public Class ChatEstados_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
        Public ReadOnly property ReferenciaEmpleadoPrincipal As Guid
            get
                return me.GetValue_Guid("pr_70b2027wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_70b204bwd")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_776af32wd")
            End Get   
        End Property
          Public property EmpleadoSecundarioTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_70b22c5wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_70b22c5wd", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaParticipacionDeEmpleado As Guid
            get
                return me.GetValue_Guid("pr_70b22bdwd")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_70b2057wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_70b2057wd", value)
            End Set
          End Property
        Public ReadOnly property LeidoHasta_UTC As Date
            get
                return me.GetValue_DateTime("pr_70b22d1wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_70b202fwd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaEmpleadoSecundario As Guid
            get
                return me.GetValue_Guid("pr_70b22c1wd")
            End Get   
        End Property
        Public ReadOnly property RecibidoHasta_UTC As Date
            get
                return me.GetValue_DateTime("pr_70b22d9wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaSala As Guid
            get
                return me.GetValue_Guid("pr_70b22ddwd")
            End Get   
        End Property
        Public ReadOnly property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_70b203fwd")
            End Get   
        End Property
          Public property EmpleadoTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_70b204fwd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_70b204fwd", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaParticipacionEmpleadoSecundario As Guid
            get
                return me.GetValue_Guid("pr_70b22c9wd")
            End Get   
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
