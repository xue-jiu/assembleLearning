using System;
using System.Collections;
using System.Collections.Generic;

namespace assembleLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------用于学习C#各类集合----------------------------");
            Console.WriteLine("---------------------------Array数组----------------------------");
            string[] SmallArray = new string[7]//固定长度,也可以不写7
            {
                "One",
                "Two",
                "Three",
                "Four",
                "Five",
                "Six",
                null
            };
            Console.WriteLine(SmallArray[0]);
            string[] BigArray = new string[7];
            Console.WriteLine(BigArray[0]);//null
            int[] ToobigArray  = new int[7];
            Console.WriteLine(ToobigArray[0]);//0
            int?[] vs = new int?[7];
            Console.WriteLine(vs[0]);//null
            Console.WriteLine("---------------------------List列表(底层事故数组)----------------------------");
            List<string> smallList = new List<string>();//List必定是泛型的
            smallList.Add("One");
            foreach (var item in smallList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------ArrayList列表(底层事故数组)----------------------------");
            var array = new ArrayList();//装箱拆箱,可以村方法各种数据
            array.Add(1);
            array.Add("gaga");

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------ICollction列表(底层事故数组)----------------------------");
            ICollection Collection = new ArrayList();
            Collection.CopyTo(SmallArray,0);//将一个复制到另一个列表
            ICollection<string> NewColletion = new List<string>();
            
            Console.WriteLine("采用IList");

            IList newArray = new ArrayList();
            newArray.Add(1);
            newArray.Add("dada");
            foreach (var item in newArray)
            {
                Console.WriteLine(item);
            }
            


//      — System.Collections.ICollection：（继承于IEnumerable）定义所有集合的大小，枚举器和同步方法，可以获取集合中项的个数，并能把项复制到一个简单的数组类型中。
//      — System.Collections.IComparer：比较两个对象的方法
//      — System.Collections.IList：(继承于IEnumerable 和 ICollection)表示可按照索引单独访问一组对象,提供集合的项列表，并可以访问这些项。
//      — System.Collections.IDictionary：（继承于IEnumerable 和 ICollection）表示键 / 值对的集合
//      — System.Collections.IDictionaryEnumerator：枚举字典的元素
//      — System.Collections.IEnumerator：支持在集合上进行简单迭代，可以迭代集合中的项。支持在非泛型集合进行简单迭代。
//————————————————
//版权声明：本文为CSDN博主「一斤阳光」的原创文章，遵循CC 4.0 BY - SA版权协议，转载请附上原文出处链接及本声明。
//原文链接：https://blog.csdn.net/weixin_44302503/article/details/120995689



        }
    }
}
