public static class ChordFormulas
{
    public static readonly List<ChordFormula> All = new()
    {
        new("Major", new[]{0,4,7}),
        new("Minor", new[]{0,3,7}),
        new("Diminished", new[]{0,3,6}),
        new("Augmented", new[]{0,4,8}),

        new("Major7", new[]{0,4,7,11}),
        new("Dominant7", new[]{0,4,7,10}),
        new("Minor7", new[]{0,3,7,10})
    };
}