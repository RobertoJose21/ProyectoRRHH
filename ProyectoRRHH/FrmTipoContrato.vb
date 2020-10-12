Public Class FrmTipoContrato
    Private Sub TIPO_CONTRATOBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TIPO_CONTRATOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB_RRHHDataSet)

    End Sub

    Private Sub TIPO_CONTRATOBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles TIPO_CONTRATOBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TIPO_CONTRATOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB_RRHHDataSet)

    End Sub

    Private Sub FrmTipoContrato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DB_RRHHDataSet.TIPO_CONTRATO' Puede moverla o quitarla según sea necesario.
        Me.TIPO_CONTRATOTableAdapter.Fill(Me.DB_RRHHDataSet.TIPO_CONTRATO)

    End Sub
End Class