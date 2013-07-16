<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainConsole
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainConsole))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AnswerRepoTextBox = New System.Windows.Forms.TextBox()
        Me.QuestionRepoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Patient_TBIDataSet = New Patient_TBI.Patient_TBIDataSet()
        Me.talkStartButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.homeButton = New System.Windows.Forms.Button()
        Me.responseTextBox = New System.Windows.Forms.TextBox()
        Me.queryButton = New System.Windows.Forms.Button()
        Me.queryText = New System.Windows.Forms.TextBox()
        Me.AxActiveHaptekX1 = New AxACTIVEHAPTEKXLib.AxActiveHaptekX()
        Me.QuestionRepoTableAdapter1 = New Patient_TBI.Patient_TBIDataSetTableAdapters.QuestionRepoTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.QuestionRepoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Patient_TBIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxActiveHaptekX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.AnswerRepoTextBox)
        Me.Panel1.Controls.Add(Me.talkStartButton)
        Me.Panel1.Controls.Add(Me.exitButton)
        Me.Panel1.Controls.Add(Me.homeButton)
        Me.Panel1.Controls.Add(Me.responseTextBox)
        Me.Panel1.Controls.Add(Me.queryButton)
        Me.Panel1.Controls.Add(Me.queryText)
        Me.Panel1.Controls.Add(Me.AxActiveHaptekX1)
        Me.Panel1.Location = New System.Drawing.Point(12, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(669, 829)
        Me.Panel1.TabIndex = 0
        '
        'AnswerRepoTextBox
        '
        Me.AnswerRepoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QuestionRepoBindingSource, "Answer", True))
        Me.AnswerRepoTextBox.Location = New System.Drawing.Point(11, 796)
        Me.AnswerRepoTextBox.Name = "AnswerRepoTextBox"
        Me.AnswerRepoTextBox.Size = New System.Drawing.Size(144, 20)
        Me.AnswerRepoTextBox.TabIndex = 8
        '
        'QuestionRepoBindingSource
        '
        Me.QuestionRepoBindingSource.DataMember = "QuestionRepo"
        Me.QuestionRepoBindingSource.DataSource = Me.Patient_TBIDataSet
        '
        'Patient_TBIDataSet
        '
        Me.Patient_TBIDataSet.DataSetName = "Patient_TBIDataSet"
        Me.Patient_TBIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'talkStartButton
        '
        Me.talkStartButton.BackColor = System.Drawing.Color.Transparent
        Me.talkStartButton.Location = New System.Drawing.Point(400, 784)
        Me.talkStartButton.Name = "talkStartButton"
        Me.talkStartButton.Size = New System.Drawing.Size(89, 25)
        Me.talkStartButton.TabIndex = 6
        Me.talkStartButton.Text = "Click to Talk"
        Me.talkStartButton.UseVisualStyleBackColor = False
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(602, 12)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(53, 25)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'homeButton
        '
        Me.homeButton.Location = New System.Drawing.Point(15, 12)
        Me.homeButton.Name = "homeButton"
        Me.homeButton.Size = New System.Drawing.Size(50, 25)
        Me.homeButton.TabIndex = 4
        Me.homeButton.Text = "Home"
        Me.homeButton.UseVisualStyleBackColor = True
        '
        'responseTextBox
        '
        Me.responseTextBox.BackColor = System.Drawing.Color.Silver
        Me.responseTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.responseTextBox.Location = New System.Drawing.Point(67, 592)
        Me.responseTextBox.Multiline = True
        Me.responseTextBox.Name = "responseTextBox"
        Me.responseTextBox.Size = New System.Drawing.Size(545, 89)
        Me.responseTextBox.TabIndex = 3
        Me.responseTextBox.Text = "Patient Response "
        '
        'queryButton
        '
        Me.queryButton.BackColor = System.Drawing.Color.Transparent
        Me.queryButton.Location = New System.Drawing.Point(188, 784)
        Me.queryButton.Name = "queryButton"
        Me.queryButton.Size = New System.Drawing.Size(92, 25)
        Me.queryButton.TabIndex = 2
        Me.queryButton.Text = "Query Send"
        Me.queryButton.UseVisualStyleBackColor = False
        '
        'queryText
        '
        Me.queryText.Location = New System.Drawing.Point(69, 703)
        Me.queryText.Multiline = True
        Me.queryText.Name = "queryText"
        Me.queryText.Size = New System.Drawing.Size(544, 65)
        Me.queryText.TabIndex = 1
        Me.queryText.Text = "Enter your text here"
        '
        'AxActiveHaptekX1
        '
        Me.AxActiveHaptekX1.Enabled = True
        Me.AxActiveHaptekX1.Location = New System.Drawing.Point(92, 43)
        Me.AxActiveHaptekX1.Name = "AxActiveHaptekX1"
        Me.AxActiveHaptekX1.OcxState = CType(resources.GetObject("AxActiveHaptekX1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxActiveHaptekX1.Size = New System.Drawing.Size(494, 510)
        Me.AxActiveHaptekX1.TabIndex = 0
        '
        'QuestionRepoTableAdapter1
        '
        Me.QuestionRepoTableAdapter1.ClearBeforeFill = True
        '
        'mainConsole
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(693, 850)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Name = "mainConsole"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.QuestionRepoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Patient_TBIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxActiveHaptekX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents AxActiveHaptekX1 As AxACTIVEHAPTEKXLib.AxActiveHaptekX
    Friend WithEvents queryButton As System.Windows.Forms.Button
    Friend WithEvents queryText As System.Windows.Forms.TextBox
    Friend WithEvents responseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents homeButton As System.Windows.Forms.Button
    Friend WithEvents talkStartButton As System.Windows.Forms.Button
    Friend WithEvents QuestionRepoTableAdapter1 As Patient_TBI.Patient_TBIDataSetTableAdapters.QuestionRepoTableAdapter
    Friend WithEvents AnswerRepoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QuestionRepoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Patient_TBIDataSet As Patient_TBI.Patient_TBIDataSet

End Class
