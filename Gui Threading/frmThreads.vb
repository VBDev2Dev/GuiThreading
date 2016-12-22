Imports System.Threading
Imports Gui_Threading

Public Class frmThreads
    Private Sub btnWork_Click(sender As Object, e As EventArgs) Handles btnWork.Click
        MessageBox.Show("Notice window is NOT responsive for the next minute.")
        ButtonStatus = False
        Dim num As Integer = DoWork()
        ButtonStatus = True
    End Sub

    Private Async Sub btnDoWorkAsync_Click(sender As Object, e As EventArgs) Handles btnDoWorkAsync.Click
        MessageBox.Show("Notice window is responsive for the next minute.")
        ButtonStatus = False
        Dim num As Integer = Await DoWorkAsync()
        ButtonStatus = True
    End Sub

    WriteOnly Property ButtonStatus As Boolean
        Set(value As Boolean)
            btnDoWorkAsync.Enabled = value
            btnWork.Enabled = value
        End Set
    End Property
    Protected Overridable Sub OnWorkProgress(ByVal sender As Object, ByVal e As WorkProgressInfoEventArgs)
        RaiseEvent WorkProgress(sender, e)
    End Sub
    Event WorkProgress(sender As Object, e As WorkProgressInfoEventArgs)

    Function DoWork() As Integer
        Dim num As Integer = 0

        Const count As Integer = 60
        For x As Integer = 0 To count
            num += x

            Dim tmp As Integer = x
            Thread.Sleep(1000) 'NEVER use this in real code.
            'Just used to artificially extend the time this process takes
            Dim prgUpdate As Action = Sub()
                                          OnWorkProgress(Me, New WorkProgressInfoEventArgs With {.Progress = CInt(tmp / count * 100)})
                                      End Sub
            If InvokeRequired Then
                Invoke(prgUpdate)
            Else
                prgUpdate()
            End If

        Next
        Return num

    End Function

    Async Function DoWorkAsync() As Task(Of Integer)
        Return Await Task.Run(Function()
                                  Return DoWork()
                              End Function)
    End Function

    Private Sub frmThreads_WorkProgress(sender As Object, e As WorkProgressInfoEventArgs) Handles Me.WorkProgress
        prgStatus.Value = e.Progress
    End Sub

End Class
