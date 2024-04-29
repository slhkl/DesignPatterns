Resizer.Instance.ResizePng();

SmsSender.Instance.Send();

MailSender.Instance.Send();
MailSender.Instance.Resize();

QRCodeCreator.Instance.Create();

public class Resizer
{
    private Resizer() { }

    private static Resizer instance;

    public static Resizer Instance

    {
        get
        {
            if (instance == null)
            {
                instance = new Resizer();
            }
            return instance;
        }
    }

    public void ResizePng()
    {
        Console.WriteLine("Png resized");
    }
}

public class SmsSender
{
    private SmsSender() { }

    private static object lockObject = new object();

    private static SmsSender instance;

    public static SmsSender Instance
    {
        get
        {
            lock (lockObject)
            {
                if (instance == null)
                {
                    instance = new SmsSender();
                }
                return instance;
            }
        }
    }

    public void Send()
    {
        Console.WriteLine("Sms sended");
    }
}

public class MailSender
{
    private MailSender() { }

    public static MailSender Instance = new Lazy<MailSender>(() => new MailSender()).Value;

    public void Send()
    {
        Console.WriteLine("Mail sended");
    }

    public void Resize()
    {
        Console.WriteLine("Mail resized");
    }
}

public class QRCodeCreator
{
    private QRCodeCreator() { }

    // Wrong usage
    public static QRCodeCreator Instance => new Lazy<QRCodeCreator>(() => new QRCodeCreator()).Value;

    public void Create()
    {
        Console.WriteLine("QR code created.");
    }
}