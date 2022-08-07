using System.Text;

namespace Subscription_Tracker
{
    public class FileStreamUpdater : IDisposable
    {
        private FileStream _fileStream;
        private bool disposedValue;

        public FileStreamUpdater(string filename)
        {
            _fileStream = File.Open(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            if (_fileStream.Length == 0)
            {
                WriteFile("0");
            }
        }

        public string ReadFile ()
        {
            _fileStream.Seek(0, SeekOrigin.Begin);
            byte[] fileContents = new byte[1024];
            _fileStream.Read(fileContents, 0, 1024);
            _fileStream.Seek(0, SeekOrigin.Begin);
            return Encoding.ASCII.GetString(fileContents);
        }

        public async void WriteFile(string text)
        {
            byte[] textBytes = Encoding.ASCII.GetBytes(text);

            _fileStream.Seek(0, SeekOrigin.Begin);
            _fileStream.SetLength(0);
            await _fileStream.WriteAsync(textBytes, 0, textBytes.Length);
            await _fileStream.FlushAsync();
            _fileStream.Seek(0, SeekOrigin.Begin);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                _fileStream.Dispose();
                disposedValue = true;
            }
        }

        protected virtual async Task DisposeAsync(bool disposing)
        {
            if (!disposedValue)
            {
                await _fileStream.DisposeAsync();
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}