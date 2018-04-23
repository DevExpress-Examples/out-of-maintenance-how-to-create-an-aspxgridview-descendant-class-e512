Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.ComponentModel
Imports System.Windows.Forms
Imports DevExpress.Web.ASPxGridView.Design
Imports DevExpress.Web.ASPxGridView

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
