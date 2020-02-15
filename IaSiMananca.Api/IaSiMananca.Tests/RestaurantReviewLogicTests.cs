using FluentAssertions;
using IaSiMananca.Business.Logic.Implementations;
using IaSiMananca.DataAccess.Entities;
using IaSiMananca.DataAccess.Repository;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Xunit;

namespace IaSiMananca.Tests
{
    public class RestaurantReviewLogicTests
    {
        private Mock<IRepository<RestaurantReview>> repositoryMock;
        private RestaurantReviewLogic sut;

        private void SetupTests()
        {
            repositoryMock = new Mock<IRepository<RestaurantReview>>();
            sut = new RestaurantReviewLogic(repositoryMock.Object);
        }

        private void TearDownTests()
        {
            repositoryMock = null;
            sut = null;
        }

        [Fact]
        public void When_GetAllIsCalled_Then_ShouldNotReturnNull()
        {
            SetupTests();

            //Arrange
            repositoryMock.Setup(rr => rr.GetAll())
                .Returns(new List<RestaurantReview>
                {
                    new RestaurantReview(),
                    new RestaurantReview(),
                    new RestaurantReview(),
                    new RestaurantReview(),
                    new RestaurantReview()
                });

            //Act
            var result = sut.GetAll();

            //Assert
            result.Should().NotBeNull();

            TearDownTests();
        }

        [Fact]
        public void When_GetAllIsCalled_Then_ShouldReturnCorrectRestaurantReviews()
        {
            SetupTests();

            //Arrange
            repositoryMock.Setup(rr => rr.GetAll())
                .Returns(new List<RestaurantReview>
                {
                    new RestaurantReview(),
                    new RestaurantReview(),
                    new RestaurantReview(),
                    new RestaurantReview(),
                    new RestaurantReview()
                });

            //Act
            var result = sut.GetAll();

            //Assert
            result.Count().Should().Be(5);

            TearDownTests();
        }
        
        [Fact]
        public void When_GetAllByRestaurantIdIsCalled_Then_ShouldReturnCorrectRestaurantReviews()
        {
            SetupTests();

            //Arrange
            var lookupId = new Guid("a60db043-d911-41e5-9074-9381e6dc57fb");
            repositoryMock.Setup(rr => rr.Filter(It.IsAny<Expression<Func<RestaurantReview, bool>>>()))
                .Returns(new List<RestaurantReview>
                {
                    new RestaurantReview{RestaurantId = lookupId},
                    new RestaurantReview{RestaurantId = lookupId}
                });

            //Act
            var result = sut.GetAllByRestaurantId(lookupId);

            //Assert
            result.Count().Should().Be(2);
            result.First().RestaurantId.Should().Be(lookupId);

            TearDownTests();
        }

        [Fact]
        public void When_GetByIdIsCalled_Then_ShouldReturnCorrectRestaurantReview()
        {
            SetupTests();

            //Arrange
            var lookupId = new Guid("a60db043-d911-41e5-9074-9381e6dc57fb");
            repositoryMock.Setup(rr => rr.GetById(lookupId)).Returns(new RestaurantReview { Id = lookupId });

            //Act
            var result = sut.GetById(lookupId);

            //Assert
            result.Id.Should().Be(lookupId);

            TearDownTests();
        }

        [Fact]
        public void When_GetAverageRatingByRestaurantIdIsCalled_Then_ShouldReturnCorrectDouble()
        {
            SetupTests();

            //Arrange
            var lookupId = new Guid("a60db043-d911-41e5-9074-9381e6dc57fb");
            repositoryMock.Setup(rr => rr.Filter(It.IsAny<Expression<Func<RestaurantReview, bool>>>()))
                .Returns(new List<RestaurantReview>
                {
                    new RestaurantReview{RestaurantId = lookupId, Rating = 10},
                    new RestaurantReview{RestaurantId = lookupId, Rating = 4}
                });

            //Act
            var result = sut.GetAverageRatingByRestaurantId(lookupId);

            //Assert
            result.Should().Be(7);

            TearDownTests();
        }
    }

}
