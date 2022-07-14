using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FileReader
{
    // text reader  
    [INotifyPropertyChanged]
    public partial class MainViewModel
    {
        OpenFileDialog openFile { get; set; }
        SaveFileDialog saveFile { get; set; }
        string fileName { get; set; } 
        FileInfo fileInfo { get; set; }
        public MainViewModel()
        {
            openFile = new OpenFileDialog();
            saveFile = new SaveFileDialog(); 
           //fileInfo = new FileInfo(fileName);
           fileName = "Documnet"; 
        }
        [ICommand]
        void Open()
        {
            bool? result = openFile.ShowDialog();

            if (result == true)
            {
                fileName = openFile.FileName;
            } 
           
        }
        [ICommand]
        void Save()
        {
                       saveFile.FileName = "Document"; // Default file name
            saveFile.DefaultExt = ".txt"; // Default file extension
            saveFile.Filter = "Text documents (.txt)|*.txt"; // Filter files by extension

            // Show save file dialog box
            bool? result = saveFile.ShowDialog();

            // Process save file dialog box results
            if (result == true)
            {
                // Save document
                string filename = saveFile.FileName;
            }

        }


        //Thread thread = new Thread(() =>
        //{

        //    int i = 0;
        //    while (i++ < 10)
        //    {
        //        Interlocked.And(ref total, 2); // total += 2;
        //        Interlocked.Increment(ref total); // total++;
        //    }
        //});
    }
}
