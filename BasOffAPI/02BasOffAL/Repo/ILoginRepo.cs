﻿using _01BasOffEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02BasOffBL.Repo
{
    public interface ILoginRepo
    {
        public string Login(UserCredentialsEntity credentials);
    }
}
