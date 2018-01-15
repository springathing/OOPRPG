using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPRPG
{
    class OOPCrashCourse
    {
    }
}

// class is a blueprint, class Weapon, access modifiers (public), class is
// public (access modifier) class (keyword) weapon (name)
// {            } block of code is syntax of the class
// public (access modifier for property) string (type) name { get; set; }
// can't weapon.name because it needs to be an object. Instantiate it
// var weapon = new (keyword) Weapon() (name of class); <<<<< instantiation to make it an object
// new Weapon(); is a new instance of the class, it builds a new instance. Weapon() is the invokation of a method
// Weapon() is a default constructor even if you don't have a constructor stated
// var (((weapon))) is the actual object
// weapon.Name (Name will show up once object is instantiated)
// constructor name is the same name as the class name, must have parenthesis because it is a method.
// when you create a weapon you want the hero to be attached so you need to have hero passed into the weapon (into the parenthesis)
// public Weapon(Hero hero) {}      var (((hero))) = new Hero(); is being passed through
//imagine three doors, Weapon() Armor() Hero(), pass as parameter because you'll use it in the method,
// for Weapon() you only accept triangle data, Armor(square) and Hero(circle)
// Class Triangle triangle
// object is abstract, but you can touch class

// class is a blueprint of an object, an object is an instance of a class
// instantiation is the invokation of the constructor (creating an instance)
// constructor constructs an object
// parameters are the passing arguments
// object type .. object = new Constructor();                                  ************************************************
// Game (object type) myGame (object variable) = new (instance of) Game()....... same as..... int myGame = 5; or string myStr = "Marty";
//                                                                             ************************************************
// specify the property that you're passing, very strict about data types because it is a strongly written language
// the whole point is setting up a structure for data flow, the User Interface is on the side (UI) with all the Console
// explicit is [Weapon weapon = new Weapon()] , implicit is [var weapon = new Weapon();]
// invoke a method == call a method
// field == variable, if you have field inside a class then you want some kind of access modifier to only use the value inside class

// value type....int is value type so myNum becomes value in "int myNum;"
// reference type