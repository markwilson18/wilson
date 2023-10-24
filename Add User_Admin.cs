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
    public partial class frm_Add_User_Admin : Form
    {
        public frm_Add_User_Admin()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Edit(false);
            tbllogBindingSource.ResetBindings(false);
        }

        private void Add_User_Admin_Load(object sender, EventArgs e)
        {
            this.tbllogTableAdapter.Fill(this.appData.tbllog);
            Edit(false);
            if (ulog.type == "A")
            {
                btn_new.Visible = true;
                btn_edit.Visible = true;
                btn_save.Visible = true;
                btn_delete.Visible = true;
                btn_cancel.Visible = true;

            }
            else if (ulog.type == "U")
            {
                btn_new.Visible = true;
                btn_edit.Visible = false;
                btn_save.Visible = true;
                btn_delete.Visible = false;
                btn_cancel.Visible = true;
            }
        }

        private void Edit(bool value)
        {
            txt_userName.Enabled = value;
            txt_password.Enabled = value;
            cb_role.Enabled = value;
        }
        private void btn_new_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(true);
                appData.tbllog.AddtbllogRow(appData.tbllog.NewtbllogRow());
                tbllogBindingSource.MoveLast();
                txt_userName.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appData.tbllog.RejectChanges();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Edit(true);
            txt_userName.Focus();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false);
                tbllogBindingSource.EndEdit();
                tbllogTableAdapter.Update(appData.tbllog);
                dgv_adminuser.Refresh();
                txt_userName.Focus();
                MessageBox.Show("Your data has been successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appData.tbllog.RejectChanges();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tbllogBindingSource.RemoveCurrent();
            }
        }

        private void dgv_adminuser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cb_role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_userName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
