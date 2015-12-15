using System;
using System.ComponentModel;

namespace BindingListSerializator
{
    class JsonManagerList<T> : IManageList<T> where T : new()
    {
        public void SaveList(BindingList<T> serverList)
        {
            throw new NotImplementedException();
        }

        public BindingList<T> ReadList()
        {
            throw new NotImplementedException();
        }
    }
}
