using System;

namespace LinkedList
{
  public class LinkedList
  {

    public int Length { get; private set; }

    private Node _root;

    public int this[int index]
    {
      get
      {
        Node tmp = _root;
        for (int i = 1; i <= index; i++)
        {
          tmp = tmp.Next;
        }
        return tmp.Value;
      }

      set
      {
        Node tmp = _root;
        for (int i = 1; i <= index; i++)
        {
          tmp = tmp.Next;
        }
        tmp.Value = value;
      }
    }

    public LinkedList()
    {
      Length = 0;
      _root = null;
    }

    public LinkedList(int value)
    {
      _root = new Node(value);
      Length = 1;
    }

    public LinkedList(int[] array)
    {
      if (array.Length != 0)
      {
        _root = new Node(array[0]);
        Node tmp = _root;

        for (int i = 1; i < array.Length; i++)
        {
          tmp.Next = new Node(array[i]);
          tmp = tmp.Next;
        }

        Length = array.Length;
      }
      else
      {
        Length = 0;
        _root = null;
      }
    }
    // добавление значения в конец
    public void Add(int value)
    {
      if (_root == null)
      {
        _root = new Node(value);
        return;
      }
      Node current = _root;
      while (current.Next != null)
      {
        current = current.Next;
      }
      current.Next = new Node(value);
      Length++;
    }
    // добавление значения в начало
    public void AddFirst(int value)
    {
      if (_root == null)
      {
        _root = new Node(value);
        return;
      }
      Node newNode = new Node(value);
      newNode.Next = _root;
      _root = newNode;
      Length++;
    }
    // добавление значения по индексу
    public void AddByIndex(int index, int value)
    {
      if (index == 0)
      {
        Node tmp1 = _root;
        _root = new Node(value);
        _root.Next = tmp1;
      }
      else
      {
        Node current = _root;
      for (int i = 1; i < index; i++)
        {
          current = current.Next;
        }

        Node tmp = current.Next;
        current.Next = new Node(value);

        current.Next.Next = tmp;
        }
      Length++;
    }
    // удаление из конца одного элемента
    public void DeleteLast()
    {
      Node current = _root;
      while (current.Next != null)
      {
        current = current.Next;
      }
      current = null;
      Length--;
    }
    // удаление значения по индексу
    public void DeleteByIndex(int index)
    {
      if (index == 0)
      {
        _root = _root.Next;
        Length--;
        return;
      }
      Node current = _root;
      for (int i = 1; i < index; i++)
      {
        current = current.Next;
      }
      current.Next = current.Next.Next;
      Length--;
    }
    // удаление из начала одного элемента
    public void DeleteFirst()
    {
      DeleteByIndex(0);
    }
    // вернуть длинну
    public int GetLength()
    {
      Node current = _root;
      int counter = 0;
      while (current.Next != null)
      {
        current = current.Next;
        counter++;
      }
      return counter+1;
    }
    // доступ по индексу 
    public int GetValueByIndex(int index)
    {
      Node current = _root;
      if (index >= 0)
        for (int i = 1; i <= index; i++)
        {
          current = current.Next;
        }
      return current.Value;
      throw new Exception("Index out of range");
    }

