namespace TestGUI
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
            this.textBoxElementId = new System.Windows.Forms.TextBox();
            this.btnNode = new System.Windows.Forms.Button();
            this.btnWay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxElementId
            // 
            this.textBoxElementId.Location = new System.Drawing.Point(13, 13);
            this.textBoxElementId.Name = "textBoxElementId";
            this.textBoxElementId.Size = new System.Drawing.Size(100, 20);
            this.textBoxElementId.TabIndex = 0;
            // 
            // btnNode
            // 
            this.btnNode.Location = new System.Drawing.Point(120, 13);
            this.btnNode.Name = "btnNode";
            this.btnNode.Size = new System.Drawing.Size(76, 23);
            this.btnNode.TabIndex = 1;
            this.btnNode.Text = "Node";
            this.btnNode.UseVisualStyleBackColor = true;
            this.btnNode.Click += new System.EventHandler(this.btnId_Click);
            // 
            // btnWay
            // 
            this.btnWay.Location = new System.Drawing.Point(203, 13);
            this.btnWay.Name = "btnWay";
            this.btnWay.Size = new System.Drawing.Size(75, 23);
            this.btnWay.TabIndex = 2;
            this.btnWay.Text = "Way";
            this.btnWay.UseVisualStyleBackColor = true;
            this.btnWay.Click += new System.EventHandler(this.btnWay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 45);
            this.Controls.Add(this.btnWay);
            this.Controls.Add(this.btnNode);
            this.Controls.Add(this.textBoxElementId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxElementId;
        private System.Windows.Forms.Button btnNode;
        private System.Windows.Forms.Button btnWay;
    }
}

