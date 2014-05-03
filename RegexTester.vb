Imports System.String
Imports System.Text.RegularExpressions
Imports System.IO

Public Class RegexTester
    Private str_regex As String
    Private str_pattern As String = "^((\w+ *)+)[\s+|,?]+([A-Z][A-Z])?\s+(\d{5})?-?(\d{4})?$"
    Private matchobj As Match
    Private regexobj As New Regex(str_pattern, RegexOptions.IgnoreCase)
    Private regexArray As String()

    Private Sub BtnRegex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRegex.Click
        Try
            str_regex = txtRegex.Text
            str_pattern = txtExpression.Text
            txtGroups.Text = String.Empty
            regexArray = regexobj.Split(str_regex)

            Using fr As New StreamWriter(Me.txtLog.Text, False)
                Dim line As String = String.Empty
                Dim counter As Integer = 0
                Using fs As TextReader = File.OpenText(Me.txtRegex.Text)
                    While fs.Peek() <> -1
                        counter += 1
                        line = fs.ReadLine()

                        matchobj = Regex.Match(line, str_pattern)

                        If counter Mod 5 = 0 Then
                            txtGroups.Text = "Running."
                        ElseIf counter Mod 10 = 0 Then
                            txtGroups.Text = "Running.."
                        Else
                            txtGroups.Text = "Running..."
                        End If

                        fr.WriteLine(matchobj.Groups.Count.ToString)
                        For i As Int16 = 0 To matchobj.Groups.Count - 1
                            fr.WriteLine("-G" + i.ToString + ": " + matchobj.Groups(i).ToString)
                        Next
                    End While
                End Using
            End Using
            txtGroups.Text += vbNewLine + "Done."
            Process.Start(Me.txtLog.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtRegex_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtRegex.TextChanged
        Me.txtRegex.Text = Me.txtRegex.Text.Replace("""", "")
        Me.txtLog.Text = Me.txtRegex.Text
        If Me.txtLog.Text.Contains("\") Then
            Me.txtLog.Text = Me.txtLog.Text.Substring(0, Me.txtLog.Text.LastIndexOf("\") + 1)
            Me.txtLog.Text += "log.txt"
        End If
    End Sub
End Class
