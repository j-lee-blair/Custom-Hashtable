//Julian 14/09/22
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning2
{
    class Entry
    {
        private object my_Key;//the index of the key
        private object my_Value; //the value associated with the key

        public object GetKey { get {return my_Key; } }
        public object GetValue { get {return my_Value;} }


        /// <summary>
        /// Initializes a new instance of the <see cref="Entry"/> class.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        public Entry (object key, object value)
        {
            this.my_Key = key;
            this.my_Value = value;
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" }, is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj) //this compares the input (keyValue) with 
        {
            Entry keyValue = (Entry)obj;
            return my_Key.Equals(keyValue.my_Key);
        }
        
    }
}
