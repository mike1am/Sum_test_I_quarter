# Итоговая проверочная работа по I четверти

## Формирование массива строк

### Задача
Требуется сформировать массив строк из имеющегося массива, где длина строк меньше либо равна заданному количеству символов.

При решении задачи предполагается использовать массивы с определённым заранее числом элементов.

### Решение
Пользователь вводит длину и элементы изначального массива строк, а также максимальное количество символов для выбора элементов в результирующий массив.

Далее в цикле осуществляется перебор элементов изначального массива с определением элементов, подлежащих копированию в результирующий массив, а также их количества. После чего создаётся результирующий массив с определённым в этом цикле числом элементов. Для оперделения элементов, подлежащих копированию, создаётся вспомогательный массив с элементами логического типа, определяющими необходимость копирования элементов изначального массива в результирующий.

В последнем цикле осуществляется копирование нужных элементов из изначального массива в результирующий. После чего осуществляется вывод результирующего массива на консоль.