﻿using ParsiCoin.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParsiCoin
{
    public class Account : IPICObject
    {
        public Guid ID { get; private set; }
        public string HashStirng { get; set; }
        public string ComputeObjectHash()
        {
            throw new NotImplementedException();
        }

        public bool Equal(IPICObject obj)
        {
            throw new NotImplementedException();
        }
    }
}
