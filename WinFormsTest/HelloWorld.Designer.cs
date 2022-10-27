namespace WinFormsTest
{
    partial class HelloWorld
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
            this.BestButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MainInput = new System.Windows.Forms.TextBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.MainList = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // BestButton
            // 
            this.BestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BestButton.Location = new System.Drawing.Point(400, 450);
            this.BestButton.Name = "BestButton";
            this.BestButton.Size = new System.Drawing.Size(150, 50);
            this.BestButton.TabIndex = 0;
            this.BestButton.Text = "Tap me";
            this.BestButton.UseVisualStyleBackColor = true;
            this.BestButton.Click += new System.EventHandler(this.OnBestButtonClick);
            this.BestButton.MouseEnter += new System.EventHandler(this.OnMainButtonMouseEnter);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(448, 164);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(0, 25);
            this.TitleLabel.TabIndex = 1;
            // 
            // MainInput
            // 
            this.MainInput.Location = new System.Drawing.Point(591, 477);
            this.MainInput.Name = "MainInput";
            this.MainInput.Size = new System.Drawing.Size(128, 23);
            this.MainInput.TabIndex = 2;
            this.MainInput.TextChanged += new System.EventHandler(this.OnMainTextChanged);
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(608, 87);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(48, 19);
            this.checkBox.TabIndex = 3;
            this.checkBox.Text = "True";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // MainList
            // 
            this.MainList.FormattingEnabled = true;
            this.MainList.Location = new System.Drawing.Point(369, 141);
            this.MainList.Name = "MainList";
            this.MainList.Size = new System.Drawing.Size(120, 94);
            this.MainList.TabIndex = 4;
            this.MainList.SelectedIndexChanged += new System.EventHandler(this.MainList_SelectedIndexChanged);
            // 
            // HelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.MainList);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.MainInput);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.BestButton);
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "HelloWorld";
            this.Text = "Hello World";
            this.Shown += new System.EventHandler(this.HelloWorld_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BestButton;
        private Label TitleLabel;
        private TextBox MainInput;
        private CheckBox checkBox;
        private CheckedListBox MainList;
    }
}