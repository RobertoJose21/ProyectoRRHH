﻿Public Class FrmRegimenPensionario
    Private Sub REGIMEN_PENSIONARIOBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles REGIMEN_PENSIONARIOBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.REGIMEN_PENSIONARIOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_RecursosHumanosDataSet)

    End Sub

    Private Sub FrmRegimenPensionario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_RecursosHumanosDataSet.REGIMEN_PENSIONARIO' Puede moverla o quitarla según sea necesario.
        Me.REGIMEN_PENSIONARIOTableAdapter.Fill(Me.BD_RecursosHumanosDataSet.REGIMEN_PENSIONARIO)

    End Sub
End Class