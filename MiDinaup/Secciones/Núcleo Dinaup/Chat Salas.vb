Partial Public Class SeccionesD
  Public Class ChatSalasD
      Public Shared _SeccionID As String = "dd11a9f1-aeed-4ce1-8ba0-fbc16e406838"
      Public Shared _SeccionIDGUID As New Guid("dd11a9f1-aeed-4ce1-8ba0-fbc16e406838")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As ChatSalas_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, ChatSalasES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New ChatSalas_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As ChatSalas_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, ChatSalasES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New ChatSalas_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class ChatSalasES
          Public shared _SeccionID as Guid = New Guid("dd11a9f1-aeed-4ce1-8ba0-fbc16e406838")
          Public shared _Tabla$ = "tpr_4f0f6dfwc"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_1464b59a53i123wd"
      Public Shared TotalParticipantes$ = "pr_4f0f927xbewc"
      Public Shared FechaAlta_UTC$ = "pr_14c9f3ef0cx38fwd"
      Public Shared FechaDato_UTC$ = "pr_14631070b4i371wd"
      Public Shared Descripcion$ = "pr_4f0f877x2eewc"
      Public Shared ReferenciaAutorDelAlta$ = "pr_14631070b4h371wd"
      Public Shared HoraLocal$ = "pr_776ae32wd"
      Public Shared TotalParticipantesEnSala$ = "pr_4f0f9b4x186wc"
      Public Shared ParticipantesFueraDeSala$ = "pr_4f0f9fex383wc"
      Public Shared ReferenciaDestinador$ = "pr_14631071e6x31ewd"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_1464b4264ehe0wd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_146314933dx2acwd"
      Public Shared SalaArchivada$ = "pr_1a01ad7603xfcwd"
      Public Shared ReferenciaImagenDeSala$ = "pr_4f0f8bax1a8wc"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_1464b4264ege0wd"
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
      Public Class ChatSalasC
          Public EmpleadoTieneAccesoWeb As Boolean
          Public TotalParticipantes As Integer
          Public FechaAlta_UTC As Date
          Public FechaDato_UTC As Date
          Public Descripcion As String
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public TotalParticipantesEnSala As Integer
          Public ParticipantesFueraDeSala As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public SalaArchivada As Boolean
          Public ReferenciaImagenDeSala As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
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
          Sub new()
          End Sub
      End Class
      Public Class ChatSalas_FormularioC
        Inherits DinaNETCore.VentanaVirtualC

    Public _Lista As List(Of ChatSalasListaD.ChatSalasLista_FormularioC)



    Overrides Sub Evento_Actualizar()

        If Me.EsListador Then
            Dim FormLista = Me.__VV__.Formularios_Lista
            Dim CreandoLista As New List(Of ChatSalasListaD.ChatSalasLista_FormularioC)
            If FormLista IsNot Nothing Then
                For i = 0 To FormLista.Count - 1
                    Dim ElementoLista As New ChatSalasListaD.ChatSalasLista_FormularioC(Me.__VV__, FormLista(i).Token)
                    CreandoLista.Add(ElementoLista)
                Next
            End If
            _Lista = CreandoLista
        End If

    End Sub

                  


          Public property EmpleadoTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_1464b59a53i123wd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_1464b59a53i123wd", value)
            End Set
          End Property
        Public ReadOnly property TotalParticipantes As Integer
            get
                return me.GetValue_Integer("pr_4f0f927xbewc")
            End Get   
        End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_14c9f3ef0cx38fwd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_14c9f3ef0cx38fwd", value)
            End Set
          End Property
          Public property FechaDato_UTC As Date
            get
                return me.GetValue_DateTime("pr_14631070b4i371wd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_14631070b4i371wd", value)
            End Set
          End Property
          Public property Descripcion As String
            get
                return me.GetValue_String("pr_4f0f877x2eewc")
            End Get
            Set(value As String)
                me.SetValue_String("pr_4f0f877x2eewc", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_14631070b4h371wd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_14631070b4h371wd", value)
            End Set
          End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_776ae32wd")
            End Get   
        End Property
        Public ReadOnly property TotalParticipantesEnSala As Integer
            get
                return me.GetValue_Integer("pr_4f0f9b4x186wc")
            End Get   
        End Property
        Public ReadOnly property ParticipantesFueraDeSala As Integer
            get
                return me.GetValue_Integer("pr_4f0f9fex383wc")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_14631071e6x31ewd")
            End Get   
        End Property
          Public property ReferenciaUbicacionPrincipal As Guid
            get
                return me.GetValue_Guid("pr_1464b4264ehe0wd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_1464b4264ehe0wd", value)
            End Set
          End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_146314933dx2acwd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_146314933dx2acwd", value)
            End Set
          End Property
          Public property SalaArchivada As Boolean
            get
                return me.GetValue_Boolean("pr_1a01ad7603xfcwd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_1a01ad7603xfcwd", value)
            End Set
          End Property
          Public property ReferenciaImagenDeSala As Guid
            get
                return me.GetValue_Guid("pr_4f0f8bax1a8wc")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_4f0f8bax1a8wc", value)
            End Set
          End Property
          Public property ReferenciaEmpleadoPrincipal As Guid
            get
                return me.GetValue_Guid("pr_1464b4264ege0wd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_1464b4264ege0wd", value)
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
