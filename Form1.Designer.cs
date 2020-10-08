namespace kursovaya_bakinykh
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
            this.messagebox = new System.Windows.Forms.TextBox();
            this.keybox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messagebox
            // 
            this.messagebox.Location = new System.Drawing.Point(135, 59);
            this.messagebox.Name = "messagebox";
            this.messagebox.Size = new System.Drawing.Size(669, 38);
            this.messagebox.TabIndex = 0;
            // 
            // keybox
            // 
            this.keybox.Location = new System.Drawing.Point(135, 158);
            this.keybox.Name = "keybox";
            this.keybox.Size = new System.Drawing.Size(669, 38);
            this.keybox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "сообщение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "ключ шифрования";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(462, 72);
            this.button1.TabIndex = 4;
            this.button1.Text = "зашифровать/расшифровать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 403);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keybox);
            this.Controls.Add(this.messagebox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox messagebox;
        private System.Windows.Forms.TextBox keybox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

