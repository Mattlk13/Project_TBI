Public Class sample

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label1.Text = "Voice Recognition Started"
        Button2.Enabled = True
        Button1.Enabled = False
        'SpeechLibrary_StartSpeechRecognition()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Label1.Text = "Press start to start speech recognition"
        Button1.Enabled = True
        Button2.Enabled = False
        'SpeechLibrary_StopSpeechRecognition()
    End Sub
End Class