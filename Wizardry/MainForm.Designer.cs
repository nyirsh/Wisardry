
namespace Wizardry
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoadTemplate = new System.Windows.Forms.Button();
            this.config_targetPower = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.config_maxMarchPower = new System.Windows.Forms.TextBox();
            this.config_maxMarches = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.configGroupBox = new System.Windows.Forms.GroupBox();
            this.dataGroupBox = new System.Windows.Forms.GroupBox();
            this.data_gv = new System.Windows.Forms.DataGridView();
            this.resultsGroupBox = new System.Windows.Forms.GroupBox();
            this.results_results = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.configGroupBox.SuspendLayout();
            this.dataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_gv)).BeginInit();
            this.resultsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Target Power Level";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnLoadTemplate
            // 
            this.btnLoadTemplate.Location = new System.Drawing.Point(12, 12);
            this.btnLoadTemplate.Name = "btnLoadTemplate";
            this.btnLoadTemplate.Size = new System.Drawing.Size(104, 23);
            this.btnLoadTemplate.TabIndex = 1;
            this.btnLoadTemplate.Text = "Load Template";
            this.btnLoadTemplate.UseVisualStyleBackColor = true;
            this.btnLoadTemplate.Click += new System.EventHandler(this.btnLoadTemplate_Click);
            // 
            // config_targetPower
            // 
            this.config_targetPower.Location = new System.Drawing.Point(117, 16);
            this.config_targetPower.Name = "config_targetPower";
            this.config_targetPower.Size = new System.Drawing.Size(62, 23);
            this.config_targetPower.TabIndex = 2;
            this.config_targetPower.Text = "1000000";
            this.config_targetPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Max March Power";
            // 
            // config_maxMarchPower
            // 
            this.config_maxMarchPower.Location = new System.Drawing.Point(117, 45);
            this.config_maxMarchPower.Name = "config_maxMarchPower";
            this.config_maxMarchPower.Size = new System.Drawing.Size(62, 23);
            this.config_maxMarchPower.TabIndex = 4;
            this.config_maxMarchPower.Text = "800000";
            this.config_maxMarchPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // config_maxMarches
            // 
            this.config_maxMarches.Location = new System.Drawing.Point(117, 74);
            this.config_maxMarches.Name = "config_maxMarches";
            this.config_maxMarches.Size = new System.Drawing.Size(62, 23);
            this.config_maxMarches.TabIndex = 6;
            this.config_maxMarches.Text = "4";
            this.config_maxMarches.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Max Marches";
            // 
            // configGroupBox
            // 
            this.configGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.configGroupBox.Controls.Add(this.label1);
            this.configGroupBox.Controls.Add(this.config_maxMarches);
            this.configGroupBox.Controls.Add(this.config_targetPower);
            this.configGroupBox.Controls.Add(this.label3);
            this.configGroupBox.Controls.Add(this.label2);
            this.configGroupBox.Controls.Add(this.config_maxMarchPower);
            this.configGroupBox.Location = new System.Drawing.Point(12, 41);
            this.configGroupBox.Name = "configGroupBox";
            this.configGroupBox.Size = new System.Drawing.Size(197, 487);
            this.configGroupBox.TabIndex = 7;
            this.configGroupBox.TabStop = false;
            this.configGroupBox.Text = "Configs";
            // 
            // dataGroupBox
            // 
            this.dataGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGroupBox.Controls.Add(this.data_gv);
            this.dataGroupBox.Location = new System.Drawing.Point(215, 41);
            this.dataGroupBox.Name = "dataGroupBox";
            this.dataGroupBox.Size = new System.Drawing.Size(776, 257);
            this.dataGroupBox.TabIndex = 8;
            this.dataGroupBox.TabStop = false;
            this.dataGroupBox.Text = "Data";
            // 
            // data_gv
            // 
            this.data_gv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_gv.Location = new System.Drawing.Point(6, 19);
            this.data_gv.Name = "data_gv";
            this.data_gv.ReadOnly = true;
            this.data_gv.RowTemplate.Height = 25;
            this.data_gv.Size = new System.Drawing.Size(764, 207);
            this.data_gv.TabIndex = 0;
            // 
            // resultsGroupBox
            // 
            this.resultsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultsGroupBox.Controls.Add(this.results_results);
            this.resultsGroupBox.Location = new System.Drawing.Point(215, 304);
            this.resultsGroupBox.Name = "resultsGroupBox";
            this.resultsGroupBox.Size = new System.Drawing.Size(776, 224);
            this.resultsGroupBox.TabIndex = 9;
            this.resultsGroupBox.TabStop = false;
            this.resultsGroupBox.Text = "Results";
            // 
            // results_results
            // 
            this.results_results.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.results_results.Location = new System.Drawing.Point(6, 22);
            this.results_results.Multiline = true;
            this.results_results.Name = "results_results";
            this.results_results.ReadOnly = true;
            this.results_results.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.results_results.Size = new System.Drawing.Size(764, 196);
            this.results_results.TabIndex = 0;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(134, 12);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Visible = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 540);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.resultsGroupBox);
            this.Controls.Add(this.dataGroupBox);
            this.Controls.Add(this.configGroupBox);
            this.Controls.Add(this.btnLoadTemplate);
            this.Name = "MainForm";
            this.Text = "Wizardry";
            this.configGroupBox.ResumeLayout(false);
            this.configGroupBox.PerformLayout();
            this.dataGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_gv)).EndInit();
            this.resultsGroupBox.ResumeLayout(false);
            this.resultsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadTemplate;
        private System.Windows.Forms.TextBox config_targetPower;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox config_maxMarchPower;
        private System.Windows.Forms.TextBox config_maxMarches;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox configGroupBox;
        private System.Windows.Forms.GroupBox dataGroupBox;
        private System.Windows.Forms.DataGridView data_gv;
        private System.Windows.Forms.GroupBox resultsGroupBox;
        private System.Windows.Forms.TextBox results_results;
        private System.Windows.Forms.Button btnCalculate;
    }
}

