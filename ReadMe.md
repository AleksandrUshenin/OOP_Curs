        Основы ООП в С#

    Урок 6. Наследование и ещё немного полиморфизма

1. Для класса банковский счет переопределить операторы == и != для сравнения информации в двух счетах. Переопределить метод Equals аналогично оператору ==, не забыть переопределить метод GetHashCode(). Переопределить методToString() для печати информации о счете. Протестировать функционирование переопределенных методов и операторов на простом примере.

2. * Создать класс Figure для работы с геометрическими фигурами. В качестве полей класса задаются цвет фигуры, состояние «видимое/невидимое». Реализовать операции: передвижение геометрической фигуры по горизонтали, по вертикали, изменение цвета, опрос состояния (видимый/невидимый). Метод вывода на экран должен выводить состояние всех полей объекта. Создать класс Point (точка) как потомок геометрической фигуры. Создать класс Circle (окружность) как потомок точки. В класс Circle добавить метод, который вычисляет площадь окружности. Создать класс Rectangle (прямоугольник) как потомок точки, реализовать метод вычисления площади прямоугольника. Точка, окружность, прямоугольник должны поддерживать методы передвижения по горизонтали и вертикали, изменения цвета.