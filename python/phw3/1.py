# 1. Задайте список, состоящий из произвольных чисел, количество задаёт пользователь.
# Напишите программу, которая найдёт сумму элементов списка, стоящих на нечётных позициях(не индексах).
# in
# 5

# out
# [10, 2, 3, 8, 9]
# 22

# in
# 4

# out
# [4, 2, 4, 9]
# 8


# x = [2, 3, 6, 10, 12, 16, 5]
# #print(x)
# summ = 0
# for i in range(1, len(x), 2):
#     #if i % 2 == 1:
#         summ += x[i]       
# print(f"{x} -> сумма элементов на нечётных позициях: {summ}")



def list_r(count:int):
    if count < 0:
        print("введите положительное число")
        return[]
    
    list_n = sample(range(1, count * 2), count)
    return list_n

def sum (list_n: list):
    sum_n = 0
    for k in range(0, len(list_n), 2):
        sum_n += list_n[k]
        return sum_n

from random import sample
all_list = list_r (int(input("Введите размер списка ")))
print("Сумма элементов списка, стоящих на нечётных позициях ", all_list, "равна", sum(all_list))


