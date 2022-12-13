# 2. Напишите программу, которая найдёт произведение пар чисел списка.
# Парой считаем первый и последний элемент, второй и предпоследний и т.д.
# in
# 4

# out
# [2, 5, 8, 10]
# [20, 40]

# in
# 5

# out
# [2, 2, 4, 8, 8]
# [16, 16, 4]



# def completion (number: list):
#     for i in range(number):
#         list.append(randint(0, 9))
#     return list

# def matching (number: completion(list)):
#     for i in range(len(list)):
#         while i < len(list)/2 and number > len(list)/2:
#             number = number - 1
#             a = list[i] * list[number]
#             list2.append(a)
#             i += 1
#         return list2

# from random import randint

# number = int(input("Введите размер списка "))
# list = []
# list2 = []

# print(list[])
# print


def completion (number, lists):
    for i in range(number):
        lists.append(randint(0, 9))
    return lists

def matching (number, lists,list2):
    
    for i in range(len(lists)):
        while i < len(lists)/2 and number > len(lists)/2:
            number = number - 1
            a = lists[i] * lists[number]
            list2.append(a)
            i += 1
        return list2

from random import randint

number = int(input("Введите размер списка "))

list2 = []
lists = []

lists=completion(number,lists)
matching (number, lists,list2)

print(lists)
print(list2)
