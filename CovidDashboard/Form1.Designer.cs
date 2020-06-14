namespace CovidDashboard
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
            this.comboBox_Countries = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DisplayMessage = new System.Windows.Forms.Label();
            this.dateTimePicker_From = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_NewConfirmed = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_TotalConfirmed = new System.Windows.Forms.Label();
            this.label_NewDeaths = new System.Windows.Forms.Label();
            this.label_TotalDeaths = new System.Windows.Forms.Label();
            this.label_NewRecovered = new System.Windows.Forms.Label();
            this.label_TotalRecovered = new System.Windows.Forms.Label();
            this.listBox_Results = new System.Windows.Forms.ListBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.label_LatestUpdatedDate = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_Countries
            // 
            this.comboBox_Countries.FormattingEnabled = true;
            this.comboBox_Countries.Location = new System.Drawing.Point(12, 67);
            this.comboBox_Countries.Name = "comboBox_Countries";
            this.comboBox_Countries.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Countries.TabIndex = 0;
            this.comboBox_Countries.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Countries_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Countries";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // DisplayMessage
            // 
            this.DisplayMessage.AutoSize = true;
            this.DisplayMessage.Location = new System.Drawing.Point(12, 20);
            this.DisplayMessage.Name = "DisplayMessage";
            this.DisplayMessage.Size = new System.Drawing.Size(10, 13);
            this.DisplayMessage.TabIndex = 1;
            this.DisplayMessage.Text = "-";
            this.DisplayMessage.Click += new System.EventHandler(this.Label1_Click);
            // 
            // dateTimePicker_From
            // 
            this.dateTimePicker_From.Location = new System.Drawing.Point(150, 68);
            this.dateTimePicker_From.Name = "dateTimePicker_From";
            this.dateTimePicker_From.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_From.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "From Date";
            this.label2.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "NewConfirmed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(170, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "TotalConfirmed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(336, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "NewDeaths";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(476, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "TotalDeaths";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(614, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 24);
            this.label8.TabIndex = 3;
            this.label8.Text = "NewRecovered";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(785, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 24);
            this.label9.TabIndex = 3;
            this.label9.Text = "TotalRecovered";
            // 
            // label_NewConfirmed
            // 
            this.label_NewConfirmed.AutoSize = true;
            this.label_NewConfirmed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NewConfirmed.Location = new System.Drawing.Point(8, 50);
            this.label_NewConfirmed.Name = "label_NewConfirmed";
            this.label_NewConfirmed.Size = new System.Drawing.Size(14, 20);
            this.label_NewConfirmed.TabIndex = 3;
            this.label_NewConfirmed.Text = "-";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label_TotalRecovered);
            this.panel1.Controls.Add(this.label_NewRecovered);
            this.panel1.Controls.Add(this.label_TotalDeaths);
            this.panel1.Controls.Add(this.label_NewDeaths);
            this.panel1.Controls.Add(this.label_TotalConfirmed);
            this.panel1.Controls.Add(this.label_NewConfirmed);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 85);
            this.panel1.TabIndex = 4;
            // 
            // label_TotalConfirmed
            // 
            this.label_TotalConfirmed.AutoSize = true;
            this.label_TotalConfirmed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TotalConfirmed.Location = new System.Drawing.Point(177, 50);
            this.label_TotalConfirmed.Name = "label_TotalConfirmed";
            this.label_TotalConfirmed.Size = new System.Drawing.Size(14, 20);
            this.label_TotalConfirmed.TabIndex = 3;
            this.label_TotalConfirmed.Text = "-";
            // 
            // label_NewDeaths
            // 
            this.label_NewDeaths.AutoSize = true;
            this.label_NewDeaths.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NewDeaths.Location = new System.Drawing.Point(340, 50);
            this.label_NewDeaths.Name = "label_NewDeaths";
            this.label_NewDeaths.Size = new System.Drawing.Size(14, 20);
            this.label_NewDeaths.TabIndex = 3;
            this.label_NewDeaths.Text = "-";
            // 
            // label_TotalDeaths
            // 
            this.label_TotalDeaths.AutoSize = true;
            this.label_TotalDeaths.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TotalDeaths.Location = new System.Drawing.Point(482, 50);
            this.label_TotalDeaths.Name = "label_TotalDeaths";
            this.label_TotalDeaths.Size = new System.Drawing.Size(14, 20);
            this.label_TotalDeaths.TabIndex = 3;
            this.label_TotalDeaths.Text = "-";
            // 
            // label_NewRecovered
            // 
            this.label_NewRecovered.AutoSize = true;
            this.label_NewRecovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NewRecovered.Location = new System.Drawing.Point(619, 50);
            this.label_NewRecovered.Name = "label_NewRecovered";
            this.label_NewRecovered.Size = new System.Drawing.Size(14, 20);
            this.label_NewRecovered.TabIndex = 3;
            this.label_NewRecovered.Text = "-";
            // 
            // label_TotalRecovered
            // 
            this.label_TotalRecovered.AutoSize = true;
            this.label_TotalRecovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TotalRecovered.Location = new System.Drawing.Point(793, 50);
            this.label_TotalRecovered.Name = "label_TotalRecovered";
            this.label_TotalRecovered.Size = new System.Drawing.Size(14, 20);
            this.label_TotalRecovered.TabIndex = 3;
            this.label_TotalRecovered.Text = "-";
            // 
            // listBox_Results
            // 
            this.listBox_Results.FormattingEnabled = true;
            this.listBox_Results.Location = new System.Drawing.Point(12, 242);
            this.listBox_Results.Name = "listBox_Results";
            this.listBox_Results.Size = new System.Drawing.Size(932, 212);
            this.listBox_Results.TabIndex = 5;
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(367, 67);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(75, 23);
            this.button_Search.TabIndex = 6;
            this.button_Search.Text = "Fetch";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.Button_Search_Click);
            // 
            // label_LatestUpdatedDate
            // 
            this.label_LatestUpdatedDate.AutoSize = true;
            this.label_LatestUpdatedDate.Location = new System.Drawing.Point(12, 212);
            this.label_LatestUpdatedDate.Name = "label_LatestUpdatedDate";
            this.label_LatestUpdatedDate.Size = new System.Drawing.Size(10, 13);
            this.label_LatestUpdatedDate.TabIndex = 1;
            this.label_LatestUpdatedDate.Text = "-";
            this.label_LatestUpdatedDate.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 497);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.listBox_Results);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker_From);
            this.Controls.Add(this.label_LatestUpdatedDate);
            this.Controls.Add(this.DisplayMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Countries);
            this.Name = "Form1";
            this.Text = "Covid Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Countries;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DisplayMessage;
        private System.Windows.Forms.DateTimePicker dateTimePicker_From;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_NewConfirmed;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_TotalRecovered;
        private System.Windows.Forms.Label label_NewRecovered;
        private System.Windows.Forms.Label label_TotalDeaths;
        private System.Windows.Forms.Label label_NewDeaths;
        private System.Windows.Forms.Label label_TotalConfirmed;
        private System.Windows.Forms.ListBox listBox_Results;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Label label_LatestUpdatedDate;
    }
}

