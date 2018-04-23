using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.Web.ASPxEditors;

namespace WebApplication156
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && !IsCallback)
            {
                cmbRating.Value = "1";
            }
            UpdateImage(cmbRating);
        }
        void UpdateImage(ASPxComboBox cb)
        {
            if (cb.SelectedItem != null)
            {
                cb.BackgroundImage.ImageUrl = cb.SelectedItem.ImageUrl;
                cb.BackgroundImage.Repeat = DevExpress.Web.ASPxClasses.BackgroundImageRepeat.NoRepeat;
                cb.BackgroundImage.HorizontalPosition = "2px";
                cb.BackgroundImage.VerticalPosition = "50%";
            }
        }
    }
}