    //индекс по значению
    public int GetIndexByValue(int value)
    {
      Node current = _root;
      int counter = 0;
      if (_root.Value == value)
      {
        return 0;
      }
      while (current.Value != value)
      {
        current = current.Next;
        counter++;
      }
      return counter;
    }
    // изменение по индексу
    public void ChangeValueByIndex(int value, int index)
    {
      Node current = _root;
      if (index >= 0)
      {
        for (int i = 1; i < index; i++)
        {
          current = current.Next;
        }
        current.Value = value;
      }
      else
        throw new Exception("Index out of range");
    }
    //поиск значения максимального элемента
    public int GetMaxValue()
    {
      Node current = _root;
      Node current2 = _root;
      int tmp;
      int max = _root.Value;
      while (current2.Next != null)
      {
        current2 = current2.Next;
      }
      tmp = current2.Value;
      while (current.Next != null)
      {
        if (max < current.Value) max = current.Value;
        current = current.Next;
      }
      if (tmp > max) return tmp;
      return max;
    }
    //поиск значения минимального элемента
    public int GetMinValue()
    {
      if (_root == null)
      {
        new Exception("List is Empty");
      }
      Node current = _root;
      Node current2 = _root;
      int min = _root.Value;
      int tmp;
      while (current2.Next != null)
      {
        current2 = current2.Next;
      }
      tmp = current2.Value;
      while (current.Next != null)
      {
        if (min > current.Value) min = current.Value;
        current = current.Next;
      }
      if (tmp < min) return tmp;
      return min;
    }
    // поиск индекса минимального элемента
    public int GetIndexMin()
    {
      if (_root == null)
      {
        throw new Exception("List is Empty");
      }
      Node current = _root;
      Node current2 = _root;
      int min = _root.Value;
      int counter = 0;
      int counter2 = 0;
      int tmp;
      while (current2.Next != null)
      {
        current2 = current2.Next;
        counter2++;
      }
      tmp = current2.Value;
      while (current.Next != null)
      {
        if (min > current.Value) min = current.Value;
        current = current.Next;
      }
      current = _root;
      while (current.Next != null)
      {
        if (min == current.Value)
        {
          if (tmp < min) return counter2;
          return counter; 
        }
        counter++;
        current = current.Next;
      }
      return 0;
    }
    // сортировка
    public void ArraySort()
    {
      Node current1 = _root;
      for (int i = 0; i < Length; i++)
      {
        Node current2 = _root;
        current2 = current2.Next;
        for (int j = 1; j < Length; j++)
        {
          if (j > i)
          {
            if (current1.Value > current2.Value)
            {

              int tmp;
              tmp = current1.Value;
              current1.Value = current2.Value;
              current2.Value = tmp;
            }
          }
          current2 = current2.Next;
        }
        current1 = current1.Next;
      }
    }
    //public void ArraySortReverse()
    //{
    //  Node current1 = _root;
    //  for (int i = 0; i < Length; i++)
    //  {
    //    Node current2 = _root;
    //    current2 = current2.Next;
    //    for (int j = 1; j < Length; j++)
    //    {
    //      if (j > i)
    //      {
    //        if (current1.Value < current2.Value)
    //        {
    //          int tmp;
    //          tmp = current1.Value;
    //          current1.Value = current2.Value;
    //          current2.Value = tmp;
    //        }
    //      }
    //      current2 = current2.Next;
    //    }
    //    current1 = current1.Next;
    //  }
    //}
    //public int this[int index]
    //{

    //  get
    //  {
    //    if (index > Length - 1 || index < 0)
    //    {
    //      throw new IndexOutOfRangeException();
    //    }
    //    Node tmp = _root;
    //    for (int i = 0; i < index; i++)
    //    {
    //      tmp = tmp.Next;
    //    }
    //    return tmp.Value;
    //  }

    //  set
    //  {
    //    if (index > Length - 1 || index < 0)
    //    {
    //      throw new IndexOutOfRangeException();
    //    }
    //    Node tmp = _root;
    //    for (int i = 0; i < index; i++)
    //    {
    //      tmp = tmp.Next;
    //    }
    //    tmp.Value = value;
    //  }
    //}

    // поиск индекса максимального элемента
    public int GetIndexMax()
    {
      if (_root == null)
      {
        throw new Exception("List is Empty");
      }
      Node current = _root;
      Node current2 = _root;
      int max = _root.Value;
      int counter = 0;
      int counter2 = 0;
      int tmp;
      while (current2.Next != null)
      {
        current2 = current2.Next;
        counter2++;
      }
      tmp = current2.Value;
      while (current.Next != null)
      {
        if (max < current.Value) max = current.Value;
        current = current.Next;
      }
      current = _root;
      while (current.Next != null)
      {
        if (max == current.Value)
        {
          if (tmp > max) return counter2;
          return counter;
        }
        counter++;
        current = current.Next;
      }
      return 0;
    }

