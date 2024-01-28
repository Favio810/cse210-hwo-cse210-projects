using System;
using System.Collections.Generic;

public class Scripture
{
    private string _scripture1;
    private string _text1;

    List<int> RandomNumb = new List<int>();
    List<int> contNumbers = new List<int>();

    public Scripture()
    {
        _text1 = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life";
    }
    public string GetScriptureString()
    {
        string text = $"{_text1}";
        return text;
    }
    public string GetNewText()
    {
        string text = $"{_text1}";
        var newText = text.Replace("God", "_");
        return newText;
    }
    public string GetNewText2()
    {
        string text = $"{_text1}";
        string text2 = text.Replace(",", "");
        string text3 = text2.Replace(".", "");
        List<string> tokens = text3.Split(" ").ToList();
        string wordsList = String.Join(", ", tokens);
        return wordsList;
    }
    public int GetNumberOfElements()
    {
        string text = $"_text1";
        string myText = GetNewText2();
        string myText1 = myText.Replace(" ", "");
        char del = ',';
        string[] values = myText1.Split(del);
        int wordQuant = values.Count();
        return wordQuant;
    }
    public int sortNumber()
    {
        int aNumber = GetNumberOfElements();
        Random myNumber = new Random();
        int ranNumb = myNumber.Next(1, aNumber);
        return ranNumb;
    }
    public string threeNumbers()
    {
        int i;
        for (i=1; i<50; i++)
        {
            int myRandomNumb = sortNumber();
            if(!RandomNumb.Contains(myRandomNumb))
            {
                RandomNumb.Add(myRandomNumb);
            }
        }
        return String.Join(", ", RandomNumb);
    }
    public string wordSort()
    {
        var aNumber = RandomNumb[0];
        var bNumber = RandomNumb[1];
        var cNumber = RandomNumb[2];
        string text = _text1;

        string myText = GetNewText2();
        string myText1 = myText.Replace(" ", "");
        char del = ',';
        string[] values = myText1.Split(del);
        string first = values[aNumber];
        string second = values[bNumber];
        string third = values[cNumber];
        //string wordsfa = $"{first}, {second}, {third}";
        string newText = text.Replace($"{first}", "_").Replace($"{second}", "_").Replace($"{third}", "_");
        return newText;
    }
    public string wordSort2()
    {
        var aNumber = RandomNumb[3];
        var bNumber = RandomNumb[4];
        var cNumber = RandomNumb[5];
        string text = wordSort();

        string myText = GetNewText2();
        string myText1 = myText.Replace(" ", "");
        char del = ',';
        string[] values = myText1.Split(del);
        string first = values[aNumber];
        string second = values[bNumber];
        string third = values[cNumber];
        //string wordsfa = $"{first}, {second}, {third}";
        string newText = text.Replace($"{first}", "_").Replace($"{second}", "_").Replace($"{third}", "_");
        return newText;
    }
    public string wordSort3()
    {
        var aNumber = RandomNumb[6];
        var bNumber = RandomNumb[7];
        var cNumber = RandomNumb[8];
        string text = wordSort2();

        string myText = GetNewText2();
        string myText1 = myText.Replace(" ", "");
        char del = ',';
        string[] values = myText1.Split(del);
        string first = values[aNumber];
        string second = values[bNumber];
        string third = values[cNumber];
        //string wordsfa = $"{first}, {second}, {third}";
        string newText = text.Replace($"{first}", "_").Replace($"{second}", "_").Replace($"{third}", "_");
        return newText;
    }
    public string wordSort4()
    {
        var aNumber = RandomNumb[9];
        var bNumber = RandomNumb[10];
        var cNumber = RandomNumb[11];
        string text = wordSort3();

        string myText = GetNewText2();
        string myText1 = myText.Replace(" ", "");
        char del = ',';
        string[] values = myText1.Split(del);
        string first = values[aNumber];
        string second = values[bNumber];
        string third = values[cNumber];
        //string wordsfa = $"{first}, {second}, {third}";
        string newText = text.Replace($"{first}", "_").Replace($"{second}", "_").Replace($"{third}", "_");
        return newText;
    }
    public string wordSort5()
    {
        var aNumber = RandomNumb[12];
        var bNumber = RandomNumb[13];
        var cNumber = RandomNumb[14];
        string text = wordSort4();

        string myText = GetNewText2();
        string myText1 = myText.Replace(" ", "");
        char del = ',';
        string[] values = myText1.Split(del);
        string first = values[aNumber];
        string second = values[bNumber];
        string third = values[cNumber];
        //string wordsfa = $"{first}, {second}, {third}";
        string newText = text.Replace($"{first}", "_").Replace($"{second}", "_").Replace($"{third}", "_");
        return newText;
    }
    public string wordSort6()
    {
        var aNumber = RandomNumb[15];
        var bNumber = RandomNumb[16];
        var cNumber = RandomNumb[17];
        string text = wordSort5();

        string myText = GetNewText2();
        string myText1 = myText.Replace(" ", "");
        char del = ',';
        string[] values = myText1.Split(del);
        string first = values[aNumber];
        string second = values[bNumber];
        string third = values[cNumber];
        //string wordsfa = $"{first}, {second}, {third}";
        string newText = text.Replace($"{first}", "_").Replace($"{second}", "_").Replace($"{third}", "_");
        return newText;
    }
    public string hideWords(string textWords)
    {
        string text1 = textWords;
        //string text1 = wordSort();
        int aNumber = sortNumber();
        int bNumber = sortNumber();
        int cNumber = sortNumber();
        string myText = GetNewText2();
        string myText1 = myText.Replace(" ", "");
        char del = ',';
        string[] values = myText1.Split(del);
        string first = values[aNumber];
        string second = values[bNumber];
        string third = values[cNumber];
        string newText1 = text1.Replace($"{first}", "_").Replace($"{second}", "_").Replace($"{third}", "_");
        return newText1;
    }
    public string continueNumbers()
    {
        int aNumber = GetNumberOfElements();
        int start = 1;
        for (int i=start; i<=aNumber; i++)
        {
            contNumbers.Add(i);
        }
        return String.Join(", ", contNumbers);
    }
    public string wordClear()
    {
        string text = _text1;
        string myText = GetNewText2();
        string myText1 = myText.Replace(" ", "");
        char del = ',';
        string[] values = myText1.Split(del);
        string a1 = values[contNumbers[0]];
        string a2 = values[contNumbers[1]];
        string a3 = values[contNumbers[2]];
        string a4 = values[contNumbers[3]];
        string a5 = values[contNumbers[4]];
        string a6 = values[contNumbers[5]];
        string a7 = values[contNumbers[6]];
        string a8 = values[contNumbers[7]];
        string a9 = values[contNumbers[8]];
        string a10 = values[contNumbers[9]];
        string a11 = values[contNumbers[10]];
        string a12 = values[contNumbers[11]];
        string a13 = values[contNumbers[12]];
        string a14 = values[contNumbers[13]];
        string a15 = values[contNumbers[14]];
        string a16 = values[contNumbers[15]];
        string a17 = values[contNumbers[16]];
        string a18 = values[contNumbers[17]];
        string a19 = values[contNumbers[18]];
        string a20 = values[contNumbers[19]];
        string a21 = values[contNumbers[20]];
        string a22 = values[contNumbers[21]];
        string a23 = values[contNumbers[22]];
        string a24 = values[contNumbers[23]];

        string newText = text.Replace($"{a1}", "_").Replace($"{a2}", "_").Replace($"{a3}", "_").Replace($"{a4}", "_").Replace($"{a5}", "_").Replace($"{a6}", "_").Replace($"{a7}", "_").Replace($"{a8}", "_").Replace($"{a9}", "_").Replace($"{a10}", "_").Replace($"{a11}", "_").Replace($"{a12}", "_").Replace($"{a13}", "_").Replace($"{a14}", "_").Replace($"{a15}", "_").Replace($"{a16}", "_").Replace($"{a17}", "_").Replace($"{a18}", "_").Replace($"{a19}", "_").Replace($"{a20}", "_").Replace($"{a21}", "_").Replace($"{a22}", "_").Replace($"{a23}", "_").Replace($"{a24}", "_");
        return newText;
    }
}