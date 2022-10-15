using System;
using System.Threading;
namespace EventTest
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press a to simulate a button click");
            var key = Console.ReadLine();
            if(key=="a")
            {
                KeyPressed();
            }
        }
        static void KeyPressed()
        {
            Button button = new Button();
            button.ClickEvent += (s, args) =>
              {
                  Console.WriteLine("You clicked a button");
              };
            button.OnClick();
        }
    }
    public class Button
    {
        public EventHandler ClickEvent;
        public void OnClick()
        {
            ClickEvent.Invoke(this, EventArgs.Empty);

        }
    }
}
