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
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("oData Service", 6, 6)
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("File Servers", 1, 1)
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Run Modes", 2, 2)
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Configuration", 0, 0, New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode6, TreeNode7})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfig))
        Me.ServerContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddServerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModeContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Tree = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PropertyGrid = New System.Windows.Forms.PropertyGrid()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ActContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SendActionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReceiveActionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModeActContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServerItemContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteServerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenameServerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServerContextMenu.SuspendLayout()
        Me.ModeContextMenu.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ActContextMenu.SuspendLayout()
        Me.ModeActContextMenu.SuspendLayout()
        Me.ServerItemContextMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'ServerContextMenu
        '
        Me.ServerContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddServerToolStripMenuItem})
        Me.ServerContextMenu.Name = "ServerContextMenu"
        Me.ServerContextMenu.Size = New System.Drawing.Size(132, 26)
        '
        'AddServerToolStripMenuItem
        '
        Me.AddServerToolStripMenuItem.Name = "AddServerToolStripMenuItem"
        Me.AddServerToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.AddServerToolStripMenuItem.Text = "Add Server"
        '
        'ModeContextMenu
        '
        Me.ModeContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddModeToolStripMenuItem})
        Me.ModeContextMenu.Name = "ModeContextMenu"
        Me.ModeContextMenu.Size = New System.Drawing.Size(131, 26)
        '
        'AddModeToolStripMenuItem
        '
        Me.AddModeToolStripMenuItem.Name = "AddModeToolStripMenuItem"
        Me.AddModeToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.AddModeToolStripMenuItem.Text = "Add Mode"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.SplitContainer1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(681, 492)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 71)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Tree)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.PropertyGrid)
        Me.SplitContainer1.Size = New System.Drawing.Size(675, 368)
        Me.SplitContainer1.SplitterDistance = 350
        Me.SplitContainer1.TabIndex = 1
        '
        'Tree
        '
        Me.Tree.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tree.ImageIndex = 0
        Me.Tree.ImageList = Me.ImageList1
        Me.Tree.Indent = 5
        Me.Tree.LabelEdit = True
        Me.Tree.Location = New System.Drawing.Point(0, 0)
        Me.Tree.Name = "Tree"
        TreeNode5.ImageIndex = 6
        TreeNode5.Name = "oDataNode"
        TreeNode5.SelectedImageIndex = 6
        TreeNode5.Text = "oData Service"
        TreeNode6.ContextMenuStrip = Me.ServerContextMenu
        TreeNode6.ImageIndex = 1
        TreeNode6.Name = "NodeServer"
        TreeNode6.SelectedImageIndex = 1
        TreeNode6.Text = "File Servers"
        TreeNode7.ContextMenuStrip = Me.ModeContextMenu
        TreeNode7.ImageIndex = 2
        TreeNode7.Name = "nodeAct"
        TreeNode7.SelectedImageIndex = 2
        TreeNode7.Text = "Run Modes"
        TreeNode8.ImageIndex = 0
        TreeNode8.Name = "nodeMain"
        TreeNode8.SelectedImageIndex = 0
        TreeNode8.Text = "Configuration"
        Me.Tree.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode8})
        Me.Tree.SelectedImageIndex = 0
        Me.Tree.Size = New System.Drawing.Size(350, 368)
        Me.Tree.TabIndex = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Icon_1.ico")
        Me.ImageList1.Images.SetKeyName(1, "Icon_2.ico")
        Me.ImageList1.Images.SetKeyName(2, "Icon_4.ico")
        Me.ImageList1.Images.SetKeyName(3, "settings.ico")
        Me.ImageList1.Images.SetKeyName(4, "download.ico")
        Me.ImageList1.Images.SetKeyName(5, "upload.ico")
        Me.ImageList1.Images.SetKeyName(6, "oData.ico")
        '
        'PropertyGrid
        '
        Me.PropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PropertyGrid.Location = New System.Drawing.Point(0, 0)
        Me.PropertyGrid.Name = "PropertyGrid"
        Me.PropertyGrid.Size = New System.Drawing.Size(321, 368)
        Me.PropertyGrid.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(583, 445)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 44)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Ok"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(675, 62)
        Me.Panel1.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = Global.ediftp.My.Resources.Resources.top
        Me.PictureBox1.Location = New System.Drawing.Point(180, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(495, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'ActContextMenu
        '
        Me.ActContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.ActContextMenu.Name = "ActContextMenu"
        Me.ActContextMenu.Size = New System.Drawing.Size(142, 48)
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SendActionToolStripMenuItem, Me.ReceiveActionToolStripMenuItem})
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'SendActionToolStripMenuItem
        '
        Me.SendActionToolStripMenuItem.Name = "SendActionToolStripMenuItem"
        Me.SendActionToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SendActionToolStripMenuItem.Text = "Send Action"
        '
        'ReceiveActionToolStripMenuItem
        '
        Me.ReceiveActionToolStripMenuItem.Name = "ReceiveActionToolStripMenuItem"
        Me.ReceiveActionToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ReceiveActionToolStripMenuItem.Text = "Receive Action"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete Mode"
        '
        'ModeActContextMenu
        '
        Me.ModeActContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem1})
        Me.ModeActContextMenu.Name = "ModeActContextMenu"
        Me.ModeActContextMenu.Size = New System.Drawing.Size(146, 26)
        '
        'DeleteToolStripMenuItem1
        '
        Me.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1"
        Me.DeleteToolStripMenuItem1.Size = New System.Drawing.Size(145, 22)
        Me.DeleteToolStripMenuItem1.Text = "Delete Action"
        '
        'ServerItemContextMenu
        '
        Me.ServerItemContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteServerToolStripMenuItem, Me.RenameServerToolStripMenuItem})
        Me.ServerItemContextMenu.Name = "ServerItemContextMenu"
        Me.ServerItemContextMenu.Size = New System.Drawing.Size(181, 70)
        '
        'DeleteServerToolStripMenuItem
        '
        Me.DeleteServerToolStripMenuItem.Name = "DeleteServerToolStripMenuItem"
        Me.DeleteServerToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.DeleteServerToolStripMenuItem.Text = "Delete Server"
        '
        'RenameServerToolStripMenuItem
        '
        Me.RenameServerToolStripMenuItem.Name = "RenameServerToolStripMenuItem"
        Me.RenameServerToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RenameServerToolStripMenuItem.Text = "Rename Server"
        '
        'frmConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 492)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConfig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FTP Configuration"
        Me.ServerContextMenu.ResumeLayout(False)
        Me.ModeContextMenu.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ActContextMenu.ResumeLayout(False)
        Me.ModeActContextMenu.ResumeLayout(False)
        Me.ServerItemContextMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As Windows.Forms.TableLayoutPanel
    Friend WithEvents SplitContainer1 As Windows.Forms.SplitContainer
    Friend WithEvents Tree As Windows.Forms.TreeView
    Friend WithEvents PropertyGrid As Windows.Forms.PropertyGrid
    Friend WithEvents Button1 As Windows.Forms.Button
    Friend WithEvents ImageList1 As Windows.Forms.ImageList
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents PictureBox1 As Windows.Forms.PictureBox
    Friend WithEvents ServerContextMenu As Windows.Forms.ContextMenuStrip
    Friend WithEvents AddServerToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModeContextMenu As Windows.Forms.ContextMenuStrip
    Friend WithEvents AddModeToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActContextMenu As Windows.Forms.ContextMenuStrip
    Friend WithEvents AddToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents SendActionToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReceiveActionToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModeActContextMenu As Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem1 As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServerItemContextMenu As Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteServerToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents RenameServerToolStripMenuItem As Windows.Forms.ToolStripMenuItem
End Class
