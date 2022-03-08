using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace ShoppingList
{
    public class ShoppingListData : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;


        public string textbox = "";
        
        public ShoppingListData()
        {

        }

        private List<string> items = new List<string>();

        public IEnumerable<string> Items => items.ToArray();

        public void addtotextbox(string i)
        {
            textbox = i;
        }

        public void AddItem(string item)
        {
            if(item == "apple")
            {
                items.Add("Death");
            }
            else
            {
                items.Add(item);
            }
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

        public void RemoveItem(string item)
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

    }
}
