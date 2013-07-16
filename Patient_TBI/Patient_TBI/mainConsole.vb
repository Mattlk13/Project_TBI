'mainConsole.vb: Main interaction form where users get to interact with patient using text and speech
'Date: 10 June 2013
'Author: Raghavi Sakpal

Imports System.Timers
Imports System.Speech.Recognition
Imports Patient_TBI.patientChoice

Public Class mainConsole

    Private Shared WithEvents myTimer As New System.Timers.Timer
    Private Shared exitFlag As Boolean = False
    Private Shared timerCounter As Integer = 1


    ' Recogniser & Grammer
    Dim recog As New SpeechRecognizer
    Dim gram As Grammar

    ' Events
    Public Event SpeechRecognized As EventHandler(Of SpeechRecognizedEventArgs)
    Public Event SpeechRecognizedRejected As EventHandler(Of SpeechRecognitionRejectedEventArgs)

    ' Variable to store speech input to send to database
    Dim speechResult As String

    ' Date: 06/14/2013 
    ' Function: To load all components on form load
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Create the Speech Recognition Grammar
        Dim sqlQuest() As String = {"What is your name", "What is your country of birth", "What is your current occupation"}
        Dim speechGrammar() As String = {"What is your name", "What is your country of birth", "What is your current occupation"}
        Dim words As New Choices(speechGrammar)
        gram = New Grammar(New GrammarBuilder(words))
        'recog.LoadGrammar(gram)
        recog.LoadGrammar(New DictationGrammar())

        ' Make a call to load background image for haptek player
        loadBkgrnd(AxActiveHaptekX1)

        ' Make a call to load the patients on load
        agentLoad(AxActiveHaptekX1, patientChoice.passButtonValue)

        ' Introduce the agent
        agentTalk(AxActiveHaptekX1, "Hello ! My name is Kevin and I am your patient today.")

        ' Add a timer interval for 10 seconds
        myTimer.Interval = 20000
        myTimer.Enabled = True

        'Enable the Speech Recognizer
        recog.Enabled = False

        'Add Handlers for Speech and Timer
        AddHandler recog.SpeechRecognized, AddressOf RecieveEvent
        AddHandler recog.SpeechRecognitionRejected, AddressOf RecieveEventFail
        AddHandler myTimer.Elapsed, AddressOf startTimer

    End Sub

    ' Date: 06/14/2013 
    ' Function: To load the character in the main interface
    Private Sub queryButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles queryButton.Click
        'Send the query back to the patient
        If queryText.Text = "" Or queryText.Text = "Enter your text here" Then
            MsgBox("Enter a query in the text box to send.")
        Else
            'Gesture while talking
            responseTextBox.Text = queryText.Text
            randomAgentTalking(AxActiveHaptekX1)
            agentTalk(AxActiveHaptekX1, queryText.Text)
        End If
    End Sub

    ' Date: 06/12/2013
    ' Function: On click of home button go back to patientChoice interface
    Private Sub homeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles homeButton.Click
        closeForm()

    End Sub

    ' Date: 06/12/2013
    ' Function: On click of exit button quit the entire application
    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        'Stop the timer
        myTimer.Enabled = False

        'Exit out of the software
        If MsgBox("Are you sure you want to close the application ?", MsgBoxStyle.OkCancel) = DialogResult.OK Then
            End
        End If
    End Sub

    ' Date: 06/18/2013
    ' Function: Set a timer function to associate a random mood and behavior at radom times
    Private Sub startTimer()

        'Genrate a random number every time
        Dim randomVal As Integer = CInt(Int(moods.Length() * Rnd()))

        'Generate a random mood every few seconds
        Dim agentMood As String = randomAgentMood(AxActiveHaptekX1, randomVal)

        'Generate a random gesture based on the mood
        randomAgentGestures(AxActiveHaptekX1, agentMood)

    End Sub

    Private Delegate Sub closeFormCallBack()

    ' Date: 06/12/2013
    ' Function: On click of home button go back to patientChoice interface
    Private Sub closeForm()

        If InvokeRequired Then
            Dim d As New closeFormCallBack(AddressOf closeForm)
            Invoke(d, Nothing)
        Else
            'Take the user back to the main page
            patientChoice.Visible = True
            Me.Close()
        End If
    End Sub

    ' Date: 06/21/2013
    ' Function: On click of this button enable speech recognition and disable other buttons
    Private Sub talkStartButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles talkStartButton.Click
        'Enable the Speech Recognizer
        recog.Enabled = True
        talkStartButton.Enabled = False
        queryButton.Enabled = False
        responseTextBox.Text = "Listening...."

        'Agent Gestures while listening to User Speech 
        randomAgentListening(AxActiveHaptekX1)

    End Sub

    ' Date: 06/21/2013
    ' Function: Speech Recognition Event
    Public Sub RecieveEvent(ByVal sender As System.Object, ByVal e As RecognitionEventArgs)

        MsgBox(e.Result.Text)
        If e.Result.Text = "What is your name" Or e.Result.Text = "What is your country of birth" Or e.Result.Text = "What is your current occupation" Then
            responseTextBox.Text = e.Result.Text
            speechResult = e.Result.Text
            MsgBox("Speech Detected")
        End If

        ' Disable the speech recognizer
        recog.Enabled = False

        talkStartButton.Enabled = True

        ' Call to the function to retrieve information from database
        informationRetrieval()

    End Sub

    ' Date: 06/21/2013
    ' Function: Speech Recognition Failed
    Public Sub RecieveEventFail(ByVal sender As System.Object, ByVal e As RecognitionEventArgs)
        MsgBox(e.Result.Text)
        MsgBox("No Speech Detected")
        agentTalk(AxActiveHaptekX1, "Can't comprehend the question.")

        ' Disable the speech recognizer
        recog.Enabled = False

        talkStartButton.Enabled = True
        responseTextBox.Text = "Patient Response"
    End Sub

    ' Date: 06/25/2013
    ' Function: To retrieve the agent response based on the question asked
    Public Sub informationRetrieval()

        'Make a call to the SQL Patient_TBI database to retrieve answer based on user question
        Me.QuestionRepoTableAdapter1.retrieveAns(Me.Patient_TBIDataSet.QuestionRepo, speechResult)
        agentTalk(AxActiveHaptekX1, AnswerRepoTextBox.Text)
        responseTextBox.Text = AnswerRepoTextBox.Text

        responseTextBox.Text = "Patient Response"
    End Sub

End Class
