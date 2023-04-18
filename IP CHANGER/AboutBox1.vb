Imports System.IO
Imports System.Reflection

Public NotInheritable Class AboutBox1

    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the title of the form.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("About {0}", ApplicationTitle)
        Me.lblProductName.Text = My.Application.Info.ProductName
        Me.lblVersion.Text = String.Format("Version: {0}", My.Application.Info.Version.ToString)

        Dim compileTimeStamp As DateTime = File.GetLastWriteTime(Assembly.GetExecutingAssembly().Location)
        Me.lblCompileDate.Text = String.Format("Build date: {0}", compileTimeStamp)

        Me.lblCopyright.Text = My.Application.Info.Copyright
        Me.lblCompanyName.Text = My.Application.Info.CompanyName
        Me.txtDescription.Text = My.Application.Info.Description
        Me.lblDescription.Text = "Network adapter IP change tool"

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
