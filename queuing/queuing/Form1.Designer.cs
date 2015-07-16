namespace queuing
{
    partial class Form1
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
            this.PullButton = new System.Windows.Forms.Button();
            this.ShowRemainNumLabel = new System.Windows.Forms.Label();
            this.justLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Counter1NumLabel = new System.Windows.Forms.Label();
            this.Counter2NumLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Counter1Button = new System.Windows.Forms.Button();
            this.Counter2Button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.NowNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PullButton
            // 
            this.PullButton.Location = new System.Drawing.Point(342, 12);
            this.PullButton.Name = "PullButton";
            this.PullButton.Size = new System.Drawing.Size(97, 67);
            this.PullButton.TabIndex = 0;
            this.PullButton.Text = "번호표뽑기";
            this.PullButton.UseVisualStyleBackColor = true;
            this.PullButton.Click += new System.EventHandler(this.PullButton_Click);
            // 
            // ShowRemainNumLabel
            // 
            this.ShowRemainNumLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShowRemainNumLabel.Font = new System.Drawing.Font("Gulim", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ShowRemainNumLabel.ForeColor = System.Drawing.Color.Red;
            this.ShowRemainNumLabel.Location = new System.Drawing.Point(217, 9);
            this.ShowRemainNumLabel.Name = "ShowRemainNumLabel";
            this.ShowRemainNumLabel.Size = new System.Drawing.Size(91, 67);
            this.ShowRemainNumLabel.TabIndex = 1;
            this.ShowRemainNumLabel.Text = "0";
            this.ShowRemainNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ShowRemainNumLabel.Click += new System.EventHandler(this.ShowRemainNumLabel_Click);
            // 
            // justLabel
            // 
            this.justLabel.AutoSize = true;
            this.justLabel.Font = new System.Drawing.Font("Gulim", 20F);
            this.justLabel.Location = new System.Drawing.Point(12, 23);
            this.justLabel.Name = "justLabel";
            this.justLabel.Size = new System.Drawing.Size(218, 34);
            this.justLabel.TabIndex = 2;
            this.justLabel.Text = "대기인원수 : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "제 1청구";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "제 2청구";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "번호 : ";
            // 
            // Counter1NumLabel
            // 
            this.Counter1NumLabel.AutoSize = true;
            this.Counter1NumLabel.Location = new System.Drawing.Point(150, 268);
            this.Counter1NumLabel.Name = "Counter1NumLabel";
            this.Counter1NumLabel.Size = new System.Drawing.Size(15, 15);
            this.Counter1NumLabel.TabIndex = 6;
            this.Counter1NumLabel.Text = "0";
            // 
            // Counter2NumLabel
            // 
            this.Counter2NumLabel.AutoSize = true;
            this.Counter2NumLabel.Location = new System.Drawing.Point(293, 268);
            this.Counter2NumLabel.Name = "Counter2NumLabel";
            this.Counter2NumLabel.Size = new System.Drawing.Size(15, 15);
            this.Counter2NumLabel.TabIndex = 7;
            this.Counter2NumLabel.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "호출 : ";
            // 
            // Counter1Button
            // 
            this.Counter1Button.Location = new System.Drawing.Point(98, 339);
            this.Counter1Button.Name = "Counter1Button";
            this.Counter1Button.Size = new System.Drawing.Size(110, 64);
            this.Counter1Button.TabIndex = 9;
            this.Counter1Button.Text = "Next";
            this.Counter1Button.UseVisualStyleBackColor = true;
            this.Counter1Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Counter2Button
            // 
            this.Counter2Button.Location = new System.Drawing.Point(246, 339);
            this.Counter2Button.Name = "Counter2Button";
            this.Counter2Button.Size = new System.Drawing.Size(110, 64);
            this.Counter2Button.TabIndex = 10;
            this.Counter2Button.Text = "Next";
            this.Counter2Button.UseVisualStyleBackColor = true;
            this.Counter2Button.Click += new System.EventHandler(this.Counter2Button_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gulim", 20F);
            this.label7.Location = new System.Drawing.Point(12, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(274, 34);
            this.label7.TabIndex = 11;
            this.label7.Text = "나의 현재 번호 : ";
            // 
            // NowNum
            // 
            this.NowNum.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NowNum.Font = new System.Drawing.Font("Gulim", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NowNum.ForeColor = System.Drawing.Color.OliveDrab;
            this.NowNum.Location = new System.Drawing.Point(310, 97);
            this.NowNum.Name = "NowNum";
            this.NowNum.Size = new System.Drawing.Size(91, 67);
            this.NowNum.TabIndex = 12;
            this.NowNum.Text = "1";
            this.NowNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 451);
            this.Controls.Add(this.NowNum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Counter2Button);
            this.Controls.Add(this.Counter1Button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Counter2NumLabel);
            this.Controls.Add(this.Counter1NumLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowRemainNumLabel);
            this.Controls.Add(this.justLabel);
            this.Controls.Add(this.PullButton);
            this.Name = "Form1";
            this.Text = "대기표 뽑기";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PullButton;
        private System.Windows.Forms.Label ShowRemainNumLabel;
        private System.Windows.Forms.Label justLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Counter1NumLabel;
        private System.Windows.Forms.Label Counter2NumLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Counter1Button;
        private System.Windows.Forms.Button Counter2Button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label NowNum;
    }
}

