
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
    public class TransactionControllerTestUnit
    {
        [Fact]
        public void IndextTest()
        {
            //Arrange
            var mock = new Mock<ITransactionRepository>();     //ZMIEŃ
            var customer = new TransactionController(mock.Object);  //ZMIEŃ CONTROLLER

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
            var newTransaction = new Transaction() { TransactionID = 1 };
            var list = new List<Transaction>();
            list.Add(newTransaction);

            //Arrange
            var mock = new Mock<ITransactionRepository>();
            var customer = new TransactionController(mock.Object);
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
            var newTransaction = new Transaction() { TransactionID = 1 };
            var list = new List<Transaction>();
            list.Add(newTransaction);
            //arrange
            var mock = new Mock<ITransactionRepository>();
            var customer = new TransactionController(mock.Object);
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
            var mock = new Mock<ITransactionRepository>();
            var customer = new TransactionController(mock.Object);

            //Art
            var resultController = customer.Edit(new TransactionViewModel() { TransactionID = 1 });

            //Assert
            resultController.Should().NotBeNull();
            resultController.Should().BeOfType<ViewResult>();
            resultController.Should().BeAssignableTo<IActionResult>();

            mock.Verify(v => v.Update(It.IsAny<Transaction>()), Times.Once());
        }

        [Fact]
        public void DeleteTest()
        {
            //Arrange
            var mock = new Mock<ITransactionRepository>();
            var customer = new TransactionController(mock.Object);

            //Art
            var resultController = customer.Delete(1);

            //Assert
            resultController.Should().NotBeNull();
            resultController.Should().BeOfType<ViewResult>();
            resultController.Should().BeAssignableTo<IActionResult>();


            mock.Verify(v => v.Delete(It.IsAny<Transaction>()), Times.Once());
        }

        [Fact]
        public void AddTest()
        {
            //Arrange
            var mock = new Mock<ITransactionRepository>();
            var customer = new TransactionController(mock.Object);

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
            var mock = new Mock<ITransactionRepository>();
            var customer = new TransactionController(mock.Object);

            //Art
            var resultController = customer.Add(new Transaction() { TransactionID = 1 });

            //Assert
            resultController.Should().NotBeNull();
            resultController.Should().BeOfType<ViewResult>();
            resultController.Should().BeAssignableTo<IActionResult>();


            mock.Verify(v => v.Create(It.IsAny<Transaction>()), Times.Once());
        }
    }
}