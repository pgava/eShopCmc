﻿using System.Collections.Generic;
using System.Threading;
using eShopCmc.Application.Countries.GetCountries;
using eShopCmc.Domain.Countries;
using FluentAssertions;
using Moq;
using Xunit;

namespace eShopCmc.UnitTests.Countries
{
    public class GetAllCountriesTests
    {
        private readonly Mock<ICountryRepository> _countryRepository;
        private readonly List<Country> _countries = new()
        {
            new Country { Id = 1, CountryName = "country 1", Currency = "A", ExchangeRate = 0.1M },
            new Country { Id = 2, CountryName = "country 2", Currency = "B", ExchangeRate = 0.2M },
        };

        public GetAllCountriesTests()
        {
            _countryRepository = new Mock<ICountryRepository>();
        }

        [Fact]
        public async void GetCountries_AllAvailableCountriesAreReturned()
        {
            // Arrange
            _countryRepository.Setup(s => s.GetCountriesAsync(CancellationToken.None))
                .ReturnsAsync(_countries);
            var sut = new GetAllCountriesQueryHandler(_countryRepository.Object);
            
            // Act
            var countries = await sut.Handle(new GetAllCountriesQuery(), CancellationToken.None);
            
            // Assert
            countries.Should().BeEquivalentTo(_countries);
        }

    }
}
