using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge1
{
    class Inner
    {
        public class Private

        {

            public bool Power(int n)

            {

                if (n == 0)

                    return false;

                while (n != 1)

                {

                    if (n % 2 != 0)

                        return false;

                    n = n / 2;

                }

                return true;

            }
        }
    }
}
