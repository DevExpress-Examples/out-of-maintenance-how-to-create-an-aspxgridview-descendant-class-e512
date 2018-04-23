<%@ Page Language="vb" AutoEventWireup="true"  CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v12.2, Version=12.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dxwgv" %>
<%@ Register Assembly="DevExpress.Web.v12.2, Version=12.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>
<%@ Register Assembly="CustomGridView, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cdac251a4e3de10f"
	Namespace="CustomGridView" TagPrefix="cgv" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>Untitled Page</title>
</head>
<body>
	<form id="form1" runat="server">
	<div>
		<cgv:CustomGridView ID="CustomGridView1" runat="server" AutoGenerateColumns="False"
			KeyFieldName="ID">
			<Columns>
				<dxwgv:GridViewDataTextColumn FieldName="ID" ReadOnly="True" VisibleIndex="0">
				</dxwgv:GridViewDataTextColumn>
				<dxwgv:GridViewDataTextColumn FieldName="ItemName" VisibleIndex="1">
				</dxwgv:GridViewDataTextColumn>
			</Columns>
		</cgv:CustomGridView>
	</form>
</body>
</html>