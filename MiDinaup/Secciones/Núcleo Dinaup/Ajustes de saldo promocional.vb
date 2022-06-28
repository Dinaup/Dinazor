﻿Partial Public Class SeccionesD
  Public Class AjustesDeSaldoPromocionalD
      Public Shared _SeccionID As String = "12984b99-7743-4fda-a404-52b2764002fc"
      Public Shared _SeccionIDGUID As New Guid("12984b99-7743-4fda-a404-52b2764002fc")
      Public Shared Function AbrirVentana_Agregar(DinaupSesion As DinaNETCore.APID.DinaupSesionC) As AjustesDeSaldoPromocional_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, AjustesDeSaldoPromocionalES._SeccionID, "id", "")
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New AjustesDeSaldoPromocional_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Shared Function AbrirVentana_Editar(DinaupSesion As DinaNETCore.APID.DinaupSesionC, Campo$, Valor$) As AjustesDeSaldoPromocional_FormularioC
          Dim Form_Nuevo = DinaupSesion.ConexionServidor.Funcion_Formulario_Abrir(DinaupSesion, AjustesDeSaldoPromocionalES._SeccionID,Campo, Valor)
          Dim API_VV = New DinaNETCore.API_VVC
          API_VV.Actualizar(Form_Nuevo)
          Return New AjustesDeSaldoPromocional_FormularioC(API_VV, API_VV.TokenListador)
      End Function
      Public Class AjustesDeSaldoPromocionalES
          Public shared _SeccionID as Guid = New Guid("12984b99-7743-4fda-a404-52b2764002fc")
          Public shared _Tabla$ = "tpr_20040113181"
      Public Shared FechaDato_UTC$ = "pr_20040113188"
      Public Shared FechaAlta_UTC$ = "pr_200401131811"
      Public Shared EmpleadoTieneAccesoWeb$ = "pr_200401131824"
      Public Shared ImporteImporte$ = "pr_200401131828"
      Public Shared ReferenciaAutorDelAlta$ = "pr_20040113187"
      Public Shared ReferenciaMovimientoInterno$ = "pr_200401131825"
      Public Shared ClienteTieneAccesoWeb$ = "pr_200401131827"
      Public Shared ReferenciaUbicacionPrincipal$ = "pr_20040113186"
      Public Shared ReferenciaCliente$ = "pr_200401131826"
      Public Shared HoraLocal$ = "pr_20040113189"
      Public Shared ReferenciaDestinador$ = "pr_200401131812"
      Public Shared AutorDelAltaTieneAccesoWeb$ = "pr_200401131822"
      Public Shared ReferenciaEmpleadoPrincipal$ = "pr_20040113185"
      Public Shared MotivoDelAjuste$ = "pr_40040242732"
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
      Public Class AjustesDeSaldoPromocionalC
          Public FechaDato_UTC As Date
          Public FechaAlta_UTC As Date
          Public EmpleadoTieneAccesoWeb As Boolean
          Public ImporteImporte As Decimal
          Public ReferenciaAutorDelAlta As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaMovimientoInterno As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ClienteTieneAccesoWeb As Boolean
          Public ReferenciaUbicacionPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public ReferenciaCliente As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public HoraLocal As Integer
          Public ReferenciaDestinador As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public AutorDelAltaTieneAccesoWeb As Boolean
          Public ReferenciaEmpleadoPrincipal As DinaNETCore.APID.DinaupAPI_IdentificacionRegistroC
          Public MotivoDelAjuste As String
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
      Public Class AjustesDeSaldoPromocional_FormularioC
        Inherits DinaNETCore.VentanaVirtualC
    Overrides Sub Evento_Actualizar()
    End Sub
          Public property FechaDato_UTC As Date
            get
                return me.GetValue_DateTime("pr_20040113188")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_20040113188", value)
            End Set
          End Property
          Public property FechaAlta_UTC As Date
            get
                return me.GetValue_DateTime("pr_200401131811")
            End Get
            Set(value As Date)
                me.SetValue_DateTime("pr_200401131811", value)
            End Set
          End Property
          Public property EmpleadoTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_200401131824")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_200401131824", value)
            End Set
          End Property
          Public property ImporteImporte As Decimal
            get
                return me.GetValue_Decimal("pr_200401131828")
            End Get
            Set(value As Decimal)
                me.SetValue_Decimal("pr_200401131828", value)
            End Set
          End Property
          Public property ReferenciaAutorDelAlta As Guid
            get
                return me.GetValue_Guid("pr_20040113187")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_20040113187", value)
            End Set
          End Property
        Public ReadOnly property ReferenciaMovimientoInterno As Guid
            get
                return me.GetValue_Guid("pr_200401131825")
            End Get   
        End Property
          Public property ClienteTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_200401131827")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_200401131827", value)
            End Set
          End Property
          Public property ReferenciaUbicacionPrincipal As Guid
            get
                return me.GetValue_Guid("pr_20040113186")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_20040113186", value)
            End Set
          End Property
          Public property ReferenciaCliente As Guid
            get
                return me.GetValue_Guid("pr_200401131826")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_200401131826", value)
            End Set
          End Property
        Public ReadOnly property HoraLocal As Integer
            get
                return me.GetValue_Integer("pr_20040113189")
            End Get   
        End Property
        Public ReadOnly property ReferenciaDestinador As Guid
            get
                return me.GetValue_Guid("pr_200401131812")
            End Get   
        End Property
          Public property AutorDelAltaTieneAccesoWeb As Boolean
            get
                return me.GetValue_Boolean("pr_200401131822")
            End Get
            Set(value As Boolean)
                me.SetValue_Boolean("pr_200401131822", value)
            End Set
          End Property
          Public property ReferenciaEmpleadoPrincipal As Guid
            get
                return me.GetValue_Guid("pr_20040113185")
            End Get
            Set(value As Guid)
                me.SetValue_Guid("pr_20040113185", value)
            End Set
          End Property
          Public property MotivoDelAjuste As String
            get
                return me.GetValue_String("pr_40040242732")
            End Get
            Set(value As String)
                me.SetValue_String("pr_40040242732", value)
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
