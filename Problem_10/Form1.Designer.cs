namespace Problem_10
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.symbol = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.提交 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lad = new System.Windows.Forms.Label();
            this.goal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // symbol
            // 
            this.symbol.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.symbol.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.symbol.Location = new System.Drawing.Point(348, 58);
            this.symbol.Name = "symbol";
            this.symbol.Size = new System.Drawing.Size(65, 65);
            this.symbol.TabIndex = 0;
            this.symbol.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(242, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 75);
            this.label2.TabIndex = 1;
            this.label2.Text = "00";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(419, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 75);
            this.label3.TabIndex = 2;
            this.label3.Text = "00";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(328, 220);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "答题框";
            this.textBox1.UseWaitCursor = true;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(328, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 100);
            this.button2.TabIndex = 3;
            this.button2.Text = "开始  答题";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // 提交
            // 
            this.提交.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.提交.Location = new System.Drawing.Point(459, 220);
            this.提交.Name = "提交";
            this.提交.Size = new System.Drawing.Size(75, 23);
            this.提交.TabIndex = 5;
            this.提交.Text = "提交";
            this.提交.UseVisualStyleBackColor = true;
            this.提交.Click += new System.EventHandler(this.提交_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lad
            // 
            this.lad.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lad.ForeColor = System.Drawing.Color.Red;
            this.lad.Location = new System.Drawing.Point(53, 322);
            this.lad.Name = "lad";
            this.lad.Size = new System.Drawing.Size(100, 100);
            this.lad.TabIndex = 6;
            this.lad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lad.Click += new System.EventHandler(this.label1_Click);
            // 
            // goal
            // 
            this.goal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.goal.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.goal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.goal.Location = new System.Drawing.Point(633, 37);
            this.goal.Name = "goal";
            this.goal.Size = new System.Drawing.Size(120, 100);
            this.goal.TabIndex = 7;
            this.goal.Text = "0";
            this.goal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.goal.Click += new System.EventHandler(this.goal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.goal);
            this.Controls.Add(this.lad);
            this.Controls.Add(this.提交);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.symbol);
            this.Name = "Form1";
            this.Text = "答题器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label symbol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button 提交;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lad;
        private System.Windows.Forms.Label goal;
    }
}

