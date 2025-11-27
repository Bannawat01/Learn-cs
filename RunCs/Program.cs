class Player 
{
  public int Hp = 100;

  static void Main(string[] args)
  {
    Player Hero = new Player();
    Hero.Hp = 100;
    void Attack(int damage)
    {
      Hero.Hp -= damage;
    }
    int damage = 10;
    Attack(damage);
    Console.WriteLine($"player: HP is {Hero.Hp} Damage is {damage}");
  }
  
}

// class Enemy
// {
// 	public string nameOfenermy = string.Empty;
// 	public int hp;
// }

// class Program
// {
// 	static void Main(string[] args)
// 	{

// 		List<string> weapons = new List<string>(4);
// 		weapons.Add("Sword");
// 		weapons.Add("Axe");
// 		weapons.Add("Bow");
// 		weapons.Add("Magic Staff");

// 		foreach (var item in weapons)
// 		{
// 			Console.WriteLine(item);
// 		}

// 		List<int> damageList = new List<int>();
// 		damageList.Add(10);
// 		damageList.Add(12);
// 		damageList.Add(20);
// 		damageList.Add(50);
// 		var max = damageList[0];

// 		for (int i = 1; i < damageList.Count; i++)
// 		{
// 			var next = damageList[i];
// 			if (max < next)
// 			{
// 				max = next;
// 			}
// 		}
// 		Console.WriteLine(max);

// 		List<int> enemyHp = new List<int>() { 100, 50, 200, 10 };
// 		enemyHp.RemoveAll(hp => hp <= 50);
// 		for (int i = 0; i < enemyHp.Count; i++)
// 		{

// 			Console.WriteLine(enemyHp[i]);
// 		}



// 		List<Enemy> enemies = new List<Enemy>();
// 		Enemy slime = new Enemy();
// 		slime.nameOfenermy = "Slime";
// 		slime.hp = 50;

// 		Enemy goblin = new Enemy();
// 		goblin.nameOfenermy = "Goblin";
// 		goblin.hp = 100;

// 		Enemy orc = new Enemy();
// 		orc.nameOfenermy = "Orc";
// 		orc.hp = 200;

// 		enemies.Add(slime);
// 		enemies.Add(goblin);
// 		enemies.Add(orc);

// 		foreach (var item in enemies)
// 		{
// 			Console.WriteLine(item.nameOfenermy);
// 		}
// 	}
// }




// for (int i = 0; i < 10; i++)
// {
// 	Console.WriteLine(i+1);
// }

// int num = 0;
// for (int i = 0; i < 100+1; i++)
// {
// 	num = num + i;
// }
// Console.WriteLine(num);

// string[] nameOfenermy = ["Slime", "Goblin", "Orc", "Dragon"];
// for (int i = 0; i < nameOfenermy.Length ; i++)
// {
// 	Console.WriteLine($"Enemy {i+1}: {nameOfenermy[i]}");
// }

// int[] enemyHp = [ 50, 120, 80, 200, 10 ];
// Console.WriteLine(enemyHp.Max());

// int hp = 100;

// void TakeDamage(int amount)
// {
// 	hp -= amount;
// 	Console.WriteLine(hp <= 0 ? "Dead" : $"HP: {hp}");
// }

// TakeDamage(90);

// int maxHp = 100;
// void Heal(int amount)
// {
//     hp += amount;
// 	Console.WriteLine(hp > 100 ? $"HP: {hp = maxHp}" : $"HP: {hp}");
// }

// Heal(900);

// int level = 1;
// int exp = 0;
// int expToLevel = 100;

// void AddExp(int amount)

// {
// 	exp += amount;
// 	while (exp >= expToLevel)
// 	{
// 		exp -= expToLevel;
// 		level++;
// 		Console.WriteLine($"Level UP! {level}");
// 	}
// 	Console.WriteLine($"EXP: {exp}/{expToLevel}");
// }

// AddExp(100);
// AddExp(90);
// AddExp(10);
// AddExp(99);

// void RandomDamage(int min, int max)
// {
//     Random random = new Random();
// 	int damage = random.Next(min,max);
// 	Console.WriteLine($"Damage: {damage}");
// }

// RandomDamage(1,10);