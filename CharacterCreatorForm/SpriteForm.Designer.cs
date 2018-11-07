namespace CharacterCreator
{
    partial class SpriteForm
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSheets = new System.Windows.Forms.ComboBox();
            this.listViewTiles = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tilex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tiley = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(286, 301);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(442, 290);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(523, 290);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(354, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Layers";
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sheet";
            // 
            // comboBoxSheets
            // 
            this.comboBoxSheets.FormattingEnabled = true;
            this.comboBoxSheets.Location = new System.Drawing.Point(355, 39);
            this.comboBoxSheets.Name = "comboBoxSheets";
            this.comboBoxSheets.Size = new System.Drawing.Size(243, 21);
            this.comboBoxSheets.TabIndex = 10;
            this.comboBoxSheets.SelectedValueChanged += new System.EventHandler(this.comboBoxSheets_SelectedValueChanged);
            // 
            // listViewTiles
            // 
            this.listViewTiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.priority,
            this.tilex,
            this.tiley});
            this.listViewTiles.LabelEdit = true;
            this.listViewTiles.Location = new System.Drawing.Point(355, 66);
            this.listViewTiles.MultiSelect = false;
            this.listViewTiles.Name = "listViewTiles";
            this.listViewTiles.Size = new System.Drawing.Size(243, 218);
            this.listViewTiles.TabIndex = 11;
            this.listViewTiles.UseCompatibleStateImageBehavior = false;
            this.listViewTiles.View = System.Windows.Forms.View.Details;
            this.listViewTiles.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listViewTiles_AfterLabelEdit);
            // 
            // name
            // 
            this.name.Text = "Layer Name";
            this.name.Width = 100;
            // 
            // priority
            // 
            this.priority.Text = "Priority";
            this.priority.Width = 45;
            // 
            // tilex
            // 
            this.tilex.Text = "Tile X";
            this.tilex.Width = 45;
            // 
            // tiley
            // 
            this.tiley.Text = "Tile Y";
            this.tiley.Width = 45;
            // 
            // SpriteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 331);
            this.Controls.Add(this.listViewTiles);
            this.Controls.Add(this.comboBoxSheets);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.pictureBox);
            this.Name = "SpriteForm";
            this.Text = "Sprite";
            this.Activated += new System.EventHandler(this.SpriteForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSheets;
        private System.Windows.Forms.ListView listViewTiles;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader tilex;
        private System.Windows.Forms.ColumnHeader tiley;
        public System.Windows.Forms.ColumnHeader priority;
    }
}

