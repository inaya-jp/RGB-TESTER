Public Class Main
    ''' <summary>
    ''' SUB : パネル背景色変更処理(初期表示)
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub pnlHead_CellPaint(sender As Object, e As TableLayoutCellPaintEventArgs) Handles ColorPanel.CellPaint

        '一つおきにセルの背景色を変更する
        If e.Row = 0 Then
            If e.Column = 0 Then e.Graphics.FillRectangle(Brushes.Gray, e.CellBounds)

            If e.Column = 1 Then e.Graphics.FillRectangle(Brushes.White, e.CellBounds)

            If e.Column = 2 Then e.Graphics.FillRectangle(Brushes.Yellow, e.CellBounds)

            If e.Column = 3 Then e.Graphics.FillRectangle(Brushes.Cyan, e.CellBounds)

            If e.Column = 4 Then e.Graphics.FillRectangle(Brushes.Green, e.CellBounds)

            If e.Column = 5 Then e.Graphics.FillRectangle(Brushes.Magenta, e.CellBounds)

            If e.Column = 6 Then e.Graphics.FillRectangle(Brushes.Red, e.CellBounds)

            If e.Column = 7 Then e.Graphics.FillRectangle(Brushes.Blue, e.CellBounds)

            If e.Column = 8 Then e.Graphics.FillRectangle(Brushes.Gray, e.CellBounds)
        End If
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl1.BackColor = Color.Gray

        lbl2.BackColor = Color.White

        lbl3.BackColor = Color.Yellow

        lbl4.BackColor = Color.Cyan

        lbl5.BackColor = Color.Green

        lbl6.BackColor = Color.Magenta

        lbl7.BackColor = Color.Red

        lbl8.BackColor = Color.Blue

        lbl9.BackColor = Color.Blue

        lbl9.BackColor = Color.Gray
    End Sub
End Class
