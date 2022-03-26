
namespace LabWork4
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
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.refreshButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.decreaseButton = new System.Windows.Forms.Button();
            this.increaseButton = new System.Windows.Forms.Button();
            this.rotateUndoButton = new System.Windows.Forms.Button();
            this.rotateRedoButton = new System.Windows.Forms.Button();
            this.moveDownButton = new System.Windows.Forms.Button();
            this.moveRightButton = new System.Windows.Forms.Button();
            this.moveUpButton = new System.Windows.Forms.Button();
            this.moveLeftButton = new System.Windows.Forms.Button();
            this.thicknessTrackBar = new System.Windows.Forms.TrackBar();
            this.colorButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessTrackBar)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.refreshButton.Location = new System.Drawing.Point(6, 499);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.Text = "Очистить";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.decreaseButton);
            this.groupBox1.Controls.Add(this.increaseButton);
            this.groupBox1.Controls.Add(this.rotateUndoButton);
            this.groupBox1.Controls.Add(this.rotateRedoButton);
            this.groupBox1.Controls.Add(this.moveDownButton);
            this.groupBox1.Controls.Add(this.moveRightButton);
            this.groupBox1.Controls.Add(this.moveUpButton);
            this.groupBox1.Controls.Add(this.moveLeftButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(6, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 296);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление";
            // 
            // decreaseButton
            // 
            this.decreaseButton.BackgroundImage = global::LabWork4.Properties.Resources.decrease;
            this.decreaseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.decreaseButton.Location = new System.Drawing.Point(171, 73);
            this.decreaseButton.Name = "decreaseButton";
            this.decreaseButton.Size = new System.Drawing.Size(48, 48);
            this.decreaseButton.TabIndex = 7;
            this.decreaseButton.UseVisualStyleBackColor = true;
            this.decreaseButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveButton_MouseDown);
            this.decreaseButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveButton_MouseUp);
            // 
            // increaseButton
            // 
            this.increaseButton.BackgroundImage = global::LabWork4.Properties.Resources.increase;
            this.increaseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.increaseButton.Location = new System.Drawing.Point(171, 19);
            this.increaseButton.Name = "increaseButton";
            this.increaseButton.Size = new System.Drawing.Size(48, 48);
            this.increaseButton.TabIndex = 6;
            this.increaseButton.UseVisualStyleBackColor = true;
            this.increaseButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveButton_MouseDown);
            this.increaseButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveButton_MouseUp);
            // 
            // rotateUndoButton
            // 
            this.rotateUndoButton.BackgroundImage = global::LabWork4.Properties.Resources.rotate_undo;
            this.rotateUndoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rotateUndoButton.Location = new System.Drawing.Point(9, 19);
            this.rotateUndoButton.Name = "rotateUndoButton";
            this.rotateUndoButton.Size = new System.Drawing.Size(48, 48);
            this.rotateUndoButton.TabIndex = 5;
            this.rotateUndoButton.UseVisualStyleBackColor = true;
            this.rotateUndoButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveButton_MouseDown);
            this.rotateUndoButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveButton_MouseUp);
            // 
            // rotateRedoButton
            // 
            this.rotateRedoButton.BackgroundImage = global::LabWork4.Properties.Resources.rotate_redo;
            this.rotateRedoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rotateRedoButton.Location = new System.Drawing.Point(117, 19);
            this.rotateRedoButton.Name = "rotateRedoButton";
            this.rotateRedoButton.Size = new System.Drawing.Size(48, 48);
            this.rotateRedoButton.TabIndex = 4;
            this.rotateRedoButton.UseVisualStyleBackColor = true;
            this.rotateRedoButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveButton_MouseDown);
            this.rotateRedoButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveButton_MouseUp);
            // 
            // moveDownButton
            // 
            this.moveDownButton.BackgroundImage = global::LabWork4.Properties.Resources.move_down;
            this.moveDownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.moveDownButton.Location = new System.Drawing.Point(63, 73);
            this.moveDownButton.Name = "moveDownButton";
            this.moveDownButton.Size = new System.Drawing.Size(48, 48);
            this.moveDownButton.TabIndex = 3;
            this.moveDownButton.UseVisualStyleBackColor = true;
            this.moveDownButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveButton_MouseDown);
            this.moveDownButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveButton_MouseUp);
            // 
            // moveRightButton
            // 
            this.moveRightButton.BackgroundImage = global::LabWork4.Properties.Resources.move_right;
            this.moveRightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.moveRightButton.Location = new System.Drawing.Point(117, 73);
            this.moveRightButton.Name = "moveRightButton";
            this.moveRightButton.Size = new System.Drawing.Size(48, 48);
            this.moveRightButton.TabIndex = 2;
            this.moveRightButton.UseVisualStyleBackColor = true;
            this.moveRightButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveButton_MouseDown);
            this.moveRightButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveButton_MouseUp);
            // 
            // moveUpButton
            // 
            this.moveUpButton.BackgroundImage = global::LabWork4.Properties.Resources.move_up;
            this.moveUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.moveUpButton.Location = new System.Drawing.Point(63, 19);
            this.moveUpButton.Name = "moveUpButton";
            this.moveUpButton.Size = new System.Drawing.Size(48, 48);
            this.moveUpButton.TabIndex = 1;
            this.moveUpButton.UseVisualStyleBackColor = true;
            this.moveUpButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveButton_MouseDown);
            this.moveUpButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveButton_MouseUp);
            // 
            // moveLeftButton
            // 
            this.moveLeftButton.BackgroundImage = global::LabWork4.Properties.Resources.move_left;
            this.moveLeftButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.moveLeftButton.Location = new System.Drawing.Point(9, 73);
            this.moveLeftButton.Name = "moveLeftButton";
            this.moveLeftButton.Size = new System.Drawing.Size(48, 48);
            this.moveLeftButton.TabIndex = 0;
            this.moveLeftButton.UseVisualStyleBackColor = true;
            this.moveLeftButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveButton_MouseDown);
            this.moveLeftButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moveButton_MouseUp);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.colorButton);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.thicknessTrackBar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(6, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 136);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры линии";
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
            this.splitContainer1.Panel2MinSize = 261;
            this.splitContainer1.Size = new System.Drawing.Size(800, 534);
            this.splitContainer1.SplitterDistance = 535;
            this.splitContainer1.TabIndex = 1;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(535, 534);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.SizeChanged += new System.EventHandler(this.pictureBox_SizeChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 160);
            this.label1.TabIndex = 8;
            this.label1.Text = "W - Вверх\r\nA - Налево\r\nS - Вниз\r\nD - Направо\r\nQ - Против часовой\r\nE - По часовой\r" +
    "\nR - Увеличить\r\nF - Уменьшить\r\n";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.splitContainer1);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "LabWork4";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessTrackBar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar thicknessTrackBar;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button moveLeftButton;
        private System.Windows.Forms.Button moveDownButton;
        private System.Windows.Forms.Button moveRightButton;
        private System.Windows.Forms.Button moveUpButton;
        private System.Windows.Forms.Button rotateRedoButton;
        private System.Windows.Forms.Button rotateUndoButton;
        private System.Windows.Forms.Button decreaseButton;
        private System.Windows.Forms.Button increaseButton;
        private System.Windows.Forms.Label label1;
    }
}

