using Statistici.service;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Statistici.controller
{
    class Suplimentare
    {
        private int min;
        private int max;
        private ProgressBar progressBarValidari;
        private ServiceValidari serviceValidari;
        private ServiceTemperaturi serviceTemperaturi;
        private int validMed;
        private RichTextBox textBoxRez;

        public Suplimentare(ServiceValidari serviceValidari, ServiceTemperaturi serviceTemperaturi, TextBox textBoxMin, TextBox textBoxMax, ProgressBar progressBarValidari, RichTextBox textBoxRez)
        {
            this.min = Int32.Parse(textBoxMin.Text);
            this.max = Int32.Parse(textBoxMax.Text);
            this.progressBarValidari = progressBarValidari;
            this.serviceValidari = serviceValidari;
            this.serviceTemperaturi = serviceTemperaturi;
            this.validMed = serviceValidari.get_nr_validari_mediu();
            this.textBoxRez = textBoxRez;
        }

        internal void set_progress()
        {
            List<DateTime> dates = serviceTemperaturi.get_data(this.min, this.max);
            int nrVal;
            int val = 0;
            int nr = 0;
            foreach (DateTime date in dates)
            {
                val += serviceValidari.get_nr_validari(date.Day, date.Month, date.Year);
                nr++;
            }
            nrVal = val / nr;

            this.progressBarValidari.Maximum = this.validMed + 300;
            this.progressBarValidari.Minimum = this.validMed - 300;
            if (nrVal > this.validMed - 300)
                this.progressBarValidari.Value = nrVal;
            else
                this.progressBarValidari.Value = this.validMed - 300;

            if (nrVal > this.validMed)
                this.textBoxRez.Text = "Conform numarului de validari inregistrate intr-o zi cu temperatura medie similara, astazi numarul de calatori ar putea depasi valoarea medie. Linia necesita suplimentare.";
            else
                this.textBoxRez.Text = "Conform numarului de validari inregistrate intr-o zi cu temperatura medie similara, astazi numarul de calatori nu ar putea depasi valoarea medie. Linia nu necesita suplimentare.";

        }
    }
}
