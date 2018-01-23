<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddAssociation
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
        Me.AddThingAssociationComboBox = New System.Windows.Forms.ComboBox()
        Me.ThingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AddButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        CType(Me.ThingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AddThingAssociationComboBox
        '
        Me.AddThingAssociationComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddThingAssociationComboBox.DataSource = Me.ThingBindingSource
        Me.AddThingAssociationComboBox.DisplayMember = "Title"
        Me.AddThingAssociationComboBox.FormattingEnabled = True
        Me.AddThingAssociationComboBox.Location = New System.Drawing.Point(0, 1)
        Me.AddThingAssociationComboBox.Name = "AddThingAssociationComboBox"
        Me.AddThingAssociationComboBox.Size = New System.Drawing.Size(202, 21)
        Me.AddThingAssociationComboBox.TabIndex = 0
        Me.AddThingAssociationComboBox.ValueMember = "ThingId"
        '
        'ThingBindingSource
        '
        Me.ThingBindingSource.DataSource = GetType(ThingManager.Thing)
        '
        'AddButton
        '
        Me.AddButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddButton.Location = New System.Drawing.Point(203, 1)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(40, 21)
        Me.AddButton.TabIndex = 1
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelButton.Location = New System.Drawing.Point(242, 1)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(49, 21)
        Me.CancelButton.TabIndex = 2
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'AddAssociation
        '
        Me.AcceptButton = Me.AddButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 22)
        Me.ControlBox = False
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.AddThingAssociationComboBox)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1000, 60)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(306, 60)
        Me.Name = "AddAssociation"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Choose the Thing from the drop down and click add"
        CType(Me.ThingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AddThingAssociationComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ThingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents CancelButton As System.Windows.Forms.Button
End Class
