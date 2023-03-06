
namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.香蕉 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // 香蕉
            // 
            this.香蕉.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.香蕉.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.香蕉.ForeColor = System.Drawing.Color.Honeydew;
            this.香蕉.Image = ((System.Drawing.Image)(resources.GetObject("香蕉.Image")));
            this.香蕉.Location = new System.Drawing.Point(12, 9);
            this.香蕉.Name = "香蕉";
            this.香蕉.Size = new System.Drawing.Size(1214, 650);
            this.香蕉.TabIndex = 1;
            this.香蕉.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(803, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 81);
            this.label1.TabIndex = 2;
            this.label1.Text = "帥章魚";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 653);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.香蕉);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label 香蕉;
        private System.Windows.Forms.Label label1;
    }
}

