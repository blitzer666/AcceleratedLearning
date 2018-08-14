using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapeList = AskForListOfShapes();
            PrintAllShapes(shapeList);
            ReportAreaOfShapes(shapeList);
        }
        private void ReportAreaOfShapes(List<Shape> shapeList);
        {
    }
}
