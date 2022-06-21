List<int> myInts4 = new List<int> { 7, 2, 1, 9, 0, 4, 6, 3, 8, 5 };
List<int> myInts5 = MergeSort(myInts4);
foreach(var i in myInts5)
{
    Console.Write(i);
}
List<int> MergeSort (List<int> MyList)
{
    List<int> MyList1 = new();
    List<int> MyList2 = new();
    int number = 0;
    if (MyList.Count > 1)
    {
        number = MyList.Count / 2;
        for (int i = 0; i < number; i++)
        {
            MyList2.Add(MyList[i]);
        }
        for (int i = 0; i < MyList.Count - number; i++)
        {
            MyList1.Add(MyList[number + i]);
        }
        return Merge(MergeSort(MyList1), MergeSort(MyList2));
    }
    else
    {
        return MyList;
    }
}

List<int> Merge(List<int> a1, List<int> a2)
{
    List<int> MyList = new();
    int k1 = 0;
    int k2 = 0;
    int z = 0;
    while (k1 + k2 < a1.Count + a2.Count)
    {
        if (a1[k1] > a2[k2])
        {
            MyList.Add(a2[k2]);
            k2++;
        }
        else
        {
            MyList.Add(a1[k1]);
            k1++;
        }
        if (k1 == a1.Count)
        {
            z = 1;
            break;
        }
        else if (k2 == a2.Count)
        {
            z = 2;
            break;
        }

    }

    if (z == 2)
    {
        for (int i = k1; i < a1.Count; i++)
        {
            MyList.Add(a1[i]);
        }
    }
    else if (z == 1)
    {
        for (int i = k2; i < a2.Count; i++)
        {
            MyList.Add(a2[i]);
        }
    }
    return MyList;

}