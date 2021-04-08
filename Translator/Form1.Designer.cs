
namespace Translator
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
            this.fromText = new System.Windows.Forms.RichTextBox();
            this.toText = new System.Windows.Forms.RichTextBox();
            this.fromLanguage = new System.Windows.Forms.ComboBox();
            this.toLanguage = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fromText
            // 
            this.fromText.EnableAutoDragDrop = true;
            this.fromText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.fromText.Location = new System.Drawing.Point(12, 101);
            this.fromText.Name = "fromText";
            this.fromText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.fromText.Size = new System.Drawing.Size(375, 225);
            this.fromText.TabIndex = 0;
            this.fromText.Text = "";
            // 
            // toText
            // 
            this.toText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.toText.Location = new System.Drawing.Point(413, 101);
            this.toText.Name = "toText";
            this.toText.ReadOnly = true;
            this.toText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.toText.Size = new System.Drawing.Size(375, 225);
            this.toText.TabIndex = 0;
            this.toText.Text = "";
            // 
            // fromLanguage
            // 
            this.fromLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.fromLanguage.FormattingEnabled = true;
            this.fromLanguage.Items.AddRange(new object[] {
            "English",
            "French",
            "Spanish",
            "Arabic",
            "Urdu"});
            this.fromLanguage.Location = new System.Drawing.Point(12, 48);
            this.fromLanguage.Name = "fromLanguage";
            this.fromLanguage.Size = new System.Drawing.Size(202, 33);
            this.fromLanguage.TabIndex = 1;
            this.fromLanguage.Text = "English";
            // 
            // toLanguage
            // 
            this.toLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.toLanguage.FormattingEnabled = true;
            this.toLanguage.Items.AddRange(new object[] {
            "English",
            "French",
            "Spanish",
            "Arabic",
            "Urdu"});
            this.toLanguage.Location = new System.Drawing.Point(586, 48);
            this.toLanguage.Name = "toLanguage";
            this.toLanguage.Size = new System.Drawing.Size(202, 33);
            this.toLanguage.TabIndex = 1;
            this.toLanguage.Text = "English";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button1.Location = new System.Drawing.Point(345, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Translate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toLanguage);
            this.Controls.Add(this.fromLanguage);
            this.Controls.Add(this.toText);
            this.Controls.Add(this.fromText);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Translate";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox fromText;
        private System.Windows.Forms.RichTextBox toText;
        private System.Windows.Forms.ComboBox fromLanguage;
        private System.Windows.Forms.ComboBox toLanguage;
        private System.Windows.Forms.Button button1;
    }
}

