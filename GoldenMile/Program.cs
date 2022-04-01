// Задача о золотой миле
//Условие про золотую милю: 4 друга должны посетить 12 пабов, в котором выпить по британской пинте пенного напитка. 
//До каждого бара идти примерно 15-20 минут, каждый пьет пинту за 15 минут. 
//У первого друга лимит выпитого 1.6 литра, у второго 8.2, у третьего 4.3 литра, у 4 - 10.4 литра, это их максимум. 
//Необходимо выяснить, до скольки баров смогут дойти каждый из друзей(Пройденное расстояние (в барах)), пока не упадет. 
//И сколько всего времени будет потрачено на выпивку.

using System;

const int time_drink = 15;
const int time_walk = 25;

const double pinta = 0.58;

const int count_friends = 4;
const int count_bars = 12;

double [] friends_limit_volumes = new double [count_friends] {1.6,8.2,4.3,10.4};

double [] time_friends = new double[count_friends] {0,0,0,0};
double [] volume_friends = new double[count_friends] {0,0,0,0};
int [] friends_alive = new int [count_friends] {0,0,0,0};

void print_array(double [] local_array)
{
  Console.Write("[");
  for(int i=0;i<local_array.Length - 1;i++)
  {
      Console.Write($"{local_array[i]}, ");
  }
  Console.WriteLine($"{local_array[local_array.Length - 1 ]}]");
}

for(int i=0; i<count_friends;i++)
{
    for(int j=0;j<count_bars;j++)
    {
        if (friends_alive[i]==0) {time_friends[i] += time_drink;}
        if (friends_alive[i]==0)
        {
            if (volume_friends[i]<friends_limit_volumes[i]) {volume_friends[i] += pinta;}else {friends_alive[i]=j;} 
        }
        if (friends_alive[i]==0) {time_friends[i] += time_walk;}
    }
    
}
Console.WriteLine("Затраченное время");
print_array(time_friends);

for(int i=0;i<friends_alive.Length;i++)
{
    if (friends_alive[i]==0) {friends_alive[i]=11;} 
}

Console.WriteLine("Пройденное расстояние (в барах)");
Console.Write("[");
for(int i=0;i<friends_alive.Length - 1;i++)
{
    Console.Write($"{friends_alive[i]}, ");
}
Console.WriteLine($"{friends_alive[friends_alive.Length - 1 ]}]");


