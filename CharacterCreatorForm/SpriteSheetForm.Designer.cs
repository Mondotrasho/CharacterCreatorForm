namespace CharacterCreator
{
    partial class SpriteSheetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpriteSheetForm));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.Width = new System.Windows.Forms.TextBox();
            this.Height = new System.Windows.Forms.TextBox();
            this.Spacing = new System.Windows.Forms.TextBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.TEXT1 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.InitialImage")));
            this.pictureBox.Location = new System.Drawing.Point(13, 13);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(775, 333);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // Width
            // 
            this.Width.Location = new System.Drawing.Point(74, 366);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(100, 20);
            this.Width.TabIndex = 1;
            this.Width.Tag = "";
            this.Width.Text = "16";
            this.Width.TextChanged += new System.EventHandler(this.Width_TextChanged);
            // 
            // Height
            // 
            this.Height.Location = new System.Drawing.Point(74, 392);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(100, 20);
            this.Height.TabIndex = 2;
            this.Height.Text = "16";
            this.Height.TextChanged += new System.EventHandler(this.Height_TextChanged);
            // 
            // Spacing
            // 
            this.Spacing.Location = new System.Drawing.Point(74, 418);
            this.Spacing.Name = "Spacing";
            this.Spacing.Size = new System.Drawing.Size(100, 20);
            this.Spacing.TabIndex = 3;
            this.Spacing.Text = "1";
            this.Spacing.TextChanged += new System.EventHandler(this.Spacing_TextChanged);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(680, 362);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 4;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // TEXT1
            // 
            this.TEXT1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TEXT1.Location = new System.Drawing.Point(13, 366);
            this.TEXT1.Name = "TEXT1";
            this.TEXT1.ReadOnly = true;
            this.TEXT1.Size = new System.Drawing.Size(55, 13);
            this.TEXT1.TabIndex = 5;
            this.TEXT1.Tag = "";
            this.TEXT1.Text = "Tile Width";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(13, 392);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(55, 13);
            this.textBox1.TabIndex = 6;
            this.textBox1.Tag = "";
            this.textBox1.Text = "Tile Height";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(13, 418);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(55, 13);
            this.textBox2.TabIndex = 7;
            this.textBox2.Tag = "";
            this.textBox2.Text = "Spacing";
            // 
            // SpriteSheetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TEXT1);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.Spacing);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.Width);
            this.Controls.Add(this.pictureBox);
            this.Name = "SpriteSheetForm";
            this.Text = "Sprite Sheet";
            this.Shown += new System.EventHandler(this.SpriteSheetForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox Width;
        private System.Windows.Forms.TextBox Height;
        private System.Windows.Forms.TextBox Spacing;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.TextBox TEXT1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

