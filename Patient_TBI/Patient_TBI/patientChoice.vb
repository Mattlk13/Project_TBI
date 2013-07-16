'patientChoice: Main interaction form where users get to interact with patient using text and speech
'Date: 12 June 2013
'Author: Raghavi Sakpal

Public Class patientChoice
    Public passButtonValue As String

    ' Date: 06/12/2013
    ' Function: On click 2nd patient button load patient2 in mainConsole
    Private Sub patient2Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles patient2Button.Click
        passButtonValue = "patient2"
        mainConsole.Show()
        Me.Visible = False
    End Sub

    ' Date: 06/12/2013
    ' Function: On click 1st patient button load patient1 in mainConsole
    Private Sub patient1Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles patient1Button.Click
        passButtonValue = "patient1"
        mainConsole.Show()
        Me.Visible = False
    End Sub

    ' Date: 06/12/2013
    ' Function: Function to quit the application
    Private Sub patientChoice_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Are you sure you want to close the application ?", MsgBoxStyle.OkCancel) = DialogResult.Cancel Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        sample.Visible = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        speechExample.Show()
    End Sub
End Class