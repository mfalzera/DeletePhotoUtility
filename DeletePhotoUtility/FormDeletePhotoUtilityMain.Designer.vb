<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDeletePhotoUtility
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
        Me.LabelPhotoLogsLocation = New System.Windows.Forms.Label()
        Me.TextBoxPhotoLogsLocation = New System.Windows.Forms.TextBox()
        Me.ButtonSelectPhotoLogsLocation = New System.Windows.Forms.Button()
        Me.TtPhotoDeleteUtility = New System.Windows.Forms.ToolTip(Me.components)
        Me.FbdPhotoDeleteUtility = New System.Windows.Forms.FolderBrowserDialog()
        Me.TextBoxActivityLog = New System.Windows.Forms.TextBox()
        Me.LabelActivityLog = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelPhotoLogsLocation
        '
        Me.LabelPhotoLogsLocation.AutoSize = True
        Me.LabelPhotoLogsLocation.Location = New System.Drawing.Point(12, 9)
        Me.LabelPhotoLogsLocation.Name = "LabelPhotoLogsLocation"
        Me.LabelPhotoLogsLocation.Size = New System.Drawing.Size(146, 19)
        Me.LabelPhotoLogsLocation.TabIndex = 0
        Me.LabelPhotoLogsLocation.Text = "Photo Log(s) Location:"
        '
        'TextBoxPhotoLogsLocation
        '
        Me.TextBoxPhotoLogsLocation.Location = New System.Drawing.Point(12, 32)
        Me.TextBoxPhotoLogsLocation.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxPhotoLogsLocation.Name = "TextBoxPhotoLogsLocation"
        Me.TextBoxPhotoLogsLocation.Size = New System.Drawing.Size(368, 25)
        Me.TextBoxPhotoLogsLocation.TabIndex = 1
        Me.TextBoxPhotoLogsLocation.Text = "C:\OglethorpePhotoLogs"
        '
        'ButtonSelectPhotoLogsLocation
        '
        Me.ButtonSelectPhotoLogsLocation.Location = New System.Drawing.Point(386, 28)
        Me.ButtonSelectPhotoLogsLocation.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonSelectPhotoLogsLocation.Name = "ButtonSelectPhotoLogsLocation"
        Me.ButtonSelectPhotoLogsLocation.Size = New System.Drawing.Size(29, 30)
        Me.ButtonSelectPhotoLogsLocation.TabIndex = 2
        Me.ButtonSelectPhotoLogsLocation.Text = "..."
        Me.TtPhotoDeleteUtility.SetToolTip(Me.ButtonSelectPhotoLogsLocation, "Select Photo Log Folder Location")
        Me.ButtonSelectPhotoLogsLocation.UseVisualStyleBackColor = True
        '
        'FbdPhotoDeleteUtility
        '
        Me.FbdPhotoDeleteUtility.RootFolder = System.Environment.SpecialFolder.UserProfile
        '
        'TextBoxActivityLog
        '
        Me.TextBoxActivityLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxActivityLog.Location = New System.Drawing.Point(434, 32)
        Me.TextBoxActivityLog.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxActivityLog.Multiline = True
        Me.TextBoxActivityLog.Name = "TextBoxActivityLog"
        Me.TextBoxActivityLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxActivityLog.Size = New System.Drawing.Size(311, 363)
        Me.TextBoxActivityLog.TabIndex = 3
        Me.TextBoxActivityLog.WordWrap = False
        '
        'LabelActivityLog
        '
        Me.LabelActivityLog.AutoSize = True
        Me.LabelActivityLog.Location = New System.Drawing.Point(430, 9)
        Me.LabelActivityLog.Name = "LabelActivityLog"
        Me.LabelActivityLog.Size = New System.Drawing.Size(84, 19)
        Me.LabelActivityLog.TabIndex = 4
        Me.LabelActivityLog.Text = "Activity Log:"
        '
        'FormDeletePhotoUtility
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 408)
        Me.Controls.Add(Me.LabelActivityLog)
        Me.Controls.Add(Me.TextBoxActivityLog)
        Me.Controls.Add(Me.ButtonSelectPhotoLogsLocation)
        Me.Controls.Add(Me.TextBoxPhotoLogsLocation)
        Me.Controls.Add(Me.LabelPhotoLogsLocation)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormDeletePhotoUtility"
        Me.Text = "Delete Photo Utility"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelPhotoLogsLocation As System.Windows.Forms.Label
    Friend WithEvents TextBoxPhotoLogsLocation As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSelectPhotoLogsLocation As System.Windows.Forms.Button
    Friend WithEvents TtPhotoDeleteUtility As System.Windows.Forms.ToolTip
    Friend WithEvents FbdPhotoDeleteUtility As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents TextBoxActivityLog As System.Windows.Forms.TextBox
    Friend WithEvents LabelActivityLog As System.Windows.Forms.Label

End Class
