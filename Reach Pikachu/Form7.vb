Public Class frmlastlevel6
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Frmintro.playtheme("levelsixtheme.wav")

        MsgBox("Remember what greninja said? He said 'Remember .............' If you do what he said now then you will win the level or you could keep pressing buttons until you get it right????????/")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button3.Click, Button5.Click, Button6.Click, Button8.Click, Button9.Click, Button10.Click, Button11.Click, Button12.Click, Button13.Click, Button14.Click, Button15.Click, Button16.Click, Button2.Click

        Frmintro.stoptheme()

        Frmintro.playtheme("levelfail.wav")



        MsgBox("You didn't do what greninja told you, It's a shame that you lost at the very last level")

        Frmintro.stoptheme()

        Frmintro.playtheme("mainmenutheme.wav") ' plays menu intro theme

        frmlevel1.Close()
        frmlevel2.Close()
        frmlevel3.Close()
        frmlevel4.Close()
        frmlevel5.Close()
        Me.Close()


    End Sub

    Private Sub btnwin_Click(sender As Object, e As EventArgs) Handles btnwin.Click

        Frmintro.stoptheme()

        Frmintro.playtheme("gamewon.wav")

        MsgBox("You win, I am amazed at your briliance and ability to randomly guess")

        Frmintro.stoptheme()

        frmdatabasechallenge.ShowDialog()
    End Sub
End Class