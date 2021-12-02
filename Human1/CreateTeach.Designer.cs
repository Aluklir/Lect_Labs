
namespace Human1
{
    partial class CreateTeach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeach));
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxRegion = new System.Windows.Forms.TextBox();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(74, 230);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 41);
            this.button1.TabIndex = 20;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.BackColor = System.Drawing.Color.White;
            this.textBoxStreet.Location = new System.Drawing.Point(23, 185);
            this.textBoxStreet.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(191, 20);
            this.textBoxStreet.TabIndex = 19;
            this.textBoxStreet.Text = "Street";
            this.textBoxStreet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxStreet.Click += new System.EventHandler(this.textBoxStreet_Click);
            this.textBoxStreet.Leave += new System.EventHandler(this.textBoxStreet_Leave);
            // 
            // textBoxCity
            // 
            this.textBoxCity.BackColor = System.Drawing.Color.White;
            this.textBoxCity.Location = new System.Drawing.Point(23, 161);
            this.textBoxCity.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(191, 20);
            this.textBoxCity.TabIndex = 18;
            this.textBoxCity.Text = "Sity";
            this.textBoxCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCity.Click += new System.EventHandler(this.textBoxSity_Click);
            this.textBoxCity.Leave += new System.EventHandler(this.textBoxSity_Leave);
            // 
            // textBoxRegion
            // 
            this.textBoxRegion.BackColor = System.Drawing.Color.White;
            this.textBoxRegion.Location = new System.Drawing.Point(23, 138);
            this.textBoxRegion.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRegion.Name = "textBoxRegion";
            this.textBoxRegion.Size = new System.Drawing.Size(191, 20);
            this.textBoxRegion.TabIndex = 17;
            this.textBoxRegion.Text = "Region\r\n";
            this.textBoxRegion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRegion.Click += new System.EventHandler(this.textBoxRegion_Click);
            this.textBoxRegion.Leave += new System.EventHandler(this.textBoxRegion_Leave);
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.BackColor = System.Drawing.Color.White;
            this.textBoxCountry.Location = new System.Drawing.Point(23, 115);
            this.textBoxCountry.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(191, 20);
            this.textBoxCountry.TabIndex = 16;
            this.textBoxCountry.Text = "Country";
            this.textBoxCountry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCountry.Click += new System.EventHandler(this.textBoxCountry_Click);
            this.textBoxCountry.Leave += new System.EventHandler(this.textBoxCountry_Leave);
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.Color.White;
            this.textBoxID.Location = new System.Drawing.Point(23, 92);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(191, 20);
            this.textBoxID.TabIndex = 15;
            this.textBoxID.Text = "ID";
            this.textBoxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxID.Click += new System.EventHandler(this.textBoxID_Click);
            this.textBoxID.Leave += new System.EventHandler(this.textBoxID_Leave);
            // 
            // textBoxAge
            // 
            this.textBoxAge.BackColor = System.Drawing.Color.White;
            this.textBoxAge.Location = new System.Drawing.Point(23, 69);
            this.textBoxAge.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(191, 20);
            this.textBoxAge.TabIndex = 13;
            this.textBoxAge.Text = "Age";
            this.textBoxAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxAge.Click += new System.EventHandler(this.textBoxAge_Click);
            this.textBoxAge.Leave += new System.EventHandler(this.textBoxAge_Leave);
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxSurname.BackColor = System.Drawing.Color.White;
            this.textBoxSurname.HideSelection = false;
            this.textBoxSurname.Location = new System.Drawing.Point(23, 47);
            this.textBoxSurname.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(191, 20);
            this.textBoxSurname.TabIndex = 12;
            this.textBoxSurname.Text = "Surmane";
            this.textBoxSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSurname.Click += new System.EventHandler(this.textBoxSurname_Click);
            this.textBoxSurname.Leave += new System.EventHandler(this.textBoxSurname_Leave);
            // 
            // textBoxName
            // 
            this.textBoxName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxName.BackColor = System.Drawing.Color.White;
            this.textBoxName.Location = new System.Drawing.Point(23, 24);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(191, 20);
            this.textBoxName.TabIndex = 11;
            this.textBoxName.Text = "Name";
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxName.Click += new System.EventHandler(this.textBoxName_Click);
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
            // 
            // CreateTeach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(243, 294);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxStreet);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxRegion);
            this.Controls.Add(this.textBoxCountry);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "CreateTeach";
            this.Text = "CreateTeach";
            this.Load += new System.EventHandler(this.CreateTeach_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxRegion;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
    }
}