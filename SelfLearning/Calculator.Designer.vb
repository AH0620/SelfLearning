<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calculator
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
        Btn1 = New Button()
        LblMonitor = New Label()
        Btn3 = New Button()
        Btn4 = New Button()
        Btn5 = New Button()
        Btn6 = New Button()
        Btn7 = New Button()
        Btn8 = New Button()
        Btn9 = New Button()
        Btn0 = New Button()
        BtnPeriod = New Button()
        BtnAdd = New Button()
        BtnSubtract = New Button()
        BtnMultiplication = New Button()
        BtnDivde = New Button()
        BtnEqual = New Button()
        Btn2 = New Button()
        BtnClear = New Button()
        SuspendLayout()
        ' 
        ' Btn1
        ' 
        Btn1.Location = New Point(13, 135)
        Btn1.Name = "Btn1"
        Btn1.Size = New Size(60, 60)
        Btn1.TabIndex = 0
        Btn1.Tag = "1"
        Btn1.Text = "1"
        Btn1.UseVisualStyleBackColor = True
        ' 
        ' LblMonitor
        ' 
        LblMonitor.AutoSize = True
        LblMonitor.Location = New Point(12, 32)
        LblMonitor.Name = "LblMonitor"
        LblMonitor.Size = New Size(41, 15)
        LblMonitor.TabIndex = 1
        LblMonitor.Text = "Label1"
        ' 
        ' Btn3
        ' 
        Btn3.Location = New Point(145, 135)
        Btn3.Name = "Btn3"
        Btn3.Size = New Size(60, 60)
        Btn3.TabIndex = 3
        Btn3.Tag = "3"
        Btn3.Text = "3"
        Btn3.UseVisualStyleBackColor = True
        ' 
        ' Btn4
        ' 
        Btn4.Location = New Point(13, 201)
        Btn4.Name = "Btn4"
        Btn4.Size = New Size(60, 60)
        Btn4.TabIndex = 4
        Btn4.Tag = "4"
        Btn4.Text = "4"
        Btn4.UseVisualStyleBackColor = True
        ' 
        ' Btn5
        ' 
        Btn5.Location = New Point(79, 201)
        Btn5.Name = "Btn5"
        Btn5.Size = New Size(60, 60)
        Btn5.TabIndex = 5
        Btn5.Tag = "5"
        Btn5.Text = "5"
        Btn5.UseVisualStyleBackColor = True
        ' 
        ' Btn6
        ' 
        Btn6.Location = New Point(145, 201)
        Btn6.Name = "Btn6"
        Btn6.Size = New Size(60, 60)
        Btn6.TabIndex = 6
        Btn6.Tag = "6"
        Btn6.Text = "6"
        Btn6.UseVisualStyleBackColor = True
        ' 
        ' Btn7
        ' 
        Btn7.Location = New Point(13, 267)
        Btn7.Name = "Btn7"
        Btn7.Size = New Size(60, 60)
        Btn7.TabIndex = 7
        Btn7.Tag = "7"
        Btn7.Text = "7"
        Btn7.UseVisualStyleBackColor = True
        ' 
        ' Btn8
        ' 
        Btn8.Location = New Point(79, 267)
        Btn8.Name = "Btn8"
        Btn8.Size = New Size(60, 60)
        Btn8.TabIndex = 8
        Btn8.Tag = "8"
        Btn8.Text = "8"
        Btn8.UseVisualStyleBackColor = True
        ' 
        ' Btn9
        ' 
        Btn9.Location = New Point(145, 267)
        Btn9.Name = "Btn9"
        Btn9.Size = New Size(60, 60)
        Btn9.TabIndex = 9
        Btn9.Tag = "9"
        Btn9.Text = "9"
        Btn9.UseVisualStyleBackColor = True
        ' 
        ' Btn0
        ' 
        Btn0.Location = New Point(79, 333)
        Btn0.Name = "Btn0"
        Btn0.Size = New Size(60, 60)
        Btn0.TabIndex = 10
        Btn0.Tag = "0"
        Btn0.Text = "0"
        Btn0.UseVisualStyleBackColor = True
        ' 
        ' BtnPeriod
        ' 
        BtnPeriod.Location = New Point(145, 333)
        BtnPeriod.Name = "BtnPeriod"
        BtnPeriod.Size = New Size(60, 60)
        BtnPeriod.TabIndex = 11
        BtnPeriod.Tag = "."
        BtnPeriod.Text = "."
        BtnPeriod.UseVisualStyleBackColor = True
        ' 
        ' BtnAdd
        ' 
        BtnAdd.Location = New Point(210, 69)
        BtnAdd.Name = "BtnAdd"
        BtnAdd.Size = New Size(60, 60)
        BtnAdd.TabIndex = 12
        BtnAdd.Tag = "+"
        BtnAdd.Text = "＋"
        BtnAdd.UseVisualStyleBackColor = True
        ' 
        ' BtnSubtract
        ' 
        BtnSubtract.Location = New Point(210, 135)
        BtnSubtract.Name = "BtnSubtract"
        BtnSubtract.Size = New Size(60, 60)
        BtnSubtract.TabIndex = 13
        BtnSubtract.Tag = "-"
        BtnSubtract.Text = "ー"
        BtnSubtract.UseVisualStyleBackColor = True
        ' 
        ' BtnMultiplication
        ' 
        BtnMultiplication.Location = New Point(210, 201)
        BtnMultiplication.Name = "BtnMultiplication"
        BtnMultiplication.Size = New Size(60, 60)
        BtnMultiplication.TabIndex = 14
        BtnMultiplication.Tag = "*"
        BtnMultiplication.Text = "×"
        BtnMultiplication.UseVisualStyleBackColor = True
        ' 
        ' BtnDivde
        ' 
        BtnDivde.Location = New Point(210, 267)
        BtnDivde.Name = "BtnDivde"
        BtnDivde.Size = New Size(60, 60)
        BtnDivde.TabIndex = 15
        BtnDivde.Tag = "/"
        BtnDivde.Text = "÷"
        BtnDivde.UseVisualStyleBackColor = True
        ' 
        ' BtnEqual
        ' 
        BtnEqual.Location = New Point(211, 333)
        BtnEqual.Name = "BtnEqual"
        BtnEqual.Size = New Size(60, 60)
        BtnEqual.TabIndex = 16
        BtnEqual.Tag = ""
        BtnEqual.Text = "="
        BtnEqual.UseVisualStyleBackColor = True
        ' 
        ' Btn2
        ' 
        Btn2.Location = New Point(79, 135)
        Btn2.Name = "Btn2"
        Btn2.Size = New Size(60, 60)
        Btn2.TabIndex = 2
        Btn2.Tag = "2"
        Btn2.Text = "2"
        Btn2.UseVisualStyleBackColor = True
        ' 
        ' BtnClear
        ' 
        BtnClear.Location = New Point(14, 69)
        BtnClear.Name = "BtnClear"
        BtnClear.Size = New Size(60, 60)
        BtnClear.TabIndex = 17
        BtnClear.Tag = ""
        BtnClear.Text = "AC"
        BtnClear.UseVisualStyleBackColor = True
        ' 
        ' Calculator
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(284, 403)
        Controls.Add(BtnClear)
        Controls.Add(BtnEqual)
        Controls.Add(BtnDivde)
        Controls.Add(BtnMultiplication)
        Controls.Add(BtnSubtract)
        Controls.Add(BtnAdd)
        Controls.Add(BtnPeriod)
        Controls.Add(Btn0)
        Controls.Add(Btn9)
        Controls.Add(Btn8)
        Controls.Add(Btn7)
        Controls.Add(Btn6)
        Controls.Add(Btn5)
        Controls.Add(Btn4)
        Controls.Add(Btn3)
        Controls.Add(Btn2)
        Controls.Add(LblMonitor)
        Controls.Add(Btn1)
        Name = "Calculator"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Btn1 As Button
    Friend WithEvents LblMonitor As Label
    Friend WithEvents Btn3 As Button
    Friend WithEvents Btn4 As Button
    Friend WithEvents Btn5 As Button
    Friend WithEvents Btn6 As Button
    Friend WithEvents Btn7 As Button
    Friend WithEvents Btn8 As Button
    Friend WithEvents Btn9 As Button
    Friend WithEvents Btn0 As Button
    Friend WithEvents BtnPeriod As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnSubtract As Button
    Friend WithEvents BtnMultiplication As Button
    Friend WithEvents BtnDivde As Button
    Friend WithEvents BtnEqual As Button
    Friend WithEvents Btn2 As Button
    Friend WithEvents BtnClear As Button

End Class
