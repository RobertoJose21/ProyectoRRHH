﻿Public Class Form1
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

    Private Sub DISTRITOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DISTRITOToolStripMenuItem.Click
        Dim objdistrito As New FrmDistrito
        objdistrito.MdiParent = Me
        objdistrito.Show()
    End Sub

    Private Sub EXPERIENCIALABORALToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXPERIENCIALABORALToolStripMenuItem.Click
        Dim objexplaboral As New FrmExperienciaLaboral
        objexplaboral.MdiParent = Me
        objexplaboral.Show()
    End Sub

    Private Sub BENEFICIOLABORALToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BENEFICIOLABORALToolStripMenuItem.Click
        Dim objbeneflaboral As New FrmExperienciaLaboral
        objbeneflaboral.MdiParent = Me
        objbeneflaboral.Show()
    End Sub

    Private Sub VACACIONESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VACACIONESToolStripMenuItem.Click
        Dim objvacaciones As New FrmVacaciones
        objvacaciones.MdiParent = Me
        objvacaciones.Show()
    End Sub

    Private Sub REGIMENSALUDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REGIMENSALUDToolStripMenuItem.Click
        Dim objRegSalud As New FrmRegimenSalud
        objRegSalud.MdiParent = Me
        objRegSalud.Show()
    End Sub

    Private Sub REGIMENPENSIONARIOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REGIMENPENSIONARIOToolStripMenuItem.Click
        Dim objRegPensionario As New FrmRegimenPensionario
        objRegPensionario.MdiParent = Me
        objRegPensionario.Show()
    End Sub

    Private Sub MANTENEDORASISTENCIASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MANTENEDORASISTENCIASToolStripMenuItem.Click
        Dim objAsistencia As New FrmAsistencia
        objAsistencia.MdiParent = Me
        objAsistencia.Show()
    End Sub

    Private Sub CONTROLDEASISTENCIASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONTROLDEASISTENCIASToolStripMenuItem.Click

    End Sub

    Private Sub MANTENEDORDEEMPLEADOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MANTENEDORDEEMPLEADOSToolStripMenuItem.Click
        Dim objEmpleado As New FrmEmpleado
        objEmpleado.MdiParent = Me
        objEmpleado.Show()
    End Sub

    Private Sub GERENTEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GERENTEToolStripMenuItem.Click
        Dim objGerente As New FrmGerente
        objGerente.MdiParent = Me
        objGerente.Show()
    End Sub



    Private Sub NIVELDEEDUCACIÓNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NIVELDEEDUCACIÓNToolStripMenuItem.Click
        Dim objNivelEducacion As New FrmNivelEducacion
        objNivelEducacion.MdiParent = Me
        objNivelEducacion.Show()
    End Sub

    Private Sub DATOSTRIBUTARIOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DATOSTRIBUTARIOSToolStripMenuItem.Click
        Dim objDatoTributario As New FrmDatosTributarios
        objDatoTributario.MdiParent = Me
        objDatoTributario.Show()
    End Sub

    Private Sub CONTRATOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONTRATOToolStripMenuItem.Click
        Dim objContrato As New FrmContrato
        objContrato.MdiParent = Me
        objContrato.Show()
    End Sub

    Private Sub ADELANTODEPRESTAMOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADELANTODEPRESTAMOSToolStripMenuItem.Click
        Dim objAdelantoPrestamo As New FrmPrestamosAdelantados
        objAdelantoPrestamo.MdiParent = Me
        objAdelantoPrestamo.Show()
    End Sub

    Private Sub MEMORANDUMSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MEMORANDUMSToolStripMenuItem.Click
        Dim objMemorandums As New FrmMemorandums
        objMemorandums.MdiParent = Me
        objMemorandums.Show()
    End Sub
End Class
