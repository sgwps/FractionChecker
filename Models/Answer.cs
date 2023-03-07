namespace SchoolNumbers.Models;

class Answer{
    public Fraction Fraction {get; set;}

    public string Input {get; set;} = "";

    public bool IsCoreect {
        get{
            Console.WriteLine(Fraction.Text());
            Console.WriteLine(Input);
            foreach (string i in Fraction.Text().Split(" ", StringSplitOptions.RemoveEmptyEntries))
            Console.Write(i);
            foreach (string i in Input.Split(" ", StringSplitOptions.RemoveEmptyEntries))
            Console.Write(i);
            return (Fraction.Text().Split(" ", StringSplitOptions.RemoveEmptyEntries)).Equals(Input.Split(" ", StringSplitOptions.RemoveEmptyEntries));
        }
    }

    public Answer (Fraction fraction, string input){
        Fraction =  fraction;
        Input = input;
    }
}