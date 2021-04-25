using System;
using System.Windows.Forms;
using Google.Cloud.Translation.V2;

namespace Translator
{
    
    public partial class Form1 : Form
    {
        
        TranslationClient client ;
        public Form1()
        {
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", "../../key.json");
            client = TranslationClient.Create();
            InitializeComponent();
            fromText.Select();
        }
        private void UpdateOutput()
        {
            string from_text = fromText.Text;
            string from_lang=getLanguageCode(fromLanguage.Text);
            string to_lang=getLanguageCode(toLanguage.Text);
            if (to_lang != from_lang)
            {
                toText.Text = client.TranslateText(from_text, to_lang, from_lang).TranslatedText;
            }
            else
            {
                toText.Text = from_text;
            }
                
        }
        private string getLanguageCode(string input)
        {
            string code = "";
            switch (input)
            {
                case "English":
                    code = LanguageCodes.English;
                    break;
                case "French":
                    code = LanguageCodes.French;
                    break;
                case "Arabic":
                    code = LanguageCodes.Arabic;
                    break;
                case "Urdu":
                    code = LanguageCodes.Urdu;
                    break;
                case "Afrikaans":
                    code = LanguageCodes.Afrikaans;
                    break;
                case "Albanian":
                    code = LanguageCodes.Albanian;
                    break;
                case "Amharic":
                    code = LanguageCodes.Amharic;
                    break;
                case "Armenian":
                    code = LanguageCodes.Armenian;
                    break;
                case "Azerbaijani":
                    code = LanguageCodes.Azerbaijani;
                    break;
                case "Basque":
                    code = LanguageCodes.Basque;
                    break;
                case "Belarusian":
                    code = LanguageCodes.Belarusian;
                    break;
                case "Bengali":
                    code = LanguageCodes.Bengali;
                    break;
                case "Bosnian":
                    code = LanguageCodes.Bosnian;
                    break;
                case "Bulgarian":
                    code = LanguageCodes.Bulgarian;
                    break;
                case "Catalan":
                    code = LanguageCodes.Catalan;
                    break;
                case "Cebuano":
                    code = LanguageCodes.Cebuano;
                    break;
                case "Chichewa":
                    code = LanguageCodes.Chichewa;
                    break;
                case "ChineseSimplified":
                    code = LanguageCodes.ChineseSimplified;
                    break;
                case "ChineseTraditional":
                    code = LanguageCodes.ChineseTraditional;
                    break;
                case "Corsican":
                    code = LanguageCodes.Corsican;
                    break;
                case "Croatian":
                    code = LanguageCodes.Croatian;
                    break;
                case "Czech":
                    code = LanguageCodes.Czech;
                    break;
                case "Danish":
                    code = LanguageCodes.Danish;
                    break;
                case "Dutch":
                    code = LanguageCodes.Dutch;
                    break;
                case "Esperanto":
                    code = LanguageCodes.Esperanto;
                    break;
                case "Estonian":
                    code = LanguageCodes.Estonian;
                    break;
                case "Filipino":
                    code = LanguageCodes.Filipino;
                    break;
                case "Finnish":
                    code = LanguageCodes.Finnish;
                    break;
                case "Frisian":
                    code = LanguageCodes.Frisian;
                    break;
                case "Galician":
                    code = LanguageCodes.Galician;
                    break;
                case "Georgian":
                    code = LanguageCodes.Georgian;
                    break;
                case "German":
                    code = LanguageCodes.German;
                    break;
                case "Greek":
                    code = LanguageCodes.Greek;
                    break;
                case "Gujarati":
                    code = LanguageCodes.Gujarati;
                    break;
                case "HaitianCreole":
                    code = LanguageCodes.HaitianCreole;
                    break;
                case "Hausa":
                    code = LanguageCodes.Hausa;
                    break;
                case "Hawaiian":
                    code = LanguageCodes.Hawaiian;
                    break;
                case "Hebrew":
                    code = LanguageCodes.Hebrew;
                    break;
                case "Hindi":
                    code = LanguageCodes.Hindi;
                    break;
                case "Hmong":
                    code = LanguageCodes.Hmong;
                    break;
                case "Hungarian":
                    code = LanguageCodes.Hungarian;
                    break;
                case "Icelandic":
                    code = LanguageCodes.Icelandic;
                    break;
                case "Igbo":
                    code = LanguageCodes.Igbo;
                    break;
                case "Indonesian":
                    code = LanguageCodes.Indonesian;
                    break;
                case "Irish":
                    code = LanguageCodes.Irish;
                    break;
                case "Italian":
                    code = LanguageCodes.Italian;
                    break;
                case "Japanese":
                    code = LanguageCodes.Japanese;
                    break;
                case "Javanese":
                    code = LanguageCodes.Javanese;
                    break;
                case "Kannada":
                    code = LanguageCodes.Kannada;
                    break;
                case "Kazakh":
                    code = LanguageCodes.Kazakh;
                    break;
                case "Khmer":
                    code = LanguageCodes.Khmer;
                    break;
                case "Korean":
                    code = LanguageCodes.Korean;
                    break;
                case "KurdishKurmanji":
                    code = LanguageCodes.KurdishKurmanji;
                    break;
                case "Kyrgyz":
                    code = LanguageCodes.Kyrgyz;
                    break;
                case "Lao":
                    code = LanguageCodes.Lao;
                    break;
                case "Latin":
                    code = LanguageCodes.Latin;
                    break;
                case "Latvian":
                    code = LanguageCodes.Latvian;
                    break;
                case "Lithuanian":
                    code = LanguageCodes.Lithuanian;
                    break;
                case "Luxembourgish":
                    code = LanguageCodes.Luxembourgish;
                    break;
                case "Macedonian":
                    code = LanguageCodes.Macedonian;
                    break;
                case "Malagasy":
                    code = LanguageCodes.Malagasy;
                    break;
                case "Malay":
                    code = LanguageCodes.Malay;
                    break;
                case "Malayalam":
                    code = LanguageCodes.Malayalam;
                    break;
                case "Maltese":
                    code = LanguageCodes.Maltese;
                    break;
                case "Maori":
                    code = LanguageCodes.Maori;
                    break;
                case "Marathi":
                    code = LanguageCodes.Marathi;
                    break;
                case "Mongolian":
                    code = LanguageCodes.Mongolian;
                    break;
                case "MyanmarBurmese":
                    code = LanguageCodes.MyanmarBurmese;
                    break;
                case "Nepali":
                    code = LanguageCodes.Nepali;
                    break;
                case "Norwegian":
                    code = LanguageCodes.Norwegian;
                    break;
                case "Pashto":
                    code = LanguageCodes.Pashto;
                    break;
                case "Persian":
                    code = LanguageCodes.Persian;
                    break;
                case "Polish":
                    code = LanguageCodes.Polish;
                    break;
                case "Portuguese":
                    code = LanguageCodes.Portuguese;
                    break;
                case "Punjabi":
                    code = LanguageCodes.Punjabi;
                    break;
                case "Romanian":
                    code = LanguageCodes.Romanian;
                    break;
                case "Russian":
                    code = LanguageCodes.Russian;
                    break;
                case "Samoan":
                    code = LanguageCodes.Samoan;
                    break;
                case "ScotsGaelic":
                    code = LanguageCodes.ScotsGaelic;
                    break;
                case "Serbian":
                    code = LanguageCodes.Serbian;
                    break;
                case "Sesotho":
                    code = LanguageCodes.Sesotho;
                    break;
                case "Shona":
                    code = LanguageCodes.Shona;
                    break;
                case "Sindhi":
                    code = LanguageCodes.Sindhi;
                    break;
                case "Sinhala":
                    code = LanguageCodes.Sinhala;
                    break;
                case "Slovak":
                    code = LanguageCodes.Slovak;
                    break;
                case "Slovenian":
                    code = LanguageCodes.Slovenian;
                    break;
                case "Somali":
                    code = LanguageCodes.Somali;
                    break;
                case "Spanish":
                    code = LanguageCodes.Spanish;
                    break;
                case "Sundanese":
                    code = LanguageCodes.Sundanese;
                    break;
                case "Swahili":
                    code = LanguageCodes.Swahili;
                    break;
                case "Swedish":
                    code = LanguageCodes.Swedish;
                    break;
                case "Tajik":
                    code = LanguageCodes.Tajik;
                    break;
                case "Tamil":
                    code = LanguageCodes.Tamil;
                    break;
                case "Telugu":
                    code = LanguageCodes.Telugu;
                    break;
                case "Thai":
                    code = LanguageCodes.Thai;
                    break;
                case "Turkish":
                    code = LanguageCodes.Turkish;
                    break;
                case "Ukrainian":
                    code = LanguageCodes.Ukrainian;
                    break;
                case "Uzbek":
                    code = LanguageCodes.Uzbek;
                    break;
                case "Vietnamese":
                    code = LanguageCodes.Vietnamese;
                    break;
                case "Welsh":
                    code = LanguageCodes.Welsh;
                    break;
                case "Xhosa":
                    code = LanguageCodes.Xhosa;
                    break;
                case "Yiddish":
                    code = LanguageCodes.Yiddish;
                    break;
                case "Yoruba":
                    code = LanguageCodes.Yoruba;
                    break;
                case "Zulu":
                    code = LanguageCodes.Zulu;
                    break;
            }
            return code;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateOutput();
        }
    }
}
