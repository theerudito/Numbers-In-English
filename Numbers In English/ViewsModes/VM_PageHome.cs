using MarcTron.Plugin;
using Microsoft.EntityFrameworkCore;
using NumbersInEnglish.ApplicationContextDB;
using NumbersInEnglish.Helpers;
using NumbersInEnglish.Models;
using NumbersInEnglish.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Color = System.Drawing.Color;

namespace NumbersInEnglish.ViewsModes
{
    public class VM_PageHome : BaseVM
    {
        #region Constructor

        private ApplicationContext_DB _dbContext = new ApplicationContext_DB();

        public VM_PageHome(INavigation navigation)
        {
            ThemeApp = LocalStorange.GetLocalStorange("theme");
            ColorFramePrincipal = Xamarin.Forms.Color.FromHex("333333");

            LabelPoints = 10;
            LabelTime = 99;

            if (ThemeApp == "Dark")
            {
                Theme();
            }
            else
            {
                Theme();
            }

            GenerateNumber();
            GenerateAnswers();
            Thema = Color.Black;

            Navigation = navigation;
        }

        #endregion Constructor

        #region Properties

        private string _themeApp;
        private ImageSource _imageTheme;
        private int _timeAppMax;
        private int _labelPoints;
        private int _labelTime;
        private Color _colorFramePrincipal;
        private string _numAleatory;
        private int _idNumber;
        private string _textFrame1;
        private string _textFrame2;
        private string _textFrame3;
        private string _textFrame4;
        private string _textFrame5;
        private string _textFrame6;
        private Color _colorFrame1;
        private Color _colorFrame2;
        private Color _colorFrame3;
        private Color _colorFrame4;
        private Color _colorFrame5;
        private Color _colorFrame6;
        private Color _theme;
        private bool _correct;
        private int _fontsice;
        private int _fontFrame;

        #endregion Properties

        #region Objects

        public ImageSource ImageTheme
        {
            get => _imageTheme;
            set => SetProperty(ref _imageTheme, value);
        }

        public bool Correct
        {
            get => _correct;
            set => SetProperty(ref _correct, value);
        }

        public int TimeAppMax
        {
            get => _timeAppMax;
            set => SetProperty(ref _timeAppMax, value);
        }

        public int LabelPoints
        {
            get => _labelPoints;
            set => SetProperty(ref _labelPoints, value);
        }

        public int LabelTime
        {
            get => _labelTime;
            set => SetProperty(ref _labelTime, value);
        }

        public Color ColorFramePrincipal
        {
            get => _colorFramePrincipal;
            set => SetProperty(ref _colorFramePrincipal, value);
        }

        public string NumAleatory
        {
            get => _numAleatory;
            set => SetProperty(ref _numAleatory, value);
        }

        public int IdNumber
        {
            get => _idNumber;
            set => SetProperty(ref _idNumber, value);
        }

        public string TextFrame1
        {
            get => _textFrame1;
            set => SetProperty(ref _textFrame1, value);
        }

        public string TextFrame2
        {
            get => _textFrame2;
            set => SetProperty(ref _textFrame2, value);
        }

        public string TextFrame3
        {
            get => _textFrame3;
            set => SetProperty(ref _textFrame3, value);
        }

        public string TextFrame4
        {
            get => _textFrame4;
            set => SetProperty(ref _textFrame4, value);
        }

        public string TextFrame5
        {
            get => _textFrame5;
            set => SetProperty(ref _textFrame5, value);
        }

        public string TextFrame6
        {
            get => _textFrame6;
            set => SetProperty(ref _textFrame6, value);
        }

        public Color ColorFrame1
        {
            get => _colorFrame1;
            set => SetProperty(ref _colorFrame1, value);
        }

        public Color ColorFrame2
        {
            get => _colorFrame2;
            set => SetProperty(ref _colorFrame2, value);
        }

        public Color ColorFrame3
        {
            get => _colorFrame3;
            set => SetProperty(ref _colorFrame3, value);
        }

        public Color ColorFrame4
        {
            get => _colorFrame4;
            set => SetProperty(ref _colorFrame4, value);
        }

        public Color ColorFrame5
        {
            get => _colorFrame5;
            set => SetProperty(ref _colorFrame5, value);
        }

        public Color ColorFrame6
        {
            get => _colorFrame6;
            set => SetProperty(ref _colorFrame6, value);
        }

        public Color Thema
        {
            get => _theme;
            set => SetProperty(ref _theme, value);
        }

        public string ThemeApp
        {
            get => _themeApp;
            set => SetProperty(ref _themeApp, value);
        }

