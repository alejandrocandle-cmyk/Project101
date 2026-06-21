using Final;

Console.WriteLine($"How many favorite foods do you have?");
string food = Console.ReadLine();
int foodint = Convert.ToInt32(food);

int total = -1;

string[] favorite = new string[foodint];

Console.WriteLine("Put your favorite food in");

for(int i = 0; i < foodint; i++)
{
    total += 1;
    Console.WriteLine($"Enter name {total}");
    favorite[total] = Console.ReadLine();
}

int totalv2 = 0;
Console.WriteLine("This is all your favorite food");
for (int i = 0; i < favorite.Length; i++)
{
    totalv2 += 1;
    Console.WriteLine($"{totalv2}: {favorite[i]}");
}

Console.WriteLine("How much time do you eat your favorite food in day?");
string time = Console.ReadLine();
int timeint = Convert.ToInt32(time); 

string result = costmethod(timeint);
Console.WriteLine(result);

static string costmethod(int week)
{
    int sum = week * 7;
    return $"This is how much time you eat your favorite food a week {sum}";
}

FinalClass person = new FinalClass();
Console.WriteLine("What your number one favorite food?");
string answer1person = Console.ReadLine();
Console.WriteLine("What your place to eat it at?");
string answer2person = Console.ReadLine();
Console.WriteLine("How much does it cost?");
string answer3person = Console.ReadLine();

int answer3int = Convert.ToInt32(answer3person);

person.SetFavoriteFood(answer1person);
person.SetPlace(answer2person);
person.SetCost(answer3int);

Console.WriteLine($"Your favorite food is {person.GetFavoriteFood()} and you get it at {person.Getplace()} and it cost about ${person.Getcost()}");

if(answer1person == "pizza")
{
    Console.WriteLine("I love pizza too, its so good");
}

else
{
    Console.WriteLine("Your favorite food sounds good but I like pizza little bit better");
}