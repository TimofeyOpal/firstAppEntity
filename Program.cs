using System;

namespace firstAppEntity
{
    class Program
    {
        static void Main(string[] args)
        {
           using(AppContext context = new AppContext())
            {
                context.Users.Add(new User()
               {
                   Name = "Витя", Age = 22});
                context.SaveChanges();
            }
        }
    }
}
