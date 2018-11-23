namespace Lab1_CA
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.lbInput = new System.Windows.Forms.Label();
            this.btCheck = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.lbM = new System.Windows.Forms.Label();
            this.tbInM = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(109, 19);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(322, 20);
            this.textBox.TabIndex = 0;
            // 
            // lbInput
            // 
            this.lbInput.AutoSize = true;
            this.lbInput.Location = new System.Drawing.Point(21, 22);
            this.lbInput.Name = "lbInput";
            this.lbInput.Size = new System.Drawing.Size(64, 13);
            this.lbInput.TabIndex = 1;
            this.lbInput.Text = "Input sticks:";
            // 
            // btCheck
            // 
            this.btCheck.Location = new System.Drawing.Point(24, 122);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(75, 23);
            this.btCheck.TabIndex = 2;
            this.btCheck.Text = "Check";
            this.btCheck.UseVisualStyleBackColor = true;
            this.btCheck.Click += new System.EventHandler(this.btCheck_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(181, 122);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 3;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(356, 122);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 4;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // lbM
            // 
            this.lbM.AutoSize = true;
            this.lbM.Location = new System.Drawing.Point(21, 73);
            this.lbM.Name = "lbM";
            this.lbM.Size = new System.Drawing.Size(46, 13);
            this.lbM.TabIndex = 6;
            this.lbM.Text = "Input M:";
            // 
            // tbInM
            // 
            this.tbInM.Location = new System.Drawing.Point(109, 70);
            this.tbInM.Name = "tbInM";
            this.tbInM.Size = new System.Drawing.Size(322, 20);
            this.tbInM.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 160);
            this.Controls.Add(this.tbInM);
            this.Controls.Add(this.lbM);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btCheck);
            this.Controls.Add(this.lbInput);
            this.Controls.Add(this.textBox);
            this.Name = "MainForm";
            this.Text = "Lab1 ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label lbInput;
        private System.Windows.Forms.Button btCheck;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label lbM;
        private System.Windows.Forms.TextBox tbInM;
    }
}

