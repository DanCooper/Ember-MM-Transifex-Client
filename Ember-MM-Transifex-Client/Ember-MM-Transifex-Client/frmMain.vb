Imports System.Xml.Serialization
Imports System.IO


Public Class frmMain

    Private SelectedText As String = String.Empty

    Private Sub mnuEditSettings_Click(sender As Object, e As EventArgs) Handles mnuEditSettings.Click
        Using dlgSettings As New dlgSettings
            dlgSettings.ShowDialog()
        End Using
    End Sub

    Private Function LoadXHML(ByVal sPath As String) As Transifex.Strings
        Dim xmlSer As XmlSerializer = Nothing
        Dim xmlMov As New Transifex.Strings

        If Not String.IsNullOrEmpty(sPath) Then
            Try
                If File.Exists(sPath) AndAlso Path.GetExtension(sPath).ToLower = ".xhtml" Then
                    Using xmlSR As StreamReader = New StreamReader(sPath)
                        xmlSer = New XmlSerializer(GetType(Transifex.Strings))
                        xmlMov = DirectCast(xmlSer.Deserialize(xmlSR), Transifex.Strings)
                    End Using
                End If
            Catch

            End Try

            If Not IsNothing(xmlSer) Then
                xmlSer = Nothing
            End If
        End If

        Return xmlMov
    End Function

    Private Sub SaveXHML(ByRef Translation As Transifex.Strings)

        Dim sPath As String = String.Empty

        Try
            With sfdFiles
                .Filter = String.Concat("New Filename", "|*.xhtml")
                .FilterIndex = 0
            End With

            If sfdFiles.ShowDialog() = DialogResult.OK Then
                sPath = sfdFiles.FileName
            End If
        Catch ex As Exception

        End Try
        Try
            If Not String.IsNullOrEmpty(sPath) Then
                Dim xmlSer As New XmlSerializer(GetType(Transifex.Strings))
                Dim doesExist As Boolean = False
                Dim fAtt As New FileAttributes
                Dim fAttWritable As Boolean = True

                doesExist = File.Exists(sPath)
                If Not doesExist OrElse (Not CBool(File.GetAttributes(sPath) And FileAttributes.ReadOnly)) Then
                    If doesExist Then
                        fAtt = File.GetAttributes(sPath)
                        Try
                            File.SetAttributes(sPath, FileAttributes.Normal)
                        Catch ex As Exception
                            fAttWritable = False
                        End Try
                    End If
                    Using xmlSW As New StreamWriter(sPath)
                        xmlSer.Serialize(xmlSW, Translation)
                    End Using
                    If doesExist And fAttWritable Then File.SetAttributes(sPath, fAtt)
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnLoadForTranslation_Click(sender As Object, e As EventArgs) Handles btnLoadForTranslation.Click
        Dim sPath As String = String.Empty

        Try
            With ofdFiles
                .Filter = String.Concat("for_translation", "|*.xhtml")
                .FilterIndex = 0
            End With

            If ofdFiles.ShowDialog() = DialogResult.OK Then
                sPath = ofdFiles.FileName
            End If
        Catch ex As Exception

        End Try

        If Not String.IsNullOrEmpty(sPath) Then
            FillForTranslations(LoadXHML(sPath))
        End If
    End Sub

    Private Sub btnLoadResource_Click(sender As Object, e As EventArgs) Handles btnLoadResource.Click
        Dim sPath As String = String.Empty

        Try
            With ofdFiles
                .Filter = String.Concat("for_use (eng)", "|*.xhtml")
                .FilterIndex = 0
            End With

            If ofdFiles.ShowDialog() = DialogResult.OK Then
                sPath = ofdFiles.FileName
            End If
        Catch ex As Exception

        End Try

        If Not String.IsNullOrEmpty(sPath) Then
            FillRecource(LoadXHML(sPath))
        End If
    End Sub

    Private Sub btnLoadTranslations_Click(sender As Object, e As EventArgs) Handles btnLoadTranslations.Click
        Dim sPath As String = String.Empty

        Try
            With ofdFiles
                .Filter = String.Concat("any *.xhtml file with translations", "|*.xhtml")
                .FilterIndex = 0
            End With

            If ofdFiles.ShowDialog() = DialogResult.OK Then
                sPath = ofdFiles.FileName
            End If
        Catch ex As Exception

        End Try

        If Not String.IsNullOrEmpty(sPath) Then
            FillTranslations(LoadXHML(sPath))
        End If
    End Sub

    Private Sub FillForTranslations(ByVal Translations As Transifex.Strings)

        Me.lvForTranslation.Items.Clear()

        Dim index As Integer = 0
        For Each tString In Translations.Strings
            Dim Item As New ListViewItem
            index = lvForTranslation.Items.Add(tString.ID).Index
            Me.lvForTranslation.Items(index).SubItems.Add(tString.Data)
            Me.lvForTranslation.Items(index).SubItems.Add(String.Empty)
            Me.lvForTranslation.Items(index).SubItems.Add(tString.Text)
            index = index + 1
        Next

    End Sub

    Private Sub FillRecource(ByVal Recources As Transifex.Strings)

        For Each tRecource In Recources.Strings
            For Each tItem As ListViewItem In Me.lvForTranslation.Items
                If tItem.SubItems(0).Text = tRecource.ID.ToString Then
                    tItem.SubItems(2).Text = tRecource.Text.ToString
                    Exit For
                End If
            Next
        Next

    End Sub

    Private Sub FillTranslations(ByVal Translations As Transifex.Strings)

        Dim index As Integer = 0
        For Each tString In Translations.Strings
            Dim Item As New ListViewItem
            index = lvTranslations.Items.Add(tString.ID).Index
            Me.lvTranslations.Items(index).SubItems.Add(tString.Text)
            index = index + 1
        Next

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lvForTranslation.AllowDrop = True
        Me.lvForTranslation.HideSelection = False
        Me.lvTranslations.HideSelection = False
    End Sub

    Private Sub lvTranslations_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvTranslations.SelectedIndexChanged
        If Me.lvTranslations.SelectedItems.Count = 1 Then
            Me.SelectedText = Me.lvTranslations.SelectedItems(0).SubItems(1).Text
        End If
    End Sub

    Private Sub lvForTranslation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvForTranslation.SelectedIndexChanged
        If Me.lvForTranslation.SelectedItems.Count = 1 Then
            Me.txtTranslation.Text = Me.lvForTranslation.SelectedItems(0).SubItems(3).Text
        End If
    End Sub

    Private Sub Check()
        If Me.lvForTranslation.SelectedItems(0).SubItems(3).Text = Me.txtTranslation.Text Then
            Me.btnSave.BackColor = Color.LightGreen
        Else
            Me.btnSave.BackColor = Color.IndianRed
        End If
    End Sub

    Private Sub SaveTranslation()
        If Me.lvForTranslation.SelectedItems.Count = 1 Then
            Me.lvForTranslation.SelectedItems(0).SubItems(3).Text = Me.txtTranslation.Text
        End If
        Check()
    End Sub

    Private Sub txtTranslation_TextChanged(sender As Object, e As EventArgs) Handles txtTranslation.TextChanged
        Check()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveTranslation()
    End Sub

    Private Sub lvTranslations_DoubleClick(sender As Object, e As EventArgs) Handles lvTranslations.DoubleClick
        If Me.lvTranslations.SelectedItems.Count = 1 Then
            Me.txtTranslation.Text = Me.lvTranslations.SelectedItems(0).SubItems(1).Text
        End If
    End Sub

    Private Sub mnuFileSave_Click(sender As Object, e As EventArgs) Handles mnuFileSave.Click
        Dim newTranslation As New Transifex.Strings

        For Each tItem As ListViewItem In Me.lvForTranslation.Items
            Dim tTrans As New Transifex.String
            tTrans.ID = tItem.SubItems(0).Text
            tTrans.Data = tItem.SubItems(1).Text
            tTrans.Text = tItem.SubItems(3).Text
            newTranslation.Strings.Add(tTrans)
        Next

        SaveXHML(newTranslation)
    End Sub
End Class
