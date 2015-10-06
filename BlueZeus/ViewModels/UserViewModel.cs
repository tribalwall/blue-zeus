 namespace BlueZeus.ViewModels
{

    using System;
    using System.Diagnostics;
    using BlueZeus.Models;

    internal class UserViewModel
    {

 

        public UserViewModel()
        {
            _User = new User("che");
            _User.Username = "che";
             
        }

        private User _User;
 
        public User User { 
             get  { return _User; }
    }

        
        


    }


}
