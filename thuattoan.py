import numpy as np
import random

#64 57 81 98 59 87 93 62 20 14
process1 = np.array([64, 57, 81, 98, 76])
process2 = np.array([39, 96, 88, 83, 62])
process3 = np.array([96, 66, 88, 60, 83])
process4 = np.array([93, 92, 96, 70, 67])
job = []
pop_size = 40
num_of_jobs = 5
num_of_machines = 5
num_of_process =4
num_of_operations = num_of_process*num_of_jobs
crossover = 0.7
mutate = 0.3
Loop = 40

class Operation:
    start_time = 0
    job_number = None
    def __init__(self, number, machine, operation_time):
        self.number = number
        self.machine = machine
        self.operation_time = operation_time

class Machine:

    def __init__(self,list_of_operations,number_machine):
        self.number_machine = []
        self.time = []
        for i, line in enumerate(list_of_operations):
            for j, operation in enumerate(line):
                if operation.machine == number_machine:
                    self.number_machine.append([j+1,i+1])
                    self.time.append(operation.operation_time)
class Fitness:
    time_largest = 0
    def __init__(self,job,time):
        self.job = job
        self.time_last = time
class Danhgia:
    def __init__(self,chromosome,timemax):
        self.chromosome = chromosome
        self.max = timemax
def initialize_population():
    list_of_operations = []
    op_counter = 1
    for i, line in enumerate(job):
        operation_list = []
        list_of_machines = []
        for operation_time in line:
            rand_num = random.randint(1, num_of_machines)
            if rand_num not in list_of_machines:
                list_of_machines.append(rand_num)
                time = int(operation_time)
                new_operation = Operation(op_counter, rand_num, time)
                operation_list.append(new_operation)
                op_counter += 1
            else:
                while (True):
                    rand_num = random.randint(1, num_of_machines)
                    if rand_num not in list_of_machines:
                        list_of_machines.append(rand_num)
                        time = int(operation_time)
                        new_operation = Operation(
                            op_counter, rand_num, time)
                        operation_list.append(new_operation)
                        op_counter += 1
                        break
                    else:
                        continue
        list_of_operations.append(operation_list)
    return list_of_operations
def population(pop_size):
    population = []
    for a in range(pop_size):
        list = initialize_population()
        population.append(list)
    return population
def Time_max(chromosome):
    machine = []
    machine.append(0)
    fitness = []
    fitness.append(0)
    for i in range(1, num_of_machines + 1):
        machine.append(Machine(chromosome, i))
        fitness.append(Machine(chromosome, i))


    for i in range(1, num_of_process + 1):
        if i == 1:
            for j in range(1, num_of_machines + 1):
                fitness[j] = Fitness(machine[j].number_machine[i - 1][0], machine[j].time[i - 1])

        else:
            for j in range(1, num_of_machines + 1):
                fitness[j].job = machine[j].number_machine[i - 1][0]
                for a in range(1, num_of_machines + 1):
                    if machine[j].number_machine[i - 1][0] == machine[a].number_machine[i - 2][0]:
                        stt1 = fitness[j].time_last
                        stt2 = fitness[a].time_last
                        if stt1 < stt2:
                            fitness[j].time_largest = fitness[a].time_last + machine[j].time[i - 1]
                        else:
                            fitness[j].time_largest = fitness[j].time_last + machine[j].time[i - 1]
                        break
            for j in range(1, num_of_machines + 1):
                fitness[j].time_last = fitness[j].time_largest
    max = fitness[1].time_largest
    for i in range(1, num_of_machines + 1):
        if max < fitness[i].time_largest:
            max = fitness[i].time_largest
    return max
def Crossing(population,crossover):
    num_parent1 = random.randint(0,pop_size-1)
    while True:
        num_parent2 = random.randint(0, pop_size-1)
        if num_parent2 != num_parent1:
            break
    parent1 = population[num_parent1].chromosome
    parent2 = population[num_parent2].chromosome
    child1 = parent1
    child2 = parent2
    if crossover > random.randint(0,100):
        for i,line in enumerate(parent2):
            if random.randint(0,1) == 1:
                child1[i] = line
    if crossover > random.randint(0,100):
        for i,lines in enumerate(parent1):
            if random.randint(0,1) == 1:
                child2[i] = lines
    return [child1,child2]
