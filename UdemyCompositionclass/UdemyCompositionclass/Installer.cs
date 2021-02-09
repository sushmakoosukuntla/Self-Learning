using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCompositionclass
{
    public class Installer
    {
        private readonly Logger _logger;
        public Installer(Logger logger)
        {
            this._logger = logger;
        }

        public void install()
        {
            _logger.Log("we are installing the application");
        }
    }
}
