using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week14.Objects;
using Week14.Views;

namespace Week14
{
    public static class Program
    {
        //
        public static CharacterPortfolio character;
        public static Identity identity;
        public static Skill skill;

        public static CharactorGenerationForm charactorForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            charactorForm = new CharactorGenerationForm();
            
            Application.Run(charactorForm);
        }
    }
}
