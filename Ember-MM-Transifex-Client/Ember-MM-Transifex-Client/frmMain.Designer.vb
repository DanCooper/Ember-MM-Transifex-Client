<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.sstripStatus = New System.Windows.Forms.StatusStrip()
        Me.mstripMain = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.mstripMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'sstripStatus
        '
        Me.sstripStatus.Location = New System.Drawing.Point(0, 462)
        Me.sstripStatus.Name = "sstripStatus"
        Me.sstripStatus.Size = New System.Drawing.Size(817, 22)
        Me.sstripStatus.TabIndex = 0
        Me.sstripStatus.Text = "StatusStrip1"
        '
        'mstripMain
        '
        Me.mstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit})
        Me.mstripMain.Location = New System.Drawing.Point(0, 0)
        Me.mstripMain.Name = "mstripMain"
        Me.mstripMain.Size = New System.Drawing.Size(817, 24)
        Me.mstripMain.TabIndex = 1
        Me.mstripMain.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(92, 22)
        Me.mnuFileExit.Text = "Exit"
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEditSettings})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(39, 20)
        Me.mnuEdit.Text = "Edit"
        '
        'mnuEditSettings
        '
        Me.mnuEditSettings.Name = "mnuEditSettings"
        Me.mnuEditSettings.Size = New System.Drawing.Size(152, 22)
        Me.mnuEditSettings.Text = "Settings"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 484)
        Me.Controls.Add(Me.sstripStatus)
        Me.Controls.Add(Me.mstripMain)
        Me.MainMenuStrip = Me.mstripMain
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.mstripMain.ResumeLayout(False)
        Me.mstripMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sstripStatus As System.Windows.Forms.StatusStrip
    Friend WithEvents mstripMain As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEditSettings As System.Windows.Forms.ToolStripMenuItem

End Class
