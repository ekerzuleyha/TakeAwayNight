﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeAwayNight.Application.Features.CQRS.Commands.AddressCommands
{
    //public class RemoveAddressCommand
    //{
    //    public int Id { get; set; }

    //    public RemoveAddressCommand(int id)
    //    {
    //        Id = id;
    //    }
    //}

    public class RemoveAddressCommand
    {
        public int Id { get; set; }
        public RemoveAddressCommand(int id)
        {
            Id = id;
        }
    }
}
