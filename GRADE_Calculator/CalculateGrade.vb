Public Class CalculateGrade
    Public Sub CtrlHasChildren(ByVal Ctrl As Control)
        For Each child As Control In Ctrl.Controls
            If (child.HasChildren) Then
                CtrlHasChildren(child)
            Else
                If TypeOf child Is TextBox Then
                    If child.Name <> "txtGrade1" Or child.Name <> "txtWeight1" Or child.Name <> "txtTotalPoints1" Or child.Name <> "txtEarnedPoints1" Or child.Name <> "txtAvgGrade1" Then
                        Console.WriteLine(child.Name)
                        child.Enabled = False
                    End If
                End If
            End If
            ' ==========================================
            ' ==========================================
            ' == Note: This sub procedure is NOT done ==
            ' ==========================================
            ' ==========================================
        Next
    End Sub

    Public Sub Calculate(ByVal CalcMode As String,
                          ByVal TextBox1 As String,
                          ByVal TextBox2 As String,
                          ByVal FirstTextBox As TextBox,
                          ByVal SecondTextBox As TextBox,
                          ByVal lblGrade As Label,
                          ByVal lblLetter As Label,
                          ByVal Count As Integer)

        ' For AVERAGE Calculation, pass "Nothing" for the SecondTextBox parameter
        ' Example: SecondTextBox = Nothing
        Dim Letter As String
        Dim YourGrade As Decimal

        Try
            Dim i As Int32 = 1
            Dim GradeXWeight, Result, EarnedPoints, GradeSum As Decimal
            Dim TotalWeight, TotalPoints, AmountOfGrades As Int32

            For i = 1 To Count
                Dim txtBox1 = GradeCalculator.Controls.Find(TextBox1 & i, True)
                Dim txtBox2 = GradeCalculator.Controls.Find(TextBox2 & i, True)

                If TextBox2 <> "" AndAlso SecondTextBox IsNot Nothing Then
                    If txtBox1(0).Text = "" Or txtBox2(0).Text = "" Then
                        If FirstTextBox.Text = "" Or SecondTextBox.Text = "" Then
                            MessageBox.Show("You must enter at least one grade")
                            Exit Sub
                        Else
                            Exit For
                        End If
                    End If
                Else
                    If txtBox1(0).Text = "" Then
                        If FirstTextBox.Text = "" Then
                            MessageBox.Show("You must enter at least one grade")
                            Exit Sub
                        Else
                            Exit For
                        End If
                    End If
                End If
                If CalcMode = "Weight" Then
                    Result = Decimal.Parse(txtBox1(0).Text) * Decimal.Parse(txtBox2(0).Text)
                    GradeXWeight += Result
                    TotalWeight += Int32.Parse(txtBox2(0).Text)
                ElseIf CalcMode = "Points" Then
                    EarnedPoints = Decimal.Parse(EarnedPoints) + Decimal.Parse(txtBox1(0).Text)
                    TotalPoints = Decimal.Parse(TotalPoints) + Decimal.Parse(txtBox2(0).Text)
                ElseIf CalcMode = "Average" Then
                    GradeSum = Decimal.Parse(GradeSum) + Decimal.Parse(txtBox1(0).Text)
                    AmountOfGrades += 1
                End If
            Next

            If CalcMode = "Weight" Then
                YourGrade = GradeXWeight / TotalWeight
            ElseIf CalcMode = "Points" Then
                YourGrade = (EarnedPoints / TotalPoints) * 100
            ElseIf CalcMode = "Average" Then
                YourGrade = GradeSum / AmountOfGrades
            End If

            Letter = getGradeLetter(YourGrade)
            lblGrade.Text = YourGrade.ToString("N2") & "%"
            lblLetter.Text = Letter
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub AddRow(ByVal FirstTextBox As String, ByVal SecondTextBox As String,
                      ByVal RowLabel As String, ByVal PanelCtrl As Panel,
                      ByVal NewBox As Int32, ByVal LastBox As Int32)
        Dim TabCtrl As TabControl = GradeCalculator.TabControl1

        Try
            Dim FirstTxtBox As New TextBox
            Dim SecondTxtBox As New TextBox
            Dim lblRow As New Label
            Dim LastFirstTxt = TabCtrl.Controls.Find(FirstTextBox & LastBox.ToString, True)
            Dim LastSecondTxt = TabCtrl.Controls.Find(SecondTextBox & LastBox.ToString, True)
            Dim LastRowLbl = TabCtrl.Controls.Find(RowLabel & LastBox.ToString, True)
            Dim FirstTxtName As String = FirstTextBox & NewBox.ToString
            Dim SecondTxtName As String = SecondTextBox & NewBox.ToString
            Dim lblRowName As String = RowLabel & NewBox.ToString

            With FirstTxtBox
                If FirstTextBox <> "txtAvgGrade" Then
                    .Size = New Size(100, 24)
                Else
                    .Size = New Size(240, 24)
                End If
                .Location = New Size(LastFirstTxt(0).Location.X, LastFirstTxt(0).Location.Y + 26)
                .Name = FirstTxtName
                .Font = New Font("Microsoft Sans Serif", 11)
            End With

            If SecondTextBox <> "" Then
                With SecondTxtBox
                    .Size = New Size(100, 24)
                    .Location = New Size(LastSecondTxt(0).Location.X, LastSecondTxt(0).Location.Y + 26)
                    .Name = SecondTxtName
                    .Font = New Font("Microsoft Sans Serif", 11)
                End With
            End If

            With lblRow
                .Location = New Size(LastRowLbl(0).Location.X, LastRowLbl(0).Location.Y + 26)
                .Name = lblRowName
                .Font = New Font("Microsoft Sans Serif", 12)
                .Text = NewBox
                .AutoSize = True
            End With

            AddHandler FirstTxtBox.KeyPress, AddressOf GradeCalculator.PercentCalc_KeyPress
            AddHandler FirstTxtBox.TextChanged, AddressOf GradeCalculator.txtGrade1_TextChange

            If SecondTextBox <> "" Then
                AddHandler SecondTxtBox.KeyPress, AddressOf GradeCalculator.PercentCalc_KeyPress
                AddHandler SecondTxtBox.TextChanged, AddressOf GradeCalculator.txtGrade1_TextChange

                PanelCtrl.Controls.Add(SecondTxtBox)
            End If

            PanelCtrl.Controls.Add(FirstTxtBox)
            PanelCtrl.Controls.Add(lblRow)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub Reset_TextBox(ByVal TextBox1 As String, TextBox2 As String,
                             ByVal lblRow As String,
                             ByVal Grade As Label, ByVal LetterGrade As Label,
                             ByVal CalcButton As Button, ByVal ResetButton As Button,
                             ByVal pnlMode As Panel, ByRef NewTextBox As Integer,
                             ByRef LastTextBox As Integer)
        Dim i As Int32 = 1

        For i = 1 To 8
            Dim txtBox1 = GradeCalculator.Controls.Find(TextBox1 & i, True)
            Dim txtBox2 = GradeCalculator.Controls.Find(TextBox2 & i, True)

            If TextBox2 <> "" Then
                If txtBox1(0).Text <> "" OrElse txtBox2(0).Text <> "" Then
                    txtBox1(0).Text = ""
                    txtBox2(0).Text = ""
                Else
                    Continue For
                End If
            Else
                If txtBox1(0).Text <> "" Then
                    txtBox1(0).Text = ""
                Else
                    Continue For
                End If
            End If
        Next

        Dim TxtBoxAmt As Int32 = 0
        For Each ctrl As Control In pnlMode.Controls.OfType(Of TextBox)
            TxtBoxAmt += 1
        Next

        Dim h As Int32
        For h = 9 To (TxtBoxAmt / 2)
            Dim txtBox1 = pnlMode.Controls.Find(TextBox1 & h, True)
            Dim txtBox2 = pnlMode.Controls.Find(TextBox2 & h, True)
            Dim RowLabel = pnlMode.Controls.Find(lblRow & h, True)

            If txtBox1.Length > 0 OrElse txtBox2.Length > 0 OrElse lblRow.Length > 0 Then
                pnlMode.Controls.Remove(txtBox1(0))
                If TextBox2 <> "" Then
                    pnlMode.Controls.Remove(txtBox2(0))
                End If
                pnlMode.Controls.Remove(RowLabel(0))
            Else
                Exit For
            End If
        Next

        Grade.Text = ""
        LetterGrade.Text = ""

        CalcButton.Enabled = False
        ResetButton.Enabled = False

        NewTextBox = 9
        LastTextBox = 8
    End Sub

    Public Function getGradeLetter(ByVal Value As Decimal)
        Dim LetterGrade As String

        Select Case True
            Case Value >= 93
                LetterGrade = "A"
            Case Value >= 90
                LetterGrade = "A-"
            Case Value >= 87
                LetterGrade = "B+"
            Case Value >= 83
                LetterGrade = "B"
            Case Value >= 80
                LetterGrade = "B-"
            Case Value >= 77
                LetterGrade = "C+"
            Case Value >= 73
                LetterGrade = "C"
            Case Value >= 70
                LetterGrade = "C-"
            Case Value >= 67
                LetterGrade = "D+"
            Case Value >= 63
                LetterGrade = "D"
            Case Value >= 60
                LetterGrade = "D-"
            Case Value < 60
                LetterGrade = "F"
        End Select

        Return LetterGrade
    End Function
End Class
