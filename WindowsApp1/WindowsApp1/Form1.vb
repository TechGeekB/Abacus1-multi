Public Class Form1
    'Store current state in these variable
    Dim questionNumber As Integer = 0
    Dim operandChecked
    Structure Question
        Dim Operand1 As Integer
        Dim Operand2 As Integer
        Dim resultProvided As String
        Dim isCorrect As Boolean
    End Structure
    Dim questionList As ArrayList = New ArrayList()


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
    End Sub


    Private Sub AdditionRadio_CheckedChanged(sender As Object, e As EventArgs) Handles AdditionRadio.CheckedChanged
        'MsgBox("clicked data: " + AdditionRadio.Text)
        operatorLabel.Text = AdditionRadio.Text
        operandChecked = AdditionRadio.Text
        'MsgBox("after setting operandChecked: " + operandChecked)
    End Sub

    Private Sub SubtractionRadio_CheckedChanged(sender As Object, e As EventArgs) Handles SubtractionRadio.CheckedChanged
        operatorLabel.Text = SubtractionRadio.Text
        operandChecked = SubtractionRadio.Text
    End Sub




    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        secondTxt.Text = secondTxt.Text + 1

    End Sub

    Private Sub startBtn_Click(sender As Object, e As EventArgs) Handles startBtn.Click


        If StrComp(startBtn.Text, "Start", vbTextCompare) = 0 Then
            ' MsgBox("Start clicked")
            secondTxt.Text = 0
            startBtn.Text = "Stop"
            Timer1.Enabled = True

            'Disable radio buttons
            enableDisableRadioButtons(False)
            resetPerformancePanel() 'reset performance panel

            resultTxt.Enabled = True 'Enable type in text box


            operand1Txt.Text = ""
            operand2Txt.Text = ""
            resultTxt.Text = ""

            nextBtn.Visible = True
            resetBtn.Enabled = False

            'If (AdditionRadio.Checked) Then

            displayQuestion()



            'ElseIf (SubtractionRadio.Checked) Then
            'End If



        ElseIf StrComp(startBtn.Text, "Stop", vbTextCompare) = 0 Then
            'MsgBox("Stop clicked")
            startBtn.Text = "Start"
            Timer1.Enabled = False
            'Disable radio buttons
            enableDisableRadioButtons(True)
            operand1Txt.Text = ""
            operand2Txt.Text = ""
            resultTxt.Text = ""
            resultTxt.Enabled = False
            'MsgBox(questionList)
            displayPerformanceData()
            resetPublicState()
            questionNumberTxt.Text = ""
            nextBtn.Visible = False
        End If
        resultTxt.Focus()

        '
        '
        'secondTxt.Text = 0
        'startBtn.Text = "Stop"


        ' Timer1.Start()

    End Sub

    Sub displayPerformanceData()
        'MsgBox(questionList.Count)
        questionsAttendedTxt.Text = questionList.Count
        timeTakenTxt.Text = secondTxt.Text
        timePerQuestionTxt.Text = (secondTxt.Text / questionList.Count).ToString("F2")
        Dim correctQuestions As Integer = 0
        For Each item As Question In questionList
            If item.isCorrect Then
                correctQuestions += 1
            End If
        Next
        AccuracyTxt.Text = ((correctQuestions * 100) / questionList.Count).ToString("F2")

        resetBtn.Enabled = True
    End Sub

    Sub enableDisableRadioButtons(ByVal truefalse As Boolean)
        AdditionRadio.Enabled = truefalse
        SubtractionRadio.Enabled = truefalse
        multiRadio.Enabled = truefalse
    End Sub

    Private Sub nextBtn_Click(sender As Object, e As EventArgs) Handles nextBtn.Click
        If StrComp(startBtn.Text, "Start", vbTextCompare) = 0 Then 'if Start button is "start" then no effect of pression this button
            Return
        End If
        'Evaluate the result and store it, then display next question
        saveCurrentQuestionState()
        displayQuestion()
        resultTxt.Focus()
    End Sub

    Public Function getRandomNumber(ByVal lowerBound As Integer, ByVal upperBound As Integer) As Integer
        Dim randomValue As Integer
        randomValue = CInt(Math.Floor((upperBound - lowerBound + 1) * Rnd())) + lowerBound
        Return randomValue
    End Function


    Private Sub resultTxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles resultTxt.KeyPress
        'check if Enter is pressed here
        If e.KeyChar = Convert.ToChar(13) Then
            saveCurrentQuestionState()
            displayQuestion()
        ElseIf Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Sub displayQuestion()

        Dim operand1 As Integer
        Dim operand2 As Integer

        ' + -> no restrictions
        ' - -> 2nd operand should be less than 1st operand
        ' * -> no restrictions except 3*2 or 2*2 or 4*1 for now
        'MsgBox("Before checking for *: " + operandChecked)
        If StrComp(operandChecked, "/", vbTextCompare) = 0 Then
            operand1 = getRandomNumber(1000, 9999)
            operand2 = getRandomNumber(10, 99)

        ElseIf StrComp(operandChecked, "*", vbTextCompare) = 0 Then
            'if multiply then generate 2*2 and 2*3 for now
            operand2 = getRandomNumber(10, 99)
            operand1 = getRandomNumber(10, 999)

        Else
            operand1 = getRandomNumber(11111, 99999)
            While True
                operand2 = getRandomNumber(11111, 99999)
                If operand2 < operand1 Then
                    Exit While
                End If
            End While

        End If
        'MsgBox("After checking for *: " + operandChecked)


        operand1Txt.Text = operand1.ToString
        operand2Txt.Text = operand2.ToString
        resultTxt.Text = "" 'clear the previous answer
        questionNumber += 1 'increment current question number 
        questionNumberTxt.Text = questionNumber

    End Sub

    Sub saveCurrentQuestionState()
        'MsgBox("OperandChecked: " + operandChecked)
        Dim currentQuestion As Question
        currentQuestion.Operand1 = operand1Txt.Text
        currentQuestion.Operand2 = operand2Txt.Text
        currentQuestion.resultProvided = resultTxt.Text

        'Dim expression As String = operand1Txt.Text + operandChecked + operand2Txt.Text
        Dim expression As String = operand1Txt.Text + operatorLabel.Text + operand2Txt.Text
        'MsgBox("expression getting evaluated:" + expression)
        'MsgBox((New DataTable().Compute(expression, Nothing)))
        Dim evaluatedResult As Double = New DataTable().Compute(expression, Nothing)
        'MsgBox("evaluated result:" + evaluatedResult)
        Dim resultFromInput As Double = If((Int32.TryParse(resultTxt.Text, 0) = True), resultTxt.Text, "0")
        currentQuestion.isCorrect = evaluatedResult = resultFromInput
        'MsgBox("iscorrect: " + currentQuestion.isCorrect)
        'MsgBox(Convert.ToInt32(Convert.ToDecimal(resultTxt.Text)))
        'MsgBox(evaluatedResult == resultTxt.Text)
        'MsgBox(Convert.ToInt32(resultTxt.Text))
        'MsgBox(Int32.TryParse(resultTxt.Text, 0))
        'MsgBox(New DataTable().Compute(expression, Nothing))
        'MsgBox(New DataTable().Compute(operand1Txt.Text, Nothing))
        questionList.Add(currentQuestion)
    End Sub

    Sub resetPublicState()
        questionNumber = 0
        questionList.Clear()

    End Sub

    Sub resetPerformancePanel()
        secondTxt.Text = 0 'reset timer to ZERO
        questionsAttendedTxt.Text = ""
        timeTakenTxt.Text = ""
        timePerQuestionTxt.Text = ""
        AccuracyTxt.Text = ""

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub resetBtn_Click(sender As Object, e As EventArgs) Handles resetBtn.Click
        resetPerformancePanel()
    End Sub

    Private Sub multiRadio_CheckedChanged(sender As Object, e As EventArgs) Handles multiRadio.CheckedChanged
        operatorLabel.Text = multiRadio.Text
        operandChecked = multiRadio.Text
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub operatorLabel_Click(sender As Object, e As EventArgs) Handles operatorLabel.Click

    End Sub

    Private Sub operand1Txt_TextChanged(sender As Object, e As EventArgs) Handles operand1Txt.TextChanged

    End Sub

    Private Sub divisionRadio_CheckedChanged(sender As Object, e As EventArgs) Handles divisionRadio.CheckedChanged
        operatorLabel.Text = divisionRadio.Text
        operandChecked = divisionRadio.Text
    End Sub
End Class
