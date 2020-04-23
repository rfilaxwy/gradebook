using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {

        [Fact]
        public void Test1()
        {
            var x = GetInt();
            SetInt(ref x);
            Assert.Equal(42, x);
        }

        private void SetInt(ref object z)
        {
            z = 42;
        }

        private object GetInt()
        {
            return 3;
        }

        [Fact]
        public void CSharpCanPassByValue()
        {
            var book1 = new Book("Book1");
            GetBookSetName(ref book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }

        private void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CSharpIsPassByValue()
        {
            var book1 = new Book("Book1");
            GetBookSetName(book1, "New Name");

            Assert.Equal("Book1", book1.Name);
        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }



        [Fact]
        public void CanSetNameFromReference()
        {
            var book1 = new Book("Book1");
            SetName(book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            var book1 = GetBook("Book1");
            var book2 = GetBook("Book2");

            Assert.Equal("Book1", book1.Name);
            Assert.Equal("Book2", book2.Name);
            Assert.NotSame(book1, book2);

        }
        [Fact]
        public void TwoVariablesCanReferenceTheSameObject()
        {
            var book1 = GetBook("Book1");
            var book2 = book1;

            Assert.Same(book1, book2);

        }
        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
