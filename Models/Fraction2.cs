 namespace SchoolNumbers.Models;
 
 
 public partial class Fraction
    {
        private static Random s_rand = new Random();
        
        private byte[] _getNumDigits(uint num)
        {
            List<byte> digits = new List<byte>();
            while (num > 0)
            {
                digits.Add((byte)(num % 10));
                num /= 10;
            }
            return digits.ToArray();
        }
        public string getStrFor6DigitNumber(int num)
        {
            int thNum = num / 1000;
 
            return (thNum != 0 ? getStrFor3DigitNumberOfThousands(thNum) + $" {getThousandForm(thNum)} " : " ")  + getStrFor3DigitNumberOfThousands(num % 1000);
        }
        public string getThousandForm(int num)
        {
            if (num % 10 == 1 && num % 100 != 11) return "тысяча";
            if (num % 10 == 2 && num % 100 != 12) return "тысячи";
            if (num % 10 == 3 && num % 100 != 13) return "тысячи";
            if (num % 10 == 4 && num % 100 != 14) return "тысячи";
            return "тысяч";
        }
 
        public string getThousandthForm(int num)
        {
            if (num % 10 == 1 && num % 100 != 11) return "тысячная";
            if (num % 10 == 2 && num % 100 != 12) return "тысячные";
            if (num % 10 == 3 && num % 100 != 13) return "тысячные";
            if (num % 10 == 4 && num % 100 != 14) return "тысячные";
            return "тысячных";
        }
        public string getHundredthForm(int num)
        {
            if (num % 10 == 1 && num != 11) return "сотая";
            if (num % 10 == 2 && num != 12) return "сотые";
            if (num % 10 == 3 && num != 13) return "сотые";
            if (num % 10 == 4 && num != 14) return "сотые";
            return "сотых";
        }
        public string getTenthForm(int num)
        {
            if (num % 10 == 1 && num != 11) return "десятая";
            if (num % 10 == 2 && num != 12) return "десятые";
            if (num % 10 == 3 && num != 13) return "десятые";
            if (num % 10 == 4 && num != 14) return "десятые";
            return "десятых";
        }
        public string getStrFor3DigitNumber(int num)
        {
            return getStrForHundreds(num / 100) + " " + (num % 100!=0?getStrFor2DigitsNumer(num%100):"");
        }
 
        public string getStrFor3DigitNumberOfThousands(int num)
        {
            return getStrForHundreds(num / 100) + " " + (num % 100 != 0 ? getStrFor2DigitNumberOfThousands(num % 100) : "");
        }
 
        public string getStrForHundreds (int h)
        {
            switch (h)
            {
                case 0: return "";
                case 1: return "сто";
                case 2: return "двести";
                case 3: return "триста";
                case 4: return "четыреста";
                case 5: return "пятьсот";
                case 6: return "шестьсот";
                case 7: return "семьсот";
                case 8: return "восемьсот";
                case 9: return "девятьсот";
            }
            return "";
        }
 
        public string getStrFor2DigitsNumer(int num)
        {
            if (num < 10) return getStrForOnes(num);
            if (num < 20)
            {
                switch (num)
                {
                    case 10: return "десять";
                    case 11: return "одиннадцать";
                    case 12: return "двенадцать";
                    case 13: return "тринадцать";
                    case 14: return "четырнадцать";
                    case 15: return "пятнадцать";
                    case 16: return "шестнадцать";
                    case 17: return "семнадцать";
                    case 18: return "восемнадцать";
                    case 19: return "девятнадцать";
                }
                return "";
            }
            else
            {
                return getStrForDecimals(num / 10) +" "+ (num % 10!=0?getStrForOnes(num%10):"");
            }
        }
 
        public string getStrFor2DigitNumberOfThousands(int num)
        {
            if (num < 10) return getStrForOnesForThousands(num);
            if (num < 20)
            {
                switch (num)
                {
                    case 10: return "десять";
                    case 11: return "одиннадцать";
                    case 12: return "двенадцать";
                    case 13: return "тринадцать";
                    case 14: return "четырнадцать";
                    case 15: return "пятнадцать";
                    case 16: return "шестнадцать";
                    case 17: return "семнадцать";
                    case 18: return "восемнадцать";
                    case 19: return "девятнадцать";
                }
                return "";
            }
            else
            {
                return getStrForDecimals(num / 10) + " " + (num % 10 != 0 ? getStrForOnesForThousands(num % 10) : "");
            }
        }
 
        public string getStrForDecimals(int dec)
        {
            switch (dec)
            {
                case 0: return "";
                case 1: return "";
                case 2: return "двадцать";
                case 3: return "тридцать";
                case 4: return "сорок";
                case 5: return "пятьдесят";
                case 6: return "шестьдесят";
                case 7: return "семьдесят";
                case 8: return "восемьдесят";
                case 9: return "девяносто";
            }
            return "";
        }
 
        public string getStrForOnes(int o)
        {
            switch (o)
            {
                case 0: return "ноль";
                case 1: return "один";
                case 2: return "два";
                case 3: return "три";
                case 4: return "четыре";
                case 5: return "пять";
                case 6: return "шесть";
                case 7: return "семь";
                case 8: return "восемь";
                case 9: return "девять";
            }
            return "";
        }
 
        public string getStrForOnesForThousands(int o)
        {
            switch (o)
            {
                case 0: return "";
                case 1: return "одна";
                case 2: return "две";
                case 3: return "три";
                case 4: return "четыре";
                case 5: return "пять";
                case 6: return "шесть";
                case 7: return "семь";
                case 8: return "восемь";
                case 9: return "девять";
            }
            return "";
        }
 
        public enum GenMode
        {
            FRACTION_ONLY, NON_FRACTION_ONLY, COMBINED
        }
        /// <summary>
        /// Генерация дроби
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public static Fraction Generate(GenMode mode)
        {
            int num = s_rand.Next(0, 1000000);
            int den = s_rand.Next(0, 1000);
            if (mode == GenMode.COMBINED)
            {
                return new Fraction(num, den);
            }
            if (mode == GenMode.FRACTION_ONLY)
            {
                return new Fraction(0, den);
            }
            if (mode == GenMode.NON_FRACTION_ONLY)
            {
                return new Fraction(num, 0);
            }
            return new Fraction(0, 0);
        }
 
        /// <summary>
        /// Получение строкового представления
        /// </summary>
        /// <returns></returns>
        public string Text()
        {
            int countDigits = _getNumDigits((uint)Denumerator).Length;
            string endForm = countDigits == 1 ? getTenthForm((int)Denumerator) : countDigits == 2 ? getHundredthForm((int)Denumerator) : getThousandthForm((int)Denumerator);
            return getStrFor6DigitNumber((int)Numerator) +(Numerator!=0?" целых ":" ")+ getStrFor3DigitNumberOfThousands((int)Denumerator)+" "+endForm;
        }
 
    }
