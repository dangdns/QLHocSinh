Imports System.Configuration

Public Class Form1
    Private Sub HọcSinhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HọcSinhToolStripMenuItem.Click
        Dim frm As frmNhapHS = New frmNhapHS()
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class
