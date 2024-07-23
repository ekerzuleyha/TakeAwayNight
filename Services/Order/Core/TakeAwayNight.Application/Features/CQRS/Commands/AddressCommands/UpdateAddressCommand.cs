﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeAwayNight.Application.Features.CQRS.Commands.AddressCommands
{
    //public class UpdateAddressCommand
    //{
    //    public int AddressId { get; set; }
    //    public string UserId { get; set; }
    //    public string Name { get; set; }
    //    public string Detail { get; set; }
    //    public string City { get; set; }
    //    public string District { get; set; }
    //}

    public class UpdateAddressCommand
    {
        public int AddressId { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public string City { get; set; }
        public string District { get; set; }
    }
}