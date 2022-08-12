Public Class frmlevel1


    ' Determines the color of the labels 
    Private Sub frmlevel1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Frmintro.playtheme("levelonetheme.wav") 'plays level one theme

        'Safe labels
        lblright1.BackColor = Color.Blue
        lblright2.BackColor = Color.Blue
        lblright3.BackColor = Color.Blue
        lblright4.BackColor = Color.Blue
        lblright5.BackColor = Color.Blue
        lblright6.BackColor = Color.Blue
        lblright7.BackColor = Color.Blue
        lblright8.BackColor = Color.Blue
        lblright9.BackColor = Color.Blue
        lblright10.BackColor = Color.Blue

        'evil labels 
        lblwrong1.BackColor = Color.Red
        lblwrong2.BackColor = Color.Red
        lblwrong3.BackColor = Color.Red
        lblwrong4.BackColor = Color.Red
        lblwrong5.BackColor = Color.Red
        lblwrong6.BackColor = Color.Red
        lblwrong7.BackColor = Color.Red
        lblwrong8.BackColor = Color.Red
        lblwrong9.BackColor = Color.Red
        lblwrong10.BackColor = Color.Red
        lblwrong11.BackColor = Color.Red

    End Sub

    'If you win
    Private Sub pbolevel1win_MouseMove(sender As Object, e As EventArgs) Handles pbolevel1win.MouseMove
        Frmintro.stoptheme() ' temporarily stops audio


        Frmintro.playtheme("levelsuccess.wav") 'plays level success theme

        MsgBox("You have beaten level 1, Good luck on level 2")

        Frmintro.stoptheme() ' temporarily stops audio

        frmlevel2.ShowDialog()
    End Sub

    'If you lose 
    Private Sub lblwrong1_MouseMove(sender As Object, e As EventArgs) Handles lblwrong1.MouseMove, lblwrong2.MouseMove, lblwrong3.MouseMove, lblwrong4.MouseMove, lblwrong5.MouseMove, lblwrong6.MouseMove, lblwrong7.MouseMove, lblwrong8.MouseMove, lblwrong9.MouseMove, lblwrong10.MouseMove, lblwrong11.MouseMove

        Frmintro.stoptheme() ' temporarily stops audio



        Frmintro.playtheme("levelfail.wav") 'plays level fail theme

        MsgBox("YOU SHALL NOT PASSSSSS (you lose lol)")

        Frmintro.stoptheme() ' temporarily stops audio

        Frmintro.playtheme("mainmenutheme.wav") ' plays menu intro theme

        Me.Close()

    End Sub
End Class