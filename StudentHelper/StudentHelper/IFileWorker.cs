using StudentHelper.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StudentHelper
{
    public interface IFileWorker
    {
        void SaveDataAsync(string filename, Term obj);   // сохранение текста в файл
        Term LoadDataAsync(string filename);  // загрузка текста из файла
    }
}
