Public Class FrmEmpleado
    Private Sub EMPLEADOBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EMPLEADOBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EMPLEADOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_RecursosHumanosDataSet)

    End Sub

    Private Sub FrmEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_RecursosHumanosDataSet.EMPLEADO' Puede moverla o quitarla según sea necesario.
        Me.EMPLEADOTableAdapter.Fill(Me.BD_RecursosHumanosDataSet.EMPLEADO)

    End Sub
End Class