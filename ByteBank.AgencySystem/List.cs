using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.AgencySystem {
  public class List<T> {
    private T[] _items;
    private int _nextPosition;

    public int Length {
      get {
        return _nextPosition;
      }
    }

    public T this[int index] {
      get {
        return GetItem(index);
      }
    }

    public List(int initialCapacity = 5) {
      _items = new T[initialCapacity];
      _nextPosition = 0;
    }

    public void Append(T item) {
      VerifyCapacity(_nextPosition + 1);

      _items[_nextPosition] = item;
      _nextPosition++;
    }

    public void AppendMore(params T[] items) {
      foreach (T item in items) {
        Append(item);
      }
    }

    public void Remove(T item) {
      int itemIndex = -1;

      for (int i = 0; i < _nextPosition; i++) {
        T actualItem = _items[i];

        if (actualItem.Equals(item)) {
          itemIndex = i;
          break;
        }
      }

      for (int i = itemIndex; i < _nextPosition; i++) {
        _items[i] = _items[i + 1];
      }

      _nextPosition--;
      //_items[_nextPosition] = null;
    }

    public T GetItem(int index) {
      if (index < 0 || index >= _nextPosition) {
        throw new ArgumentOutOfRangeException(nameof(index));
      }

      return _items[index];
    }

    public void VerifyCapacity(int lengthNeeded) {
      if (_items.Length >= lengthNeeded) {
        return;
      }

      int newLength = _items.Length * 2;

      if (newLength < lengthNeeded) {
        newLength = lengthNeeded;
      }

      T[] newArray = new T[newLength];

      for (int i = 0; i < _items.Length; i++) {
        newArray[i] = _items[i];
      }

      _items = newArray;
    }
  }
}