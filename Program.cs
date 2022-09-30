string[] EnterStrArray() {
    Console.Write("Please enter the size of the array: ");
    int size = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Please enter the element values: ");
    string[] arr = new string[size];
    for (int i = 0; i < size; i++) {
        Console.Write($"Element {i}: ");
        arr[i] = Console.ReadLine();
    }

    return arr;
}

void PrintStrArray (string [] arr) {
    int len = arr.Length;
    for (int i = 0; i < len; i++) {
        Console.WriteLine(arr[i]);
    }
}

string [] selectLimitStr (string [] initArr, int limit) {
    int resCount = 0;
    bool [] resFlags = new bool [initArr.Length];

    for (int i = 0; i < initArr.Length; i++)
        if (initArr[i].Length <= limit) {
            resFlags[i] = true;
            resCount++;
        }
        else resFlags[i] = false;
    
    string [] resArr = new string [resCount];

    for (int i = 0, j = 0; i < initArr.Length; i++)
        if (resFlags[i]) {
            resArr[j] = initArr[i];
            j++;
        }
    
    return resArr;
}

string [] initArray = EnterStrArray();

Console.Write("Please enter the length limit: ");
int strLimit = Convert.ToInt32(Console.ReadLine()); 

string [] resArray = selectLimitStr (initArray, strLimit);

Console.WriteLine("");
Console.WriteLine("The result array:");
PrintStrArray(resArray);