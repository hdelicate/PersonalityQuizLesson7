using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PersonalityQuiz
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private string myStringProperty;
        public string MyStringProperty
        {
            get { return myStringProperty; }
            set
            {
                myStringProperty = value;
                OnPropertyChanged(nameof(MyStringProperty)); // Notify that there was a change on this property
            }
        }
        public int EmperorOfMan=0;
        public int Nurgal = 0;
        public int Lorgar = 0;
        public int Slaanesh = 0;
        public void OnButtonClicked1(object sender, EventArgs args)
        {
            EmperorOfMan+=2;
            Lorgar++;
            Nurgal--;
            Slaanesh--;
        }
        public void OnButtonClicked2(object sender, EventArgs args)
        {
            EmperorOfMan-=2;
            Lorgar--;
            Nurgal++;
            Slaanesh++;
        }
        public void OnButtonClicked3(object sender, EventArgs args)
        {
            EmperorOfMan++;
            Lorgar-=2;
            Nurgal--;
            Slaanesh--;
        }
        public void OnButtonClicked4(object sender, EventArgs args)
        {
            EmperorOfMan--;
            Lorgar+=2;
            Nurgal++;
            Slaanesh++;
        }
        public void OnButtonClicked5(object sender, EventArgs args)
        {
            EmperorOfMan-=2;
            Lorgar-=2;
            Nurgal-=2;
            Slaanesh += 2;
        }
        public void OnButtonClicked6(object sender, EventArgs args)
        {
            EmperorOfMan++;
            Lorgar++;
            Nurgal++;
            Slaanesh -= 2;
        }
        public void OnButtonClicked7(object sender, EventArgs args)
        {
            EmperorOfMan--;
            Lorgar--;
            Nurgal += 2;
            Slaanesh -= 2;
        }
        public void OnButtonClicked8(object sender, EventArgs args)
        {
            
            EmperorOfMan++;
            Lorgar++;
            Nurgal -= 2;
            Slaanesh += 2;
        }
        public void OnButtonClicked9(object sender, EventArgs args)
        {
            EmperorOfMan+=2;
            Lorgar++;
            Nurgal -= 2;
            Slaanesh -= 2;
        }
        public void OnButtonClicked10(object sender, EventArgs args)
        {

            EmperorOfMan-=2;
            Lorgar--;
            Nurgal +=2;
            Slaanesh += 2;
        }
        public void SubmitResults(object sender, EventArgs args)
        {
            var yourPersonality = "";
            if(EmperorOfMan>Lorgar && EmperorOfMan>Nurgal && EmperorOfMan > Slaanesh)
            {
                yourPersonality = "Your personality is closest to the Emperor of Mankind. After leading humanity to victory over the xenos, His son and greatest friend Horus betrayed Him in the Horus Heresy. After a fierce fight, He killed His son Horus but was mortally wounded in the process. His sacrifice saved humanity from eternal damnation at the hands of the warp. No longer is He merely the Emperor of Man, now he is revered as the God-Emperor. The faithful trillions of the Imperium cling to worshipping Him, as faith in Him is all that keeps them going against the horrors of Chaos and the sheer brutality of the Imperium";
            }
            if (Lorgar > EmperorOfMan && Lorgar > Nurgal && Lorgar > Slaanesh)
            {
                yourPersonality = "Your personality is closest to Lorgar, the primarch of the Word Bearers Legion. Once the most devout of the Emperors Primarch, he revered the Emperor as a God despite the Emperor's admonition not to. After being chastised by the Emperor, he abandoned his worship of the Emperor and turned to the dark Gods of the warp know collectively as Chaos. Every day thousands are sacrificed at his commanand to empower the warp and defeat those who still cling to the worship of the Emperor.";
            }
            if (Slaanesh > EmperorOfMan && Slaanesh > Nurgal && Slaanesh > Lorgar)
            {
                yourPersonality = "Your personality is closest to the dark God of pleasure, Slaanesh. Every temptation he posesses, and many a righteous warrior filled with faith in the God-Emperor has been turned astray by his machinations. Slaanesh Pleasure cult worm their way into the very core of the Imperium, eating away at it.";
            }
            if (Nurgal > EmperorOfMan && Nurgal > Slaanesh && Nurgal > Lorgar)
            {
                yourPersonality = "Your personality is closest to the Chaos God Nurgle. The God of disease and decay, he finds delight in infecting humanity with all sorts of horrible diseases. He works feverishely on creating diseases that will bring the Imperium to its knees and cause the most pain to the Imperium. He strangely takes a fatherly approach to his acolytes and test subjects, despite inflicting unimaginable horrors upon them.";
            }
            BindingContext = this;

            MyStringProperty = yourPersonality; 
        }
        void OnSwiped(object sender, SwipedEventArgs e)
        {
            _label.Text = $"You swiped: {e.Direction.ToString()}";
        }

    }
}
