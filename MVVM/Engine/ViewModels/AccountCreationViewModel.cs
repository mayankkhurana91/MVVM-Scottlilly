﻿using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.ViewModels
{
    public class AccountCreationViewModel
    {
        public AccountModel NewAccount { get; set; }

        public AccountCreationViewModel()
        {
            NewAccount = new AccountModel();
        }

        public void ValidatePassword()
        {
            NewAccount.ValidatePassword();
        }
    }
}
