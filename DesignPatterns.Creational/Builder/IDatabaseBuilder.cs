using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public interface IDatabaseBuilder
    {
        Database Database { get; }

        void BuildConnection();

        void BuildCommand();

        void SetSettings();
    }
}
