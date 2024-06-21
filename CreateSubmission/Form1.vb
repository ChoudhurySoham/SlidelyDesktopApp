Imports System.CodeDom.Compiler
Imports System.Diagnostics.Eventing.Reader
Imports System.Net
Imports System.Text
Imports System.IO

Public Class Form1

    Dim ss, tt, vv As Integer
    Dim t As Integer = 0



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timerBox.Text = Format(ss, "00:") & Format(tt, "00:") & Format(vv, "00")
        vv = vv + 1
        If vv > 59 Then
            vv = 0
            tt = tt + 1
        End If
    End Sub

    Private Sub btnStopWatch_Click(sender As Object, e As EventArgs) Handles btnStopWatch.Click
        If (t = 0) Then
            Timer1.Enabled = True
            t = 1
        Else
            Timer1.Enabled = False
            t = 0
        End If

    End Sub

    Private Sub btnStopWatch_KeyDown(sender As Object, e As KeyEventArgs) Handles btnStopWatch.KeyDown
        If e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.T Then
            btnStopWatch_Click(sender, e)
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' CODE TO POST DATA INTO THE DATABASE
        Dim name As String = tbName1.Text
        Dim email As String = tbEmail1.Text
        Dim phone As String = tbPhoneNum1.Text
        Dim github As String = tbGitHub1.Text
        Dim stopwatchTime As String = timerBox.Text

        Dim json As String = "{
            ""name"":""" & name & """,
            ""email"":""" & email & """,
            ""phone"":""" & phone & """,
            ""github_link"":""" & github & """,
            ""stopwatch_time"":""" & stopwatchTime & """
        }"

        Dim url As String = "http://localhost:3000/submit"
        Dim result As String = PostJson(url, json)
        MessageBox.Show(result)
    End Sub

    Private Function PostJson(url As String, jsonData As String) As String
        Dim httpWebRequest As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
        httpWebRequest.ContentType = "application/json"
        httpWebRequest.Method = "POST"

        Using streamWriter As New StreamWriter(httpWebRequest.GetRequestStream())
            streamWriter.Write(jsonData)
            streamWriter.Flush()
            streamWriter.Close()
        End Using

        Dim httpResponse As HttpWebResponse = CType(httpWebRequest.GetResponse(), HttpWebResponse)
        Using streamReader As New StreamReader(httpResponse.GetResponseStream())
            Return streamReader.ReadToEnd()
        End Using
    End Function

    Private Sub btnSubmit_KeyDown(sender As Object, e As KeyEventArgs) Handles btnSubmit.KeyDown
        If e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit_Click(sender, e)
        End If
    End Sub
End Class
