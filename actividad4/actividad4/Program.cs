using System;

// ================= CLASE ABSTRACTA =================
abstract class AbstractSample
{
    // Atributo privado
    private string message;

    // Propiedad protegida para las subclases
    protected string Message
    {
        get { return message; }
        set { message = value; }
    }

    // Método abstracto
    public abstract void PrintMessage(string msg);

    // Método virtual que invierte el mensaje
    public virtual void InvertMessage(string msg)
    {
        Message = ReverseString(msg);
    }

    // Método auxiliar para invertir strings
    protected string ReverseString(string text)
    {
        char[] chars = text.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
}

// ================= SUBCLASE NORMAL =================
class NormalSample : AbstractSample
{
    public override void PrintMessage(string msg)
    {
        Message = msg;
        Console.WriteLine(Message);
    }
}

// ================= SUBCLASE CON MAYÚSCULAS / MINÚSCULAS =================
class InvertedCaseSample : AbstractSample
{
    // Imprime con mayúsculas y minúsculas invertidas
    public override void PrintMessage(string msg)
    {
        Console.WriteLine(InvertirMayusculasMinusculas(msg));
    }

    // Sobrescribe InvertMessage
    public override void InvertMessage(string msg)
    {
        string invertido = ReverseString(msg);
        Message = InvertirMayusculasMinusculas(invertido);
    }

    // Cambia mayúsculas por minúsculas y viceversa
    private string InvertirMayusculasMinusculas(string text)
    {
        char[] resultado = new char[text.Length];

        for (int i = 0; i < text.Length; i++)
        {
            if (char.IsUpper(text[i]))
                resultado[i] = char.ToLower(text[i]);
            else if (char.IsLower(text[i]))
                resultado[i] = char.ToUpper(text[i]);
            else
                resultado[i] = text[i];
        }

        return new string(resultado);
    }
}

// ================= PROGRAMA PRINCIPAL =================
class Program
{
    static void Main()
    {
        AbstractSample a = new NormalSample();
        a.PrintMessage("We all gonna die, but not TODAY");
        a.InvertMessage("Maybe tomorrow,maybe..., OH");
        a.PrintMessage("YADOT ton tub ,eid annog lla eW");

        Console.WriteLine();

        AbstractSample b = new InvertedCaseSample();
        b.PrintMessage("We all gonna die, but not TODAY");
        b.InvertMessage("Maybe tomorrow,maybe..., OH");
        b.PrintMessage("yadot TON TUB ,EID ANNOG LLA Ew");

        Console.ReadKey();
    }
}
