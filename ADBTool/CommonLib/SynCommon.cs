using System;
using System.IO;
using System.Data;


namespace SynCommon
{
    public class SynCommon
    {
       
        //得到程序路径
        public static string GetAssemblyPath()
        {
            return Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }

        // 得到文件路径
        public static string GetFilePath(string fileName)
        {
            return GetAssemblyPath() + "\\" + fileName;
        }

    }
}
