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
            this.ModuleButton = new System.Windows.Forms.Button();
            this.CosButton = new System.Windows.Forms.Button();
            this.SinButton = new System.Windows.Forms.Button();
            this.PowerButton = new System.Windows.Forms.Button();
            this.SqrtButton = new System.Windows.Forms.Button();
            this.TanButton = new System.Windows.Forms.Button();
            this.LogButton = new System.Windows.Forms.Button();
            this.SinhButton = new System.Windows.Forms.Button();
            this.BubbleSortButton = new System.Windows.Forms.Button();
            this.CocktailSortButton = new System.Windows.Forms.Button();
            this.GnomeSortButton = new System.Windows.Forms.Button();
            this.SelectionSortButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // InputLable
            // 
            this.InputLable.AutoSize = true;
            this.InputLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputLable.ForeColor = System.Drawing.Color.SteelBlue;
            this.InputLable.Location = new System.Drawing.Point(155, 6);
            this.InputLable.Name = "InputLable";
            this.InputLable.Size = new System.Drawing.Size(51, 20);
            this.InputLable.TabIndex = 0;
            this.InputLable.Text = "Input";
            // 
            // ValueOneInput
            // 
            this.ValueOneInput.Location = new System.Drawing.Point(125, 28);
            this.ValueOneInput.Name = "ValueOneInput";
            this.ValueOneInput.Size = new System.Drawing.Size(224, 20);
            this.ValueOneInput.TabIndex = 1;
            this.ValueOneInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ValueOneInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueOneInputKeyPress);
            // 
            // ValueTwoInput
            // 
            this.ValueTwoInput.Location = new System.Drawing.Point(125, 70);
            this.ValueTwoInput.Name = "ValueTwoInput";
            this.ValueTwoInput.Size = new System.Drawing.Size(224, 20);
            this.ValueTwoInput.TabIndex = 2;
            this.ValueTwoInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ValueTwoInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValueTwoInputKeyPress);
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.OutputLabel.Location = new System.Drawing.Point(12, 282);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(69, 20);
            this.OutputLabel.TabIndex = 3;
            this.OutputLabel.Text = "Output:";
            // 
            // OutputField
            // 
            this.OutputField.Location = new System.Drawing.Point(87, 282);
            this.OutputField.Name = "OutputField";
            this.OutputField.ReadOnly = true;
            this.OutputField.Size = new System.Drawing.Size(262, 20);
            this.OutputField.TabIndex = 4;
            this.OutputField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.MultiplyButton.Click += new System.EventHandler(this.CalculateTwoArguments);
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
            this.DivisionButton.Click += new System.EventHandler(this.CalculateTwoArguments);
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
            this.AdditionButton.Click += new System.EventHandler(this.CalculateTwoArguments);
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
            this.SubstractionButton.Click += new System.EventHandler(this.CalculateTwoArguments);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-22, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // ModuleButton
            // 
            this.ModuleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModuleButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ModuleButton.Location = new System.Drawing.Point(241, 167);
            this.ModuleButton.Name = "ModuleButton";
            this.ModuleButton.Size = new System.Drawing.Size(51, 40);
            this.ModuleButton.TabIndex = 10;
            this.ModuleButton.Text = "abs";
            this.ModuleButton.UseVisualStyleBackColor = true;
            this.ModuleButton.Click += new System.EventHandler(this.CalculateSingleArgument);
            // 
            // CosButton
            // 
            this.CosButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CosButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.CosButton.Location = new System.Drawing.Point(298, 166);
            this.CosButton.Name = "CosButton";
            this.CosButton.Size = new System.Drawing.Size(51, 40);
            this.CosButton.TabIndex = 11;
            this.CosButton.Text = "cos";
            this.CosButton.UseVisualStyleBackColor = true;
            this.CosButton.Click += new System.EventHandler(this.CalculateSingleArgument);
            // 
            // SinButton
            // 
            this.SinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SinButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.SinButton.Location = new System.Drawing.Point(298, 120);
            this.SinButton.Name = "SinButton";
            this.SinButton.Size = new System.Drawing.Size(51, 40);
            this.SinButton.TabIndex = 12;
            this.SinButton.Text = "sin";
            this.SinButton.UseVisualStyleBackColor = true;
            this.SinButton.Click += new System.EventHandler(this.CalculateSingleArgument);
            // 
            // PowerButton
            // 
            this.PowerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PowerButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.PowerButton.Location = new System.Drawing.Point(240, 120);
            this.PowerButton.Name = "PowerButton";
            this.PowerButton.Size = new System.Drawing.Size(52, 40);
            this.PowerButton.TabIndex = 13;
            this.PowerButton.Text = "pow";
            this.PowerButton.UseVisualStyleBackColor = true;
            this.PowerButton.Click += new System.EventHandler(this.CalculateTwoArguments);
            // 
            // SqrtButton
            // 
            this.SqrtButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SqrtButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.SqrtButton.Location = new System.Drawing.Point(12, 166);
            this.SqrtButton.Name = "SqrtButton";
            this.SqrtButton.Size = new System.Drawing.Size(48, 40);
            this.SqrtButton.TabIndex = 14;
            this.SqrtButton.Text = "sqrt";
            this.SqrtButton.UseVisualStyleBackColor = true;
            this.SqrtButton.Click += new System.EventHandler(this.CalculateSingleArgument);
            // 
            // TanButton
            // 
            this.TanButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TanButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TanButton.Location = new System.Drawing.Point(68, 167);
            this.TanButton.Name = "TanButton";
            this.TanButton.Size = new System.Drawing.Size(50, 39);
            this.TanButton.TabIndex = 15;
            this.TanButton.Text = "tan";
            this.TanButton.UseVisualStyleBackColor = true;
            this.TanButton.Click += new System.EventHandler(this.CalculateSingleArgument);
            // 
            // LogButton
            // 
            this.LogButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.LogButton.Location = new System.Drawing.Point(125, 167);
            this.LogButton.Name = "LogButton";
            this.LogButton.Size = new System.Drawing.Size(51, 39);
            this.LogButton.TabIndex = 16;
            this.LogButton.Text = "log";
            this.LogButton.UseVisualStyleBackColor = true;
            this.LogButton.Click += new System.EventHandler(this.CalculateSingleArgument);
            // 
            // SinhButton
            // 
            this.SinhButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SinhButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.SinhButton.Location = new System.Drawing.Point(183, 167);
            this.SinhButton.Name = "SinhButton";
            this.SinhButton.Size = new System.Drawing.Size(51, 39);
            this.SinhButton.TabIndex = 17;
            this.SinhButton.Text = "sinh";
            this.SinhButton.UseVisualStyleBackColor = true;
            this.SinhButton.Click += new System.EventHandler(this.CalculateSingleArgument);
            // 
            // BubbleSortButton
            // 
            this.BubbleSortButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BubbleSortButton.Location = new System.Drawing.Point(12, 225);
            this.BubbleSortButton.Name = "BubbleSortButton";
            this.BubbleSortButton.Size = new System.Drawing.Size(87, 39);
            this.BubbleSortButton.TabIndex = 18;
            this.BubbleSortButton.Text = "Bubble";
            this.BubbleSortButton.UseVisualStyleBackColor = true;
            this.BubbleSortButton.Click += new System.EventHandler(this.ArraySortes);
            // 
            // CocktailSortButton
            // 
            this.CocktailSortButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CocktailSortButton.Location = new System.Drawing.Point(105, 225);
            this.CocktailSortButton.Name = "CocktailSortButton";
            this.CocktailSortButton.Size = new System.Drawing.Size(79, 38);
            this.CocktailSortButton.TabIndex = 19;
            this.CocktailSortButton.Text = "Cocktail";
            this.CocktailSortButton.UseVisualStyleBackColor = true;
            this.CocktailSortButton.Click += new System.EventHandler(this.ArraySortes);
            // 
            // GnomeSortButton
            // 
            this.GnomeSortButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GnomeSortButton.Location = new System.Drawing.Point(190, 225);
            this.GnomeSortButton.Name = "GnomeSortButton";
            this.GnomeSortButton.Size = new System.Drawing.Size(77, 39);
            this.GnomeSortButton.TabIndex = 20;
            this.GnomeSortButton.Text = "Gnome";
            this.GnomeSortButton.UseVisualStyleBackColor = true;
            this.GnomeSortButton.Click += new System.EventHandler(this.ArraySortes);
            // 
            // SelectionSortButton
            // 
            this.SelectionSortButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SelectionSortButton.Location = new System.Drawing.Point(273, 224);
            this.SelectionSortButton.Name = "SelectionSortButton";
            this.SelectionSortButton.Size = new System.Drawing.Size(76, 39);
            this.SelectionSortButton.TabIndex = 21;
            this.SelectionSortButton.Text = "Selection";
            this.SelectionSortButton.UseVisualStyleBackColor = true;
            this.SelectionSortButton.Click += new System.EventHandler(this.ArraySortes);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 311);
            this.Controls.Add(this.SelectionSortButton);
            this.Controls.Add(this.GnomeSortButton);
            this.Controls.Add(this.CocktailSortButton);
            this.Controls.Add(this.BubbleSortButton);
            this.Controls.Add(this.SinhButton);
            this.Controls.Add(this.LogButton);
            this.Controls.Add(this.TanButton);
            this.Controls.Add(this.SqrtButton);
            this.Controls.Add(this.PowerButton);
            this.Controls.Add(this.SinButton);
            this.Controls.Add(this.CosButton);
            this.Controls.Add(this.ModuleButton);
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
        private Button ModuleButton;
        private Button CosButton;
        private Button SinButton;
        private Button PowerButton;
        private Button SqrtButton;
        private Button TanButton;
        private Button LogButton;
        private Button SinhButton;
        private Button BubbleSortButton;
        private Button CocktailSortButton;
        private Button GnomeSortButton;
        private Button SelectionSortButton;
    }
}

