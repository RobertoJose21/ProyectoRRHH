Public Class FrmBoleta
    Private Sub BOLETABindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BOLETABindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BOLETABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_RecursosHumanosDataSet)

    End Sub

    Private Sub FrmBoleta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_RecursosHumanosDataSet.BOLETA' Puede moverla o quitarla según sea necesario.
        Me.BOLETATableAdapter.Fill(Me.BD_RecursosHumanosDataSet.BOLETA)

    End Sub

    Private Sub BOLETADataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BOLETADataGridView.CellContentClick

    End Sub
End Class