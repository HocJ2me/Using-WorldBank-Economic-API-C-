
namespace Economic_API
{
    partial class formMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.chrGDP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblChar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblGDP = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblCurrence = new System.Windows.Forms.Label();
            this.lblNameCountry = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxNameCountry = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chrGDP)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // chrGDP
            // 
            chartArea2.Name = "ChartArea1";
            this.chrGDP.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chrGDP.Legends.Add(legend2);
            this.chrGDP.Location = new System.Drawing.Point(473, 196);
            this.chrGDP.Name = "chrGDP";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "GDP";
            this.chrGDP.Series.Add(series2);
            this.chrGDP.Size = new System.Drawing.Size(799, 461);
            this.chrGDP.TabIndex = 11;
            this.chrGDP.Text = "GDP";
            // 
            // lblChar
            // 
            this.lblChar.AutoSize = true;
            this.lblChar.Location = new System.Drawing.Point(715, 672);
            this.lblChar.Name = "lblChar";
            this.lblChar.Size = new System.Drawing.Size(127, 17);
            this.lblChar.TabIndex = 12;
            this.lblChar.Text = "GDP theo các năm";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.lblArea);
            this.panel1.Controls.Add(this.lblGDP);
            this.panel1.Controls.Add(this.lblGroup);
            this.panel1.Controls.Add(this.lblCurrence);
            this.panel1.Controls.Add(this.lblNameCountry);
            this.panel1.Location = new System.Drawing.Point(29, 196);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 461);
            this.panel1.TabIndex = 13;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(20, 97);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(65, 17);
            this.lblArea.TabIndex = 16;
            this.lblArea.Text = "khu vực: ";
            // 
            // lblGDP
            // 
            this.lblGDP.AutoSize = true;
            this.lblGDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGDP.Location = new System.Drawing.Point(20, 345);
            this.lblGDP.Name = "lblGDP";
            this.lblGDP.Size = new System.Drawing.Size(46, 17);
            this.lblGDP.TabIndex = 14;
            this.lblGDP.Text = "GDP: ";
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroup.Location = new System.Drawing.Point(16, 255);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(77, 17);
            this.lblGroup.TabIndex = 13;
            this.lblGroup.Text = "Thu nhập: ";
            // 
            // lblCurrence
            // 
            this.lblCurrence.AutoSize = true;
            this.lblCurrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrence.Location = new System.Drawing.Point(20, 174);
            this.lblCurrence.Name = "lblCurrence";
            this.lblCurrence.Size = new System.Drawing.Size(95, 17);
            this.lblCurrence.TabIndex = 12;
            this.lblCurrence.Text = "Đơn vị tiền tệ:";
            // 
            // lblNameCountry
            // 
            this.lblNameCountry.AutoSize = true;
            this.lblNameCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCountry.Location = new System.Drawing.Point(20, 16);
            this.lblNameCountry.Name = "lblNameCountry";
            this.lblNameCountry.Size = new System.Drawing.Size(99, 17);
            this.lblNameCountry.TabIndex = 11;
            this.lblNameCountry.Text = "Tên quốc gia: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.pbxLogo);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.tbxNameCountry);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Controls.Add(this.lblInfo);
            this.panel2.Location = new System.Drawing.Point(29, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1243, 160);
            this.panel2.TabIndex = 14;
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(-6, 5);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(264, 151);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 13;
            this.pbxLogo.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(965, 81);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(253, 40);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbxNameCountry
            // 
            this.tbxNameCountry.Location = new System.Drawing.Point(1059, 47);
            this.tbxNameCountry.Name = "tbxNameCountry";
            this.tbxNameCountry.Size = new System.Drawing.Size(159, 22);
            this.tbxNameCountry.TabIndex = 11;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(962, 47);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(91, 17);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Tên quốc gia";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(308, 58);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(560, 36);
            this.lblInfo.TabIndex = 9;
            this.lblInfo.Text = "Dữ liệu từ ngân hàng thế giới World Bank";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(101, 406);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(201, 34);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Lưu trữ mySQL";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 709);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblChar);
            this.Controls.Add(this.chrGDP);
            this.Name = "formMain";
            this.Text = "Hiển thị dữ liệu về kinh tế các quốc gia";
            this.Load += new System.EventHandler(this.formMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrGDP)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrGDP;
        private System.Windows.Forms.Label lblChar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblGDP;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblCurrence;
        private System.Windows.Forms.Label lblNameCountry;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxNameCountry;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnSave;
    }
}

