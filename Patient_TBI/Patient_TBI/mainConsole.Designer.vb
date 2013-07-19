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
        Me.talkStartButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.homeButton = New System.Windows.Forms.Button()
        Me.responseTextBox = New System.Windows.Forms.TextBox()
        Me.queryButton = New System.Windows.Forms.Button()
        Me.queryText = New System.Windows.Forms.TextBox()
        Me.AxActiveHaptekX1 = New AxACTIVEHAPTEKXLib.AxActiveHaptekX()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.QIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuestionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnswerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuestionKeywordsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmotionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacialExpressionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuestionTBLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Patient_TBIDataSet1 = New Patient_TBI.Patient_TBIDataSet1()
        Me.Question_TBLTableAdapter1 = New Patient_TBI.Patient_TBIDataSet1TableAdapters.Question_TBLTableAdapter()
        Me.FollowUp_TBLTableAdapter1 = New Patient_TBI.Patient_TBIDataSet1TableAdapters.FollowUp_TBLTableAdapter()
        Me.FollowUpTBLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.SrNumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuestionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnswerDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuestionKeywordsDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmotionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacialExpressionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dataFile_Button = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.AxActiveHaptekX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuestionTBLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Patient_TBIDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FollowUpTBLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.AnswerRepoTextBox.Location = New System.Drawing.Point(11, 796)
        Me.AnswerRepoTextBox.Name = "AnswerRepoTextBox"
        Me.AnswerRepoTextBox.Size = New System.Drawing.Size(144, 20)
        Me.AnswerRepoTextBox.TabIndex = 8
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
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.QIDDataGridViewTextBoxColumn, Me.QuestionDataGridViewTextBoxColumn, Me.AnswerDataGridViewTextBoxColumn, Me.QuestionKeywordsDataGridViewTextBoxColumn, Me.EmotionDataGridViewTextBoxColumn, Me.FacialExpressionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.QuestionTBLBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(727, 21)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(441, 200)
        Me.DataGridView1.TabIndex = 1
        '
        'QIDDataGridViewTextBoxColumn
        '
        Me.QIDDataGridViewTextBoxColumn.DataPropertyName = "Q_ID"
        Me.QIDDataGridViewTextBoxColumn.HeaderText = "Q_ID"
        Me.QIDDataGridViewTextBoxColumn.Name = "QIDDataGridViewTextBoxColumn"
        '
        'QuestionDataGridViewTextBoxColumn
        '
        Me.QuestionDataGridViewTextBoxColumn.DataPropertyName = "Question"
        Me.QuestionDataGridViewTextBoxColumn.HeaderText = "Question"
        Me.QuestionDataGridViewTextBoxColumn.Name = "QuestionDataGridViewTextBoxColumn"
        '
        'AnswerDataGridViewTextBoxColumn
        '
        Me.AnswerDataGridViewTextBoxColumn.DataPropertyName = "Answer"
        Me.AnswerDataGridViewTextBoxColumn.HeaderText = "Answer"
        Me.AnswerDataGridViewTextBoxColumn.Name = "AnswerDataGridViewTextBoxColumn"
        '
        'QuestionKeywordsDataGridViewTextBoxColumn
        '
        Me.QuestionKeywordsDataGridViewTextBoxColumn.DataPropertyName = "Question_Keywords"
        Me.QuestionKeywordsDataGridViewTextBoxColumn.HeaderText = "Question_Keywords"
        Me.QuestionKeywordsDataGridViewTextBoxColumn.Name = "QuestionKeywordsDataGridViewTextBoxColumn"
        '
        'EmotionDataGridViewTextBoxColumn
        '
        Me.EmotionDataGridViewTextBoxColumn.DataPropertyName = "Emotion"
        Me.EmotionDataGridViewTextBoxColumn.HeaderText = "Emotion"
        Me.EmotionDataGridViewTextBoxColumn.Name = "EmotionDataGridViewTextBoxColumn"
        '
        'FacialExpressionDataGridViewTextBoxColumn
        '
        Me.FacialExpressionDataGridViewTextBoxColumn.DataPropertyName = "Facial_Expression"
        Me.FacialExpressionDataGridViewTextBoxColumn.HeaderText = "Facial_Expression"
        Me.FacialExpressionDataGridViewTextBoxColumn.Name = "FacialExpressionDataGridViewTextBoxColumn"
        '
        'QuestionTBLBindingSource
        '
        Me.QuestionTBLBindingSource.DataMember = "Question_TBL"
        Me.QuestionTBLBindingSource.DataSource = Me.Patient_TBIDataSet1
        '
        'Patient_TBIDataSet1
        '
        Me.Patient_TBIDataSet1.DataSetName = "Patient_TBIDataSet1"
        Me.Patient_TBIDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Question_TBLTableAdapter1
        '
        Me.Question_TBLTableAdapter1.ClearBeforeFill = True
        '
        'FollowUp_TBLTableAdapter1
        '
        Me.FollowUp_TBLTableAdapter1.ClearBeforeFill = True
        '
        'FollowUpTBLBindingSource
        '
        Me.FollowUpTBLBindingSource.DataMember = "FollowUp_TBL"
        Me.FollowUpTBLBindingSource.DataSource = Me.Patient_TBIDataSet1
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SrNumDataGridViewTextBoxColumn, Me.QIDDataGridViewTextBoxColumn1, Me.QuestionDataGridViewTextBoxColumn1, Me.AnswerDataGridViewTextBoxColumn1, Me.QuestionKeywordsDataGridViewTextBoxColumn1, Me.EmotionDataGridViewTextBoxColumn1, Me.FacialExpressionDataGridViewTextBoxColumn1})
        Me.DataGridView2.DataSource = Me.FollowUpTBLBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(727, 269)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(441, 246)
        Me.DataGridView2.TabIndex = 5
        '
        'SrNumDataGridViewTextBoxColumn
        '
        Me.SrNumDataGridViewTextBoxColumn.DataPropertyName = "Sr_Num"
        Me.SrNumDataGridViewTextBoxColumn.HeaderText = "Sr_Num"
        Me.SrNumDataGridViewTextBoxColumn.Name = "SrNumDataGridViewTextBoxColumn"
        Me.SrNumDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QIDDataGridViewTextBoxColumn1
        '
        Me.QIDDataGridViewTextBoxColumn1.DataPropertyName = "Q_ID"
        Me.QIDDataGridViewTextBoxColumn1.HeaderText = "Q_ID"
        Me.QIDDataGridViewTextBoxColumn1.Name = "QIDDataGridViewTextBoxColumn1"
        '
        'QuestionDataGridViewTextBoxColumn1
        '
        Me.QuestionDataGridViewTextBoxColumn1.DataPropertyName = "Question"
        Me.QuestionDataGridViewTextBoxColumn1.HeaderText = "Question"
        Me.QuestionDataGridViewTextBoxColumn1.Name = "QuestionDataGridViewTextBoxColumn1"
        '
        'AnswerDataGridViewTextBoxColumn1
        '
        Me.AnswerDataGridViewTextBoxColumn1.DataPropertyName = "Answer"
        Me.AnswerDataGridViewTextBoxColumn1.HeaderText = "Answer"
        Me.AnswerDataGridViewTextBoxColumn1.Name = "AnswerDataGridViewTextBoxColumn1"
        '
        'QuestionKeywordsDataGridViewTextBoxColumn1
        '
        Me.QuestionKeywordsDataGridViewTextBoxColumn1.DataPropertyName = "Question_Keywords"
        Me.QuestionKeywordsDataGridViewTextBoxColumn1.HeaderText = "Question_Keywords"
        Me.QuestionKeywordsDataGridViewTextBoxColumn1.Name = "QuestionKeywordsDataGridViewTextBoxColumn1"
        '
        'EmotionDataGridViewTextBoxColumn1
        '
        Me.EmotionDataGridViewTextBoxColumn1.DataPropertyName = "Emotion"
        Me.EmotionDataGridViewTextBoxColumn1.HeaderText = "Emotion"
        Me.EmotionDataGridViewTextBoxColumn1.Name = "EmotionDataGridViewTextBoxColumn1"
        '
        'FacialExpressionDataGridViewTextBoxColumn1
        '
        Me.FacialExpressionDataGridViewTextBoxColumn1.DataPropertyName = "Facial_Expression"
        Me.FacialExpressionDataGridViewTextBoxColumn1.HeaderText = "Facial_Expression"
        Me.FacialExpressionDataGridViewTextBoxColumn1.Name = "FacialExpressionDataGridViewTextBoxColumn1"
        '
        'dataFile_Button
        '
        Me.dataFile_Button.Location = New System.Drawing.Point(726, 551)
        Me.dataFile_Button.Name = "dataFile_Button"
        Me.dataFile_Button.Size = New System.Drawing.Size(130, 33)
        Me.dataFile_Button.TabIndex = 6
        Me.dataFile_Button.Text = "Create Data File"
        Me.dataFile_Button.UseVisualStyleBackColor = True
        '
        'mainConsole
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1197, 858)
        Me.ControlBox = False
        Me.Controls.Add(Me.dataFile_Button)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "mainConsole"
        Me.Text = "Virtual Standardized Patient (VSP)"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.AxActiveHaptekX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuestionTBLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Patient_TBIDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FollowUpTBLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents AnswerRepoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Question_TBLTableAdapter1 As Patient_TBI.Patient_TBIDataSet1TableAdapters.Question_TBLTableAdapter
    Friend WithEvents FollowUp_TBLTableAdapter1 As Patient_TBI.Patient_TBIDataSet1TableAdapters.FollowUp_TBLTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents QIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuestionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnswerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuestionKeywordsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmotionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FacialExpressionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuestionTBLBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Patient_TBIDataSet1 As Patient_TBI.Patient_TBIDataSet1
    Friend WithEvents FollowUpTBLBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents SrNumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QIDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuestionDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnswerDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuestionKeywordsDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmotionDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FacialExpressionDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dataFile_Button As System.Windows.Forms.Button

End Class