        private int[] IdWordData = { 1, 2, 3, 4, 5, 6 };

        public int FontSice
        {
            get => _fontsice;
            set => SetProperty(ref _fontsice, value);
        }

        public int FontFrame
        {
            get => _fontFrame;
            set => SetProperty(ref _fontFrame, value);
        }


        #endregion Objects

        #region Methods

        public async void GenerateNumber()
        {
            var number = await _dbContext.Number.Where(x => x.IdNumber == RandomNumber.GetRandomNumber()).FirstOrDefaultAsync();

            StringLength(number.Number.ToString());

            NumAleatory = number.Number.ToString();

            IdNumber = number.IdNumber;
        }

        public void StringLength(string text)
        {
            if (text.Length == 3)
            {
                FontSice = 150;
            }
            else if (text.Length == 4)
            {
                FontSice = 120;
            }
            else if (text.Length == 5)
            {
                FontSice = 90;
            }
            else if (text.Length == 6)
            {
                FontSice = 80;
            }
            else
            {
                FontSice = 200;
            }
        }

        public async void GenerateAnswers()
        {
            List<int> dataRandom = RandomNumber.numAletory(5);

            var numberOne = await _dbContext.Number.Where(x => x.IdNumber == IdNumber).FirstOrDefaultAsync();
            var numberTwo = await _dbContext.Number.Where(x => x.IdNumber == dataRandom[0]).FirstOrDefaultAsync();
            var numberThree = await _dbContext.Number.Where(x => x.IdNumber == dataRandom[1]).FirstOrDefaultAsync();
            var numberFour = await _dbContext.Number.Where(x => x.IdNumber == dataRandom[2]).FirstOrDefaultAsync();
            var numberFive = await _dbContext.Number.Where(x => x.IdNumber == dataRandom[3]).FirstOrDefaultAsync();
            var numberSix = await _dbContext.Number.Where(x => x.IdNumber == dataRandom[4]).FirstOrDefaultAsync();

            FontSiceFrame(numberOne.Traduction.ToString(), numberOne.Traduction.ToString(), numberThree.Traduction.ToString(), numberFour.Traduction.ToString(), numberFive.Traduction.ToString(), numberSix.Traduction.ToString());

            var random = new Random();

            var numRandom = random.Next(1, 5);

            if (numRandom == 1)
            {
                TextFrame1 = numberOne.Traduction;
                TextFrame2 = numberTwo.Traduction;
                TextFrame3 = numberThree.Traduction;
                TextFrame4 = numberFour.Traduction;
                TextFrame5 = numberFive.Traduction;
                TextFrame6 = numberSix.Traduction;



                IdWordData[0] = IdNumber;

                ColorFrame1 = Xamarin.Forms.Color.FromHex("005DFF");
                ColorFrame2 = Color.Violet;
                ColorFrame3 = Xamarin.Forms.Color.FromHex("ADADAD"); ;
                ColorFrame4 = Color.Orange;
                ColorFrame5 = Color.Gold;
                ColorFrame6 = Color.Aqua;
            }
            else if (numRandom == 2)
            {
                TextFrame2 = numberOne.Traduction;
                TextFrame1 = numberTwo.Traduction;
                TextFrame3 = numberThree.Traduction;
                TextFrame4 = numberFour.Traduction;
                TextFrame5 = numberFive.Traduction;
                TextFrame6 = numberSix.Traduction;

                IdWordData[1] = IdNumber;

                ColorFrame4 = Xamarin.Forms.Color.FromHex("005DFF");
                ColorFrame1 = Color.Violet;
                ColorFrame5 = Xamarin.Forms.Color.FromHex("ADADAD"); ;
                ColorFrame6 = Color.Orange;
                ColorFrame2 = Color.Gold;
                ColorFrame3 = Color.Aqua;
            }
            else if (numRandom == 3)
            {
                TextFrame3 = numberOne.Traduction;
                TextFrame2 = numberTwo.Traduction;
                TextFrame1 = numberThree.Traduction;
                TextFrame4 = numberFour.Traduction;
                TextFrame5 = numberFive.Traduction;
                TextFrame6 = numberSix.Traduction;

                IdWordData[2] = IdNumber;

                ColorFrame3 = Xamarin.Forms.Color.FromHex("005DFF");
                ColorFrame1 = Color.Violet;
                ColorFrame2 = Xamarin.Forms.Color.FromHex("ADADAD");
                ColorFrame6 = Color.Orange;
                ColorFrame4 = Color.Gold;
                ColorFrame5 = Color.Aqua;
            }
            else if (numRandom == 4)
            {
                TextFrame4 = numberOne.Traduction;
                TextFrame2 = numberTwo.Traduction;
                TextFrame3 = numberThree.Traduction;
                TextFrame1 = numberFour.Traduction;
                TextFrame5 = numberFive.Traduction;
                TextFrame6 = numberSix.Traduction;

                IdWordData[3] = IdNumber;

                ColorFrame4 = Xamarin.Forms.Color.FromHex("005DFF");
                ColorFrame2 = Color.Violet;
                ColorFrame3 = Xamarin.Forms.Color.FromHex("ADADAD"); ;
                ColorFrame1 = Color.Orange;
                ColorFrame5 = Color.Gold;
                ColorFrame6 = Color.Aqua;
            }
            else if (numRandom == 5)
            {
                TextFrame3 = numberOne.Traduction;
                TextFrame5 = numberTwo.Traduction;
                TextFrame1 = numberThree.Traduction;
                TextFrame2 = numberFour.Traduction;
                TextFrame6 = numberFive.Traduction;
                TextFrame4 = numberSix.Traduction;

                IdWordData[4] = IdNumber;

                ColorFrame6 = Xamarin.Forms.Color.FromHex("005DFF");
                ColorFrame2 = Color.Violet;
                ColorFrame1 = Xamarin.Forms.Color.FromHex("ADADAD"); ;
                ColorFrame4 = Color.Orange;
                ColorFrame3 = Color.Gold;
                ColorFrame5 = Color.Aqua;
            }
            else if (numRandom == 6)
            {
                TextFrame2 = numberOne.Traduction;
                TextFrame4 = numberTwo.Traduction;
                TextFrame6 = numberThree.Traduction;
                TextFrame1 = numberFour.Traduction;
                TextFrame3 = numberFive.Traduction;
                TextFrame5 = numberSix.Traduction;

                IdWordData[5] = IdNumber;

                ColorFrame6 = Xamarin.Forms.Color.FromHex("005DFF");
                ColorFrame5 = Color.Violet;
                ColorFrame4 = Xamarin.Forms.Color.FromHex("939034"); ;
                ColorFrame3 = Color.Orange;
                ColorFrame2 = Color.Gold;
                ColorFrame1 = Color.Aqua;
            }
        }

