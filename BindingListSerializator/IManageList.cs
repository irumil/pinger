using System.ComponentModel;

namespace BindingListSerializator
{
    public interface IManageList<T>
    {
        void SaveList(BindingList<T> serverList);

        BindingList<T> ReadList();
    }
}
