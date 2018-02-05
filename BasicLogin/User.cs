using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginCred
{
    class User
    {
        public string UserID { get; set; }
        public string Password { get; set; }
        public char type;
        //the function is to be called from register so that the user can sign in.
        public void GetDetails(int chc)
        {
            if (chc == 1)
            {
                Console.Write("Enter the ADMIN ID:\t");
                UserID = Console.ReadLine();
                Console.Write("Enter the PASSWORD:\t");
                Password = Console.ReadLine();
                type = 'E';
            }
            else if(chc ==2)
            {
                Console.Write("Enter the USER ID:\t");
                UserID = Console.ReadLine();
                Console.Write("Enter the PASSWORD:\t");
                Password = Console.ReadLine();
                type = 'C';
            }
            //Link the function to fill into the user details so that the file is updated
            LogFile userLog = new LogFile();
            userLog.WriteToFile(this);
        }
    }
}
