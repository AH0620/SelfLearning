Public Class Calculator

    ''' <summary>
    ''' 表示名
    ''' </summary>
    Private monitor As String = "0"

    ''' <summary>
    ''' 計算式リスト
    ''' </summary>
    Private inputSequence As New List(Of String)()

    ''' <summary>
    ''' オールクリア
    ''' </summary>
    Private Const clearAll As String = "AC"

    ''' <summary>
    ''' クリア
    ''' </summary>
    Private Const clear As String = "C"

    ''' <summary>
    ''' 初期処理
    ''' </summary>
    ''' <param name="sender">送信元</param>
    ''' <param name="e">イベント</param>
    Private Sub Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inputSequence.Add("0")
        LblMonitor.Text = String.Join("", inputSequence)
    End Sub

    ''' <summary>
    ''' 数値ボタン押下時
    ''' </summary>
    ''' <param name="sender">送信元</param>
    ''' <param name="e">イベント</param>
    Private Sub BtnNumber_Click(sender As Object, e As EventArgs) Handles Btn0.Click, Btn1.Click, Btn2.Click, Btn3.Click, Btn4.Click, Btn5.Click, Btn6.Click, Btn7.Click, Btn8.Click, Btn9.Click
        Try
            Dim pushNumber = sender.tag.ToString()

            If inputSequence.Count = 0 Then
                inputSequence.Add(pushNumber)
                Displaying_Screen()
            End If

            If inputSequence.Count Mod 2 <> 0 Then
                '直前が数値の場合
                If inputSequence(inputSequence.Count - 1) = "0" Then
                    inputSequence(inputSequence.Count - 1) = pushNumber
                Else
                    inputSequence(inputSequence.Count - 1) &= pushNumber
                End If
            Else
                '直前が演算子の場合
                inputSequence.Add(pushNumber)
            End If
            Displaying_Screen()
        Catch ex As Exception
            Error_Screen()
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' ピリオドボタン押下時
    ''' </summary>
    ''' <param name="sender">送信元</param>
    ''' <param name="e">イベント</param>
    Private Sub BtnPeriod_Click(sender As Object, e As EventArgs) Handles BtnPeriod.Click
        Try
            If inputSequence.Count = 0 Then
                '何も入力されていない場合
                inputSequence.Add("0.")
            End If

            If inputSequence.Count Mod 2 = 1 Then
                '直前が演算子の場合
                Dim currentNum As String = inputSequence(inputSequence.Count - 1)

                If currentNum.Contains(".") Then
                    'すでにピリオドが入力されている場合
                    Return
                End If
                inputSequence(inputSequence.Count - 1) &= "."
            Else
                '直前が演算子の場合
                inputSequence.Add("0.")
            End If
            Displaying_Screen()
        Catch ex As Exception
            Error_Screen()
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' 演算子ボタン押下時
    ''' </summary>
    ''' <param name="sender">送信元</param>
    ''' <param name="e">イベント</param>
    Private Sub BtnOperator_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click, BtnSubtract.Click, BtnMultiplication.Click, BtnDivde.Click

        Try
            Dim pushNumber = sender.tag.ToString()

            If inputSequence.Count = 0 Then
                '何も入力されていない場合
                Return
            End If

            If inputSequence.Count Mod 2 = 1 Then
                '直前が数値の場合
                Dim currentNum As String = inputSequence(inputSequence.Count - 1).Last()

                If currentNum.Contains(".") Then
                    '直前がピリオドの場合
                    Return
                End If
                inputSequence.Add(pushNumber)
            Else
                '直前が演算子の場合
                inputSequence(inputSequence.Count - 1) = pushNumber
            End If
            Displaying_Screen()
        Catch ex As Exception
            Error_Screen()
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' イコールボタン押下時
    ''' </summary>
    ''' <param name="sender">送信元</param>
    ''' <param name="e">イベント</param>
    Private Sub BtnEqual_Click(sender As Object, e As EventArgs) Handles BtnEqual.Click
        Try
            Dim formulaVal = String.Join("", inputSequence)

            If inputSequence.Count Mod 2 = 0 Then
                '最後が演算子の場合
                Return
            End If

            If inputSequence.Count.ToString().Last() = (".") Then
                '最後がピリオドの場合
                Return
            End If

            Dim calculationVal = New DataTable().Compute(formulaVal, Nothing)

            inputSequence.Clear()
            inputSequence.Add(calculationVal)

            Displaying_Screen()
        Catch ex As Exception
            Error_Screen()
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' クリアボタン押下
    ''' </summary>
    ''' <param name="sender">送信元</param>
    ''' <param name="e">イベント</param>
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        Try


            Dim lastIndex = inputSequence.Count - 1

            '入力が空なら何もしない
            If lastIndex < 0 Then Return

            Dim lastItem = inputSequence(lastIndex)

            '最後の項目が演算子かどうかを判定
            Dim isOperator As Boolean = (lastItem = "+" OrElse lastItem = "-" OrElse lastItem = "*" OrElse lastItem = "/")

            If isOperator Then
                inputSequence.RemoveAt(lastIndex)
            Else
                '文字数が2文字以上なら末尾1文字を削除
                If lastItem.Length > 1 Then
                    inputSequence(lastIndex) = lastItem.Substring(0, lastItem.Length - 1)
                Else
                    '1文字だけなら要素を削除
                    inputSequence.RemoveAt(lastIndex)
                End If
            End If

            If inputSequence.Count = 0 Then
                inputSequence.Add("0")
            End If

            Displaying_Screen()
        Catch ex As Exception
            Error_Screen()
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    ''' <summary>
    ''' モニターに表示
    ''' </summary>
    Private Sub Displaying_Screen()
        Dim display As New Text.StringBuilder()

        For i As Integer = 0 To inputSequence.Count - 1
            Dim inputItem As String = inputSequence(i)

            If i Mod 2 = 1 Then
                '演算子を記号変換
                inputItem = inputItem.Replace("*", "×").Replace("/", "÷")
                display.Append(inputItem)
                Continue For
            End If

            '数値にピリオドが含まれている場合
            If inputItem.Contains(".") Then

                '小数点の位置
                Dim dotIndex As Integer = inputItem.IndexOf(".")
                '小数点より前の数値
                Dim intPart As String = inputItem.Substring(0, dotIndex)
                '小数点より後の数値
                Dim decPart As String = inputItem.Substring(dotIndex + 1)

                If IsNumeric(intPart) Then
                    intPart = FormatNumberWithComma(intPart)
                End If
                inputItem = intPart & "." & decPart
            Else
                inputItem = FormatNumberWithComma(inputItem)
            End If

            display.Append(inputItem)
        Next

        LblMonitor.Text = display.ToString()
    End Sub

    ''' <summary>
    ''' 数値をカンマ付きに変換
    ''' </summary>
    Private Function FormatNumberWithComma(value As String) As String
        If IsNumeric(value) Then
            Dim decValue As Decimal = Decimal.Parse(value)
            Return decValue.ToString("#,0")
        End If
        Return value
    End Function

    ''' <summary>
    ''' エラー字の画面処理
    ''' </summary>
    Private Sub Error_Screen()
        inputSequence.Clear()
        inputSequence.Add("0")
        LblMonitor.Text = "エラー"
    End Sub
End Class
