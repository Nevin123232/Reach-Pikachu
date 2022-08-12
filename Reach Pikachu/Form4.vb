Public Class frmlevel3
    Private Sub frmlevel3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Frmintro.playtheme("levelthreetheme.wav") 'plays level 3 theme



        'good labels 
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
        lblright17.BackColor = Color.Blue
        lblright16.BackColor = Color.Blue
        lblright18.BackColor = Color.Blue
        lblright20.BackColor = Color.Blue
        lblright19.BackColor = Color.Blue
        lblright21.BackColor = Color.Blue

        'bad labels

        lblwrong1.BackColor = Color.Green
        lblwrong2.BackColor = Color.Green
        lblwrong3.BackColor = Color.Green
        lblwrong4.BackColor = Color.Green
        lblwrong5.BackColor = Color.Green


        lblwrong7.BackColor = Color.Green
        lblwrong8.BackColor = Color.Green
        lblwrong9.BackColor = Color.Green
        lblwrong10.BackColor = Color.Green
        lblwrong11.BackColor = Color.Green
        lblwrong12.BackColor = Color.Green
        lblwrong13.BackColor = Color.Green
        lblwrong14.BackColor = Color.Green

        lblwrong20.BackColor = Color.Green
        lblwrong21.BackColor = Color.Green
        lblwrong22.BackColor = Color.Green

        lblwrong24.BackColor = Color.Green
        lblwrong25.BackColor = Color.Green
        lblwrong26.BackColor = Color.Green
        lblwrong27.BackColor = Color.Green

        lblwrong28.BackColor = Color.Green
        lblwrong29.BackColor = Color.Green
        lblwrong30.BackColor = Color.Green
        lblwrong31.BackColor = Color.Green

        lblwrong33.BackColor = Color.Green
        lblwrong34.BackColor = Color.Green
        lblwrong35.BackColor = Color.Green
        lblwrong36.BackColor = Color.Green

        lblwrong38.BackColor = Color.Green
        lblwrong39.BackColor = Color.Green
        lblwrong40.BackColor = Color.Green
        lblwrong41.BackColor = Color.Green


    End Sub

    Private Sub lblwrong1_MouseMove(sender As Object, e As MouseEventArgs) Handles lblwrong1.MouseMove, lblwrong2.MouseMove, lblwrong3.MouseMove, lblwrong4.MouseMove, lblwrong5.MouseMove, lblwrong7.MouseMove, lblwrong8.MouseMove, lblwrong9.MouseMove, lblwrong10.MouseMove, lblwrong11.MouseMove, lblwrong12.MouseMove, lblwrong13.MouseMove, lblwrong14.MouseMove, lblwrong20.MouseMove, lblwrong21.MouseMove, lblwrong22.MouseMove, lblwrong24.MouseMove, lblwrong25.MouseMove, lblwrong26.MouseMove, lblwrong27.MouseMove, lblwrong28.MouseMove, lblwrong29.MouseMove, lblwrong30.MouseMove, lblwrong31.MouseMove, lblwrong33.MouseMove, lblwrong34.MouseMove, lblwrong35.MouseMove, lblwrong36.MouseMove, lblwrong38.MouseMove, lblwrong39.MouseMove, lblwrong40.MouseMove, lblwrong41.MouseMove
        Frmintro.stoptheme() 'stops currently played audio

        Frmintro.playtheme("levelfail.wav") 'plays level failed theme

        MsgBox("You are just bad")

        Frmintro.stoptheme() 'stops currently played audio

        Frmintro.playtheme("mainmenutheme.wav") ' plays menu intro theme

        frmlevel1.Close()

        frmlevel2.Close()


        Me.Close()
    End Sub


    Private Sub pborealpikachu_MouseMove(sender As Object, e As MouseEventArgs) Handles pborealpikachu.MouseMove

        Frmintro.stoptheme() 'stops currently played audio

        Frmintro.playtheme("levelsuccess.wav")

        MsgBox("You win, You have succeded")

        Frmintro.stoptheme() 'stops currently played audio

        frmlevel4.ShowDialog()
    End Sub

    Private Sub pbofakeditto_MouseMove(sender As Object, e As MouseEventArgs) Handles pbofakeditto.MouseMove

        Frmintro.stoptheme() 'stops currently played audio

        Frmintro.playtheme("levelfail.wav") 'plays level failed theme


        pbofakeditto.Visible = False
        pboditto.Visible = True
        MsgBox("YOu lose, Ditto has fooled you ")


        Frmintro.stoptheme() ' stops audio

        Frmintro.playtheme("mainmenutheme.wav") ' plays menu intro theme

        Me.Close()

    End Sub

    Private Sub pbofakezoroa_MouseMove(sender As Object, e As MouseEventArgs) Handles pbofakezoroa.MouseMove
        Frmintro.stoptheme() 'stops currently played audio

        Frmintro.playtheme("levelfail.wav") 'plays level failed theme


        pbofakezoroa.Visible = False
        pbozoroa.Visible = True
        MsgBox("Zoroa has fooled you, you lose")

        Frmintro.stoptheme() ' stops played audio

        Frmintro.playtheme("mainmenutheme.wav") ' plays menu intro theme

        frmlevel1.Close()
        frmlevel2.Close()
        Me.Close()
    End Sub
End Class