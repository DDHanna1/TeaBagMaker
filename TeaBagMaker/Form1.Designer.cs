﻿namespace TeaBagMaker
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
            this.components = new System.ComponentModel.Container();
            this.teaList = new System.Windows.Forms.ComboBox();
            this.btn = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.LabResult = new System.Windows.Forms.Label();
            this.teaTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // teaList
            // 
            this.teaList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teaList.FormattingEnabled = true;
            this.teaList.Location = new System.Drawing.Point(12, 12);
            this.teaList.Name = "teaList";
            this.teaList.Size = new System.Drawing.Size(317, 20);
            this.teaList.TabIndex = 0;
            this.teaList.SelectedIndexChanged += new System.EventHandler(this.TeaList_SelectedIndexChanged);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(12, 38);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(317, 35);
            this.btn.TabIndex = 1;
            this.btn.Text = "담그기!";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(13, 81);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 12);
            this.result.TabIndex = 2;
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(75, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "2019-05-27   3516 정한나";
            // 
            // LabResult
            // 
            this.LabResult.AutoSize = true;
            this.LabResult.Font = new System.Drawing.Font("굴림", 16F);
            this.LabResult.Location = new System.Drawing.Point(13, 227);
            this.LabResult.Name = "LabResult";
            this.LabResult.Size = new System.Drawing.Size(125, 22);
            this.LabResult.TabIndex = 4;
            this.LabResult.Text = "남은 시간 : ";
            // 
            // teaTime
            // 
            this.teaTime.AutoSize = true;
            this.teaTime.Font = new System.Drawing.Font("굴림", 16F);
            this.teaTime.Location = new System.Drawing.Point(13, 104);
            this.teaTime.Name = "teaTime";
            this.teaTime.Size = new System.Drawing.Size(54, 22);
            this.teaTime.TabIndex = 5;
            this.teaTime.Text = "시간";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 366);
            this.Controls.Add(this.teaTime);
            this.Controls.Add(this.LabResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.teaList);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox teaList;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabResult;
        private System.Windows.Forms.Label teaTime;
    }
}

