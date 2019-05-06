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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptimizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptimizeSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Databox1 = New System.Windows.Forms.DataGridView()
        Me.G_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.G_X = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.G_Y = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.G_Z = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.G_I = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.G_J = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.G_R = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.G_F = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.progressor1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Databox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.progressor1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 470)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(850, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(850, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save as"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(109, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolToolStripMenuItem
        '
        Me.ToolToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptimizeToolStripMenuItem, Me.OptimizeSettingsToolStripMenuItem})
        Me.ToolToolStripMenuItem.Name = "ToolToolStripMenuItem"
        Me.ToolToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ToolToolStripMenuItem.Text = "Tools"
        '
        'OptimizeToolStripMenuItem
        '
        Me.OptimizeToolStripMenuItem.Name = "OptimizeToolStripMenuItem"
        Me.OptimizeToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.OptimizeToolStripMenuItem.Text = "Optimize"
        '
        'OptimizeSettingsToolStripMenuItem
        '
        Me.OptimizeSettingsToolStripMenuItem.Name = "OptimizeSettingsToolStripMenuItem"
        Me.OptimizeSettingsToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.OptimizeSettingsToolStripMenuItem.Text = "Optimize settings"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Databox1
        '
        Me.Databox1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Databox1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Databox1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.G_code, Me.G_X, Me.G_Y, Me.G_Z, Me.G_I, Me.G_J, Me.G_R, Me.G_F})
        Me.Databox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Databox1.Location = New System.Drawing.Point(0, 24)
        Me.Databox1.Name = "Databox1"
        Me.Databox1.Size = New System.Drawing.Size(850, 446)
        Me.Databox1.TabIndex = 2
        '
        'G_code
        '
        Me.G_code.HeaderText = "G-Code"
        Me.G_code.Name = "G_code"
        Me.G_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'G_X
        '
        Me.G_X.HeaderText = "X"
        Me.G_X.Name = "G_X"
        Me.G_X.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'G_Y
        '
        Me.G_Y.HeaderText = "Y"
        Me.G_Y.Name = "G_Y"
        Me.G_Y.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'G_Z
        '
        Me.G_Z.HeaderText = "Z"
        Me.G_Z.Name = "G_Z"
        Me.G_Z.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'G_I
        '
        Me.G_I.HeaderText = "I"
        Me.G_I.Name = "G_I"
        Me.G_I.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'G_J
        '
        Me.G_J.HeaderText = "J"
        Me.G_J.Name = "G_J"
        Me.G_J.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'G_R
        '
        Me.G_R.HeaderText = "R"
        Me.G_R.Name = "G_R"
        Me.G_R.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'G_F
        '
        Me.G_F.HeaderText = "F"
        Me.G_F.Name = "G_F"
        Me.G_F.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'progressor1
        '
        Me.progressor1.Name = "progressor1"
        Me.progressor1.Size = New System.Drawing.Size(100, 16)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(850, 492)
        Me.Controls.Add(Me.Databox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Gcode Unifier"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Databox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Databox1 As DataGridView
    Friend WithEvents OptimizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptimizeSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents G_code As DataGridViewTextBoxColumn
    Friend WithEvents G_X As DataGridViewTextBoxColumn
    Friend WithEvents G_Y As DataGridViewTextBoxColumn
    Friend WithEvents G_Z As DataGridViewTextBoxColumn
    Friend WithEvents G_I As DataGridViewTextBoxColumn
    Friend WithEvents G_J As DataGridViewTextBoxColumn
    Friend WithEvents G_R As DataGridViewTextBoxColumn
    Friend WithEvents G_F As DataGridViewTextBoxColumn
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents progressor1 As ToolStripProgressBar
End Class
