Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.ComponentModel
Imports DevExpress.Web.ASPxGridView
Imports DevExpress.Web.ASPxGridView.Design
Imports System.Windows.Forms

Namespace CustomGridView
	<ToolboxItem(False)> _
	Public Class CustomGridViewDesigner
		Inherits GridViewDesigner
		Public Overrides Sub Initialize(ByVal component As IComponent)
			MyBase.Initialize(component)
			RegisterTagPrefix(GetType(ASPxGridView))
		End Sub
	End Class
End Namespace
