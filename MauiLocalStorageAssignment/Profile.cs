using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiLocalStorageAssignment
{
    public partial class Profile : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
            }
        }
        private string _surname;
        public string Surname
        {
            get => _surname;
            set
            {
                _surname = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Surname)));
            }
        }

        private string _emailaddress;
        public string EmailAddress
        {
            get => _emailaddress;
            set
            {
                _emailaddress = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Email)));
            }
        }

        private string _bio;

        public string Bio
        {
            get => _bio;
            set
            {
                _bio = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Bio)));
            }
        }
        private string _password;

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Password)));
            }
        }
    }
}
