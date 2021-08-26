using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Timers;
//using Google.Cloud.Speech.V1;
//using Google.Cloud.Language.V1;
//using Google.Apis.Auth.OAuth2;
using NAudio.Mixer;
using NAudio.Wave;
//using Grpc.Auth;
//using Google.Protobuf.Collections;
using System.Device.Location;
using System.Media;

namespace AI_personal_assistant_Csharp
{


    public partial class Form1 : Form
    {
        public static Form1 instance; // creating an instance to connect forms

        SpeechRecognitionEngine recogEngine = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US"));

        // SpeechRecognitionEngine recogEngine = new SpeechRecognitionEngine(); //  speech recognition object
        SpeechSynthesizer catVoice = new SpeechSynthesizer(); // speech synthesizer object

        private bool drag = false; // for the panelTop to be draggable
        private Point startPoint = new Point(0, 0); // for the panelTop to be draggable

        private GeoCoordinateWatcher Watcher = null; //set watcher to null
        string localLat;
        string localLong;

        public static string voiceAct = "hello";

        public void loadActivationGrammar()
        {
            Choices newVoiceActive = new Choices();
            newVoiceActive.Add(voiceAct);
            GrammarBuilder g3Builder = new GrammarBuilder();
            g3Builder.Append(newVoiceActive);
            Grammar grammar3 = new Grammar(g3Builder);
            recogEngine.LoadGrammar(grammar3);

        }

        public static string notes = "";

        public void loadNotesGrammar()
        {
            Choices notesGrammar = new Choices();
            notesGrammar.Add(notes);
            GrammarBuilder g4Builder = new GrammarBuilder();
            g4Builder.Append(notesGrammar);
            Grammar grammar4 = new Grammar(g4Builder);
            recogEngine.LoadGrammar(grammar4);

        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")] // for rouded edges
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public Form1()
        {
            InitializeComponent();
            instance = this; //allows for connection between forms

            APIHelper.InitializeClient(); // initialize api client

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10)); // for the rounded edges

            this.panelTop.Location = this.Location; // to help set panelTop to top
            this.panelTop.Width = this.Width; // to help align panelTop to top
            this.closeButton.BringToFront(); // extra in case of error (no close button when there is an error on compiling the code is annoying)

            this.panelTop.MouseDown += new MouseEventHandler(panelTop_MouseDown); //making panelTop draggable
            this.panelTop.MouseUp += new MouseEventHandler(panelTop_MouseUp);
            this.panelTop.MouseMove += new MouseEventHandler(panelTop_MouseMove);

            


            NAudio.CoreAudioApi.MMDeviceEnumerator enumerator = new NAudio.CoreAudioApi.MMDeviceEnumerator();
            var devices = enumerator.EnumerateAudioEndPoints(NAudio.CoreAudioApi.DataFlow.All, NAudio.CoreAudioApi.DeviceState.Active);
            comboBox1.Items.AddRange(devices.ToArray());

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                var device = (NAudio.CoreAudioApi.MMDevice)comboBox1.SelectedItem;
                progressBar1.Value = (int)(Math.Round(device.AudioMeterInformation.MasterPeakValue * 100));
            }
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            Choices commands = new Choices();
            commands.Add(new string[] { "long speech", "introduce yourself", "show me your commands", "stop", "halt", "continue", "resume", "pause", "wait", "delete", "forget", "open google", "what's the weather", "show me your pants", "goodbye", "search for corvid breeders", "I have vocal Tourette's", "I have a stutter", "yes", "no", "call me your highness", "close", "play music" });
            GrammarBuilder gBuilder = new GrammarBuilder();
            gBuilder.Append(commands);
            Grammar grammar = new Grammar(gBuilder);

            Choices voiceActive = new Choices();
            voiceActive.Add(voiceAct);
            GrammarBuilder g2Builder = new GrammarBuilder();
            g2Builder.Append(voiceActive);
            Grammar grammar2 = new Grammar(g2Builder);


            //GrammarBuilder state = new GrammarBuilder();
            //state.Append(new Choices("on", "off"));
            //state.Culture = ri.Culture;
            //GrammarBuilder noun = new GrammarBuilder();
            //noun.Append(new Choices("lamp"));
            //noun.Culture = ri.Culture;
            //GrammarBuilder verb = new GrammarBuilder();
            //verb.Append(new Choices("turn"));
            //verb.Culture = ri.Culture;

