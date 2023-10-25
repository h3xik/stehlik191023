// See https://aka.ms/new-console-template for more information

class praceSPolem
{
    private int[] pole;
    public int pocet;

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

    public int Get(int index)
    {
        if (index >= pocet)
        {
            throw new IndexOutOfRangeException("Zadaná pozice je mimo rozsah pole.");
        }
        return pole[index];
    }

    public void Remove(int index)
    {
        if (index < 0 || index >= pole.Length)
        {
            throw new IndexOutOfRangeException("Zadaná pozice je mimo rozsah pole.");
        }

        for (int i = index; i < pocet - 1; i++)
        {
            pole[i] = pole[i + 1];
        }
        pocet--;

        if (pocet < pole.Length / 2)
        {
            Array.Resize(ref pole, pole.Length / 2);
        }
    }

    public void Insert(int index, int value)
    {
        if (index < 0)
        {
            throw new IndexOutOfRangeException("Zadaná pozice je mimo rozsah pole.");
        }

        if (pocet >= pole.Length || index > pole.Length)
        {
            Array.Resize(ref pole, pole.Length * 2 > index + 1 ? pole.Length * 2 : index + 1);
        }

        for (int i = pocet; i > index; i--)
        {
            pole[i] = pole[i - 1];
        }

        pole[index] = value;
        pocet++;
    }

    public void Compact()
    {
        if (pocet < pole.Length)
        {
            Array.Resize(ref pole, pocet);
        }
    }

    // Funkce na vypisování
    public void PrintPole()
    {
        foreach (var x in pole)
        {
            Console.Write(x + ", ");
            Console.WriteLine(" ");
        }
    }
    public void PrintPos(int index)
    {
        if (index >= pole.Length)
        {

        }
    }
    public int Length()
    {
        return pole.Length;
    }

    public int PocetNenulovych()
    {
        return pocet;
    }
}

class Program
{
    static void Main(string[] args)
    {
        praceSPolem dA = new praceSPolem();
        dA.Add(69);
        dA.Set(8, 69);

        Console.WriteLine("nigga" + dA.pocet);
        dA.Insert(55, 15);
        // dA.Remove(0);

        dA.PrintPole();

        Console.WriteLine("Počet prvků v poli: " + dA.Length());
        Console.WriteLine("Počet nenulových prvků v poli: " + dA.PocetNenulovych());
    }

}

