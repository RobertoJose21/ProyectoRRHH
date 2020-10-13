Public Class FrmPrestamosAdelantados
    Private Sub PRESTAMO_ADELANTOSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PRESTAMO_ADELANTOSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PRESTAMO_ADELANTOSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_RecursosHumanosDataSet)

    End Sub

    Private Sub FrmPrestamosAdelantados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_RecursosHumanosDataSet.PRESTAMO_ADELANTOS' Puede moverla o quitarla según sea necesario.
        Me.PRESTAMO_ADELANTOSTableAdapter.Fill(Me.BD_RecursosHumanosDataSet.PRESTAMO_ADELANTOS)

    End Sub
End Class