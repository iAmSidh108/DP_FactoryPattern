# **Factory Pattern in Unity:**

## **What is the Factory Pattern?**

The Factory Pattern is a creational design pattern that provides an interface for creating instances of a class, but allows subclasses to alter the type of objects that will be created. It involves defining an interface for creating an object, but leaving the choice of its type to the subclasses, creating an instance of the appropriate class based on certain conditions.

![factory-method-en](https://github.com/iAmSidh108/DP_FactoryPattern/assets/63715240/d1b9712b-cab1-412b-9efd-7adf4e93b276)


## **Examples of using the Factory Pattern in game development:**

1. **Character Creation:**
   - **Factory Interface:** `ICharacterFactory` with a method like `CreateCharacter()`.
   - **Concrete Factories:** `ElfFactory`, `OrcFactory` implementing `ICharacterFactory`.
   - **Client Code:** Calls `CreateCharacter()` on a specific factory to get an instance of a character.

2. **Weapon Crafting:**
   - **Factory Interface:** `IWeaponFactory` with a method like `CreateWeapon()`.
   - **Concrete Factories:** `SwordFactory`, `BowFactory` implementing `IWeaponFactory`.
   - **Client Code:** Calls `CreateWeapon()` on a specific factory to get an instance of a weapon.
     
![problem1-en](https://github.com/iAmSidh108/DP_FactoryPattern/assets/63715240/dad48c5a-af1a-4784-9381-c8b45e386bf1)

## **Drawbacks of using Factory Pattern:**

1. **Increased Number of Classes:**
   - The pattern can result in a larger number of classes, especially in scenarios with numerous product variations.

2. **Complexity:**
   - Implementing multiple factories and managing them can introduce complexity, particularly for smaller projects.

3. **Learning Curve:**
   - Developers unfamiliar with the pattern may find it challenging to understand and implement, especially in smaller projects.

## **How to implement Factory Pattern:**

1. **Define Factory Interface:**
   - Establish an interface (e.g., `IProductFactory`) that declares a method for creating objects (e.g., `CreateProduct()`).

2. **Create Concrete Factories:**
   - Implement concrete classes (e.g., `ConcreteProductFactoryA`, `ConcreteProductFactoryB`) that implement the factory interface.

3. **Implement Product Interface:**
   - Define an interface or base class (e.g., `IProduct`) for the products to be created by the factories.

4. **Create Concrete Products:**
   - Implement concrete classes (e.g., `ConcreteProductA`, `ConcreteProductB`) that inherit from the product interface.

5. **Factory Usage in Client Code:**
   - In the client code, use the factory interface to create instances of products without specifying their concrete classes.

6. **Unity Prefab Instantiation:**
   - In Unity, prefab instantiation can be considered a form of the factory pattern, where a prefab acts as a factory creating instances of game objects.

7. **Parameterized Factory Methods:**
   - Consider using parameterized factory methods if the creation logic requires additional parameters or customization.

8. **Documentation:**
   - Clearly document the purpose and usage of each factory and product, making it easier for developers to understand and maintain the system.

## **Real-life Example:**

Imagine a car manufacturing plant where cars are produced based on different models and specifications. The plant acts as a factory, and each model (e.g., sedan, SUV) has its own concrete factory responsible for creating instances of cars with unique features, such as engine type, color, and interior design. The client (e.g., customer or dealership) can request cars from specific factories based on their desired model and configuration. This illustrates how the Factory Pattern can be applied in real-life scenarios for efficient object creation and management.

![solution3-en](https://github.com/iAmSidh108/DP_FactoryPattern/assets/63715240/ae244a87-a419-4fd8-93d0-8e5e7a264b95)


## How I implemented this design pattern in my project.

Will be updated soon when complete.
