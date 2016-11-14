Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class Class1
    Public Function ketnoi() As String
        Dim chuoiketnoi As String = "Data Source=(local);AttachDbFilename=" + My.Application.Info.DirectoryPath.ToString + "\QuanLyThuVien_db.mdf;Integrated Security=True"

        Return chuoiketnoi
    End Function

    Public Function source() As String
        Dim chuoiketnoi As String = "Data Source=(local);AttachDbFilename=" + My.Application.Info.DirectoryPath.ToString + "\QuanLyThuVien_db.mdf;Integrated Security=True"
        Return chuoiketnoi
    End Function


End Class
