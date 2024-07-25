using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carIndex
{
    public class Cars
    {
        double price;
        int milage;
        string model , year, engineCap;

        public Cars(string enigineCap, string model, string year, int milage, double price)
        {
            this.engineCap = enigineCap;
            this.model = model;
            this.year = year;
            this.milage = milage;
            this.price = price;
        }
        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return this.price;
                else if (index == 1)
                    return this.milage;
                else if (index == 2)
                    return this.engineCap;
                else if (index == 3)
                    return this.model;
                else if (index == 4)
                    return this.year;

                return null;
            }
            set
            {
                if (index == 0)
                    this.price = (double)value;
                else if (index == 1)
                    this.milage = (int)value;
                else if (index == 2)
                    this.engineCap = (string)value;
                else if (index == 3)
                    this.model = (string)value;
                else if (index == 4)
                    this.year = (string)value;

            }
        }
        public object this[string attrName]
        {
            get
            {
                if (attrName.ToLower().Equals("empNUmber"))
                    return this.price;
                if (attrName.ToLower().Equals("jobtitle"))
                    return this.milage;
                if (attrName.ToLower().Equals("enigineCap"))
                    return this.engineCap;
                if (attrName.ToLower().Equals("model"))
                    return this.model;
                if (attrName.ToLower().Equals("year"))
                    return this.year;

                return null;

            }
            set
            {
                if (attrName.ToLower().Equals("empnumber"))
                    this.price = (double)value;
                if (attrName.ToLower().Equals("jobtitle"))
                    this.milage = (int)value;
                if (attrName.ToLower().Equals("enigineCap"))
                    this.engineCap = (string)value;
                if (attrName.ToLower().Equals("model"))
                    this.model = (string)value;
                if (attrName.ToLower().Equals("year"))
                    this.year = (string)value;
            }
        }

    }
}
