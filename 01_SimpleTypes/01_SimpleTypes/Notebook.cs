using System;

using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace _01_SimpleTypes
{
    class Notebook : IDisposable
    {
       // pages
       Dictionary<int, string> pages = new Dictionary<int, string>();
        Color coverColor = System.Drawing.Color.Brown;
        string coverPattern = "plain";
        string coverMaterial = "unknown";

        public void CreateMessage(string message)
        {
            pages.Add(pages.Count + 1, message);
            Console.WriteLine("New Message for Page {0}, {1}", pages.Count, message);
        }

        public void DeleteMessage(int pageNumber)
        {
            Console.WriteLine("Deleting page {0}", pageNumber);
            if(pages.ContainsKey(pageNumber))
            {
                pages.Remove(pageNumber);
            }
        }

        public void UpdateMessage(int pageNumber, string newMessage)
        {
            Console.WriteLine("Updating page {0} with {1}", pageNumber, newMessage);
            if(pages.ContainsKey(pageNumber))
            {
                pages[pageNumber] = newMessage;
            }
            else
            {
                CreateMessage(newMessage);
            }
        }

        public void ThrowAway() {

            Console.WriteLine("throw my notebook!!!");
            this.Dispose();
        }

        public void Dispose()
        {
            
        }
    }
}
