using Newtonsoft.Json;
using System.ComponentModel;
using System.Text.Json.Serialization;
using System.Text;

namespace MauiLocalStorageAssignment
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        private string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "LocalStorageText.txt");

        private Profile _details;
        public Profile Details
        {
            get => _details;
            set
            {
                _details = value;
                OnPropertyChanged();
            }
        }

        public MainPage()
        {
            InitializeComponent();
            Details = loadData();
            BindingContext = this;
        }


        #region eventhandlers
        private void SaveBtn_Clicked (object sender, EventArgs e)
        {
            SaveData(Details);
            /*string name = NameEntry.Text;
            string surname = SurnameEntry.Text;
            string emailaddress = EmailEntry.Text;
            string password = PasswordEntry.Text;

            Profile profile = new Profile();
            {
                Name = name;
                Surname = surname;
                EmailAddress = emailaddress;
                Password = password;
            };*/

            

        }

        public void SaveData(Profile profile)
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "LocalStorageText.txt");
            string json = JsonConvert.SerializeObject(profile);
            File.WriteAllText(filePath, json);
            // TextBox.Text = File.ReadAllText(filePath);

        }
        #endregion

        public void LoadBtn_Clicked (object sender, EventArgs e)
        {
            Details = loadData();
        }

        public static Profile loadData()
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "LocalStorageText.txt");

            if (File.Exists(filePath))
            {
                string currentprofile = File.ReadAllText(filePath);
                Profile newdetails = JsonConvert.DeserializeObject<Profile>(currentprofile);
                return newdetails;
            }
            else
            {
                return new Profile();
            }


        }
       
    }
}
