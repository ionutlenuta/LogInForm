using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginForm
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void buttonLog_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection con = new SqlConnection(@"server=DESKTOP-DJK1SUC\SQLEXPRESS;database=Log;Integrated Security=true");
				SqlCommand com = new SqlCommand("SELECT * FROM Table_log WHERE username=@user and password=@password", con);
				con.Open();
				com.Parameters.AddWithValue("@user", textBoxUser.Text);
				com.Parameters.AddWithValue("@password", textBoxPass.Text);
				SqlDataReader Dr = com.ExecuteReader();
				if (Dr.HasRows == true)
				{
					MessageBox.Show("Corrected!");
				}
				else
				{ MessageBox.Show("Check your username and password again!"); }
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			bool check = checkBox1.Checked;
			if (check == true)
				textBoxPass.UseSystemPasswordChar = false;
			else
				textBoxPass.UseSystemPasswordChar = true;


		}
	}
}