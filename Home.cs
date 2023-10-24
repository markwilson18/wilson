using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KLL_COMPUTER_STUDIES_LOGIN_FORM
{
    public partial class frm_Home : Form
    {
        public frm_Home(string log)
        {
            InitializeComponent();
            lbl_loguser.Text = log;
        }



        private void btn_adduseradmin_Click(object sender, EventArgs e)
        {
            frm_Add_User_Admin fau = new frm_Add_User_Admin();
            fau.ShowDialog();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            frm_login fl = new frm_login();
            fl.Show();
            this.Hide();
        }

        private void frm_Home_Load(object sender, EventArgs e)
        {
            if(ulog.type == "A")
            {
                btn_adduseradmin.Visible = true;
                btn_attendance.Visible = true;
                btn_settings.Visible = true;
                btn_Student.Visible = true;

            }
            else if (ulog.type == "U")
            {
                btn_adduseradmin.Visible = true;
                btn_attendance.Visible = true;
                btn_settings.Visible = false;
                btn_Student.Visible = true;
            }
        }

        private void btn_Student_Click(object sender, EventArgs e)
        {
           frm_Students frm_Students = new frm_Students();
            frm_Students.ShowDialog();
        }

        private void lbl_loguser_Click(object sender, EventArgs e)
        {

        }

        private void btn_settings_Click_1(object sender, EventArgs e)
        {

        }

    
    }
}
