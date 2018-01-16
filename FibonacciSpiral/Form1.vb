Public Class Form1
    'Robert Foster
    'January 2018
    '
    'Program generates the fibonacci sequence and draws a fibonacci spiral
    '
    'f holds fibonacci sequence
    'x,y are location where spiral originates for box n and form spiral coordinates
    'xr, yr are coordinates for VB to draw rectangle for each box
    Dim f(), x(), y(), xb(), yb(), xr(), yr(), wb(), wr(), startAngle(), sweepAngle() As Integer
    Dim numberOfSequenceElements = 5
    Dim xCenter As Integer
    Dim yCenter As Integer
    Dim drawFibonacciBoxes As Boolean = True
    Dim drawSpiralBoxes As Boolean = False
    Dim drawSpiral As Boolean = True
    Dim drawArcs As Boolean = False
    Dim scaleFactorMax As Integer = 100
    Dim fillSpiralBoxes As Boolean = False

    Dim scaleFactor As Integer = 10 'box of length 1 will be scaled to 10 pixels
    Dim graphics As System.Drawing.Graphics

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        Me.UpdateStyles()
        VScrollBar1.Value = scaleFactor
        xCenter = Me.Width / 2
        yCenter = Me.Height / 2
        updateMenu()
        fibonacci()
    End Sub

    'creates an array of fibonacci numbers and the coordinates for the arcs forming the spiral
    Private Sub fibonacci()
        Dim i, d As Integer

        ReDim f(numberOfSequenceElements - 1)
        ReDim x(numberOfSequenceElements - 1)
        ReDim y(numberOfSequenceElements - 1)
        ReDim xb(numberOfSequenceElements - 1)
        ReDim yb(numberOfSequenceElements - 1)
        ReDim xr(numberOfSequenceElements - 1)
        ReDim yr(numberOfSequenceElements - 1)
        ReDim wb(numberOfSequenceElements - 1)
        ReDim wr(numberOfSequenceElements - 1)
        ReDim startAngle(numberOfSequenceElements - 1)
        ReDim sweepAngle(numberOfSequenceElements - 1)

        f(0) = 1
        f(1) = 1
        x(0) = xCenter
        y(0) = yCenter

        'create array of fibonacci numbers
        For i = 2 To numberOfSequenceElements - 1
            f(i) = f(i - 1) + f(i - 2)
        Next

        listSequence.Items.Clear()
        listSequence.Items.Add("Fibonacci Sequence")
        For i = 0 To numberOfSequenceElements - 1
            listSequence.Items.Add(f(i))
        Next

        For i = 1 To numberOfSequenceElements - 1
            'calculate spiral coordinates 
            d = i Mod 4
            Try
                Select Case d
                    Case 1 'go up to left
                        'x(i) = x(i - 1) - scaleFactor* f(i)
                        x(i) = x(i - 1) - scaleFactor * f(i - 1)
                        y(i) = y(i - 1) - scaleFactor * f(i - 1)
                    Case 2 'go down to left
                        x(i) = x(i - 1) - scaleFactor * f(i - 1)
                        y(i) = y(i - 1) + scaleFactor * f(i - 1)
                    Case 3 'go down to right
                        x(i) = x(i - 1) + scaleFactor * f(i - 1)
                        y(i) = y(i - 1) + scaleFactor * f(i - 1)
                    Case 0 'go up to right
                        x(i) = x(i - 1) + scaleFactor * f(i - 1)
                        y(i) = y(i - 1) - scaleFactor * f(i - 1)
                End Select
            Catch ex As OverflowException
            End Try
        Next

        'calculate coordinates of boxes with length of size = fibonacci(i)
        For i = 1 To numberOfSequenceElements - 1
            d = i Mod 4
            Try
                Select Case d
                    Case 1
                        xb(i) = x(i - 1) - scaleFactor * f(i - 1)
                        yb(i) = y(i)
                    Case 2
                        xb(i) = x(i - 1) - scaleFactor * f(i - 1)
                        yb(i) = y(i - 1)
                    Case 3
                        xb(i) = x(i - 1)
                        yb(i) = y(i - 1)
                    Case 0 'go up to right
                        xb(i) = x(i - 1)
                        yb(i) = y(i)
                End Select
                wb(i) = scaleFactor * f(i - 1)
            Catch ex As OverflowException

            End Try
        Next

        'calculate coordinates of boxes with length of size twice fibonacci(i) for drawing vb arcs
        For i = 1 To numberOfSequenceElements - 1
            d = i Mod 4
            Try
                Select Case d
                    Case 1
                        xr(i) = x(i - 1) - 2 * scaleFactor * f(i - 1)
                        yr(i) = y(i)
                        startAngle(i) = 0
                        sweepAngle(i) = -90
                    Case 2
                        'xr(i) = x(i)
                        'yr(i) = y(i - 1)
                        xr(i) = x(i - 1) - scaleFactor * f(i - 1)
                        yr(i) = yr(i - 1)
                        startAngle(i) = -90
                        sweepAngle(i) = -90
                    Case 3
                        xr(i) = x(i - 1)
                        yr(i) = y(i) - 2 * scaleFactor * f(i - 1)
                        startAngle(i) = 180
                        sweepAngle(i) = -90
                    Case 0 'go up to right
                        xr(i) = x(i) - 2 * scaleFactor * f(i - 1)
                        yr(i) = y(i) - scaleFactor * f(i - 1)
                        startAngle(i) = 90
                        sweepAngle(i) = -90
                End Select
                wr(i) = 2 * scaleFactor * f(i - 1)
            Catch ex As OverflowException
            End Try
        Next

        Dim someStuff As String
        listCoord.Items.Clear()
        For i = 1 To numberOfSequenceElements - 1
            someStuff = i & ": (" & xb(i) & ", " & yb(i) & ") (" & xr(i) & ", " & yr(i) & ") "
            listCoord.Items.Add(someStuff)
        Next
    End Sub

    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        graphics = e.Graphics
        Dim bluePen As New Pen(Color.Blue, 2)
        Dim spiralPen As New Pen(Color.Green, 3)
        Dim brush1 As New SolidBrush(Color.LightSkyBlue)
        Dim brush2 As New SolidBrush(Color.CornflowerBlue)
        Dim brush3 As New SolidBrush(Color.Blue)
        Dim brush4 As New SolidBrush(Color.DarkBlue)

        If drawArcs Then
            Dim pointarray As ArrayList = New ArrayList

            Dim i As Integer
            For i = 0 To numberOfSequenceElements - 1
                pointarray.Add(New Point(x(i), y(i)))
            Next

            Dim pointarray2b() As Point = pointarray.ToArray(pointarray(0).GetType())
            graphics.DrawCurve(Pens.Black, pointarray2b)
        End If

        If drawFibonacciBoxes Then
            For i = 1 To numberOfSequenceElements - 1
                graphics.DrawRectangle(bluePen, xb(i), yb(i), wb(i), wb(i))
            Next
        End If

        If drawSpiralBoxes Then
            For i = 1 To numberOfSequenceElements - 1
                If fillSpiralBoxes Then

                Else
                    graphics.DrawRectangle(Pens.Red, xr(i), yr(i), wr(i), wr(i))
                End If
            Next
        End If

        If drawSpiral Then
            For i = 1 To numberOfSequenceElements - 1
                graphics.DrawArc(spiralPen, xr(i), yr(i), wr(i), wr(i), startAngle(i), sweepAngle(i))
            Next
        End If
    End Sub

    Private Sub Form1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        xCenter = e.X
        yCenter = e.Y
        fibonacci()
        Me.Refresh()
    End Sub

    Private Sub Form1_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseWheel
        scaleFactor = (scaleFactor + e.Delta) / 10
        If scaleFactor < 0 Then
            scaleFactor = 1
        ElseIf scaleFactor > scaleFactorMax Then
            scaleFactor = scaleFactorMax
        End If
        fibonacci()
        Me.Refresh()
    End Sub

    Private Sub VScrollBar1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles VScrollBar1.Scroll
        scaleFactor = VScrollBar1.Value
        If scaleFactor < 0 Then
            scaleFactor = 1
        ElseIf scaleFactor > scaleFactorMax Then
            scaleFactor = scaleFactorMax
        End If
        fibonacci()
        Me.Refresh()
    End Sub

    Private Sub VScrollBar2_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles VScrollBar2.Scroll
        numberOfSequenceElements = VScrollBar2.Value
        fibonacci()
        Me.Refresh()
    End Sub

    Private Sub EndToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EndToolStripMenuItem.Click
        End
    End Sub

    Private Sub FibonacciBoxesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FibonacciBoxesToolStripMenuItem.Click
        If drawFibonacciBoxes Then
            drawFibonacciBoxes = False
        Else
            drawFibonacciBoxes = True
        End If
        updateMenu()
        Me.Refresh()
    End Sub

    Private Sub SprialBoxesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SprialBoxesToolStripMenuItem.Click
        If drawSpiralBoxes Then
            drawSpiralBoxes = False
        Else
            drawSpiralBoxes = True
        End If
        updateMenu()
        Me.Refresh()
    End Sub

    Private Sub FibonacciSpiralToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FibonacciSpiralToolStripMenuItem.Click
        If drawSpiral Then
            drawSpiral = False
        Else
            drawSpiral = True
        End If
        updateMenu()
        Me.Refresh()
    End Sub

    Private Sub ArcSpiralToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ArcSpiralToolStripMenuItem.Click
        If drawArcs Then
            drawArcs = False
        Else
            drawArcs = True
        End If
        updateMenu()
        Me.Refresh()
    End Sub

    Private Sub ShowSequenceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowSequenceToolStripMenuItem.Click
        If listSequence.Visible Then
            listSequence.Visible = False
        Else
            listSequence.Visible = True
        End If
        updateMenu()
        Me.Refresh()
    End Sub

    Private Sub ShowCoordinatesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowCoordinatesToolStripMenuItem.Click
        If listCoord.Visible Then
            listCoord.Visible = False
        Else
            listCoord.Visible = True
        End If
        updateMenu()
        Me.Refresh()
    End Sub
    Private Sub updateMenu()
        ShowCoordinatesToolStripMenuItem.Checked = listCoord.Visible
        ShowSequenceToolStripMenuItem.Checked = listSequence.Visible
        ArcSpiralToolStripMenuItem.Checked = drawArcs
        FibonacciSpiralToolStripMenuItem.Checked = drawSpiral
        SprialBoxesToolStripMenuItem.Checked = drawSpiralBoxes
        FibonacciBoxesToolStripMenuItem.Checked = drawFibonacciBoxes
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        MessageBox.Show("click anywhere to re-center spiral, right slider adjusts zoom level, left slider adjusts number of terms generated")
    End Sub

End Class
