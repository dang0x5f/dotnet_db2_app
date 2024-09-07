using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IBM.Data.DB2.iSeries;

namespace PixisAir_Team3_dg
{
    public partial class DanielsForm : Form
    {
        // Constants
        private const string CONNECTION_STRING = ""; // REMOVED
        private const string RES_TABLE = "Flight2023.ResHist";
        private const string CAR_TABLE = "Flight2023.Cars";

        // Database Components
        private iDB2Connection connection = null;
        private iDB2Command command = null;
        private iDB2DataReader reader = null;

        public DanielsForm()
        {
            InitializeComponent();
        }

        private void RESHISTButton_Click(object sender, EventArgs e)
        {
            ClearListBox();
            String sql = "SELECT * FROM " + RES_TABLE;
            SelectProcedure(sql);
        }
        
        private void CarsButton_Click(object sender, EventArgs e)
        {
            ClearListBox();
            String sql = "SELECT * FROM " + CAR_TABLE;
            SelectProcedure(sql);
        }

        private void SelectProcedure(string sql)
        {
            try
            {
                connection = new iDB2Connection(CONNECTION_STRING);
                connection.Open();

                command = new iDB2Command(sql, connection);

                reader = command.ExecuteReader();

                StringBuilder record = new StringBuilder();
                int fieldSize = reader.FieldCount;
                while (reader.Read())
                {
                    for (int i = 0; i < fieldSize; i++)
                    {
                        string trimmed = reader[i].ToString().Trim();
                        if (trimmed.Length < 10)
                        {
                            record.AppendFormat("{0,-12}", trimmed.PadLeft(10, ' '));
                        }
                        else
                        {
                            record.AppendFormat("{0,-12}", trimmed);
                        }
                    }

                    DB2DataListBox.Items.Add(record);
                    record.Clear();
                }

                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                DB2DataListBox.Items.Add(ex);
            }
        }

        private void AddCarButton_Click(object sender, EventArgs e)
        {
            if (ValidateTextBoxes())
            {
                Car car = new Car(int.Parse(IDTextBox.Text), MakeTextBox.Text, ModelTextBox.Text);

                string sql = "INSERT INTO Flight2023.Cars(ID, Make, Model) " +
                             "VALUES(" + car.ID + ", '" + car.Make + "', '" + car.Model + "')";
                InsertProcedure(sql);
            }
        }

        private void InsertProcedure(string sql)
        {
            ClearListBox();
            try
            {
                connection = new iDB2Connection(CONNECTION_STRING);
                connection.Open();

                command = new iDB2Command(sql, connection);
                command.ExecuteNonQuery();

                DB2DataListBox.Items.Add("Record Successfully Added.");
                connection.Close();
            }
            catch(Exception ex)
            {
                DB2DataListBox.Items.Add(ex.Message);
            }
        }

        private bool ValidateTextBoxes()
        {
            bool pass = true;

            // if cannot parse int, is greater than 5 digits, or is less than 0, fail
            if(!(int.TryParse(IDTextBox.Text, out int i)) || IDTextBox.Text.Length > 5 || i < 0)
            {
                ClearListBox();
                DB2DataListBox.Items.Add("Invalid ID value.");
                pass = false;     
            }   
            // if length is greater than 10 or empty, fail
            else if(MakeTextBox.Text.Length > 10 || MakeTextBox.Text.Length == 0)
            {
                ClearListBox();
                DB2DataListBox.Items.Add("Invalid Make value.");
                pass = false;
            }
            // if length is greater than 10 or empty, fail
            else if (ModelTextBox.Text.Length > 10 || ModelTextBox.Text.Length == 0)
            {
                ClearListBox();
                DB2DataListBox.Items.Add("Invalid Model value.");
                pass = false;
            }

            return pass;
        }

        public class Car
        {
            public int ID { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }

            public Car(int iD, string make, string model)
            {
                ID = iD;
                Make = make;
                Model = model;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearListBox();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearListBox()
        {
            if (DB2DataListBox.Items.Count > 0)
                DB2DataListBox.Items.Clear();
        }
    }
}