            //GrammarBuilder grammar = new GrammarBuilder();
            //grammar.Append(verb);
            //grammar.Append(lamp);
            //grammar.Append(state);
            //Grammar g = new Grammar(grammar);

            catVoice.SelectVoiceByHints(VoiceGender.Female); // speech synthesizer customization
            catVoice.Rate = 3;

            // Create the watcher.
            Watcher = new GeoCoordinateWatcher();

            // Catch the StatusChanged event.
            Watcher.StatusChanged += Watcher_StatusChanged;

            // Start the watcher.
            Watcher.Start();

            if (catVoice.State == SynthesizerState.Speaking)
            {
                startBtn.Enabled = true;
            }

                try
            {
                recogEngine.RequestRecognizerUpdate();
                recogEngine.LoadGrammar(grammar);
                recogEngine.LoadGrammar(grammar2);
                recogEngine.SpeechRecognized += RecogEngine_SpeechRecognized;
                recogEngine.SetInputToDefaultAudioDevice();
                recogEngine.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch
            {
                return;
            }
        }

        public void Say(string phrase)
        {
            catVoice.SpeakAsync(phrase);
            wake = false;
            manualAct = false;
        }

        private bool wake = false;
        private bool manualAct = false;
        private bool speechDetect = false;
        private bool pauseMusicControl = false;

        private void StartBtn_Click(object sender, EventArgs e)
        {
            manualAct = true;
            startBtn.Enabled = false; //start unclickable

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\User\Desktop\project_ref\beep2.wav");
            player.Play();
        }


        private void stopBtn_Click(object sender, EventArgs e)
        {
            stopSpeaking();
            player.Stop();
            stopBtn.Enabled = false; // stop unclickable
        }

       // private static System.Timers.Timer commandTimer; // creating a timer for the user's time to give voice commands

        private void RecogEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            speechDetect = true;

            string speechSaid = e.Result.Text;
            catVoice.SpeakStarted += catVoice_SpeakStarted; // creating methods for 'stop talking' button
            catVoice.SpeakCompleted += catVoice_SpeakCompleted;


            if (manualAct == true || speechSaid == voiceAct)
            {
                richTextBox1.Text = String.Empty; //empties box
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\User\Desktop\project_ref\beep2.wav");
                player.Play();
                richTextBox1.Text += e.Result.Text;
                richTextBox1.Text += " <-- Voice activation detected!";

                

                wake = true;
                manualAct = false;

            }
            // setting a stopwatch for 10 seconds
            // Stopwatch stopWatch = new Stopwatch();
            //stopWatch.Start();
            //Thread.Sleep(10000); 
            // stopWatch.Stop();

