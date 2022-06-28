Partial Public Class SeccionesD
  Public Class UbicacionesD
      Public Shared _SeccionID As String = "b9adbfbf-a81a-45fb-861c-90502902c982"
      Public Shared _SeccionIDGUID As New Guid("b9adbfbf-a81a-45fb-861c-90502902c982")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As Ubicaciones_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, UbicacionesES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New Ubicaciones_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As Ubicaciones_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, UbicacionesES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New Ubicaciones_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class UbicacionesES
          Public shared _SeccionID as Guid = New Guid("b9adbfbf-a81a-45fb-861c-90502902c982")
          Public shared _Tabla$ = "tpr_1549n"
      Public Shared Direccion$ = "pr_1553n"
      Public Shared CodigoPostal$ = "pr_1554n"
      Public Shared FechaAlta_UTC$ = "pr_14c9f3de68x33ewd"
      Public Shared FechaReferenciaEnvioSC_UTC$ = "pr_6f300a7wd"
      Public Shared ReferenciaFoto1$ = "pr_1557n"
      Public Shared IdentificadorExtra3$ = "pr_6f4a573wd"
      Public Shared ReferenciaAutorDelAlta$ = "pr_14631007adx324wd"
      Public Shared FechaReferenciaRecepcionSC_UTC$ = "pr_6f30866wd"
      Public Shared ConexionEstablecida$ = "pr_1a0e957255x2efwd"
      Public Shared Telefono$ = "pr_1552n"
      Public Shared NumeroDeSerie$ = "pr_1550n"
      Public Shared FechaSISC_UTC$ = "pr_6f300abwd"
      Public Shared ReferenciaUbicacionSC$ = "pr_6f300a3wd"
      Public Shared IdentificadorExtra1$ = "pr_6f4a56bwd"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_146314a46ax17ewd"
      Public Shared HoraLocal$ = "pr_776aee0wd"
      Public Shared ReferenciaDestinador$ = "pr_146310087cx3cwd"
      Public Shared ReferenciaUbicacionBase$ = "pr_60040114662"
      Public Shared IdentificadorExtra4$ = "pr_6f4a577wd"
      Public Shared IdentificadorExtra2$ = "pr_6f4a56fwd"
      Public Shared ReferenciaDatosFiscales$ = "pr_50040138791"
      Public Shared NombrePublico$ = "pr_40040179921"
      Public Shared ReferenciaServidor$ = "pr_20040209431"
      Public Shared Observaciones$ = "pr_1551n"
      Public Shared TodosLosEmpleadosTienenAcceso$ = "pr_40040480313"
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
      Public Class UbicacionesC
          Public Direccion As String
          Public CodigoPostal As String
          Public FechaAlta_UTC As Date
          Public FechaReferenciaEnvioSC_UTC As Date
          Public ReferenciaFoto1 As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public IdentificadorExtra3 As String
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public FechaReferenciaRecepcionSC_UTC As Date
          Public ConexionEstablecida As Boolean
          Public Telefono As String
          Public NumeroDeSerie As String
          Public FechaSISC_UTC As Date
          Public ReferenciaUbicacionSC As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public IdentificadorExtra1 As String
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaUbicacionBase As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public IdentificadorExtra4 As String
          Public IdentificadorExtra2 As String
          Public ReferenciaDatosFiscales As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public NombrePublico As String
          Public ReferenciaServidor As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public Observaciones As String
          Public TodosLosEmpleadosTienenAcceso As Boolean
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
      Public Class Ubicaciones_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
        Public ReadOnly property Direccion As String
            get
                return me.GetValue_String("pr_1553n")
            End Get   
        End Property
        Public ReadOnly property CodigoPostal As String
            get
                return me.GetValue_String("pr_1554n")
            End Get   
        End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_14c9f3de68x33ewd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_14c9f3de68x33ewd", value)
            End Set
          End Property
        Public ReadOnly property FechaReferenciaEnvioSC_UTC As Date
            get
                return me.GetValue_DateTime("pr_6f300a7wd")
            End Get   
        End Property
          Public property ReferenciaFoto1 As Guid
            get
                return me.GetValue_Guid("pr_1557n")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_1557n", value)
            End Set
          End Property
        Public ReadOnly property IdentificadorExtra3 As String
            get
                return me.GetValue_String("pr_6f4a573wd")
            End Get   
        End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_14631007adx324wd")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_14631007adx324wd", value)
            End Set
          End Property
          Public property FechaReferenciaRecepcionSC_UTC As Date
            get
                return me.GetValue_DateTime("pr_6f30866wd")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_6f30866wd", value)
            End Set
          End Property
        Public ReadOnly property ConexionEstablecida As Boolean
            get
                return me.GetValue_Boolean("pr_1a0e957255x2efwd")
            End Get   
        End Property
        Public ReadOnly property Telefono As String
            get
                return me.GetValue_String("pr_1552n")
            End Get   
        End Property
        Public ReadOnly property NumeroDeSerie As String
            get
                return me.GetValue_String("pr_1550n")
            End Get   
        End Property
        Public ReadOnly property FechaSISC_UTC As Date
            get
                return me.GetValue_DateTime("pr_6f300abwd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaUbicacionSC As Guid
            get
                return me.GetValue_Guid("pr_6f300a3wd")
            End Get   
        End Property
        Public ReadOnly property IdentificadorExtra1 As String
            get
                return me.GetValue_String("pr_6f4a56bwd")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_146314a46ax17ewd")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_146314a46ax17ewd", value)
            End Set
          End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_776aee0wd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_146310087cx3cwd")
            End Get   
        End Property
        Public ReadOnly property ReferenciaUbicacionBase As Guid
            get
                return me.GetValue_Guid("pr_60040114662")
            End Get   
        End Property
        Public ReadOnly property IdentificadorExtra4 As String
            get
                return me.GetValue_String("pr_6f4a577wd")
            End Get   
        End Property
        Public ReadOnly property IdentificadorExtra2 As String
            get
                return me.GetValue_String("pr_6f4a56fwd")
            End Get   
        End Property
          Public property ReferenciaDatosFiscales As Guid
            get
                return me.GetValue_Guid("pr_50040138791")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_50040138791", value)
            End Set
          End Property
          Public property NombrePublico As String
            get
                return me.GetValue_String("pr_40040179921")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040179921", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaServidor As Guid
            get
                return me.GetValue_Guid("pr_20040209431")
            End Get   
        End Property
          Public property Observaciones As String
            get
                return me.GetValue_String("pr_1551n")
            End Get
            Set(value As String)
                me.SetValue_String("pr_1551n", value)
            End Set
          End Property
          Public property TodosLosEmpleadosTienenAcceso As Boolean
            get
                return me.GetValue_Boolean("pr_40040480313")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_40040480313", value)
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
