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
            this.ValueOneInput = new System.Windows.Forms.TextBox();
            this.ValueTwoInput = new System.Windows.Forms.TextBox();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.OutputField = new System.Windows.Forms.TextBox();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.DivisionButton = new System.Windows.Forms.Button();
            this.AdditionButton = new System.Windows.Forms.Button();
            this.SubstractionButton = new System.Windows.Forms.Button();
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
            // InputValueOne
            // 
            this.ValueOneInput.Location = new System.Drawing.Point(12, 28);
            this.ValueOneInput.Name = "InputValueOne";
            this.ValueOneInput.Size = new System.Drawing.Size(104, 20);
            this.ValueOneInput.TabIndex = 1;
            this.ValueOneInput.TextChanged += new System.EventHandler(this.ValueOneInputTextChanged);
            // 
            // InpValTwo
            // 
            this.ValueTwoInput.Location = new System.Drawing.Point(149, 28);
            this.ValueTwoInput.Name = "InpValTwo";
            this.ValueTwoInput.Size = new System.Drawing.Size(100, 20);
            this.ValueTwoInput.TabIndex = 2;
            this.ValueTwoInput.TextChanged += new System.EventHandler(this.ValueTwoInputTextChanged);
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
            this.OutputField.Location = new System.Drawing.Point(12, 102);
            this.OutputField.Name = "Output";
            this.OutputField.Size = new System.Drawing.Size(237, 20);
            this.OutputField.TabIndex = 4;
            this.OutputField.TextChanged += new System.EventHandler(this.OutputFieldTextChanged);
            // 
            // ButtMltp
            // 
            this.MultiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MultiplyButton.Location = new System.Drawing.Point(12, 140);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(32, 28);
            this.MultiplyButton.TabIndex = 5;
            this.MultiplyButton.Text = "*";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButtonClick);
            // 
            // ButtDiv
            // 
            this.DivisionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DivisionButton.Location = new System.Drawing.Point(72, 140);
            this.DivisionButton.Name = "DivisionButton";
            this.DivisionButton.Size = new System.Drawing.Size(29, 28);
            this.DivisionButton.TabIndex = 6;
            this.DivisionButton.Text = "/";
            this.DivisionButton.UseVisualStyleBackColor = true;
            this.DivisionButton.Click += new System.EventHandler(this.DivisionButtonClick);
            // 
            // ButtAdd
            // 
            this.AdditionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdditionButton.Location = new System.Drawing.Point(137, 140);
            this.AdditionButton.Name = "AdditionButton";
            this.AdditionButton.Size = new System.Drawing.Size(29, 28);
            this.AdditionButton.TabIndex = 7;
            this.AdditionButton.Text = "+";
            this.AdditionButton.UseVisualStyleBackColor = true;
            this.AdditionButton.Click += new System.EventHandler(this.AdditionButtonClick);
            // 
            // ButtSubr
            // 
            this.SubstractionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubstractionButton.Location = new System.Drawing.Point(208, 140);
            this.SubstractionButton.Name = "SubstractionButton";
            this.SubstractionButton.Size = new System.Drawing.Size(25, 28);
            this.SubstractionButton.TabIndex = 8;
            this.SubstractionButton.Text = "-";
            this.SubstractionButton.UseVisualStyleBackColor = true;
            this.SubstractionButton.Click += new System.EventHandler(this.SubstractionButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.SubstractionButton);
            this.Controls.Add(this.AdditionButton);
            this.Controls.Add(this.DivisionButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.OutputField);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.ValueTwoInput);
            this.Controls.Add(this.ValueOneInput);
            this.Controls.Add(this.InputLable);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InputLable;
        private System.Windows.Forms.TextBox ValueOneInput;
        private System.Windows.Forms.TextBox ValueTwoInput;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.TextBox OutputField;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button DivisionButton;
        private System.Windows.Forms.Button AdditionButton;
        private System.Windows.Forms.Button SubstractionButton;
    }
}

