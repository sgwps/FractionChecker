namespace SchoolNumbers.Models;

partial class Fraction
{
    public int Numerator { get; set; }
    public int Denumerator { get; set; }
    public string ToText
    {
        get { return $"дробь перевелась {Numerator} / {Denumerator}"; }
    }

    public override string ToString()
    {
        return @$"{Numerator} / {Denumerator}";
    }

    public Fraction(int num, int denum)
    {
        Numerator = num;
        Denumerator = denum;
    }

    public static Fraction gen_fraction()
    {
        Random random = new Random();
        int Denumerator = 1;
        int Numerator = random.Next(1, 1000);
        do
        {
            Denumerator = random.Next(2, 100);
            if (Numerator % Denumerator != 0)
            {
                break;
            }
        } while (true);

        return new Fraction(
            Numerator / gcd(Numerator, Denumerator),
            Denumerator / gcd(Numerator, Denumerator)
        );
    }

    static int gcd(int num1, int num2)
    {
        int Remainder;

        while (num2 != 0)
        {
            Remainder = num1 % num2;
            num1 = num2;
            num2 = Remainder;
        }

        return num1;
    }


    static public bool TryParse(string? str, out Fraction frac)
    {
        frac = new Fraction(0, 1);
        if (str == null) return false;
        string[] parts = str.Split("/").Select(x => x.Trim()).ToArray();
        if (parts.Length <= 1) return false;
        if (int.TryParse(parts[0], out int num) && int.TryParse(parts[1], out int den))
        {
            frac = new Fraction(num, den);
            return true;
        }
        else
        {
            return false;
        }
    }
}
