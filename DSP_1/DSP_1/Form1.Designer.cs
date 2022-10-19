
namespace DSP_1
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.numberInput = new System.Windows.Forms.ComboBox();
            this.signalTypeInput = new System.Windows.Forms.ComboBox();
            this.constValues = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(498, 468);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numberInput
            // 
            this.numberInput.FormattingEnabled = true;
            this.numberInput.Items.AddRange(new object[] {
            "512",
            "1024",
            "2048",
            "4096"});
            this.numberInput.Location = new System.Drawing.Point(3, 465);
            this.numberInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numberInput.Name = "numberInput";
            this.numberInput.Size = new System.Drawing.Size(92, 21);
            this.numberInput.TabIndex = 1;
            // 
            // signalTypeInput
            // 
            this.signalTypeInput.FormattingEnabled = true;
            this.signalTypeInput.Items.AddRange(new object[] {
            "harmonical",
            "polyharmonical",
            "poly+linear"});
            this.signalTypeInput.Location = new System.Drawing.Point(144, 465);
            this.signalTypeInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.signalTypeInput.Name = "signalTypeInput";
            this.signalTypeInput.Size = new System.Drawing.Size(92, 21);
            this.signalTypeInput.TabIndex = 2;
            // 
            // constValues
            // 
            this.constValues.FormattingEnabled = true;
            this.constValues.Items.AddRange(new object[] {
            "A and f const",
            "A and fi const",
            "fi and f const"});
            this.constValues.Location = new System.Drawing.Point(274, 465);
            this.constValues.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.constValues.Name = "constValues";
            this.constValues.Size = new System.Drawing.Size(92, 21);
            this.constValues.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 510);
            this.Controls.Add(this.constValues);
            this.Controls.Add(this.signalTypeInput);
            this.Controls.Add(this.numberInput);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox numberInput;
        private System.Windows.Forms.ComboBox signalTypeInput;
        private System.Windows.Forms.ComboBox constValues;
    }
}

