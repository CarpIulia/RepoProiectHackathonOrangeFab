
namespace Statistici
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonOutput = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.checkBoxValidari = new System.Windows.Forms.CheckBox();
            this.checkBoxTemperatura = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonVerificare = new System.Windows.Forms.Button();
            this.progressBarValidari = new System.Windows.Forms.ProgressBar();
            this.textBoxRez = new System.Windows.Forms.RichTextBox();
            this.comboBoxAutobuze = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNivel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxReducere = new System.Windows.Forms.TextBox();
            this.textBoxPretCalatorie = new System.Windows.Forms.TextBox();
            this.pictureBoxNivelPol = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonNivel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNivelPol)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOutput
            // 
            this.buttonOutput.Location = new System.Drawing.Point(251, 26);
            this.buttonOutput.Name = "buttonOutput";
            this.buttonOutput.Size = new System.Drawing.Size(75, 23);
            this.buttonOutput.TabIndex = 0;
            this.buttonOutput.Text = "Afisare";
            this.buttonOutput.UseVisualStyleBackColor = true;
            this.buttonOutput.Click += new System.EventHandler(this.buttonOutput_Click);
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(12, 68);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(1414, 502);
            this.chart.TabIndex = 2;
            this.chart.Text = "Chart";
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(88, 40);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(146, 22);
            this.dateTimePickerEnd.TabIndex = 3;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(88, 12);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(146, 22);
            this.dateTimePickerStart.TabIndex = 4;
            // 
            // checkBoxValidari
            // 
            this.checkBoxValidari.AutoSize = true;
            this.checkBoxValidari.Location = new System.Drawing.Point(348, 28);
            this.checkBoxValidari.Name = "checkBoxValidari";
            this.checkBoxValidari.Size = new System.Drawing.Size(77, 21);
            this.checkBoxValidari.TabIndex = 5;
            this.checkBoxValidari.Text = "Valiadri";
            this.checkBoxValidari.UseVisualStyleBackColor = true;
            this.checkBoxValidari.CheckedChanged += new System.EventHandler(this.checkBoxValidari_CheckedChanged);
            // 
            // checkBoxTemperatura
            // 
            this.checkBoxTemperatura.AutoSize = true;
            this.checkBoxTemperatura.Location = new System.Drawing.Point(442, 28);
            this.checkBoxTemperatura.Name = "checkBoxTemperatura";
            this.checkBoxTemperatura.Size = new System.Drawing.Size(112, 21);
            this.checkBoxTemperatura.TabIndex = 6;
            this.checkBoxTemperatura.Text = "Temperatura";
            this.checkBoxTemperatura.UseVisualStyleBackColor = true;
            this.checkBoxTemperatura.CheckedChanged += new System.EventHandler(this.checkBoxTemperatura_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Din";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pana in";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1579, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Verificare suplimentare autobuze";
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(1664, 173);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(100, 22);
            this.textBoxMax.TabIndex = 12;
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(1664, 201);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(100, 22);
            this.textBoxMin.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1603, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Maxima";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1603, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Minima";
            // 
            // buttonVerificare
            // 
            this.buttonVerificare.Location = new System.Drawing.Point(1645, 264);
            this.buttonVerificare.Name = "buttonVerificare";
            this.buttonVerificare.Size = new System.Drawing.Size(83, 23);
            this.buttonVerificare.TabIndex = 18;
            this.buttonVerificare.Text = "Verificare";
            this.buttonVerificare.UseVisualStyleBackColor = true;
            this.buttonVerificare.Click += new System.EventHandler(this.buttonVerificare_Click);
            // 
            // progressBarValidari
            // 
            this.progressBarValidari.Location = new System.Drawing.Point(1582, 327);
            this.progressBarValidari.Name = "progressBarValidari";
            this.progressBarValidari.Size = new System.Drawing.Size(213, 23);
            this.progressBarValidari.TabIndex = 19;
            // 
            // textBoxRez
            // 
            this.textBoxRez.Location = new System.Drawing.Point(1512, 375);
            this.textBoxRez.Name = "textBoxRez";
            this.textBoxRez.Size = new System.Drawing.Size(370, 146);
            this.textBoxRez.TabIndex = 20;
            this.textBoxRez.Text = "";
            // 
            // comboBoxAutobuze
            // 
            this.comboBoxAutobuze.FormattingEnabled = true;
            this.comboBoxAutobuze.Location = new System.Drawing.Point(221, 604);
            this.comboBoxAutobuze.Name = "comboBoxAutobuze";
            this.comboBoxAutobuze.Size = new System.Drawing.Size(121, 24);
            this.comboBoxAutobuze.TabIndex = 21;
            this.comboBoxAutobuze.SelectedIndexChanged += new System.EventHandler(this.comboBoxAutobuze_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(111, 607);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Autobuz";
            // 
            // textBoxNivel
            // 
            this.textBoxNivel.Location = new System.Drawing.Point(221, 657);
            this.textBoxNivel.Name = "textBoxNivel";
            this.textBoxNivel.Size = new System.Drawing.Size(121, 22);
            this.textBoxNivel.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 660);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Nivel poluare";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(110, 719);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Reducere";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(110, 770);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Pret/calatorie";
            // 
            // textBoxReducere
            // 
            this.textBoxReducere.Location = new System.Drawing.Point(221, 714);
            this.textBoxReducere.Name = "textBoxReducere";
            this.textBoxReducere.Size = new System.Drawing.Size(121, 22);
            this.textBoxReducere.TabIndex = 27;
            // 
            // textBoxPretCalatorie
            // 
            this.textBoxPretCalatorie.Location = new System.Drawing.Point(221, 765);
            this.textBoxPretCalatorie.Name = "textBoxPretCalatorie";
            this.textBoxPretCalatorie.Size = new System.Drawing.Size(121, 22);
            this.textBoxPretCalatorie.TabIndex = 28;
            // 
            // pictureBoxNivelPol
            // 
            this.pictureBoxNivelPol.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxNivelPol.ErrorImage")));
            this.pictureBoxNivelPol.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNivelPol.Image")));
            this.pictureBoxNivelPol.ImageLocation = "C:\\Users\\iulia\\Desktop\\Hackathon\\nivele_poluare.jpg";
            this.pictureBoxNivelPol.Location = new System.Drawing.Point(403, 592);
            this.pictureBoxNivelPol.Name = "pictureBoxNivelPol";
            this.pictureBoxNivelPol.Size = new System.Drawing.Size(955, 209);
            this.pictureBoxNivelPol.TabIndex = 29;
            this.pictureBoxNivelPol.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1603, 592);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 17);
            this.label10.TabIndex = 30;
            this.label10.Text = "Nivelul de poluare curent";
            // 
            // buttonNivel
            // 
            this.buttonNivel.Location = new System.Drawing.Point(1606, 642);
            this.buttonNivel.Name = "buttonNivel";
            this.buttonNivel.Size = new System.Drawing.Size(163, 145);
            this.buttonNivel.TabIndex = 31;
            this.buttonNivel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1945, 829);
            this.Controls.Add(this.buttonNivel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBoxNivelPol);
            this.Controls.Add(this.textBoxPretCalatorie);
            this.Controls.Add(this.textBoxReducere);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxNivel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxAutobuze);
            this.Controls.Add(this.textBoxRez);
            this.Controls.Add(this.progressBarValidari);
            this.Controls.Add(this.buttonVerificare);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxTemperatura);
            this.Controls.Add(this.checkBoxValidari);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.buttonOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNivelPol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOutput;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.CheckBox checkBoxValidari;
        private System.Windows.Forms.CheckBox checkBoxTemperatura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonVerificare;
        private System.Windows.Forms.ProgressBar progressBarValidari;
        private System.Windows.Forms.RichTextBox textBoxRez;
        private System.Windows.Forms.ComboBox comboBoxAutobuze;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNivel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxReducere;
        private System.Windows.Forms.TextBox textBoxPretCalatorie;
        private System.Windows.Forms.PictureBox pictureBoxNivelPol;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonNivel;
    }
}

