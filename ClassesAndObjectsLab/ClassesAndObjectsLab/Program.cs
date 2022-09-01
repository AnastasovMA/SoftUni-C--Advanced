using System;

namespace ClassesAndObjectsLab
{
    class Dog
    {
        public string Name { get; set; }    //properties              // CLASS
        public string Breed { get; set; }   //properties              // CLASS
        public int Age { get; set; }        //properties              // CLASS
                                                                      // CLASS
        public void Bark() // Method - behaviour                      // CLASS
        {                                              
            Dog puppy = new Dog("Sparky", "Corgi", 3);           // Objects of the new class     
            Dog puppy1 = new Dog("Rufus", "Sheperd", 2);         // Objects of the new class       
            Dog puppy2 = new Dog("Allie", "Husky", 5);           // Objects of the new class     
                                                       
        }                                             

    }

}
