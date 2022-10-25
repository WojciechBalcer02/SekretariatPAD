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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.Label imieLabel;
            System.Windows.Forms.Label nazwiskoLabel;
            System.Windows.Forms.Label klasaLabel;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.search = new System.Windows.Forms.Button();
            this.szukaj = new System.Windows.Forms.TextBox();
            this.kryterium = new System.Windows.Forms.ComboBox();
            this.daneUcznia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.add = new System.Windows.Forms.Button();
            this.classname = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.klasa = new System.Windows.Forms.Label();
            this.nazwisko = new System.Windows.Forms.Label();
            this.imie = new System.Windows.Forms.Label();
            this.database2DataSet2 = new SekretariatPAD.Database2DataSet2();
            this.uczniowieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uczniowieTableAdapter = new SekretariatPAD.Database2DataSet2TableAdapters.uczniowieTableAdapter();
            this.tableAdapterManager = new SekretariatPAD.Database2DataSet2TableAdapters.TableAdapterManager();
            this.uczniowieBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.uczniowieBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.imieTextBox = new System.Windows.Forms.TextBox();
            this.nazwiskoTextBox = new System.Windows.Forms.TextBox();
            this.klasaTextBox = new System.Windows.Forms.TextBox();
            imieLabel = new System.Windows.Forms.Label();
            nazwiskoLabel = new System.Windows.Forms.Label();
            klasaLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uczniowieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uczniowieBindingNavigator)).BeginInit();
            this.uczniowieBindingNavigator.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.search);
            this.tabPage1.Controls.Add(this.szukaj);
            this.tabPage1.Controls.Add(this.kryterium);
            this.tabPage1.Controls.Add(this.daneUcznia);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(793, 411);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Wyszukaj ucznia/uczniów";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(522, 90);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 5;
            this.search.Text = "szukaj";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // szukaj
            // 
            this.szukaj.Location = new System.Drawing.Point(460, 55);
            this.szukaj.Name = "szukaj";
            this.szukaj.Size = new System.Drawing.Size(137, 20);
            this.szukaj.TabIndex = 4;
            // 
            // kryterium
            // 
            this.kryterium.FormattingEnabled = true;
            this.kryterium.Items.AddRange(new object[] {
            "zaczyna się od",
            "równe",
            "zawiera"});
            this.kryterium.Location = new System.Drawing.Point(239, 54);
            this.kryterium.Name = "kryterium";
            this.kryterium.Size = new System.Drawing.Size(154, 21);
            this.kryterium.TabIndex = 3;
            // 
            // daneUcznia
            // 
            this.daneUcznia.FormattingEnabled = true;
            this.daneUcznia.Items.AddRange(new object[] {
            "Imię",
            "Nazwisko",
            "Klasa"});
            this.daneUcznia.Location = new System.Drawing.Point(29, 55);
            this.daneUcznia.Name = "daneUcznia";
            this.daneUcznia.Size = new System.Drawing.Size(154, 21);
            this.daneUcznia.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wczytaj kryteria wyszukiwania";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 131);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(781, 274);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(imieLabel);
            this.tabPage2.Controls.Add(this.imieTextBox);
            this.tabPage2.Controls.Add(nazwiskoLabel);
            this.tabPage2.Controls.Add(this.nazwiskoTextBox);
            this.tabPage2.Controls.Add(klasaLabel);
            this.tabPage2.Controls.Add(this.klasaTextBox);
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
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.add.Location = new System.Drawing.Point(478, 271);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(135, 34);
            this.add.TabIndex = 6;
            this.add.Text = "Dodaj";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // classname
            // 
            this.classname.Location = new System.Drawing.Point(243, 171);
            this.classname.Name = "classname";
            this.classname.Size = new System.Drawing.Size(299, 20);
            this.classname.TabIndex = 5;
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(243, 125);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(299, 20);
            this.lastname.TabIndex = 4;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(243, 73);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(299, 20);
            this.name.TabIndex = 3;
            this.name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // database2DataSet2
            // 
            this.database2DataSet2.DataSetName = "Database2DataSet2";
            this.database2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uczniowieBindingSource
            // 
            this.uczniowieBindingSource.DataMember = "uczniowie";
            this.uczniowieBindingSource.DataSource = this.database2DataSet2;
            // 
            // uczniowieTableAdapter
            // 
            this.uczniowieTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.uczniowieTableAdapter = this.uczniowieTableAdapter;
            this.tableAdapterManager.UpdateOrder = SekretariatPAD.Database2DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // uczniowieBindingNavigator
            // 
            this.uczniowieBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.uczniowieBindingNavigator.BindingSource = this.uczniowieBindingSource;
            this.uczniowieBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.uczniowieBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.uczniowieBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uczniowieBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.uczniowieBindingNavigatorSaveItem});
            this.uczniowieBindingNavigator.Location = new System.Drawing.Point(0, 425);
            this.uczniowieBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.uczniowieBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.uczniowieBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.uczniowieBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.uczniowieBindingNavigator.Name = "uczniowieBindingNavigator";
            this.uczniowieBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.uczniowieBindingNavigator.Size = new System.Drawing.Size(804, 25);
            this.uczniowieBindingNavigator.TabIndex = 1;
            this.uczniowieBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Przenieś pierwszy";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Przenieś poprzedni";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Pozycja";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Bieżąca pozycja";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 15);
            this.bindingNavigatorCountItem.Text = "z {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Suma elementów";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Przenieś następny";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Przenieś ostatni";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Dodaj nowy";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Usuń";
            // 
            // uczniowieBindingNavigatorSaveItem
            // 
            this.uczniowieBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uczniowieBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("uczniowieBindingNavigatorSaveItem.Image")));
            this.uczniowieBindingNavigatorSaveItem.Name = "uczniowieBindingNavigatorSaveItem";
            this.uczniowieBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.uczniowieBindingNavigatorSaveItem.Text = "Zapisz dane";
            this.uczniowieBindingNavigatorSaveItem.Click += new System.EventHandler(this.uczniowieBindingNavigatorSaveItem_Click);
            // 
            // imieLabel
            // 
            imieLabel.AutoSize = true;
            imieLabel.Location = new System.Drawing.Point(127, 246);
            imieLabel.Name = "imieLabel";
            imieLabel.Size = new System.Drawing.Size(28, 13);
            imieLabel.TabIndex = 7;
            imieLabel.Text = "imie:";
            // 
            // imieTextBox
            // 
            this.imieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uczniowieBindingSource, "imie", true));
            this.imieTextBox.Location = new System.Drawing.Point(187, 243);
            this.imieTextBox.Name = "imieTextBox";
            this.imieTextBox.Size = new System.Drawing.Size(100, 20);
            this.imieTextBox.TabIndex = 8;
            // 
            // nazwiskoLabel
            // 
            nazwiskoLabel.AutoSize = true;
            nazwiskoLabel.Location = new System.Drawing.Point(127, 272);
            nazwiskoLabel.Name = "nazwiskoLabel";
            nazwiskoLabel.Size = new System.Drawing.Size(54, 13);
            nazwiskoLabel.TabIndex = 9;
            nazwiskoLabel.Text = "nazwisko:";
            // 
            // nazwiskoTextBox
            // 
            this.nazwiskoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uczniowieBindingSource, "nazwisko", true));
            this.nazwiskoTextBox.Location = new System.Drawing.Point(187, 269);
            this.nazwiskoTextBox.Name = "nazwiskoTextBox";
            this.nazwiskoTextBox.Size = new System.Drawing.Size(100, 20);
            this.nazwiskoTextBox.TabIndex = 10;
            // 
            // klasaLabel
            // 
            klasaLabel.AutoSize = true;
            klasaLabel.Location = new System.Drawing.Point(127, 298);
            klasaLabel.Name = "klasaLabel";
            klasaLabel.Size = new System.Drawing.Size(35, 13);
            klasaLabel.TabIndex = 11;
            klasaLabel.Text = "klasa:";
            // 
            // klasaTextBox
            // 
            this.klasaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uczniowieBindingSource, "klasa", true));
            this.klasaTextBox.Location = new System.Drawing.Point(187, 295);
            this.klasaTextBox.Name = "klasaTextBox";
            this.klasaTextBox.Size = new System.Drawing.Size(100, 20);
            this.klasaTextBox.TabIndex = 12;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.uczniowieBindingNavigator);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Sekretariat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Shown += new System.EventHandler(this.Form2_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database2DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uczniowieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uczniowieBindingNavigator)).EndInit();
            this.uczniowieBindingNavigator.ResumeLayout(false);
            this.uczniowieBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox szukaj;
        private System.Windows.Forms.ComboBox kryterium;
        private System.Windows.Forms.ComboBox daneUcznia;
        private System.Windows.Forms.Label label1;
        private Database2DataSet2 database2DataSet2;
        private System.Windows.Forms.BindingSource uczniowieBindingSource;
        private Database2DataSet2TableAdapters.uczniowieTableAdapter uczniowieTableAdapter;
        private Database2DataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator uczniowieBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton uczniowieBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox imieTextBox;
        private System.Windows.Forms.TextBox nazwiskoTextBox;
        private System.Windows.Forms.TextBox klasaTextBox;
    }
}