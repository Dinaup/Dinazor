﻿Partial Public Class SeccionesD
  Public Class GruposDeUbicacionesD
      Public Shared _SeccionID As String = "7ef065f0-6d28-451c-9417-298267d88fda"
      Public Shared _SeccionIDGUID As New Guid("7ef065f0-6d28-451c-9417-298267d88fda")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As GruposDeUbicaciones_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, GruposDeUbicacionesES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New GruposDeUbicaciones_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As GruposDeUbicaciones_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, GruposDeUbicacionesES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New GruposDeUbicaciones_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class GruposDeUbicacionesES
          Public shared _SeccionID as Guid = New Guid("7ef065f0-6d28-451c-9417-298267d88fda")
          Public shared _Tabla$ = "tpr_20040180171"
      Public Shared ReferenciaDestinador$ = "pr_200401801712"
      Public Shared FechaAlta_UTC$ = "pr_200401801711"
      Public Shared ExportarEnModulos$ = "pr_200401801710"
      Public Shared ReferenciaAutorDelAlta$ = "pr_20040180177"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_200401801723"
      Public Shared HoraLocal$ = "pr_20040180179"
      Public Shared Observaciones$ = "pr_200401801726"
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
      Public Class GruposDeUbicacionesC
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaAlta_UTC As Date
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public HoraLocal As Integer
          Public Observaciones As String
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
      Public Class GruposDeUbicaciones_FormularioC
        Inherits DinaNETCore.VentanaVirtualC

    Public _Lista As List(Of GruposDeUbicacionesListaD.GruposDeUbicacionesLista_FormularioC)



    Overrides Sub Evento_Actualizar()

        If Me.EsListador Then
            Dim FormLista = Me.__VV__.Formularios_Lista
            Dim CreandoLista As New List(Of GruposDeUbicacionesListaD.GruposDeUbicacionesLista_FormularioC)
            If FormLista IsNot Nothing Then
                For i = 0 To FormLista.Count - 1
                    Dim ElementoLista As New GruposDeUbicacionesListaD.GruposDeUbicacionesLista_FormularioC(Me.__VV__, FormLista(i).Token)
                    CreandoLista.Add(ElementoLista)
                Next
            End If
            _Lista = CreandoLista
        End If

    End Sub

                  


        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_200401801712")
            End Get   
        End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_200401801711")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_200401801711", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_20040180177")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_20040180177", value)
            End Set
          End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_200401801723")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_200401801723", value)
            End Set
          End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_20040180179")
            End Get   
        End Property
          Public property Observaciones As String
            get
                return me.GetValue_String("pr_200401801726")
            End Get
            Set(value As String)
                me.SetValue_String("pr_200401801726", value)
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
