Public Class FrmContrato
    Private Sub CONTRATOBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CONTRATOBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CONTRATOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB_RRHHDataSet)

    End Sub

    Private Sub FrmContrato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DB_RRHHDataSet.CONTRATO' Puede moverla o quitarla según sea necesario.
        Me.CONTRATOTableAdapter.Fill(Me.DB_RRHHDataSet.CONTRATO)

    End Sub
End Class