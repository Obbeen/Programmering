using System;
using System.Collections.Generic;

namespace _4030
{
    class Cat   
    {
        public int age; 
        public Cat(int a)
        {
            age = a;
        }

        public void Act()
        {
            Console.WriteLine("");
            for (int i = 0; i < age; i++)
            {
                Console.WriteLine("mjau, ");
            }
            
        }
        
        
        

    
    }
     class Dog   
    {
        public int age; 
        public Dog(int a)
        {
            age = a;
        }

        public void Act()
        {
            Console.WriteLine("");
            for (int i = 0; i < age; i++)
            {
                Console.WriteLine("voff, ");
            } 
        }  
    }
    class Ko
    {
        public int age;
        
        public Ko(int a)
        {
            age = a;
        }

        public void Act()
        {
            Console.WriteLine("");
            for (int i = 0; i < age; i++)
            {
                Console.WriteLine("mu, muuu ");
            }
        }
    }
    class Zoo   
    {
        List<Cat> katter = new List<Cat>();

        List<Dog> hundar = new List<Dog>();

        List<Ko> kossor = new List<Ko>();



        public Zoo()
        {

        
           
            katter.Add(new Cat(3));
            katter.Add(new Cat(3));
            katter.Add(new Cat(3));
            


           
            hundar.Add(new Dog(3));
            hundar.Add(new Dog(3));

            kossor.Add(new Ko(1));
            kossor.Add(new Ko(1));
            kossor.Add(new Ko(1));
            
        


        }
         public void Run()
        {
           foreach (Cat item in katter)
            {
                item.Act();
            }

             foreach (Dog item in hundar)
            {
                item.Act();
            }
             foreach (Ko item in kossor)
            {
                item.Act();
            }

        }
        
    }
}

