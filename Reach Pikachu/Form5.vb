Public Class frmlevel4
    Private Sub frmlevel4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Frmintro.playtheme("levelfourtheme.wav") 'plays level 4 theme 

        'hide fake images

        pboditto.Visible = False
        pbozoroa.Visible = False
        pbozoroark.Visible = False


        'color of bad labels 
        lblwrong1.BackColor = Color.Purple
        lblwrong2.BackColor = Color.Purple
        lblwrong3.BackColor = Color.Purple
        lblwrong4.BackColor = Color.Purple
        lblwrong5.BackColor = Color.Purple
        lblwrong6.BackColor = Color.Purple
        lblwrong7.BackColor = Color.Purple
        lblwrong8.BackColor = Color.Purple
        lblwrong9.BackColor = Color.Purple
        lblwrong10.BackColor = Color.Purple
        lblwrong11.BackColor = Color.Purple
        lblwrong12.BackColor = Color.Purple
        lblwrong13.BackColor = Color.Purple
        lblwrong14.BackColor = Color.Purple
        lblwrong15.BackColor = Color.Purple
        lblwrong16.BackColor = Color.Purple

        lblwrong17.BackColor = Color.Purple




        'color of good labels 
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
        lblright11.BackColor = Color.Blue

        lblright12.BackColor = Color.Blue
        lblright13.BackColor = Color.Blue
        lblright14.BackColor = Color.Blue
        lblright15.BackColor = Color.Blue
        lblright16.BackColor = Color.Blue
        lblright17.BackColor = Color.Blue
        lblright18.BackColor = Color.Blue
        lblright19.BackColor = Color.Blue
        lblright20.BackColor = Color.Blue
        lblright21.BackColor = Color.Blue
        lblright22.BackColor = Color.Blue
        lblright23.BackColor = Color.Blue
        lblright24.BackColor = Color.Blue
        lblright25.BackColor = Color.Blue
        lblright26.BackColor = Color.Blue
        lblright27.BackColor = Color.Blue
        lblright28.BackColor = Color.Blue
        lblright29.BackColor = Color.Blue
        lblright30.BackColor = Color.Blue





    End Sub



    Private Sub pborightpikachu_MouseMove(sender As Object, e As MouseEventArgs) Handles pborightpikachu.MouseMove


        Frmintro.stoptheme() 'stop audio

        Frmintro.playtheme("levelsuccess.wav") 'play success theme


        MsgBox("I am impressed that you chose the correct pikachu, (25% chance, cool)")

        Frmintro.stoptheme() 'stop audio

        frmlevel5.ShowDialog() ' go onto level 5

    End Sub

    Private Sub pbofakepikaditto_MouseMove(sender As Object, e As MouseEventArgs) Handles pbofakepikaditto.MouseMove


        Frmintro.stoptheme()

        Frmintro.playtheme("levelfail.wav")


        pbofakepikaditto.Visible = False
        pboditto.Visible = True
        MsgBox("Ditto has tricked you, you lose")


        Frmintro.stoptheme()


        frmlevel1.Close()
        frmlevel2.Close()
        frmlevel3.Close()
        Me.Close()

    End Sub

    Private Sub pbofakepikazoroark_MouseMove(sender As Object, e As MouseEventArgs) Handles pbofakepikazoroark.MouseMove



        Frmintro.stoptheme()

        Frmintro.playtheme("levelfail.wav")

        pbofakepikazoroark.Visible = False
        pbozoroark.Visible = True
        MsgBox("Zoroark has tricked you, you have been defeated ")

        Frmintro.stoptheme()


        frmlevel1.Close()
        frmlevel2.Close()
        frmlevel3.Close()
        Me.Close()

    End Sub

    Private Sub pbofakepikazoroa_MouseMove(sender As Object, e As MouseEventArgs) Handles pbofakepikazoroa.MouseMove


        Frmintro.stoptheme()

        Frmintro.playtheme("levelfail.wav")

        pbofakepikazoroa.Visible = False
        pbozoroa.Visible = True
        MsgBox("Zoroa has tricked you, You have lost")

        Frmintro.stoptheme()


        frmlevel1.Close()
        frmlevel2.Close()
        frmlevel3.Close()
        Me.Close()

    End Sub

    Private Sub lblwrong1_MouseMove(sender As Object, e As MouseEventArgs) Handles lblwrong1.MouseMove, lblwrong2.MouseMove, lblwrong3.MouseMove, lblwrong4.MouseMove, lblwrong5.MouseMove, lblwrong6.MouseMove, lblwrong7.MouseMove, lblwrong8.MouseMove, lblwrong9.MouseMove, lblwrong10.MouseMove, lblwrong11.MouseMove, lblwrong12.MouseMove, lblwrong13.MouseMove, lblwrong14.MouseMove, lblwrong15.MouseMove, lblwrong16.MouseMove, lblwrong17.MouseMove


        Frmintro.stoptheme()

        Frmintro.playtheme("levelfail.wav")

        MsgBox("You have lost, time to close ")

        Frmintro.stoptheme()

        frmlevel1.Close()
        frmlevel2.Close()
        frmlevel3.Close()
        Me.Close()



    End Sub


End Class