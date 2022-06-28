Partial Public Class SeccionesD
  Public Class AnotacionesInternasListaD
      Public Shared _SeccionID As String = "61675f53-408f-44ad-8505-4767bb1a6322"
      Public Shared _SeccionIDGUID As New Guid("61675f53-408f-44ad-8505-4767bb1a6322")
      Public Class AnotacionesInternasListaES
          Public shared _SeccionID as Guid = New Guid("61675f53-408f-44ad-8505-4767bb1a6322")
          Public shared _Tabla$ = "tpr_72cffdfxd_e"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_72d003bwd"
      Public Shared FechaAlta_UTC$ = "pr_72cfffbwd"
      Public Shared FechaDato_UTC$ = "pr_72cfff7wd"
      Public Shared NotificacionRevisada$ = "pr_72ed22fwd"
      Public Shared DatoAdjuntoNombre$ = "pr_72ed933wd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_72cfff3wd"
      Public Shared EmpleadoMencionadoTieneAccesoWeb$ = "pr_72ed227wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_72d0047wd"
      Public Shared ReferenciaEmpleadoMencionado$ = "pr_72ed223wd"
      Public Shared HoraLocal$ = "pr_77611d4wd"
      Public Shared ReferenciaDestinador$ = "pr_72d0007wd"
      Public Shared ReferenciaSeccionAdjuntada$ = "pr_72ed92bwd"
      Public Shared ReferenciaDatoAdjunto$ = "pr_72ed92fwd"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_72cffebwd"
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
      Public Class AnotacionesInternasListaC
          Public EmpleadoTieneAccesoWeb As Boolean
          Public FechaAlta_UTC As Date
          Public FechaDato_UTC As Date
          Public NotificacionRevisada As Boolean
          Public DatoAdjuntoNombre As String
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public EmpleadoMencionadoTieneAccesoWeb As Boolean
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaEmpleadoMencionado As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaSeccionAdjuntada As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaDatoAdjunto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
      Public Class AnotacionesInternasLista_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
          Public property EmpleadoTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_72d003bwd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_72d003bwd", value)
            End Set
          End Property
        Public ReadOnly property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_72cfffbwd")
            End Get   
        End Property
        Public ReadOnly property FechaDato_UTC As Date
            get
                return me.GetValue_DateTime("pr_72cfff7wd")
            End Get   
        End Property
        Public ReadOnly property NotificacionRevisada As Boolean
            get
                return me.GetValue_Boolean("pr_72ed22fwd")
            End Get   
        End Property
        Public ReadOnly property DatoAdjuntoNombre As String
            get
                return me.GetValue_String("pr_72ed933wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_72cfff3wd")
            End Get   
        End Property
          Public property EmpleadoMencionadoTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_72ed227wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_72ed227wd", value)
            End Set
          End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_72d0047wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_72d0047wd", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaEmpleadoMencionado As Guid
            get
                return me.GetValue_Guid("pr_72ed223wd")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_77611d4wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_72d0007wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaSeccionAdjuntada As Guid
            get
                return me.GetValue_Guid("pr_72ed92bwd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDatoAdjunto As Guid
            get
                return me.GetValue_Guid("pr_72ed92fwd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaEmpleadoPrincipal As Guid
            get
                return me.GetValue_Guid("pr_72cffebwd")
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
