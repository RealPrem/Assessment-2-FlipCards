
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
            this.Flip = new System.Windows.Forms.Button();
            this.GetRandomCard = new System.Windows.Forms.Button();
            this.ShuffleCard = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.CardPosition = new System.Windows.Forms.Label();
            this.TestMyself = new System.Windows.Forms.Button();
            this.AnswerBox = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.Answers = new System.Windows.Forms.RichTextBox();
            this.ChallengeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ChangeFile
            // 
            this.ChangeFile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeFile.Location = new System.Drawing.Point(366, 12);
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
            this.QuestionLabel.Location = new System.Drawing.Point(450, 63);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(183, 53);
            this.QuestionLabel.TabIndex = 1;
            this.QuestionLabel.Text = "Question";
            // 
            // Previous
            // 
            this.Previous.Font = new System.Drawing.Font("Calibri", 10F);
            this.Previous.ForeColor = System.Drawing.Color.Red;
            this.Previous.Location = new System.Drawing.Point(366, 137);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(94, 32);
            this.Previous.TabIndex = 3;
            this.Previous.Text = "Previous";
            this.Previous.UseVisualStyleBackColor = true;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // Next
            // 
            this.Next.Font = new System.Drawing.Font("Calibri", 10F);
            this.Next.ForeColor = System.Drawing.Color.Green;
            this.Next.Location = new System.Drawing.Point(665, 137);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(90, 32);
            this.Next.TabIndex = 4;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // LoadFile
            // 
            this.LoadFile.Font = new System.Drawing.Font("Calibri", 12F);
            this.LoadFile.Location = new System.Drawing.Point(633, 12);
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
            // Flip
            // 
            this.Flip.Font = new System.Drawing.Font("Calibri", 10F);
            this.Flip.Location = new System.Drawing.Point(514, 137);
            this.Flip.Name = "Flip";
            this.Flip.Size = new System.Drawing.Size(91, 32);
            this.Flip.TabIndex = 7;
            this.Flip.Text = "Flip";
            this.Flip.UseVisualStyleBackColor = true;
            this.Flip.Click += new System.EventHandler(this.Flip_Click);
            // 
            // GetRandomCard
            // 
            this.GetRandomCard.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetRandomCard.Location = new System.Drawing.Point(12, 137);
            this.GetRandomCard.Name = "GetRandomCard";
            this.GetRandomCard.Size = new System.Drawing.Size(119, 32);
            this.GetRandomCard.TabIndex = 8;
            this.GetRandomCard.Text = "Random Card";
            this.GetRandomCard.UseVisualStyleBackColor = true;
            this.GetRandomCard.Click += new System.EventHandler(this.GetRandomCard_Click);
            // 
            // ShuffleCard
            // 
            this.ShuffleCard.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShuffleCard.Location = new System.Drawing.Point(149, 137);
            this.ShuffleCard.Name = "ShuffleCard";
            this.ShuffleCard.Size = new System.Drawing.Size(119, 32);
            this.ShuffleCard.TabIndex = 9;
            this.ShuffleCard.Text = "Shuffle";
            this.ShuffleCard.UseVisualStyleBackColor = true;
            this.ShuffleCard.Click += new System.EventHandler(this.ShuffleCard_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(12, 58);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(210, 23);
            this.ProgressBar.TabIndex = 10;
            // 
            // CardPosition
            // 
            this.CardPosition.AutoSize = true;
            this.CardPosition.Font = new System.Drawing.Font("Calibri", 10F);
            this.CardPosition.Location = new System.Drawing.Point(12, 95);
            this.CardPosition.Name = "CardPosition";
            this.CardPosition.Size = new System.Drawing.Size(48, 21);
            this.CardPosition.TabIndex = 11;
            this.CardPosition.Text = "CARD";
            // 
            // TestMyself
            // 
            this.TestMyself.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestMyself.Location = new System.Drawing.Point(12, 191);
            this.TestMyself.Name = "TestMyself";
            this.TestMyself.Size = new System.Drawing.Size(119, 31);
            this.TestMyself.TabIndex = 12;
            this.TestMyself.Text = "Test Yourself";
            this.TestMyself.UseVisualStyleBackColor = true;
            this.TestMyself.Click += new System.EventHandler(this.TestMyself_Click);
            // 
            // AnswerBox
            // 
            this.AnswerBox.Location = new System.Drawing.Point(514, 137);
            this.AnswerBox.Name = "AnswerBox";
            this.AnswerBox.Size = new System.Drawing.Size(100, 24);
            this.AnswerBox.TabIndex = 13;
            this.AnswerBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AnswerBox_KeyDown);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(94, 241);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(85, 31);
            this.ExitButton.TabIndex = 14;
            this.ExitButton.Text = "Exit ";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Answers
            // 
            this.Answers.Location = new System.Drawing.Point(442, 191);
            this.Answers.Name = "Answers";
            this.Answers.Size = new System.Drawing.Size(247, 127);
            this.Answers.TabIndex = 16;
            this.Answers.Text = "";
            // 
            // ChallengeButton
            // 
            this.ChallengeButton.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChallengeButton.Location = new System.Drawing.Point(149, 191);
            this.ChallengeButton.Name = "ChallengeButton";
            this.ChallengeButton.Size = new System.Drawing.Size(119, 31);
            this.ChallengeButton.TabIndex = 17;
            this.ChallengeButton.Text = "Challenge Mode";
            this.ChallengeButton.UseVisualStyleBackColor = true;
            this.ChallengeButton.Click += new System.EventHandler(this.ChallengeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(544, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 46);
            this.label1.TabIndex = 18;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChallengeButton);
            this.Controls.Add(this.Answers);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AnswerBox);
            this.Controls.Add(this.TestMyself);
            this.Controls.Add(this.CardPosition);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.ShuffleCard);
            this.Controls.Add(this.GetRandomCard);
            this.Controls.Add(this.Flip);
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
        private System.Windows.Forms.Button Flip;
        private System.Windows.Forms.Button GetRandomCard;
        private System.Windows.Forms.Button ShuffleCard;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label CardPosition;
        private System.Windows.Forms.Button TestMyself;
        private System.Windows.Forms.TextBox AnswerBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.RichTextBox Answers;
        private System.Windows.Forms.Button ChallengeButton;
        private System.Windows.Forms.Label label1;
    }
}

