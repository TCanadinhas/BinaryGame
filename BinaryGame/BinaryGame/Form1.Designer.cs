namespace BinaryGame
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
            this.howButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.easterEgg = new System.Windows.Forms.Label();
            this.menuTittle = new System.Windows.Forms.Label();
            this.instructionsTittle = new System.Windows.Forms.Label();
            this.instructionsText = new System.Windows.Forms.Button();
            this.binaryBox1 = new System.Windows.Forms.TextBox();
            this.operationLabel = new System.Windows.Forms.Label();
            this.digit1Button = new System.Windows.Forms.Button();
            this.digit0Button = new System.Windows.Forms.Button();
            this.binaryBox2 = new System.Windows.Forms.TextBox();
            this.doButton = new System.Windows.Forms.Button();
            this.decimalLabel = new System.Windows.Forms.Label();
            this.decimalTextBox = new System.Windows.Forms.TextBox();
            this.backToMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // howButton
            // 
            this.howButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.howButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howButton.Location = new System.Drawing.Point(98, 232);
            this.howButton.Name = "howButton";
            this.howButton.Size = new System.Drawing.Size(129, 34);
            this.howButton.TabIndex = 1;
            this.howButton.Text = "How to play";
            this.howButton.UseVisualStyleBackColor = true;
            this.howButton.Click += new System.EventHandler(this.goToInsturctions);
            // 
            // startButton
            // 
            this.startButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startButton.AutoSize = true;
            this.startButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(98, 278);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(129, 34);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.beginGame);
            // 
            // easterEgg
            // 
            this.easterEgg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.easterEgg.AutoSize = true;
            this.easterEgg.Enabled = false;
            this.easterEgg.Location = new System.Drawing.Point(172, 411);
            this.easterEgg.Name = "easterEgg";
            this.easterEgg.Size = new System.Drawing.Size(145, 13);
            this.easterEgg.TabIndex = 3;
            this.easterEgg.Text = "A game by Talita Canadinhas";
            // 
            // menuTittle
            // 
            this.menuTittle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuTittle.AutoSize = true;
            this.menuTittle.Font = new System.Drawing.Font("Consolas", 22F);
            this.menuTittle.Location = new System.Drawing.Point(35, 140);
            this.menuTittle.Name = "menuTittle";
            this.menuTittle.Size = new System.Drawing.Size(255, 36);
            this.menuTittle.TabIndex = 4;
            this.menuTittle.Text = "The Binary Game";
            // 
            // instructionsTittle
            // 
            this.instructionsTittle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.instructionsTittle.AutoSize = true;
            this.instructionsTittle.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsTittle.Location = new System.Drawing.Point(97, 105);
            this.instructionsTittle.Name = "instructionsTittle";
            this.instructionsTittle.Size = new System.Drawing.Size(130, 22);
            this.instructionsTittle.TabIndex = 5;
            this.instructionsTittle.Text = "Instructions";
            this.instructionsTittle.Visible = false;
            // 
            // instructionsText
            // 
            this.instructionsText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.instructionsText.Enabled = false;
            this.instructionsText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsText.Location = new System.Drawing.Point(38, 139);
            this.instructionsText.Name = "instructionsText";
            this.instructionsText.Size = new System.Drawing.Size(249, 127);
            this.instructionsText.TabIndex = 6;
            this.instructionsText.Text = "Use a binary number of at most 4 digits in the operation provided to make the hig" +
    "hest score in time.";
            this.instructionsText.UseVisualStyleBackColor = true;
            this.instructionsText.Visible = false;
            // 
            // binaryBox1
            // 
            this.binaryBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.binaryBox1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binaryBox1.Location = new System.Drawing.Point(80, 70);
            this.binaryBox1.Name = "binaryBox1";
            this.binaryBox1.ReadOnly = true;
            this.binaryBox1.Size = new System.Drawing.Size(171, 32);
            this.binaryBox1.TabIndex = 7;
            this.binaryBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.binaryBox1.Visible = false;
            // 
            // operationLabel
            // 
            this.operationLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.operationLabel.AutoSize = true;
            this.operationLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operationLabel.Location = new System.Drawing.Point(92, 113);
            this.operationLabel.Name = "operationLabel";
            this.operationLabel.Size = new System.Drawing.Size(150, 32);
            this.operationLabel.TabIndex = 8;
            this.operationLabel.Text = "operation";
            this.operationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.operationLabel.Visible = false;
            // 
            // digit1Button
            // 
            this.digit1Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.digit1Button.Font = new System.Drawing.Font("OCR-A BT", 14F);
            this.digit1Button.Location = new System.Drawing.Point(191, 220);
            this.digit1Button.Name = "digit1Button";
            this.digit1Button.Size = new System.Drawing.Size(75, 77);
            this.digit1Button.TabIndex = 20;
            this.digit1Button.Text = "1";
            this.digit1Button.UseVisualStyleBackColor = true;
            this.digit1Button.Visible = false;
            this.digit1Button.Click += new System.EventHandler(this.typeIn);
            // 
            // digit0Button
            // 
            this.digit0Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.digit0Button.Font = new System.Drawing.Font("OCR-A BT", 14F);
            this.digit0Button.Location = new System.Drawing.Point(57, 220);
            this.digit0Button.Name = "digit0Button";
            this.digit0Button.Size = new System.Drawing.Size(75, 77);
            this.digit0Button.TabIndex = 19;
            this.digit0Button.Text = "0";
            this.digit0Button.UseVisualStyleBackColor = true;
            this.digit0Button.Visible = false;
            this.digit0Button.Click += new System.EventHandler(this.typeIn);
            // 
            // binaryBox2
            // 
            this.binaryBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.binaryBox2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binaryBox2.Location = new System.Drawing.Point(101, 161);
            this.binaryBox2.MaxLength = 4;
            this.binaryBox2.Name = "binaryBox2";
            this.binaryBox2.ReadOnly = true;
            this.binaryBox2.Size = new System.Drawing.Size(120, 32);
            this.binaryBox2.TabIndex = 21;
            this.binaryBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.binaryBox2.Visible = false;
            // 
            // doButton
            // 
            this.doButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.doButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doButton.Location = new System.Drawing.Point(98, 306);
            this.doButton.Name = "doButton";
            this.doButton.Size = new System.Drawing.Size(129, 34);
            this.doButton.TabIndex = 22;
            this.doButton.Text = "Do it";
            this.doButton.UseVisualStyleBackColor = true;
            this.doButton.Visible = false;
            this.doButton.Click += new System.EventHandler(this.doIt);
            // 
            // decimalLabel
            // 
            this.decimalLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.decimalLabel.AutoSize = true;
            this.decimalLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalLabel.Location = new System.Drawing.Point(76, 371);
            this.decimalLabel.Name = "decimalLabel";
            this.decimalLabel.Size = new System.Drawing.Size(72, 19);
            this.decimalLabel.TabIndex = 23;
            this.decimalLabel.Text = "Decimal";
            this.decimalLabel.Visible = false;
            // 
            // decimalTextBox
            // 
            this.decimalTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.decimalTextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decimalTextBox.Location = new System.Drawing.Point(151, 368);
            this.decimalTextBox.Name = "decimalTextBox";
            this.decimalTextBox.ReadOnly = true;
            this.decimalTextBox.Size = new System.Drawing.Size(100, 26);
            this.decimalTextBox.TabIndex = 24;
            this.decimalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.decimalTextBox.Visible = false;
            this.decimalTextBox.WordWrap = false;
            // 
            // backToMenuButton
            // 
            this.backToMenuButton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToMenuButton.Location = new System.Drawing.Point(13, 13);
            this.backToMenuButton.Name = "backToMenuButton";
            this.backToMenuButton.Size = new System.Drawing.Size(94, 23);
            this.backToMenuButton.TabIndex = 25;
            this.backToMenuButton.Text = "Back to menu";
            this.backToMenuButton.UseVisualStyleBackColor = true;
            this.backToMenuButton.Visible = false;
            this.backToMenuButton.Click += new System.EventHandler(this.backToMenu);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 434);
            this.Controls.Add(this.backToMenuButton);
            this.Controls.Add(this.decimalTextBox);
            this.Controls.Add(this.decimalLabel);
            this.Controls.Add(this.doButton);
            this.Controls.Add(this.binaryBox2);
            this.Controls.Add(this.digit1Button);
            this.Controls.Add(this.digit0Button);
            this.Controls.Add(this.operationLabel);
            this.Controls.Add(this.binaryBox1);
            this.Controls.Add(this.instructionsTittle);
            this.Controls.Add(this.menuTittle);
            this.Controls.Add(this.easterEgg);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.howButton);
            this.Controls.Add(this.instructionsText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "binaryGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button howButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label easterEgg;
        private System.Windows.Forms.Label menuTittle;
        private System.Windows.Forms.Label instructionsTittle;
        private System.Windows.Forms.Button instructionsText;
        private System.Windows.Forms.TextBox binaryBox1;
        private System.Windows.Forms.Label operationLabel;
        internal System.Windows.Forms.Button digit1Button;
        internal System.Windows.Forms.Button digit0Button;
        private System.Windows.Forms.TextBox binaryBox2;
        private System.Windows.Forms.Button doButton;
        private System.Windows.Forms.Label decimalLabel;
        private System.Windows.Forms.TextBox decimalTextBox;
        private System.Windows.Forms.Button backToMenuButton;
    }
}

