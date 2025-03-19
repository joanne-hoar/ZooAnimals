# ZooAnimals
Demonstrating Polymorphism and Interface

## Step 1: Define the Animal Class

Create a base class Animal with the following properties and methods:

- Properties:
  - Name (string): Name of the animal.
  - Age (int): Age of the animal.

- Methods:
  - MakeSound(): A virtual method that outputs as a string a sound based on the type of animal.

## Step 2: Create Derived Classes

Create three derived classes from the Animal class:

1. Lion: Add a new method Roar() that outputs a lion-specific sound.
2. Elephant: Add a new method Trumpet() that outputs an elephant-specific sound.
3. Penguin: Add a new method Honk() that outputs a penguin-specific sound.

## Step 3: Implement an Interface

Create an interface called ISwim with a method Swim(). Implement this interface in the Penguin class.

## Step 4: Create a Zoo Class

Create a class called Zoo that contains a list of animals. Include methods to:

- Add an animal to the zoo.
- Display information about all the animals in the zoo, including their name, age, and the sound they make.
- Allow all animals in the zoo to make their sounds.

## Step 5: Testing

In the Main method of your console application, create an instance of the Zoo class. Add instances of Lion, Elephant, and Penguin to the zoo. Display information about all the animals and make them make their sounds.

## Step 6: Bonus (Polymorphism)

Modify the MakeSound method in the base class to demonstrate polymorphism. Instead of printing a generic sound, call the MakeSound method for each animal in the zoo, and let polymorphism handle the specific sound for each animal.