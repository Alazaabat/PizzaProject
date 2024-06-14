using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PizzaProject.Utilities
{
    internal static class FileInputOutput
    {
        public static void WriteObject(string path,object o)
        {
            using (FileStream file=new FileStream(path,FileMode.Append))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(file, o);
            }
        }
        public static Object ReadObject(string path)
        {
            object result = null;
            using (FileStream file = new FileStream(path, FileMode.Open))
            {
                IFormatter formatter = new BinaryFormatter();
                try
                {
                    result = formatter.Deserialize(file);
                }
                catch (Exception ex)
                {
                }

            }
            return result;
        }
        public static Object ReadObject(FileStream file)
        {
                object result = null;
                IFormatter formatter = new BinaryFormatter();
            try
            {
                result = formatter.Deserialize(file);
            }
            catch (Exception ex)
            {
            }
            return result;
        }
        public static void WriteObject(FileStream file,object obj)
        {
            if (obj is null)
                return;


            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(file,obj);

        }




    }
}
