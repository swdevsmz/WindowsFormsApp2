namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.c1DateEdit1 = new C1.Win.Calendar.C1DateEdit();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.c1DateEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1DateEdit1
            // 
            this.c1DateEdit1.AllowSpinLoop = false;
            this.c1DateEdit1.Calendar.RightToLeft = System.Windows.Forms.RightToLeft.Inherit;
            this.c1DateEdit1.ImagePadding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.c1DateEdit1.Location = new System.Drawing.Point(12, 73);
            this.c1DateEdit1.Name = "c1DateEdit1";
            this.c1DateEdit1.Size = new System.Drawing.Size(200, 17);
            this.c1DateEdit1.TabIndex = 0;
            this.c1DateEdit1.Tag = null;
            this.c1DateEdit1.ValueChanged += new System.EventHandler(this.c1DateEdit1_ValueChanged);
            this.c1DateEdit1.TextChanged += new System.EventHandler(this.c1DateEdit1_TextChanged);
            this.c1DateEdit1.LostFocus += new System.EventHandler(this.c1DateEdit1_LostFocus);

            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(184, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.c1DateEdit1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1DateEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.Calendar.C1DateEdit c1DateEdit1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

