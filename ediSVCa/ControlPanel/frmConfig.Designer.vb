<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfig
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfig))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Settings")
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddMonitorFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiceController1 = New System.ServiceProcess.ServiceController()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Tree = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PropertyGrid = New System.Windows.Forms.PropertyGrid()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Abandon = New System.Windows.Forms.Button()
        Me.Save = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_start = New System.Windows.Forms.Button()
        Me.btn_stop = New System.Windows.Forms.Button()
        Me.btn_pause = New System.Windows.Forms.Button()
        Me.btn_restart = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteMonitorFolderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddMonitorFolderToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(179, 26)
        '
        'AddMonitorFolderToolStripMenuItem
        '
        Me.AddMonitorFolderToolStripMenuItem.Name = "AddMonitorFolderToolStripMenuItem"
        Me.AddMonitorFolderToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.AddMonitorFolderToolStripMenuItem.Text = "Add Monitor Folder"
        '
        'ServiceController1
        '
        Me.ServiceController1.ServiceName = "ediSVC"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.SplitContainer1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(656, 481)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(650, 62)
        Me.Panel1.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(155, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(495, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 121)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Tree)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.PropertyGrid)
        Me.SplitContainer1.Size = New System.Drawing.Size(650, 307)
        Me.SplitContainer1.SplitterDistance = 300
        Me.SplitContainer1.TabIndex = 7
        '
        'Tree
        '
        Me.Tree.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tree.ImageIndex = 0
        Me.Tree.ImageList = Me.ImageList1
        Me.Tree.Location = New System.Drawing.Point(0, 0)
        Me.Tree.Name = "Tree"
        TreeNode1.ContextMenuStrip = Me.ContextMenuStrip1
        TreeNode1.Name = "root"
        TreeNode1.Text = "Settings"
        Me.Tree.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1})
        Me.Tree.SelectedImageIndex = 0
        Me.Tree.Size = New System.Drawing.Size(300, 307)
        Me.Tree.TabIndex = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "cog.ico")
        Me.ImageList1.Images.SetKeyName(1, "oData.ico")
        Me.ImageList1.Images.SetKeyName(2, "folder2.ico")
        '
        'PropertyGrid
        '
        Me.PropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PropertyGrid.Location = New System.Drawing.Point(0, 0)
        Me.PropertyGrid.Name = "PropertyGrid"
        Me.PropertyGrid.Size = New System.Drawing.Size(346, 307)
        Me.PropertyGrid.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Abandon, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Save, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(453, 434)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(200, 44)
        Me.TableLayoutPanel2.TabIndex = 8
        '
        'Abandon
        '
        Me.Abandon.Dock = System.Windows.Forms.DockStyle.Right
        Me.Abandon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Abandon.Location = New System.Drawing.Point(103, 3)
        Me.Abandon.Name = "Abandon"
        Me.Abandon.Size = New System.Drawing.Size(94, 38)
        Me.Abandon.TabIndex = 8
        Me.Abandon.Text = "Close"
        Me.Abandon.UseVisualStyleBackColor = True
        '
        'Save
        '
        Me.Save.Dock = System.Windows.Forms.DockStyle.Right
        Me.Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save.Location = New System.Drawing.Point(3, 3)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(94, 38)
        Me.Save.TabIndex = 7
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 6
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btn_start, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btn_stop, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btn_pause, 4, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btn_restart, 5, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(240, 75)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(3, 7, 3, 6)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(413, 37)
        Me.TableLayoutPanel3.TabIndex = 9
        '
        'btn_start
        '
        Me.btn_start.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btn_start.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_start.ImageIndex = 0
        Me.btn_start.ImageList = Me.ImageList2
        Me.btn_start.Location = New System.Drawing.Point(268, 3)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(31, 31)
        Me.btn_start.TabIndex = 0
        Me.btn_start.UseVisualStyleBackColor = True
        '
        'btn_stop
        '
        Me.btn_stop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stop.ImageIndex = 1
        Me.btn_stop.ImageList = Me.ImageList2
        Me.btn_stop.Location = New System.Drawing.Point(305, 3)
        Me.btn_stop.Name = "btn_stop"
        Me.btn_stop.Size = New System.Drawing.Size(31, 31)
        Me.btn_stop.TabIndex = 1
        Me.btn_stop.UseVisualStyleBackColor = True
        '
        'btn_pause
        '
        Me.btn_pause.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pause.ImageIndex = 2
        Me.btn_pause.ImageList = Me.ImageList2
        Me.btn_pause.Location = New System.Drawing.Point(342, 3)
        Me.btn_pause.Name = "btn_pause"
        Me.btn_pause.Size = New System.Drawing.Size(31, 31)
        Me.btn_pause.TabIndex = 2
        Me.btn_pause.UseVisualStyleBackColor = True
        '
        'btn_restart
        '
        Me.btn_restart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_restart.ImageIndex = 3
        Me.btn_restart.ImageList = Me.ImageList2
        Me.btn_restart.Location = New System.Drawing.Point(379, 3)
        Me.btn_restart.Name = "btn_restart"
        Me.btn_restart.Size = New System.Drawing.Size(31, 31)
        Me.btn_restart.TabIndex = 3
        Me.btn_restart.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 37)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Service is:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(109, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 37)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Label2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteMonitorFolderToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(190, 26)
        '
        'DeleteMonitorFolderToolStripMenuItem
        '
        Me.DeleteMonitorFolderToolStripMenuItem.Name = "DeleteMonitorFolderToolStripMenuItem"
        Me.DeleteMonitorFolderToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.DeleteMonitorFolderToolStripMenuItem.Text = "Delete Monitor Folder"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "play-circle-line.png")
        Me.ImageList2.Images.SetKeyName(1, "stop-circle-line.png")
        Me.ImageList2.Images.SetKeyName(2, "pause-circle-line.png")
        Me.ImageList2.Images.SetKeyName(3, "refresh-fill.png")
        '
        'frmConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 481)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConfig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MedatechUK EDI | Filesystem Monitor"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ServiceController1 As ServiceProcess.ServiceController
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Tree As TreeView
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents PropertyGrid As PropertyGrid
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Abandon As Button
    Friend WithEvents Save As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents AddMonitorFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents DeleteMonitorFolderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btn_start As Button
    Friend WithEvents btn_stop As Button
    Friend WithEvents btn_pause As Button
    Friend WithEvents btn_restart As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ImageList2 As ImageList
End Class
