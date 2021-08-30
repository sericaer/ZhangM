using System;
using System.Collections.Generic;
using System.Text;

namespace ZhangM
{
    public class ProductManager
    {
        private Dictionary<string, IProduct> all;

        public IProduct this[string index]
        {
            get
            {
                return all[index];
            }
        }

        public ProductManager()
        {
            all = new Dictionary<string, IProduct>();
        }
    }
}
