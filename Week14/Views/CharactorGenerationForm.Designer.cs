namespace Week14.Views
{
    partial class CharactorGenerationForm
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
            this.MainTapControl = new System.Windows.Forms.TabControl();
            this.IdentityPage = new System.Windows.Forms.TabPage();
            this.AbilityPage = new System.Windows.Forms.TabPage();
            this.NextButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SkillPage = new System.Windows.Forms.TabPage();
            this.CharactorSheet = new System.Windows.Forms.TabPage();
            this.MainTapControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTapControl
            // 
            this.MainTapControl.Controls.Add(this.IdentityPage);
            this.MainTapControl.Controls.Add(this.AbilityPage);
            this.MainTapControl.Controls.Add(this.SkillPage);
            this.MainTapControl.Controls.Add(this.CharactorSheet);
            this.MainTapControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainTapControl.Location = new System.Drawing.Point(0, 0);
            this.MainTapControl.Name = "MainTapControl";
            this.MainTapControl.SelectedIndex = 0;
            this.MainTapControl.Size = new System.Drawing.Size(784, 447);
            this.MainTapControl.TabIndex = 0;
            // 
            // IdentityPage
            // 
            this.IdentityPage.Location = new System.Drawing.Point(4, 33);
            this.IdentityPage.Name = "IdentityPage";
            this.IdentityPage.Padding = new System.Windows.Forms.Padding(3);
            this.IdentityPage.Size = new System.Drawing.Size(776, 410);
            this.IdentityPage.TabIndex = 0;
            this.IdentityPage.Text = "Identity";
            this.IdentityPage.UseVisualStyleBackColor = true;
            // 
            // AbilityPage
            // 
            this.AbilityPage.Location = new System.Drawing.Point(4, 33);
            this.AbilityPage.Name = "AbilityPage";
            this.AbilityPage.Padding = new System.Windows.Forms.Padding(3);
            this.AbilityPage.Size = new System.Drawing.Size(776, 410);
            this.AbilityPage.TabIndex = 1;
            this.AbilityPage.Text = "Ability";
            this.AbilityPage.UseVisualStyleBackColor = true;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(640, 489);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(140, 60);
            this.NextButton.TabIndex = 1;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(4, 489);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(140, 60);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SkillPage
            // 
            this.SkillPage.Location = new System.Drawing.Point(4, 33);
            this.SkillPage.Name = "SkillPage";
            this.SkillPage.Size = new System.Drawing.Size(776, 410);
            this.SkillPage.TabIndex = 2;
            this.SkillPage.Text = "Skill";
            this.SkillPage.UseVisualStyleBackColor = true;
            // 
            // CharactorSheet
            // 
            this.CharactorSheet.Location = new System.Drawing.Point(4, 33);
            this.CharactorSheet.Name = "CharactorSheet";
            this.CharactorSheet.Size = new System.Drawing.Size(776, 410);
            this.CharactorSheet.TabIndex = 3;
            this.CharactorSheet.Text = "Charactor Sheet";
            this.CharactorSheet.UseVisualStyleBackColor = true;
            // 
            // CharactorGenerationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.MainTapControl);
            this.Name = "CharactorGenerationForm";
            this.Text = "Charactor Generator";
            this.MainTapControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTapControl;
        private System.Windows.Forms.TabPage IdentityPage;
        private System.Windows.Forms.TabPage AbilityPage;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TabPage SkillPage;
        private System.Windows.Forms.TabPage CharactorSheet;
    }
}
