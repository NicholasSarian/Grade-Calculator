<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GradeCalculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GradeCalculator))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.WeightTab = New System.Windows.Forms.TabPage()
        Me.btnAddRowWeight = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblDisplayGrade = New System.Windows.Forms.Label()
        Me.lblLetterGrade = New System.Windows.Forms.Label()
        Me.Weight = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Grade = New System.Windows.Forms.Label()
        Me.RowNumber = New System.Windows.Forms.Label()
        Me.WeightPanel = New System.Windows.Forms.Panel()
        Me.lblRow2 = New System.Windows.Forms.Label()
        Me.txtWeight7 = New System.Windows.Forms.TextBox()
        Me.txtWeight8 = New System.Windows.Forms.TextBox()
        Me.lblRow1 = New System.Windows.Forms.Label()
        Me.txtWeight6 = New System.Windows.Forms.TextBox()
        Me.txtWeight5 = New System.Windows.Forms.TextBox()
        Me.lblRow3 = New System.Windows.Forms.Label()
        Me.txtWeight4 = New System.Windows.Forms.TextBox()
        Me.lblRow4 = New System.Windows.Forms.Label()
        Me.txtWeight3 = New System.Windows.Forms.TextBox()
        Me.lblRow5 = New System.Windows.Forms.Label()
        Me.txtWeight2 = New System.Windows.Forms.TextBox()
        Me.lblRow6 = New System.Windows.Forms.Label()
        Me.txtWeight1 = New System.Windows.Forms.TextBox()
        Me.lblRow7 = New System.Windows.Forms.Label()
        Me.txtGrade8 = New System.Windows.Forms.TextBox()
        Me.lblRow8 = New System.Windows.Forms.Label()
        Me.txtGrade7 = New System.Windows.Forms.TextBox()
        Me.txtGrade1 = New System.Windows.Forms.TextBox()
        Me.txtGrade6 = New System.Windows.Forms.TextBox()
        Me.txtGrade2 = New System.Windows.Forms.TextBox()
        Me.txtGrade5 = New System.Windows.Forms.TextBox()
        Me.txtGrade3 = New System.Windows.Forms.TextBox()
        Me.txtGrade4 = New System.Windows.Forms.TextBox()
        Me.PointsTab = New System.Windows.Forms.TabPage()
        Me.btnAddRowPoints = New System.Windows.Forms.Button()
        Me.lblDisplayPointGrade = New System.Windows.Forms.Label()
        Me.lblDisplayPointLetterGrade = New System.Windows.Forms.Label()
        Me.btnPointReset = New System.Windows.Forms.Button()
        Me.btnPointCalculate = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.PointsPanel = New System.Windows.Forms.Panel()
        Me.txtTotalPoints7 = New System.Windows.Forms.TextBox()
        Me.lblPointsRow1 = New System.Windows.Forms.Label()
        Me.txtTotalPoints8 = New System.Windows.Forms.TextBox()
        Me.lblPointsRow2 = New System.Windows.Forms.Label()
        Me.txtTotalPoints6 = New System.Windows.Forms.TextBox()
        Me.lblPointsRow3 = New System.Windows.Forms.Label()
        Me.txtTotalPoints5 = New System.Windows.Forms.TextBox()
        Me.lblPointsRow4 = New System.Windows.Forms.Label()
        Me.txtTotalPoints4 = New System.Windows.Forms.TextBox()
        Me.lblPointsRow5 = New System.Windows.Forms.Label()
        Me.txtTotalPoints3 = New System.Windows.Forms.TextBox()
        Me.lblPointsRow6 = New System.Windows.Forms.Label()
        Me.txtTotalPoints2 = New System.Windows.Forms.TextBox()
        Me.lblPointsRow7 = New System.Windows.Forms.Label()
        Me.txtTotalPoints1 = New System.Windows.Forms.TextBox()
        Me.lblPointsRow8 = New System.Windows.Forms.Label()
        Me.txtEarnedPoints8 = New System.Windows.Forms.TextBox()
        Me.txtEarnedPoints1 = New System.Windows.Forms.TextBox()
        Me.txtEarnedPoints7 = New System.Windows.Forms.TextBox()
        Me.txtEarnedPoints2 = New System.Windows.Forms.TextBox()
        Me.txtEarnedPoints6 = New System.Windows.Forms.TextBox()
        Me.txtEarnedPoints3 = New System.Windows.Forms.TextBox()
        Me.txtEarnedPoints5 = New System.Windows.Forms.TextBox()
        Me.txtEarnedPoints4 = New System.Windows.Forms.TextBox()
        Me.AverageTab = New System.Windows.Forms.TabPage()
        Me.btnAddRowAvg = New System.Windows.Forms.Button()
        Me.lblAvgGrade = New System.Windows.Forms.Label()
        Me.lblAvgLetterGrade = New System.Windows.Forms.Label()
        Me.btnAvgReset = New System.Windows.Forms.Button()
        Me.btnAvgCalculate = New System.Windows.Forms.Button()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.AvgPanel = New System.Windows.Forms.Panel()
        Me.txtAvgGrade8 = New System.Windows.Forms.TextBox()
        Me.lblAvgRow1 = New System.Windows.Forms.Label()
        Me.txtAvgGrade7 = New System.Windows.Forms.TextBox()
        Me.lblAvgRow2 = New System.Windows.Forms.Label()
        Me.txtAvgGrade6 = New System.Windows.Forms.TextBox()
        Me.lblAvgRow3 = New System.Windows.Forms.Label()
        Me.txtAvgGrade5 = New System.Windows.Forms.TextBox()
        Me.lblAvgRow4 = New System.Windows.Forms.Label()
        Me.txtAvgGrade4 = New System.Windows.Forms.TextBox()
        Me.lblAvgRow5 = New System.Windows.Forms.Label()
        Me.txtAvgGrade3 = New System.Windows.Forms.TextBox()
        Me.lblAvgRow6 = New System.Windows.Forms.Label()
        Me.txtAvgGrade2 = New System.Windows.Forms.TextBox()
        Me.lblAvgRow7 = New System.Windows.Forms.Label()
        Me.txtAvgGrade1 = New System.Windows.Forms.TextBox()
        Me.lblAvgRow8 = New System.Windows.Forms.Label()
        Me.SettingsTab = New System.Windows.Forms.TabPage()
        Me.btnResetChanges = New System.Windows.Forms.Button()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.btnChangeColor = New System.Windows.Forms.Button()
        Me.txtChangeName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNameOfCalc = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.TabControl1.SuspendLayout()
        Me.WeightTab.SuspendLayout()
        Me.WeightPanel.SuspendLayout()
        Me.PointsTab.SuspendLayout()
        Me.PointsPanel.SuspendLayout()
        Me.AverageTab.SuspendLayout()
        Me.AvgPanel.SuspendLayout()
        Me.SettingsTab.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.WeightTab)
        Me.TabControl1.Controls.Add(Me.PointsTab)
        Me.TabControl1.Controls.Add(Me.AverageTab)
        Me.TabControl1.Controls.Add(Me.SettingsTab)
        Me.TabControl1.Location = New System.Drawing.Point(16, 17)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(340, 451)
        Me.TabControl1.TabIndex = 0
        '
        'WeightTab
        '
        Me.WeightTab.Controls.Add(Me.btnAddRowWeight)
        Me.WeightTab.Controls.Add(Me.btnCalculate)
        Me.WeightTab.Controls.Add(Me.btnReset)
        Me.WeightTab.Controls.Add(Me.lblDisplayGrade)
        Me.WeightTab.Controls.Add(Me.lblLetterGrade)
        Me.WeightTab.Controls.Add(Me.Weight)
        Me.WeightTab.Controls.Add(Me.Label13)
        Me.WeightTab.Controls.Add(Me.Label12)
        Me.WeightTab.Controls.Add(Me.Grade)
        Me.WeightTab.Controls.Add(Me.RowNumber)
        Me.WeightTab.Controls.Add(Me.WeightPanel)
        Me.WeightTab.Location = New System.Drawing.Point(4, 22)
        Me.WeightTab.Name = "WeightTab"
        Me.WeightTab.Padding = New System.Windows.Forms.Padding(3)
        Me.WeightTab.Size = New System.Drawing.Size(332, 425)
        Me.WeightTab.TabIndex = 0
        Me.WeightTab.Text = "Weight"
        Me.WeightTab.UseVisualStyleBackColor = True
        '
        'btnAddRowWeight
        '
        Me.btnAddRowWeight.BackgroundImage = CType(resources.GetObject("btnAddRowWeight.BackgroundImage"), System.Drawing.Image)
        Me.btnAddRowWeight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddRowWeight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddRowWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddRowWeight.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAddRowWeight.Location = New System.Drawing.Point(215, 265)
        Me.btnAddRowWeight.Name = "btnAddRowWeight"
        Me.btnAddRowWeight.Size = New System.Drawing.Size(85, 39)
        Me.btnAddRowWeight.TabIndex = 6
        Me.btnAddRowWeight.Text = "Add Row"
        Me.btnAddRowWeight.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.BackgroundImage = CType(resources.GetObject("btnCalculate.BackgroundImage"), System.Drawing.Image)
        Me.btnCalculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCalculate.Location = New System.Drawing.Point(33, 265)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(85, 39)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.BackgroundImage = CType(resources.GetObject("btnReset.BackgroundImage"), System.Drawing.Image)
        Me.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnReset.Location = New System.Drawing.Point(124, 265)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(85, 39)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblDisplayGrade
        '
        Me.lblDisplayGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisplayGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplayGrade.Location = New System.Drawing.Point(28, 352)
        Me.lblDisplayGrade.Name = "lblDisplayGrade"
        Me.lblDisplayGrade.Size = New System.Drawing.Size(134, 53)
        Me.lblDisplayGrade.TabIndex = 9
        Me.lblDisplayGrade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLetterGrade
        '
        Me.lblLetterGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLetterGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLetterGrade.Location = New System.Drawing.Point(175, 352)
        Me.lblLetterGrade.Name = "lblLetterGrade"
        Me.lblLetterGrade.Size = New System.Drawing.Size(134, 53)
        Me.lblLetterGrade.TabIndex = 10
        Me.lblLetterGrade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Weight
        '
        Me.Weight.AutoSize = True
        Me.Weight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Weight.Location = New System.Drawing.Point(205, 20)
        Me.Weight.Name = "Weight"
        Me.Weight.Size = New System.Drawing.Size(87, 20)
        Me.Weight.TabIndex = 2
        Me.Weight.Text = "Weight (%)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(177, 321)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 20)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Letter Grade:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(24, 321)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 20)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Grade:"
        '
        'Grade
        '
        Me.Grade.AutoSize = True
        Me.Grade.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grade.Location = New System.Drawing.Point(65, 20)
        Me.Grade.Name = "Grade"
        Me.Grade.Size = New System.Drawing.Size(82, 20)
        Me.Grade.TabIndex = 1
        Me.Grade.Text = "Grade (%)"
        '
        'RowNumber
        '
        Me.RowNumber.AutoSize = True
        Me.RowNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RowNumber.Location = New System.Drawing.Point(24, 20)
        Me.RowNumber.Name = "RowNumber"
        Me.RowNumber.Size = New System.Drawing.Size(18, 20)
        Me.RowNumber.TabIndex = 0
        Me.RowNumber.Text = "#"
        '
        'WeightPanel
        '
        Me.WeightPanel.AutoScroll = True
        Me.WeightPanel.BackColor = System.Drawing.Color.Transparent
        Me.WeightPanel.Controls.Add(Me.lblRow2)
        Me.WeightPanel.Controls.Add(Me.txtWeight7)
        Me.WeightPanel.Controls.Add(Me.txtWeight8)
        Me.WeightPanel.Controls.Add(Me.lblRow1)
        Me.WeightPanel.Controls.Add(Me.txtWeight6)
        Me.WeightPanel.Controls.Add(Me.txtWeight5)
        Me.WeightPanel.Controls.Add(Me.lblRow3)
        Me.WeightPanel.Controls.Add(Me.txtWeight4)
        Me.WeightPanel.Controls.Add(Me.lblRow4)
        Me.WeightPanel.Controls.Add(Me.txtWeight3)
        Me.WeightPanel.Controls.Add(Me.lblRow5)
        Me.WeightPanel.Controls.Add(Me.txtWeight2)
        Me.WeightPanel.Controls.Add(Me.lblRow6)
        Me.WeightPanel.Controls.Add(Me.txtWeight1)
        Me.WeightPanel.Controls.Add(Me.lblRow7)
        Me.WeightPanel.Controls.Add(Me.txtGrade8)
        Me.WeightPanel.Controls.Add(Me.lblRow8)
        Me.WeightPanel.Controls.Add(Me.txtGrade7)
        Me.WeightPanel.Controls.Add(Me.txtGrade1)
        Me.WeightPanel.Controls.Add(Me.txtGrade6)
        Me.WeightPanel.Controls.Add(Me.txtGrade2)
        Me.WeightPanel.Controls.Add(Me.txtGrade5)
        Me.WeightPanel.Controls.Add(Me.txtGrade3)
        Me.WeightPanel.Controls.Add(Me.txtGrade4)
        Me.WeightPanel.Location = New System.Drawing.Point(7, 47)
        Me.WeightPanel.Name = "WeightPanel"
        Me.WeightPanel.Size = New System.Drawing.Size(319, 215)
        Me.WeightPanel.TabIndex = 3
        '
        'lblRow2
        '
        Me.lblRow2.AutoSize = True
        Me.lblRow2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRow2.Location = New System.Drawing.Point(17, 34)
        Me.lblRow2.Name = "lblRow2"
        Me.lblRow2.Size = New System.Drawing.Size(18, 20)
        Me.lblRow2.TabIndex = 3
        Me.lblRow2.Text = "2"
        '
        'txtWeight7
        '
        Me.txtWeight7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeight7.Location = New System.Drawing.Point(202, 162)
        Me.txtWeight7.Name = "txtWeight7"
        Me.txtWeight7.Size = New System.Drawing.Size(100, 24)
        Me.txtWeight7.TabIndex = 20
        '
        'txtWeight8
        '
        Me.txtWeight8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeight8.Location = New System.Drawing.Point(202, 188)
        Me.txtWeight8.Name = "txtWeight8"
        Me.txtWeight8.Size = New System.Drawing.Size(100, 24)
        Me.txtWeight8.TabIndex = 23
        '
        'lblRow1
        '
        Me.lblRow1.AutoSize = True
        Me.lblRow1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRow1.Location = New System.Drawing.Point(17, 8)
        Me.lblRow1.Name = "lblRow1"
        Me.lblRow1.Size = New System.Drawing.Size(18, 20)
        Me.lblRow1.TabIndex = 0
        Me.lblRow1.Text = "1"
        '
        'txtWeight6
        '
        Me.txtWeight6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeight6.Location = New System.Drawing.Point(202, 136)
        Me.txtWeight6.Name = "txtWeight6"
        Me.txtWeight6.Size = New System.Drawing.Size(100, 24)
        Me.txtWeight6.TabIndex = 17
        '
        'txtWeight5
        '
        Me.txtWeight5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeight5.Location = New System.Drawing.Point(202, 110)
        Me.txtWeight5.Name = "txtWeight5"
        Me.txtWeight5.Size = New System.Drawing.Size(100, 24)
        Me.txtWeight5.TabIndex = 14
        '
        'lblRow3
        '
        Me.lblRow3.AutoSize = True
        Me.lblRow3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRow3.Location = New System.Drawing.Point(17, 60)
        Me.lblRow3.Name = "lblRow3"
        Me.lblRow3.Size = New System.Drawing.Size(18, 20)
        Me.lblRow3.TabIndex = 6
        Me.lblRow3.Text = "3"
        '
        'txtWeight4
        '
        Me.txtWeight4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeight4.Location = New System.Drawing.Point(202, 84)
        Me.txtWeight4.Name = "txtWeight4"
        Me.txtWeight4.Size = New System.Drawing.Size(100, 24)
        Me.txtWeight4.TabIndex = 11
        '
        'lblRow4
        '
        Me.lblRow4.AutoSize = True
        Me.lblRow4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRow4.Location = New System.Drawing.Point(17, 86)
        Me.lblRow4.Name = "lblRow4"
        Me.lblRow4.Size = New System.Drawing.Size(18, 20)
        Me.lblRow4.TabIndex = 9
        Me.lblRow4.Text = "4"
        '
        'txtWeight3
        '
        Me.txtWeight3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeight3.Location = New System.Drawing.Point(202, 58)
        Me.txtWeight3.Name = "txtWeight3"
        Me.txtWeight3.Size = New System.Drawing.Size(100, 24)
        Me.txtWeight3.TabIndex = 8
        '
        'lblRow5
        '
        Me.lblRow5.AutoSize = True
        Me.lblRow5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRow5.Location = New System.Drawing.Point(17, 112)
        Me.lblRow5.Name = "lblRow5"
        Me.lblRow5.Size = New System.Drawing.Size(18, 20)
        Me.lblRow5.TabIndex = 12
        Me.lblRow5.Text = "5"
        '
        'txtWeight2
        '
        Me.txtWeight2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeight2.Location = New System.Drawing.Point(202, 32)
        Me.txtWeight2.Name = "txtWeight2"
        Me.txtWeight2.Size = New System.Drawing.Size(100, 24)
        Me.txtWeight2.TabIndex = 5
        '
        'lblRow6
        '
        Me.lblRow6.AutoSize = True
        Me.lblRow6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRow6.Location = New System.Drawing.Point(17, 138)
        Me.lblRow6.Name = "lblRow6"
        Me.lblRow6.Size = New System.Drawing.Size(18, 20)
        Me.lblRow6.TabIndex = 15
        Me.lblRow6.Text = "6"
        '
        'txtWeight1
        '
        Me.txtWeight1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeight1.Location = New System.Drawing.Point(202, 4)
        Me.txtWeight1.Name = "txtWeight1"
        Me.txtWeight1.Size = New System.Drawing.Size(100, 24)
        Me.txtWeight1.TabIndex = 2
        '
        'lblRow7
        '
        Me.lblRow7.AutoSize = True
        Me.lblRow7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRow7.Location = New System.Drawing.Point(17, 164)
        Me.lblRow7.Name = "lblRow7"
        Me.lblRow7.Size = New System.Drawing.Size(18, 20)
        Me.lblRow7.TabIndex = 18
        Me.lblRow7.Text = "7"
        '
        'txtGrade8
        '
        Me.txtGrade8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrade8.Location = New System.Drawing.Point(62, 188)
        Me.txtGrade8.Name = "txtGrade8"
        Me.txtGrade8.Size = New System.Drawing.Size(100, 24)
        Me.txtGrade8.TabIndex = 22
        '
        'lblRow8
        '
        Me.lblRow8.AutoSize = True
        Me.lblRow8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRow8.Location = New System.Drawing.Point(17, 190)
        Me.lblRow8.Name = "lblRow8"
        Me.lblRow8.Size = New System.Drawing.Size(18, 20)
        Me.lblRow8.TabIndex = 21
        Me.lblRow8.Text = "8"
        '
        'txtGrade7
        '
        Me.txtGrade7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrade7.Location = New System.Drawing.Point(62, 162)
        Me.txtGrade7.Name = "txtGrade7"
        Me.txtGrade7.Size = New System.Drawing.Size(100, 24)
        Me.txtGrade7.TabIndex = 19
        '
        'txtGrade1
        '
        Me.txtGrade1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrade1.Location = New System.Drawing.Point(62, 4)
        Me.txtGrade1.Name = "txtGrade1"
        Me.txtGrade1.Size = New System.Drawing.Size(100, 24)
        Me.txtGrade1.TabIndex = 1
        '
        'txtGrade6
        '
        Me.txtGrade6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrade6.Location = New System.Drawing.Point(62, 136)
        Me.txtGrade6.Name = "txtGrade6"
        Me.txtGrade6.Size = New System.Drawing.Size(100, 24)
        Me.txtGrade6.TabIndex = 16
        '
        'txtGrade2
        '
        Me.txtGrade2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrade2.Location = New System.Drawing.Point(62, 32)
        Me.txtGrade2.Name = "txtGrade2"
        Me.txtGrade2.Size = New System.Drawing.Size(100, 24)
        Me.txtGrade2.TabIndex = 4
        '
        'txtGrade5
        '
        Me.txtGrade5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrade5.Location = New System.Drawing.Point(62, 110)
        Me.txtGrade5.Name = "txtGrade5"
        Me.txtGrade5.Size = New System.Drawing.Size(100, 24)
        Me.txtGrade5.TabIndex = 13
        '
        'txtGrade3
        '
        Me.txtGrade3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrade3.Location = New System.Drawing.Point(62, 58)
        Me.txtGrade3.Name = "txtGrade3"
        Me.txtGrade3.Size = New System.Drawing.Size(100, 24)
        Me.txtGrade3.TabIndex = 7
        '
        'txtGrade4
        '
        Me.txtGrade4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrade4.Location = New System.Drawing.Point(62, 84)
        Me.txtGrade4.Name = "txtGrade4"
        Me.txtGrade4.Size = New System.Drawing.Size(100, 24)
        Me.txtGrade4.TabIndex = 10
        '
        'PointsTab
        '
        Me.PointsTab.Controls.Add(Me.btnAddRowPoints)
        Me.PointsTab.Controls.Add(Me.lblDisplayPointGrade)
        Me.PointsTab.Controls.Add(Me.lblDisplayPointLetterGrade)
        Me.PointsTab.Controls.Add(Me.btnPointReset)
        Me.PointsTab.Controls.Add(Me.btnPointCalculate)
        Me.PointsTab.Controls.Add(Me.Label18)
        Me.PointsTab.Controls.Add(Me.Label19)
        Me.PointsTab.Controls.Add(Me.Label20)
        Me.PointsTab.Controls.Add(Me.Label21)
        Me.PointsTab.Controls.Add(Me.Label30)
        Me.PointsTab.Controls.Add(Me.PointsPanel)
        Me.PointsTab.Location = New System.Drawing.Point(4, 22)
        Me.PointsTab.Name = "PointsTab"
        Me.PointsTab.Padding = New System.Windows.Forms.Padding(3)
        Me.PointsTab.Size = New System.Drawing.Size(332, 425)
        Me.PointsTab.TabIndex = 1
        Me.PointsTab.Text = "Points"
        Me.PointsTab.UseVisualStyleBackColor = True
        '
        'btnAddRowPoints
        '
        Me.btnAddRowPoints.BackgroundImage = CType(resources.GetObject("btnAddRowPoints.BackgroundImage"), System.Drawing.Image)
        Me.btnAddRowPoints.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddRowPoints.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddRowPoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddRowPoints.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAddRowPoints.Location = New System.Drawing.Point(215, 265)
        Me.btnAddRowPoints.Name = "btnAddRowPoints"
        Me.btnAddRowPoints.Size = New System.Drawing.Size(85, 39)
        Me.btnAddRowPoints.TabIndex = 6
        Me.btnAddRowPoints.Text = "Add Row"
        Me.btnAddRowPoints.UseVisualStyleBackColor = True
        '
        'lblDisplayPointGrade
        '
        Me.lblDisplayPointGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisplayPointGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplayPointGrade.Location = New System.Drawing.Point(28, 352)
        Me.lblDisplayPointGrade.Name = "lblDisplayPointGrade"
        Me.lblDisplayPointGrade.Size = New System.Drawing.Size(134, 53)
        Me.lblDisplayPointGrade.TabIndex = 9
        Me.lblDisplayPointGrade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDisplayPointLetterGrade
        '
        Me.lblDisplayPointLetterGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDisplayPointLetterGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplayPointLetterGrade.Location = New System.Drawing.Point(175, 352)
        Me.lblDisplayPointLetterGrade.Name = "lblDisplayPointLetterGrade"
        Me.lblDisplayPointLetterGrade.Size = New System.Drawing.Size(134, 53)
        Me.lblDisplayPointLetterGrade.TabIndex = 10
        Me.lblDisplayPointLetterGrade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnPointReset
        '
        Me.btnPointReset.BackgroundImage = CType(resources.GetObject("btnPointReset.BackgroundImage"), System.Drawing.Image)
        Me.btnPointReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPointReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPointReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPointReset.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPointReset.Location = New System.Drawing.Point(124, 265)
        Me.btnPointReset.Name = "btnPointReset"
        Me.btnPointReset.Size = New System.Drawing.Size(85, 39)
        Me.btnPointReset.TabIndex = 5
        Me.btnPointReset.Text = "Reset"
        Me.btnPointReset.UseVisualStyleBackColor = True
        '
        'btnPointCalculate
        '
        Me.btnPointCalculate.BackgroundImage = CType(resources.GetObject("btnPointCalculate.BackgroundImage"), System.Drawing.Image)
        Me.btnPointCalculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPointCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPointCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPointCalculate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPointCalculate.Location = New System.Drawing.Point(33, 265)
        Me.btnPointCalculate.Name = "btnPointCalculate"
        Me.btnPointCalculate.Size = New System.Drawing.Size(85, 39)
        Me.btnPointCalculate.TabIndex = 4
        Me.btnPointCalculate.Text = "Calculate"
        Me.btnPointCalculate.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(205, 20)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(48, 20)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Total:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(177, 321)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(104, 20)
        Me.Label19.TabIndex = 8
        Me.Label19.Text = "Letter Grade:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(24, 321)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(58, 20)
        Me.Label20.TabIndex = 7
        Me.Label20.Text = "Grade:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(65, 20)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(65, 20)
        Me.Label21.TabIndex = 1
        Me.Label21.Text = "Earned:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(24, 20)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(18, 20)
        Me.Label30.TabIndex = 0
        Me.Label30.Text = "#"
        '
        'PointsPanel
        '
        Me.PointsPanel.AutoScroll = True
        Me.PointsPanel.Controls.Add(Me.txtTotalPoints7)
        Me.PointsPanel.Controls.Add(Me.lblPointsRow1)
        Me.PointsPanel.Controls.Add(Me.txtTotalPoints8)
        Me.PointsPanel.Controls.Add(Me.lblPointsRow2)
        Me.PointsPanel.Controls.Add(Me.txtTotalPoints6)
        Me.PointsPanel.Controls.Add(Me.lblPointsRow3)
        Me.PointsPanel.Controls.Add(Me.txtTotalPoints5)
        Me.PointsPanel.Controls.Add(Me.lblPointsRow4)
        Me.PointsPanel.Controls.Add(Me.txtTotalPoints4)
        Me.PointsPanel.Controls.Add(Me.lblPointsRow5)
        Me.PointsPanel.Controls.Add(Me.txtTotalPoints3)
        Me.PointsPanel.Controls.Add(Me.lblPointsRow6)
        Me.PointsPanel.Controls.Add(Me.txtTotalPoints2)
        Me.PointsPanel.Controls.Add(Me.lblPointsRow7)
        Me.PointsPanel.Controls.Add(Me.txtTotalPoints1)
        Me.PointsPanel.Controls.Add(Me.lblPointsRow8)
        Me.PointsPanel.Controls.Add(Me.txtEarnedPoints8)
        Me.PointsPanel.Controls.Add(Me.txtEarnedPoints1)
        Me.PointsPanel.Controls.Add(Me.txtEarnedPoints7)
        Me.PointsPanel.Controls.Add(Me.txtEarnedPoints2)
        Me.PointsPanel.Controls.Add(Me.txtEarnedPoints6)
        Me.PointsPanel.Controls.Add(Me.txtEarnedPoints3)
        Me.PointsPanel.Controls.Add(Me.txtEarnedPoints5)
        Me.PointsPanel.Controls.Add(Me.txtEarnedPoints4)
        Me.PointsPanel.Location = New System.Drawing.Point(7, 47)
        Me.PointsPanel.Name = "PointsPanel"
        Me.PointsPanel.Size = New System.Drawing.Size(319, 215)
        Me.PointsPanel.TabIndex = 3
        '
        'txtTotalPoints7
        '
        Me.txtTotalPoints7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPoints7.Location = New System.Drawing.Point(202, 162)
        Me.txtTotalPoints7.MaxLength = 6
        Me.txtTotalPoints7.Name = "txtTotalPoints7"
        Me.txtTotalPoints7.Size = New System.Drawing.Size(100, 24)
        Me.txtTotalPoints7.TabIndex = 20
        '
        'lblPointsRow1
        '
        Me.lblPointsRow1.AutoSize = True
        Me.lblPointsRow1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPointsRow1.Location = New System.Drawing.Point(17, 8)
        Me.lblPointsRow1.Name = "lblPointsRow1"
        Me.lblPointsRow1.Size = New System.Drawing.Size(18, 20)
        Me.lblPointsRow1.TabIndex = 0
        Me.lblPointsRow1.Text = "1"
        '
        'txtTotalPoints8
        '
        Me.txtTotalPoints8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPoints8.Location = New System.Drawing.Point(202, 188)
        Me.txtTotalPoints8.MaxLength = 6
        Me.txtTotalPoints8.Name = "txtTotalPoints8"
        Me.txtTotalPoints8.Size = New System.Drawing.Size(100, 24)
        Me.txtTotalPoints8.TabIndex = 23
        '
        'lblPointsRow2
        '
        Me.lblPointsRow2.AutoSize = True
        Me.lblPointsRow2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPointsRow2.Location = New System.Drawing.Point(17, 34)
        Me.lblPointsRow2.Name = "lblPointsRow2"
        Me.lblPointsRow2.Size = New System.Drawing.Size(18, 20)
        Me.lblPointsRow2.TabIndex = 3
        Me.lblPointsRow2.Text = "2"
        '
        'txtTotalPoints6
        '
        Me.txtTotalPoints6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPoints6.Location = New System.Drawing.Point(202, 136)
        Me.txtTotalPoints6.MaxLength = 6
        Me.txtTotalPoints6.Name = "txtTotalPoints6"
        Me.txtTotalPoints6.Size = New System.Drawing.Size(100, 24)
        Me.txtTotalPoints6.TabIndex = 17
        '
        'lblPointsRow3
        '
        Me.lblPointsRow3.AutoSize = True
        Me.lblPointsRow3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPointsRow3.Location = New System.Drawing.Point(17, 60)
        Me.lblPointsRow3.Name = "lblPointsRow3"
        Me.lblPointsRow3.Size = New System.Drawing.Size(18, 20)
        Me.lblPointsRow3.TabIndex = 6
        Me.lblPointsRow3.Text = "3"
        '
        'txtTotalPoints5
        '
        Me.txtTotalPoints5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPoints5.Location = New System.Drawing.Point(202, 110)
        Me.txtTotalPoints5.MaxLength = 6
        Me.txtTotalPoints5.Name = "txtTotalPoints5"
        Me.txtTotalPoints5.Size = New System.Drawing.Size(100, 24)
        Me.txtTotalPoints5.TabIndex = 14
        '
        'lblPointsRow4
        '
        Me.lblPointsRow4.AutoSize = True
        Me.lblPointsRow4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPointsRow4.Location = New System.Drawing.Point(17, 86)
        Me.lblPointsRow4.Name = "lblPointsRow4"
        Me.lblPointsRow4.Size = New System.Drawing.Size(18, 20)
        Me.lblPointsRow4.TabIndex = 9
        Me.lblPointsRow4.Text = "4"
        '
        'txtTotalPoints4
        '
        Me.txtTotalPoints4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPoints4.Location = New System.Drawing.Point(202, 84)
        Me.txtTotalPoints4.MaxLength = 6
        Me.txtTotalPoints4.Name = "txtTotalPoints4"
        Me.txtTotalPoints4.Size = New System.Drawing.Size(100, 24)
        Me.txtTotalPoints4.TabIndex = 11
        '
        'lblPointsRow5
        '
        Me.lblPointsRow5.AutoSize = True
        Me.lblPointsRow5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPointsRow5.Location = New System.Drawing.Point(17, 112)
        Me.lblPointsRow5.Name = "lblPointsRow5"
        Me.lblPointsRow5.Size = New System.Drawing.Size(18, 20)
        Me.lblPointsRow5.TabIndex = 12
        Me.lblPointsRow5.Text = "5"
        '
        'txtTotalPoints3
        '
        Me.txtTotalPoints3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPoints3.Location = New System.Drawing.Point(202, 58)
        Me.txtTotalPoints3.MaxLength = 6
        Me.txtTotalPoints3.Name = "txtTotalPoints3"
        Me.txtTotalPoints3.Size = New System.Drawing.Size(100, 24)
        Me.txtTotalPoints3.TabIndex = 8
        '
        'lblPointsRow6
        '
        Me.lblPointsRow6.AutoSize = True
        Me.lblPointsRow6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPointsRow6.Location = New System.Drawing.Point(17, 138)
        Me.lblPointsRow6.Name = "lblPointsRow6"
        Me.lblPointsRow6.Size = New System.Drawing.Size(18, 20)
        Me.lblPointsRow6.TabIndex = 15
        Me.lblPointsRow6.Text = "6"
        '
        'txtTotalPoints2
        '
        Me.txtTotalPoints2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPoints2.Location = New System.Drawing.Point(202, 32)
        Me.txtTotalPoints2.MaxLength = 6
        Me.txtTotalPoints2.Name = "txtTotalPoints2"
        Me.txtTotalPoints2.Size = New System.Drawing.Size(100, 24)
        Me.txtTotalPoints2.TabIndex = 5
        '
        'lblPointsRow7
        '
        Me.lblPointsRow7.AutoSize = True
        Me.lblPointsRow7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPointsRow7.Location = New System.Drawing.Point(17, 164)
        Me.lblPointsRow7.Name = "lblPointsRow7"
        Me.lblPointsRow7.Size = New System.Drawing.Size(18, 20)
        Me.lblPointsRow7.TabIndex = 18
        Me.lblPointsRow7.Text = "7"
        '
        'txtTotalPoints1
        '
        Me.txtTotalPoints1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPoints1.Location = New System.Drawing.Point(202, 4)
        Me.txtTotalPoints1.MaxLength = 6
        Me.txtTotalPoints1.Name = "txtTotalPoints1"
        Me.txtTotalPoints1.Size = New System.Drawing.Size(100, 24)
        Me.txtTotalPoints1.TabIndex = 2
        '
        'lblPointsRow8
        '
        Me.lblPointsRow8.AutoSize = True
        Me.lblPointsRow8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPointsRow8.Location = New System.Drawing.Point(17, 190)
        Me.lblPointsRow8.Name = "lblPointsRow8"
        Me.lblPointsRow8.Size = New System.Drawing.Size(18, 20)
        Me.lblPointsRow8.TabIndex = 21
        Me.lblPointsRow8.Text = "8"
        '
        'txtEarnedPoints8
        '
        Me.txtEarnedPoints8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEarnedPoints8.Location = New System.Drawing.Point(62, 188)
        Me.txtEarnedPoints8.MaxLength = 6
        Me.txtEarnedPoints8.Name = "txtEarnedPoints8"
        Me.txtEarnedPoints8.Size = New System.Drawing.Size(100, 24)
        Me.txtEarnedPoints8.TabIndex = 22
        '
        'txtEarnedPoints1
        '
        Me.txtEarnedPoints1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEarnedPoints1.Location = New System.Drawing.Point(62, 4)
        Me.txtEarnedPoints1.MaxLength = 6
        Me.txtEarnedPoints1.Name = "txtEarnedPoints1"
        Me.txtEarnedPoints1.Size = New System.Drawing.Size(100, 24)
        Me.txtEarnedPoints1.TabIndex = 1
        '
        'txtEarnedPoints7
        '
        Me.txtEarnedPoints7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEarnedPoints7.Location = New System.Drawing.Point(62, 162)
        Me.txtEarnedPoints7.MaxLength = 6
        Me.txtEarnedPoints7.Name = "txtEarnedPoints7"
        Me.txtEarnedPoints7.Size = New System.Drawing.Size(100, 24)
        Me.txtEarnedPoints7.TabIndex = 19
        '
        'txtEarnedPoints2
        '
        Me.txtEarnedPoints2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEarnedPoints2.Location = New System.Drawing.Point(62, 32)
        Me.txtEarnedPoints2.MaxLength = 6
        Me.txtEarnedPoints2.Name = "txtEarnedPoints2"
        Me.txtEarnedPoints2.Size = New System.Drawing.Size(100, 24)
        Me.txtEarnedPoints2.TabIndex = 4
        '
        'txtEarnedPoints6
        '
        Me.txtEarnedPoints6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEarnedPoints6.Location = New System.Drawing.Point(62, 136)
        Me.txtEarnedPoints6.MaxLength = 6
        Me.txtEarnedPoints6.Name = "txtEarnedPoints6"
        Me.txtEarnedPoints6.Size = New System.Drawing.Size(100, 24)
        Me.txtEarnedPoints6.TabIndex = 16
        '
        'txtEarnedPoints3
        '
        Me.txtEarnedPoints3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEarnedPoints3.Location = New System.Drawing.Point(62, 58)
        Me.txtEarnedPoints3.MaxLength = 6
        Me.txtEarnedPoints3.Name = "txtEarnedPoints3"
        Me.txtEarnedPoints3.Size = New System.Drawing.Size(100, 24)
        Me.txtEarnedPoints3.TabIndex = 7
        '
        'txtEarnedPoints5
        '
        Me.txtEarnedPoints5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEarnedPoints5.Location = New System.Drawing.Point(62, 110)
        Me.txtEarnedPoints5.MaxLength = 6
        Me.txtEarnedPoints5.Name = "txtEarnedPoints5"
        Me.txtEarnedPoints5.Size = New System.Drawing.Size(100, 24)
        Me.txtEarnedPoints5.TabIndex = 13
        '
        'txtEarnedPoints4
        '
        Me.txtEarnedPoints4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEarnedPoints4.Location = New System.Drawing.Point(62, 84)
        Me.txtEarnedPoints4.MaxLength = 6
        Me.txtEarnedPoints4.Name = "txtEarnedPoints4"
        Me.txtEarnedPoints4.Size = New System.Drawing.Size(100, 24)
        Me.txtEarnedPoints4.TabIndex = 10
        '
        'AverageTab
        '
        Me.AverageTab.Controls.Add(Me.btnAddRowAvg)
        Me.AverageTab.Controls.Add(Me.lblAvgGrade)
        Me.AverageTab.Controls.Add(Me.lblAvgLetterGrade)
        Me.AverageTab.Controls.Add(Me.btnAvgReset)
        Me.AverageTab.Controls.Add(Me.btnAvgCalculate)
        Me.AverageTab.Controls.Add(Me.Label34)
        Me.AverageTab.Controls.Add(Me.Label35)
        Me.AverageTab.Controls.Add(Me.Label36)
        Me.AverageTab.Controls.Add(Me.Label45)
        Me.AverageTab.Controls.Add(Me.AvgPanel)
        Me.AverageTab.Location = New System.Drawing.Point(4, 22)
        Me.AverageTab.Name = "AverageTab"
        Me.AverageTab.Size = New System.Drawing.Size(332, 425)
        Me.AverageTab.TabIndex = 2
        Me.AverageTab.Text = "Average"
        Me.AverageTab.UseVisualStyleBackColor = True
        '
        'btnAddRowAvg
        '
        Me.btnAddRowAvg.BackgroundImage = CType(resources.GetObject("btnAddRowAvg.BackgroundImage"), System.Drawing.Image)
        Me.btnAddRowAvg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddRowAvg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddRowAvg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddRowAvg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAddRowAvg.Location = New System.Drawing.Point(215, 265)
        Me.btnAddRowAvg.Name = "btnAddRowAvg"
        Me.btnAddRowAvg.Size = New System.Drawing.Size(85, 39)
        Me.btnAddRowAvg.TabIndex = 6
        Me.btnAddRowAvg.Text = "Add Row"
        Me.btnAddRowAvg.UseVisualStyleBackColor = True
        '
        'lblAvgGrade
        '
        Me.lblAvgGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAvgGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgGrade.Location = New System.Drawing.Point(28, 352)
        Me.lblAvgGrade.Name = "lblAvgGrade"
        Me.lblAvgGrade.Size = New System.Drawing.Size(134, 53)
        Me.lblAvgGrade.TabIndex = 9
        Me.lblAvgGrade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAvgLetterGrade
        '
        Me.lblAvgLetterGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAvgLetterGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgLetterGrade.Location = New System.Drawing.Point(175, 352)
        Me.lblAvgLetterGrade.Name = "lblAvgLetterGrade"
        Me.lblAvgLetterGrade.Size = New System.Drawing.Size(134, 53)
        Me.lblAvgLetterGrade.TabIndex = 0
        Me.lblAvgLetterGrade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAvgReset
        '
        Me.btnAvgReset.BackgroundImage = CType(resources.GetObject("btnAvgReset.BackgroundImage"), System.Drawing.Image)
        Me.btnAvgReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAvgReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAvgReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAvgReset.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAvgReset.Location = New System.Drawing.Point(124, 265)
        Me.btnAvgReset.Name = "btnAvgReset"
        Me.btnAvgReset.Size = New System.Drawing.Size(85, 39)
        Me.btnAvgReset.TabIndex = 5
        Me.btnAvgReset.Text = "Reset"
        Me.btnAvgReset.UseVisualStyleBackColor = True
        '
        'btnAvgCalculate
        '
        Me.btnAvgCalculate.BackgroundImage = CType(resources.GetObject("btnAvgCalculate.BackgroundImage"), System.Drawing.Image)
        Me.btnAvgCalculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAvgCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAvgCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAvgCalculate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAvgCalculate.Location = New System.Drawing.Point(33, 265)
        Me.btnAvgCalculate.Name = "btnAvgCalculate"
        Me.btnAvgCalculate.Size = New System.Drawing.Size(85, 39)
        Me.btnAvgCalculate.TabIndex = 4
        Me.btnAvgCalculate.Text = "Calculate"
        Me.btnAvgCalculate.UseVisualStyleBackColor = True
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(177, 321)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(104, 20)
        Me.Label34.TabIndex = 8
        Me.Label34.Text = "Letter Grade:"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(24, 321)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(121, 20)
        Me.Label35.TabIndex = 7
        Me.Label35.Text = "Average Grade:"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(65, 20)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(236, 20)
        Me.Label36.TabIndex = 1
        Me.Label36.Text = "Earned Grade Percentages (%):"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(24, 20)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(18, 20)
        Me.Label45.TabIndex = 0
        Me.Label45.Text = "#"
        '
        'AvgPanel
        '
        Me.AvgPanel.AutoScroll = True
        Me.AvgPanel.BackColor = System.Drawing.Color.Transparent
        Me.AvgPanel.Controls.Add(Me.txtAvgGrade8)
        Me.AvgPanel.Controls.Add(Me.lblAvgRow1)
        Me.AvgPanel.Controls.Add(Me.txtAvgGrade7)
        Me.AvgPanel.Controls.Add(Me.lblAvgRow2)
        Me.AvgPanel.Controls.Add(Me.txtAvgGrade6)
        Me.AvgPanel.Controls.Add(Me.lblAvgRow3)
        Me.AvgPanel.Controls.Add(Me.txtAvgGrade5)
        Me.AvgPanel.Controls.Add(Me.lblAvgRow4)
        Me.AvgPanel.Controls.Add(Me.txtAvgGrade4)
        Me.AvgPanel.Controls.Add(Me.lblAvgRow5)
        Me.AvgPanel.Controls.Add(Me.txtAvgGrade3)
        Me.AvgPanel.Controls.Add(Me.lblAvgRow6)
        Me.AvgPanel.Controls.Add(Me.txtAvgGrade2)
        Me.AvgPanel.Controls.Add(Me.lblAvgRow7)
        Me.AvgPanel.Controls.Add(Me.txtAvgGrade1)
        Me.AvgPanel.Controls.Add(Me.lblAvgRow8)
        Me.AvgPanel.Location = New System.Drawing.Point(7, 47)
        Me.AvgPanel.Name = "AvgPanel"
        Me.AvgPanel.Size = New System.Drawing.Size(319, 215)
        Me.AvgPanel.TabIndex = 3
        '
        'txtAvgGrade8
        '
        Me.txtAvgGrade8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvgGrade8.Location = New System.Drawing.Point(62, 188)
        Me.txtAvgGrade8.Name = "txtAvgGrade8"
        Me.txtAvgGrade8.Size = New System.Drawing.Size(240, 24)
        Me.txtAvgGrade8.TabIndex = 15
        Me.txtAvgGrade8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAvgRow1
        '
        Me.lblAvgRow1.AutoSize = True
        Me.lblAvgRow1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgRow1.Location = New System.Drawing.Point(17, 8)
        Me.lblAvgRow1.Name = "lblAvgRow1"
        Me.lblAvgRow1.Size = New System.Drawing.Size(18, 20)
        Me.lblAvgRow1.TabIndex = 0
        Me.lblAvgRow1.Text = "1"
        '
        'txtAvgGrade7
        '
        Me.txtAvgGrade7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvgGrade7.Location = New System.Drawing.Point(62, 162)
        Me.txtAvgGrade7.Name = "txtAvgGrade7"
        Me.txtAvgGrade7.Size = New System.Drawing.Size(240, 24)
        Me.txtAvgGrade7.TabIndex = 13
        Me.txtAvgGrade7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAvgRow2
        '
        Me.lblAvgRow2.AutoSize = True
        Me.lblAvgRow2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgRow2.Location = New System.Drawing.Point(17, 34)
        Me.lblAvgRow2.Name = "lblAvgRow2"
        Me.lblAvgRow2.Size = New System.Drawing.Size(18, 20)
        Me.lblAvgRow2.TabIndex = 2
        Me.lblAvgRow2.Text = "2"
        '
        'txtAvgGrade6
        '
        Me.txtAvgGrade6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvgGrade6.Location = New System.Drawing.Point(62, 136)
        Me.txtAvgGrade6.Name = "txtAvgGrade6"
        Me.txtAvgGrade6.Size = New System.Drawing.Size(240, 24)
        Me.txtAvgGrade6.TabIndex = 11
        Me.txtAvgGrade6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAvgRow3
        '
        Me.lblAvgRow3.AutoSize = True
        Me.lblAvgRow3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgRow3.Location = New System.Drawing.Point(17, 60)
        Me.lblAvgRow3.Name = "lblAvgRow3"
        Me.lblAvgRow3.Size = New System.Drawing.Size(18, 20)
        Me.lblAvgRow3.TabIndex = 4
        Me.lblAvgRow3.Text = "3"
        '
        'txtAvgGrade5
        '
        Me.txtAvgGrade5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvgGrade5.Location = New System.Drawing.Point(62, 110)
        Me.txtAvgGrade5.Name = "txtAvgGrade5"
        Me.txtAvgGrade5.Size = New System.Drawing.Size(240, 24)
        Me.txtAvgGrade5.TabIndex = 9
        Me.txtAvgGrade5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAvgRow4
        '
        Me.lblAvgRow4.AutoSize = True
        Me.lblAvgRow4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgRow4.Location = New System.Drawing.Point(17, 86)
        Me.lblAvgRow4.Name = "lblAvgRow4"
        Me.lblAvgRow4.Size = New System.Drawing.Size(18, 20)
        Me.lblAvgRow4.TabIndex = 6
        Me.lblAvgRow4.Text = "4"
        '
        'txtAvgGrade4
        '
        Me.txtAvgGrade4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvgGrade4.Location = New System.Drawing.Point(62, 84)
        Me.txtAvgGrade4.Name = "txtAvgGrade4"
        Me.txtAvgGrade4.Size = New System.Drawing.Size(240, 24)
        Me.txtAvgGrade4.TabIndex = 7
        Me.txtAvgGrade4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAvgRow5
        '
        Me.lblAvgRow5.AutoSize = True
        Me.lblAvgRow5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgRow5.Location = New System.Drawing.Point(17, 112)
        Me.lblAvgRow5.Name = "lblAvgRow5"
        Me.lblAvgRow5.Size = New System.Drawing.Size(18, 20)
        Me.lblAvgRow5.TabIndex = 8
        Me.lblAvgRow5.Text = "5"
        '
        'txtAvgGrade3
        '
        Me.txtAvgGrade3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvgGrade3.Location = New System.Drawing.Point(62, 58)
        Me.txtAvgGrade3.Name = "txtAvgGrade3"
        Me.txtAvgGrade3.Size = New System.Drawing.Size(240, 24)
        Me.txtAvgGrade3.TabIndex = 5
        Me.txtAvgGrade3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAvgRow6
        '
        Me.lblAvgRow6.AutoSize = True
        Me.lblAvgRow6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgRow6.Location = New System.Drawing.Point(17, 138)
        Me.lblAvgRow6.Name = "lblAvgRow6"
        Me.lblAvgRow6.Size = New System.Drawing.Size(18, 20)
        Me.lblAvgRow6.TabIndex = 10
        Me.lblAvgRow6.Text = "6"
        '
        'txtAvgGrade2
        '
        Me.txtAvgGrade2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvgGrade2.Location = New System.Drawing.Point(62, 32)
        Me.txtAvgGrade2.Name = "txtAvgGrade2"
        Me.txtAvgGrade2.Size = New System.Drawing.Size(240, 24)
        Me.txtAvgGrade2.TabIndex = 3
        Me.txtAvgGrade2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAvgRow7
        '
        Me.lblAvgRow7.AutoSize = True
        Me.lblAvgRow7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgRow7.Location = New System.Drawing.Point(17, 164)
        Me.lblAvgRow7.Name = "lblAvgRow7"
        Me.lblAvgRow7.Size = New System.Drawing.Size(18, 20)
        Me.lblAvgRow7.TabIndex = 12
        Me.lblAvgRow7.Text = "7"
        '
        'txtAvgGrade1
        '
        Me.txtAvgGrade1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAvgGrade1.Location = New System.Drawing.Point(62, 4)
        Me.txtAvgGrade1.Name = "txtAvgGrade1"
        Me.txtAvgGrade1.Size = New System.Drawing.Size(240, 24)
        Me.txtAvgGrade1.TabIndex = 1
        Me.txtAvgGrade1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAvgRow8
        '
        Me.lblAvgRow8.AutoSize = True
        Me.lblAvgRow8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgRow8.Location = New System.Drawing.Point(17, 190)
        Me.lblAvgRow8.Name = "lblAvgRow8"
        Me.lblAvgRow8.Size = New System.Drawing.Size(18, 20)
        Me.lblAvgRow8.TabIndex = 14
        Me.lblAvgRow8.Text = "8"
        '
        'SettingsTab
        '
        Me.SettingsTab.Controls.Add(Me.btnResetChanges)
        Me.SettingsTab.Controls.Add(Me.btnSaveChanges)
        Me.SettingsTab.Controls.Add(Me.btnChangeColor)
        Me.SettingsTab.Controls.Add(Me.txtChangeName)
        Me.SettingsTab.Controls.Add(Me.Label1)
        Me.SettingsTab.Controls.Add(Me.lblNameOfCalc)
        Me.SettingsTab.Location = New System.Drawing.Point(4, 22)
        Me.SettingsTab.Name = "SettingsTab"
        Me.SettingsTab.Size = New System.Drawing.Size(332, 425)
        Me.SettingsTab.TabIndex = 3
        Me.SettingsTab.Text = "Settings"
        Me.SettingsTab.UseVisualStyleBackColor = True
        '
        'btnResetChanges
        '
        Me.btnResetChanges.Location = New System.Drawing.Point(140, 261)
        Me.btnResetChanges.Name = "btnResetChanges"
        Me.btnResetChanges.Size = New System.Drawing.Size(98, 23)
        Me.btnResetChanges.TabIndex = 6
        Me.btnResetChanges.Text = "Reset Changes"
        Me.btnResetChanges.UseVisualStyleBackColor = True
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.Location = New System.Drawing.Point(36, 261)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(98, 23)
        Me.btnSaveChanges.TabIndex = 5
        Me.btnSaveChanges.Text = "Save Changes"
        Me.btnSaveChanges.UseVisualStyleBackColor = True
        '
        'btnChangeColor
        '
        Me.btnChangeColor.BackgroundImage = CType(resources.GetObject("btnChangeColor.BackgroundImage"), System.Drawing.Image)
        Me.btnChangeColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnChangeColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangeColor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnChangeColor.Location = New System.Drawing.Point(168, 48)
        Me.btnChangeColor.Name = "btnChangeColor"
        Me.btnChangeColor.Size = New System.Drawing.Size(85, 23)
        Me.btnChangeColor.TabIndex = 2
        Me.btnChangeColor.Text = "Change Color"
        Me.btnChangeColor.UseVisualStyleBackColor = True
        '
        'txtChangeName
        '
        Me.txtChangeName.Location = New System.Drawing.Point(168, 15)
        Me.txtChangeName.Name = "txtChangeName"
        Me.txtChangeName.Size = New System.Drawing.Size(153, 20)
        Me.txtChangeName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Change Text Color:"
        '
        'lblNameOfCalc
        '
        Me.lblNameOfCalc.AutoSize = True
        Me.lblNameOfCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameOfCalc.Location = New System.Drawing.Point(14, 15)
        Me.lblNameOfCalc.Name = "lblNameOfCalc"
        Me.lblNameOfCalc.Size = New System.Drawing.Size(148, 20)
        Me.lblNameOfCalc.TabIndex = 0
        Me.lblNameOfCalc.Text = "Name of Calculator:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(373, 485)
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'GradeCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(373, 485)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(389, 524)
        Me.MinimumSize = New System.Drawing.Size(389, 524)
        Me.Name = "GradeCalculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grade Calculator"
        Me.TabControl1.ResumeLayout(False)
        Me.WeightTab.ResumeLayout(False)
        Me.WeightTab.PerformLayout()
        Me.WeightPanel.ResumeLayout(False)
        Me.WeightPanel.PerformLayout()
        Me.PointsTab.ResumeLayout(False)
        Me.PointsTab.PerformLayout()
        Me.PointsPanel.ResumeLayout(False)
        Me.PointsPanel.PerformLayout()
        Me.AverageTab.ResumeLayout(False)
        Me.AverageTab.PerformLayout()
        Me.AvgPanel.ResumeLayout(False)
        Me.AvgPanel.PerformLayout()
        Me.SettingsTab.ResumeLayout(False)
        Me.SettingsTab.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents WeightTab As TabPage
    Friend WithEvents PointsTab As TabPage
    Friend WithEvents AverageTab As TabPage
    Friend WithEvents Weight As Label
    Friend WithEvents Grade As Label
    Friend WithEvents RowNumber As Label
    Friend WithEvents lblDisplayGrade As Label
    Friend WithEvents lblLetterGrade As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblDisplayPointGrade As Label
    Friend WithEvents lblDisplayPointLetterGrade As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents lblAvgGrade As Label
    Friend WithEvents lblAvgLetterGrade As Label
    Friend WithEvents btnAvgReset As Button
    Friend WithEvents btnAvgCalculate As Button
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnPointReset As Button
    Friend WithEvents btnPointCalculate As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnAddRowWeight As Button
    Friend WithEvents btnAddRowPoints As Button
    Friend WithEvents btnAddRowAvg As Button
    Friend WithEvents WeightPanel As Panel
    Friend WithEvents lblRow2 As Label
    Friend WithEvents txtWeight7 As TextBox
    Friend WithEvents txtWeight8 As TextBox
    Friend WithEvents lblRow1 As Label
    Friend WithEvents txtWeight6 As TextBox
    Friend WithEvents txtWeight5 As TextBox
    Friend WithEvents lblRow3 As Label
    Friend WithEvents txtWeight4 As TextBox
    Friend WithEvents lblRow4 As Label
    Friend WithEvents txtWeight3 As TextBox
    Friend WithEvents lblRow5 As Label
    Friend WithEvents txtWeight2 As TextBox
    Friend WithEvents lblRow6 As Label
    Friend WithEvents txtWeight1 As TextBox
    Friend WithEvents lblRow7 As Label
    Friend WithEvents txtGrade8 As TextBox
    Friend WithEvents lblRow8 As Label
    Friend WithEvents txtGrade7 As TextBox
    Friend WithEvents txtGrade1 As TextBox
    Friend WithEvents txtGrade6 As TextBox
    Friend WithEvents txtGrade2 As TextBox
    Friend WithEvents txtGrade5 As TextBox
    Friend WithEvents txtGrade3 As TextBox
    Friend WithEvents txtGrade4 As TextBox
    Friend WithEvents AvgPanel As Panel
    Friend WithEvents txtAvgGrade8 As TextBox
    Friend WithEvents lblAvgRow1 As Label
    Friend WithEvents txtAvgGrade7 As TextBox
    Friend WithEvents lblAvgRow2 As Label
    Friend WithEvents txtAvgGrade6 As TextBox
    Friend WithEvents lblAvgRow3 As Label
    Friend WithEvents txtAvgGrade5 As TextBox
    Friend WithEvents lblAvgRow4 As Label
    Friend WithEvents txtAvgGrade4 As TextBox
    Friend WithEvents lblAvgRow5 As Label
    Friend WithEvents txtAvgGrade3 As TextBox
    Friend WithEvents lblAvgRow6 As Label
    Friend WithEvents txtAvgGrade2 As TextBox
    Friend WithEvents lblAvgRow7 As Label
    Friend WithEvents txtAvgGrade1 As TextBox
    Friend WithEvents lblAvgRow8 As Label
    Friend WithEvents PointsPanel As Panel
    Friend WithEvents txtTotalPoints7 As TextBox
    Friend WithEvents lblPointsRow1 As Label
    Friend WithEvents txtTotalPoints8 As TextBox
    Friend WithEvents lblPointsRow2 As Label
    Friend WithEvents txtTotalPoints6 As TextBox
    Friend WithEvents lblPointsRow3 As Label
    Friend WithEvents txtTotalPoints5 As TextBox
    Friend WithEvents lblPointsRow4 As Label
    Friend WithEvents txtTotalPoints4 As TextBox
    Friend WithEvents lblPointsRow5 As Label
    Friend WithEvents txtTotalPoints3 As TextBox
    Friend WithEvents lblPointsRow6 As Label
    Friend WithEvents txtTotalPoints2 As TextBox
    Friend WithEvents lblPointsRow7 As Label
    Friend WithEvents txtTotalPoints1 As TextBox
    Friend WithEvents lblPointsRow8 As Label
    Friend WithEvents txtEarnedPoints8 As TextBox
    Friend WithEvents txtEarnedPoints1 As TextBox
    Friend WithEvents txtEarnedPoints7 As TextBox
    Friend WithEvents txtEarnedPoints2 As TextBox
    Friend WithEvents txtEarnedPoints6 As TextBox
    Friend WithEvents txtEarnedPoints3 As TextBox
    Friend WithEvents txtEarnedPoints5 As TextBox
    Friend WithEvents txtEarnedPoints4 As TextBox
    Friend WithEvents SettingsTab As TabPage
    Friend WithEvents btnChangeColor As Button
    Friend WithEvents txtChangeName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNameOfCalc As Label
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents btnSaveChanges As Button
    Friend WithEvents btnResetChanges As Button
End Class
