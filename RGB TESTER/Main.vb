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

        If e.Row = 1 Then
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

        If e.Row = 2 Then
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

        If e.Row = 3 Then
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

        lbl9.BackColor = Color.Gray


        lbl10.BackColor = Color.Gray

        lbl11.BackColor = Color.White

        lbl12.BackColor = Color.Yellow

        lbl13.BackColor = Color.Cyan

        lbl14.BackColor = Color.Green

        lbl15.BackColor = Color.Magenta

        lbl16.BackColor = Color.Red

        lbl17.BackColor = Color.Blue

        lbl18.BackColor = Color.Gray



        lbl19.BackColor = Color.Gray

        lbl20.BackColor = Color.White

        lbl21.BackColor = Color.Yellow

        lbl22.BackColor = Color.Cyan

        lbl23.BackColor = Color.Green

        lbl24.BackColor = Color.Magenta

        lbl25.BackColor = Color.Red

        lbl26.BackColor = Color.Blue

        lbl27.BackColor = Color.Gray



        lbl28.BackColor = Color.Gray

        lbl29.BackColor = Color.White

        lbl30.BackColor = Color.Yellow

        lbl31.BackColor = Color.Cyan

        lbl32.BackColor = Color.Green

        lbl33.BackColor = Color.Magenta

        lbl34.BackColor = Color.Red

        lbl35.BackColor = Color.Blue

        lbl36.BackColor = Color.Gray

    End Sub
End Class
