Public Class FrmAsistencias
    Private Sub ASISTENCIABindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ASISTENCIABindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ASISTENCIABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_RecursosHumanosDataSet)

    End Sub

    Private Sub FrmAsistencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_RecursosHumanosDataSet.ASISTENCIA' Puede moverla o quitarla según sea necesario.
        Me.ASISTENCIATableAdapter.Fill(Me.BD_RecursosHumanosDataSet.ASISTENCIA)

    End Sub


End Class