**Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Решение**:
1. Программа принимает на вход строковый массив words: ["hello", "2", "world", ":-)"]
2. Создается метод ShowArray, в котором реализуется вывод исходного массива на экран посредством цикла.
3. Создается метод ShortArray, в котором создается новый массив newWords. Далее, посредством цикла, элементы массива words проверяются на соответствие условию: длина элемента массива должна быть <= 3 символам. В случае, если элемент массива соответствует условию, то он записывается в новый массив countNewWords.
4. Выполняется вывод на экран содержимого нового массива.