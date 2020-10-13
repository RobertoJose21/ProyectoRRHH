Public Class frmPRESTAMOS_ADELANTOS
    Private Sub PRESTAMO_ADELANTOSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PRESTAMO_ADELANTOSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PRESTAMO_ADELANTOSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB_RRHHDataSet)

    End Sub

    Private Sub frmPRESTAMOS_ADELANTOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DB_RRHHDataSet.PRESTAMO_ADELANTOS' Puede moverla o quitarla según sea necesario.
        Me.PRESTAMO_ADELANTOSTableAdapter.Fill(Me.DB_RRHHDataSet.PRESTAMO_ADELANTOS)

    End Sub
End Class