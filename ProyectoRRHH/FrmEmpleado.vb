Public Class FrmEmpleado
    Private Sub EMPLEADOBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EMPLEADOBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EMPLEADOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB_RRHHDataSet)

    End Sub

    Private Sub FrmEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DB_RRHHDataSet.EMPLEADO' Puede moverla o quitarla según sea necesario.
        Me.EMPLEADOTableAdapter.Fill(Me.DB_RRHHDataSet.EMPLEADO)

    End Sub
End Class