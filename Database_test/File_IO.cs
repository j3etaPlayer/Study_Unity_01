using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_test
{
    internal class File_IO
    {
        // File, Directory(folder), Stream
        // Stream 스트림 : 시간의 흐름에 따라 연속적으로 발생하는 데이터의 흐름
        // IO 데이터를 저장하고 불러올때 상요하는 클레스 이름, 스트림이 연결되어있어야 한다.

        void ReadStream()
        {
            string data;
            StreamReader reader = new StreamReader(@"C:\Sample.test.txt");

            data = reader.ReadLine();
            
            while (data != null)
                data = reader.ReadLine();

            reader.Close();
        }
        void WriteStream()
        {
            StreamWriter writer = new StreamWriter(@"C:\Sample.test.txt");

            writer.WriteLine("여기에는 데이터가 들어갑니다");

            writer.Close();
        }
    }
}
