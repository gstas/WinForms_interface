using System;
using System.Collections;

namespace WinForms_interface
{
    class Store
    {
        ArrayList storeGoods;

        public ArrayList StoreGoods { get => storeGoods; set => storeGoods = value; }

        public Store()
        {
            storeGoods = new ArrayList();
        }

        public int[] GetExpired()
        {
            int[] result = new int[0];
            for (int i = 0; i < storeGoods.Count; i++)
            {
                if (((GroceryGoods)storeGoods[i]).ExpDate < DateTime.Today)
                {
                    Array.Resize<int>(ref result, result.Length+1);
                    result[result.Length-1] = i;
                }
            }
            return result;
        }
    }
}
