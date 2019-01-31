using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ApplicationLayer
{
    public class Program
    {

        static void Main(string[] args)
        {
            Menu menu = new Menu();
            Program program = new ApplicationLayer.Program();
            menu.Run();
        }
    }
}
