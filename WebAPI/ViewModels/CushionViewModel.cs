namespace WebAPI.ViewModels
{
    /// <summary>
    /// Current installed cushion view model
    /// </summary>
    public class CushionViewModel
    {
        /// <summary>
        /// Stand number
        /// </summary>
        public int Stand { get; set; }
        /// <summary>
        /// Installation place [O - up, U - down]
        /// </summary>
        public string Place { get; set; }
        /// <summary>
        /// Typ of roll [AW - working roll]
        /// </summary>
        public string Typ { get; set; }
        /// <summary>
        /// OS cushion number
        /// </summary>
        public int CushOs { get; set; }
        /// <summary>
        /// DS cushion number
        /// </summary>
        public int CushDs { get; set; }
    }
}