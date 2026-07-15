/*
 Create an Allergies class that holds a person's name and the things s/he is allergic to. Each allergy has a unique score value as follows:

Allergy	Score
Eggs	1
Peanuts	2
Shellfish	4
Strawberries	8
Tomatoes	16
Chocolate	32
Pollen	64
Cats	128
By combining the scores for each allergy suffered by a person their overall allergy score is obtained. 

For example, if someone was allergic to Peanuts, Tomatoes, and Pollen, their allergy score would be 2 (Peanuts) + 16 (Tomatoes) + 64 (Pollen) their allergy score would be 82.

An enumeration type enum called Allergen is already declared in the Code tab and should not be altered.

The class should have the following members:*/
using System;
using System.Collections.Generic;
using System.Linq;

var mary = new Allergies("Mary");

var joe = new Allergies("Joe", 65);

var rob = new Allergies("Rob", "Peanuts Chocolate Cats Strawberries");

public class Allergies
{
    // do not alter this enum
    [Flags]
    public enum Allergen
    {
        Eggs = 1,
        Peanuts = 2,
        Shellfish = 4,
        Strawberries = 8,
        Tomatoes = 16,
        Chocolate = 32,
        Pollen = 64,
        Cats = 128
    }

 
    // properties
    private string? _name;
    private string? _description;
    private int _score;
    private string [] _allergies;
    public string? Name { get { return _name; } private set { _name = value; } }
    public int Score { get { return _score; } private set { _score = value; } }
    public string? Description { get { return _description; } set { _description = value; } }
    public string[] AllergiesList { get { return _allergies; } set { _allergies = value; } }

    // constructors 
    public Allergies(string name)
    {
        // add code here to initialize the instance with the given name
        Name = name;
    }
    // methods
    public bool IsAllergicTo(Allergen allergen)
    {

    }

    public AddAllergy() { 
    
    }

    public DeleteAllergy()
    {
    }

    public override string ToString()
    {
        // add code here to return string representation of this instance
        return base.ToString();
    }
}