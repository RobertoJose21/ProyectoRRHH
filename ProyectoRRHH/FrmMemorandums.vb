Public Class FrmMemorandums
    Private Sub MEMORANDUMSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MEMORANDUMSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MEMORANDUMSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB_RRHHDataSet)

    End Sub

    Private Sub FrmMemorandums_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DB_RRHHDataSet.MEMORANDUMS' Puede moverla o quitarla según sea necesario.
        Me.MEMORANDUMSTableAdapter.Fill(Me.DB_RRHHDataSet.MEMORANDUMS)

    End Sub
End Class