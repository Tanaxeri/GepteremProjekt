namespace GepteremProjekt
{
    partial class GepteremProjekt
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
            this.TeremPanel = new System.Windows.Forms.Panel();
            this.MentesGomb = new System.Windows.Forms.Button();
            this.JobbGomb = new System.Windows.Forms.Button();
            this.BalGomb = new System.Windows.Forms.Button();
            this.TeremNevSzemely = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TeremNevSzemely)).BeginInit();
            this.SuspendLayout();
            // 
            // TeremPanel
            // 
            this.TeremPanel.Location = new System.Drawing.Point(481, 19);
            this.TeremPanel.Name = "TeremPanel";
            this.TeremPanel.Size = new System.Drawing.Size(691, 299);
            this.TeremPanel.TabIndex = 4;
            // 
            // MentesGomb
            // 
            this.MentesGomb.BackgroundImage = global::GepteremProjekt.Properties.Resources.ment;
            this.MentesGomb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MentesGomb.Location = new System.Drawing.Point(146, 306);
            this.MentesGomb.Name = "MentesGomb";
            this.MentesGomb.Size = new System.Drawing.Size(130, 74);
            this.MentesGomb.TabIndex = 3;
            this.MentesGomb.UseVisualStyleBackColor = true;
            this.MentesGomb.Click += new System.EventHandler(this.MentesGomb_Click);
            // 
            // JobbGomb
            // 
            this.JobbGomb.BackgroundImage = global::GepteremProjekt.Properties.Resources.jobb;
            this.JobbGomb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.JobbGomb.Location = new System.Drawing.Point(332, 99);
            this.JobbGomb.Name = "JobbGomb";
            this.JobbGomb.Size = new System.Drawing.Size(109, 59);
            this.JobbGomb.TabIndex = 2;
            this.JobbGomb.UseVisualStyleBackColor = true;
            this.JobbGomb.Click += new System.EventHandler(this.JobbGomb_Click);
            // 
            // BalGomb
            // 
            this.BalGomb.BackgroundImage = global::GepteremProjekt.Properties.Resources.bal;
            this.BalGomb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BalGomb.Location = new System.Drawing.Point(12, 99);
            this.BalGomb.Name = "BalGomb";
            this.BalGomb.Size = new System.Drawing.Size(112, 59);
            this.BalGomb.TabIndex = 1;
            this.BalGomb.UseVisualStyleBackColor = true;
            this.BalGomb.Click += new System.EventHandler(this.BalGomb_Click);
            // 
            // TeremNevSzemely
            // 
            this.TeremNevSzemely.Location = new System.Drawing.Point(136, 43);
            this.TeremNevSzemely.Name = "TeremNevSzemely";
            this.TeremNevSzemely.Size = new System.Drawing.Size(166, 214);
            this.TeremNevSzemely.TabIndex = 0;
            this.TeremNevSzemely.TabStop = false;
            // 
            // GepteremProjekt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.TeremPanel);
            this.Controls.Add(this.MentesGomb);
            this.Controls.Add(this.JobbGomb);
            this.Controls.Add(this.BalGomb);
            this.Controls.Add(this.TeremNevSzemely);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GepteremProjekt";
            this.Text = "GepteremProjekt";
            this.Load += new System.EventHandler(this.GepteremProjekt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TeremNevSzemely)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox TeremNevSzemely;
        private System.Windows.Forms.Button BalGomb;
        private System.Windows.Forms.Button JobbGomb;
        private System.Windows.Forms.Button MentesGomb;
        private System.Windows.Forms.Panel TeremPanel;
    }
}

