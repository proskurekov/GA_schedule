
namespace GA_schedule
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.jobsPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listJobs = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnFill = new System.Windows.Forms.Button();
            this.BtnSrart = new System.Windows.Forms.Button();
            this.numOperations = new System.Windows.Forms.NumericUpDown();
            this.numJobs = new System.Windows.Forms.NumericUpDown();
            this.numMachine = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.BtnStartProc = new System.Windows.Forms.Button();
            this.numSizePop = new System.Windows.Forms.NumericUpDown();
            this.numMut = new System.Windows.Forms.NumericUpDown();
            this.numPop = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOperations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numJobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMachine)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSizePop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPop)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.HotTrack = true;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.ItemSize = new System.Drawing.Size(60, 30);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(10, 6);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1011, 587);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.jobsPanel);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(1003, 549);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Таблица";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // jobsPanel
            // 
            this.jobsPanel.AutoScroll = true;
            this.jobsPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.jobsPanel.Location = new System.Drawing.Point(259, 4);
            this.jobsPanel.Name = "jobsPanel";
            this.jobsPanel.Size = new System.Drawing.Size(741, 541);
            this.jobsPanel.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listJobs);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.BtnClear);
            this.groupBox1.Controls.Add(this.BtnFill);
            this.groupBox1.Controls.Add(this.BtnSrart);
            this.groupBox1.Controls.Add(this.numOperations);
            this.groupBox1.Controls.Add(this.numJobs);
            this.groupBox1.Controls.Add(this.numMachine);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(250, 541);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки таблицы";
            // 
            // listJobs
            // 
            this.listJobs.FormattingEnabled = true;
            this.listJobs.Location = new System.Drawing.Point(127, 228);
            this.listJobs.Name = "listJobs";
            this.listJobs.Size = new System.Drawing.Size(98, 22);
            this.listJobs.TabIndex = 10;
            this.listJobs.SelectedIndexChanged += new System.EventHandler(this.listJobs_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(7, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Выбрать работу";
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(7, 314);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.BtnClear.Size = new System.Drawing.Size(218, 34);
            this.BtnClear.TabIndex = 7;
            this.BtnClear.Text = "Очистить таблицу";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnFill
            // 
            this.BtnFill.Location = new System.Drawing.Point(7, 267);
            this.BtnFill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnFill.Name = "BtnFill";
            this.BtnFill.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.BtnFill.Size = new System.Drawing.Size(218, 34);
            this.BtnFill.TabIndex = 6;
            this.BtnFill.Text = "Заполнить таблицу";
            this.BtnFill.UseVisualStyleBackColor = true;
            this.BtnFill.Click += new System.EventHandler(this.BtnFill_Click);
            // 
            // BtnSrart
            // 
            this.BtnSrart.Location = new System.Drawing.Point(7, 175);
            this.BtnSrart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSrart.Name = "BtnSrart";
            this.BtnSrart.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.BtnSrart.Size = new System.Drawing.Size(218, 34);
            this.BtnSrart.TabIndex = 1;
            this.BtnSrart.Text = "Создать таблицу";
            this.BtnSrart.UseVisualStyleBackColor = true;
            this.BtnSrart.Click += new System.EventHandler(this.BtnSrart_Click);
            // 
            // numOperations
            // 
            this.numOperations.Location = new System.Drawing.Point(140, 124);
            this.numOperations.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numOperations.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numOperations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numOperations.Name = "numOperations";
            this.numOperations.Size = new System.Drawing.Size(85, 22);
            this.numOperations.TabIndex = 5;
            this.numOperations.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numJobs
            // 
            this.numJobs.Location = new System.Drawing.Point(140, 82);
            this.numJobs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numJobs.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numJobs.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numJobs.Name = "numJobs";
            this.numJobs.Size = new System.Drawing.Size(85, 22);
            this.numJobs.TabIndex = 4;
            this.numJobs.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numMachine
            // 
            this.numMachine.Location = new System.Drawing.Point(140, 41);
            this.numMachine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numMachine.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMachine.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMachine.Name = "numMachine";
            this.numMachine.Size = new System.Drawing.Size(85, 22);
            this.numMachine.TabIndex = 3;
            this.numMachine.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Число операций:\r\n";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Число работ:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Число машин:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1003, 549);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Параметры ГА";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.BtnStartProc);
            this.groupBox2.Controls.Add(this.numSizePop);
            this.groupBox2.Controls.Add(this.numMut);
            this.groupBox2.Controls.Add(this.numPop);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(250, 543);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Основные параметры";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(7, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 30);
            this.label8.TabIndex = 7;
            this.label8.Text = "Статус:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(7, 223);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.button5.Size = new System.Drawing.Size(228, 34);
            this.button5.TabIndex = 6;
            this.button5.Text = "Остановить";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // BtnStartProc
            // 
            this.BtnStartProc.Location = new System.Drawing.Point(7, 175);
            this.BtnStartProc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnStartProc.Name = "BtnStartProc";
            this.BtnStartProc.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.BtnStartProc.Size = new System.Drawing.Size(228, 34);
            this.BtnStartProc.TabIndex = 1;
            this.BtnStartProc.Text = "Запустить";
            this.BtnStartProc.UseVisualStyleBackColor = true;
            this.BtnStartProc.Click += new System.EventHandler(this.BtnStartProc_Click);
            // 
            // numSizePop
            // 
            this.numSizePop.Location = new System.Drawing.Point(150, 124);
            this.numSizePop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numSizePop.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numSizePop.Name = "numSizePop";
            this.numSizePop.Size = new System.Drawing.Size(85, 22);
            this.numSizePop.TabIndex = 5;
            this.numSizePop.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numMut
            // 
            this.numMut.Location = new System.Drawing.Point(150, 82);
            this.numMut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numMut.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMut.Name = "numMut";
            this.numMut.Size = new System.Drawing.Size(85, 22);
            this.numMut.TabIndex = 4;
            this.numMut.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numPop
            // 
            this.numPop.Location = new System.Drawing.Point(150, 41);
            this.numPop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numPop.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPop.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numPop.Name = "numPop";
            this.numPop.Size = new System.Drawing.Size(85, 22);
            this.numPop.TabIndex = 3;
            this.numPop.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(7, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 30);
            this.label5.TabIndex = 1;
            this.label5.Text = "Размер популяции:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(7, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 30);
            this.label6.TabIndex = 2;
            this.label6.Text = "Проц. мутации:\r\n";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(7, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 30);
            this.label7.TabIndex = 1;
            this.label7.Text = "Число популяций:\r\n\r\n\r\n:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1003, 549);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Расписание";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 587);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numOperations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numJobs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMachine)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numSizePop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.Panel jobsPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnFill;
        private System.Windows.Forms.Button BtnSrart;
        private System.Windows.Forms.NumericUpDown numOperations;
        private System.Windows.Forms.NumericUpDown numJobs;
        private System.Windows.Forms.NumericUpDown numMachine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button BtnStartProc;
        private System.Windows.Forms.NumericUpDown numSizePop;
        private System.Windows.Forms.NumericUpDown numMut;
        private System.Windows.Forms.NumericUpDown numPop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox listJobs;
    }
}

