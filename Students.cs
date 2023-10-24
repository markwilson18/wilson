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
    public partial class frm_Students : Form
    {
        public frm_Students()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Students_Load(object sender, EventArgs e)
        {
            this.tableTableAdapter.Fill(this.dataApp.Table);
            Edit(false);
            if (ulog.type == "A")
            {
                btn_New.Visible = true;
                btn_Edit.Visible = true;
                btn_Save.Visible = true;
                btn_Delete.Visible = true;
                btn_Cancel.Visible = true;

            }
            else if (ulog.type == "U")
            {
                btn_New.Visible = true;
                btn_Edit.Visible = false;
                btn_Save.Visible = true;
                btn_Delete.Visible = false;
                btn_Cancel.Visible = true;
            }
        }

        private void Edit(bool value)
        {
            txt_Surname.Enabled = value;
            txt_Firstname.Enabled = value;
            txt_Middlename.Enabled = value;
            txt_Birthday.Enabled = value;
            txt_Address.Enabled = value;
            txt_Contactno.Enabled = value;
            txt_Courseyear.Enabled = value;
            cb_Role.Enabled = value;

        }
        private void btn_New_Click(object sender, EventArgs e)
        {
            Edit(true);
            dataApp.Table.AddTableRow(dataApp.Table.NewTableRow());
            tableBindingSource.MoveLast();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Edit(true);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Edit(false);
            tableBindingSource.EndEdit();
            tableTableAdapter.Update(dataApp.Table);
            dgv_studentslist.Refresh();
            txt_Surname.Focus();
            MessageBox.Show("Your Name has sucessfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
              {
                tableBindingSource.RemoveCurrent();
              }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Edit(false);
            tableBindingSource.CancelEdit();
        }
      }
   }
