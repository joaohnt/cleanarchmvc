using System.ComponentModel;
using Clean.ArchMvc.Domain.Entities;
using FluentAssertions;

namespace CleanArchMvc.Domain.Test;

public class ProductUnitTest
{
    [Fact(DisplayName="teste")]
    public void CreateProduct_WithValidParameters_ResultObjectValidState()
    {
        Action action = () => new Product(1, "product name", "product description", 10.50m, 100, "urlimage");
        action.Should().NotThrow<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
    }
    
    [Fact]
    public void CreateProduct_NegativeIdValue_ResultObjectValidState()
    {
        Action action = () => new Product(-1, "product name", "product description", 10.50m, 100, null);
        action.Should().Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
    }
    
    // [Fact(DisplayName="teste")]
    // public void CreateProduct_WithInvalidName_ResultObjectValidState()
    // {
    //     Action action = () => new Product(1, "a");
    //     action.Should().Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
    //         .WithMessage("invalid name, too short, minimum 3 characters");
    // }
}