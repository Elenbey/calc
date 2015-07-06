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
            this.InputLable = new Label();
            this.ValueOneInput = new TextBox();
            this.ValueTwoInput = new TextBox();
            this.OutputLabel = new Label();
            this.OutputField = new TextBox();
            this.MultiplyButton = new Button();
            this.DivisionButton = new Button();
            this.AdditionButton = new Button();
            this.SubstractionButton = new Button();
            this.SuspendLayout();
            // 
            // InputLable
            // 
            this.InputLable.AutoSize = true;
            this.InputLable.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            this.InputLable.ForeColor = Color.DarkCyan;
            this.InputLable.Location = new Point(12, 9);
            this.InputLable.Name = "InputLable";
            this.InputLable.Size = new Size(41, 16);
            this.InputLable.TabIndex = 0;
            this.InputLable.Text = "Input";
            // 
            // ValueOneInput
            // 
            this.ValueOneInput.Location = new Point(12, 28);
            this.ValueOneInput.Name = "ValueOneInput";
            this.ValueOneInput.Size = new Size(104, 20);
            this.ValueOneInput.TabIndex = 1;
            // 
            // ValueTwoInput
            // 
            this.ValueTwoInput.Location = new Point(149, 28);
            this.ValueTwoInput.Name = "ValueTwoInput";
            this.ValueTwoInput.Size = new Size(100, 20);
            this.ValueTwoInput.TabIndex = 2;
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            this.OutputLabel.ForeColor = Color.DarkCyan;
            this.OutputLabel.Location = new Point(13, 68);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new Size(52, 16);
            this.OutputLabel.TabIndex = 3;
            this.OutputLabel.Text = "Output";
            // 
            // OutputField
            // 
            this.OutputField.Location = new Point(12, 102);
            this.OutputField.Name = "OutputField";
            this.OutputField.Size = new Size(237, 20);
            this.OutputField.TabIndex = 4;
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.MultiplyButton.Location = new Point(12, 140);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new Size(32, 28);
            this.MultiplyButton.TabIndex = 5;
            this.MultiplyButton.Text = "*";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new EventHandler(this.Calculate);
            // 
            // DivisionButton
            // 
            this.DivisionButton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.DivisionButton.Location = new Point(72, 140);
            this.DivisionButton.Name = "DivisionButton";
            this.DivisionButton.Size = new Size(29, 28);
            this.DivisionButton.TabIndex = 6;
            this.DivisionButton.Text = "/";
            this.DivisionButton.UseVisualStyleBackColor = true;
            this.DivisionButton.Click += new EventHandler(this.Calculate);
            // 
            // AdditionButton
            // 
            this.AdditionButton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.AdditionButton.Location = new Point(137, 140);
            this.AdditionButton.Name = "AdditionButton";
            this.AdditionButton.Size = new Size(29, 28);
            this.AdditionButton.TabIndex = 7;
            this.AdditionButton.Text = "+";
            this.AdditionButton.UseVisualStyleBackColor = true;
            this.AdditionButton.Click += new EventHandler(this.Calculate);
            // 
            // SubstractionButton
            // 
            this.SubstractionButton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.SubstractionButton.Location = new Point(208, 140);
            this.SubstractionButton.Name = "SubstractionButton";
            this.SubstractionButton.Size = new Size(25, 28);
            this.SubstractionButton.TabIndex = 8;
            this.SubstractionButton.Text = "-";
            this.SubstractionButton.UseVisualStyleBackColor = true;
            this.SubstractionButton.Click += new EventHandler(this.Calculate);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(284, 261);
            this.Controls.Add(this.SubstractionButton);
            this.Controls.Add(this.AdditionButton);
            this.Controls.Add(this.DivisionButton);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.OutputField);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.ValueTwoInput);
            this.Controls.Add(this.ValueOneInput);
            this.Controls.Add(this.InputLable);
            this.Name = "MainForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Form1";
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
    }
}

