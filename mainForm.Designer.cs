namespace FilamentManager
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            subPanel = new Panel();
            addBTN = new Button();
            searchBox = new TextBox();
            display = new FlowLayoutPanel();
            panel1 = new Panel();
            searchBTN = new Button();
            subPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // subPanel
            // 
            subPanel.BackColor = Color.White;
            subPanel.BorderStyle = BorderStyle.FixedSingle;
            subPanel.Controls.Add(addBTN);
            subPanel.Dock = DockStyle.Bottom;
            subPanel.Location = new Point(0, 546);
            subPanel.Name = "subPanel";
            subPanel.Size = new Size(1140, 37);
            subPanel.TabIndex = 0;
            // 
            // addBTN
            // 
            addBTN.Location = new Point(528, 3);
            addBTN.Name = "addBTN";
            addBTN.Size = new Size(75, 29);
            addBTN.TabIndex = 0;
            addBTN.Text = "+";
            addBTN.UseVisualStyleBackColor = true;
            addBTN.Click += addBTN_Click;
            // 
            // searchBox
            // 
            searchBox.BorderStyle = BorderStyle.FixedSingle;
            searchBox.Location = new Point(67, 12);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(1048, 23);
            searchBox.TabIndex = 1;
            searchBox.KeyDown += searchBox_KeyDown;
            // 
            // display
            // 
            display.BackColor = Color.FromArgb(224, 224, 224);
            display.Dock = DockStyle.Fill;
            display.Location = new Point(0, 0);
            display.Name = "display";
            display.Size = new Size(1140, 546);
            display.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(searchBTN);
            panel1.Controls.Add(searchBox);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1140, 49);
            panel1.TabIndex = 4;
            // 
            // searchBTN
            // 
            searchBTN.BackColor = SystemColors.WindowFrame;
            searchBTN.BackgroundImage = Properties.Resources.magnifier;
            searchBTN.BackgroundImageLayout = ImageLayout.Center;
            searchBTN.FlatAppearance.BorderSize = 0;
            searchBTN.FlatStyle = FlatStyle.Flat;
            searchBTN.Location = new Point(1114, 12);
            searchBTN.Name = "searchBTN";
            searchBTN.Size = new Size(23, 23);
            searchBTN.TabIndex = 5;
            searchBTN.UseVisualStyleBackColor = false;
            searchBTN.Click += searchBTN_Click;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 583);
            Controls.Add(panel1);
            Controls.Add(display);
            Controls.Add(subPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "mainForm";
            Text = "FSM";
            ResizeEnd += mainForm_ResizeEnd;
            subPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel subPanel;
        private TextBox searchBox;
        private FlowLayoutPanel display;
        private Panel panel1;
        private Button searchBTN;
        private Button addBTN;
    }
}