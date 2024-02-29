public interface IWeapon
{
    void Attack();

    static IWeapon CreateDefault()
    {
        return new Sword();
    }
}
