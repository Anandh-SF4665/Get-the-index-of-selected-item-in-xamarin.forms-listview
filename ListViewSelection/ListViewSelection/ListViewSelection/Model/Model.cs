using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionItemIndex
{
    public class Model:INotifyPropertyChanged
    {
        private string contactName;
        private string contactNumber;
        public string ContactName
        {
            get { return contactName; }
            set
            {
                if (contactName != value)
                {
                    contactName = value;
                    OnPropertyChanged("ContactName");
                }
            }
        }

        public string ContactNumber
        {
            get { return contactNumber; }
            set
            {
                if (contactNumber != value)
                {
                    contactNumber = value;
                    OnPropertyChanged("ContactNumber");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string v)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(v));
        }
    }
}
