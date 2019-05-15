using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;
using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
using System.Windows.Threading;
using Microsoft.Win32;
using System.Windows.Interop;
using System.Windows.Forms;
using System.IO;


namespace Preview
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BackPriviewBtn_Click(object sender, RoutedEventArgs e)
        {
          //  View.Position -=new  TimeSpan(00,00,05);
        }

        private void BackPriviewBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
          //  View.Position -= new TimeSpan(00, 00, 02);

        }

        private void PlayPriviewBtn_Click(object sender, RoutedEventArgs e)
        {
            //  View.Play();
             Thread t = new Thread(delegate ()
             {
                  RecognizeSpeechAsync().Wait();

             });
              t.Start();
            Thread enter = new Thread(delegate ()
            {
               // Thread.Sleep(1000);
                SendKeys.Send("<ENTER>");
              //  SendKeys.Send("{ENTER}"); // отправка нажатия


            });
            axTimeLine.Play();
           
        }

        private void PausePriviewBtn_Click(object sender, RoutedEventArgs e)
        {
            axTimeLine.Pause();
            


        }

        private void NextPriviewBtn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void MutePriviewBtn_Click(object sender, RoutedEventArgs e)
        {
            /*
            double volum = View.Volume;
            bool on_off = true;
            if (on_off == false)
            {
                View.Volume = volum;
                on_off = true;
            }
            else 
            {
                View.Volume = 0;
                on_off = false;
            }
            */
          
        }

        public  async Task RecognizeSpeechAsync()
        {

            // Creates an instance of a speech config with specified subscription key and service region.
            // Replace with your own subscription key and service region (e.g., "westus").
            var config = SpeechConfig.FromSubscription("c14e2c4bf1ce4c5cb3baae64ffb4556d", "westus");


            var stopRecognition = new TaskCompletionSource<int>();
            
            // Creates a speech recognizer using file as audio input.
            // Replace with your own audio file name.
            using (var audioInput = AudioConfig.FromWavFileInput(@"E:\Marvel Studios Avengers Endgame - Official Trailer.wav"))
            {
                using (var recognizer = new SpeechRecognizer(config, audioInput))
                {
                    // Subscribes to events.
                   
                    recognizer.Recognizing += (s, e) =>
                    { 
                        RecognitionText.Dispatcher.Invoke((Action)(() =>
                        {
                            RecognitionText.Text =e.Result.Text;
                           // EditSub.Text += e.Result.Text;


                        }));

                       // RecognitionText.Text += e.Result.Text;
                        
                    };   

                    recognizer.Recognized += (s, e) =>
                    {

                        if (e.Result.Reason == ResultReason.RecognizedSpeech)
                        {
                            RecognitionText.Dispatcher.Invoke((Action)(() =>
                            {
                                RecognitionText.Text = e.Result.Text;
                            //EditSub.Text += e.Result.Text;

                            }));
                        }
                        else if (e.Result.Reason == ResultReason.NoMatch)
                        {
                            RecognitionText.Dispatcher.Invoke((Action)(() =>
                            {
                                RecognitionText.Text += " NOMATCH: Speech could not be recognized.";
                            }));
                            
                        }
                    };

                    recognizer.Canceled += (s, e) =>
                    {
                        RecognitionText.Dispatcher.Invoke((Action)(() =>
                        {
                            RecognitionText.Text = e.Result.Text;
                           // EditSub.Text += e.Result.Text;

                        }));

                        if (e.Reason == CancellationReason.Error)
                        {
                            RecognitionText.Dispatcher.Invoke((Action)(() =>
                            {
                                RecognitionText.Text += e.ErrorCode.ToString();
                                RecognitionText.Text += e.ErrorDetails;
                                RecognitionText.Text += "CANCELED: Did you update the subscription info?";
                            }));
                         
                        }

                        stopRecognition.TrySetResult(0);
                    };

                    recognizer.SessionStarted += (s, e) =>
                    {
                        //Sub.Text = "\n    Session started event.";
                    };

                    recognizer.SessionStopped += (s, e) =>
                    {
                        //Sub.Text ="\n    Session stopped event.";
                        //Sub.Text = "\n Stop recognition.";
                        //Sub.Text = "\n Stop recognition.";
                        stopRecognition.TrySetResult(0);
                    };

                    // Starts continuous recognition. Uses StopContinuousRecognitionAsync() to stop recognition.
                    await recognizer.StartContinuousRecognitionAsync().ConfigureAwait(false);

                    // Waits for completion.
                    // Use Task.WaitAny to keep the task rooted.
                    Task.WaitAny(new[] { stopRecognition.Task });

                    // Stops recognition.
                    await recognizer.StopContinuousRecognitionAsync().ConfigureAwait(false);
                    Thread.Sleep(70);

                }
            }

            // </recognitionContinuousWithFile>
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            IntPtr helper = new WindowInteropHelper(this).Handle;
            axTimeLine.SetPreviewWnd((int)PictureBox.Handle);
        }

        private void StopPriViewBtn_Click(object sender, RoutedEventArgs e)
        {
            axTimeLine.Stop();
        }

       

        private void Import_Click(object sender, RoutedEventArgs e)
        {
            float iduration;
            int iwidth;
            int iheight;
            float framerate;
            int videobitrate;
            int iaudiobitrate;
            int iaudiochannel;
            int audiosamplerate;
            int ivideostreamcount;
            int iaudiostreamcouunt;
            string strmediacontainer;
            string strvideostreamformat;
            string straudiostreamformat;

            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.Filter = "All Files (*.*)|*.*|mpg (*.mpg*.vob) | *.mpg;*.vob|avi (*.avi) | *.avi|Divx (*.divx) | *.divx|wmv (*.wmv)| *.wmv|QuickTime (*.mov)| *.mov|MP4 (*.mp4) | *.mp4|AVCHD (*.m2ts*.ts*.mts*m2t)|*.m2ts;*.ts;*.mts;*.m2t|wav (*.wav)|*.wav|MP3 (*.mp3)|*.mp3|WMA (*.wma)|*.wma||";
            if (openFileDialog.ShowDialog() == true)
            { 
                string strFile = openFileDialog.FileName;
                axTimeLine.GetMediaInfo(strFile, out iduration, out iwidth, out iheight, out framerate, out videobitrate, out iaudiobitrate, out iaudiochannel, out audiosamplerate, out ivideostreamcount,out iaudiostreamcouunt, out strmediacontainer, out strvideostreamformat, out straudiostreamformat);
                axTimeLine.SetVideoTrackResolution(iwidth, iheight);
                axTimeLine.AddVideoClip(1, strFile, 0, axTimeLine.GetMediaDuration(strFile), 0);
                axTimeLine.AddAudioClip(5, strFile, 0, axTimeLine.GetMediaDuration(strFile), 0,(float)1.0);

            }
        }

        private void Export_Click(object sender, RoutedEventArgs e)
        {
            ExportOptions export = new ExportOptions(axTimeLine);
            export.Show();
            
        }
    }
}
