﻿using System;
namespace PrototypeCheckoutSystem
{
    public class MenuItem
    {
        public string Description { get; set; }
        public Action Execute { get; set; }
    }
}