        public void FontSiceFrame(string r1, string r2, string r3, string r4, string r5, string r6)
        {
            if (r1.Length >= 19 || r2.Length >= 19 || r3.Length >= 19 || r4.Length >= 19 || r5.Length >= 19 || r6.Length >= 19)
            {
                FontFrame = 10;
            }
            else if (r1.Length <= 8 || r2.Length <= 8 || r3.Length <= 8 || r4.Length <= 8 || r5.Length <= 8 || r6.Length <= 8)
            {
                FontFrame = 15;
            }
            else
            {
                FontFrame = 15;
            }
        }

        public async Task<Numbers> FetchData()
        {
            var query = await _dbContext.Number.Where(x => x.IdNumber == IdNumber).FirstOrDefaultAsync();
            return query;
        }

        public async void CheckFrameOne()
        {
            Numbers result = await FetchData();

            if (result.IdNumber == IdWordData[0])
            {
                ColorFrame1 = FrameCorrect();
                Correct = true;
                Points();
                GenerateNumber();
                AnswerCorrect();
                ColorDefault();
                await Task.Delay(500);
                GenerateAnswers();
            }
            else
            {
                ColorFrame1 = FrameInCorrect();
                AnswerInCorrect();
                Correct = false;
                Points();
            }
        }

        public async void CheckFrameTwo()
        {
            Numbers result = await FetchData();

            if (result.IdNumber == IdWordData[1])
            {
                ColorFrame2 = FrameCorrect();
                Correct = true;
                Points();
                GenerateNumber();
                AnswerCorrect();
                ColorDefault();
                await Task.Delay(500);
                GenerateAnswers();
            }
            else
            {
                Correct = false;
                Points();
                ColorFrame2 = FrameInCorrect();
                AnswerInCorrect();
            }
        }

        public async void CheckFrameThree()
        {
            Numbers result = await FetchData();

            if (result.IdNumber == IdWordData[2])
            {
                ColorFrame3 = FrameCorrect();
                Correct = true;
                Points();
                GenerateNumber();
                AnswerCorrect();
                ColorDefault();
                await Task.Delay(500);
                GenerateAnswers();
            }
            else
            {
                Correct = false;
                Points();
                ColorFrame3 = FrameInCorrect();
                AnswerInCorrect();
            }
        }

