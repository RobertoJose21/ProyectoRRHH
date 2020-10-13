Public Class FrmArea
    Private Sub AREABindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AREABindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AREABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB_RRHHDataSet)

    End Sub

    Private Sub FrmArea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_RecursosHumanosDataSet.AREA' Puede moverla o quitarla según sea necesario.
        Me.AREATableAdapter1.Fill(Me.BD_RecursosHumanosDataSet.AREA)
        'TODO: esta línea de código carga datos en la tabla 'DB_RRHHDataSet.AREA' Puede moverla o quitarla según sea necesario.
        Me.AREATableAdapter.Fill(Me.DB_RRHHDataSet.AREA)

    End Sub
End Class