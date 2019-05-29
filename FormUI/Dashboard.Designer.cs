using System;

namespace FormUI
{
    partial class Dashboard
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
            this.peopleFoundListBox = new System.Windows.Forms.ListBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.AuthorIdLabel1 = new System.Windows.Forms.Label();
            this.authorIdBox = new System.Windows.Forms.TextBox();
            this.NameLabel2 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.InsertRecordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // peopleFoundListBox
            // 
            this.peopleFoundListBox.FormattingEnabled = true;
            this.peopleFoundListBox.ItemHeight = 31;
            this.peopleFoundListBox.Location = new System.Drawing.Point(49, 142);
            this.peopleFoundListBox.Name = "peopleFoundListBox";
            this.peopleFoundListBox.Size = new System.Drawing.Size(344, 221);
            this.peopleFoundListBox.TabIndex = 0;
            // 
            // nameText
            // 
            this.nameText.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.nameText.Location = new System.Drawing.Point(214, 12);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(218, 38);
            this.nameText.TabIndex = 1;
            this.nameText.Text = " ";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(43, 19);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(86, 31);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(157, 73);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(139, 50);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // AuthorIdLabel1
            // 
            this.AuthorIdLabel1.AutoSize = true;
            this.AuthorIdLabel1.Location = new System.Drawing.Point(15, 386);
            this.AuthorIdLabel1.Name = "AuthorIdLabel1";
            this.AuthorIdLabel1.Size = new System.Drawing.Size(117, 31);
            this.AuthorIdLabel1.TabIndex = 5;
            this.AuthorIdLabel1.Text = "AuthorId";
            // 
            // authorIdBox
            // 
            this.authorIdBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.authorIdBox.Location = new System.Drawing.Point(186, 379);
            this.authorIdBox.Name = "authorIdBox";
            this.authorIdBox.Size = new System.Drawing.Size(218, 38);
            this.authorIdBox.TabIndex = 4;
            this.authorIdBox.Text = " ";
            // 
            // NameLabel2
            // 
            this.NameLabel2.AutoSize = true;
            this.NameLabel2.Location = new System.Drawing.Point(15, 430);
            this.NameLabel2.Name = "NameLabel2";
            this.NameLabel2.Size = new System.Drawing.Size(86, 31);
            this.NameLabel2.TabIndex = 7;
            this.NameLabel2.Text = "Name";
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.nameBox.Location = new System.Drawing.Point(186, 423);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(218, 38);
            this.nameBox.TabIndex = 6;
            this.nameBox.Text = " ";
            // 
            // InsertRecordButton
            // 
            this.InsertRecordButton.Location = new System.Drawing.Point(214, 487);
            this.InsertRecordButton.Name = "InsertRecordButton";
            this.InsertRecordButton.Size = new System.Drawing.Size(139, 50);
            this.InsertRecordButton.TabIndex = 8;
            this.InsertRecordButton.Text = "Search";
            this.InsertRecordButton.UseVisualStyleBackColor = true;
            this.InsertRecordButton.Click += new System.EventHandler(this.InsertRecordButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(600, 566);
            this.Controls.Add(this.InsertRecordButton);
            this.Controls.Add(this.NameLabel2);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.AuthorIdLabel1);
            this.Controls.Add(this.authorIdBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.peopleFoundListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Dashboard";
            this.Text = "Data Access Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox peopleFoundListBox;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button SearchButton;
        private EventHandler LastNameLabel_Click;
        private System.Windows.Forms.Label AuthorIdLabel1;
        private System.Windows.Forms.TextBox authorIdBox;
        private System.Windows.Forms.Label NameLabel2;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button InsertRecordButton;
        private EventHandler label1_Click_2;
        private EventHandler button1_Click;
    }
}

