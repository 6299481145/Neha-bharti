n=int(input("Enter a number: "))
ft = st = 1
print("Fibonacci Series: ", end=" ")
print(ft, end=" ")
print(st, end=" ")
for i in range(3, n+1):
    nt = ft + st 
    print(nt, end=" ")
    ft = st
    st = nt