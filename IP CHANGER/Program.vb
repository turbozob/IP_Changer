Imports System.Threading


Module Program
    '// CANNOT USE LOGGER HERE BECAUSE IT CRASHED THIS MODULE THEN
    'Public loggerProgram As log4net.ILog

    Public Sub Main()

        'loggerProgram = log4net.LogManager.GetLogger("IP_CHANGER_ON_LF")
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)


        'MessageBox.Show(" Before program ")
        AddHandler Application.ThreadException, AddressOf OnThreadException

        ''Added this
        AddHandler AppDomain.CurrentDomain.UnhandledException, AddressOf UnhandledExceptionEventRaised
        Application.Run(New Form1()) ''//Use your main form here
    End Sub
    Private Sub OnThreadException(ByVal sender As Object,
                      ByVal e As ThreadExceptionEventArgs)
        ' This is where you handle the exception

        MessageBox.Show(e.Exception.Message, "OnThreadException",
MessageBoxButtons.OK, MessageBoxIcon.Error)

    End Sub

    'Added this
    Sub UnhandledExceptionEventRaised(ByVal sender As Object, ByVal e As UnhandledExceptionEventArgs)
        Dim EX As Exception = e.ExceptionObject

        If e.IsTerminating Then
            Dim o As Object = e.ExceptionObject
            ' MessageBox.Show(o.ToString, "UnhandledExceptionEventRaised ToString",
            '         MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' MessageBox.Show(EX.StackTrace, "UnhandledExceptionEventRaised EX.StackTrace",
            'MessageBoxButtons.OK, MessageBoxIcon.Error)

            MessageBox.Show(EX.Message, "UnhandledExceptionEventRaised EX.Message",
MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' loggerProgram.Error("UnhandledExceptionEventRaised EX.Message" & EX.Message)


        End If



    End Sub
End Module