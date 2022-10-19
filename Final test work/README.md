## Описание решения:

1. Задается массив строк *arrayStringInit*;
2. Определяется число строк в массиве, длина которых меньше или равна трем;
3. Создается новый массив *arrayStringResult* с числом строк, определенным на предыдущем этапе (длина которых меньше или равна трем);
4. В цикле проверяется длина строк в массиве *arrayStringInit*, и те строки, длина которых меньше или равна трем, записываются в массив *arrayStringResult*;
5. Выводится массив *arrayStringResult*.

_**Используемые функции**_:

* _int GetNumStringsLessOrEqual3(string[] arrayString)_ - возвращает число строк массива *arrayString*, длина которых меньше или равна трем
* _void FillArrayStringsLessOrEqual3(string[] arrayStringInit, string[] arrayStringResult)_ - заполняет массив *arrayStringResult* строками из массива *arrayStringInit*, длина которых меньше или равна трем.