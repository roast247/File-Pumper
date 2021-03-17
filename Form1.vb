Public Class Form1

    Private draggable As Boolean
    Private mouseY As Integer
    Private mouseX As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbtnKilobyte.Checked = True
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "All Files (*.*)|*.*"
        ofd.ShowDialog()
        txtFileName.Text = ofd.FileName
    End Sub

    Private Sub btnPump_Click(sender As Object, e As EventArgs) Handles btnPump.Click
        Try
            MsgBox("The more bytes added the longer it will take to pump, so please be patient if pumping a lot of bytes")
            Dim sfd As New SaveFileDialog
            sfd.Filter = "All Files (*.*)|*.*"
            sfd.ShowDialog()
            Dim filesize As Double = Val(NumericUpDown1.Value)
            IO.File.Copy(txtFileName.Text, sfd.FileName)
            If rbtnKilobyte.Checked Then
                filesize = filesize * 1024
            End If
            If rbtnMegabyte.Checked Then
                filesize = filesize * 1048576
            End If
            Dim filetopump = IO.File.OpenWrite(sfd.FileName)
            Dim size = filetopump.Seek(0, IO.SeekOrigin.End)
            While size < filesize
                filetopump.WriteByte(0)
                size += 1
            End While
            filetopump.Close()
            MsgBox("Pumped Successfully!")
        Catch ex As Exception
            MsgBox("Error(s) occured" & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        draggable = False
    End Sub

    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label1.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles Label1.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub

    Private Sub Label1_MouseUp(sender As Object, e As MouseEventArgs) Handles Label1.MouseUp
        draggable = False
    End Sub

    Private Sub PictureBox2_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub PictureBox2_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub

    Private Sub PictureBox2_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseUp
        draggable = False
    End Sub
End Class