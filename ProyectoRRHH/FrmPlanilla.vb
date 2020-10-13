Public Class FrmPlanilla
    Private Sub PLANILLABindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PLANILLABindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PLANILLABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_RecursosHumanosDataSet)

    End Sub

    Private Sub FrmPlanilla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_RecursosHumanosDataSet.PLANILLA' Puede moverla o quitarla según sea necesario.
        Me.PLANILLATableAdapter.Fill(Me.BD_RecursosHumanosDataSet.PLANILLA)

    End Sub
End Class