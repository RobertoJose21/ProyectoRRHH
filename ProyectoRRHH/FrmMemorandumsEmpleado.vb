Imports System.Data.SqlClient

Public Class FrmMemorandumsEmpleado
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            Dim oConeccion As New SqlConnection
            Dim oComando As New SqlCommand
            Dim oLector As SqlDataReader
            Dim oFila As ListViewItem
            oConeccion.ConnectionString = "Server=(local);Integrated Security=true;Database=BD_RecursosHumanos"
            oConeccion.Open()
            oComando.CommandText = "ProdEmpleado_Memorandum"
            oComando.CommandType = CommandType.StoredProcedure
            oComando.Parameters.Add("@NombreEmpleado", SqlDbType.VarChar, 40).Value = ComboBox1.Text
            oComando.Connection = oConeccion
            Me.ListView1.Items.Clear()
            oLector = oComando.ExecuteReader
            If oLector.HasRows = True Then
                While oLector.Read
                    oFila = New ListViewItem
                    oFila.Text = CStr(oLector.Item(0))
                    oFila.SubItems.Add(CStr(oLector.Item(1)))
                    oFila.SubItems.Add(CStr(oLector.Item(2)))
                    oFila.SubItems.Add(CStr(oLector.Item(3)))
                    Me.ListView1.Items.Add(oFila)
                End While
            End If
            oConeccion.Close()
            oConeccion.Dispose()
            oLector.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FrmMemorandumsEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_RecursosHumanosDataSet.V_ApellidosyNombresEmpleados' Puede moverla o quitarla según sea necesario.
        Me.V_ApellidosyNombresEmpleadosTableAdapter.Fill(Me.BD_RecursosHumanosDataSet.V_ApellidosyNombresEmpleados)

    End Sub
End Class