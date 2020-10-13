Public Class FrmDistrito
    Private Sub DISTRITOBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.DISTRITOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB_RRHHDataSet)

    End Sub

    Private Sub DISTRITOBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles DISTRITOBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DISTRITOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB_RRHHDataSet)

    End Sub

    Private Sub FrmDistrito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BD_RecursosHumanosDataSet.DISTRITO' Puede moverla o quitarla según sea necesario.
        Me.DISTRITOTableAdapter1.Fill(Me.BD_RecursosHumanosDataSet.DISTRITO)
        'TODO: esta línea de código carga datos en la tabla 'DB_RRHHDataSet.DISTRITO' Puede moverla o quitarla según sea necesario.
        Me.DISTRITOTableAdapter.Fill(Me.DB_RRHHDataSet.DISTRITO)

    End Sub
End Class