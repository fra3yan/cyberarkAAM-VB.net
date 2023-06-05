Imports System.Security
Imports CyberArk.AAM.NetStandardPasswordSDK
Imports CyberArk.AIM.NetPasswordSDK.Exceptions
Imports System
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class Form1
    Dim con As New MySqlConnection("server=localhost;user=root;Password=;database=world;sslMode=none")
    Dim cmd As MySqlCommand
    Dim dr As MySqlDataReader
    Dim sql As String
    Dim result As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim password As PSDKPassword = Nothing
        Try
            Dim passRequest As PSDKPasswordRequest = New PSDKPasswordRequest()

            passRequest.AppID = "anggi"
            passRequest.Safe = "dummy"
            passRequest.Folder = "root"
            passRequest.Object = "anggi-test"
            passRequest.Reason = "Testing to mysql"
            passRequest.Query = "Safe=dummy;Object=anggi-test"
            passRequest.RequiredProperties.Add("PolicyId")
            passRequest.RequiredProperties.Add("userName")
            passRequest.RequiredProperties.Add("Address")

            password = PasswordSDK.GetPassword(passRequest)
            Console.WriteLine(password.UserName)
            'Use password properties
            'password.UserName
            'password.Address
            'password.GetAttribute("PassProps.PolicyId")
        Catch ex As PSDKException
            Console.WriteLine(ex.Reason)
        Finally

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            con.Open()
            sql = "SELECT * FROM country"
            cmd = New MySqlCommand
            With cmd
                .Connection = con
                .CommandText = sql
                dr = .ExecuteReader()
            End With
            ListView1.Items.Clear()
            Do While dr.Read = True
                Dim list = ListView1.Items.Add(dr(1))
                list.SubItems.Add(dr(2))
                list.SubItems.Add(dr(3))
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class
