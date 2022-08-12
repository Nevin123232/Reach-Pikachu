

Public Class Frmintro
    Public Function playtheme(songfile As String) 'plays theme provided in sound file

        My.Computer.Audio.Play(songfile, AudioPlayMode.BackgroundLoop) ' starts ausio based on file provided

    End Function

    Public Function stoptheme() ' stops playing of theme in a sound file

        My.Computer.Audio.Stop() 'stops audio currently playing

    End Function
    Private Sub Frmintro_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblexample.BackColor = Color.Blue

        playtheme("mainmenutheme.wav") ' plays menu intro theme


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        frmlevel1.Close()
        frmlevel2.Close()
        frmlevel3.Close()
        frmlevel4.Close()
        frmlevel5.Close()
        frmlastlevel6.Close()

        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        pboditto.Visible = True
        pbozoroa.Visible = True
        pbozoroark.Visible = True
        MsgBox("Watch out for Zoroa, Zoroark, and Ditto. They can randomly appear on the map pretending to be pikachu (You'll have to guess randomly and get lucky) . Also remember Alt-K. (You'll need it)")
    End Sub

    Private Sub btnstart_Click(sender As Object, e As EventArgs) Handles btnstart.Click
        stoptheme() 'stops audio
        frmlevel1.ShowDialog()

    End Sub
End Class
