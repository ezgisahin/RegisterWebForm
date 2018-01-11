using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegisterWebForm
{
    public partial class tckimlik : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (var client = new ServiceReference1.KPSPublicSoapClient("KPSPublicSoap"))
            {
                var result = client.TCKimlikNoDogrula(Convert.ToInt64(this.TextBox1.Text), this.TextBox2.Text, this.TextBox3.Text, Convert.ToInt32(this.TextBox4.Text));
                if (result == true)
                {
                    this.Literal1.Text = "TC Kimlik doğrulandı.";
                }
                else
                {
                    this.Literal1.Text = "Geçersiz kimlik no!";
                }
            }
        }
    }
}