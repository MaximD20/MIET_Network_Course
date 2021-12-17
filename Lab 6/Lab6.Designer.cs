
namespace Lab_6
{
    partial class Lab6
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
            this.label2 = new System.Windows.Forms.Label();
            this.FileAdress = new System.Windows.Forms.TextBox();
            this.PathSave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonSend = new System.Windows.Forms.Button();
            this.SuccessBox = new System.Windows.Forms.Label();
            this.ErrorBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(116, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "FTP Downloader";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(45, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Url file for download:";
            // 
            // FileAdress
            // 
            this.FileAdress.Location = new System.Drawing.Point(194, 51);
            this.FileAdress.Name = "FileAdress";
            this.FileAdress.Size = new System.Drawing.Size(223, 20);
            this.FileAdress.TabIndex = 4;
            // 
            // PathSave
            // 
            this.PathSave.Location = new System.Drawing.Point(194, 89);
            this.PathSave.Name = "PathSave";
            this.PathSave.Size = new System.Drawing.Size(223, 20);
            this.PathSave.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Path directory for save file:";
            // 
            // ButtonSend
            // 
            this.ButtonSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSend.Location = new System.Drawing.Point(9, 124);
            this.ButtonSend.Name = "ButtonSend";
            this.ButtonSend.Size = new System.Drawing.Size(424, 49);
            this.ButtonSend.TabIndex = 7;
            this.ButtonSend.Text = "Get File";
            this.ButtonSend.UseVisualStyleBackColor = true;
            this.ButtonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // SuccessBox
            // 
            this.SuccessBox.AutoSize = true;
            this.SuccessBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SuccessBox.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.SuccessBox.Location = new System.Drawing.Point(191, 185);
            this.SuccessBox.Name = "SuccessBox";
            this.SuccessBox.Size = new System.Drawing.Size(61, 17);
            this.SuccessBox.TabIndex = 8;
            this.SuccessBox.Text = "Success";
            // 
            // ErrorBox
            // 
            this.ErrorBox.AutoSize = true;
            this.ErrorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorBox.ForeColor = System.Drawing.Color.Brown;
            this.ErrorBox.Location = new System.Drawing.Point(12, 209);
            this.ErrorBox.Name = "ErrorBox";
            this.ErrorBox.Size = new System.Drawing.Size(40, 17);
            this.ErrorBox.TabIndex = 9;
            this.ErrorBox.Text = "Error";
            // 
            // Lab6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 249);
            this.Controls.Add(this.ErrorBox);
            this.Controls.Add(this.SuccessBox);
            this.Controls.Add(this.ButtonSend);
            this.Controls.Add(this.PathSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FileAdress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Lab6";
            this.Text = "FTP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FileAdress;
        private System.Windows.Forms.TextBox PathSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonSend;
        private System.Windows.Forms.Label SuccessBox;
        private System.Windows.Forms.Label ErrorBox;
    }
}

