Public Class FrmRegimenSalud
    Private Sub REGIMEN_SALUDBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles REGIMEN_SALUDBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.REGIMEN_SALUDBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_RecursosHumanosDataSet)

    End Sub

    Private Sub FrmRegimenSalud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_RecursosHumanosDataSet.REGIMEN_SALUD' Puede moverla o quitarla según sea necesario.
        Me.REGIMEN_SALUDTableAdapter.Fill(Me.BD_RecursosHumanosDataSet.REGIMEN_SALUD)

    End Sub
End Class