using System;
using System.Reflection.Metadata.Ecma335;

namespace Ver8.ReadonlyMembers
{
    // https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8
    
    public class Example
    {
        public void MyMethod()
        {
            //ReadonlyMembers varia = new ReadonlyMembers(4)
            //{
            //    RwProperty = 5
            //};
            //Console.WriteLine(varia.RoMethod());
        }
    }
    /// <summary>
    /// Members of structs can be marked as readonly
    /// Does not work for classes
    /// </summary>
    public struct ReadonlyMembers
    {
        public readonly int _roField;

        private int _rwField;

        public readonly int RoProperty { get; }

        //Readonly-Properties with setter not allowed:
        //public readonly int RoProperty { get; set; }  //Error CS8659  Auto-implemented property 'ReadonlyMembers.RoProperty' cannot be marked 'readonly' because it has a 'set' accessor.


        public int RwProperty { get { return _rwField; } set { _rwField = 2 * value; } }

        public readonly string RoMethod()
        {
            return string.Empty;
        }

        public ReadonlyMembers(int fieldValue)
        {
            _roField = fieldValue;
            _rwField = fieldValue;
            RoProperty = _roField * 2;
        }
    }
}
