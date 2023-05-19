namespace FilamentManager.userControls
{
    partial class filamentItem
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            filamentPreview = new Panel();
            creatorLabel = new Label();
            filamentTypLabel = new Label();
            amountBox = new TextBox();
            panel1 = new Panel();
            deleteBTN = new Button();
            colorDialog = new ColorDialog();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // filamentPreview
            // 
            filamentPreview.BackColor = Color.FromArgb(0, 0, 192);
            filamentPreview.BorderStyle = BorderStyle.FixedSingle;
            filamentPreview.Location = new Point(3, 3);
            filamentPreview.Name = "filamentPreview";
            filamentPreview.Size = new Size(34, 34);
            filamentPreview.TabIndex = 0;
            // 
            // creatorLabel
            // 
            creatorLabel.AutoSize = true;
            creatorLabel.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            creatorLabel.Location = new Point(40, 8);
            creatorLabel.Name = "creatorLabel";
            creatorLabel.Size = new Size(74, 23);
            creatorLabel.TabIndex = 1;
            creatorLabel.Text = "Generic";
            // 
            // filamentTypLabel
            // 
            filamentTypLabel.AutoSize = true;
            filamentTypLabel.BackColor = SystemColors.ControlDark;
            filamentTypLabel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            filamentTypLabel.Location = new Point(114, 18);
            filamentTypLabel.Name = "filamentTypLabel";
            filamentTypLabel.Size = new Size(37, 19);
            filamentTypLabel.TabIndex = 2;
            filamentTypLabel.Text = "PLA";
            // 
            // amountBox
            // 
            amountBox.Location = new Point(4, 9);
            amountBox.Name = "amountBox";
            amountBox.PlaceholderText = "1KG";
            amountBox.Size = new Size(81, 23);
            amountBox.TabIndex = 3;

            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(deleteBTN);
            panel1.Controls.Add(amountBox);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(956, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 40);
            panel1.TabIndex = 4;
            // 
            // deleteBTN
            // 
            deleteBTN.BackgroundImage = Properties.Resources.trash_can;
            deleteBTN.BackgroundImageLayout = ImageLayout.Center;
            deleteBTN.FlatAppearance.BorderSize = 0;
            deleteBTN.FlatStyle = FlatStyle.Flat;
            deleteBTN.Location = new Point(166, 9);
            deleteBTN.Name = "deleteBTN";
            deleteBTN.Size = new Size(23, 23);
            deleteBTN.TabIndex = 4;
            deleteBTN.UseVisualStyleBackColor = true;
            deleteBTN.Click += deleteBTN_Click;
            // 
            // filamentItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            Controls.Add(panel1);
            Controls.Add(filamentTypLabel);
            Controls.Add(creatorLabel);
            Controls.Add(filamentPreview);
            Name = "filamentItem";
            Size = new Size(1156, 40);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel filamentPreview;
        private Label creatorLabel;
        private Label filamentTypLabel;
        private TextBox amountBox;
        private Panel panel1;
        private Button deleteBTN;
        private ColorDialog colorDialog;
    }
}
