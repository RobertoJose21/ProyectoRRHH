Public Class FrmExperienciaLaboral
    Private Sub EXPERIENCIA_LABORALBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EXPERIENCIA_LABORALBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EXPERIENCIA_LABORALBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB_RRHHDataSet)

    End Sub

    Private Sub FrmExperienciaLaboral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_RecursosHumanosDataSet.EXPERIENCIA_LABORAL' Puede moverla o quitarla según sea necesario.
        Me.EXPERIENCIA_LABORALTableAdapter1.Fill(Me.BD_RecursosHumanosDataSet.EXPERIENCIA_LABORAL)
        'TODO: esta línea de código carga datos en la tabla 'DB_RRHHDataSet.EXPERIENCIA_LABORAL' Puede moverla o quitarla según sea necesario.
        Me.EXPERIENCIA_LABORALTableAdapter.Fill(Me.DB_RRHHDataSet.EXPERIENCIA_LABORAL)

    End Sub

    Private Sub EXPERIENCIA_LABORALDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) 

    End Sub
End Class