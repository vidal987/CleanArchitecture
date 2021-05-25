using CleanArch.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Entities
{
    //SEALED GARANTE QUE A CLASSE NÃO PODE SER HERDADA
    //PRIVATE garante que as propriedades não podem ser alterardas externamente
    public sealed class Product : Entity
    {
        public string Name { get; private set; }
        public string  Description { get; private set; }
        public decimal Price { get; private set; }
        public int Stock { get; private set; }
        public string Image { get; private set; }

        #region Contrutores parametrizados
        public Product(string name, string description, decimal price, int stock, string image)
        {
            ValidateDomain(name, description, price, stock, image);
        }

        public Product(int id, string name, string description, decimal price, int stock, string image, int categoryId, Category category)
        {

            DomainExceptionValidation.When(id < 0, "Invalid Id value");
            Id = id;
            ValidateDomain(name, description, price, stock, image);
        }
        #endregion

        public void Update(string name, string description, decimal price, int stock, string image, int categoryId)
        {
            ValidateDomain(name, description, price, stock, image);
            CategoryId = categoryId;
        }


        #region Validação de dominio
        public void ValidateDomain(string name, string description, decimal price, int stock, string image)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name),
                "Invalid name. Name is required");

            DomainExceptionValidation.When(name.Length < 3,
                "Invalid name. too short, minimum 3 characters");

            DomainExceptionValidation.When(string.IsNullOrEmpty(description),
               "Invalid description. description is required");

            DomainExceptionValidation.When(description.Length < 5,
                "Invalid description. too short, minimum 5 characters");

            DomainExceptionValidation.When(price < 0, "Invalid price value");

            DomainExceptionValidation.When(stock < 0, "Invalid price value");

            DomainExceptionValidation.When(image.Length > 250,
                "Invalid image name. too long. maximum 250 characters");

            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
            Image = image;
        }
        #endregion
        public int CategoryId { get; set; }
        public Category category { get; set; }
    }
}
