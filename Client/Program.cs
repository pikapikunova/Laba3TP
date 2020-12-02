using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ChannelFactory<ClassLibrary.IClass> factory = new ChannelFactory<ClassLibrary.IClass>("class1TCP");
            ClassLibrary.IClass clService = factory.CreateChannel();

            //ChannelFactory<ClassLibrary.IClass> factory = new ChannelFactory<ClassLibrary.IClass>("class1Http");
            //ClassLibrary.IClass clService = factory.CreateChannel();


            //double r = clService.first(51, 159, 20, true, 1.2);

            Application.Run(new Form1(clService));
        }
    }
}
