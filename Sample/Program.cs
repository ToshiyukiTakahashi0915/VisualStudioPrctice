// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//3．関数の引数に3つの値を渡し、最大値/最小値を求めるプログラムを作ってください。

//   サブ関数内で結果をメッセージボックスで表示してください。

// 引数に渡す3つの配列
//int[] num = new int[3] { -235, 5000, 100 };

//Console.WriteLine("最大値: " + Max(num) + "最小値: " + Min(num));

//int Max(int[] num)
//{
//    // 最大値を収める変数
//    int maxNum = 0;

//    bool bFirst = true;

//    foreach (int i in num)
//    {
//        // nullかどうかを判断
//        if (bFirst)
//        {
//            maxNum = i;
//            bFirst = false;
//        }
//        else if(i > maxNum)
//        {
//            maxNum = i;
//        }
//    }
//    return maxNum;
//}

//int Min(int[] num)
//{
//    // 最小値を収める変数
//    int minNum = 0;
//    bool bFirst = true;

//    foreach (int i in num)
//    {
//        if(bFirst)
//        {
//            minNum = i;
//            bFirst = false;
//        }
//        else if (i < minNum)
//        {
//            minNum = i;
//        }
//    }
//    return minNum;
//}



//4. 10個の数値を入力し、平均値を求めるプログラムを作ってください。
//int[] num = new int[9] { 300, 500, 10, 4, 6, 300, 500, 20, 45  };

//Console.WriteLine("平均値; " + Average(num));

//int Average(int[] num)
//{
//    int sum = 0;

//    foreach (int i in num)
//    {
//        sum += i;
//    }
//    int count = num.Count();
//    return sum/num.Count();
//}
// 要素の数はカウントの方が良い


//6. 2重ループで九九表を表示するプログラムを作ってください。

//   [1と2の出力例、1～9の九九を出力]

//1,2,3,4,5,6,7,8,9

//   2,4,6,8,10,12,14,16,18

//Console.WriteLine(MultiplicationTables());

//String MultiplicationTables()
//{
//    String result = "";

//    for (int i = 1; i <= 9; i++)
//    {
//        for (int j = 1; j <= 9; j++)
//        {
//            result += i * j;

//            if (j != 9)
//            {
//                result += ",";
//            }
//        }

//        result += "\n";
//    }

//    return result;
//}




//7.三角形の底辺と高さを持つ構造体を作ってください。

//   また、構造体を引数で渡して三角形の面積を計算して結果を表示する関数を用意してください。

//   (三角形の面積：底辺×高さ÷2)

//class Toi7
//{
//    struct Triangle
//    {
//        public double Base;
//        public double Height;
//    }

//    static void Main(string[] arg)
//    {
//        Triangle myTriangle = new Triangle();
//        myTriangle.Base = 3.0;
//        myTriangle.Height = 5.0;

//        CalculationArea(myTriangle);
//    }

//    static void CalculationArea(Triangle myTriangle)
//    {
//        Console.WriteLine("三角形の面積: " + ((myTriangle.Base * myTriangle.Height) / 2.0));
//    }
//}




//8.int型のポインタ変数を用意し、関数の引数で渡すプログラムを作ってください。

//   関数では渡されたポインタ変数を10倍してください。

//   関数を抜けた後、main関数で10倍にしたポインタ変数の値を表示してください。

//   尚、関数はvoid型とします。

//unsafe class Toi8
//{

//    static void Main(string[] args)
//    {
//        // 値を入れる変数
//        int num = 15;
//        // ポインターに変数を入れる
//        int* x = &num;

//        TenTimes(x);

//        Console.WriteLine(*x);
//    }
//    // 十倍するメソッド
//    static void TenTimes(int* x)
//    {
//        *x *= 10;
//    }
//}

//9. 整数を入力し、0までカウントダウンするプログラムを作ってください。
//int num = 150;

//while(num >= 0)
//{
//    Console.WriteLine(num);
//    num -= 1;
//}



//10. 3の倍数を300まで表示してください。

//    ただし、2の数字が入る数字は表示しないでください。

//    (例：3,6,9,15) ※12は2が入るので除外する

for (int i = 1; i <= 100; i++)
{
    int num = i * 3;
    if (num.ToString().Contains("2"))
    {
        continue;
    }
        Console.WriteLine(num);
}
