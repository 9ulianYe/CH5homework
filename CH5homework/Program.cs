// See https://aka.ms/new-console-template for more information

/* 例題5.1-利用一維陣列求10個數字的計算平均值*/

//double[] array = new double[10];
//double sum = 0;    
//for (int i = 0; i <10 ; i++)
//{
//    Console.Write($"第{i+1}個數字 = ");
//    int inputNum = Convert.ToInt32( Console.ReadLine() );
//    array[i]= inputNum ;

//}
// foreach (double item in array)
//    {
//        sum = sum + item ;
//    }
//double avg = sum / 10;
//Console.WriteLine($"avg = {avg}");
//Console.ReadKey();

/* 例題5.2-利用一維陣列求10個數字的最大值。*/

//double[] array = new double[10];

//for (int i = 0; i < array.Length; i++) {
//    Console.Write($"第{i+1}個數字 = ");
//    double inputNum = Convert.ToDouble(Console.ReadLine());
//    array[i] = inputNum;
//}
//double max = int.MinValue;
//for (int i = 0; i < array.Length; i++)
//{
//    if (array[i] > max) { 
//        max= array[i];
//    }
//}
//Console.WriteLine($"max= {max}");
//Console.ReadKey();



/* 例題5.3-搜尋問題：輸入10個數字至A[ ]，再輸入x，判斷x是否存在於A陣列中，*/

//int[] arr = new int[10];
//for (int i = 0; i < arr.Length; i++) {
//    Console.Write($"輸入第{i+1}個數字 = ");
//    int input = Convert.ToInt32( Console.ReadLine() );
//    arr[i] = input;
//}

//bool isExist = true;
//Console.Write($"輸入x = ");
//int x = Convert.ToInt32( Console.ReadLine() );

//foreach (int i in arr) { 
//    if (i == x) Console.WriteLine($" x在A陣列a{i}中");
//    else
//    {
//        Console.WriteLine($"x不在A陣列a{i}中");
//    }
//}

/*例題5.4求兩個2乘3的二維矩陣相加之結果，第一個及第二個矩陣分別以A及B表示，
 * 相加之結果存入C矩陣，最後將C矩陣內容顯示出來*/

//int[,] arrA = new int[2, 3] {
//{1,2,3 },
//{4,5,6 }
//};

//int[,] arrB = new int[2, 3] {
//{2,3,4 },
//{5,6,7 }
//};

//int[,] arrC = new int[2, 3];
//for (int row = 0; row < 2; row++) {
//    for (int col = 0; col < 3; col++)
//    {
//        arrC[row,col] = arrA[row, col] + arrB[row, col];
//    }
//}

//for (int row = 0; row < 2; row++) {
//    for (int col = 0; col < 3; col++)
//    {
//        Console.Write(arrC[row,col]+" " );
//    }
//    Console.WriteLine();
//}



/* 習題 5-1.寫一程式，將10個數字讀入A陣列，然後逐一檢查此陣列，
    如A[i]>5，則令A[i]=A[i]-5，否則A[i]=A[i]+5 */





/* 習題 5-2.寫一程式，將10個數字讀入A陣列，對每一個數字，令A[i]=A[i]+i。
*/


/* 習題 5-3.寫一程式，將10個數字讀入A陣列，並建立一個B陣列，如A[i]≥0，令B[i]=1，否則令B[i]=0。
*/

/* 習題 5-4.寫一程式，將15數字存入3×5的二維陣列A中，求每一行及每一列數字的和。
*/


/* 習題 5-5.寫一程式，將15數字存入3×5的二維陣列A中，求每一行及每一列數字的最小值。
*/


/* 習題 5-6.寫一程式，輸入兩組數字：a1,a2,…,a5和b1,b2,…,b5。求ai+bi，i=1到i=5。
*/


/* 習題 5-7.寫一程式，輸入兩組數字： a1,a2,…,a5和b1,b2,…,b5。令x為a中的最大值，令y為b中的最大值，求x與y中較小者。
*/

/* 例題5.1-利用一維陣列求10個數字的計算平均值*/

/* 例題5.1-利用一維陣列求10個數字的計算平均值*/

/* 例題5.1-利用一維陣列求10個數字的計算平均值*/