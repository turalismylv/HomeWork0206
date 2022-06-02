using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)




        {
            //            Tapşırıq:

            //            Asagidaki metodlari olan IAccount interface yaradirsiniz : PasswordChecker() - parameter oalraq string sifreni qebul edir
            //            ShowInfo()
            //            Asagidaki memberlerden ibaret User class-i yaradirsiniz ve IAccount-u implement edirsiniz:
            //Fullname
            //Email
            //Password
            //PasswordChecker() - PasswordChecker metodu - gelen string sifre deyerinin sertleri odeyib odemediyini yoxlayib true/false deyer qaytarir.Şertler: - sifrede minimum 8 character olmalidir -
            //ifrede en az 1 boyuk herf olmaldir - sifrede en az 1 kicik herf olmalidir - sifrede en az 1 reqem olmalidir
            //ShowInfo() - bu metod Console-a user-in Fullanem ve email-inin yazdirir
            //ps: User classina IAccount interface-i implement edilir.User yarandigi zaman email ve sifre teyin edilmesi mecburidir.
            //Usere sifre teyin edilerken sifrenin PasswordChecker metodunun sertlerini odemesi lazimdir.
            User us1 = new User();

            us1.Email = "turalhi@code.edu.az";
            us1.FullName = "Tural Ismayilov";
            us1.Password = "Tural123";

            
            us1.ShowInfo();
            Console.WriteLine(us1.PasswordChecker());

        }


    }
}
