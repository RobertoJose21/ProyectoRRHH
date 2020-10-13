Public Class FrmGerente
    Private Sub GERENTEBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles GERENTEBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.GERENTEBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_RecursosHumanosDataSet)

    End Sub

    Private Sub FrmGerente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_RecursosHumanosDataSet.GERENTE' Puede moverla o quitarla según sea necesario.
        Me.GERENTETableAdapter.Fill(Me.BD_RecursosHumanosDataSet.GERENTE)

    End Sub
End Class