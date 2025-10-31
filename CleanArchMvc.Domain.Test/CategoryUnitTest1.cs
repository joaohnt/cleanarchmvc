using System.ComponentModel;
using Clean.ArchMvc.Domain.Entities;
using FluentAssertions;

namespace CleanArchMvc.Domain.Test;

public class UnitTest1
{
    [Fact(DisplayName="teste")]
    public void CreateCategory_WithValidParameters_ResultObjectValidState()
    {
        Action action = () => new Category(1, "category name");
        action.Should().NotThrow<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
    }
    
    [Fact]
    public void CreateCategory_NegativeIdValue_ResultObjectValidState()
    {
        Action action = () => new Category(-1, "category name");
        action.Should().Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
    }
    
    [Fact(DisplayName="teste")]
    public void CreateCategory_WithInvalidName_ResultObjectValidState()
    {
        Action action = () => new Category(1, "a");
        action.Should().Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
    }
}