﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ApplyChangesWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tablelayoutpanelApplyChanges = New System.Windows.Forms.TableLayoutPanel()
        Me.datagridviewAppsBeingInstalled = New System.Windows.Forms.DataGridView()
        Me.PackageName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PackageVersion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PackageAction = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PackageCurrentStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.buttonCancel = New System.Windows.Forms.Button()
        Me.buttonConfirmChanges = New System.Windows.Forms.Button()
        Me.LinkLabelMiniOptionsForm = New System.Windows.Forms.LinkLabel()
        Me.ContextMenuStripResetStatus = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ResetStatusForAllPackagesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetStatusForSelectedPackageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.zToolStripSeparatorResetStatus = New System.Windows.Forms.ToolStripSeparator()
        Me.tablelayoutpanelApplyChanges.SuspendLayout()
        CType(Me.datagridviewAppsBeingInstalled, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripResetStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'tablelayoutpanelApplyChanges
        '
        Me.tablelayoutpanelApplyChanges.ColumnCount = 5
        Me.tablelayoutpanelApplyChanges.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tablelayoutpanelApplyChanges.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tablelayoutpanelApplyChanges.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tablelayoutpanelApplyChanges.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105.0!))
        Me.tablelayoutpanelApplyChanges.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.tablelayoutpanelApplyChanges.Controls.Add(Me.datagridviewAppsBeingInstalled, 0, 0)
        Me.tablelayoutpanelApplyChanges.Controls.Add(Me.buttonCancel, 4, 1)
        Me.tablelayoutpanelApplyChanges.Controls.Add(Me.buttonConfirmChanges, 3, 1)
        Me.tablelayoutpanelApplyChanges.Controls.Add(Me.LinkLabelMiniOptionsForm, 0, 1)
        Me.tablelayoutpanelApplyChanges.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tablelayoutpanelApplyChanges.Location = New System.Drawing.Point(0, 0)
        Me.tablelayoutpanelApplyChanges.Margin = New System.Windows.Forms.Padding(2)
        Me.tablelayoutpanelApplyChanges.Name = "tablelayoutpanelApplyChanges"
        Me.tablelayoutpanelApplyChanges.RowCount = 2
        Me.tablelayoutpanelApplyChanges.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tablelayoutpanelApplyChanges.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.tablelayoutpanelApplyChanges.Size = New System.Drawing.Size(630, 373)
        Me.tablelayoutpanelApplyChanges.TabIndex = 0
        '
        'datagridviewAppsBeingInstalled
        '
        Me.datagridviewAppsBeingInstalled.AllowUserToAddRows = False
        Me.datagridviewAppsBeingInstalled.AllowUserToDeleteRows = False
        Me.datagridviewAppsBeingInstalled.AllowUserToOrderColumns = True
        Me.datagridviewAppsBeingInstalled.AllowUserToResizeRows = False
        Me.datagridviewAppsBeingInstalled.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagridviewAppsBeingInstalled.BackgroundColor = System.Drawing.SystemColors.Window
        Me.datagridviewAppsBeingInstalled.ColumnHeadersHeight = 29
        Me.datagridviewAppsBeingInstalled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.datagridviewAppsBeingInstalled.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PackageName, Me.PackageVersion, Me.PackageAction, Me.PackageCurrentStatus})
        Me.tablelayoutpanelApplyChanges.SetColumnSpan(Me.datagridviewAppsBeingInstalled, 5)
        Me.datagridviewAppsBeingInstalled.ContextMenuStrip = Me.ContextMenuStripResetStatus
        Me.datagridviewAppsBeingInstalled.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewAppsBeingInstalled.Location = New System.Drawing.Point(2, 2)
        Me.datagridviewAppsBeingInstalled.Margin = New System.Windows.Forms.Padding(2)
        Me.datagridviewAppsBeingInstalled.MultiSelect = False
        Me.datagridviewAppsBeingInstalled.Name = "datagridviewAppsBeingInstalled"
        Me.datagridviewAppsBeingInstalled.ReadOnly = True
        Me.datagridviewAppsBeingInstalled.RowHeadersVisible = False
        Me.datagridviewAppsBeingInstalled.RowHeadersWidth = 51
        Me.datagridviewAppsBeingInstalled.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewAppsBeingInstalled.RowTemplate.Height = 24
        Me.datagridviewAppsBeingInstalled.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewAppsBeingInstalled.Size = New System.Drawing.Size(626, 337)
        Me.datagridviewAppsBeingInstalled.StandardTab = True
        Me.datagridviewAppsBeingInstalled.TabIndex = 0
        '
        'PackageName
        '
        Me.PackageName.HeaderText = "Package"
        Me.PackageName.MinimumWidth = 6
        Me.PackageName.Name = "PackageName"
        Me.PackageName.ReadOnly = True
        '
        'PackageVersion
        '
        Me.PackageVersion.HeaderText = "Version"
        Me.PackageVersion.MinimumWidth = 6
        Me.PackageVersion.Name = "PackageVersion"
        Me.PackageVersion.ReadOnly = True
        '
        'PackageAction
        '
        Me.PackageAction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PackageAction.HeaderText = "Action"
        Me.PackageAction.MinimumWidth = 6
        Me.PackageAction.Name = "PackageAction"
        Me.PackageAction.ReadOnly = True
        Me.PackageAction.Width = 62
        '
        'PackageCurrentStatus
        '
        Me.PackageCurrentStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PackageCurrentStatus.HeaderText = "Current status"
        Me.PackageCurrentStatus.MinimumWidth = 6
        Me.PackageCurrentStatus.Name = "PackageCurrentStatus"
        Me.PackageCurrentStatus.ReadOnly = True
        Me.PackageCurrentStatus.Width = 97
        '
        'buttonCancel
        '
        Me.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.buttonCancel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.buttonCancel.Location = New System.Drawing.Point(542, 343)
        Me.buttonCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonCancel.Name = "buttonCancel"
        Me.buttonCancel.Size = New System.Drawing.Size(86, 28)
        Me.buttonCancel.TabIndex = 1
        Me.buttonCancel.Text = "Close"
        Me.buttonCancel.UseVisualStyleBackColor = True
        '
        'buttonConfirmChanges
        '
        Me.buttonConfirmChanges.Dock = System.Windows.Forms.DockStyle.Fill
        Me.buttonConfirmChanges.Location = New System.Drawing.Point(437, 343)
        Me.buttonConfirmChanges.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonConfirmChanges.Name = "buttonConfirmChanges"
        Me.buttonConfirmChanges.Size = New System.Drawing.Size(101, 28)
        Me.buttonConfirmChanges.TabIndex = 2
        Me.buttonConfirmChanges.Text = "Confirm changes"
        Me.buttonConfirmChanges.UseVisualStyleBackColor = True
        '
        'LinkLabelMiniOptionsForm
        '
        Me.LinkLabelMiniOptionsForm.AutoSize = True
        Me.LinkLabelMiniOptionsForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LinkLabelMiniOptionsForm.Location = New System.Drawing.Point(3, 341)
        Me.LinkLabelMiniOptionsForm.Name = "LinkLabelMiniOptionsForm"
        Me.LinkLabelMiniOptionsForm.Size = New System.Drawing.Size(52, 32)
        Me.LinkLabelMiniOptionsForm.TabIndex = 5
        Me.LinkLabelMiniOptionsForm.TabStop = True
        Me.LinkLabelMiniOptionsForm.Text = "Options..."
        Me.LinkLabelMiniOptionsForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ContextMenuStripResetStatus
        '
        Me.ContextMenuStripResetStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetStatusForSelectedPackageToolStripMenuItem, Me.zToolStripSeparatorResetStatus, Me.ResetStatusForAllPackagesToolStripMenuItem})
        Me.ContextMenuStripResetStatus.Name = "ContextMenuStripResetStatus"
        Me.ContextMenuStripResetStatus.Size = New System.Drawing.Size(248, 54)
        '
        'ResetStatusForAllPackagesToolStripMenuItem
        '
        Me.ResetStatusForAllPackagesToolStripMenuItem.Name = "ResetStatusForAllPackagesToolStripMenuItem"
        Me.ResetStatusForAllPackagesToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.ResetStatusForAllPackagesToolStripMenuItem.Text = "Reset status for all packages"
        '
        'ResetStatusForSelectedPackageToolStripMenuItem
        '
        Me.ResetStatusForSelectedPackageToolStripMenuItem.Name = "ResetStatusForSelectedPackageToolStripMenuItem"
        Me.ResetStatusForSelectedPackageToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.ResetStatusForSelectedPackageToolStripMenuItem.Text = "Reset status for selected package"
        '
        'zToolStripSeparatorResetStatus
        '
        Me.zToolStripSeparatorResetStatus.Name = "zToolStripSeparatorResetStatus"
        Me.zToolStripSeparatorResetStatus.Size = New System.Drawing.Size(244, 6)
        '
        'ApplyChangesWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.CancelButton = Me.buttonCancel
        Me.ClientSize = New System.Drawing.Size(630, 373)
        Me.Controls.Add(Me.tablelayoutpanelApplyChanges)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimizeBox = False
        Me.Name = "ApplyChangesWindow"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Apply changes"
        Me.tablelayoutpanelApplyChanges.ResumeLayout(False)
        Me.tablelayoutpanelApplyChanges.PerformLayout()
        CType(Me.datagridviewAppsBeingInstalled, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripResetStatus.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tablelayoutpanelApplyChanges As TableLayoutPanel
    Friend WithEvents buttonCancel As Button
    Friend WithEvents buttonConfirmChanges As Button
    Friend WithEvents datagridviewAppsBeingInstalled As DataGridView
    Friend WithEvents PackageName As DataGridViewTextBoxColumn
    Friend WithEvents PackageVersion As DataGridViewTextBoxColumn
    Friend WithEvents PackageAction As DataGridViewTextBoxColumn
    Friend WithEvents PackageCurrentStatus As DataGridViewTextBoxColumn
    Friend WithEvents LinkLabelMiniOptionsForm As LinkLabel
    Friend WithEvents ContextMenuStripResetStatus As ContextMenuStrip
    Friend WithEvents ResetStatusForAllPackagesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetStatusForSelectedPackageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents zToolStripSeparatorResetStatus As ToolStripSeparator
End Class
