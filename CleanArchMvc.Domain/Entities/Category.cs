using System;
using System.Collections.Generic;
using CleanArchMvc.Domain.Validation;
using CleanArchMvc.Domain.Entities;
namespace Clean.ArchMvc.Domain.Entities
{
    public sealed class Category : Entity
    {
        public string Name { get; private set; }
        public Category(string name)
        {
            ValidateDomain(name);
        }

        public Category(int id, string name)
        {
            DomainExceptionValidation.When(id < 0, "invalid id value");
            Id = id;
            ValidateDomain(name);
        }

        public void Update(string name)
        {
            ValidateDomain(name);
        }

        public ICollection<Product> Products { get; private set; }

        private void ValidateDomain(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "invalid name. name is required");
            DomainExceptionValidation.When(name.Length < 3, "invalid name, too short, minimum 3 characters");
            Name = name;
        }
    }
}
