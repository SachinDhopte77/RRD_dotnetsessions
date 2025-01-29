﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountCommonLib.Models
{
    public class InsufficientFundsException : Exception
    {
        public Account _accountHolder;//HasA relationship

        public InsufficientFundsException(Account account)
        {

            _accountHolder = account;
        }
        public override string Message
        {
            get
            {

                return $"account holder:{_accountHolder.Name} , doesnot have sufficient fund for withraw of balacne is only ${_accountHolder.Balance}";
            }
        }




    }


}