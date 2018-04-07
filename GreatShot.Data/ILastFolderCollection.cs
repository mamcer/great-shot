namespace GreatShot.Data
{
    public interface ILastFolderCollection
    {
        string Get(int index);

        void Add(string folderPath);

        void Remove(int index);

        int Count();

        void Save();
    }
}