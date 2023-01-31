//@CodeCopy
//MdStart
using ReactiveUI;
using System.Runtime.CompilerServices;

namespace QTChinnok.MvvMApp.ViewModels
{
    public class BaseViewModel : ReactiveObject
    {
        protected virtual void OnPropertyChanged([CallerMemberName]string? propertyName = null)
        {
            this.RaisePropertyChanged(propertyName);
        }
    }
}
//MdEnd
