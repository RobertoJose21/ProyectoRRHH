Public Class FrmTipoPlanilla
    Private Sub TIPO_PLANILLABindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TIPO_PLANILLABindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TIPO_PLANILLABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_RecursosHumanosDataSet)

    End Sub

    Private Sub FrmTipoPlanilla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_RecursosHumanosDataSet.TIPO_PLANILLA' Puede moverla o quitarla según sea necesario.
        Me.TIPO_PLANILLATableAdapter.Fill(Me.BD_RecursosHumanosDataSet.TIPO_PLANILLA)

    End Sub
End Class