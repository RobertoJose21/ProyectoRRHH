Public Class frmDATOS_TRIBUTARIOS
    Private Sub DATOS_TRIBUTARIOSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DATOS_TRIBUTARIOSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DATOS_TRIBUTARIOSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB_RRHHDataSet)

    End Sub

    Private Sub frmDATOS_TRIBUTARIOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DB_RRHHDataSet.DATOS_TRIBUTARIOS' Puede moverla o quitarla según sea necesario.
        Me.DATOS_TRIBUTARIOSTableAdapter.Fill(Me.DB_RRHHDataSet.DATOS_TRIBUTARIOS)

    End Sub
End Class