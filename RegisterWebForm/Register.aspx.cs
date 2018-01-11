using RegisterWebForm.Data;
using RegisterWebForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegisterWebForm
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (this.IsValid)
            {
                //veritabanına ekleme işlemi yapılır.
                using (var db = new RegisterModel())
                {
                    var user = new User();
                    user.Email = this.TextBox1.Text;
                    user.Password = this.TextBox2.Text;
                    user.EnableNotifications = this.CheckBox1.Checked;

                    db.Users.Add(user);
                    db.SaveChanges();
                }
            }
        }
    }
}