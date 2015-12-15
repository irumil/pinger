using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using PingServersManager.Abstract;

namespace PingServersManager.Concreate
{
    public class XmlServerListManager: IServerListManager
    {
       private readonly string _fileName;

       public XmlServerListManager(string fileName = "listServer.xml")
       {
           _fileName = fileName;
       }

       public string GetFileName()
       {
            return _fileName;
       }

       public List<ServerInfo> GetServerList()
       {
            List<ServerInfo> serversList = new List<ServerInfo>();
            if (!File.Exists(_fileName)) return serversList;
            
            using (StreamReader streamReader = new StreamReader(_fileName))
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<ServerInfo>));
                    serversList = (List<ServerInfo>)serializer.Deserialize(streamReader);
                }
                catch (Exception e)
                {
                    throw new Exception(string.Format("{0} - {1}",
                        "Ошибка в списке серверов, удалите XML файл со списком серверов", e.Message));                        
                }
            }

            return serversList;
        }

       public void SaveServerList(List<ServerInfo> serverList)
       {
            XmlSerializer serialiser = new XmlSerializer(typeof(List<ServerInfo>));
            using (TextWriter fileStream = new StreamWriter(_fileName))
            {
                try
                {
                    serialiser.Serialize(fileStream, serverList.ToList());
                } 
                catch (IOException e)
                {
                    throw new Exception(string.Format("{0} - {1}", 
                        "Не удалось сохранить список серверов ", e.Message));
                }
            }
        }

       }
}
