using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQS.JeitoErrado
{
    public class FileStore
    {
        public string WorkingDirectory { get; set; }
        public string Save(int id, string message)
        {
            var path = Path.Combine(this.WorkingDirectory, id + ".txt");
            File.WriteAllText(path, message);

            return path;
        }

        public EventHandler<MessageEventArgs> MessageReader;

        public void Read(int id)
        {
            var path = Path.Combine(this.WorkingDirectory, id + ".txt");
            var msg = File.ReadAllText(path);

            MessageReader(this, new MessageEventArgs() { Message = msg });
        }
    }

    public class MessageEventArgs : EventArgs
    {
        public string Message { get; set; }
    }
}
