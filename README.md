# **Задача:**

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## **Решение:**

1. объявляем пустой массив длиной в 4 значения.
2. значения массива вводятся с клавиатуры с новой строки.
3. метод FillArray производит заполнение массива:
    - циклом for до заданной длины массива (array.Length) заполняем элементы массива;
4. метод PrintArray проверяет длину строки <=3 и выводит новый массив в консоль:
    - циклом for проверяем каждый элемент массива (array.Length)
    - если (if) длина строки меньше или равна 3, то печатаем значение в консоль.
