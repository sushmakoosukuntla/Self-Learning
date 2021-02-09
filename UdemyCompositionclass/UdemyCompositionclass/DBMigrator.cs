using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCompositionclass
{
    public class DBMigrator
    {
        private readonly Logger _logger;
        public DBMigrator(Logger logger)
        {
           this. _logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("we are migrating");
        }
    }
}
