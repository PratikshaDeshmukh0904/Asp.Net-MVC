using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticeLinq
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Using Lambda Expression
            IEnumerable<Student> queryResult = Student.GetAllStudents().Where(student => student.Gender == "Female");
            gridview1.DataSource = queryResult;
            gridview1.DataBind();

            //Using Sql like query Expression 
            IEnumerable<Student> queryResult1 = from student in Student.GetAllStudents() where student.Gender == "male" select student ;
            gridview2.DataSource = queryResult1;
            gridview2.DataBind();
        }
    }
}