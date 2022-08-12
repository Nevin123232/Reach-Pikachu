Option Explicit On


'used to create files 
Imports System.IO
Imports System.Text


Public Class frmdatabasechallenge
    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click

        'closes all of the previous forms containing levels 
        Frmintro.Close()
        frmlevel1.Close()
        frmlevel2.Close()
        frmlevel3.Close()
        frmlevel4.Close()
        frmlevel5.Close()
        frmlastlevel6.Close()
        Me.Close()


    End Sub

    Private Sub btninput_Click(sender As Object, e As EventArgs) Handles btninput.Click



        ' makes it so that you can write files (looked it up lol ) 
        Dim name As String
        name = txtwinners.Text
        Dim winfile As String = "winner.txt"

        If System.IO.File.Exists(winfile) = True Then
            ' This cleared the previous winner then wrote the new winner
            ' Dim objWriter As New System.IO.StreamWriter(FILE_NAME)

            ' objWriter.WriteLine(name)
            '  objWriter.Close()



            'This should hopefully just add a new winner (append text)

            'vbCrLf (i think this is the vb newline character, I looked it up on the internet


            My.Computer.FileSystem.WriteAllText(winfile, name + "  " + vbCrLf, True) 'Append text is set to true

            MessageBox.Show("You have been inputted into the file of winners, Congradulations !!!!!!")

            'clears listbox of previous information 
            lbowinners.Items.Clear()

            'Apparently reads the file and writes the new information in a listbox 
            Dim lines() As String = IO.File.ReadAllLines(winfile)
            lbowinners.Items.AddRange(lines)




        Else

            MessageBox.Show("File Does Not Exist")

        End If


    End Sub

    Private Sub frmdatabasechallenge_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Frmintro.playtheme("levelseventheme.wav")


        If System.IO.File.Exists("winner.txt") = True Then

            'Idek mannnnnnn, stackoverflow hard carried, writes text from a file to a listbox
            Dim lines() As String = IO.File.ReadAllLines("winner.txt")
            lbowinners.Items.AddRange(lines)

        Else

            Dim path As String = "winner.txt"


            ' Create or overwrite the file. (This incase this is being run on another user's computer)
            Dim fs As FileStream = File.Create(path)

            MessageBox.Show("The winners File Does Not Exist on this computer, A replicate has been created")

        End If
    End Sub


End Class