Public Class FrmAsistencia
    Private Sub ASISTENCIABindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ASISTENCIABindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ASISTENCIABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB_RRHHDataSet)

    End Sub

    Private Sub FrmAsistencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DB_RRHHDataSet.ASISTENCIA' Puede moverla o quitarla según sea necesario.
        Me.ASISTENCIATableAdapter.Fill(Me.DB_RRHHDataSet.ASISTENCIA)

    End Sub
End Class