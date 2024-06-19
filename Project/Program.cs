class Program
{
    static void Main()
    {
        Weapon weapon = new Weapon(30, 10, "tekli");

        while (true)
        {
            Console.WriteLine("0 - İnformasiya almaq üçün");
            Console.WriteLine("1 - Shoot metodu üçün");
            Console.WriteLine("2 - Fire metodu üçün");
            Console.WriteLine("3 - GetRemainBulletCount metodu üçün");
            Console.WriteLine("4 - Reload metodunu çağırmaq üçün");
            Console.WriteLine("5 - ChangeFireMode metodu üçün");
            Console.WriteLine("6 - Proqramdan dayandırmaq üçün");

            string choice = Console.ReadLine();

            if (choice == "0")
            {
                Console.WriteLine($"Atış modu: {weapon.GetFireMode()}");
                Console.WriteLine($"Qalan gülle sayı: {weapon.GetRemainBulletCount()}");
            }
            else if (choice == "1")
            {
                weapon.Shoot();
            }
            else if (choice == "2")
            {
                weapon.Fire();
            }
            else if (choice == "3")
            {
                Console.WriteLine($"Qalan gülle sayı: {weapon.GetRemainBulletCount()}");
            }
            else if (choice == "4")
            {
                weapon.Reload();
            }
            else if (choice == "5")
            {
                Console.WriteLine("Yeni atış modunu daxil edin:");
                string newFireMode = Console.ReadLine();
                weapon.ChangeFireMode(newFireMode);
            }
            else if (choice == "6")
            {
                break; // while dövründən çıxmaq üçün
            }
            else
            {
                Console.WriteLine("Düzgün seçim edin.");
            }
        }
    }
}