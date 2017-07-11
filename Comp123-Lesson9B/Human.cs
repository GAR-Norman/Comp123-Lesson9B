using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 Name: Gabriel Norman
 Date: July 11th 2017 
 Description: abstract human class
 Version 01: created abstract human class*/
namespace Comp123_Lesson9B
{
    public abstract class Human
    {
        //private instance variables(fields) 
        private string _name;

        //public properties 
        public string name
        {
            get { return this._name; }set{ this._name = value; }
        }
        // constructor 
        /// <summary>
        /// this is the constructor for the human class it takes one property -- name (string)
        /// </summary>
        /// <param name="name"></param>
        public Human(string name)
        {
            this.name = name;
        } 

        //private methods 

        //public methods
    }
}