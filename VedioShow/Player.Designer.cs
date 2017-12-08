namespace VedioShow
{
    partial class Player
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Player));
            this.btn_Show = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.axPlayer1 = new AxAPlayer3Lib.AxPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Show
            // 
            this.btn_Show.Location = new System.Drawing.Point(12, 308);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(75, 23);
            this.btn_Show.TabIndex = 1;
            this.btn_Show.Text = "播放";
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(112, 308);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 4;
            this.btn_stop.Text = "暂停";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "转码";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(454, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "新播";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // axPlayer1
            // 
            this.axPlayer1.Enabled = true;
            this.axPlayer1.Location = new System.Drawing.Point(12, 12);
            this.axPlayer1.Name = "axPlayer1";
            this.axPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axPlayer1.OcxState")));
            this.axPlayer1.Size = new System.Drawing.Size(517, 277);
            this.axPlayer1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 353);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.axPlayer1);
            this.Controls.Add(this.btn_Show);
            this.Name = "Form1";
            this.Text = "VedioTest";
            ((System.ComponentModel.ISupportInitialize)(this.axPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Show;
        private AxAPlayer3Lib.AxPlayer axPlayer1;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

