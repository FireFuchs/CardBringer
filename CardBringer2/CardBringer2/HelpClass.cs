﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardBringer2
{
    class HelpClass
    {
        public HelpClass(string tekstHelp)
        {
            HelpForm help = new HelpForm(tekstHelp);
            help.Show();
        }
    }
}
