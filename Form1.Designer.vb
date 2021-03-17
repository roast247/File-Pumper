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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.NumericUpDown1 = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.rbtnKilobyte = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.rbtnMegabyte = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.btnPump = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnBrowse = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(13, 36)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(153, 20)
        Me.txtFileName.TabIndex = 0
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(121, 74)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {10240, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.NumericUpDown1.Size = New System.Drawing.Size(122, 22)
        Me.NumericUpDown1.TabIndex = 1
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'rbtnKilobyte
        '
        Me.rbtnKilobyte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbtnKilobyte.Location = New System.Drawing.Point(13, 62)
        Me.rbtnKilobyte.Name = "rbtnKilobyte"
        Me.rbtnKilobyte.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.rbtnKilobyte.Size = New System.Drawing.Size(80, 20)
        Me.rbtnKilobyte.TabIndex = 2
        Me.rbtnKilobyte.Values.Text = "Kilobyte(s)"
        '
        'rbtnMegabyte
        '
        Me.rbtnMegabyte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbtnMegabyte.Location = New System.Drawing.Point(13, 88)
        Me.rbtnMegabyte.Name = "rbtnMegabyte"
        Me.rbtnMegabyte.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.rbtnMegabyte.Size = New System.Drawing.Size(90, 20)
        Me.rbtnMegabyte.TabIndex = 3
        Me.rbtnMegabyte.Values.Text = "Megabyte(s)"
        '
        'btnPump
        '
        Me.btnPump.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPump.Location = New System.Drawing.Point(79, 114)
        Me.btnPump.Name = "btnPump"
        Me.btnPump.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.btnPump.Size = New System.Drawing.Size(98, 25)
        Me.btnPump.TabIndex = 4
        Me.btnPump.Values.Text = "Pump"
        '
        'btnBrowse
        '
        Me.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowse.Location = New System.Drawing.Point(187, 36)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.btnBrowse.Size = New System.Drawing.Size(56, 20)
        Me.btnBrowse.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.TabIndex = 5
        Me.btnBrowse.Values.Text = "..."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(255, 25)
        Me.Panel1.TabIndex = 6
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Roasting_File_Pumper.My.Resources.Resources.FilePumper
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(230, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 25)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Roasting File Pumper"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(255, 152)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.btnPump)
        Me.Controls.Add(Me.rbtnMegabyte)
        Me.Controls.Add(Me.rbtnKilobyte)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.txtFileName)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFileName As TextBox
    Friend WithEvents NumericUpDown1 As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents rbtnKilobyte As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbtnMegabyte As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents btnPump As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnBrowse As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
