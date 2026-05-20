using FactoryMethod.Classes;
using FactoryMethod.Classes.Abstract_Factory;
using FactoryMethod.Classes.FactoryMethod;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //simple factory method (Notification => email or sms) => simpleFac class create object
            INotification emailNotification = SimpleFactory.CreateNotification("Email");
            INotification smsNotification = SimpleFactory.CreateNotification("Sms");

            emailNotification.sendMessaage("Hello, this is an email notification.");
            smsNotification.sendMessaage("Hello, this is an SMS notification.");


            // FACTORY METHOD (Notification => email or sms) => creator for each type of notification
            EmailNotificationCreator emeilCreator = new EmailNotificationCreator();
            NotificationCreator smsCreator = new SmsNotificationCreator();

            emeilCreator.Send("Hello, this is an email notification.");
            smsCreator.Send("Hello, this is an SMS notification.");


            //Abstract Factory => you want family of related objects (ex. windows [Buttons + Checkbox] or mac [Buttons + Checkbox]) => factory for each family  
            IGUIFactory windowsFactory = new WindowsFactory();
            IButton wButton;
            ICheckbox wCheckbox;

            wButton = windowsFactory.CreateButton();
            wCheckbox = windowsFactory.CreateCheckbox();

            wButton.OnClick();
            wCheckbox.Paint();

            IButton McButton;
            ICheckbox McCheckBox;

            IGUIFactory MacSFactory = new MacOSFactory();
            McButton = MacSFactory.CreateButton();
            McCheckBox = MacSFactory.CreateCheckbox();

            McButton.OnClick();
            McCheckBox.Paint();
        }
    }
}
