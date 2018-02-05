using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace LoginCred
{
    class LogFile
    {
        FileStream fs = null;
        StreamWriter sw = null;
        StreamReader sr = null;
        public void WriteToFile(User U)
        {
            try
            {

                fs = new FileStream(@"E:\UserLog.txt", FileMode.Append, FileAccess.Write);
                sw = new StreamWriter(fs);
                sw.WriteLine("UserID:\t{0}\nPassword:\t{1}\nUser Type:\t{2}\n\n", U.UserID, U.Password,U.type);
                sw.Flush();
            }
            catch(NullReferenceException E1)
            {
                Console.WriteLine(E1.Message);
            }
            catch(IOException E2)
            {
                Console.WriteLine(E2.Message);
            }
            catch(Exception E3)
            {
                Console.WriteLine(E3.Message);

            }
            finally
            {
                sw.Close();
                fs.Close();

            }
        }
        public void ReadFromFile()
        {
            try
            {
                fs = new FileStream(@"E:\UserLog.txt", FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);
                
                string str = sr.ReadToEnd();
                if (str != null)
                    Console.WriteLine(str);
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }
            finally
            {
                if (sr != null)
                    sr.Close();
                if (fs != null)
                    fs.Close();
            }
        }
    }
}
