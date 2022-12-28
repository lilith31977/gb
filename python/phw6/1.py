# 1. Представлен список чисел. Необходимо вывести элементы исходного списка, 
# значения которых больше предыдущего элемента. Use comprehension.
# in
# 9

# out
# [15, 16, 2, 3, 1, 7, 5, 4, 10]
# [16, 3, 7, 10]

# in
# 10

# out
# [28, 20, 10, 5, 1, 24, 7, 15, 23, 25]
# [24, 15, 23, 25]

from random import sample
len_list = int(input("Введите длинну списка: "))
my_list = [i for i in sample(range(1, len_list*2), len_list)]
print("генерируем список: ", my_list)
sort_list = [my_list[i]
             for i in range(1, len(my_list)) if my_list[i] > my_list[i-1]]
print("значения больше предыдущего элемента в списке: ", sort_list)