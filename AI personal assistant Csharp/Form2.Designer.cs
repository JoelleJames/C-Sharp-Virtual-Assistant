namespace AI_personal_assistant_Csharp
{
    partial class settingsForm
    {
       
        private System.ComponentModel.IContainer components = null;

        
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settingsForm));
            this.leftPanel = new System.Windows.Forms.Panel();
            this.bigSettingsLabel = new System.Windows.Forms.Label();
            this.catImage = new System.Windows.Forms.PictureBox();
            this.faq = new System.Windows.Forms.Button();
            this.notesPage = new System.Windows.Forms.Button();
            this.voiceActPage = new System.Windows.Forms.Button();
            this.topPanelLine = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.welcomeSettings = new System.Windows.Forms.Label();
            this.clickHere1 = new System.Windows.Forms.Label();
            this.clickHere2 = new System.Windows.Forms.Label();
            this.clickHere3 = new System.Windows.Forms.Label();
            this.voiceActTitle = new System.Windows.Forms.Label();
            this.onLabel = new System.Windows.Forms.Label();
            this.offLabel = new System.Windows.Forms.Label();
            this.arrow1 = new System.Windows.Forms.PictureBox();
            this.arrow2 = new System.Windows.Forms.PictureBox();
            this.arrow3 = new System.Windows.Forms.PictureBox();
            this.onOffLine = new System.Windows.Forms.PictureBox();
            this.onCheck1 = new System.Windows.Forms.CheckBox();
            this.offCheck1 = new System.Windows.Forms.CheckBox();
            this.onCheck2 = new System.Windows.Forms.CheckBox();
            this.offCheck2 = new System.Windows.Forms.CheckBox();
            this.longerWaitLabel = new System.Windows.Forms.Label();
            this.slowActivationLabel = new System.Windows.Forms.Label();
            this.newVoiceActLabel = new System.Windows.Forms.Label();
            this.currentVoiceActLabel = new System.Windows.Forms.Label();
            this.insertNewVoiceA = new System.Windows.Forms.TextBox();
            this.currentVoiceAct = new System.Windows.Forms.Label();
            this.notesBox = new System.Windows.Forms.RichTextBox();
            this.readNotesButton = new System.Windows.Forms.Button();
            this.stopReadingButton = new System.Windows.Forms.Button();
            this.pauseReadingButton = new System.Windows.Forms.Button();
            this.notesPageTitle = new System.Windows.Forms.Label();
            this.notesPageDetails = new System.Windows.Forms.Label();
            this.faqTitle = new System.Windows.Forms.Label();
            this.howToTitle = new System.Windows.Forms.Label();
            this.howToDetails = new System.Windows.Forms.Label();
            this.dataCollectionTitle = new System.Windows.Forms.Label();
            this.dataCollectionDetails = new System.Windows.Forms.Label();
            this.nicknamesTitle = new System.Windows.Forms.Label();
            this.nicknamesDetails = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onOffLine)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.leftPanel.Controls.Add(this.bigSettingsLabel);
            this.leftPanel.Controls.Add(this.catImage);
            this.leftPanel.Controls.Add(this.faq);
            this.leftPanel.Controls.Add(this.notesPage);
            this.leftPanel.Controls.Add(this.voiceActPage);
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(179, 451);
            this.leftPanel.TabIndex = 0;
            // 
            // bigSettingsLabel
            // 
            this.bigSettingsLabel.AutoSize = true;
            this.bigSettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigSettingsLabel.ForeColor = System.Drawing.SystemColors.Menu;
            this.bigSettingsLabel.Location = new System.Drawing.Point(19, 9);
            this.bigSettingsLabel.Name = "bigSettingsLabel";
            this.bigSettingsLabel.Size = new System.Drawing.Size(140, 37);
            this.bigSettingsLabel.TabIndex = 2;
            this.bigSettingsLabel.Text = "Settings";
            this.bigSettingsLabel.Click += new System.EventHandler(this.bigSettingsLabel_Click);
            // 
            // catImage
            // 
            this.catImage.Image = ((System.Drawing.Image)(resources.GetObject("catImage.Image")));
            this.catImage.Location = new System.Drawing.Point(35, 49);
            this.catImage.Name = "catImage";
            this.catImage.Size = new System.Drawing.Size(99, 86);
            this.catImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.catImage.TabIndex = 6;
            this.catImage.TabStop = false;
            this.catImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // faq
            // 
            this.faq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.faq.ForeColor = System.Drawing.SystemColors.Menu;
            this.faq.Location = new System.Drawing.Point(12, 284);
            this.faq.Name = "faq";
            this.faq.Size = new System.Drawing.Size(147, 55);
            this.faq.TabIndex = 4;
            this.faq.Text = "FAQ";
            this.faq.UseVisualStyleBackColor = true;
            this.faq.Click += new System.EventHandler(this.faq_Click);
            // 
            // notesPage
            // 
            this.notesPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notesPage.ForeColor = System.Drawing.SystemColors.Menu;
            this.notesPage.Location = new System.Drawing.Point(12, 223);
            this.notesPage.Name = "notesPage";
            this.notesPage.Size = new System.Drawing.Size(147, 55);
            this.notesPage.TabIndex = 3;
            this.notesPage.Text = "Notes page";
            this.notesPage.UseVisualStyleBackColor = true;
            this.notesPage.Click += new System.EventHandler(this.button3_Click);
            // 
            // voiceActPage
            // 
            this.voiceActPage.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.voiceActPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voiceActPage.ForeColor = System.Drawing.SystemColors.Menu;
            this.voiceActPage.Location = new System.Drawing.Point(12, 162);
            this.voiceActPage.Name = "voiceActPage";
            this.voiceActPage.Size = new System.Drawing.Size(147, 55);
            this.voiceActPage.TabIndex = 2;
            this.voiceActPage.Text = "Voice Activation and Commands";
            this.voiceActPage.UseVisualStyleBackColor = true;
            this.voiceActPage.Click += new System.EventHandler(this.button2_Click);
            // 
            // topPanelLine
            // 
            this.topPanelLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.topPanelLine.Location = new System.Drawing.Point(218, 28);
            this.topPanelLine.Name = "topPanelLine";
            this.topPanelLine.Size = new System.Drawing.Size(420, 4);
            this.topPanelLine.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.closeButton.Location = new System.Drawing.Point(605, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(23, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.topPanel.Location = new System.Drawing.Point(176, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(462, 28);
            this.topPanel.TabIndex = 2;
            // 
            // welcomeSettings
            // 
            this.welcomeSettings.AutoSize = true;
            this.welcomeSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.welcomeSettings.Location = new System.Drawing.Point(185, 72);
            this.welcomeSettings.Name = "welcomeSettings";
            this.welcomeSettings.Size = new System.Drawing.Size(256, 18);
            this.welcomeSettings.TabIndex = 3;
            this.welcomeSettings.Text = "Welcome to the settings section.";
            // 
            // clickHere1
            // 
            this.clickHere1.AutoSize = true;
            this.clickHere1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickHere1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.clickHere1.Location = new System.Drawing.Point(253, 181);
            this.clickHere1.Name = "clickHere1";
            this.clickHere1.Size = new System.Drawing.Size(512, 15);
            this.clickHere1.TabIndex = 4;
            this.clickHere1.Text = "Click here to set a new word for voice activation. Set listening length for comma" +
    "nds and more.";
            this.clickHere1.Click += new System.EventHandler(this.clickHere1_Click);
            // 
            // clickHere2
            // 
            this.clickHere2.AutoSize = true;
            this.clickHere2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickHere2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.clickHere2.Location = new System.Drawing.Point(253, 244);
            this.clickHere2.Name = "clickHere2";
            this.clickHere2.Size = new System.Drawing.Size(358, 15);
            this.clickHere2.TabIndex = 5;
            this.clickHere2.Text = "Click here for the notes page. Here you can make personal notes";
            this.clickHere2.Click += new System.EventHandler(this.clickHere2_Click);
            // 
            // clickHere3
            // 
            this.clickHere3.AutoSize = true;
            this.clickHere3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickHere3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.clickHere3.Location = new System.Drawing.Point(253, 305);
            this.clickHere3.Name = "clickHere3";
            this.clickHere3.Size = new System.Drawing.Size(514, 15);
            this.clickHere3.TabIndex = 6;
            this.clickHere3.Text = "Click here for Facts and Questions, including data collection information and a h" +
    "ow-to section.";
            this.clickHere3.Click += new System.EventHandler(this.clickHere3_Click);
            // 
            // voiceActTitle
            // 
            this.voiceActTitle.AutoSize = true;
            this.voiceActTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voiceActTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.voiceActTitle.Location = new System.Drawing.Point(185, 72);
            this.voiceActTitle.Name = "voiceActTitle";
            this.voiceActTitle.Size = new System.Drawing.Size(306, 18);
            this.voiceActTitle.TabIndex = 7;
            this.voiceActTitle.Text = "Voice Activation and Command settings";
            // 
            // onLabel
            // 
            this.onLabel.AutoSize = true;
            this.onLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.onLabel.Location = new System.Drawing.Point(511, 120);
            this.onLabel.Name = "onLabel";
            this.onLabel.Size = new System.Drawing.Size(25, 15);
            this.onLabel.TabIndex = 8;
            this.onLabel.Text = "On";
            // 
            // offLabel
            // 
            this.offLabel.AutoSize = true;
            this.offLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.offLabel.Location = new System.Drawing.Point(571, 120);
            this.offLabel.Name = "offLabel";
            this.offLabel.Size = new System.Drawing.Size(25, 15);
            this.offLabel.TabIndex = 9;
            this.offLabel.Text = "Off";
            // 
            // arrow1
            // 
            this.arrow1.Image = ((System.Drawing.Image)(resources.GetObject("arrow1.Image")));
            this.arrow1.Location = new System.Drawing.Point(180, 162);
            this.arrow1.Name = "arrow1";
            this.arrow1.Size = new System.Drawing.Size(67, 55);
            this.arrow1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrow1.TabIndex = 10;
            this.arrow1.TabStop = false;
            // 
            // arrow2
            // 
            this.arrow2.Image = ((System.Drawing.Image)(resources.GetObject("arrow2.Image")));
            this.arrow2.Location = new System.Drawing.Point(180, 223);
            this.arrow2.Name = "arrow2";
            this.arrow2.Size = new System.Drawing.Size(67, 55);
            this.arrow2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrow2.TabIndex = 11;
            this.arrow2.TabStop = false;
            this.arrow2.Click += new System.EventHandler(this.arrow2_Click);
            // 
            // arrow3
            // 
            this.arrow3.Image = ((System.Drawing.Image)(resources.GetObject("arrow3.Image")));
            this.arrow3.Location = new System.Drawing.Point(180, 284);
            this.arrow3.Name = "arrow3";
            this.arrow3.Size = new System.Drawing.Size(67, 55);
            this.arrow3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.arrow3.TabIndex = 12;
            this.arrow3.TabStop = false;
            // 
            // onOffLine
            // 
            this.onOffLine.Image = ((System.Drawing.Image)(resources.GetObject("onOffLine.Image")));
            this.onOffLine.Location = new System.Drawing.Point(542, 115);
            this.onOffLine.Name = "onOffLine";
            this.onOffLine.Size = new System.Drawing.Size(23, 126);
            this.onOffLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.onOffLine.TabIndex = 7;
            this.onOffLine.TabStop = false;
            // 
            // onCheck1
            // 
            this.onCheck1.AutoSize = true;
            this.onCheck1.Location = new System.Drawing.Point(521, 151);
            this.onCheck1.Name = "onCheck1";
            this.onCheck1.Size = new System.Drawing.Size(15, 14);
            this.onCheck1.TabIndex = 13;
            this.onCheck1.UseVisualStyleBackColor = true;
            this.onCheck1.Click += new System.EventHandler(this.onCheck1_Click);
            // 
            // offCheck1
            // 
            this.offCheck1.AutoSize = true;
            this.offCheck1.Location = new System.Drawing.Point(574, 150);
            this.offCheck1.Name = "offCheck1";
            this.offCheck1.Size = new System.Drawing.Size(15, 14);
            this.offCheck1.TabIndex = 14;
            this.offCheck1.UseVisualStyleBackColor = true;
            this.offCheck1.Click += new System.EventHandler(this.offCheck1_Click);
            // 
            // onCheck2
            // 
            this.onCheck2.AutoSize = true;
            this.onCheck2.Location = new System.Drawing.Point(521, 199);
            this.onCheck2.Name = "onCheck2";
            this.onCheck2.Size = new System.Drawing.Size(15, 14);
            this.onCheck2.TabIndex = 15;
            this.onCheck2.UseVisualStyleBackColor = true;
            // 
            // offCheck2
            // 
            this.offCheck2.AutoSize = true;
            this.offCheck2.Location = new System.Drawing.Point(574, 199);
            this.offCheck2.Name = "offCheck2";
            this.offCheck2.Size = new System.Drawing.Size(15, 14);
            this.offCheck2.TabIndex = 16;
            this.offCheck2.UseVisualStyleBackColor = true;
            // 
            // longerWaitLabel
            // 
            this.longerWaitLabel.AutoSize = true;
            this.longerWaitLabel.Location = new System.Drawing.Point(228, 152);
            this.longerWaitLabel.Name = "longerWaitLabel";
            this.longerWaitLabel.Size = new System.Drawing.Size(263, 13);
            this.longerWaitLabel.TabIndex = 17;
            this.longerWaitLabel.Text = "Make assistant wait longer for all commands to be said";
            // 
            // slowActivationLabel
            // 
            this.slowActivationLabel.AutoSize = true;
            this.slowActivationLabel.Location = new System.Drawing.Point(241, 200);
            this.slowActivationLabel.Name = "slowActivationLabel";
            this.slowActivationLabel.Size = new System.Drawing.Size(246, 13);
            this.slowActivationLabel.TabIndex = 18;
            this.slowActivationLabel.Text = "Set voice activation command to slow speech only";
            // 
            // newVoiceActLabel
            // 
            this.newVoiceActLabel.AutoSize = true;
            this.newVoiceActLabel.Location = new System.Drawing.Point(253, 292);
            this.newVoiceActLabel.Name = "newVoiceActLabel";
            this.newVoiceActLabel.Size = new System.Drawing.Size(237, 13);
            this.newVoiceActLabel.TabIndex = 7;
            this.newVoiceActLabel.Text = "Type here to set new voice activation command:";
            this.newVoiceActLabel.TextChanged += new System.EventHandler(this.newVoiceActLabel_TextChanged);
            // 
            // currentVoiceActLabel
            // 
            this.currentVoiceActLabel.AutoSize = true;
            this.currentVoiceActLabel.Location = new System.Drawing.Point(320, 320);
            this.currentVoiceActLabel.Name = "currentVoiceActLabel";
            this.currentVoiceActLabel.Size = new System.Drawing.Size(171, 13);
            this.currentVoiceActLabel.TabIndex = 8;
            this.currentVoiceActLabel.Text = "Current voice activation command:";
            // 
            // insertNewVoiceA
            // 
            this.insertNewVoiceA.Location = new System.Drawing.Point(505, 289);
            this.insertNewVoiceA.Name = "insertNewVoiceA";
            this.insertNewVoiceA.Size = new System.Drawing.Size(100, 20);
            this.insertNewVoiceA.TabIndex = 19;
            this.insertNewVoiceA.TextChanged += new System.EventHandler(this.insertNewVoiceA_TextChanged);
            // 
            // currentVoiceAct
            // 
            this.currentVoiceAct.AutoSize = true;
            this.currentVoiceAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentVoiceAct.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.currentVoiceAct.Location = new System.Drawing.Point(535, 320);
            this.currentVoiceAct.Name = "currentVoiceAct";
            this.currentVoiceAct.Size = new System.Drawing.Size(36, 13);
            this.currentVoiceAct.TabIndex = 20;
            this.currentVoiceAct.Text = "Hello";
            this.currentVoiceAct.TextChanged += new System.EventHandler(this.currentVoiceAct_TextChanged);
            // 
            // notesBox
            // 
            this.notesBox.Location = new System.Drawing.Point(201, 136);
            this.notesBox.Name = "notesBox";
            this.notesBox.Size = new System.Drawing.Size(404, 235);
            this.notesBox.TabIndex = 21;
            this.notesBox.Text = "";
            this.notesBox.TextChanged += new System.EventHandler(this.notesBox_TextChanged);
            // 
            // readNotesButton
            // 
            this.readNotesButton.Location = new System.Drawing.Point(246, 377);
            this.readNotesButton.Name = "readNotesButton";
            this.readNotesButton.Size = new System.Drawing.Size(100, 40);
            this.readNotesButton.TabIndex = 22;
            this.readNotesButton.Text = "Read Notes";
            this.readNotesButton.UseVisualStyleBackColor = true;
            this.readNotesButton.Click += new System.EventHandler(this.readNotesButton_Click);
            // 
            // stopReadingButton
            // 
            this.stopReadingButton.Location = new System.Drawing.Point(468, 377);
            this.stopReadingButton.Name = "stopReadingButton";
            this.stopReadingButton.Size = new System.Drawing.Size(100, 40);
            this.stopReadingButton.TabIndex = 23;
            this.stopReadingButton.Text = "Stop Reading";
            this.stopReadingButton.UseVisualStyleBackColor = true;
            this.stopReadingButton.Click += new System.EventHandler(this.stopReadingButton_Click);
            // 
            // pauseReadingButton
            // 
            this.pauseReadingButton.Location = new System.Drawing.Point(352, 377);
            this.pauseReadingButton.Name = "pauseReadingButton";
            this.pauseReadingButton.Size = new System.Drawing.Size(110, 40);
            this.pauseReadingButton.TabIndex = 24;
            this.pauseReadingButton.Text = "Pause Reading";
            this.pauseReadingButton.UseVisualStyleBackColor = true;
            this.pauseReadingButton.Click += new System.EventHandler(this.pauseReadingButton_Click);
            // 
            // notesPageTitle
            // 
            this.notesPageTitle.AutoSize = true;
            this.notesPageTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesPageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.notesPageTitle.Location = new System.Drawing.Point(185, 72);
            this.notesPageTitle.Name = "notesPageTitle";
            this.notesPageTitle.Size = new System.Drawing.Size(168, 18);
            this.notesPageTitle.TabIndex = 25;
            this.notesPageTitle.Text = "Personal Notes Page";
            // 
            // notesPageDetails
            // 
            this.notesPageDetails.AutoSize = true;
            this.notesPageDetails.Location = new System.Drawing.Point(185, 107);
            this.notesPageDetails.Name = "notesPageDetails";
            this.notesPageDetails.Size = new System.Drawing.Size(401, 13);
            this.notesPageDetails.TabIndex = 26;
            this.notesPageDetails.Text = "Here you can type your personal notes and the assistant will read them back to yo" +
    "u.";
            // 
            // faqTitle
            // 
            this.faqTitle.AutoSize = true;
            this.faqTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faqTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.faqTitle.Location = new System.Drawing.Point(185, 72);
            this.faqTitle.Name = "faqTitle";
            this.faqTitle.Size = new System.Drawing.Size(164, 18);
            this.faqTitle.TabIndex = 27;
            this.faqTitle.Text = "Facts and Questions";
            // 
            // howToTitle
            // 
            this.howToTitle.AutoSize = true;
            this.howToTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howToTitle.Location = new System.Drawing.Point(209, 152);
            this.howToTitle.Name = "howToTitle";
            this.howToTitle.Size = new System.Drawing.Size(55, 15);
            this.howToTitle.TabIndex = 28;
            this.howToTitle.Text = "How To";
            // 
            // howToDetails
            // 
            this.howToDetails.AutoSize = true;
            this.howToDetails.Location = new System.Drawing.Point(209, 187);
            this.howToDetails.Name = "howToDetails";
            this.howToDetails.Size = new System.Drawing.Size(371, 13);
            this.howToDetails.TabIndex = 29;
            this.howToDetails.Text = "How to use this virtual assistant including how to edit taught rules and names.";
            // 
            // dataCollectionTitle
            // 
            this.dataCollectionTitle.AutoSize = true;
            this.dataCollectionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataCollectionTitle.Location = new System.Drawing.Point(209, 242);
            this.dataCollectionTitle.Name = "dataCollectionTitle";
            this.dataCollectionTitle.Size = new System.Drawing.Size(105, 15);
            this.dataCollectionTitle.TabIndex = 30;
            this.dataCollectionTitle.Text = "Data Collection";
            // 
            // dataCollectionDetails
            // 
            this.dataCollectionDetails.AutoSize = true;
            this.dataCollectionDetails.Location = new System.Drawing.Point(209, 281);
            this.dataCollectionDetails.Name = "dataCollectionDetails";
            this.dataCollectionDetails.Size = new System.Drawing.Size(411, 13);
            this.dataCollectionDetails.TabIndex = 31;
            this.dataCollectionDetails.Text = "Here is some information on how your data is collected and what your data is used" +
    " for.";
            this.dataCollectionDetails.Click += new System.EventHandler(this.dataCollectionDetails_Click);
            // 
            // nicknamesTitle
            // 
            this.nicknamesTitle.AutoSize = true;
            this.nicknamesTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nicknamesTitle.Location = new System.Drawing.Point(209, 324);
            this.nicknamesTitle.Name = "nicknamesTitle";
            this.nicknamesTitle.Size = new System.Drawing.Size(78, 15);
            this.nicknamesTitle.TabIndex = 32;
            this.nicknamesTitle.Text = "Nicknames";
            // 
            // nicknamesDetails
            // 
            this.nicknamesDetails.AutoSize = true;
            this.nicknamesDetails.Location = new System.Drawing.Point(209, 361);
            this.nicknamesDetails.Name = "nicknamesDetails";
            this.nicknamesDetails.Size = new System.Drawing.Size(325, 13);
            this.nicknamesDetails.TabIndex = 33;
            this.nicknamesDetails.Text = "Here is some information on how nicknames work with this program.";
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(638, 450);
            this.Controls.Add(this.nicknamesDetails);
            this.Controls.Add(this.nicknamesTitle);
            this.Controls.Add(this.dataCollectionDetails);
            this.Controls.Add(this.dataCollectionTitle);
            this.Controls.Add(this.howToDetails);
            this.Controls.Add(this.howToTitle);
            this.Controls.Add(this.faqTitle);
            this.Controls.Add(this.notesPageDetails);
            this.Controls.Add(this.notesPageTitle);
            this.Controls.Add(this.pauseReadingButton);
            this.Controls.Add(this.stopReadingButton);
            this.Controls.Add(this.readNotesButton);
            this.Controls.Add(this.notesBox);
            this.Controls.Add(this.currentVoiceAct);
            this.Controls.Add(this.insertNewVoiceA);
            this.Controls.Add(this.newVoiceActLabel);
            this.Controls.Add(this.currentVoiceActLabel);
            this.Controls.Add(this.slowActivationLabel);
            this.Controls.Add(this.longerWaitLabel);
            this.Controls.Add(this.offCheck2);
            this.Controls.Add(this.onCheck2);
            this.Controls.Add(this.offCheck1);
            this.Controls.Add(this.onCheck1);
            this.Controls.Add(this.onOffLine);
            this.Controls.Add(this.arrow3);
            this.Controls.Add(this.arrow2);
            this.Controls.Add(this.arrow1);
            this.Controls.Add(this.onLabel);
            this.Controls.Add(this.offLabel);
            this.Controls.Add(this.voiceActTitle);
            this.Controls.Add(this.clickHere3);
            this.Controls.Add(this.clickHere2);
            this.Controls.Add(this.clickHere1);
            this.Controls.Add(this.welcomeSettings);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.topPanelLine);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "settingsForm";
            this.Text = "settingsForm";
            this.Load += new System.EventHandler(this.settingsForm_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onOffLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //always visible
        private System.Windows.Forms.Panel leftPanel; 
        private System.Windows.Forms.Panel topPanelLine; 
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button voiceActPage;
        private System.Windows.Forms.Button notesPage;
        private System.Windows.Forms.PictureBox catImage;
        private System.Windows.Forms.Button faq;
        private System.Windows.Forms.Label bigSettingsLabel;
        private System.Windows.Forms.Panel topPanel;

        // settings main page
        private System.Windows.Forms.Label welcomeSettings;
        private System.Windows.Forms.Label clickHere1;
        private System.Windows.Forms.Label clickHere2;
        private System.Windows.Forms.Label clickHere3;
        private System.Windows.Forms.PictureBox arrow1;
        private System.Windows.Forms.PictureBox arrow2;
        private System.Windows.Forms.PictureBox arrow3;

        // voice activation page
        private System.Windows.Forms.Label voiceActTitle;
        private System.Windows.Forms.Label onLabel;
        private System.Windows.Forms.Label offLabel;
        private System.Windows.Forms.PictureBox onOffLine;
        private System.Windows.Forms.CheckBox onCheck1;
        private System.Windows.Forms.CheckBox offCheck1;
        private System.Windows.Forms.CheckBox onCheck2;
        private System.Windows.Forms.CheckBox offCheck2;
        private System.Windows.Forms.Label longerWaitLabel;
        private System.Windows.Forms.Label slowActivationLabel;
        private System.Windows.Forms.Label newVoiceActLabel;
        private System.Windows.Forms.Label currentVoiceActLabel;
        private System.Windows.Forms.TextBox insertNewVoiceA;
        public System.Windows.Forms.Label currentVoiceAct;
        
        //notes page
        private System.Windows.Forms.RichTextBox notesBox;
        private System.Windows.Forms.Button readNotesButton;
        private System.Windows.Forms.Button stopReadingButton;
        private System.Windows.Forms.Button pauseReadingButton;
        private System.Windows.Forms.Label notesPageTitle;
        private System.Windows.Forms.Label notesPageDetails;

        //FAQ Page
        private System.Windows.Forms.Label faqTitle;
        private System.Windows.Forms.Label howToTitle;
        private System.Windows.Forms.Label howToDetails;
        private System.Windows.Forms.Label dataCollectionTitle;
        private System.Windows.Forms.Label dataCollectionDetails;
        private System.Windows.Forms.Label nicknamesTitle;
        private System.Windows.Forms.Label nicknamesDetails;

        public void settingsHomePageVisible()
        {
            welcomeSettings.Visible = true;
            clickHere1.Visible = true;
            clickHere2.Visible = true;
            clickHere3.Visible = true;
            arrow1.Visible = true;
            arrow2.Visible = true;
            arrow3.Visible = true;
        }

        public void voiceActPageVisible()
        {
            voiceActTitle.Visible = true;
            onLabel.Visible = true;
            offLabel.Visible = true;
            onOffLine.Visible = true;
            onCheck1.Visible = true;
            offCheck1.Visible = true;
            onCheck2.Visible = true;
            offCheck2.Visible = true;
            longerWaitLabel.Visible = true;
            slowActivationLabel.Visible = true;
            newVoiceActLabel.Visible = true;
            currentVoiceActLabel.Visible = true;
            insertNewVoiceA.Visible = true;
            currentVoiceAct.Visible = true;
        }

        public void notesPageVisible()
        {
            notesBox.Visible = true;
            readNotesButton.Visible = true;
            stopReadingButton.Visible = true;
            pauseReadingButton.Visible = true;
            notesPageTitle.Visible = true;
            notesPageDetails.Visible = true;
        }

        public void faqPageVisible()
        {
            faqTitle.Visible = true;
            howToTitle.Visible = true;
            howToDetails.Visible = true;
            dataCollectionTitle.Visible = true;
            dataCollectionDetails.Visible = true;
            nicknamesTitle.Visible = true;
            nicknamesDetails.Visible = true;
        }

        public void settingsHomePageInvisible()
        {
            welcomeSettings.Visible = false;
            clickHere1.Visible = false;
            clickHere2.Visible = false;
            clickHere3.Visible = false;
            arrow1.Visible = false;
            arrow2.Visible = false;
            arrow3.Visible = false;
        }

        public void voiceActPageInvisible()
        {
            voiceActTitle.Visible = false;
            onLabel.Visible = false;
            offLabel.Visible = false;
            onOffLine.Visible = false;
            onCheck1.Visible = false;
            offCheck1.Visible = false;
            onCheck2.Visible = false;
            offCheck2.Visible = false;
            longerWaitLabel.Visible = false;
            slowActivationLabel.Visible = false;
            newVoiceActLabel.Visible = false;
            currentVoiceActLabel.Visible = false;
            insertNewVoiceA.Visible = false;
            currentVoiceAct.Visible = false;
        }

        public void notesPageInvisible()
        {
            notesBox.Visible = false;
            readNotesButton.Visible = false;
            stopReadingButton.Visible = false;
            pauseReadingButton.Visible = false;
            notesPageTitle.Visible = false;
            notesPageDetails.Visible = false;
        }

        public void faqPageInvisible()
        {
            faqTitle.Visible = false;
            howToTitle.Visible = false;
            howToDetails.Visible = false;
            dataCollectionTitle.Visible = false;
            dataCollectionDetails.Visible = false;
            nicknamesTitle.Visible = false;
            nicknamesDetails.Visible = false;
        }

        public void ShowSettingsHome()
        {
            settingsHomePageVisible();
            voiceActPageInvisible();
            notesPageInvisible();
            faqPageInvisible();
        }

        public void ShowVoiceActPage()
        {
            voiceActPageVisible();
            settingsHomePageInvisible();
            notesPageInvisible();
            faqPageInvisible();
        }

        public void showNotesPage()
        {
            notesPageVisible();
            settingsHomePageInvisible();
            voiceActPageInvisible();
            faqPageInvisible();
        }

        public void showFaqPage()
        {
            faqPageVisible();
            settingsHomePageInvisible();
            voiceActPageInvisible();
            notesPageInvisible();
        }        
    }
}