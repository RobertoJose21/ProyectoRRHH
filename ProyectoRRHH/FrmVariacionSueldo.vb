Public Class FrmVariacionSueldo
    Private Sub VARIACION_SUELDOBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles VARIACION_SUELDOBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VARIACION_SUELDOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB_RRHHDataSet)

    End Sub

    Private Sub FrmVariacionSueldo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_RecursosHumanosDataSet.VARIACION_SUELDO' Puede moverla o quitarla según sea necesario.
        Me.VARIACION_SUELDOTableAdapter1.Fill(Me.BD_RecursosHumanosDataSet.VARIACION_SUELDO)
        'TODO: esta línea de código carga datos en la tabla 'DB_RRHHDataSet.VARIACION_SUELDO' Puede moverla o quitarla según sea necesario.
        Me.VARIACION_SUELDOTableAdapter.Fill(Me.DB_RRHHDataSet.VARIACION_SUELDO)

    End Sub
End Class