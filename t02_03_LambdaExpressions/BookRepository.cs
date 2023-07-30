﻿namespace t02_03_LambdaExpressions
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title="Title 1",Price=5},
                new Book() {Title="Title 2",Price=7},
                new Book() {Title="Title 3",Price=10},
                new Book() {Title="Title 4",Price=17}
            };
        }
    }
}