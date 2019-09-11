Public Class GradeCalculator
    Private CalcGrade As New CalculateGrade
    Public NewWeightTextBox As Int32 = 9
    Public LastWeightTextBox As Int32 = 8
    Public NewPointsTextBox As Int32 = 9
    Public LastPointsTextBox As Int32 = 8
    Public NewAvgTextBox As Int32 = 9
    Public LastAvgTextBox As Int32 = 8
    Private CustFormColor As Color
    Private Sub GradeCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnCalculate.Enabled = False
        btnPointCalculate.Enabled = False
        btnAvgCalculate.Enabled = False

        btnReset.Enabled = False
        btnPointReset.Enabled = False
        btnAvgReset.Enabled = False
        btnAvgReset.Enabled = False
        btnAvgReset.Enabled = False
        btnAvgReset.Enabled = False

        'For Each ctrl In WeightPanel.Controls
        '    If TypeOf ctrl Is TextBox Then
        '        If ctrl.Name = "txtGrade1" Or ctrl.Name = "txtWeight1" Then
        '            Continue For
        '        Else
        '            ctrl.Enabled = False
        '        End If
        '    End If
        'Next
        'For Each ctrl In PointsPanel.Controls
        '    If TypeOf ctrl Is TextBox Then
        '        If ctrl.Name = "txtTotalPoints1" Or ctrl.Name = "txtEarnedPoints1" Then
        '            Continue For
        '        Else
        '            ctrl.Enabled = False
        '        End If
        '    End If
        'Next
        'For Each ctrl In AvgPanel.Controls
        '    If TypeOf ctrl Is TextBox Then
        '        If ctrl.Name = "txtAvgGrade1" Then
        '            Continue For
        '        Else
        '            ctrl.Enabled = False
        '        End If
        '    End If
        'Next

        'CalcGrade.CtrlHasChildren(Me)

        Me.ForeColor = My.Settings.FormColor
        If My.Settings.FormName <> "" Then
            Me.Text = My.Settings.FormName
        End If
    End Sub

    Public Sub PercentCalc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGrade1.KeyPress, txtGrade2.KeyPress,
                                                                                       txtGrade3.KeyPress, txtGrade4.KeyPress,
                                                                                       txtGrade5.KeyPress, txtGrade6.KeyPress,
                                                                                       txtGrade7.KeyPress, txtGrade8.KeyPress,
                                                                                       txtWeight1.KeyPress, txtWeight2.KeyPress,
                                                                                       txtWeight3.KeyPress, txtWeight4.KeyPress,
                                                                                       txtWeight5.KeyPress, txtWeight6.KeyPress,
                                                                                       txtWeight7.KeyPress, txtWeight8.KeyPress
        Dim GradeTextBox As TextBox = CType(sender, TextBox)

        ' Handled = False means the event will not handle the character and the character will continue to the OS to be processed.
        ' Handled = True means the event will handle the character and the character will not be sent to the OS for processing.
        ' ASCII 46 is . (Dot)
        ' ASCII 8 is Backspace
        If Asc(e.KeyChar) <> "32" AndAlso ((sender.Text.IndexOf(".") < 0 AndAlso Asc(e.KeyChar) = "46") Or Char.IsNumber(e.KeyChar.ToString) Or Asc(e.KeyChar) = "8") Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub txtGrade1_TextChange(sender As Object, e As EventArgs) Handles txtGrade1.TextChanged, txtGrade2.TextChanged,
                                                                               txtGrade3.TextChanged, txtGrade4.TextChanged,
                                                                               txtGrade5.TextChanged, txtGrade6.TextChanged,
                                                                               txtGrade7.TextChanged, txtGrade8.TextChanged,
                                                                               txtWeight1.TextChanged, txtWeight2.TextChanged,
                                                                               txtWeight3.TextChanged, txtWeight4.TextChanged,
                                                                               txtWeight5.TextChanged, txtWeight6.TextChanged,
                                                                               txtWeight7.TextChanged, txtWeight8.TextChanged
        Dim gradeTxt As TextBox = CType(sender, TextBox)

        Try
            If gradeTxt.Text.Trim.Length > 0 Then
                If gradeTxt.Text > 100 Then
                    MessageBox.Show("Grade can't be greater than 100%", "Invalid Grade", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    gradeTxt.Focus()
                    gradeTxt.Clear()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim strGrade, strWeight, lblRow As String
        Dim lblGrade, lblLetter As Label
        Dim CalcButton, ResetButton As Button
        Dim panelMode As Panel

        strGrade = "txtGrade"
        strWeight = "txtWeight"
        lblRow = "lblRow"
        lblGrade = lblDisplayGrade
        lblLetter = lblLetterGrade
        CalcButton = btnCalculate
        ResetButton = btnReset
        panelMode = WeightPanel

        CalcGrade.Reset_TextBox(strGrade, strWeight, lblRow, lblGrade, lblLetter, CalcButton, ResetButton, WeightPanel, NewWeightTextBox, LastWeightTextBox)
    End Sub

    Private Sub btnPointReset_Click(sender As Object, e As EventArgs) Handles btnPointReset.Click
        Dim strPoints, strTotalPoints, lblRow As String
        Dim lblGrade, lblLetter As Label
        Dim CalcButton, ResetButton As Button
        Dim panelMode As Panel

        strPoints = "txtEarnedPoints"
        strTotalPoints = "txtTotalPoints"
        lblRow = "lblPointsRow"
        lblGrade = lblDisplayPointGrade
        lblLetter = lblDisplayPointLetterGrade
        CalcButton = btnPointCalculate
        ResetButton = btnPointReset
        panelMode = PointsPanel

        CalcGrade.Reset_TextBox(strPoints, strTotalPoints, lblRow, lblGrade, lblLetter, CalcButton, ResetButton, panelMode, NewPointsTextBox, LastPointsTextBox)
    End Sub

    Private Sub btnAvgReset_Click(sender As Object, e As EventArgs) Handles btnAvgReset.Click
        Dim strAvgGrade, strNothing, lblRow As String
        Dim lblGrade, lblLetter As Label
        Dim CalcButton, ResetButton As Button
        Dim panelMode As Panel

        strAvgGrade = "txtAvgGrade"
        strNothing = ""
        lblRow = "lblAvgRow"
        lblGrade = lblAvgGrade
        lblLetter = lblAvgLetterGrade
        CalcButton = btnAvgCalculate
        ResetButton = btnAvgReset
        panelMode = AvgPanel

        CalcGrade.Reset_TextBox(strAvgGrade, strNothing, lblRow, lblGrade, lblLetter, CalcButton, ResetButton, panelMode, NewAvgTextBox, LastAvgTextBox)
    End Sub

    Private Sub txtGrade1_TextChanged(sender As Object, e As EventArgs) Handles txtGrade1.TextChanged, txtWeight1.TextChanged,
                                                                                txtEarnedPoints1.TextChanged, txtTotalPoints1.TextChanged,
                                                                                txtAvgGrade1.TextChanged
        Dim Tab As TextBox = CType(sender, TextBox)

        If Tab.Name = "txtGrade1" Or Tab.Name = "txtWeight1" Then
            If txtGrade1.Text <> "" Or txtWeight1.Text <> "" Then
                If txtGrade1.Text <> "" And txtWeight1.Text <> "" Then
                    btnCalculate.Enabled = True
                Else
                    btnCalculate.Enabled = False
                End If
                btnReset.Enabled = True
            Else
                btnCalculate.Enabled = False
                btnReset.Enabled = False
            End If
        ElseIf Tab.Name = "txtEarnedPoints1" Or Tab.Name = "txtTotalPoints1" Then
            If txtEarnedPoints1.Text <> "" Or txtTotalPoints1.Text <> "" Then
                If txtEarnedPoints1.Text <> "" And txtTotalPoints1.Text <> "" Then
                    btnPointCalculate.Enabled = True
                Else
                    btnPointCalculate.Enabled = False
                End If
                btnPointReset.Enabled = True
            Else
                btnPointCalculate.Enabled = False
                btnPointReset.Enabled = False
            End If
        ElseIf Tab.Name = "txtAvgGrade1" Then
            If txtAvgGrade1.Text <> "" Then
                btnAvgCalculate.Enabled = True
                btnAvgReset.Enabled = True
            Else
                btnAvgCalculate.Enabled = False
                btnAvgReset.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim Mode, TextBox1, TextBox2 As String
        Dim FirstTxtBox, SecondTxtBox As TextBox
        Dim lblGrade, lblLetter As Label
        Dim Count As Integer

        For Each TextBox In WeightPanel.Controls.OfType(Of TextBox)
            If TextBox.Text <> "" Then
                Count += 1
            End If
        Next

        Mode = "Weight"
        TextBox1 = "txtGrade"
        TextBox2 = "txtWeight"
        FirstTxtBox = txtGrade1
        SecondTxtBox = txtWeight1
        lblGrade = lblDisplayGrade
        lblLetter = lblLetterGrade

        CalcGrade.Calculate(Mode, TextBox1, TextBox2, FirstTxtBox, SecondTxtBox, lblGrade, lblLetter, Count)
    End Sub

    Private Sub btnPointCalculate_Click(sender As Object, e As EventArgs) Handles btnPointCalculate.Click
        Dim Mode, TextBox1, TextBox2 As String
        Dim FirstTxtBox, SecondTxtBox As TextBox
        Dim lblGrade, lblLetter As Label
        Dim Count As Integer

        For Each TextBox In PointsPanel.Controls.OfType(Of TextBox)
            If TextBox.Text <> "" Then
                Count += 1
            End If
        Next

        Mode = "Points"
        TextBox1 = "txtEarnedPoints"
        TextBox2 = "txtTotalPoints"
        FirstTxtBox = txtEarnedPoints1
        SecondTxtBox = txtTotalPoints1
        lblGrade = lblDisplayPointGrade
        lblLetter = lblDisplayPointLetterGrade

        CalcGrade.Calculate(Mode, TextBox1, TextBox2, FirstTxtBox, SecondTxtBox, lblGrade, lblLetter, Count)
    End Sub

    Private Sub btnAvgCalculate_Click(sender As Object, e As EventArgs) Handles btnAvgCalculate.Click
        Dim Mode, TextBox1, TextBox2 As String
        Dim FirstTxtBox, SecondTxtBox As TextBox
        Dim lblGrade, lblLetter As Label
        Dim Count As Integer

        For Each TextBox In AvgPanel.Controls.OfType(Of TextBox)
            If TextBox.Text <> "" Then
                Count += 1
            End If
        Next

        Mode = "Average"
        TextBox1 = "txtAvgGrade"
        TextBox2 = ""
        FirstTxtBox = txtAvgGrade1
        SecondTxtBox = Nothing
        lblGrade = lblAvgGrade
        lblLetter = lblAvgLetterGrade

        CalcGrade.Calculate(Mode, TextBox1, TextBox2, FirstTxtBox, SecondTxtBox, lblGrade, lblLetter, Count)
    End Sub

    Private Sub tbnAddRowWeight_Click(sender As Object, e As EventArgs) Handles btnAddRowWeight.Click
        Dim TxtBox1, TxtBox2, lblRow As String
        Dim PanelCtrl As Panel
        Dim NewBox, LastBox As Int32

        TxtBox1 = "txtGrade"
        TxtBox2 = "txtWeight"
        lblRow = "lblRow"
        PanelCtrl = WeightPanel
        NewBox = NewWeightTextBox
        LastBox = LastWeightTextBox

        CalcGrade.AddRow(TxtBox1, TxtBox2, lblRow, PanelCtrl, NewBox, LastBox)

        NewWeightTextBox += 1
        LastWeightTextBox += 1
    End Sub

    Private Sub btnAddRowPoints_Click(sender As Object, e As EventArgs) Handles btnAddRowPoints.Click
        Dim TxtBox1, TxtBox2, lblRow As String
        Dim PanelCtrl As Panel
        Dim NewBox, LastBox As Int32

        TxtBox1 = "txtTotalPoints"
        TxtBox2 = "txtEarnedPoints"
        lblRow = "lblPointsRow"
        PanelCtrl = PointsPanel
        NewBox = NewPointsTextBox
        LastBox = LastPointsTextBox

        CalcGrade.AddRow(TxtBox1, TxtBox2, lblRow, PanelCtrl, NewBox, LastBox)

        NewPointsTextBox += 1
        LastPointsTextBox += 1
    End Sub

    Private Sub btnAddRowAvg_Click(sender As Object, e As EventArgs) Handles btnAddRowAvg.Click
        Dim TxtBox1, TxtBox2, lblRow As String
        Dim PanelCtrl As Panel
        Dim NewBox, LastBox As Int32

        TxtBox1 = "txtAvgGrade"
        TxtBox2 = ""
        lblRow = "lblAvgRow"
        PanelCtrl = AvgPanel
        NewBox = NewAvgTextBox
        LastBox = LastAvgTextBox

        CalcGrade.AddRow(TxtBox1, TxtBox2, lblRow, PanelCtrl, NewBox, LastBox)

        NewAvgTextBox += 1
        LastAvgTextBox += 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnChangeColor.Click
        ColorDialog1.Color = Me.ForeColor
        ColorDialog1.ShowDialog()
        CustFormColor = ColorDialog1.Color
        Console.WriteLine(CustFormColor)
    End Sub

    Private Sub btnCalculate_MouseEnter(sender As Object, e As EventArgs) Handles btnCalculate.MouseEnter, btnReset.MouseEnter,
                                                                                  btnPointCalculate.MouseEnter, btnPointReset.MouseEnter,
                                                                                  btnAvgCalculate.MouseEnter, btnAvgReset.MouseEnter,
                                                                                  btnAddRowWeight.MouseEnter, btnAddRowPoints.MouseEnter,
                                                                                  btnAddRowAvg.MouseEnter, btnChangeColor.MouseEnter
        Dim ButtonBackground As Button = CType(sender, Button)

        ButtonBackground.BackgroundImage = My.Resources.Dark_New_Background
    End Sub

    Private Sub btnCalculate_MouseLeave(sender As Object, e As EventArgs) Handles btnCalculate.MouseLeave, btnReset.MouseLeave,
                                                                                  btnPointCalculate.MouseLeave, btnReset.MouseLeave,
                                                                                  btnAvgCalculate.MouseLeave, btnAvgReset.MouseLeave,
                                                                                  btnAddRowWeight.MouseLeave, btnAddRowPoints.MouseLeave,
                                                                                  btnAddRowAvg.MouseLeave, btnChangeColor.MouseLeave
        Dim ButtonBackground As Button = CType(sender, Button)

        ButtonBackground.BackgroundImage = My.Resources.New_Background
    End Sub

    Private Sub btnSaveSettings_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        'If CustFormColor <> Nothing Then

        'End If
        My.Settings.FormColor = CustFormColor
        My.Settings.FormName = txtChangeName.Text
        My.Settings.Save()

        Console.WriteLine(CustFormColor.ToString = "Color [Empty]")
    End Sub

    Private Sub btnResetChanges_Click(sender As Object, e As EventArgs) Handles btnResetChanges.Click
        Me.ForeColor = Color.Black
        Me.Text = "Grade Calculator"
    End Sub

    Private Sub txtChangeName_Leave(sender As Object, e As EventArgs) Handles txtChangeName.Leave
        If txtChangeName.Text <> "" Then
            Me.Text = txtChangeName.Text
        End If
    End Sub
End Class
