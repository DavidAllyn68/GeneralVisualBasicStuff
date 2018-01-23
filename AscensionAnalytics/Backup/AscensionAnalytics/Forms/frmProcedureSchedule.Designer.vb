<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProcedureSchedule
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
        Me.components = New System.ComponentModel.Container
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Dim grexProcedureSchedule_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProcedureSchedule))
        Me.vsmProcedureSchedule = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.cmdMgrProcedureSchedule = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
        Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.AddProcedure = New Janus.Windows.UI.CommandBars.UICommand("AddProcedure")
        Me.DeleteProcedure = New Janus.Windows.UI.CommandBars.UICommand("DeleteProcedure")
        Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.ctxtMenuAssignments = New Janus.Windows.UI.CommandBars.UIContextMenu
        Me.grexProcedureSchedule = New Janus.Windows.GridEX.GridEX
        Me.bsProcedureSchedule = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.cmdMgrProcedureSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ctxtMenuAssignments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grexProcedureSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProcedureSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vsmProcedureSchedule
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmProcedureSchedule.ColorSchemes.Add(JanusColorScheme1)
        '
        'cmdMgrProcedureSchedule
        '
        Me.cmdMgrProcedureSchedule.BottomRebar = Me.BottomRebar1
        Me.cmdMgrProcedureSchedule.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.AddProcedure, Me.DeleteProcedure})
        Me.cmdMgrProcedureSchedule.ContainerControl = Me
        Me.cmdMgrProcedureSchedule.Id = New System.Guid("a60001cb-2461-4e62-b66c-ae51fce9f718")
        Me.cmdMgrProcedureSchedule.LeftRebar = Me.LeftRebar1
        Me.cmdMgrProcedureSchedule.RightRebar = Me.RightRebar1
        Me.cmdMgrProcedureSchedule.TopRebar = Me.TopRebar1
        '
        'BottomRebar1
        '
        Me.BottomRebar1.CommandManager = Me.cmdMgrProcedureSchedule
        Me.BottomRebar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomRebar1.Location = New System.Drawing.Point(0, 479)
        Me.BottomRebar1.Name = "BottomRebar1"
        Me.BottomRebar1.Size = New System.Drawing.Size(1230, 0)
        '
        'AddProcedure
        '
        Me.AddProcedure.Key = "AddProcedure"
        Me.AddProcedure.Name = "AddProcedure"
        Me.AddProcedure.Text = "Add Scheduled Procedure"
        '
        'DeleteProcedure
        '
        Me.DeleteProcedure.Key = "DeleteProcedure"
        Me.DeleteProcedure.Name = "DeleteProcedure"
        Me.DeleteProcedure.Text = "Delete Scheduled Procedure"
        '
        'LeftRebar1
        '
        Me.LeftRebar1.CommandManager = Me.cmdMgrProcedureSchedule
        Me.LeftRebar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftRebar1.Location = New System.Drawing.Point(0, 0)
        Me.LeftRebar1.Name = "LeftRebar1"
        Me.LeftRebar1.Size = New System.Drawing.Size(0, 479)
        '
        'RightRebar1
        '
        Me.RightRebar1.CommandManager = Me.cmdMgrProcedureSchedule
        Me.RightRebar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightRebar1.Location = New System.Drawing.Point(1230, 0)
        Me.RightRebar1.Name = "RightRebar1"
        Me.RightRebar1.Size = New System.Drawing.Size(0, 479)
        '
        'TopRebar1
        '
        Me.TopRebar1.CommandManager = Me.cmdMgrProcedureSchedule
        Me.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopRebar1.Location = New System.Drawing.Point(0, 0)
        Me.TopRebar1.Name = "TopRebar1"
        Me.TopRebar1.Size = New System.Drawing.Size(1230, 0)
        '
        'ctxtMenuAssignments
        '
        Me.ctxtMenuAssignments.Key = "ctxtMenuAssignments"
        '
        'grexProcedureSchedule
        '
        Me.grexProcedureSchedule.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexProcedureSchedule.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexProcedureSchedule.DataSource = Me.bsProcedureSchedule
        grexProcedureSchedule_DesignTimeLayout.LayoutString = resources.GetString("grexProcedureSchedule_DesignTimeLayout.LayoutString")
        Me.grexProcedureSchedule.DesignTimeLayout = grexProcedureSchedule_DesignTimeLayout
        Me.grexProcedureSchedule.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexProcedureSchedule.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexProcedureSchedule.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexProcedureSchedule.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grexProcedureSchedule.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grexProcedureSchedule.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grexProcedureSchedule.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.grexProcedureSchedule.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexProcedureSchedule.Location = New System.Drawing.Point(0, 0)
        Me.grexProcedureSchedule.Name = "grexProcedureSchedule"
        Me.grexProcedureSchedule.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grexProcedureSchedule.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexProcedureSchedule.Size = New System.Drawing.Size(1230, 479)
        Me.grexProcedureSchedule.TabIndex = 4
        Me.grexProcedureSchedule.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grexProcedureSchedule.VisualStyleManager = Me.vsmProcedureSchedule
        '
        'bsProcedureSchedule
        '
        Me.bsProcedureSchedule.DataSource = GetType(AscensionAnalytics.ProcedureSchedule)
        '
        'frmProcedureSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1230, 479)
        Me.Controls.Add(Me.TopRebar1)
        Me.Controls.Add(Me.grexProcedureSchedule)
        Me.Controls.Add(Me.LeftRebar1)
        Me.Controls.Add(Me.RightRebar1)
        Me.Controls.Add(Me.BottomRebar1)
        Me.Name = "frmProcedureSchedule"
        Me.Text = "Procedure Execution"
        CType(Me.cmdMgrProcedureSchedule, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ctxtMenuAssignments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grexProcedureSchedule, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProcedureSchedule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmProcedureSchedule As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents cmdMgrProcedureSchedule As Janus.Windows.UI.CommandBars.UICommandManager
    Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents ctxtMenuAssignments As Janus.Windows.UI.CommandBars.UIContextMenu
    Friend WithEvents AddProcedure As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents DeleteProcedure As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents grexProcedureSchedule As Janus.Windows.GridEX.GridEX
    Friend WithEvents bsProcedureSchedule As System.Windows.Forms.BindingSource
End Class
