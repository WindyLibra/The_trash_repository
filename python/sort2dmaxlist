from math import *
from random import *

kq = []
hp = {}
mih = []
s=1


for i in range(5):
    bb = []
    for j in range(5):
        bb.append(randint(1, 100))
    kq.append(bb)

for i in range(5):
    hp.update({max(kq[i]): s})
    s+=1

hp = {k: v for k, v in sorted(hp.items())}

print(hp)

for i in range(len(kq)):
    print(kq[i])

#---------------------------------------------

d4c = list(hp.values())

for i in range(5):
    jjf = d4c[i]
    print(jjf)
    mih.append(kq[jjf-1])

for i in range(len(mih)):
    print(mih[i])
