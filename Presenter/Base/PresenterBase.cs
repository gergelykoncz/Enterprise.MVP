
namespace Presenter.Base
{
    public abstract class PresenterBase<T>
    {
        protected T View;

        public void Init(T view)
        {
            this.View = view;
            this.Init();
        }

        protected virtual void Init()
        {
        }
    }
}
