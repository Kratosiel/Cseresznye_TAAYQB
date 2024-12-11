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
using Newtonsoft.Json;
using Microsoft.VisualBasic;
using Cseresznye_TAAYQB;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cseresznye_TAAYQB
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            richTextBox2.Text = "{\r\n    \"Meta Data\": {\r\n        \"1. Information\": \"Monthly Prices (open, high, low, close) and Volumes\",\r\n        \"2. Symbol\": \"TSCO.LON\",\r\n        \"3. Last Refreshed\": \"2024-12-09\",\r\n        \"4. Time Zone\": \"US/Eastern\"\r\n    },\r\n    \"Monthly Time Series\": {\r\n        \"2024-12-09\": {\r\n            \"1. open\": \"367.1000\",\r\n            \"2. high\": \"375.3000\",\r\n            \"3. low\": \"363.9000\",\r\n            \"4. close\": \"364.8000\",\r\n            \"5. volume\": \"119675688\"\r\n        },\r\n        \"2024-11-29\": {\r\n            \"1. open\": \"343.4000\",\r\n            \"2. high\": \"367.7000\",\r\n            \"3. low\": \"337.9000\",\r\n            \"4. close\": \"366.4000\",\r\n            \"5. volume\": \"569858574\"\r\n        },\r\n        \"2024-10-31\": {\r\n            \"1. open\": \"358.6000\",\r\n            \"2. high\": \"368.4000\",\r\n            \"3. low\": \"337.7000\",\r\n            \"4. close\": \"342.2000\",\r\n            \"5. volume\": \"503130555\"\r\n        },\r\n        \"2024-09-30\": {\r\n            \"1. open\": \"354.7000\",\r\n            \"2. high\": \"373.9000\",\r\n            \"3. low\": \"353.1934\",\r\n            \"4. close\": \"358.7000\",\r\n            \"5. volume\": \"354750557\"\r\n        },\r\n        \"2024-08-30\": {\r\n            \"1. open\": \"331.2000\",\r\n            \"2. high\": \"354.6000\",\r\n            \"3. low\": \"316.7000\",\r\n            \"4. close\": \"353.7000\",\r\n            \"5. volume\": \"373645331\"\r\n        },";
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            RestClient rClient = new RestClient();
            rClient.endPoint = textBox1.Text;

            string strResponse = string.Empty;
            strResponse = rClient.makeRequest();
            if (strResponse != string.Empty)
            {
                kiiras("Rest Client elkészítve");
                kiiras(strResponse);
            }
            else { kiiras("Hibás url"); }
         
        }

        private void kiiras(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                richTextBox1.Text = richTextBox1.Text + strDebugText + Environment.NewLine;
                richTextBox1.SelectionStart = richTextBox1.TextLength;
                richTextBox1.ScrollToCaret();

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

       
        


    }

}
