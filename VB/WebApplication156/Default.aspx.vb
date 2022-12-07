Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web

Namespace WebApplication156
	Partial Public Class _Default
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			If (Not IsPostBack) AndAlso (Not IsCallback) Then
				cmbRating.Value = "1"
			End If
			UpdateImage(cmbRating)
		End Sub
		Private Sub UpdateImage(ByVal cb As ASPxComboBox)
			If cb.SelectedItem IsNot Nothing Then
				cb.BackgroundImage.ImageUrl = cb.SelectedItem.ImageUrl
				cb.BackgroundImage.Repeat = DevExpress.Web.BackgroundImageRepeat.NoRepeat
				cb.BackgroundImage.HorizontalPosition = "2px"
				cb.BackgroundImage.VerticalPosition = "50%"
			End If
		End Sub
	End Class
End Namespace
