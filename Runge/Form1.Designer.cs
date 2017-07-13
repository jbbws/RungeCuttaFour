namespace Runge
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.y1st = new System.Windows.Forms.TextBox();
            this.y2st = new System.Windows.Forms.TextBox();
            this.y3st = new System.Windows.Forms.TextBox();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.Parallelcb = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Tftb = new System.Windows.Forms.TextBox();
            this.CalcBtn = new System.Windows.Forms.Button();
            this.pgb = new System.Windows.Forms.ProgressBar();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "y1(0)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "y2(0)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "y3(0)";
            // 
            // y1st
            // 
            this.y1st.Location = new System.Drawing.Point(48, 10);
            this.y1st.Name = "y1st";
            this.y1st.Size = new System.Drawing.Size(39, 20);
            this.y1st.TabIndex = 3;
            this.y1st.Text = "1";
            // 
            // y2st
            // 
            this.y2st.Location = new System.Drawing.Point(48, 36);
            this.y2st.Name = "y2st";
            this.y2st.Size = new System.Drawing.Size(39, 20);
            this.y2st.TabIndex = 4;
            this.y2st.Text = "1";
            // 
            // y3st
            // 
            this.y3st.Location = new System.Drawing.Point(48, 62);
            this.y3st.Name = "y3st";
            this.y3st.Size = new System.Drawing.Size(39, 20);
            this.y3st.TabIndex = 5;
            this.y3st.Text = "0";
            // 
            // rtb
            // 
            this.rtb.Location = new System.Drawing.Point(12, 119);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(178, 165);
            this.rtb.TabIndex = 6;
            this.rtb.Text = "";
            // 
            // Parallelcb
            // 
            this.Parallelcb.AutoSize = true;
            this.Parallelcb.Checked = true;
            this.Parallelcb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Parallelcb.Location = new System.Drawing.Point(130, 13);
            this.Parallelcb.Name = "Parallelcb";
            this.Parallelcb.Size = new System.Drawing.Size(60, 17);
            this.Parallelcb.TabIndex = 7;
            this.Parallelcb.Text = "Parallel";
            this.Parallelcb.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Время окончания";
            // 
            // Tftb
            // 
            this.Tftb.Location = new System.Drawing.Point(424, 10);
            this.Tftb.Name = "Tftb";
            this.Tftb.Size = new System.Drawing.Size(29, 20);
            this.Tftb.TabIndex = 10;
            this.Tftb.Text = "60";
            // 
            // CalcBtn
            // 
            this.CalcBtn.Location = new System.Drawing.Point(378, 251);
            this.CalcBtn.Name = "CalcBtn";
            this.CalcBtn.Size = new System.Drawing.Size(75, 23);
            this.CalcBtn.TabIndex = 11;
            this.CalcBtn.Text = "Calculate";
            this.CalcBtn.UseVisualStyleBackColor = true;
            this.CalcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // pgb
            // 
            this.pgb.Location = new System.Drawing.Point(196, 241);
            this.pgb.Name = "pgb";
            this.pgb.Size = new System.Drawing.Size(160, 33);
            this.pgb.TabIndex = 12;
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(378, 222);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(75, 23);
            this.cancelbtn.TabIndex = 13;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 296);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.pgb);
            this.Controls.Add(this.CalcBtn);
            this.Controls.Add(this.Tftb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Parallelcb);
            this.Controls.Add(this.rtb);
            this.Controls.Add(this.y3st);
            this.Controls.Add(this.y2st);
            this.Controls.Add(this.y1st);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox y1st;
        private System.Windows.Forms.TextBox y2st;
        private System.Windows.Forms.TextBox y3st;
        private System.Windows.Forms.RichTextBox rtb;
        private System.Windows.Forms.CheckBox Parallelcb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tftb;
        private System.Windows.Forms.Button CalcBtn;
        private System.Windows.Forms.ProgressBar pgb;
        private System.Windows.Forms.Button cancelbtn;
    }
}

