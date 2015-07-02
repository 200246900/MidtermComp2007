using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using COMP2007Midterm.Models;

namespace COMP2007Midterm.SchoolCourses
{
    public partial class Default : System.Web.UI.Page
    {
		protected COMP2007Midterm.Models.MidtermEntities _db = new COMP2007Midterm.Models.MidtermEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        // Model binding method to get List of SchoolCours entries
        // USAGE: <asp:ListView SelectMethod="GetData">
        public IQueryable<COMP2007Midterm.Models.SchoolCours> GetData()
        {
            return _db.SchoolCourses;
        }
    }
}

