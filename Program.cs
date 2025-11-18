int hp = 100;

void TakeDamage(int amount)
{
	hp -= amount;
	Console.WriteLine(hp <= 0 ? "Dead" : $"HP: {hp}");
}

TakeDamage(90);

int maxHp = 100;
void Heal(int amount)
{
    hp += amount;
	Console.WriteLine(hp > 100 ? $"HP: {hp = maxHp}" : $"HP: {hp}");
}

Heal(900);

int level = 1;
int exp = 0;
int expToLevel = 100;

void AddExp(int amount)

{
	exp += amount;
	while (exp >= expToLevel)
	{
		exp -= expToLevel;
		level++;
		Console.WriteLine($"Level UP! {level}");
	}
	Console.WriteLine($"EXP: {exp}/{expToLevel}");
}

AddExp(100);
AddExp(90);
AddExp(10);
AddExp(99);

void RandomDamage(int min, int max)
{
    Random random = new Random();
	int damage = random.Next(min,max);
	Console.WriteLine($"Damage: {damage}");
}

RandomDamage(1,10);