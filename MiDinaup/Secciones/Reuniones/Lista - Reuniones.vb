Partial Public Class SeccionesD
  Public Class ReunionesListaD
      Public Shared _SeccionID As String = "f35f6ad8-dd78-4e75-8a74-217385df4d71"
      Public Shared _SeccionIDGUID As New Guid("f35f6ad8-dd78-4e75-8a74-217385df4d71")
      Public Class ReunionesListaES
          Public shared _SeccionID as Guid = New Guid("f35f6ad8-dd78-4e75-8a74-217385df4d71")
          Public shared _Tabla$ = "tpr_7c1098axd_e"
      Public Shared AsistenteTieneAccesoWeb$ = "pr_7c11367wd"
      Public Shared FechaAlta_UTC$ = "pr_7c109b6wd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_7c109b0wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_7c109c2wd"
      Public Shared HoraLocal$ = "pr_7c109b4wd"
      Public Shared ReferenciaDestinador$ = "pr_7c109bcwd"
      Public Shared ReferenciaAsistente$ = "pr_7c11365wd"
      Public Shared HaLlegadoTardeObsoleto$ = "pr_30040147532"
      Public Shared Ponente$ = "pr_30040147534"
      Public Shared HaAportadoIdeas$ = "pr_30040147533"
      Public Shared AnotacionesSobreLaAsistencia$ = "pr_40040147531"
      Public Shared AusenciaObsoleto$ = "pr_30040147531"
      Public Shared Asistencia$ = "pr_60040404262"
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
      Public Class ReunionesListaC
          Public AsistenteTieneAccesoWeb As Boolean
          Public FechaAlta_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaAsistente As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HaLlegadoTardeObsoleto As Boolean
          Public Ponente As Boolean
          Public HaAportadoIdeas As Boolean
          Public AnotacionesSobreLaAsistencia As String
          Public AusenciaObsoleto As Boolean
          Public Asistencia As Integer
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
      Public Class ReunionesLista_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
          Public property AsistenteTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_7c11367wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_7c11367wd", value)
            End Set
          End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_7c109b6wd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_7c109b6wd", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_7c109b0wd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_7c109b0wd", value)
            End Set
          End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_7c109c2wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_7c109c2wd", value)
            End Set
          End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_7c109b4wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_7c109bcwd")
            End Get   
        End Property
          Public property ReferenciaAsistente As Guid
            get
                return me.GetValue_Guid("pr_7c11365wd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_7c11365wd", value)
            End Set
          End Property
          Public property HaLlegadoTardeObsoleto As Boolean
            get
                return me.GetValue_Boolean("pr_30040147532")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_30040147532", value)
            End Set
          End Property
          Public property Ponente As Boolean
            get
                return me.GetValue_Boolean("pr_30040147534")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_30040147534", value)
            End Set
          End Property
          Public property HaAportadoIdeas As Boolean
            get
                return me.GetValue_Boolean("pr_30040147533")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_30040147533", value)
            End Set
          End Property
          Public property AnotacionesSobreLaAsistencia As String
            get
                return me.GetValue_String("pr_40040147531")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040147531", value)
            End Set
          End Property
          Public property AusenciaObsoleto As Boolean
            get
                return me.GetValue_Boolean("pr_30040147531")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_30040147531", value)
            End Set
          End Property
          Public property Asistencia As Integer
            get
                return me.GetValue_Integer("pr_60040404262")
            End Get
            Set(value As Integer)
                me.SetValue_Integer("pr_60040404262", value)
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