        public async void CheckFrameFour()
        {
            Numbers result = await FetchData();

            if (result.IdNumber == IdWordData[3])
            {
                Correct = true;
                Points();
                ColorFrame4 = FrameCorrect();
                GenerateNumber();
                AnswerCorrect();
                ColorDefault();
                await Task.Delay(500);
                GenerateAnswers();
            }
            else
            {
                Correct = false;
                ColorFrame4 = FrameInCorrect();
                AnswerInCorrect();
                Points();
            }
        }

        public async void CheckFrameFive()
        {
            Numbers result = await FetchData();

            if (result.IdNumber == IdWordData[4])
            {
                ColorFrame5 = FrameCorrect();
                Correct = true;
                Points();
                GenerateNumber();
                AnswerCorrect();
                ColorDefault();
                await Task.Delay(500);
                GenerateAnswers();
            }
            else
            {
                Correct = false;
                ColorFrame5 = FrameInCorrect();
                AnswerInCorrect();
                Points();
            }
        }

        public async void CheckFrameSix()
        {
            Numbers result = await FetchData();

            if (result.IdNumber == IdWordData[5])
            {
                ColorFrame6 = FrameCorrect();
                Correct = true;
                Points();
                GenerateNumber();
                AnswerCorrect();
                ColorDefault();
                await Task.Delay(500);
                GenerateAnswers();
            }
            else
            {
                Correct = false;
                ColorFrame6 = FrameInCorrect();
                AnswerInCorrect();
                Points();
            }
        }

        public async void ColorDefault()
        {
            await Task.Delay(500);
            ColorFramePrincipal = Xamarin.Forms.Color.FromHex("333333");
        }

        public void AnswerCorrect()
        {
            ColorFramePrincipal = FrameCorrect();
            SoundsApp.SoundCorrect();
        }

        public void AnswerInCorrect()
        {
            ColorFramePrincipal = FrameInCorrect();
            SoundsApp.SoundInCorrect();
        }

        public Color FrameCorrect()
        {
            return Color.GreenYellow;
        }

        public Color FrameInCorrect()
        {
            return Color.Red;
        }

        public void Points()
        {
            if (Correct == true)
            {
                LabelPoints++;
            }
            else
            {
                if (LabelPoints < 1) LabelPoints = 1;
                LabelPoints--;
            }
        }

        public void TimeApp()
        {
            //Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            //{
            //    if (TimeAppMax > 0)
            //    {
            //        TimeAppMax--;
            //        LabelTime = TimeAppMax;
            //    }
            //    else
            //    {
            //        TimeAppMax = 60;
            //        GenerateAnswers();
            //        GenerateNumber();
            //        Points();
            //        AnswerIncCorrect();
            //        ColorDefault();
            //        return false;
            //    }
            //    return true;
            //});
        }

        public async Task GoPageInfo()
        {
            //if (ValidationInternet.IsConnected())
            //{
            //    ShowInterstical();
            //    if (CrossMTAdmob.Current.IsInterstitialLoaded())
            //    {
            //        CrossMTAdmob.Current.ShowInterstitial();
            //        await Navigation.PushAsync(new Page_Info());
            //    }
            //}
            await Navigation.PushAsync(new Page_Info());
        }

        public void ShowInterstical()
        {
            var idIntersticial = "ca-app-pub-7633493507240683/9106078997";

            CrossMTAdmob.Current.LoadInterstitial(idIntersticial);
        }

        public void Theme()
        {
            ThemeApp = LocalStorange.GetLocalStorange("theme");

            if (ThemeApp == "Dark")
            {
                Thema = Xamarin.Forms.Color.FromHex("#000000");
                ImageTheme = ImageSource.FromFile("light.png");
                LocalStorange.SetLocalStorange("theme", "Light");
            }
            else
            {
                Thema = Xamarin.Forms.Color.FromHex("303345");
                ImageTheme = ImageSource.FromFile("dark.png");
                LocalStorange.SetLocalStorange("theme", "Dark");
            }
        }

        #endregion Methods

        #region Commands

        public ICommand bntCkeckCommandOne => new Command(CheckFrameOne);

        public ICommand bntCkeckCommandTwo => new Command(CheckFrameTwo);
        public ICommand bntCkeckCommandThree => new Command(CheckFrameThree);
        public ICommand bntCkeckCommandFour => new Command(CheckFrameFour);
        public ICommand bntCkeckCommandFive => new Command(CheckFrameFive);
        public ICommand bntCkeckCommandSix => new Command(CheckFrameSix);
        public ICommand bntGoPageInfoCommand => new Command(async () => await GoPageInfo());
        public ICommand bntThemeCommand => new Command(Theme);

        #endregion Commands
    }
}