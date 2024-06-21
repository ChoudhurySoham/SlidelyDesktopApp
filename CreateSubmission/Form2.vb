Imports System.Net
Imports System.IO
Imports System.Security.Policy
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class Form2
    Private currentIndex As Integer = 0
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CODE TO FETCH THE FIRST RECORD BY DEFAULT
        LoadSubmission(currentIndex)
    End Sub
    Private Sub btnPrevious2_Click(sender As Object, e As EventArgs) Handles btnPrevious2.Click
        'CODE TO FETCH THE PREVIOUS RECORD
        If currentIndex > 0 Then
            currentIndex -= 1
            LoadSubmission(currentIndex)
        End If
    End Sub

    Private Sub btnPrevious2_KeyDown(sender As Object, e As KeyEventArgs) Handles btnPrevious2.KeyDown
        If e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious2_Click(sender, e)
        End If
    End Sub

    Private Sub btnNext2_Click(sender As Object, e As EventArgs) Handles btnNext2.Click
        'CODE TO FETCH THE NEXT RECORD
        currentIndex += 1
        LoadSubmission(currentIndex)
    End Sub

    Private Sub btnNext2_KeyDown(sender As Object, e As KeyEventArgs) Handles btnNext2.KeyDown
        If e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.N Then
            btnNext2_Click(sender, e)
        End If
    End Sub

    Private Sub LoadSubmission(index As Integer)
        Try
            Dim url As String = "http://localhost:3000/read?index=" & index.ToString()
            Dim result As String = GetJson(url)

            Dim submission As Dictionary(Of String, String) = ParseJson(result)
            If submission IsNot Nothing Then
                tbName2.Text = submission("name")
                tbEmail2.Text = submission("email")
                tbPhoneNum2.Text = submission("phone")
                tbGitHub2.Text = submission("github_link")
                tbStopWatch2.Text = submission("stopwatch_time")
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading submission: " & ex.Message)
        End Try
    End Sub

    Private Function GetJson(url As String) As String
        Dim httpWebRequest As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
        httpWebRequest.ContentType = "application/json"
        httpWebRequest.Method = "GET"

        Dim httpResponse As HttpWebResponse = CType(httpWebRequest.GetResponse(), HttpWebResponse)
        Using streamReader As New StreamReader(httpResponse.GetResponseStream())
            Return streamReader.ReadToEnd()
        End Using
    End Function

    Private Function ParseJson(json As String) As Dictionary(Of String, String)
        Dim submission As New Dictionary(Of String, String)
        Dim jsonObj As JObject = JObject.Parse(json)
        If jsonObj IsNot Nothing Then
            submission("name") = jsonObj("name").ToString()
            submission("email") = jsonObj("email").ToString()
            submission("phone") = jsonObj("phone").ToString()
            submission("github_link") = jsonObj("github_link").ToString()
            submission("stopwatch_time") = jsonObj("stopwatch_time").ToString()
        End If
        Return submission
    End Function
End Class