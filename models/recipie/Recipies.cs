using shoppingAPI.enums;

namespace shoppingAPI.models.Recipies
{
    public class Recipies
    {
        public int RecID;
        public string RecDescription;
        public string RecIngredients;
        public string RecInstructions;
        public RecipieTypeENUM RecType;
        public RecipieMealTypeENUM RecMealType;
        public string RecLink;
    }
}