using System;
using System.Collections;
using System.Windows.Forms;

namespace WinForms_interface
{
    public enum StoreSortMode : sbyte
    {
        Asc = 1,
        Desc = -1
    }

    class Store
    {
        ArrayList storeGoods;
        delegate sbyte DelSortByExpDate(GroceryGoods g1, GroceryGoods g2);

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

     

        
        public void SortByExpDate(StoreSortMode mode)
        {
            uint numOfReplacements = 1;
            uint cnt = (uint)storeGoods.Count;

            ArrayList tmp = new ArrayList();
            ArrayList sorted = (ArrayList)storeGoods.Clone();

            DelSortByExpDate sort = delegate (GroceryGoods g1, GroceryGoods g2)
            {
                if (g1.ExpDate > g2.ExpDate)
                    return 1;
                else if (g1.ExpDate < g2.ExpDate)
                    return -1;
                else
                    return 0;
            };


            while (numOfReplacements > 0) {
                tmp = new ArrayList();
                numOfReplacements = 0;
                
                for (int i = 0; i < cnt-1; i++)
                {
                    GroceryGoods g1 = (GroceryGoods)sorted[i];
                    GroceryGoods g2 = (GroceryGoods)sorted[i+1];
                    
                    if (sort(g1, g2) == (sbyte)mode)
                    {
                        tmp.Add(g2);
                        tmp.Add(g1);
                        numOfReplacements++;
                    } else
                    {
                        tmp.Add(g1);
                        tmp.Add(g2);
                    }
                }

                sorted = (ArrayList)tmp.Clone();
                tmp = null;
            }

            storeGoods = (ArrayList)sorted.Clone();
            sorted = null;
        }
    }
}
