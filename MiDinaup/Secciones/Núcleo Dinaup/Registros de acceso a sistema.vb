Partial Public Class SeccionesD
  Public Class RegistrosDeAccesoASistemaD
      Public Shared _SeccionID As String = "e489afac-9b55-49eb-bb0d-00d02e192b77"
      Public Shared _SeccionIDGUID As New Guid("e489afac-9b55-49eb-bb0d-00d02e192b77")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As RegistrosDeAccesoASistema_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, RegistrosDeAccesoASistemaES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New RegistrosDeAccesoASistema_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As RegistrosDeAccesoASistema_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, RegistrosDeAccesoASistemaES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New RegistrosDeAccesoASistema_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class RegistrosDeAccesoASistemaES
          Public shared _SeccionID as Guid = New Guid("e489afac-9b55-49eb-bb0d-00d02e192b77")
          Public shared _Tabla$ = "tpr_3fff25bwc"
      Public Shared FechaAlta_UTC$ = "pr_14c9f3dfc2ga0wd"
      Public Shared Equipo$ = "pr_3fff638x74wc"
      Public Shared SistemaOperativo$ = "pr_3fff7cdx15wc"
      Public Shared FechaDato_UTC$ = "pr_1463101298x354wd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_1464b596e0i332wd"
      Public Shared ReferenciaTurnoDeJornadaObsoleto$ = "pr_20040103284"
      Public Shared Tipo$ = "pr_169e9c8ab1x380wd"
      Public Shared DireccionIP$ = "pr_3fff778x1wc"
      Public Shared UsuarioDeWindows$ = "pr_3fff6dex3a7wc"
      Public Shared ReferenciaTurnoObsoleto$ = "pr_184f16e1f5x3b5wd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_1463101259x3b3wd"
      Public Shared ReferenciaPuestoDeTrabajo$ = "pr_18458e2935x28awd"
      Public Shared ReferenciaUbicacionDeConexion$ = "pr_3fffc88xb0wc"
      Public Shared ReferenciaAsignacionDeHorarioObsoleto$ = "pr_20040103285"
      Public Shared ReferenciaJornadaDeHorario$ = "pr_20040103286"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_1464b40bddx112wd"
      Public Shared ReferenciaDestinador$ = "pr_1463101336g2bcwd"
      Public Shared HoraLocal$ = "pr_776aed6wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_1463148f21i143wd"
      Public Shared InformacionAdicional$ = "pr_184f0db33dx173wd"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_1464b40b9fx2dbwd"
      Public Shared ReferenciaJornadaObsoleto$ = "pr_20040103283"
      Public Shared ReferenciaAccesoRelacionado$ = "pr_169efb9314x265wd"
      Public Shared ReferenciaHorarioObsoleto$ = "pr_20040103282"
      Public Shared ReferenciaServidor$ = "pr_40040212262"
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
      Public Class RegistrosDeAccesoASistemaC
          Public FechaAlta_UTC As Date
          Public Equipo As String
          Public SistemaOperativo As String
          Public FechaDato_UTC As Date
          Public EmpleadoTieneAccesoWeb As Boolean
          Public ReferenciaTurnoDeJornadaObsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Tipo As Integer
          Public DireccionIP As String
          Public UsuarioDeWindows As String
          Public ReferenciaTurnoObsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaPuestoDeTrabajo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaUbicacionDeConexion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaAsignacionDeHorarioObsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaJornadaDeHorario As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public InformacionAdicional As String
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaJornadaObsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaAccesoRelacionado As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaHorarioObsoleto As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaServidor As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
      Public Class RegistrosDeAccesoASistema_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
        Public ReadOnly property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_14c9f3dfc2ga0wd")
            End Get   
        End Property
        Public ReadOnly property Equipo As String
            get
                return me.GetValue_String("pr_3fff638x74wc")
            End Get   
        End Property
        Public ReadOnly property SistemaOperativo As String
            get
                return me.GetValue_String("pr_3fff7cdx15wc")
            End Get   
        End Property
        Public ReadOnly property FechaDato_UTC As Date
            get
                return me.GetValue_DateTime("pr_1463101298x354wd")
            End Get   
        End Property
          Public property EmpleadoTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_1464b596e0i332wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_1464b596e0i332wd", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaTurnoDeJornadaObsoleto As Guid
            get
                return me.GetValue_Guid("pr_20040103284")
            End Get   
        End Property
        Public ReadOnly property Tipo As Integer
            get
                return me.GetValue_Integer("pr_169e9c8ab1x380wd")
            End Get   
        End Property
        Public ReadOnly property DireccionIP As String
            get
                return me.GetValue_String("pr_3fff778x1wc")
            End Get   
        End Property
        Public ReadOnly property UsuarioDeWindows As String
            get
                return me.GetValue_String("pr_3fff6dex3a7wc")
            End Get   
        End Property
        Public ReadOnly property ReferenciaTurnoObsoleto As Guid
            get
                return me.GetValue_Guid("pr_184f16e1f5x3b5wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_1463101259x3b3wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaPuestoDeTrabajo As Guid
            get
                return me.GetValue_Guid("pr_18458e2935x28awd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaUbicacionDeConexion As Guid
            get
                return me.GetValue_Guid("pr_3fffc88xb0wc")
            End Get   
        End Property
        Public ReadOnly property ReferenciaAsignacionDeHorarioObsoleto As Guid
            get
                return me.GetValue_Guid("pr_20040103285")
            End Get   
        End Property
          Public property ReferenciaJornadaDeHorario As Guid
            get
                return me.GetValue_Guid("pr_20040103286")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_20040103286", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaUbicacionPrincipal As Guid
            get
                return me.GetValue_Guid("pr_1464b40bddx112wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_1463101336g2bcwd")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_776aed6wd")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_1463148f21i143wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_1463148f21i143wd", value)
            End Set
          End Property
        Public ReadOnly property InformacionAdicional As String
            get
                return me.GetValue_String("pr_184f0db33dx173wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaEmpleadoPrincipal As Guid
            get
                return me.GetValue_Guid("pr_1464b40b9fx2dbwd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaJornadaObsoleto As Guid
            get
                return me.GetValue_Guid("pr_20040103283")
            End Get   
        End Property
        Public ReadOnly property ReferenciaAccesoRelacionado As Guid
            get
                return me.GetValue_Guid("pr_169efb9314x265wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaHorarioObsoleto As Guid
            get
                return me.GetValue_Guid("pr_20040103282")
            End Get   
        End Property
        Public ReadOnly property ReferenciaServidor As Guid
            get
                return me.GetValue_Guid("pr_40040212262")
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
