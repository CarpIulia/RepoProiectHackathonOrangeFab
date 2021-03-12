using Statistici.controller;
using Statistici.repository;
using Statistici.service;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace Statistici
{
   /* enum busID
    {
        BV18DKZ = 16000081,
        BV18EIK = 16000082,
        BV18EHX = 16000086,
        BV18EIL = 16000087,
        BV18DKY = 1600008
    }*/

    public partial class Form1 : Form
    {
        private Dictionary<string, string> BusID = new Dictionary<string, string>();
        private DataAPI dataAPI;
        private RepoValidari repoValidari;
        private ServiceValidari serviceValidari;
        private RepoTemperaturi repoTemperaturi;
        private ServiceTemperaturi serviceTemperaturi;
        private DataChart dataChart;
        public Form1()
        {
            repoValidari = new RepoValidari();
            serviceValidari = new ServiceValidari(repoValidari);
            repoTemperaturi = new RepoTemperaturi();
            serviceTemperaturi = new ServiceTemperaturi(repoTemperaturi);
            BusID["BV18DKZ"] = "/16000081";
            BusID["BV18EIK"] = "/16000082";
            BusID["BV18EHX"] = "/16000086";
            BusID["BV18EIL"] = "/16000087";
            BusID["BV18DKY"] = "/1600008C";
            dataAPI = new DataAPI("https://data.uradmonitor.com/api/v1/devices", "");
            dataAPI.setRequest();
            dataAPI.getResponse();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            this.dateTimePickerStart.CustomFormat = "d/MM/yyyy";
            this.dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            this.dateTimePickerEnd.CustomFormat = "d/MM/yyyy";
            this.chart.Legends.Clear();

            this.comboBoxAutobuze.Items.Add("BV18DKZ");
            this.comboBoxAutobuze.Items.Add("BV18EIK");
            this.comboBoxAutobuze.Items.Add("BV18EHX");
            this.comboBoxAutobuze.Items.Add("BV18EIL");
            this.comboBoxAutobuze.Items.Add("BV18DKY");

        }

        private void buttonOutput_Click(object sender, EventArgs e)
        {
            this.dataChart = new DataChart(this.serviceTemperaturi, this.serviceValidari, this.chart, this.dateTimePickerStart, this.dateTimePickerEnd);
            this.dataChart.load();
            this.checkBoxValidari.Checked = true;
            this.checkBoxTemperatura.Checked = true;
        }

        private void checkBoxValidari_CheckedChanged(object sender, EventArgs e)
        {
            Series seriesValid = dataChart.get_series_validari();
            if (this.checkBoxValidari.Checked == true && !this.chart.Series.Contains(seriesValid))
                this.chart.Series.Add(seriesValid);
            else
            {
                if(this.checkBoxValidari.Checked == false)
                    this.chart.Series.Remove(seriesValid);
            }
        }

        private void checkBoxTemperatura_CheckedChanged(object sender, EventArgs e)
        {
            Series seriesTemp = dataChart.get_series_temperatura();
            if (this.checkBoxTemperatura.Checked == true && !this.chart.Series.Contains(seriesTemp))
                this.chart.Series.Add(seriesTemp);
            else
            {
                if(this.checkBoxTemperatura.Checked == false)
                    this.chart.Series.Remove(seriesTemp);
            }
        }

        private void buttonVerificare_Click(object sender, EventArgs e)
        {
            Suplimentare suplimentare = new Suplimentare(this.serviceValidari, this.serviceTemperaturi, this.textBoxMin, this.textBoxMax, this.progressBarValidari, this.textBoxRez);
            suplimentare.set_progress();

        }

        private void comboBoxAutobuze_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dictionary<string, int> niv = dataAPI.getPolLvl();
            foreach (KeyValuePair<string, int> kv in niv)
            {
                if (comboBoxAutobuze.SelectedItem.ToString().Equals(kv.Key))
                    this.textBoxNivel.Text = kv.Value.ToString();
            }

            int pol = Int32.Parse(this.textBoxNivel.Text);
            int proc = 100 * pol / 150;
            this.textBoxReducere.Text = proc.ToString() + "%";
            float pret = 2 - (float)proc / 100 * 2;
            this.textBoxPretCalatorie.Text = pret.ToString();

            if (pol <= 35)
                this.buttonNivel.BackColor = Color.FromArgb(77, 255, 136);
            if(pol >35 && pol<=115)
                this.buttonNivel.BackColor = Color.FromArgb(255, 255, 0);
            if (pol > 115 && pol <= 150)
                this.buttonNivel.BackColor = Color.FromArgb(255, 170, 0);
            if (pol > 150 && pol <= 250)
                this.buttonNivel.BackColor = Color.FromArgb(255, 0, 0);
        }
    }
}
