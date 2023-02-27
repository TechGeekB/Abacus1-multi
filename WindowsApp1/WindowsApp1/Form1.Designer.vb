<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.startBtn = New System.Windows.Forms.Button()
        Me.AdditionRadio = New System.Windows.Forms.RadioButton()
        Me.SubtractionRadio = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.multiRadio = New System.Windows.Forms.RadioButton()
        Me.operatorLabel = New System.Windows.Forms.Label()
        Me.operand1Txt = New System.Windows.Forms.TextBox()
        Me.operand2Txt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.resultTxt = New System.Windows.Forms.TextBox()
        Me.nextBtn = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.secondTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.timeTakenTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AccuracyTxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.timePerQuestionTxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.questionsAttendedTxt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.questionNumberTxt = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.resetBtn = New System.Windows.Forms.Button()
        Me.divisionRadio = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'startBtn
        '
        Me.startBtn.Location = New System.Drawing.Point(55, 499)
        Me.startBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.startBtn.Name = "startBtn"
        Me.startBtn.Size = New System.Drawing.Size(127, 112)
        Me.startBtn.TabIndex = 0
        Me.startBtn.Text = "Start"
        Me.startBtn.UseVisualStyleBackColor = True
        '
        'AdditionRadio
        '
        Me.AdditionRadio.AutoSize = True
        Me.AdditionRadio.Checked = True
        Me.AdditionRadio.Location = New System.Drawing.Point(45, 38)
        Me.AdditionRadio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AdditionRadio.Name = "AdditionRadio"
        Me.AdditionRadio.Size = New System.Drawing.Size(52, 33)
        Me.AdditionRadio.TabIndex = 1
        Me.AdditionRadio.TabStop = True
        Me.AdditionRadio.Text = "+"
        Me.AdditionRadio.UseVisualStyleBackColor = True
        '
        'SubtractionRadio
        '
        Me.SubtractionRadio.AutoSize = True
        Me.SubtractionRadio.Location = New System.Drawing.Point(115, 38)
        Me.SubtractionRadio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SubtractionRadio.Name = "SubtractionRadio"
        Me.SubtractionRadio.Size = New System.Drawing.Size(46, 33)
        Me.SubtractionRadio.TabIndex = 2
        Me.SubtractionRadio.Text = "-"
        Me.SubtractionRadio.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.divisionRadio)
        Me.GroupBox1.Controls.Add(Me.multiRadio)
        Me.GroupBox1.Controls.Add(Me.SubtractionRadio)
        Me.GroupBox1.Controls.Add(Me.AdditionRadio)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.89565!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(55, 22)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(362, 88)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "What you want to practice?"
        '
        'multiRadio
        '
        Me.multiRadio.AutoSize = True
        Me.multiRadio.Location = New System.Drawing.Point(185, 38)
        Me.multiRadio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.multiRadio.Name = "multiRadio"
        Me.multiRadio.Size = New System.Drawing.Size(48, 33)
        Me.multiRadio.TabIndex = 3
        Me.multiRadio.Text = "*"
        Me.multiRadio.UseVisualStyleBackColor = True
        '
        'operatorLabel
        '
        Me.operatorLabel.AutoSize = True
        Me.operatorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.17391!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.operatorLabel.Location = New System.Drawing.Point(188, 201)
        Me.operatorLabel.Name = "operatorLabel"
        Me.operatorLabel.Size = New System.Drawing.Size(62, 65)
        Me.operatorLabel.TabIndex = 4
        Me.operatorLabel.Text = "+"
        '
        'operand1Txt
        '
        Me.operand1Txt.Enabled = False
        Me.operand1Txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.operand1Txt.Location = New System.Drawing.Point(31, 201)
        Me.operand1Txt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.operand1Txt.MinimumSize = New System.Drawing.Size(112, 75)
        Me.operand1Txt.Name = "operand1Txt"
        Me.operand1Txt.Size = New System.Drawing.Size(151, 75)
        Me.operand1Txt.TabIndex = 5
        '
        'operand2Txt
        '
        Me.operand2Txt.Enabled = False
        Me.operand2Txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.operand2Txt.Location = New System.Drawing.Point(255, 201)
        Me.operand2Txt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.operand2Txt.MinimumSize = New System.Drawing.Size(112, 75)
        Me.operand2Txt.Name = "operand2Txt"
        Me.operand2Txt.Size = New System.Drawing.Size(162, 75)
        Me.operand2Txt.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 299)
        Me.Label1.MinimumSize = New System.Drawing.Size(225, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(384, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "---------------------------------------------------------------------------"
        '
        'resultTxt
        '
        Me.resultTxt.Enabled = False
        Me.resultTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.31305!)
        Me.resultTxt.Location = New System.Drawing.Point(142, 325)
        Me.resultTxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.resultTxt.MinimumSize = New System.Drawing.Size(112, 70)
        Me.resultTxt.Name = "resultTxt"
        Me.resultTxt.Size = New System.Drawing.Size(162, 90)
        Me.resultTxt.TabIndex = 10
        '
        'nextBtn
        '
        Me.nextBtn.Location = New System.Drawing.Point(256, 499)
        Me.nextBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.nextBtn.Name = "nextBtn"
        Me.nextBtn.Size = New System.Drawing.Size(129, 112)
        Me.nextBtn.TabIndex = 11
        Me.nextBtn.Text = "Next"
        Me.nextBtn.UseVisualStyleBackColor = True
        Me.nextBtn.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.01739!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(624, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 25)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Time (seconds)"
        '
        'secondTxt
        '
        Me.secondTxt.Enabled = False
        Me.secondTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.31305!)
        Me.secondTxt.ForeColor = System.Drawing.Color.Blue
        Me.secondTxt.Location = New System.Drawing.Point(810, 15)
        Me.secondTxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.secondTxt.Name = "secondTxt"
        Me.secondTxt.Size = New System.Drawing.Size(202, 90)
        Me.secondTxt.TabIndex = 13
        Me.secondTxt.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 420)
        Me.Label2.MinimumSize = New System.Drawing.Size(225, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(384, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "---------------------------------------------------------------------------"
        '
        'timeTakenTxt
        '
        Me.timeTakenTxt.Enabled = False
        Me.timeTakenTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.139131!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeTakenTxt.Location = New System.Drawing.Point(250, 84)
        Me.timeTakenTxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.timeTakenTxt.Name = "timeTakenTxt"
        Me.timeTakenTxt.Size = New System.Drawing.Size(115, 26)
        Me.timeTakenTxt.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 20)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Time Taken (seconds)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 20)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Accuracy (%)"
        '
        'AccuracyTxt
        '
        Me.AccuracyTxt.Enabled = False
        Me.AccuracyTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.139131!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccuracyTxt.Location = New System.Drawing.Point(250, 172)
        Me.AccuracyTxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AccuracyTxt.Name = "AccuracyTxt"
        Me.AccuracyTxt.Size = New System.Drawing.Size(115, 26)
        Me.AccuracyTxt.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 20)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Questions Attended"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.timePerQuestionTxt)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.questionsAttendedTxt)
        Me.GroupBox2.Controls.Add(Me.AccuracyTxt)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.timeTakenTxt)
        Me.GroupBox2.Location = New System.Drawing.Point(631, 140)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(381, 220)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Performance"
        '
        'timePerQuestionTxt
        '
        Me.timePerQuestionTxt.Enabled = False
        Me.timePerQuestionTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.139131!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timePerQuestionTxt.Location = New System.Drawing.Point(250, 125)
        Me.timePerQuestionTxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.timePerQuestionTxt.Name = "timePerQuestionTxt"
        Me.timePerQuestionTxt.Size = New System.Drawing.Size(115, 26)
        Me.timePerQuestionTxt.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(220, 20)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Avg.Time(seconds) / Question"
        '
        'questionsAttendedTxt
        '
        Me.questionsAttendedTxt.Enabled = False
        Me.questionsAttendedTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.139131!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.questionsAttendedTxt.Location = New System.Drawing.Point(250, 42)
        Me.questionsAttendedTxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.questionsAttendedTxt.Name = "questionsAttendedTxt"
        Me.questionsAttendedTxt.Size = New System.Drawing.Size(115, 26)
        Me.questionsAttendedTxt.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 166)
        Me.Label8.MinimumSize = New System.Drawing.Size(19, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 21)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Q."
        '
        'questionNumberTxt
        '
        Me.questionNumberTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.questionNumberTxt.Enabled = False
        Me.questionNumberTxt.Location = New System.Drawing.Point(48, 169)
        Me.questionNumberTxt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.questionNumberTxt.Name = "questionNumberTxt"
        Me.questionNumberTxt.Size = New System.Drawing.Size(54, 19)
        Me.questionNumberTxt.TabIndex = 22
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(648, 499)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(375, 135)
        Me.TextBox1.TabIndex = 23
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'resetBtn
        '
        Me.resetBtn.Enabled = False
        Me.resetBtn.Location = New System.Drawing.Point(631, 361)
        Me.resetBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.resetBtn.Name = "resetBtn"
        Me.resetBtn.Size = New System.Drawing.Size(84, 29)
        Me.resetBtn.TabIndex = 24
        Me.resetBtn.Text = "Reset"
        Me.resetBtn.UseVisualStyleBackColor = True
        '
        'divisionRadio
        '
        Me.divisionRadio.AutoSize = True
        Me.divisionRadio.Location = New System.Drawing.Point(257, 38)
        Me.divisionRadio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.divisionRadio.Name = "divisionRadio"
        Me.divisionRadio.Size = New System.Drawing.Size(45, 33)
        Me.divisionRadio.TabIndex = 4
        Me.divisionRadio.Text = "/"
        Me.divisionRadio.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1026, 642)
        Me.Controls.Add(Me.resetBtn)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.questionNumberTxt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.secondTxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nextBtn)
        Me.Controls.Add(Me.resultTxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.operand2Txt)
        Me.Controls.Add(Me.operand1Txt)
        Me.Controls.Add(Me.operatorLabel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.startBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Abacus Practice"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents startBtn As Button
    Friend WithEvents AdditionRadio As RadioButton
    Friend WithEvents SubtractionRadio As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents operatorLabel As Label
    Friend WithEvents operand1Txt As TextBox
    Friend WithEvents operand2Txt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents resultTxt As TextBox
    Friend WithEvents nextBtn As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents secondTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents timeTakenTxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents AccuracyTxt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents timePerQuestionTxt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents questionsAttendedTxt As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents questionNumberTxt As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents resetBtn As Button
    Friend WithEvents multiRadio As RadioButton
    Friend WithEvents divisionRadio As RadioButton
End Class
