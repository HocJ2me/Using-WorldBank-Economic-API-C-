using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using MySql.Data.MySqlClient;

namespace Economic_API
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        String getJSON(String url)
        {
            // replace guest:guest with your key
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            //Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            String responseFromServer;
            using (Stream dataStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);
                responseFromServer = reader.ReadToEnd();

            }
            //Console.WriteLine(responseFromServer);

            response.Close();
            return responseFromServer;
        }

        void LoadCountry(String id_country)
        {
            dynamic dataWB = JObject.Parse(getJSON("https://api.worldbank.org/v2/sources/2/country/" + id_country + "/metadata?format=json"));
            dynamic sourceJSON = dataWB.source;
            dynamic conceptJSON = sourceJSON[0].concept;
            conceptJSON = conceptJSON[0].variable;
            conceptJSON = conceptJSON[0];
            int length = ((JArray)conceptJSON["metatype"]).Count;
            //Console.WriteLine(length);
            conceptJSON = conceptJSON.metatype;
            for (int id_meta = 0; id_meta < length; id_meta++)
            {
                if (conceptJSON[id_meta].id == "CurrencyUnit") lblCurrence.Text = "Đồng tiền: " + conceptJSON[id_meta].value;
                if (conceptJSON[id_meta].id == "IncomeGroup") lblGroup.Text = "Nhóm nước có thu nhập: " + conceptJSON[id_meta].value;
                if (conceptJSON[id_meta].id == "LongName") lblNameCountry.Text = "Tên quốc gia: " + conceptJSON[id_meta].value;
                if (conceptJSON[id_meta].id == "Region") lblArea.Text = "Khu vực: " + conceptJSON[id_meta].value;
            }

        }

        void LoadGDPCountry(String id_country)
        {
            String strJSON = getJSON("https://api.worldbank.org/v2/country/" + id_country + "/indicator/NY.GDP.MKTP.CD?format=json");
            Console.WriteLine(strJSON);
            strJSON = "{\"data\":" + strJSON + "}";
            dynamic dataWB = JObject.Parse(strJSON);
            dataWB = dataWB.data;
            dynamic sourceJSON = dataWB[1];
            int length = ((JArray)sourceJSON).Count;
            Console.WriteLine(length);
            lblGDP.Text = "GDP: " + sourceJSON[1].value.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("en-us"));
            chrGDP.Series["GDP"].Points.Clear();
            for (int i = length-1; i>0; i--)
            {
                chrGDP.Series["GDP"].Points.AddXY( sourceJSON[i].date.ToString(), sourceJSON[i].value.ToString("C"));
            }    
        }
        private void formMain_Load(object sender, EventArgs e)
        {
            
            
            //lblNameCountry.Text = "Tên quốc gia: " + conceptJSON[10].value;
            //lblArea.Text = "Khu vực: " + conceptJSON[14].value;
            //dynamic parseSource = JObject.Parse(sourceJSON);
            //Console.WriteLine(parseSource.name);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String id_country = "-1";
            for(int i=1;i<=6;i++)
            {
                String strJSON = getJSON("https://api.worldbank.org/v2/country?page=" + i.ToString() + "&format=json");
                strJSON = "{\"data\":" + strJSON + "}";
                dynamic dataWB = JObject.Parse(strJSON);
                dataWB = dataWB.data;
                dynamic sourceJSON = dataWB[1];
                int length = ((JArray)sourceJSON).Count;
                for(int id = 0;id < length;id++)
                {

                    Console.WriteLine(sourceJSON[id].name);
                    if ( sourceJSON[id].name.ToString().ToLower() == tbxNameCountry.Text.ToString().ToLower())
                    {
                        id_country = sourceJSON[id].id;
                        break;
                    }
                }
                if (id_country != "-1") break;
                

            }
            if (id_country == "-1") MessageBox.Show("Không tìm thấy tên quốc gia");
            else
            {
                MessageBox.Show(tbxNameCountry.Text + " : " +id_country);
                LoadCountry(id_country);
                LoadGDPCountry(id_country);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=dlgdp;";
                string query = " CREATE TABLE `dlgdp`.`" + tbxNameCountry.Text.ToLower() + "` (`date` INT NOT NULL , `value` DOUBLE NOT NULL ) ENGINE = InnoDB;";

                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;

                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("Tạo bảng oke");

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            StringBuilder command = new StringBuilder();


            foreach (var value in chrGDP.Series["GDP"].Points)
            {

                command.Append("INSERT INTO " + tbxNameCountry.Text.ToLower() + "(`date`, `value`) VALUES ('" + value.AxisLabel.ToString() + "', '" + value.YValues[0].ToString() + "');"); ;
                Console.WriteLine();

            }

            try
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=dlgdp;";

                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(command.ToString(), databaseConnection);
                commandDatabase.CommandTimeout = 60;

                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                MessageBox.Show("Cập nhật dữ liệu Oke");

                databaseConnection.Close();
            }
            catch
            {

            }
        }
    }
}
