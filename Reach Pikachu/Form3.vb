Public Class frmlevel2
    Private Sub frmlevel2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Frmintro.playtheme("leveltwotheme.wav") 'plays level 2 theme

        ' The good labels 
        lblright1.BackColor = Color.Blue
        lblright2.BackColor = Color.Blue
        lblright4.BackColor = Color.Blue
        lblright5.BackColor = Color.Blue
        lblright6.BackColor = Color.Blue
        lblright7.BackColor = Color.Blue
        lblright8.BackColor = Color.Blue
        lblright9.BackColor = Color.Blue


        'all bad labels 
        lblwrong1.BackColor = Color.Cyan
        lblwrong2.BackColor = Color.Cyan
        lblwrong3.BackColor = Color.Cyan
        lblwrong4.BackColor = Color.Cyan
        lblwrong5.BackColor = Color.Cyan
        lblwrong6.BackColor = Color.Cyan
        lblwrong7.BackColor = Color.Cyan
        lblwrong8.BackColor = Color.Cyan
        lblwrong9.BackColor = Color.Cyan
        lblwrong10.BackColor = Color.Cyan
        lblwrong11.BackColor = Color.Cyan
        lblwrong12.BackColor = Color.Cyan
        lblrip1.BackColor = Color.Cyan
        lblrip2.BackColor = Color.Cyan




    End Sub


    Private Sub lblwrong1_MouseMove(sender As Object, e As EventArgs) Handles lblwrong1.MouseMove, lblwrong2.MouseMove, lblwrong3.MouseMove, lblwrong4.MouseMove, lblwrong5.MouseMove, lblwrong6.MouseMove, lblwrong7.MouseMove, lblwrong8.MouseMove, lblwrong9.MouseMove, lblwrong10.MouseMove, lblwrong11.MouseMove, lblwrong12.MouseMove

        Frmintro.stoptheme()



        Frmintro.playtheme("levelfail.wav") 'plays level fail theme

        MsgBox("You lose lol")

        Frmintro.stoptheme()

        frmlevel1.Close()

        Me.Close()
    End Sub

    'if you move over the right pikachu
    Private Sub pboright_mousemove(sender As Object, e As EventArgs) Handles pboright.MouseMove

        Frmintro.stoptheme()

        Frmintro.playtheme("levelsuccess.wav") 'plays level success theme

        MsgBox("you win lol")

        Frmintro.stoptheme()


        frmlevel3.ShowDialog()
    End Sub

    'if you move over ditto 
    Private Sub pbowrong1_mousemove(sender As Object, e As EventArgs) Handles pbowrong1.MouseMove


        Frmintro.stoptheme()


        Frmintro.playtheme("levelfail.wav") ' plays level fail theme

        pboditto.Visible = True

        MsgBox("You lose idiot Ditto tricked you, I guess you didn't guess hard enough")

        Frmintro.stoptheme()

        frmlevel1.Close()

        Me.Close()
    End Sub


End Class