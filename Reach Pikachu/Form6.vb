Public Class frmlevel5
    Private Sub frmlevel5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Frmintro.playtheme("levelfivetheme.wav")


        lblwrongx.BackColor = Color.DarkRed
        lblrightx.BackColor = Color.Blue
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
        lblrighty.BackColor = Color.Blue

    End Sub

    Private Sub lblwrongx_MouseMove(sender As Object, e As MouseEventArgs) Handles lblwrongx.MouseMove


        Frmintro.stoptheme()

        Frmintro.playtheme("levelfail.wav")


        MsgBox("Ha Ha You have lost, oof ")

        Frmintro.stoptheme()

        frmlevel1.Close()
        frmlevel2.Close()
        frmlevel3.Close()
        frmlevel4.Close()
        Me.Close()




    End Sub

    Private Sub pbofakepikachuditto_MouseMove(sender As Object, e As MouseEventArgs) Handles pbofakepikachuditto.MouseMove

        Frmintro.stoptheme()

        Frmintro.playtheme("levelfail.wav")

        pbofakepikachuditto.Visible = False
        pboditto.Visible = True
        MsgBox("Ditto has tricked you, Ha ha Loser")


        Frmintro.stoptheme()

        frmlevel1.Close()
        frmlevel2.Close()
        frmlevel3.Close()
        frmlevel4.Close()
        Me.Close()

    End Sub

    Private Sub pbofakepikachumimikyu_MouseMove(sender As Object, e As MouseEventArgs) Handles pbofakepikachumimikyu.MouseMove

        Frmintro.stoptheme()

        Frmintro.playtheme("levelfail.wav")


        pbofakepikachumimikyu.Visible = False
        pbomimikyu.Visible = True
        MsgBox("You have accidentally found mimikyu instead of pikachu, You lose")

        Frmintro.stoptheme()


        frmlevel1.Close()
        frmlevel2.Close()
        frmlevel3.Close()
        frmlevel4.Close()
        Me.Close()



    End Sub

    Private Sub pbofakepikachuzoroa_MouseMove(sender As Object, e As MouseEventArgs) Handles pbofakepikachuzoroa.MouseMove


        Frmintro.stoptheme()

        Frmintro.playtheme("levelfail.wav")


        pbofakepikachuzoroa.Visible = False
        pbozoroa.Visible = True
        MsgBox("You accidently found zoroa instead of pikachu, You lose ha")


        Frmintro.stoptheme()


        frmlevel1.Close()
        frmlevel2.Close()
        frmlevel3.Close()
        frmlevel4.Close()
        Me.Close()

    End Sub

    Private Sub pbofakepikachuzoroark_MouseMove(sender As Object, e As MouseEventArgs) Handles pbofakepikachuzoroark.MouseMove
        Frmintro.stoptheme()

        Frmintro.playtheme("levelfail.wav")


        pbofakepikachuzoroark.Visible = False
        pbozoroark.Visible = True
        MsgBox("You have accidentally found zoroark, You lose")

        Frmintro.stoptheme()

        frmlevel1.Close()
        frmlevel2.Close()
        frmlevel3.Close()
        frmlevel4.Close()
        Me.Close()

    End Sub

    Private Sub pborealpikachu_MouseMove(sender As Object, e As MouseEventArgs) Handles pborealpikachu.MouseMove

        Frmintro.stoptheme()

        Frmintro.playtheme("levelsuccess.wav")

        MsgBox("You have won, You are excellent at the maze game, You are going to have a blast on the last level")

        Frmintro.stoptheme()

        frmlastlevel6.ShowDialog()





    End Sub
End Class
