using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Santarsieri.Andrea.Gatto._4H
{
    class Punto
    {
        int _x;
        int _y;
        public int X
        {
            get
            {
                return _x;
            }

            set

            {
                _x = value;
            }
        }
        public int Y
        {
            get
            {
                return _y;
            }

            set

            {
                _y = value;
            }
        }
        public Punto(int x, int y)
        {
            _x = x;
            _y = y;
        }
        public Punto Trasla(int tx, int ty)
        {
            Punto z = new Punto(0, 0);

            z._x = this._x + tx;
            z._y = this._y + ty;

            return z;
        }
        public Punto Scala(int sx, int sy)
        {
            Punto z = new Punto(0, 0);

            z._x = this._x * sx;
            z._y = this._y * sy;

            return z;


        }
    }
}
