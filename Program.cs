using System;
using System.Collections.Generic;
using System.Linq;
namespace Program
{
    class Program
    {
        
        class Bag
        {
            public delegate void delOfNotify(string mess);
            public event delOfNotify Notify;
            int m_amount;
            public Bag(int amount)
            {
                m_amount = amount;
            }

            void showMessageOfEvent(string message)
            {
                Notify?.Invoke(message);
            }

            public void addAmount(int amount)
            {
                m_amount += amount;
                showMessageOfEvent($"You are added {amount} amount.");
            }

            public int takeAmount(int amount) 
            {
                m_amount -= amount;
                showMessageOfEvent($"You are taked {amount} amount.");
                return amount;
            }

            public void showAmount()
            {
                showMessageOfEvent($"You are have {m_amount} of amount.");
            }
        }

        static void Main(string[] args)
        {
            Bag myBag = new Bag(100);
            myBag.Notify += showMessage;
            myBag.addAmount(50);
            myBag.takeAmount(100);
            myBag.showAmount();
        }

        static void showMessage(string mess)
        {
            Console.WriteLine(mess);
        }

    }
}