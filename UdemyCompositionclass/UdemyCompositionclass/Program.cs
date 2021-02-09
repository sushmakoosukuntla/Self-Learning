using System;

namespace UdemyCompositionclass
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new DBMigrator(new Logger());
            var insta = new Installer(new Logger());
            db.Migrate();
            insta.install();
        }
    }
}
 