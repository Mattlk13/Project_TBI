'Agent: Module to define patient's behavior and action. All haptek commands are in this module
'Date: 14th June 2013
'Author: Raghavi Sakpal

Module Agent

    'Random moods the agents go through
    Public moods() As String = {"Hap_Angry.hap", "Hap_Broken_Hearted.hap", "Hap_Bully.hap", "Hap_Calm.hap", "Hap_Mellow.hap",
                                "Hap_Neutral.hap", "Hap_Pondering_Mysteries.hap", "Hap_Sad.hap", "Hap_Shy.hap", "Hap_Skeptic.hap"}

    'Random animation/gestures the agents go through

    'Angry, Bully
    Public aggression() As String = {"grr", "shake_fist", "hands_on_hips", "pound_fist", "arms_crossed"}
    Public aggressionState() As String = {"a", "a", "start", "a", "start"}

    'Broken Hearted, Sad
    Public sadness() As String = {"hand_thru_hair", "shrug_sad", "arms_cross_sad", "hide_face_sad", "big_sigh_sad", "weep_sad", "wipe_tear"}
    Public sadnessState() As String = {"a1", "start", "start", "start", "start", "start", "start"}

    'Shy
    Public shy() As String = {"hand_thru_hair"}
    Public shyState() As String = {"a1"}

    'Calm, Mellow, Neutral
    Public neutral() = {"yawn", "hands_on_hips", "inspect_nails"}
    Public neutralState() = {"a", "start", "start"}

    'Pondering Mysteries, Skeptic
    Public skeptic() = {"smirkish", "hands_on_hips", "hand_thru_hair", "arms_crossed", "inspect_nail"}
    Public skepticState() = {"a", "start", "a1", "start", "start"}

    'Gestures when listening
    Public listeningGest() As String = {"headWander", "talkBob", "noddy", "smirkish", "headnod", "headshake", "headshakeLong", "yackLean",
                                       "hand_thru_hair", "arms_crossed", "considering"}
    Public listeningGestState() As String = {"whenTalking", "on", "a", "a", "nodDown", "lookleft", "lookleft", "leanFor",
                                             "a1", "start", "start"}

    'Gestures when talking
    Public talkingGest() As String = {"talkGestL1", "talkGestL2", "talkGestL3", "talkGestR1", "talkGestR2", "GestureMaster", "talkGestR3"}
    Public talkingGestState() As String = {"start", "start", "start", "start", "start", "start", "start"}

    'Look switches for idle behavior
    Public lookSwitches() As String = {"lookright", "lookleft", "lookup", "lookdown"}
    Public lookSwitchesState() As String = {"a", "a", "a", "a"}

    ' Date: 06/14/2013 
    ' Function: To load patients
    Public Sub agentLoad(ByVal haptexX As AxACTIVEHAPTEKXLib.AxActiveHaptekX, ByVal patientName As String)
        If patientName = "patient1" Then
            haptexX.HyperText = "\load [file=[C:\Documents and Settings\rsakpal.UNCCHARLOTTE-NT\Desktop\Project_TBI\Haptar\TBI_Patient1.haptar]]"
        Else
            haptexX.HyperText = "\load [file=[C:\Documents and Settings\rsakpal.UNCCHARLOTTE-NT\Desktop\Project_TBI\Haptar\kevin.haptar]]"
        End If
    End Sub

    ' Date: 07/15/2013
    ' Function: To load background image in haptek player
    Public Sub loadBkgrnd(ByVal haptek As AxACTIVEHAPTEKXLib.AxActiveHaptekX)
        haptek.HyperText = "\LoadBackGrnd [file= [C:\Documents and Settings\rsakpal.UNCCHARLOTTE-NT\Desktop\Project_TBI\Images\Doctors_Office_4.jpg]]"
    End Sub

    ' Date: 07/17/2013
    ' Function: To translate the agent within the screen
    Public Sub translateAgent(ByVal haptek As AxACTIVEHAPTEKXLib.AxActiveHaptekX, ByVal x As Double, ByVal y As Double, ByVal z As Double)
        haptek.HyperText = "\translate [x=" & x & " y=" & y & " z=" & z & "]"
    End Sub

    'Date: 06/13/2013
    'Function: Agent query to start text-to-speech
    Public Sub agentTalk(ByVal haptexX As AxACTIVEHAPTEKXLib.AxActiveHaptekX, ByVal msgString As String)
        haptexX.HyperText = "\q2[s0=[" & msgString & "]]"
    End Sub

    ' Date: 06/12/2013
    ' Function: Animate agents to perform radom moods at random time intervals
    Function randomAgentMood(ByVal haptexX As AxACTIVEHAPTEKXLib.AxActiveHaptekX, ByVal randomValue As Integer)

        Dim randomMood As String = moods(randomValue) & "]]"
        haptexX.HyperText = "\load [file= [C:\Documents and Settings\rsakpal.UNCCHARLOTTE-NT\Desktop\FCL_Demo_Project\Moods\" & randomMood

        Return moods(randomValue)
    End Function

    ' Date: 06/20/2013
    ' Function: Animate agents to perform random animation/gestures based on the mood passed by the mainConsole form
    Public Sub randomAgentGestures(ByVal haptexX As AxACTIVEHAPTEKXLib.AxActiveHaptekX, ByVal moodSelected As String)

        If moodSelected = "Hap_Angry.hap" Or moodSelected = "Hap_Bully.hap" Then
            'Angry, Bully
            MsgBox(moodSelected)
            Dim randomGest As Integer = CInt(Int(aggression.Length() * Rnd()))
            haptexX.HyperText = "\setswitch [switch=" & aggression(randomGest) & " state=" & aggressionState(randomGest) & "]"
        ElseIf moodSelected = "Hap_Broken_Hearted.hap" Or moodSelected = "Hap_Sad.hap" Then
            'Sad, Broken Hearted
            MsgBox(moodSelected)
            Dim randomGest As Integer = CInt(Int(sadness.Length() * Rnd()))
            haptexX.HyperText = "\setswitch [switch=" & sadness(randomGest) & " state=" & sadnessState(randomGest) & "]"
        ElseIf moodSelected = "Hap_Shy.hap" Then
            'Shy
            MsgBox(moodSelected)
            Dim randomGest As Integer = CInt(Int(shy.Length() * Rnd()))
            haptexX.HyperText = "\setswitch [switch=" & shy(randomGest) & " state=" & shyState(randomGest) & "]"
        ElseIf moodSelected = "Hap_Calm.hap" Or moodSelected = "Hap_Mellow.hap" Or moodSelected = "Hap_Neutral.hap" Then
            'Calm, Mellow, Neutral
            MsgBox(moodSelected)
            Dim randomGest As Integer = CInt(Int(neutral.Length() * Rnd()))
            haptexX.HyperText = "\setswitch [switch=" & neutral(randomGest) & " state=" & neutralState(randomGest) & "]"
        ElseIf moodSelected = "Hap_Pondering_Mysteries.hap" Or moodSelected = "Hap_Skeptic.hap" Then
            'Skeptic, Pondering Mysteries
            MsgBox(moodSelected)
            Dim randomGest As Integer = CInt(Int(skeptic.Length() * Rnd()))
            haptexX.HyperText = "\setswitch [switch=" & skeptic(randomGest) & " state=" & skepticState(randomGest) & "]"
        End If

    End Sub

    ' Date: 06/20/2013
    ' Function: Animate agents to perform random gestures when they are listening
    Public Sub randomAgentListening(ByVal haptexX As AxACTIVEHAPTEKXLib.AxActiveHaptekX)

        Dim randomListeningGest As Integer = CInt(Int(listeningGest.Length() * Rnd()))
        haptexX.HyperText = "\setswitch [switch=" & listeningGest(randomListeningGest) & " state=" & listeningGestState(randomListeningGest) & "]"
    End Sub

    ' Date: 06/20/2013
    ' Function: Animate agents to perform random gestures when they are talking
    Public Sub randomAgentTalking(ByVal haptexX As AxACTIVEHAPTEKXLib.AxActiveHaptekX)

        Dim randomTalkingGest As Integer = CInt(Int(talkingGest.Length() * Rnd()))
        haptexX.HyperText = "\setswitch [switch=" & talkingGest(randomTalkingGest) & " state=" & talkingGestState(randomTalkingGest) & "]"
    End Sub

    ' Date: 06/20/2013
    ' Function: Animate agents to perform random gestures for looking
    Public Sub randomAgentLook(ByVal haptexX As AxACTIVEHAPTEKXLib.AxActiveHaptekX)

        Dim randomLookingGest As Integer = CInt(Int(lookSwitches.Length() * Rnd()))
        haptexX.HyperText = "\setswitch [switch=" & lookSwitches(randomLookingGest) & " state=" & lookSwitchesState(randomLookingGest) & "]"
    End Sub

End Module
