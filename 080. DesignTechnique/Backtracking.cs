using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _080._DesignTechnique
{
    internal class Backtracking
    {
        /* 백 트래킹 */
        // 폴더 삭제

        void RemoveDir(Directory directory)
        {
            foreach (Directory dir in directory.childDir)
            {
                RemoveDir(dir);
            }

            Console.WriteLine("폴더 내 파일 모두 삭제");
        }

        struct Directory
        {
            public List<Directory> childDir;
        }
    }
}