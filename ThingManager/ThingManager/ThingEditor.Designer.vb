<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ThingEditor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ThingEditor))
        Me.ThingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ThingBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ThingBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ParentThingsListBox = New System.Windows.Forms.ListBox()
        Me.ParentContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddParentAssociation = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveParentAssociation = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ChildThingsListBox = New System.Windows.Forms.ListBox()
        Me.ChildrenContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddChildAssociation = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveChildAssociation = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChildrenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.MemoTextBox = New System.Windows.Forms.TextBox()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.AddAssociationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.ThingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ThingBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ThingBindingNavigator.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.ParentContextMenuStrip.SuspendLayout()
        CType(Me.ParentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ChildrenContextMenuStrip.SuspendLayout()
        CType(Me.ChildrenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddAssociationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ThingBindingSource
        '
        Me.ThingBindingSource.DataSource = GetType(ThingManager.Thing)
        '
        'ThingBindingNavigator
        '
        Me.ThingBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ThingBindingNavigator.BindingSource = Me.ThingBindingSource
        Me.TableLayoutPanel1.SetColumnSpan(Me.ThingBindingNavigator, 3)
        Me.ThingBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ThingBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ThingBindingNavigator.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ThingBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ThingBindingNavigatorSaveItem})
        Me.ThingBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ThingBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ThingBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ThingBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ThingBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ThingBindingNavigator.Name = "ThingBindingNavigator"
        Me.ThingBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ThingBindingNavigator.Size = New System.Drawing.Size(620, 30)
        Me.ThingBindingNavigator.TabIndex = 0
        Me.ThingBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 27)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 27)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 27)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 27)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 27)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 30)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 30)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 27)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 27)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 30)
        '
        'ThingBindingNavigatorSaveItem
        '
        Me.ThingBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ThingBindingNavigatorSaveItem.Enabled = False
        Me.ThingBindingNavigatorSaveItem.Image = CType(resources.GetObject("ThingBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ThingBindingNavigatorSaveItem.Name = "ThingBindingNavigatorSaveItem"
        Me.ThingBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 27)
        Me.ThingBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ThingBindingNavigator, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ParentThingsListBox, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ChildThingsListBox, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TitleTextBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.StatusStrip1, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.MemoTextBox, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(620, 483)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'ParentThingsListBox
        '
        Me.ParentThingsListBox.ContextMenuStrip = Me.ParentContextMenuStrip
        Me.ParentThingsListBox.DataSource = Me.ParentBindingSource
        Me.ParentThingsListBox.DisplayMember = "Title"
        Me.ParentThingsListBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ParentThingsListBox.FormattingEnabled = True
        Me.ParentThingsListBox.Location = New System.Drawing.Point(3, 33)
        Me.ParentThingsListBox.Name = "ParentThingsListBox"
        Me.TableLayoutPanel1.SetRowSpan(Me.ParentThingsListBox, 2)
        Me.ParentThingsListBox.Size = New System.Drawing.Size(149, 417)
        Me.ParentThingsListBox.TabIndex = 2
        Me.ParentThingsListBox.ValueMember = "ThingId"
        '
        'ParentContextMenuStrip
        '
        Me.ParentContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddParentAssociation, Me.RemoveParentAssociation})
        Me.ParentContextMenuStrip.Name = "ContextMenuStrip1"
        Me.ParentContextMenuStrip.Size = New System.Drawing.Size(182, 48)
        '
        'AddParentAssociation
        '
        Me.AddParentAssociation.Name = "AddParentAssociation"
        Me.AddParentAssociation.Size = New System.Drawing.Size(181, 22)
        Me.AddParentAssociation.Text = "Add Association"
        '
        'RemoveParentAssociation
        '
        Me.RemoveParentAssociation.Name = "RemoveParentAssociation"
        Me.RemoveParentAssociation.Size = New System.Drawing.Size(181, 22)
        Me.RemoveParentAssociation.Text = "Remove Association"
        '
        'ParentBindingSource
        '
        Me.ParentBindingSource.DataSource = GetType(ThingManager.Thing)
        '
        'ChildThingsListBox
        '
        Me.ChildThingsListBox.ContextMenuStrip = Me.ChildrenContextMenuStrip
        Me.ChildThingsListBox.DataSource = Me.ChildrenBindingSource
        Me.ChildThingsListBox.DisplayMember = "Title"
        Me.ChildThingsListBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChildThingsListBox.FormattingEnabled = True
        Me.ChildThingsListBox.Location = New System.Drawing.Point(468, 33)
        Me.ChildThingsListBox.Name = "ChildThingsListBox"
        Me.TableLayoutPanel1.SetRowSpan(Me.ChildThingsListBox, 2)
        Me.ChildThingsListBox.Size = New System.Drawing.Size(149, 417)
        Me.ChildThingsListBox.TabIndex = 3
        Me.ChildThingsListBox.ValueMember = "ThingId"
        '
        'ChildrenContextMenuStrip
        '
        Me.ChildrenContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddChildAssociation, Me.RemoveChildAssociation})
        Me.ChildrenContextMenuStrip.Name = "ChildrenContextMenuStrip"
        Me.ChildrenContextMenuStrip.Size = New System.Drawing.Size(182, 48)
        Me.ChildrenContextMenuStrip.Text = "ChildrenMenuStrip"
        '
        'AddChildAssociation
        '
        Me.AddChildAssociation.Name = "AddChildAssociation"
        Me.AddChildAssociation.Size = New System.Drawing.Size(181, 22)
        Me.AddChildAssociation.Text = "Add Association"
        '
        'RemoveChildAssociation
        '
        Me.RemoveChildAssociation.Name = "RemoveChildAssociation"
        Me.RemoveChildAssociation.Size = New System.Drawing.Size(181, 22)
        Me.RemoveChildAssociation.Text = "Remove Association"
        '
        'ChildrenBindingSource
        '
        Me.ChildrenBindingSource.DataSource = GetType(ThingManager.Thing)
        '
        'TitleTextBox
        '
        Me.TitleTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ThingBindingSource, "Title", True))
        Me.TitleTextBox.Location = New System.Drawing.Point(158, 33)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(304, 20)
        Me.TitleTextBox.TabIndex = 4
        Me.TitleTextBox.Text = "Thing Title"
        '
        'StatusStrip1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.StatusStrip1, 3)
        Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 453)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(620, 30)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'MemoTextBox
        '
        Me.MemoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ThingBindingSource, "Memo", True))
        Me.MemoTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MemoTextBox.Location = New System.Drawing.Point(158, 58)
        Me.MemoTextBox.Multiline = True
        Me.MemoTextBox.Name = "MemoTextBox"
        Me.MemoTextBox.Size = New System.Drawing.Size(304, 392)
        Me.MemoTextBox.TabIndex = 6
        Me.MemoTextBox.Text = "Thing Memo"
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Location = New System.Drawing.Point(190, 30)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(30, 13)
        Me.TitleLabel.TabIndex = 4
        Me.TitleLabel.Text = "Title:"
        '
        'AddAssociationBindingSource
        '
        Me.AddAssociationBindingSource.DataSource = GetType(ThingManager.Thing)
        '
        'ThingEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 483)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "ThingEditor"
        Me.Text = "Things"
        CType(Me.ThingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ThingBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ThingBindingNavigator.ResumeLayout(False)
        Me.ThingBindingNavigator.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ParentContextMenuStrip.ResumeLayout(False)
        CType(Me.ParentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ChildrenContextMenuStrip.ResumeLayout(False)
        CType(Me.ChildrenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddAssociationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ThingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ThingBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ThingBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ParentThingsListBox As System.Windows.Forms.ListBox
    Friend WithEvents ChildThingsListBox As System.Windows.Forms.ListBox
    Friend WithEvents TitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents MemoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ChildrenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ParentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ChildrenContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ParentContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AddParentAssociation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveParentAssociation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddChildAssociation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveChildAssociation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddAssociationBindingSource As System.Windows.Forms.BindingSource

End Class
