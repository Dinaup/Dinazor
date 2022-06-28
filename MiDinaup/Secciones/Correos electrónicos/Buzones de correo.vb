Partial Public Class SeccionesD
  Public Class BuzonesDeCorreoD
      Public Shared _SeccionID As String = "93dc3756-c5c1-44d8-b11f-a23250336260"
      Public Shared _SeccionIDGUID As New Guid("93dc3756-c5c1-44d8-b11f-a23250336260")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As BuzonesDeCorreo_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, BuzonesDeCorreoES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New BuzonesDeCorreo_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As BuzonesDeCorreo_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, BuzonesDeCorreoES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New BuzonesDeCorreo_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class BuzonesDeCorreoES
          Public shared _SeccionID as Guid = New Guid("93dc3756-c5c1-44d8-b11f-a23250336260")
          Public shared _Tabla$ = "tpr_50040257403"
      Public Shared ReferenciaDestinador$ = "pr_500402574016"
      Public Shared ExportarEnModulos$ = "pr_500402574014"
      Public Shared HoraLocal$ = "pr_500402574013"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_500402574027"
      Public Shared FechaAlta_UTC$ = "pr_500402574015"
      Public Shared ReferenciaAutorDelAlta$ = "pr_500402574011"
      Public Shared ReferenciaCuentaDeCorreo$ = "pr_600402574029"
      Public Shared EtiquetaDelBuzon$ = "pr_40040257411"
      Public Shared ReferenciaEmpresaALaQueAsociarLosCorreos$ = "pr_60040257411"
      Public Shared BuzonDesactivado$ = "pr_40040257422"
      Public Shared ReferenciaSeccionDeDestino1$ = "pr_40040257431"
      Public Shared ReferenciaSeccionDeDestino2$ = "pr_40040257432"
      Public Shared ReferenciaSeccionDeDestino3$ = "pr_40040257433"
      Public Shared ReferenciaSeccionDeDestino4$ = "pr_40040257434"
      Public Shared ReferenciaSeccionDeDestino5$ = "pr_40040257435"
      Public Shared ReferenciaSeccionDeDestino6$ = "pr_40040257436"
      Public Shared EntidadALaQueAsociarLosCorreosTieneAccesoWeb$ = "pr_60040257449"
      Public Shared ReferenciaEntidadALaQueAsociarLosCorreos$ = "pr_60040257448"
      Public Shared ReferenciaEstadoParaNuevos$ = "pr_10040257451"
      Public Shared PermisosDeEnvio$ = "pr_60040257882"
      Public Shared PermisosDeLectura$ = "pr_60040257881"
      Public Shared EtiquetaComoAliasRecomendado$ = "pr_20040474821"
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
      Public Class BuzonesDeCorreoC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public FechaAlta_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaCuentaDeCorreo As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public EtiquetaDelBuzon As String
          Public ReferenciaEmpresaALaQueAsociarLosCorreos As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public BuzonDesactivado As Boolean
          Public ReferenciaSeccionDeDestino1 As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaSeccionDeDestino2 As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaSeccionDeDestino3 As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaSeccionDeDestino4 As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaSeccionDeDestino5 As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaSeccionDeDestino6 As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public EntidadALaQueAsociarLosCorreosTieneAccesoWeb As Boolean
          Public ReferenciaEntidadALaQueAsociarLosCorreos As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaEstadoParaNuevos As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public PermisosDeEnvio As Integer
          Public PermisosDeLectura As Integer
          Public EtiquetaComoAliasRecomendado As Boolean
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
      Public Class BuzonesDeCorreo_FormularioC
        Inherits DinaNETCore.VentanaVirtualC

    Public _Lista As List(Of BuzonesDeCorreoListaD.BuzonesDeCorreoLista_FormularioC)



    Overrides Sub Evento_Actualizar()

        If Me.EsListador Then
            Dim FormLista = Me.__VV__.Formularios_Lista
            Dim CreandoLista As New List(Of BuzonesDeCorreoListaD.BuzonesDeCorreoLista_FormularioC)
            If FormLista IsNot Nothing Then
                For i = 0 To FormLista.Count - 1
                    Dim ElementoLista As New BuzonesDeCorreoListaD.BuzonesDeCorreoLista_FormularioC(Me.__VV__, FormLista(i).Token)
                    CreandoLista.Add(ElementoLista)
                Next
            End If
            _Lista = CreandoLista
        End If

    End Sub

                  


        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_500402574016")
            End Get   
        End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_500402574013")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_500402574027")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_500402574027", value)
            End Set
          End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_500402574015")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_500402574015", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_500402574011")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_500402574011", value)
            End Set
          End Property
          Public property ReferenciaCuentaDeCorreo As Guid
            get
                return me.GetValue_Guid("pr_600402574029")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_600402574029", value)
            End Set
          End Property
          Public property EtiquetaDelBuzon As String
            get
                return me.GetValue_String("pr_40040257411")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040257411", value)
            End Set
          End Property
          Public property ReferenciaEmpresaALaQueAsociarLosCorreos As Guid
            get
                return me.GetValue_Guid("pr_60040257411")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_60040257411", value)
            End Set
          End Property
          Public property BuzonDesactivado As Boolean
            get
                return me.GetValue_Boolean("pr_40040257422")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_40040257422", value)
            End Set
          End Property
          Public property ReferenciaSeccionDeDestino1 As Guid
            get
                return me.GetValue_Guid("pr_40040257431")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_40040257431", value)
            End Set
          End Property
          Public property ReferenciaSeccionDeDestino2 As Guid
            get
                return me.GetValue_Guid("pr_40040257432")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_40040257432", value)
            End Set
          End Property
          Public property ReferenciaSeccionDeDestino3 As Guid
            get
                return me.GetValue_Guid("pr_40040257433")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_40040257433", value)
            End Set
          End Property
          Public property ReferenciaSeccionDeDestino4 As Guid
            get
                return me.GetValue_Guid("pr_40040257434")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_40040257434", value)
            End Set
          End Property
          Public property ReferenciaSeccionDeDestino5 As Guid
            get
                return me.GetValue_Guid("pr_40040257435")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_40040257435", value)
            End Set
          End Property
          Public property ReferenciaSeccionDeDestino6 As Guid
            get
                return me.GetValue_Guid("pr_40040257436")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_40040257436", value)
            End Set
          End Property
          Public property EntidadALaQueAsociarLosCorreosTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_60040257449")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_60040257449", value)
            End Set
          End Property
          Public property ReferenciaEntidadALaQueAsociarLosCorreos As Guid
            get
                return me.GetValue_Guid("pr_60040257448")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_60040257448", value)
            End Set
          End Property
          Public property ReferenciaEstadoParaNuevos As Guid
            get
                return me.GetValue_Guid("pr_10040257451")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_10040257451", value)
            End Set
          End Property
        Public ReadOnly property PermisosDeEnvio As Integer
            get
                return me.GetValue_Integer("pr_60040257882")
            End Get   
        End Property
        Public ReadOnly property PermisosDeLectura As Integer
            get
                return me.GetValue_Integer("pr_60040257881")
            End Get   
        End Property
        Public ReadOnly property EtiquetaComoAliasRecomendado As Boolean
            get
                return me.GetValue_Boolean("pr_20040474821")
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
