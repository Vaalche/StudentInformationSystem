using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    class DataContext
    {
        private static List<String> oksChoices;

        public static List<String> OksChoices
        {
            get
            {
                return new List<String>() { "бакалавър", "магистър", "доктор", "пр." };
            }

            set
            {
                oksChoices = value;
            }
        }

        public static String SelectedOksChoice { get; set; }

        public String SelectedStudentFacNumber { get; set; }

    }
}