    //Реверс
    public void Reverse()
    {
      Node current = _root;
      Node tmp;
      while (current.Next != null)
      {
        tmp = current.Next;
        current.Next = current.Next.Next;
        tmp.Next = _root;
        _root = tmp;
      }
    }
    //удаление по значению первого
    public void DeleteFirstByValue(int value)
    {
      Node current = _root;
      if (_root.Value == value)
      {
        DeleteByIndex(0);
        Length--;
      }
      while (current.Next.Value != value)
      {
        current = current.Next;
      }
      current.Next = current.Next.Next;
      Length--;
    }
    //удаление по значению всех
    public void DeleteAllByValue(int value)
    {
      Node current = _root;
      if (_root.Value == value)
      {
        DeleteByIndex(0);
        Length--;
      }
      while (current.Next != null)
      {
        if (current.Next.Value == value)
        {
          current.Next = current.Next.Next;
          Length--;
        }
        current = current.Next;
      }
    }
    //добавление массива в конец
    public void AddArrayAnd(int[] elements)
    {
      Node current = _root;
      while (current.Next != null)
      {
        current = current.Next;
      }
      for (int i = 0; i < elements.Length; i++)
      {
        current.Next = new Node(elements[i]);
        current = current.Next;
        Length++;
      }
    }
    // добавление массива в начало
    public void AddArrayFirst(int[] elements)
    {
      for (int i = elements.Length - 1; i >= 0; i--)
      {
        Node newNode = new Node(elements[i]);
        newNode.Next = _root;
        _root = newNode;
        Length++;
      }
    }
    // добавление массива по индексу
    public void AddArrayIndex(int[] elements, int index)
    {
      Node current = _root;
      int counter = 0;
      if (index > 0)
      {
        while (counter != index - 1)
        {
          current = current.Next;
          counter++;
        }
        var tail = current.Next;
        for (int i = 0; i < elements.Length; i++)
        {
          current.Next = new Node(elements[i]);
          current = current.Next;
          Length++;
        }
        current.Next = tail;
      }
      else
        throw new Exception("Index out of range");
    }
    // удаление по индексу N элементов
    public void DeleteByIndexNElement(int N, int index)
    {
      Node current = _root;
      if (index > 0 && index < Length)
      {       
        for (int i = 1; i < index; i++)
        {
          current = current.Next;
        }
        Node tmp=_root;
        for (int i = 1; i < index + N+1; i++)
        {
          tmp = tmp.Next;
        }
        current.Next = tmp;
      }
      else if (index == 0)
      {
        int counter = 0;
        while (counter != N)
        {
          current = current.Next;
          counter++;
        }
        _root = current;
      }
      Length -= N;
    }
    //удаление из конца N элементов
    public void DeleteN(int N)
    {
      Node current = _root;
      Node tmp = _root;
      int counter = 0;
      while (current.Next != null)
      {
        current = current.Next;
        counter++;
      }
        for (int i = 1; i <= counter - N; i++)
        {
          tmp = tmp.Next;
        }
        tmp.Next=null;
        Length -= N;
      
    }
    //удаление из начала N элементов
    public void DeleteNFirst(int N)
    {
      DeleteByIndexNElement(N, 0);
    }
    public override bool Equals(object obj)
    {
      LinkedList linkedList = (LinkedList)obj;

      if (Length != linkedList.Length)
      {
        return false;
      }

      //for (int i = 0; i < Length; i++)
      //{
      //    if(this[i]!=linkedList[i])
      //    {
      //        return false;
      //    }
      //}

      Node tmp1 = _root;
      Node tmp2 = linkedList._root;
      for (int i = 0; i < Length; i++)
      {
        if (tmp1.Value != tmp2.Value)
        {
          return false;
        }
        tmp1 = tmp1.Next;
        tmp2 = tmp2.Next;
      }
      return true;
    }

    public override string ToString()
    {
      string s = "";

      if (_root != null)
      {
        Node tmp = _root;

        while (tmp != null)
        {
          s += tmp.Value + ";";
          tmp = tmp.Next;
        }
      }
      return s;
    }
  }
}
