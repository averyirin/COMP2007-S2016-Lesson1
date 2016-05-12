using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lesson_1
{
    public partial class Default : System.Web.UI.Page //extends
    {

        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            FullNameTextBox.Text = FirstNameTextBox.Text.ToString() + " " + LastNameTextBox.Text.ToString();
        }

     
    }
}