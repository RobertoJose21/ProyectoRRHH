Public Class FrmTipoTrabajador
    Private Sub TIPO_TRABAJADORBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TIPO_TRABAJADORBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TIPO_TRABAJADORBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB_RRHHDataSet)

    End Sub

    Private Sub FrmTipoTrabajador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DB_RRHHDataSet.TIPO_TRABAJADOR' Puede moverla o quitarla según sea necesario.
        Me.TIPO_TRABAJADORTableAdapter.Fill(Me.DB_RRHHDataSet.TIPO_TRABAJADOR)

    End Sub
End Class