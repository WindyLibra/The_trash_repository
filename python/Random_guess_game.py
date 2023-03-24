from random import *
while True:
    a=randint(1,100)
    s=0
    for i in range(7):
        print(f"You have {7-i} attempts")
        f=int(input("Your guess is: "))
        if f==a:
            print(f"You're goddamn right, the number is {a}")
            break
        elif f>a:
            print("Your guess is bigger")
        elif f<a:
            print("Your guess is lower")
        s+=1
    if s==7:
        print(f"You've ran out of attempts, the number was {a}")
    again = input("Wanna play again? (y/n): ")
    if again=="n":
        break
