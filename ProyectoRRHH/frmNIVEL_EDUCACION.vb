﻿Public Class frmNIVEL_EDUCACION
    Private Sub NIVEL_EDUCACIONBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles NIVEL_EDUCACIONBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.NIVEL_EDUCACIONBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB_RRHHDataSet)

    End Sub

    Private Sub frmNIVEL_EDUCACION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DB_RRHHDataSet.EMPLEADO' Puede moverla o quitarla según sea necesario.
        Me.EMPLEADOTableAdapter.Fill(Me.DB_RRHHDataSet.EMPLEADO)
        'TODO: esta línea de código carga datos en la tabla 'DB_RRHHDataSet.NIVEL_EDUCACION' Puede moverla o quitarla según sea necesario.
        Me.NIVEL_EDUCACIONTableAdapter.Fill(Me.DB_RRHHDataSet.NIVEL_EDUCACION)

    End Sub
End Class