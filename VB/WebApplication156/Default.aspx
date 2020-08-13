<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="WebApplication156._Default" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.15.0, Culture=neutral, PublicKeyToken=B88D1754D700E49A"
	Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dxe" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>Untitled Page</title>
</head>
<body>
<script type="text/javascript">
function SetComboBoxImage(s){
	var cbstyle = s.mainElement.style;
	cbstyle.backgroundImage = 'url('+(s.GetSelectedItem().imageUrl)+')';
	cbstyle.backgroundRepeat = "no-repeat";    
	cbstyle.backgroundPosition = "2px";
}
</script>
	<form id="form1" runat="server">
	<div>
		<dxe:ASPxComboBox BackgroundImage-Repeat="NoRepeat" BackgroundImage-HorizontalPosition="left" ID="cmbRating" runat="server" ClientInstanceName="cmbRating" ValueType="System.String" Height="32px" >            
		<Items>
			<dxe:ListEditItem Text="Good" Value="0" ImageUrl="~/Images/good.gif" />
			<dxe:ListEditItem Text="Average" Value="1" ImageUrl="~/Images/average.gif" />
			<dxe:ListEditItem Text="Poor" Value="3" ImageUrl="~/Images/poor.gif"/>            
		</Items>                
			<ClientSideEvents SelectedIndexChanged="function(s, e) { SetComboBoxImage(s); }" />
			<Paddings PaddingLeft="30px" />
			<BackgroundImage HorizontalPosition="left" Repeat="NoRepeat" />
		</dxe:ASPxComboBox>

	</div>
		<dxe:ASPxButton ID="ASPxButton1" runat="server" Text="ASPxButton">
		</dxe:ASPxButton>
		&nbsp;
	</form>
</body>
</html>
