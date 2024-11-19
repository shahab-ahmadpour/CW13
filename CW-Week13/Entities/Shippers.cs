using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_Week13.Entities;

public class Shipper
{
    public int ShipperId { get; set; }
    public string CompanyName { get; set; }
    public string Phone { get; set; }

    public ICollection<Order> Orders { get; set; } = new List<Order>();
}

