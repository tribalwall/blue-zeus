namespace BlueZeus.Models
{
    using System;
    using System.ComponentModel;


    public class User : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;


        public User(String userUsername)
        {

            Username = userUsername;

        }


        private string _Username;



        public String Username
        {

            
            get  {  return _Username; }
            set  { _Username = value; OnPropertyChanged("Username");   }

        }


        // this method raises PropertyChanged event
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null) // if there is any subscribers 
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }




    }

}