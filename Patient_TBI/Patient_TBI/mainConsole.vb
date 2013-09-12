'mainConsole.vb: Main interaction form where users get to interact with patient using text and speech
'Date: 10 June 2013
'Author: Raghavi Sakpal

Imports System.Timers
Imports System.Speech.Recognition
Imports System.IO
Imports Patient_TBI.patientChoice
Imports System.Net

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

    ' Variable to Measure row count for Question DataGrid
    Dim rowCountQuestion As Integer

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

        ' Translate agent within the screen
        translateAgent(AxActiveHaptekX1, 0, 20, 70)

        ' Introduce the agent
        agentTalk(AxActiveHaptekX1, "Hello ! My name is Kevin and I am your patient today.")

        ' Load Questions from database: Only Call Once
        'PHPfileCall()

        ' Load questions: Only Call Once
        'SQLtoText()

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
            Dim question As String = queryText.Text

            'Make a call to the algorithm to find the correct question
            IR(question)
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
        'agentTalk(AxActiveHaptekX1, AnswerRepoTextBox.Text)
        'responseTextBox.Text = AnswerRepoTextBox.Text

        responseTextBox.Text = "Patient Response"
    End Sub

    ' Date: 07/18/2013
    ' Function: Create a data file populated with questions
    Private Sub dataFile_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim filePath = "C:\Documents and Settings\rsakpal.UNCCHARLOTTE-NT\Desktop\Project_TBI\Patient_TBI\POSTagger\question.txt"

        ' Check to see if the file exists
        If Not File.Exists(filePath) Then
            ' Create a file to write to
            File.CreateText(filePath)
        Else
            File.WriteAllText(filePath, "")
        End If

        'Shell("C:\python27\python ""C:\Documents and Settings\rsakpal.UNCCHARLOTTE-NT\Desktop\Project_TBI\Patient_TBI\POSTagger\POSTagger.py"" ", vbHide)

        'System.Diagnostics.Process.Start("C:\Documents and Settings\rsakpal.UNCCHARLOTTE-NT\Desktop\Project_TBI\Patient_TBI\POSTagger\POSTagger.py")
        MsgBox("Done")
    End Sub

    ' To Read data from SQL sever to the text file
    Private Sub SQLtoText()
        ' Create a text file to copy your data
        Dim path As String = "C:\Documents and Settings\rsakpal.UNCCHARLOTTE-NT\Desktop\Project_TBI\Patient_TBI\Patient_TBI\QuestionLog.txt"

        ' Create or overwrite the file.
        Dim File = My.Computer.FileSystem.OpenTextFileWriter(path, False)

        ' Retrieve questions from the database
        Dim quesCount = Question_TBLTableAdapter1.SelectCountQ_ID()


        ' Retrieve each question from the database and write it down to the text file
        For index As Integer = 1 To quesCount

            ' Retrieve question from the database based on the question number
            Dim question = Question_TBLTableAdapter1.SelectQuestion(index)

            Dim regexQuestion = questionMatching.regexQuestion(question)

            Dim taggedSentDict = POSTagger.main_POS(regexQuestion)

            ' Concat the contents of Dictionary to create set of keywords
            Dim taggedSent As String = POSTagger.regexKeyword(taggedSentDict)

            ' Add text to the file.
            File.Write(index)
            File.Write(Space(5))
            File.Write(regexQuestion)
            File.Write(Space(5))
            File.Write(taggedSent)
            File.Write(vbNewLine)
        Next

        File.Close()

        MsgBox("File Created")
    End Sub

    Private Sub PHPfileCall()
        Dim client As WebClient = New WebClient()
        Dim phpResponse As String = client.DownloadString("http://ccis004.uncc.edu/~rsakpal/Patient_TBI/SQLProcessing.php")
        MsgBox(phpResponse)
        ' Split the phpResponse String based on HTML line break <BR> tags
        Dim SQLData() As String = Split(phpResponse, "<BR>")
        For index As Integer = 0 To SQLData.Length() - 1
            Dim queryData() As String = Split(SQLData(index), "<SPACE>")
            ' Insert this data in our local database
            Question_TBLTableAdapter1.InsertQueryNew(queryData(0), queryData(1), queryData(2), queryData(3), queryData(4), index + 1)
        Next

    End Sub

    ' The main IR algorithm
    Private Sub IR(ByVal ques As String)
        ' METHOD 1: Direct Matching
        Dim quesNo As Integer = questionMatching.directMatchingFile(ques)

        ' If match not found break the question up
        If quesNo = -1 Then
            MsgBox("Question not found by direct matching.")
            ' METHOD 2: N-Gram matching
            Dim quesNumNgram = n_gramMatching.main_nGrams(ques)
            
            ' Display answer from the n-gram method 
            If quesNumNgram = -1 Then
                MsgBox("No solution found by N-Gram Method")
            Else
                displayAnswer(quesNumNgram)
            End If
            
            '----------------------------------------------------------
            ' METHOD 3: POS-Tagging Method
            MsgBox("Lets find the match by POS tagging method")
            Dim taggedDict = POSTagger.main_POS(ques)
            ' Concat the contents of Dictionary to create set of keywords
            Dim taggedSent As String = POSTagger.regexKeyword(taggedDict)
            ' Display the question on the screen
            Dim quesNumPOS = POSTagMatching(taggedSent)
            
            ' Display the result from POS-tagging method
            If quesNumPOS = -1 Then
                MsgBox("No solution found by POS-Tagging method")
            Else
                displayAnswer(quesNumPOS)
            End If

            '--------------------------------------------------
            ' If Method 2 soln found and Method 3 soln not found
            'If Not quesNumNgram = -1 And quesNumPOS = -1 Then
                ' Display the result on the screen
                'retrieveAns(quesNumNgram)
            'ElseIf quesNumNgram = -1 And Not quesNumPOS = -1 Then ' If Method 2 soln not found and Method 3 soln found
                ' Display the result on the screen
                'retrieveAns(quesNumPOS)
            'ElseIf Not quesNumNgram = -1 And Not quesNumPOS = -1 Then ' IF soln found for both method
                'compareAns(quesNumNgram, quesNumPOS)
            'Else ' If -1 returned
                'MsgBox("Question not found by n-gram tokenizing method and POS-tagging Method")
            'End If

        Else ' Display the answer found by the direct matching method
            MsgBox("Question Found: " & quesNo)
            responseTextBox.Text = Question_TBLTableAdapter1.SelectAnswer(quesNo)
        End If
    End Sub

    ' Function to display question found by POS tag method
    Function POSTagMatching(ByVal taggedInput As String)
        'MsgBox("Tagged Sentence: " & taggedInput)
        Dim keywordMatchCount As Integer                                        ' Variable to count the number of keywords match
        Dim keywordMatchDict As New Dictionary(Of Integer, List(Of Integer))    ' Dictionary to store the question number and their match count

        ' Split the tagged input based on commas
        Dim tagInputArr() As String = Split(taggedInput, ",")

        ' Open the input file 
        Dim path As String = "C:\Documents and Settings\rsakpal.UNCCHARLOTTE-NT\Desktop\Project_TBI\Patient_TBI\Patient_TBI\QuestionLog.txt"

        ' Open file to Read
        Dim file = My.Computer.FileSystem.OpenTextFileReader(path)

        Do Until file.EndOfStream
            ' Initialize the keyowrd count to zero
            keywordMatchCount = 0

            ' Read line from the file
            Dim dataString As String = file.ReadLine()

            ' Split the questionString into tokens based on space
            Dim dataArr() As String = Split(dataString, Space(5))

            'MsgBox("Tagged Data: " & dataArr(2))
            ' Split the keyword data string based on commas
            Dim keywordArr() As String = Split(dataArr(2), ",")

            ' Compare each keyword in input string with each keyword in data string
            For item As Integer = 0 To tagInputArr.Length - 2
                For index As Integer = 0 To keywordArr.Length - 2
                    If String.Compare(tagInputArr(item), keywordArr(index), True) = 0 Then
                        ' Increment the match count by 1
                        keywordMatchCount = keywordMatchCount + 1
                    End If
                Next
            Next

            ' Create a new list to store question number
            Dim questionNoList As New List(Of Integer)

            ' Add the question number associated with the question to the list
            questionNoList.Add(CInt(dataArr(0)))

            ' Check if key already present in the Dictionary
            If keywordMatchDict.ContainsKey(keywordMatchCount) Then
                ' Append the question number associated with it to the dictionary
                keywordMatchDict.Item(keywordMatchCount).Add(CInt(dataArr(0)))
            Else
                ' Create a new key and add the questio number list to the dictionary
                keywordMatchDict.Add(keywordMatchCount, questionNoList)
            End If
        Loop
        ' Close the file
        file.Close()

        ' Find the question number with maximum count
        Dim quesNumPOS = n_gramMatching.findQuestionNo(keywordMatchDict)

        Return quesNumPOS

    End Function

    ' Function to retrieve the answer from the database
    Private Sub retrieveAns(ByVal quesNumString As String)
        ' Split the string object in tokens
        Dim qNo() = Split(quesNumString, ",")

        ' Check if qNo array has more than one question number
        If qNo.Length() > 1 Then
            ' Print each question number in the textbox for user to choose from
            For index As Integer = 0 To qNo.Length() - 1
                responseTextBox.Text = String.Concat(responseTextBox.Text, questionMatching.question(Question_TBLTableAdapter1, CInt(qNo(index))), vbNewLine)
            Next
            MsgBox("Select question from one of the list.")
        Else
            'responseTextBox.Text = questionMatching.retrieveAnswer(Question_TBLTableAdapter11, CInt(qNo(0)))
            responseTextBox.Text = Question_TBLTableAdapter1.SelectAnswer(CInt(qNo(0)))
        End If
    End Sub

    ' Function to compare answer of two methods and display the best possible answer
    Private Sub compareAns(ByVal quesNgramStr As String, ByVal quesPOSStr As String)
        ' Split the string object in tokens
        Dim qNgramArr() = Split(quesNgramStr, ",")
        Dim qPOSArr() = Split(quesPOSStr, ",")

        ' Check if qNo array has more than one question number
        If qNgramArr.Length() > qPOSArr.Length() And qPOSArr.Length() > 1 Then
            ' Print each question number in the textbox for user to choose from
            For index As Integer = 0 To qPOSArr.Length() - 1
                responseTextBox.Text = String.Concat(responseTextBox.Text, questionMatching.question(Question_TBLTableAdapter1, CInt(qPOSArr(index))), vbNewLine)
            Next
            MsgBox("Select question from one of the list.")
        ElseIf qNgramArr.Length() < qPOSArr.Length() And qNgramArr.Length() > 1 Then
            ' Print each question number in the textbox for user to choose from
            For index As Integer = 0 To qNgramArr.Length() - 1
                responseTextBox.Text = String.Concat(responseTextBox.Text, questionMatching.question(Question_TBLTableAdapter1, CInt(qNgramArr(index))), vbNewLine)
            Next
            MsgBox("Select question from one of the list.")
        ElseIf qNgramArr.Length() = qPOSArr.Length() And qNgramArr.Length() > 1 Then
            ' Print each question number in the textbox for user to choose from
            For index As Integer = 0 To qNgramArr.Length() - 1
                responseTextBox.Text = String.Concat(responseTextBox.Text, questionMatching.question(Question_TBLTableAdapter1, CInt(qNgramArr(index))), vbNewLine)
            Next
            MsgBox("Select question from one of the list.")
        ElseIf qPOSArr.Length() = 1 Then
            'responseTextBox.Text = questionMatching.retrieveAnswer(Sample_Repo_TBLTableAdapter1, CInt(qPOSArr(0)))
            responseTextBox.Text = Question_TBLTableAdapter1.SelectAnswer(CInt(qPOSArr(0)))
        Else
            'responseTextBox.Text = questionMatching.retrieveAnswer(Sample_Repo_TBLTableAdapter1, CInt(qNgramArr(0)))
            responseTextBox.Text = Question_TBLTableAdapter1.SelectAnswer(CInt(qNgramArr(0)))
        End If
    End Sub

    ' Display the resulting answer or the multiple questions on the screen
    Private Sub displayAnswer(ByVal quesNo As String)
        MsgBox("Questions No: " & quesNo)

        ' Split the string into tokens
        Dim quesNoArr() As String = Split(quesNo, ",")

        ' Check if qNo array has more than one question number
        If quesNoArr.Length() > 1 Then
            ' Print each question number in the textbox for user to choose from
            For index As Integer = 0 To quesNoArr.Length() - 1
                responseTextBox.Text = String.Concat(answerTextBox.Text, Question_TBLTableAdapter1.SelectQuestion(CInt(quesNoArr(index))), vbNewLine)
            Next
            MsgBox("Select question from one of the list.")
        Else
            responseTextBox.Text = Question_TBLTableAdapter1.SelectAnswer(CInt(quesNoArr(0)))
        End If
    End Sub

End Class
