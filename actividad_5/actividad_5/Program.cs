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

// ================= SUBCLASE MAYÚSCULAS / MINÚSCULAS =================
class InvertedCaseSample : AbstractSample
{
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

// ================= MESSAGE MANAGER =================
class MessageManager
{
    public void Execute()
    {
        AbstractSample normal = new NormalSample();
        AbstractSample invertido = new InvertedCaseSample();

        string mensaje = "We all gonna die, but not TODAY";

        normal.PrintMessage(mensaje);
        normal.InvertMessage(mensaje);
        normal.PrintMessage("YADOT ton tub ,eid annog lla eW");

        Console.WriteLine();

        invertido.PrintMessage(mensaje);
        invertido.InvertMessage(mensaje);
        invertido.PrintMessage("yadot TON TUB ,EID ANNOG LLA Ew");
    }
}

// ================= PROGRAMA PRINCIPAL =================
class Program
{
    static void Main()
    {
        MessageManager manager = new MessageManager();
        manager.Execute();

        Console.ReadKey();
    }
}
