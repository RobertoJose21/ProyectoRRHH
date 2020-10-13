Public Class FrmDatosTributarios
    Private Sub DATOS_TRIBUTARIOSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DATOS_TRIBUTARIOSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DATOS_TRIBUTARIOSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_RecursosHumanosDataSet)

    End Sub

    Private Sub FrmDatosTributarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_RecursosHumanosDataSet.DATOS_TRIBUTARIOS' Puede moverla o quitarla según sea necesario.
        Me.DATOS_TRIBUTARIOSTableAdapter.Fill(Me.BD_RecursosHumanosDataSet.DATOS_TRIBUTARIOS)

    End Sub
End Class