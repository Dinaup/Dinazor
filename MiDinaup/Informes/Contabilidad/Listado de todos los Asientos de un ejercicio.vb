Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class ContabilidadD
      Public Class ListadoDeTodosLosAsientosDeUnEjercicioC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of ListadoDeTodosLosAsientosDeUnEjercicio_FilaC)
          Public TokenCambios As Guid
          Sub new(Ejercicio As Guid)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("a7fc4acd-a41c-46a7-aeaf-aead9c45a3b6"))
              me.ID = new GUID("a7fc4acd-a41c-46a7-aeaf-aead9c45a3b6")
              me.Titulo  = "Listado de todos los Asientos de un ejercicio"
              Agregar_Respuesta("Ejercicio",Ejercicio)
          End sub
          <ProtoContract>
          Public Class ListadoDeTodosLosAsientosDeUnEjercicio_FilaC
                <ProtoMember(100)>  Public Debe As Decimal
                <ProtoMember(101)>  Public Haber As Decimal
                <ProtoMember(102)>  Public Fecha As Date?
                <ProtoMember(103)>  Public Concepto As String
                <ProtoMember(104)>  Public NAsiento As Integer
                <ProtoMember(105)>  Public Ubicacion As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Debe = o("Debe").DEC
              Me.Haber = o("Haber").DEC
              Me.Fecha = o("Fecha").ToDate
              Me.Concepto = o("Concepto").STR
              Me.NAsiento = o("NAsiento").INT
              Me.Ubicacion = o("Ubicacion").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of ListadoDeTodosLosAsientosDeUnEjercicio_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New ListadoDeTodosLosAsientosDeUnEjercicio_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class