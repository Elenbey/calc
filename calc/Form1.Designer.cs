namespace calc
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.InputLable = new System.Windows.Forms.Label();
            this.InpValOne = new System.Windows.Forms.TextBox();
            this.InpValTwo = new System.Windows.Forms.TextBox();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.TextBox();
            this.ButtMltp = new System.Windows.Forms.Button();
            this.ButtDiv = new System.Windows.Forms.Button();
            this.ButtAdd = new System.Windows.Forms.Button();
            this.ButtSubr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputLable
            // 
            this.InputLable.AutoSize = true;
            this.InputLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputLable.ForeColor = System.Drawing.Color.DarkCyan;
            this.InputLable.Location = new System.Drawing.Point(12, 9);
            this.InputLable.Name = "InputLable";
            this.InputLable.Size = new System.Drawing.Size(41, 16);
            this.InputLable.TabIndex = 0;
            this.InputLable.Text = "Input";
            this.InputLable.Click += new System.EventHandler(this.InputLableClick);
            // 
            // InpValOne
            // 
            this.InpValOne.Location = new System.Drawing.Point(12, 28);
            this.InpValOne.Name = "InpValOne";
            this.InpValOne.Size = new System.Drawing.Size(104, 20);
            this.InpValOne.TabIndex = 1;
            this.InpValOne.TextChanged += new System.EventHandler(this.InpValOneTextChanged);
            // 
            // InpValTwo
            // 
            this.InpValTwo.Location = new System.Drawing.Point(149, 28);
            this.InpValTwo.Name = "InpValTwo";
            this.InpValTwo.Size = new System.Drawing.Size(100, 20);
            this.InpValTwo.TabIndex = 2;
            this.InpValTwo.TextChanged += new System.EventHandler(this.InpValTwoTextChanged);
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.OutputLabel.Location = new System.Drawing.Point(13, 68);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(52, 16);
            this.OutputLabel.TabIndex = 3;
            this.OutputLabel.Text = "Output";
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(12, 102);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(237, 20);
            this.Output.TabIndex = 4;
            this.Output.TextChanged += new System.EventHandler(this.OutputTextChanged);
            // 
            // ButtMltp
            // 
            this.ButtMltp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtMltp.Location = new System.Drawing.Point(12, 140);
            this.ButtMltp.Name = "ButtMltp";
            this.ButtMltp.Size = new System.Drawing.Size(32, 28);
            this.ButtMltp.TabIndex = 5;
            this.ButtMltp.Text = "*";
            this.ButtMltp.UseVisualStyleBackColor = true;
            this.ButtMltp.Click += new System.EventHandler(this.ButtMltpClick);
            // 
            // ButtDiv
            // 
            this.ButtDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtDiv.Location = new System.Drawing.Point(72, 140);
            this.ButtDiv.Name = "ButtDiv";
            this.ButtDiv.Size = new System.Drawing.Size(29, 28);
            this.ButtDiv.TabIndex = 6;
            this.ButtDiv.Text = "/";
            this.ButtDiv.UseVisualStyleBackColor = true;
            this.ButtDiv.Click += new System.EventHandler(this.ButtDivClick);
            // 
            // ButtAdd
            // 
            this.ButtAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtAdd.Location = new System.Drawing.Point(137, 140);
            this.ButtAdd.Name = "ButtAdd";
            this.ButtAdd.Size = new System.Drawing.Size(29, 28);
            this.ButtAdd.TabIndex = 7;
            this.ButtAdd.Text = "+";
            this.ButtAdd.UseVisualStyleBackColor = true;
            this.ButtAdd.Click += new System.EventHandler(this.ButtAddClick);
            // 
            // ButtSubr
            // 
            this.ButtSubr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtSubr.Location = new System.Drawing.Point(208, 140);
            this.ButtSubr.Name = "ButtSubr";
            this.ButtSubr.Size = new System.Drawing.Size(25, 28);
            this.ButtSubr.TabIndex = 8;
            this.ButtSubr.Text = "-";
            this.ButtSubr.UseVisualStyleBackColor = true;
            this.ButtSubr.Click += new System.EventHandler(this.ButtSubrClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ButtSubr);
            this.Controls.Add(this.ButtAdd);
            this.Controls.Add(this.ButtDiv);
            this.Controls.Add(this.ButtMltp);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.InpValTwo);
            this.Controls.Add(this.InpValOne);
            this.Controls.Add(this.InputLable);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InputLable;
        private System.Windows.Forms.TextBox InpValOne;
        private System.Windows.Forms.TextBox InpValTwo;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Button ButtMltp;
        private System.Windows.Forms.Button ButtDiv;
        private System.Windows.Forms.Button ButtAdd;
        private System.Windows.Forms.Button ButtSubr;
    }
}

