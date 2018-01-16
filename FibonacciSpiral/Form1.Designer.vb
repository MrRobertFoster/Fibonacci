<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.VScrollBar2 = New System.Windows.Forms.VScrollBar()
        Me.listSequence = New System.Windows.Forms.ListBox()
        Me.listCoord = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DrawFibonacciBoxesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EndToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FibonacciBoxesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SprialBoxesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FibonacciSpiralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArcSpiralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowSequenceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowCoordinatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.VScrollBar1.Location = New System.Drawing.Point(957, 28)
        Me.VScrollBar1.Minimum = 1
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(25, 927)
        Me.VScrollBar1.TabIndex = 0
        Me.VScrollBar1.Value = 10
        '
        'VScrollBar2
        '
        Me.VScrollBar2.Dock = System.Windows.Forms.DockStyle.Left
        Me.VScrollBar2.Location = New System.Drawing.Point(0, 28)
        Me.VScrollBar2.Maximum = 25
        Me.VScrollBar2.Minimum = 2
        Me.VScrollBar2.Name = "VScrollBar2"
        Me.VScrollBar2.Size = New System.Drawing.Size(25, 927)
        Me.VScrollBar2.TabIndex = 5
        Me.VScrollBar2.Value = 5
        '
        'listSequence
        '
        Me.listSequence.FormattingEnabled = True
        Me.listSequence.ItemHeight = 16
        Me.listSequence.Location = New System.Drawing.Point(51, 98)
        Me.listSequence.Name = "listSequence"
        Me.listSequence.Size = New System.Drawing.Size(195, 164)
        Me.listSequence.TabIndex = 6
        Me.listSequence.Visible = False
        '
        'listCoord
        '
        Me.listCoord.FormattingEnabled = True
        Me.listCoord.ItemHeight = 16
        Me.listCoord.Location = New System.Drawing.Point(51, 280)
        Me.listCoord.Name = "listCoord"
        Me.listCoord.Size = New System.Drawing.Size(201, 388)
        Me.listCoord.TabIndex = 11
        Me.listCoord.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DrawFibonacciBoxesToolStripMenuItem, Me.DrawToolStripMenuItem, Me.DataToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(982, 28)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DrawFibonacciBoxesToolStripMenuItem
        '
        Me.DrawFibonacciBoxesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EndToolStripMenuItem})
        Me.DrawFibonacciBoxesToolStripMenuItem.Name = "DrawFibonacciBoxesToolStripMenuItem"
        Me.DrawFibonacciBoxesToolStripMenuItem.Size = New System.Drawing.Size(78, 24)
        Me.DrawFibonacciBoxesToolStripMenuItem.Text = "Program"
        '
        'EndToolStripMenuItem
        '
        Me.EndToolStripMenuItem.Name = "EndToolStripMenuItem"
        Me.EndToolStripMenuItem.Size = New System.Drawing.Size(103, 24)
        Me.EndToolStripMenuItem.Text = "End"
        '
        'DrawToolStripMenuItem
        '
        Me.DrawToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FibonacciBoxesToolStripMenuItem, Me.SprialBoxesToolStripMenuItem, Me.FibonacciSpiralToolStripMenuItem, Me.ArcSpiralToolStripMenuItem})
        Me.DrawToolStripMenuItem.Name = "DrawToolStripMenuItem"
        Me.DrawToolStripMenuItem.Size = New System.Drawing.Size(56, 24)
        Me.DrawToolStripMenuItem.Text = "Draw"
        '
        'FibonacciBoxesToolStripMenuItem
        '
        Me.FibonacciBoxesToolStripMenuItem.Name = "FibonacciBoxesToolStripMenuItem"
        Me.FibonacciBoxesToolStripMenuItem.Size = New System.Drawing.Size(231, 24)
        Me.FibonacciBoxesToolStripMenuItem.Text = "Fibonacci Boxes"
        '
        'SprialBoxesToolStripMenuItem
        '
        Me.SprialBoxesToolStripMenuItem.Name = "SprialBoxesToolStripMenuItem"
        Me.SprialBoxesToolStripMenuItem.Size = New System.Drawing.Size(231, 24)
        Me.SprialBoxesToolStripMenuItem.Text = "Spiral Boxes(drawArc)"
        '
        'FibonacciSpiralToolStripMenuItem
        '
        Me.FibonacciSpiralToolStripMenuItem.Name = "FibonacciSpiralToolStripMenuItem"
        Me.FibonacciSpiralToolStripMenuItem.Size = New System.Drawing.Size(231, 24)
        Me.FibonacciSpiralToolStripMenuItem.Text = "Fibonacci Spiral"
        '
        'ArcSpiralToolStripMenuItem
        '
        Me.ArcSpiralToolStripMenuItem.Name = "ArcSpiralToolStripMenuItem"
        Me.ArcSpiralToolStripMenuItem.Size = New System.Drawing.Size(231, 24)
        Me.ArcSpiralToolStripMenuItem.Text = "Arc Spiral (less precise)"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowSequenceToolStripMenuItem, Me.ShowCoordinatesToolStripMenuItem})
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.DataToolStripMenuItem.Text = "Data"
        '
        'ShowSequenceToolStripMenuItem
        '
        Me.ShowSequenceToolStripMenuItem.Name = "ShowSequenceToolStripMenuItem"
        Me.ShowSequenceToolStripMenuItem.Size = New System.Drawing.Size(198, 24)
        Me.ShowSequenceToolStripMenuItem.Text = "Show Sequence"
        '
        'ShowCoordinatesToolStripMenuItem
        '
        Me.ShowCoordinatesToolStripMenuItem.Name = "ShowCoordinatesToolStripMenuItem"
        Me.ShowCoordinatesToolStripMenuItem.Size = New System.Drawing.Size(198, 24)
        Me.ShowCoordinatesToolStripMenuItem.Text = "Show Coordinates"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 955)
        Me.Controls.Add(Me.listCoord)
        Me.Controls.Add(Me.listSequence)
        Me.Controls.Add(Me.VScrollBar2)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Fibonacci Spiral Generator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VScrollBar1 As System.Windows.Forms.VScrollBar
    Friend WithEvents VScrollBar2 As System.Windows.Forms.VScrollBar
    Friend WithEvents listSequence As System.Windows.Forms.ListBox
    Friend WithEvents listCoord As System.Windows.Forms.ListBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DrawFibonacciBoxesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EndToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DrawToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FibonacciBoxesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SprialBoxesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FibonacciSpiralToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArcSpiralToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowSequenceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowCoordinatesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
