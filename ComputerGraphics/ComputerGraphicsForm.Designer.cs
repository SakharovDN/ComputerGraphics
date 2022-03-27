
namespace ComputerGraphics
{
    partial class ComputerGraphicsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComputerGraphicsForm));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.colorButton = new System.Windows.Forms.Button();
            this.thicknessTrackBar = new System.Windows.Forms.TrackBar();
            this.xRotateButton = new System.Windows.Forms.Button();
            this.zRotateButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.visiblePlanesCheckBox = new System.Windows.Forms.CheckBox();
            this.figureComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.yRotateButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(535, 491);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Толщина линии";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.colorButton);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.thicknessTrackBar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(6, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 136);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры линии";
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(6, 96);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(228, 31);
            this.colorButton.TabIndex = 9;
            this.colorButton.Text = "Цвет линии";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // thicknessTrackBar
            // 
            this.thicknessTrackBar.Location = new System.Drawing.Point(3, 45);
            this.thicknessTrackBar.Minimum = 1;
            this.thicknessTrackBar.Name = "thicknessTrackBar";
            this.thicknessTrackBar.Size = new System.Drawing.Size(231, 45);
            this.thicknessTrackBar.TabIndex = 0;
            this.thicknessTrackBar.Value = 1;
            this.thicknessTrackBar.Scroll += new System.EventHandler(this.thicknessTrackBar_Scroll);
            // 
            // xRotateButton
            // 
            this.xRotateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.xRotateButton.Location = new System.Drawing.Point(9, 19);
            this.xRotateButton.Name = "xRotateButton";
            this.xRotateButton.Size = new System.Drawing.Size(48, 48);
            this.xRotateButton.TabIndex = 5;
            this.xRotateButton.Text = "X";
            this.xRotateButton.UseVisualStyleBackColor = true;
            this.xRotateButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveButton_MouseDown);
            this.xRotateButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveButton_MouseUp);
            // 
            // zRotateButton
            // 
            this.zRotateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.zRotateButton.Location = new System.Drawing.Point(117, 19);
            this.zRotateButton.Name = "zRotateButton";
            this.zRotateButton.Size = new System.Drawing.Size(48, 48);
            this.zRotateButton.TabIndex = 4;
            this.zRotateButton.Text = "Z";
            this.zRotateButton.UseVisualStyleBackColor = true;
            this.zRotateButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveButton_MouseDown);
            this.zRotateButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveButton_MouseUp);
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
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.refreshButton);
            this.splitContainer1.Panel2MinSize = 261;
            this.splitContainer1.Size = new System.Drawing.Size(800, 491);
            this.splitContainer1.SplitterDistance = 535;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.visiblePlanesCheckBox);
            this.groupBox3.Controls.Add(this.figureComboBox);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(6, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(243, 97);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Фигура";
            // 
            // visiblePlanesCheckBox
            // 
            this.visiblePlanesCheckBox.AutoSize = true;
            this.visiblePlanesCheckBox.Location = new System.Drawing.Point(9, 59);
            this.visiblePlanesCheckBox.Name = "visiblePlanesCheckBox";
            this.visiblePlanesCheckBox.Size = new System.Drawing.Size(201, 24);
            this.visiblePlanesCheckBox.TabIndex = 1;
            this.visiblePlanesCheckBox.Text = "Невидимые плоскости";
            this.visiblePlanesCheckBox.UseVisualStyleBackColor = true;
            this.visiblePlanesCheckBox.CheckedChanged += new System.EventHandler(this.visiblePlanesCheckBox_CheckedChanged);
            // 
            // figureComboBox
            // 
            this.figureComboBox.DataSource = ((object)(resources.GetObject("figureComboBox.DataSource")));
            this.figureComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.figureComboBox.FormattingEnabled = true;
            this.figureComboBox.Location = new System.Drawing.Point(9, 25);
            this.figureComboBox.Name = "figureComboBox";
            this.figureComboBox.Size = new System.Drawing.Size(228, 28);
            this.figureComboBox.TabIndex = 0;
            this.figureComboBox.SelectedIndexChanged += new System.EventHandler(this.figureComboBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.xRotateButton);
            this.groupBox1.Controls.Add(this.zRotateButton);
            this.groupBox1.Controls.Add(this.yRotateButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(6, 257);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 76);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление";
            // 
            // yRotateButton
            // 
            this.yRotateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yRotateButton.Location = new System.Drawing.Point(63, 19);
            this.yRotateButton.Name = "yRotateButton";
            this.yRotateButton.Size = new System.Drawing.Size(48, 48);
            this.yRotateButton.TabIndex = 1;
            this.yRotateButton.Text = "Y";
            this.yRotateButton.UseVisualStyleBackColor = true;
            this.yRotateButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveButton_MouseDown);
            this.yRotateButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveButton_MouseUp);
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.refreshButton.Location = new System.Drawing.Point(6, 456);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.Text = "Очистить";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // ComputerGraphicsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ComputerGraphicsForm";
            this.Text = "LabWork5";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessTrackBar)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.TrackBar thicknessTrackBar;
        private System.Windows.Forms.Button xRotateButton;
        private System.Windows.Forms.Button zRotateButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button yRotateButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox visiblePlanesCheckBox;
        private System.Windows.Forms.ComboBox figureComboBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

