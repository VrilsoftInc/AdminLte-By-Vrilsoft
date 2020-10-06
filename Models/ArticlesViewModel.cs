namespace AdminLte_By_Vrilsoft.Models
{
    public static class ArticlesViewModel
    {
        public static string AuthorNameBy_ID(int id, bool getName)
        {
            if (getName)
                return string.Empty; //This is where we get the Author Name of an Article. Change type to string!!!
            else return "";
        }
    }
}