def Mutate(child):
    num_mutate = random.randint(0,num_of_process-1)
    num_genmutate1 = random.randint(0,num_of_machines-1)
    while True:
        num_genmutate2 = random.randint(0,num_of_machines-1)
        if num_genmutate2 != num_genmutate1:
            break
    return [num_mutate,num_genmutate1,num_genmutate2]
def chuongtrinh():

    danso = population(pop_size)
    population_after = []
    for i,chromosome in enumerate(danso):
        time_max = Time_max(chromosome)
        chromosome_after = Danhgia(chromosome,time_max)
        population_after.append(chromosome_after)
    counter = 0
    print(pop_size, mutate, crossover)
    print(Loop)
    while counter < Loop:

        child1,child2 = Crossing(population_after,crossover)
        # Mutate
        # child1
        if mutate > random.randint(0, 100):
            num_mutate, num_genmutate1, num_genmutate2 = Mutate(child1)
            num_machine = child1[num_mutate][num_genmutate1].machine
            child1[num_mutate][num_genmutate1].machine = child1[num_mutate][num_genmutate2].machine
            child1[num_mutate][num_genmutate2].machine = num_machine
        # child2
        if mutate > random.randint(0, 100):
            num_mutate, num_genmutate1, num_genmutate2 = Mutate(child2)
            num_machine = child2[num_mutate][num_genmutate1].machine
            child2[num_mutate][num_genmutate1].machine = child2[num_mutate][num_genmutate2].machine
            child2[num_mutate][num_genmutate2].machine = num_machine

        time_max = Time_max(child1)
        child1 = Danhgia(child1, time_max)
        time_max = Time_max(child2)
        child2 = Danhgia(child2, time_max)
        population_after.append(child1)
        population_after.append(child2)
        population_after = sorted(population_after, key=lambda x: x.max)[0:pop_size]
        counter += 1
    print(' OK ')
    return draw_job(population_after[0].chromosome)

    #print(population_after[0].chromosome)
def draw_job(chromosome):
    machine_time = []
    machine = []
    machine.append(0)
    fitness = []
    fitness.append(0)
    for i in range(1, num_of_machines + 1):
        machine.append(Machine(chromosome, i))
        fitness.append(Machine(chromosome, i))
        machine_time.append(Machine(chromosome, i))
    cout = []

    for i in range(num_of_machines):
        cout.append(0)

    for i in range(1, num_of_process + 1):
        if i == 1:
            for j in range(1, num_of_machines + 1):
                fitness[j] = Fitness(machine[j].number_machine[i - 1][0], machine[j].time[i - 1])

        else:
            for j in range(1, num_of_machines + 1):
                cout1 = False
                fitness[j].job = machine[j].number_machine[i - 1][0]
                for a in range(1, num_of_machines + 1):
                    if machine[j].number_machine[i - 1][0] == machine[a].number_machine[i - 2][0]:
                        stt1 = fitness[j].time_last
                        stt2 = fitness[a].time_last
                        if stt1 < stt2:
                            fitness[j].time_largest = fitness[a].time_last + machine[j].time[i - 1]
                            machine_time[j-1].time.insert(i-1 + cout[j-1],fitness[a].time_last-fitness[j].time_last)
                            machine_time[j-1].number_machine.insert(i-1 + cout[j-1], 'a')
                            cout1 = True
                            if cout1 is True:
                                cout[j-1] +=1
                                cout1 = False
                        else:
                            fitness[j].time_largest = fitness[j].time_last + machine[j].time[i - 1]
                        break
            for j in range(1, num_of_machines + 1):
                fitness[j].time_last = fitness[j].time_largest

    max = fitness[1].time_largest
    for i in range(1, num_of_machines + 1):
        if max < fitness[i].time_largest:
            max = fitness[i].time_largest
    jobs_time = []
    num_jobs = []
    for i in range(num_of_machines):
        jobs_time.append(machine_time[i].time)
        num_jobs.append(machine_time[i].number_machine)
    return [max, jobs_time, num_jobs]
