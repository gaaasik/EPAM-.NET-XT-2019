using System;
using System.Collections;
using System.Collections.Generic;

namespace dynamic_array
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicArray<int> array = new DynamicArray<int>();

            //Insert IEnumerable
            List<int> vs = new List<int> {0,1,2,3,34,35,4,5,43,62,34,6,12,13,14,15,16 };
            array.AddRange(vs);

            Console.Write("Array output : ");
            foreach (int x in array)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Введите 1 чтобы вывести нулевой элемент");
            Console.WriteLine("Введите 2 чтобы вывести массив на экран");
            Console.WriteLine("Введите 3 чтобы вставить элемент массива");
            Console.WriteLine("Введите 4 для удаления элемента массива");
            Console.WriteLine("Введите 5 для создания массива IEnumerable");
            Console.WriteLine("Введите 10 для выхода из программы ");
            int caseSwitch = int.Parse(Console.ReadLine());
            switch (caseSwitch)
            {
                case 1: 
                    //Index output
                    Console.WriteLine("Zero element a[0] = ", array[0]);
                    break;
                    
                case 2:
                    //Foreach output
                    Console.Write("Array output : ");
                    foreach (int x in array)
                    {
                        Console.Write(x + " ");
                    }
                    Console.WriteLine();
                    break;

                case 3:
                    Console.Clear();
                    //Insert by index
                    Console.Write("Введите элемент который хотите вставить x = ");
                    int X = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введте позицию перед которой будет стоять этот элемент p =  ");
                    int p = int.Parse(Console.ReadLine());
                    array.Insert(X, p);
                    Console.WriteLine("Вставка на позицию {0} элемент  {1}: ", p , X);
                    foreach (int x in array)
                    {
                        Console.Write(x + " ");
                    }
                    Console.WriteLine();
                    break;

                case 4:
                    //remove
                    Console.Write("Введите индекс элемента для удаления : ");
                    if (!int.TryParse(Console.ReadLine(), out int res))
                    {
                        Console.WriteLine("Некорректный ввод");
                        return;
                    }
                    if (!array.Remove(res))
                        Console.WriteLine("Элемент не найден");
                    else
                    {
                        Console.Write("Удаление элемента с индексом i = : ", res);
                        foreach (int x in array)
                        {
                            Console.Write(x + " ");
                        }
                        Console.WriteLine();
                    }
                    break;

                case 5:
                    //Creating an array of IEnumerable
                    DynamicArray<int> vs1 = new DynamicArray<int>(vs);
                    Console.Write("Создание массива IEnumerable: ");
                    foreach (int x in vs1)
                    {
                        Console.Write(x + " ");
                    }
                    Console.WriteLine();
                    break;

                    

                
                   

            }
            Console.ReadKey();








        }

    }

    public class DynamicArray<T> : IEnumerable, IEnumerable<T>
    {
        protected T[] array;

        public int Length { get; protected set; }

        public int Capacity
        {
            get => array.Length;
            set
            {
                if (value < Length)
                    throw new ArgumentOutOfRangeException("Wrong argument: capacity cannot be less then length");
                else
                {
                    var temp = new T[Capacity];
                    for (int i = 0; i < array.Length; i++)
                    {
                        temp[i] = array[i];
                    }
                    array = temp;
                }
            }
        }
        /// <summary>
        /// Returns an array element by index
        /// </summary>
        /// <param name="index">Item Index</param>
        /// <returns>Array element</returns>
        public T this[int index]
        {
            get
            {
                if (index < Length || index >= 0)
                    return array[index];
                else throw new ArgumentOutOfRangeException("Wrong argument: index cannot be more than array length or negative.");
            }
            set
            {
                if (index < Length || index < 0)
                    array[index] = value;
                else throw new ArgumentOutOfRangeException("Wrong argument: index cannot be more than array length or negative.");
            }
        }

        public DynamicArray()
        {
            int initCapacity = 8;
            array = new T[initCapacity];
            Length = 0;
        }

        public DynamicArray(int capacity)
        {
            array = new T[capacity];
            Length = 0;
        }

        public DynamicArray(IEnumerable<T> ts)
        {
            int additCapacity = 8;
            //Считываем количество элементов IEnumerable на входе
            int tsLength = 0;
            foreach (T item in ts)
            {
                tsLength++;
            }
            Length = tsLength;
            int newCapacity = additCapacity + tsLength;
            array = new T[newCapacity];

            int indexer = 0;
            foreach (T item in ts)
            {
                array[indexer] = item;
                indexer++;
            }
        }
        // Добавляет элемент в массив
        public void Add(T element)
        {
            if (Length > Capacity)
                array = new T[Capacity * 2];
            array[Length] = element;
            Length++;
        }
        //Добавляет все элементы из IEnumerable в конец массива.
        public void AddRange(IEnumerable<T> ts)
        {
            //количество элементов IEnumerable на входе
            int tsLength = 0;
            foreach (T item in ts)
            {
                tsLength++;
            }
            //Выберите емкость и заново создайте массив (при необходимости)
            if (Length + tsLength > Capacity)
            {
                int additionalCapacity = 8;
                int newCapacity = Capacity + tsLength + additionalCapacity;
                T[] buff = array;
                array = new T[newCapacity];
                Capacity = newCapacity;
                buff.CopyTo(array, 0);
            }
            //Добавляем элементы из IEnumerable в массив
            int index = Length;
            foreach (T item in ts)
            {
                array[index] = item;
                index++;
            }
            Length += tsLength;
        }

        //Вставляет новый элемент в позицию индекса
        public void Insert(T element, int index)
        {
            if (index < 0 || index >= Length)
                throw new ArgumentOutOfRangeException("Wrong argument: index cannot be greater then array length or negative.");
            if (Length >= Capacity)
                array = new T[Capacity * 2];
            Length++;
            for (int i = Length - 1; i > index; i--)
            {
                array[i] = array[i - 1];
            }
            array[index] = element;
        }


        // Удаляет первое вхождение элемента из массива.

        public bool Remove(T elem)
        {
            for (int i = 0; i < Length; i++)
            {
                if (array[i].Equals(elem))
                {
                    for (int j = i; j < Length - 1; j++)
                    {
                        T buf = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = buf;
                    }
                    array[Length - 1] = default;
                    Length--;
                    return true;
                }
            }
            return false;
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            T[] newArray = new T[Length];
            Array.Copy(array, newArray, Length);
            return new DynamicArrayEnumerator<T>(newArray);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            T[] newArray = new T[Length];
            Array.Copy(array, newArray, Length);
            return newArray.GetEnumerator();
        }

    }

    class DynamicArrayEnumerator<T> : IEnumerator<T>
    {
        T[] array;
        int position = -1;

        public DynamicArrayEnumerator(T[] array)
        {
            this.array = array;
        }

        public T Current
        {
            get
            {
                if (position < 0 || position > array.Length)
                    throw new ArgumentOutOfRangeException();
                else return array[position];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                if (position < 0 || position > array.Length)
                    throw new ArgumentOutOfRangeException();
                else return array[position];
            }
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (position < array.Length - 1)
            {
                position++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
