Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TIPOSDECONTRATOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TIPOSDECONTRATOToolStripMenuItem.Click
        Dim objtipocontrato As New FrmTipoContrato
        objtipocontrato.MdiParent = Me
        objtipocontrato.Show()
    End Sub

    Private Sub PERIODOLABORALToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PERIODOLABORALToolStripMenuItem.Click
        Dim objperiodolaboral As New FrmPeriodoLaboral
        objperiodolaboral.MdiParent = Me
        objperiodolaboral.Show()
    End Sub

    Private Sub TIPODETRABAJADORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TIPODETRABAJADORToolStripMenuItem.Click
        Dim objtipotrabajador As New FrmTipoTrabajador
        objtipotrabajador.MdiParent = Me
        objtipotrabajador.Show()
    End Sub

    Private Sub AREASDETRABAJOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AREASDETRABAJOToolStripMenuItem.Click
        Dim objareatrabajo As New FrmArea
        objareatrabajo.MdiParent = Me
        objareatrabajo.Show()
    End Sub

    Private Sub VARIACIONDELToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VARIACIONDELToolStripMenuItem.Click
        Dim objvariacionsueldo As New FrmVariacionSueldo
        objvariacionsueldo.MdiParent = Me
        objvariacionsueldo.Show()
    End Sub

    Private Sub REGISTROToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles REGISTROToolStripMenuItem1.Click
        Dim objpagoplanilla As New FrmPagoPlanilla
        objpagoplanilla.MdiParent = Me
        objpagoplanilla.Show()
    End Sub

    Private Sub MANTENEDORPLANILLAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MANTENEDORPLANILLAToolStripMenuItem.Click
        Dim objplanilla As New FrmPlanilla
        objplanilla.MdiParent = Me
        objplanilla.Show()
    End Sub

    Private Sub MANTENEDORDEBOLETASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MANTENEDORDEBOLETASToolStripMenuItem.Click

    End Sub

    Private Sub REGISTROToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REGISTROToolStripMenuItem.Click
        Dim objboleta As New FrmBoleta
        objboleta.MdiParent = Me
        objboleta.Show()
    End Sub

    Private Sub VISTAVENTANASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VISTAVENTANASToolStripMenuItem.Click

    End Sub

    Private Sub CASCADAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CASCADAToolStripMenuItem.Click

    End Sub

    Private Sub HORIZONTALToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HORIZONTALToolStripMenuItem.Click

    End Sub

    Private Sub VERTICALToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VERTICALToolStripMenuItem.Click

    End Sub

    Private Sub ORGANIZARTODOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ORGANIZARTODOToolStripMenuItem.Click

    End Sub
End Class
