using System;
using System.Collections.Generic;
using System.Text;

namespace _00_ReferenceMaterials.Inheritence
{
    #region "Base" Class

    public abstract class Shape
    {
        /// <summary>
        /// virtual class that CAN be overridden in the "Inherited Classes"
        /// </summary>
        /// <returns></returns>
        public virtual int Perimeter()
        {
            return 0;
        }
        public abstract int Area();
    }

    #endregion
    
    #region Inherited "Rectagle" Class

    public class Rectangle : Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public override int Perimeter()
        {
            return (Height + Width) * 2;
        }
        public override int Area()
        {
            throw new NotImplementedException();
        }

    }

    #endregion

    #region Inherited "Triangle" Class

    public class Triangle : Shape
    {
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }

        public override int Perimeter()
        {
            return Side1 + Side2 + Side3;
        }

        public override int Area()
        {
            throw new NotImplementedException();
        }

    }

    #endregion

}
