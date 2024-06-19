using System;

public class Weapon
{
    private int bulletCount;
    private int maxBulletCapacity;
    private string fireMode;

    public Weapon(int maxBulletCapacity, int initialBulletCount, string initialFireMode)
    {
        this.maxBulletCapacity = maxBulletCapacity;
        this.bulletCount = initialBulletCount;
        this.fireMode = initialFireMode;
    }

    public void Shoot()
    {
        if (bulletCount > 0)
        {
            Console.WriteLine("Gülle atıldı!");
            bulletCount--;
        }
        else
        {
            Console.WriteLine("Daraqda gülle qalmayıb!");
        }
    }

    public void Fire()
    {
        if (bulletCount > 0)
        {
            Console.WriteLine($"Bütün gülleler atəşləndi! {bulletCount} gülle qalıb.");
            bulletCount = 0;
        }
        else
        {
            Console.WriteLine("Daraqda gülle qalmayıb!");
        }
    }

    public int GetRemainBulletCount()
    {
        return bulletCount;
    }

    public void Reload()
    {
        bulletCount = maxBulletCapacity;
        Console.WriteLine($"Daraq yenidən dolduruldu. {bulletCount} gülle var.");
    }

    public void ChangeFireMode(string newFireMode)
    {
        fireMode = newFireMode;
        Console.WriteLine($"Atış modu dəyişdirildi: {fireMode}");
    }

    public string GetFireMode()
    {
        return fireMode;
    }
}