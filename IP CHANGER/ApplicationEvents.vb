'Imports System.Text
'Imports System.IO

'Namespace My

'    ' The following events are available for MyApplication:
'    ' 
'    ' Startup: Raised when the application starts, before the startup form is created.
'    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
'    ' UnhandledException: Raised if the application encounters an unhandled exception.
'    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
'    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
'    Partial Friend Class MyApplication



'        'One of the global exceptions we are catching is not thread safe, 
'        'so we need to make it thread safe first.
'        Private Delegate Sub SafeApplicationThreadException(ByVal sender As Object, ByVal e As Threading.ThreadExceptionEventArgs)


'        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup

'            MessageBox.Show("MyApplication_Startup", "MyApplication_Startup",
'      MessageBoxButtons.OK, MessageBoxIcon.Information)

'            'There are three places to catch all global unhandled exceptions:
'            'AppDomain.CurrentDomain.UnhandledException event.
'            'System.Windows.Forms.Application.ThreadException event.
'            'MyApplication.UnhandledException event.
'            AddHandler AppDomain.CurrentDomain.UnhandledException, AddressOf AppDomain_UnhandledException
'            AddHandler System.Windows.Forms.Application.ThreadException, AddressOf app_ThreadException
'            ' AddHandler AccessViolationException, AddressOf app_AccessViolationException


'        End Sub


'        'Private Sub app_AccessViolationException(ByVal sender As Object, ByVal ex As System.AccessViolationException)

'        'End Sub

'        Private Sub app_ThreadException(ByVal sender As Object, ByVal e As Threading.ThreadExceptionEventArgs)

'            MessageBox.Show(e.Exception.Message, "app_ThreadException",
'      MessageBoxButtons.OK, MessageBoxIcon.Error)
'            'This is not thread safe, so make it thread safe.
'            If MainForm.InvokeRequired Then
'                ' Invoke back to the main thread
'                MainForm.Invoke(New SafeApplicationThreadException(AddressOf app_ThreadException),
'                    New Object() {sender, e})
'            Else


'            End If

'        End Sub

'        Private Sub AppDomain_UnhandledException(ByVal sender As Object, ByVal e As UnhandledExceptionEventArgs)
'            Dim EX As Exception = e.ExceptionObject

'            MessageBox.Show(EX.StackTrace, "AppDomain_UnhandledException",
'      MessageBoxButtons.OK, MessageBoxIcon.Error)

'        End Sub


'        Private Sub MyApplication_UnhandledException(sender As Object, e As Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException

'            MessageBox.Show(e.Exception.StackTrace, "MyApplication_UnhandledException",
'        MessageBoxButtons.OK, MessageBoxIcon.Error)

'        End Sub



'    End Class


'End Namespace