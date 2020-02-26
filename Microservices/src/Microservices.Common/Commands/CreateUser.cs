﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Microservices.Common.Commands
{
    public class CreateUser : ICommand
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }
    }
}
