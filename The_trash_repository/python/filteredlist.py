from math import *
from random import *
'''
f = []
g = []
k=int(input("the divisor: "))
'''

def filterHand(f,k,g):
    for i in range(0,10):
        f.append(float(input(f"input {i+1} number: ")))
    for i in f:
        if floor(i)%k==0:
            g.append(i)
    print(g)

def filterRandom(f,k,g):
    for i in range(0,10):
        f.append(float(randint(0,100)))
    for i in f:
        if floor(i)%k==0:
            g.append(i)
    print(f)
    print(g)

f = []
g = []
k=int(input("the divisor: "))
h=int(input("You wanna do it yourself or leave it to random?(1 - by hand/0 - random): "))
if h==1:
    filterHand(f,k,g)
elif h==0:
    filterRandom(f,k,g)
else:
    print("Error: invalid answer")
