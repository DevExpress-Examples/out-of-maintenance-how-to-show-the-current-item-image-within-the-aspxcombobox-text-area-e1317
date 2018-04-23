# How to show the current item image within the ASPxComboBox text area


<p>To accomplish this task, handle the client-side SelectedIndexChanged event, and change the background image of the control's main HTML element. Also, you should set the ASPxComboBox.BackgroundImage.ImageUrl on the server side to synchronize the selected image. Surely, it is necessary to manually adjust paddings and control height.</p><p>This functionality is implemented in version 9.2 (see <a href="https://www.devexpress.com/Support/Center/p/S18329">ASPxComboBox - Show the selected item's image within the editor's edit area</a>).</p>

<br/>


