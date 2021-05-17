using System.Collections.Generic;
using AutoMapper;
using LMS.API.Controllers;
using LMS.API.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace LMS.Tests.Controller
{
    /// <summary>
    /// Test to return Authors by FirstName
    /// </summary>
    public class AuthorsControllerTests
    {
        private readonly AuthorsController authorController;
        private Mock<List<Author>> mockAuthorsList;
        private readonly IMapper mapper;

        public AuthorsControllerTests()
        {
            // �ndra put-metoden i AuthorsController s� den inte anv�nder context (se Dimitris EventDay)
            // Ta bort context fr�n Authorscontroller
            // F� in AutoMapper i testklassen och mocka den ocks�

            mockAuthorsList = new Mock<List<Author>>();
            authorController = new AuthorsController(mockAuthorsList.Object);
           // mapper = new IMapper();
            
        }

        [Fact]
        public void GetAuthorsTest_ReturnsListOfAuthorsByFirstName()
        {
            //arrange

            var mockAuthors = new List<Author> {
                new Author{FirstName = "Tdd One"},
                new Author{FirstName = "Tdd Two"}
            };

            mockAuthorsList.Object.AddRange(mockAuthors);

            // act

            var result = authorController.GetAuthors(null);

            //assert
            var model = Assert.IsAssignableFrom<ActionResult<List<Author>>>(result);
            Assert.Equal(2, model.Value.Count);

        }

        
    }

    public class ModulesControllerTests
    {

    }
}
