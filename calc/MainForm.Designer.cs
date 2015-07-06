using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace calc
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.InputLable = new System.Windows.Forms.Label();
            this.ValueOneInput = new System.Windows.Forms.TextBox();
            this.ValueTwoInput = new System.Windows.Forms.TextBox();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.OutputField = new System.Windows.Forms.TextBox();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.DivisionButton = new System.Windows.Forms.Button();
            this.AdditionButton = new System.Windows.Forms.Button();
            this.SubstractionButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // InputLable
            // 
            this.InputLable.AutoSize = true;
            this.InputLable.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputLable.ForeColor = System.Drawing.Color.SteelBlue;
            this.InputLable.Location = new System.Drawing.Point(155, 6);
            this.InputLable.Name = "InputLable";
            this.InputLable.Size = new System.Drawing.Size(52, 19);
            this.InputLable.TabIndex = 0;
            this.InputLable.Text = "Input";
            // 
            // ValueOneInput
            // 
            this.ValueOneInput.Location = new System.Drawing.Point(125, 28);
            this.ValueOneInput.Name = "ValueOneInput";
            this.ValueOneInput.Size = new System.Drawing.Size(147, 20);
            this.ValueOneInput.TabIndex = 1;
            this.ValueOneInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueInputKeyPress);
            // 
            // ValueTwoInput
            // 
            this.ValueTwoInput.Location = new System.Drawing.Point(125, 70);
            this.ValueTwoInput.Name = "ValueTwoInput";
            this.ValueTwoInput.Size = new System.Drawing.Size(147, 20);
            this.ValueTwoInput.TabIndex = 2;
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.OutputLabel.Location = new System.Drawing.Point(12, 199);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(72, 19);
            this.OutputLabel.TabIndex = 3;
            this.OutputLabel.Text = "Output:";
            // 
            // OutputField
            // 
            this.OutputField.Location = new System.Drawing.Point(86, 198);
            this.OutputField.Name = "OutputField";
            this.OutputField.Size = new System.Drawing.Size(186, 20);
            this.OutputField.TabIndex = 4;
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MultiplyButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.MultiplyButton.Location = new System.Drawing.Point(182, 120);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(52, 40);
            this.MultiplyButton.TabIndex = 5;
            this.MultiplyButton.Text = "*";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.Calculate);
            // 
            // DivisionButton
            // 
            this.DivisionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DivisionButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.DivisionButton.Location = new System.Drawing.Point(125, 120);
            this.DivisionButton.Name = "DivisionButton";
            this.DivisionButton.Size = new System.Drawing.Size(51, 40);
            this.DivisionButton.TabIndex = 6;
            this.DivisionButton.Text = "/";
            this.DivisionButton.UseVisualStyleBackColor = true;
            this.DivisionButton.Click += new System.EventHandler(this.Calculate);
            // 
            // AdditionButton
            // 
            this.AdditionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdditionButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.AdditionButton.Location = new System.Drawing.Point(12, 120);
            this.AdditionButton.Name = "AdditionButton";
            this.AdditionButton.Size = new System.Drawing.Size(48, 40);
            this.AdditionButton.TabIndex = 7;
            this.AdditionButton.Text = "+";
            this.AdditionButton.UseVisualStyleBackColor = true;
            this.AdditionButton.Click += new System.EventHandler(this.Calculate);
            // 
            // SubstractionButton
            // 
            this.SubstractionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubstractionButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.SubstractionButton.Location = new System.Drawing.Point(67, 120);
            this.SubstractionButton.Name = "SubstractionButton";
            this.SubstractionButton.Size = new System.Drawing.Size(51, 40);
            this.SubstractionButton.TabIndex = 8;
            this.SubstractionButton.Text = "-";
            this.SubstractionButton.UseVisualStyleBackColor = true;
            this.SubstractionButton.Click += new System.EventHandler(this.Calculate);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-23, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SubstractionButton);
            this.Controls.Add(this.AdditionButton);
            this.Controls.Add(this.DivisionButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.OutputField);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.ValueTwoInput);
            this.Controls.Add(this.ValueOneInput);
            this.Controls.Add(this.InputLable);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label InputLable;
        private TextBox ValueOneInput;
        private TextBox ValueTwoInput;
        private Label OutputLabel;
        private TextBox OutputField;
        private Button MultiplyButton;
        private Button DivisionButton;
        private Button AdditionButton;
        private Button SubstractionButton;
        private PictureBox pictureBox1;
    }
}

