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

//https://github.com/ToshiyukiTakahashi0915/VisualStudioPrctice.git


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

//for (int i = 1; i <= 100; i++)
//{
//    int num = i * 3;
//    if (num.ToString().Contains("2"))
//    {
//        continue;
//    }
//        Console.WriteLine(num);
//}

//11.円をドル(ドルとセント)へ変換するプログラムを作成せよ。

//    1ドルは110円とし、100セントで1ドルとします。

////渡される円を定義
//int enn = 1500;
//// 変換されるドルとセント
//int doll = 0; ;
//int cent = 0;

//MoneyConversion(enn);

//Console.WriteLine(enn + "円は" + doll + "ドルと" + cent + "セントです。");

//void MoneyConversion(int enn)
//{
//    if (enn > 110)
//    {
//        doll = enn/110;
//        cent = (int)Math.Floor((enn%110)/1.1);
//    }
//    else
//    {
//        cent = (int)Math.Floor((enn%110)/1.1);
//    }
//}

//12. 1700mまで610円、それ以降は300m毎に80円増加するタクシーがあります。

//    距離を入力し、タクシー代を算出するプログラムを作成せよ。

//// 走行距離
//int driving_meter = 5555;

//Console.WriteLine("走行距離は" + driving_meter + "です。料金は" + PriceCalculation(driving_meter) + "円です。");

//int PriceCalculation(int driving_meter)
//{
//    // 最終的な料金
//    int price = 0;

//    if (driving_meter >= 1700)
//    {
//        // 追加料金の計算
//        int addprice = ((driving_meter - 1700) / 300) * 80;
//        price += addprice + 610;
//    }
//    else price = 610;

//    return price;
//}



//13. 田崎さんの課題で、『1円玉』『5円玉』『10円玉』『100円玉』『500円玉』『1000円札』『5000円札』『10000円札』の

//    枚数を計算する処理を関数化してください。

//    構造体や参照渡しなど、手段はお任せます。

// 関数に渡される金額
//int money = 105899;

//// 各紙幣の個数
//int one = 0;
//int five = 0;
//int ten = 0;
//int hun = 0;
//int five_hun = 0;
//int thous = 0;
//int five_thous = 0;
//int ten_thous = 0;

//MoneyChecker(money);

//Console.WriteLine(money + "円は" + "\n10000円札が" + ten_thous + "枚\n" +
//                  "5000円札が" + five_thous + "枚\n" +  "1000円札が" + thous + "枚\n" +
//                  "500円硬貨が" + five_hun + "枚\n" + "100円硬貨が" + hun + "枚\n" +
//                  "10円硬貨が" + ten + "枚\n" + "5円硬貨が" + five + "枚\n" +
//                  "1円硬貨が" + one + "枚です。");

//void MoneyChecker(int money)
//{

//    // 余りを収める変数
//    int remainder = 0;
//    if (money >= 10000)
//    {
//        ten_thous += money/10000;
//        remainder = money%10000;
//    }
//    if (remainder >= 5000)
//    {
//        five_thous += remainder/5000;
//        remainder = remainder%5000;
//    }
//    if (remainder >= 1000)
//    {
//        thous += remainder/1000;
//        remainder = remainder%1000;
//    }
//    if (remainder >= 500)
//    {
//        five_hun += remainder/500;
//        remainder = remainder%500;
//    }
//    if (remainder >= 100)
//    {
//        hun += remainder/100;
//        remainder = remainder%100;
//    }
//    if (remainder >= 10)
//    {
//        ten += remainder/10;
//        remainder = remainder%10;
//    }
//    if (remainder >= 5)
//    {
//        five += remainder/5;
//        remainder = money%5;
//    }
//    one += remainder;
//}





//14. 以下の名前とIDの構造体を作り、名前を入力すると対象者のIDを出力するプログラムを作成せよ。

//    対象者が存在しない場合は、対象者なしと出力すること。



//    名前：増田、ID：113200081

//    名前：田村、ID：320108580

//　　名前：田崎、ID：318134677

//    名前：田中、ID：318241842

//class Toi14
//{
//    struct Info
//    {
//        public String Name;
//        public int Id;
//    }

//    public　static void Main(string[] arg)
//    {
//        // 構造体の配列を作成
//        Info[] infos = new Info[]
//        {
//            new Info {Name = "増田",Id = 113200081},
//            new Info {Name = "田村",Id = 320108580},
//            new Info {Name = "田崎",Id = 318134677},
//            new Info {Name = "田中",Id = 318241842}
//        };

//        IdGeneration("増田",infos);
//    }

//    private static void IdGeneration(string v, Info[] infos)
//    {
//        bool jude = false;

//        foreach (Info i in infos)
//        {

//            if(i.Name == v)
//            {
//                Console.WriteLine(i.Id);
//                jude = true;
//                break;
//            }
//        }

//        if (jude == false)
//        {
//            Console.WriteLine("対象者なし");
//        }

//    }

//}


//15. ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz で英字のいずれかを入力すると、

//    上記の英字列の何番目に存在するか返すプログラムを作成せよ。



//    (例)

//    B⇒2

//    Z⇒26

//    a⇒27

//    z⇒52

// 対象の文字列

//Char s = 'M';

//Return(s);

//void Return(Char s)
//{
//    String str = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

//    int count = 0;

//    foreach (char c in str)
//    {
//        count++;
//        if (c == s)
//        {
//            Console.WriteLine(count);
//            break;
//        }
//    }

//}







//16. 課題14の問題を参考にして、名前と住所を追加し、住所を入力し、該当するデータの苗字、名前、ID、住所をすべて出力しなさい。

//該当しない場合は、該当なしと出力しなさい。