            //if (stopWatch.IsRunning == true)
            // {
            if (wake) {
                switch (speechSaid)
                {
                    case "long speech":
                        
                        richTextBox1.SelectionColor = Color.ForestGreen;
                        richTextBox1.AppendText("You:  ");
                        richTextBox1.AppendText(e.Result.Text);               
                        richTextBox1.SelectionColor = Color.DeepPink;
                        richTextBox1.AppendText("\nCat:  ");
                        richTextBox1.AppendText("Hello. This is a long output text to show how the audio bar looks on the Virtual Assistant. The audio bar is above in green and is intended to add a smart look to this interface.");
                        Say("Hello. This is a long output text to show how the audio bar looks on the Virtual Assistant. The audio bar is above in green and is intended to add a smart look to this interface.");
                        break;

                    case "introduce yourself":
                        richTextBox1.SelectionColor = Color.ForestGreen;
                        richTextBox1.AppendText("\nYou:  ");
                        richTextBox1.AppendText(e.Result.Text);
                        richTextBox1.SelectionColor = Color.DeepPink;
                        richTextBox1.AppendText("\nCat:  ");
                        richTextBox1.AppendText("Hello, I am a C# assistant made for Joelle's Master's project. Joelle told me that I often get her speech wrong which made me sad, but she said that I am essential for her study on user embarrassment, so I guess my existence isn't meaningless after all.");
                        Say("Hello, I am a see sharp assistant made for Joelle's Master's project. Joelle told me that I often get her speech wrong which made me sad, but she said that I am essential for her study on user embarrassment, so I guess my existence isn't meaningless after all.");
                        break;

                    case "stop":
                        richTextBox1.SelectionColor = Color.ForestGreen;
                        richTextBox1.AppendText("\nYou:  ");
                        richTextBox1.AppendText(e.Result.Text);
                        richTextBox1.SelectionColor = Color.DeepPink;
                        richTextBox1.AppendText("\nCat:  ");
                        richTextBox1.AppendText("Stopping");
                        Say("Stopping");
                        stopSpeaking();
                        player.Stop();
                        break;

                    case "halt":
                        richTextBox1.SelectionColor = Color.ForestGreen;
                        richTextBox1.AppendText("\nYou:  ");
                        richTextBox1.AppendText(e.Result.Text);
                        richTextBox1.SelectionColor = Color.DeepPink;
                        richTextBox1.AppendText("\nCat:  ");
                        richTextBox1.AppendText("Stopping...");
                        stopSpeaking();
                        break;

                    case "continue":
                        richTextBox1.SelectionColor = Color.ForestGreen;
                        richTextBox1.AppendText("\nYou:  ");
                        richTextBox1.AppendText(e.Result.Text);
                        richTextBox1.SelectionColor = Color.DeepPink;
                        richTextBox1.AppendText("\nCat:  ");
                        richTextBox1.AppendText("Contining...");
                        catVoice.Resume();
                        break;

                    case "resume":
                        richTextBox1.SelectionColor = Color.ForestGreen;
                        richTextBox1.AppendText("\nYou:  ");
                        richTextBox1.AppendText(e.Result.Text);
                        richTextBox1.SelectionColor = Color.DeepPink;
                        richTextBox1.AppendText("\nCat:  ");
                        richTextBox1.AppendText("Contining...");
                        catVoice.Resume();
                        break;

                    case "pause":
                        richTextBox1.SelectionColor = Color.ForestGreen;
                        richTextBox1.AppendText("\nYou:  ");
                        richTextBox1.AppendText(e.Result.Text);
                        richTextBox1.SelectionColor = Color.DeepPink;
                        richTextBox1.AppendText("\nCat:  ");
                        richTextBox1.AppendText("Pawsing...");
                        pauseSpeech();
                        pauseMusicControl = false;
                        pauseIndex++;
                        break;

                    case "wait":
                        richTextBox1.SelectionColor = Color.ForestGreen;
                        richTextBox1.AppendText("\nYou:  ");
                        richTextBox1.AppendText(e.Result.Text);
                        richTextBox1.SelectionColor = Color.DeepPink;
                        richTextBox1.AppendText("\nCat:  ");
                        richTextBox1.AppendText("Pawsing...");
                        pauseSpeech();
                        break;

                    case "delete":
                        richTextBox1.SelectionColor = Color.ForestGreen;
                        richTextBox1.AppendText("\nYou:  ");
                        richTextBox1.AppendText(e.Result.Text);
                        richTextBox1.SelectionColor = Color.DeepPink;
                        richTextBox1.AppendText("\nCat:  ");
                        richTextBox1.AppendText("My queue was deleted, let's start again.");
                        catVoice.SpeakAsyncCancelAll();
                        break;

                    case "forget":
                        richTextBox1.SelectionColor = Color.ForestGreen;
                        richTextBox1.AppendText("\nYou:  ");
                        richTextBox1.AppendText(e.Result.Text);
                        richTextBox1.SelectionColor = Color.DeepPink;
                        richTextBox1.AppendText("\nCat:  ");
                        richTextBox1.AppendText("Ok, let's start again.");
                        catVoice.SpeakAsyncCancelAll();
                        break;

                    case ("open google"):
                        richTextBox1.SelectionColor = Color.ForestGreen;
                        richTextBox1.AppendText("\nYou:  ");
                        richTextBox1.AppendText(e.Result.Text);
                        richTextBox1.SelectionColor = Color.DeepPink;
                        richTextBox1.AppendText("\nCat:  ");
                        richTextBox1.AppendText("Opening Google...");
                        Say("opening google");
                        Process.Start("https://www.google.com");
                        break;

                    case ("what's the weather"):
                        richTextBox1.SelectionColor = Color.ForestGreen;
                        richTextBox1.AppendText("\nYou:  ");
                        richTextBox1.AppendText(e.Result.Text);
                        richTextBox1.SelectionColor = Color.DeepPink;
                        richTextBox1.AppendText("\nCat:  ");
                        richTextBox1.AppendText("opening the weather api. Feature currently not working due to the device's longitude and latitude not converting to the url string.");
                        Say("opening the weather api. Feature currently not working due to the device's longitude and latitude not converting to the url string.");
                        Process.Start($"https://api.openweathermap.org/data/2.5/onecall?lat=&lon=units=metric&exclude=hourly,daily&appid=768d94f6478d5692721b50548e57b83e");
                        break;

                    case ("show me your pants"):
                        richTextBox1.SelectionColor = Color.ForestGreen;
                        richTextBox1.AppendText("\nYou:  ");
                        richTextBox1.AppendText(e.Result.Text);
                        richTextBox1.SelectionColor = Color.DeepPink;
                        richTextBox1.AppendText("\nCat:  ");
                        richTextBox1.AppendText("Please don't ask me that.");
                        Process.Start("https://http.cat/401");
                        break;

                    case "show me your commands":
                        richTextBox1.SelectionColor = Color.ForestGreen;
                        richTextBox1.AppendText("\nYou:  ");
                        richTextBox1.AppendText(e.Result.Text);
                        richTextBox1.SelectionColor = Color.DeepPink;
                        richTextBox1.AppendText("\nCat:  ");
                        richTextBox1.AppendText("Ok. Opening up a list of commands for you to choose from.");
                        Say("Okay. Opening up a list of commands for you to choose from.");
                        MessageBox.Show("hello\nlong speech\nsay hello\nwhat's my name\nintroduce yourself\nshow list of commands\nstop\nhalt\ncontinue\nresume\npause\ndelete\nforget\nopen google\nwhat's the weather\nshow me your panties\ngoodbye\nsearch for corvid breeders\nI have vocal Tourette's\nI have a stutter\nclose\nplay music");
                        break;

                    case ("goodbye"):
                        richTextBox1.SelectionColor = Color.ForestGreen;
                        richTextBox1.AppendText("You:  ");
                        richTextBox1.AppendText(e.Result.Text);
                        richTextBox1.SelectionColor = Color.DeepPink;
                        richTextBox1.AppendText("\nCat:  ");
                        richTextBox1.AppendText("Goodbye.");
                        Say("Goodbye");
                        wake = false;
                        return;

                    case ("search for corvid breeders"):
                        richTextBox1.SelectionColor = Color.ForestGreen;
                        richTextBox1.AppendText("You:  ");
                        richTextBox1.AppendText(e.Result.Text);
                        richTextBox1.SelectionColor = Color.DeepPink;
                        richTextBox1.AppendText("\nCat:  ");
                        richTextBox1.AppendText("Ok. Searching Google for corvid breeders.");
                        Say("Ok. Searching Google for corvid breeders.");
                        Process.Start("https://www.google.com/search?q=corvid+breeders");
                        break;

                    case ("I have vocal Tourette's"):
                        richTextBox1.SelectionColor = Color.ForestGreen;
                        richTextBox1.AppendText("You:  ");
                        richTextBox1.AppendText(e.Result.Text);
                        richTextBox1.SelectionColor = Color.DeepPink;
                        richTextBox1.AppendText("\nCat:  ");
                        richTextBox1.AppendText("I am opening up the voice activation and command settings page. May I recommend setting a new voice activation command.");
                        Say("I am opening up the voice activation and command settings page. May I recommend setting a new voice activation command.");
                        openVoiceAct();
                        break;

                    case ("I have a stutter"):
                        richTextBox1.SelectionColor = Color.ForestGreen;
                        richTextBox1.AppendText("You:  ");
                        richTextBox1.AppendText(e.Result.Text);
                        richTextBox1.SelectionColor = Color.DeepPink;
                        richTextBox1.AppendText("\nCat:  ");
                        richTextBox1.AppendText("I am opening up the voice activation and command settings page. You have the option to set a long wait time for commands.");
                        Say("I am opening up the voice activation and command settings page. You have the option to set a long wait time for commands.");
                        openVoiceAct();
                        break;

                    case ("play music"):
                        richTextBox1.SelectionColor = Color.ForestGreen;
                        richTextBox1.AppendText("You:  ");
                        richTextBox1.AppendText(e.Result.Text);
                        richTextBox1.SelectionColor = Color.DeepPink;
                        richTextBox1.AppendText("\nCat:  ");
                        richTextBox1.AppendText("OK, playing music...");
                        Say("Ok, playing music.");
                        playRandomMusic();
                        break;

                    case ("call me your highness"):
                        richTextBox1.SelectionColor = Color.ForestGreen;
                        richTextBox1.AppendText("You:  ");
                        richTextBox1.AppendText(e.Result.Text);
                        richTextBox1.SelectionColor = Color.DeepPink;
                        richTextBox1.AppendText("\nCat:  ");                        
                        string[] nicknameResponses = { "Ok, you are your highness.", "Yes, your highness", "Your highness. I like this name." };
                        Random rndNicknameResp = new Random();
                        int rndNum = rndNicknameResp.Next(nicknameResponses.Length);                        
                        richTextBox1.AppendText(nicknameResponses[rndNum]);
                        Say(nicknameResponses[rndNum]);
                        break;

                    case ("yes"):
                        confirmation = true;
                        break;

                    case ("close"):
                        richTextBox1.SelectionColor = Color.ForestGreen;
                        richTextBox1.AppendText("You:  ");
                        richTextBox1.AppendText(e.Result.Text);
                        richTextBox1.SelectionColor = Color.DeepPink;
                        richTextBox1.AppendText("\nCat:  ");
                        richTextBox1.AppendText("Closing...");
                        this.Close();
                        break;

                }

                } // end of switch for commands
               // }
               // else
               // {
               //     wake = false;
               //     richTextBox1.Text += "\nasleep";
               // }
             // end of if(wake)
        }

        private bool confirmation = false;

        public void pauseSpeech()
        {
            catVoice.Pause();
        }

        public void resumeSpeech()
        {
            catVoice.Resume();
        }

        public void sayNotes()
        {
            Say("Are you sure");
            Say(notes);
            
            
        }

        private void catVoice_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            stopBtn.Enabled = false;
        }

        private void catVoice_SpeakStarted(object sender, SpeakStartedEventArgs e)
        {
            stopBtn.Enabled = true;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // the following code for automatically scrolling the text bar
            richTextBox1.SelectionStart = richTextBox1.Text.Length; // to set to the bottom of the text bar 
            richTextBox1.ScrollToCaret(); // scroll automatically
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close(); // closes application (both forms)
        }

        void panelTop_MouseUp(object sender, MouseEventArgs e)
        {
            this.drag = false;
        }

        void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            this.startPoint = e.Location;
            this.drag = true;
        }

        void panelTop_MouseMove(object sender, MouseEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void pictureBox2_Click(object sender, EventArgs e)
        {
            settingsForm frm = new settingsForm(); //create the settings form
            frm.Show(); // show the settings form
            

        }

        private void Watcher_StatusChanged(object sender, GeoPositionStatusChangedEventArgs e)
        {
            if (e.Status == GeoPositionStatus.Ready)
            {
                // Display the latitude and longitude.
                if (Watcher.Position.Location.IsUnknown)
                {
                    MessageBox.Show("Cannot find location data");
                }
                else
                {
                    GeoCoordinate location =
                        Watcher.Position.Location;
                    localLat = location.Latitude.ToString();
                    localLong = location.Longitude.ToString();
                }
            }
        }

        public void stopSpeaking()
        {
            if (catVoice.State == SynthesizerState.Speaking)
            {
                catVoice.SpeakAsyncCancelAll();
            }
        }

        public void openVoiceAct()
        {
            settingsForm frm = new settingsForm();
            frm.Show();
            frm.ShowVoiceActPage();
        }

        SoundPlayer player = new SoundPlayer();

        public void playRandomMusic()
        {
            // List of files from directory, sorted by *.wav type.
            string[] filePaths = Directory.GetFiles(@"C:\Users\User\Desktop\project_ref\music", "*.wav", SearchOption.AllDirectories);

            // Random number from 0 to the amount of files you have
            Random rnd = new Random(System.Guid.NewGuid().GetHashCode());
            int choices = rnd.Next(filePaths.Length);

            // Create a new player with a random filepath from the array
            player.SoundLocation = filePaths[choices];
            player.Play();

            if (pauseMusicControl == true)
            {
                player.Stop();
            }
            
            switch (pauseIndex)
            {
                case 0:

                    break;

                case 1:

                    break;

                case 2:

                    break;
            }
        }

        public void waitTimeOn()
        {
            recogEngine.EndSilenceTimeout = TimeSpan.FromSeconds(2);
            recogEngine.EndSilenceTimeoutAmbiguous = TimeSpan.FromSeconds(3);
        }

        public void waitTimeOff()
        {
            recogEngine.EndSilenceTimeout = TimeSpan.FromSeconds(0);
            recogEngine.EndSilenceTimeoutAmbiguous = TimeSpan.FromSeconds(0);
        }

        private System.Timers.Timer aTimerForMusic;

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            aTimerForMusic = new System.Timers.Timer(20000);
            aTimerForMusic.AutoReset = true;
            aTimerForMusic.Enabled = true;
        }

        private int pauseIndex = 0;
        

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pauseIndex--;
        }
    } // end of Form1 : Form
}
