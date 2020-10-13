Public Class FrmTipoContrato
    Private Sub TIPO_CONTRATOBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TIPO_CONTRATOBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TIPO_CONTRATOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_RecursosHumanosDataSet)

    End Sub

    Private Sub FrmTipoContrato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_RecursosHumanosDataSet.TIPO_CONTRATO' Puede moverla o quitarla según sea necesario.
        Me.TIPO_CONTRATOTableAdapter.Fill(Me.BD_RecursosHumanosDataSet.TIPO_CONTRATO)

    End Sub
End Class