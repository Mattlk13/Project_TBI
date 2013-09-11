Imports System.Speech.Recognition


Public Class speechExample

    
    Private Sub speechExample_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Patient_TBIDataSet.QuestionRepo' table. You can move, or remove it, as needed.
        'Me.QuestionRepoTableAdapter.Fill(Me.Patient_TBIDataSet.QuestionRepo)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Q_ID field is Empty", vbOK)
        Else
            Dim questionNumber As Integer = TextBox1.Text
            'Me.QuestionRepoTableAdapter.FillBy(Me.Patient_TBIDataSet.QuestionRepo, questionNumber)
            'Me.QuestionRepoTableAdapter.FillBy1(Me.Patient_TBIDataSet.QuestionRepo, questionNumber)
        End If
    End Sub

End Class