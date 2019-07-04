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
    }
}
