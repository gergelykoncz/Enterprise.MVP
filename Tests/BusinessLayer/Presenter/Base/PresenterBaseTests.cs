using Moq;
using Moq.Protected;
using NUnit.Framework;
using Presenter.Base;

namespace Tests.BusinessLayer.Presenter.Base
{
    [TestFixture]
    public class PresenterBaseTests
    {
        [Test]
        public void InitMethodMustCallProtectedInit()
        {
            var presenter = new Mock<PresenterBase<object>>(MockBehavior.Strict);
            presenter.Protected().Setup("Init");
            presenter.Object.Init(new object());
            presenter.Protected().Verify("Init", Times.Once());
        }
    }
}
