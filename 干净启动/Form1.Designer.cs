
namespace 干净启动
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
            this.btn_service_disabled = new System.Windows.Forms.Button();
            this.btn_service_recover = new System.Windows.Forms.Button();
            this.txt_log = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_service_disabled
            // 
            this.btn_service_disabled.Location = new System.Drawing.Point(57, 12);
            this.btn_service_disabled.Name = "btn_service_disabled";
            this.btn_service_disabled.Size = new System.Drawing.Size(254, 23);
            this.btn_service_disabled.TabIndex = 0;
            this.btn_service_disabled.Text = "All Service Disabled(if can stop)";
            this.btn_service_disabled.UseVisualStyleBackColor = true;
            this.btn_service_disabled.Click += new System.EventHandler(this.btn_service_disabled_Click);
            // 
            // btn_service_recover
            // 
            this.btn_service_recover.Location = new System.Drawing.Point(57, 57);
            this.btn_service_recover.Name = "btn_service_recover";
            this.btn_service_recover.Size = new System.Drawing.Size(254, 23);
            this.btn_service_recover.TabIndex = 1;
            this.btn_service_recover.Text = "All Service Recover";
            this.btn_service_recover.UseVisualStyleBackColor = true;
            // 
            // txt_log
            // 
            this.txt_log.Location = new System.Drawing.Point(12, 106);
            this.txt_log.Multiline = true;
            this.txt_log.Name = "txt_log";
            this.txt_log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_log.Size = new System.Drawing.Size(340, 309);
            this.txt_log.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 439);
            this.Controls.Add(this.txt_log);
            this.Controls.Add(this.btn_service_recover);
            this.Controls.Add(this.btn_service_disabled);
            this.Name = "Form1";
            this.Text = "clean start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_service_disabled;
        private System.Windows.Forms.Button btn_service_recover;
        private System.Windows.Forms.TextBox txt_log;
    }
}

