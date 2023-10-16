
// int[] array = { 1, 4, 9, 10, 5, 2, 8, 6, 7, 3};

// int n = array.Length;
// int find = 3;

// int i = 0;

// while (i<n)
// {
//     if (array[i] == find)
//     {
//         Console.WriteLine(i);
//         break;
//     }
//     i++;
// }


// метод, имя метода    Переменная(collection) К НЕЙ МЫ ОБРАЩАЕМСЯ
void FullArray (int [] collection) // 2. Создаём метод (Void) Для заполнения случайными числами.  Void метод ничего не возвращает 
{    // 2.1 С помощью Lenght получаем длинну нашего массива С ПЕРЕМЕННОЙ
    int Dlina = collection.Length; 
    // 2.2 Позиция i по умолчанию ставим на 0
    int i = 0;
    while (i<Dlina) // 2.3  !!!!!!     внутри While пишется i++ !!!!!!
    { // 2.4 к ПЕРЕМЕННОЙ    позиции     Кладём случайное число
        collection           [i] =          new Random().Next(1,10); // 3. обращаемся к collectoin(ПЕРЕМЕННОЙ) и кладенм рандомное число
        i++;
    }
}


void PrintArray (int[] col) // 3. Создаём метод (Void) который печатает .Void  метод ничего не возвращает 
{// количество элементов 
    int count = col.Length;
    int position = 0;
    while (position<count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
    //Оператор return не используется в void
    
}

int iVIHOD(int[] collection, int find)
{
    int KOLICHESTVOelementov = collection.Length;
    int i = 0;
    int Mesto = -1;
    while(i<KOLICHESTVOelementov)
    {
        if(collection[i] == find)
        {
            Mesto = i;
            break;
        }
        i++;

    }
    return Mesto;
}

int[] array = new int[10]; // 1. Определяем новый массив с названием Array. По умолчанию наполнен десятью нулями


//Тестируем методы. Где аргумент указываем УКАЗЫВАЕМ наименование нашего массива
FullArray(array);
PrintArray(array);
// всё
Console.WriteLine();
int QMesto = iVIHOD(array, 4);
Console.WriteLine(QMesto);


