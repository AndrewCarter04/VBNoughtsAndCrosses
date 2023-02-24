Public Class frmNaC

    Dim player1 As Boolean = True

    Dim hasWinner As Boolean = False
    Dim canRestart As Boolean = False

    Dim p1Score As Integer = 0
    Dim p2Score As Integer = 0

    Dim cpu As Boolean
    Dim difficulty As String

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        submitClick(0, btn0)
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        submitClick(1, btn1)
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        submitClick(2, btn2)
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        submitClick(3, btn3)
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        submitClick(4, btn4)
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        submitClick(5, btn5)
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        submitClick(6, btn6)
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        submitClick(7, btn7)
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        submitClick(8, btn8)
    End Sub

    Private Sub submitClick(btnNumber As Integer, button As Button)

        If button.Text = " " Then

            If Not canRestart Then

                If player1 Then
                    button.Text = "X"
                    player1 = False
                    lblInfo.Text = "It is Player Two's turn."
                Else
                    button.Text = "O"
                    player1 = True
                    lblInfo.Text = "It is Player One's turn."
                End If

                checkForWinner()

            End If

        Else

            If Not canRestart Then
                MsgBox("That square has already been used! Please try another.")
            Else
                restart()
            End If

        End If

    End Sub

    Private Sub checkForWinner()

        ' 0 1 2
        ' 3 4 5
        ' 6 7 8

        Dim board As String = ""

        board += btn0.Text
        board += btn1.Text
        board += btn2.Text
        board += btn3.Text
        board += btn4.Text
        board += btn5.Text
        board += btn6.Text
        board += btn7.Text
        board += btn8.Text

        If Not board.Contains(" ") Then
            canRestart = True
            MsgBox("There are no squares left!")
        End If

        If (board(0) = board(1) And board(1) = board(2) And board(2) <> " ") Or (board(0) = board(3) And board(3) = board(6) And board(6) <> " ") Or (board(0) = board(4) And board(4) = board(8) And board(8) <> " ") Then
            winner(board(0))
        End If

        If board(1) = board(4) And board(4) = board(7) And board(7) <> " " Then
            winner(board(1))
        End If

        If board(3) = board(4) And board(4) = board(5) And board(5) <> " " Then
            winner(board(3))
        End If

        If (board(2) = board(5) And board(5) = board(8) And board(8) <> " ") Or (board(6) = board(7) And board(7) = board(8) And board(8) <> " ") Then
            winner(board(8))
        End If

        If board(2) = board(4) And board(4) = board(6) And board(6) <> " " Then
            winner(board(2))
        End If

    End Sub

    Private Sub updateScore()

        lblP1Score.Text = "P1 Score = " + Str(p1Score)
        lblP2Score.Text = "P2 Score = " + Str(p2Score)

    End Sub

    Private Sub winner(winner As Char)

        hasWinner = True
        canRestart = True

        If winner = "X" Then

            lblInfo.Text = "Player One has won!"
            p1Score += 1
            player1 = False

        ElseIf winner = "O" Then

            lblInfo.Text = "Player Two has won!"
            p2Score += 1
            player1 = True

        End If

        updateScore()

    End Sub

    Private Sub restart()

        btn0.Text = " "
        btn1.Text = " "
        btn2.Text = " "
        btn3.Text = " "
        btn4.Text = " "
        btn5.Text = " "
        btn6.Text = " "
        btn7.Text = " "
        btn8.Text = " "

        hasWinner = False
        canRestart = False

        lblInfo.Text = "It is Player One's turn."

    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click

        If canRestart Then
            restart()
        End If

    End Sub

    Public Sub setSettings(onePlayer As Boolean, cpuDifficulty As String)

        cpu = onePlayer
        difficulty = cpuDifficulty

    End Sub

    Private Sub frmNaC_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmMenu.Close()
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        frmMenu.Show()
        Me.Hide()
    End Sub
End Class
