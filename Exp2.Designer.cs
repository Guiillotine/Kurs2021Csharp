
namespace Kurs2021Csharp
{
    partial class Exp2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.to = new System.Windows.Forms.MaskedTextBox();
            this.from = new System.Windows.Forms.MaskedTextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fileName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(213, 53);
            this.to.Mask = "0000";
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(31, 20);
            this.to.TabIndex = 85;
            this.to.ValidatingType = typeof(System.DateTime);
            // 
            // from
            // 
            this.from.Location = new System.Drawing.Point(157, 53);
            this.from.Mask = "0000";
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(31, 20);
            this.from.TabIndex = 84;
            this.from.ValidatingType = typeof(System.DateTime);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 122);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(60, 23);
            this.buttonBack.TabIndex = 83;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(184, 122);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(60, 23);
            this.buttonOk.TabIndex = 82;
            this.buttonOk.Text = "Ок";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 81;
            this.label4.Text = "_";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 80;
            this.label3.Text = "Экспортировать строки:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 79;
            this.label2.Text = "Введите название файла:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "Экспорт журнала учета выполненной ПКД";
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(156, 92);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(88, 20);
            this.fileName.TabIndex = 77;
            // 
            // Exp2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(257, 158);
            this.Controls.Add(this.to);
            this.Controls.Add(this.from);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileName);
            this.MaximizeBox = false;
            this.Name = "Exp2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Экспорт журнала";
            this.Load += new System.EventHandler(this.Exp2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox to;
        private System.Windows.Forms.MaskedTextBox from;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fileName;
    }
}