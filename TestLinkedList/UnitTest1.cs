using NUnit.Framework;
using LinkedList;

namespace TestLinkedList
{
  public class Tests
  {
    [TestCase(new int[] { 1, 2, 3, 4, 5 }, 3, new int[] { 1, 2, 4, 5 })]
    [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4, new int[] { 1, 2, 3, 5 })]
    [TestCase(new int[] { 1, 2, 3, 6, 6,6,6,7,8,9 },6, new int[] { 1, 2, 3, 6, 6, 6, 7, 8, 9 })]
    public void DeleteFirstByValueTest(int[] actualArray, int value, int[] expectedArray)
    {
      LinkedList.LinkedList actual = new LinkedList.LinkedList(actualArray);
      LinkedList.LinkedList expected = new LinkedList.LinkedList(expectedArray);

      actual.DeleteFirstByValue(value);

      Assert.AreEqual(expected, actual);
    }


    [TestCase(new int[] { 1, 2, 3, 4 }, 5, new int[] { 1, 2, 3, 4, 5 })]
    [TestCase(new int[] { 1, 2, 3, 4 }, 4, new int[] { 1, 2, 3, 4, 4 })]
    [TestCase(new int[] { 1, 2, 3, 4,5,6,7,8 }, 4, new int[] { 1, 2, 3, 4, 5, 6, 7, 8,4 })]
    public void AddTest(int[] actualArray, int value, int[] expectedArray)
    {
      LinkedList.LinkedList actual = new LinkedList.LinkedList(actualArray);
      LinkedList.LinkedList expected = new LinkedList.LinkedList(expectedArray);

      actual.Add(value);

      Assert.AreEqual(expected, actual);
    }

