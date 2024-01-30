using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UwcAppShellExample.Models;

namespace UwcAppShellExample.Interfaces
{
    internal interface IMonkeyMaker
    {
        public List<Monkey> Monkeys { get; set; }
    }
}
