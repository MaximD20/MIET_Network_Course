
namespace Lab5
{
    partial class Lab5
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
            this.label1 = new System.Windows.Forms.Label();
            this.UrlBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SendButton = new System.Windows.Forms.Button();
            this.HTMLBox = new System.Windows.Forms.TextBox();
            this.ErrorBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(87, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Get HTML by url page";
            // 
            // UrlBox
            // 
            this.UrlBox.Location = new System.Drawing.Point(50, 49);
            this.UrlBox.Name = "UrlBox";
            this.UrlBox.Size = new System.Drawing.Size(426, 20);
            this.UrlBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "URL:";
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(127, 75);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(215, 34);
            this.SendButton.TabIndex = 3;
            this.SendButton.Text = "GET";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // HTMLBox
            // 
            this.HTMLBox.Location = new System.Drawing.Point(15, 116);
            this.HTMLBox.Multiline = true;
            this.HTMLBox.Name = "HTMLBox";
            this.HTMLBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.HTMLBox.Size = new System.Drawing.Size(461, 310);
            this.HTMLBox.TabIndex = 4;
            // 
            // ErrorBox
            // 
            this.ErrorBox.AutoEllipsis = true;
            this.ErrorBox.AutoSize = true;
            this.ErrorBox.ForeColor = System.Drawing.Color.Maroon;
            this.ErrorBox.Location = new System.Drawing.Point(12, 429);
            this.ErrorBox.MaximumSize = new System.Drawing.Size(504, 0);
            this.ErrorBox.Name = "ErrorBox";
            this.ErrorBox.Size = new System.Drawing.Size(35, 13);
            this.ErrorBox.TabIndex = 5;
            this.ErrorBox.Text = "label3";
            this.ErrorBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 486);
            this.Controls.Add(this.ErrorBox);
            this.Controls.Add(this.HTMLBox);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UrlBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Text browser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UrlBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox HTMLBox;
        private System.Windows.Forms.Label ErrorBox;
    }
}

