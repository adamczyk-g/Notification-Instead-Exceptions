
namespace RefactoringExceptions.WinForms.View
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bookSeats = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numberOfSeats = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateOfThePerformance = new System.Windows.Forms.DateTimePicker();
            this.messages = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bookSeats
            // 
            this.bookSeats.Location = new System.Drawing.Point(113, 145);
            this.bookSeats.Name = "bookSeats";
            this.bookSeats.Size = new System.Drawing.Size(134, 23);
            this.bookSeats.TabIndex = 0;
            this.bookSeats.Text = "Book seats";
            this.bookSeats.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of seats:";
            // 
            // numberOfSeats
            // 
            this.numberOfSeats.Location = new System.Drawing.Point(113, 99);
            this.numberOfSeats.Name = "numberOfSeats";
            this.numberOfSeats.Size = new System.Drawing.Size(134, 23);
            this.numberOfSeats.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Booking date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Messages:";
            // 
            // dateOfThePerformance
            // 
            this.dateOfThePerformance.CustomFormat = "";
            this.dateOfThePerformance.Location = new System.Drawing.Point(113, 60);
            this.dateOfThePerformance.Name = "dateOfThePerformance";
            this.dateOfThePerformance.Size = new System.Drawing.Size(134, 23);
            this.dateOfThePerformance.TabIndex = 7;
            // 
            // messages
            // 
            this.messages.Location = new System.Drawing.Point(6, 196);
            this.messages.Multiline = true;
            this.messages.Name = "messages";
            this.messages.Size = new System.Drawing.Size(456, 113);
            this.messages.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(350, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Please give the date of the performance and the number of seats:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 321);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.messages);
            this.Controls.Add(this.dateOfThePerformance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numberOfSeats);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookSeats);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bookSeats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberOfSeats;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateOfThePerformance;
        private System.Windows.Forms.TextBox messages;
        private System.Windows.Forms.Label label4;
    }
}

