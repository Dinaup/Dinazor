Partial Public Class SeccionesD
  Public Class BandejasDeCorreosD
      Public Shared _SeccionID As String = "70090a84-24a5-486d-b2d8-7aaff6ed2966"
      Public Shared _SeccionIDGUID As New Guid("70090a84-24a5-486d-b2d8-7aaff6ed2966")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As BandejasDeCorreos_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, BandejasDeCorreosES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New BandejasDeCorreos_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As BandejasDeCorreos_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, BandejasDeCorreosES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New BandejasDeCorreos_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class BandejasDeCorreosES
          Public shared _SeccionID as Guid = New Guid("70090a84-24a5-486d-b2d8-7aaff6ed2966")
          Public shared _Tabla$ = "tpr_20040257111"
      Public Shared ReferenciaDestinador$ = "pr_200402571114"
      Public Shared FechaAlta_UTC$ = "pr_200402571113"
      Public Shared ReferenciaAutorDelAlta$ = "pr_20040257119"
      Public Shared HoraLocal$ = "pr_200402571111"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_200402571125"
      Public Shared FechaDato_UTC$ = "pr_200402571110"
      Public Shared Contenido$ = "pr_300402571127"
      Public Shared HaSidoMarcadoComoCorreoNoDeseado$ = "pr_300402571128"
      Public Shared Asunto$ = "pr_300402571131"
      Public Shared CorreoDestino$ = "pr_300402571130"
      Public Shared EntidadRelacionadaTieneAccesoWeb$ = "pr_40040257112"
      Public Shared ReferenciaEntidadRelacionada$ = "pr_40040257111"
      Public Shared ReferenciaEmpresaRelacionada$ = "pr_40040257113"
      Public Shared Cabecera$ = "pr_40040257114"
      Public Shared CorreoDeOrigen$ = "pr_300402571129"
      Public Shared ReferenciaEstado$ = "pr_500402571131"
      Public Shared IdentificadorUnico$ = "pr_10040257122"
      Public Shared ReferenciaConfiguracionDeCorreo$ = "pr_300402571134"
      Public Shared ReferenciaBuzon$ = "pr_50040257411"
      Public Shared CantidadDeArchivosAdjuntos$ = "pr_60040257111"
      Public Shared FechaDeCorreo_UTC$ = "pr_300402571136"
      Public Shared ReferenciaRegistroRelacionadoSeccion$ = "pr_20040257684"
      Public Shared ReferenciaRegistroRelacionado$ = "pr_20040257682"
      Public Shared Autor$ = "pr_10040408083"
      Public Shared DireccionDeEnvioAlias$ = "pr_10040408084"
      Public Shared DireccionDeRespuesta$ = "pr_10040408085"
      Public Shared MensajeIDEmail$ = "pr_20040452512"
      Public Shared Tipo$ = "pr_50040452752"
      Public Shared Carpeta$ = "pr_10040474828"
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
      Public Class BandejasDeCorreosC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public FechaDato_UTC As Date
          Public Contenido As String
          Public HaSidoMarcadoComoCorreoNoDeseado As Boolean
          Public Asunto As String
          Public CorreoDestino As String
          Public EntidadRelacionadaTieneAccesoWeb As Boolean
          Public ReferenciaEntidadRelacionada As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaEmpresaRelacionada As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Cabecera As String
          Public CorreoDeOrigen As String
          Public ReferenciaEstado As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public IdentificadorUnico As String
          Public ReferenciaConfiguracionDeCorreo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaBuzon As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public CantidadDeArchivosAdjuntos As Integer
          Public FechaDeCorreo_UTC As Date
          Public ReferenciaRegistroRelacionadoSeccion As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaRegistroRelacionado As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Autor As String
          Public DireccionDeEnvioAlias As String
          Public DireccionDeRespuesta As String
          Public MensajeIDEmail As String
          Public Tipo As Integer
          Public Carpeta As String
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
      Public Class BandejasDeCorreos_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_200402571114")
            End Get   
        End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_200402571113")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_200402571113", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_20040257119")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_20040257119", value)
            End Set
          End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_200402571111")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_200402571125")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_200402571125", value)
            End Set
          End Property
          Public property FechaDato_UTC As Date
            get
                return me.GetValue_DateTime("pr_200402571110")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_200402571110", value)
            End Set
          End Property
        Public ReadOnly property Contenido As String
            get
                return me.GetValue_String("pr_300402571127")
            End Get   
        End Property
          Public property HaSidoMarcadoComoCorreoNoDeseado As Boolean
            get
                return me.GetValue_Boolean("pr_300402571128")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_300402571128", value)
            End Set
          End Property
        Public ReadOnly property Asunto As String
            get
                return me.GetValue_String("pr_300402571131")
            End Get   
        End Property
        Public ReadOnly property CorreoDestino As String
            get
                return me.GetValue_String("pr_300402571130")
            End Get   
        End Property
          Public property EntidadRelacionadaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_40040257112")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_40040257112", value)
            End Set
          End Property
          Public property ReferenciaEntidadRelacionada As Guid
            get
                return me.GetValue_Guid("pr_40040257111")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_40040257111", value)
            End Set
          End Property
          Public property ReferenciaEmpresaRelacionada As Guid
            get
                return me.GetValue_Guid("pr_40040257113")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_40040257113", value)
            End Set
          End Property
        Public ReadOnly property Cabecera As String
            get
                return me.GetValue_String("pr_40040257114")
            End Get   
        End Property
        Public ReadOnly property CorreoDeOrigen As String
            get
                return me.GetValue_String("pr_300402571129")
            End Get   
        End Property
          Public property ReferenciaEstado As Guid
            get
                return me.GetValue_Guid("pr_500402571131")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_500402571131", value)
            End Set
          End Property
        Public ReadOnly property IdentificadorUnico As String
            get
                return me.GetValue_String("pr_10040257122")
            End Get   
        End Property
        Public ReadOnly property ReferenciaConfiguracionDeCorreo As Guid
            get
                return me.GetValue_Guid("pr_300402571134")
            End Get   
        End Property
          Public property ReferenciaBuzon As Guid
            get
                return me.GetValue_Guid("pr_50040257411")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_50040257411", value)
            End Set
          End Property
        Public ReadOnly property CantidadDeArchivosAdjuntos As Integer
            get
                return me.GetValue_Integer("pr_60040257111")
            End Get   
        End Property
        Public ReadOnly property FechaDeCorreo_UTC As Date
            get
                return me.GetValue_DateTime("pr_300402571136")
            End Get   
        End Property
        Public ReadOnly property ReferenciaRegistroRelacionadoSeccion As Guid
            get
                return me.GetValue_Guid("pr_20040257684")
            End Get   
        End Property
        Public ReadOnly property ReferenciaRegistroRelacionado As Guid
            get
                return me.GetValue_Guid("pr_20040257682")
            End Get   
        End Property
        Public ReadOnly property Autor As String
            get
                return me.GetValue_String("pr_10040408083")
            End Get   
        End Property
        Public ReadOnly property DireccionDeEnvioAlias As String
            get
                return me.GetValue_String("pr_10040408084")
            End Get   
        End Property
        Public ReadOnly property DireccionDeRespuesta As String
            get
                return me.GetValue_String("pr_10040408085")
            End Get   
        End Property
          Public property MensajeIDEmail As String
            get
                return me.GetValue_String("pr_20040452512")
            End Get
            Set(value As String)
                me.SetValue_String("pr_20040452512", value)
            End Set
          End Property
        Public ReadOnly property Tipo As Integer
            get
                return me.GetValue_Integer("pr_50040452752")
            End Get   
        End Property
        Public ReadOnly property Carpeta As String
            get
                return me.GetValue_String("pr_10040474828")
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
