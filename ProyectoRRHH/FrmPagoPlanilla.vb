﻿Public Class FrmPagoPlanilla
    Private Sub PAGO_PLANILLABindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PAGO_PLANILLABindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PAGO_PLANILLABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB_RRHHDataSet)

    End Sub

    Private Sub FrmPagoPlanilla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_RecursosHumanosDataSet.PAGO_PLANILLA' Puede moverla o quitarla según sea necesario.
        Me.PAGO_PLANILLATableAdapter1.Fill(Me.BD_RecursosHumanosDataSet.PAGO_PLANILLA)
        'TODO: esta línea de código carga datos en la tabla 'DB_RRHHDataSet.PAGO_PLANILLA' Puede moverla o quitarla según sea necesario.
        Me.PAGO_PLANILLATableAdapter.Fill(Me.DB_RRHHDataSet.PAGO_PLANILLA)

    End Sub
End Class