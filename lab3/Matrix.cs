
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба3
{
    public class Matrix<T>
    {
        Dictionary<string, T> mtrx = new Dictionary<string, T>();
        int maxX;//максимальное колличесвто элементов по X
        int maxY;//максимальное колличесвто элементов по Y
        int maxZ;//максимальное колличесвто элементов по Z
        T nullElement;
        public Matrix(int py, int px, int pz, T pnullElement)
        {
            this.maxX = px;
            this.maxY = py;
            this.maxZ = pz;
            this.nullElement = pnullElement;
        }
        //индексатор для доступа к данным
        public T this[int x, int y, int z]
        {
            set
            {
                CheckBounds(x, y, z);
                string key = DictKey(x, y, z);
                this.mtrx.Add(key, value);
            }
            get
            {
                CheckBounds(x, y, z);
                string key = DictKey(x, y, z);
                if (this.mtrx.ContainsKey(key))
                {
                    return this.mtrx[key];
                }
                else
                {
                    return this.nullElement;
                }


            }
        }
        void CheckBounds(int x, int y, int z)
        {
            if ((x < 0) || (x > this.maxX)) throw new ArgumentOutOfRangeException("X", "X=" + x + " выходит за границы.");
            if ((y < 0) || (y > this.maxY)) throw new ArgumentOutOfRangeException("Y", "Y=" + x + " выходит за границы.");
            if ((z < 0) || (z > this.maxZ)) throw new ArgumentOutOfRangeException("Z", "Z=" + x + " выходит за границы.");
        }
        string DictKey(int x, int y, int z)
        {
            return x.ToString() + " " + y.ToString() + " " + z.ToString();
        }
        public override string ToString()
        {
            StringBuilder b = new StringBuilder();
            for (int k = 0; k < this.maxY; k++)
            {
                b.Append("[");
                for (int j = 0; j < maxY; j++)
                {
                    if (j > 0) b.Append("\t");
                    b.Append("[");
                    for (int i = 0; i < maxX; i++)
                    {
                        if (this[i, j, k] != null)
                            b.Append(this[i, j, k].ToString());
                        else
                            b.Append("0");
                        if (i != (maxX - 1)) b.Append(", ");
                    }
                    b.Append("]");
                }

                b.Append("]\n");
            }
            return b.ToString();
        }
    }
}
