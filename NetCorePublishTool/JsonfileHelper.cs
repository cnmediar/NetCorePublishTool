using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
namespace NetCorePublishTool

{

     public sealed class JsonfileHelper
        {
            static JsonfileHelper instance = null;

          
            public List<PathItem> m_path = new List<PathItem>();

            //基础数据文件路径
            private string sBaseDataFile;

            //任务数据文件路径
            private string sTaskFile;


            private JsonfileHelper()
            {
                string sPath = System.IO.Directory.GetCurrentDirectory();
           
                sTaskFile = sPath + "\\path.json";
            }

            public static JsonfileHelper Instance
            {
                get
                {
                    if (instance == null)
                    {
                        instance = new JsonfileHelper();
                    }
                    return instance;
                }
            }


        

            public List<PathItem> getTaskList()
            {
                return m_path;
            }

        public int addPath(PathItem path)
        {
            m_path.Add(path);

            saveTask();
            return m_path.Count;
        }



            public List<PathItem> loadTask()
            {
                m_path.Clear();
                if (File.Exists(sTaskFile) == false)
                    return m_path;

                string json = File.ReadAllText(sTaskFile);
                if (json.Length <= 0)
                    return m_path;

                JArray arTask = JArray.Parse(json);
                foreach (JObject task in arTask)
                {
                    PathItem item = new PathItem();
                  
                    item.ProjectPath =  (task["ProjectPath"].ToString());
                    item.PublishPath =  (task["PublishPath"].ToString());                


                    m_path.Add(item);
                }

               return m_path;
            }

 

         


            public void saveTask()
            {
                string json = JsonConvert.SerializeObject(m_path);

                File.Delete(sTaskFile);

                FileStream fs = new FileStream(sTaskFile, FileMode.OpenOrCreate);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(json);
                sw.Flush();
                sw.Close();
                fs.Close();
            }


        }
    }

 
