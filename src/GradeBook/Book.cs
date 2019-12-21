using System;

namespace GradeBook
{
    public delegate void GradeAddedDelegate(object sender, EventArgs args);

    public abstract class Book : NameObject
    {
        public Book(string name) : base(name)
        {
        }

        public abstract void AddGrade(double grade);
        public abstract void AddGrade(char letter);
    }
}
