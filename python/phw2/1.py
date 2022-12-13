# 1. Напишите программу, которая принимает на вход
# вещественное число и показывает сумму его цифр.
# Без работы с методами строк.
# in -> out
# - 6782 -> 23
# - 0.67 -> 13
# - 198.45 -> 27

num = input('Введите число: ')
sum = 0

power = len(num) - 2
num = float(num)
num *= int(10 ** power)

while num:
    sum += int(num%10)
    num  //= 10


# for a in num:
#     if a.isdigit():
#         sum += int(a)

print (f"Сумма цифр в числе равна: ", sum)