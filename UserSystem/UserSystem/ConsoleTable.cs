using System;

namespace UserSystem
{
    internal class ConsoleTable
    {
        private string v1;
        private string v2;
        private string v3;

        public ConsoleTable(string v1, string v2, string v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        internal void AddRow(int v1, int v2, int v3)
        {
            throw new NotImplementedException();
        }

        internal void Write()
        {
            throw new NotImplementedException();
        }
    }
}