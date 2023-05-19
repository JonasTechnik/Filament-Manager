namespace FilamentManager.dialogForms
{
    partial class enterDialog
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
            oldLabel = new Label();
            arrow = new PictureBox();
            inputBox = new TextBox();
            cancelBTN = new Button();
            submitBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)arrow).BeginInit();
            SuspendLayout();
            // 
            // oldLabel
            // 
            oldLabel.AutoSize = true;
            oldLabel.Font = new Font("Bahnschrift", 18F, FontStyle.Bold, GraphicsUnit.Point);
            oldLabel.Location = new Point(12, 78);
            oldLabel.Name = "oldLabel";
            oldLabel.Size = new Size(58, 29);
            oldLabel.TabIndex = 0;
            oldLabel.Text = "OLD";
            // 
            // arrow
            // 
            arrow.BackgroundImage = Properties.Resources.arrow;
            arrow.BackgroundImageLayout = ImageLayout.Center;
            arrow.Location = new Point(61, 86);
            arrow.Name = "arrow";
            arrow.Size = new Size(40, 15);
            arrow.TabIndex = 1;
            arrow.TabStop = false;
            // 
            // inputBox
            // 
            inputBox.Location = new Point(106, 82);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(308, 23);
            inputBox.TabIndex = 2;
            // 
            // cancelBTN
            // 
            cancelBTN.Location = new Point(12, 163);
            cancelBTN.Name = "cancelBTN";
            cancelBTN.Size = new Size(194, 29);
            cancelBTN.TabIndex = 3;
            cancelBTN.Text = "Cancel";
            cancelBTN.UseVisualStyleBackColor = true;
            cancelBTN.Click += cancelBTN_Click;
            // 
            // submitBTN
            // 
            submitBTN.Location = new Point(212, 163);
            submitBTN.Name = "submitBTN";
            submitBTN.Size = new Size(202, 29);
            submitBTN.TabIndex = 4;
            submitBTN.Text = "Ok";
            submitBTN.UseVisualStyleBackColor = true;
            submitBTN.Click += submitBTN_Click;
            // 
            // enterDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 197);
            Controls.Add(submitBTN);
            Controls.Add(cancelBTN);
            Controls.Add(inputBox);
            Controls.Add(arrow);
            Controls.Add(oldLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "enterDialog";
            Text = "enterDialog";
            ((System.ComponentModel.ISupportInitialize)arrow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label oldLabel;
        private PictureBox arrow;
        private TextBox inputBox;
        private Button cancelBTN;
        private Button submitBTN;
    }
}