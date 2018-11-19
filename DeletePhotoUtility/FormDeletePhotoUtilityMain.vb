Public Class FormDeletePhotoUtility

    ''' <summary>
    ''' Logs the specified message to the Activity Log.
    ''' </summary>
    ''' <param name="messageText">Message to be logged.</param>
    Private Sub LogMessage(ByVal messageText)
        Me.TextBoxActivityLog.AppendText(String.Format("{0} - {1}{2}",
                                                       Format(DateTime.Now(), "hh:mm:ss"),
                                                       messageText,
                                                       Environment.NewLine))

    End Sub

    ''' <summary>
    ''' Populate the textbox with the selected folder location.
    ''' </summary>
    ''' <param name="locationTextBox">Textbox to be populated.</param>
    Private Sub SelectFolderLocation(ByRef locationTextBox As TextBox)
        If (FbdPhotoDeleteUtility.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            locationTextBox.Text = FbdPhotoDeleteUtility.SelectedPath
            LogMessage("Selected Photo Log Path: " + locationTextBox.Text)
        End If
    End Sub

    Private Sub ButtonSelectPhotoLogsLocation_Click(sender As Object, e As EventArgs) Handles ButtonSelectPhotoLogsLocation.Click
        Me.SelectFolderLocation(Me.TextBoxPhotoLogsLocation)
    End Sub
End Class
