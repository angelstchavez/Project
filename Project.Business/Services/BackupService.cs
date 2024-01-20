using Project.Data.Connection;

namespace Project.Business.Services
{
    public class BackupService
    {
        private readonly Backup backup;

        public BackupService()
        {
            this.backup = new Backup();
        }

        public bool Generate(string backupFilePath)
        {
            return this.backup.Generate(backupFilePath); 
        }
    }
}
