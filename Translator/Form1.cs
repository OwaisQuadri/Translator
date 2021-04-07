using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Translation.V2;

namespace Translator
{
    public partial class Form1 : Form
    {
        TranslationClient client = TranslationClient.Create();
        public Form1()
        {
            InitializeComponent();
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
                case "Spanish":
                    code = LanguageCodes.Spanish;
                    break;
                case "Arabic":
                    code = LanguageCodes.Arabic;
                    break;
                case "Urdu":
                    code = LanguageCodes.Urdu;
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
