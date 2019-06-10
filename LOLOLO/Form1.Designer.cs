namespace LOLOLO
{
    partial class move_step
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
        	this.components = new System.ComponentModel.Container();
        	this.timer1 = new System.Windows.Forms.Timer(this.components);
        	this.label1 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.pictureBox1 = new System.Windows.Forms.PictureBox();
        	this.label3 = new System.Windows.Forms.Label();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// timer1
        	// 
        	this.timer1.Interval = 20;
        	this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(15, 14);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(49, 13);
        	this.label1.TabIndex = 1;
        	this.label1.Text = "label1";
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(100, 14);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(49, 13);
        	this.label2.TabIndex = 2;
        	this.label2.Text = "label2";
        	// 
        	// pictureBox1
        	// 
        	this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        	this.pictureBox1.Location = new System.Drawing.Point(286, 207);
        	this.pictureBox1.Name = "pictureBox1";
        	this.pictureBox1.Size = new System.Drawing.Size(111, 87);
        	this.pictureBox1.TabIndex = 0;
        	this.pictureBox1.TabStop = false;
        	// 
        	// label3
        	// 
        	this.label3.Location = new System.Drawing.Point(12, 474);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(100, 18);
        	this.label3.TabIndex = 3;
        	this.label3.Text = "WASD to move";
        	// 
        	// move_step
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(681, 501);
        	this.Controls.Add(this.label3);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.pictureBox1);
        	this.Name = "move_step";
        	this.Text = "Form1";
        	this.Load += new System.EventHandler(this.move_step_Load);
        	this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.move_step_KeyDown);
        	this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.move_step_KeyUp);
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}

