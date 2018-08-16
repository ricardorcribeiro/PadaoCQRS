namespace Equinox.Domain.Models
{
    public class Customer : Entity
    {
        
        public Customer(string name, string email, DateTime birthDate) 
        {
            this.Name = name;
            this.Email = email;
            this.BirthDate = birthDate;
        }
        
        protected Customer(){}
        public string Name { get; set; }   
        public string Email { get; set; }   
        public DateTime BirthDate { get; set; }
    }
}