
//using System;
//using System.Drawing;
//using System.Drawing.Drawing2D;
//using System.Drawing.Text;
//using System.Linq;


//namespace Dinazor.Services
//{
//    namespace CaptchaGenerator
//    {
//        public sealed class CaptchaProperties
//        {
//            private readonly CaptchaPropertiesFluentInterface _configure;
//            public CaptchaPropertiesFluentInterface Configure => _configure;


//            private readonly Color _default_background_color = Color.White;
//            public Color BackgroundColor { get; private set; }

//            private readonly int _default_characters = 5;
//            public int Characters { get; private set; }

//            private readonly Color _default_color_down_up_line = Color.Black;
//            public Color ColorDownUpLine { get; private set; }

//            private readonly Color _default_color_up_down_line = Color.Black;
//            public Color ColorUpDownLine { get; private set; }

//            private readonly bool _default_draw_down_up_line = false;
//            public bool DrawDownUpLine { get; private set; }

//            private readonly bool _default_draw_up_down_line = false;
//            public bool DrawUpDownLine { get; private set; }

//            private readonly Color _default_font_color = Color.Black;
//            public Color FontColor { get; private set; }

//            private readonly RandomCharactersType _default_random_characters = RandomCharactersType.All;
//            public RandomCharactersType RandomCharacters { get; private set; }

//            private readonly int _default_size_down_up_line = 2;
//            public int SizeDownUpLine { get; private set; }

//            private readonly int _default_size_up_down_line = 2;
//            public int SizeUpDownLine { get; private set; }

//            private readonly Font _default_font = new Font("Tahoma", 24);
//            public Font StringFont { get; private set; }


//            public CaptchaProperties()
//            {
//                _configure = new CaptchaPropertiesFluentInterface(this);

//                BackgroundColor = _default_background_color;
//                Characters = _default_characters;
//                ColorDownUpLine = _default_color_down_up_line;
//                ColorUpDownLine = _default_color_up_down_line;
//                DrawDownUpLine = _default_draw_down_up_line;
//                DrawUpDownLine = _default_draw_up_down_line;
//                FontColor = _default_font_color;
//                RandomCharacters = _default_random_characters;
//                SizeDownUpLine = _default_size_down_up_line;
//                SizeUpDownLine = _default_size_up_down_line;
//                StringFont = _default_font;
//            }

//            public class CaptchaPropertiesFluentInterface
//            {
//                private readonly CaptchaProperties _captchaProperties;

//                public CaptchaPropertiesFluentInterface(CaptchaProperties captchaProperties)
//                {
//                    _captchaProperties = captchaProperties;
//                }

//                public CaptchaProperties Get()
//                {
//                    return _captchaProperties;
//                }

//                public CaptchaPropertiesFluentInterface WithBackgroundColor(Color backgroundColor)
//                {
//                    _captchaProperties.BackgroundColor = backgroundColor;
//                    return this;
//                }

//                public CaptchaPropertiesFluentInterface WithCharacters(int characters)
//                {
//                    _captchaProperties.Characters = characters <= 0 || characters > 10 ? _captchaProperties._default_characters : characters;
//                    return this;
//                }

//                public CaptchaPropertiesFluentInterface WithColorDownUpLine(Color colorDownUpLine)
//                {
//                    _captchaProperties.ColorDownUpLine = colorDownUpLine;
//                    return this;
//                }

//                public CaptchaPropertiesFluentInterface WithColorUpDownLine(Color colorUpDownLine)
//                {
//                    _captchaProperties.ColorUpDownLine = colorUpDownLine;
//                    return this;
//                }

//                public CaptchaPropertiesFluentInterface WithDownUpLine(bool isVisible)
//                {
//                    _captchaProperties.DrawDownUpLine = isVisible;
//                    return this;
//                }

//                public CaptchaPropertiesFluentInterface WithUpDownLine(bool isVisible)
//                {
//                    _captchaProperties.DrawUpDownLine = isVisible;
//                    return this;
//                }

//                public CaptchaPropertiesFluentInterface WithRandomCharacters(RandomCharactersType randomCharactersType)
//                {
//                    _captchaProperties.RandomCharacters = randomCharactersType;
//                    return this;
//                }

//                public CaptchaPropertiesFluentInterface WithSizeDownUpLine(int size)
//                {
//                    _captchaProperties.SizeDownUpLine = size <= 0 || size > 10 ? _captchaProperties._default_size_down_up_line : size;
//                    return this;
//                }

