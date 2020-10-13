Public Class FrmVacaciones
    Private Sub VACACIONESBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles VACACIONESBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VACACIONESBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_RecursosHumanosDataSet)

    End Sub

    Private Sub FrmVacaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_RecursosHumanosDataSet.VACACIONES' Puede moverla o quitarla según sea necesario.
        Me.VACACIONESTableAdapter.Fill(Me.BD_RecursosHumanosDataSet.VACACIONES)

    End Sub
End Class