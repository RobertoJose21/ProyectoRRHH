Imports System.Data.SqlClient
Public Class FrmDistritosEmpleados
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            'Declarando las variables
            Dim Cnn As New SqlConnection
            Dim Comando As New SqlCommand
            Dim Lector As SqlDataReader
            Dim Fila As ListViewItem
            'Configurando la Conección
            Cnn.ConnectionString = "server=(local); Integrated Security=true; database=DB_RRHH"
            'Configuración alternativa para la Conección
            Cnn.Open()
            Comando.CommandText = "select * from V_DistritoEmpleados"
            Comando.CommandType = CommandType.Text
            Comando.Connection = Cnn
            Me.ListView1.Items.Clear()
            Lector = Comando.ExecuteReader()
            If Lector.HasRows = True Then
                While Lector.Read
                    Fila = New ListViewItem
                    Fila.Text = CStr(Lector.Item(0))
                    Fila.SubItems.Add(CStr(Lector.Item(1)))
                    Fila.SubItems.Add(CStr(Lector.Item(2)))
                    Fila.SubItems.Add(CStr(Lector.Item(3)))
                    Fila.SubItems.Add(CStr(Lector.Item(4)))
                    Me.ListView1.Items.Add(Fila)
                End While
            End If
            Lector.Close()
            Cnn.Close()
            Cnn.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class