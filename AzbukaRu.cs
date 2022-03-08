using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorzeConverter
{
    public class AzbukaRu
    {
        public List<Letter> letters = new List<Letter>()
        {
            new Letter("А", ".-"),
            new Letter("Б", "-..."),
            new Letter("В", ".--"),
            new Letter("Г", "--."),
            new Letter("Д", "-.."),
            new Letter("Е", "."),
            new Letter("Ж", "...-"),
            new Letter("З", "--.."),
            new Letter("И", ".."),
            new Letter("Й", ".---"),
            new Letter("К", "-.-"),
            new Letter("Л", ".-.."),
            new Letter("М", "--"),
            new Letter("Н", "-."),
            new Letter("О", "---"),
            new Letter("П", ".--."),
            new Letter("Р", ".-."),
            new Letter("С", "..."),
            new Letter("Т", "−"),
            new Letter("У", "..-"),
            new Letter("Ф", "..-."),
            new Letter("Х", "...."),
            new Letter("Ц", "-.-."),
            new Letter("Ч", "---."),
            new Letter("Ш", "----"),
            new Letter("Щ", "--.-"),
            new Letter("Ъ", "--.--"),
            new Letter("Ы", "-.--"),
            new Letter("Ь", "-..-"),
            new Letter("Э", "..-.."),
            new Letter("Ю", "..--"),
            new Letter("Я", ".-.-"),
            new Letter("1", ".----"),
            new Letter("2", "..---"),
            new Letter("3", "...--"),
            new Letter("4", "....-"),
            new Letter("5", "....."),
            new Letter("6", "-...."),
            new Letter("7", "--..."),
            new Letter("8", "---.."),
            new Letter("9", "----."),
            new Letter("0", "-----"),
            new Letter(".", "......"),
            new Letter(",", ".-.-.-"),
            new Letter(":", "---..."),
            new Letter(";", "-.-.-."),
            new Letter("()", "-.--.-"),
            new Letter("'", ".----."),
            new Letter("\"", ".- ..-."),
            new Letter("-", "-....-"),
            new Letter("/", "-..-."),
            new Letter("_", "..--.-"),
            new Letter("?", "..--.."),
            new Letter("!", "--..--"),
            new Letter("+", ".-.-."),
            new Letter("Знакраздела", "-...-"),
            new Letter("Ошибка/перебой", "........"),
            new Letter("@", ".--.-."),
            new Letter("Конецсвязи", "·..-.-"),
            new Letter(" ", " "),
            new Letter(" ", "SPASE")

        };
    }


    public class Letter
    {
        public string Value { get; set; }
        public string Code { get; set; }
        public Letter(string v, string c)
        {
            Value = v;
            Code = c;
        }
    }
}
