using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using FluentAssertions;
using IaSiMananca.Business.Logic.Implementations;
using IaSiMananca.DataAccess.Entities;
using IaSiMananca.DataAccess.Repository;
using Moq;
using Xunit;


namespace IaSiMananca.Tests
{
    public class RestaurantLogicTests
    {
        private Mock<IRepository<Restaurant>> repositoryMock;
        private RestaurantLogic sut; // System under test

        private void SetupTests()
        {
            repositoryMock = new Mock<IRepository<Restaurant>>();
            sut = new RestaurantLogic(repositoryMock.Object);
        }

        private void TearDownTests()
        {
            repositoryMock = null;
            sut = null;
        }

        [Fact]
        public void When_GetByIdIsCalled_Then_ShouldReturnCorrectEvent()
        {
            SetupTests();

            // Arrange
            var lookupId = new Guid("B69FA565-4BE1-46A3-A6DD-1DE633451341");
            repositoryMock
                .Setup(r => r.GetById(lookupId))
                .Returns(new Restaurant { Id = lookupId });

            // Act
            var result = sut.GetById(lookupId);

            // Assert 
            result.Should().NotBeNull();
            result.Id.Should().Be(lookupId);

            TearDownTests();
        }

        [Fact]
        public void When_GetByTypeIsCalled_Then_ShouldReturnCorrectEvents()
        {
            SetupTests();

            //Arrange
            var typeString = new String("333E879F-5068-404E-8C94-4FA8DEF23ABF");
            repositoryMock
                .Setup(r => r.Filter(It.IsAny<Expression<Func<Restaurant, bool>>>()))
                .Returns(new List<Restaurant>
                {
                    new Restaurant{
                        Type = typeString
                    }
                });

            //Act
            var result = sut.GetByType(typeString);

            //Assert
            result.Should().NotBeNull();
            result.Count().Should().Be(1);
            result.First().Type.Should().Be(typeString);

            TearDownTests();
        }



        [Fact]
        public void When_GetByNameIsCalled_Then_ShouldNotReturnNull()
        {
            SetupTests();

            // Arrange
            var lookupName = "Class";
            SetupTests();
            repositoryMock
                .Setup(r => r.GetAll())
                .Returns(new List<Restaurant>
                {
                    new Restaurant
                    {
                        Name = "not class"

                    },
                    new Restaurant
                    {
                        Name = "not class"

                    },
                    new Restaurant{
                        Name = lookupName
                    }

                });

            // Act
            var result = sut.GetByName(lookupName);

            // Assert
            result.Should().NotBeNull();

            TearDownTests();
        }

        [Fact]
        public void When_GetByNameIsCalled_Then_ShouldReturnCorrectEvets()
        {
            SetupTests();

            // Arrange
            var lookupName = "Class";
            SetupTests();
            repositoryMock
                .Setup(r => r.Filter(It.IsAny<Expression<Func<Restaurant, bool>>>()))
                .Returns(new List<Restaurant>
                {
                    new Restaurant{
                        Name = lookupName
                    }
                });

            // Act
            var result = sut.GetByName(lookupName);

            // Assert
            result.Count().Should().Be(1);

            TearDownTests();
        }

        [Fact]
        public void When_GetByNameIsCalledWithNonExistantLocation_Then_ShouldReturnEmptyList()
        {
            SetupTests();

            // Arrange
            var lookupName = "Class";
            SetupTests();
            repositoryMock
                .Setup(r => r.GetAll())
                .Returns(new List<Restaurant>
                {
                    new Restaurant
                    {
                        Name = "not class"
                    },
                    new Restaurant
                    {
                        Name = "not class"
                    },
                    new Restaurant{
                        Name = "not class"
                    }
                });

            // Act
            var result = sut.GetByName(lookupName);

            // Assert
            result.Count().Should().Be(0);

            TearDownTests();
        }
    }
}
