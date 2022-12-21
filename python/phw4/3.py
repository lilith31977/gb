
# 3. Задайте последовательность чисел. Напишите программу, которая выведет список неповторяющихся элементов исходной последовательности в том же порядке.
# in
# 7

# out
# [4, 5, 3, 3, 4, 1, 2]
# [5, 1, 2]

# in
# -1

# out
# Negative value of the number of numbers!
# []

# in
# 10

# out
# [4, 4, 5, 5, 6, 2, 3, 0, 9, 4]
# [6, 2, 3, 0, 9]

def return_unique(my_list, new_list):
        for char in my_list:
            if my_list.count(char) < 2:
                new_list.append(char)


my_list = list(map(int, input("Введите числа через пробел:\n").split()))
new_list = []
return_unique(my_list, new_list)
print(f"Исходный список: {my_list}")
print(f"Список из неповторяющихся элементов: {new_list}")



# lists=completion(number,lists)
# matching (number, lists,list2)

# print(lists)
# print(list2)