    [TestCase(new int[] { 1, 2, 3, 4, 5 }, 5, new int[] { 5,1, 2, 3, 4, 5 })]
    [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4, new int[] { 4,1, 2, 3, 4, 5 })]
    [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 4, new int[] { 4, 1, 2, 3, 4, 5, 6, 7, 8 })]
    public void AddFirstTest(int[] actualArray, int value, int[] expectedArray)
    {
      LinkedList.LinkedList actual = new LinkedList.LinkedList(actualArray);
      LinkedList.LinkedList expected = new LinkedList.LinkedList(expectedArray);

      actual.AddFirst(value);

      Assert.AreEqual(expected, actual);
    }

    [TestCase(new int[] { 1, 2, 3, 4, 5 }, 3, 3, new int[] {  1, 2,3,3, 4, 5 })]
    [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, 2, new int[] {  1, 2,2, 3, 4, 5 })]
    [TestCase(new int[] { 1, 2, 3, 4, 5 }, 1, 1, new int[] {  1,1, 2, 3, 4, 5 })]
    public void AddByIndexTest(int[] actualArray, int value, int index, int[] expectedArray)
    {
      LinkedList.LinkedList actual = new LinkedList.LinkedList(actualArray);
      LinkedList.LinkedList expected = new LinkedList.LinkedList(expectedArray);

      actual.AddByIndex(value, index);

      Assert.AreEqual(expected, actual);
    }
      [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4 })]
    [TestCase(new int[] { 1, 2, 3, 4, 5,6,7,8 }, new int[] { 1, 2, 3, 4, 5,6,7 })]
    [TestCase(new int[] { 1, 2 }, new int[] { 1 })]
    public void DeleteLastTest(int[] actualArray, int[] expectedArray)
    {
      LinkedList.LinkedList actual = new LinkedList.LinkedList(actualArray);
      LinkedList.LinkedList expected = new LinkedList.LinkedList(expectedArray);

      actual.DeleteLast();
      Assert.AreEqual(expected, actual);
    }

    [TestCase(new int[] { 1, 2, 3, 4, 5 },2, new int[] { 1, 2, 4, 5 })]
    [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 },0, new int[] {  2, 3, 4, 5, 6, 7, 8 })]
    [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4, new int[] { 1, 2,3, 4, })]
    public void DeleteByIndexTest(int[] actualArray,int index, int[] expectedArray)
    {
      LinkedList.LinkedList actual = new LinkedList.LinkedList(actualArray);
      LinkedList.LinkedList expected = new LinkedList.LinkedList(expectedArray);

      actual.DeleteByIndex(index);
      Assert.AreEqual(expected, actual);
    }
    
    [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 2, 3, 4, 5 })]
    [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, new int[] {2, 3, 4, 5, 6, 7, 8 })]
    [TestCase(new int[] { 1, 2 }, new int[] { 2 })]
    public void DeleteFirstTest(int[] actualArray, int[] expectedArray)
    {
      LinkedList.LinkedList actual = new LinkedList.LinkedList(actualArray);
      LinkedList.LinkedList expected = new LinkedList.LinkedList(expectedArray);

      actual.DeleteFirst();
      Assert.AreEqual(expected, actual);
    }

    

    //[TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, new int[] {8,8 }, new int[] { 1, 8, 8, 2, 3, 4, 5 })]
    //[TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 1, new int[] { 9,9 })]
    //public void AddArrayIndexTest(int[] actualArray, int index,int[]arr, int[] expectedArray)
    //{
    //  LinkedListData actual = new LinkedListData(actualArray);
    //  LinkedListData expected = new LinkedListData(expectedArray);

    //  actual.AddArrayIndex(arr, index);
    //  Assert.AreEqual(expected, actual);
    //}

    [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, 3)]
    [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 3, 4)]
    [TestCase(new int[] { 1, 2 }, 1, 2)]
    public void GetValueByIndexTest(int[] actualArray, int index, int expectedValue)
    {
      LinkedList.LinkedList List = new LinkedList.LinkedList(actualArray);

      var actualValue = List.GetValueByIndex(index);
      Assert.AreEqual(expectedValue, actualValue);
    }

    [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, 1)]
    [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 3, 2)]
    [TestCase(new int[] { 1, 2 }, 1, 0)]
    public void GetIndexByValueTest(int[] actualArray, int value, int expectedIndex)
    {
      LinkedList.LinkedList list = new LinkedList.LinkedList(actualArray);
    
      var actualIndex = list.GetIndexByValue(value);
      Assert.AreEqual(expectedIndex, actualIndex);
    }

    [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, new int[] {1, 2, 3 })]
    [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 3, new int[] { 1, 2, 3,4, 5 })]
    [TestCase(new int[] { 1, 2 }, 1, new int[] { 1 })]
    public void DeleteNTest(int[] actualArray, int N, int[] expectedArray)
    {
      LinkedList.LinkedList actual = new LinkedList.LinkedList(actualArray);
      LinkedList.LinkedList expected = new LinkedList.LinkedList(expectedArray);

      actual.DeleteN(N);
      Assert.AreEqual(expected, actual);
    }

    [TestCase(new int[] { 1, 2, 3, 4, 5 }, 5)]
    [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 8)]
    [TestCase(new int[] { 1, 2 }, 2)]
    public void GetLengthTest(int[] actualArray, int expectedLenght)
    {
      LinkedList.LinkedList list = new LinkedList.LinkedList(actualArray);

      var actualLenght = list.GetLength();
      Assert.AreEqual(expectedLenght, actualLenght);
    }

    [TestCase(new int[] { 1, 2, 3, 4, 5 }, 9,2, new int[] { 1, 9, 3, 4, 5 })]
    [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 9,3, new int[] { 1, 2, 9, 4, 5, 6, 7, 8 })]
    [TestCase(new int[] { 1, 2 }, 8, 2, new int[] { 1, 8 })]
    public void ChangeValueByIndexTest(int[] actualArray, int value, int index, int[] expectedArray)
    {
      LinkedList.LinkedList actual = new LinkedList.LinkedList(actualArray);
      LinkedList.LinkedList expected = new LinkedList.LinkedList(expectedArray);

      actual.ChangeValueByIndex(value, index);
      Assert.AreEqual(expected, actual);
    }

    [TestCase(new int[] { 1, 2, 3, 4, 5 }, 5)]
    [TestCase(new int[] { 1, 2, 3, 9, 5, 6, 7, 8 }, 9)]
    [TestCase(new int[] { 7, 7 }, 7)]
    public void GetMaxValueTest(int[] actualArray, int expectedLenght)
    {
      LinkedList.LinkedList list = new LinkedList.LinkedList(actualArray);

      var actualLenght = list.GetMaxValue();
      Assert.AreEqual(expectedLenght, actualLenght);
    }

    [TestCase(new int[] { 1, 2, 3, 4, 5 }, 1)]
    [TestCase(new int[] { 2, 1, 3, 9, 5, 6, 7, 8 }, 1)]
    [TestCase(new int[] { 8,7,8,5,4,3,2 }, 2)]
    public void GetMinValueTest(int[] actualArray, int expectedLenght)
    {
      LinkedList.LinkedList list = new LinkedList.LinkedList(actualArray);

      var actualLenght = list.GetMinValue();
      Assert.AreEqual(expectedLenght, actualLenght);
    }

    [TestCase(new int[] { 1, 2, 3, 4, 5 }, 0)]
    [TestCase(new int[] { 4, 4, 3, 2, 5, 6, 7, 8 }, 3)]
    [TestCase(new int[] { 8,7,8,5,4,3,2 }, 6)]
    public void GetIndexMinTest(int[] actualArray, int expectedLenght)
    {
      LinkedList.LinkedList list = new LinkedList.LinkedList(actualArray);

      var actualLenght = list.GetIndexMin();
      Assert.AreEqual(expectedLenght, actualLenght);
    }

    [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4)]
    [TestCase(new int[] { 4, 4, 3, 2, 9, 6, 7, 8 }, 4)]
    [TestCase(new int[] { 9, 7, 8, 5, 4, 3, 2 }, 0)]
    public void GetIndexMaxTest(int[] actualArray, int expectedLenght)
    {
      LinkedList.LinkedList list = new LinkedList.LinkedList(actualArray);

      var actualLenght = list.GetIndexMax();
      Assert.AreEqual(expectedLenght, actualLenght);
    }

    [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5,4,3,2,1 })]
    [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, new int[] { 8,7,6,5,4,3,2,1 })]
    [TestCase(new int[] { 2, 2, 2 }, new int[] { 2, 2, 2})]
    public void ReverseTest(int[] actualArray, int[] expectedArray)
    {
      LinkedList.LinkedList actual = new LinkedList.LinkedList(actualArray);
      LinkedList.LinkedList expected = new LinkedList.LinkedList(expectedArray);

      actual.Reverse();
      Assert.AreEqual(expected, actual);
    }
    [TestCase(new int[] { 1, 2, 3, 4, 5 },2, new int[] { 1, 3, 4, 5 })]
    [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 },3, new int[] { 1, 2, 4, 5, 6, 7, 8 })]
    [TestCase(new int[] { 1, 1, 3, 1, 1 }, 3, new int[] { 1,1,1,1 })]
    public void DeleteAllByValueTest(int[] actualArray,int value, int[] expectedArray)
    {
      LinkedList.LinkedList actual = new LinkedList.LinkedList(actualArray);
      LinkedList.LinkedList expected = new LinkedList.LinkedList(expectedArray);

      actual.DeleteAllByValue(value);
      Assert.AreEqual(expected, actual);
    }

    [TestCase(new int[] { 1 }, new int[] { 9, 9, 9,9,9 }, new int[] {1, 9, 9, 9, 9, 9 })]
    [TestCase(new int[] { 1, 2 }, new int[] { 9, 9, 9 }, new int[] { 1, 2, 9, 9, 9 })]
    [TestCase(new int[] { 1, 1, 3, 1, 1 },new int[] {9,9,9 }, new int[] { 1, 1, 3, 1, 1,9,9,9 })]
    public void AddArrayAndTest(int[] actualArray, int[] arr, int[] expectedArray)
    {
      LinkedList.LinkedList actual = new LinkedList.LinkedList(actualArray);
      LinkedList.LinkedList expected = new LinkedList.LinkedList(expectedArray);

      actual.AddArrayAnd(arr);
      Assert.AreEqual(expected, actual);
    }

    [TestCase(new int[] { 1 }, new int[] { 9, 9, 9, 9, 9 }, new int[] { 9, 9, 9, 9, 9,1 })]
    [TestCase(new int[] { 1, 2 }, new int[] { 9, 9, 9 }, new int[] { 9, 9, 9,1, 2  })]
    [TestCase(new int[] { 1, 1, 3, 1, 1 }, new int[] { 9, 9, 9 }, new int[] {9, 9, 9, 1, 1, 3, 1, 1 })]
    public void AddArrayFirstTest(int[] actualArray, int[] arr, int[] expectedArray)
    {
      LinkedList.LinkedList actual = new LinkedList.LinkedList(actualArray);
      LinkedList.LinkedList expected = new LinkedList.LinkedList(expectedArray);

      actual.AddArrayFirst(arr);
      Assert.AreEqual(expected, actual);
    }

    [TestCase(new int[] { 1,2,3,4 }, new int[] { 9, 9, 9 },2, new int[] { 1,2, 9, 9, 9, 3,4 })]
    [TestCase(new int[] { 1, 2, 3 }, new int[] { 9, 9 },1, new int[] { 1, 9, 9, 2, 3 })]
    [TestCase(new int[] { 1, 2, 3,4  }, new int[] { 9, 9 },4, new int[] { 1, 2, 3, 4, 9, 9 })]
    public void AddArrayIndexTest(int[] actualArray, int[] arr, int index, int[] expectedArray)
    {
      LinkedList.LinkedList actual = new LinkedList.LinkedList(actualArray);
      LinkedList.LinkedList expected = new LinkedList.LinkedList(expectedArray);

      actual.AddArrayIndex(arr, index);
      Assert.AreEqual(expected, actual);
    }

    [TestCase(new int[] { 1, 2, 3, 4 }, 2, new int[] { 3, 4 })]
    [TestCase(new int[] { 1, 2,3,5,6 }, 2, new int[] { 3, 5, 6 })]
    [TestCase(new int[] { 1, 2, 3, 4,8,8,8 }, 4, new int[] { 8, 8, 8 })]
    public void DeleteNFirstTest(int[] actualArray, int N, int[] expectedArray)
    {
      LinkedList.LinkedList actual = new LinkedList.LinkedList(actualArray);
      LinkedList.LinkedList expected = new LinkedList.LinkedList(expectedArray);

      actual.DeleteNFirst(N);
      Assert.AreEqual(expected, actual);
    }
    [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, 0, new int[] { 3, 4, 5 })]
    [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, 2, new int[] { 1, 2, 5 })]
    [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 2, 3, new int[] { 1, 2,3, 6, 7, 8 })]
    public void DeleteByIndexNElementTest(int[] actualArray, int N, int index, int[] expectedArray)
    {
      LinkedList.LinkedList actual = new LinkedList.LinkedList(actualArray);
      LinkedList.LinkedList expected = new LinkedList.LinkedList(expectedArray);

      actual.DeleteByIndexNElement(N, index);
      Assert.AreEqual(expected, actual);
    }
    [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
    [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8 })]
    [TestCase(new int[] { 6, 9, 6,5,4,3 }, new int[] { 3, 4, 5,6,6,9 })]
    public void ArraySortTest(int[] actualArray, int[] expectedArray)
    {
      LinkedList.LinkedList actual = new LinkedList.LinkedList(actualArray);
      LinkedList.LinkedList expected = new LinkedList.LinkedList(expectedArray);

      actual.ArraySort();
      Assert.AreEqual(expected, actual);
    }
  }

}