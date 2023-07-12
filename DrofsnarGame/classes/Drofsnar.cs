namespace Classes;

public class Drofsnar
{
    public bool ExtraLife { get; set; }
    public int Points { get; set; }
    public int Lives { get; set; }
    public int HunterPoints { get; set; }
    public void EncounterObject(string bird)
    {
        switch(bird)
        {
            case "Bird":
                Points += 10;
                break;
            case "CrestedIbis":
                Points += 100;
                break;
            case "GreatKiskudee":
                Points += 300;
                break;
            case "RedCrossbill":
                Points += 500;
                break;
            case "Red-neckedPhalarope":
                Points += 700;
                break;
            case "EveningGrosbeak":
                Points += 1000;
                break;
            case "GreaterPrairieChicken":
                Points += 2000;
                break;
            case "IcelandGull":
                Points += 3000;
                break;
            case "Orange-belliedParrot":
                Points += 5000;
                break;
            case "VulnerableBirdHunter":
                Points += HunterPoints;
                HunterPoints *= 2;
                break;
            case "InvincibleBirdHunter":
                Lives -= 1;
                break; 
        }
        if (Points >= 10000 && ExtraLife == false)
        {
            Lives += 1;
            ExtraLife = true;
        }
    }
    public Drofsnar(int points, int lives)
    {
        this.Points = points;
        this.Lives = lives;
        this.HunterPoints = 200;
        this.ExtraLife = false;    
    }
}