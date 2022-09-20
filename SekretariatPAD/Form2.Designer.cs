namespace SekretariatPAD
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.imie = new System.Windows.Forms.Label();
            this.nazwisko = new System.Windows.Forms.Label();
            this.klasa = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.classname = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 437);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(793, 411);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Wyszukaj ucznia/uczniów";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.add);
            this.tabPage2.Controls.Add(this.classname);
            this.tabPage2.Controls.Add(this.lastname);
            this.tabPage2.Controls.Add(this.name);
            this.tabPage2.Controls.Add(this.klasa);
            this.tabPage2.Controls.Add(this.nazwisko);
            this.tabPage2.Controls.Add(this.imie);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(793, 411);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dodaj ucznia";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // imie
            // 
            this.imie.AutoSize = true;
            this.imie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imie.Location = new System.Drawing.Point(98, 73);
            this.imie.Name = "imie";
            this.imie.Size = new System.Drawing.Size(43, 20);
            this.imie.TabIndex = 0;
            this.imie.Text = "Imię";
            // 
            // nazwisko
            // 
            this.nazwisko.AutoSize = true;
            this.nazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazwisko.Location = new System.Drawing.Point(98, 125);
            this.nazwisko.Name = "nazwisko";
            this.nazwisko.Size = new System.Drawing.Size(84, 20);
            this.nazwisko.TabIndex = 1;
            this.nazwisko.Text = "Nazwisko";
            // 
            // klasa
            // 
            this.klasa.AutoSize = true;
            this.klasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.klasa.Location = new System.Drawing.Point(98, 171);
            this.klasa.Name = "klasa";
            this.klasa.Size = new System.Drawing.Size(51, 20);
            this.klasa.TabIndex = 2;
            this.klasa.Text = "klasa";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(243, 73);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(299, 20);
            this.name.TabIndex = 3;
            this.name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(243, 125);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(299, 20);
            this.lastname.TabIndex = 4;
            // 
            // classname
            // 
            this.classname.Location = new System.Drawing.Point(243, 171);
            this.classname.Name = "classname";
            this.classname.Size = new System.Drawing.Size(299, 20);
            this.classname.TabIndex = 5;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.add.Location = new System.Drawing.Point(478, 271);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(135, 34);
            this.add.TabIndex = 6;
            this.add.Text = "Dodaj";
            this.add.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Sekretariat";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label klasa;
        private System.Windows.Forms.Label nazwisko;
        private System.Windows.Forms.Label imie;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox classname;
        private System.Windows.Forms.Button add;
    }
}