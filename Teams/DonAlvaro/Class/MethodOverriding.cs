using System;
using System.Collections.Generic;

namespace MethodOverridingAndAbstract
{
    class Program
    {
        static void main(string[] args)
        {
            var shapes = new List<Shape>();

        //OLD    shapes.Add(new Shape { Width = 100, Height = 100, Type=ShapeType.Circle });  //Object Initializer
        //OLD   shapes.Add(new Shape { Width = 100, Height = 30, Type = ShapeType.Rectangle });

        shapes.Add(new Circle { Width = 100, Height = 100 }); //NEW
        shapes.Add(new Rectangle { Width = 100, Height = 30 }); //NEW 

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);

        }
    }
     public class Circle : Shape //NEWLY ADDED
    {
        public override void Draw()
        {
            //Any code specific to the Circle class itself
            Console.WriteLine("Draw a Circle");
        }

    }

    public class Rectangle : Shape //NEWLY ADDED
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Rectangle");
        }//Must implement all abstract members in this derived class

    }

    public class Canvas
    { 
        public void DrawShapes(List<Shape> shapes) { 
                                                   ////Any changes to this and any class using this class
                                                   ///will be recompiled and redeployed
            foreach (var shape in shapes)           //This method will get fat if it supported many shapes
            {
                shape.Draw();    //added after commenting switch block below. Run-time Polymorphism. Upcasting.
                                 //Can call overrided Draw method from the Derived Class
                //switch (shape.Type) //Code Break here
                //{
                //    case ShapeType.Circle:              //Since behaviour is here, will need to be moved it into the Shape Class
                //        Console.WriteLine("Draw a Circle"); //Algorithm/behaviour for drawing a circle is not encapsulated to Circle class
                //        break;
                //    case ShapeType.Rectangle:
                //        Console.WriteLine("Draw a Rectangle");
                //        break;
                //    case ShapeType.Triangle:
                //        Console.WriteLine("Draw a Triangle");
                //        break;

                //}

            }

        }
    }

    public abstract class Shape      
    {
        //This class previously has only been used for storing data.
        //Doesn't have any methods.
        //Sample of bad practice// Edited to abstract class, Cannot be Instantiated.

        public int Width { get; set; }  
        public int Height { get; set; }

        //public ShapeType Type { get; set; } will be Removed After extending the Shape Class

        
        public abstract void Draw(); //Added to Encapsulated behaviour from the Canvas
       // {
            //Shape class will be transformed into an abstract class since
            //Draw method can't be described or defined. Concept of shape is abstract
            //Commented out the method body. Abstract methods do not include implementation.
        //}

        //Use Abstract when you want to provide some common behaviour, while forcing other
        //developers to follow your design.

        //Some Common Behavior
        public void Copy()
        {
            Console.WriteLine("Copy Shape into Clipboard");
        }

        public void Select()
        {
            Console.WriteLine("Select Shape");
        }
    }

    public enum ShapeType //Any changes to this and any class using this enum will be recompiled and redeployed
    {                       //Will be deleted after Extending the Shape class using inheritance.
        Circle,
        Rectangle, 
        Triangle
    }
}

