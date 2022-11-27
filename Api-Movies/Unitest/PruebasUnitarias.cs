using Api_Movies.Controllers;
using Api_Movies.Core.UserManager;
using Api_Movies.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;


namespace TestProject1
{
    [TestClass]
    public class PruebasUnitarias
    {
        [TestMethod]
        public void ValidarSiAgregaUsuarios()
        {
            //Arrange
            UserController context = new UserController();

            User user = new User();
            user.Name = "Prueba";
            user.LastName = "Prueba";
            user.Email = "Prueba@Prueba.com";
            user.Password = "Prueba123";
            user.Doc = "123456789";
            user.Status = true;
            user.IdRol = 1;
            user.IdTypeDoc = 2;

            //Act

            var result = context.Post(user);
            //Assert
            Assert.IsFalse(result.IsCompletedSuccessfully);
        }


        [TestMethod]
        public void UserList()
        {
            //arrange
            UserController context = new UserController();
            User user = new User();
            //act
            var result = context.GetAll();
            //assert
            Assert.IsFalse(result.IsCompletedSuccessfully);

        }
        [TestMethod]
        public void Login()
        {
            // Arrange / Preparar el ambiente de nuestra prueba
            UserController context = new UserController();
            User user = new User();
            user.Email = "AndresPeralta@gmail.com";
            user.Password = "andresitoww123";
            // Act / Ejecucion de nuestro metodo en prueba
            var result = context.Post(user);
            //assert
            Assert.IsFalse(result.IsCompletedSuccessfully);
        }
        [TestMethod]
        public void UsersListForId()
        {
            //arrange
            UserController context = new UserController();

            User user = new User();
            var id = 1;
            //act
            var result = context.GetAll();
            //assert
            Assert.IsFalse(result.IsCompletedSuccessfully);

        }

        public void ValidarSiAgregaRol()
        {
            //Arrange
            UserDataController context = new UserDataController();

            Rol rol = new Rol();
            rol.NameRole = "Administrador";

            //Act
            var result = context.Post(rol);
            //Assert
            Assert.IsFalse(result.IsCompletedSuccessfully);
        }

        [TestMethod]
        public void ListRol()
        {
            //arrange
            UserDataController context = new UserDataController();
            Rol rol = new Rol();
            //act
            var result = context.GetAll();
            //assert
            Assert.IsFalse(result.IsCompletedSuccessfully);

        }

        [TestMethod]
        public void RolsListForId()
        {
            //arrange
            UserDataController context = new UserDataController();
            Rol rol = new Rol();

            var id = 1;
            //act
            var result = context.GetAll();
            //assert
            Assert.IsFalse(result.IsCompletedSuccessfully);

        }

        public void ValidarSiAgregaTypeDOc()
        {
            //Arrange
            UserDataController context = new UserDataController();

            TypeDoc typeDoc = new TypeDoc();
            typeDoc.NameTypeDoc = "Cedula";

            //Act
            var result = context.PostDoc(typeDoc);
            //Assert
            Assert.IsFalse(result.IsCompletedSuccessfully);
        }

        [TestMethod]
        public void ListTypeDoc()
        {
            //arrange
            UserDataController context = new UserDataController();
            TypeDoc typeDoc = new TypeDoc();
            //act
            var result = context.GetAll();
            //assert
            Assert.IsFalse(result.IsCompletedSuccessfully);

        }

        [TestMethod]
        public void TypeDOcListForId()
        {
            //arrange
            UserDataController context = new UserDataController();
            TypeDoc typeDoc = new TypeDoc();

            var id = 1;
            //act
            var result = context.GetAll();
            //assert
            Assert.IsFalse(result.IsCompletedSuccessfully);

        }
    }
}