//入力する住所は、『県』や『知立市』など、一部を入力することも可能にして、該当するものをすべて出力しなさい。





//<対象者データ>

//    苗字：増田、名前：美幸、ID：113200081、住所：愛知県知立市

//    苗字：田村、名前：義治、ID：320108580、住所：東京都目黒区

//  　苗字：田崎、名前：信二、ID：318134677、住所：静岡県島田市

//    苗字：田中、名前：舞子、ID：318241842、住所：北海道稚内市



//例：

//・入力

//　知立市

//・出力

//　苗字：増田、名前：美幸、ID：113200081、住所：愛知県知立市



//・入力

//　県

//・出力

//   苗字：増田、名前：美幸、ID：113200081、住所：愛知県知立市

//　苗字：田崎、名前：信二、ID：318134677、住所：静岡県島田市

//class Toi16
//{
//    struct Info
//    {
//        public String FirstName;
//        public String LastName;
//        public int Id;
//        public String Addres;
//    }

//    public static void Main(string[] arg)
//    {
//        // 構造体の配列を作成
//        Info[] infos = new Info[]
//        {
//            new Info {LastName = "増田", FirstName = "美幸", Id = 113200081, Addres = "愛知県知立市"},
//            new Info {LastName = "田村", FirstName = "義治", Id = 320108580, Addres = "東京都目黒区"},
//            new Info {LastName = "田崎", FirstName = "信二", Id = 318134677, Addres = "静岡県島田市"},
//            new Info {LastName = "田中", FirstName = "舞子", Id = 318241842, Addres = "北海道稚内市"},
//        };

//        AddressSearch("県", infos);
//    }

//    private static void AddressSearch(string v, Info[] infos)
//    {
//        bool jude = false;

//        foreach (Info i in infos)
//        {

//            if (i.Addres.Contains(v))
//            {
//                Console.WriteLine("苗字：" + i.LastName + "、名前：" + i.FirstName + "、ID：" + i.Id + "、住所：" + i.Addres);
//                jude = true;
//            }
//        }

//        if (jude == false)
//        {
//            Console.WriteLine("対象者なし");
//        }

//    }

//}







//17.入力をした段数分の*(半角アスタリスク)をピラミッド型に配置するプログラムを作成しなさい。



//例：

//入力：5

//    *

//   ***

//  *****

//*******

//*********

//int num = 20;
//int Num = num;

//Pyramid(num, Num);

//void Pyramid(int num, int Num)
//{

//    String PyramidParts = "*";

//    for (int i = 0; i < num ; i++)
//    {
//        String space = "";

//        //スペースを足していくサイクル
//        for (int j = 0; j < Num; j++) 
//        { 
//            // 最後の周だけスペースは加えない分岐
//            if (j == Num - 1)
//                 space += "";
//            else space += " ";

//        }
//        Num--;

//        // for文の一周目だけ分岐させる
//        if (i == 0)
//        {
//            Console.WriteLine(space + PyramidParts);
//        }
//        else
//        {
//            pyramid_parts += "**";
//            Console.WriteLine(space + PyramidParts);
//        }        
//    }
//}



//課題18.

//  複数人(人数は指定なし)の点数を引数で渡すと、平均点と最高点、最小点を出力する関数を作ってください。

//  引数は動的配列で渡してください。

//List<int> Points = new List<int> {75, 60, 93, 44, 58 };

//Points.Add(77);

//Calculation(Points);


//void Calculation(List<int> Points)
//{
//    // 平均値は四捨五入にしてる
//    Console.WriteLine("平均点: " + Math.Round(Points.Average()) + "点 最高点: " + 
//        Points.Max() + "点 最小点: " + Points.Min() + "点です。");
//}



//課題19.

//   開始数字と終了数字、検索数字を引数で渡し、開始 ～ 終了までの間に検索数字が何回出てきたか出力する関数を作成せよ

//  <例>

//   開始：10

//   終了：22

//   結果：5

//   (12⇒1個、20⇒1個、21⇒1個、22⇒2個  合計：5個)

int StartNum = 8;

int EndNum = 88;

String SearchNum = "8";

NumCount(StartNum, EndNum, SearchNum);

void NumCount(int StartNum, int EndNum, String SearchNum)
{
    int count = 0;
    for (int i = StartNum; i <= EndNum; i++)
    {
        if (i.ToString().Contains(SearchNum) == true)
            count++;
    }
    Console.WriteLine(count);
}


//課題20.

//  1/1 ⇒ 1ドル100円

//  1/2 ⇒ 1ドル110円

//  1/3 ⇒ 1ドル105円



//  日付と日本円を引数で渡し、レートに合った円/ドル変換をしてください。

//  1ドル=100セントとし、セント単位で算出してください。





//課題21.

//  ユーザが数値を入力した数だけ2の累乗を算出するプログラムを作成せよ

//課題22.

//  int 型の配列に格納されている値の最大値、最小値および平均値を求めよ。

//  配列の値はテキストファイルに記載し、プログラムからは指定したファイルを開いて値を取得すること



//課題23.

//  任意の数値を入力し、その数値以下のフィボナッチ数列をすべて表示しなさい。

//  ※フィボナッチ数列は、どの数値も前2つの数値を足した数になります。(わからなければ聞くか、調べてください)



//  課題23の例

//   入力：100

//   出力：0 1 1 2 3 5 8 13 21 34 55 89




//課題24.

//  5つの数値を入力し、大きい順に並べなおしなさい。ただし、ループ文(while文、for文)を使用して並べ替えること。

//  (ライブラリに並べ替えるものがありますが、使用しないでください)



//  課題24の例

//  入力：10、-3、1、0、-8

//  出力：10、1、0、-3、-8
