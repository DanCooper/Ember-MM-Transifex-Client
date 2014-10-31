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
        Me.mnuFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnLoadForTranslation = New System.Windows.Forms.Button()
        Me.btnLoadResource = New System.Windows.Forms.Button()
        Me.btnLoadTranslations = New System.Windows.Forms.Button()
        Me.lvForTranslation = New System.Windows.Forms.ListView()
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colData = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colRecource = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTranslation = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvTranslations = New System.Windows.Forms.ListView()
        Me.colTID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTText = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.scTop = New System.Windows.Forms.SplitContainer()
        Me.scMain = New System.Windows.Forms.SplitContainer()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtTranslation = New System.Windows.Forms.TextBox()
        Me.ofdFiles = New System.Windows.Forms.OpenFileDialog()
        Me.sfdFiles = New System.Windows.Forms.SaveFileDialog()
        Me.mstripMain.SuspendLayout()
        CType(Me.scTop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scTop.Panel1.SuspendLayout()
        Me.scTop.Panel2.SuspendLayout()
        Me.scTop.SuspendLayout()
        CType(Me.scMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scMain.Panel1.SuspendLayout()
        Me.scMain.Panel2.SuspendLayout()
        Me.scMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'sstripStatus
        '
        Me.sstripStatus.Location = New System.Drawing.Point(0, 524)
        Me.sstripStatus.Name = "sstripStatus"
        Me.sstripStatus.Size = New System.Drawing.Size(910, 22)
        Me.sstripStatus.TabIndex = 0
        Me.sstripStatus.Text = "StatusStrip1"
        '
        'mstripMain
        '
        Me.mstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit})
        Me.mstripMain.Location = New System.Drawing.Point(0, 0)
        Me.mstripMain.Name = "mstripMain"
        Me.mstripMain.Size = New System.Drawing.Size(910, 24)
        Me.mstripMain.TabIndex = 1
        Me.mstripMain.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileSave, Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Name = "mnuFileSave"
        Me.mnuFileSave.Size = New System.Drawing.Size(218, 22)
        Me.mnuFileSave.Text = "Save Translation to new file"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(218, 22)
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
        Me.mnuEditSettings.Size = New System.Drawing.Size(116, 22)
        Me.mnuEditSettings.Text = "Settings"
        '
        'btnLoadForTranslation
        '
        Me.btnLoadForTranslation.Location = New System.Drawing.Point(100, 1)
        Me.btnLoadForTranslation.Name = "btnLoadForTranslation"
        Me.btnLoadForTranslation.Size = New System.Drawing.Size(95, 23)
        Me.btnLoadForTranslation.TabIndex = 2
        Me.btnLoadForTranslation.Text = "For Translation"
        Me.btnLoadForTranslation.UseVisualStyleBackColor = True
        '
        'btnLoadResource
        '
        Me.btnLoadResource.Location = New System.Drawing.Point(201, 1)
        Me.btnLoadResource.Name = "btnLoadResource"
        Me.btnLoadResource.Size = New System.Drawing.Size(95, 23)
        Me.btnLoadResource.TabIndex = 2
        Me.btnLoadResource.Text = "Resource"
        Me.btnLoadResource.UseVisualStyleBackColor = True
        '
        'btnLoadTranslations
        '
        Me.btnLoadTranslations.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLoadTranslations.Location = New System.Drawing.Point(565, 1)
        Me.btnLoadTranslations.Name = "btnLoadTranslations"
        Me.btnLoadTranslations.Size = New System.Drawing.Size(95, 23)
        Me.btnLoadTranslations.TabIndex = 3
        Me.btnLoadTranslations.Text = "Translations"
        Me.btnLoadTranslations.UseVisualStyleBackColor = True
        '
        'lvForTranslation
        '
        Me.lvForTranslation.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colID, Me.colData, Me.colRecource, Me.colTranslation})
        Me.lvForTranslation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvForTranslation.FullRowSelect = True
        Me.lvForTranslation.Location = New System.Drawing.Point(0, 0)
        Me.lvForTranslation.MultiSelect = False
        Me.lvForTranslation.Name = "lvForTranslation"
        Me.lvForTranslation.Size = New System.Drawing.Size(453, 397)
        Me.lvForTranslation.TabIndex = 4
        Me.lvForTranslation.UseCompatibleStateImageBehavior = False
        Me.lvForTranslation.View = System.Windows.Forms.View.Details
        '
        'colID
        '
        Me.colID.Text = "ID"
        Me.colID.Width = 40
        '
        'colData
        '
        Me.colData.Text = "data-tx-text"
        Me.colData.Width = 80
        '
        'colRecource
        '
        Me.colRecource.Text = "Recource Text"
        Me.colRecource.Width = 120
        '
        'colTranslation
        '
        Me.colTranslation.Text = "Translation"
        Me.colTranslation.Width = 120
        '
        'lvTranslations
        '
        Me.lvTranslations.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colTID, Me.colTText})
        Me.lvTranslations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvTranslations.FullRowSelect = True
        Me.lvTranslations.Location = New System.Drawing.Point(0, 0)
        Me.lvTranslations.MultiSelect = False
        Me.lvTranslations.Name = "lvTranslations"
        Me.lvTranslations.Size = New System.Drawing.Size(453, 397)
        Me.lvTranslations.TabIndex = 5
        Me.lvTranslations.UseCompatibleStateImageBehavior = False
        Me.lvTranslations.View = System.Windows.Forms.View.Details
        '
        'colTID
        '
        Me.colTID.Text = "ID"
        Me.colTID.Width = 40
        '
        'colTText
        '
        Me.colTText.Text = "Text"
        Me.colTText.Width = 300
        '
        'scTop
        '
        Me.scTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scTop.Location = New System.Drawing.Point(0, 0)
        Me.scTop.Name = "scTop"
        '
        'scTop.Panel1
        '
        Me.scTop.Panel1.Controls.Add(Me.lvForTranslation)
        '
        'scTop.Panel2
        '
        Me.scTop.Panel2.Controls.Add(Me.lvTranslations)
        Me.scTop.Size = New System.Drawing.Size(910, 397)
        Me.scTop.SplitterDistance = 453
        Me.scTop.TabIndex = 6
        '
        'scMain
        '
        Me.scMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scMain.Location = New System.Drawing.Point(0, 24)
        Me.scMain.Name = "scMain"
        Me.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'scMain.Panel1
        '
        Me.scMain.Panel1.Controls.Add(Me.scTop)
        '
        'scMain.Panel2
        '
        Me.scMain.Panel2.Controls.Add(Me.btnSave)
        Me.scMain.Panel2.Controls.Add(Me.txtTranslation)
        Me.scMain.Size = New System.Drawing.Size(910, 500)
        Me.scMain.SplitterDistance = 397
        Me.scMain.TabIndex = 7
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(805, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(93, 93)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtTranslation
        '
        Me.txtTranslation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTranslation.Location = New System.Drawing.Point(3, 3)
        Me.txtTranslation.Multiline = True
        Me.txtTranslation.Name = "txtTranslation"
        Me.txtTranslation.Size = New System.Drawing.Size(796, 93)
        Me.txtTranslation.TabIndex = 0
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 546)
        Me.Controls.Add(Me.scMain)
        Me.Controls.Add(Me.btnLoadTranslations)
        Me.Controls.Add(Me.btnLoadResource)
        Me.Controls.Add(Me.btnLoadForTranslation)
        Me.Controls.Add(Me.sstripStatus)
        Me.Controls.Add(Me.mstripMain)
        Me.MainMenuStrip = Me.mstripMain
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.mstripMain.ResumeLayout(False)
        Me.mstripMain.PerformLayout()
        Me.scTop.Panel1.ResumeLayout(False)
        Me.scTop.Panel2.ResumeLayout(False)
        CType(Me.scTop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scTop.ResumeLayout(False)
        Me.scMain.Panel1.ResumeLayout(False)
        Me.scMain.Panel2.ResumeLayout(False)
        Me.scMain.Panel2.PerformLayout()
        CType(Me.scMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scMain.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sstripStatus As System.Windows.Forms.StatusStrip
    Friend WithEvents mstripMain As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEditSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnLoadForTranslation As System.Windows.Forms.Button
    Friend WithEvents btnLoadResource As System.Windows.Forms.Button
    Friend WithEvents btnLoadTranslations As System.Windows.Forms.Button
    Friend WithEvents lvForTranslation As System.Windows.Forms.ListView
    Friend WithEvents lvTranslations As System.Windows.Forms.ListView
    Friend WithEvents colTID As System.Windows.Forms.ColumnHeader
    Friend WithEvents colTText As System.Windows.Forms.ColumnHeader
    Friend WithEvents colID As System.Windows.Forms.ColumnHeader
    Friend WithEvents colData As System.Windows.Forms.ColumnHeader
    Friend WithEvents colRecource As System.Windows.Forms.ColumnHeader
    Friend WithEvents colTranslation As System.Windows.Forms.ColumnHeader
    Friend WithEvents scTop As System.Windows.Forms.SplitContainer
    Friend WithEvents scMain As System.Windows.Forms.SplitContainer
    Friend WithEvents txtTranslation As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents mnuFileSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ofdFiles As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sfdFiles As System.Windows.Forms.SaveFileDialog

End Class
