namespace SekretariatPAD
{
    partial class Sekretariat
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sekretariat));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textW = new System.Windows.Forms.Label();
            this.napisZdj = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.losujObraz = new System.Windows.Forms.LinkLabel();
            this.blad = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(110, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Użytkownik:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(143, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasło:";
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(252, 39);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(172, 20);
            this.user.TabIndex = 2;
            this.user.TextChanged += new System.EventHandler(this.user_TextChanged);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(252, 80);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(172, 20);
            this.password.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(110, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Weryfikacja:";
            // 
            // textW
            // 
            this.textW.AutoSize = true;
            this.textW.Location = new System.Drawing.Point(163, 170);
            this.textW.Name = "textW";
            this.textW.Size = new System.Drawing.Size(0, 13);
            this.textW.TabIndex = 5;
            // 
            // napisZdj
            // 
            this.napisZdj.Location = new System.Drawing.Point(252, 220);
            this.napisZdj.Name = "napisZdj";
            this.napisZdj.Size = new System.Drawing.Size(172, 20);
            this.napisZdj.TabIndex = 7;
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.login.Location = new System.Drawing.Point(401, 316);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 8;
            this.login.Text = "Zaloguj";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // losujObraz
            // 
            this.losujObraz.AutoSize = true;
            this.losujObraz.LinkColor = System.Drawing.Color.Black;
            this.losujObraz.Location = new System.Drawing.Point(249, 254);
            this.losujObraz.Name = "losujObraz";
            this.losujObraz.Size = new System.Drawing.Size(60, 13);
            this.losujObraz.TabIndex = 9;
            this.losujObraz.TabStop = true;
            this.losujObraz.Text = "Losuj nowy";
            this.losujObraz.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // blad
            // 
            this.blad.AutoSize = true;
            this.blad.Location = new System.Drawing.Point(30, 382);
            this.blad.Name = "blad";
            this.blad.Size = new System.Drawing.Size(0, 13);
            this.blad.TabIndex = 10;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.png");
            this.imageList1.Images.SetKeyName(1, "2.png");
            this.imageList1.Images.SetKeyName(2, "3.png");
            this.imageList1.Images.SetKeyName(3, "4.png");
            this.imageList1.Images.SetKeyName(4, "5.png");
            this.imageList1.Images.SetKeyName(5, "6.png");
            this.imageList1.Images.SetKeyName(6, "7.png");
            // 
            // Sekretariat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 423);
            this.Controls.Add(this.blad);
            this.Controls.Add(this.losujObraz);
            this.Controls.Add(this.login);
            this.Controls.Add(this.napisZdj);
            this.Controls.Add(this.textW);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sekretariat";
            this.Text = "Sekretariat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label textW;
        private System.Windows.Forms.TextBox napisZdj;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.LinkLabel losujObraz;
        private System.Windows.Forms.Label blad;
        private System.Windows.Forms.ImageList imageList1;
    }
}

