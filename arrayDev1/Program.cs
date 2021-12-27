// Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел. 
// Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом.
//  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
 
 int [] myArray = new int [8];
 Random rand = new Random(); 
 for (int x = 0; x < myArray.Length; x++)
     { 
          myArray[x] = rand.Next(10);
           Console.Write(myArray [x]+ " ");
     }  
Console.WriteLine();  
  int j = 0;
                int[] newArray = new int[8];
                Console.WriteLine("четные чисела массива:");
                for(int i=0; i<myArray.Length; i++)
                {
                    if (myArray[i] % 2 == 0)
                    {
                        newArray[j]=myArray[i];
                        Console.Write(newArray[j]+" ");
                        j++;
                    }
                }


        


