// See https://aka.ms/new-console-template for more information

class praceSPolem
{
    private int[] pole;
    private int pocet;

    public praceSPolem(int initialSize = 10)
    {
        pole = new int[initialSize];
        pocet = 0;
    }

    public int[] Add(int value)
    {
        if (pocet >= pole.Length)
        {
            Array.Resize(ref pole, pole.Length * 2);
        }
        pole[pocet++] = value;
        return pole;
    }

    public void Set(int index, int value)
    {
        if (index >= pole.Length)
        {
            Array.Resize(ref pole, index + 1);
        }
        pole[index++] = value;
    }

    // Funkce na vypisování
    public void PrintPole()
    {
        foreach (var x in pole)
        {
            Console.Write(x + ", ");
        }
    }
    public void PrintPos(int index)
    {
        if (index >= pole.Length)
        {

        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        praceSPolem dA = new praceSPolem();
        dA.Add(69);
        dA.Set(8, 69);
       
        dA.PrintPole();
    }

}

