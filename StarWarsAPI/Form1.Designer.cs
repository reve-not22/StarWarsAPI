namespace StarWarsAPI
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
            this.button1 = new System.Windows.Forms.Button();
            this.txt_ID_Planet = new System.Windows.Forms.TextBox();
            this.List_AllSpecies = new System.Windows.Forms.ListBox();
            this.btn_AllSpecies = new System.Windows.Forms.Button();
            this.txt_ID_Person = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.list_Planet = new System.Windows.Forms.ListBox();
            this.list_Person = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get Planet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_ID_Planet
            // 
            this.txt_ID_Planet.Location = new System.Drawing.Point(35, 12);
            this.txt_ID_Planet.Name = "txt_ID_Planet";
            this.txt_ID_Planet.Size = new System.Drawing.Size(100, 20);
            this.txt_ID_Planet.TabIndex = 1;
            // 
            // List_AllSpecies
            // 
            this.List_AllSpecies.FormattingEnabled = true;
            this.List_AllSpecies.Location = new System.Drawing.Point(495, 41);
            this.List_AllSpecies.Name = "List_AllSpecies";
            this.List_AllSpecies.Size = new System.Drawing.Size(293, 394);
            this.List_AllSpecies.TabIndex = 2;
            // 
            // btn_AllSpecies
            // 
            this.btn_AllSpecies.Location = new System.Drawing.Point(495, 12);
            this.btn_AllSpecies.Name = "btn_AllSpecies";
            this.btn_AllSpecies.Size = new System.Drawing.Size(119, 23);
            this.btn_AllSpecies.TabIndex = 3;
            this.btn_AllSpecies.Text = "Get All Species";
            this.btn_AllSpecies.UseVisualStyleBackColor = true;
            this.btn_AllSpecies.Click += new System.EventHandler(this.btn_AllSpecies_Click);
            // 
            // txt_ID_Person
            // 
            this.txt_ID_Person.Location = new System.Drawing.Point(263, 12);
            this.txt_ID_Person.Name = "txt_ID_Person";
            this.txt_ID_Person.Size = new System.Drawing.Size(100, 20);
            this.txt_ID_Person.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(263, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Get Person";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // list_Planet
            // 
            this.list_Planet.FormattingEnabled = true;
            this.list_Planet.Location = new System.Drawing.Point(35, 67);
            this.list_Planet.Name = "list_Planet";
            this.list_Planet.Size = new System.Drawing.Size(120, 368);
            this.list_Planet.TabIndex = 6;
            // 
            // list_Person
            // 
            this.list_Person.FormattingEnabled = true;
            this.list_Person.Location = new System.Drawing.Point(263, 67);
            this.list_Person.Name = "list_Person";
            this.list_Person.Size = new System.Drawing.Size(226, 368);
            this.list_Person.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_Person);
            this.Controls.Add(this.list_Planet);
            this.Controls.Add(this.txt_ID_Person);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_AllSpecies);
            this.Controls.Add(this.List_AllSpecies);
            this.Controls.Add(this.txt_ID_Planet);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_ID_Planet;
        private System.Windows.Forms.ListBox List_AllSpecies;
        private System.Windows.Forms.Button btn_AllSpecies;
        private System.Windows.Forms.TextBox txt_ID_Person;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox list_Planet;
        private System.Windows.Forms.ListBox list_Person;
        private System.Windows.Forms.Label label1;
    }
}

