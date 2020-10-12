Public Class FrmPrincipal
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub NIVELDEEDUCACIÓNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NIVELDEEDUCACIÓNToolStripMenuItem.Click
        Dim objNIVELDEEDUCACION As New frmNIVEL_EDUCACION
        objNIVELDEEDUCACION.MdiParent = Me
        objNIVELDEEDUCACION.Show()
    End Sub

    Private Sub CASCADAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CASCADAToolStripMenuItem.Click
        Me.LayoutMdi(0)
    End Sub

    Private Sub HORIZONTALToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HORIZONTALToolStripMenuItem.Click
        Me.LayoutMdi(1)
    End Sub

    Private Sub VERTICALToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VERTICALToolStripMenuItem.Click
        Me.LayoutMdi(2)
    End Sub

    Private Sub ORGANIZARTODOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ORGANIZARTODOToolStripMenuItem.Click
        Me.LayoutMdi(3)
    End Sub
End Class
