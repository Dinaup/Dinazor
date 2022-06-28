Partial Public Class SeccionesD
  Public Class ControlDePresenciaD
      Public Shared _SeccionID As String = "cab883f0-069c-4a69-b15d-554746f347e5"
      Public Shared _SeccionIDGUID As New Guid("cab883f0-069c-4a69-b15d-554746f347e5")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As ControlDePresencia_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, ControlDePresenciaES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New ControlDePresencia_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As ControlDePresencia_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, ControlDePresenciaES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New ControlDePresencia_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class ControlDePresenciaES
          Public shared _SeccionID as Guid = New Guid("cab883f0-069c-4a69-b15d-554746f347e5")
          Public shared _Tabla$ = "tpr_63535efxd"
      Public Shared FechaAlta_UTC$ = "pr_183fdac389x47wd"
      Public Shared FechaDato_UTC$ = "pr_183fe68584xa8wd"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_183fe84035x3b3wd"
      Public Shared ReferenciaJornada$ = "pr_30040103151"
      Public Shared ReferenciaControlRelativo$ = "pr_1844a51abdx22dwd"
      Public Shared ReferenciaTurnoDeJornada$ = "pr_30040103152"
      Public Shared ReferenciaAutorDelAlta$ = "pr_183fdac371x2fwd"
      Public Shared ReferenciaUltimoCierreDeSesionEnTurnoSesion$ = "pr_18601891e8x258wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_183fdde8e4x376wd"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_183fe6856ex297wd"
      Public Shared HoraLocal$ = "pr_776aebewd"
      Public Shared ReferenciaHorario$ = "pr_183feba35cx3c6wd"
      Public Shared ReferenciaDestinador$ = "pr_183fdac3c6x81wd"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_183fe6855ax276wd"
      Public Shared ReferenciaJornadaDeHorario$ = "pr_183fec773dxc7wd"
      Public Shared TipoAccion$ = "pr_7c219fbwd"
      Public Shared ReferenciaAsignacionDeHorario$ = "pr_30040103155"
      Public Shared DiferenciaEnMinutos$ = "pr_1844ca9f9cx61wd"
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
      Public Class ControlDePresenciaC
          Public FechaAlta_UTC As Date
          Public FechaDato_UTC As Date
          Public EmpleadoTieneAccesoWeb As Boolean
          Public ReferenciaJornada As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaControlRelativo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaTurnoDeJornada As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaUltimoCierreDeSesionEnTurnoSesion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public ReferenciaHorario As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaJornadaDeHorario As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public TipoAccion As Integer
          Public ReferenciaAsignacionDeHorario As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public DiferenciaEnMinutos As Integer
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
      Public Class ControlDePresencia_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
        Public ReadOnly property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_183fdac389x47wd")
            End Get   
        End Property
        Public ReadOnly property FechaDato_UTC As Date
            get
                return me.GetValue_DateTime("pr_183fe68584xa8wd")
            End Get   
        End Property
          Public property EmpleadoTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_183fe84035x3b3wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_183fe84035x3b3wd", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaJornada As Guid
            get
                return me.GetValue_Guid("pr_30040103151")
            End Get   
        End Property
        Public ReadOnly property ReferenciaControlRelativo As Guid
            get
                return me.GetValue_Guid("pr_1844a51abdx22dwd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaTurnoDeJornada As Guid
            get
                return me.GetValue_Guid("pr_30040103152")
            End Get   
        End Property
        Public ReadOnly property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_183fdac371x2fwd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaUltimoCierreDeSesionEnTurnoSesion As Guid
            get
                return me.GetValue_Guid("pr_18601891e8x258wd")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_183fdde8e4x376wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_183fdde8e4x376wd", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaUbicacionPrincipal As Guid
            get
                return me.GetValue_Guid("pr_183fe6856ex297wd")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_776aebewd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaHorario As Guid
            get
                return me.GetValue_Guid("pr_183feba35cx3c6wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_183fdac3c6x81wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaEmpleadoPrincipal As Guid
            get
                return me.GetValue_Guid("pr_183fe6855ax276wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaJornadaDeHorario As Guid
            get
                return me.GetValue_Guid("pr_183fec773dxc7wd")
            End Get   
        End Property
        Public ReadOnly property TipoAccion As Integer
            get
                return me.GetValue_Integer("pr_7c219fbwd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaAsignacionDeHorario As Guid
            get
                return me.GetValue_Guid("pr_30040103155")
            End Get   
        End Property
        Public ReadOnly property DiferenciaEnMinutos As Integer
            get
                return me.GetValue_Integer("pr_1844ca9f9cx61wd")
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
