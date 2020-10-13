Public Class FrmMemorandums
    Private Sub MEMORANDUMSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MEMORANDUMSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MEMORANDUMSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_RecursosHumanosDataSet)

    End Sub

    Private Sub FrmMemorandums_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_RecursosHumanosDataSet.MEMORANDUMS' Puede moverla o quitarla según sea necesario.
        Me.MEMORANDUMSTableAdapter.Fill(Me.BD_RecursosHumanosDataSet.MEMORANDUMS)

    End Sub
End Class