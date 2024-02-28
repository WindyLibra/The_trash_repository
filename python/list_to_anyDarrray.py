from random import *
from math import *

n = int(input('n='))
line = int(input("on line="))
list1 = []
list2 = []
for i in range(n):
    list1.append(randint(0, 101))

print(list1)


listpl = []
count = 0

for i in range(0,n):
    listpl.append(list1[i])
    count += 1
    if count % line == 0:
        list2.append(listpl)
        listpl = []
    if i == n-1:
        list2.append(listpl)


for i in range(ceil(n/line)):
    print(list2[i])

print("elements work as in arrays")

i = int(input("i="))
j = int(input("j="))

print(list2[i][j])
