namespace MBoxShapeLib.Classes.Abstractions
{
    public abstract class Shape
    {
        public string typeName { get; set; }

        public Shape(string typeName) => this.typeName = typeName;
    }
}