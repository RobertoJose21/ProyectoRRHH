Public Class FrmNivelEducacion
    Private Sub NIVEL_EDUCACIONBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles NIVEL_EDUCACIONBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.NIVEL_EDUCACIONBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_RecursosHumanosDataSet)

    End Sub

    Private Sub FrmNivelEducacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_RecursosHumanosDataSet.NIVEL_EDUCACION' Puede moverla o quitarla según sea necesario.
        Me.NIVEL_EDUCACIONTableAdapter.Fill(Me.BD_RecursosHumanosDataSet.NIVEL_EDUCACION)

    End Sub
End Class