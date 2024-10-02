using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Utils.Display;

namespace DesignPatterns.Creational.Builder;

public class Builder
{
    private readonly IOutput _output;

    public Builder(IOutput output)
    {
        _output = output;
    }

    public void Run(string policyType)
    {

        //#### Advantages:

        //1. * *Improves Readability and Maintainability * *:
        //   -The Builder pattern enhances the readability of the code by separating the construction of complex objects from their representation. It makes the code easier to understand and maintain.

        //2. * *Supports Step - by - Step Construction * *:
        //   -This pattern allows for constructing complex objects step by step.You can create different configurations of an object by varying the director's steps.

        //3. * *Encapsulates Construction Code * *:
        //   -The construction logic is encapsulated in the builder, which helps in organizing the code better and adhering to the Single Responsibility Principle.

        //4. * *Fluent Interface * *:
        //   -Using fluent syntax, the Builder pattern provides an expressive way to construct objects, making the code more readable and easier to use.

        //5. * *Immutable Objects * *:
        //   -Builders can be used to create immutable objects by only setting the values once during the construction phase and not allowing changes afterward.

        //6. * *Reusability * *:
        //   -The same builder can be reused to create different representations of the product by changing the sequence of construction steps.

        //#### Disadvantages:

        //1. * *More Complex Code * *:
        //   -The Builder pattern introduces additional classes and interfaces, which can increase the complexity of the codebase, especially for simpler objects where the pattern might be overkill.

        //2. * *Verbosity * *:
        //   -The pattern can lead to verbose code, as you need to create a builder class, director class, and the product class. This verbosity might not be justified for simple objects.

        //3. **Requires More Effort**:
        //   - Implementing the Builder pattern requires more effort compared to straightforward object construction. It might not be beneficial if the complexity of object construction is low.

        //4. **Director Dependency**:
        //   - The director can add an extra layer of dependency, which might not always be necessary. It can sometimes complicate the design if not used judiciously.

        //5. **Learning Curve**:
        //   - For developers unfamiliar with design patterns, understanding and implementing the Builder pattern might require a learning curve, adding to the initial development time.

        //### When to Use the Builder IPattern

        //- **Complex Construction Logic**: When the construction of an object involves many steps, and the object has many configurations.
        //- **Immutability**: When you need to create immutable objects and want to provide a clear and concise way to construct them.
        //- **Readable Code**: When you want to improve the readability and maintainability of the code by separating the construction logic.
        //- **Reusable Builders**: When you need to reuse the construction code to create different representations of the product.

        //The Builder pattern is powerful for creating complex objects with many configurations, but it should be used judiciously to avoid unnecessary complexity in the code.

        var builder = new InsurancePolicyBuilder();
        var director = new InsurancePolicyDirector();

        switch (policyType)
        {
            case "Comprehensive":
                InsurancePolicy comprehensivePolicy = director.ConstructComprehensivePolicy(builder);
                _output.Display(comprehensivePolicy.ToString());
                break;
            case "Basic":
                InsurancePolicy basicPolicy = director.ConstructBasicPolicy(builder);
                _output.Display(basicPolicy.ToString());
                break;
            default:
                _output.Display("Invalid option.");
                break;
        }
    }
}
