Public Class FrmExperienciaLaboral
    Private Sub EXPERIENCIA_LABORALBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EXPERIENCIA_LABORALBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EXPERIENCIA_LABORALBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_RecursosHumanosDataSet)

    End Sub

    Private Sub FrmExperienciaLaboral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_RecursosHumanosDataSet.EXPERIENCIA_LABORAL' Puede moverla o quitarla según sea necesario.
        Me.EXPERIENCIA_LABORALTableAdapter.Fill(Me.BD_RecursosHumanosDataSet.EXPERIENCIA_LABORAL)

    End Sub
End Class