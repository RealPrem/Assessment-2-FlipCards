
namespace Assessment_2_FlipCards
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ChangeFile = new System.Windows.Forms.Button();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.Previous = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.LoadFile = new System.Windows.Forms.Button();
            this.DeckList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ChangeFile
            // 
            this.ChangeFile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeFile.Location = new System.Drawing.Point(262, 12);
            this.ChangeFile.Name = "ChangeFile";
            this.ChangeFile.Size = new System.Drawing.Size(130, 31);
            this.ChangeFile.TabIndex = 0;
            this.ChangeFile.Text = "Select File";
            this.ChangeFile.UseVisualStyleBackColor = true;
            this.ChangeFile.Click += new System.EventHandler(this.ChangeFile_Click);
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Font = new System.Drawing.Font("Calibri", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionLabel.Location = new System.Drawing.Point(332, 60);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(186, 54);
            this.QuestionLabel.TabIndex = 1;
            this.QuestionLabel.Text = "Question";
            // 
            // Previous
            // 
            this.Previous.Location = new System.Drawing.Point(262, 137);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(75, 23);
            this.Previous.TabIndex = 3;
            this.Previous.Text = "Previous";
            this.Previous.UseVisualStyleBackColor = true;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(508, 137);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 4;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // LoadFile
            // 
            this.LoadFile.Font = new System.Drawing.Font("Calibri", 12F);
            this.LoadFile.Location = new System.Drawing.Point(461, 12);
            this.LoadFile.Name = "LoadFile";
            this.LoadFile.Size = new System.Drawing.Size(122, 31);
            this.LoadFile.TabIndex = 5;
            this.LoadFile.Text = "Load";
            this.LoadFile.UseVisualStyleBackColor = true;
            this.LoadFile.Click += new System.EventHandler(this.LoadFile_Click);
            // 
            // DeckList
            // 
            this.DeckList.FormattingEnabled = true;
            this.DeckList.Location = new System.Drawing.Point(12, 12);
            this.DeckList.Name = "DeckList";
            this.DeckList.Size = new System.Drawing.Size(210, 25);
            this.DeckList.TabIndex = 6;
            this.DeckList.SelectedIndexChanged += new System.EventHandler(this.DeckList_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeckList);
            this.Controls.Add(this.LoadFile);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Previous);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.ChangeFile);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button ChangeFile;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Button Previous;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button LoadFile;
        private System.Windows.Forms.ComboBox DeckList;
    }
}