//                public CaptchaPropertiesFluentInterface WithSizeUpDownLine(int size)
//                {
//                    _captchaProperties.SizeUpDownLine = size <= 0 || size > 10 ? _captchaProperties._default_size_up_down_line : size;
//                    return this;
//                }

//                public CaptchaPropertiesFluentInterface WithFont(Font stringFont)
//                {
//                    _captchaProperties.StringFont = stringFont;
//                    return this;
//                }

//                public CaptchaPropertiesFluentInterface WithFontColor(Color fontColor)
//                {
//                    _captchaProperties.FontColor = fontColor;
//                    return this;
//                }

//            }

//        }


//        public enum RandomCharactersType
//        {
//            All,
//            LowerCaseLetters,
//            LowerAndUpperCaseLetters,
//            LowerCaseLettersAndNumbers,
//            Numbers,
//            UpperCaseLetters,
//            UpperCaseLettersAndNumbers
//        }
//        public class Builder
//        {
//            private Random random = new Random((int)DateTime.Now.Ticks);

//            private const string LOWER_CASE_LETTERS = "abcdefghijklmnopqrstuvwyxz";
//            private const string NUMBERS = "0123456789";
//            private const string UPPER_CASE_LETTERS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

//            private string GetPattern(RandomCharactersType randomCharactersType)
//            {
//                var pattern = LOWER_CASE_LETTERS + UPPER_CASE_LETTERS + NUMBERS;

//                switch (randomCharactersType)
//                {
//                    case RandomCharactersType.LowerCaseLetters:
//                        pattern = LOWER_CASE_LETTERS;
//                        break;
//                    case RandomCharactersType.LowerAndUpperCaseLetters:
//                        pattern = LOWER_CASE_LETTERS + UPPER_CASE_LETTERS;
//                        break;
//                    case RandomCharactersType.LowerCaseLettersAndNumbers:
//                        pattern = LOWER_CASE_LETTERS + NUMBERS;
//                        break;
//                    case RandomCharactersType.Numbers:
//                        pattern = NUMBERS;
//                        break;
//                    case RandomCharactersType.UpperCaseLetters:
//                        pattern = UPPER_CASE_LETTERS;
//                        break;
//                    case RandomCharactersType.UpperCaseLettersAndNumbers:
//                        pattern = UPPER_CASE_LETTERS + NUMBERS;
//                        break;
//                    default:
//                        break;
//                }

//                return pattern;
//            }

//            private SizeF GetStringSize(string text, System.Drawing.Font stringFont)
//            {
//                var bitmap = new System.Drawing.Bitmap(1, 1);
//                var graphics = Graphics.FromImage(bitmap);

//                var stringSize = graphics.MeasureString(text, stringFont);

//                bitmap.Dispose();
//                graphics.Dispose();

//                return stringSize;
//            }

//            private string RandomString(int size, RandomCharactersType randomCharactersType)
//            {
//                var pattern = GetPattern(randomCharactersType);
//                var characters = Enumerable.Range(0, size).Select(x => pattern[random.Next(0, pattern.Length)]);

//                return new string(characters.ToArray());
//            }

//            public Tuple<Image, string> CreateImage(CaptchaProperties captchaProperties = null)
//            {
//                captchaProperties = captchaProperties == null ? new CaptchaProperties() : captchaProperties;

//                var text = RandomString(captchaProperties.Characters, captchaProperties.RandomCharacters);
//                var stringFont = captchaProperties.StringFont;

//                var stringSize = GetStringSize(text, stringFont);

//                var bitmap = new Bitmap(Convert.ToInt32(stringSize.Width), Convert.ToInt32(stringSize.Height));
//                var graphics = Graphics.FromImage(bitmap);

//                graphics.Clear(captchaProperties.BackgroundColor);

//                graphics.SmoothingMode = SmoothingMode.AntiAlias;
//                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
//                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
//                graphics.TextRenderingHint = TextRenderingHint.SingleBitPerPixelGridFit;

//                graphics.DrawString(text, stringFont, new SolidBrush(captchaProperties.FontColor), new PointF(0, 0));

//                if (captchaProperties.DrawDownUpLine)
//                    graphics.DrawLine(new Pen(captchaProperties.ColorDownUpLine, captchaProperties.SizeDownUpLine), 0.0F, stringSize.Height, stringSize.Width, 0.0F);

//                if (captchaProperties.DrawUpDownLine)
//                    graphics.DrawLine(new Pen(captchaProperties.ColorUpDownLine, captchaProperties.SizeUpDownLine), 0.0F, 0.0F, stringSize.Width, stringSize.Height);

//                graphics.Flush();

//                return new Tuple<Image, string>(bitmap, text);
//            }

//        }

//    }
