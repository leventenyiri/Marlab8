using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Signals
{
    public class SignalDocument : Document
    {
        private List<SignalValue> SignalValues;

        public SignalDocument(string name) : base(name)
        {
            SignalValues = new List<SignalValue>();
            DateTime time = new DateTime(2024, 8, 4, 23, 58, 30, 34);
            SignalValues.Add(new SignalValue(1, time));
            SignalValues.Add(new SignalValue(4,new DateTime(2024, 8, 30, 13, 40, 32, 41)));
            SignalValues.Add(new SignalValue(14, new DateTime(2024,9, 1,12,10,50, 120)));
            SignalValues.Add(new SignalValue(20, new DateTime(2024,9,4,15,30,40,55)));
            SignalValues.Add(new SignalValue(10, new DateTime(2024,9,6,4,40,30,200)));

        }

        
        public override void SaveDocument(string filePath)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (SignalValue q in SignalValues)
                {
                    string dt = q.TimeStamp.ToUniversalTime().ToString("o");
                    //q.Value.ToString()
                    sw.WriteLine($"{q.Value.ToString()}\t{dt}");

                }

            }
            
        }

        public override void LoadDocument(string filePath)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() != DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        string fileContent = reader.ReadToEnd();
                        fileContent = fileContent.Trim();
                        string[] columns = fileContent.Split('\t');

                        for (int i = 0; i < columns.Length; i++)
                        {
                            if (i % 2 == 0 || i == 0)
                                double d = double.Parse(columns.GetValue(i));
                            else
                                DateTime dt = DateTime.Parse(columns.GetValue(i));

                        }
                    }




                }
            }
        }
    }
}
