
namespace TruckersMPinfo
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
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.info = new System.Windows.Forms.Button();
            this.openFileDialog_softalk = new System.Windows.Forms.OpenFileDialog();
            this.filePath = new System.Windows.Forms.TextBox();
            this.openbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.game_text = new System.Windows.Forms.TextBox();
            this.server_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(12, 12);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(75, 23);
            this.info.TabIndex = 0;
            this.info.Text = "交通情報";
            this.info.UseVisualStyleBackColor = true;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // openFileDialog_softalk
            // 
            this.openFileDialog_softalk.FileName = "openFileDialog_softalk";
            // 
            // filePath
            // 
            this.filePath.Location = new System.Drawing.Point(12, 41);
            this.filePath.Name = "filePath";
            this.filePath.ReadOnly = true;
            this.filePath.Size = new System.Drawing.Size(224, 19);
            this.filePath.TabIndex = 1;
            // 
            // openbutton
            // 
            this.openbutton.Location = new System.Drawing.Point(12, 66);
            this.openbutton.Name = "openbutton";
            this.openbutton.Size = new System.Drawing.Size(125, 23);
            this.openbutton.TabIndex = 2;
            this.openbutton.Text = "softalk.exeを選択";
            this.openbutton.UseVisualStyleBackColor = true;
            this.openbutton.Click += new System.EventHandler(this.openbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "game";
            // 
            // game_text
            // 
            this.game_text.Location = new System.Drawing.Point(12, 125);
            this.game_text.Name = "game_text";
            this.game_text.Size = new System.Drawing.Size(100, 19);
            this.game_text.TabIndex = 4;
            // 
            // server_text
            // 
            this.server_text.Location = new System.Drawing.Point(136, 125);
            this.server_text.Name = "server_text";
            this.server_text.Size = new System.Drawing.Size(100, 19);
            this.server_text.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "server";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 161);
            this.Controls.Add(this.server_text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.game_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openbutton);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.info);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button info;
        private System.Windows.Forms.OpenFileDialog openFileDialog_softalk;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.Button openbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox game_text;
        private System.Windows.Forms.TextBox server_text;
        private System.Windows.Forms.Label label2;
    }
}

