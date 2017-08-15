using DevEnvPrimer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevEnvPrimer.ViewModels
{
    public class HomeViewModel
    {

        public HomeViewModel()
        {
            ClientAddress = new Address();
            NewClient = new Client();
        }

        public Address ClientAddress { get; set; }

        public Client NewClient { get; set; }
    }
}