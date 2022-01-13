﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio.Presenter
{
    class PresenterManage
    {
        private ILog log;
        private bool newUser;

        public PresenterManage(ILog log, bool newUser)
        {
            this.log = log;
            this.newUser = newUser;
            logSelection();
        }

        public void logSelection()
        {
            if (newUser)
            {
                LogUp.LogUpManage logUpManager = new LogUp.LogUpManage(log);
                logUpManager.createUser();
            } else
            {

                LogIn.LogInManage logInManager = new LogIn.LogInManage(log);
                logInManager.logInUser();
            }

        }

        

    }
}
