using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaunryManager
{
    public partial class newService : Form
    {
        databaseContext db = new databaseContext();
        public newService()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveButtonHandler();
        }

        private void saveButtonHandler()
        {
            String serviceName = txtServiceName.Text.ToString();
            String price = txtPrice.Text.ToString();
            if (validateFields(serviceName, price))
            {
                if (checkPriceDataType(price))
                {
                    if (checkServiceExist(serviceName))
                    {
                        addNewService(serviceName, Convert.ToInt32(price));
                    }
                    else
                    {
                        showServiceError();
                    }
                }
                else
                {
                    showPriceDataTypeErr();
                }
            }
        }

        private void addNewService(string serviceName, int price)
        {
            try
            {
                SqlConnection conn = db.getConnection();
                String query = "INSERT INTO Services (serviceName,price) VALUES (@serviceName,@price)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@serviceName", SqlDbType.NVarChar).Value = serviceName;
                    cmd.Parameters.Add("@price", SqlDbType.Int).Value = price;
                    conn.Open();
                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                    {
                        showSuccessMessage();
                        resetField();
                    }
                    else
                    {
                        showAddServiceErr();
                    }
                    conn.Close();
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private static void showPriceDataTypeErr()
        {
            MessageBox.Show("Price must be numberic!");
        }

        private bool checkPriceDataType(String price)
        {
            int i;
            bool check = int.TryParse(price, out i);
            return check;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Boolean validateFields(string serviceName, String price)
        {
            if (serviceName.Equals("") && price.Equals(""))
            {
                nameErr.Visible = true;
                priceErr.Visible = true;
                return false;
            }
            else if (serviceName.Equals(""))
            {
                nameErr.Visible = true;
                return false;
            }
            else if (priceErr.Equals(""))
            {
                priceErr.Visible = true;
                return false;
            }
            else
            {
                return true;
            }
        }

        private Boolean checkServiceExist(String serviceName)
        {
            String query;
            int count = 0;
            SqlConnection conn = db.getConnection();
            query = "select * from Services where serviceName = '" + serviceName + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dbr;
            conn.Open();
            dbr = cmd.ExecuteReader();
            while (dbr.Read())
            {
                count = count + 1;
            }
            conn.Close();
            if (count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void resetField()
        {
            txtServiceName.Text = "";
            txtPrice.Text = "";
        }

        private static void showSuccessMessage()
        {
            MessageBox.Show("New service added!");
        }

        private static void showServiceError()
        {
            MessageBox.Show("This service is exist!");
        }

        private static void showAddServiceErr()
        {
            MessageBox.Show("Have an error when add new service!");
        }

        private void txtServiceName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                saveButtonHandler();
            }
        }

        private void txtPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                saveButtonHandler();
            }
        }
    }
}
