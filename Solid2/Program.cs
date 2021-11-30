using System;

//Який принцип S.O.L.I.D. порушено? Виправте!
/** було порушено принцип The Open Closed Principle**/
/*Зверніть увагу на клас EmailSender. Крім того, що за допомогою методу Send, він відправляє повідомлення, 
він ще і вирішує як буде вестися лог. В даному прикладі лог ведеться через консоль.
Якщо трапиться так, що нам доведеться міняти спосіб логування, то ми будемо змушені внести правки в клас EmailSender.
Хоча, здавалося б, ці правки не стосуються відправки повідомлень. Очевидно, EmailSender виконує кілька обов'язків і, 
щоб клас ні прив'язаний тільки до одного способу вести лог, потрібно винести вибір балки з цього класу.*/
class Email
{
    public String Theme { get; set; }
    public String From { get; set; }
    public String To { get; set; }
}
interface ILogger
{
    void Log(string from, string to);
}
class ConsoleLogger : ILogger
{
    public void Log(string from, string to)
    {
        Console.WriteLine("Email from '" + from + "' to '" + to + "' was send");
    }
}
class EmailSender
{
    public void Send(Email email, ILogger logger)
    {
        // ... sending...
        logger.Log(email.From, email.To);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Email e1 = new Email() { From = "Me", To = "Vasya", Theme = "Who are you?" };
        Email e2 = new Email() { From = "Vasya", To = "Me", Theme = "vacuum cleaners!" };
        Email e3 = new Email() { From = "Kolya", To = "Vasya", Theme = "No! Thanks!" };
        Email e4 = new Email() { From = "Vasya", To = "Me", Theme = "washing machines!" };
        Email e5 = new Email() { From = "Me", To = "Vasya", Theme = "Yes" };
        Email e6 = new Email() { From = "Vasya", To = "Petya", Theme = "+2" };

        EmailSender es = new EmailSender();
        ILogger logger = new ConsoleLogger();
        es.Send(e1, logger);
        es.Send(e2, logger);
        es.Send(e3, logger);
        es.Send(e4, logger);
        es.Send(e5, logger);
        es.Send(e6, logger);

        Console.ReadKey();
    }
}