using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Classes.Abstract_Factory
{
    public interface IButton
    {
        void Paint();
        void OnClick();
    }

    public interface ICheckbox
    {
        void Paint();
        void OnSelect();
    }

    public class WindowsButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("Painting Windows Button");
        }
        public void OnClick()
        {
            Console.WriteLine("Windows Button Clicked");
        }
    }

    public class MacOSButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("Painting MacOS Button");
        }
        public void OnClick()
        {
            Console.WriteLine("MacOS Button Clicked");
        }
    }

    public class WindowsCheckbox : ICheckbox
    {
        public void Paint()
        {
            Console.WriteLine("Painting Windows Checkbox");
        }
        public void OnSelect()
        {
            Console.WriteLine("Windows Checkbox Selected");
        }
    }

    public class MacOSCheckbox : ICheckbox
    {
        public void Paint()
        {
            Console.WriteLine("Painting MacOS Checkbox");
        }
        public void OnSelect()
        {
            Console.WriteLine("MacOS Checkbox Selected");
        }
    }

    public interface IGUIFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }

    public class WindowsFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }
        public ICheckbox CreateCheckbox()
        {
            return new WindowsCheckbox();
        }
    }

    public class MacOSFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new MacOSButton();
        }
        public ICheckbox CreateCheckbox()
        {
            return new MacOSCheckbox();
        }

    }
}
