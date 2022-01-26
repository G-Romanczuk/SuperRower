
using FluentAssertions;

using Microsoft.AspNetCore.Mvc;

using Moq;
using SuperRower.Controllers;
using SuperRower.Models;
using SuperRowerDB;
using System.Collections.Generic;
using Xunit;

namespace Test
{
    public class ControllerTestUnit
    {
        [Fact]
        public void IndextTest()
        {
            //Arrange
            var mock = new Mock<ICustomerRepository>();     //ZMIEÑ
            var customer = new CustomerController(mock.Object);  //ZMIEÑ CONTROLLER

            //Art
            var resultController = customer.Index(); 

            //Assert
            resultController.Should().NotBeNull();
            resultController.Should().BeOfType<ViewResult>();
            resultController.Should().BeAssignableTo<IActionResult>();
        }

        [Fact]
        public void DetailsTest()
        {
            var newCustomer = new Customer() { CustomerID = 1 };
            var list = new List<Customer>();
            list.Add(newCustomer);

            //Arrange
            var mock = new Mock<ICustomerRepository>();
            var customer = new CustomerController(mock.Object);
            mock.Setup(v => v.GetAll()).Returns(list);
            //Art
            var resultController = customer.Details(1);

            //Assert
            resultController.Should().NotBeNull();
            resultController.Should().BeOfType<ViewResult>();
            resultController.Should().BeAssignableTo<IActionResult>();

            mock.Verify(v => v.GetAll(), Times.Once());
        }

        [Fact]
        public void edittest()
        {
            var newCustomer = new Customer() { CustomerID = 1 };
            var list = new List<Customer>();
            list.Add(newCustomer);
            //arrange
            var mock = new Mock<ICustomerRepository>();
            var customer = new CustomerController(mock.Object);
            mock.Setup(v => v.GetAll()).Returns(list);


            //art
            var resultcontroller = customer.Edit(1);

            //assert
            resultcontroller.Should().NotBeNull();
            resultcontroller.Should().BeOfType<ViewResult>();
            resultcontroller.Should().BeAssignableTo<IActionResult>();

            mock.Verify(v => v.GetAll(), Times.Once());
        }

        [Fact]
        public void EditPostTest()
        {
            //Arrange
            var mock = new Mock<ICustomerRepository>();
            var customer = new CustomerController(mock.Object);

            //Art
            var resultController = customer.Edit(new CustomerViewModel() { CustomerID = 1 });

            //Assert
            resultController.Should().NotBeNull();
            resultController.Should().BeOfType<ViewResult>();
            resultController.Should().BeAssignableTo<IActionResult>();

            mock.Verify(v => v.Update(It.IsAny<Customer>()), Times.Once());
        }

        [Fact]
        public void DeleteTest()
        {
            //Arrange
            var mock = new Mock<ICustomerRepository>();
            var customer = new CustomerController(mock.Object);

            //Art
            var resultController = customer.Delete(1);

            //Assert
            resultController.Should().NotBeNull();
            resultController.Should().BeOfType<ViewResult>();
            resultController.Should().BeAssignableTo<IActionResult>();


            mock.Verify(v => v.Delete(It.IsAny<Customer>()), Times.Once());
        }

        [Fact]
        public void AddTest()
        {
            //Arrange
            var mock = new Mock<ICustomerRepository>();
            var customer = new CustomerController(mock.Object);

            //Art
            var resultController = customer.Add();

            //Assert
            resultController.Should().NotBeNull();
            resultController.Should().BeOfType<ViewResult>();
            resultController.Should().BeAssignableTo<IActionResult>();
        }

        [Fact]
        public void AddPostTest()
        {
            //Arrange
            var mock = new Mock<ICustomerRepository>();
            var customer = new CustomerController(mock.Object);

            //Art
            var resultController = customer.Add(new CustomerViewModel() { CustomerID = 1 });

            //Assert
            resultController.Should().NotBeNull();
            resultController.Should().BeOfType<ViewResult>();
            resultController.Should().BeAssignableTo<IActionResult>();


            mock.Verify(v => v.Create(It.IsAny<Customer>()), Times.Once());
        }
    }
}