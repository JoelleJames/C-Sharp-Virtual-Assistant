using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AI_personal_assistant_Csharp
{
    public partial class settingsForm : Form
    {
        public static settingsForm instance;

        private bool drag = false; // for the panelTop to be draggable
        private Point startPoint = new Point(0, 0); // for the panelTop to be draggable


        public settingsForm()
        {
            InitializeComponent();
            instance = this; //connecting to form 1

            this.topPanel.MouseDown += new MouseEventHandler(panel1_MouseDown); //making panelTop draggable
            this.topPanel.MouseUp += new MouseEventHandler(panel1_MouseUp);
            this.topPanel.MouseMove += new MouseEventHandler(panel1_MouseMove);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.drag)
            { // if we should be dragging it, we need to figure out some movement
                Point p1 = new Point(e.X, e.Y);
                Point p2 = this.PointToScreen(p1);
                Point p3 = new Point(p2.X - this.startPoint.X,
                                     p2.Y - this.startPoint.Y);
                this.Location = p3;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            this.drag = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            this.startPoint = e.Location;
            this.drag = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowVoiceActPage();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showNotesPage();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\User\Desktop\project_ref\cat noise.wav");
                player.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void settingsForm_Load(object sender, EventArgs e)
        {
            ShowSettingsHome();
        }

        private void clickHere1_Click(object sender, EventArgs e)
        {

        }

        private void arrow2_Click(object sender, EventArgs e)
        {

        }

        private void clickHere2_Click(object sender, EventArgs e)
        {

        }

        private void clickHere3_Click(object sender, EventArgs e)
        {

        }

        private void bigSettingsLabel_Click(object sender, EventArgs e)
        {
            ShowSettingsHome();
        }

        private void faq_Click(object sender, EventArgs e)
        {
            showFaqPage();
        }

        public void stopReadingButton_Click(object sender, EventArgs e)
        {
            Form1.instance.stopSpeaking();
        }

        private void notesBox_TextChanged(object sender, EventArgs e)
        {
            Form1.notes = notesBox.Text.ToString();
            Form1.instance.loadNotesGrammar();
        }

        public void newVoiceActLabel_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataCollectionDetails_Click(object sender, EventArgs e)
        {

        }

        private void insertNewVoiceA_TextChanged(object sender, EventArgs e)
        {
            currentVoiceAct.Text = insertNewVoiceA.Text; //text box changes label underneath
        }

        public void currentVoiceAct_TextChanged(object sender, EventArgs e)
        {
            Form1.voiceAct = currentVoiceAct.Text.ToString();//make label in voice activation settings page new voice activation command
            Form1.instance.loadActivationGrammar(); //load new voice activation command with method in form1
        }

        private void onCheck1_Click(object sender, EventArgs e)
        {
            Form1.instance.waitTimeOn();
            offCheck1.Checked = false;

        }

        private void offCheck1_Click(object sender, EventArgs e)
        {
            Form1.instance.waitTimeOff();
            onCheck1.Checked = false;
        }

        private void readNotesButton_Click(object sender, EventArgs e)
        {
            Form1.instance.sayNotes();
            Form1.instance.resumeSpeech();
        }

        private void pauseReadingButton_Click(object sender, EventArgs e)
        {
            Form1.instance.pauseSpeech();
        }
    }
}
