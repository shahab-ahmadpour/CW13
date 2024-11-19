﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_Week13.Entities;

public class Category
{
    public int CategoryId { get; set; } 
    public string CategoryName { get; set; }
    public string Description { get; set; }
    public string Picture { get; set; }

    public ICollection<Product> Products { get; set; } = new List<Product>();
}

