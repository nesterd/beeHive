using Configuration.JobsList;

namespace FunWithBees_page301
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAssignJob = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownShifts = new System.Windows.Forms.NumericUpDown();
            this.comboBoxWorkerBeeJob = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonNextShift = new System.Windows.Forms.Button();
            this.textBoxReport = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShifts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAssignJob);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDownShifts);
            this.groupBox1.Controls.Add(this.comboBoxWorkerBeeJob);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Worker Bee Assignments";
            // 
            // buttonAssignJob
            // 
            this.buttonAssignJob.Location = new System.Drawing.Point(7, 93);
            this.buttonAssignJob.Name = "buttonAssignJob";
            this.buttonAssignJob.Size = new System.Drawing.Size(566, 33);
            this.buttonAssignJob.TabIndex = 4;
            this.buttonAssignJob.Text = "Assign this job to a bee";
            this.buttonAssignJob.UseVisualStyleBackColor = true;
            this.buttonAssignJob.Click += new System.EventHandler(this.buttonAssignJob_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Shift";
            // 
            // numericUpDownShifts
            // 
            this.numericUpDownShifts.Location = new System.Drawing.Point(414, 60);
            this.numericUpDownShifts.Name = "numericUpDownShifts";
            this.numericUpDownShifts.Size = new System.Drawing.Size(159, 24);
            this.numericUpDownShifts.TabIndex = 2;
            // 
            // comboBoxWorkerBeeJob
            // 
            this.comboBoxWorkerBeeJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWorkerBeeJob.FormattingEnabled = true;
            this.comboBoxWorkerBeeJob.Items.AddRange(new object[] {
            "Nectar Collector",
            "Honey manufacturing",
            "Egg care",
            "Baby bee tutoring",
            "Hive maintenance",
            "Sting patrol"});
            this.comboBoxWorkerBeeJob.Location = new System.Drawing.Point(7, 60);
            this.comboBoxWorkerBeeJob.Name = "comboBoxWorkerBeeJob";
            this.comboBoxWorkerBeeJob.Size = new System.Drawing.Size(400, 26);
            this.comboBoxWorkerBeeJob.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Job";
            // 
            // buttonNextShift
            // 
            this.buttonNextShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNextShift.Location = new System.Drawing.Point(598, 13);
            this.buttonNextShift.Name = "buttonNextShift";
            this.buttonNextShift.Size = new System.Drawing.Size(230, 132);
            this.buttonNextShift.TabIndex = 1;
            this.buttonNextShift.Text = "Work the next shift";
            this.buttonNextShift.UseVisualStyleBackColor = true;
            this.buttonNextShift.Click += new System.EventHandler(this.buttonNextShift_Click);
            // 
            // textBoxReport
            // 
            this.textBoxReport.Location = new System.Drawing.Point(13, 151);
            this.textBoxReport.Multiline = true;
            this.textBoxReport.Name = "textBoxReport";
            this.textBoxReport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxReport.Size = new System.Drawing.Size(815, 393);
            this.textBoxReport.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 557);
            this.Controls.Add(this.textBoxReport);
            this.Controls.Add(this.buttonNextShift);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beehive Management System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShifts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownShifts;
        private System.Windows.Forms.ComboBox comboBoxWorkerBeeJob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonNextShift;
        private System.Windows.Forms.Button buttonAssignJob;
        private System.Windows.Forms.TextBox textBoxReport;
    }
}

