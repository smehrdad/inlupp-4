namespace AnimalMotel
{
    partial class AnimalMotel
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
        ///// 
        //private void InitializeOpenFileDialog()
        //{
        //    // Set the file dialog to filter for graphics files. 
        //    this.picBox.Filter =
        //        "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|" +
        //        "All files (*.*)|*.*";

        //    // Allow the user to select multiple images. 
        //    this.openFileDialpicBoxog1.Multiselect = true;
        //    this.openFileDialog1.Title = "My Image Browser";
        //}
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txbName = new System.Windows.Forms.TextBox();
            this.labName = new System.Windows.Forms.Label();
            this.labAge = new System.Windows.Forms.Label();
            this.labNameInListBox = new System.Windows.Forms.Label();
            this.txbAge = new System.Windows.Forms.TextBox();
            this.labCategory = new System.Windows.Forms.Label();
            this.labAnimalObject = new System.Windows.Forms.Label();
            this.labImportantInfo = new System.Windows.Forms.Label();
            this.grBoxLitsResult = new System.Windows.Forms.GroupBox();
            this.listBxSpecialData = new System.Windows.Forms.TextBox();
            this.labSpecialData = new System.Windows.Forms.Label();
            this.listViewListOfRegisteredAnimals = new System.Windows.Forms.ListView();
            this.grBoxAnimalSpec = new System.Windows.Forms.GroupBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.btnLoadPicture = new System.Windows.Forms.Button();
            this.grBoxAnimalSpecifications = new System.Windows.Forms.GroupBox();
            this.tboxNoOfTeeth = new System.Windows.Forms.TextBox();
            this.texBoxDaysInQuarantine = new System.Windows.Forms.TextBox();
            this.chBoxUnderQuarantine = new System.Windows.Forms.CheckBox();
            this.labDaysInGuarantie = new System.Windows.Forms.Label();
            this.labNoOfTeeth = new System.Windows.Forms.Label();
            this.chBoxAllAnimal = new System.Windows.Forms.CheckBox();
            this.labGender = new System.Windows.Forms.Label();
            this.labBxImportantInfo = new System.Windows.Forms.TextBox();
            this.btnAddAnimal = new System.Windows.Forms.Button();
            this.listBxGender = new System.Windows.Forms.ListBox();
            this.listbxAnimalSpecies = new System.Windows.Forms.ListBox();
            this.listBxCategori = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorPrName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProAge = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNoOfTeeth = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDayInQuarantiner = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oppenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grBoxLitsResult.SuspendLayout();
            this.grBoxAnimalSpec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.grBoxAnimalSpecifications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNoOfTeeth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDayInQuarantiner)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(202, 63);
            this.txbName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(148, 26);
            this.txbName.TabIndex = 0;
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(9, 74);
            this.labName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(51, 20);
            this.labName.TabIndex = 1;
            this.labName.Text = "Name";
            // 
            // labAge
            // 
            this.labAge.AutoSize = true;
            this.labAge.Location = new System.Drawing.Point(9, 115);
            this.labAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labAge.Name = "labAge";
            this.labAge.Size = new System.Drawing.Size(38, 20);
            this.labAge.TabIndex = 2;
            this.labAge.Text = "Age";
            // 
            // labNameInListBox
            // 
            this.labNameInListBox.Location = new System.Drawing.Point(0, 0);
            this.labNameInListBox.Name = "labNameInListBox";
            this.labNameInListBox.Size = new System.Drawing.Size(100, 23);
            this.labNameInListBox.TabIndex = 0;
            // 
            // txbAge
            // 
            this.txbAge.Location = new System.Drawing.Point(280, 105);
            this.txbAge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbAge.Name = "txbAge";
            this.txbAge.Size = new System.Drawing.Size(70, 26);
            this.txbAge.TabIndex = 3;
            // 
            // labCategory
            // 
            this.labCategory.AutoSize = true;
            this.labCategory.Location = new System.Drawing.Point(453, 25);
            this.labCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labCategory.Name = "labCategory";
            this.labCategory.Size = new System.Drawing.Size(73, 20);
            this.labCategory.TabIndex = 4;
            this.labCategory.Text = "Category";
            // 
            // labAnimalObject
            // 
            this.labAnimalObject.AutoSize = true;
            this.labAnimalObject.Location = new System.Drawing.Point(714, 25);
            this.labAnimalObject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labAnimalObject.Name = "labAnimalObject";
            this.labAnimalObject.Size = new System.Drawing.Size(107, 20);
            this.labAnimalObject.TabIndex = 5;
            this.labAnimalObject.Text = "Animal Object";
            // 
            // labImportantInfo
            // 
            this.labImportantInfo.AutoSize = true;
            this.labImportantInfo.Location = new System.Drawing.Point(1143, 38);
            this.labImportantInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labImportantInfo.Name = "labImportantInfo";
            this.labImportantInfo.Size = new System.Drawing.Size(108, 20);
            this.labImportantInfo.TabIndex = 6;
            this.labImportantInfo.Text = "Important info";
            // 
            // grBoxLitsResult
            // 
            this.grBoxLitsResult.Controls.Add(this.listBxSpecialData);
            this.grBoxLitsResult.Controls.Add(this.labSpecialData);
            this.grBoxLitsResult.Controls.Add(this.listViewListOfRegisteredAnimals);
            this.grBoxLitsResult.Location = new System.Drawing.Point(22, 535);
            this.grBoxLitsResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grBoxLitsResult.Name = "grBoxLitsResult";
            this.grBoxLitsResult.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grBoxLitsResult.Size = new System.Drawing.Size(1383, 348);
            this.grBoxLitsResult.TabIndex = 8;
            this.grBoxLitsResult.TabStop = false;
            this.grBoxLitsResult.Text = "List of registered animals with general data";
            // 
            // listBxSpecialData
            // 
            this.listBxSpecialData.Enabled = false;
            this.listBxSpecialData.Location = new System.Drawing.Point(902, 72);
            this.listBxSpecialData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBxSpecialData.Multiline = true;
            this.listBxSpecialData.Name = "listBxSpecialData";
            this.listBxSpecialData.Size = new System.Drawing.Size(408, 264);
            this.listBxSpecialData.TabIndex = 16;
            // 
            // labSpecialData
            // 
            this.labSpecialData.AutoSize = true;
            this.labSpecialData.Location = new System.Drawing.Point(897, 48);
            this.labSpecialData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labSpecialData.Name = "labSpecialData";
            this.labSpecialData.Size = new System.Drawing.Size(100, 20);
            this.labSpecialData.TabIndex = 16;
            this.labSpecialData.Text = "Special Data";
            // 
            // listViewListOfRegisteredAnimals
            // 
            this.listViewListOfRegisteredAnimals.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.listViewListOfRegisteredAnimals.FullRowSelect = true;
            this.listViewListOfRegisteredAnimals.GridLines = true;
            this.listViewListOfRegisteredAnimals.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewListOfRegisteredAnimals.Location = new System.Drawing.Point(9, 72);
            this.listViewListOfRegisteredAnimals.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewListOfRegisteredAnimals.Name = "listViewListOfRegisteredAnimals";
            this.listViewListOfRegisteredAnimals.Size = new System.Drawing.Size(882, 264);
            this.listViewListOfRegisteredAnimals.TabIndex = 12;
            this.listViewListOfRegisteredAnimals.UseCompatibleStateImageBehavior = false;
            this.listViewListOfRegisteredAnimals.View = System.Windows.Forms.View.Details;
            this.listViewListOfRegisteredAnimals.Click += new System.EventHandler(this.selectRow_klick);
            // 
            // grBoxAnimalSpec
            // 
            this.grBoxAnimalSpec.Controls.Add(this.picBox);
            this.grBoxAnimalSpec.Controls.Add(this.btnLoadPicture);
            this.grBoxAnimalSpec.Controls.Add(this.grBoxAnimalSpecifications);
            this.grBoxAnimalSpec.Controls.Add(this.chBoxAllAnimal);
            this.grBoxAnimalSpec.Controls.Add(this.labGender);
            this.grBoxAnimalSpec.Controls.Add(this.labBxImportantInfo);
            this.grBoxAnimalSpec.Controls.Add(this.btnAddAnimal);
            this.grBoxAnimalSpec.Controls.Add(this.listBxGender);
            this.grBoxAnimalSpec.Controls.Add(this.listbxAnimalSpecies);
            this.grBoxAnimalSpec.Controls.Add(this.listBxCategori);
            this.grBoxAnimalSpec.Controls.Add(this.txbAge);
            this.grBoxAnimalSpec.Controls.Add(this.labName);
            this.grBoxAnimalSpec.Controls.Add(this.labAge);
            this.grBoxAnimalSpec.Controls.Add(this.labImportantInfo);
            this.grBoxAnimalSpec.Controls.Add(this.txbName);
            this.grBoxAnimalSpec.Controls.Add(this.labAnimalObject);
            this.grBoxAnimalSpec.Controls.Add(this.labCategory);
            this.grBoxAnimalSpec.Location = new System.Drawing.Point(22, 54);
            this.grBoxAnimalSpec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grBoxAnimalSpec.Name = "grBoxAnimalSpec";
            this.grBoxAnimalSpec.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grBoxAnimalSpec.Size = new System.Drawing.Size(1383, 472);
            this.grBoxAnimalSpec.TabIndex = 9;
            this.grBoxAnimalSpec.TabStop = false;
            this.grBoxAnimalSpec.Text = "Animal Specifications";
            // 
            // picBox
            // 
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBox.Location = new System.Drawing.Point(902, 63);
            this.picBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(120, 129);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBox.TabIndex = 19;
            this.picBox.TabStop = false;
            // 
            // btnLoadPicture
            // 
            this.btnLoadPicture.Location = new System.Drawing.Point(902, 266);
            this.btnLoadPicture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoadPicture.Name = "btnLoadPicture";
            this.btnLoadPicture.Size = new System.Drawing.Size(182, 43);
            this.btnLoadPicture.TabIndex = 17;
            this.btnLoadPicture.Text = "Load animal photo";
            this.btnLoadPicture.UseVisualStyleBackColor = true;
            this.btnLoadPicture.Click += new System.EventHandler(this.btnLoadPicture_Click_1);
            // 
            // grBoxAnimalSpecifications
            // 
            this.grBoxAnimalSpecifications.Controls.Add(this.tboxNoOfTeeth);
            this.grBoxAnimalSpecifications.Controls.Add(this.texBoxDaysInQuarantine);
            this.grBoxAnimalSpecifications.Controls.Add(this.chBoxUnderQuarantine);
            this.grBoxAnimalSpecifications.Controls.Add(this.labDaysInGuarantie);
            this.grBoxAnimalSpecifications.Controls.Add(this.labNoOfTeeth);
            this.grBoxAnimalSpecifications.Location = new System.Drawing.Point(28, 277);
            this.grBoxAnimalSpecifications.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grBoxAnimalSpecifications.Name = "grBoxAnimalSpecifications";
            this.grBoxAnimalSpecifications.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grBoxAnimalSpecifications.Size = new System.Drawing.Size(572, 154);
            this.grBoxAnimalSpecifications.TabIndex = 15;
            this.grBoxAnimalSpecifications.TabStop = false;
            this.grBoxAnimalSpecifications.Text = "Specifications";
            this.grBoxAnimalSpecifications.Visible = false;
            // 
            // tboxNoOfTeeth
            // 
            this.tboxNoOfTeeth.Location = new System.Drawing.Point(238, 34);
            this.tboxNoOfTeeth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tboxNoOfTeeth.Name = "tboxNoOfTeeth";
            this.tboxNoOfTeeth.Size = new System.Drawing.Size(52, 26);
            this.tboxNoOfTeeth.TabIndex = 20;
            // 
            // texBoxDaysInQuarantine
            // 
            this.texBoxDaysInQuarantine.Enabled = false;
            this.texBoxDaysInQuarantine.Location = new System.Drawing.Point(474, 105);
            this.texBoxDaysInQuarantine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.texBoxDaysInQuarantine.Name = "texBoxDaysInQuarantine";
            this.texBoxDaysInQuarantine.Size = new System.Drawing.Size(52, 26);
            this.texBoxDaysInQuarantine.TabIndex = 16;
            // 
            // chBoxUnderQuarantine
            // 
            this.chBoxUnderQuarantine.AutoSize = true;
            this.chBoxUnderQuarantine.Location = new System.Drawing.Point(27, 109);
            this.chBoxUnderQuarantine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chBoxUnderQuarantine.Name = "chBoxUnderQuarantine";
            this.chBoxUnderQuarantine.Size = new System.Drawing.Size(159, 24);
            this.chBoxUnderQuarantine.TabIndex = 16;
            this.chBoxUnderQuarantine.Text = "Under quarantine";
            this.chBoxUnderQuarantine.UseVisualStyleBackColor = true;
            this.chBoxUnderQuarantine.CheckedChanged += new System.EventHandler(this.chBoxUnderQuarantine_CheckedChanged);
            // 
            // labDaysInGuarantie
            // 
            this.labDaysInGuarantie.AutoSize = true;
            this.labDaysInGuarantie.Location = new System.Drawing.Point(248, 109);
            this.labDaysInGuarantie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labDaysInGuarantie.Name = "labDaysInGuarantie";
            this.labDaysInGuarantie.Size = new System.Drawing.Size(172, 20);
            this.labDaysInGuarantie.TabIndex = 19;
            this.labDaysInGuarantie.Text = "Days in quarantine or 0";
            // 
            // labNoOfTeeth
            // 
            this.labNoOfTeeth.AutoSize = true;
            this.labNoOfTeeth.Location = new System.Drawing.Point(22, 38);
            this.labNoOfTeeth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labNoOfTeeth.Name = "labNoOfTeeth";
            this.labNoOfTeeth.Size = new System.Drawing.Size(95, 20);
            this.labNoOfTeeth.TabIndex = 18;
            this.labNoOfTeeth.Text = "NO. of teeth";
            // 
            // chBoxAllAnimal
            // 
            this.chBoxAllAnimal.AutoSize = true;
            this.chBoxAllAnimal.Location = new System.Drawing.Point(918, 365);
            this.chBoxAllAnimal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chBoxAllAnimal.Name = "chBoxAllAnimal";
            this.chBoxAllAnimal.Size = new System.Drawing.Size(137, 24);
            this.chBoxAllAnimal.TabIndex = 14;
            this.chBoxAllAnimal.Text = "List all animals";
            this.chBoxAllAnimal.UseVisualStyleBackColor = true;
            this.chBoxAllAnimal.Click += new System.EventHandler(this.Onclick_listAllAnimals);
            // 
            // labGender
            // 
            this.labGender.AutoSize = true;
            this.labGender.Location = new System.Drawing.Point(9, 160);
            this.labGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labGender.Name = "labGender";
            this.labGender.Size = new System.Drawing.Size(63, 20);
            this.labGender.TabIndex = 12;
            this.labGender.Text = "Gender";
            // 
            // labBxImportantInfo
            // 
            this.labBxImportantInfo.Location = new System.Drawing.Point(1100, 63);
            this.labBxImportantInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labBxImportantInfo.Multiline = true;
            this.labBxImportantInfo.Name = "labBxImportantInfo";
            this.labBxImportantInfo.Size = new System.Drawing.Size(210, 244);
            this.labBxImportantInfo.TabIndex = 13;
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.Location = new System.Drawing.Point(680, 348);
            this.btnAddAnimal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(200, 43);
            this.btnAddAnimal.TabIndex = 11;
            this.btnAddAnimal.Text = "Add this new animal";
            this.btnAddAnimal.UseVisualStyleBackColor = true;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // listBxGender
            // 
            this.listBxGender.FormattingEnabled = true;
            this.listBxGender.ItemHeight = 20;
            this.listBxGender.Location = new System.Drawing.Point(153, 160);
            this.listBxGender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBxGender.Name = "listBxGender";
            this.listBxGender.Size = new System.Drawing.Size(198, 84);
            this.listBxGender.TabIndex = 10;
            // 
            // listbxAnimalSpecies
            // 
            this.listbxAnimalSpecies.FormattingEnabled = true;
            this.listbxAnimalSpecies.ItemHeight = 20;
            this.listbxAnimalSpecies.Location = new System.Drawing.Point(680, 63);
            this.listbxAnimalSpecies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listbxAnimalSpecies.Name = "listbxAnimalSpecies";
            this.listbxAnimalSpecies.Size = new System.Drawing.Size(198, 244);
            this.listbxAnimalSpecies.TabIndex = 8;
            this.listbxAnimalSpecies.Click += new System.EventHandler(this.Click_ChooseCategoriFromList);
            // 
            // listBxCategori
            // 
            this.listBxCategori.FormattingEnabled = true;
            this.listBxCategori.ItemHeight = 20;
            this.listBxCategori.Location = new System.Drawing.Point(400, 63);
            this.listBxCategori.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBxCategori.Name = "listBxCategori";
            this.listBxCategori.Size = new System.Drawing.Size(198, 184);
            this.listBxCategori.TabIndex = 7;
            this.listBxCategori.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorPrName
            // 
            this.errorPrName.ContainerControl = this;
            // 
            // errorProAge
            // 
            this.errorProAge.ContainerControl = this;
            // 
            // errorNoOfTeeth
            // 
            this.errorNoOfTeeth.ContainerControl = this;
            // 
            // errorDayInQuarantiner
            // 
            this.errorDayInQuarantiner.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1486, 35);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.oppenToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.xMLToolStripMenuItem,
            this.databaseToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.newToolStripMenuItem.Text = "New";
            // 
            // oppenToolStripMenuItem
            // 
            this.oppenToolStripMenuItem.Name = "oppenToolStripMenuItem";
            this.oppenToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.oppenToolStripMenuItem.Text = "Oppen...";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.xMLToolStripMenuItem.Text = "XML";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDataToolStripMenuItem,
            this.saveDataToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // loadDataToolStripMenuItem
            // 
            this.loadDataToolStripMenuItem.Name = "loadDataToolStripMenuItem";
            this.loadDataToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.loadDataToolStripMenuItem.Text = "Load Data";
            this.loadDataToolStripMenuItem.Click += new System.EventHandler(this.loadDataToolStripMenuItem_Click);
            // 
            // saveDataToolStripMenuItem
            // 
            this.saveDataToolStripMenuItem.Name = "saveDataToolStripMenuItem";
            this.saveDataToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.saveDataToolStripMenuItem.Text = "Save Data";
            this.saveDataToolStripMenuItem.Click += new System.EventHandler(this.saveDataToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationInfoToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // applicationInfoToolStripMenuItem
            // 
            this.applicationInfoToolStripMenuItem.Name = "applicationInfoToolStripMenuItem";
            this.applicationInfoToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.applicationInfoToolStripMenuItem.Text = "Application info";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // AnimalMotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 1083);
            this.Controls.Add(this.grBoxAnimalSpec);
            this.Controls.Add(this.grBoxLitsResult);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AnimalMotel";
            this.Text = "Apu Animal Motel";
            this.grBoxLitsResult.ResumeLayout(false);
            this.grBoxLitsResult.PerformLayout();
            this.grBoxAnimalSpec.ResumeLayout(false);
            this.grBoxAnimalSpec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.grBoxAnimalSpecifications.ResumeLayout(false);
            this.grBoxAnimalSpecifications.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNoOfTeeth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDayInQuarantiner)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void saveAsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labAge;
        private System.Windows.Forms.Label labNameInListBox;
        private System.Windows.Forms.TextBox txbAge;
        private System.Windows.Forms.Label labCategory;
        private System.Windows.Forms.Label labAnimalObject;
        private System.Windows.Forms.Label labImportantInfo;
        private System.Windows.Forms.GroupBox grBoxLitsResult;
        private System.Windows.Forms.GroupBox grBoxAnimalSpec;
        private System.Windows.Forms.ListView listViewListOfRegisteredAnimals;
        private System.Windows.Forms.Button btnAddAnimal;
        private System.Windows.Forms.ListBox listBxGender;
        private System.Windows.Forms.ListBox listbxAnimalSpecies;
        private System.Windows.Forms.ListBox listBxCategori;
        private System.Windows.Forms.Label labGender;
        private System.Windows.Forms.TextBox labBxImportantInfo;
        private System.Windows.Forms.Label labSpecialData;

        private System.Windows.Forms.CheckBox chBoxAllAnimal;
        private System.Windows.Forms.GroupBox grBoxAnimalSpecifications;
        private System.Windows.Forms.TextBox tboxNoOfTeeth;
        private System.Windows.Forms.TextBox texBoxDaysInQuarantine;
        private System.Windows.Forms.CheckBox chBoxUnderQuarantine;
        private System.Windows.Forms.Label labDaysInGuarantie;
        private System.Windows.Forms.Label labNoOfTeeth;
        private System.Windows.Forms.TextBox listBxSpecialData;
        private System.Windows.Forms.Button btnLoadPicture;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.ErrorProvider errorPrName;
        private System.Windows.Forms.ErrorProvider errorProAge;
        private System.Windows.Forms.ErrorProvider errorNoOfTeeth;
        private System.Windows.Forms.ErrorProvider errorDayInQuarantiner;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oppenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationInfoToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDataToolStripMenuItem;
       
        private System.Windows.Forms.BindingSource animalBindingSource;
     
    }
}

