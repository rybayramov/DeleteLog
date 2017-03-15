using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeleteLogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo source = new DirectoryInfo(System.IO.Directory.GetCurrentDirectory());

            foreach (FileInfo fi in source.GetFiles())
            {
                if (fi.Extension == ".log")
                {
                    var creationTime = fi.Name.Substring(0, 8);

                    if (DateTime.ParseExact(creationTime,
                                      "yyyyMMdd",
                                       CultureInfo.InvariantCulture) < (DateTime.Now - new TimeSpan(7, 0, 0, 0)))
                    {
                        fi.Delete();
                    }
                }
            }
        }
    }
}
