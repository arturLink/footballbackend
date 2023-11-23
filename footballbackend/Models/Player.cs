namespace footballbackend.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string Sex { get; set; }
        public string DateOfBirth { get; set; }
        public int TeamId { get; set; }
        public string Country { get; set; }
    }
}
