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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Net.WebRequestMethods;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics.Eventing.Reader;
using System.Data.SqlClient;
using Cseresznye_TAAYQB;

namespace Cseresznye_TAAYQB
{
    public partial class Form3 : Form
    {
        StockData deserialized = new StockData();

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            RestClient rClient = new RestClient();
            rClient.endPoint = textBox1.Text;

            string strResponse = rClient.makeRequest();

            deserialized = JsonConvert.DeserializeObject<StockData>(strResponse);

            if (deserialized != null)
            {
                DataTable table = Tablakeszito(deserialized.MonthlyTimeSeries);
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = table;
                dataGridView1.Columns["Date"].Visible = true;
                Diagramkeszito(deserialized.MonthlyTimeSeries, deserialized.MetaData);
            }
            else
            {
                MessageBox.Show("Nem sikerült a JSON forma importálása");
            }
        }

        private DataTable Tablakeszito(Dictionary<string, MonthlyTimeSeries> monthlyData)
        {
            DataTable table = new DataTable();

            table.Columns.Add("Date", typeof(string));
            table.Columns.Add("Open", typeof(decimal));
            table.Columns.Add("High", typeof(decimal));
            table.Columns.Add("Low", typeof(decimal));
            table.Columns.Add("Close", typeof(decimal));
            table.Columns.Add("Volume", typeof(long));

            foreach (var rekord in monthlyData)
            {
                var date = rekord.Key;
                var data = rekord.Value;

                table.Rows.Add(
                    date,
                    decimal.Parse(data.Open, CultureInfo.InvariantCulture),
                    decimal.Parse(data.High, CultureInfo.InvariantCulture),
                    decimal.Parse(data.Low, CultureInfo.InvariantCulture),
                    decimal.Parse(data.Close, CultureInfo.InvariantCulture),
                    long.Parse(data.Volume, CultureInfo.InvariantCulture)
                );
            }

            return table;
        }

        private void Diagramkeszito(Dictionary<string, MonthlyTimeSeries> monthlyData, MetaData metaData)
        {
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();

            var chartArea = new ChartArea("MainChartArea")
            {
                AxisX =
                {
                    Title = "Date",
                    IntervalType = DateTimeIntervalType.Months,
                    Interval = 20, //csak így fér el
                    IsLabelAutoFit = true,
                    LabelStyle = { Format = "yyyy-MM-dd" }
                },
                AxisY =
                {
                    Title = "Ár (USD)",
                    LabelStyle = { Format = "0.00" }
                }
            };

            chart1.ChartAreas.Add(chartArea);

            var series = new Series("Closing Price")
            {
                ChartType = SeriesChartType.Line,
                XValueType = ChartValueType.DateTime,
                YValueType = ChartValueType.Double
            };
            chart1.Series.Add(series);

            foreach (var entry in monthlyData.OrderBy(x => x.Key))
            {
                string date = entry.Key;
                decimal closePrice = decimal.Parse(entry.Value.Close, CultureInfo.InvariantCulture);

                series.Points.AddXY(DateTime.Parse(date), closePrice);
            }

            chart1.Titles.Clear();
            chart1.Titles.Add(metaData.Symbol);

            chartArea.AxisX.LabelAutoFitMaxFontSize = 8;
            chartArea.AxisX.LabelAutoFitMinFontSize = 6;

            chart1.Invalidate();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (deserialized != null)
            {
                Elemző(deserialized.MonthlyTimeSeries);
            }
            else
            {
                MessageBox.Show("Nincs megadva URL!");
            }
        }


        private void Elemző(Dictionary<string, MonthlyTimeSeries> monthlyData)
        {
            try
            {
                decimal legmagasabb = decimal.MinValue;
                string legmagasabbdatum = string.Empty;
                decimal nagykulnbseg = decimal.MinValue;
                string datum1 = string.Empty;
                string datum2 = string.Empty;

                decimal elozozar = decimal.MinValue;
                string elozodatum = string.Empty;
                foreach (var entry in monthlyData.OrderBy(x => x.Key))
                {
                    string simadatum = entry.Key;
                    decimal simazaroar = decimal.Parse(entry.Value.Close, CultureInfo.InvariantCulture);

                    if (simazaroar > legmagasabb)
                    {
                        legmagasabb = simazaroar;
                        legmagasabbdatum = simadatum;
                    }

                    if (elozozar != decimal.MinValue)
                    {
                        decimal abskulunbseg = Math.Abs(simazaroar - elozozar);

                        if (abskulunbseg > nagykulnbseg)
                        {
                            nagykulnbseg = abskulunbseg;
                            datum1 = elozodatum;
                            datum2 = simadatum;
                        }
                    }

                    elozodatum = simadatum;
                    elozozar = simazaroar;
                }

                richTextBox1.Clear();
                richTextBox1.AppendText($"Legmagasabb ár: {legmagasabb}\n");
                richTextBox1.AppendText($"Legmagasabb ár dátuma: {legmagasabbdatum}\n");

                if (nagykulnbseg != decimal.MinValue)
                {
                    richTextBox1.AppendText($"\nLegnagyobb különbség: {nagykulnbseg} ami: {datum1} között {datum2} volt.\n");
                }
                else
                {
                    richTextBox1.AppendText("\nNem található jelentős különbség.\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Hiba");
            }
        }



        private void chart1_Click(object sender, EventArgs e)
        {
        }
        private void btnCsv_Click_1(object sender, EventArgs e)
        {
            if (deserialized?.MetaData != null)
            {
                ExportToCsv(deserialized.MetaData);
            }
            else
            {
                MessageBox.Show("Jelenleg nincs Stock adat betöltve!");
            }
        }

        private void ExportToCsv(MetaData metaData)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "CSV file (*.csv)|*.csv|Text file (*.txt)|*.txt|All files (*.*)|*.*",
                    FileName = $"{metaData.Symbol}.csv"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        foreach (DataGridViewColumn oszlop in dataGridView1.Columns)
                        {
                            writer.Write(oszlop.HeaderText + ",");
                        }
                        writer.WriteLine();

                        foreach (DataGridViewRow sor in dataGridView1.Rows)
                        {
                            foreach (DataGridViewCell cell in sor.Cells)
                            {
                                writer.Write(cell.Value?.ToString() + ",");
                            }
                            writer.WriteLine();
                        }
                    }
                    MessageBox.Show("Adatok sikeres exportálása");
                }
            }
            else
            {
                MessageBox.Show("A mentés nem sikerült!");
            }
        }



    }
}
