Public Class FrmBoleta
    Private Sub BOLETABindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BOLETABindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BOLETABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB_RRHHDataSet)

    End Sub

    Private Sub FrmBoleta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_RecursosHumanosDataSet.BOLETA' Puede moverla o quitarla según sea necesario.
        Me.BOLETATableAdapter1.Fill(Me.BD_RecursosHumanosDataSet.BOLETA)
        'TODO: esta línea de código carga datos en la tabla 'DB_RRHHDataSet.BOLETA' Puede moverla o quitarla según sea necesario.
        Me.BOLETATableAdapter.Fill(Me.DB_RRHHDataSet.BOLETA)

    End Sub
End Class