using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.AppLogic.Services
{
    public class CalculatorService : ICalculatorService
    {
        public string Calculate()
        {
            return "test";
        }
    }
}
