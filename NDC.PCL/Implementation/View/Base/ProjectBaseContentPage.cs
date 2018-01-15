using NDC.Base;
using NDC.Implementation.Repository;
using Xamarin.Forms;

namespace NDC.Implementation.View
{
    public abstract class ProjectBaseContentPage<T, M> : ContentPage
        where T: ProjectBaseViewController<M>, new()
        where M: ProjectBaseViewModel, new()
    {
        protected T _ViewController;

        protected ProjectBaseContentPage()
        {
			_ViewController = new T();
			_ViewController.InputObject = new M();
			SetSVGCollection();
            _ViewController._MasterRepo = MasterRepository.MasterRepo;
            _ViewController.SetRepositories();
        }

        protected abstract void SetSVGCollection();
    }
}
