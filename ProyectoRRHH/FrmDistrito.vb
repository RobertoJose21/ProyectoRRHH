Public Class FrmDistrito
    Private Sub DISTRITOBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DISTRITOBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DISTRITOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BD_RecursosHumanosDataSet)

    End Sub

    Private Sub FrmDistrito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_RecursosHumanosDataSet.DISTRITO' Puede moverla o quitarla según sea necesario.
        Me.DISTRITOTableAdapter.Fill(Me.BD_RecursosHumanosDataSet.DISTRITO)

    End Sub
End Class