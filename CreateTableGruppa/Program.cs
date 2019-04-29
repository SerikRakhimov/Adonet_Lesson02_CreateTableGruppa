using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTableGruppa
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataService = new DataService();
            dataService.CreateGruppa();
        }
    }
}
