Public Class FrmTipoTrabajo
    Private Sub TIPO_TRABAJADORBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TIPO_TRABAJADORBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TIPO_TRABAJADORBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_RecursosHumanosDataSet)

    End Sub

    Private Sub FrmTipoTrabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_RecursosHumanosDataSet.TIPO_TRABAJADOR' Puede moverla o quitarla según sea necesario.
        Me.TIPO_TRABAJADORTableAdapter.Fill(Me.BD_RecursosHumanosDataSet.TIPO_TRABAJADOR)

    End Sub
End Class