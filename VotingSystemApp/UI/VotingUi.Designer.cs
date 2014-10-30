namespace VotingSystemApp
{
    partial class VotingUi
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
            this.selectSymbolOfCandidateComboBox = new System.Windows.Forms.ComboBox();
            this.castButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.votersEmailAddressTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selectSymbolOfCandidateComboBox
            // 
            this.selectSymbolOfCandidateComboBox.FormattingEnabled = true;
            this.selectSymbolOfCandidateComboBox.Location = new System.Drawing.Point(184, 122);
            this.selectSymbolOfCandidateComboBox.Name = "selectSymbolOfCandidateComboBox";
            this.selectSymbolOfCandidateComboBox.Size = new System.Drawing.Size(186, 21);
            this.selectSymbolOfCandidateComboBox.TabIndex = 0;
            // 
            // castButton
            // 
            this.castButton.Location = new System.Drawing.Point(244, 161);
            this.castButton.Name = "castButton";
            this.castButton.Size = new System.Drawing.Size(126, 56);
            this.castButton.TabIndex = 1;
            this.castButton.Text = "Cast";
            this.castButton.UseVisualStyleBackColor = true;
            this.castButton.Click += new System.EventHandler(this.castButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Voter\'s Email Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Symbol of Candidate";
            // 
            // votersEmailAddressTextBox
            // 
            this.votersEmailAddressTextBox.Location = new System.Drawing.Point(150, 52);
            this.votersEmailAddressTextBox.Name = "votersEmailAddressTextBox";
            this.votersEmailAddressTextBox.Size = new System.Drawing.Size(220, 20);
            this.votersEmailAddressTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cast Your Vote";
            // 
            // VotingUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 229);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.votersEmailAddressTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.castButton);
            this.Controls.Add(this.selectSymbolOfCandidateComboBox);
            this.Name = "VotingUi";
            this.Text = "VotingUi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectSymbolOfCandidateComboBox;
        private System.Windows.Forms.Button castButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox votersEmailAddressTextBox;
        private System.Windows.Forms.Label label3;
    }
}