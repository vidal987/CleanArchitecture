using CleanArch.Domain.Validation;
using System.Collections.Generic;

namespace CleanArch.Domain.Entities
{
    //SEALED GARANTE QUE A CLASSE NÃO PODE SER HERDADA
    public sealed class Category : Entity
    {
        public string Name { get; private set; }


        #region Construtores Parametrizados
        public Category(string name)
        {
            ValidateDomain(name);
        }

        public Category(int id, string name)
        {
            DomainExceptionValidation.When(id < 0, "Invalid Id value");
            Id = id;
            ValidateDomain(name);
        }
        #endregion

        //Alterar nome da categoria
        public void Update(string name)
        {
            ValidateDomain(name);
        }

        public ICollection<Product> Products { get; set; }

        #region Validação do dominio
        //VALIDAÇÃO DE DOMINIO
        private void ValidateDomain(string name)
        {
            //Quando o nome for nulo ou vazio
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), 
                "Invalid name. Name is required");

            DomainExceptionValidation.When(name.Length  < 3,
                "Invalid name. too short, minimum 3 characters");

            Name = name;
        }
        #endregion

    }
}
