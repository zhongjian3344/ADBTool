using System;
using System.IO;
using System.Data;


namespace SynCommon
{
    public class SynCommon
    {
       
        //�õ�����·��
        public static string GetAssemblyPath()
        {
            return Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        }

        // �õ��ļ�·��
        public static string GetFilePath(string fileName)
        {
            return GetAssemblyPath() + "\\" + fileName;
        }

    }
}
