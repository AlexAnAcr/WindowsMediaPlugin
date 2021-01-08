Public Class Form1
    Dim player As New WMPLib.WindowsMediaPlayer
    Dim second_all As Integer = 0
    Dim url As String
    Dim second As Integer = 0
    Dim name0 As String = ""
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox2.Text <> "" Then
            Button1.Enabled = False
            Button2.Enabled = False
            NumericUpDown1.Enabled = False
            Button3.Enabled = True
            Button4.Enabled = False
            second_all = NumericUpDown1.Value
            If Dialog1.Notreeforstart.Checked Then
                Me.WindowState = 1
            End If
            Label2.Text = "До срабатывания таймера осталось: " & (second_all) & " сек."
            If Dialog1.CheckBox1.Checked Then
                Form2.Label1.Text = second_all
                Form2.WindowState = 0
                Form2.Show()
            End If
            If Dialog1.CheckBox2.Checked Then
                NumericUpDown1.Value = 1
                TextBox2.Text = ""
                OpenFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                name0 = ""
            End If
            Timer1.Enabled = True
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        OpenFileDialog1.FileName = name0
        Dim result As DialogResult
        result = OpenFileDialog1.ShowDialog()
        If result = DialogResult.OK Then
            url = OpenFileDialog1.FileName
            TextBox2.Text = Mid(OpenFileDialog1.SafeFileName, 1, OpenFileDialog1.SafeFileName.Length - 4)
            name0 = Mid(OpenFileDialog1.SafeFileName, 1, OpenFileDialog1.SafeFileName.Length - 4)
            Button1.Enabled = True
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label2.Text = "До срабатывания таймера осталось: " & (second_all) - second & " сек."
        If Dialog1.CheckBox1.Checked Then
            Form2.Label1.Text = (second_all) - second
        End If
        If second = second_all Then
            If Dialog1.Treeforstart.Checked Then
                Me.WindowState = 1
            ElseIf Dialog1.Notreeforstart.Checked Then
                Me.WindowState = 0
            End If
            Label2.Text = "Воспроизведение..."
            Timer1.Enabled = False
            PlayState.Enabled = True
            If My.Computer.FileSystem.FileExists(url) Then
                player.URL = url
            Else
                MsgBox("Ошибка, заданый файл не существует!", , "Ошибка")
            End If
            If Dialog1.CheckBox1.Checked Then
                Form2.Close()
            End If
        Else
            second += 1
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Button2.Enabled = True
        NumericUpDown1.Enabled = True
        Button3.Enabled = False
        Timer1.Enabled = False
        Button4.Enabled = True
        second = 0
        Label2.Text = "Таймер не запущен."
        player.controls.stop()
        If Dialog1.CheckBox2.Checked = False Then
            Button1.Enabled = True
        End If
        If Dialog1.CheckBox1.Checked Then
            Form2.Close()
        End If
    End Sub
    Private Sub КопирватьToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles КопирватьToolStripMenuItem.Click
        My.Computer.Clipboard.SetText(NumericUpDown1.Value)
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dialog1.ShowDialog()
    End Sub
    Private Sub PlayState_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayState.Tick
        If player.playState = 1 Then
            If Dialog1.CheckBox2.Checked = False Then
                Button1.Enabled = True
            End If
            Button2.Enabled = True
            NumericUpDown1.Enabled = True
            Button3.Enabled = False
            Timer1.Enabled = False
            PlayState.Enabled = False
            Button4.Enabled = True
            second = 0
            Label2.Text = "Таймер не запущен."
            player.controls.stop()
        End If
    End Sub
End Class
