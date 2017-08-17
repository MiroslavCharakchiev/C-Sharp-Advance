using System;
using System.Runtime.InteropServices;
using System.Text;

namespace _03.Detail_Printer
{
    using System.Collections.Generic;

    public class Manager : Employee
    {
        public Manager(string name, ICollection<string> documents) : base(name)
        {
            this.Documents = new List<string>(documents);
        }

        public IReadOnlyCollection<string> Documents { get; set; }

        public override string ToString()
        {
            var sb  =new StringBuilder();
            
            foreach (var document in this.Documents)
            {
                sb.AppendLine($"--{document}");
            }
            return base.ToString()+ Environment.NewLine + sb.ToString();
        }
    }
}
