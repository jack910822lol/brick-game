namespace H005
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.red = new System.Windows.Forms.PictureBox();
            this.blue = new System.Windows.Forms.PictureBox();
            this.green = new System.Windows.Forms.PictureBox();
            this.Obrick = new System.Windows.Forms.PictureBox();
            this.board = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obrick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.board)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "分數 :";
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(412, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "生命值 : ";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(173, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 111);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // red
            // 
            this.red.Image = global::H005.Properties.Resources.redbrick;
            this.red.Location = new System.Drawing.Point(584, 602);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(43, 27);
            this.red.TabIndex = 8;
            this.red.TabStop = false;
            this.red.Visible = false;
            // 
            // blue
            // 
            this.blue.Image = global::H005.Properties.Resources.bluebrick;
            this.blue.Location = new System.Drawing.Point(652, 602);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(43, 27);
            this.blue.TabIndex = 7;
            this.blue.TabStop = false;
            this.blue.Visible = false;
            // 
            // green
            // 
            this.green.Image = global::H005.Properties.Resources.greenbrick;
            this.green.Location = new System.Drawing.Point(520, 602);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(43, 27);
            this.green.TabIndex = 6;
            this.green.TabStop = false;
            this.green.Visible = false;
            // 
            // Obrick
            // 
            this.Obrick.Image = global::H005.Properties.Resources._0215;
            this.Obrick.Location = new System.Drawing.Point(451, 602);
            this.Obrick.Name = "Obrick";
            this.Obrick.Size = new System.Drawing.Size(43, 27);
            this.Obrick.TabIndex = 3;
            this.Obrick.TabStop = false;
            this.Obrick.Visible = false;
            // 
            // board
            // 
            this.board.Image = global::H005.Properties.Resources.png_0937;
            this.board.Location = new System.Drawing.Point(243, 626);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(98, 19);
            this.board.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.board.TabIndex = 2;
            this.board.TabStop = false;
            // 
            // ball
            // 
            this.ball.Image = global::H005.Properties.Resources.png_0803;
            this.ball.Location = new System.Drawing.Point(273, 587);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(31, 33);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(404, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 120);
            this.button2.TabIndex = 9;
            this.button2.Text = "start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1126, 671);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.red);
            this.Controls.Add(this.blue);
            this.Controls.Add(this.green);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Obrick);
            this.Controls.Add(this.board);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obrick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.board)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox board;
        private System.Windows.Forms.PictureBox Obrick;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox green;
        private System.Windows.Forms.PictureBox blue;
        private System.Windows.Forms.PictureBox red;
        private System.Windows.Forms.Button button2;
    }
}

