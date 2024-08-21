using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Json;

public class Json : MonoBehaviour
{

    private void Start()
    {
        Cat cat = new Cat();
        Debug.Log(cat);
        //Cat cat = new Cat("catty" , true , 10);    
        //Debug.Log(cat);
    }

    [Serializable]
    public class animall
    {
        public string Name { get; set; }
        public bool animal {  get; set; }
        public int age {  get; set; }
        //public animall(string name, bool animal, int age)
        //{
        //    this.Name = name;
        //    this.animal = animal;
        //    this.age = age;
        //}
    }
    [Serializable]
    public class  Cat : animall
    {
        public Cat()
        { 
            Name = "Catt1";
            animal = true;
            age = 10;

        }
    }


}
