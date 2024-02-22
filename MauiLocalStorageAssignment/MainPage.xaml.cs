using Newtonsoft.Json;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace MauiLocalStorageAssignment
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        private string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "LocalStorageText.txt");
      
        public Profile _profile {  get; set; }
       

        public MainPage()
        {
            InitializeComponent();
            SaveBtn.Clicked += SaveBtn_Clicked;
        }

        #region properties

        public class Profile
        {
            public string Name;
            public string Surname;
            public string EmailAddress;
            public string Password;
        }
        #endregion

        #region eventhandlers
        private void SaveBtn_Clicked (object sender, EventArgs e)
        {
            string name = NameEntry.Text;
            string surname = SurnameEntry.Text;
            string emailaddress = EmailEntry.Text;
            string password = PasswordEntry.Text;

            Profile profile = new Profile();
            {
                name = name;
                surname = surname;
                emailaddress = emailaddress;
                password = password;
            };

            string json = JsonConvert.SerializeObject(profile);
            File.WriteAllText(filePath, json);
            TextBox.Text = File.ReadAllText(filePath);

        }
        #endregion

        private void LoadBtn_Clicked(object sender, EventArgs e)
        {
            
        }
    }

}
