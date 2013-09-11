<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class speechExample
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.QuestionRepoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Patient_TBIDataSet = New Patient_TBI.Patient_TBIDataSet()
        'Me.QuestionRepoTableAdapter = New Patient_TBI.Patient_TBIDataSetTableAdapters.QuestionRepoTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.QuestionRepoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Patient_TBIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(83, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID:"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QuestionRepoBindingSource, "Q_ID", True))
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.QuestionRepoBindingSource, "Q_ID", True))
        Me.TextBox1.Location = New System.Drawing.Point(167, 116)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(217, 20)
        Me.TextBox1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(182, 367)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 38)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QuestionRepoBindingSource, "Question", True))
        Me.TextBox2.Location = New System.Drawing.Point(167, 168)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(217, 20)
        Me.TextBox2.TabIndex = 9
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
        'QuestionRepoTableAdapter
        '
        'Me.QuestionRepoTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Question:"
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QuestionRepoBindingSource, "Answer", True))
        Me.TextBox3.Location = New System.Drawing.Point(168, 222)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(215, 20)
        Me.TextBox3.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Answer:"
        '
        'speechExample
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 455)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "speechExample"
        Me.Text = "speechExample"
        CType(Me.QuestionRepoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Patient_TBIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Patient_TBIDataSet As Patient_TBI.Patient_TBIDataSet
    Friend WithEvents QuestionRepoBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents QuestionRepoTableAdapter As Patient_TBI.Patient_TBIDataSetTableAdapters.QuestionRepoTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
