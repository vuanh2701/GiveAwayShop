namespace ReuseShop.Data.Infrastructure
{
    public class Disposable : IDisposable
    {
        private bool isDisposed;

        ~Disposable()
        {
            Dispose(false);
        }
        public void Dispose()
        {
            Dispose(true);
            // thu hoi bo nho
            GC.SuppressFinalize(this);
        }
        private void Dispose (bool disposing)
        {
            if(!isDisposed && disposing)
            {
                DisposeCore();
            }isDisposed = true;
        }
        
        // Overide this to dispose custom object
        protected virtual void DisposeCore()
        {

        }
    }
}
