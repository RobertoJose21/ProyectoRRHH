﻿Public Class FrmTipoAsistencia
    Private Sub TIPO_ASISTENCIABindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TIPO_ASISTENCIABindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TIPO_ASISTENCIABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB_RRHHDataSet)

    End Sub

    Private Sub FrmTipoAsistencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DB_RRHHDataSet.TIPO_ASISTENCIA' Puede moverla o quitarla según sea necesario.
        Me.TIPO_ASISTENCIATableAdapter.Fill(Me.DB_RRHHDataSet.TIPO_ASISTENCIA)

    End Sub
End Class