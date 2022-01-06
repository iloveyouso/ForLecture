
bulb_list =[]

num_bulb = 10000

for i in range(num_bulb):
    bulb_list.append(False)

for i in range(num_bulb):
    n = i+1
    for j in range(num_bulb):
        if ((j+1)%n==0):
            bulb_list[j] = not bulb_list[j]

answer = bulb_list.count(True)

print(answer)