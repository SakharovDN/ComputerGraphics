
namespace LabWork2
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.colorButton = new System.Windows.Forms.Button();
            this.lineTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.thicknessTrackBar = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.drawByCoordinatesButton = new System.Windows.Forms.Button();
            this.y2NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.x2NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.y1NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.x1NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.drawingAlgorithmComboBox = new System.Windows.Forms.ComboBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessTrackBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.y2NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x2NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y1NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x1NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.refreshButton);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.drawingAlgorithmComboBox);
            this.splitContainer1.Panel2MinSize = 261;
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 535;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(535, 450);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.colorButton);
            this.groupBox2.Controls.Add(this.lineTypeComboBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.thicknessTrackBar);
            this.groupBox2.Location = new System.Drawing.Point(6, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 155);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры линии";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Тип линии:";
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(9, 83);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(228, 23);
            this.colorButton.TabIndex = 9;
            this.colorButton.Text = "Цвет линии";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // lineTypeComboBox
            // 
            this.lineTypeComboBox.FormattingEnabled = true;
            this.lineTypeComboBox.Location = new System.Drawing.Point(6, 125);
            this.lineTypeComboBox.Name = "lineTypeComboBox";
            this.lineTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.lineTypeComboBox.TabIndex = 5;
            this.lineTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.lineTypeComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Толщина линии";
            // 
            // thicknessTrackBar
            // 
            this.thicknessTrackBar.Location = new System.Drawing.Point(6, 32);
            this.thicknessTrackBar.Minimum = 1;
            this.thicknessTrackBar.Name = "thicknessTrackBar";
            this.thicknessTrackBar.Size = new System.Drawing.Size(231, 45);
            this.thicknessTrackBar.TabIndex = 0;
            this.thicknessTrackBar.Value = 1;
            this.thicknessTrackBar.Scroll += new System.EventHandler(this.thicknessTrackBar_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.drawByCoordinatesButton);
            this.groupBox1.Controls.Add(this.y2NumericUpDown);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.x2NumericUpDown);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.y1NumericUpDown);
            this.groupBox1.Controls.Add(this.x1NumericUpDown);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Координаты";
            // 
            // drawByCoordinatesButton
            // 
            this.drawByCoordinatesButton.Location = new System.Drawing.Point(9, 71);
            this.drawByCoordinatesButton.Name = "drawByCoordinatesButton";
            this.drawByCoordinatesButton.Size = new System.Drawing.Size(228, 23);
            this.drawByCoordinatesButton.TabIndex = 8;
            this.drawByCoordinatesButton.Text = "Нарисовать";
            this.drawByCoordinatesButton.UseVisualStyleBackColor = true;
            this.drawByCoordinatesButton.Click += new System.EventHandler(this.drawByCoordinatesButton_Click);
            // 
            // y2NumericUpDown
            // 
            this.y2NumericUpDown.Location = new System.Drawing.Point(149, 45);
            this.y2NumericUpDown.Name = "y2NumericUpDown";
            this.y2NumericUpDown.Size = new System.Drawing.Size(88, 20);
            this.y2NumericUpDown.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "y2:";
            // 
            // x2NumericUpDown
            // 
            this.x2NumericUpDown.Location = new System.Drawing.Point(149, 19);
            this.x2NumericUpDown.Name = "x2NumericUpDown";
            this.x2NumericUpDown.Size = new System.Drawing.Size(88, 20);
            this.x2NumericUpDown.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "x2:";
            // 
            // y1NumericUpDown
            // 
            this.y1NumericUpDown.Location = new System.Drawing.Point(33, 45);
            this.y1NumericUpDown.Name = "y1NumericUpDown";
            this.y1NumericUpDown.Size = new System.Drawing.Size(88, 20);
            this.y1NumericUpDown.TabIndex = 3;
            // 
            // x1NumericUpDown
            // 
            this.x1NumericUpDown.Location = new System.Drawing.Point(33, 19);
            this.x1NumericUpDown.Name = "x1NumericUpDown";
            this.x1NumericUpDown.Size = new System.Drawing.Size(88, 20);
            this.x1NumericUpDown.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "y1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "x1:";
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(6, 415);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.Text = "Очистить";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите алгоритм:";
            // 
            // drawingAlgorithmComboBox
            // 
            this.drawingAlgorithmComboBox.FormattingEnabled = true;
            this.drawingAlgorithmComboBox.Location = new System.Drawing.Point(6, 25);
            this.drawingAlgorithmComboBox.Name = "drawingAlgorithmComboBox";
            this.drawingAlgorithmComboBox.Size = new System.Drawing.Size(121, 21);
            this.drawingAlgorithmComboBox.TabIndex = 0;
            this.drawingAlgorithmComboBox.SelectedIndexChanged += new System.EventHandler(this.drawingAlgorithmComboBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "LabWork2";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessTrackBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.y2NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x2NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y1NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x1NumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.ComboBox lineTypeComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar thicknessTrackBar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button drawByCoordinatesButton;
        private System.Windows.Forms.NumericUpDown y2NumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown x2NumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown y1NumericUpDown;
        private System.Windows.Forms.NumericUpDown x1NumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox drawingAlgorithmComboBox;
    }
}

