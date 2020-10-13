Public Class FrmBeneficioLaboral
    Private Sub BENEFICIO_LABORALBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BENEFICIO_LABORALBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BENEFICIO_LABORALBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_RecursosHumanosDataSet)

    End Sub

    Private Sub FrmBeneficioLaboral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_RecursosHumanosDataSet.BENEFICIO_LABORAL' Puede moverla o quitarla según sea necesario.
        Me.BENEFICIO_LABORALTableAdapter.Fill(Me.BD_RecursosHumanosDataSet.BENEFICIO_LABORAL)

    End Sub
End Class