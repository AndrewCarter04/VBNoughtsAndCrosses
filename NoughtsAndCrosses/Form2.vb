Public Class frmMenu
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        If rdb1Player.Checked And cmbDifficulty.SelectedItem = Nothing Then
            MsgBox("You must select a difficulty!")
            Return
        End If

        If rdb1Player.Checked Then
            frmNaC.setSettings(rdb1Player.Checked, cmbDifficulty.SelectedItem)
        Else
            frmNaC.setSettings(rdb2Player.Checked, "")
        End If

        Me.Hide()
        frmNaC.Show()

    End Sub

    Private Sub rdb1Player_CheckedChanged(sender As Object, e As EventArgs) Handles rdb1Player.CheckedChanged
        cmbDifficulty.Show()
        lblDifficulty.Show()
    End Sub

    Private Sub rdb2Player_CheckedChanged(sender As Object, e As EventArgs) Handles rdb2Player.CheckedChanged
        cmbDifficulty.Hide()
        lblDifficulty.Hide()
    End Sub
End Class