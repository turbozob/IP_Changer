Public Class Form2
    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        Me.Close()
    End Sub

    Private Sub CheckBox1_Click(sender As Object, e As EventArgs) Handles CheckBox1.Click
        If CheckBox1.Checked Then
            My.Settings.ConfigFilePath = Form1.FilePath
            My.Settings.Save()
        End If
    End Sub
    Private Sub CheckBox2_Click(sender As Object, e As EventArgs) Handles CheckBox2.Click
        If CheckBox2.Checked Then
            My.Settings.LastNICUsed = Form1.ComboBox3.SelectedItem
            My.Settings.Save()
        End If
    End Sub

End Class