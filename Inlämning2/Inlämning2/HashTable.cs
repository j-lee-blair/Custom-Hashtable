//Julian 14/09/22
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inlämning2
{
    class HashTable
    {
        private LinkedList<object> insertionOrder = new LinkedList<object>();   //this keeps track of the order in which elements are inserted
        private LinkedList<Entry>[] table;                                      //this is the vector (it consists of a list of keys and associated elements)
        public int Count{ get { return insertionOrder.Count; }}                 //returns the number of elements in the hash table
        


        /// <summary>
        /// constructor decides the size of the vectors and initializes all the elements
        /// </summary>
        /// <param name="size">The size.</param>
        public HashTable(int size) 
        {
            table = new LinkedList<Entry>[size]; //this is the hash table

            for (int i = 0;  i < size; i++)
            {
                table[i] = new LinkedList<Entry>(); //a linked list is added at each index of the hash table
            }
        }

        /// <summary>
        /// Generates a hash index value for a specific key
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>Index</returns>
        private int HashIndex(object key)
        {
            if (key != null)
            {
                int hashCode = key.GetHashCode();

                hashCode = hashCode % table.Length;//modulus operation works out the remainder and uses this as the index value

                return (hashCode < 0) ? -hashCode : hashCode;//if the hashvalue is not negative it is converted to positive
            }
            else
            {
                MessageBox.Show("Key not found.");
                return 0;
            }
        }


        /// <summary>
        /// Gets the specified key. If it is found it returns its associated value.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        public object Get(object key) 
        {


            int hashIndex = HashIndex(key);// ←----- Finds the key's index
       
            if(table[hashIndex].Contains(new Entry(key, null)))//←---- if the key exists in the table
            { 
                    Entry entry = table[hashIndex].Find(new Entry(key, null)).Value;// <--- Searches for the key value
                    return entry.GetValue;// <---- returns the key's value
            }
            return null;
        }


        //public LinkedList<object> GetInserionOrder() - Returnera den länkade listan 'insertionOrder'.
        /// <summary>
        /// Gets the insertion order.
        /// </summary>
        /// <returns></returns>
        public object GetInsertionOrder(LinkedList<object> i_Order)
        {
            i_Order = insertionOrder;
            return insertionOrder;
        }

        /// <summary>
        /// The method adds a new Entry to the hash table IF the key is not already there. Add also the value to the InsertionOrder at the last position in the list.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        public void AddValue(object key, object value)
        {
            if (Get(key) == null)                   //Look in the hashtable
            {
                                                    //If the Input does not match an entry in the hashtable
                table[HashIndex(key)].AddFirst(new Entry(key, value));
                insertionOrder.AddFirst(value);     //Add the value to the Insertion Order List
            }
        }

           
        /// <summary>
        /// The method removes an Entry from the hash table IF the key is found. It then removes the value from the Insertion Order List's LAST position.
        /// </summary>
        /// <param name="key">The key.</param>
        public void RemoveValue(object key)
        {
            if (Get(key) != null)
            {
                table[HashIndex(key)].Remove(new Entry (key, null));
                GetInsertionOrder(insertionOrder);
                insertionOrder.RemoveLast();
            }
            else
            {
                MessageBox.Show("Value entered was not found in list.");
            }
        }


        /// <summary>
        /// Translates the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        public void Translate(object key)
        {
            if (Get(key) != null)
            {
                MessageBox.Show("Translation: " + Get(key).ToString());
            }
        }
    }
}
