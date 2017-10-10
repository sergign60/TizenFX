using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ElmSharp.Wearable
{
    class MoreOptionList : IList<MoreOptionItem>
    {
        MoreOption Owner { get; set; }

        List<MoreOptionItem> Items { get; set; }

        /// <summary>
        /// Sets or gets the count of Items
        /// </summary>
        public int Count => Items.Count;

        /// <summary>
        /// Sets or gets whether it is read only
        /// </summary>
        public bool IsReadOnly => false;

        /// <summary>
        /// Sets or gets the item with the index
        /// </summary>
        /// <param name="index">the position of item in items</param>
        /// <returns></returns>
        public MoreOptionItem this[int index]
        {
            get
            {
                return Items[index];
            }

            set
            {
                Items[index] = value;
            }
        }

        /// <summary>
        /// Creates and initializes a new instance of MoreOptionList class.
        /// </summary>
        /// <param name="owner">the object of more option</param>
        public MoreOptionList(MoreOption owner)
        {
            Owner = owner;
            Items = new List<MoreOptionItem>();
        }

        /// <summary>
        /// Append a new item to a more option.
        /// </summary>
        /// <param name="item">The more option item</param>
        public void Add(MoreOptionItem item)
        {
            item.Handle = Interop.Eext.eext_more_option_item_append(Owner);
            Items.Add(item);
        }

        /// <summary>
        /// add a new item to a more option at the first.
        /// </summary>
        /// <param name="item">The more option item</param>
        public void AddFirst(MoreOptionItem item)
        {
            item.Handle = Interop.Eext.eext_more_option_item_prepend(Owner);
            Items.Insert(0, item);
        }

        /// <summary>
        /// add a new item to a more option at the last.
        /// </summary>
        /// <param name="item">The more option item</param>
        public void AddLast(MoreOptionItem item)
        {
            Add(item);
        }

        /// <summary>
        /// Get the index of item
        /// </summary>
        /// <param name="item">The more option item</param>
        /// <returns>the index of item</returns>
        public int IndexOf(MoreOptionItem item)
        {
            return Items.IndexOf(item);
        }

        /// <summary>
        /// Insert a new item into the more option after more option item with the index.
        /// </summary>
        /// <param name="index">the index of item which is insert after</param>
        /// <param name="item">The more option item</param>
        public void Insert(int index, MoreOptionItem item)
        {
            if (Items.Count < index + 1 || index < 0)
                throw new ArgumentOutOfRangeException("index is not valid in the MoreOption");

            MoreOptionItem target = Items[index];
            item.Handle = Interop.Eext.eext_more_option_item_insert_after(Owner, target.Handle);
            Items.Insert(index, item);
        }

        /// <summary>
        /// Delete an item which is the given item index
        /// </summary>
        /// <param name="index">the item index which will be deleted</param>
        public void RemoveAt(int index)
        {
            if (Items.Count < index + 1 || index < 0)
                throw new ArgumentOutOfRangeException("index is not valid in the MoreOptionList");

            MoreOptionItem item = Items[index];
            Interop.Eext.eext_more_option_item_del(item.Handle);
            item.Handle = IntPtr.Zero;
            Items.RemoveAt(index);
        }

        /// <summary>
        /// Remove all items from a given more option list object.
        /// </summary>
        public void Clear()
        {
            Interop.Eext.eext_more_option_items_clear(Owner);
            foreach (MoreOptionItem item in Items)
            {
                item.Handle = IntPtr.Zero;
            }
            Items.Clear();
        }

        /// <summary>
        /// Check the item whether is contained
        /// </summary>
        /// <param name="item">The more option item</param>
        /// <returns>If contain return true, otherwise false</returns>
        public bool Contains(MoreOptionItem item)
        {
            return Items.Contains(item);
        }

        /// <summary>
        /// Copy Items
        /// </summary>
        /// <param name="array">the target array</param>
        /// <param name="arrayIndex">which index the item will copy to</param>
        public void CopyTo(MoreOptionItem[] array, int arrayIndex)
        {
            Items.CopyTo(array, arrayIndex);
        }

        /// <summary>
        /// Remove a item
        /// </summary>
        /// <param name="item">the item will be removed</param>
        /// <returns>if remove success return true, otherwise false</returns>
        public bool Remove(MoreOptionItem item)
        {
            if (Items.Contains(item))
            {
                Interop.Eext.eext_more_option_item_del(item.Handle);
                Items.Remove(item);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Return an enumerator that iterates through IEnumerator
        /// </summary>
        /// <returns></returns>
        public IEnumerator<MoreOptionItem> GetEnumerator()
        {
            return Items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Items.GetEnumerator();
        }
    }
}
