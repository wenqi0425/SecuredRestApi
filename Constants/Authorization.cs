﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecuredRestApi.Constants
{
    public class Authorization
    { 
        // User Roles 

        public enum Roles
        {
            Administrator,
            Moderator,
            User
        }

        // mock data: default user with default roles
        public const string default_username = "user";
        public const string default_email = "user@secureapi.com";
        public const string default_password = "Pa$$w0rd.";
        public const Roles default_role = Roles.User;
    }
}