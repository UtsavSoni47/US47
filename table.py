# Simple multiplication table

num = int(input("Enter a number to print its table: "))

print("Multiplication table of:", num)

for i in range(1, 11):
    print(num, "x", i, "=", num * i)
