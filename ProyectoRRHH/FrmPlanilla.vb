Public Class FrmPlanilla
    Private Sub PLANILLABindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PLANILLABindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PLANILLABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB_RRHHDataSet)

    End Sub

    Private Sub FrmPlanilla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DB_RRHHDataSet.PLANILLA' Puede moverla o quitarla según sea necesario.
        Me.PLANILLATableAdapter.Fill(Me.DB_RRHHDataSet.PLANILLA)

    End Sub
End Class