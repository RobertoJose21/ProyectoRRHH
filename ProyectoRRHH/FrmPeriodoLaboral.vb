﻿Public Class FrmPeriodoLaboral
    Private Sub PERIODO_LABORALBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PERIODO_LABORALBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PERIODO_LABORALBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB_RRHHDataSet)

    End Sub

    Private Sub FrmPeriodoLaboral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DB_RRHHDataSet.PERIODO_LABORAL' Puede moverla o quitarla según sea necesario.
        Me.PERIODO_LABORALTableAdapter.Fill(Me.DB_RRHHDataSet.PERIODO_LABORAL)

    End Sub
End Class