namespace PasswordManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal class Data
    {
        public string Alias { get; set; }
        public string PWD { get; set; }
        public override string ToString() => Alias;
    }
    internal class PWDObj
    {
        public List<Data> Data { get; set; } = new List<Data>();
    }
}
