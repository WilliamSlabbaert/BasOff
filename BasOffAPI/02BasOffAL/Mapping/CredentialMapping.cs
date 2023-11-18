using _01BasOffEL.Entities;
using _02BasOffBL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02BasOffBL.Mapping
{
    public static class CredentialMapping
    {
        public static UserCredentialsEntity BaseCredentialMapping(UserCredentialsDTO credentials)
        {
            var response = new UserCredentialsEntity() { 
                Password = credentials.Password,
                Username = credentials.Username,
            };
            return response;
        }
    }
}
