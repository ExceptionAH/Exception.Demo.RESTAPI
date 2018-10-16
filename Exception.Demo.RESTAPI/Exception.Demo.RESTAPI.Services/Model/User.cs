using System;
using System.Collections.Generic;
using System.Text;

namespace Exception.Demo.RESTAPI.Services.Model
{
    public class User
    {
        public string Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Adress Adress { get; set; }

    }
}
