Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class EjerciciosContablesAsientosEspecialesC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of EjerciciosContablesAsientosEspeciales_FilaC)
          Public TokenCambios As Guid
          Sub new(Ejercicio As Guid)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("70bfe769-b036-4fe7-9876-dcd126351e8c"))
              me.ID = new GUID("70bfe769-b036-4fe7-9876-dcd126351e8c")
              me.Titulo  = "Ejercicios contables > Asientos especiales"
              Agregar_Respuesta("Ejercicio",Ejercicio)
          End sub
          <ProtoContract>
          Public Class EjerciciosContablesAsientosEspeciales_FilaC
                <ProtoMember(100)>  Public Debe As Decimal
                <ProtoMember(101)>  Public Haber As Decimal
                <ProtoMember(102)>  Public Tipo As Integer
                <ProtoMember(103)>  Public Concepto As String
                <ProtoMember(104)>  Public N As String
                <ProtoMember(105)>  Public Fecha As Date?
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Debe = o("Debe").DEC
              Me.Haber = o("Haber").DEC
              Me.Tipo = ctype(o("Tipo").INT(0), EnumAsientoE)
              Me.Concepto = o("Concepto").STR
              Me.N = o("N").STR
              Me.Fecha = o("Fecha").ToDate
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of EjerciciosContablesAsientosEspeciales_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New EjerciciosContablesAsientosEspeciales_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class