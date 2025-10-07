using System;


namespace AppJogoDaForca.Models
{
    public class Word
    {
        public String Tips { get; set; } = string.Empty;
        public String Text { get; set; } = string.Empty;



        public Word(string tips, string text)
        {
            Tips = tips;
            Text = text;
        }
    }

}

