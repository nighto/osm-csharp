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
            this.btnGo = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.outputAsLabel = new System.Windows.Forms.Label();
            this.nodeRadioButton = new System.Windows.Forms.RadioButton();
            this.wayRadioButton = new System.Windows.Forms.RadioButton();
            this.relationRadioButton = new System.Windows.Forms.RadioButton();
            this.textRadioButton = new System.Windows.Forms.RadioButton();
            this.XMLRadioButton = new System.Windows.Forms.RadioButton();
            this.typePanel = new System.Windows.Forms.Panel();
            this.outputPanel = new System.Windows.Forms.Panel();
            this.typePanel.SuspendLayout();
            this.outputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxElementId
            // 
            this.textBoxElementId.Location = new System.Drawing.Point(74, 6);
            this.textBoxElementId.Name = "textBoxElementId";
            this.textBoxElementId.Size = new System.Drawing.Size(100, 20);
            this.textBoxElementId.TabIndex = 0;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(184, 63);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(76, 23);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(47, 9);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 13);
            this.idLabel.TabIndex = 3;
            this.idLabel.Text = "ID:";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(34, 37);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(34, 13);
            this.typeLabel.TabIndex = 4;
            this.typeLabel.Text = "Type:";
            // 
            // outputAsLabel
            // 
            this.outputAsLabel.AutoSize = true;
            this.outputAsLabel.Location = new System.Drawing.Point(12, 68);
            this.outputAsLabel.Name = "outputAsLabel";
            this.outputAsLabel.Size = new System.Drawing.Size(56, 13);
            this.outputAsLabel.TabIndex = 5;
            this.outputAsLabel.Text = "Output as:";
            // 
            // nodeRadioButton
            // 
            this.nodeRadioButton.AutoSize = true;
            this.nodeRadioButton.Checked = true;
            this.nodeRadioButton.Location = new System.Drawing.Point(3, 3);
            this.nodeRadioButton.Name = "nodeRadioButton";
            this.nodeRadioButton.Size = new System.Drawing.Size(51, 17);
            this.nodeRadioButton.TabIndex = 6;
            this.nodeRadioButton.TabStop = true;
            this.nodeRadioButton.Text = "Node";
            this.nodeRadioButton.UseVisualStyleBackColor = true;
            // 
            // wayRadioButton
            // 
            this.wayRadioButton.AutoSize = true;
            this.wayRadioButton.Location = new System.Drawing.Point(60, 3);
            this.wayRadioButton.Name = "wayRadioButton";
            this.wayRadioButton.Size = new System.Drawing.Size(47, 17);
            this.wayRadioButton.TabIndex = 7;
            this.wayRadioButton.Text = "Way";
            this.wayRadioButton.UseVisualStyleBackColor = true;
            // 
            // relationRadioButton
            // 
            this.relationRadioButton.AutoSize = true;
            this.relationRadioButton.Location = new System.Drawing.Point(113, 3);
            this.relationRadioButton.Name = "relationRadioButton";
            this.relationRadioButton.Size = new System.Drawing.Size(64, 17);
            this.relationRadioButton.TabIndex = 8;
            this.relationRadioButton.Text = "Relation";
            this.relationRadioButton.UseVisualStyleBackColor = true;
            // 
            // textRadioButton
            // 
            this.textRadioButton.AutoSize = true;
            this.textRadioButton.Checked = true;
            this.textRadioButton.Location = new System.Drawing.Point(3, 3);
            this.textRadioButton.Name = "textRadioButton";
            this.textRadioButton.Size = new System.Drawing.Size(46, 17);
            this.textRadioButton.TabIndex = 9;
            this.textRadioButton.TabStop = true;
            this.textRadioButton.Text = "Text";
            this.textRadioButton.UseVisualStyleBackColor = true;
            // 
            // XMLRadioButton
            // 
            this.XMLRadioButton.AutoSize = true;
            this.XMLRadioButton.Location = new System.Drawing.Point(55, 3);
            this.XMLRadioButton.Name = "XMLRadioButton";
            this.XMLRadioButton.Size = new System.Drawing.Size(47, 17);
            this.XMLRadioButton.TabIndex = 10;
            this.XMLRadioButton.TabStop = true;
            this.XMLRadioButton.Text = "XML";
            this.XMLRadioButton.UseVisualStyleBackColor = true;
            // 
            // typePanel
            // 
            this.typePanel.Controls.Add(this.nodeRadioButton);
            this.typePanel.Controls.Add(this.wayRadioButton);
            this.typePanel.Controls.Add(this.relationRadioButton);
            this.typePanel.Location = new System.Drawing.Point(74, 32);
            this.typePanel.Name = "typePanel";
            this.typePanel.Size = new System.Drawing.Size(186, 25);
            this.typePanel.TabIndex = 11;
            // 
            // outputPanel
            // 
            this.outputPanel.Controls.Add(this.textRadioButton);
            this.outputPanel.Controls.Add(this.XMLRadioButton);
            this.outputPanel.Location = new System.Drawing.Point(74, 63);
            this.outputPanel.Name = "outputPanel";
            this.outputPanel.Size = new System.Drawing.Size(108, 25);
            this.outputPanel.TabIndex = 12;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnGo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 89);
            this.Controls.Add(this.outputPanel);
            this.Controls.Add(this.typePanel);
            this.Controls.Add(this.outputAsLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.textBoxElementId);
            this.Name = "Form1";
            this.Text = "osm-csharp Test GUI";
            this.typePanel.ResumeLayout(false);
            this.typePanel.PerformLayout();
            this.outputPanel.ResumeLayout(false);
            this.outputPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxElementId;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label outputAsLabel;
        private System.Windows.Forms.RadioButton nodeRadioButton;
        private System.Windows.Forms.RadioButton wayRadioButton;
        private System.Windows.Forms.RadioButton relationRadioButton;
        private System.Windows.Forms.RadioButton textRadioButton;
        private System.Windows.Forms.RadioButton XMLRadioButton;
        private System.Windows.Forms.Panel typePanel;
        private System.Windows.Forms.Panel outputPanel;
    }
}

