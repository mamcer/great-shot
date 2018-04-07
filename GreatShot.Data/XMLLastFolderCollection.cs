using System.Collections;
using System.IO;
using System.Reflection;
using System.Xml;

namespace GreatShot.Data
{
    public class XmlLastFolderCollection : ILastFolderCollection
    {
        private static XmlLastFolderCollection _instance;
        private static readonly object LockObject = new object();
        private ArrayList _lastFolders;
        private string _xmlFilePath;

        public string XmlFilePath
        {
            get
            {
                if (string.IsNullOrEmpty(_xmlFilePath))
                {
                    _xmlFilePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), ".lastfolderpaths.xml");
                }

                return _xmlFilePath;
            }
        }

        public ArrayList LastFolders
        {
            get
            {
                if (_lastFolders == null)
                {
                    _lastFolders = new ArrayList();
                }

                return _lastFolders;
            }
        }

        private XmlLastFolderCollection()
        {
            ReadXmlFile();
        }

        private void ReadXmlFile()
        {
            if (File.Exists(XmlFilePath))
            {
                XmlTextReader reader = new XmlTextReader(XmlFilePath);
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:
                            if (reader.Name == "LastFolderPath")
                            {
                                LastFolders.Add(reader.GetAttribute("path"));
                            }

                            break;
                    }
                }

                reader.Close();
            }
        }

        private void WriteXmlFile()
        {
            var writer = new XmlTextWriter(XmlFilePath, null);
            writer.WriteStartDocument();
            writer.WriteComment("\nGreat Shot last folder paths xml file.");
            writer.Formatting = Formatting.Indented;
            writer.WriteStartElement("LastFolderPaths");

            for (int i = 0; i < LastFolders.Count; i++)
            {
                writer.WriteStartElement("LastFolderPath");
                writer.WriteAttributeString("path", LastFolders[i].ToString());
                writer.WriteEndElement();
            }

            writer.WriteEndElement();
            writer.Close();
        }

        public static XmlLastFolderCollection Instance
        {
            get
            {
                lock (LockObject)
                {
                    if (_instance == null)
                    {
                        _instance = new XmlLastFolderCollection();
                    }
                }

                return _instance;
            }
        }

        public string Get(int index)
        {
            if (index < LastFolders.Count)
            {
                return LastFolders[index].ToString();
            }

            return string.Empty;
        }

        public void Add(string folderPath)
        {
            if (!LastFolders.Contains(folderPath))
            {
                LastFolders.Insert(0, folderPath);
            }

            if (LastFolders.Count > 10)
            {
                LastFolders.RemoveRange(10, LastFolders.Count - 10);
            }
        }

        public int Count()
        {
            return LastFolders.Count;
        }

        public void Remove(int index)
        {
            if (index < LastFolders.Count)
            {
                LastFolders.RemoveAt(index);
            }
        }

        public void Save()
        {
            WriteXmlFile();
        }
    }
}