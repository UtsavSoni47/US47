a=[10,'ksc',-10,10.28]
print(a)
for i in a:
    print(i, end=" ")
print(a[0])
print(a[1:])
print(a[2:5])
print(a[-1])
print(a[-2])
print(a[-2:])
print(a[0:7:3])
a[0]=200
for i in a:
    print(i,end=" ")
    
#list methods
    
print('append method')
b=[10,20,30,40,50,60,70,80]
b.append(90)
print(b,'\n')

print('copy method')
b=[10,20,30,40,50,60,70,80]
c=b.copy()
print(b)
print(c,'\n')

print('count method')
b=[10,20,30,40,50,60,70,80]
print(b.count(80),'\n')

print('extend method')
b=[10,20,30,40,50,60,70,80]
b.extend([90,100])
print(b,'\n')

print('index method')
b=[10,20,30,40,50,60,70,80]
print(b.index(80),'\n')

print('insert method')
b=[10,20,30,40,50,60,70,80]
b.insert(0,100)
print(b,'\n')

print('pop method')
b=[10,20,30,40,50,60,70,80]
b.pop(0)
print(b,'\n')

print('clear method')
b=[10,20,30,40,50,60,70,80]
b.clear()
print(b,'\n')

print('reverse method' )
b=[10,20,30,40,50,60,70,80]
b.reverse()
print(b,'\n')

print('remove method')
b=[10,20,30,40,50,60,70,80]
b.remove(20)
print(b,'\n')

print('short method')
b = [80, 100, 90, 70, 40, 50, 10, 30, 20]
b.sort()
print(b,'\n')

print('tuple datatype')
t=(10,20,30)
print(t)
print(type(t))
print(t[0],'\n')
#t[0]=100

print('range datatype')
r=range(1,11)
#print(r)
for i in r:
    print(i,end=" ")
print('\n')

print('odd number')
r=range(1,100,2)
#print(r)
for i in r:
    print(i,end=" ")
print('\n')

print('even number')
r=range(2,101,2)
for i in r:
    print(i,end=" ")
print('\n')

print('set datatype')
s={10,10,20,30,50,50}
print(s)
print(type(s))
for i in s:
    print(i,end=" ")
print('\n')

ch=set('hello')
print(ch)
s.update([60,70])
print(s)
s.remove(50)
print(s)
print('\n')

print('fozen datatype')
s={10,10,20,30,40,40}
fs=frozenset(s)
print(fs)
print('\n')
