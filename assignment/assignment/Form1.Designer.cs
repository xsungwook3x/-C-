
namespace assignment
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.OKbtn = new System.Windows.Forms.Button();
            this.EXITbtn = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OKbtn
            // 
            this.OKbtn.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OKbtn.Location = new System.Drawing.Point(207, 280);
            this.OKbtn.Name = "OKbtn";
            this.OKbtn.Size = new System.Drawing.Size(75, 23);
            this.OKbtn.TabIndex = 0;
            this.OKbtn.Text = "OK";
            this.OKbtn.UseVisualStyleBackColor = true;
            this.OKbtn.Click += new System.EventHandler(this.okBTN_Click);
            // 
            // EXITbtn
            // 
            this.EXITbtn.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EXITbtn.Location = new System.Drawing.Point(493, 280);
            this.EXITbtn.Name = "EXITbtn";
            this.EXITbtn.Size = new System.Drawing.Size(75, 23);
            this.EXITbtn.TabIndex = 1;
            this.EXITbtn.Text = "EXIT";
            this.EXITbtn.UseVisualStyleBackColor = true;
            this.EXITbtn.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Font = new System.Drawing.Font("굴림", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.message.Location = new System.Drawing.Point(196, 141);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(145, 48);
            this.message.TabIndex = 2;
            this.message.Text = "Start!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.message);
            this.Controls.Add(this.EXITbtn);
            this.Controls.Add(this.OKbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OKbtn;
        private System.Windows.Forms.Button EXITbtn;
        private System.Windows.Forms.Label message;
    }
}

