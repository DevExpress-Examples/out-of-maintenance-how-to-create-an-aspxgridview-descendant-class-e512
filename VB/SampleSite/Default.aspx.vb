Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
		CustomGridView1.DataSource = GetDataTable()
		CustomGridView1.DataBind()
	End Sub

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

	End Sub

	Private Function GetDataTable() As Object
		Dim table As New DataTable()
		table.Columns.Add("ID", GetType(Integer))
		table.Columns.Add("ItemName", GetType(String))
		For i As Integer = 1 To 10
			table.Rows.Add(i, "Item " & i.ToString())
		Next i
		Return table
	End Function
End Class