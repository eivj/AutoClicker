namespace AutoClicker
{
    partial class AutoClicker
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
            this.components = new System.ComponentModel.Container();
            this.Start = new System.Windows.Forms.Button();
            this.labelCurrentCursorPosition = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.textBoxCurrentCursorPositionX = new System.Windows.Forms.TextBox();
            this.textBoxCurrentCursorPositionY = new System.Windows.Forms.TextBox();
            this.labelSetCoordinates = new System.Windows.Forms.Label();
            this.textBoxSetCoordinateX = new System.Windows.Forms.TextBox();
            this.textBoxSetCoordinateY = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(109, 83);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.start_Click);
            // 
            // labelCurrentCursorPosition
            // 
            this.labelCurrentCursorPosition.AutoSize = true;
            this.labelCurrentCursorPosition.Location = new System.Drawing.Point(12, 9);
            this.labelCurrentCursorPosition.Name = "labelCurrentCursorPosition";
            this.labelCurrentCursorPosition.Size = new System.Drawing.Size(112, 13);
            this.labelCurrentCursorPosition.TabIndex = 2;
            this.labelCurrentCursorPosition.Text = "Current cursor position";
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(12, 34);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(14, 13);
            this.labelX.TabIndex = 3;
            this.labelX.Text = "X";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(12, 59);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(14, 13);
            this.labelY.TabIndex = 4;
            this.labelY.Text = "Y";
            // 
            // textBoxCurrentCursorPositionX
            // 
            this.textBoxCurrentCursorPositionX.Enabled = false;
            this.textBoxCurrentCursorPositionX.Location = new System.Drawing.Point(32, 31);
            this.textBoxCurrentCursorPositionX.Name = "textBoxCurrentCursorPositionX";
            this.textBoxCurrentCursorPositionX.ReadOnly = true;
            this.textBoxCurrentCursorPositionX.Size = new System.Drawing.Size(100, 20);
            this.textBoxCurrentCursorPositionX.TabIndex = 5;
            // 
            // textBoxCurrentCursorPositionY
            // 
            this.textBoxCurrentCursorPositionY.Enabled = false;
            this.textBoxCurrentCursorPositionY.Location = new System.Drawing.Point(32, 56);
            this.textBoxCurrentCursorPositionY.Name = "textBoxCurrentCursorPositionY";
            this.textBoxCurrentCursorPositionY.ReadOnly = true;
            this.textBoxCurrentCursorPositionY.Size = new System.Drawing.Size(100, 20);
            this.textBoxCurrentCursorPositionY.TabIndex = 6;
            // 
            // labelSetCoordinates
            // 
            this.labelSetCoordinates.AutoSize = true;
            this.labelSetCoordinates.Location = new System.Drawing.Point(157, 9);
            this.labelSetCoordinates.Name = "labelSetCoordinates";
            this.labelSetCoordinates.Size = new System.Drawing.Size(81, 13);
            this.labelSetCoordinates.TabIndex = 7;
            this.labelSetCoordinates.Text = "Set coordinates";
            // 
            // textBoxSetCoordinateX
            // 
            this.textBoxSetCoordinateX.Location = new System.Drawing.Point(160, 31);
            this.textBoxSetCoordinateX.Name = "textBoxSetCoordinateX";
            this.textBoxSetCoordinateX.Size = new System.Drawing.Size(100, 20);
            this.textBoxSetCoordinateX.TabIndex = 8;
            // 
            // textBoxSetCoordinateY
            // 
            this.textBoxSetCoordinateY.Location = new System.Drawing.Point(160, 57);
            this.textBoxSetCoordinateY.Name = "textBoxSetCoordinateY";
            this.textBoxSetCoordinateY.Size = new System.Drawing.Size(100, 20);
            this.textBoxSetCoordinateY.TabIndex = 9;
            // 
            // AutoClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 135);
            this.Controls.Add(this.textBoxSetCoordinateY);
            this.Controls.Add(this.textBoxSetCoordinateX);
            this.Controls.Add(this.labelSetCoordinates);
            this.Controls.Add(this.textBoxCurrentCursorPositionY);
            this.Controls.Add(this.textBoxCurrentCursorPositionX);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.labelCurrentCursorPosition);
            this.Controls.Add(this.Start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AutoClicker";
            this.Text = "AutoClicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label labelCurrentCursorPosition;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.TextBox textBoxCurrentCursorPositionX;
        private System.Windows.Forms.TextBox textBoxCurrentCursorPositionY;
        private System.Windows.Forms.Label labelSetCoordinates;
        private System.Windows.Forms.TextBox textBoxSetCoordinateX;
        private System.Windows.Forms.TextBox textBoxSetCoordinateY;
    }
}

