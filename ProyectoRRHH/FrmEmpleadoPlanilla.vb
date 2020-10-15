Imports System.Data.SqlClient

Public Class FrmEmpleadoPlanilla
    Private Sub FrmEmpleadoPlanilla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_RecursosHumanosDataSet1.TIPO_PLANILLA' Puede moverla o quitarla según sea necesario.
        Me.TIPO_PLANILLATableAdapter.Fill(Me.BD_RecursosHumanosDataSet1.TIPO_PLANILLA)
        'TODO: esta línea de código carga datos en la tabla 'BD_RecursosHumanosDataSet.PLANILLA' Puede moverla o quitarla según sea necesario.
        Me.PLANILLATableAdapter.Fill(Me.BD_RecursosHumanosDataSet.PLANILLA)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            Dim oConeccion As New SqlConnection
            Dim oComando As New SqlCommand
            Dim oLector As SqlDataReader
            Dim oFila As ListViewItem
            oConeccion.ConnectionString = "Server=(local);Integrated Security=true;Database=BD_RecursosHumanos"
            oConeccion.Open()
            oComando.CommandText = "ProdEmpleado_Planilla"
            oComando.CommandType = CommandType.StoredProcedure
            oComando.Parameters.Add("@tipoPlanilla", SqlDbType.VarChar, 50).Value = ComboBox1.Text
            oComando.Connection = oConeccion
            Me.ListView1.Items.Clear()
            oLector = oComando.ExecuteReader
            If oLector.HasRows = True Then
                While oLector.Read
                    oFila = New ListViewItem
                    oFila.Text = CStr(oLector.Item(0))
                    oFila.SubItems.Add(CStr(oLector.Item(1)))
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
End Class