Partial Public Class SeccionesD
  Public Class ChatSalasListaD
      Public Shared _SeccionID As String = "8f3dda6b-e85a-49eb-9a22-0cda42e50379"
      Public Shared _SeccionIDGUID As New Guid("8f3dda6b-e85a-49eb-9a22-0cda42e50379")
      Public Class ChatSalasListaES
          Public shared _SeccionID as Guid = New Guid("8f3dda6b-e85a-49eb-9a22-0cda42e50379")
          Public shared _Tabla$ = "tpr_4f0f6dfwc_e"
      Public Shared ReferenciaParticipante$ = "pr_4f1001dx1e1wc"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_146314aeb7x5dwd"
      Public Shared PuedeEnviarMensajes$ = "pr_1a01911320x30bwd"
      Public Shared PuedeSilenciarLaSala$ = "pr_1a195e534fx1bwd"
      Public Shared PuedeExpulsarAParticipantes$ = "pr_4f10360x25fwc"
      Public Shared DentroDeSala$ = "pr_4f0ff21x26ewc"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_1464b3f1dag29fwd"
      Public Shared PuedeGestionarMensajesOcultos$ = "pr_1a1eee7cadx308wd"
      Public Shared HoraLocal$ = "pr_776af3awd"
      Public Shared ReferenciaDestinador$ = "pr_14630fb38bx91wd"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_1464b3f1dax29fwd"
      Public Shared MensajesVisibleDesde_UTC$ = "pr_70ee28fwd"
      Public Shared LeidoHastaObsoleto_UTC$ = "pr_4f10656x257wc"
      Public Shared PuedePersonalizarLaSala$ = "pr_4f1042fx341wc"
      Public Shared MensajesVisiblesDesdeObsoleto_UTC$ = "pr_1a01934f88x3b0wd"
      Public Shared PuedeModificarPermisosDeOtrosParticipantes$ = "pr_4f104d2x7awc"
      Public Shared FechaAlta_UTC$ = "pr_14c9f3d368x83wd"
      Public Shared FechaDato_UTC$ = "pr_14630fb30ex36cwd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_1464b59f4dgbdwd"
      Public Shared RecibidoHastaObsoleto_UTC$ = "pr_4f105e9x2edwc"
      Public Shared ReferenciaAutorDelAlta$ = "pr_14630fb2e2x342wd"
      Public Shared PuedeAgregarParticipantes$ = "pr_4f1030ex252wc"
      Public Shared ParticipanteTieneAccesoWeb$ = "pr_146310df5cx25wd"
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
      Public Class ChatSalasListaC
          Public ReferenciaParticipante As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public PuedeEnviarMensajes As Boolean
          Public PuedeSilenciarLaSala As Boolean
          Public PuedeExpulsarAParticipantes As Boolean
          Public DentroDeSala As Boolean
          Public ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public PuedeGestionarMensajesOcultos As Boolean
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public MensajesVisibleDesde_UTC As Date
          Public LeidoHastaObsoleto_UTC As Date
          Public PuedePersonalizarLaSala As Boolean
          Public MensajesVisiblesDesdeObsoleto_UTC As Date
          Public PuedeModificarPermisosDeOtrosParticipantes As Boolean
          Public FechaAlta_UTC As Date
          Public FechaDato_UTC As Date
          Public EmpleadoTieneAccesoWeb As Boolean
          Public RecibidoHastaObsoleto_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public PuedeAgregarParticipantes As Boolean
          Public ParticipanteTieneAccesoWeb As Boolean
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
      Public Class ChatSalasLista_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
          Public property ReferenciaParticipante As Guid
            get
                return me.GetValue_Guid("pr_4f1001dx1e1wc")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_4f1001dx1e1wc", value)
            End Set
          End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_146314aeb7x5dwd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_146314aeb7x5dwd", value)
            End Set
          End Property
          Public property PuedeEnviarMensajes As Boolean
            get
                return me.GetValue_Boolean("pr_1a01911320x30bwd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_1a01911320x30bwd", value)
            End Set
          End Property
          Public property PuedeSilenciarLaSala As Boolean
            get
                return me.GetValue_Boolean("pr_1a195e534fx1bwd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_1a195e534fx1bwd", value)
            End Set
          End Property
          Public property PuedeExpulsarAParticipantes As Boolean
            get
                return me.GetValue_Boolean("pr_4f10360x25fwc")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_4f10360x25fwc", value)
            End Set
          End Property
          Public property DentroDeSala As Boolean
            get
                return me.GetValue_Boolean("pr_4f0ff21x26ewc")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_4f0ff21x26ewc", value)
            End Set
          End Property
          Public property ReferenciaUbicacionPrincipal As Guid
            get
                return me.GetValue_Guid("pr_1464b3f1dag29fwd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_1464b3f1dag29fwd", value)
            End Set
          End Property
          Public property PuedeGestionarMensajesOcultos As Boolean
            get
                return me.GetValue_Boolean("pr_1a1eee7cadx308wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_1a1eee7cadx308wd", value)
            End Set
          End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_776af3awd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_14630fb38bx91wd")
            End Get   
        End Property
          Public property ReferenciaEmpleadoPrincipal As Guid
            get
                return me.GetValue_Guid("pr_1464b3f1dax29fwd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_1464b3f1dax29fwd", value)
            End Set
          End Property
        Public ReadOnly property MensajesVisibleDesde_UTC As Date
            get
                return me.GetValue_DateTime("pr_70ee28fwd")
            End Get   
        End Property
        Public ReadOnly property LeidoHastaObsoleto_UTC As Date
            get
                return me.GetValue_DateTime("pr_4f10656x257wc")
            End Get   
        End Property
          Public property PuedePersonalizarLaSala As Boolean
            get
                return me.GetValue_Boolean("pr_4f1042fx341wc")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_4f1042fx341wc", value)
            End Set
          End Property
          Public property MensajesVisiblesDesdeObsoleto_UTC As Date
            get
                return me.GetValue_DateTime("pr_1a01934f88x3b0wd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_1a01934f88x3b0wd", value)
            End Set
          End Property
          Public property PuedeModificarPermisosDeOtrosParticipantes As Boolean
            get
                return me.GetValue_Boolean("pr_4f104d2x7awc")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_4f104d2x7awc", value)
            End Set
          End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_14c9f3d368x83wd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_14c9f3d368x83wd", value)
            End Set
          End Property
        Public ReadOnly property FechaDato_UTC As Date
            get
                return me.GetValue_DateTime("pr_14630fb30ex36cwd")
            End Get   
        End Property
          Public property EmpleadoTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_1464b59f4dgbdwd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_1464b59f4dgbdwd", value)
            End Set
          End Property
        Public ReadOnly property RecibidoHastaObsoleto_UTC As Date
            get
                return me.GetValue_DateTime("pr_4f105e9x2edwc")
            End Get   
        End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_14630fb2e2x342wd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_14630fb2e2x342wd", value)
            End Set
          End Property
          Public property PuedeAgregarParticipantes As Boolean
            get
                return me.GetValue_Boolean("pr_4f1030ex252wc")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_4f1030ex252wc", value)
            End Set
          End Property
          Public property ParticipanteTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_146310df5cx25wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_146310df5cx25wd", value)
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
        Public ReadOnly property RelacionElementoContenedorListador As Guid
            get
                return me.GetValue_Guid("idrelacionlistador")
            End Get   
        End Property
          Public property Listadoreliminado As Boolean
            get
                return me.GetValue_Boolean("listadoreliminado")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("listadoreliminado", value)
            End Set
          End Property
          Sub New(___VV__ As DinaNETCore.API_VVC , _Token$)
              MyBase.New(___VV__, _Token) 
              Me.Evento_Actualizar()
          End Sub
      End Class
  End Class
End Class
