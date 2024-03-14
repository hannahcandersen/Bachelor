namespace DefaultNamespace;

public class LevelData : ILevelData
{
    public string LevelName { get; set; }
    public int LevelIndex { get; set; }
    public bool IsUnlocked { get; set; } = false; 
    public Potion Potion { get; set; }
    public Recipe Recipe { get; set; }
    public List<Ingredient> Ingredients { get; set; }

    public LevelData(string levelName, int levelIndex, Potion potion, Recipe recipe, List<Ingredient> ingredients)
    {
        LevelName = levelName;
        LevelIndex = levelIndex;
        Potion = potion;
        Recipe = recipe;
        Ingredients = ingredients;
    }

}