Public Class FrmVacaciones
    Private Sub VACACIONESBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles VACACIONESBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VACACIONESBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB_RRHHDataSet)

    End Sub

    Private Sub FrmVacaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_RecursosHumanosDataSet.VACACIONES' Puede moverla o quitarla según sea necesario.
        Me.VACACIONESTableAdapter1.Fill(Me.BD_RecursosHumanosDataSet.VACACIONES)
        'TODO: esta línea de código carga datos en la tabla 'DB_RRHHDataSet.VACACIONES' Puede moverla o quitarla según sea necesario.
        Me.VACACIONESTableAdapter.Fill(Me.DB_RRHHDataSet.VACACIONES)

    End Sub
End Class